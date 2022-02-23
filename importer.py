import bpy
import json
import os
import time
from io_import_scene_unreal_psa_psk_280 import pskimport
from math import *
import json
from random import randint
import threading


working_dir = "D:\\FNaFMenuLoader-production\\Fnaf99\\bin\\x64\\Debug\\Dump\\"
class TextureData:
    diffusePath = ""
    nonInstanced=False
    matName = ""
def copyOrImportPsk(filePath):
    if True:
        importResult = pskimport(filePath,bpy.context,bReorientBones=True)
        return (True,bpy.context.active_object)
    else:
        global pskObjectCache
        if pskObjectCache.get(filePath) is None:
            importResult = pskimport(filePath,bpy.context,bReorientBones=True)
            if importResult:
               imported = bpy.context.active_object
                bpy.ops.object.select_all(action='DESELECT')
                imported.select_set(True)
                bpy.ops.object.duplicate()
                duplicated = bpy.context.active_object
                pskObjectCache[filePath] = duplicated
                duplicated.location=(0,0,15)
                print(importResult)
                return (True,imported)
            else:
                return (False,None)
        else:
            bpy.ops.object.select_all(action='DESELECT')
            pskObjectCache[filePath].select_set(True)
            bpy.ops.object.duplicate()
            duplicated = bpy.context.active_object
            #duplicated.location = (0,0,15)
            return (True,duplicated)
    return (False,None)

def importObject(filePath,xPos,yPos,zPos,xRot,yRot,zRot,xScl,yScl,zScl,texData):
    #t1 = threading.Thread(target=pskimport,args=(filePath,bpy.context))
    #t1.start()
    #(result,imported) = copyOrImportPsk(filePath)
    result = pskimport(filePath, bpy.context, bReorientBones=True)
    if result==False:
        global nonImportedObjects
        nonImportedObjects.append(filePath)
        return
    imported = bpy.context.active_object
    imported.location = (xPos,yPos,zPos)
    imported.rotation_euler  = (radians(xRot),radians(yRot),radians(zRot))
    imported.scale = (xScl,yScl,zScl)
    #bpy.ops.transform.resize(value=(xScl,yScl,zScl))
"""
    mat = imported.material_slots[0].material
    if texData.matName is not None and texData.matName!=mat.name:
        mat = bpy.data.materials.new(name=texData.matName)
    if texData.diffusePath is None or "CUBE_" in texData.diffusePath:
        mat.name = mat.name+"_NODIFFUSE"
        return
    mat.use_nodes=True
    nodes = mat.node_tree.nodes
    nodes.clear()
    links = mat.node_tree.links
    links.clear()
    
    master_node = nodes.new(type='ShaderNodeBsdfPrincipled')
    bt_node = nodes.new(type='ShaderNodeTexImage')
    
    actualTexturePath = working_dir+"UmodelExport"
    if texData.nonInstanced:
        bt_node.image = bpy.data.images.load("E:\\fnaf1texture.png")
    else:
        print("USING CUSTOM TEXTURE")
        clearTexturePath = (texData.diffusePath.split('.')[0])
        clearTexturePath = clearTexturePath+".tga"
        actualTexturePath = actualTexturePath+clearTexturePath
        bt_node.image = bpy.data.images.load(actualTexturePath)
    
    links.new(master_node.inputs['Base Color'], bt_node.outputs['Color'])
    links.new(master_node.inputs['Alpha'], bt_node.outputs['Alpha'])
    
    out_node = nodes.new(type='ShaderNodeOutputMaterial')
    
    links.new(master_node.outputs['BSDF'], out_node.inputs[0])
    """
    
    
def objFromJson(object,i):
    try:
        filePath = object["path"]
        pos = object["position"]
        rot = object["rotation"]
        scl = object["scale"]
        xPos = pos["X"]/100
        yPos = pos["Y"]/100*-1
        zPos = pos["Z"]/100
        #xRot = jsonFileData[i]["rotation"]["X"]
        #yRot = jsonFileData[i]["rotation"]["Z"]
        #zRot = jsonFileData[i]["rotation"]["Y"]*-1
        xRot = rot["Z"]
        yRot = rot["X"]*-1
        zRot = rot["Y"]*-1
        xScl = scl["X"]
        yScl = scl["Y"]
        zScl = scl["Z"]
        realFilePath = working_dir+"UmodelExport"+filePath
        realFilePath = realFilePath.split(".")[0]+".pskx"
        textureData = TextureData()
        textureData.diffusePath =object["baseTexture"]
        textureData.nonInstanced =object["nonInstanced"]
        textureData.matName = object["materialName"]
        importObject(realFilePath,xPos,yPos,zPos,xRot,yRot,zRot,xScl,yScl,zScl,textureData)
        print("Imported object ",i)
        global successfulObjects
        successfulObjects+=1
            #bpy.ops.object.empty_add(type='PLAIN_AXES',radius=0.3,location=(xPos,yPos,zPos))
            #bpy.context.active_object.name = filePath
        
    except Exception as ex:
        print("Failed to import object ",i)
        global failedObjects
        failedObjects+=1
        raise Exception("cum treasurer, dick measurer   ",object["path"],object["type"],object["position"]["X"])
        print(ex)

def createObject(object,i):
    if object["type"]=="mesh":
        objFromJson(object,i)
    elif object["type"]=="dummy":
        for ci in range(0,len(object["children"])):
            if(object["children"][ci]["type"]=="mesh"):
                objFromJson(object["children"][ci],i+ci)
            else:
                bpy.ops.object.empty_add(type='PLAIN_AXES',radius=0.3,location=(object["children"][ci]["position"]["X"]/100,object["children"][ci]["position"]["Y"]/100*-1,object["children"][ci]["position"]["Z"]/100))
                bpy.context.active_object.name = object["children"][ci]["path"]



def main():  
    jsonFileData = json.loads((open(working_dir+"dump.json","r").read())) 
    for i in range(0,len(jsonFileData)):
        createObject(jsonFileData[i],i)
        
    print("done! Success: ",successfulObjects, ".Failed: ",failedObjects,".Total: ",failedObjects+successfulObjects)
    bpy.ops.object.select_all(action='DESELECT')
    for jopa,(dupObjName,dupObj) in enumerate(pskObjectCache.items()):
        print("removing cache: ",dupObj.name)
        dupObj.select_set(True)
        bpy.ops.object.delete()
    textfile = open(working_dir+"brokenObjects.txt", "w")
    for element in nonImportedObjects:
        textfile.write(element + "\n")
    textfile.close()
    

successfulObjects = 0
failedObjects = 0
nonImportedObjects = []
pskObjectCache = {}
main()
