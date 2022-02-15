using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.MagicLeapIdentitySDK
{
    public class MagicLeapIdentity : Object
    {
        public MagicLeapIdentity(ulong addr) : base(addr) { }
        public void RequestIdentityAttributeValueDelegate__DelegateSignature(EMagicLeapIdentityError ResultCode, Array<MagicLeapIdentityAttribute> AttributeValue) { Invoke(nameof(RequestIdentityAttributeValueDelegate__DelegateSignature), ResultCode, AttributeValue); }
        public EMagicLeapIdentityError RequestAttributeValueAsync(Array<EMagicLeapIdentityKey> RequestedAttributeList, Object ResultDelegate) { return Invoke<EMagicLeapIdentityError>(nameof(RequestAttributeValueAsync), RequestedAttributeList, ResultDelegate); }
        public EMagicLeapIdentityError RequestAttributeValue(Array<EMagicLeapIdentityKey> RequestedAttributeList, Array<MagicLeapIdentityAttribute> RequestedAttributeValues) { return Invoke<EMagicLeapIdentityError>(nameof(RequestAttributeValue), RequestedAttributeList, RequestedAttributeValues); }
        public void ModifyIdentityAttributeValueDelegate__DelegateSignature(EMagicLeapIdentityError ResultCode, Array<EMagicLeapIdentityKey> AttributesUpdatedSuccessfully) { Invoke(nameof(ModifyIdentityAttributeValueDelegate__DelegateSignature), ResultCode, AttributesUpdatedSuccessfully); }
        public void GetAllAvailableAttributesAsync(Object ResultDelegate) { Invoke(nameof(GetAllAvailableAttributesAsync), ResultDelegate); }
        public EMagicLeapIdentityError GetAllAvailableAttributes(Array<EMagicLeapIdentityKey> AvailableAttributes) { return Invoke<EMagicLeapIdentityError>(nameof(GetAllAvailableAttributes), AvailableAttributes); }
        public void AvailableIdentityAttributesDelegate__DelegateSignature(EMagicLeapIdentityError ResultCode, Array<EMagicLeapIdentityKey> AvailableAttributes) { Invoke(nameof(AvailableIdentityAttributesDelegate__DelegateSignature), ResultCode, AvailableAttributes); }
    }
    public enum EMagicLeapIdentityKey : int
    {
        GivenName = 0,
        FamilyName = 1,
        Email = 2,
        Bio = 3,
        PhoneNumber = 4,
        Avatar2D = 5,
        Avatar3D = 6,
        Unknown = 7,
        EMagicLeapIdentityKey_MAX = 8,
    }
    public enum EMagicLeapIdentityError : int
    {
        Ok = 0,
        InvalidParam = 1,
        AllocFailed = 2,
        PrivilegeDenied = 3,
        FailedToConnectToLocalService = 4,
        FailedToConnectToCloudService = 5,
        CloudAuthentication = 6,
        InvalidInformationFromCloud = 7,
        NotLoggedIn = 8,
        ExpiredCredentials = 9,
        FailedToGetUserProfile = 10,
        Unauthorized = 11,
        CertificateError = 12,
        RejectedByCloud = 13,
        AlreadyLoggedIn = 14,
        ModifyIsNotSupported = 15,
        NetworkError = 16,
        UnspecifiedFailure = 17,
        EMagicLeapIdentityError_MAX = 18,
    }
    public class MagicLeapIdentityAttribute : Object
    {
        public MagicLeapIdentityAttribute(ulong addr) : base(addr) { }
        public EMagicLeapIdentityKey Attribute { get { return (EMagicLeapIdentityKey)this[nameof(Attribute)].GetValue<int>(); } set { this[nameof(Attribute)].SetValue<int>((int)value); } }
        public Object Value { get { return this[nameof(Value)]; } set { this[nameof(Value)] = value; } }
    }
}
