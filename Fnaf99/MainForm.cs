using Newtonsoft.Json;
using SDK.Script.EngineSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrealSharp;
using Console = System.Console;
using Timer = System.Windows.Forms.Timer;

namespace Fnaf99
{
    public partial class MainForm : Form
    {
        Process process;
        Timer mainTimer = new Timer() { Interval = 1000, Enabled = true };
        Timer umodelTimer = new Timer() { Interval = 10, Enabled = true };
        public MainForm()
        {
            InitializeComponent();
        }
        public bool ConnectToProcess()
        {
            process = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.Contains(Program.settings.gameName) && p.MainWindowHandle != IntPtr.Zero);
            if (CheckProc())
            {
                var ue = new UnrealEngine(new Memory(process));
                ue.UpdateAddresses();
                ue.EnableConsole();
            }
                
           
            else return false;
            return true;
        }
        public bool CheckProc()
        {
            if (process == null) return false;
            if (process.HasExited) return false;
            return true;
        }
        public void ParseWorldObject()
        {
            world = new World(UnrealEngine.Memory.ReadProcessMemory<UInt64>(UnrealEngine.GWorldPtr));
            if (!world.IsA<World>()) return;
            var worldObj = world.Levels;
            Levels.Items.Clear();
            for (uint i = 0; i < worldObj.Num; i++)
            {
                var level = worldObj[(uint)i];
                Levels.Items.Add(level.ClassName.Split('.')[1]);
            }
        }
        public void Tick(object sender,EventArgs x)
        {
            if(CheckProc())ParseWorldObject();
        }
        void UmodelTick(object sender, EventArgs x)
        {
            var procs = Process.GetProcessesByName("umodel");
            umodelInsts.Text = "UModel Instances: " + procs.Length;

        }
        World world;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (ConnectToProcess())
            {
                isConnected.Text = "Connected";
                ulong entityList = UnrealEngine.Memory.ReadProcessMemory<ulong>(UnrealEngine.Memory.BaseAddress + UnrealEngine.GObjects);
                uint count = UnrealEngine.Memory.ReadProcessMemory<uint>(UnrealEngine.Memory.BaseAddress + UnrealEngine.GObjects + 20UL);
                entityList = UnrealEngine.Memory.ReadProcessMemory<ulong>(entityList);
                var objs = new UEObject(entityList);
                for (uint i = 0U; i < count; i += 1U)
                {
                    ulong entityAddr = UnrealEngine.Memory.ReadProcessMemory<ulong>(entityList + (ulong)(8U * (i >> 16)) + (ulong)(24U * (i % 65536U)));
                    if (entityAddr != 0UL)
                    {
                        if (new UEObject(entityAddr).GetName() == "Default__KismetSystemLibrary")
                        {
                            kismetSystemLibAddr = entityAddr;
                            break;

                        }
                    }
                }

            }
            mainTimer.Tick += Tick;
            umodelTimer.Tick += UmodelTick;

        }

        private void reconnectToProc_Click(object sender, EventArgs e)
        {
            if (ConnectToProcess())
            {
                isConnected.Text = "Connected";

                ulong entityList = UnrealEngine.Memory.ReadProcessMemory<ulong>(UnrealEngine.Memory.BaseAddress + UnrealEngine.GObjects);
                uint count = UnrealEngine.Memory.ReadProcessMemory<uint>(UnrealEngine.Memory.BaseAddress + UnrealEngine.GObjects + 20UL);
                entityList = UnrealEngine.Memory.ReadProcessMemory<ulong>(entityList);
                var objs = new UEObject(entityList);
                for (uint i = 0U; i < count; i += 1U)
                {
                    ulong entityAddr = UnrealEngine.Memory.ReadProcessMemory<ulong>(entityList + (ulong)(8U * (i >> 16)) + (ulong)(24U * (i % 65536U)));
                    if (entityAddr != 0UL)
                    {
                        if(new UEObject(entityAddr).GetName()== "Default__KismetSystemLibrary")
                        {
                            kismetSystemLibAddr = entityAddr;
                            break;

                        }
                    }
                }
            }
        }
        static void Log(string msg)
        {
            Console.WriteLine(msg);
            //log.WriteLine(msg);
        }
        static void Log(object obj)
        {
            Log(obj.ToString());
        }
        Dictionary<string, UEObjectInfo> alreadyDumped = new Dictionary<string, UEObjectInfo>();
        Dictionary<string, UEObjectInfo> alreadyDumpedBlueprints = new Dictionary<string, UEObjectInfo>();
        List<string> texturesToDump = new List<string>();
        List<UEObjectInfo> objects = new List<UEObjectInfo>();
        void UmodelDump(string name)
        {
            new Thread(() =>
                 {
                     var args = "";
                     args += $"\"{Program.settings.pakFolder}\"";
                     args += " ";
                     args += $"-aes={Program.settings.AESKey}";
                     args += " ";
                     args += $"-game={Program.settings.ue4version}";
                     args += " ";
                     args += $"-pkg={name.Split('.')[0]}";
                     args += " ";
                     try
                     {
                         args += $"-export {name.Split('.')[1]}";
                     }
                     catch { args += $"-export {name}"; }

                     Process p = new Process();
                     p.StartInfo = new ProcessStartInfo($"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}\\umodel\\umodel.exe");
                     p.StartInfo.Arguments = args;
                     p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Dump";
                     p.StartInfo.CreateNoWindow = true;
                     p.StartInfo.UseShellExecute = false;
                     p.Start();

                 }).Start();
        }
        public void DumpComponentsRecursively(ref List<UEObjectInfo> objs, Array<SceneComponent> children, SceneComponent parent, UEObjectInfo parentObject)
        {
            var count = children.Num;

            for (uint i = 0; i < children.Num; i++)
            {
                if (children[i].IsA(out StaticMeshComponent sm))
                {
                    var newObject = new UEObjectInfo();
                    var namme = sm.StaticMesh.GetFullPath().Split(' ');
                    newObject.path = namme[1];
                    newObject.type = "mesh";

                    newObject.position = parentObject.position;
                    newObject.rotation = parentObject.rotation;
                    newObject.scale = parentObject.scale;
                    newObject.position.X += sm.RelativeLocation.X;
                    newObject.position.Y += sm.RelativeLocation.Y;
                    newObject.position.Z += sm.RelativeLocation.Z;
                    newObject.rotation.X += sm.RelativeRotation.Pitch;
                    newObject.rotation.Y += sm.RelativeRotation.Yaw;
                    newObject.rotation.Z += sm.RelativeRotation.Roll;
                    newObject.scale.X += sm.RelativeScale3D.X;
                    newObject.scale.Y += sm.RelativeScale3D.Y;
                    newObject.scale.Z += sm.RelativeScale3D.Z;
                    parentObject.children.Add(newObject);

                    if (alreadyDumped.Keys.Contains(namme[1])) continue;
                    UmodelDump(namme[1]);

                    DumpComponentsRecursively(ref objs, sm.AttachChildren, sm, newObject);
                }
                else if (children[i].IsA(out SceneComponent sc))
                {
                    var newObject = new UEObjectInfo();
                    newObject.type = "dummy";
                    newObject.path = sc.GetShortName();

                    newObject.position = parentObject.position;
                    newObject.rotation = parentObject.rotation;
                    newObject.scale = parentObject.scale;
                    newObject.position.X += sc.RelativeLocation.X;
                    newObject.position.Y += sc.RelativeLocation.Y;
                    newObject.position.Z += sc.RelativeLocation.Z;
                    newObject.rotation.X += sc.RelativeRotation.Pitch;
                    newObject.rotation.Y += sc.RelativeRotation.Yaw;
                    newObject.rotation.Z += sc.RelativeRotation.Roll;
                    newObject.scale.X += sc.RelativeScale3D.X;
                    newObject.scale.Y += sc.RelativeScale3D.Y;
                    newObject.scale.Z += sc.RelativeScale3D.Z;

                    parentObject.children.Add(newObject);
                    DumpComponentsRecursively(ref objs, sc.AttachChildren, sc, newObject);
                }

            }

        }
        ulong kismetSystemLibAddr;
        void Dump()
        {
            objects.Clear();
            int staticMeshActorCount = 0;
            //ulong addr = (ulong)process.MainModule.BaseAddress.ToInt64() + 0x44291A0;
            //addr = UnrealEngine.Memory.ReadProcessMemory<ulong>(addr);
            //addr = UnrealEngine.Memory.ReadProcessMemory<ulong>(addr + 0x118);
            var kismetSysLib = new KismetSystemLibrary(kismetSystemLibAddr);
            Directory.CreateDirectory("Dump");
            //world = new World(UnrealEngine.Memory.ReadProcessMemory<UInt64>(UnrealEngine.GWorldPtr));
            var worldObj = world.Levels;
            for (uint i = 0; i < worldObj.Num; i++)
            {
                var level = worldObj[i];
                if (mapsToDumpList.Contains(level.ClassName.Split('.')[1]))
                {
                    Log("FOUND LEVEL: " + level.ClassName);
                    var Actors = new UEObject(level.Address + 0x98); // todo fix hardcoded 0xA8 offset...
                    for (var a = 0u; a < Actors.Num; a++)
                    {
                        var Actor = Actors[a].As<Actor>();
                        if (Actor.Address == 0) continue;
                        if (Actor.IsA("Class /Script/Engine.Actor"))
                        {
                            if (Actor.IsA<StaticMeshActor>())
                            {
                                staticMeshActorCount++;
                                var staticMeshActor = Actor.As<StaticMeshActor>();
                                var namme = staticMeshActor.StaticMeshComponent.StaticMesh.GetFullPath().Split(' ');
                                if (!namme[1].Contains("Game")) continue;
                                //if (!(namme[1].Contains("MOD_MERGED_FreddyGreenRoom"))) continue;


                                ulong namePtr = (ulong)kismetSysLib.RetardInvoke(nameof(KismetSystemLibrary.GetPathName), staticMeshActor.StaticMeshComponent.StaticMesh.Address).ToInt64();
                                namePtr = UnrealEngine.Memory.ReadProcessMemory<ulong>(namePtr + 8);
                                var actualName = Program.ReadStringAtAddress(namePtr);

                                //namePtr = UnrealEngine.Memory.ReadProcessMemory<ulong>(namePtr+8);
                                //Console.WriteLine(actualName);
                                namme[1] = actualName;
                                if (actualName == null || actualName == "")
                                {
                                    namme = staticMeshActor.StaticMeshComponent.StaticMesh.GetFullPath().Split(' ');
                                }
                                //Log(new UEObject(0x000001D88D6CCAF0).ClassName);
                                var pos = staticMeshActor.K2_GetActorLocation();
                                var rot = staticMeshActor.K2_GetActorRotation();
                                var scl = staticMeshActor.GetActorScale3D();

                                var newObject = new UEObjectInfo();

                                //KismetSystemLibrary
                                newObject.path = namme[1];
                                newObject.type = "mesh";
                                newObject.position = pos;
                                newObject.rotation = rot;
                                newObject.scale = scl;


                                if (alreadyDumped.Keys.Contains(namme[1]))
                                {
                                    newObject.baseTexture = alreadyDumped[namme[1]].baseTexture;
                                    newObject.materialName = alreadyDumped[namme[1]].materialName;
                                    newObject.nonInstanced = alreadyDumped[namme[1]].nonInstanced;
                                    objects.Add(newObject);
                                    continue;
                                }//
                                var mats = staticMeshActor.StaticMeshComponent.StaticMesh.StaticMaterials;
                                //var obj = new UEObject(pointer);
                                try
                                {
                                    for (int matIndex = 0; matIndex < mats.Num; matIndex++)
                                    {

                                        //var newMat = mats[(uint)matIndex].As<MaterialInstance>();
                                        var pointer = Program.RetardInvoke(staticMeshActor.StaticMeshComponent, nameof(StaticMeshComponent.GetMaterial), matIndex);
                                        var newSuperMat = new UEObject((ulong)pointer);
                                        var actualPointer = UnrealEngine.Memory.ReadProcessMemory<ulong>((ulong)((long)pointer + 8));
                                        var newMat1 = new UEObject(actualPointer);
                                        if (newMat1.GetName() == "None") continue;
                                        if (newMat1.IsA(out MaterialInstanceConstant matInst))
                                        {
                                            for (int textureIndex = 0; textureIndex < matInst?.TextureParameterValues.Num; textureIndex++)
                                            {
                                                //var 

                                                var newTexturePointer = UnrealEngine.Memory.ReadProcessMemory<ulong>((ulong)((long)matInst.TextureParameterValues.Address));
                                                newTexturePointer = UnrealEngine.Memory.ReadProcessMemory<ulong>((ulong)((long)newTexturePointer + 0x10));
                                                var newTexture = new Texture(newTexturePointer);
                                                if (newTexture.GetName() != "None")
                                                {

                                                    newObject.baseTexture = newTexture.GetFullPath().Split(' ')[1];
                                                    texturesToDump.Add(newTexture.GetFullPath());
                                                    newObject.materialName = matInst.GetName();
                                                }
                                            }

                                        }
                                        else if (newMat1.IsA<Material>(out Material actualMat))
                                        {
                                            Log("Encountered non-instanced material");
                                            newObject.nonInstanced = true;
                                            //MaterialTextureInfo
                                            //actualMat.TextureStreamingData
                                        }

                                    }
                                }
                                catch (Exception ex)
                                {
                                    Log("ERROR WHILE PARSING TEXTUERS: " + ex);
                                    Console.ReadKey();
                                }
                                objects.Add(newObject);
                                //Log(stufftolog);

                                //
                                Log("Processing " + namme[1] + " " + a);

                                UmodelDump(namme[1]);
                                //p.BeginOutputReadLine();



                                alreadyDumped.Add(namme[1], newObject);

                            }
                            else
                            {
                               var pos = Actor.K2_GetActorLocation();
                               var rot = Actor.K2_GetActorRotation();
                               var scl = Actor.GetActorScale3D();

                               var newObject = new UEObjectInfo();

                               //KismetSystemLibrary
                               newObject.path = Actor.GetShortName();
                               newObject.type = "dummy";
                               newObject.position = pos;
                               newObject.rotation = rot;
                               newObject.scale = scl;
                               objects.Add(newObject);
                               /*

                                var realActor = Actor.As<Actor>();

                                var root = realActor["RootComponent"];
                                Log($"Doing recursive dumping for object {realActor.GetShortName()} {a}");
                                if(alreadyDumpedBlueprints.Keys.Contains(realActor.ClassName))
                                {
                                    var newObject = alreadyDumpedBlueprints[realActor.ClassName];
                                    newObject.position = realActor.K2_GetActorLocation();
                                    newObject.rotation = realActor.K2_GetActorRotation();
                                    newObject.scale = realActor.GetActorScale3D();
                                    objects.Add(newObject);
                                    return;
                                }
                                //Console.WriteLine($"SKIPPING {realActor.GetShortName()}. Root component - {root.GetShortName()}");
                                if (root.IsA(out SceneComponent sceneComponent))
                                {
                                    var newObject = new UEObjectInfo();
                                    newObject.type = "dummy";
                                    newObject.path = sceneComponent.GetShortName();
                                    newObject.position = realActor.K2_GetActorLocation();
                                    newObject.rotation = realActor.K2_GetActorRotation();
                                    newObject.scale = realActor.GetActorScale3D();
                                    objects.Add(newObject);
                                    DumpComponentsRecursively(ref objects, sceneComponent.AttachChildren, sceneComponent, newObject);
                                }
                                else if (root.IsA(out StaticMeshComponent sm))
                                {
                                    var newObject = new UEObjectInfo();
                                    var namme = sm.StaticMesh.GetFullPath().Split(' ');
                                    newObject.path = namme[1];
                                    newObject.type = "mesh";
                                    var pos = realActor.K2_GetActorLocation();
                                    var rot = realActor.K2_GetActorRotation();
                                    var scl = realActor.GetActorScale3D();
                                    newObject.position = pos;
                                    newObject.rotation = rot;
                                    newObject.scale = scl;


                                    if (alreadyDumped.Keys.Contains(namme[1])) continue;

                                    UmodelDump(namme[1]);
                                }

                                /*   var pos = Actor.K2_GetActorLocation();
                               var rot = Actor.K2_GetActorRotation();
                               var scl = Actor.GetActorScale3D();

                               var newObject = new UEObjectInfo();

                               //KismetSystemLibrary
                               newObject.path = Actor.GetShortName();
                               newObject.type = "empty";
                               newObject.position = pos;
                               newObject.rotation = rot;
                               newObject.scale = scl;
                               objects.Add(newObject);*/

                            }
                        }

                    }

                }
                
            }
            if (true)
            {

                List<string> alreadyDumpedTextures = new List<string>();
                for (int i = 0; i < objects.Count; i++)
                {
                    var textureName = objects[i].baseTexture;
                    if (alreadyDumpedTextures.Contains(textureName)) continue;
                    if (textureName == null) continue;
                    try
                    {
                        Log("Dumping texture: " + textureName);
                        UmodelDump(textureName);
                    }
                    catch
                    {
                        Log("ERROR WHILE REPARSING TEXTURES");
                    }
                    alreadyDumpedTextures.Add(textureName);
                }
            }
            var stringLevel = JsonConvert.SerializeObject(objects, Formatting.Indented);
            File.WriteAllText("Dump\\dump.json", stringLevel);
            Log("Done. Actors dumped: " + staticMeshActorCount);

        }
        private void dumpButton_Click(object sender, EventArgs e)
        {
            new Thread(() => { Dump(); }).Start();
        }
        List<string> mapsToDumpList = new List<string>();
        int tempActorsToDump = 0;
        private void Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var item = Levels.SelectedItem.ToString();

            if (!mapsToDumpList.Contains(item))               
            {
                mapsToDumpList.Add(item);
                mapsToDump.Items.Add(item);
               
                for (int i = 0; i < world.Levels.Num; i++)
                {
                    if (mapsToDumpList.Contains(world.Levels[(uint)i].ClassName.Split('.')[1]))
                    {
                        var Actors = new UEObject(world.Levels[(uint)i].Address + 0x98); // todo fix hardcoded 0xA8 offset...
                        for (var a = 0u; a < Actors.Num; a++)
                        {
                            var Actor = Actors[a];
                            if (Actor.Address == 0) continue;
                            if (Actor.IsA("Class /Script/Engine.Actor"))
                            {
                                if (Actor.IsA<StaticMeshActor>())
                                {
                                    tempActorsToDump++;
                                }
                            }
                        }
                    }
                }
                actortodumplabel.Text = "Meshes to dump: " + tempActorsToDump;

            }
        }



        private void clearBtn_Click(object sender, EventArgs e)
        {
            mapsToDumpList.Clear();
            mapsToDump.Items.Clear();
            tempActorsToDump = 0;
            actortodumplabel.Text = "Meshes to dump: " + 0;

        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("penis");
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            var newForm = new AboutForm();
            newForm.Show();
        }
    }
}
