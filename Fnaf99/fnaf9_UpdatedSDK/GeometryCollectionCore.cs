using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.GeometryCollectionCoreSDK
{
    public enum EGeometryCollectionCacheType : int
    {
        None = 0,
        Record = 1,
        Play = 2,
        RecordAndPlay = 3,
        EGeometryCollectionCacheType_MAX = 4,
    }
    public class RecordedTransformTrack : Object
    {
        public RecordedTransformTrack(ulong addr) : base(addr) { }
        public Array<RecordedFrame> Records { get { return new Array<RecordedFrame>(this[nameof(Records)].Address); } }
    }
    public class RecordedFrame : Object
    {
        public RecordedFrame(ulong addr) : base(addr) { }
        public Array<Transform> Transforms { get { return new Array<Transform>(this[nameof(Transforms)].Address); } }
        public Array<int> TransformIndices { get { return new Array<int>(this[nameof(TransformIndices)].Address); } }
        public Array<int> PreviousTransformIndices { get { return new Array<int>(this[nameof(PreviousTransformIndices)].Address); } }
        public Array<bool> DisabledFlags { get { return new Array<bool>(this[nameof(DisabledFlags)].Address); } }
        public Array<SolverCollisionData> Collisions { get { return new Array<SolverCollisionData>(this[nameof(Collisions)].Address); } }
        public Array<SolverBreakingData> Breakings { get { return new Array<SolverBreakingData>(this[nameof(Breakings)].Address); } }
        public Object Trailings { get { return this[nameof(Trailings)]; } set { this[nameof(Trailings)] = value; } }
        public float Timestamp { get { return this[nameof(Timestamp)].GetValue<float>(); } set { this[nameof(Timestamp)].SetValue<float>(value); } }
    }
    public class SolverTrailingData : Object
    {
        public SolverTrailingData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
    }
    public class SolverBreakingData : Object
    {
        public SolverBreakingData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector AngularVelocity { get { return this[nameof(AngularVelocity)].As<Vector>(); } set { this["AngularVelocity"] = value; } }
        public float Mass { get { return this[nameof(Mass)].GetValue<float>(); } set { this[nameof(Mass)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
    }
    public class SolverCollisionData : Object
    {
        public SolverCollisionData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Vector AccumulatedImpulse { get { return this[nameof(AccumulatedImpulse)].As<Vector>(); } set { this["AccumulatedImpulse"] = value; } }
        public Vector Normal { get { return this[nameof(Normal)].As<Vector>(); } set { this["Normal"] = value; } }
        public Vector Velocity1 { get { return this[nameof(Velocity1)].As<Vector>(); } set { this["Velocity1"] = value; } }
        public Vector Velocity2 { get { return this[nameof(Velocity2)].As<Vector>(); } set { this["Velocity2"] = value; } }
        public Vector AngularVelocity1 { get { return this[nameof(AngularVelocity1)].As<Vector>(); } set { this["AngularVelocity1"] = value; } }
        public Vector AngularVelocity2 { get { return this[nameof(AngularVelocity2)].As<Vector>(); } set { this["AngularVelocity2"] = value; } }
        public float Mass1 { get { return this[nameof(Mass1)].GetValue<float>(); } set { this[nameof(Mass1)].SetValue<float>(value); } }
        public float Mass2 { get { return this[nameof(Mass2)].GetValue<float>(); } set { this[nameof(Mass2)].SetValue<float>(value); } }
        public int ParticleIndex { get { return this[nameof(ParticleIndex)].GetValue<int>(); } set { this[nameof(ParticleIndex)].SetValue<int>(value); } }
        public int LevelsetIndex { get { return this[nameof(LevelsetIndex)].GetValue<int>(); } set { this[nameof(LevelsetIndex)].SetValue<int>(value); } }
        public int ParticleIndexMesh { get { return this[nameof(ParticleIndexMesh)].GetValue<int>(); } set { this[nameof(ParticleIndexMesh)].SetValue<int>(value); } }
        public int LevelsetIndexMesh { get { return this[nameof(LevelsetIndexMesh)].GetValue<int>(); } set { this[nameof(LevelsetIndexMesh)].SetValue<int>(value); } }
    }
}
