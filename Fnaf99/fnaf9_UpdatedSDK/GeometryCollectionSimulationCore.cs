using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.GeometryCollectionSimulationCoreSDK
{
    public enum EEmissionPatternTypeEnum : int
    {
        Chaos_Emission_Pattern_First_Frame = 0,
        Chaos_Emission_Pattern_On_Demand = 1,
        Chaos_Max = 2,
    }
    public enum EInitialVelocityTypeEnum : int
    {
        Chaos_Initial_Velocity_User_Defined = 0,
        Chaos_Initial_Velocity_None = 1,
        Chaos_Max = 2,
    }
    public enum EGeometryCollectionPhysicsTypeEnum : int
    {
        Chaos_AngularVelocity = 0,
        Chaos_DynamicState = 1,
        Chaos_LinearVelocity = 2,
        Chaos_InitialAngularVelocity = 3,
        Chaos_InitialLinearVelocity = 4,
        Chaos_CollisionGroup = 5,
        Chaos_LinearForce = 6,
        Chaos_AngularTorque = 7,
        Chaos_Max = 8,
    }
    public enum EObjectStateTypeEnum : int
    {
        Chaos_NONE = 0,
        Chaos_Object_Sleeping = 1,
        Chaos_Object_Kinematic = 2,
        Chaos_Object_Static = 3,
        Chaos_Object_Dynamic = 4,
        Chaos_Object_UserDefined = 100,
        Chaos_Max = 101,
    }
    public enum EImplicitTypeEnum : int
    {
        Chaos_Implicit_Box = 0,
        Chaos_Implicit_Sphere = 1,
        Chaos_Implicit_Capsule = 2,
        Chaos_Implicit_LevelSet = 3,
        Chaos_Implicit_None = 4,
        Chaos_Max = 5,
    }
    public enum ECollisionTypeEnum : int
    {
        Chaos_Volumetric = 0,
        Chaos_Surface_Volumetric = 1,
        Chaos_Max = 2,
    }
}
