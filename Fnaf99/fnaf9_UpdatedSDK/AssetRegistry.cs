using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.AssetRegistrySDK
{
    public class AssetRegistryImpl : Object
    {
        public AssetRegistryImpl(ulong addr) : base(addr) { }
    }
    public class AssetRegistryHelpers : Object
    {
        public AssetRegistryHelpers(ulong addr) : base(addr) { }
        public SoftObjectPath ToSoftObjectPath(AssetData InAssetData) { return Invoke<SoftObjectPath>(nameof(ToSoftObjectPath), InAssetData); }
        public ARFilter SetFilterTagsAndValues(ARFilter InFilter, Array<TagAndValue> InTagsAndValues) { return Invoke<ARFilter>(nameof(SetFilterTagsAndValues), InFilter, InTagsAndValues); }
        public bool IsValid(AssetData InAssetData) { return Invoke<bool>(nameof(IsValid), InAssetData); }
        public bool IsUAsset(AssetData InAssetData) { return Invoke<bool>(nameof(IsUAsset), InAssetData); }
        public bool IsRedirector(AssetData InAssetData) { return Invoke<bool>(nameof(IsRedirector), InAssetData); }
        public bool IsAssetLoaded(AssetData InAssetData) { return Invoke<bool>(nameof(IsAssetLoaded), InAssetData); }
        public bool GetTagValue(AssetData InAssetData, Object InTagName, Object OutTagValue) { return Invoke<bool>(nameof(GetTagValue), InAssetData, InTagName, OutTagValue); }
        public Object GetFullName(AssetData InAssetData) { return Invoke<Object>(nameof(GetFullName), InAssetData); }
        public Object GetExportTextName(AssetData InAssetData) { return Invoke<Object>(nameof(GetExportTextName), InAssetData); }
        public Object GetClass(AssetData InAssetData) { return Invoke<Object>(nameof(GetClass), InAssetData); }
        public Object GetAssetRegistry() { return Invoke<Object>(nameof(GetAssetRegistry)); }
        public Object GetAsset(AssetData InAssetData) { return Invoke<Object>(nameof(GetAsset), InAssetData); }
        public AssetData CreateAssetData(Object InAsset, bool bAllowBlueprintClass) { return Invoke<AssetData>(nameof(CreateAssetData), InAsset, bAllowBlueprintClass); }
    }
    public class AssetRegistry : Interface
    {
        public AssetRegistry(ulong addr) : base(addr) { }
        public void UseFilterToExcludeAssets(Array<AssetData> AssetDataList, ARFilter Filter) { Invoke(nameof(UseFilterToExcludeAssets), AssetDataList, Filter); }
        public void SearchAllAssets(bool bSynchronousSearch) { Invoke(nameof(SearchAllAssets), bSynchronousSearch); }
        public void ScanPathsSynchronous(Array<Object> InPaths, bool bForceRescan) { Invoke(nameof(ScanPathsSynchronous), InPaths, bForceRescan); }
        public void ScanModifiedAssetFiles(Array<Object> InFilePaths) { Invoke(nameof(ScanModifiedAssetFiles), InFilePaths); }
        public void ScanFilesSynchronous(Array<Object> InFilePaths, bool bForceRescan) { Invoke(nameof(ScanFilesSynchronous), InFilePaths, bForceRescan); }
        public void RunAssetsThroughFilter(Array<AssetData> AssetDataList, ARFilter Filter) { Invoke(nameof(RunAssetsThroughFilter), AssetDataList, Filter); }
        public void PrioritizeSearchPath(Object PathToPrioritize) { Invoke(nameof(PrioritizeSearchPath), PathToPrioritize); }
        public bool K2_GetReferencers(Object PackageName, AssetRegistryDependencyOptions ReferenceOptions, Array<Object> OutReferencers) { return Invoke<bool>(nameof(K2_GetReferencers), PackageName, ReferenceOptions, OutReferencers); }
        public bool K2_GetDependencies(Object PackageName, AssetRegistryDependencyOptions DependencyOptions, Array<Object> OutDependencies) { return Invoke<bool>(nameof(K2_GetDependencies), PackageName, DependencyOptions, OutDependencies); }
        public bool IsLoadingAssets() { return Invoke<bool>(nameof(IsLoadingAssets)); }
        public bool HasAssets(Object PackagePath, bool bRecursive) { return Invoke<bool>(nameof(HasAssets), PackagePath, bRecursive); }
        public void GetSubPaths(Object InBasePath, Array<Object> OutPathList, bool bInRecurse) { Invoke(nameof(GetSubPaths), InBasePath, OutPathList, bInRecurse); }
        public bool GetAssetsByPath(Object PackagePath, Array<AssetData> OutAssetData, bool bRecursive, bool bIncludeOnlyOnDiskAssets) { return Invoke<bool>(nameof(GetAssetsByPath), PackagePath, OutAssetData, bRecursive, bIncludeOnlyOnDiskAssets); }
        public bool GetAssetsByPackageName(Object PackageName, Array<AssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets) { return Invoke<bool>(nameof(GetAssetsByPackageName), PackageName, OutAssetData, bIncludeOnlyOnDiskAssets); }
        public bool GetAssetsByClass(Object ClassName, Array<AssetData> OutAssetData, bool bSearchSubClasses) { return Invoke<bool>(nameof(GetAssetsByClass), ClassName, OutAssetData, bSearchSubClasses); }
        public bool GetAssets(ARFilter Filter, Array<AssetData> OutAssetData) { return Invoke<bool>(nameof(GetAssets), Filter, OutAssetData); }
        public AssetData GetAssetByObjectPath(Object ObjectPath, bool bIncludeOnlyOnDiskAssets) { return Invoke<AssetData>(nameof(GetAssetByObjectPath), ObjectPath, bIncludeOnlyOnDiskAssets); }
        public void GetAllCachedPaths(Array<Object> OutPathList) { Invoke(nameof(GetAllCachedPaths), OutPathList); }
        public bool GetAllAssets(Array<AssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets) { return Invoke<bool>(nameof(GetAllAssets), OutAssetData, bIncludeOnlyOnDiskAssets); }
    }
    public class ARFilter : Object
    {
        public ARFilter(ulong addr) : base(addr) { }
        public Array<Object> PackageNames { get { return new Array<Object>(this[nameof(PackageNames)].Address); } }
        public Array<Object> PackagePaths { get { return new Array<Object>(this[nameof(PackagePaths)].Address); } }
        public Array<Object> ObjectPaths { get { return new Array<Object>(this[nameof(ObjectPaths)].Address); } }
        public Array<Object> ClassNames { get { return new Array<Object>(this[nameof(ClassNames)].Address); } }
        public Object RecursiveClassesExclusionSet { get { return this[nameof(RecursiveClassesExclusionSet)]; } set { this[nameof(RecursiveClassesExclusionSet)] = value; } }
        public bool bRecursivePaths { get { return this[nameof(bRecursivePaths)].Flag; } set { this[nameof(bRecursivePaths)].Flag = value; } }
        public bool bRecursiveClasses { get { return this[nameof(bRecursiveClasses)].Flag; } set { this[nameof(bRecursiveClasses)].Flag = value; } }
        public bool bIncludeOnlyOnDiskAssets { get { return this[nameof(bIncludeOnlyOnDiskAssets)].Flag; } set { this[nameof(bIncludeOnlyOnDiskAssets)].Flag = value; } }
    }
    public class AssetBundleData : Object
    {
        public AssetBundleData(ulong addr) : base(addr) { }
        public Array<AssetBundleEntry> Bundles { get { return new Array<AssetBundleEntry>(this[nameof(Bundles)].Address); } }
    }
    public class AssetBundleEntry : Object
    {
        public AssetBundleEntry(ulong addr) : base(addr) { }
        public PrimaryAssetId BundleScope { get { return this[nameof(BundleScope)].As<PrimaryAssetId>(); } set { this["BundleScope"] = value; } }
        public Object BundleName { get { return this[nameof(BundleName)]; } set { this[nameof(BundleName)] = value; } }
        public Array<SoftObjectPath> BundleAssets { get { return new Array<SoftObjectPath>(this[nameof(BundleAssets)].Address); } }
    }
    public class AssetData : Object
    {
        public AssetData(ulong addr) : base(addr) { }
        public Object ObjectPath { get { return this[nameof(ObjectPath)]; } set { this[nameof(ObjectPath)] = value; } }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public Object PackagePath { get { return this[nameof(PackagePath)]; } set { this[nameof(PackagePath)] = value; } }
        public Object AssetName { get { return this[nameof(AssetName)]; } set { this[nameof(AssetName)] = value; } }
        public Object AssetClass { get { return this[nameof(AssetClass)]; } set { this[nameof(AssetClass)] = value; } }
    }
    public class TagAndValue : Object
    {
        public TagAndValue(ulong addr) : base(addr) { }
        public Object Tag { get { return this[nameof(Tag)]; } set { this[nameof(Tag)] = value; } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
    public class AssetRegistryDependencyOptions : Object
    {
        public AssetRegistryDependencyOptions(ulong addr) : base(addr) { }
        public bool bIncludeSoftPackageReferences { get { return this[nameof(bIncludeSoftPackageReferences)].Flag; } set { this[nameof(bIncludeSoftPackageReferences)].Flag = value; } }
        public bool bIncludeHardPackageReferences { get { return this[nameof(bIncludeHardPackageReferences)].Flag; } set { this[nameof(bIncludeHardPackageReferences)].Flag = value; } }
        public bool bIncludeSearchableNames { get { return this[nameof(bIncludeSearchableNames)].Flag; } set { this[nameof(bIncludeSearchableNames)].Flag = value; } }
        public bool bIncludeSoftManagementReferences { get { return this[nameof(bIncludeSoftManagementReferences)].Flag; } set { this[nameof(bIncludeSoftManagementReferences)].Flag = value; } }
        public bool bIncludeHardManagementReferences { get { return this[nameof(bIncludeHardManagementReferences)].Flag; } set { this[nameof(bIncludeHardManagementReferences)].Flag = value; } }
    }
}
