using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.HeadMountedDisplaySDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.MRMeshSDK;
namespace SDK.Script.MagicLeapSDK
{
    public class InAppPurchaseComponent : ActorComponent
    {
        public InAppPurchaseComponent(ulong addr) : base(addr) { }
        public Object InAppPurchaseLogMessage { get { return this[nameof(InAppPurchaseLogMessage)]; } set { this[nameof(InAppPurchaseLogMessage)] = value; } }
        public Object GetItemsDetailsSuccess { get { return this[nameof(GetItemsDetailsSuccess)]; } set { this[nameof(GetItemsDetailsSuccess)] = value; } }
        public Object GetItemsDetailsFailure { get { return this[nameof(GetItemsDetailsFailure)]; } set { this[nameof(GetItemsDetailsFailure)] = value; } }
        public Object PurchaseConfirmationSuccess { get { return this[nameof(PurchaseConfirmationSuccess)]; } set { this[nameof(PurchaseConfirmationSuccess)] = value; } }
        public Object PurchaseConfirmationFailure { get { return this[nameof(PurchaseConfirmationFailure)]; } set { this[nameof(PurchaseConfirmationFailure)] = value; } }
        public Object GetPurchaseHistorySuccess { get { return this[nameof(GetPurchaseHistorySuccess)]; } set { this[nameof(GetPurchaseHistorySuccess)] = value; } }
        public Object GetPurchaseHistoryFailure { get { return this[nameof(GetPurchaseHistoryFailure)]; } set { this[nameof(GetPurchaseHistoryFailure)] = value; } }
        public bool TryPurchaseItemAsync(PurchaseItemDetails ItemDetails) { return Invoke<bool>(nameof(TryPurchaseItemAsync), ItemDetails); }
        public bool TryGetPurchaseHistoryAsync(int InNumPages) { return Invoke<bool>(nameof(TryGetPurchaseHistoryAsync), InNumPages); }
        public bool TryGetItemsDetailsAsync(Array<Object> ItemIDs) { return Invoke<bool>(nameof(TryGetItemsDetailsAsync), ItemIDs); }
        public void PurchaseConfirmationSuccess__DelegateSignature(PurchaseConfirmation PurchaseConfirmations) { Invoke(nameof(PurchaseConfirmationSuccess__DelegateSignature), PurchaseConfirmations); }
        public void PurchaseConfirmationFailure__DelegateSignature() { Invoke(nameof(PurchaseConfirmationFailure__DelegateSignature)); }
        public void InAppPurchaseLogMessage__DelegateSignature(Object LogMessage) { Invoke(nameof(InAppPurchaseLogMessage__DelegateSignature), LogMessage); }
        public void GetPurchaseHistorySuccess__DelegateSignature(Array<PurchaseConfirmation> PurchaseHistory) { Invoke(nameof(GetPurchaseHistorySuccess__DelegateSignature), PurchaseHistory); }
        public void GetPurchaseHistoryFailure__DelegateSignature() { Invoke(nameof(GetPurchaseHistoryFailure__DelegateSignature)); }
        public void GetItemsDetailsSuccess__DelegateSignature(Array<PurchaseItemDetails> ItemsDetails) { Invoke(nameof(GetItemsDetailsSuccess__DelegateSignature), ItemsDetails); }
        public void GetItemsDetailsFailure__DelegateSignature() { Invoke(nameof(GetItemsDetailsFailure__DelegateSignature)); }
    }
    public class LuminApplicationLifecycleComponent : ApplicationLifecycleComponent
    {
        public LuminApplicationLifecycleComponent(ulong addr) : base(addr) { }
        public Object DeviceHasReactivatedDelegate { get { return this[nameof(DeviceHasReactivatedDelegate)]; } set { this[nameof(DeviceHasReactivatedDelegate)] = value; } }
        public Object DeviceWillEnterRealityModeDelegate { get { return this[nameof(DeviceWillEnterRealityModeDelegate)]; } set { this[nameof(DeviceWillEnterRealityModeDelegate)] = value; } }
        public Object DeviceWillGoInStandbyDelegate { get { return this[nameof(DeviceWillGoInStandbyDelegate)]; } set { this[nameof(DeviceWillGoInStandbyDelegate)] = value; } }
        public Object FocusLostDelegate { get { return this[nameof(FocusLostDelegate)]; } set { this[nameof(FocusLostDelegate)] = value; } }
        public Object FocusGainedDelegate { get { return this[nameof(FocusGainedDelegate)]; } set { this[nameof(FocusGainedDelegate)] = value; } }
    }
    public class MagicLeapHeadTrackingNotificationsComponent : VRNotificationsComponent
    {
        public MagicLeapHeadTrackingNotificationsComponent(ulong addr) : base(addr) { }
        public Object OnHeadTrackingLost { get { return this[nameof(OnHeadTrackingLost)]; } set { this[nameof(OnHeadTrackingLost)] = value; } }
        public Object OnHeadTrackingRecovered { get { return this[nameof(OnHeadTrackingRecovered)]; } set { this[nameof(OnHeadTrackingRecovered)] = value; } }
        public Object OnHeadTrackingRecoveryFailed { get { return this[nameof(OnHeadTrackingRecoveryFailed)]; } set { this[nameof(OnHeadTrackingRecoveryFailed)] = value; } }
        public Object OnHeadTrackingNewSessionStarted { get { return this[nameof(OnHeadTrackingNewSessionStarted)]; } set { this[nameof(OnHeadTrackingNewSessionStarted)] = value; } }
    }
    public class MagicLeapHMDFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapHMDFunctionLibrary(ulong addr) : base(addr) { }
        public void SetStabilizationDepthActor(Actor InStabilizationDepthActor, bool bSetFocusActor) { Invoke(nameof(SetStabilizationDepthActor), InStabilizationDepthActor, bSetFocusActor); }
        public void SetFocusActor(Actor InFocusActor, bool bSetStabilizationActor) { Invoke(nameof(SetFocusActor), InFocusActor, bSetStabilizationActor); }
        public void SetBaseRotation(Rotator InBaseRotation) { Invoke(nameof(SetBaseRotation), InBaseRotation); }
        public void SetBasePosition(Vector InBasePosition) { Invoke(nameof(SetBasePosition), InBasePosition); }
        public void SetBaseOrientation(Quat InBaseOrientation) { Invoke(nameof(SetBaseOrientation), InBaseOrientation); }
        public bool SetAppReady() { return Invoke<bool>(nameof(SetAppReady)); }
        public bool IsRunningOnMagicLeapHMD() { return Invoke<bool>(nameof(IsRunningOnMagicLeapHMD)); }
        public int GetPlatformAPILevel() { return Invoke<int>(nameof(GetPlatformAPILevel)); }
        public int GetMLSDKVersionRevision() { return Invoke<int>(nameof(GetMLSDKVersionRevision)); }
        public int GetMLSDKVersionMinor() { return Invoke<int>(nameof(GetMLSDKVersionMinor)); }
        public int GetMLSDKVersionMajor() { return Invoke<int>(nameof(GetMLSDKVersionMajor)); }
        public Object GetMLSDKVersion() { return Invoke<Object>(nameof(GetMLSDKVersion)); }
        public int GetMinimumAPILevel() { return Invoke<int>(nameof(GetMinimumAPILevel)); }
        public bool GetHeadTrackingState(MagicLeapHeadTrackingState State) { return Invoke<bool>(nameof(GetHeadTrackingState), State); }
        public bool GetHeadTrackingMapEvents(Object MapEvents) { return Invoke<bool>(nameof(GetHeadTrackingMapEvents), MapEvents); }
        public bool GetGraphicsClientPerformanceInfo(MagicLeapGraphicsClientPerformanceInfo PerformanceInfo) { return Invoke<bool>(nameof(GetGraphicsClientPerformanceInfo), PerformanceInfo); }
    }
    public class MagicLeapMeshTrackerComponent : SceneComponent
    {
        public MagicLeapMeshTrackerComponent(ulong addr) : base(addr) { }
        public Object OnMeshTrackerUpdated { get { return this[nameof(OnMeshTrackerUpdated)]; } set { this[nameof(OnMeshTrackerUpdated)] = value; } }
        public bool ScanWorld { get { return this[nameof(ScanWorld)].Flag; } set { this[nameof(ScanWorld)].Flag = value; } }
        public EMagicLeapMeshType MeshType { get { return (EMagicLeapMeshType)this[nameof(MeshType)].GetValue<int>(); } set { this[nameof(MeshType)].SetValue<int>((int)value); } }
        public BoxComponent BoundingVolume { get { return this[nameof(BoundingVolume)].As<BoxComponent>(); } set { this["BoundingVolume"] = value; } }
        public EMagicLeapMeshLOD LevelOfDetail { get { return (EMagicLeapMeshLOD)this[nameof(LevelOfDetail)].GetValue<int>(); } set { this[nameof(LevelOfDetail)].SetValue<int>((int)value); } }
        public float PerimeterOfGapsToFill { get { return this[nameof(PerimeterOfGapsToFill)].GetValue<float>(); } set { this[nameof(PerimeterOfGapsToFill)].SetValue<float>(value); } }
        public bool Planarize { get { return this[nameof(Planarize)].Flag; } set { this[nameof(Planarize)].Flag = value; } }
        public float DisconnectedSectionArea { get { return this[nameof(DisconnectedSectionArea)].GetValue<float>(); } set { this[nameof(DisconnectedSectionArea)].SetValue<float>(value); } }
        public bool RequestNormals { get { return this[nameof(RequestNormals)].Flag; } set { this[nameof(RequestNormals)].Flag = value; } }
        public bool RequestVertexConfidence { get { return this[nameof(RequestVertexConfidence)].Flag; } set { this[nameof(RequestVertexConfidence)].Flag = value; } }
        public EMagicLeapMeshVertexColorMode VertexColorMode { get { return (EMagicLeapMeshVertexColorMode)this[nameof(VertexColorMode)].GetValue<int>(); } set { this[nameof(VertexColorMode)].SetValue<int>((int)value); } }
        public Array<Color> BlockVertexColors { get { return new Array<Color>(this[nameof(BlockVertexColors)].Address); } }
        public LinearColor VertexColorFromConfidenceZero { get { return this[nameof(VertexColorFromConfidenceZero)].As<LinearColor>(); } set { this["VertexColorFromConfidenceZero"] = value; } }
        public LinearColor VertexColorFromConfidenceOne { get { return this[nameof(VertexColorFromConfidenceOne)].As<LinearColor>(); } set { this["VertexColorFromConfidenceOne"] = value; } }
        public bool RemoveOverlappingTriangles { get { return this[nameof(RemoveOverlappingTriangles)].Flag; } set { this[nameof(RemoveOverlappingTriangles)].Flag = value; } }
        public MRMeshComponent MRMesh { get { return this[nameof(MRMesh)].As<MRMeshComponent>(); } set { this["MRMesh"] = value; } }
        public int BricksPerFrame { get { return this[nameof(BricksPerFrame)].GetValue<int>(); } set { this[nameof(BricksPerFrame)].SetValue<int>(value); } }
        public void SelectMeshBlocks(MagicLeapTrackingMeshInfo NewMeshInfo, Array<MagicLeapMeshBlockRequest> RequestedMesh) { Invoke(nameof(SelectMeshBlocks), NewMeshInfo, RequestedMesh); }
        public void OnMeshTrackerUpdated__DelegateSignature(Guid ID, Array<Vector> Vertices, Array<int> Triangles, Array<Vector> Normals, Array<float> Confidence) { Invoke(nameof(OnMeshTrackerUpdated__DelegateSignature), ID, Vertices, Triangles, Normals, Confidence); }
        public int GetNumQueuedBlockUpdates() { return Invoke<int>(nameof(GetNumQueuedBlockUpdates)); }
        public void DisconnectMRMesh(MRMeshComponent InMRMeshPtr) { Invoke(nameof(DisconnectMRMesh), InMRMeshPtr); }
        public void DisconnectBlockSelector() { Invoke(nameof(DisconnectBlockSelector)); }
        public void ConnectMRMesh(MRMeshComponent InMRMeshPtr) { Invoke(nameof(ConnectMRMesh), InMRMeshPtr); }
        public void ConnectBlockSelector(Object Selector) { Invoke(nameof(ConnectBlockSelector), Selector); }
    }
    public class MagicLeapSettings : Object
    {
        public MagicLeapSettings(ulong addr) : base(addr) { }
        public bool bEnableZI { get { return this[nameof(bEnableZI)].Flag; } set { this[nameof(bEnableZI)].Flag = value; } }
        public bool bUseVulkanForZI { get { return this[nameof(bUseVulkanForZI)].Flag; } set { this[nameof(bUseVulkanForZI)].Flag = value; } }
        public bool bUseMLAudioForZI { get { return this[nameof(bUseMLAudioForZI)].Flag; } set { this[nameof(bUseMLAudioForZI)].Flag = value; } }
    }
    public class MagicLeapMeshBlockSelectorInterface : Interface
    {
        public MagicLeapMeshBlockSelectorInterface(ulong addr) : base(addr) { }
        public void SelectMeshBlocks(MagicLeapTrackingMeshInfo NewMeshInfo, Array<MagicLeapMeshBlockRequest> RequestedMesh) { Invoke(nameof(SelectMeshBlocks), NewMeshInfo, RequestedMesh); }
    }
    public class MagicLeapRaycastComponent : ActorComponent
    {
        public MagicLeapRaycastComponent(ulong addr) : base(addr) { }
        public bool RequestRaycast(MagicLeapRaycastQueryParams RequestParams, Object ResultDelegate) { return Invoke<bool>(nameof(RequestRaycast), RequestParams, ResultDelegate); }
        public void RaycastResultDelegate__DelegateSignature(MagicLeapRaycastHitResult HitResult) { Invoke(nameof(RaycastResultDelegate__DelegateSignature), HitResult); }
    }
    public class MagicLeapRaycastFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapRaycastFunctionLibrary(ulong addr) : base(addr) { }
        public MagicLeapRaycastQueryParams MakeRaycastQueryParams(Vector Position, Vector Direction, Vector UpVector, int Width, int Height, float HorizontalFovDegrees, bool CollideWithUnobserved, int UserData) { return Invoke<MagicLeapRaycastQueryParams>(nameof(MakeRaycastQueryParams), Position, Direction, UpVector, Width, Height, HorizontalFovDegrees, CollideWithUnobserved, UserData); }
    }
    public class PurchaseItemDetails : Object
    {
        public PurchaseItemDetails(ulong addr) : base(addr) { }
        public Object Price { get { return this[nameof(Price)]; } set { this[nameof(Price)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public PurchaseType Type { get { return (PurchaseType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public enum PurchaseType : int
    {
        Consumable = 0,
        Nonconsumable = 1,
        Undefined = 2,
        PurchaseType_MAX = 3,
    }
    public class PurchaseConfirmation : Object
    {
        public PurchaseConfirmation(ulong addr) : base(addr) { }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public PurchaseType Type { get { return (PurchaseType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public enum EFocusLostReason : int
    {
        EFocusLostReason_Invalid = 0,
        EFocusLostReason_System = 1,
        EFocusLostReason_MAX = 2,
    }
    public class MagicLeapMeshBlockRequest : Object
    {
        public MagicLeapMeshBlockRequest(ulong addr) : base(addr) { }
        public Guid BlockID { get { return this[nameof(BlockID)].As<Guid>(); } set { this["BlockID"] = value; } }
        public EMagicLeapMeshLOD LevelOfDetail { get { return (EMagicLeapMeshLOD)this[nameof(LevelOfDetail)].GetValue<int>(); } set { this[nameof(LevelOfDetail)].SetValue<int>((int)value); } }
    }
    public enum EMagicLeapMeshLOD : int
    {
        Minimum = 0,
        Medium = 1,
        Maximum = 2,
        EMagicLeapMeshLOD_MAX = 3,
    }
    public class MagicLeapTrackingMeshInfo : Object
    {
        public MagicLeapTrackingMeshInfo(ulong addr) : base(addr) { }
        public Timespan Timestamp { get { return this[nameof(Timestamp)].As<Timespan>(); } set { this["Timestamp"] = value; } }
        public Array<MagicLeapMeshBlockInfo> BlockData { get { return new Array<MagicLeapMeshBlockInfo>(this[nameof(BlockData)].Address); } }
    }
    public class MagicLeapMeshBlockInfo : Object
    {
        public MagicLeapMeshBlockInfo(ulong addr) : base(addr) { }
        public Guid BlockID { get { return this[nameof(BlockID)].As<Guid>(); } set { this["BlockID"] = value; } }
        public Vector BlockPosition { get { return this[nameof(BlockPosition)].As<Vector>(); } set { this["BlockPosition"] = value; } }
        public Rotator BlockOrientation { get { return this[nameof(BlockOrientation)].As<Rotator>(); } set { this["BlockOrientation"] = value; } }
        public Vector BlockDimensions { get { return this[nameof(BlockDimensions)].As<Vector>(); } set { this["BlockDimensions"] = value; } }
        public Timespan Timestamp { get { return this[nameof(Timestamp)].As<Timespan>(); } set { this["Timestamp"] = value; } }
        public EMagicLeapMeshState BlockState { get { return (EMagicLeapMeshState)this[nameof(BlockState)].GetValue<int>(); } set { this[nameof(BlockState)].SetValue<int>((int)value); } }
    }
    public enum EMagicLeapMeshState : int
    {
        New = 0,
        Updated = 1,
        Deleted = 2,
        Unchanged = 3,
        EMagicLeapMeshState_MAX = 4,
    }
    public enum EMagicLeapMeshVertexColorMode : int
    {
        None = 0,
        Confidence = 1,
        Block = 2,
        LOD = 3,
        EMagicLeapMeshVertexColorMode_MAX = 4,
    }
    public enum EMagicLeapMeshType : int
    {
        Triangles = 0,
        PointCloud = 1,
        EMagicLeapMeshType_MAX = 2,
    }
    public class MagicLeapRaycastHitResult : Object
    {
        public MagicLeapRaycastHitResult(ulong addr) : base(addr) { }
        public EMagicLeapRaycastResultState HitState { get { return (EMagicLeapRaycastResultState)this[nameof(HitState)].GetValue<int>(); } set { this[nameof(HitState)].SetValue<int>((int)value); } }
        public Vector HitPoint { get { return this[nameof(HitPoint)].As<Vector>(); } set { this["HitPoint"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public float Confidence { get { return this[nameof(Confidence)].GetValue<float>(); } set { this[nameof(Confidence)].SetValue<float>(value); } }
        public int UserData { get { return this[nameof(UserData)].GetValue<int>(); } set { this[nameof(UserData)].SetValue<int>(value); } }
    }
    public enum EMagicLeapRaycastResultState : int
    {
        RequestFailed = 0,
        NoCollision = 1,
        HitUnobserved = 2,
        HitObserved = 3,
        EMagicLeapRaycastResultState_MAX = 4,
    }
    public class MagicLeapRaycastQueryParams : Object
    {
        public MagicLeapRaycastQueryParams(ulong addr) : base(addr) { }
        public Vector Position { get { return this[nameof(Position)].As<Vector>(); } set { this["Position"] = value; } }
        public Vector Direction { get { return this[nameof(Direction)].As<Vector>(); } set { this["Direction"] = value; } }
        public Vector UpVector { get { return this[nameof(UpVector)].As<Vector>(); } set { this["UpVector"] = value; } }
        public int Width { get { return this[nameof(Width)].GetValue<int>(); } set { this[nameof(Width)].SetValue<int>(value); } }
        public int Height { get { return this[nameof(Height)].GetValue<int>(); } set { this[nameof(Height)].SetValue<int>(value); } }
        public float HorizontalFovDegrees { get { return this[nameof(HorizontalFovDegrees)].GetValue<float>(); } set { this[nameof(HorizontalFovDegrees)].SetValue<float>(value); } }
        public bool CollideWithUnobserved { get { return this[nameof(CollideWithUnobserved)].Flag; } set { this[nameof(CollideWithUnobserved)].Flag = value; } }
        public int UserData { get { return this[nameof(UserData)].GetValue<int>(); } set { this[nameof(UserData)].SetValue<int>(value); } }
    }
    public enum CloudStatus : int
    {
        CloudStatus_NotDone = 0,
        CloudStatus_Done = 1,
        CloudStatus_MAX = 2,
    }
    public enum EMagicLeapHeadTrackingMapEvent : int
    {
        Lost = 0,
        Recovered = 1,
        RecoveryFailed = 2,
        NewSession = 3,
        EMagicLeapHeadTrackingMapEvent_MAX = 4,
    }
    public enum EMagicLeapHeadTrackingMode : int
    {
        PositionAndOrientation = 0,
        Unavailable = 1,
        Unknown = 2,
        EMagicLeapHeadTrackingMode_MAX = 3,
    }
    public enum EMagicLeapHeadTrackingError : int
    {
        None = 0,
        NotEnoughFeatures = 1,
        LowLight = 2,
        Unknown = 3,
        EMagicLeapHeadTrackingError_MAX = 4,
    }
    public class MagicLeapGraphicsClientPerformanceInfo : Object
    {
        public MagicLeapGraphicsClientPerformanceInfo(ulong addr) : base(addr) { }
        public float FrameStartCPUCompAcquireCPUTimeMs { get { return this[nameof(FrameStartCPUCompAcquireCPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameStartCPUCompAcquireCPUTimeMs)].SetValue<float>(value); } }
        public float FrameStartCPUFrameEndGPUTimeMs { get { return this[nameof(FrameStartCPUFrameEndGPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameStartCPUFrameEndGPUTimeMs)].SetValue<float>(value); } }
        public float FrameStartCPUFrameStartCPUTimeMs { get { return this[nameof(FrameStartCPUFrameStartCPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameStartCPUFrameStartCPUTimeMs)].SetValue<float>(value); } }
        public float FrameDurationCPUTimeMs { get { return this[nameof(FrameDurationCPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameDurationCPUTimeMs)].SetValue<float>(value); } }
        public float FrameDurationGPUTimeMs { get { return this[nameof(FrameDurationGPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameDurationGPUTimeMs)].SetValue<float>(value); } }
        public float FrameInternalDurationCPUTimeMs { get { return this[nameof(FrameInternalDurationCPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameInternalDurationCPUTimeMs)].SetValue<float>(value); } }
        public float FrameInternalDurationGPUTimeMs { get { return this[nameof(FrameInternalDurationGPUTimeMs)].GetValue<float>(); } set { this[nameof(FrameInternalDurationGPUTimeMs)].SetValue<float>(value); } }
    }
    public class MagicLeapHeadTrackingState : Object
    {
        public MagicLeapHeadTrackingState(ulong addr) : base(addr) { }
        public EMagicLeapHeadTrackingMode Mode { get { return (EMagicLeapHeadTrackingMode)this[nameof(Mode)].GetValue<int>(); } set { this[nameof(Mode)].SetValue<int>((int)value); } }
        public EMagicLeapHeadTrackingError Error { get { return (EMagicLeapHeadTrackingError)this[nameof(Error)].GetValue<int>(); } set { this[nameof(Error)].SetValue<int>((int)value); } }
        public float Confidence { get { return this[nameof(Confidence)].GetValue<float>(); } set { this[nameof(Confidence)].SetValue<float>(value); } }
    }
}
