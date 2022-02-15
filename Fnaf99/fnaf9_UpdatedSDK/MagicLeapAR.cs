using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.AugmentedRealitySDK;
using SDK.Script.MagicLeapPlanesSDK;
namespace SDK.Script.MagicLeapARSDK
{
    public class LuminARSessionFunctionLibrary : BlueprintFunctionLibrary
    {
        public LuminARSessionFunctionLibrary(ulong addr) : base(addr) { }
        public void StartLuminARSession(Object WorldContextObject, LatentActionInfo LatentInfo, LuminARSessionConfig Configuration) { Invoke(nameof(StartLuminARSession), WorldContextObject, LatentInfo, Configuration); }
    }
    public class LuminARFrameFunctionLibrary : BlueprintFunctionLibrary
    {
        public LuminARFrameFunctionLibrary(ulong addr) : base(addr) { }
        public bool LuminARLineTrace(Object WorldContextObject, Vector2D ScreenPosition, Object TraceChannels, Array<ARTraceResult> OutHitResults) { return Invoke<bool>(nameof(LuminARLineTrace), WorldContextObject, ScreenPosition, TraceChannels, OutHitResults); }
        public ELuminARTrackingState GetTrackingState() { return Invoke<ELuminARTrackingState>(nameof(GetTrackingState)); }
    }
    public class LuminARImageTrackingFunctionLibrary : BlueprintFunctionLibrary
    {
        public LuminARImageTrackingFunctionLibrary(ulong addr) : base(addr) { }
        public LuminARCandidateImage AddLuminRuntimeCandidateImage(ARSessionConfig SessionConfig, Texture2D CandidateTexture, Object FriendlyName, float PhysicalWidth, bool bUseUnreliablePose, bool bImageIsStationary) { return Invoke<LuminARCandidateImage>(nameof(AddLuminRuntimeCandidateImage), SessionConfig, CandidateTexture, FriendlyName, PhysicalWidth, bUseUnreliablePose, bImageIsStationary); }
    }
    public class LuminARSessionConfig : ARSessionConfig
    {
        public LuminARSessionConfig(ulong addr) : base(addr) { }
        public MagicLeapPlanesQuery PlanesQuery { get { return this[nameof(PlanesQuery)].As<MagicLeapPlanesQuery>(); } set { this["PlanesQuery"] = value; } }
        public int MaxPlaneQueryResults { get { return this[nameof(MaxPlaneQueryResults)].GetValue<int>(); } set { this[nameof(MaxPlaneQueryResults)].SetValue<int>(value); } }
        public int MinPlaneArea { get { return this[nameof(MinPlaneArea)].GetValue<int>(); } set { this[nameof(MinPlaneArea)].SetValue<int>(value); } }
        public bool bArbitraryOrientationPlaneDetection { get { return this[nameof(bArbitraryOrientationPlaneDetection)].Flag; } set { this[nameof(bArbitraryOrientationPlaneDetection)].Flag = value; } }
        public Vector PlaneSearchExtents { get { return this[nameof(PlaneSearchExtents)].As<Vector>(); } set { this["PlaneSearchExtents"] = value; } }
        public Array<EMagicLeapPlaneQueryFlags> PlaneQueryFlags { get { return new Array<EMagicLeapPlaneQueryFlags>(this[nameof(PlaneQueryFlags)].Address); } }
        public bool bDiscardZeroExtentPlanes { get { return this[nameof(bDiscardZeroExtentPlanes)].Flag; } set { this[nameof(bDiscardZeroExtentPlanes)].Flag = value; } }
        public bool bDefaultUseUnreliablePose { get { return this[nameof(bDefaultUseUnreliablePose)].Flag; } set { this[nameof(bDefaultUseUnreliablePose)].Flag = value; } }
    }
    public class LuminARLightEstimate : ARBasicLightEstimate
    {
        public LuminARLightEstimate(ulong addr) : base(addr) { }
        public Array<float> AmbientIntensityNits { get { return new Array<float>(this[nameof(AmbientIntensityNits)].Address); } }
        public Array<float> GetAmbientIntensityNits() { return Invoke<Array<float>>(nameof(GetAmbientIntensityNits)); }
    }
    public class LuminARCandidateImage : ARCandidateImage
    {
        public LuminARCandidateImage(ulong addr) : base(addr) { }
        public bool bUseUnreliablePose { get { return this[nameof(bUseUnreliablePose)].Flag; } set { this[nameof(bUseUnreliablePose)].Flag = value; } }
        public bool bImageIsStationary { get { return this[nameof(bImageIsStationary)].Flag; } set { this[nameof(bImageIsStationary)].Flag = value; } }
        public bool GetUseUnreliablePose() { return Invoke<bool>(nameof(GetUseUnreliablePose)); }
        public bool GetImageIsStationary() { return Invoke<bool>(nameof(GetImageIsStationary)); }
    }
    public enum ELuminARLineTraceChannel : int
    {
        None = 0,
        FeaturePoint = 1,
        InfinitePlane = 2,
        PlaneUsingExtent = 4,
        PlaneUsingBoundaryPolygon = 8,
        FeaturePointWithSurfaceNormal = 16,
        ELuminARLineTraceChannel_MAX = 17,
    }
    public enum ELuminARTrackingState : int
    {
        Tracking = 0,
        NotTracking = 1,
        StoppedTracking = 2,
        ELuminARTrackingState_MAX = 3,
    }
}
