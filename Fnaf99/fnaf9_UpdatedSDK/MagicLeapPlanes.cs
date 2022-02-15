using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapPlanesSDK
{
    public class MagicLeapPlanesComponent : SceneComponent
    {
        public MagicLeapPlanesComponent(ulong addr) : base(addr) { }
        public Array<EMagicLeapPlaneQueryFlags> QueryFlags { get { return new Array<EMagicLeapPlaneQueryFlags>(this[nameof(QueryFlags)].Address); } }
        public BoxComponent SearchVolume { get { return this[nameof(SearchVolume)].As<BoxComponent>(); } set { this["SearchVolume"] = value; } }
        public int MaxResults { get { return this[nameof(MaxResults)].GetValue<int>(); } set { this[nameof(MaxResults)].SetValue<int>(value); } }
        public float MinHolePerimeter { get { return this[nameof(MinHolePerimeter)].GetValue<float>(); } set { this[nameof(MinHolePerimeter)].SetValue<float>(value); } }
        public float MinPlaneArea { get { return this[nameof(MinPlaneArea)].GetValue<float>(); } set { this[nameof(MinPlaneArea)].SetValue<float>(value); } }
        public EMagicLeapPlaneQueryType QueryType { get { return (EMagicLeapPlaneQueryType)this[nameof(QueryType)].GetValue<int>(); } set { this[nameof(QueryType)].SetValue<int>((int)value); } }
        public float SimilarityThreshold { get { return this[nameof(SimilarityThreshold)].GetValue<float>(); } set { this[nameof(SimilarityThreshold)].SetValue<float>(value); } }
        public Object OnPlanesQueryResult { get { return this[nameof(OnPlanesQueryResult)]; } set { this[nameof(OnPlanesQueryResult)] = value; } }
        public Object OnPersistentPlanesQueryResult { get { return this[nameof(OnPersistentPlanesQueryResult)]; } set { this[nameof(OnPersistentPlanesQueryResult)] = value; } }
        public bool RequestPlanesAsync() { return Invoke<bool>(nameof(RequestPlanesAsync)); }
    }
    public class MagicLeapPlanesFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapPlanesFunctionLibrary(ulong addr) : base(addr) { }
        public void ReorderPlaneFlags(Array<EMagicLeapPlaneQueryFlags> InPriority, Array<EMagicLeapPlaneQueryFlags> InFlagsToReorder, Array<EMagicLeapPlaneQueryFlags> OutReorderedFlags) { Invoke(nameof(ReorderPlaneFlags), InPriority, InFlagsToReorder, OutReorderedFlags); }
        public bool RemovePersistentQuery(Guid Handle) { return Invoke<bool>(nameof(RemovePersistentQuery), Handle); }
        public void RemoveFlagsNotInQuery(Array<EMagicLeapPlaneQueryFlags> InQueryFlags, Array<EMagicLeapPlaneQueryFlags> InResultFlags, Array<EMagicLeapPlaneQueryFlags> OutFlags) { Invoke(nameof(RemoveFlagsNotInQuery), InQueryFlags, InResultFlags, OutFlags); }
        public bool PlanesQueryBeginAsync(MagicLeapPlanesQuery Query, Object ResultDelegate) { return Invoke<bool>(nameof(PlanesQueryBeginAsync), Query, ResultDelegate); }
        public bool PlanesPersistentQueryBeginAsync(MagicLeapPlanesQuery Query, Guid Handle, Object ResultDelegate) { return Invoke<bool>(nameof(PlanesPersistentQueryBeginAsync), Query, Handle, ResultDelegate); }
        public bool IsTrackerValid() { return Invoke<bool>(nameof(IsTrackerValid)); }
        public Transform GetContentScale(Actor ContentActor, MagicLeapPlaneResult PlaneResult) { return Invoke<Transform>(nameof(GetContentScale), ContentActor, PlaneResult); }
        public bool DestroyTracker() { return Invoke<bool>(nameof(DestroyTracker)); }
        public bool CreateTracker() { return Invoke<bool>(nameof(CreateTracker)); }
        public Guid AddPersistentQuery(EMagicLeapPlaneQueryType PersistentQueryType) { return Invoke<Guid>(nameof(AddPersistentQuery), PersistentQueryType); }
    }
    public class MagicLeapPlaneBoundaries : Object
    {
        public MagicLeapPlaneBoundaries(ulong addr) : base(addr) { }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Array<MagicLeapPlaneBoundary> Boundaries { get { return new Array<MagicLeapPlaneBoundary>(this[nameof(Boundaries)].Address); } }
    }
    public class MagicLeapPlaneBoundary : Object
    {
        public MagicLeapPlaneBoundary(ulong addr) : base(addr) { }
        public MagicLeapPolygon Polygon { get { return this[nameof(Polygon)].As<MagicLeapPolygon>(); } set { this["Polygon"] = value; } }
        public Array<MagicLeapPolygon> Holes { get { return new Array<MagicLeapPolygon>(this[nameof(Holes)].Address); } }
    }
    public class MagicLeapPolygon : Object
    {
        public MagicLeapPolygon(ulong addr) : base(addr) { }
        public Array<Vector> Vertices { get { return new Array<Vector>(this[nameof(Vertices)].Address); } }
    }
    public class MagicLeapPlaneResult : Object
    {
        public MagicLeapPlaneResult(ulong addr) : base(addr) { }
        public Vector PlanePosition { get { return this[nameof(PlanePosition)].As<Vector>(); } set { this["PlanePosition"] = value; } }
        public Rotator PlaneOrientation { get { return this[nameof(PlaneOrientation)].As<Rotator>(); } set { this["PlaneOrientation"] = value; } }
        public Rotator ContentOrientation { get { return this[nameof(ContentOrientation)].As<Rotator>(); } set { this["ContentOrientation"] = value; } }
        public Vector2D PlaneDimensions { get { return this[nameof(PlaneDimensions)].As<Vector2D>(); } set { this["PlaneDimensions"] = value; } }
        public Array<EMagicLeapPlaneQueryFlags> PlaneFlags { get { return new Array<EMagicLeapPlaneQueryFlags>(this[nameof(PlaneFlags)].Address); } }
        public Guid ID { get { return this[nameof(ID)].As<Guid>(); } set { this["ID"] = value; } }
        public Guid InnerID { get { return this[nameof(InnerID)].As<Guid>(); } set { this["InnerID"] = value; } }
    }
    public enum EMagicLeapPlaneQueryFlags : int
    {
        Vertical = 0,
        Horizontal = 1,
        Arbitrary = 2,
        OrientToGravity = 3,
        PreferInner = 4,
        Ceiling = 5,
        Floor = 6,
        Wall = 7,
        Polygons = 8,
        EMagicLeapPlaneQueryFlags_MAX = 9,
    }
    public enum EMagicLeapPlaneQueryType : int
    {
        Bulk = 0,
        Delta = 1,
        EMagicLeapPlaneQueryType_MAX = 2,
    }
    public class MagicLeapPlanesQuery : Object
    {
        public MagicLeapPlanesQuery(ulong addr) : base(addr) { }
        public Array<EMagicLeapPlaneQueryFlags> Flags { get { return new Array<EMagicLeapPlaneQueryFlags>(this[nameof(Flags)].Address); } }
        public BoxComponent SearchVolume { get { return this[nameof(SearchVolume)].As<BoxComponent>(); } set { this["SearchVolume"] = value; } }
        public int MaxResults { get { return this[nameof(MaxResults)].GetValue<int>(); } set { this[nameof(MaxResults)].SetValue<int>(value); } }
        public float MinHoleLength { get { return this[nameof(MinHoleLength)].GetValue<float>(); } set { this[nameof(MinHoleLength)].SetValue<float>(value); } }
        public float MinPlaneArea { get { return this[nameof(MinPlaneArea)].GetValue<float>(); } set { this[nameof(MinPlaneArea)].SetValue<float>(value); } }
        public Vector SearchVolumePosition { get { return this[nameof(SearchVolumePosition)].As<Vector>(); } set { this["SearchVolumePosition"] = value; } }
        public Quat SearchVolumeOrientation { get { return this[nameof(SearchVolumeOrientation)].As<Quat>(); } set { this["SearchVolumeOrientation"] = value; } }
        public Vector SearchVolumeExtents { get { return this[nameof(SearchVolumeExtents)].As<Vector>(); } set { this["SearchVolumeExtents"] = value; } }
        public float SimilarityThreshold { get { return this[nameof(SimilarityThreshold)].GetValue<float>(); } set { this[nameof(SimilarityThreshold)].SetValue<float>(value); } }
        public bool bSearchVolumeTrackingSpace { get { return this[nameof(bSearchVolumeTrackingSpace)].Flag; } set { this[nameof(bSearchVolumeTrackingSpace)].Flag = value; } }
        public bool bResultTrackingSpace { get { return this[nameof(bResultTrackingSpace)].Flag; } set { this[nameof(bResultTrackingSpace)].Flag = value; } }
    }
}
