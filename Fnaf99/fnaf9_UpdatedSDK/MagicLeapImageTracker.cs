using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.MagicLeapImageTrackerSDK
{
    public class MagicLeapImageTrackerComponent : SceneComponent
    {
        public MagicLeapImageTrackerComponent(ulong addr) : base(addr) { }
        public Texture2D TargetImageTexture { get { return this[nameof(TargetImageTexture)].As<Texture2D>(); } set { this["TargetImageTexture"] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public float LongerDimension { get { return this[nameof(LongerDimension)].GetValue<float>(); } set { this[nameof(LongerDimension)].SetValue<float>(value); } }
        public bool bIsStationary { get { return this[nameof(bIsStationary)].Flag; } set { this[nameof(bIsStationary)].Flag = value; } }
        public bool bUseUnreliablePose { get { return this[nameof(bUseUnreliablePose)].Flag; } set { this[nameof(bUseUnreliablePose)].Flag = value; } }
        public Object OnSetImageTargetSucceeded { get { return this[nameof(OnSetImageTargetSucceeded)]; } set { this[nameof(OnSetImageTargetSucceeded)] = value; } }
        public Object OnSetImageTargetFailed { get { return this[nameof(OnSetImageTargetFailed)]; } set { this[nameof(OnSetImageTargetFailed)] = value; } }
        public Object OnImageTargetFound { get { return this[nameof(OnImageTargetFound)]; } set { this[nameof(OnImageTargetFound)] = value; } }
        public Object OnImageTargetLost { get { return this[nameof(OnImageTargetLost)]; } set { this[nameof(OnImageTargetLost)] = value; } }
        public Object OnImageTargetUnreliableTracking { get { return this[nameof(OnImageTargetUnreliableTracking)]; } set { this[nameof(OnImageTargetUnreliableTracking)] = value; } }
        public bool SetTargetAsync(Texture2D ImageTarget) { return Invoke<bool>(nameof(SetTargetAsync), ImageTarget); }
        public bool RemoveTargetAsync() { return Invoke<bool>(nameof(RemoveTargetAsync)); }
    }
    public class MagicLeapImageTrackerFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapImageTrackerFunctionLibrary(ulong addr) : base(addr) { }
        public void SetMaxSimultaneousTargets(int MaxSimultaneousTargets) { Invoke(nameof(SetMaxSimultaneousTargets), MaxSimultaneousTargets); }
        public bool IsImageTrackingEnabled() { return Invoke<bool>(nameof(IsImageTrackingEnabled)); }
        public int GetMaxSimultaneousTargets() { return Invoke<int>(nameof(GetMaxSimultaneousTargets)); }
        public void EnableImageTracking(bool bEnable) { Invoke(nameof(EnableImageTracking), bEnable); }
    }
    public class MagicLeapImageTrackerTarget : Object
    {
        public MagicLeapImageTrackerTarget(ulong addr) : base(addr) { }
    }
}
