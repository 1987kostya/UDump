using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Numerics;
using UnrealSharp;
using SDK.Script.EngineSDK;
using Console = System.Console;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using SDK.Script.CoreUObjectSDK;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fnaf99
{
    public class TextureData
    {
    }
    public class UEObjectInfo
    {
        public string path;
        public string type;
        public List<UEObjectInfo> children = new List<UEObjectInfo>();
        public Vector3 position;
        public Vector3 rotation;
        public Vector3 scale;
        public string baseTexture;
        public bool nonInstanced;
        public string materialName;

    }
    public class Settings
    {
        public string AESKey;
        public string gameName;
        public string pakFolder;
        public string ue4version;
    }
    
    public static class Program
    {
        public static List<UEObjectInfo> objects = new List<UEObjectInfo>();
        static String staticGameName = "freddys-Win64-Shipping";
        static StreamWriter log = new StreamWriter(new FileStream("Latest.log", FileMode.Create)) { AutoFlush = true };



        static Process process;
        static List<UEObject> Players = new List<UEObject>();

        static Dictionary<string,UEObjectInfo> alreadyDumped = new Dictionary<string, UEObjectInfo>();
        static List<string> texturesToDump = new List<string>();
        static void Log(string msg)
        {
            Console.WriteLine(msg);
            log.WriteLine(msg);
        }
        static void Log(object obj)
        {
            Log(obj.ToString());
        }
        [DllImport("kernel32")]
        private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, int dwProcessId);

        // Token: 0x06000014 RID: 20
        [DllImport("kernel32")]
        private static extern int ReadProcessMemory(IntPtr hProcess, ulong lpBaseAddress, [In][Out] byte[] buffer, int size, out int lpNumberOfBytesRead);

        // Token: 0x06000015 RID: 21
        [DllImport("kernel32")]
        private static extern bool WriteProcessMemory(IntPtr hProcess, ulong lpBaseAddress, byte[] buffer, int nSize, out int lpNumberOfBytesWritten);

        // Token: 0x06000016 RID: 22
        [DllImport("kernel32")]
        private static extern int CloseHandle(IntPtr hObject);

        // Token: 0x06000017 RID: 23
        [DllImport("kernel32")]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        // Token: 0x06000018 RID: 24
        [DllImport("kernel32")]
        private static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

        // Token: 0x06000019 RID: 25
        [DllImport("kernel32")]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int flAllocationType, int flProtect);

        // Token: 0x0600001A RID: 26
        [DllImport("kernel32")]
        private static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);

        // Token: 0x0600001B RID: 27
        [DllImport("user32")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

        // Token: 0x0600001C RID: 28
        [DllImport("user32")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);
        public static IntPtr RetardedExecuteUEFunc(IntPtr vtableAddr, IntPtr objAddr, IntPtr funcAddr, params object[] args)
        {
            IntPtr dummyParms = VirtualAllocEx(UnrealEngine.Memory.procHandle, IntPtr.Zero, 256, 4096, 64);
            UnrealEngine.Memory.WriteProcessMemory((ulong)((long)dummyParms), BitConverter.GetBytes(ulong.MaxValue));
            uint offset = 0U;
            foreach (object obj in args)
            {
                UnrealEngine.Memory.WriteProcessMemory<object>((ulong)((long)dummyParms + (long)((ulong)offset)), obj);
                Type outputType = obj.GetType().IsEnum ? System.Enum.GetUnderlyingType(obj.GetType()) : obj.GetType();
                offset += (uint)Marshal.SizeOf(outputType);
            }
            List<byte> asm = new List<byte>();
            asm.AddRange(new byte[]
            {
                72,
                131,
                236
            });
            asm.Add(40);
            asm.AddRange(new byte[]
            {
                72,
                184
            });
            asm.AddRange(BitConverter.GetBytes((ulong)((long)vtableAddr)));
            asm.AddRange(new byte[]
            {
                72,
                185
            });
            asm.AddRange(BitConverter.GetBytes((ulong)((long)objAddr)));
            asm.AddRange(new byte[]
            {
                72,
                186
            });
            asm.AddRange(BitConverter.GetBytes((ulong)((long)funcAddr)));
            asm.AddRange(new byte[]
            {
                73,
                184
            });
            asm.AddRange(BitConverter.GetBytes((ulong)((long)dummyParms)));
            asm.AddRange(new byte[]
            {
                byte.MaxValue,
                208
            });
            asm.AddRange(new byte[]
            {
                72,
                131,
                196
            });
            asm.Add(40);
            asm.Add(195);
            IntPtr codePtr = VirtualAllocEx(UnrealEngine.Memory.procHandle, IntPtr.Zero, asm.Count, 4096, 64);
            int bytesRead;
            WriteProcessMemory(UnrealEngine.Memory.procHandle, (ulong)((long)codePtr), asm.ToArray(), asm.Count, out bytesRead);
            IntPtr thread = CreateRemoteThread(UnrealEngine.Memory.procHandle, IntPtr.Zero, 0U, codePtr, IntPtr.Zero, 0U, IntPtr.Zero);
            WaitForSingleObject(thread, 10000U);
            ulong result = UnrealEngine.Memory.ReadProcessMemory<ulong>((ulong)((long)dummyParms));
            //VirtualFreeEx(UnrealEngine.Memory.procHandle, dummyParms, 0, 32768);
            VirtualFreeEx(UnrealEngine.Memory.procHandle, codePtr, 0, 32768);
            CloseHandle(thread);
            return dummyParms;
        }
        public static T RetardInvoke<T>(this UEObject inst, string funcName, params object[] args) where T: UEObject, new()
        {
            var pointer = (ulong)RetardInvoke(inst, funcName, args).ToInt64();
            return new UEObject(pointer).As<T>();
        }

        public static IntPtr RetardInvoke(this UEObject inst,string funcName, params object[] args)
        {
            ulong funcAddr = inst.GetFuncAddr(inst.ClassAddr, inst.ClassAddr, funcName);
            ulong initFlags = UnrealEngine.Memory.ReadProcessMemory<ulong>(funcAddr + (ulong)UEObject.funcFlagsOffset);
            ulong nativeFlag = initFlags;
            nativeFlag |= 1024UL;
            if (nativeFlag != initFlags)
            {
                UnrealEngine.Memory.WriteProcessMemory(funcAddr + (ulong)UEObject.funcFlagsOffset, BitConverter.GetBytes(nativeFlag));
            }
            IntPtr result = RetardedExecuteUEFunc((IntPtr)((long)inst.VTableFunc), (IntPtr)((long)inst.Address), (IntPtr)((long)funcAddr), args);
            if (nativeFlag != initFlags)
            {
                UnrealEngine.Memory.WriteProcessMemory(funcAddr + (ulong)UEObject.funcFlagsOffset, BitConverter.GetBytes(initFlags));
            }
            return result;
        }
        public static Vector3 FixRotationRecursive(Actor actor,Vector3 baseRotation)
        {
            var parentPointer = actor.RetardInvoke(nameof(StaticMeshActor.GetParentComponent));
            var parent = new UEObject((ulong)parentPointer.ToInt64());
            //Log("Parent is: " + parent.GetName());
            if (!parent.IsA<Actor>()) return baseRotation;
                var parentparentPointer = parent.RetardInvoke(nameof(StaticMeshActor.GetParentComponent));
            
            var parentparent = new Actor((ulong)parentPointer.ToInt64());

            if (parent.IsA<Actor>())
            {
                //baseRotation += FixRotationRecursive(parent, baseRotation);
            }

            return baseRotation;
        }
        static int staticMeshActorCount = 0;
        public static string GetName(UEObject obj)
        {
            var key = UnrealEngine.Memory.ReadProcessMemory<int>(obj.Address + (ulong)UEObject.nameOffset);

            ulong namePtr = UnrealEngine.Memory.ReadProcessMemory<ulong>(UnrealEngine.GNames + (ulong)(((key >> 16) + 2) * 8));
            if (namePtr == 0UL)
            {
                return "badIndex";
            }
            int nameLength = UnrealEngine.Memory.ReadProcessMemory<ushort>(namePtr + (ulong)((ushort)key * 2)) >> 6;
            if (nameLength <= 0)
            {
                return "badIndex";
            }
            UnrealEngine.Memory.maxStringLength = nameLength;
            string result = UnrealEngine.Memory.ReadProcessMemory<string>(namePtr + (ulong)((ushort)key * 2) + 2UL);
            UnrealEngine.Memory.maxStringLength = 256;
            return result;
        }
        public static string ReadStringAtAddress(ulong addr)
        {
            byte[] buffer;
            var stringBuilder = new StringBuilder();
            buffer = UnrealEngine.Memory.ReadProcessMemory(addr, 4096);
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i] == 0&&buffer[i+1]==0) break;
                var newShort = (short)(buffer[i] + (buffer[i+1] << 8));
                stringBuilder.Append((char)newShort);
                i++;
            }
            return stringBuilder.ToString();
        }
        public static unsafe void UpdateAllGregorys()
        {

            try
            {
                ulong addr = (ulong)process.MainModule.BaseAddress.ToInt64() + 0x44291A0;
                addr = UnrealEngine.Memory.ReadProcessMemory<ulong>(addr);
                addr = UnrealEngine.Memory.ReadProcessMemory<ulong>(addr + 0x118);
                var kismetSysLib = new KismetSystemLibrary(addr);
                Directory.CreateDirectory("Dump");
                var World = new UEObject(UnrealEngine.Memory.ReadProcessMemory<UInt64>(UnrealEngine.GWorldPtr)); if (World == null || !World.IsA("Class /Script/Engine.World")) return;
                var PersistentLevel = World["PersistentLevel"];
                var worldObj = World.As<SDK.Script.EngineSDK.World>().Levels;
                for (uint i = 0; i < worldObj.Num; i++)
                {
                    var level = worldObj[i];
                    //if(level.ClassName.Contains("Freddy"))
                    {
                        Log("FOUND LEVEL: " + level.ClassName);
                        var Actors = new UEObject(level.Address + 0x98); // todo fix hardcoded 0xA8 offset...
                        for (var a = 0u; a < Actors.Num; a++)
                        {
                            var Actor = Actors[a];
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
                                    namePtr = UnrealEngine.Memory.ReadProcessMemory<ulong>(namePtr+8);
                                    var actualName = ReadStringAtAddress(namePtr);
                                    
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
                                    else objects.Add(newObject);
                                    var mats = staticMeshActor.StaticMeshComponent.StaticMesh.StaticMaterials;
                                    //var obj = new UEObject(pointer);
                                    try
                                    {
                                        for (int matIndex = 0; matIndex < mats.Num; matIndex++)
                                        {

                                            //var newMat = mats[(uint)matIndex].As<MaterialInstance>();
                                            var pointer = RetardInvoke(staticMeshActor.StaticMeshComponent, nameof(StaticMeshComponent.GetMaterial), matIndex);
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
                                    //Log(stufftolog);

                                    //
                                    var args = "";
                                    args += $"\"{settings.pakFolder}\"";
                                    args += " ";
                                    args += $"-aes={settings.AESKey}";
                                    args += " ";
                                    args += "-game=ue4.25";
                                    args += " ";
                                    args += $"-pkg={namme[1].Split('.')[0]}";
                                    args += " ";
                                    try
                                    {
                                        args += $"-export {namme[1].Split('.')[1]}";
                                    }
                                    catch { args += $"-export {namme[1]}"; }

                                    Log("Processing " + namme[1] + " " + a);

                                    Process p = new Process();
                                    p.StartInfo = new ProcessStartInfo($"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}\\umodel\\umodel.exe");
                                    p.StartInfo.Arguments = args;
                                    p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Dump";
                                    p.StartInfo.CreateNoWindow = true;
                                    p.StartInfo.UseShellExecute = false;
                                    p.StartInfo.RedirectStandardOutput = true;
                                    p.Start();
                                    //p.BeginOutputReadLine();



                                    alreadyDumped.Add(namme[1], newObject);

                                }
                                else
                                {
                                    continue;
                                    var realActor = Actor.As<Actor>();

                                    var root = realActor["RootComponent"];
                                    Log($"Doing recursive dumping for object {realActor.GetShortName()} {a}");
                                    //Console.WriteLine($"SKIPPING {realActor.GetShortName()}. Root component - {root.GetShortName()}");
                                    if (root.IsA(out SceneComponent sceneComponent))
                                    {
                                        var newObject = new UEObjectInfo();
                                        newObject.type = "dummy";
                                        newObject.position = realActor.K2_GetActorLocation();
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

                                        var args = "";
                                        args += $"\"{settings.pakFolder}\"";
                                        args += " ";
                                        args += $"-aes={settings.AESKey}";
                                        args += " ";
                                        args += "-game=ue4.25";
                                        args += " ";
                                        args += $"-pkg={namme[1].Split('.')[0]}";
                                        args += " ";

                                        try
                                        {
                                            args += $"-export {namme[1].Split('.')[1]}";
                                        }
                                        catch
                                        {
                                        }

                                        Process p = new Process();
                                        p.StartInfo = new ProcessStartInfo($"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}\\umodel\\umodel.exe");
                                        p.StartInfo.Arguments = args;
                                        p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Dump";
                                        p.StartInfo.CreateNoWindow = true;

                                        p.Start();



                                    }

                                    //Console.ReadKey();
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
                            var args = "";
                            args += $"\"{settings.pakFolder}\"";
                            args += " ";
                            args += $"-aes={settings.AESKey}";
                            args += " ";
                            args += "-game=ue4.25";
                            args += " ";
                            args += $"-pkg={textureName.Split('.')[0]}";
                            args += " ";
                            var split = textureName.Split('/');

                                args += $"-export {split[split.Length-1].Split('.')[0]}";

                            
                            Log("Processing " + textureName + " " + i);
                                //Log(args);
                                //Console.ReadKey();
                            
                            Process p = new Process();
                            p.StartInfo = new ProcessStartInfo($"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}\\umodel\\umodel.exe");
                            p.StartInfo.Arguments = args;
                            p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Dump";
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.Start();
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
                Log("Done. Actors dumped: "+staticMeshActorCount);
                while (true) { }
            
            }
            catch (Exception ex)
            {
                Log(ex.ToString());
                Console.ReadKey();
            }
        
        }
        public static void DumpComponentsRecursively(ref List<UEObjectInfo> objs, Array<SceneComponent> children,SceneComponent parent,UEObjectInfo parentObject)
        {
            var count = children.Num;
            
            for (uint i = 0; i < children.Num; i++)
            {
                if(children[i].IsA(out StaticMeshComponent sm))
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
                    var args = "";
                    args += $"\"{settings.pakFolder}\"";
                    args += " ";
                    args += $"-aes={settings.AESKey}";
                    args += " ";
                    args += "-game=ue4.25";
                    args += " ";
                    args += $"-pkg={namme[1].Split('.')[0]}";
                    args += " ";
                    
                    try
                    {
                        args += $"-export {namme[1].Split('.')[1]}";
                    }
                    catch { 
                    }
                    Process p = new Process();
                    p.StartInfo = new ProcessStartInfo($"{Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)}\\umodel\\umodel.exe");
                    p.StartInfo.Arguments = args;
                    p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Dump";
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.UseShellExecute = false;
                    p.Start();

                    DumpComponentsRecursively(ref objs, sm.AttachChildren, sm, newObject);  
                }
                else if(children[i].IsA(out SceneComponent sc))
                {
                    var newObject = new UEObjectInfo();
                    newObject.type = "dummy";

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
        



       static void GetProcess()
        {
            while (true)
            {
                if (settings.gameName != "autogenerate") process = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.Contains(settings.gameName) && p.MainWindowHandle != IntPtr.Zero);
                if (process != null) break;
                Thread.Sleep(500);
            }
        }

        static Object sync = new Object();
        public static void Initlize()
        {
            if (process == null)
            {
                try
                {
                    GetProcess();
                    new UnrealEngine(new Memory(process)).UpdateAddresses();
                }
                catch(Exception ex)
                {
                    Log(ex);
                }
                
            }

        }
        public static Settings settings;

        static void Main(string[] args)
        {
            if (File.Exists("settings.json"))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));

            }
            else settings = new Settings();
            var form = new MainForm();
            Application.Run(form);
            return;
            Console.Title = "UDump 1.0";
            
            staticGameName = settings.gameName;

            Initlize();
            UpdateAllGregorys();

        }
    }
}
