using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.MRMeshSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapHandMeshingSDK
{
    public class MagicLeapHandMeshingComponent : ActorComponent
    {
        public MagicLeapHandMeshingComponent(ulong addr) : base(addr) { }
        public void SetUseWeightedNormals(bool bInUseWeightedNormals) { Invoke(nameof(SetUseWeightedNormals), bInUseWeightedNormals); }
        public bool DisconnectMRMesh(MRMeshComponent InMRMeshPtr) { return Invoke<bool>(nameof(DisconnectMRMesh), InMRMeshPtr); }
        public bool ConnectMRMesh(MRMeshComponent InMRMeshPtr) { return Invoke<bool>(nameof(ConnectMRMesh), InMRMeshPtr); }
    }
    public class MagicLeapHandMeshingFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapHandMeshingFunctionLibrary(ulong addr) : base(addr) { }
        public bool DisconnectMRMesh(MRMeshComponent InMRMeshPtr) { return Invoke<bool>(nameof(DisconnectMRMesh), InMRMeshPtr); }
        public bool DestroyClient() { return Invoke<bool>(nameof(DestroyClient)); }
        public bool CreateClient() { return Invoke<bool>(nameof(CreateClient)); }
        public bool ConnectMRMesh(MRMeshComponent InMRMeshPtr) { return Invoke<bool>(nameof(ConnectMRMesh), InMRMeshPtr); }
    }
    public class MagicLeapHandMesh : Object
    {
        public MagicLeapHandMesh(ulong addr) : base(addr) { }
        public int Version { get { return this[nameof(Version)].GetValue<int>(); } set { this[nameof(Version)].SetValue<int>(value); } }
        public int DataCount { get { return this[nameof(DataCount)].GetValue<int>(); } set { this[nameof(DataCount)].SetValue<int>(value); } }
        public Array<MagicLeapHandMeshBlock> Data { get { return new Array<MagicLeapHandMeshBlock>(this[nameof(Data)].Address); } }
    }
    public class MagicLeapHandMeshBlock : Object
    {
        public MagicLeapHandMeshBlock(ulong addr) : base(addr) { }
        public int IndexCount { get { return this[nameof(IndexCount)].GetValue<int>(); } set { this[nameof(IndexCount)].SetValue<int>(value); } }
        public int VertexCount { get { return this[nameof(VertexCount)].GetValue<int>(); } set { this[nameof(VertexCount)].SetValue<int>(value); } }
        public Array<Vector> Vertex { get { return new Array<Vector>(this[nameof(Vertex)].Address); } }
        public Array<int> Index { get { return new Array<int>(this[nameof(Index)].Address); } }
    }
}
