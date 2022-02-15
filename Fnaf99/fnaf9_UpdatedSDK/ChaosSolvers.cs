using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.ChaosSolversSDK
{
    public class SolverBreakingFilterSettings : Object
    {
        public SolverBreakingFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinVolume { get { return this[nameof(MinVolume)].GetValue<float>(); } set { this[nameof(MinVolume)].SetValue<float>(value); } }
    }
    public class SolverCollisionFilterSettings : Object
    {
        public SolverCollisionFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinImpulse { get { return this[nameof(MinImpulse)].GetValue<float>(); } set { this[nameof(MinImpulse)].SetValue<float>(value); } }
    }
    public class SolverTrailingFilterSettings : Object
    {
        public SolverTrailingFilterSettings(ulong addr) : base(addr) { }
        public bool FilterEnabled { get { return this[nameof(FilterEnabled)].Flag; } set { this[nameof(FilterEnabled)].Flag = value; } }
        public float MinMass { get { return this[nameof(MinMass)].GetValue<float>(); } set { this[nameof(MinMass)].SetValue<float>(value); } }
        public float MinSpeed { get { return this[nameof(MinSpeed)].GetValue<float>(); } set { this[nameof(MinSpeed)].SetValue<float>(value); } }
        public float MinVolume { get { return this[nameof(MinVolume)].GetValue<float>(); } set { this[nameof(MinVolume)].SetValue<float>(value); } }
    }
}
