using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.LiveLinkInterfaceSDK;
using SDK.Script.EngineSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapHandTrackingSDK
{
    public class LiveLinkMagicLeapHandTrackingSourceFactory : LiveLinkSourceFactory
    {
        public LiveLinkMagicLeapHandTrackingSourceFactory(ulong addr) : base(addr) { }
    }
    public class MagicLeapHandTrackingFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapHandTrackingFunctionLibrary(ulong addr) : base(addr) { }
        public void SetStaticGestureConfidenceThreshold(EMagicLeapHandTrackingGesture Gesture, float Confidence) { Invoke(nameof(SetStaticGestureConfidenceThreshold), Gesture, Confidence); }
        public bool SetConfiguration(Array<EMagicLeapHandTrackingGesture> StaticGesturesToActivate, EMagicLeapHandTrackingKeypointFilterLevel KeypointsFilterLevel, EMagicLeapHandTrackingGestureFilterLevel GestureFilterLevel, bool bTrackingEnabled) { return Invoke<bool>(nameof(SetConfiguration), StaticGesturesToActivate, KeypointsFilterLevel, GestureFilterLevel, bTrackingEnabled); }
        public bool IsHoldingControl(EControllerHand Hand) { return Invoke<bool>(nameof(IsHoldingControl), Hand); }
        public float GetStaticGestureConfidenceThreshold(EMagicLeapHandTrackingGesture Gesture) { return Invoke<float>(nameof(GetStaticGestureConfidenceThreshold), Gesture); }
        public bool GetMotionSourceForHandKeypoint(EControllerHand Hand, EMagicLeapHandTrackingKeypoint Keypoint, Object OutMotionSource) { return Invoke<bool>(nameof(GetMotionSourceForHandKeypoint), Hand, Keypoint, OutMotionSource); }
        public bool GetMagicLeapHandTrackingLiveLinkSource(LiveLinkSourceHandle SourceHandle) { return Invoke<bool>(nameof(GetMagicLeapHandTrackingLiveLinkSource), SourceHandle); }
        public bool GetHandThumbTip(EControllerHand Hand, EMagicLeapGestureTransformSpace TransformSpace, Transform Secondary) { return Invoke<bool>(nameof(GetHandThumbTip), Hand, TransformSpace, Secondary); }
        public bool GetHandKeypointForMotionSource(Object MotionSource, EMagicLeapHandTrackingKeypoint OutKeyPoint) { return Invoke<bool>(nameof(GetHandKeypointForMotionSource), MotionSource, OutKeyPoint); }
        public bool GetHandIndexFingerTip(EControllerHand Hand, EMagicLeapGestureTransformSpace TransformSpace, Transform Pointer) { return Invoke<bool>(nameof(GetHandIndexFingerTip), Hand, TransformSpace, Pointer); }
        public bool GetHandCenterNormalized(EControllerHand Hand, Vector HandCenterNormalized) { return Invoke<bool>(nameof(GetHandCenterNormalized), Hand, HandCenterNormalized); }
        public bool GetHandCenter(EControllerHand Hand, Transform HandCenter) { return Invoke<bool>(nameof(GetHandCenter), Hand, HandCenter); }
        public bool GetGestureKeypointTransform(EControllerHand Hand, EMagicLeapHandTrackingKeypoint Keypoint, EMagicLeapGestureTransformSpace TransformSpace, Transform Transform) { return Invoke<bool>(nameof(GetGestureKeypointTransform), Hand, Keypoint, TransformSpace, Transform); }
        public bool GetGestureKeypoints(EControllerHand Hand, Array<Transform> Keypoints) { return Invoke<bool>(nameof(GetGestureKeypoints), Hand, Keypoints); }
        public bool GetCurrentGestureConfidence(EControllerHand Hand, float Confidence) { return Invoke<bool>(nameof(GetCurrentGestureConfidence), Hand, Confidence); }
        public bool GetCurrentGesture(EControllerHand Hand, EMagicLeapHandTrackingGesture Gesture) { return Invoke<bool>(nameof(GetCurrentGesture), Hand, Gesture); }
        public bool GetConfiguration(Array<EMagicLeapHandTrackingGesture> ActiveStaticGestures, EMagicLeapHandTrackingKeypointFilterLevel KeypointsFilterLevel, EMagicLeapHandTrackingGestureFilterLevel GestureFilterLevel, bool bTrackingEnabled) { return Invoke<bool>(nameof(GetConfiguration), ActiveStaticGestures, KeypointsFilterLevel, GestureFilterLevel, bTrackingEnabled); }
    }
    public enum EMagicLeapGestureTransformSpace : int
    {
        World = 0,
        Hand = 1,
        Tracking = 2,
        EMagicLeapGestureTransformSpace_MAX = 3,
    }
    public enum EMagicLeapHandTrackingGestureFilterLevel : int
    {
        NoFilter = 0,
        SlightRobustnessToFlicker = 1,
        MoreRobustnessToFlicker = 2,
        EMagicLeapHandTrackingGestureFilterLevel_MAX = 3,
    }
    public enum EMagicLeapHandTrackingKeypointFilterLevel : int
    {
        NoFilter = 0,
        SimpleSmoothing = 1,
        PredictiveSmoothing = 2,
        EMagicLeapHandTrackingKeypointFilterLevel_MAX = 3,
    }
    public enum EMagicLeapHandTrackingGesture : int
    {
        Finger = 0,
        Fist = 1,
        Pinch = 2,
        Thumb = 3,
        L = 4,
        OpenHand = 5,
        OpenHandBack = 5,
        Ok = 6,
        C = 7,
        NoPose = 8,
        NoHand = 9,
        EMagicLeapHandTrackingGesture_MAX = 10,
    }
    public enum EMagicLeapHandTrackingKeypoint : int
    {
        Thumb_Tip = 0,
        Thumb_IP = 1,
        Thumb_MCP = 2,
        Thumb_CMC = 3,
        Index_Tip = 4,
        Index_DIP = 5,
        Index_PIP = 6,
        Index_MCP = 7,
        Middle_Tip = 8,
        Middle_DIP = 9,
        Middle_PIP = 10,
        Middle_MCP = 11,
        Ring_Tip = 12,
        Ring_DIP = 13,
        Ring_PIP = 14,
        Ring_MCP = 15,
        Pinky_Tip = 16,
        Pinky_DIP = 17,
        Pinky_PIP = 18,
        Pinky_MCP = 19,
        Wrist_Center = 20,
        Wrist_Ulnar = 21,
        Wrist_Radial = 22,
        Hand_Center = 23,
        EMagicLeapHandTrackingKeypoint_MAX = 24,
    }
}
