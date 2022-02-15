using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.EngineSDK;
using SDK.Script.RoomSystemSDK;
using SDK.Script.AIModuleSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.UMGSDK;
using SDK.Script.RandomItemSystemSDK;
using SDK.Script.SlateCoreSDK;
namespace SDK.Script.fnaf9SDK
{
    public class AIHiderInterface : Interface
    {
        public AIHiderInterface(ulong addr) : base(addr) { }
        public void ExitHideMode(Actor HideActor) { Invoke(nameof(ExitHideMode), HideActor); }
        public void EnterHideMode(Actor HideActor) { Invoke(nameof(EnterHideMode), HideActor); }
    }
    public class AIManagementSystem : WorldSubsystem
    {
        public AIManagementSystem(ulong addr) : base(addr) { }
        public bool EnableDebugCloak { get { return this[nameof(EnableDebugCloak)].Flag; } set { this[nameof(EnableDebugCloak)].Flag = value; } }
        public Object OnAISpawned { get { return this[nameof(OnAISpawned)]; } set { this[nameof(OnAISpawned)] = value; } }
        public Array<Pawn> CurrentPawnAlertList { get { return new Array<Pawn>(this[nameof(CurrentPawnAlertList)].Address); } }
        public void UnregisterSeekerPath(Object SeekerPatrolPath) { Invoke(nameof(UnregisterSeekerPath), SeekerPatrolPath); }
        public void UnRegisterAI(Pawn AIPawn) { Invoke(nameof(UnRegisterAI), AIPawn); }
        public void UnpauseManager() { Invoke(nameof(UnpauseManager)); }
        public void StoreEndoStates() { Invoke(nameof(StoreEndoStates)); }
        public void StartManager() { Invoke(nameof(StartManager)); }
        public void SpawnVannyOrVanessa(bool bSpawnVanny, bool bOutSpawned, LatentActionInfo LatentActionInfo) { Invoke(nameof(SpawnVannyOrVanessa), bSpawnVanny, bOutSpawned, LatentActionInfo); }
        public void SpawnSpecificAIAtSpawnPoint(FNAFAISpawnPoint SpawnPoint, EFNAFAISpawnType AIType, bool ForceShattered) { Invoke(nameof(SpawnSpecificAIAtSpawnPoint), SpawnPoint, AIType, ForceShattered); }
        public Pawn SpawnAIWithTransformAndPath(EFNAFAISpawnType AIType, bool bForceShattered, Transform SpawnTransform, Object PathName) { return Invoke<Pawn>(nameof(SpawnAIWithTransformAndPath), AIType, bForceShattered, SpawnTransform, PathName); }
        public Pawn SpawnAITypeWithTransformSafe(EFNAFAISpawnType AIType, Transform SpawnTransform, bool ForceShattered, bool success, ESpawnActorCollisionHandlingMethod CollisionOverrideMethod, Actor Owner, bool bForceRespawn) { return Invoke<Pawn>(nameof(SpawnAITypeWithTransformSafe), AIType, SpawnTransform, ForceShattered, success, CollisionOverrideMethod, Owner, bForceRespawn); }
        public Pawn SpawnAITypeWithTransform(EFNAFAISpawnType AIType, Transform SpawnTransform, bool ForceShattered, ESpawnActorCollisionHandlingMethod CollisionOverrideMethod, Actor Owner) { return Invoke<Pawn>(nameof(SpawnAITypeWithTransform), AIType, SpawnTransform, ForceShattered, CollisionOverrideMethod, Owner); }
        public Pawn SpawnAITypeAtLocation(EFNAFAISpawnType AIType, Vector SpawnLocation, bool ForceShattered) { return Invoke<Pawn>(nameof(SpawnAITypeAtLocation), AIType, SpawnLocation, ForceShattered); }
        public Pawn SpawnAIOnPathNearLocation(EFNAFAISpawnType AIType, Vector Location, Object PathName) { return Invoke<Pawn>(nameof(SpawnAIOnPathNearLocation), AIType, Location, PathName); }
        public Pawn SpawnAIOnPath(EFNAFAISpawnType AIType, bool bForceShattered, Object PathName) { return Invoke<Pawn>(nameof(SpawnAIOnPath), AIType, bForceShattered, PathName); }
        public void SpawnAINearPlayer() { Invoke(nameof(SpawnAINearPlayer)); }
        public void SpawnAIFar() { Invoke(nameof(SpawnAIFar)); }
        public void SpawnAIAtSpawnPoint(FNAFAISpawnPoint SpawnPoint, bool bForceShattered) { Invoke(nameof(SpawnAIAtSpawnPoint), SpawnPoint, bForceShattered); }
        public void SpawnAIAtDistance(float Distance) { Invoke(nameof(SpawnAIAtDistance), Distance); }
        public void SetWorldSpawnEnabled(bool bEnable) { Invoke(nameof(SetWorldSpawnEnabled), bEnable); }
        public void SetVanessaSpawnEnable(bool bEnable) { Invoke(nameof(SetVanessaSpawnEnable), bEnable); }
        public void SetUseStagedSpawns(bool enable) { Invoke(nameof(SetUseStagedSpawns), enable); }
        public void SetSpawningEnabled(bool enable) { Invoke(nameof(SetSpawningEnabled), enable); }
        public void SetExpectedAI(Array<AnimatronicExpectedData> AITypes) { Invoke(nameof(SetExpectedAI), AITypes); }
        public void SetAllAIExpected() { Invoke(nameof(SetAllAIExpected)); }
        public void SetAITeleportEnabled(bool bEnable) { Invoke(nameof(SetAITeleportEnabled), bEnable); }
        public void SendVanessaAlert(Array<EFNAFAISpawnType> TypesToAlert, int NumberToAlert) { Invoke(nameof(SendVanessaAlert), TypesToAlert, NumberToAlert); }
        public void SendGeneralAlert(Vector AlertLocation, Array<EFNAFAISpawnType> TypesToAlert, int NumberToAlert) { Invoke(nameof(SendGeneralAlert), AlertLocation, TypesToAlert, NumberToAlert); }
        public void RespawnEndos() { Invoke(nameof(RespawnEndos)); }
        public void RespawnAnimatronics() { Invoke(nameof(RespawnAnimatronics)); }
        public void RespawnAllAI() { Invoke(nameof(RespawnAllAI)); }
        public void Reset() { Invoke(nameof(Reset)); }
        public void RemoveExpectedAI(EFNAFAISpawnType AIType) { Invoke(nameof(RemoveExpectedAI), AIType); }
        public void RemoveCharacterByType(EFNAFAISpawnType AIType) { Invoke(nameof(RemoveCharacterByType), AIType); }
        public void RemoveAllCharacters() { Invoke(nameof(RemoveAllCharacters)); }
        public void RegisterSeekerPath(Object SeekerPatrolPath) { Invoke(nameof(RegisterSeekerPath), SeekerPatrolPath); }
        public void RegisterAI(Pawn AIPawn) { Invoke(nameof(RegisterAI), AIPawn); }
        public void PawnExitedRoom(Pawn AIPawn, RoomAreaBase Room) { Invoke(nameof(PawnExitedRoom), AIPawn, Room); }
        public void PawnEnteringRoom(Pawn AIPawn, RoomAreaBase Room) { Invoke(nameof(PawnEnteringRoom), AIPawn, Room); }
        public void PawnEnteredRoom(Pawn AIPawn, RoomAreaBase Room) { Invoke(nameof(PawnEnteredRoom), AIPawn, Room); }
        public void PauseManager() { Invoke(nameof(PauseManager)); }
        public void OnWorldStateChanged(EFNAFGameState NewState, EFNAFGameState OldState) { Invoke(nameof(OnWorldStateChanged), NewState, OldState); }
        public void OnVannyPathsCollected() { Invoke(nameof(OnVannyPathsCollected)); }
        public void OnPawnEndPlay(Actor DestroyedPawn, byte EndPlayReason) { Invoke(nameof(OnPawnEndPlay), DestroyedPawn, EndPlayReason); }
        public void OnAlertDistancesCollected() { Invoke(nameof(OnAlertDistancesCollected)); }
        public void OnAIFellOutOfWorld(Pawn AIPawn) { Invoke(nameof(OnAIFellOutOfWorld), AIPawn); }
        public bool IsWorldSpawnEnabled() { return Invoke<bool>(nameof(IsWorldSpawnEnabled)); }
        public bool IsUsingStagedSpawns() { return Invoke<bool>(nameof(IsUsingStagedSpawns)); }
        public bool IsSpawningEnabled() { return Invoke<bool>(nameof(IsSpawningEnabled)); }
        public bool IsRoomOccupied(RoomAreaBase Room) { return Invoke<bool>(nameof(IsRoomOccupied), Room); }
        public bool IsRoomBeingEntered(RoomAreaBase Room) { return Invoke<bool>(nameof(IsRoomBeingEntered), Room); }
        public bool IsAITeleportEnabled() { return Invoke<bool>(nameof(IsAITeleportEnabled)); }
        public float GetTimeSinceLastEncounter() { return Invoke<float>(nameof(GetTimeSinceLastEncounter)); }
        public Object GetRoomDistancesToPlayer() { return Invoke<Object>(nameof(GetRoomDistancesToPlayer)); }
        public RoomAreaBase GetRoomAIPawnIsIn(Pawn AIPawn) { return Invoke<RoomAreaBase>(nameof(GetRoomAIPawnIsIn), AIPawn); }
        public RoomAreaBase GetRoomAIPawnIsEntering(Pawn AIPawn) { return Invoke<RoomAreaBase>(nameof(GetRoomAIPawnIsEntering), AIPawn); }
        public Pawn GetPawnForType(EFNAFAISpawnType AIType) { return Invoke<Pawn>(nameof(GetPawnForType), AIType); }
        public Object GetPawnClassForType(EFNAFAISpawnType AIType, bool bForceShattered) { return Invoke<Object>(nameof(GetPawnClassForType), AIType, bForceShattered); }
        public Object GetPathForAI(EFNAFAISpawnType AIType, Object PathName) { return Invoke<Object>(nameof(GetPathForAI), AIType, PathName); }
        public Array<EFNAFAISpawnType> GetExistingPawnTypes() { return Invoke<Array<EFNAFAISpawnType>>(nameof(GetExistingPawnTypes)); }
        public Pawn GetExistingPawn(EFNAFAISpawnType AIType) { return Invoke<Pawn>(nameof(GetExistingPawn), AIType); }
        public void GetCurrentVannyMeterValuesAsPercentage(float OutCurrentValuePercent, float OutSoftMaxPercent) { Invoke(nameof(GetCurrentVannyMeterValuesAsPercentage), OutCurrentValuePercent, OutSoftMaxPercent); }
        public void GetCurrentVannyMeterValues(float CurrentValue, float Max, float SoftMax) { Invoke(nameof(GetCurrentVannyMeterValues), CurrentValue, Max, SoftMax); }
        public float GetCurrentVannyMeterPercentage() { return Invoke<float>(nameof(GetCurrentVannyMeterPercentage)); }
        public Array<AIDistanceResult> GetCachedDistances() { return Invoke<Array<AIDistanceResult>>(nameof(GetCachedDistances)); }
        public void GetCachedDistanceFor(Pawn Pawn, bool bOutResultValid, AIDistanceResult OutResult) { Invoke(nameof(GetCachedDistanceFor), Pawn, bOutResultValid, OutResult); }
        public Array<FNAFAISpawnPoint> GetAllSpawnPointsFor(EFNAFAISpawnType AIType) { return Invoke<Array<FNAFAISpawnPoint>>(nameof(GetAllSpawnPointsFor), AIType); }
        public Array<FNAFAISpawnPoint> GetAllSpawnPoints() { return Invoke<Array<FNAFAISpawnPoint>>(nameof(GetAllSpawnPoints)); }
        public Array<Pawn> GetAllRegisteredAI() { return Invoke<Array<Pawn>>(nameof(GetAllRegisteredAI)); }
        public void GetAllAnimatronicPawns(Array<Pawn> OutAnimatronicPawns) { Invoke(nameof(GetAllAnimatronicPawns), OutAnimatronicPawns); }
        public Array<Pawn> GetAllAIInRoomAtMost(int numRooms) { return Invoke<Array<Pawn>>(nameof(GetAllAIInRoomAtMost), numRooms); }
        public Array<Pawn> GetAllAI() { return Invoke<Array<Pawn>>(nameof(GetAllAI)); }
        public Array<Pawn> GetAIPawnsWithSightToPlayer() { return Invoke<Array<Pawn>>(nameof(GetAIPawnsWithSightToPlayer)); }
        public Array<Pawn> GetAIPawnsEnteringRoom(RoomAreaBase Room) { return Invoke<Array<Pawn>>(nameof(GetAIPawnsEnteringRoom), Room); }
        public Array<Pawn> GetAIPawnInRoom(RoomAreaBase Room) { return Invoke<Array<Pawn>>(nameof(GetAIPawnInRoom), Room); }
        public FNAFAISpawnPoint FindSpawnPointClosestToDistance(float Distance) { return Invoke<FNAFAISpawnPoint>(nameof(FindSpawnPointClosestToDistance), Distance); }
        public void FindSpawnNotVisibleAtDistance(float Distance, EFNAFAISpawnType SpawnType, Pawn PawnForNavProperties, Array<FNAFAISpawnPoint> OutSpawnPointsResult, Array<float> OutDistances, LatentActionInfo LatentInfo) { Invoke(nameof(FindSpawnNotVisibleAtDistance), Distance, SpawnType, PawnForNavProperties, OutSpawnPointsResult, OutDistances, LatentInfo); }
        public bool FindRandomPatrolPointOutOfView(EFNAFAISpawnType AIType, Object PatrolPath, Vector OutLocation) { return Invoke<bool>(nameof(FindRandomPatrolPointOutOfView), AIType, PatrolPath, OutLocation); }
        public FNAFAISpawnPoint FindFurthestSpawnPoint() { return Invoke<FNAFAISpawnPoint>(nameof(FindFurthestSpawnPoint)); }
        public FNAFAISpawnPoint FindClosestSpawnPoint() { return Invoke<FNAFAISpawnPoint>(nameof(FindClosestSpawnPoint)); }
        public void FindClosestPatrolPointOutOfView(Pawn AIPawn, bool bOutResultValid, Object OutPatrolPath, Vector OutLocation, LatentActionInfo LatentActionInfo, int OutPointIndex) { Invoke(nameof(FindClosestPatrolPointOutOfView), AIPawn, bOutResultValid, OutPatrolPath, OutLocation, LatentActionInfo, OutPointIndex); }
        public void FindClosestPathPointForAI(Pawn AIPawn, bool OutResultValid, Object OutPatrolPath, int OutPointIndex, Vector OutLocation, LatentActionInfo LatentInfo) { Invoke(nameof(FindClosestPathPointForAI), AIPawn, OutResultValid, OutPatrolPath, OutPointIndex, OutLocation, LatentInfo); }
        public void ExitedHiding(Pawn AIPawn) { Invoke(nameof(ExitedHiding), AIPawn); }
        public void DestroyAllAINotVisible() { Invoke(nameof(DestroyAllAINotVisible)); }
        public void DestroyAllAIInRoomsAtleast(int RoomDist) { Invoke(nameof(DestroyAllAIInRoomsAtleast), RoomDist); }
        public void DestroyAllAI() { Invoke(nameof(DestroyAllAI)); }
        public void ClearExpectedAI() { Invoke(nameof(ClearExpectedAI)); }
        public void CalculateAllAIDistances(Array<AIDistanceResult> DistanceResults, bool bOutClosestIsValid, int ClosestIndex, LatentActionInfo LatentInfo) { Invoke(nameof(CalculateAllAIDistances), DistanceResults, bOutClosestIsValid, ClosestIndex, LatentInfo); }
        public void ApplySound(float Strength, Vector WorldLocation) { Invoke(nameof(ApplySound), Strength, WorldLocation); }
        public void ApplyCollect(Vector WorldLocation) { Invoke(nameof(ApplyCollect), WorldLocation); }
        public bool AnyPawnInPlayerRoom() { return Invoke<bool>(nameof(AnyPawnInPlayerRoom)); }
        public void AISpottedPlayer(Pawn AIPawn) { Invoke(nameof(AISpottedPlayer), AIPawn); }
        public void AILostSightOfPlayer(Pawn AIPawn) { Invoke(nameof(AILostSightOfPlayer), AIPawn); }
        public void AdjustVannyMeter(float Amount) { Invoke(nameof(AdjustVannyMeter), Amount); }
        public void AddExpectedAI(AnimatronicExpectedData AIType) { Invoke(nameof(AddExpectedAI), AIType); }
    }
    public class PathPointProvider : Interface
    {
        public PathPointProvider(ulong addr) : base(addr) { }
        public void SetPointType(int PointIndex, int PointType) { Invoke(nameof(SetPointType), PointIndex, PointType); }
        public void SetPointLocation(int PointIndex, Vector Location) { Invoke(nameof(SetPointLocation), PointIndex, Location); }
        public void RemovePointConnection(int PointIndex, int PointToDisconnectIndex) { Invoke(nameof(RemovePointConnection), PointIndex, PointToDisconnectIndex); }
        public void RemovePoint(int PointIndex) { Invoke(nameof(RemovePoint), PointIndex); }
        public int GetPointType(int PointIndex) { return Invoke<int>(nameof(GetPointType), PointIndex); }
        public Array<int> GetPointsConnectedTo(int PointIndex) { return Invoke<Array<int>>(nameof(GetPointsConnectedTo), PointIndex); }
        public Vector GetPointLocation(int PointIndex) { return Invoke<Vector>(nameof(GetPointLocation), PointIndex); }
        public LinearColor GetPointColor(int PointIndex) { return Invoke<LinearColor>(nameof(GetPointColor), PointIndex); }
        public int GetNumberOfPathPoints() { return Invoke<int>(nameof(GetNumberOfPathPoints)); }
        public Array<Object> GetAvailablePointTypes() { return Invoke<Array<Object>>(nameof(GetAvailablePointTypes)); }
        public void AddPointConnection(int PointIndex, int PointToConnectIndex) { Invoke(nameof(AddPointConnection), PointIndex, PointToConnectIndex); }
        public int AddPoint(Vector Location) { return Invoke<int>(nameof(AddPoint), Location); }
    }
    public class AIPathComponent : ActorComponent
    {
        public AIPathComponent(ulong addr) : base(addr) { }
    }
    public class AISpawnPointComponent : ArrowComponent
    {
        public AISpawnPointComponent(ulong addr) : base(addr) { }
    }
    public class PlayerTrigger : Actor
    {
        public PlayerTrigger(ulong addr) : base(addr) { }
        public Object OnPlayerTriggered { get { return this[nameof(OnPlayerTriggered)]; } set { this[nameof(OnPlayerTriggered)] = value; } }
        public BoxComponent TriggerComponent { get { return this[nameof(TriggerComponent)].As<BoxComponent>(); } set { this["TriggerComponent"] = value; } }
        public bool bUseContinuousTrigger { get { return this[nameof(bUseContinuousTrigger)].Flag; } set { this[nameof(bUseContinuousTrigger)].Flag = value; } }
        public Object SaveName { get { return this[nameof(SaveName)]; } set { this[nameof(SaveName)] = value; } }
        public bool bSaveOnTrigger { get { return this[nameof(bSaveOnTrigger)].Flag; } set { this[nameof(bSaveOnTrigger)].Flag = value; } }
        public Array<EFNAFGameType> ValidGameTypes { get { return new Array<EFNAFGameType>(this[nameof(ValidGameTypes)].Address); } }
        public bool bFixCollision { get { return this[nameof(bFixCollision)].Flag; } set { this[nameof(bFixCollision)].Flag = value; } }
        public bool bTriggerOnActorOverlap { get { return this[nameof(bTriggerOnActorOverlap)].Flag; } set { this[nameof(bTriggerOnActorOverlap)].Flag = value; } }
        public void SetTriggerActive(bool bActive) { Invoke(nameof(SetTriggerActive), bActive); }
        public void SaveActivated() { Invoke(nameof(SaveActivated)); }
        public void OnWorldObjectStateChanged(Object ObjectName, bool ObjectState) { Invoke(nameof(OnWorldObjectStateChanged), ObjectName, ObjectState); }
        public void OnTriggerStay() { Invoke(nameof(OnTriggerStay)); }
        public void OnTriggered() { Invoke(nameof(OnTriggered)); }
        public bool IsTriggerStateSet() { return Invoke<bool>(nameof(IsTriggerStateSet)); }
        public bool IsTriggerActive() { return Invoke<bool>(nameof(IsTriggerActive)); }
        public void ForceTrigger() { Invoke(nameof(ForceTrigger)); }
        public bool CanTrigger() { return Invoke<bool>(nameof(CanTrigger)); }
    }
    public class AISpawnTrigger : PlayerTrigger
    {
        public AISpawnTrigger(ulong addr) : base(addr) { }
        public Object OnAISpawnedDelegate { get { return this[nameof(OnAISpawnedDelegate)]; } set { this[nameof(OnAISpawnedDelegate)] = value; } }
        public Object OnAISpawnedFailureDelegate { get { return this[nameof(OnAISpawnedFailureDelegate)]; } set { this[nameof(OnAISpawnedFailureDelegate)] = value; } }
        public bool SpawnAnyCharacter { get { return this[nameof(SpawnAnyCharacter)].Flag; } set { this[nameof(SpawnAnyCharacter)].Flag = value; } }
        public bool ForceShattered { get { return this[nameof(ForceShattered)].Flag; } set { this[nameof(ForceShattered)].Flag = value; } }
        public Array<EFNAFAISpawnType> SpawnCharacters { get { return new Array<EFNAFAISpawnType>(this[nameof(SpawnCharacters)].Address); } }
        public ArrowComponent SpawnLocation { get { return this[nameof(SpawnLocation)].As<ArrowComponent>(); } set { this["SpawnLocation"] = value; } }
        public void OnAISpawnedFailure(Pawn SpawnedPawn) { Invoke(nameof(OnAISpawnedFailure), SpawnedPawn); }
        public void OnAISpawned(Pawn SpawnedPawn) { Invoke(nameof(OnAISpawned), SpawnedPawn); }
    }
    public class AISystemSettings : DeveloperSettings
    {
        public AISystemSettings(ulong addr) : base(addr) { }
        public Object FNAFAITypeClasses { get { return this[nameof(FNAFAITypeClasses)]; } set { this[nameof(FNAFAITypeClasses)] = value; } }
        public float MinimumSpawnDistance { get { return this[nameof(MinimumSpawnDistance)].GetValue<float>(); } set { this[nameof(MinimumSpawnDistance)].SetValue<float>(value); } }
        public float MaximumSpawnDistance { get { return this[nameof(MaximumSpawnDistance)].GetValue<float>(); } set { this[nameof(MaximumSpawnDistance)].SetValue<float>(value); } }
        public float SpawnDelayTime { get { return this[nameof(SpawnDelayTime)].GetValue<float>(); } set { this[nameof(SpawnDelayTime)].SetValue<float>(value); } }
        public float TimeBetweenSightings { get { return this[nameof(TimeBetweenSightings)].GetValue<float>(); } set { this[nameof(TimeBetweenSightings)].SetValue<float>(value); } }
        public float OutOfRangeDistance { get { return this[nameof(OutOfRangeDistance)].GetValue<float>(); } set { this[nameof(OutOfRangeDistance)].SetValue<float>(value); } }
        public float TeleportDistance { get { return this[nameof(TeleportDistance)].GetValue<float>(); } set { this[nameof(TeleportDistance)].SetValue<float>(value); } }
        public float VannyMeterIncreasePerSecond { get { return this[nameof(VannyMeterIncreasePerSecond)].GetValue<float>(); } set { this[nameof(VannyMeterIncreasePerSecond)].SetValue<float>(value); } }
        public float VannyMeterIncreasePerCampSecond { get { return this[nameof(VannyMeterIncreasePerCampSecond)].GetValue<float>(); } set { this[nameof(VannyMeterIncreasePerCampSecond)].SetValue<float>(value); } }
        public float VannyMeterIncreasePerSoundUnit { get { return this[nameof(VannyMeterIncreasePerSoundUnit)].GetValue<float>(); } set { this[nameof(VannyMeterIncreasePerSoundUnit)].SetValue<float>(value); } }
        public float VannyMeterIncreasePerGift { get { return this[nameof(VannyMeterIncreasePerGift)].GetValue<float>(); } set { this[nameof(VannyMeterIncreasePerGift)].SetValue<float>(value); } }
        public float VannyMeterLowAppear { get { return this[nameof(VannyMeterLowAppear)].GetValue<float>(); } set { this[nameof(VannyMeterLowAppear)].SetValue<float>(value); } }
        public float VannyMeterMax { get { return this[nameof(VannyMeterMax)].GetValue<float>(); } set { this[nameof(VannyMeterMax)].SetValue<float>(value); } }
        public Array<float> VannyMeterPerHourBase { get { return new Array<float>(this[nameof(VannyMeterPerHourBase)].Address); } }
    }
    public class BallPitVolume : Actor
    {
        public BallPitVolume(ulong addr) : base(addr) { }
        public BoxComponent Volume { get { return this[nameof(Volume)].As<BoxComponent>(); } set { this["Volume"] = value; } }
        public Array<Actor> Balls { get { return new Array<Actor>(this[nameof(Balls)].Address); } }
    }
    public class CameraHelperFunctions : BlueprintFunctionLibrary
    {
        public CameraHelperFunctions(ulong addr) : base(addr) { }
        public bool IsLocationInCameraView(Object WorldContextObject, Vector Location, ECameraAngleFlags CameraAngles, float OutHorizontalAngle, float OutVerticalAngle) { return Invoke<bool>(nameof(IsLocationInCameraView), WorldContextObject, Location, CameraAngles, OutHorizontalAngle, OutVerticalAngle); }
        public void GetLocationAnglesFromCamera(Object WorldContextObject, Vector Location, float OutHorizontalAngle, float OutVerticalAngle) { Invoke(nameof(GetLocationAnglesFromCamera), WorldContextObject, Location, OutHorizontalAngle, OutVerticalAngle); }
    }
    public class CameraTrigger : Interface
    {
        public CameraTrigger(ulong addr) : base(addr) { }
        public EAlertType GetAlertType() { return Invoke<EAlertType>(nameof(GetAlertType)); }
    }
    public class ConditionalCheckComponent : ActorComponent
    {
        public ConditionalCheckComponent(ulong addr) : base(addr) { }
        public Object OnConditionalCheckUpdated { get { return this[nameof(OnConditionalCheckUpdated)]; } set { this[nameof(OnConditionalCheckUpdated)] = value; } }
        public EConditionCheckType ConditionCheck { get { return (EConditionCheckType)this[nameof(ConditionCheck)].GetValue<int>(); } set { this[nameof(ConditionCheck)].SetValue<int>((int)value); } }
        public void OnConditionUpdated(Object ConditionCheckInterface) { Invoke(nameof(OnConditionUpdated), ConditionCheckInterface); }
    }
    public class ConditionCheckInterface : Interface
    {
        public ConditionCheckInterface(ulong addr) : base(addr) { }
        public void UnbindConditionUpdatedDelegate(Object OnConditionResultUpdated) { Invoke(nameof(UnbindConditionUpdatedDelegate), OnConditionResultUpdated); }
        public bool ConditionsMet() { return Invoke<bool>(nameof(ConditionsMet)); }
        public void BindConditionUpdatedDelegate(Object OnConditionResultUpdated) { Invoke(nameof(BindConditionUpdatedDelegate), OnConditionResultUpdated); }
    }
    public class ConditionFunctionLibrary : BlueprintFunctionLibrary
    {
        public ConditionFunctionLibrary(ulong addr) : base(addr) { }
        public void RemoveConditionDelegate(ConditionResultDelegates DelegateHandle, Object Delegate) { Invoke(nameof(RemoveConditionDelegate), DelegateHandle, Delegate); }
        public void HasMetComponentConditionsWithGet(Actor ActorToCheck, bool bOutConditionsMet, Array<Object> OutConditionsSucceeded, Array<Object> OutConditionsFailed) { Invoke(nameof(HasMetComponentConditionsWithGet), ActorToCheck, bOutConditionsMet, OutConditionsSucceeded, OutConditionsFailed); }
        public bool HasMetComponentConditions(Actor ActorToCheck) { return Invoke<bool>(nameof(HasMetComponentConditions), ActorToCheck); }
        public bool HasMetAnyComponentConditions(Actor ActorToCheck) { return Invoke<bool>(nameof(HasMetAnyComponentConditions), ActorToCheck); }
        public void CallConditionUpdate(Object ConditionCheckInterface, ConditionResultDelegates DelegateHandle) { Invoke(nameof(CallConditionUpdate), ConditionCheckInterface, DelegateHandle); }
        public void AddConditionDelegate(ConditionResultDelegates DelegateHandle, Object Delegate) { Invoke(nameof(AddConditionDelegate), DelegateHandle, Delegate); }
    }
    public class DoorComponent : ActorComponent
    {
        public DoorComponent(ulong addr) : base(addr) { }
        public DoorEntryRequirements NormalDoorEntryRequirements { get { return this[nameof(NormalDoorEntryRequirements)].As<DoorEntryRequirements>(); } set { this["NormalDoorEntryRequirements"] = value; } }
        public DoorEntryRequirements SurvivalDoorEntryRequirements { get { return this[nameof(SurvivalDoorEntryRequirements)].As<DoorEntryRequirements>(); } set { this["SurvivalDoorEntryRequirements"] = value; } }
        public bool bIsOpen { get { return this[nameof(bIsOpen)].Flag; } set { this[nameof(bIsOpen)].Flag = value; } }
        public Object OnPawnEnteredDoor { get { return this[nameof(OnPawnEnteredDoor)]; } set { this[nameof(OnPawnEnteredDoor)] = value; } }
        public Object OnPawnExitedDoor { get { return this[nameof(OnPawnExitedDoor)]; } set { this[nameof(OnPawnExitedDoor)] = value; } }
        public Object OnInitialOpen { get { return this[nameof(OnInitialOpen)]; } set { this[nameof(OnInitialOpen)] = value; } }
        public Object OnOpenDoor { get { return this[nameof(OnOpenDoor)]; } set { this[nameof(OnOpenDoor)] = value; } }
        public Object OnCloseDoor { get { return this[nameof(OnCloseDoor)]; } set { this[nameof(OnCloseDoor)] = value; } }
        public Object OnPlayerLockStateChanged { get { return this[nameof(OnPlayerLockStateChanged)]; } set { this[nameof(OnPlayerLockStateChanged)] = value; } }
        public Object OnAILockStateChanged { get { return this[nameof(OnAILockStateChanged)]; } set { this[nameof(OnAILockStateChanged)] = value; } }
        public bool bIsLockedForAI { get { return this[nameof(bIsLockedForAI)].Flag; } set { this[nameof(bIsLockedForAI)].Flag = value; } }
        public bool bIsLockedForPlayer { get { return this[nameof(bIsLockedForPlayer)].Flag; } set { this[nameof(bIsLockedForPlayer)].Flag = value; } }
        public Object PawnsInDoorway { get { return this[nameof(PawnsInDoorway)]; } set { this[nameof(PawnsInDoorway)] = value; } }
        public PrimitiveComponent PlayerBlocker { get { return this[nameof(PlayerBlocker)].As<PrimitiveComponent>(); } set { this["PlayerBlocker"] = value; } }
        public void SetSecurityLevel(int NewSecurityLevel) { Invoke(nameof(SetSecurityLevel), NewSecurityLevel); }
        public void SetPlayerBlocker(PrimitiveComponent InPlayerBlocker) { Invoke(nameof(SetPlayerBlocker), InPlayerBlocker); }
        public void SetLockedForPlayer(bool bLocked) { Invoke(nameof(SetLockedForPlayer), bLocked); }
        public void SetLockedForAI(bool bLocked) { Invoke(nameof(SetLockedForAI), bLocked); }
        public void SetAutomaticDoorEnableForPlayer(bool bEnable) { Invoke(nameof(SetAutomaticDoorEnableForPlayer), bEnable); }
        public void SetAutomaticDoorEnableForAI(bool bEnable) { Invoke(nameof(SetAutomaticDoorEnableForAI), bEnable); }
        public void PawnExitedDoor(Pawn Pawn) { Invoke(nameof(PawnExitedDoor), Pawn); }
        public void PawnEnteredDoor(Pawn Pawn) { Invoke(nameof(PawnEnteredDoor), Pawn); }
        public bool IsLockedForPlayer() { return Invoke<bool>(nameof(IsLockedForPlayer)); }
        public bool IsLockedForAI() { return Invoke<bool>(nameof(IsLockedForAI)); }
        public void HasMetConditions(FNAFBasePlayerCharacter BasePlayerCharacter, bool bConditionsMet, EConditionFailReason FailReason) { Invoke(nameof(HasMetConditions), BasePlayerCharacter, bConditionsMet, FailReason); }
        public bool HasDoorInitialized() { return Invoke<bool>(nameof(HasDoorInitialized)); }
        public Array<Pawn> GetPawnsInDoor() { return Invoke<Array<Pawn>>(nameof(GetPawnsInDoor)); }
        public bool GetIsAutomaticDoorEnabledForPlayer() { return Invoke<bool>(nameof(GetIsAutomaticDoorEnabledForPlayer)); }
        public bool GetIsAutomaticDoorEnabledForAI() { return Invoke<bool>(nameof(GetIsAutomaticDoorEnabledForAI)); }
        public EDoorSide GetDoorSideFromLocation(Vector WorldLocation) { return Invoke<EDoorSide>(nameof(GetDoorSideFromLocation), WorldLocation); }
        public EDoorSide GetDoorSideFromActor(Actor Actor) { return Invoke<EDoorSide>(nameof(GetDoorSideFromActor), Actor); }
        public DoorEntryRequirements GetCurrentRequirements() { return Invoke<DoorEntryRequirements>(nameof(GetCurrentRequirements)); }
        public void ForceOpen() { Invoke(nameof(ForceOpen)); }
        public void ForceClose() { Invoke(nameof(ForceClose)); }
        public void CopyConditions(DoorComponent OtherDoorComponent) { Invoke(nameof(CopyConditions), OtherDoorComponent); }
        public void CanPawnOpenDoor(Pawn Pawn, bool bOutConditionsMet, EConditionFailReason OutFailReason) { Invoke(nameof(CanPawnOpenDoor), Pawn, bOutConditionsMet, OutFailReason); }
    }
    public class DoorInteractor : Interface
    {
        public DoorInteractor(ulong addr) : base(addr) { }
        public void OnOverlappedDoor(bool bCanEnterDoor, EConditionFailReason CantEnterReason, DoorComponent DoorComponent) { Invoke(nameof(OnOverlappedDoor), bCanEnterDoor, CantEnterReason, DoorComponent); }
        public void OnEndOverlapDoor() { Invoke(nameof(OnEndOverlapDoor)); }
        public bool DoorEntryNotAllowed(DoorComponent DoorComponent) { return Invoke<bool>(nameof(DoorEntryNotAllowed), DoorComponent); }
    }
    public class EnvQueryTest_ObjectSweep : EnvQueryTest
    {
        public EnvQueryTest_ObjectSweep(ulong addr) : base(addr) { }
        public Object Context { get { return this[nameof(Context)]; } set { this[nameof(Context)] = value; } }
        public float SphereRadius { get { return this[nameof(SphereRadius)].GetValue<float>(); } set { this[nameof(SphereRadius)].SetValue<float>(value); } }
    }
    public class fnaf9GameModeBase : GameModeBase
    {
        public fnaf9GameModeBase(ulong addr) : base(addr) { }
        public Object OnSetAIDisplay { get { return this[nameof(OnSetAIDisplay)]; } set { this[nameof(OnSetAIDisplay)] = value; } }
        public void ToggleFullAIDisplay() { Invoke(nameof(ToggleFullAIDisplay)); }
        public void StartRepairGame() { Invoke(nameof(StartRepairGame)); }
        public void SetAIDisplay(bool enable) { Invoke(nameof(SetAIDisplay), enable); }
        public void RoomHeatDisplay(bool enable) { Invoke(nameof(RoomHeatDisplay), enable); }
        public void POIVisible(bool bVisible) { Invoke(nameof(POIVisible), bVisible); }
        public void POIDetectionVisible(bool bVisible) { Invoke(nameof(POIDetectionVisible), bVisible); }
        public void PlayerFlashlightVis(bool bEnable) { Invoke(nameof(PlayerFlashlightVis), bEnable); }
        public void OnRoomHeatDisplayChanged(bool enable) { Invoke(nameof(OnRoomHeatDisplayChanged), enable); }
        public void OnPlayerFlashlightVis(bool bEnable) { Invoke(nameof(OnPlayerFlashlightVis), bEnable); }
        public void OnForceSpawnVanny() { Invoke(nameof(OnForceSpawnVanny)); }
        public void OnAIPawnsVis(bool bEnable) { Invoke(nameof(OnAIPawnsVis), bEnable); }
        public bool IsAIDisplayOn() { return Invoke<bool>(nameof(IsAIDisplayOn)); }
        public void ForceSpawnVanny() { Invoke(nameof(ForceSpawnVanny)); }
        public void FinishRepairGame() { Invoke(nameof(FinishRepairGame)); }
        public void AIPawnsVis(bool bEnable) { Invoke(nameof(AIPawnsVis), bEnable); }
    }
    public class FNAFAchievementUtils : Object
    {
        public FNAFAchievementUtils(ulong addr) : base(addr) { }
        public Array<Object> GetAllAchievements() { return Invoke<Array<Object>>(nameof(GetAllAchievements)); }
    }
    public class FNAFAISpawnPoint : NavigationObjectBase
    {
        public FNAFAISpawnPoint(ulong addr) : base(addr) { }
        public bool bUseType { get { return this[nameof(bUseType)].Flag; } set { this[nameof(bUseType)].Flag = value; } }
        public EFNAFAISpawnType AIType { get { return (EFNAFAISpawnType)this[nameof(AIType)].GetValue<int>(); } set { this[nameof(AIType)].SetValue<int>((int)value); } }
        public bool bIsStagedPoint { get { return this[nameof(bIsStagedPoint)].Flag; } set { this[nameof(bIsStagedPoint)].Flag = value; } }
        public EFNAFAISpawnType GetAIType() { return Invoke<EFNAFAISpawnType>(nameof(GetAIType)); }
    }
    public class FNAFBaseCharacter : Character
    {
        public FNAFBaseCharacter(ulong addr) : base(addr) { }
        public void OnFellOutOfWorld() { Invoke(nameof(OnFellOutOfWorld)); }
    }
    public class FNAFBaseAICharacter : FNAFBaseCharacter
    {
        public FNAFBaseAICharacter(ulong addr) : base(addr) { }
    }
    public class FNAFBasePlayerCharacter : Character
    {
        public FNAFBasePlayerCharacter(ulong addr) : base(addr) { }
        public EPlayerPawnType PawnType { get { return (EPlayerPawnType)this[nameof(PawnType)].GetValue<int>(); } set { this[nameof(PawnType)].SetValue<int>((int)value); } }
        public void TeleportPlayerWithCameraLocation(Vector CameraWorldLocation, float Yaw) { Invoke(nameof(TeleportPlayerWithCameraLocation), CameraWorldLocation, Yaw); }
        public void TeleportPlayer(Vector WorldLocation, float Yaw) { Invoke(nameof(TeleportPlayer), WorldLocation, Yaw); }
        public void OnKillZLevelsLoaded() { Invoke(nameof(OnKillZLevelsLoaded)); }
        public EPlayerPawnType GetPlayerPawnType() { return Invoke<EPlayerPawnType>(nameof(GetPlayerPawnType)); }
        public void GetLastSavedLocationAndRotation(Vector LastSavedLocation, Rotator LastSavedRotation) { Invoke(nameof(GetLastSavedLocationAndRotation), LastSavedLocation, LastSavedRotation); }
    }
    public class FNAFBasePlayerController : PlayerController
    {
        public FNAFBasePlayerController(ulong addr) : base(addr) { }
        public Object OnControlTypeChanged { get { return this[nameof(OnControlTypeChanged)]; } set { this[nameof(OnControlTypeChanged)] = value; } }
        public void OnUsingGamepadChanged() { Invoke(nameof(OnUsingGamepadChanged)); }
        public void OnTriggerVannyScare() { Invoke(nameof(OnTriggerVannyScare)); }
        public void OnToggleLocalizationQA() { Invoke(nameof(OnToggleLocalizationQA)); }
        public void OnToggleFlightMode() { Invoke(nameof(OnToggleFlightMode)); }
        public void OnToggleDevUI() { Invoke(nameof(OnToggleDevUI)); }
        public void OnToggleCinemaMode() { Invoke(nameof(OnToggleCinemaMode)); }
        public void OnDebugSequenceEntered() { Invoke(nameof(OnDebugSequenceEntered)); }
        public bool IsUsingGamepad() { return Invoke<bool>(nameof(IsUsingGamepad)); }
        public void GiveVIPAchievement() { Invoke(nameof(GiveVIPAchievement)); }
        public Array<Key> GetCurrentKeysDown() { return Invoke<Array<Key>>(nameof(GetCurrentKeysDown)); }
        public bool AnyOtherKeysDown(Key Key) { return Invoke<bool>(nameof(AnyOtherKeysDown), Key); }
    }
    public class FNAFCheatManager : CheatManager
    {
        public FNAFCheatManager(ulong addr) : base(addr) { }
        public void UpgradeFreddy(EFreddyUpgradeType Type) { Invoke(nameof(UpgradeFreddy), Type); }
        public void ToggleDebugCloaking() { Invoke(nameof(ToggleDebugCloaking)); }
        public void SetDebugCloaking(bool Value) { Invoke(nameof(SetDebugCloaking), Value); }
        public bool GetDebugCloaking() { return Invoke<bool>(nameof(GetDebugCloaking)); }
        public void ApplyQualitySettings(int VisualQualityLevel, int RayTraceQualityLevel) { Invoke(nameof(ApplyQualitySettings), VisualQualityLevel, RayTraceQualityLevel); }
    }
    public class FNAFEventObject : Interface
    {
        public FNAFEventObject(ulong addr) : base(addr) { }
        public void TriggerEvent() { Invoke(nameof(TriggerEvent)); }
        public bool IsEventFinished() { return Invoke<bool>(nameof(IsEventFinished)); }
        public bool CanPlayEvent() { return Invoke<bool>(nameof(CanPlayEvent)); }
    }
    public class FNAFEventSystem : GameInstanceSubsystem
    {
        public FNAFEventSystem(ulong addr) : base(addr) { }
        public void UnpauseEventSystem() { Invoke(nameof(UnpauseEventSystem)); }
        public void StoreEventTriggered(Object EventTag) { Invoke(nameof(StoreEventTriggered), EventTag); }
        public void StopEventTimer() { Invoke(nameof(StopEventTimer)); }
        public void StartEventTimer() { Invoke(nameof(StartEventTimer)); }
        public void SetEventTimeSeconds(float MinTimeBetweenEvents, float MaxTimeBetweenEvents) { Invoke(nameof(SetEventTimeSeconds), MinTimeBetweenEvents, MaxTimeBetweenEvents); }
        public void SetEventActorWeight(float NewWeight) { Invoke(nameof(SetEventActorWeight), NewWeight); }
        public void SetCurrentAudioComponent(AudioComponent EventSoundCue) { Invoke(nameof(SetCurrentAudioComponent), EventSoundCue); }
        public void PauseEventSystem() { Invoke(nameof(PauseEventSystem)); }
        public void OnAudioFinished() { Invoke(nameof(OnAudioFinished)); }
        public bool HasEventBeenTriggered(Object EventTag) { return Invoke<bool>(nameof(HasEventBeenTriggered), EventTag); }
    }
    public class FNAFGameInstanceBase : GameInstance
    {
        public FNAFGameInstanceBase(ulong addr) : base(addr) { }
        public void StartGamePlay(EFNAFGameType GameType) { Invoke(nameof(StartGamePlay), GameType); }
        public void SetVisualQualityLevel(int Level) { Invoke(nameof(SetVisualQualityLevel), Level); }
        public void SetSplashFinished(bool bFinished) { Invoke(nameof(SetSplashFinished), bFinished); }
        public void SetRayTraceQualityLevel(int Level) { Invoke(nameof(SetRayTraceQualityLevel), Level); }
        public void ProcessActivityIntent() { Invoke(nameof(ProcessActivityIntent)); }
        public void OnGameActivityLoadComplete() { Invoke(nameof(OnGameActivityLoadComplete)); }
        public void OnApplicationReactivated() { Invoke(nameof(OnApplicationReactivated)); }
        public void OnApplicationDeactivated() { Invoke(nameof(OnApplicationDeactivated)); }
        public void LogGameClockDelegates() { Invoke(nameof(LogGameClockDelegates)); }
        public bool IsNormalPlay() { return Invoke<bool>(nameof(IsNormalPlay)); }
        public bool IsLoadingActivity() { return Invoke<bool>(nameof(IsLoadingActivity)); }
        public bool IsFromTitle() { return Invoke<bool>(nameof(IsFromTitle)); }
        public bool HasSplashFinished() { return Invoke<bool>(nameof(HasSplashFinished)); }
        public int GetVisualQualityLevel() { return Invoke<int>(nameof(GetVisualQualityLevel)); }
        public int GetRayTraceQualityLevel() { return Invoke<int>(nameof(GetRayTraceQualityLevel)); }
        public bool GetIsShippingConfig() { return Invoke<bool>(nameof(GetIsShippingConfig)); }
        public float GetGPUBenchmarkResult() { return Invoke<float>(nameof(GetGPUBenchmarkResult)); }
        public EFNAFGameType GetCurrentGameType() { return Invoke<EFNAFGameType>(nameof(GetCurrentGameType)); }
        public float GetCPUBenchmarkResult() { return Invoke<float>(nameof(GetCPUBenchmarkResult)); }
        public Object GetAllLoadedLevelsString() { return Invoke<Object>(nameof(GetAllLoadedLevelsString)); }
    }
    public class FNAFGameUserSettings : GameUserSettings
    {
        public FNAFGameUserSettings(ulong addr) : base(addr) { }
        public int VisualQualityLevel { get { return this[nameof(VisualQualityLevel)].GetValue<int>(); } set { this[nameof(VisualQualityLevel)].SetValue<int>(value); } }
        public int RayTraceQualityLevel { get { return this[nameof(RayTraceQualityLevel)].GetValue<int>(); } set { this[nameof(RayTraceQualityLevel)].SetValue<int>(value); } }
    }
    public class FNAFGeneralEditorSettings : DeveloperSettings
    {
        public FNAFGeneralEditorSettings(ulong addr) : base(addr) { }
        public bool bSurvivalMode { get { return this[nameof(bSurvivalMode)].Flag; } set { this[nameof(bSurvivalMode)].Flag = value; } }
        public bool bPIEUseIntro { get { return this[nameof(bPIEUseIntro)].Flag; } set { this[nameof(bPIEUseIntro)].Flag = value; } }
        public bool bSurvivalAllLocations { get { return this[nameof(bSurvivalAllLocations)].Flag; } set { this[nameof(bSurvivalAllLocations)].Flag = value; } }
        public int MinutesPerHour { get { return this[nameof(MinutesPerHour)].GetValue<int>(); } set { this[nameof(MinutesPerHour)].SetValue<int>(value); } }
        public int SurvivalSeed { get { return this[nameof(SurvivalSeed)].GetValue<int>(); } set { this[nameof(SurvivalSeed)].SetValue<int>(value); } }
    }
    public class FNAFInputDeviceSystem : GameInstanceSubsystem
    {
        public FNAFInputDeviceSystem(ulong addr) : base(addr) { }
        public Object OnInputDeviceTypeChanged { get { return this[nameof(OnInputDeviceTypeChanged)]; } set { this[nameof(OnInputDeviceTypeChanged)] = value; } }
        public ESWGInputDeviceType GetCurrentInputDevice() { return Invoke<ESWGInputDeviceType>(nameof(GetCurrentInputDevice)); }
    }
    public class FNAFInputSystemDeveloperSettings : DeveloperSettings
    {
        public FNAFInputSystemDeveloperSettings(ulong addr) : base(addr) { }
        public bool bOverrideInputDevice { get { return this[nameof(bOverrideInputDevice)].Flag; } set { this[nameof(bOverrideInputDevice)].Flag = value; } }
        public ESWGInputDeviceType OverrideInputDevice { get { return (ESWGInputDeviceType)this[nameof(OverrideInputDevice)].GetValue<int>(); } set { this[nameof(OverrideInputDevice)].SetValue<int>((int)value); } }
    }
    public class FNAFInventorySystem : GameInstanceSubsystem
    {
        public FNAFInventorySystem(ulong addr) : base(addr) { }
        public Object OnInventoryItemAdded { get { return this[nameof(OnInventoryItemAdded)]; } set { this[nameof(OnInventoryItemAdded)] = value; } }
        public Object OnInventoryItemRemoved { get { return this[nameof(OnInventoryItemRemoved)]; } set { this[nameof(OnInventoryItemRemoved)] = value; } }
        public Object OnMessageAdded { get { return this[nameof(OnMessageAdded)]; } set { this[nameof(OnMessageAdded)] = value; } }
        public Object OnSecurityLevelUpdated { get { return this[nameof(OnSecurityLevelUpdated)]; } set { this[nameof(OnSecurityLevelUpdated)] = value; } }
        public Object OnPartyLevelUpdated { get { return this[nameof(OnPartyLevelUpdated)]; } set { this[nameof(OnPartyLevelUpdated)] = value; } }
        public Object OnPartyPassUsed { get { return this[nameof(OnPartyPassUsed)]; } set { this[nameof(OnPartyPassUsed)] = value; } }
        public DataTable InventoryDataTable { get { return this[nameof(InventoryDataTable)].As<DataTable>(); } set { this["InventoryDataTable"] = value; } }
        public DataTable MessageDataTable { get { return this[nameof(MessageDataTable)].As<DataTable>(); } set { this["MessageDataTable"] = value; } }
        public int FazwatchPowerLevel { get { return this[nameof(FazwatchPowerLevel)].GetValue<int>(); } set { this[nameof(FazwatchPowerLevel)].SetValue<int>(value); } }
        public int FazwatchMaxPowerLevel { get { return this[nameof(FazwatchMaxPowerLevel)].GetValue<int>(); } set { this[nameof(FazwatchMaxPowerLevel)].SetValue<int>(value); } }
        public int FreddyPowerLevel { get { return this[nameof(FreddyPowerLevel)].GetValue<int>(); } set { this[nameof(FreddyPowerLevel)].SetValue<int>(value); } }
        public int FreddyMaxPowerLevel { get { return this[nameof(FreddyMaxPowerLevel)].GetValue<int>(); } set { this[nameof(FreddyMaxPowerLevel)].SetValue<int>(value); } }
        public int SecurityLevel { get { return this[nameof(SecurityLevel)].GetValue<int>(); } set { this[nameof(SecurityLevel)].SetValue<int>(value); } }
        public int CollectedPartyPassCount { get { return this[nameof(CollectedPartyPassCount)].GetValue<int>(); } set { this[nameof(CollectedPartyPassCount)].SetValue<int>(value); } }
        public int UsedPartyPassCount { get { return this[nameof(UsedPartyPassCount)].GetValue<int>(); } set { this[nameof(UsedPartyPassCount)].SetValue<int>(value); } }
        public int NumAvailableFlash { get { return this[nameof(NumAvailableFlash)].GetValue<int>(); } set { this[nameof(NumAvailableFlash)].SetValue<int>(value); } }
        public bool bUnlimitedFazwatchPower { get { return this[nameof(bUnlimitedFazwatchPower)].Flag; } set { this[nameof(bUnlimitedFazwatchPower)].Flag = value; } }
        public bool bUnlimitedStamina { get { return this[nameof(bUnlimitedStamina)].Flag; } set { this[nameof(bUnlimitedStamina)].Flag = value; } }
        public Object TapesListenedTo { get { return this[nameof(TapesListenedTo)]; } set { this[nameof(TapesListenedTo)] = value; } }
        public int NumDishesBroken { get { return this[nameof(NumDishesBroken)].GetValue<int>(); } set { this[nameof(NumDishesBroken)].SetValue<int>(value); } }
        public bool UsePartyPass() { return Invoke<bool>(nameof(UsePartyPass)); }
        public void UseFlash(bool bOutFlashUsed) { Invoke(nameof(UseFlash), bOutFlashUsed); }
        public void SetupNewGame() { Invoke(nameof(SetupNewGame)); }
        public void SetSecurityLevel(int NewSecurityLevel) { Invoke(nameof(SetSecurityLevel), NewSecurityLevel); }
        public void SetPowerLevel_Freddy(int InPowerLevel) { Invoke(nameof(SetPowerLevel_Freddy), InPowerLevel); }
        public void SetPowerLevel_Fazwatch(int InPowerLevel) { Invoke(nameof(SetPowerLevel_Fazwatch), InPowerLevel); }
        public void SetPartyLevel(int NewPartyLevel) { Invoke(nameof(SetPartyLevel), NewPartyLevel); }
        public void SetMessageViewed(Object Message) { Invoke(nameof(SetMessageViewed), Message); }
        public void SetMaxPowerLevel_Freddy(int NewMax) { Invoke(nameof(SetMaxPowerLevel_Freddy), NewMax); }
        public void SetMaxPowerLevel_Fazwatch(int NewMax) { Invoke(nameof(SetMaxPowerLevel_Fazwatch), NewMax); }
        public void SetItemViewed(Object Item) { Invoke(nameof(SetItemViewed), Item); }
        public void SetFlashlightStationID(int StationID) { Invoke(nameof(SetFlashlightStationID), StationID); }
        public void ResetFreddyPower() { Invoke(nameof(ResetFreddyPower)); }
        public void ResetFlashlightPower() { Invoke(nameof(ResetFlashlightPower)); }
        public void ResetFlashes() { Invoke(nameof(ResetFlashes)); }
        public void RemoveMessage(Object Message) { Invoke(nameof(RemoveMessage), Message); }
        public void RemoveItem(Object Item) { Invoke(nameof(RemoveItem), Item); }
        public void RemoveEverything() { Invoke(nameof(RemoveEverything)); }
        public bool IsVIPItem(Object Item) { return Invoke<bool>(nameof(IsVIPItem), Item); }
        public bool IsMessageValid(Object Message) { return Invoke<bool>(nameof(IsMessageValid), Message); }
        public bool IsItemValid(Object Item) { return Invoke<bool>(nameof(IsItemValid), Item); }
        public bool HasSecurityClearance(int InSecurityLevel) { return Invoke<bool>(nameof(HasSecurityClearance), InSecurityLevel); }
        public bool HasMessageBeenViewed(Object ItemOrMessage) { return Invoke<bool>(nameof(HasMessageBeenViewed), ItemOrMessage); }
        public bool HasMessage(Object SearchMessage) { return Invoke<bool>(nameof(HasMessage), SearchMessage); }
        public bool HasItemBeenViewed(Object ItemOrMessage) { return Invoke<bool>(nameof(HasItemBeenViewed), ItemOrMessage); }
        public bool HasItem(Object searchItem) { return Invoke<bool>(nameof(HasItem), searchItem); }
        public bool HasEnoughPower_Freddy(int PowerRequired) { return Invoke<bool>(nameof(HasEnoughPower_Freddy), PowerRequired); }
        public bool HasEnoughPower_Fazwatch(int PowerRequired) { return Invoke<bool>(nameof(HasEnoughPower_Fazwatch), PowerRequired); }
        public bool HasAvailablePartyPass() { return Invoke<bool>(nameof(HasAvailablePartyPass)); }
        public Object GetTapesListenedTo() { return Invoke<Object>(nameof(GetTapesListenedTo)); }
        public float GetStaminaUpgradeMultiplier() { return Invoke<float>(nameof(GetStaminaUpgradeMultiplier)); }
        public int GetNumberOfUnreadMessages() { return Invoke<int>(nameof(GetNumberOfUnreadMessages)); }
        public void GetMessageInfo(Object MessageName, FNAFMessageTableStruct OutMessageInfo, bool OutFound) { Invoke(nameof(GetMessageInfo), MessageName, OutMessageInfo, OutFound); }
        public int GetMaxFlashes() { return Invoke<int>(nameof(GetMaxFlashes)); }
        public void GetItemInfo(Object ItemName, FNAFInventoryTableStruct OutItemInfo, bool OutFound) { Invoke(nameof(GetItemInfo), ItemName, OutItemInfo, OutFound); }
        public float GetFreddyUpgradeMutliplier() { return Invoke<float>(nameof(GetFreddyUpgradeMutliplier)); }
        public int GetFreddyMaxPower() { return Invoke<int>(nameof(GetFreddyMaxPower)); }
        public float GetFlashlightUpgradMultiplier() { return Invoke<float>(nameof(GetFlashlightUpgradMultiplier)); }
        public int GetFlashlightStationID() { return Invoke<int>(nameof(GetFlashlightStationID)); }
        public int GetFlashlightMaxPower() { return Invoke<int>(nameof(GetFlashlightMaxPower)); }
        public Array<Object> GetCollectedPartyPasses() { return Invoke<Array<Object>>(nameof(GetCollectedPartyPasses)); }
        public Array<Object> GetAllSurvivalItemsOfType(EInventoryItemSurvivalCategory SurvivalCategory) { return Invoke<Array<Object>>(nameof(GetAllSurvivalItemsOfType), SurvivalCategory); }
        public void ClearFlashlightStationID() { Invoke(nameof(ClearFlashlightStationID)); }
        public bool CanUseFlashBeacon() { return Invoke<bool>(nameof(CanUseFlashBeacon)); }
        public void AwardMessage(Object Message, bool bNotify) { Invoke(nameof(AwardMessage), Message, bNotify); }
        public void AwardItem(Object Item, bool bNotify) { Invoke(nameof(AwardItem), Item, bNotify); }
        public bool AdjustPower_Freddy(int ChangeAmount) { return Invoke<bool>(nameof(AdjustPower_Freddy), ChangeAmount); }
        public bool AdjustPower_Fazwatch(int ChangeAmount) { return Invoke<bool>(nameof(AdjustPower_Fazwatch), ChangeAmount); }
        public void AddTapeListenedTo(Object InTapeListenedTo) { Invoke(nameof(AddTapeListenedTo), InTapeListenedTo); }
        public void AddEverything() { Invoke(nameof(AddEverything)); }
        public int AddBrokenPlate() { return Invoke<int>(nameof(AddBrokenPlate)); }
    }
    public class FNAFLevelManager : WorldSubsystem
    {
        public FNAFLevelManager(ulong addr) : base(addr) { }
        public Object OnlevelsUpdated { get { return this[nameof(OnlevelsUpdated)]; } set { this[nameof(OnlevelsUpdated)] = value; } }
        public void UnregisterStreamingSource(SceneComponent SceneComponent) { Invoke(nameof(UnregisterStreamingSource), SceneComponent); }
        public void UnregisterPawnStreamingSource(SceneComponent SceneComponent) { Invoke(nameof(UnregisterPawnStreamingSource), SceneComponent); }
        public void SetPlayerPawn(Pawn PlayerPawn) { Invoke(nameof(SetPlayerPawn), PlayerPawn); }
        public void SetLevelStreamingEnable(bool bEnable) { Invoke(nameof(SetLevelStreamingEnable), bEnable); }
        public void RemoveLevelsFromStreamingSource(SceneComponent StreamingSource) { Invoke(nameof(RemoveLevelsFromStreamingSource), StreamingSource); }
        public void RemoveLevelArray(Array<LevelStreaming> Levels) { Invoke(nameof(RemoveLevelArray), Levels); }
        public void RemoveLevel(LevelStreaming LevelToUnload) { Invoke(nameof(RemoveLevel), LevelToUnload); }
        public void RemoveAllLevels() { Invoke(nameof(RemoveAllLevels)); }
        public void RegisterStreamingSource(SceneComponent SceneComponent) { Invoke(nameof(RegisterStreamingSource), SceneComponent); }
        public void RegisterPawnStreamingSource(SceneComponent SceneComponent) { Invoke(nameof(RegisterPawnStreamingSource), SceneComponent); }
        public bool IsLevelStreamingEnable() { return Invoke<bool>(nameof(IsLevelStreamingEnable)); }
        public Array<SceneComponent> GetStreamingSources() { return Invoke<Array<SceneComponent>>(nameof(GetStreamingSources)); }
        public Array<Object> GetLevelNamesForComponent(SceneComponent SceneComponent) { return Invoke<Array<Object>>(nameof(GetLevelNamesForComponent), SceneComponent); }
        public void AddLevelToLoad(LevelStreaming LevelToLoad) { Invoke(nameof(AddLevelToLoad), LevelToLoad); }
        public void AddLevelsFromStreamingSourceToLoad(SceneComponent StreamingSource) { Invoke(nameof(AddLevelsFromStreamingSourceToLoad), StreamingSource); }
        public void AddLevelArrayToLoad(Array<LevelStreaming> LevelsToLoad) { Invoke(nameof(AddLevelArrayToLoad), LevelsToLoad); }
    }
    public class FNAFManagedAI : Interface
    {
        public FNAFManagedAI(ulong addr) : base(addr) { }
        public void TeleportAI(Vector Location) { Invoke(nameof(TeleportAI), Location); }
        public void StartMoveTo(Vector Location) { Invoke(nameof(StartMoveTo), Location); }
        public void SendVanessaAlert(Pawn VanessaPawn) { Invoke(nameof(SendVanessaAlert), VanessaPawn); }
        public void SendPositionalAlert(Vector Location) { Invoke(nameof(SendPositionalAlert), Location); }
        public bool IsShatteredVersion() { return Invoke<bool>(nameof(IsShatteredVersion)); }
        public EFNAFAISpawnType GetManagedAIType() { return Invoke<EFNAFAISpawnType>(nameof(GetManagedAIType)); }
        public Object GetCurrentPathName() { return Invoke<Object>(nameof(GetCurrentPathName)); }
        public void ForceTrackToPlayer() { Invoke(nameof(ForceTrackToPlayer)); }
        public void EndTrackToPlayer() { Invoke(nameof(EndTrackToPlayer)); }
        public bool CanReceiveAlert() { return Invoke<bool>(nameof(CanReceiveAlert)); }
    }
    public class FNAFMasterData : SaveGame
    {
        public FNAFMasterData(ulong addr) : base(addr) { }
        public int newSaveSlotNumber { get { return this[nameof(newSaveSlotNumber)].GetValue<int>(); } set { this[nameof(newSaveSlotNumber)].SetValue<int>(value); } }
        public Object lastSavedSlotName { get { return this[nameof(lastSavedSlotName)]; } set { this[nameof(lastSavedSlotName)] = value; } }
        public Object lastLoadedSlotName { get { return this[nameof(lastLoadedSlotName)]; } set { this[nameof(lastLoadedSlotName)] = value; } }
        public Object ActivitySaveSlot { get { return this[nameof(ActivitySaveSlot)]; } set { this[nameof(ActivitySaveSlot)] = value; } }
        public Object SaveGameSlotNames_Map { get { return this[nameof(SaveGameSlotNames_Map)]; } set { this[nameof(SaveGameSlotNames_Map)] = value; } }
        public bool InvertedGamepad { get { return this[nameof(InvertedGamepad)].Flag; } set { this[nameof(InvertedGamepad)].Flag = value; } }
        public bool bLastSaveWasAuto { get { return this[nameof(bLastSaveWasAuto)].Flag; } set { this[nameof(bLastSaveWasAuto)].Flag = value; } }
        public Object ActivityIdSaveSlotNamesMap { get { return this[nameof(ActivityIdSaveSlotNamesMap)]; } set { this[nameof(ActivityIdSaveSlotNamesMap)] = value; } }
    }
    public class FNAFMissionSystem : GameInstanceSubsystem
    {
        public FNAFMissionSystem(ulong addr) : base(addr) { }
        public Object OnNewActiveMissionAdded { get { return this[nameof(OnNewActiveMissionAdded)]; } set { this[nameof(OnNewActiveMissionAdded)] = value; } }
        public Object OnActiveMissionRemoved { get { return this[nameof(OnActiveMissionRemoved)]; } set { this[nameof(OnActiveMissionRemoved)] = value; } }
        public Object OnActiveMissionUpdated { get { return this[nameof(OnActiveMissionUpdated)]; } set { this[nameof(OnActiveMissionUpdated)] = value; } }
        public Object OnMissionCompleted { get { return this[nameof(OnMissionCompleted)]; } set { this[nameof(OnMissionCompleted)] = value; } }
        public DataTable MissionDataTable { get { return this[nameof(MissionDataTable)].As<DataTable>(); } set { this["MissionDataTable"] = value; } }
        public DataTable MissionTaskDataTable { get { return this[nameof(MissionTaskDataTable)].As<DataTable>(); } set { this["MissionTaskDataTable"] = value; } }
        public void SetupNewGame() { Invoke(nameof(SetupNewGame)); }
        public void SetMissionInfoState(Object MissionName, int InfoState) { Invoke(nameof(SetMissionInfoState), MissionName, InfoState); }
        public void RemoveActiveMission(Object MissionName) { Invoke(nameof(RemoveActiveMission), MissionName); }
        public void NotifyMissionUpdate(Object MissionName) { Invoke(nameof(NotifyMissionUpdate), MissionName); }
        public bool IsValidMission(Object MissionName) { return Invoke<bool>(nameof(IsValidMission), MissionName); }
        public bool IsMissionActiveOrCompleted(Object MissionName) { return Invoke<bool>(nameof(IsMissionActiveOrCompleted), MissionName); }
        public bool IsInSurvivalMode() { return Invoke<bool>(nameof(IsInSurvivalMode)); }
        public bool IsCompletedMission(Object MissionName) { return Invoke<bool>(nameof(IsCompletedMission), MissionName); }
        public bool IsActiveMission(Object MissionName) { return Invoke<bool>(nameof(IsActiveMission), MissionName); }
        public Array<FNAFMissionState> GetTrackedMissions() { return Invoke<Array<FNAFMissionState>>(nameof(GetTrackedMissions)); }
        public DataTable GetTaskTable() { return Invoke<DataTable>(nameof(GetTaskTable)); }
        public void GetTaskInfo(Object TaskName, FNAFMissionTaskInfo OutMissionTaskInfo, bool OutValidTask) { Invoke(nameof(GetTaskInfo), TaskName, OutMissionTaskInfo, OutValidTask); }
        public void GetTaskByIndex(Object MissionName, int TaskIndex, FNAFMissionTaskInfo OutMissionTaskInfo, bool OutValidTask) { Invoke(nameof(GetTaskByIndex), MissionName, TaskIndex, OutMissionTaskInfo, OutValidTask); }
        public DataTable GetMissionTable() { return Invoke<DataTable>(nameof(GetMissionTable)); }
        public void GetMissionState(Object MissionName, FNAFMissionState OutMissionState, bool OutValidMission) { Invoke(nameof(GetMissionState), MissionName, OutMissionState, OutValidMission); }
        public void GetMissionInfo(Object MissionName, FNAFMissionInfo OutMissionInfo, bool OutValidMission) { Invoke(nameof(GetMissionInfo), MissionName, OutMissionInfo, OutValidMission); }
        public void GetMissionFromTask(Object TaskName, FNAFMissionInfo OutMissionInfo, bool OutValidMission) { Invoke(nameof(GetMissionFromTask), TaskName, OutMissionInfo, OutValidMission); }
        public void GetMissionFromMessage(Object MessageName, Object OutMissionName, int OutMissionStateIndex) { Invoke(nameof(GetMissionFromMessage), MessageName, OutMissionName, OutMissionStateIndex); }
        public Array<MissionMarker> GetMarkersForMission(Object MissionName, int MissionStateIndex) { return Invoke<Array<MissionMarker>>(nameof(GetMarkersForMission), MissionName, MissionStateIndex); }
        public Array<FNAFMissionState> GetCompletedMissions() { return Invoke<Array<FNAFMissionState>>(nameof(GetCompletedMissions)); }
        public void GetAreaMarkerCounts(Object MapOfCounts) { Invoke(nameof(GetAreaMarkerCounts), MapOfCounts); }
        public Array<Object> GetAllMissionNames() { return Invoke<Array<Object>>(nameof(GetAllMissionNames)); }
        public Array<MissionMarker> GetAllMissionMarkers() { return Invoke<Array<MissionMarker>>(nameof(GetAllMissionMarkers)); }
        public Array<MissionMarker> GetAllCurrentMarkers() { return Invoke<Array<MissionMarker>>(nameof(GetAllCurrentMarkers)); }
        public Array<FNAFMissionState> GetActiveMissions() { return Invoke<Array<FNAFMissionState>>(nameof(GetActiveMissions)); }
        public void CompleteMissionTask(Object MissionName, int TaskIndex) { Invoke(nameof(CompleteMissionTask), MissionName, TaskIndex); }
        public void CompleteMission(Object MissionName) { Invoke(nameof(CompleteMission), MissionName); }
        public void BranchMissionStatus(Object MissionName, EMissionStatus Status) { Invoke(nameof(BranchMissionStatus), MissionName, Status); }
        public void AddActiveMission(Object MissionName) { Invoke(nameof(AddActiveMission), MissionName); }
    }
    public class FNAFPawnTypeProviderInterface : Interface
    {
        public FNAFPawnTypeProviderInterface(ulong addr) : base(addr) { }
        public EPlayerPawnType GetPlayerPawnType() { return Invoke<EPlayerPawnType>(nameof(GetPlayerPawnType)); }
    }
    public class FNAFSaveData : SaveGame
    {
        public FNAFSaveData(ulong addr) : base(addr) { }
        public FNAFEventSystemData EventSystemData { get { return this[nameof(EventSystemData)].As<FNAFEventSystemData>(); } set { this["EventSystemData"] = value; } }
        public FNAFAISaveData AISaveData { get { return this[nameof(AISaveData)].As<FNAFAISaveData>(); } set { this["AISaveData"] = value; } }
        public FNAFWorldStateSaveData WorldStateData { get { return this[nameof(WorldStateData)].As<FNAFWorldStateSaveData>(); } set { this["WorldStateData"] = value; } }
        public ArcadeSaveData ArcadeSaveData { get { return this[nameof(ArcadeSaveData)].As<ArcadeSaveData>(); } set { this["ArcadeSaveData"] = value; } }
        public FNAFInventorySaveData InventorySaveData { get { return this[nameof(InventorySaveData)].As<FNAFInventorySaveData>(); } set { this["InventorySaveData"] = value; } }
        public FNAFPowerSaveData FazwatchPowerSaveData { get { return this[nameof(FazwatchPowerSaveData)].As<FNAFPowerSaveData>(); } set { this["FazwatchPowerSaveData"] = value; } }
        public FNAFPowerSaveData FreddyPowerSaveData { get { return this[nameof(FreddyPowerSaveData)].As<FNAFPowerSaveData>(); } set { this["FreddyPowerSaveData"] = value; } }
        public Array<FNAFMissionState> MissionState { get { return new Array<FNAFMissionState>(this[nameof(MissionState)].Address); } }
        public FreddyUpgradeState FreddyUpgrades { get { return this[nameof(FreddyUpgrades)].As<FreddyUpgradeState>(); } set { this["FreddyUpgrades"] = value; } }
        public LightScenarioManagerData LightScenarioManagerData { get { return this[nameof(LightScenarioManagerData)].As<LightScenarioManagerData>(); } set { this["LightScenarioManagerData"] = value; } }
        public int Hour { get { return this[nameof(Hour)].GetValue<int>(); } set { this[nameof(Hour)].SetValue<int>(value); } }
        public int Minute { get { return this[nameof(Minute)].GetValue<int>(); } set { this[nameof(Minute)].SetValue<int>(value); } }
        public int GameIteration { get { return this[nameof(GameIteration)].GetValue<int>(); } set { this[nameof(GameIteration)].SetValue<int>(value); } }
        public int TotalTimePlayedInSeconds { get { return this[nameof(TotalTimePlayedInSeconds)].GetValue<int>(); } set { this[nameof(TotalTimePlayedInSeconds)].SetValue<int>(value); } }
        public DateTime RealtimeSaveTime { get { return this[nameof(RealtimeSaveTime)].As<DateTime>(); } set { this["RealtimeSaveTime"] = value; } }
        public Vector PlayerLocation { get { return this[nameof(PlayerLocation)].As<Vector>(); } set { this["PlayerLocation"] = value; } }
        public Rotator PlayerRotation { get { return this[nameof(PlayerRotation)].As<Rotator>(); } set { this["PlayerRotation"] = value; } }
        public bool bInPowerStation { get { return this[nameof(bInPowerStation)].Flag; } set { this[nameof(bInPowerStation)].Flag = value; } }
        public int PowerStationID { get { return this[nameof(PowerStationID)].GetValue<int>(); } set { this[nameof(PowerStationID)].SetValue<int>(value); } }
        public Array<PowerStationSaveInfo> PowerStationsVisited { get { return new Array<PowerStationSaveInfo>(this[nameof(PowerStationsVisited)].Address); } }
        public Object ActivityId { get { return this[nameof(ActivityId)]; } set { this[nameof(ActivityId)] = value; } }
        public void SetHourOfCheckpoint(int InHour) { Invoke(nameof(SetHourOfCheckpoint), InHour); }
    }
    public class FNAFSaveGameSystem : GameInstanceSubsystem
    {
        public FNAFSaveGameSystem(ulong addr) : base(addr) { }
        public FNAFSaveData SaveDataObject { get { return this[nameof(SaveDataObject)].As<FNAFSaveData>(); } set { this["SaveDataObject"] = value; } }
        public FNAFSaveData TempSaveDataObject { get { return this[nameof(TempSaveDataObject)].As<FNAFSaveData>(); } set { this["TempSaveDataObject"] = value; } }
        public FNAFSaveData WorldTransitDataObject { get { return this[nameof(WorldTransitDataObject)].As<FNAFSaveData>(); } set { this["WorldTransitDataObject"] = value; } }
        public FNAFMasterData MasterDataObject { get { return this[nameof(MasterDataObject)].As<FNAFMasterData>(); } set { this["MasterDataObject"] = value; } }
        public Object OnSaveGameBegin { get { return this[nameof(OnSaveGameBegin)]; } set { this[nameof(OnSaveGameBegin)] = value; } }
        public Object OnSaveGameComplete { get { return this[nameof(OnSaveGameComplete)]; } set { this[nameof(OnSaveGameComplete)] = value; } }
        public Object OnLoadGameComplete { get { return this[nameof(OnLoadGameComplete)]; } set { this[nameof(OnLoadGameComplete)] = value; } }
        public Object SaveSlotNames_Data { get { return this[nameof(SaveSlotNames_Data)]; } set { this[nameof(SaveSlotNames_Data)] = value; } }
        public Object MasterDataSlotName { get { return this[nameof(MasterDataSlotName)]; } set { this[nameof(MasterDataSlotName)] = value; } }
        public Object SaveSlotName { get { return this[nameof(SaveSlotName)]; } set { this[nameof(SaveSlotName)] = value; } }
        public uint UserIndex { get { return this[nameof(UserIndex)].GetValue<uint>(); } set { this[nameof(UserIndex)].SetValue<uint>(value); } }
        public bool bIsSavingAllowed { get { return this[nameof(bIsSavingAllowed)].Flag; } set { this[nameof(bIsSavingAllowed)].Flag = value; } }
        public bool bInvertedGamepad { get { return this[nameof(bInvertedGamepad)].Flag; } set { this[nameof(bInvertedGamepad)].Flag = value; } }
        public void SetupPIE() { Invoke(nameof(SetupPIE)); }
        public void SetupNewSurvivalGame() { Invoke(nameof(SetupNewSurvivalGame)); }
        public void SetupNewGameOnSlot(Object originalSlotName) { Invoke(nameof(SetupNewGameOnSlot), originalSlotName); }
        public void SetupNewGame() { Invoke(nameof(SetupNewGame)); }
        public void SetIsSavingAllowed(bool IsSavingAllowed) { Invoke(nameof(SetIsSavingAllowed), IsSavingAllowed); }
        public void SaveCurrentGame() { Invoke(nameof(SaveCurrentGame)); }
        public void SaveCheckpoint() { Invoke(nameof(SaveCheckpoint)); }
        public void SaveArcade() { Invoke(nameof(SaveArcade)); }
        public void Reset_SaveSlots() { Invoke(nameof(Reset_SaveSlots)); }
        public void Rename_SaveSlot(Object originalSlotName, Object renamedSlotName) { Invoke(nameof(Rename_SaveSlot), originalSlotName, renamedSlotName); }
        public bool PreviousSaveIsAuto() { return Invoke<bool>(nameof(PreviousSaveIsAuto)); }
        public void LoadWorldTransitSave() { Invoke(nameof(LoadWorldTransitSave)); }
        public FNAFSaveData LoadSaveSlotData(Object SlotName) { return Invoke<FNAFSaveData>(nameof(LoadSaveSlotData), SlotName); }
        public void LoadCheckpoint() { Invoke(nameof(LoadCheckpoint)); }
        public void LoadAutoSave() { Invoke(nameof(LoadAutoSave)); }
        public void LoadActivitySave(Object InActivityId) { Invoke(nameof(LoadActivitySave), InActivityId); }
        public bool IsSavingAllowed() { return Invoke<bool>(nameof(IsSavingAllowed)); }
        public bool HasSaveData() { return Invoke<bool>(nameof(HasSaveData)); }
        public bool HasPreviousSave() { return Invoke<bool>(nameof(HasPreviousSave)); }
        public bool HasAutoSave() { return Invoke<bool>(nameof(HasAutoSave)); }
        public bool HasActivitySave(Object InActivityId) { return Invoke<bool>(nameof(HasActivitySave), InActivityId); }
        public int GetGameIteration() { return Invoke<int>(nameof(GetGameIteration)); }
        public void Get_SaveSlotNameData(Object SaveSlots_Map) { Invoke(nameof(Get_SaveSlotNameData), SaveSlots_Map); }
        public void FinalizeCheckpoint() { Invoke(nameof(FinalizeCheckpoint)); }
        public void DeleteSaveGameByName(Object SlotName) { Invoke(nameof(DeleteSaveGameByName), SlotName); }
        public void DeleteSavedGame_BySlot(int saveSlotNumber) { Invoke(nameof(DeleteSavedGame_BySlot), saveSlotNumber); }
        public void CreateWorldTransitSave() { Invoke(nameof(CreateWorldTransitSave)); }
        public void CreatePotentialCheckpoint() { Invoke(nameof(CreatePotentialCheckpoint)); }
        public void AutoSave() { Invoke(nameof(AutoSave)); }
        public void AsyncSaveGame(Object originalSlotName, bool isANewSlot, bool isCurrentSlot, Object Renamed_SaveSlot, Object internal_SlotName) { Invoke(nameof(AsyncSaveGame), originalSlotName, isANewSlot, isCurrentSlot, Renamed_SaveSlot, internal_SlotName); }
        public void AsyncLoadGameLastLoaded() { Invoke(nameof(AsyncLoadGameLastLoaded)); }
        public void AsyncLoadGame(Object originalSlotName, bool isContinueSelected, Object internal_SlotName) { Invoke(nameof(AsyncLoadGame), originalSlotName, isContinueSelected, internal_SlotName); }
    }
    public class FNAFSightSystem : WorldSubsystem
    {
        public FNAFSightSystem(ulong addr) : base(addr) { }
        public void SetSightSystemDisplay(bool bEnable) { Invoke(nameof(SetSightSystemDisplay), bEnable); }
    }
    public class GameClockSettings : DeveloperSettings
    {
        public GameClockSettings(ulong addr) : base(addr) { }
        public float TotalGameTimeHours { get { return this[nameof(TotalGameTimeHours)].GetValue<float>(); } set { this[nameof(TotalGameTimeHours)].SetValue<float>(value); } }
        public float TotalRealTimeHours { get { return this[nameof(TotalRealTimeHours)].GetValue<float>(); } set { this[nameof(TotalRealTimeHours)].SetValue<float>(value); } }
        public float TickRate { get { return this[nameof(TickRate)].GetValue<float>(); } set { this[nameof(TickRate)].SetValue<float>(value); } }
    }
    public class GameClockSystem : GameInstanceSubsystem
    {
        public GameClockSystem(ulong addr) : base(addr) { }
        public Object OnGameClockStateChange { get { return this[nameof(OnGameClockStateChange)]; } set { this[nameof(OnGameClockStateChange)] = value; } }
        public Object NormalModeDelegate { get { return this[nameof(NormalModeDelegate)]; } set { this[nameof(NormalModeDelegate)] = value; } }
        public Object MoonmanLiteDelegate { get { return this[nameof(MoonmanLiteDelegate)]; } set { this[nameof(MoonmanLiteDelegate)] = value; } }
        public Object MoonmanIntermediateDelegate { get { return this[nameof(MoonmanIntermediateDelegate)]; } set { this[nameof(MoonmanIntermediateDelegate)] = value; } }
        public Object MoonmanDangerDelegate { get { return this[nameof(MoonmanDangerDelegate)]; } set { this[nameof(MoonmanDangerDelegate)] = value; } }
        public Object OnGameClockTick { get { return this[nameof(OnGameClockTick)]; } set { this[nameof(OnGameClockTick)] = value; } }
        public Object OnGameClockTimeChanged { get { return this[nameof(OnGameClockTimeChanged)]; } set { this[nameof(OnGameClockTimeChanged)] = value; } }
        public Object OnGameClockTickDelta { get { return this[nameof(OnGameClockTickDelta)]; } set { this[nameof(OnGameClockTickDelta)] = value; } }
        public void StartNextHour() { Invoke(nameof(StartNextHour)); }
        public void SetGameTimeEvent(Object Delegate, int Hour, int Minute) { Invoke(nameof(SetGameTimeEvent), Delegate, Hour, Minute); }
        public void SetGameEndEvent(Object Delegate) { Invoke(nameof(SetGameEndEvent), Delegate); }
        public void SetCurrentTime(int Hour, int Minute, bool bPlayDelegates) { Invoke(nameof(SetCurrentTime), Hour, Minute, bPlayDelegates); }
        public void SetCurrentMinute(int Minute) { Invoke(nameof(SetCurrentMinute), Minute); }
        public void SetCurrentHour(int Hour) { Invoke(nameof(SetCurrentHour), Hour); }
        public void SetClockRunning(bool bRunClock) { Invoke(nameof(SetClockRunning), bRunClock); }
        public void SetClockRateInMinutesPerHour(int MinutesPerHour) { Invoke(nameof(SetClockRateInMinutesPerHour), MinutesPerHour); }
        public void SetClockRate(int TotalRealHours) { Invoke(nameof(SetClockRate), TotalRealHours); }
        public void ResetTimeDelegatesUpTo(int Hour, int Minute) { Invoke(nameof(ResetTimeDelegatesUpTo), Hour, Minute); }
        public void OnNormalModeTriggered() { Invoke(nameof(OnNormalModeTriggered)); }
        public void OnMoonmanLiteTriggered() { Invoke(nameof(OnMoonmanLiteTriggered)); }
        public void OnMoonmanIntermediateTriggered() { Invoke(nameof(OnMoonmanIntermediateTriggered)); }
        public void OnMoonmanDangerTriggered() { Invoke(nameof(OnMoonmanDangerTriggered)); }
        public bool IsClockRunning() { return Invoke<bool>(nameof(IsClockRunning)); }
        public float GetCurrentTimeInSeconds() { return Invoke<float>(nameof(GetCurrentTimeInSeconds)); }
        public void GetCurrentTime(int Hour, int Minute) { Invoke(nameof(GetCurrentTime), Hour, Minute); }
    }
    public class GameTypeCheckComponent : ActorComponent
    {
        public GameTypeCheckComponent(ulong addr) : base(addr) { }
        public Array<EFNAFGameType> AllowedGameTypes { get { return new Array<EFNAFGameType>(this[nameof(AllowedGameTypes)].Address); } }
        public Object OnGameTypeAllowed { get { return this[nameof(OnGameTypeAllowed)]; } set { this[nameof(OnGameTypeAllowed)] = value; } }
        public Object OnGameTypeNotAllowed { get { return this[nameof(OnGameTypeNotAllowed)]; } set { this[nameof(OnGameTypeNotAllowed)] = value; } }
        public void OnNotAllowedGameType() { Invoke(nameof(OnNotAllowedGameType)); }
        public void OnAllowedGameType() { Invoke(nameof(OnAllowedGameType)); }
        public bool IsAllowed() { return Invoke<bool>(nameof(IsAllowed)); }
    }
    public class GameTypeCheckDestroy : GameTypeCheckComponent
    {
        public GameTypeCheckDestroy(ulong addr) : base(addr) { }
    }
    public class GlobalAIPerception : Actor
    {
        public GlobalAIPerception(ulong addr) : base(addr) { }
    }
    public class HideObjectInterface : Interface
    {
        public HideObjectInterface(ulong addr) : base(addr) { }
        public void StartSearch(Pawn SearcherPawn) { Invoke(nameof(StartSearch), SearcherPawn); }
        public void PlayBotSearchSound(Actor SearcherActor) { Invoke(nameof(PlayBotSearchSound), SearcherActor); }
        public void OnPlayerLeave() { Invoke(nameof(OnPlayerLeave)); }
        public void OnPlayerHide(Character PlayerCharacter) { Invoke(nameof(OnPlayerHide), PlayerCharacter); }
        public void GetSearchLocation(Vector Location, Rotator Rotation) { Invoke(nameof(GetSearchLocation), Location, Rotation); }
        public EHideObjectType GetHideType() { return Invoke<EHideObjectType>(nameof(GetHideType)); }
        public Vector GetHideLocation() { return Invoke<Vector>(nameof(GetHideLocation)); }
        public Character GetHiddenPlayer() { return Invoke<Character>(nameof(GetHiddenPlayer)); }
        public void EndSearch() { Invoke(nameof(EndSearch)); }
    }
    public class InstructionCardRowBlueprintFunctionLibrary : BlueprintFunctionLibrary
    {
        public InstructionCardRowBlueprintFunctionLibrary(ulong addr) : base(addr) { }
        public Texture2D GetControllerInstructionCard(InstructionCardRow MyStructRef) { return Invoke<Texture2D>(nameof(GetControllerInstructionCard), MyStructRef); }
    }
    public class InventoryConditionalComponent : ActorComponent
    {
        public InventoryConditionalComponent(ulong addr) : base(addr) { }
        public Object RequiredInventoryItem { get { return this[nameof(RequiredInventoryItem)]; } set { this[nameof(RequiredInventoryItem)] = value; } }
        public int RequiredSecurityLevel { get { return this[nameof(RequiredSecurityLevel)].GetValue<int>(); } set { this[nameof(RequiredSecurityLevel)].SetValue<int>(value); } }
        public bool RequiresPartyPass { get { return this[nameof(RequiresPartyPass)].Flag; } set { this[nameof(RequiresPartyPass)].Flag = value; } }
        public EPlayerPawnType RequiresPawn { get { return (EPlayerPawnType)this[nameof(RequiresPawn)].GetValue<int>(); } set { this[nameof(RequiresPawn)].SetValue<int>((int)value); } }
        public EPlayerPawnType PawnTypeIgnoresConditions { get { return (EPlayerPawnType)this[nameof(PawnTypeIgnoresConditions)].GetValue<int>(); } set { this[nameof(PawnTypeIgnoresConditions)].SetValue<int>((int)value); } }
        public void SetNewConditions(Object NewRequiredInventoryItem, int NewRequiredSecurityLevel, bool NewRequiresPartyPass) { Invoke(nameof(SetNewConditions), NewRequiredInventoryItem, NewRequiredSecurityLevel, NewRequiresPartyPass); }
        public void OnMessageCollected(Object ItemName, FNAFMessageTableStruct MessageTableStruct) { Invoke(nameof(OnMessageCollected), ItemName, MessageTableStruct); }
        public void OnItemCollected(Object ItemName, FNAFInventoryTableStruct InventoryTableStruct) { Invoke(nameof(OnItemCollected), ItemName, InventoryTableStruct); }
        public void HasMetConditions(bool OutConditionsMet, EConditionFailReason OutFailReason) { Invoke(nameof(HasMetConditions), OutConditionsMet, OutFailReason); }
    }
    public class ItemCollectListenerComponent : ActorComponent
    {
        public ItemCollectListenerComponent(ulong addr) : base(addr) { }
        public Object OnItemCollected { get { return this[nameof(OnItemCollected)]; } set { this[nameof(OnItemCollected)] = value; } }
        public Object OnItemAlreadyCollected { get { return this[nameof(OnItemAlreadyCollected)]; } set { this[nameof(OnItemAlreadyCollected)] = value; } }
        public Object InventoryItem { get { return this[nameof(InventoryItem)]; } set { this[nameof(InventoryItem)] = value; } }
        public bool bEventsEnabled { get { return this[nameof(bEventsEnabled)].Flag; } set { this[nameof(bEventsEnabled)].Flag = value; } }
        public void SetEventsEnabled(bool bEnable) { Invoke(nameof(SetEventsEnabled), bEnable); }
        public void OnItemCollectedHandler(Object ItemName, FNAFInventoryTableStruct InventoryItemInfo) { Invoke(nameof(OnItemCollectedHandler), ItemName, InventoryItemInfo); }
        public bool GetEventsEnabled() { return Invoke<bool>(nameof(GetEventsEnabled)); }
    }
    public class LevelStreamViewpoint : SceneComponent
    {
        public LevelStreamViewpoint(ulong addr) : base(addr) { }
        public Object OnLevelsLoaded { get { return this[nameof(OnLevelsLoaded)]; } set { this[nameof(OnLevelsLoaded)] = value; } }
        public bool bStreamingEnable { get { return this[nameof(bStreamingEnable)].Flag; } set { this[nameof(bStreamingEnable)].Flag = value; } }
        public bool bEnableStreamOnActivePawn { get { return this[nameof(bEnableStreamOnActivePawn)].Flag; } set { this[nameof(bEnableStreamOnActivePawn)].Flag = value; } }
        public void SetStreamingEnable(bool bEnable) { Invoke(nameof(SetStreamingEnable), bEnable); }
        public void OnLevelManagerUpdated() { Invoke(nameof(OnLevelManagerUpdated)); }
        public Array<Object> GetStreamingLevelNames() { return Invoke<Array<Object>>(nameof(GetStreamingLevelNames)); }
        public bool AnyLevelsLoaded() { return Invoke<bool>(nameof(AnyLevelsLoaded)); }
    }
    public class LightingMaterialManager : Actor
    {
        public LightingMaterialManager(ulong addr) : base(addr) { }
        public Array<LightMeshMaterialInfo> MeshMaterials { get { return new Array<LightMeshMaterialInfo>(this[nameof(MeshMaterials)].Address); } }
        public void OnLevelVisible() { Invoke(nameof(OnLevelVisible)); }
        public void OnBeginLightScenarioChange() { Invoke(nameof(OnBeginLightScenarioChange)); }
        public void OnActivateSpecialLightingScenerio(Object Key) { Invoke(nameof(OnActivateSpecialLightingScenerio), Key); }
    }
    public class LightScenarioManager : WorldSubsystem
    {
        public LightScenarioManager(ulong addr) : base(addr) { }
        public void UnbindOnEndScenarioChange(Object Delegate) { Invoke(nameof(UnbindOnEndScenarioChange), Delegate); }
        public void UnbindOnBeginScenarioChange(Object Delegate) { Invoke(nameof(UnbindOnBeginScenarioChange), Delegate); }
        public void SetInitialScenario(int Area, ELightingScenario Scenario) { Invoke(nameof(SetInitialScenario), Area, Scenario); }
        public void OnUnloadFinished() { Invoke(nameof(OnUnloadFinished)); }
        public void OnTick() { Invoke(nameof(OnTick)); }
        public void OnLoadFinished() { Invoke(nameof(OnLoadFinished)); }
        public void OnFadeoutFinished() { Invoke(nameof(OnFadeoutFinished)); }
        public void OnChangeAreaUnloadFinished() { Invoke(nameof(OnChangeAreaUnloadFinished)); }
        public void OnChangeAreaLoadFinished() { Invoke(nameof(OnChangeAreaLoadFinished)); }
        public bool IsChangingScenario() { return Invoke<bool>(nameof(IsChangingScenario)); }
        public void GetLightScenarioAreaFromMap(Object MapName, ELightScenarioArea OutArea, ELightingScenario OutScenario) { Invoke(nameof(GetLightScenarioAreaFromMap), MapName, OutArea, OutScenario); }
        public Object GetLevelNameFromAreaScenario(int Area, ELightingScenario Scenario) { return Invoke<Object>(nameof(GetLevelNameFromAreaScenario), Area, Scenario); }
        public ELightingScenario GetCurrentLightingScenario() { return Invoke<ELightingScenario>(nameof(GetCurrentLightingScenario)); }
        public int GetCurrentArea() { return Invoke<int>(nameof(GetCurrentArea)); }
        public void EndLoadSequence() { Invoke(nameof(EndLoadSequence)); }
        public void ChangeScenario(ELightingScenario NewScenario, bool bUseFade) { Invoke(nameof(ChangeScenario), NewScenario, bUseFade); }
        public void ChangeArea(int Area) { Invoke(nameof(ChangeArea), Area); }
        public void BindOnEndScenarioChange(Object Delegate) { Invoke(nameof(BindOnEndScenarioChange), Delegate); }
        public void BindOnBeginScenarioChange(Object Delegate) { Invoke(nameof(BindOnBeginScenarioChange), Delegate); }
        public void BeginLoadSequence() { Invoke(nameof(BeginLoadSequence)); }
    }
    public class LightScenarioManagerSettings : DeveloperSettings
    {
        public LightScenarioManagerSettings(ulong addr) : base(addr) { }
        public Object LightScenarioInfo { get { return this[nameof(LightScenarioInfo)]; } set { this[nameof(LightScenarioInfo)] = value; } }
        public Object LightScenarioMap { get { return this[nameof(LightScenarioMap)]; } set { this[nameof(LightScenarioMap)] = value; } }
    }
    public class LightStreamingVolume : Volume
    {
        public LightStreamingVolume(ulong addr) : base(addr) { }
        public int LightScenarioArea { get { return this[nameof(LightScenarioArea)].GetValue<int>(); } set { this[nameof(LightScenarioArea)].SetValue<int>(value); } }
    }
    public class Localization : BlueprintFunctionLibrary
    {
        public Localization(ulong addr) : base(addr) { }
        public byte GetLocalizationCulture() { return Invoke<byte>(nameof(GetLocalizationCulture)); }
        public void ChangeLocalizationCulture(byte Culture) { Invoke(nameof(ChangeLocalizationCulture), Culture); }
    }
    public class MissionDisplayQueueLibrary : BlueprintFunctionLibrary
    {
        public MissionDisplayQueueLibrary(ulong addr) : base(addr) { }
        public void PushMissionUpdate(EMissionUpdateType UpdateType, Object MissionName, FNAFMissionInfo MissionInfo, FNAFMissionState MissionState) { Invoke(nameof(PushMissionUpdate), UpdateType, MissionName, MissionInfo, MissionState); }
        public void HasMissionUpdateInQueue(EMissionInQueue MissionInQueue) { Invoke(nameof(HasMissionUpdateInQueue), MissionInQueue); }
        public MissionDisplayUpdateInfo GetNextMissionUpdate() { return Invoke<MissionDisplayUpdateInfo>(nameof(GetNextMissionUpdate)); }
        public void ClearMissionUpdateQueue() { Invoke(nameof(ClearMissionUpdateQueue)); }
    }
    public class MissionMarker : Actor
    {
        public MissionMarker(ulong addr) : base(addr) { }
        public Object MissionName { get { return this[nameof(MissionName)]; } set { this[nameof(MissionName)] = value; } }
        public int MissionStateIndex { get { return this[nameof(MissionStateIndex)].GetValue<int>(); } set { this[nameof(MissionStateIndex)].SetValue<int>(value); } }
        public int GetStateIndex() { return Invoke<int>(nameof(GetStateIndex)); }
        public Object GetMissionName() { return Invoke<Object>(nameof(GetMissionName)); }
    }
    public class MissionStateCondition : ActorComponent
    {
        public MissionStateCondition(ulong addr) : base(addr) { }
        public Object OnMissionConditionMet { get { return this[nameof(OnMissionConditionMet)]; } set { this[nameof(OnMissionConditionMet)] = value; } }
        public Object OnMissionConditionAlreadyMet { get { return this[nameof(OnMissionConditionAlreadyMet)]; } set { this[nameof(OnMissionConditionAlreadyMet)] = value; } }
        public Object OnMissionConditionUnMet { get { return this[nameof(OnMissionConditionUnMet)]; } set { this[nameof(OnMissionConditionUnMet)] = value; } }
        public Object MissionName { get { return this[nameof(MissionName)]; } set { this[nameof(MissionName)] = value; } }
        public EMissionStatus MissionStatus { get { return (EMissionStatus)this[nameof(MissionStatus)].GetValue<int>(); } set { this[nameof(MissionStatus)].SetValue<int>((int)value); } }
        public int MinMissionState { get { return this[nameof(MinMissionState)].GetValue<int>(); } set { this[nameof(MinMissionState)].SetValue<int>(value); } }
        public int MaxMissionState { get { return this[nameof(MaxMissionState)].GetValue<int>(); } set { this[nameof(MaxMissionState)].SetValue<int>(value); } }
        public void OnMissionUpdated(Object InMissionName, FNAFMissionState MissionState, FNAFMissionInfo MissionInfo) { Invoke(nameof(OnMissionUpdated), InMissionName, MissionState, MissionInfo); }
        public bool HasMetConditions() { return Invoke<bool>(nameof(HasMetConditions)); }
    }
    public class MoonmanManagementSystem : WorldSubsystem
    {
        public MoonmanManagementSystem(ulong addr) : base(addr) { }
        public Object OnMMRegisterSpawn { get { return this[nameof(OnMMRegisterSpawn)]; } set { this[nameof(OnMMRegisterSpawn)] = value; } }
        public Object OnMMUnregisterSpawn { get { return this[nameof(OnMMUnregisterSpawn)]; } set { this[nameof(OnMMUnregisterSpawn)] = value; } }
        public void UnRegisterSpawn(MoonmanSpawnPoint InSpawnPoint) { Invoke(nameof(UnRegisterSpawn), InSpawnPoint); }
        public void UnpauseMoonmanManager() { Invoke(nameof(UnpauseMoonmanManager)); }
        public void StartMoonmanLiteManager() { Invoke(nameof(StartMoonmanLiteManager)); }
        public void StartMoonmanDangerManager() { Invoke(nameof(StartMoonmanDangerManager)); }
        public void RegisterSpawn(MoonmanSpawnPoint InSpawnPoint) { Invoke(nameof(RegisterSpawn), InSpawnPoint); }
        public void PauseMoonmanManager() { Invoke(nameof(PauseMoonmanManager)); }
        public void OnWorldStateChanged(EFNAFGameState NewState, EFNAFGameState PrevState) { Invoke(nameof(OnWorldStateChanged), NewState, PrevState); }
        public Array<MoonmanSpawnPoint> GetAllMMSpawnPointsFor(EMMAnimCategory MMAnimation) { return Invoke<Array<MoonmanSpawnPoint>>(nameof(GetAllMMSpawnPointsFor), MMAnimation); }
        public Array<MoonmanSpawnPoint> GetAllMMSpawnPoints() { return Invoke<Array<MoonmanSpawnPoint>>(nameof(GetAllMMSpawnPoints)); }
    }
    public class MoonmanSpawnPoint : NavigationObjectBase
    {
        public MoonmanSpawnPoint(ulong addr) : base(addr) { }
        public BillboardComponent BillboardComponent { get { return this[nameof(BillboardComponent)].As<BillboardComponent>(); } set { this["BillboardComponent"] = value; } }
        public VisualSourceComponent VisualSource { get { return this[nameof(VisualSource)].As<VisualSourceComponent>(); } set { this["VisualSource"] = value; } }
        public Object OnMMDetected { get { return this[nameof(OnMMDetected)]; } set { this[nameof(OnMMDetected)] = value; } }
        public bool b_CanSpawn { get { return this[nameof(b_CanSpawn)].Flag; } set { this[nameof(b_CanSpawn)].Flag = value; } }
        public EMMAnimCategory MMAnimCategory { get { return (EMMAnimCategory)this[nameof(MMAnimCategory)].GetValue<int>(); } set { this[nameof(MMAnimCategory)].SetValue<int>((int)value); } }
        public Array<AnimSequence> MMAnimSeq_Array { get { return new Array<AnimSequence>(this[nameof(MMAnimSeq_Array)].Address); } }
        public bool bShouldFollowPlayer { get { return this[nameof(bShouldFollowPlayer)].Flag; } set { this[nameof(bShouldFollowPlayer)].Flag = value; } }
        public bool bIsStationary { get { return this[nameof(bIsStationary)].Flag; } set { this[nameof(bIsStationary)].Flag = value; } }
        public bool bAnimLoop { get { return this[nameof(bAnimLoop)].Flag; } set { this[nameof(bAnimLoop)].Flag = value; } }
        public bool bAimHeadAtPlayer { get { return this[nameof(bAimHeadAtPlayer)].Flag; } set { this[nameof(bAimHeadAtPlayer)].Flag = value; } }
        public bool bCanPopUp { get { return this[nameof(bCanPopUp)].Flag; } set { this[nameof(bCanPopUp)].Flag = value; } }
        public bool bIsSingleUse { get { return this[nameof(bIsSingleUse)].Flag; } set { this[nameof(bIsSingleUse)].Flag = value; } }
        public Array<TriggerBox> MMColliderActors { get { return new Array<TriggerBox>(this[nameof(MMColliderActors)].Address); } }
        public float probabilityOfSpawn { get { return this[nameof(probabilityOfSpawn)].GetValue<float>(); } set { this[nameof(probabilityOfSpawn)].SetValue<float>(value); } }
        public float originalProbabilityOfSpawn { get { return this[nameof(originalProbabilityOfSpawn)].GetValue<float>(); } set { this[nameof(originalProbabilityOfSpawn)].SetValue<float>(value); } }
        public void SetSpawnProbability(float tempProbability) { Invoke(nameof(SetSpawnProbability), tempProbability); }
        public void SetShouldFollowPlayer(bool In) { Invoke(nameof(SetShouldFollowPlayer), In); }
        public void SetMMAnimCategory(EMMAnimCategory In) { Invoke(nameof(SetMMAnimCategory), In); }
        public void SetIsTriggered(bool isTriggered) { Invoke(nameof(SetIsTriggered), isTriggered); }
        public void SetIsStationary(bool In) { Invoke(nameof(SetIsStationary), In); }
        public void SetIsSpawned(bool IsSpawned) { Invoke(nameof(SetIsSpawned), IsSpawned); }
        public void SetIsSingleUse(bool In) { Invoke(nameof(SetIsSingleUse), In); }
        public void SetIsMMDetected(bool IsSkeletonDetected) { Invoke(nameof(SetIsMMDetected), IsSkeletonDetected); }
        public void SetIsAnimLoop(bool In) { Invoke(nameof(SetIsAnimLoop), In); }
        public void SetHasSpawnedOnce(bool HasSpawnedOnce) { Invoke(nameof(SetHasSpawnedOnce), HasSpawnedOnce); }
        public void SetHasLookedOnce(bool HasLookedOnce) { Invoke(nameof(SetHasLookedOnce), HasLookedOnce); }
        public void SetCanSpawn(bool canSpawn) { Invoke(nameof(SetCanSpawn), canSpawn); }
        public void SetCanPopUp(bool In) { Invoke(nameof(SetCanPopUp), In); }
        public void SetAimHeadAtPlayer(bool In) { Invoke(nameof(SetAimHeadAtPlayer), In); }
        public void OnSetAIDisplay(bool enable) { Invoke(nameof(OnSetAIDisplay), enable); }
        public float GetSpawnProbability() { return Invoke<float>(nameof(GetSpawnProbability)); }
        public float GetOriginalProbability() { return Invoke<float>(nameof(GetOriginalProbability)); }
        public Array<AnimSequence> GetMMAnimSeq_Array() { return Invoke<Array<AnimSequence>>(nameof(GetMMAnimSeq_Array)); }
        public EMMAnimCategory GetMMAnimCategory() { return Invoke<EMMAnimCategory>(nameof(GetMMAnimCategory)); }
        public bool GetIsTriggered() { return Invoke<bool>(nameof(GetIsTriggered)); }
        public bool GetIsStationary() { return Invoke<bool>(nameof(GetIsStationary)); }
        public bool GetIsSpawned() { return Invoke<bool>(nameof(GetIsSpawned)); }
        public bool GetIsSingleUse() { return Invoke<bool>(nameof(GetIsSingleUse)); }
        public bool GetIsMMDetected() { return Invoke<bool>(nameof(GetIsMMDetected)); }
        public bool GetIsFollowPlayerTrue() { return Invoke<bool>(nameof(GetIsFollowPlayerTrue)); }
        public bool GetIsAnimLoop() { return Invoke<bool>(nameof(GetIsAnimLoop)); }
        public bool GetHasSpawnedOnce() { return Invoke<bool>(nameof(GetHasSpawnedOnce)); }
        public bool GetHasLookedOnce() { return Invoke<bool>(nameof(GetHasLookedOnce)); }
        public bool GetCanSpawn() { return Invoke<bool>(nameof(GetCanSpawn)); }
        public bool GetCanPopUp() { return Invoke<bool>(nameof(GetCanPopUp)); }
        public bool GetAimHeadAtPlayer() { return Invoke<bool>(nameof(GetAimHeadAtPlayer)); }
        public void DetectTheSpawnPoint(MoonmanSpawnPoint passed_HitActor, bool passed_bVisible) { Invoke(nameof(DetectTheSpawnPoint), passed_HitActor, passed_bVisible); }
    }
    public class PatrollerInterface : Interface
    {
        public PatrollerInterface(ulong addr) : base(addr) { }
        public void SetPatrolPath(Object PatrolPath) { Invoke(nameof(SetPatrolPath), PatrolPath); }
        public void SetCurrentPatrolPointIndex(int PatrolPointIndex) { Invoke(nameof(SetCurrentPatrolPointIndex), PatrolPointIndex); }
        public Object GetPatrolPath() { return Invoke<Object>(nameof(GetPatrolPath)); }
        public int GetCurrentPatrolPointIndex() { return Invoke<int>(nameof(GetCurrentPatrolPointIndex)); }
    }
    public class PlayerTriggerWithConditionComps : PlayerTrigger
    {
        public PlayerTriggerWithConditionComps(ulong addr) : base(addr) { }
        public EConditionCheckType ConditionCheck { get { return (EConditionCheckType)this[nameof(ConditionCheck)].GetValue<int>(); } set { this[nameof(ConditionCheck)].SetValue<int>((int)value); } }
    }
    public class RichTextControlButtonDecorator : RichTextBlockDecorator
    {
        public RichTextControlButtonDecorator(ulong addr) : base(addr) { }
        public DataTable ButtonSet { get { return this[nameof(ButtonSet)].As<DataTable>(); } set { this["ButtonSet"] = value; } }
    }
    public class SaveHandlerInterface : Interface
    {
        public SaveHandlerInterface(ulong addr) : base(addr) { }
        public void PostSaveGame() { Invoke(nameof(PostSaveGame)); }
        public void PostGameLoad() { Invoke(nameof(PostGameLoad)); }
        public void OnStoreGameData(FNAFSaveData SaveDataObject) { Invoke(nameof(OnStoreGameData), SaveDataObject); }
        public void OnGameDataLoaded(FNAFSaveData SaveDataObject) { Invoke(nameof(OnGameDataLoaded), SaveDataObject); }
        public void OnCheckpointSave(FNAFSaveData SaveDataObject) { Invoke(nameof(OnCheckpointSave), SaveDataObject); }
        public void OnCheckpointLoad(FNAFSaveData SaveDataObject) { Invoke(nameof(OnCheckpointLoad), SaveDataObject); }
    }
    public class SecurityCamera : Actor
    {
        public SecurityCamera(ulong addr) : base(addr) { }
        public SceneComponent CameraPivot { get { return this[nameof(CameraPivot)].As<SceneComponent>(); } set { this["CameraPivot"] = value; } }
        public SightComponent PlayerDetector { get { return this[nameof(PlayerDetector)].As<SightComponent>(); } set { this["PlayerDetector"] = value; } }
        public SceneComponent PlayerControlledPivot { get { return this[nameof(PlayerControlledPivot)].As<SceneComponent>(); } set { this["PlayerControlledPivot"] = value; } }
        public SightComponent EnemyDetector { get { return this[nameof(EnemyDetector)].As<SightComponent>(); } set { this["EnemyDetector"] = value; } }
        public Object CameraInventoryName { get { return this[nameof(CameraInventoryName)]; } set { this[nameof(CameraInventoryName)] = value; } }
        public bool FazwatchAccessible { get { return this[nameof(FazwatchAccessible)].Flag; } set { this[nameof(FazwatchAccessible)].Flag = value; } }
        public bool bPlayerDetectorStartsOn { get { return this[nameof(bPlayerDetectorStartsOn)].Flag; } set { this[nameof(bPlayerDetectorStartsOn)].Flag = value; } }
        public bool bEnemyDetectorStartsOn { get { return this[nameof(bEnemyDetectorStartsOn)].Flag; } set { this[nameof(bEnemyDetectorStartsOn)].Flag = value; } }
        public bool bPlayerDetected { get { return this[nameof(bPlayerDetected)].Flag; } set { this[nameof(bPlayerDetected)].Flag = value; } }
        public Object CameraName { get { return this[nameof(CameraName)]; } set { this[nameof(CameraName)] = value; } }
        public float PanMin { get { return this[nameof(PanMin)].GetValue<float>(); } set { this[nameof(PanMin)].SetValue<float>(value); } }
        public float PanMax { get { return this[nameof(PanMax)].GetValue<float>(); } set { this[nameof(PanMax)].SetValue<float>(value); } }
        public float TiltMin { get { return this[nameof(TiltMin)].GetValue<float>(); } set { this[nameof(TiltMin)].SetValue<float>(value); } }
        public float TiltMax { get { return this[nameof(TiltMax)].GetValue<float>(); } set { this[nameof(TiltMax)].SetValue<float>(value); } }
        public void StopOfficeMode() { Invoke(nameof(StopOfficeMode)); }
        public void StartOfficeMode() { Invoke(nameof(StartOfficeMode)); }
        public void SetPlayerDetectorEnabled(bool bEnable) { Invoke(nameof(SetPlayerDetectorEnabled), bEnable); }
        public void SetEnemeyDetectorEnabled(bool bEnable) { Invoke(nameof(SetEnemeyDetectorEnabled), bEnable); }
        public void OnPlayerDetectorSightChanged(Actor UpdatedActor, bool bVisible) { Invoke(nameof(OnPlayerDetectorSightChanged), UpdatedActor, bVisible); }
        public void OnOfficeModeStarted() { Invoke(nameof(OnOfficeModeStarted)); }
        public void OnEnemyDetectorSightChanged(Actor UpdatedActor, bool bVisible) { Invoke(nameof(OnEnemyDetectorSightChanged), UpdatedActor, bVisible); }
        public bool IsCameraUnlocked(bool OnlyShowCurrentMission) { return Invoke<bool>(nameof(IsCameraUnlocked), OnlyShowCurrentMission); }
        public bool HasDetectedEnemies() { return Invoke<bool>(nameof(HasDetectedEnemies)); }
        public Array<Actor> GetVisibleEnemies() { return Invoke<Array<Actor>>(nameof(GetVisibleEnemies)); }
        public SceneCaptureComponent2D GetPlayerSceneCapture() { return Invoke<SceneCaptureComponent2D>(nameof(GetPlayerSceneCapture)); }
        public TextureRenderTarget2D GetCaptureTarget() { return Invoke<TextureRenderTarget2D>(nameof(GetCaptureTarget)); }
        public void CaptureView() { Invoke(nameof(CaptureView)); }
    }
    public class SecurityCameraSystem : WorldSubsystem
    {
        public SecurityCameraSystem(ulong addr) : base(addr) { }
        public Object OnCameraAlert { get { return this[nameof(OnCameraAlert)]; } set { this[nameof(OnCameraAlert)] = value; } }
        public Object OnCameraRegistered { get { return this[nameof(OnCameraRegistered)]; } set { this[nameof(OnCameraRegistered)] = value; } }
        public Object OnCameraUnregistered { get { return this[nameof(OnCameraUnregistered)]; } set { this[nameof(OnCameraUnregistered)] = value; } }
        public Object OnCameraTriggerAlert { get { return this[nameof(OnCameraTriggerAlert)]; } set { this[nameof(OnCameraTriggerAlert)] = value; } }
        public Object OnCameraTriggerLostAlert { get { return this[nameof(OnCameraTriggerLostAlert)]; } set { this[nameof(OnCameraTriggerLostAlert)] = value; } }
        public void PlayerSpotted(SecurityCamera SecurityCamera) { Invoke(nameof(PlayerSpotted), SecurityCamera); }
        public Array<SecurityCamera> GetAllSecurityCameras() { return Invoke<Array<SecurityCamera>>(nameof(GetAllSecurityCameras)); }
    }
    public class SeekerPatrolPath : Interface
    {
        public SeekerPatrolPath(ulong addr) : base(addr) { }
        public EFNAFAISpawnType GetSpawnType() { return Invoke<EFNAFAISpawnType>(nameof(GetSpawnType)); }
        public Object GetPathName() { return Invoke<Object>(nameof(GetPathName)); }
    }
    public class SightComponent : SceneComponent
    {
        public SightComponent(ulong addr) : base(addr) { }
        public Object OnSightChanged { get { return this[nameof(OnSightChanged)]; } set { this[nameof(OnSightChanged)] = value; } }
        public float SightAngle { get { return this[nameof(SightAngle)].GetValue<float>(); } set { this[nameof(SightAngle)].SetValue<float>(value); } }
        public float StartDistance { get { return this[nameof(StartDistance)].GetValue<float>(); } set { this[nameof(StartDistance)].SetValue<float>(value); } }
        public float EndDistance { get { return this[nameof(EndDistance)].GetValue<float>(); } set { this[nameof(EndDistance)].SetValue<float>(value); } }
        public ESightType SightType { get { return (ESightType)this[nameof(SightType)].GetValue<int>(); } set { this[nameof(SightType)].SetValue<int>((int)value); } }
        public float AspectRatio { get { return this[nameof(AspectRatio)].GetValue<float>(); } set { this[nameof(AspectRatio)].SetValue<float>(value); } }
        public float MinYaw { get { return this[nameof(MinYaw)].GetValue<float>(); } set { this[nameof(MinYaw)].SetValue<float>(value); } }
        public float MaxYaw { get { return this[nameof(MaxYaw)].GetValue<float>(); } set { this[nameof(MaxYaw)].SetValue<float>(value); } }
        public float MinPitch { get { return this[nameof(MinPitch)].GetValue<float>(); } set { this[nameof(MinPitch)].SetValue<float>(value); } }
        public float MaxPitch { get { return this[nameof(MaxPitch)].GetValue<float>(); } set { this[nameof(MaxPitch)].SetValue<float>(value); } }
        public int ThetaSteps { get { return this[nameof(ThetaSteps)].GetValue<int>(); } set { this[nameof(ThetaSteps)].SetValue<int>(value); } }
        public int PhiSteps { get { return this[nameof(PhiSteps)].GetValue<int>(); } set { this[nameof(PhiSteps)].SetValue<int>(value); } }
        public Array<Actor> VisibleActors { get { return new Array<Actor>(this[nameof(VisibleActors)].Address); } }
        public Array<MoonmanSpawnPoint> VisibleMMActors { get { return new Array<MoonmanSpawnPoint>(this[nameof(VisibleMMActors)].Address); } }
        public bool bSightDetectionEnabled { get { return this[nameof(bSightDetectionEnabled)].Flag; } set { this[nameof(bSightDetectionEnabled)].Flag = value; } }
        public bool bShowVisionDebug { get { return this[nameof(bShowVisionDebug)].Flag; } set { this[nameof(bShowVisionDebug)].Flag = value; } }
        public Array<Object> IncludeTags { get { return new Array<Object>(this[nameof(IncludeTags)].Address); } }
        public void SetSightType(ESightType InSightType) { Invoke(nameof(SetSightType), InSightType); }
        public void SetSightParams(float Angle, float MinDistance, float MaxDistance) { Invoke(nameof(SetSightParams), Angle, MinDistance, MaxDistance); }
        public void SetSightEnabled(bool bEnable) { Invoke(nameof(SetSightEnabled), bEnable); }
        public void SetSightAngle(float Angle) { Invoke(nameof(SetSightAngle), Angle); }
        public void SetIncludeTags(Array<Object> InIgnoreTags) { Invoke(nameof(SetIncludeTags), InIgnoreTags); }
        public void SetFrustumTypeParams(float InMinYaw, float InMaxYaw, float InMinPitch, float InMaxPitch) { Invoke(nameof(SetFrustumTypeParams), InMinYaw, InMaxYaw, InMinPitch, InMaxPitch); }
        public void SetEndDistance(float Distance) { Invoke(nameof(SetEndDistance), Distance); }
        public void SetAspectRatio(float Ratio) { Invoke(nameof(SetAspectRatio), Ratio); }
        public void OnVisualQueryResults(Array<Object> DetectedSources) { Invoke(nameof(OnVisualQueryResults), DetectedSources); }
        public void OnVisibleActorDestroyed(Actor DestroyedActor) { Invoke(nameof(OnVisibleActorDestroyed), DestroyedActor); }
        public void OnMoonManQueryResults(Array<Object> MoonManSpawnPoints) { Invoke(nameof(OnMoonManQueryResults), MoonManSpawnPoints); }
        public ESightType IsUsingConeSight() { return Invoke<ESightType>(nameof(IsUsingConeSight)); }
        public bool IsSightEnabled() { return Invoke<bool>(nameof(IsSightEnabled)); }
        public bool IsActorVisible(Actor Actor) { return Invoke<bool>(nameof(IsActorVisible), Actor); }
        public Array<Actor> GetVisibleActors() { return Invoke<Array<Actor>>(nameof(GetVisibleActors)); }
        public float GetStartDistance() { return Invoke<float>(nameof(GetStartDistance)); }
        public float GetSightAngle() { return Invoke<float>(nameof(GetSightAngle)); }
        public float GetMinYaw() { return Invoke<float>(nameof(GetMinYaw)); }
        public float GetMinPitch() { return Invoke<float>(nameof(GetMinPitch)); }
        public float GetMaxYaw() { return Invoke<float>(nameof(GetMaxYaw)); }
        public float GetMaxPitch() { return Invoke<float>(nameof(GetMaxPitch)); }
        public Array<Object> GetIncludeTags() { return Invoke<Array<Object>>(nameof(GetIncludeTags)); }
        public void GetFrustumTypeParams(float OutMinYaw, float OutMaxYaw, float OutMinPitch, float OutMaxPitch) { Invoke(nameof(GetFrustumTypeParams), OutMinYaw, OutMaxYaw, OutMinPitch, OutMaxPitch); }
        public float GetEndDistance() { return Invoke<float>(nameof(GetEndDistance)); }
        public float GetAspectRatio() { return Invoke<float>(nameof(GetAspectRatio)); }
    }
    public class SplineFollowMovementComponent : ActorComponent
    {
        public SplineFollowMovementComponent(ulong addr) : base(addr) { }
        public Object OnFinishedFollowingSpline { get { return this[nameof(OnFinishedFollowingSpline)]; } set { this[nameof(OnFinishedFollowingSpline)] = value; } }
        public float MovementSpeed { get { return this[nameof(MovementSpeed)].GetValue<float>(); } set { this[nameof(MovementSpeed)].SetValue<float>(value); } }
        public SplineComponent SplineToFollow { get { return this[nameof(SplineToFollow)].As<SplineComponent>(); } set { this["SplineToFollow"] = value; } }
        public bool bOrientToTangent { get { return this[nameof(bOrientToTangent)].Flag; } set { this[nameof(bOrientToTangent)].Flag = value; } }
        public void StopFollowingSpline() { Invoke(nameof(StopFollowingSpline)); }
        public void StartFollowingSpline() { Invoke(nameof(StartFollowingSpline)); }
        public void SetSplineToFollow(SplineComponent Spline) { Invoke(nameof(SetSplineToFollow), Spline); }
        public void SetDistanceAlongSpline(float Distance) { Invoke(nameof(SetDistanceAlongSpline), Distance); }
        public bool IsFollowingSpline() { return Invoke<bool>(nameof(IsFollowingSpline)); }
        public float GetCurrentDistance() { return Invoke<float>(nameof(GetCurrentDistance)); }
    }
    public class SplineUtils : BlueprintFunctionLibrary
    {
        public SplineUtils(ulong addr) : base(addr) { }
        public float GetApproxDistanceClosestToWorldLocation(Vector Pos_WS, SplineComponent Spline) { return Invoke<float>(nameof(GetApproxDistanceClosestToWorldLocation), Pos_WS, Spline); }
    }
    public class WorldStateComponent : ActorComponent
    {
        public WorldStateComponent(ulong addr) : base(addr) { }
        public Object SaveName { get { return this[nameof(SaveName)]; } set { this[nameof(SaveName)] = value; } }
        public bool bSaveOnStateChange { get { return this[nameof(bSaveOnStateChange)].Flag; } set { this[nameof(bSaveOnStateChange)].Flag = value; } }
        public void SetObjectState(bool bEnabled) { Invoke(nameof(SetObjectState), bEnabled); }
        public bool HasValidSaveName() { return Invoke<bool>(nameof(HasValidSaveName)); }
        public bool GetObjectState() { return Invoke<bool>(nameof(GetObjectState)); }
    }
    public class StoreActiveStateOnTrigger : WorldStateComponent
    {
        public StoreActiveStateOnTrigger(ulong addr) : base(addr) { }
        public Object OnPlayerTriggered { get { return this[nameof(OnPlayerTriggered)]; } set { this[nameof(OnPlayerTriggered)] = value; } }
        public EPlayerPawnType PlayerType { get { return (EPlayerPawnType)this[nameof(PlayerType)].GetValue<int>(); } set { this[nameof(PlayerType)].SetValue<int>((int)value); } }
        public void OnActorTriggered(Actor OverlappedActor, Actor OtherActor) { Invoke(nameof(OnActorTriggered), OverlappedActor, OtherActor); }
    }
    public class StreamingLevelUtil : BlueprintFunctionLibrary
    {
        public StreamingLevelUtil(ulong addr) : base(addr) { }
        public void LoadStreamingLevelsAtLocation(Object WorldContextObject, Vector WorldLocation, bool bEnableVolumesAfterLoad, LatentActionInfo LatentInfo) { Invoke(nameof(LoadStreamingLevelsAtLocation), WorldContextObject, WorldLocation, bEnableVolumesAfterLoad, LatentInfo); }
        public Array<LevelStreamingVolume> GetAllStreamingVolumesAtLocation(Object WorldContextObject, Vector WorldLocation) { return Invoke<Array<LevelStreamingVolume>>(nameof(GetAllStreamingVolumesAtLocation), WorldContextObject, WorldLocation); }
        public Array<LevelStreamingVolume> GetAllStreamingVolumes(Object WorldContextObject) { return Invoke<Array<LevelStreamingVolume>>(nameof(GetAllStreamingVolumes), WorldContextObject); }
        public Array<LevelStreaming> GetAllStreamingLevelsAtLocation(Object WorldContextObject, Vector WorldLocation) { return Invoke<Array<LevelStreaming>>(nameof(GetAllStreamingLevelsAtLocation), WorldContextObject, WorldLocation); }
        public Array<LevelStreaming> GetAllStreamingLevels(Object WorldContextObject) { return Invoke<Array<LevelStreaming>>(nameof(GetAllStreamingLevels), WorldContextObject); }
        public Array<Level> GetAllLevels(Object WorldContextObject) { return Invoke<Array<Level>>(nameof(GetAllLevels), WorldContextObject); }
        public void EnableAllStreamingVolumes(Object WorldContextObject, bool bEnable) { Invoke(nameof(EnableAllStreamingVolumes), WorldContextObject, bEnable); }
    }
    public class StreamingLoadComponent : ActorComponent
    {
        public StreamingLoadComponent(ulong addr) : base(addr) { }
        public Object OnLevelStreamingFinished { get { return this[nameof(OnLevelStreamingFinished)]; } set { this[nameof(OnLevelStreamingFinished)] = value; } }
        public bool bTurnVolumesOnAfterLoad { get { return this[nameof(bTurnVolumesOnAfterLoad)].Flag; } set { this[nameof(bTurnVolumesOnAfterLoad)].Flag = value; } }
        public void StartAsyncLoadForLocation(Vector WorldLocation) { Invoke(nameof(StartAsyncLoadForLocation), WorldLocation); }
        public void OnLevelLoaded() { Invoke(nameof(OnLevelLoaded)); }
        public bool IsStreamingLevels() { return Invoke<bool>(nameof(IsStreamingLevels)); }
        public void EnableAllStreamingVolumes(bool bEnable) { Invoke(nameof(EnableAllStreamingVolumes), bEnable); }
    }
    public class SurvivalDoorConditionManager : Actor
    {
        public SurvivalDoorConditionManager(ulong addr) : base(addr) { }
        public Array<Object> DoorList { get { return new Array<Object>(this[nameof(DoorList)].Address); } }
        public int SecurityLevel { get { return this[nameof(SecurityLevel)].GetValue<int>(); } set { this[nameof(SecurityLevel)].SetValue<int>(value); } }
        public Object RequiredItem { get { return this[nameof(RequiredItem)]; } set { this[nameof(RequiredItem)] = value; } }
    }
    public class SurvivalItemPackage : Actor
    {
        public SurvivalItemPackage(ulong addr) : base(addr) { }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
        public EItemAreaType ItemArea { get { return (EItemAreaType)this[nameof(ItemArea)].GetValue<int>(); } set { this[nameof(ItemArea)].SetValue<int>((int)value); } }
        public SurvivalItemRandomizer SurvivalRandomizer { get { return this[nameof(SurvivalRandomizer)].As<SurvivalItemRandomizer>(); } set { this["SurvivalRandomizer"] = value; } }
        public void OnSetup() { Invoke(nameof(OnSetup)); }
        public bool HasCollected() { return Invoke<bool>(nameof(HasCollected)); }
        public void Collect() { Invoke(nameof(Collect)); }
    }
    public class SurvivalItemRandomizer : ItemRandomizer
    {
        public SurvivalItemRandomizer(ulong addr) : base(addr) { }
        public int PointsPerPink { get { return this[nameof(PointsPerPink)].GetValue<int>(); } set { this[nameof(PointsPerPink)].SetValue<int>(value); } }
        public int PointsPerYellow { get { return this[nameof(PointsPerYellow)].GetValue<int>(); } set { this[nameof(PointsPerYellow)].SetValue<int>(value); } }
        public int PointsPerGreen { get { return this[nameof(PointsPerGreen)].GetValue<int>(); } set { this[nameof(PointsPerGreen)].SetValue<int>(value); } }
        public int PointsPerRed { get { return this[nameof(PointsPerRed)].GetValue<int>(); } set { this[nameof(PointsPerRed)].SetValue<int>(value); } }
        public int PointsPerPurple { get { return this[nameof(PointsPerPurple)].GetValue<int>(); } set { this[nameof(PointsPerPurple)].SetValue<int>(value); } }
        public int PointsPerGold { get { return this[nameof(PointsPerGold)].GetValue<int>(); } set { this[nameof(PointsPerGold)].SetValue<int>(value); } }
        public int CollectedPink { get { return this[nameof(CollectedPink)].GetValue<int>(); } set { this[nameof(CollectedPink)].SetValue<int>(value); } }
        public int TotalPink { get { return this[nameof(TotalPink)].GetValue<int>(); } set { this[nameof(TotalPink)].SetValue<int>(value); } }
        public int CollectedYellow { get { return this[nameof(CollectedYellow)].GetValue<int>(); } set { this[nameof(CollectedYellow)].SetValue<int>(value); } }
        public int TotalYellow { get { return this[nameof(TotalYellow)].GetValue<int>(); } set { this[nameof(TotalYellow)].SetValue<int>(value); } }
        public int CollectedGreen { get { return this[nameof(CollectedGreen)].GetValue<int>(); } set { this[nameof(CollectedGreen)].SetValue<int>(value); } }
        public int TotalGreen { get { return this[nameof(TotalGreen)].GetValue<int>(); } set { this[nameof(TotalGreen)].SetValue<int>(value); } }
        public int CollectedRed { get { return this[nameof(CollectedRed)].GetValue<int>(); } set { this[nameof(CollectedRed)].SetValue<int>(value); } }
        public int TotalRed { get { return this[nameof(TotalRed)].GetValue<int>(); } set { this[nameof(TotalRed)].SetValue<int>(value); } }
        public int CollectedPurple { get { return this[nameof(CollectedPurple)].GetValue<int>(); } set { this[nameof(CollectedPurple)].SetValue<int>(value); } }
        public int TotalPurple { get { return this[nameof(TotalPurple)].GetValue<int>(); } set { this[nameof(TotalPurple)].SetValue<int>(value); } }
        public int CollectedGold { get { return this[nameof(CollectedGold)].GetValue<int>(); } set { this[nameof(CollectedGold)].SetValue<int>(value); } }
        public int TotalGold { get { return this[nameof(TotalGold)].GetValue<int>(); } set { this[nameof(TotalGold)].SetValue<int>(value); } }
        public Array<SurvivalItemPackage> RemainingPackages { get { return new Array<SurvivalItemPackage>(this[nameof(RemainingPackages)].Address); } }
        public Object InfoPerArea { get { return this[nameof(InfoPerArea)]; } set { this[nameof(InfoPerArea)] = value; } }
        public Object SurvivalPackageClass { get { return this[nameof(SurvivalPackageClass)]; } set { this[nameof(SurvivalPackageClass)] = value; } }
        public void RandomizeSurvivalItems(bool bSpawnAllLocations) { Invoke(nameof(RandomizeSurvivalItems), bSpawnAllLocations); }
        public bool HasCollected(SurvivalItemPackage Package) { return Invoke<bool>(nameof(HasCollected), Package); }
        public void GetYellowScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetYellowScore), OutCount, OutPointsPerPackage, OutScore); }
        public void GetRedScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetRedScore), OutCount, OutPointsPerPackage, OutScore); }
        public void GetPurpleScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetPurpleScore), OutCount, OutPointsPerPackage, OutScore); }
        public void GetPinkScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetPinkScore), OutCount, OutPointsPerPackage, OutScore); }
        public Array<SurvivalItemPackage> GetPackagesSortedByDistance() { return Invoke<Array<SurvivalItemPackage>>(nameof(GetPackagesSortedByDistance)); }
        public void GetGreenScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetGreenScore), OutCount, OutPointsPerPackage, OutScore); }
        public void GetGoldScore(int OutCount, int OutPointsPerPackage, int OutScore) { Invoke(nameof(GetGoldScore), OutCount, OutPointsPerPackage, OutScore); }
    }
    public class SurvivalRandomItem : RandomItemGroup
    {
        public SurvivalRandomItem(ulong addr) : base(addr) { }
        public EItemAreaType AreaType { get { return (EItemAreaType)this[nameof(AreaType)].GetValue<int>(); } set { this[nameof(AreaType)].SetValue<int>((int)value); } }
    }
    public class UpdateMissionComponent : ActorComponent
    {
        public UpdateMissionComponent(ulong addr) : base(addr) { }
        public Object MissionName { get { return this[nameof(MissionName)]; } set { this[nameof(MissionName)] = value; } }
        public int MissionStateIndex { get { return this[nameof(MissionStateIndex)].GetValue<int>(); } set { this[nameof(MissionStateIndex)].SetValue<int>(value); } }
        public bool bShouldComplete { get { return this[nameof(bShouldComplete)].Flag; } set { this[nameof(bShouldComplete)].Flag = value; } }
        public bool bShouldSave { get { return this[nameof(bShouldSave)].Flag; } set { this[nameof(bShouldSave)].Flag = value; } }
        public void UpdateMission() { Invoke(nameof(UpdateMission)); }
        public bool IsMissionFinished() { return Invoke<bool>(nameof(IsMissionFinished)); }
        public bool HasMetCondition() { return Invoke<bool>(nameof(HasMetCondition)); }
        public Object GetMissionName() { return Invoke<Object>(nameof(GetMissionName)); }
    }
    public class VisualSourceComponent : ActorComponent
    {
        public VisualSourceComponent(ulong addr) : base(addr) { }
        public Object OnSourceDetected { get { return this[nameof(OnSourceDetected)]; } set { this[nameof(OnSourceDetected)] = value; } }
        public Array<Vector> VisualOffsets { get { return new Array<Vector>(this[nameof(VisualOffsets)].Address); } }
        public bool bIsVisibilityEnabled { get { return this[nameof(bIsVisibilityEnabled)].Flag; } set { this[nameof(bIsVisibilityEnabled)].Flag = value; } }
        public void SetVisualOffsetLocations(Array<Vector> InVisualOffsets) { Invoke(nameof(SetVisualOffsetLocations), InVisualOffsets); }
        public void SetVisualOffset(int PointIndex, Vector visualOffset) { Invoke(nameof(SetVisualOffset), PointIndex, visualOffset); }
        public void SetSourceVisibility(bool bEnable) { Invoke(nameof(SetSourceVisibility), bEnable); }
        public void RemoveVisualOffset(int PointIndex) { Invoke(nameof(RemoveVisualOffset), PointIndex); }
        public Array<Vector> GetVisualOffsets() { return Invoke<Array<Vector>>(nameof(GetVisualOffsets)); }
        public Array<Vector> GetVisualLocations() { return Invoke<Array<Vector>>(nameof(GetVisualLocations)); }
        public bool GetSourceVisibility() { return Invoke<bool>(nameof(GetSourceVisibility)); }
        public Vector GetDetectedVisualLocation() { return Invoke<Vector>(nameof(GetDetectedVisualLocation)); }
        public void DetectTheSource(Vector VSLocation, Actor passed_HitActor, bool passed_bVisible) { Invoke(nameof(DetectTheSource), VSLocation, passed_HitActor, passed_bVisible); }
    }
    public class WorldStateHandlerComponent : ActorComponent
    {
        public WorldStateHandlerComponent(ulong addr) : base(addr) { }
        public Object OnObjectStateChanged { get { return this[nameof(OnObjectStateChanged)]; } set { this[nameof(OnObjectStateChanged)] = value; } }
        public Object ObjectStateName { get { return this[nameof(ObjectStateName)]; } set { this[nameof(ObjectStateName)] = value; } }
        public bool bConditionMetOnStateSet { get { return this[nameof(bConditionMetOnStateSet)].Flag; } set { this[nameof(bConditionMetOnStateSet)].Flag = value; } }
        public void SetObjectState(bool bEnable) { Invoke(nameof(SetObjectState), bEnable); }
        public void OnObjectStateChangedHandle(Object ObjectName, bool ObjectState) { Invoke(nameof(OnObjectStateChangedHandle), ObjectName, ObjectState); }
        public void OnObjectStateChangedEvent() { Invoke(nameof(OnObjectStateChangedEvent)); }
        public bool HasValidSaveName() { return Invoke<bool>(nameof(HasValidSaveName)); }
        public bool GetObjectState() { return Invoke<bool>(nameof(GetObjectState)); }
    }
    public class WorldStateSystem : GameInstanceSubsystem
    {
        public WorldStateSystem(ulong addr) : base(addr) { }
        public Object OnWorldStateChanged { get { return this[nameof(OnWorldStateChanged)]; } set { this[nameof(OnWorldStateChanged)] = value; } }
        public Object OnObjectStateChanged { get { return this[nameof(OnObjectStateChanged)]; } set { this[nameof(OnObjectStateChanged)] = value; } }
        public FreddyUpgradeState FreddyState { get { return this[nameof(FreddyState)].As<FreddyUpgradeState>(); } set { this["FreddyState"] = value; } }
        public RandomStream SeededRandomStream { get { return this[nameof(SeededRandomStream)].As<RandomStream>(); } set { this["SeededRandomStream"] = value; } }
        public EFNAFGameState WorldState { get { return (EFNAFGameState)this[nameof(WorldState)].GetValue<int>(); } set { this[nameof(WorldState)].SetValue<int>((int)value); } }
        public Object ActivatedObjects { get { return this[nameof(ActivatedObjects)]; } set { this[nameof(ActivatedObjects)] = value; } }
        public FNAFAISaveData AIState { get { return this[nameof(AIState)].As<FNAFAISaveData>(); } set { this["AIState"] = value; } }
        public ArcadeSaveData ArcadeState { get { return this[nameof(ArcadeState)].As<ArcadeSaveData>(); } set { this["ArcadeState"] = value; } }
        public Object CurrentMinigameName { get { return this[nameof(CurrentMinigameName)]; } set { this[nameof(CurrentMinigameName)] = value; } }
        public Actor CurrentMinigameActor { get { return this[nameof(CurrentMinigameActor)].As<Actor>(); } set { this["CurrentMinigameActor"] = value; } }
        public ESurvivalDifficulty SurvivalDifficulty { get { return (ESurvivalDifficulty)this[nameof(SurvivalDifficulty)].GetValue<int>(); } set { this[nameof(SurvivalDifficulty)].SetValue<int>((int)value); } }
        public Object CurrentActivityId { get { return this[nameof(CurrentActivityId)]; } set { this[nameof(CurrentActivityId)] = value; } }
        public void StartMinigame(Object MinigameName, EFNAFGameState GameState, Actor MinigameActor) { Invoke(nameof(StartMinigame), MinigameName, GameState, MinigameActor); }
        public void SetWorldState(EFNAFGameState NewState) { Invoke(nameof(SetWorldState), NewState); }
        public void SetupNewGame() { Invoke(nameof(SetupNewGame)); }
        public void SetSurvivalMaxDeaths(int MaxDeaths) { Invoke(nameof(SetSurvivalMaxDeaths), MaxDeaths); }
        public void SetSurvivalDifficulty(ESurvivalDifficulty Difficulty) { Invoke(nameof(SetSurvivalDifficulty), Difficulty); }
        public void SetRandomSeed(int Seed) { Invoke(nameof(SetRandomSeed), Seed); }
        public void SetPowerStationAvailable(bool bAvailable) { Invoke(nameof(SetPowerStationAvailable), bAvailable); }
        public void SetPlayerInPowerStation(int InPowerStationID) { Invoke(nameof(SetPlayerInPowerStation), InPowerStationID); }
        public void SetPlayerInFreddy(bool bInFreddy) { Invoke(nameof(SetPlayerInFreddy), bInFreddy); }
        public void SetPlayerHasUsedHidingSpot() { Invoke(nameof(SetPlayerHasUsedHidingSpot)); }
        public void SetFreddySick(bool bIsSick) { Invoke(nameof(SetFreddySick), bIsSick); }
        public void SetFreddyPatrolPoint(int PatrolPointIndex) { Invoke(nameof(SetFreddyPatrolPoint), PatrolPointIndex); }
        public void SetCurrentActivityId(Object InActivityId) { Invoke(nameof(SetCurrentActivityId), InActivityId); }
        public void SetCanEnterExitFreddy(bool bCanEnterExit) { Invoke(nameof(SetCanEnterExitFreddy), bCanEnterExit); }
        public void SetCanCallFreddy(bool bCanCall) { Invoke(nameof(SetCanCallFreddy), bCanCall); }
        public void SetArcadeState(ArcadeSaveData InArcadeState) { Invoke(nameof(SetArcadeState), InArcadeState); }
        public void SetAIState(FNAFAISaveData InAIState) { Invoke(nameof(SetAIState), InAIState); }
        public void RemoveActivated(Object ActivatableName) { Invoke(nameof(RemoveActivated), ActivatableName); }
        public bool IsPowerStationAvailable() { return Invoke<bool>(nameof(IsPowerStationAvailable)); }
        public bool IsPlayerInFreddy() { return Invoke<bool>(nameof(IsPlayerInFreddy)); }
        public bool IsFreddySick() { return Invoke<bool>(nameof(IsFreddySick)); }
        public bool IsActivated(Object ActivatableName) { return Invoke<bool>(nameof(IsActivated), ActivatableName); }
        public bool HasPlayerUsedHidingSpot() { return Invoke<bool>(nameof(HasPlayerUsedHidingSpot)); }
        public EFNAFGameState GetWorldState() { return Invoke<EFNAFGameState>(nameof(GetWorldState)); }
        public int GetSurvivalMaxDeaths() { return Invoke<int>(nameof(GetSurvivalMaxDeaths)); }
        public ESurvivalDifficulty GetSurvivalDifficulty() { return Invoke<ESurvivalDifficulty>(nameof(GetSurvivalDifficulty)); }
        public void GetSavedPlayerLocationAndRotation(Vector OutWorldLocation, Rotator OutWorldRotation) { Invoke(nameof(GetSavedPlayerLocationAndRotation), OutWorldLocation, OutWorldRotation); }
        public void GetSavedFreddyLocationAndRotation(bool OutFreddyInWorld, Vector OutWorldLocation, Rotator OutWorldRotation) { Invoke(nameof(GetSavedFreddyLocationAndRotation), OutFreddyInWorld, OutWorldLocation, OutWorldRotation); }
        public int GetRandomSeed() { return Invoke<int>(nameof(GetRandomSeed)); }
        public void GetPowerStationInfo(bool OutPlayerInPowerStation, int OutPowerStationID) { Invoke(nameof(GetPowerStationInfo), OutPlayerInPowerStation, OutPowerStationID); }
        public int GetLivesRemaining() { return Invoke<int>(nameof(GetLivesRemaining)); }
        public FNAFBasePlayerCharacter GetFreddyPawn() { return Invoke<FNAFBasePlayerCharacter>(nameof(GetFreddyPawn)); }
        public int GetFreddyPatrolPoint() { return Invoke<int>(nameof(GetFreddyPatrolPoint)); }
        public int GetCurrentSpottedCount() { return Invoke<int>(nameof(GetCurrentSpottedCount)); }
        public Actor GetCurrentMinigameActor() { return Invoke<Actor>(nameof(GetCurrentMinigameActor)); }
        public Object GetCurrentMinigame() { return Invoke<Object>(nameof(GetCurrentMinigame)); }
        public int GetCurrentDeathCount() { return Invoke<int>(nameof(GetCurrentDeathCount)); }
        public Object GetCurrentActivityId() { return Invoke<Object>(nameof(GetCurrentActivityId)); }
        public ArcadeSaveData GetArcadeState() { return Invoke<ArcadeSaveData>(nameof(GetArcadeState)); }
        public FNAFAISaveData GetAIState() { return Invoke<FNAFAISaveData>(nameof(GetAIState)); }
        public void EndMinigame() { Invoke(nameof(EndMinigame)); }
        public void DebugSetPlayerHasUsedHidingSpot(bool HasHid) { Invoke(nameof(DebugSetPlayerHasUsedHidingSpot), HasHid); }
        public void ClearPlayerInPowerStation() { Invoke(nameof(ClearPlayerInPowerStation)); }
        public void CanStartMinigame(bool CanStart, ECantStartMinigameReason reason) { Invoke(nameof(CanStartMinigame), CanStart, reason); }
        public bool CanEnterExitFreddy() { return Invoke<bool>(nameof(CanEnterExitFreddy)); }
        public bool CanCallFreddy() { return Invoke<bool>(nameof(CanCallFreddy)); }
        public void AddSpotted() { Invoke(nameof(AddSpotted)); }
        public void AddDeath(int OutRemainingLives) { Invoke(nameof(AddDeath), OutRemainingLives); }
        public void AddActivated(Object ActivatableName) { Invoke(nameof(AddActivated), ActivatableName); }
    }
    public class FNAFInventoryTableStruct : TableRowBase
    {
        public FNAFInventoryTableStruct(ulong addr) : base(addr) { }
        public EInventoryItemCategory Category { get { return (EInventoryItemCategory)this[nameof(Category)].GetValue<int>(); } set { this[nameof(Category)].SetValue<int>((int)value); } }
        public EInventoryItemSurvivalCategory SurvivalCategory { get { return (EInventoryItemSurvivalCategory)this[nameof(SurvivalCategory)].GetValue<int>(); } set { this[nameof(SurvivalCategory)].SetValue<int>((int)value); } }
        public bool PrizeVIP { get { return this[nameof(PrizeVIP)].Flag; } set { this[nameof(PrizeVIP)].Flag = value; } }
        public Object ItemDisplayName { get { return this[nameof(ItemDisplayName)]; } set { this[nameof(ItemDisplayName)] = value; } }
        public Texture2D ItemIcon { get { return this[nameof(ItemIcon)].As<Texture2D>(); } set { this["ItemIcon"] = value; } }
        public StaticMesh ItemModel { get { return this[nameof(ItemModel)].As<StaticMesh>(); } set { this["ItemModel"] = value; } }
        public Object ItemDescription { get { return this[nameof(ItemDescription)]; } set { this[nameof(ItemDescription)] = value; } }
    }
    public enum EInventoryItemSurvivalCategory : int
    {
        None = 0,
        Key = 1,
        Item = 2,
        FreddyUpgrade = 3,
        BotUpgrade = 4,
        GregoryUpgrade = 5,
        Bad = 6,
        Collectible_Common = 7,
        Collectible_Uncommon = 8,
        Collectible_Rare = 9,
        Collectible_UltraRare = 10,
        LobbyKey = 11,
        Flashlight = 12,
        EInventoryItemSurvivalCategory_MAX = 13,
    }
    public enum EInventoryItemCategory : int
    {
        None = 0,
        Message = 1,
        Equipment = 2,
        Food = 3,
        Toys = 4,
        Trophy = 5,
        LostAndFound = 6,
        Character = 7,
        SecurityBadge = 8,
        PartyBadge = 9,
        RetroCD = 10,
        EInventoryItemCategory_MAX = 11,
    }
    public class FNAFMessageTableStruct : TableRowBase
    {
        public FNAFMessageTableStruct(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object Sound { get { return this[nameof(Sound)]; } set { this[nameof(Sound)] = value; } }
        public bool InGame { get { return this[nameof(InGame)].Flag; } set { this[nameof(InGame)].Flag = value; } }
    }
    public enum EConditionFailReason : int
    {
        None = 0,
        ItemRequired = 1,
        SecurityLevel = 2,
        PartyPass = 3,
        WrongPawn = 4,
        Error = 5,
        EConditionFailReason_MAX = 6,
    }
    public class FNAFMissionInfo : TableRowBase
    {
        public FNAFMissionInfo(ulong addr) : base(addr) { }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Array<Object> TaskNames { get { return new Array<Object>(this[nameof(TaskNames)].Address); } }
        public bool bValidForSurvival { get { return this[nameof(bValidForSurvival)].Flag; } set { this[nameof(bValidForSurvival)].Flag = value; } }
        public bool bShowAllTasks { get { return this[nameof(bShowAllTasks)].Flag; } set { this[nameof(bShowAllTasks)].Flag = value; } }
        public Array<Object> DependentMissions { get { return new Array<Object>(this[nameof(DependentMissions)].Address); } }
    }
    public class FNAFMissionState : Object
    {
        public FNAFMissionState(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public EMissionStatus Status { get { return (EMissionStatus)this[nameof(Status)].GetValue<int>(); } set { this[nameof(Status)].SetValue<int>((int)value); } }
        public int InfoState { get { return this[nameof(InfoState)].GetValue<int>(); } set { this[nameof(InfoState)].SetValue<int>(value); } }
        public Array<int> CompletedTasks { get { return new Array<int>(this[nameof(CompletedTasks)].Address); } }
    }
    public enum EMissionStatus : int
    {
        None = 0,
        Active = 1,
        Complete = 2,
        EMissionStatus_MAX = 3,
    }
    public enum EFNAFGameState : int
    {
        Normal = 0,
        MoonManLite = 1,
        MoonManIntermediate = 2,
        MoonManDanger = 3,
        RepairGame = 4,
        OfficeGame = 5,
        BossGame = 6,
        PowerCycle = 7,
        EFNAFGameState_MAX = 8,
    }
    public enum ECameraAngleFlags : int
    {
        Horizontal = 1,
        Vertical = 2,
        HorizontalAndVertical = 3,
        None = 0,
        ECameraAngleFlags_MAX = 4,
    }
    public enum EAlertType : int
    {
        Generic = 0,
        Chica = 1,
        Vanny = 2,
        Vanessa = 3,
        EAlertType_MAX = 4,
    }
    public enum EDoorSide : int
    {
        Both = 0,
        None = 1,
        Front = 2,
        Back = 3,
        EDoorSide_MAX = 4,
    }
    public enum EFNAFAISpawnType : int
    {
        Chica = 0,
        Roxy = 1,
        Monty = 2,
        Vanessa = 3,
        DJMusicMan = 4,
        Endo = 5,
        MapBot = 6,
        Freddy = 7,
        EFNAFAISpawnType_MAX = 8,
    }
    public enum EFNAFGameType : int
    {
        Normal = 0,
        Survival = 1,
        DirectMinigame = 2,
        EFNAFGameType_MAX = 3,
    }
    public enum ESWGInputDeviceType : int
    {
        MouseAndKeyboard = 0,
        XBox = 1,
        Switch = 2,
        DUALSHOCK = 3,
        ESWGInputDeviceType_MAX = 4,
    }
    public enum ELevelArea : int
    {
        RoxyRacers = 0,
        GatorGolf = 1,
        FazerTag = 2,
        Lobby = 3,
        Atrium = 4,
        RockstarRow = 5,
        DayCare = 6,
        KidsCove = 7,
        ELevelArea_MAX = 8,
    }
    public enum EPlayerPawnType : int
    {
        None = 0,
        Flying = 1,
        Gregory = 2,
        Freddy = 3,
        StaffBot = 4,
        EPlayerPawnType_MAX = 5,
    }
    public enum EFreddyUpgradeType : int
    {
        PowerUpgrade = 0,
        MontyClaws = 1,
        ChicaBeak = 2,
        RoxyEyes = 3,
        EFreddyUpgradeType_MAX = 4,
    }
    public enum EHideObjectType : int
    {
        None = 0,
        Table = 1,
        Locker = 2,
        PhotoBooth = 3,
        FirstAidBooth = 4,
        Stroller = 5,
        ServiceCart = 6,
        Kiosk = 7,
        BeverageCart = 8,
        EHideObjectType_MAX = 9,
    }
    public enum ELightingScenario : int
    {
        None = 0,
        LightsOn = 1,
        LightsOff = 2,
        Dawn = 3,
        ELightingScenario_MAX = 4,
    }
    public enum ELightScenarioArea : int
    {
        None = 0,
        Atrium = 1,
        BehindStage = 2,
        Daycare = 3,
        EastArcade = 4,
        EastAtrium = 5,
        FazerBlast = 6,
        GatorGolf = 7,
        Kitchen = 8,
        MainLobby = 9,
        RockstarRow = 10,
        RoxyRaceway = 11,
        Salon = 12,
        UtilityEast = 13,
        UtilityWest = 14,
        WestArcade = 15,
        WestAtrium = 16,
        ELightScenarioArea_MAX = 17,
    }
    public enum ELocalizationCulture : int
    {
        English = 0,
        English_US_Computer = 1,
        French = 2,
        French_Canada = 3,
        German = 4,
        Italian = 5,
        Portuguese_Brazil = 6,
        Russian = 7,
        Spanish_Latin_America = 8,
        Spanish_Spain = 9,
        ELocalizationCulture_MAX = 10,
    }
    public enum EMissionInQueue : int
    {
        HasMoreMissions = 0,
        NoMoreMissions = 1,
        EMissionInQueue_MAX = 2,
    }
    public enum EMissionUpdateType : int
    {
        NewMission = 0,
        UpdateInfoState = 1,
        Completed = 2,
        EMissionUpdateType_MAX = 3,
    }
    public enum EMMAnimCategory : int
    {
        None = 0,
        GeneralFloor = 1,
        GeneralCeiling = 2,
        RightEdge = 3,
        RightEdgeCrawl = 4,
        LeftEdge = 5,
        LeftEdgeCrawl = 6,
        FloorEdge = 7,
        CeilingEdge = 8,
        ClosingIn = 9,
        GeneralFloor_01 = 10,
        GeneralCeiling_01 = 11,
        RightEdge_01 = 12,
        RightEdgeCrawl_01 = 13,
        LeftEdge_01 = 14,
        LeftEdgeCrawl_01 = 15,
        FloorEdge_01 = 16,
        CeilingEdge_01 = 17,
        EMMAnimCategory_MAX = 18,
    }
    public enum EConditionCheckType : int
    {
        All = 0,
        Any = 1,
        None = 2,
        EConditionCheckType_MAX = 3,
    }
    public enum ESightType : int
    {
        Cone = 0,
        FOV = 1,
        Frustum = 2,
        ESightType_MAX = 3,
    }
    public enum EItemAreaType : int
    {
        Unknown = 0,
        Pink = 1,
        Yellow = 2,
        Green = 3,
        Red = 4,
        Purple = 5,
        Gold = 6,
        EItemAreaType_MAX = 7,
    }
    public enum ESurvivalDifficulty : int
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Nightmare = 3,
        ESurvivalDifficulty_MAX = 4,
    }
    public enum ECantStartMinigameReason : int
    {
        None = 0,
        AlreadyInMinigame = 1,
        PlayerInDanger = 2,
        MoonMan = 3,
        Survival = 4,
        ECantStartMinigameReason_MAX = 5,
    }
    public class AnimatronicExpectedData : Object
    {
        public AnimatronicExpectedData(ulong addr) : base(addr) { }
        public EFNAFAISpawnType AIType { get { return (EFNAFAISpawnType)this[nameof(AIType)].GetValue<int>(); } set { this[nameof(AIType)].SetValue<int>((int)value); } }
        public Object PathName { get { return this[nameof(PathName)]; } set { this[nameof(PathName)] = value; } }
    }
    public class AIDistanceResult : Object
    {
        public AIDistanceResult(ulong addr) : base(addr) { }
        public Pawn Pawn { get { return this[nameof(Pawn)].As<Pawn>(); } set { this["Pawn"] = value; } }
        public EFNAFAISpawnType AIType { get { return (EFNAFAISpawnType)this[nameof(AIType)].GetValue<int>(); } set { this[nameof(AIType)].SetValue<int>((int)value); } }
        public float NavDistance { get { return this[nameof(NavDistance)].GetValue<float>(); } set { this[nameof(NavDistance)].SetValue<float>(value); } }
    }
    public class AIRoomEntryInfo : Object
    {
        public AIRoomEntryInfo(ulong addr) : base(addr) { }
        public Pawn AIPawn { get { return this[nameof(AIPawn)].As<Pawn>(); } set { this["AIPawn"] = value; } }
        public RoomAreaBase RoomEntering { get { return this[nameof(RoomEntering)].As<RoomAreaBase>(); } set { this["RoomEntering"] = value; } }
    }
    public class FNAFAISettingInfo : Object
    {
        public FNAFAISettingInfo(ulong addr) : base(addr) { }
        public SoftClassPath StandardType { get { return this[nameof(StandardType)].As<SoftClassPath>(); } set { this["StandardType"] = value; } }
        public SoftClassPath ShatteredType { get { return this[nameof(ShatteredType)].As<SoftClassPath>(); } set { this["ShatteredType"] = value; } }
    }
    public class ArcadeSaveData : Object
    {
        public ArcadeSaveData(ulong addr) : base(addr) { }
        public BalloonWorldSaveData BalloonWorld { get { return this[nameof(BalloonWorld)].As<BalloonWorldSaveData>(); } set { this["BalloonWorld"] = value; } }
        public ChicaFeedingFrenzySaveData ChicaFeedingFrenzy { get { return this[nameof(ChicaFeedingFrenzy)].As<ChicaFeedingFrenzySaveData>(); } set { this["ChicaFeedingFrenzy"] = value; } }
        public MinigolfOneSaveData MinigolfOne { get { return this[nameof(MinigolfOne)].As<MinigolfOneSaveData>(); } set { this["MinigolfOne"] = value; } }
        public MinigolfTwoSaveData MinigolfTwo { get { return this[nameof(MinigolfTwo)].As<MinigolfTwoSaveData>(); } set { this["MinigolfTwo"] = value; } }
        public MinigolfFullSaveData MinigolfFull { get { return this[nameof(MinigolfFull)].As<MinigolfFullSaveData>(); } set { this["MinigolfFull"] = value; } }
        public PrincessQuestOneSaveData PrincessQuestOne { get { return this[nameof(PrincessQuestOne)].As<PrincessQuestOneSaveData>(); } set { this["PrincessQuestOne"] = value; } }
        public PrincessQuestTwoSaveData PrincessQuestTwo { get { return this[nameof(PrincessQuestTwo)].As<PrincessQuestTwoSaveData>(); } set { this["PrincessQuestTwo"] = value; } }
        public PrincessQuestThreeSaveData PrincessQuestThree { get { return this[nameof(PrincessQuestThree)].As<PrincessQuestThreeSaveData>(); } set { this["PrincessQuestThree"] = value; } }
    }
    public class PrincessQuestThreeSaveData : Object
    {
        public PrincessQuestThreeSaveData(ulong addr) : base(addr) { }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
        public bool Glitched { get { return this[nameof(Glitched)].Flag; } set { this[nameof(Glitched)].Flag = value; } }
    }
    public class PrincessQuestTwoSaveData : Object
    {
        public PrincessQuestTwoSaveData(ulong addr) : base(addr) { }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
        public bool Glitched { get { return this[nameof(Glitched)].Flag; } set { this[nameof(Glitched)].Flag = value; } }
    }
    public class PrincessQuestOneSaveData : Object
    {
        public PrincessQuestOneSaveData(ulong addr) : base(addr) { }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
        public bool Glitched { get { return this[nameof(Glitched)].Flag; } set { this[nameof(Glitched)].Flag = value; } }
    }
    public class MinigolfFullSaveData : Object
    {
        public MinigolfFullSaveData(ulong addr) : base(addr) { }
        public int HighScore { get { return this[nameof(HighScore)].GetValue<int>(); } set { this[nameof(HighScore)].SetValue<int>(value); } }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
    }
    public class MinigolfTwoSaveData : Object
    {
        public MinigolfTwoSaveData(ulong addr) : base(addr) { }
        public int HighScore { get { return this[nameof(HighScore)].GetValue<int>(); } set { this[nameof(HighScore)].SetValue<int>(value); } }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
    }
    public class MinigolfOneSaveData : Object
    {
        public MinigolfOneSaveData(ulong addr) : base(addr) { }
        public int HighScore { get { return this[nameof(HighScore)].GetValue<int>(); } set { this[nameof(HighScore)].SetValue<int>(value); } }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
    }
    public class ChicaFeedingFrenzySaveData : Object
    {
        public ChicaFeedingFrenzySaveData(ulong addr) : base(addr) { }
        public int HighScore { get { return this[nameof(HighScore)].GetValue<int>(); } set { this[nameof(HighScore)].SetValue<int>(value); } }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
        public bool Glitched { get { return this[nameof(Glitched)].Flag; } set { this[nameof(Glitched)].Flag = value; } }
    }
    public class BalloonWorldSaveData : Object
    {
        public BalloonWorldSaveData(ulong addr) : base(addr) { }
        public int HighScore { get { return this[nameof(HighScore)].GetValue<int>(); } set { this[nameof(HighScore)].SetValue<int>(value); } }
        public bool Played { get { return this[nameof(Played)].Flag; } set { this[nameof(Played)].Flag = value; } }
        public bool Glitched { get { return this[nameof(Glitched)].Flag; } set { this[nameof(Glitched)].Flag = value; } }
    }
    public class ConditionResultDelegates : Object
    {
        public ConditionResultDelegates(ulong addr) : base(addr) { }
    }
    public class PawnInDoorwayInfo : Object
    {
        public PawnInDoorwayInfo(ulong addr) : base(addr) { }
    }
    public class DoorEntryRequirements : Object
    {
        public DoorEntryRequirements(ulong addr) : base(addr) { }
        public Array<EPlayerPawnType> RestrictedPawns { get { return new Array<EPlayerPawnType>(this[nameof(RestrictedPawns)].Address); } }
        public Array<EPlayerPawnType> PawnIgnoresConditions { get { return new Array<EPlayerPawnType>(this[nameof(PawnIgnoresConditions)].Address); } }
        public int RequiredSecurityLevel { get { return this[nameof(RequiredSecurityLevel)].GetValue<int>(); } set { this[nameof(RequiredSecurityLevel)].SetValue<int>(value); } }
        public Object RequiredInventoryItem { get { return this[nameof(RequiredInventoryItem)]; } set { this[nameof(RequiredInventoryItem)] = value; } }
        public EDoorSide ConditionDirection { get { return (EDoorSide)this[nameof(ConditionDirection)].GetValue<int>(); } set { this[nameof(ConditionDirection)].SetValue<int>((int)value); } }
        public bool bInitiallyLockedPlayer { get { return this[nameof(bInitiallyLockedPlayer)].Flag; } set { this[nameof(bInitiallyLockedPlayer)].Flag = value; } }
        public bool bInitiallyLockedAI { get { return this[nameof(bInitiallyLockedAI)].Flag; } set { this[nameof(bInitiallyLockedAI)].Flag = value; } }
        public bool bStartOpen { get { return this[nameof(bStartOpen)].Flag; } set { this[nameof(bStartOpen)].Flag = value; } }
        public bool bIsAutomaticDoorForPlayer { get { return this[nameof(bIsAutomaticDoorForPlayer)].Flag; } set { this[nameof(bIsAutomaticDoorForPlayer)].Flag = value; } }
        public bool bIsAutomaticDoorForAI { get { return this[nameof(bIsAutomaticDoorForAI)].Flag; } set { this[nameof(bIsAutomaticDoorForAI)].Flag = value; } }
    }
    public class FNAFAISaveData : Object
    {
        public FNAFAISaveData(ulong addr) : base(addr) { }
        public bool bShatteredChica { get { return this[nameof(bShatteredChica)].Flag; } set { this[nameof(bShatteredChica)].Flag = value; } }
        public bool bShatteredRoxy { get { return this[nameof(bShatteredRoxy)].Flag; } set { this[nameof(bShatteredRoxy)].Flag = value; } }
        public bool bShatteredMonty { get { return this[nameof(bShatteredMonty)].Flag; } set { this[nameof(bShatteredMonty)].Flag = value; } }
        public bool bWorldSpawnEnabled { get { return this[nameof(bWorldSpawnEnabled)].Flag; } set { this[nameof(bWorldSpawnEnabled)].Flag = value; } }
        public bool bAITeleportEnabled { get { return this[nameof(bAITeleportEnabled)].Flag; } set { this[nameof(bAITeleportEnabled)].Flag = value; } }
        public Object AnimatronicStates { get { return this[nameof(AnimatronicStates)]; } set { this[nameof(AnimatronicStates)] = value; } }
        public Array<EndoSaveData> Endos { get { return new Array<EndoSaveData>(this[nameof(Endos)].Address); } }
    }
    public class EndoSaveData : Object
    {
        public EndoSaveData(ulong addr) : base(addr) { }
        public Vector Location { get { return this[nameof(Location)].As<Vector>(); } set { this["Location"] = value; } }
        public Rotator Rotation { get { return this[nameof(Rotation)].As<Rotator>(); } set { this["Rotation"] = value; } }
    }
    public class AnimatronicState : Object
    {
        public AnimatronicState(ulong addr) : base(addr) { }
        public Object PathName { get { return this[nameof(PathName)]; } set { this[nameof(PathName)] = value; } }
        public bool bIsShattered { get { return this[nameof(bIsShattered)].Flag; } set { this[nameof(bIsShattered)].Flag = value; } }
    }
    public class FNAFEventSystemData : Object
    {
        public FNAFEventSystemData(ulong addr) : base(addr) { }
    }
    public class FNAFPowerSaveData : Object
    {
        public FNAFPowerSaveData(ulong addr) : base(addr) { }
        public int PowerLevel { get { return this[nameof(PowerLevel)].GetValue<int>(); } set { this[nameof(PowerLevel)].SetValue<int>(value); } }
        public int MaxPowerLevel { get { return this[nameof(MaxPowerLevel)].GetValue<int>(); } set { this[nameof(MaxPowerLevel)].SetValue<int>(value); } }
    }
    public class FNAFInventorySaveData : Object
    {
        public FNAFInventorySaveData(ulong addr) : base(addr) { }
        public Array<FNAFItemCollectInfo> InventoryItems { get { return new Array<FNAFItemCollectInfo>(this[nameof(InventoryItems)].Address); } }
        public Array<FNAFItemCollectInfo> Messages { get { return new Array<FNAFItemCollectInfo>(this[nameof(Messages)].Address); } }
        public int SecurityLevel { get { return this[nameof(SecurityLevel)].GetValue<int>(); } set { this[nameof(SecurityLevel)].SetValue<int>(value); } }
        public int UsedPartyPassCount { get { return this[nameof(UsedPartyPassCount)].GetValue<int>(); } set { this[nameof(UsedPartyPassCount)].SetValue<int>(value); } }
        public int NumFlashCharges { get { return this[nameof(NumFlashCharges)].GetValue<int>(); } set { this[nameof(NumFlashCharges)].SetValue<int>(value); } }
        public int FlashlightInStationID { get { return this[nameof(FlashlightInStationID)].GetValue<int>(); } set { this[nameof(FlashlightInStationID)].SetValue<int>(value); } }
        public Object TapesListenedTo { get { return this[nameof(TapesListenedTo)]; } set { this[nameof(TapesListenedTo)] = value; } }
        public int DishesBroken { get { return this[nameof(DishesBroken)].GetValue<int>(); } set { this[nameof(DishesBroken)].SetValue<int>(value); } }
    }
    public class FNAFItemCollectInfo : Object
    {
        public FNAFItemCollectInfo(ulong addr) : base(addr) { }
        public Object ItemName { get { return this[nameof(ItemName)]; } set { this[nameof(ItemName)] = value; } }
        public bool HasViewed { get { return this[nameof(HasViewed)].Flag; } set { this[nameof(HasViewed)].Flag = value; } }
        public long CollectionTime { get { return this[nameof(CollectionTime)].GetValue<long>(); } set { this[nameof(CollectionTime)].SetValue<long>(value); } }
        public int GameHour { get { return this[nameof(GameHour)].GetValue<int>(); } set { this[nameof(GameHour)].SetValue<int>(value); } }
        public int GameMinute { get { return this[nameof(GameMinute)].GetValue<int>(); } set { this[nameof(GameMinute)].SetValue<int>(value); } }
        public int PlayIteration { get { return this[nameof(PlayIteration)].GetValue<int>(); } set { this[nameof(PlayIteration)].SetValue<int>(value); } }
    }
    public class FNAFMissionTaskInfo : TableRowBase
    {
        public FNAFMissionTaskInfo(ulong addr) : base(addr) { }
        public Object TaskTitle { get { return this[nameof(TaskTitle)]; } set { this[nameof(TaskTitle)] = value; } }
        public Object TaskDetails { get { return this[nameof(TaskDetails)]; } set { this[nameof(TaskDetails)] = value; } }
        public Object LinkedMessage { get { return this[nameof(LinkedMessage)]; } set { this[nameof(LinkedMessage)] = value; } }
        public Array<Object> ItemsEarned { get { return new Array<Object>(this[nameof(ItemsEarned)].Address); } }
        public Array<Object> ActivatedStates { get { return new Array<Object>(this[nameof(ActivatedStates)].Address); } }
        public Array<Object> DeactivatedStates { get { return new Array<Object>(this[nameof(DeactivatedStates)].Address); } }
        public Object LocationActor { get { return this[nameof(LocationActor)]; } set { this[nameof(LocationActor)] = value; } }
        public MissionFreddySettings FreddySettings { get { return this[nameof(FreddySettings)].As<MissionFreddySettings>(); } set { this["FreddySettings"] = value; } }
        public MissionClockSettings ClockSettings { get { return this[nameof(ClockSettings)].As<MissionClockSettings>(); } set { this["ClockSettings"] = value; } }
        public bool bSkipEnabled { get { return this[nameof(bSkipEnabled)].Flag; } set { this[nameof(bSkipEnabled)].Flag = value; } }
    }
    public class MissionClockSettings : Object
    {
        public MissionClockSettings(ulong addr) : base(addr) { }
        public bool bClockRunning { get { return this[nameof(bClockRunning)].Flag; } set { this[nameof(bClockRunning)].Flag = value; } }
        public int Hour { get { return this[nameof(Hour)].GetValue<int>(); } set { this[nameof(Hour)].SetValue<int>(value); } }
        public int Minute { get { return this[nameof(Minute)].GetValue<int>(); } set { this[nameof(Minute)].SetValue<int>(value); } }
    }
    public class MissionFreddySettings : Object
    {
        public MissionFreddySettings(ulong addr) : base(addr) { }
        public bool bInsideFreddy { get { return this[nameof(bInsideFreddy)].Flag; } set { this[nameof(bInsideFreddy)].Flag = value; } }
        public bool bCanEnterExitFreddy { get { return this[nameof(bCanEnterExitFreddy)].Flag; } set { this[nameof(bCanEnterExitFreddy)].Flag = value; } }
        public bool bCanCallFreddy { get { return this[nameof(bCanCallFreddy)].Flag; } set { this[nameof(bCanCallFreddy)].Flag = value; } }
        public bool bSickFreddy { get { return this[nameof(bSickFreddy)].Flag; } set { this[nameof(bSickFreddy)].Flag = value; } }
        public Object LocationActor { get { return this[nameof(LocationActor)]; } set { this[nameof(LocationActor)] = value; } }
    }
    public class FNAFSaveslotsData : TableRowBase
    {
        public FNAFSaveslotsData(ulong addr) : base(addr) { }
        public Object SlotNameByUser { get { return this[nameof(SlotNameByUser)]; } set { this[nameof(SlotNameByUser)] = value; } }
    }
    public class FNAFWorldStateSaveData : Object
    {
        public FNAFWorldStateSaveData(ulong addr) : base(addr) { }
        public Object ActivatedObjects { get { return this[nameof(ActivatedObjects)]; } set { this[nameof(ActivatedObjects)] = value; } }
        public bool bFreddyInWorld { get { return this[nameof(bFreddyInWorld)].Flag; } set { this[nameof(bFreddyInWorld)].Flag = value; } }
        public Vector FreddyPosition { get { return this[nameof(FreddyPosition)].As<Vector>(); } set { this["FreddyPosition"] = value; } }
        public Rotator FreddyRotation { get { return this[nameof(FreddyRotation)].As<Rotator>(); } set { this["FreddyRotation"] = value; } }
        public bool bCanCallFreddy { get { return this[nameof(bCanCallFreddy)].Flag; } set { this[nameof(bCanCallFreddy)].Flag = value; } }
        public bool bCanEnterExitFreddy { get { return this[nameof(bCanEnterExitFreddy)].Flag; } set { this[nameof(bCanEnterExitFreddy)].Flag = value; } }
        public bool bIsInFreddy { get { return this[nameof(bIsInFreddy)].Flag; } set { this[nameof(bIsInFreddy)].Flag = value; } }
        public bool bUseSickFreddy { get { return this[nameof(bUseSickFreddy)].Flag; } set { this[nameof(bUseSickFreddy)].Flag = value; } }
        public bool bPlayerUsedHidingSpace { get { return this[nameof(bPlayerUsedHidingSpace)].Flag; } set { this[nameof(bPlayerUsedHidingSpace)].Flag = value; } }
        public bool bCanUsePowerStation { get { return this[nameof(bCanUsePowerStation)].Flag; } set { this[nameof(bCanUsePowerStation)].Flag = value; } }
        public int FreddyPatrolPoint { get { return this[nameof(FreddyPatrolPoint)].GetValue<int>(); } set { this[nameof(FreddyPatrolPoint)].SetValue<int>(value); } }
        public EFNAFGameState GameState { get { return (EFNAFGameState)this[nameof(GameState)].GetValue<int>(); } set { this[nameof(GameState)].SetValue<int>((int)value); } }
    }
    public class FreddyUpgradeState : Object
    {
        public FreddyUpgradeState(ulong addr) : base(addr) { }
        public bool HasPowerUpgrade { get { return this[nameof(HasPowerUpgrade)].Flag; } set { this[nameof(HasPowerUpgrade)].Flag = value; } }
        public bool HasMontyClaws { get { return this[nameof(HasMontyClaws)].Flag; } set { this[nameof(HasMontyClaws)].Flag = value; } }
        public bool HasChicaBeak { get { return this[nameof(HasChicaBeak)].Flag; } set { this[nameof(HasChicaBeak)].Flag = value; } }
        public bool HasRoxyEyes { get { return this[nameof(HasRoxyEyes)].Flag; } set { this[nameof(HasRoxyEyes)].Flag = value; } }
    }
    public class InstructionCardRow : TableRowBase
    {
        public InstructionCardRow(ulong addr) : base(addr) { }
        public Texture2D DefaultTexture2D { get { return this[nameof(DefaultTexture2D)].As<Texture2D>(); } set { this["DefaultTexture2D"] = value; } }
        public Object PerControllerTexture2D { get { return this[nameof(PerControllerTexture2D)]; } set { this[nameof(PerControllerTexture2D)] = value; } }
    }
    public class LightMeshMaterialInfo : Object
    {
        public LightMeshMaterialInfo(ulong addr) : base(addr) { }
        public Object ListName { get { return this[nameof(ListName)]; } set { this[nameof(ListName)] = value; } }
        public Array<Object> StaticMeshActor { get { return new Array<Object>(this[nameof(StaticMeshActor)].Address); } }
        public Array<MaterialInterface> LightsOnMaterials { get { return new Array<MaterialInterface>(this[nameof(LightsOnMaterials)].Address); } }
        public Array<MaterialInterface> LightsOffMaterials { get { return new Array<MaterialInterface>(this[nameof(LightsOffMaterials)].Address); } }
        public Array<MaterialInterface> DawnMaterials { get { return new Array<MaterialInterface>(this[nameof(DawnMaterials)].Address); } }
        public Object SpecialEventMaterials { get { return this[nameof(SpecialEventMaterials)]; } set { this[nameof(SpecialEventMaterials)] = value; } }
    }
    public class MaterialArray : Object
    {
        public MaterialArray(ulong addr) : base(addr) { }
        public Array<MaterialInterface> MaterialArray_value { get { return new Array<MaterialInterface>(this[nameof(MaterialArray)].Address); } }
    }
    public class LightScenarioAreaInfo : Object
    {
        public LightScenarioAreaInfo(ulong addr) : base(addr) { }
        public Object LightsOn { get { return this[nameof(LightsOn)]; } set { this[nameof(LightsOn)] = value; } }
        public Object LightsOff { get { return this[nameof(LightsOff)]; } set { this[nameof(LightsOff)] = value; } }
        public Object Dawn { get { return this[nameof(Dawn)]; } set { this[nameof(Dawn)] = value; } }
    }
    public class LightScenarioManagerData : Object
    {
        public LightScenarioManagerData(ulong addr) : base(addr) { }
        public ELightingScenario Scenario { get { return (ELightingScenario)this[nameof(Scenario)].GetValue<int>(); } set { this[nameof(Scenario)].SetValue<int>((int)value); } }
    }
    public class MissionDisplayUpdateInfo : Object
    {
        public MissionDisplayUpdateInfo(ulong addr) : base(addr) { }
        public EMissionUpdateType UpdateType { get { return (EMissionUpdateType)this[nameof(UpdateType)].GetValue<int>(); } set { this[nameof(UpdateType)].SetValue<int>((int)value); } }
        public Object MissionName { get { return this[nameof(MissionName)]; } set { this[nameof(MissionName)] = value; } }
        public FNAFMissionInfo MissionInfo { get { return this[nameof(MissionInfo)].As<FNAFMissionInfo>(); } set { this["MissionInfo"] = value; } }
        public FNAFMissionState MissionState { get { return this[nameof(MissionState)].As<FNAFMissionState>(); } set { this["MissionState"] = value; } }
    }
    public class PowerStationSaveInfo : Object
    {
        public PowerStationSaveInfo(ulong addr) : base(addr) { }
        public int PowerStationID { get { return this[nameof(PowerStationID)].GetValue<int>(); } set { this[nameof(PowerStationID)].SetValue<int>(value); } }
        public int GameIteration { get { return this[nameof(GameIteration)].GetValue<int>(); } set { this[nameof(GameIteration)].SetValue<int>(value); } }
        public int GameHour { get { return this[nameof(GameHour)].GetValue<int>(); } set { this[nameof(GameHour)].SetValue<int>(value); } }
        public int GameMinute { get { return this[nameof(GameMinute)].GetValue<int>(); } set { this[nameof(GameMinute)].SetValue<int>(value); } }
    }
    public class RichControlButtonRow : TableRowBase
    {
        public RichControlButtonRow(ulong addr) : base(addr) { }
        public SlateBrush DefaultBrush { get { return this[nameof(DefaultBrush)].As<SlateBrush>(); } set { this["DefaultBrush"] = value; } }
        public Object PerControllerBrush { get { return this[nameof(PerControllerBrush)]; } set { this[nameof(PerControllerBrush)] = value; } }
    }
    public class RandomItemAreaInfo : Object
    {
        public RandomItemAreaInfo(ulong addr) : base(addr) { }
        public int NumLobbyKeys { get { return this[nameof(NumLobbyKeys)].GetValue<int>(); } set { this[nameof(NumLobbyKeys)].SetValue<int>(value); } }
        public int NumKeys { get { return this[nameof(NumKeys)].GetValue<int>(); } set { this[nameof(NumKeys)].SetValue<int>(value); } }
        public int NumItems { get { return this[nameof(NumItems)].GetValue<int>(); } set { this[nameof(NumItems)].SetValue<int>(value); } }
        public int NumFreddyUpgrades { get { return this[nameof(NumFreddyUpgrades)].GetValue<int>(); } set { this[nameof(NumFreddyUpgrades)].SetValue<int>(value); } }
        public int NumBotUpgrades { get { return this[nameof(NumBotUpgrades)].GetValue<int>(); } set { this[nameof(NumBotUpgrades)].SetValue<int>(value); } }
        public int NumGregoryUpgrade { get { return this[nameof(NumGregoryUpgrade)].GetValue<int>(); } set { this[nameof(NumGregoryUpgrade)].SetValue<int>(value); } }
        public int NumCollectible { get { return this[nameof(NumCollectible)].GetValue<int>(); } set { this[nameof(NumCollectible)].SetValue<int>(value); } }
        public int NumBad { get { return this[nameof(NumBad)].GetValue<int>(); } set { this[nameof(NumBad)].SetValue<int>(value); } }
        public int NumFlashlight { get { return this[nameof(NumFlashlight)].GetValue<int>(); } set { this[nameof(NumFlashlight)].SetValue<int>(value); } }
    }
}
