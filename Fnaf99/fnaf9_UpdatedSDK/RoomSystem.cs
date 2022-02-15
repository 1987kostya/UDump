using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
namespace SDK.Script.RoomSystemSDK
{
    public class HideCueObjectInterface : Interface
    {
        public HideCueObjectInterface(ulong addr) : base(addr) { }
        public void SetupWorldCue() { Invoke(nameof(SetupWorldCue)); }
        public void ResetWorldCue() { Invoke(nameof(ResetWorldCue)); }
    }
    public class AIHideLocationInterface : Interface
    {
        public AIHideLocationInterface(ulong addr) : base(addr) { }
        public bool IsPlayerInAttackRange() { return Invoke<bool>(nameof(IsPlayerInAttackRange)); }
        public void GetHideLocationAndRotation(Vector Location, Rotator Rotation) { Invoke(nameof(GetHideLocationAndRotation), Location, Rotation); }
        public Actor GetHideCueActor() { return Invoke<Actor>(nameof(GetHideCueActor)); }
        public void GetAIEjectLocationAndRotation(Vector Location, Rotator Rotation) { Invoke(nameof(GetAIEjectLocationAndRotation), Location, Rotation); }
    }
    public class DoorInterface : Interface
    {
        public DoorInterface(ulong addr) : base(addr) { }
        public void SetSecurityLevel(int NewSecurityLevel) { Invoke(nameof(SetSecurityLevel), NewSecurityLevel); }
        public void SetDoorRequiredItem(Object ItemName) { Invoke(nameof(SetDoorRequiredItem), ItemName); }
        public void SetDoorLockPlayer(bool Lock) { Invoke(nameof(SetDoorLockPlayer), Lock); }
        public void SetDoorLockAI(bool Lock) { Invoke(nameof(SetDoorLockAI), Lock); }
        public bool IsDoorOpen() { return Invoke<bool>(nameof(IsDoorOpen)); }
        public bool IsDoorLockedForPlayer() { return Invoke<bool>(nameof(IsDoorLockedForPlayer)); }
        public bool IsDoorLockedForAI() { return Invoke<bool>(nameof(IsDoorLockedForAI)); }
        public bool HasDoorInitialized() { return Invoke<bool>(nameof(HasDoorInitialized)); }
        public void ForceDoorOpen() { Invoke(nameof(ForceDoorOpen)); }
        public void ForceDoorClose() { Invoke(nameof(ForceDoorClose)); }
    }
    public class POIBlueprintLibrary : BlueprintFunctionLibrary
    {
        public POIBlueprintLibrary(ulong addr) : base(addr) { }
        public void SetPOIVisited(POIIndex Index) { Invoke(nameof(SetPOIVisited), Index); }
        public bool IsValid(POIIndex Index) { return Invoke<bool>(nameof(IsValid), Index); }
        public bool HasPOIBeenVisited(POIIndex Index) { return Invoke<bool>(nameof(HasPOIBeenVisited), Index); }
        public void GetPOIResultsFromIndices(Array<POIIndex> Indices, Array<POIResult> Results) { Invoke(nameof(GetPOIResultsFromIndices), Indices, Results); }
        public PointOfInterestRuntimeInfo GetPOIInfoFromIndex(POIIndex Index) { return Invoke<PointOfInterestRuntimeInfo>(nameof(GetPOIInfoFromIndex), Index); }
        public void CreatePOIIndicesFromResults(Array<POIResult> Results, Array<POIIndex> Indices) { Invoke(nameof(CreatePOIIndicesFromResults), Results, Indices); }
    }
    public class POIResultBlueprintLibrary : BlueprintFunctionLibrary
    {
        public POIResultBlueprintLibrary(ulong addr) : base(addr) { }
        public bool HasPOIBeenVisited(PointOfInterestRuntimeInfo Info) { return Invoke<bool>(nameof(HasPOIBeenVisited), Info); }
    }
    public class RoomAreaBase : Actor
    {
        public RoomAreaBase(ulong addr) : base(addr) { }
        public Object MapName { get { return this[nameof(MapName)]; } set { this[nameof(MapName)] = value; } }
        public SceneComponent CharacterDetectorsRoot { get { return this[nameof(CharacterDetectorsRoot)].As<SceneComponent>(); } set { this["CharacterDetectorsRoot"] = value; } }
        public Array<BoxComponent> CharacterDetectors { get { return new Array<BoxComponent>(this[nameof(CharacterDetectors)].Address); } }
        public Object RoomEntryPoints { get { return this[nameof(RoomEntryPoints)]; } set { this[nameof(RoomEntryPoints)] = value; } }
        public Array<RoomAdjacencyInfo> AdjacentRooms { get { return new Array<RoomAdjacencyInfo>(this[nameof(AdjacentRooms)].Address); } }
        public Array<Actor> HideActors { get { return new Array<Actor>(this[nameof(HideActors)].Address); } }
        public Array<Actor> AIHideActors { get { return new Array<Actor>(this[nameof(AIHideActors)].Address); } }
        public Array<Actor> AICharactersInRoom { get { return new Array<Actor>(this[nameof(AICharactersInRoom)].Address); } }
        public Array<Vector> PointsOfInterest { get { return new Array<Vector>(this[nameof(PointsOfInterest)].Address); } }
        public bool bPlayerIsInRoom { get { return this[nameof(bPlayerIsInRoom)].Flag; } set { this[nameof(bPlayerIsInRoom)].Flag = value; } }
        public void SetPOIVisited(int Index) { Invoke(nameof(SetPOIVisited), Index); }
        public void ResetPOIHeat(int Index) { Invoke(nameof(ResetPOIHeat), Index); }
        public bool IsLocationInRoom(Vector Location) { return Invoke<bool>(nameof(IsLocationInRoom), Location); }
        public float GetTotalRoomArea() { return Invoke<float>(nameof(GetTotalRoomArea)); }
        public Array<Vector> GetRoomPoints(float PointDelta) { return Invoke<Array<Vector>>(nameof(GetRoomPoints), PointDelta); }
        public Object GetRoomEntryPoints() { return Invoke<Object>(nameof(GetRoomEntryPoints)); }
        public Vector GetRoomEntryPoint(int EntryIndex) { return Invoke<Vector>(nameof(GetRoomEntryPoint), EntryIndex); }
        public Array<RoomAdjacencyInfo> GetRoomAdjacency(RoomAreaBase Room) { return Invoke<Array<RoomAdjacencyInfo>>(nameof(GetRoomAdjacency), Room); }
        public Vector GetRandomLocationInRoom() { return Invoke<Vector>(nameof(GetRandomLocationInRoom)); }
        public Array<PointOfInterestRuntimeInfo> GetPointsOfInterestInfo() { return Invoke<Array<PointOfInterestRuntimeInfo>>(nameof(GetPointsOfInterestInfo)); }
        public Array<Vector> GetPointsOfInterest() { return Invoke<Array<Vector>>(nameof(GetPointsOfInterest)); }
        public PointOfInterestRuntimeInfo GetPointOfInterestInfoByIndex(int Index) { return Invoke<PointOfInterestRuntimeInfo>(nameof(GetPointOfInterestInfoByIndex), Index); }
        public float GetPlayerHeat() { return Invoke<float>(nameof(GetPlayerHeat)); }
        public Object GetMapName() { return Invoke<Object>(nameof(GetMapName)); }
        public Array<Actor> GetDoors() { return Invoke<Array<Actor>>(nameof(GetDoors)); }
        public Array<BoxComponent> GetDetectors() { return Invoke<Array<BoxComponent>>(nameof(GetDetectors)); }
        public SceneComponent GetCharacterDetectorRoot() { return Invoke<SceneComponent>(nameof(GetCharacterDetectorRoot)); }
        public Array<Actor> GetAllHideActors() { return Invoke<Array<Actor>>(nameof(GetAllHideActors)); }
        public Array<Actor> GetAllAIHideActors() { return Invoke<Array<Actor>>(nameof(GetAllAIHideActors)); }
        public Array<RoomAdjacencyInfo> GetAllAdjacentRooms() { return Invoke<Array<RoomAdjacencyInfo>>(nameof(GetAllAdjacentRooms)); }
        public Array<RoomAdjacencyInfo> GetAllAdjacentRoomInfos() { return Invoke<Array<RoomAdjacencyInfo>>(nameof(GetAllAdjacentRoomInfos)); }
        public float GetAIHeat() { return Invoke<float>(nameof(GetAIHeat)); }
        public RoomAdjacencyInfo GetAdjacentInfoFromDoor(Actor Door) { return Invoke<RoomAdjacencyInfo>(nameof(GetAdjacentInfoFromDoor), Door); }
        public void ClearPOIVisited(int Index) { Invoke(nameof(ClearPOIVisited), Index); }
        public void AdjustPOIHeat(int Index, float Amount) { Invoke(nameof(AdjustPOIHeat), Index, Amount); }
    }
    public class RoomSystem : WorldSubsystem
    {
        public RoomSystem(ulong addr) : base(addr) { }
        public Object OnPlayerEnteredRoom { get { return this[nameof(OnPlayerEnteredRoom)]; } set { this[nameof(OnPlayerEnteredRoom)] = value; } }
        public Object OnPlayerExitedRoom { get { return this[nameof(OnPlayerExitedRoom)]; } set { this[nameof(OnPlayerExitedRoom)] = value; } }
        public Object OnRoomLoaded { get { return this[nameof(OnRoomLoaded)]; } set { this[nameof(OnRoomLoaded)] = value; } }
        public Object OnRoomUnloaded { get { return this[nameof(OnRoomUnloaded)]; } set { this[nameof(OnRoomUnloaded)] = value; } }
        public void StartRoomSystem() { Invoke(nameof(StartRoomSystem)); }
        public Array<POIResult> RemovePOIsFromArray(Array<POIIndex> POIsToRemove, Array<POIResult> POIArray) { return Invoke<Array<POIResult>>(nameof(RemovePOIsFromArray), POIsToRemove, POIArray); }
        public void PlayerExitedRoom(RoomAreaBase RoomExited) { Invoke(nameof(PlayerExitedRoom), RoomExited); }
        public void PlayerEnteredRoom(RoomAreaBase RoomEntered) { Invoke(nameof(PlayerEnteredRoom), RoomEntered); }
        public bool IsPlayerInRoom(Actor Room) { return Invoke<bool>(nameof(IsPlayerInRoom), Room); }
        public void GetWeightedRandomPOIFromArray(Array<POIResult> POIArray, bool bOutValid, POIResult OutResult) { Invoke(nameof(GetWeightedRandomPOIFromArray), POIArray, bOutValid, OutResult); }
        public RoomAreaBase GetRoomAtLocation(Vector Location) { return Invoke<RoomAreaBase>(nameof(GetRoomAtLocation), Location); }
        public void GetPOIsInRange(Vector WorldLocation, float Radius, Array<POIResult> OutPointIndices) { Invoke(nameof(GetPOIsInRange), WorldLocation, Radius, OutPointIndices); }
        public void GetPOIsInNavigableRange(Pawn NavigationPawn, float Radius, Array<POIResult> OutPOIs, LatentActionInfo LatentActionInfo) { Invoke(nameof(GetPOIsInNavigableRange), NavigationPawn, Radius, OutPOIs, LatentActionInfo); }
        public float GetPlayerVisitAgeForRoom(Actor Room) { return Invoke<float>(nameof(GetPlayerVisitAgeForRoom), Room); }
        public float GetPlayerTimeInRoom(Actor Room) { return Invoke<float>(nameof(GetPlayerTimeInRoom), Room); }
        public void GetPlayerRoomInfo(Actor Room, PlayerRoomInfo RoomInfo, bool Found) { Invoke(nameof(GetPlayerRoomInfo), Room, RoomInfo, Found); }
        public Array<RoomAreaBase> GetPlayerCurrentRooms() { return Invoke<Array<RoomAreaBase>>(nameof(GetPlayerCurrentRooms)); }
        public void GetHighestHeatPOIFromArray(Array<POIResult> POIArray, bool bValid, POIResult OutResult) { Invoke(nameof(GetHighestHeatPOIFromArray), POIArray, bValid, OutResult); }
        public void GetClosestPointOfInterest(Vector WorldLocation, bool bOutValid, POIResult OutResult) { Invoke(nameof(GetClosestPointOfInterest), WorldLocation, bOutValid, OutResult); }
        public Object GetAllRoomDistancesFromRoom(RoomAreaBase Room) { return Invoke<Object>(nameof(GetAllRoomDistancesFromRoom), Room); }
        public Object GetAllRoomDistancesFromPlayerRoom() { return Invoke<Object>(nameof(GetAllRoomDistancesFromPlayerRoom)); }
        public void AdjustClosestPointOfInterestHeat(Vector WorldLocation, float Amount) { Invoke(nameof(AdjustClosestPointOfInterestHeat), WorldLocation, Amount); }
    }
    public class RoomSystemSettings : DeveloperSettings
    {
        public RoomSystemSettings(ulong addr) : base(addr) { }
        public float PlayerRoomHeatIncreaseRate { get { return this[nameof(PlayerRoomHeatIncreaseRate)].GetValue<float>(); } set { this[nameof(PlayerRoomHeatIncreaseRate)].SetValue<float>(value); } }
        public float PlayerRoomHeatDecayRate { get { return this[nameof(PlayerRoomHeatDecayRate)].GetValue<float>(); } set { this[nameof(PlayerRoomHeatDecayRate)].SetValue<float>(value); } }
        public float PlayerRoomRecentDecay { get { return this[nameof(PlayerRoomRecentDecay)].GetValue<float>(); } set { this[nameof(PlayerRoomRecentDecay)].SetValue<float>(value); } }
        public float AIRoomHeatIncreaseRate { get { return this[nameof(AIRoomHeatIncreaseRate)].GetValue<float>(); } set { this[nameof(AIRoomHeatIncreaseRate)].SetValue<float>(value); } }
        public float AIRoomHeatDecayRate { get { return this[nameof(AIRoomHeatDecayRate)].GetValue<float>(); } set { this[nameof(AIRoomHeatDecayRate)].SetValue<float>(value); } }
        public float MaxPOIHeat { get { return this[nameof(MaxPOIHeat)].GetValue<float>(); } set { this[nameof(MaxPOIHeat)].SetValue<float>(value); } }
        public float POINearIncreasePerSecond { get { return this[nameof(POINearIncreasePerSecond)].GetValue<float>(); } set { this[nameof(POINearIncreasePerSecond)].SetValue<float>(value); } }
        public float POIHeatIncreaseOnCollect { get { return this[nameof(POIHeatIncreaseOnCollect)].GetValue<float>(); } set { this[nameof(POIHeatIncreaseOnCollect)].SetValue<float>(value); } }
    }
    public class RoomVisibilityData : Object
    {
        public RoomVisibilityData(ulong addr) : base(addr) { }
        public Array<RoomVisibilityPoint> RoomVisibilityPoints { get { return new Array<RoomVisibilityPoint>(this[nameof(RoomVisibilityPoints)].Address); } }
    }
    public class RoomAdjacencyInfo : Object
    {
        public RoomAdjacencyInfo(ulong addr) : base(addr) { }
        public Object Room { get { return this[nameof(Room)]; } set { this[nameof(Room)] = value; } }
        public Object DoorActor { get { return this[nameof(DoorActor)]; } set { this[nameof(DoorActor)] = value; } }
        public int ThisRoomPointIndex { get { return this[nameof(ThisRoomPointIndex)].GetValue<int>(); } set { this[nameof(ThisRoomPointIndex)].SetValue<int>(value); } }
        public int DestinationRoomPointIndex { get { return this[nameof(DestinationRoomPointIndex)].GetValue<int>(); } set { this[nameof(DestinationRoomPointIndex)].SetValue<int>(value); } }
        public float DistanceBetweenPoints { get { return this[nameof(DistanceBetweenPoints)].GetValue<float>(); } set { this[nameof(DistanceBetweenPoints)].SetValue<float>(value); } }
    }
    public class PointOfInterestRuntimeInfo : Object
    {
        public PointOfInterestRuntimeInfo(ulong addr) : base(addr) { }
        public float CurrentHeat { get { return this[nameof(CurrentHeat)].GetValue<float>(); } set { this[nameof(CurrentHeat)].SetValue<float>(value); } }
        public float VisitTime { get { return this[nameof(VisitTime)].GetValue<float>(); } set { this[nameof(VisitTime)].SetValue<float>(value); } }
        public Vector WorldLocation { get { return this[nameof(WorldLocation)].As<Vector>(); } set { this["WorldLocation"] = value; } }
    }
    public class POIVisitAge : Object
    {
        public POIVisitAge(ulong addr) : base(addr) { }
        public POIResult POI { get { return this[nameof(POI)].As<POIResult>(); } set { this["POI"] = value; } }
    }
    public class POIResult : Object
    {
        public POIResult(ulong addr) : base(addr) { }
        public POIIndex Index { get { return this[nameof(Index)].As<POIIndex>(); } set { this["Index"] = value; } }
        public PointOfInterestRuntimeInfo Info { get { return this[nameof(Info)].As<PointOfInterestRuntimeInfo>(); } set { this["Info"] = value; } }
    }
    public class POIIndex : Object
    {
        public POIIndex(ulong addr) : base(addr) { }
        public RoomAreaBase Room { get { return this[nameof(Room)].As<RoomAreaBase>(); } set { this["Room"] = value; } }
        public int Index { get { return this[nameof(Index)].GetValue<int>(); } set { this[nameof(Index)].SetValue<int>(value); } }
    }
    public class PlayerRoomInfo : Object
    {
        public PlayerRoomInfo(ulong addr) : base(addr) { }
        public float LastVisitTime { get { return this[nameof(LastVisitTime)].GetValue<float>(); } set { this[nameof(LastVisitTime)].SetValue<float>(value); } }
        public float PlayerTotalTimeSpent { get { return this[nameof(PlayerTotalTimeSpent)].GetValue<float>(); } set { this[nameof(PlayerTotalTimeSpent)].SetValue<float>(value); } }
        public float PlayerTimeSpentRecent { get { return this[nameof(PlayerTimeSpentRecent)].GetValue<float>(); } set { this[nameof(PlayerTimeSpentRecent)].SetValue<float>(value); } }
    }
    public class RoomVisibilityPoint : Object
    {
        public RoomVisibilityPoint(ulong addr) : base(addr) { }
        public Vector WorldLocation { get { return this[nameof(WorldLocation)].As<Vector>(); } set { this["WorldLocation"] = value; } }
        public Array<int> IndexToVisiblePoints { get { return new Array<int>(this[nameof(IndexToVisiblePoints)].Address); } }
    }
}
