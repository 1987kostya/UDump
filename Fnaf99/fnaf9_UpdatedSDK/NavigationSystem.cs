using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.NavigationSystemSDK
{
    public class NavigationData : Actor
    {
        public NavigationData(ulong addr) : base(addr) { }
        public PrimitiveComponent RenderingComp { get { return this[nameof(RenderingComp)].As<PrimitiveComponent>(); } set { this["RenderingComp"] = value; } }
        public NavDataConfig NavDataConfig { get { return this[nameof(NavDataConfig)].As<NavDataConfig>(); } set { this["NavDataConfig"] = value; } }
        public bool bEnableDrawing { get { return this[nameof(bEnableDrawing)].Flag; } set { this[nameof(bEnableDrawing)].Flag = value; } }
        public bool bForceRebuildOnLoad { get { return this[nameof(bForceRebuildOnLoad)].Flag; } set { this[nameof(bForceRebuildOnLoad)].Flag = value; } }
        public bool bAutoDestroyWhenNoNavigation { get { return this[nameof(bAutoDestroyWhenNoNavigation)].Flag; } set { this[nameof(bAutoDestroyWhenNoNavigation)].Flag = value; } }
        public bool bCanBeMainNavData { get { return this[nameof(bCanBeMainNavData)].Flag; } set { this[nameof(bCanBeMainNavData)].Flag = value; } }
        public bool bCanSpawnOnRebuild { get { return this[nameof(bCanSpawnOnRebuild)].Flag; } set { this[nameof(bCanSpawnOnRebuild)].Flag = value; } }
        public bool bRebuildAtRuntime { get { return this[nameof(bRebuildAtRuntime)].Flag; } set { this[nameof(bRebuildAtRuntime)].Flag = value; } }
        public ERuntimeGenerationType RuntimeGeneration { get { return (ERuntimeGenerationType)this[nameof(RuntimeGeneration)].GetValue<int>(); } set { this[nameof(RuntimeGeneration)].SetValue<int>((int)value); } }
        public float ObservedPathsTickInterval { get { return this[nameof(ObservedPathsTickInterval)].GetValue<float>(); } set { this[nameof(ObservedPathsTickInterval)].SetValue<float>(value); } }
        public uint DataVersion { get { return this[nameof(DataVersion)].GetValue<uint>(); } set { this[nameof(DataVersion)].SetValue<uint>(value); } }
        public Array<SupportedAreaData> SupportedAreas { get { return new Array<SupportedAreaData>(this[nameof(SupportedAreas)].Address); } }
    }
    public class AbstractNavData : NavigationData
    {
        public AbstractNavData(ulong addr) : base(addr) { }
    }
    public class CrowdManagerBase : Object
    {
        public CrowdManagerBase(ulong addr) : base(addr) { }
    }
    public class NavArea : NavAreaBase
    {
        public NavArea(ulong addr) : base(addr) { }
        public float DefaultCost { get { return this[nameof(DefaultCost)].GetValue<float>(); } set { this[nameof(DefaultCost)].SetValue<float>(value); } }
        public float FixedAreaEnteringCost { get { return this[nameof(FixedAreaEnteringCost)].GetValue<float>(); } set { this[nameof(FixedAreaEnteringCost)].SetValue<float>(value); } }
        public Color DrawColor { get { return this[nameof(DrawColor)].As<Color>(); } set { this["DrawColor"] = value; } }
        public NavAgentSelector SupportedAgents { get { return this[nameof(SupportedAgents)].As<NavAgentSelector>(); } set { this["SupportedAgents"] = value; } }
        public bool bSupportsAgent0 { get { return this[nameof(bSupportsAgent0)].Flag; } set { this[nameof(bSupportsAgent0)].Flag = value; } }
        public bool bSupportsAgent1 { get { return this[nameof(bSupportsAgent1)].Flag; } set { this[nameof(bSupportsAgent1)].Flag = value; } }
        public bool bSupportsAgent2 { get { return this[nameof(bSupportsAgent2)].Flag; } set { this[nameof(bSupportsAgent2)].Flag = value; } }
        public bool bSupportsAgent3 { get { return this[nameof(bSupportsAgent3)].Flag; } set { this[nameof(bSupportsAgent3)].Flag = value; } }
        public bool bSupportsAgent4 { get { return this[nameof(bSupportsAgent4)].Flag; } set { this[nameof(bSupportsAgent4)].Flag = value; } }
        public bool bSupportsAgent5 { get { return this[nameof(bSupportsAgent5)].Flag; } set { this[nameof(bSupportsAgent5)].Flag = value; } }
        public bool bSupportsAgent6 { get { return this[nameof(bSupportsAgent6)].Flag; } set { this[nameof(bSupportsAgent6)].Flag = value; } }
        public bool bSupportsAgent7 { get { return this[nameof(bSupportsAgent7)].Flag; } set { this[nameof(bSupportsAgent7)].Flag = value; } }
        public bool bSupportsAgent8 { get { return this[nameof(bSupportsAgent8)].Flag; } set { this[nameof(bSupportsAgent8)].Flag = value; } }
        public bool bSupportsAgent9 { get { return this[nameof(bSupportsAgent9)].Flag; } set { this[nameof(bSupportsAgent9)].Flag = value; } }
        public bool bSupportsAgent10 { get { return this[nameof(bSupportsAgent10)].Flag; } set { this[nameof(bSupportsAgent10)].Flag = value; } }
        public bool bSupportsAgent11 { get { return this[nameof(bSupportsAgent11)].Flag; } set { this[nameof(bSupportsAgent11)].Flag = value; } }
        public bool bSupportsAgent12 { get { return this[nameof(bSupportsAgent12)].Flag; } set { this[nameof(bSupportsAgent12)].Flag = value; } }
        public bool bSupportsAgent13 { get { return this[nameof(bSupportsAgent13)].Flag; } set { this[nameof(bSupportsAgent13)].Flag = value; } }
        public bool bSupportsAgent14 { get { return this[nameof(bSupportsAgent14)].Flag; } set { this[nameof(bSupportsAgent14)].Flag = value; } }
        public bool bSupportsAgent15 { get { return this[nameof(bSupportsAgent15)].Flag; } set { this[nameof(bSupportsAgent15)].Flag = value; } }
    }
    public class NavArea_Default : NavArea
    {
        public NavArea_Default(ulong addr) : base(addr) { }
    }
    public class NavArea_LowHeight : NavArea
    {
        public NavArea_LowHeight(ulong addr) : base(addr) { }
    }
    public class NavArea_Null : NavArea
    {
        public NavArea_Null(ulong addr) : base(addr) { }
    }
    public class NavArea_Obstacle : NavArea
    {
        public NavArea_Obstacle(ulong addr) : base(addr) { }
    }
    public class NavAreaMeta : NavArea
    {
        public NavAreaMeta(ulong addr) : base(addr) { }
    }
    public class NavAreaMeta_SwitchByAgent : NavAreaMeta
    {
        public NavAreaMeta_SwitchByAgent(ulong addr) : base(addr) { }
        public Object Agent0Area { get { return this[nameof(Agent0Area)]; } set { this[nameof(Agent0Area)] = value; } }
        public Object Agent1Area { get { return this[nameof(Agent1Area)]; } set { this[nameof(Agent1Area)] = value; } }
        public Object Agent2Area { get { return this[nameof(Agent2Area)]; } set { this[nameof(Agent2Area)] = value; } }
        public Object Agent3Area { get { return this[nameof(Agent3Area)]; } set { this[nameof(Agent3Area)] = value; } }
        public Object Agent4Area { get { return this[nameof(Agent4Area)]; } set { this[nameof(Agent4Area)] = value; } }
        public Object Agent5Area { get { return this[nameof(Agent5Area)]; } set { this[nameof(Agent5Area)] = value; } }
        public Object Agent6Area { get { return this[nameof(Agent6Area)]; } set { this[nameof(Agent6Area)] = value; } }
        public Object Agent7Area { get { return this[nameof(Agent7Area)]; } set { this[nameof(Agent7Area)] = value; } }
        public Object Agent8Area { get { return this[nameof(Agent8Area)]; } set { this[nameof(Agent8Area)] = value; } }
        public Object Agent9Area { get { return this[nameof(Agent9Area)]; } set { this[nameof(Agent9Area)] = value; } }
        public Object Agent10Area { get { return this[nameof(Agent10Area)]; } set { this[nameof(Agent10Area)] = value; } }
        public Object Agent11Area { get { return this[nameof(Agent11Area)]; } set { this[nameof(Agent11Area)] = value; } }
        public Object Agent12Area { get { return this[nameof(Agent12Area)]; } set { this[nameof(Agent12Area)] = value; } }
        public Object Agent13Area { get { return this[nameof(Agent13Area)]; } set { this[nameof(Agent13Area)] = value; } }
        public Object Agent14Area { get { return this[nameof(Agent14Area)]; } set { this[nameof(Agent14Area)] = value; } }
        public Object Agent15Area { get { return this[nameof(Agent15Area)]; } set { this[nameof(Agent15Area)] = value; } }
    }
    public class NavCollision : NavCollisionBase
    {
        public NavCollision(ulong addr) : base(addr) { }
        public Array<NavCollisionCylinder> CylinderCollision { get { return new Array<NavCollisionCylinder>(this[nameof(CylinderCollision)].Address); } }
        public Array<NavCollisionBox> BoxCollision { get { return new Array<NavCollisionBox>(this[nameof(BoxCollision)].Address); } }
        public Object AreaClass { get { return this[nameof(AreaClass)]; } set { this[nameof(AreaClass)] = value; } }
        public bool bGatherConvexGeometry { get { return this[nameof(bGatherConvexGeometry)].Flag; } set { this[nameof(bGatherConvexGeometry)].Flag = value; } }
        public bool bCreateOnClient { get { return this[nameof(bCreateOnClient)].Flag; } set { this[nameof(bCreateOnClient)].Flag = value; } }
    }
    public class NavigationGraph : NavigationData
    {
        public NavigationGraph(ulong addr) : base(addr) { }
    }
    public class NavigationGraphNode : Actor
    {
        public NavigationGraphNode(ulong addr) : base(addr) { }
    }
    public class NavigationGraphNodeComponent : SceneComponent
    {
        public NavigationGraphNodeComponent(ulong addr) : base(addr) { }
        public NavGraphNode Node { get { return this[nameof(Node)].As<NavGraphNode>(); } set { this["Node"] = value; } }
        public NavigationGraphNodeComponent NextNodeComponent { get { return this[nameof(NextNodeComponent)].As<NavigationGraphNodeComponent>(); } set { this["NextNodeComponent"] = value; } }
        public NavigationGraphNodeComponent PrevNodeComponent { get { return this[nameof(PrevNodeComponent)].As<NavigationGraphNodeComponent>(); } set { this["PrevNodeComponent"] = value; } }
    }
    public class NavigationInvokerComponent : ActorComponent
    {
        public NavigationInvokerComponent(ulong addr) : base(addr) { }
        public float TileGenerationRadius { get { return this[nameof(TileGenerationRadius)].GetValue<float>(); } set { this[nameof(TileGenerationRadius)].SetValue<float>(value); } }
        public float TileRemovalRadius { get { return this[nameof(TileRemovalRadius)].GetValue<float>(); } set { this[nameof(TileRemovalRadius)].SetValue<float>(value); } }
    }
    public class NavigationPath : Object
    {
        public NavigationPath(ulong addr) : base(addr) { }
        public Object PathUpdatedNotifier { get { return this[nameof(PathUpdatedNotifier)]; } set { this[nameof(PathUpdatedNotifier)] = value; } }
        public Array<Vector> PathPoints { get { return new Array<Vector>(this[nameof(PathPoints)].Address); } }
        public byte RecalculateOnInvalidation { get { return this[nameof(RecalculateOnInvalidation)].GetValue<byte>(); } set { this[nameof(RecalculateOnInvalidation)].SetValue<byte>(value); } }
        public bool IsValid() { return Invoke<bool>(nameof(IsValid)); }
        public bool IsStringPulled() { return Invoke<bool>(nameof(IsStringPulled)); }
        public bool IsPartial() { return Invoke<bool>(nameof(IsPartial)); }
        public float GetPathLength() { return Invoke<float>(nameof(GetPathLength)); }
        public float GetPathCost() { return Invoke<float>(nameof(GetPathCost)); }
        public Object GetDebugString() { return Invoke<Object>(nameof(GetDebugString)); }
        public void EnableRecalculationOnInvalidation(byte DoRecalculation) { Invoke(nameof(EnableRecalculationOnInvalidation), DoRecalculation); }
        public void EnableDebugDrawing(bool bShouldDrawDebugData, LinearColor PathColor) { Invoke(nameof(EnableDebugDrawing), bShouldDrawDebugData, PathColor); }
    }
    public class NavigationPathGenerator : Interface
    {
        public NavigationPathGenerator(ulong addr) : base(addr) { }
    }
    public class NavigationQueryFilter : Object
    {
        public NavigationQueryFilter(ulong addr) : base(addr) { }
        public Array<NavigationFilterArea> Areas { get { return new Array<NavigationFilterArea>(this[nameof(Areas)].Address); } }
        public NavigationFilterFlags IncludeFlags { get { return this[nameof(IncludeFlags)].As<NavigationFilterFlags>(); } set { this["IncludeFlags"] = value; } }
        public NavigationFilterFlags ExcludeFlags { get { return this[nameof(ExcludeFlags)].As<NavigationFilterFlags>(); } set { this["ExcludeFlags"] = value; } }
    }
    public class NavigationSystemV1 : NavigationSystemBase
    {
        public NavigationSystemV1(ulong addr) : base(addr) { }
        public NavigationData MainNavData { get { return this[nameof(MainNavData)].As<NavigationData>(); } set { this["MainNavData"] = value; } }
        public NavigationData AbstractNavData { get { return this[nameof(AbstractNavData)].As<NavigationData>(); } set { this["AbstractNavData"] = value; } }
        public Object DefaultAgentName { get { return this[nameof(DefaultAgentName)]; } set { this[nameof(DefaultAgentName)] = value; } }
        public Object CrowdManagerClass { get { return this[nameof(CrowdManagerClass)]; } set { this[nameof(CrowdManagerClass)] = value; } }
        public bool bAutoCreateNavigationData { get { return this[nameof(bAutoCreateNavigationData)].Flag; } set { this[nameof(bAutoCreateNavigationData)].Flag = value; } }
        public bool bSpawnNavDataInNavBoundsLevel { get { return this[nameof(bSpawnNavDataInNavBoundsLevel)].Flag; } set { this[nameof(bSpawnNavDataInNavBoundsLevel)].Flag = value; } }
        public bool bAllowClientSideNavigation { get { return this[nameof(bAllowClientSideNavigation)].Flag; } set { this[nameof(bAllowClientSideNavigation)].Flag = value; } }
        public bool bShouldDiscardSubLevelNavData { get { return this[nameof(bShouldDiscardSubLevelNavData)].Flag; } set { this[nameof(bShouldDiscardSubLevelNavData)].Flag = value; } }
        public bool bTickWhilePaused { get { return this[nameof(bTickWhilePaused)].Flag; } set { this[nameof(bTickWhilePaused)].Flag = value; } }
        public bool bSupportRebuilding { get { return this[nameof(bSupportRebuilding)].Flag; } set { this[nameof(bSupportRebuilding)].Flag = value; } }
        public bool bInitialBuildingLocked { get { return this[nameof(bInitialBuildingLocked)].Flag; } set { this[nameof(bInitialBuildingLocked)].Flag = value; } }
        public bool bSkipAgentHeightCheckWhenPickingNavData { get { return this[nameof(bSkipAgentHeightCheckWhenPickingNavData)].Flag; } set { this[nameof(bSkipAgentHeightCheckWhenPickingNavData)].Flag = value; } }
        public ENavDataGatheringModeConfig DataGatheringMode { get { return (ENavDataGatheringModeConfig)this[nameof(DataGatheringMode)].GetValue<int>(); } set { this[nameof(DataGatheringMode)].SetValue<int>((int)value); } }
        public bool bGenerateNavigationOnlyAroundNavigationInvokers { get { return this[nameof(bGenerateNavigationOnlyAroundNavigationInvokers)].Flag; } set { this[nameof(bGenerateNavigationOnlyAroundNavigationInvokers)].Flag = value; } }
        public float ActiveTilesUpdateInterval { get { return this[nameof(ActiveTilesUpdateInterval)].GetValue<float>(); } set { this[nameof(ActiveTilesUpdateInterval)].SetValue<float>(value); } }
        public Array<NavDataConfig> SupportedAgents { get { return new Array<NavDataConfig>(this[nameof(SupportedAgents)].Address); } }
        public NavAgentSelector SupportedAgentsMask { get { return this[nameof(SupportedAgentsMask)].As<NavAgentSelector>(); } set { this["SupportedAgentsMask"] = value; } }
        public Array<NavigationData> NavDataSet { get { return new Array<NavigationData>(this[nameof(NavDataSet)].Address); } }
        public Array<NavigationData> NavDataRegistrationQueue { get { return new Array<NavigationData>(this[nameof(NavDataRegistrationQueue)].Address); } }
        public Object OnNavDataRegisteredEvent { get { return this[nameof(OnNavDataRegisteredEvent)]; } set { this[nameof(OnNavDataRegisteredEvent)] = value; } }
        public Object OnNavigationGenerationFinishedDelegate { get { return this[nameof(OnNavigationGenerationFinishedDelegate)]; } set { this[nameof(OnNavigationGenerationFinishedDelegate)] = value; } }
        public FNavigationSystemRunMode OperationMode { get { return (FNavigationSystemRunMode)this[nameof(OperationMode)].GetValue<int>(); } set { this[nameof(OperationMode)].SetValue<int>((int)value); } }
        public float DirtyAreasUpdateFreq { get { return this[nameof(DirtyAreasUpdateFreq)].GetValue<float>(); } set { this[nameof(DirtyAreasUpdateFreq)].SetValue<float>(value); } }
        public void UnregisterNavigationInvoker(Actor Invoker) { Invoke(nameof(UnregisterNavigationInvoker), Invoker); }
        public void SimpleMoveToLocation(Controller Controller, Vector Goal) { Invoke(nameof(SimpleMoveToLocation), Controller, Goal); }
        public void SimpleMoveToActor(Controller Controller, Actor Goal) { Invoke(nameof(SimpleMoveToActor), Controller, Goal); }
        public void SetMaxSimultaneousTileGenerationJobsCount(int MaxNumberOfJobs) { Invoke(nameof(SetMaxSimultaneousTileGenerationJobsCount), MaxNumberOfJobs); }
        public void SetGeometryGatheringMode(ENavDataGatheringModeConfig NewMode) { Invoke(nameof(SetGeometryGatheringMode), NewMode); }
        public void ResetMaxSimultaneousTileGenerationJobsCount() { Invoke(nameof(ResetMaxSimultaneousTileGenerationJobsCount)); }
        public void RegisterNavigationInvoker(Actor Invoker, float TileGenerationRadius, float TileRemovalRadius) { Invoke(nameof(RegisterNavigationInvoker), Invoker, TileGenerationRadius, TileRemovalRadius); }
        public Vector ProjectPointToNavigation(Object WorldContextObject, Vector Point, NavigationData NavData, Object FilterClass, Vector QueryExtent) { return Invoke<Vector>(nameof(ProjectPointToNavigation), WorldContextObject, Point, NavData, FilterClass, QueryExtent); }
        public void OnNavigationBoundsUpdated(NavMeshBoundsVolume NavVolume) { Invoke(nameof(OnNavigationBoundsUpdated), NavVolume); }
        public bool NavigationRaycast(Object WorldContextObject, Vector RayStart, Vector RayEnd, Vector HitLocation, Object FilterClass, Controller Querier) { return Invoke<bool>(nameof(NavigationRaycast), WorldContextObject, RayStart, RayEnd, HitLocation, FilterClass, Querier); }
        public bool K2_ReplaceAreaInOctreeData(Object Object, Object OldArea, Object NewArea) { return Invoke<bool>(nameof(K2_ReplaceAreaInOctreeData), Object, OldArea, NewArea); }
        public bool K2_ProjectPointToNavigation(Object WorldContextObject, Vector Point, Vector ProjectedLocation, NavigationData NavData, Object FilterClass, Vector QueryExtent) { return Invoke<bool>(nameof(K2_ProjectPointToNavigation), WorldContextObject, Point, ProjectedLocation, NavData, FilterClass, QueryExtent); }
        public bool K2_GetRandomReachablePointInRadius(Object WorldContextObject, Vector Origin, Vector RandomLocation, float Radius, NavigationData NavData, Object FilterClass) { return Invoke<bool>(nameof(K2_GetRandomReachablePointInRadius), WorldContextObject, Origin, RandomLocation, Radius, NavData, FilterClass); }
        public bool K2_GetRandomPointInNavigableRadius(Object WorldContextObject, Vector Origin, Vector RandomLocation, float Radius, NavigationData NavData, Object FilterClass) { return Invoke<bool>(nameof(K2_GetRandomPointInNavigableRadius), WorldContextObject, Origin, RandomLocation, Radius, NavData, FilterClass); }
        public bool K2_GetRandomLocationInNavigableRadius(Object WorldContextObject, Vector Origin, Vector RandomLocation, float Radius, NavigationData NavData, Object FilterClass) { return Invoke<bool>(nameof(K2_GetRandomLocationInNavigableRadius), WorldContextObject, Origin, RandomLocation, Radius, NavData, FilterClass); }
        public bool IsNavigationBeingBuiltOrLocked(Object WorldContextObject) { return Invoke<bool>(nameof(IsNavigationBeingBuiltOrLocked), WorldContextObject); }
        public bool IsNavigationBeingBuilt(Object WorldContextObject) { return Invoke<bool>(nameof(IsNavigationBeingBuilt), WorldContextObject); }
        public Vector GetRandomReachablePointInRadius(Object WorldContextObject, Vector Origin, float Radius, NavigationData NavData, Object FilterClass) { return Invoke<Vector>(nameof(GetRandomReachablePointInRadius), WorldContextObject, Origin, Radius, NavData, FilterClass); }
        public Vector GetRandomPointInNavigableRadius(Object WorldContextObject, Vector Origin, float Radius, NavigationData NavData, Object FilterClass) { return Invoke<Vector>(nameof(GetRandomPointInNavigableRadius), WorldContextObject, Origin, Radius, NavData, FilterClass); }
        public byte GetPathLength(Object WorldContextObject, Vector PathStart, Vector PathEnd, float PathLength, NavigationData NavData, Object FilterClass) { return Invoke<byte>(nameof(GetPathLength), WorldContextObject, PathStart, PathEnd, PathLength, NavData, FilterClass); }
        public byte GetPathCost(Object WorldContextObject, Vector PathStart, Vector PathEnd, float PathCost, NavigationData NavData, Object FilterClass) { return Invoke<byte>(nameof(GetPathCost), WorldContextObject, PathStart, PathEnd, PathCost, NavData, FilterClass); }
        public NavigationSystemV1 GetNavigationSystem(Object WorldContextObject) { return Invoke<NavigationSystemV1>(nameof(GetNavigationSystem), WorldContextObject); }
        public NavigationPath FindPathToLocationSynchronously(Object WorldContextObject, Vector PathStart, Vector PathEnd, Actor PathfindingContext, Object FilterClass) { return Invoke<NavigationPath>(nameof(FindPathToLocationSynchronously), WorldContextObject, PathStart, PathEnd, PathfindingContext, FilterClass); }
        public NavigationPath FindPathToActorSynchronously(Object WorldContextObject, Vector PathStart, Actor GoalActor, float TetherDistance, Actor PathfindingContext, Object FilterClass) { return Invoke<NavigationPath>(nameof(FindPathToActorSynchronously), WorldContextObject, PathStart, GoalActor, TetherDistance, PathfindingContext, FilterClass); }
    }
    public class NavigationSystemModuleConfig : NavigationSystemConfig
    {
        public NavigationSystemModuleConfig(ulong addr) : base(addr) { }
        public bool bStrictlyStatic { get { return this[nameof(bStrictlyStatic)].Flag; } set { this[nameof(bStrictlyStatic)].Flag = value; } }
        public bool bCreateOnClient { get { return this[nameof(bCreateOnClient)].Flag; } set { this[nameof(bCreateOnClient)].Flag = value; } }
        public bool bAutoSpawnMissingNavData { get { return this[nameof(bAutoSpawnMissingNavData)].Flag; } set { this[nameof(bAutoSpawnMissingNavData)].Flag = value; } }
        public bool bSpawnNavDataInNavBoundsLevel { get { return this[nameof(bSpawnNavDataInNavBoundsLevel)].Flag; } set { this[nameof(bSpawnNavDataInNavBoundsLevel)].Flag = value; } }
    }
    public class NavigationTestingActor : Actor
    {
        public NavigationTestingActor(ulong addr) : base(addr) { }
        public CapsuleComponent CapsuleComponent { get { return this[nameof(CapsuleComponent)].As<CapsuleComponent>(); } set { this["CapsuleComponent"] = value; } }
        public NavigationInvokerComponent InvokerComponent { get { return this[nameof(InvokerComponent)].As<NavigationInvokerComponent>(); } set { this["InvokerComponent"] = value; } }
        public bool bActAsNavigationInvoker { get { return this[nameof(bActAsNavigationInvoker)].Flag; } set { this[nameof(bActAsNavigationInvoker)].Flag = value; } }
        public NavAgentProperties NavAgentProps { get { return this[nameof(NavAgentProps)].As<NavAgentProperties>(); } set { this["NavAgentProps"] = value; } }
        public Vector QueryingExtent { get { return this[nameof(QueryingExtent)].As<Vector>(); } set { this["QueryingExtent"] = value; } }
        public NavigationData MyNavData { get { return this[nameof(MyNavData)].As<NavigationData>(); } set { this["MyNavData"] = value; } }
        public Vector ProjectedLocation { get { return this[nameof(ProjectedLocation)].As<Vector>(); } set { this["ProjectedLocation"] = value; } }
        public bool bProjectedLocationValid { get { return this[nameof(bProjectedLocationValid)].Flag; } set { this[nameof(bProjectedLocationValid)].Flag = value; } }
        public bool bSearchStart { get { return this[nameof(bSearchStart)].Flag; } set { this[nameof(bSearchStart)].Flag = value; } }
        public float CostLimitFactor { get { return this[nameof(CostLimitFactor)].GetValue<float>(); } set { this[nameof(CostLimitFactor)].SetValue<float>(value); } }
        public float MinimumCostLimit { get { return this[nameof(MinimumCostLimit)].GetValue<float>(); } set { this[nameof(MinimumCostLimit)].SetValue<float>(value); } }
        public bool bBacktracking { get { return this[nameof(bBacktracking)].Flag; } set { this[nameof(bBacktracking)].Flag = value; } }
        public bool bUseHierarchicalPathfinding { get { return this[nameof(bUseHierarchicalPathfinding)].Flag; } set { this[nameof(bUseHierarchicalPathfinding)].Flag = value; } }
        public bool bGatherDetailedInfo { get { return this[nameof(bGatherDetailedInfo)].Flag; } set { this[nameof(bGatherDetailedInfo)].Flag = value; } }
        public bool bDrawDistanceToWall { get { return this[nameof(bDrawDistanceToWall)].Flag; } set { this[nameof(bDrawDistanceToWall)].Flag = value; } }
        public bool bShowNodePool { get { return this[nameof(bShowNodePool)].Flag; } set { this[nameof(bShowNodePool)].Flag = value; } }
        public bool bShowBestPath { get { return this[nameof(bShowBestPath)].Flag; } set { this[nameof(bShowBestPath)].Flag = value; } }
        public bool bShowDiffWithPreviousStep { get { return this[nameof(bShowDiffWithPreviousStep)].Flag; } set { this[nameof(bShowDiffWithPreviousStep)].Flag = value; } }
        public bool bShouldBeVisibleInGame { get { return this[nameof(bShouldBeVisibleInGame)].Flag; } set { this[nameof(bShouldBeVisibleInGame)].Flag = value; } }
        public byte CostDisplayMode { get { return this[nameof(CostDisplayMode)].GetValue<byte>(); } set { this[nameof(CostDisplayMode)].SetValue<byte>(value); } }
        public Vector2D TextCanvasOffset { get { return this[nameof(TextCanvasOffset)].As<Vector2D>(); } set { this["TextCanvasOffset"] = value; } }
        public bool bPathExist { get { return this[nameof(bPathExist)].Flag; } set { this[nameof(bPathExist)].Flag = value; } }
        public bool bPathIsPartial { get { return this[nameof(bPathIsPartial)].Flag; } set { this[nameof(bPathIsPartial)].Flag = value; } }
        public bool bPathSearchOutOfNodes { get { return this[nameof(bPathSearchOutOfNodes)].Flag; } set { this[nameof(bPathSearchOutOfNodes)].Flag = value; } }
        public float PathfindingTime { get { return this[nameof(PathfindingTime)].GetValue<float>(); } set { this[nameof(PathfindingTime)].SetValue<float>(value); } }
        public float PathCost { get { return this[nameof(PathCost)].GetValue<float>(); } set { this[nameof(PathCost)].SetValue<float>(value); } }
        public int PathfindingSteps { get { return this[nameof(PathfindingSteps)].GetValue<int>(); } set { this[nameof(PathfindingSteps)].SetValue<int>(value); } }
        public NavigationTestingActor OtherActor { get { return this[nameof(OtherActor)].As<NavigationTestingActor>(); } set { this["OtherActor"] = value; } }
        public Object FilterClass { get { return this[nameof(FilterClass)]; } set { this[nameof(FilterClass)] = value; } }
        public int ShowStepIndex { get { return this[nameof(ShowStepIndex)].GetValue<int>(); } set { this[nameof(ShowStepIndex)].SetValue<int>(value); } }
        public float OffsetFromCornersDistance { get { return this[nameof(OffsetFromCornersDistance)].GetValue<float>(); } set { this[nameof(OffsetFromCornersDistance)].SetValue<float>(value); } }
    }
    public class NavLinkComponent : PrimitiveComponent
    {
        public NavLinkComponent(ulong addr) : base(addr) { }
        public Array<NavigationLink> Links { get { return new Array<NavigationLink>(this[nameof(Links)].Address); } }
    }
    public class NavRelevantComponent : ActorComponent
    {
        public NavRelevantComponent(ulong addr) : base(addr) { }
        public bool bAttachToOwnersRoot { get { return this[nameof(bAttachToOwnersRoot)].Flag; } set { this[nameof(bAttachToOwnersRoot)].Flag = value; } }
        public Object CachedNavParent { get { return this[nameof(CachedNavParent)].As<Object>(); } set { this["CachedNavParent"] = value; } }
        public void SetNavigationRelevancy(bool bRelevant) { Invoke(nameof(SetNavigationRelevancy), bRelevant); }
    }
    public class NavLinkCustomComponent : NavRelevantComponent
    {
        public NavLinkCustomComponent(ulong addr) : base(addr) { }
        public uint NavLinkUserId { get { return this[nameof(NavLinkUserId)].GetValue<uint>(); } set { this[nameof(NavLinkUserId)].SetValue<uint>(value); } }
        public Object EnabledAreaClass { get { return this[nameof(EnabledAreaClass)]; } set { this[nameof(EnabledAreaClass)] = value; } }
        public Object DisabledAreaClass { get { return this[nameof(DisabledAreaClass)]; } set { this[nameof(DisabledAreaClass)] = value; } }
        public NavAgentSelector SupportedAgents { get { return this[nameof(SupportedAgents)].As<NavAgentSelector>(); } set { this["SupportedAgents"] = value; } }
        public Vector LinkRelativeStart { get { return this[nameof(LinkRelativeStart)].As<Vector>(); } set { this["LinkRelativeStart"] = value; } }
        public Vector LinkRelativeEnd { get { return this[nameof(LinkRelativeEnd)].As<Vector>(); } set { this["LinkRelativeEnd"] = value; } }
        public byte LinkDirection { get { return this[nameof(LinkDirection)].GetValue<byte>(); } set { this[nameof(LinkDirection)].SetValue<byte>(value); } }
        public bool bLinkEnabled { get { return this[nameof(bLinkEnabled)].Flag; } set { this[nameof(bLinkEnabled)].Flag = value; } }
        public bool bNotifyWhenEnabled { get { return this[nameof(bNotifyWhenEnabled)].Flag; } set { this[nameof(bNotifyWhenEnabled)].Flag = value; } }
        public bool bNotifyWhenDisabled { get { return this[nameof(bNotifyWhenDisabled)].Flag; } set { this[nameof(bNotifyWhenDisabled)].Flag = value; } }
        public bool bCreateBoxObstacle { get { return this[nameof(bCreateBoxObstacle)].Flag; } set { this[nameof(bCreateBoxObstacle)].Flag = value; } }
        public Vector ObstacleOffset { get { return this[nameof(ObstacleOffset)].As<Vector>(); } set { this["ObstacleOffset"] = value; } }
        public Vector ObstacleExtent { get { return this[nameof(ObstacleExtent)].As<Vector>(); } set { this["ObstacleExtent"] = value; } }
        public Object ObstacleAreaClass { get { return this[nameof(ObstacleAreaClass)]; } set { this[nameof(ObstacleAreaClass)] = value; } }
        public float BroadcastRadius { get { return this[nameof(BroadcastRadius)].GetValue<float>(); } set { this[nameof(BroadcastRadius)].SetValue<float>(value); } }
        public float BroadcastInterval { get { return this[nameof(BroadcastInterval)].GetValue<float>(); } set { this[nameof(BroadcastInterval)].SetValue<float>(value); } }
        public byte BroadcastChannel { get { return this[nameof(BroadcastChannel)].GetValue<byte>(); } set { this[nameof(BroadcastChannel)].SetValue<byte>(value); } }
    }
    public class NavLinkCustomInterface : Interface
    {
        public NavLinkCustomInterface(ulong addr) : base(addr) { }
    }
    public class NavLinkHostInterface : Interface
    {
        public NavLinkHostInterface(ulong addr) : base(addr) { }
    }
    public class NavLinkRenderingComponent : PrimitiveComponent
    {
        public NavLinkRenderingComponent(ulong addr) : base(addr) { }
    }
    public class NavLinkTrivial : NavLinkDefinition
    {
        public NavLinkTrivial(ulong addr) : base(addr) { }
    }
    public class NavMeshBoundsVolume : Volume
    {
        public NavMeshBoundsVolume(ulong addr) : base(addr) { }
        public NavAgentSelector SupportedAgents { get { return this[nameof(SupportedAgents)].As<NavAgentSelector>(); } set { this["SupportedAgents"] = value; } }
    }
    public class NavMeshRenderingComponent : PrimitiveComponent
    {
        public NavMeshRenderingComponent(ulong addr) : base(addr) { }
    }
    public class NavModifierComponent : NavRelevantComponent
    {
        public NavModifierComponent(ulong addr) : base(addr) { }
        public Object AreaClass { get { return this[nameof(AreaClass)]; } set { this[nameof(AreaClass)] = value; } }
        public Vector FailsafeExtent { get { return this[nameof(FailsafeExtent)].As<Vector>(); } set { this["FailsafeExtent"] = value; } }
        public bool bIncludeAgentHeight { get { return this[nameof(bIncludeAgentHeight)].Flag; } set { this[nameof(bIncludeAgentHeight)].Flag = value; } }
        public void SetAreaClass(Object NewAreaClass) { Invoke(nameof(SetAreaClass), NewAreaClass); }
    }
    public class NavModifierVolume : Volume
    {
        public NavModifierVolume(ulong addr) : base(addr) { }
        public Object AreaClass { get { return this[nameof(AreaClass)]; } set { this[nameof(AreaClass)] = value; } }
        public void SetAreaClass(Object NewAreaClass) { Invoke(nameof(SetAreaClass), NewAreaClass); }
    }
    public class NavNodeInterface : Interface
    {
        public NavNodeInterface(ulong addr) : base(addr) { }
    }
    public class NavSystemConfigOverride : Actor
    {
        public NavSystemConfigOverride(ulong addr) : base(addr) { }
        public NavigationSystemConfig NavigationSystemConfig { get { return this[nameof(NavigationSystemConfig)].As<NavigationSystemConfig>(); } set { this["NavigationSystemConfig"] = value; } }
        public ENavSystemOverridePolicy OverridePolicy { get { return (ENavSystemOverridePolicy)this[nameof(OverridePolicy)].GetValue<int>(); } set { this[nameof(OverridePolicy)].SetValue<int>((int)value); } }
        public bool bLoadOnClient { get { return this[nameof(bLoadOnClient)].Flag; } set { this[nameof(bLoadOnClient)].Flag = value; } }
    }
    public class NavTestRenderingComponent : PrimitiveComponent
    {
        public NavTestRenderingComponent(ulong addr) : base(addr) { }
    }
    public class RecastFilter_UseDefaultArea : NavigationQueryFilter
    {
        public RecastFilter_UseDefaultArea(ulong addr) : base(addr) { }
    }
    public class RecastNavMesh : NavigationData
    {
        public RecastNavMesh(ulong addr) : base(addr) { }
        public bool bDrawTriangleEdges { get { return this[nameof(bDrawTriangleEdges)].Flag; } set { this[nameof(bDrawTriangleEdges)].Flag = value; } }
        public bool bDrawPolyEdges { get { return this[nameof(bDrawPolyEdges)].Flag; } set { this[nameof(bDrawPolyEdges)].Flag = value; } }
        public bool bDrawFilledPolys { get { return this[nameof(bDrawFilledPolys)].Flag; } set { this[nameof(bDrawFilledPolys)].Flag = value; } }
        public bool bDrawNavMeshEdges { get { return this[nameof(bDrawNavMeshEdges)].Flag; } set { this[nameof(bDrawNavMeshEdges)].Flag = value; } }
        public bool bDrawTileBounds { get { return this[nameof(bDrawTileBounds)].Flag; } set { this[nameof(bDrawTileBounds)].Flag = value; } }
        public bool bDrawPathCollidingGeometry { get { return this[nameof(bDrawPathCollidingGeometry)].Flag; } set { this[nameof(bDrawPathCollidingGeometry)].Flag = value; } }
        public bool bDrawTileLabels { get { return this[nameof(bDrawTileLabels)].Flag; } set { this[nameof(bDrawTileLabels)].Flag = value; } }
        public bool bDrawPolygonLabels { get { return this[nameof(bDrawPolygonLabels)].Flag; } set { this[nameof(bDrawPolygonLabels)].Flag = value; } }
        public bool bDrawDefaultPolygonCost { get { return this[nameof(bDrawDefaultPolygonCost)].Flag; } set { this[nameof(bDrawDefaultPolygonCost)].Flag = value; } }
        public bool bDrawLabelsOnPathNodes { get { return this[nameof(bDrawLabelsOnPathNodes)].Flag; } set { this[nameof(bDrawLabelsOnPathNodes)].Flag = value; } }
        public bool bDrawNavLinks { get { return this[nameof(bDrawNavLinks)].Flag; } set { this[nameof(bDrawNavLinks)].Flag = value; } }
        public bool bDrawFailedNavLinks { get { return this[nameof(bDrawFailedNavLinks)].Flag; } set { this[nameof(bDrawFailedNavLinks)].Flag = value; } }
        public bool bDrawClusters { get { return this[nameof(bDrawClusters)].Flag; } set { this[nameof(bDrawClusters)].Flag = value; } }
        public bool bDrawOctree { get { return this[nameof(bDrawOctree)].Flag; } set { this[nameof(bDrawOctree)].Flag = value; } }
        public bool bDrawOctreeDetails { get { return this[nameof(bDrawOctreeDetails)].Flag; } set { this[nameof(bDrawOctreeDetails)].Flag = value; } }
        public bool bDrawMarkedForbiddenPolys { get { return this[nameof(bDrawMarkedForbiddenPolys)].Flag; } set { this[nameof(bDrawMarkedForbiddenPolys)].Flag = value; } }
        public bool bDistinctlyDrawTilesBeingBuilt { get { return this[nameof(bDistinctlyDrawTilesBeingBuilt)].Flag; } set { this[nameof(bDistinctlyDrawTilesBeingBuilt)].Flag = value; } }
        public bool bDrawNavMesh { get { return this[nameof(bDrawNavMesh)].Flag; } set { this[nameof(bDrawNavMesh)].Flag = value; } }
        public float DrawOffset { get { return this[nameof(DrawOffset)].GetValue<float>(); } set { this[nameof(DrawOffset)].SetValue<float>(value); } }
        public bool bFixedTilePoolSize { get { return this[nameof(bFixedTilePoolSize)].Flag; } set { this[nameof(bFixedTilePoolSize)].Flag = value; } }
        public int TilePoolSize { get { return this[nameof(TilePoolSize)].GetValue<int>(); } set { this[nameof(TilePoolSize)].SetValue<int>(value); } }
        public float TileSizeUU { get { return this[nameof(TileSizeUU)].GetValue<float>(); } set { this[nameof(TileSizeUU)].SetValue<float>(value); } }
        public float CellSize { get { return this[nameof(CellSize)].GetValue<float>(); } set { this[nameof(CellSize)].SetValue<float>(value); } }
        public float CellHeight { get { return this[nameof(CellHeight)].GetValue<float>(); } set { this[nameof(CellHeight)].SetValue<float>(value); } }
        public float AgentRadius { get { return this[nameof(AgentRadius)].GetValue<float>(); } set { this[nameof(AgentRadius)].SetValue<float>(value); } }
        public float AgentHeight { get { return this[nameof(AgentHeight)].GetValue<float>(); } set { this[nameof(AgentHeight)].SetValue<float>(value); } }
        public float AgentMaxHeight { get { return this[nameof(AgentMaxHeight)].GetValue<float>(); } set { this[nameof(AgentMaxHeight)].SetValue<float>(value); } }
        public float AgentMaxSlope { get { return this[nameof(AgentMaxSlope)].GetValue<float>(); } set { this[nameof(AgentMaxSlope)].SetValue<float>(value); } }
        public float AgentMaxStepHeight { get { return this[nameof(AgentMaxStepHeight)].GetValue<float>(); } set { this[nameof(AgentMaxStepHeight)].SetValue<float>(value); } }
        public float MinRegionArea { get { return this[nameof(MinRegionArea)].GetValue<float>(); } set { this[nameof(MinRegionArea)].SetValue<float>(value); } }
        public float MergeRegionSize { get { return this[nameof(MergeRegionSize)].GetValue<float>(); } set { this[nameof(MergeRegionSize)].SetValue<float>(value); } }
        public float MaxSimplificationError { get { return this[nameof(MaxSimplificationError)].GetValue<float>(); } set { this[nameof(MaxSimplificationError)].SetValue<float>(value); } }
        public int MaxSimultaneousTileGenerationJobsCount { get { return this[nameof(MaxSimultaneousTileGenerationJobsCount)].GetValue<int>(); } set { this[nameof(MaxSimultaneousTileGenerationJobsCount)].SetValue<int>(value); } }
        public int TileNumberHardLimit { get { return this[nameof(TileNumberHardLimit)].GetValue<int>(); } set { this[nameof(TileNumberHardLimit)].SetValue<int>(value); } }
        public int PolyRefTileBits { get { return this[nameof(PolyRefTileBits)].GetValue<int>(); } set { this[nameof(PolyRefTileBits)].SetValue<int>(value); } }
        public int PolyRefNavPolyBits { get { return this[nameof(PolyRefNavPolyBits)].GetValue<int>(); } set { this[nameof(PolyRefNavPolyBits)].SetValue<int>(value); } }
        public int PolyRefSaltBits { get { return this[nameof(PolyRefSaltBits)].GetValue<int>(); } set { this[nameof(PolyRefSaltBits)].SetValue<int>(value); } }
        public Vector NavMeshOriginOffset { get { return this[nameof(NavMeshOriginOffset)].As<Vector>(); } set { this["NavMeshOriginOffset"] = value; } }
        public float DefaultDrawDistance { get { return this[nameof(DefaultDrawDistance)].GetValue<float>(); } set { this[nameof(DefaultDrawDistance)].SetValue<float>(value); } }
        public float DefaultMaxSearchNodes { get { return this[nameof(DefaultMaxSearchNodes)].GetValue<float>(); } set { this[nameof(DefaultMaxSearchNodes)].SetValue<float>(value); } }
        public float DefaultMaxHierarchicalSearchNodes { get { return this[nameof(DefaultMaxHierarchicalSearchNodes)].GetValue<float>(); } set { this[nameof(DefaultMaxHierarchicalSearchNodes)].SetValue<float>(value); } }
        public byte RegionPartitioning { get { return this[nameof(RegionPartitioning)].GetValue<byte>(); } set { this[nameof(RegionPartitioning)].SetValue<byte>(value); } }
        public byte LayerPartitioning { get { return this[nameof(LayerPartitioning)].GetValue<byte>(); } set { this[nameof(LayerPartitioning)].SetValue<byte>(value); } }
        public int RegionChunkSplits { get { return this[nameof(RegionChunkSplits)].GetValue<int>(); } set { this[nameof(RegionChunkSplits)].SetValue<int>(value); } }
        public int LayerChunkSplits { get { return this[nameof(LayerChunkSplits)].GetValue<int>(); } set { this[nameof(LayerChunkSplits)].SetValue<int>(value); } }
        public bool bSortNavigationAreasByCost { get { return this[nameof(bSortNavigationAreasByCost)].Flag; } set { this[nameof(bSortNavigationAreasByCost)].Flag = value; } }
        public bool bPerformVoxelFiltering { get { return this[nameof(bPerformVoxelFiltering)].Flag; } set { this[nameof(bPerformVoxelFiltering)].Flag = value; } }
        public bool bMarkLowHeightAreas { get { return this[nameof(bMarkLowHeightAreas)].Flag; } set { this[nameof(bMarkLowHeightAreas)].Flag = value; } }
        public bool bFilterLowSpanSequences { get { return this[nameof(bFilterLowSpanSequences)].Flag; } set { this[nameof(bFilterLowSpanSequences)].Flag = value; } }
        public bool bFilterLowSpanFromTileCache { get { return this[nameof(bFilterLowSpanFromTileCache)].Flag; } set { this[nameof(bFilterLowSpanFromTileCache)].Flag = value; } }
        public bool bDoFullyAsyncNavDataGathering { get { return this[nameof(bDoFullyAsyncNavDataGathering)].Flag; } set { this[nameof(bDoFullyAsyncNavDataGathering)].Flag = value; } }
        public bool bUseBetterOffsetsFromCorners { get { return this[nameof(bUseBetterOffsetsFromCorners)].Flag; } set { this[nameof(bUseBetterOffsetsFromCorners)].Flag = value; } }
        public bool bStoreEmptyTileLayers { get { return this[nameof(bStoreEmptyTileLayers)].Flag; } set { this[nameof(bStoreEmptyTileLayers)].Flag = value; } }
        public bool bUseVirtualFilters { get { return this[nameof(bUseVirtualFilters)].Flag; } set { this[nameof(bUseVirtualFilters)].Flag = value; } }
        public bool bAllowNavLinkAsPathEnd { get { return this[nameof(bAllowNavLinkAsPathEnd)].Flag; } set { this[nameof(bAllowNavLinkAsPathEnd)].Flag = value; } }
        public bool bUseVoxelCache { get { return this[nameof(bUseVoxelCache)].Flag; } set { this[nameof(bUseVoxelCache)].Flag = value; } }
        public float TileSetUpdateInterval { get { return this[nameof(TileSetUpdateInterval)].GetValue<float>(); } set { this[nameof(TileSetUpdateInterval)].SetValue<float>(value); } }
        public float HeuristicScale { get { return this[nameof(HeuristicScale)].GetValue<float>(); } set { this[nameof(HeuristicScale)].SetValue<float>(value); } }
        public float VerticalDeviationFromGroundCompensation { get { return this[nameof(VerticalDeviationFromGroundCompensation)].GetValue<float>(); } set { this[nameof(VerticalDeviationFromGroundCompensation)].SetValue<float>(value); } }
        public bool K2_ReplaceAreaInTileBounds(Box Bounds, Object OldArea, Object NewArea, bool ReplaceLinks) { return Invoke<bool>(nameof(K2_ReplaceAreaInTileBounds), Bounds, OldArea, NewArea, ReplaceLinks); }
    }
    public class RecastNavMeshDataChunk : NavigationDataChunk
    {
        public RecastNavMeshDataChunk(ulong addr) : base(addr) { }
    }
    public enum ERuntimeGenerationType : int
    {
        Static = 0,
        DynamicModifiersOnly = 1,
        Dynamic = 2,
        LegacyGeneration = 3,
        ERuntimeGenerationType_MAX = 4,
    }
    public enum ENavCostDisplay : int
    {
        TotalCost = 0,
        HeuristicOnly = 1,
        RealCostOnly = 2,
        ENavCostDisplay_MAX = 3,
    }
    public enum ENavSystemOverridePolicy : int
    {
        Override = 0,
        Append = 1,
        Skip = 2,
        ENavSystemOverridePolicy_MAX = 3,
    }
    public enum ERecastPartitioning : int
    {
        Monotone = 0,
        Watershed = 1,
        ChunkyMonotone = 2,
        ERecastPartitioning_MAX = 3,
    }
    public class NavCollisionBox : Object
    {
        public NavCollisionBox(ulong addr) : base(addr) { }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
        public Vector Extent { get { return this[nameof(Extent)].As<Vector>(); } set { this["Extent"] = value; } }
    }
    public class NavCollisionCylinder : Object
    {
        public NavCollisionCylinder(ulong addr) : base(addr) { }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Height { get { return this[nameof(Height)].GetValue<float>(); } set { this[nameof(Height)].SetValue<float>(value); } }
    }
    public class SupportedAreaData : Object
    {
        public SupportedAreaData(ulong addr) : base(addr) { }
        public Object AreaClassName { get { return this[nameof(AreaClassName)]; } set { this[nameof(AreaClassName)] = value; } }
        public int AreaID { get { return this[nameof(AreaID)].GetValue<int>(); } set { this[nameof(AreaID)].SetValue<int>(value); } }
        public Object AreaClass { get { return this[nameof(AreaClass)]; } set { this[nameof(AreaClass)] = value; } }
    }
    public class NavGraphNode : Object
    {
        public NavGraphNode(ulong addr) : base(addr) { }
        public Object Owner { get { return this[nameof(Owner)].As<Object>(); } set { this["Owner"] = value; } }
    }
    public class NavGraphEdge : Object
    {
        public NavGraphEdge(ulong addr) : base(addr) { }
    }
    public class NavigationFilterFlags : Object
    {
        public NavigationFilterFlags(ulong addr) : base(addr) { }
        public bool bNavFlag0 { get { return this[nameof(bNavFlag0)].Flag; } set { this[nameof(bNavFlag0)].Flag = value; } }
        public bool bNavFlag1 { get { return this[nameof(bNavFlag1)].Flag; } set { this[nameof(bNavFlag1)].Flag = value; } }
        public bool bNavFlag2 { get { return this[nameof(bNavFlag2)].Flag; } set { this[nameof(bNavFlag2)].Flag = value; } }
        public bool bNavFlag3 { get { return this[nameof(bNavFlag3)].Flag; } set { this[nameof(bNavFlag3)].Flag = value; } }
        public bool bNavFlag4 { get { return this[nameof(bNavFlag4)].Flag; } set { this[nameof(bNavFlag4)].Flag = value; } }
        public bool bNavFlag5 { get { return this[nameof(bNavFlag5)].Flag; } set { this[nameof(bNavFlag5)].Flag = value; } }
        public bool bNavFlag6 { get { return this[nameof(bNavFlag6)].Flag; } set { this[nameof(bNavFlag6)].Flag = value; } }
        public bool bNavFlag7 { get { return this[nameof(bNavFlag7)].Flag; } set { this[nameof(bNavFlag7)].Flag = value; } }
        public bool bNavFlag8 { get { return this[nameof(bNavFlag8)].Flag; } set { this[nameof(bNavFlag8)].Flag = value; } }
        public bool bNavFlag9 { get { return this[nameof(bNavFlag9)].Flag; } set { this[nameof(bNavFlag9)].Flag = value; } }
        public bool bNavFlag10 { get { return this[nameof(bNavFlag10)].Flag; } set { this[nameof(bNavFlag10)].Flag = value; } }
        public bool bNavFlag11 { get { return this[nameof(bNavFlag11)].Flag; } set { this[nameof(bNavFlag11)].Flag = value; } }
        public bool bNavFlag12 { get { return this[nameof(bNavFlag12)].Flag; } set { this[nameof(bNavFlag12)].Flag = value; } }
        public bool bNavFlag13 { get { return this[nameof(bNavFlag13)].Flag; } set { this[nameof(bNavFlag13)].Flag = value; } }
        public bool bNavFlag14 { get { return this[nameof(bNavFlag14)].Flag; } set { this[nameof(bNavFlag14)].Flag = value; } }
        public bool bNavFlag15 { get { return this[nameof(bNavFlag15)].Flag; } set { this[nameof(bNavFlag15)].Flag = value; } }
    }
    public class NavigationFilterArea : Object
    {
        public NavigationFilterArea(ulong addr) : base(addr) { }
        public Object AreaClass { get { return this[nameof(AreaClass)]; } set { this[nameof(AreaClass)] = value; } }
        public float TravelCostOverride { get { return this[nameof(TravelCostOverride)].GetValue<float>(); } set { this[nameof(TravelCostOverride)].SetValue<float>(value); } }
        public float EnteringCostOverride { get { return this[nameof(EnteringCostOverride)].GetValue<float>(); } set { this[nameof(EnteringCostOverride)].SetValue<float>(value); } }
        public bool bIsExcluded { get { return this[nameof(bIsExcluded)].Flag; } set { this[nameof(bIsExcluded)].Flag = value; } }
        public bool bOverrideTravelCost { get { return this[nameof(bOverrideTravelCost)].Flag; } set { this[nameof(bOverrideTravelCost)].Flag = value; } }
        public bool bOverrideEnteringCost { get { return this[nameof(bOverrideEnteringCost)].Flag; } set { this[nameof(bOverrideEnteringCost)].Flag = value; } }
    }
    public class NavLinkCustomInstanceData : ActorComponentInstanceData
    {
        public NavLinkCustomInstanceData(ulong addr) : base(addr) { }
        public uint NavLinkUserId { get { return this[nameof(NavLinkUserId)].GetValue<uint>(); } set { this[nameof(NavLinkUserId)].SetValue<uint>(value); } }
    }
    public class RecastNavMeshGenerationProperties : Object
    {
        public RecastNavMeshGenerationProperties(ulong addr) : base(addr) { }
        public int TilePoolSize { get { return this[nameof(TilePoolSize)].GetValue<int>(); } set { this[nameof(TilePoolSize)].SetValue<int>(value); } }
        public float TileSizeUU { get { return this[nameof(TileSizeUU)].GetValue<float>(); } set { this[nameof(TileSizeUU)].SetValue<float>(value); } }
        public float CellSize { get { return this[nameof(CellSize)].GetValue<float>(); } set { this[nameof(CellSize)].SetValue<float>(value); } }
        public float CellHeight { get { return this[nameof(CellHeight)].GetValue<float>(); } set { this[nameof(CellHeight)].SetValue<float>(value); } }
        public float AgentRadius { get { return this[nameof(AgentRadius)].GetValue<float>(); } set { this[nameof(AgentRadius)].SetValue<float>(value); } }
        public float AgentHeight { get { return this[nameof(AgentHeight)].GetValue<float>(); } set { this[nameof(AgentHeight)].SetValue<float>(value); } }
        public float AgentMaxSlope { get { return this[nameof(AgentMaxSlope)].GetValue<float>(); } set { this[nameof(AgentMaxSlope)].SetValue<float>(value); } }
        public float AgentMaxStepHeight { get { return this[nameof(AgentMaxStepHeight)].GetValue<float>(); } set { this[nameof(AgentMaxStepHeight)].SetValue<float>(value); } }
        public float MinRegionArea { get { return this[nameof(MinRegionArea)].GetValue<float>(); } set { this[nameof(MinRegionArea)].SetValue<float>(value); } }
        public float MergeRegionSize { get { return this[nameof(MergeRegionSize)].GetValue<float>(); } set { this[nameof(MergeRegionSize)].SetValue<float>(value); } }
        public float MaxSimplificationError { get { return this[nameof(MaxSimplificationError)].GetValue<float>(); } set { this[nameof(MaxSimplificationError)].SetValue<float>(value); } }
        public int TileNumberHardLimit { get { return this[nameof(TileNumberHardLimit)].GetValue<int>(); } set { this[nameof(TileNumberHardLimit)].SetValue<int>(value); } }
        public byte RegionPartitioning { get { return this[nameof(RegionPartitioning)].GetValue<byte>(); } set { this[nameof(RegionPartitioning)].SetValue<byte>(value); } }
        public byte LayerPartitioning { get { return this[nameof(LayerPartitioning)].GetValue<byte>(); } set { this[nameof(LayerPartitioning)].SetValue<byte>(value); } }
        public int RegionChunkSplits { get { return this[nameof(RegionChunkSplits)].GetValue<int>(); } set { this[nameof(RegionChunkSplits)].SetValue<int>(value); } }
        public int LayerChunkSplits { get { return this[nameof(LayerChunkSplits)].GetValue<int>(); } set { this[nameof(LayerChunkSplits)].SetValue<int>(value); } }
        public bool bSortNavigationAreasByCost { get { return this[nameof(bSortNavigationAreasByCost)].Flag; } set { this[nameof(bSortNavigationAreasByCost)].Flag = value; } }
        public bool bPerformVoxelFiltering { get { return this[nameof(bPerformVoxelFiltering)].Flag; } set { this[nameof(bPerformVoxelFiltering)].Flag = value; } }
        public bool bMarkLowHeightAreas { get { return this[nameof(bMarkLowHeightAreas)].Flag; } set { this[nameof(bMarkLowHeightAreas)].Flag = value; } }
        public bool bFilterLowSpanSequences { get { return this[nameof(bFilterLowSpanSequences)].Flag; } set { this[nameof(bFilterLowSpanSequences)].Flag = value; } }
        public bool bFilterLowSpanFromTileCache { get { return this[nameof(bFilterLowSpanFromTileCache)].Flag; } set { this[nameof(bFilterLowSpanFromTileCache)].Flag = value; } }
        public bool bFixedTilePoolSize { get { return this[nameof(bFixedTilePoolSize)].Flag; } set { this[nameof(bFixedTilePoolSize)].Flag = value; } }
    }
}
