using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.LuminRuntimeSettingsSDK
{
    public class LuminRuntimeSettings : Object
    {
        public LuminRuntimeSettings(ulong addr) : base(addr) { }
        public Object PackageName { get { return this[nameof(PackageName)]; } set { this[nameof(PackageName)] = value; } }
        public Object ApplicationDisplayName { get { return this[nameof(ApplicationDisplayName)]; } set { this[nameof(ApplicationDisplayName)] = value; } }
        public ELuminFrameTimingHint FrameTimingHint { get { return (ELuminFrameTimingHint)this[nameof(FrameTimingHint)].GetValue<int>(); } set { this[nameof(FrameTimingHint)].SetValue<int>((int)value); } }
        public bool bProtectedContent { get { return this[nameof(bProtectedContent)].Flag; } set { this[nameof(bProtectedContent)].Flag = value; } }
        public bool bManualCallToAppReady { get { return this[nameof(bManualCallToAppReady)].Flag; } set { this[nameof(bManualCallToAppReady)].Flag = value; } }
        public bool bUseMobileRendering { get { return this[nameof(bUseMobileRendering)].Flag; } set { this[nameof(bUseMobileRendering)].Flag = value; } }
        public bool bUseVulkan { get { return this[nameof(bUseVulkan)].Flag; } set { this[nameof(bUseVulkan)].Flag = value; } }
        public FilePath Certificate { get { return this[nameof(Certificate)].As<FilePath>(); } set { this["Certificate"] = value; } }
        public DirectoryPath IconModelPath { get { return this[nameof(IconModelPath)].As<DirectoryPath>(); } set { this["IconModelPath"] = value; } }
        public DirectoryPath IconPortalPath { get { return this[nameof(IconPortalPath)].As<DirectoryPath>(); } set { this["IconPortalPath"] = value; } }
        public LocalizedIconInfos LocalizedIconInfos { get { return this[nameof(LocalizedIconInfos)].As<LocalizedIconInfos>(); } set { this["LocalizedIconInfos"] = value; } }
        public int VersionCode { get { return this[nameof(VersionCode)].GetValue<int>(); } set { this[nameof(VersionCode)].SetValue<int>(value); } }
        public int MinimumAPILevel { get { return this[nameof(MinimumAPILevel)].GetValue<int>(); } set { this[nameof(MinimumAPILevel)].SetValue<int>(value); } }
        public Array<ELuminPrivilege> AppPrivileges { get { return new Array<ELuminPrivilege>(this[nameof(AppPrivileges)].Address); } }
        public Array<LuminComponentSubElement> ExtraComponentSubElements { get { return new Array<LuminComponentSubElement>(this[nameof(ExtraComponentSubElements)].Address); } }
        public Array<LuminComponentElement> ExtraComponentElements { get { return new Array<LuminComponentElement>(this[nameof(ExtraComponentElements)].Address); } }
        public Object SpatializationPlugin { get { return this[nameof(SpatializationPlugin)]; } set { this[nameof(SpatializationPlugin)] = value; } }
        public Object ReverbPlugin { get { return this[nameof(ReverbPlugin)]; } set { this[nameof(ReverbPlugin)] = value; } }
        public Object OcclusionPlugin { get { return this[nameof(OcclusionPlugin)]; } set { this[nameof(OcclusionPlugin)] = value; } }
        public int SoundCueCookQualityIndex { get { return this[nameof(SoundCueCookQualityIndex)].GetValue<int>(); } set { this[nameof(SoundCueCookQualityIndex)].SetValue<int>(value); } }
        public bool bRemoveDebugInfo { get { return this[nameof(bRemoveDebugInfo)].Flag; } set { this[nameof(bRemoveDebugInfo)].Flag = value; } }
        public DirectoryPath VulkanValidationLayerLibs { get { return this[nameof(VulkanValidationLayerLibs)].As<DirectoryPath>(); } set { this["VulkanValidationLayerLibs"] = value; } }
        public bool bFrameVignette { get { return this[nameof(bFrameVignette)].Flag; } set { this[nameof(bFrameVignette)].Flag = value; } }
        public Array<LocalizedAppName> LocalizedAppNames { get { return new Array<LocalizedAppName>(this[nameof(LocalizedAppNames)].Address); } }
    }
    public enum ELuminPrivilege : int
    {
        Invalid = 0,
        BatteryInfo = 1,
        CameraCapture = 2,
        ComputerVision = 3,
        WorldReconstruction = 4,
        InAppPurchase = 5,
        AudioCaptureMic = 6,
        DrmCertificates = 7,
        Occlusion = 8,
        LowLatencyLightwear = 9,
        Internet = 10,
        IdentityRead = 11,
        BackgroundDownload = 12,
        BackgroundUpload = 13,
        MediaDrm = 14,
        Media = 15,
        MediaMetadata = 16,
        PowerInfo = 17,
        LocalAreaNetwork = 18,
        VoiceInput = 19,
        Documents = 20,
        ConnectBackgroundMusicService = 21,
        RegisterBackgroundMusicService = 22,
        PcfRead = 23,
        PwFoundObjRead = 23,
        NormalNotificationsUsage = 24,
        MusicService = 25,
        ControllerPose = 26,
        GesturesSubscribe = 27,
        GesturesConfig = 28,
        AddressBookRead = 29,
        AddressBookWrite = 30,
        AddressBookBasicAccess = 31,
        CoarseLocation = 32,
        FineLocation = 33,
        HandMesh = 34,
        WifiStatusRead = 35,
        SocialConnectionsInvitesAccess = 36,
        ELuminPrivilege_MAX = 37,
    }
    public enum ELuminFrameTimingHint : int
    {
        Unspecified = 0,
        Maximum = 1,
        FPS_61 = 2,
        FPS_121 = 3,
        ELuminFrameTimingHint_MAX = 4,
    }
    public enum ELuminComponentType : int
    {
        Universe = 0,
        Fullscreen = 1,
        SearchProvider = 2,
        MusicService = 3,
        Screens = 4,
        ScreensImmersive = 5,
        Console = 6,
        SystemUI = 7,
        ELuminComponentType_MAX = 8,
    }
    public enum ELuminComponentSubElementType : int
    {
        FileExtension = 0,
        MimeType = 1,
        Mode = 2,
        MusicAttribute = 3,
        Schema = 4,
        ELuminComponentSubElementType_MAX = 5,
    }
    public class LocalizedIconInfos : Object
    {
        public LocalizedIconInfos(ulong addr) : base(addr) { }
        public Array<LocalizedIconInfo> IconData { get { return new Array<LocalizedIconInfo>(this[nameof(IconData)].Address); } }
    }
    public class LocalizedIconInfo : Object
    {
        public LocalizedIconInfo(ulong addr) : base(addr) { }
        public Object LanguageCode { get { return this[nameof(LanguageCode)]; } set { this[nameof(LanguageCode)] = value; } }
        public DirectoryPath IconModelPath { get { return this[nameof(IconModelPath)].As<DirectoryPath>(); } set { this["IconModelPath"] = value; } }
        public DirectoryPath IconPortalPath { get { return this[nameof(IconPortalPath)].As<DirectoryPath>(); } set { this["IconPortalPath"] = value; } }
    }
    public class LocalizedAppName : Object
    {
        public LocalizedAppName(ulong addr) : base(addr) { }
        public Object LanguageCode { get { return this[nameof(LanguageCode)]; } set { this[nameof(LanguageCode)] = value; } }
        public Object AppName { get { return this[nameof(AppName)]; } set { this[nameof(AppName)] = value; } }
    }
    public class LuminComponentElement : Object
    {
        public LuminComponentElement(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object VisibleName { get { return this[nameof(VisibleName)]; } set { this[nameof(VisibleName)] = value; } }
        public Object ExecutableName { get { return this[nameof(ExecutableName)]; } set { this[nameof(ExecutableName)] = value; } }
        public ELuminComponentType ComponentType { get { return (ELuminComponentType)this[nameof(ComponentType)].GetValue<int>(); } set { this[nameof(ComponentType)].SetValue<int>((int)value); } }
        public Array<LuminComponentSubElement> ExtraComponentSubElements { get { return new Array<LuminComponentSubElement>(this[nameof(ExtraComponentSubElements)].Address); } }
    }
    public class LuminComponentSubElement : Object
    {
        public LuminComponentSubElement(ulong addr) : base(addr) { }
        public ELuminComponentSubElementType ElementType { get { return (ELuminComponentSubElementType)this[nameof(ElementType)].GetValue<int>(); } set { this[nameof(ElementType)].SetValue<int>((int)value); } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
}
