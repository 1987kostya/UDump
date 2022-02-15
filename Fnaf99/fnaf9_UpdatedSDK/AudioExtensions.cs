using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.AudioExtensionsSDK
{
    public class SpatializationPluginSourceSettingsBase : Object
    {
        public SpatializationPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEncodingSettingsBase : Object
    {
        public SoundfieldEncodingSettingsBase(ulong addr) : base(addr) { }
    }
    public class AudioEndpointSettingsBase : Object
    {
        public AudioEndpointSettingsBase(ulong addr) : base(addr) { }
    }
    public class OcclusionPluginSourceSettingsBase : Object
    {
        public OcclusionPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundModulationPluginSourceSettingsBase : Object
    {
        public SoundModulationPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class ReverbPluginSourceSettingsBase : Object
    {
        public ReverbPluginSourceSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEndpointSettingsBase : Object
    {
        public SoundfieldEndpointSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEffectSettingsBase : Object
    {
        public SoundfieldEffectSettingsBase(ulong addr) : base(addr) { }
    }
    public class SoundfieldEffectBase : Object
    {
        public SoundfieldEffectBase(ulong addr) : base(addr) { }
        public SoundfieldEffectSettingsBase Settings { get { return this[nameof(Settings)].As<SoundfieldEffectSettingsBase>(); } set { this["Settings"] = value; } }
    }
    public class SoundModulationParameter : Object
    {
        public SoundModulationParameter(ulong addr) : base(addr) { }
        public Object Control { get { return this[nameof(Control)]; } set { this[nameof(Control)] = value; } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
    }
    public class SoundModulation : Object
    {
        public SoundModulation(ulong addr) : base(addr) { }
        public Array<SoundModulationPluginSourceSettingsBase> Settings { get { return new Array<SoundModulationPluginSourceSettingsBase>(this[nameof(Settings)].Address); } }
    }
}
