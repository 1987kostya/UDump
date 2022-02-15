using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.AudioExtensionsSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.SpatializationSDK
{
    public class ITDSpatializationSourceSettings : SpatializationPluginSourceSettingsBase
    {
        public ITDSpatializationSourceSettings(ulong addr) : base(addr) { }
        public bool bEnableILD { get { return this[nameof(bEnableILD)].Flag; } set { this[nameof(bEnableILD)].Flag = value; } }
        public RuntimeFloatCurve PanningIntensityOverDistance { get { return this[nameof(PanningIntensityOverDistance)].As<RuntimeFloatCurve>(); } set { this["PanningIntensityOverDistance"] = value; } }
    }
}
