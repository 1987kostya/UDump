using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapLightEstimationSDK
{
    public class MagicLeapLightingTrackingComponent : ActorComponent
    {
        public MagicLeapLightingTrackingComponent(ulong addr) : base(addr) { }
        public bool UseGlobalAmbience { get { return this[nameof(UseGlobalAmbience)].Flag; } set { this[nameof(UseGlobalAmbience)].Flag = value; } }
        public bool UseColorTemp { get { return this[nameof(UseColorTemp)].Flag; } set { this[nameof(UseColorTemp)].Flag = value; } }
    }
    public class MagicLeapLightEstimationFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapLightEstimationFunctionLibrary(ulong addr) : base(addr) { }
        public bool IsTrackerValid() { return Invoke<bool>(nameof(IsTrackerValid)); }
        public bool GetColorTemperatureState(MagicLeapLightEstimationColorTemperatureState ColorTemperatureState) { return Invoke<bool>(nameof(GetColorTemperatureState), ColorTemperatureState); }
        public bool GetAmbientGlobalState(MagicLeapLightEstimationAmbientGlobalState GlobalAmbientState) { return Invoke<bool>(nameof(GetAmbientGlobalState), GlobalAmbientState); }
        public void DestroyTracker() { Invoke(nameof(DestroyTracker)); }
        public bool CreateTracker() { return Invoke<bool>(nameof(CreateTracker)); }
    }
    public enum EMagicLeapLightEstimationCamera : int
    {
        Left = 0,
        Right = 1,
        FarLeft = 2,
        FarRight = 3,
        EMagicLeapLightEstimationCamera_MAX = 4,
    }
    public class MagicLeapLightEstimationColorTemperatureState : Object
    {
        public MagicLeapLightEstimationColorTemperatureState(ulong addr) : base(addr) { }
        public float ColorTemperatureKelvin { get { return this[nameof(ColorTemperatureKelvin)].GetValue<float>(); } set { this[nameof(ColorTemperatureKelvin)].SetValue<float>(value); } }
        public LinearColor AmbientColor { get { return this[nameof(AmbientColor)].As<LinearColor>(); } set { this["AmbientColor"] = value; } }
        public Timespan Timestamp { get { return this[nameof(Timestamp)].As<Timespan>(); } set { this["Timestamp"] = value; } }
    }
    public class MagicLeapLightEstimationAmbientGlobalState : Object
    {
        public MagicLeapLightEstimationAmbientGlobalState(ulong addr) : base(addr) { }
        public Array<float> AmbientIntensityNits { get { return new Array<float>(this[nameof(AmbientIntensityNits)].Address); } }
        public Timespan Timestamp { get { return this[nameof(Timestamp)].As<Timespan>(); } set { this["Timestamp"] = value; } }
    }
}
