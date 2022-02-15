using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.MagicLeapEyeTrackerSDK
{
    public class MagicLeapEyeTrackerFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapEyeTrackerFunctionLibrary(ulong addr) : base(addr) { }
        public bool GetEyeBlinkState(MagicLeapEyeBlinkState BlinkState) { return Invoke<bool>(nameof(GetEyeBlinkState), BlinkState); }
        public EMagicLeapEyeTrackingCalibrationStatus GetCalibrationStatus() { return Invoke<EMagicLeapEyeTrackingCalibrationStatus>(nameof(GetCalibrationStatus)); }
    }
    public enum EMagicLeapEyeTrackingCalibrationStatus : int
    {
        None = 0,
        Bad = 1,
        Good = 2,
        EMagicLeapEyeTrackingCalibrationStatus_MAX = 3,
    }
    public enum EMagicLeapEyeTrackingStatus : int
    {
        NotConnected = 0,
        Disabled = 1,
        UserNotPresent = 2,
        UserPresent = 3,
        UserPresentAndWatchingWindow = 4,
        EMagicLeapEyeTrackingStatus_MAX = 5,
    }
    public class MagicLeapEyeBlinkState : Object
    {
        public MagicLeapEyeBlinkState(ulong addr) : base(addr) { }
        public bool LeftEyeBlinked { get { return this[nameof(LeftEyeBlinked)].Flag; } set { this[nameof(LeftEyeBlinked)].Flag = value; } }
        public bool RightEyeBlinked { get { return this[nameof(RightEyeBlinked)].Flag; } set { this[nameof(RightEyeBlinked)].Flag = value; } }
    }
}
