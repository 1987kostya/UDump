using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.InputCoreSDK;
namespace SDK.Script.HeadMountedDisplaySDK
{
    public class VRNotificationsComponent : ActorComponent
    {
        public VRNotificationsComponent(ulong addr) : base(addr) { }
        public Object HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate { get { return this[nameof(HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate)]; } set { this[nameof(HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate)] = value; } }
        public Object HMDTrackingInitializedDelegate { get { return this[nameof(HMDTrackingInitializedDelegate)]; } set { this[nameof(HMDTrackingInitializedDelegate)] = value; } }
        public Object HMDRecenteredDelegate { get { return this[nameof(HMDRecenteredDelegate)]; } set { this[nameof(HMDRecenteredDelegate)] = value; } }
        public Object HMDLostDelegate { get { return this[nameof(HMDLostDelegate)]; } set { this[nameof(HMDLostDelegate)] = value; } }
        public Object HMDReconnectedDelegate { get { return this[nameof(HMDReconnectedDelegate)]; } set { this[nameof(HMDReconnectedDelegate)] = value; } }
        public Object HMDConnectCanceledDelegate { get { return this[nameof(HMDConnectCanceledDelegate)]; } set { this[nameof(HMDConnectCanceledDelegate)] = value; } }
        public Object HMDPutOnHeadDelegate { get { return this[nameof(HMDPutOnHeadDelegate)]; } set { this[nameof(HMDPutOnHeadDelegate)] = value; } }
        public Object HMDRemovedFromHeadDelegate { get { return this[nameof(HMDRemovedFromHeadDelegate)]; } set { this[nameof(HMDRemovedFromHeadDelegate)] = value; } }
        public Object VRControllerRecenteredDelegate { get { return this[nameof(VRControllerRecenteredDelegate)]; } set { this[nameof(VRControllerRecenteredDelegate)] = value; } }
    }
    public class HeadMountedDisplayFunctionLibrary : BlueprintFunctionLibrary
    {
        public HeadMountedDisplayFunctionLibrary(ulong addr) : base(addr) { }
        public void UpdateExternalTrackingHMDPosition(Transform ExternalTrackingTransform) { Invoke(nameof(UpdateExternalTrackingHMDPosition), ExternalTrackingTransform); }
        public void SetWorldToMetersScale(Object WorldContext, float NewScale) { Invoke(nameof(SetWorldToMetersScale), WorldContext, NewScale); }
        public void SetTrackingOrigin(byte Origin) { Invoke(nameof(SetTrackingOrigin), Origin); }
        public void SetSpectatorScreenTexture(Texture InTexture) { Invoke(nameof(SetSpectatorScreenTexture), InTexture); }
        public void SetSpectatorScreenModeTexturePlusEyeLayout(Vector2D EyeRectMin, Vector2D EyeRectMax, Vector2D TextureRectMin, Vector2D TextureRectMax, bool bDrawEyeFirst, bool bClearBlack, bool bUseAlpha) { Invoke(nameof(SetSpectatorScreenModeTexturePlusEyeLayout), EyeRectMin, EyeRectMax, TextureRectMin, TextureRectMax, bDrawEyeFirst, bClearBlack, bUseAlpha); }
        public void SetSpectatorScreenMode(ESpectatorScreenMode Mode) { Invoke(nameof(SetSpectatorScreenMode), Mode); }
        public void SetClippingPlanes(float Near, float Far) { Invoke(nameof(SetClippingPlanes), Near, Far); }
        public void ResetOrientationAndPosition(float Yaw, byte Options) { Invoke(nameof(ResetOrientationAndPosition), Yaw, Options); }
        public bool IsSpectatorScreenModeControllable() { return Invoke<bool>(nameof(IsSpectatorScreenModeControllable)); }
        public bool IsInLowPersistenceMode() { return Invoke<bool>(nameof(IsInLowPersistenceMode)); }
        public bool IsHeadMountedDisplayEnabled() { return Invoke<bool>(nameof(IsHeadMountedDisplayEnabled)); }
        public bool IsHeadMountedDisplayConnected() { return Invoke<bool>(nameof(IsHeadMountedDisplayConnected)); }
        public bool IsDeviceTracking(XRDeviceId XRDeviceId) { return Invoke<bool>(nameof(IsDeviceTracking), XRDeviceId); }
        public bool HasValidTrackingPosition() { return Invoke<bool>(nameof(HasValidTrackingPosition)); }
        public float GetWorldToMetersScale(Object WorldContext) { return Invoke<float>(nameof(GetWorldToMetersScale), WorldContext); }
        public void GetVRFocusState(bool bUseFocus, bool bHasFocus) { Invoke(nameof(GetVRFocusState), bUseFocus, bHasFocus); }
        public Transform GetTrackingToWorldTransform(Object WorldContext) { return Invoke<Transform>(nameof(GetTrackingToWorldTransform), WorldContext); }
        public void GetTrackingSensorParameters(Vector Origin, Rotator Rotation, float LeftFOV, float RightFOV, float TopFOV, float BottomFOV, float Distance, float NearPlane, float FarPlane, bool IsActive, int Index) { Invoke(nameof(GetTrackingSensorParameters), Origin, Rotation, LeftFOV, RightFOV, TopFOV, BottomFOV, Distance, NearPlane, FarPlane, IsActive, Index); }
        public byte GetTrackingOrigin() { return Invoke<byte>(nameof(GetTrackingOrigin)); }
        public float GetScreenPercentage() { return Invoke<float>(nameof(GetScreenPercentage)); }
        public void GetPositionalTrackingCameraParameters(Vector CameraOrigin, Rotator CameraRotation, float HFOV, float VFOV, float CameraDistance, float NearPlane, float FarPlane) { Invoke(nameof(GetPositionalTrackingCameraParameters), CameraOrigin, CameraRotation, HFOV, VFOV, CameraDistance, NearPlane, FarPlane); }
        public float GetPixelDensity() { return Invoke<float>(nameof(GetPixelDensity)); }
        public void GetOrientationAndPosition(Rotator DeviceRotation, Vector DevicePosition) { Invoke(nameof(GetOrientationAndPosition), DeviceRotation, DevicePosition); }
        public int GetNumOfTrackingSensors() { return Invoke<int>(nameof(GetNumOfTrackingSensors)); }
        public byte GetHMDWornState() { return Invoke<byte>(nameof(GetHMDWornState)); }
        public Object GetHMDDeviceName() { return Invoke<Object>(nameof(GetHMDDeviceName)); }
        public void GetDeviceWorldPose(Object WorldContext, XRDeviceId XRDeviceId, bool bIsTracked, Rotator Orientation, bool bHasPositionalTracking, Vector Position) { Invoke(nameof(GetDeviceWorldPose), WorldContext, XRDeviceId, bIsTracked, Orientation, bHasPositionalTracking, Position); }
        public void GetDevicePose(XRDeviceId XRDeviceId, bool bIsTracked, Rotator Orientation, bool bHasPositionalTracking, Vector Position) { Invoke(nameof(GetDevicePose), XRDeviceId, bIsTracked, Orientation, bHasPositionalTracking, Position); }
        public Array<XRDeviceId> EnumerateTrackedDevices(Object SystemId, EXRTrackedDeviceType DeviceType) { return Invoke<Array<XRDeviceId>>(nameof(EnumerateTrackedDevices), SystemId, DeviceType); }
        public void EnableLowPersistenceMode(bool bEnable) { Invoke(nameof(EnableLowPersistenceMode), bEnable); }
        public bool EnableHMD(bool bEnable) { return Invoke<bool>(nameof(EnableHMD), bEnable); }
        public void CalibrateExternalTrackingToHMD(Transform ExternalTrackingTransform) { Invoke(nameof(CalibrateExternalTrackingToHMD), ExternalTrackingTransform); }
    }
    public class MotionControllerComponent : PrimitiveComponent
    {
        public MotionControllerComponent(ulong addr) : base(addr) { }
        public int PlayerIndex { get { return this[nameof(PlayerIndex)].GetValue<int>(); } set { this[nameof(PlayerIndex)].SetValue<int>(value); } }
        public EControllerHand Hand { get { return (EControllerHand)this[nameof(Hand)].GetValue<int>(); } set { this[nameof(Hand)].SetValue<int>((int)value); } }
        public Object MotionSource { get { return this[nameof(MotionSource)]; } set { this[nameof(MotionSource)] = value; } }
        public bool bDisableLowLatencyUpdate { get { return this[nameof(bDisableLowLatencyUpdate)].Flag; } set { this[nameof(bDisableLowLatencyUpdate)].Flag = value; } }
        public ETrackingStatus CurrentTrackingStatus { get { return (ETrackingStatus)this[nameof(CurrentTrackingStatus)].GetValue<int>(); } set { this[nameof(CurrentTrackingStatus)].SetValue<int>((int)value); } }
        public bool bDisplayDeviceModel { get { return this[nameof(bDisplayDeviceModel)].Flag; } set { this[nameof(bDisplayDeviceModel)].Flag = value; } }
        public Object DisplayModelSource { get { return this[nameof(DisplayModelSource)]; } set { this[nameof(DisplayModelSource)] = value; } }
        public StaticMesh CustomDisplayMesh { get { return this[nameof(CustomDisplayMesh)].As<StaticMesh>(); } set { this["CustomDisplayMesh"] = value; } }
        public Array<MaterialInterface> DisplayMeshMaterialOverrides { get { return new Array<MaterialInterface>(this[nameof(DisplayMeshMaterialOverrides)].Address); } }
        public PrimitiveComponent DisplayComponent { get { return this[nameof(DisplayComponent)].As<PrimitiveComponent>(); } set { this["DisplayComponent"] = value; } }
        public void SetTrackingSource(EControllerHand NewSource) { Invoke(nameof(SetTrackingSource), NewSource); }
        public void SetTrackingMotionSource(Object NewSource) { Invoke(nameof(SetTrackingMotionSource), NewSource); }
        public void SetShowDeviceModel(bool bShowControllerModel) { Invoke(nameof(SetShowDeviceModel), bShowControllerModel); }
        public void SetDisplayModelSource(Object NewDisplayModelSource) { Invoke(nameof(SetDisplayModelSource), NewDisplayModelSource); }
        public void SetCustomDisplayMesh(StaticMesh NewDisplayMesh) { Invoke(nameof(SetCustomDisplayMesh), NewDisplayMesh); }
        public void SetAssociatedPlayerIndex(int NewPlayer) { Invoke(nameof(SetAssociatedPlayerIndex), NewPlayer); }
        public void OnMotionControllerUpdated() { Invoke(nameof(OnMotionControllerUpdated)); }
        public bool IsTracked() { return Invoke<bool>(nameof(IsTracked)); }
        public EControllerHand GetTrackingSource() { return Invoke<EControllerHand>(nameof(GetTrackingSource)); }
        public float GetParameterValue(Object InName, bool bValueFound) { return Invoke<float>(nameof(GetParameterValue), InName, bValueFound); }
        public Vector GetHandJointPosition(int jointIndex, bool bValueFound) { return Invoke<Vector>(nameof(GetHandJointPosition), jointIndex, bValueFound); }
    }
    public class MotionTrackedDeviceFunctionLibrary : BlueprintFunctionLibrary
    {
        public MotionTrackedDeviceFunctionLibrary(ulong addr) : base(addr) { }
        public void SetIsControllerMotionTrackingEnabledByDefault(bool enable) { Invoke(nameof(SetIsControllerMotionTrackingEnabledByDefault), enable); }
        public bool IsMotionTrackingEnabledForSource(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForSource), PlayerIndex, SourceName); }
        public bool IsMotionTrackingEnabledForDevice(int PlayerIndex, EControllerHand Hand) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForDevice), PlayerIndex, Hand); }
        public bool IsMotionTrackingEnabledForComponent(MotionControllerComponent MotionControllerComponent) { return Invoke<bool>(nameof(IsMotionTrackingEnabledForComponent), MotionControllerComponent); }
        public bool IsMotionTrackedDeviceCountManagementNecessary() { return Invoke<bool>(nameof(IsMotionTrackedDeviceCountManagementNecessary)); }
        public bool IsMotionSourceTracking(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(IsMotionSourceTracking), PlayerIndex, SourceName); }
        public int GetMotionTrackingEnabledControllerCount() { return Invoke<int>(nameof(GetMotionTrackingEnabledControllerCount)); }
        public int GetMaximumMotionTrackedControllerCount() { return Invoke<int>(nameof(GetMaximumMotionTrackedControllerCount)); }
        public Object GetActiveTrackingSystemName() { return Invoke<Object>(nameof(GetActiveTrackingSystemName)); }
        public Array<Object> EnumerateMotionSources() { return Invoke<Array<Object>>(nameof(EnumerateMotionSources)); }
        public bool EnableMotionTrackingOfSource(int PlayerIndex, Object SourceName) { return Invoke<bool>(nameof(EnableMotionTrackingOfSource), PlayerIndex, SourceName); }
        public bool EnableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand) { return Invoke<bool>(nameof(EnableMotionTrackingOfDevice), PlayerIndex, Hand); }
        public bool EnableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent) { return Invoke<bool>(nameof(EnableMotionTrackingForComponent), MotionControllerComponent); }
        public void DisableMotionTrackingOfSource(int PlayerIndex, Object SourceName) { Invoke(nameof(DisableMotionTrackingOfSource), PlayerIndex, SourceName); }
        public void DisableMotionTrackingOfDevice(int PlayerIndex, EControllerHand Hand) { Invoke(nameof(DisableMotionTrackingOfDevice), PlayerIndex, Hand); }
        public void DisableMotionTrackingOfControllersForPlayer(int PlayerIndex) { Invoke(nameof(DisableMotionTrackingOfControllersForPlayer), PlayerIndex); }
        public void DisableMotionTrackingOfAllControllers() { Invoke(nameof(DisableMotionTrackingOfAllControllers)); }
        public void DisableMotionTrackingForComponent(MotionControllerComponent MotionControllerComponent) { Invoke(nameof(DisableMotionTrackingForComponent), MotionControllerComponent); }
    }
    public class XRAssetFunctionLibrary : BlueprintFunctionLibrary
    {
        public XRAssetFunctionLibrary(ulong addr) : base(addr) { }
        public PrimitiveComponent AddNamedDeviceVisualizationComponentBlocking(Actor Target, Object SystemName, Object DeviceName, bool bManualAttachment, Transform RelativeTransform, XRDeviceId XRDeviceId) { return Invoke<PrimitiveComponent>(nameof(AddNamedDeviceVisualizationComponentBlocking), Target, SystemName, DeviceName, bManualAttachment, RelativeTransform, XRDeviceId); }
        public PrimitiveComponent AddDeviceVisualizationComponentBlocking(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform) { return Invoke<PrimitiveComponent>(nameof(AddDeviceVisualizationComponentBlocking), Target, XRDeviceId, bManualAttachment, RelativeTransform); }
    }
    public class AsyncTask_LoadXRDeviceVisComponent : BlueprintAsyncActionBase
    {
        public AsyncTask_LoadXRDeviceVisComponent(ulong addr) : base(addr) { }
        public Object OnModelLoaded { get { return this[nameof(OnModelLoaded)]; } set { this[nameof(OnModelLoaded)] = value; } }
        public Object OnLoadFailure { get { return this[nameof(OnLoadFailure)]; } set { this[nameof(OnLoadFailure)] = value; } }
        public PrimitiveComponent SpawnedComponent { get { return this[nameof(SpawnedComponent)].As<PrimitiveComponent>(); } set { this["SpawnedComponent"] = value; } }
        public AsyncTask_LoadXRDeviceVisComponent AddNamedDeviceVisualizationComponentAsync(Actor Target, Object SystemName, Object DeviceName, bool bManualAttachment, Transform RelativeTransform, XRDeviceId XRDeviceId, PrimitiveComponent NewComponent) { return Invoke<AsyncTask_LoadXRDeviceVisComponent>(nameof(AddNamedDeviceVisualizationComponentAsync), Target, SystemName, DeviceName, bManualAttachment, RelativeTransform, XRDeviceId, NewComponent); }
        public AsyncTask_LoadXRDeviceVisComponent AddDeviceVisualizationComponentAsync(Actor Target, XRDeviceId XRDeviceId, bool bManualAttachment, Transform RelativeTransform, PrimitiveComponent NewComponent) { return Invoke<AsyncTask_LoadXRDeviceVisComponent>(nameof(AddDeviceVisualizationComponentAsync), Target, XRDeviceId, bManualAttachment, RelativeTransform, NewComponent); }
    }
    public class XRLoadingScreenFunctionLibrary : BlueprintFunctionLibrary
    {
        public XRLoadingScreenFunctionLibrary(ulong addr) : base(addr) { }
        public void ShowLoadingScreen() { Invoke(nameof(ShowLoadingScreen)); }
        public void SetLoadingScreen(Texture Texture, Vector2D Scale, Vector Offset, bool bShowLoadingMovie, bool bShowOnSet) { Invoke(nameof(SetLoadingScreen), Texture, Scale, Offset, bShowLoadingMovie, bShowOnSet); }
        public void HideLoadingScreen() { Invoke(nameof(HideLoadingScreen)); }
        public void ClearLoadingScreenSplashes() { Invoke(nameof(ClearLoadingScreenSplashes)); }
        public void AddLoadingScreenSplash(Texture Texture, Vector Translation, Rotator Rotation, Vector2D Size, Rotator DeltaRotation, bool bClearBeforeAdd) { Invoke(nameof(AddLoadingScreenSplash), Texture, Translation, Rotation, Size, DeltaRotation, bClearBeforeAdd); }
    }
    public enum EXRTrackedDeviceType : int
    {
        HeadMountedDisplay = 0,
        Controller = 1,
        TrackingReference = 2,
        Other = 3,
        Invalid = 254,
        Any = 255,
        EXRTrackedDeviceType_MAX = 256,
    }
    public enum ESpectatorScreenMode : int
    {
        Disabled = 0,
        SingleEyeLetterboxed = 1,
        Undistorted = 2,
        Distorted = 3,
        SingleEye = 4,
        SingleEyeCroppedToFill = 5,
        Texture = 6,
        TexturePlusEye = 7,
        ESpectatorScreenMode_MAX = 8,
    }
    public enum EHMDWornState : int
    {
        Unknown = 0,
        Worn = 1,
        NotWorn = 2,
        EHMDWornState_MAX = 3,
    }
    public enum EHMDTrackingOrigin : int
    {
        Floor = 0,
        Eye = 1,
        Stage = 2,
        EHMDTrackingOrigin_MAX = 3,
    }
    public enum EOrientPositionSelector : int
    {
        Orientation = 0,
        Position = 1,
        OrientationAndPosition = 2,
        EOrientPositionSelector_MAX = 3,
    }
    public enum ETrackingStatus : int
    {
        NotTracked = 0,
        InertialOnly = 1,
        Tracked = 2,
        ETrackingStatus_MAX = 3,
    }
    public class XRDeviceId : Object
    {
        public XRDeviceId(ulong addr) : base(addr) { }
        public Object SystemName { get { return this[nameof(SystemName)]; } set { this[nameof(SystemName)] = value; } }
        public int DeviceID { get { return this[nameof(DeviceID)].GetValue<int>(); } set { this[nameof(DeviceID)].SetValue<int>(value); } }
    }
}
