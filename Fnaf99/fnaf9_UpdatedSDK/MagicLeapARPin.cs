using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapARPinSDK
{
    public class MagicLeapARPinComponent : SceneComponent
    {
        public MagicLeapARPinComponent(ulong addr) : base(addr) { }
        public Object ObjectUID { get { return this[nameof(ObjectUID)]; } set { this[nameof(ObjectUID)] = value; } }
        public int UserIndex { get { return this[nameof(UserIndex)].GetValue<int>(); } set { this[nameof(UserIndex)].SetValue<int>(value); } }
        public EMagicLeapAutoPinType AutoPinType { get { return (EMagicLeapAutoPinType)this[nameof(AutoPinType)].GetValue<int>(); } set { this[nameof(AutoPinType)].SetValue<int>((int)value); } }
        public bool bShouldPinActor { get { return this[nameof(bShouldPinActor)].Flag; } set { this[nameof(bShouldPinActor)].Flag = value; } }
        public Object PinDataClass { get { return this[nameof(PinDataClass)]; } set { this[nameof(PinDataClass)] = value; } }
        public Object OnPersistentEntityPinned { get { return this[nameof(OnPersistentEntityPinned)]; } set { this[nameof(OnPersistentEntityPinned)] = value; } }
        public Object OnPersistentEntityPinLost { get { return this[nameof(OnPersistentEntityPinLost)]; } set { this[nameof(OnPersistentEntityPinLost)] = value; } }
        public Guid PinnedCFUID { get { return this[nameof(PinnedCFUID)].As<Guid>(); } set { this["PinnedCFUID"] = value; } }
        public SceneComponent PinnedSceneComponent { get { return this[nameof(PinnedSceneComponent)].As<SceneComponent>(); } set { this["PinnedSceneComponent"] = value; } }
        public MagicLeapARPinSaveGame PinData { get { return this[nameof(PinData)].As<MagicLeapARPinSaveGame>(); } set { this["PinData"] = value; } }
        public void UnPin() { Invoke(nameof(UnPin)); }
        public bool PinSceneComponent(SceneComponent ComponentToPin) { return Invoke<bool>(nameof(PinSceneComponent), ComponentToPin); }
        public bool PinRestoredOrSynced() { return Invoke<bool>(nameof(PinRestoredOrSynced)); }
        public bool PinActor(Actor ActorToPin) { return Invoke<bool>(nameof(PinActor), ActorToPin); }
        public void PersistentEntityPinned__DelegateSignature(bool bRestoredOrSynced) { Invoke(nameof(PersistentEntityPinned__DelegateSignature), bRestoredOrSynced); }
        public void PersistentEntityPinLost__DelegateSignature() { Invoke(nameof(PersistentEntityPinLost__DelegateSignature)); }
        public bool IsPinned() { return Invoke<bool>(nameof(IsPinned)); }
        public bool GetPinState(MagicLeapARPinState State) { return Invoke<bool>(nameof(GetPinState), State); }
        public bool GetPinnedPinID(Guid PinID) { return Invoke<bool>(nameof(GetPinnedPinID), PinID); }
        public MagicLeapARPinSaveGame GetPinData(Object PinDataClass) { return Invoke<MagicLeapARPinSaveGame>(nameof(GetPinData), PinDataClass); }
    }
    public class MagicLeapARPinFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapARPinFunctionLibrary(ulong addr) : base(addr) { }
        public void UnBindToOnMagicLeapARPinUpdatedDelegate(Object Delegate) { Invoke(nameof(UnBindToOnMagicLeapARPinUpdatedDelegate), Delegate); }
        public bool IsTrackerValid() { return Invoke<bool>(nameof(IsTrackerValid)); }
        public EMagicLeapPassableWorldError GetNumAvailableARPins(int Count) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetNumAvailableARPins), Count); }
        public EMagicLeapPassableWorldError GetClosestARPin(Vector SearchPoint, Guid PinID) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetClosestARPin), SearchPoint, PinID); }
        public EMagicLeapPassableWorldError GetAvailableARPins(int NumRequested, Array<Guid> Pins) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetAvailableARPins), NumRequested, Pins); }
        public Object GetARPinStateToString(MagicLeapARPinState State) { return Invoke<Object>(nameof(GetARPinStateToString), State); }
        public EMagicLeapPassableWorldError GetARPinState(Guid PinID, MagicLeapARPinState State) { return Invoke<EMagicLeapPassableWorldError>(nameof(GetARPinState), PinID, State); }
        public bool GetARPinPositionAndOrientation_TrackingSpace(Guid PinID, Vector Position, Rotator Orientation, bool PinFoundInEnvironment) { return Invoke<bool>(nameof(GetARPinPositionAndOrientation_TrackingSpace), PinID, Position, Orientation, PinFoundInEnvironment); }
        public bool GetARPinPositionAndOrientation(Guid PinID, Vector Position, Rotator Orientation, bool PinFoundInEnvironment) { return Invoke<bool>(nameof(GetARPinPositionAndOrientation), PinID, Position, Orientation, PinFoundInEnvironment); }
        public EMagicLeapPassableWorldError DestroyTracker() { return Invoke<EMagicLeapPassableWorldError>(nameof(DestroyTracker)); }
        public EMagicLeapPassableWorldError CreateTracker() { return Invoke<EMagicLeapPassableWorldError>(nameof(CreateTracker)); }
        public void BindToOnMagicLeapARPinUpdatedDelegate(Object Delegate) { Invoke(nameof(BindToOnMagicLeapARPinUpdatedDelegate), Delegate); }
    }
    public class MagicLeapARPinSettings : Object
    {
        public MagicLeapARPinSettings(ulong addr) : base(addr) { }
        public float UpdateCheckFrequency { get { return this[nameof(UpdateCheckFrequency)].GetValue<float>(); } set { this[nameof(UpdateCheckFrequency)].SetValue<float>(value); } }
        public MagicLeapARPinState OnUpdatedEventTriggerDelta { get { return this[nameof(OnUpdatedEventTriggerDelta)].As<MagicLeapARPinState>(); } set { this["OnUpdatedEventTriggerDelta"] = value; } }
    }
    public class MagicLeapARPinSaveGame : SaveGame
    {
        public MagicLeapARPinSaveGame(ulong addr) : base(addr) { }
        public Guid PinnedID { get { return this[nameof(PinnedID)].As<Guid>(); } set { this["PinnedID"] = value; } }
        public Transform ComponentWorldTransform { get { return this[nameof(ComponentWorldTransform)].As<Transform>(); } set { this["ComponentWorldTransform"] = value; } }
        public Transform PinTransform { get { return this[nameof(PinTransform)].As<Transform>(); } set { this["PinTransform"] = value; } }
    }
    public class MagicLeapARPinState : Object
    {
        public MagicLeapARPinState(ulong addr) : base(addr) { }
        public float Confidence { get { return this[nameof(Confidence)].GetValue<float>(); } set { this[nameof(Confidence)].SetValue<float>(value); } }
        public float ValidRadius { get { return this[nameof(ValidRadius)].GetValue<float>(); } set { this[nameof(ValidRadius)].SetValue<float>(value); } }
        public float RotationError { get { return this[nameof(RotationError)].GetValue<float>(); } set { this[nameof(RotationError)].SetValue<float>(value); } }
        public float TranslationError { get { return this[nameof(TranslationError)].GetValue<float>(); } set { this[nameof(TranslationError)].SetValue<float>(value); } }
    }
    public enum EMagicLeapAutoPinType : int
    {
        OnlyOnDataRestoration = 0,
        Always = 1,
        Never = 2,
        EMagicLeapAutoPinType_MAX = 3,
    }
    public enum EMagicLeapPassableWorldError : int
    {
        None = 0,
        LowMapQuality = 1,
        UnableToLocalize = 2,
        Unavailable = 3,
        PrivilegeDenied = 4,
        InvalidParam = 5,
        UnspecifiedFailure = 6,
        PrivilegeRequestPending = 7,
        StartupPending = 8,
        NotImplemented = 9,
        PinNotFound = 10,
        EMagicLeapPassableWorldError_MAX = 11,
    }
}
