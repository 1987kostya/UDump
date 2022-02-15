using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.RandomItemSystemSDK
{
    public class ItemRandomizer : Actor
    {
        public ItemRandomizer(ulong addr) : base(addr) { }
        public void SetupItem(RandomItemGroup ItemGroup, RandomStream RandomStream) { Invoke(nameof(SetupItem), ItemGroup, RandomStream); }
        public void Randomize(Object RandomItemCls, RandomStream RandomStream) { Invoke(nameof(Randomize), RandomItemCls, RandomStream); }
        public void PickRandomLocationFromGroup(RandomItemGroup Group, RandomStream RandomStream, Vector OutLocation) { Invoke(nameof(PickRandomLocationFromGroup), Group, RandomStream, OutLocation); }
    }
    public class RandomItemGroup : Actor
    {
        public RandomItemGroup(ulong addr) : base(addr) { }
        public Array<Vector> PossibleLocations { get { return new Array<Vector>(this[nameof(PossibleLocations)].Address); } }
        public Object GetItemDisplayInformation() { return Invoke<Object>(nameof(GetItemDisplayInformation)); }
    }
}
