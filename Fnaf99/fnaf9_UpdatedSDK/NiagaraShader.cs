using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.NiagaraShaderSDK
{
    public enum FNiagaraCompileEventSeverity : int
    {
        Log = 0,
        Warning = 1,
        Error = 2,
        FNiagaraCompileEventSeverity_MAX = 3,
    }
    public class NiagaraDataInterfaceGPUParamInfo : Object
    {
        public NiagaraDataInterfaceGPUParamInfo(ulong addr) : base(addr) { }
        public Object DataInterfaceHLSLSymbol { get { return this[nameof(DataInterfaceHLSLSymbol)]; } set { this[nameof(DataInterfaceHLSLSymbol)] = value; } }
        public Object DIClassName { get { return this[nameof(DIClassName)]; } set { this[nameof(DIClassName)] = value; } }
        public Array<NiagaraDataInterfaceGeneratedFunction> GeneratedFunctions { get { return new Array<NiagaraDataInterfaceGeneratedFunction>(this[nameof(GeneratedFunctions)].Address); } }
    }
    public class NiagaraDataInterfaceGeneratedFunction : Object
    {
        public NiagaraDataInterfaceGeneratedFunction(ulong addr) : base(addr) { }
    }
    public class NiagaraCompileEvent : Object
    {
        public NiagaraCompileEvent(ulong addr) : base(addr) { }
        public FNiagaraCompileEventSeverity Severity { get { return (FNiagaraCompileEventSeverity)this[nameof(Severity)].GetValue<int>(); } set { this[nameof(Severity)].SetValue<int>((int)value); } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
        public Guid NodeGuid { get { return this[nameof(NodeGuid)].As<Guid>(); } set { this["NodeGuid"] = value; } }
        public Guid PinGuid { get { return this[nameof(PinGuid)].As<Guid>(); } set { this["PinGuid"] = value; } }
        public Array<Guid> StackGuids { get { return new Array<Guid>(this[nameof(StackGuids)].Address); } }
    }
}
