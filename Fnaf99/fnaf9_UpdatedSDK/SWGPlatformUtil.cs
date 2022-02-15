using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.SWGPlatformUtilSDK
{
    public class SWGPlatformSettings : DeveloperSettings
    {
        public SWGPlatformSettings(ulong addr) : base(addr) { }
        public ESWGPlatform BuildPlatform { get { return (ESWGPlatform)this[nameof(BuildPlatform)].GetValue<int>(); } set { this[nameof(BuildPlatform)].SetValue<int>((int)value); } }
    }
    public class SWGPlatformUtilFunctions : BlueprintFunctionLibrary
    {
        public SWGPlatformUtilFunctions(ulong addr) : base(addr) { }
        public void SwitchOnPlatform(ESWGPlatform Platform) { Invoke(nameof(SwitchOnPlatform), Platform); }
        public void StartActivity(PlayerController PlayerController, Object ActivityId) { Invoke(nameof(StartActivity), PlayerController, ActivityId); }
        public void SetActivityAvailability(PlayerController PlayerController, Object ActivityId, bool bEnabled) { Invoke(nameof(SetActivityAvailability), PlayerController, ActivityId, bEnabled); }
        public void IsInEditorSwitch(ESWGEditor Editor) { Invoke(nameof(IsInEditorSwitch), Editor); }
        public bool IsInEditor() { return Invoke<bool>(nameof(IsInEditor)); }
        public Object GetVersionString() { return Invoke<Object>(nameof(GetVersionString)); }
        public Object GetGPU() { return Invoke<Object>(nameof(GetGPU)); }
        public ESWGPlatform GetBuildPlatform() { return Invoke<ESWGPlatform>(nameof(GetBuildPlatform)); }
        public void EndActivity(PlayerController PlayerController, Object ActivityId, EGameActivityEndType Outcome) { Invoke(nameof(EndActivity), PlayerController, ActivityId, Outcome); }
    }
    public enum ESWGPlatform : int
    {
        Steam = 0,
        Oculus = 1,
        PS4 = 2,
        PS5 = 3,
        Switch = 4,
        ESWGPlatform_MAX = 5,
    }
    public enum ESWGEditor : int
    {
        InEditor = 0,
        NotInEditor = 1,
        ESWGEditor_MAX = 2,
    }
    public enum EGameActivityEndType : int
    {
        Completed = 0,
        Failed = 1,
        Cancelled = 2,
        EGameActivityEndType_MAX = 3,
    }
}
