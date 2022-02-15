using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.RTXGISDK
{
    public class DDGIBlueprintLibrary : BlueprintFunctionLibrary
    {
        public DDGIBlueprintLibrary(ulong addr) : base(addr) { }
        public void ClearProbeData(DDGIVolumeComponent DDGIVolumeComponent) { Invoke(nameof(ClearProbeData), DDGIVolumeComponent); }
    }
    public class DDGIVolume : Actor
    {
        public DDGIVolume(ulong addr) : base(addr) { }
        public BoxComponent BoxComponent { get { return this[nameof(BoxComponent)].As<BoxComponent>(); } set { this["BoxComponent"] = value; } }
        public DDGIVolumeComponent DDGIVolumeComponent { get { return this[nameof(DDGIVolumeComponent)].As<DDGIVolumeComponent>(); } set { this["DDGIVolumeComponent"] = value; } }
    }
    public class DDGIVolumeComponent : SceneComponent
    {
        public DDGIVolumeComponent(ulong addr) : base(addr) { }
        public EDDGIRaysPerProbe RaysPerProbe { get { return (EDDGIRaysPerProbe)this[nameof(RaysPerProbe)].GetValue<int>(); } set { this[nameof(RaysPerProbe)].SetValue<int>((int)value); } }
        public IntVector ProbeCounts { get { return this[nameof(ProbeCounts)].As<IntVector>(); } set { this["ProbeCounts"] = value; } }
        public float UpdatePriority { get { return this[nameof(UpdatePriority)].GetValue<float>(); } set { this[nameof(UpdatePriority)].SetValue<float>(value); } }
        public float ProbeMaxRayDistance { get { return this[nameof(ProbeMaxRayDistance)].GetValue<float>(); } set { this[nameof(ProbeMaxRayDistance)].SetValue<float>(value); } }
        public float ProbeHysteresis { get { return this[nameof(ProbeHysteresis)].GetValue<float>(); } set { this[nameof(ProbeHysteresis)].SetValue<float>(value); } }
        public float ViewBias { get { return this[nameof(ViewBias)].GetValue<float>(); } set { this[nameof(ViewBias)].SetValue<float>(value); } }
        public float NormalBias { get { return this[nameof(NormalBias)].GetValue<float>(); } set { this[nameof(NormalBias)].SetValue<float>(value); } }
        public LightingChannels LightingChannels { get { return this[nameof(LightingChannels)].As<LightingChannels>(); } set { this["LightingChannels"] = value; } }
        public float VolumeBlendDistance { get { return this[nameof(VolumeBlendDistance)].GetValue<float>(); } set { this[nameof(VolumeBlendDistance)].SetValue<float>(value); } }
        public float VolumeBlendDistanceBlack { get { return this[nameof(VolumeBlendDistanceBlack)].GetValue<float>(); } set { this[nameof(VolumeBlendDistanceBlack)].SetValue<float>(value); } }
        public bool EnableProbeRelocation { get { return this[nameof(EnableProbeRelocation)].Flag; } set { this[nameof(EnableProbeRelocation)].Flag = value; } }
        public bool EnableProbeScrolling { get { return this[nameof(EnableProbeScrolling)].Flag; } set { this[nameof(EnableProbeScrolling)].Flag = value; } }
        public bool RuntimeStatic { get { return this[nameof(RuntimeStatic)].Flag; } set { this[nameof(RuntimeStatic)].Flag = value; } }
        public float probeDistanceExponent { get { return this[nameof(probeDistanceExponent)].GetValue<float>(); } set { this[nameof(probeDistanceExponent)].SetValue<float>(value); } }
        public float probeIrradianceEncodingGamma { get { return this[nameof(probeIrradianceEncodingGamma)].GetValue<float>(); } set { this[nameof(probeIrradianceEncodingGamma)].SetValue<float>(value); } }
        public float probeChangeThreshold { get { return this[nameof(probeChangeThreshold)].GetValue<float>(); } set { this[nameof(probeChangeThreshold)].SetValue<float>(value); } }
        public float probeBrightnessThreshold { get { return this[nameof(probeBrightnessThreshold)].GetValue<float>(); } set { this[nameof(probeBrightnessThreshold)].SetValue<float>(value); } }
        public float ProbeMinFrontfaceDistance { get { return this[nameof(ProbeMinFrontfaceDistance)].GetValue<float>(); } set { this[nameof(ProbeMinFrontfaceDistance)].SetValue<float>(value); } }
        public float ProbeBackfaceThreshold { get { return this[nameof(ProbeBackfaceThreshold)].GetValue<float>(); } set { this[nameof(ProbeBackfaceThreshold)].SetValue<float>(value); } }
        public float LightMultiplier { get { return this[nameof(LightMultiplier)].GetValue<float>(); } set { this[nameof(LightMultiplier)].SetValue<float>(value); } }
        public float EmissiveMultiplier { get { return this[nameof(EmissiveMultiplier)].GetValue<float>(); } set { this[nameof(EmissiveMultiplier)].SetValue<float>(value); } }
        public float IrradianceScalar { get { return this[nameof(IrradianceScalar)].GetValue<float>(); } set { this[nameof(IrradianceScalar)].SetValue<float>(value); } }
        public Vector LastOrigin { get { return this[nameof(LastOrigin)].As<Vector>(); } set { this["LastOrigin"] = value; } }
        public IntVector ProbeScrollOffset { get { return this[nameof(ProbeScrollOffset)].As<IntVector>(); } set { this["ProbeScrollOffset"] = value; } }
        public void DDGIClearVolumes() { Invoke(nameof(DDGIClearVolumes)); }
    }
    public class RTXGIPluginSettings : DeveloperSettings
    {
        public RTXGIPluginSettings(ulong addr) : base(addr) { }
        public EDDGIIrradianceBits IrradianceBits { get { return (EDDGIIrradianceBits)this[nameof(IrradianceBits)].GetValue<int>(); } set { this[nameof(IrradianceBits)].SetValue<int>((int)value); } }
        public EDDGIDistanceBits DistanceBits { get { return (EDDGIDistanceBits)this[nameof(DistanceBits)].GetValue<int>(); } set { this[nameof(DistanceBits)].SetValue<int>((int)value); } }
        public float DebugProbeRadius { get { return this[nameof(DebugProbeRadius)].GetValue<float>(); } set { this[nameof(DebugProbeRadius)].SetValue<float>(value); } }
        public int ProbeUpdateRayBudget { get { return this[nameof(ProbeUpdateRayBudget)].GetValue<int>(); } set { this[nameof(ProbeUpdateRayBudget)].SetValue<int>(value); } }
    }
    public enum EDDGIRaysPerProbe : int
    {
        n144 = 0,
        n288 = 1,
        n432 = 2,
        n576 = 3,
        n720 = 4,
        n864 = 5,
        n1008 = 6,
        Count = 7,
        EDDGIRaysPerProbe_MAX = 8,
    }
    public enum EDDGIDistanceBits : int
    {
        n16 = 0,
        n32 = 1,
        EDDGIDistanceBits_MAX = 2,
    }
    public enum EDDGIIrradianceBits : int
    {
        n10 = 0,
        n32 = 1,
        EDDGIIrradianceBits_MAX = 2,
    }
}
