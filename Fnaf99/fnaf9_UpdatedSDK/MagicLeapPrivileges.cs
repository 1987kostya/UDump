using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.MagicLeapPrivilegesSDK
{
    public class MagicLeapPrivilegesFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapPrivilegesFunctionLibrary(ulong addr) : base(addr) { }
        public bool RequestPrivilegeAsync(EMagicLeapPrivilege Privilege, Object ResultDelegate) { return Invoke<bool>(nameof(RequestPrivilegeAsync), Privilege, ResultDelegate); }
        public bool RequestPrivilege(EMagicLeapPrivilege Privilege) { return Invoke<bool>(nameof(RequestPrivilege), Privilege); }
        public bool CheckPrivilege(EMagicLeapPrivilege Privilege) { return Invoke<bool>(nameof(CheckPrivilege), Privilege); }
    }
    public enum EMagicLeapPrivilege : int
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
        EMagicLeapPrivilege_MAX = 37,
    }
}
