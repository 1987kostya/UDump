using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.PhysicsCoreSDK
{
    public enum EChaosBufferMode : int
    {
        Double = 0,
        Triple = 1,
        Num = 2,
        Invalid = 3,
        EChaosBufferMode_MAX = 4,
    }
    public enum EChaosThreadingMode : int
    {
        DedicatedThread = 0,
        TaskGraph = 1,
        SingleThread = 2,
        Num = 3,
        Invalid = 4,
        EChaosThreadingMode_MAX = 5,
    }
    public enum EChaosSolverTickMode : int
    {
        Fixed = 0,
        Variable = 1,
        VariableCapped = 2,
        VariableCappedWithTarget = 3,
        EChaosSolverTickMode_MAX = 4,
    }
}
