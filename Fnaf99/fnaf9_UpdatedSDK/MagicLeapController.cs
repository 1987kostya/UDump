using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.MagicLeapControllerSDK
{
    public class MagicLeapControllerFunctionLibrary : BlueprintFunctionLibrary
    {
        public MagicLeapControllerFunctionLibrary(ulong addr) : base(addr) { }
        public bool SetMotionSourceForHand(EControllerHand Hand, Object MotionSource) { return Invoke<bool>(nameof(SetMotionSourceForHand), Hand, MotionSource); }
        public bool SetControllerTrackingMode(EMagicLeapControllerTrackingMode TrackingMode) { return Invoke<bool>(nameof(SetControllerTrackingMode), TrackingMode); }
        public bool PlayLEDPattern(Object MotionSource, EMagicLeapControllerLEDPattern LEDPattern, EMagicLeapControllerLEDColor LEDColor, float DurationInSec) { return Invoke<bool>(nameof(PlayLEDPattern), MotionSource, LEDPattern, LEDColor, DurationInSec); }
        public bool PlayLEDEffect(Object MotionSource, EMagicLeapControllerLEDEffect LEDEffect, EMagicLeapControllerLEDSpeed LEDSpeed, EMagicLeapControllerLEDPattern LEDPattern, EMagicLeapControllerLEDColor LEDColor, float DurationInSec) { return Invoke<bool>(nameof(PlayLEDEffect), MotionSource, LEDEffect, LEDSpeed, LEDPattern, LEDColor, DurationInSec); }
        public bool PlayHapticPattern(Object MotionSource, EMagicLeapControllerHapticPattern HapticPattern, EMagicLeapControllerHapticIntensity Intensity) { return Invoke<bool>(nameof(PlayHapticPattern), MotionSource, HapticPattern, Intensity); }
        public bool PlayControllerLEDEffect(EControllerHand Hand, EMagicLeapControllerLEDEffect LEDEffect, EMagicLeapControllerLEDSpeed LEDSpeed, EMagicLeapControllerLEDPattern LEDPattern, EMagicLeapControllerLEDColor LEDColor, float DurationInSec) { return Invoke<bool>(nameof(PlayControllerLEDEffect), Hand, LEDEffect, LEDSpeed, LEDPattern, LEDColor, DurationInSec); }
        public bool PlayControllerLED(EControllerHand Hand, EMagicLeapControllerLEDPattern LEDPattern, EMagicLeapControllerLEDColor LEDColor, float DurationInSec) { return Invoke<bool>(nameof(PlayControllerLED), Hand, LEDPattern, LEDColor, DurationInSec); }
        public bool PlayControllerHapticFeedback(EControllerHand Hand, EMagicLeapControllerHapticPattern HapticPattern, EMagicLeapControllerHapticIntensity Intensity) { return Invoke<bool>(nameof(PlayControllerHapticFeedback), Hand, HapticPattern, Intensity); }
        public int MaxSupportedMagicLeapControllers() { return Invoke<int>(nameof(MaxSupportedMagicLeapControllers)); }
        public bool IsMLControllerConnected(Object MotionSource) { return Invoke<bool>(nameof(IsMLControllerConnected), MotionSource); }
        public void InvertControllerMapping() { Invoke(nameof(InvertControllerMapping)); }
        public Object GetMotionSourceForHand(EControllerHand Hand) { return Invoke<Object>(nameof(GetMotionSourceForHand), Hand); }
        public EMagicLeapControllerType GetMLControllerType(EControllerHand Hand) { return Invoke<EMagicLeapControllerType>(nameof(GetMLControllerType), Hand); }
        public EControllerHand GetHandForMotionSource(Object MotionSource) { return Invoke<EControllerHand>(nameof(GetHandForMotionSource), MotionSource); }
        public EMagicLeapControllerType GetControllerType(Object MotionSource) { return Invoke<EMagicLeapControllerType>(nameof(GetControllerType), MotionSource); }
        public EMagicLeapControllerTrackingMode GetControllerTrackingMode() { return Invoke<EMagicLeapControllerTrackingMode>(nameof(GetControllerTrackingMode)); }
        public bool GetControllerMapping(int ControllerIndex, EControllerHand Hand) { return Invoke<bool>(nameof(GetControllerMapping), ControllerIndex, Hand); }
    }
    public class MagicLeapTouchpadGesturesComponent : ActorComponent
    {
        public MagicLeapTouchpadGesturesComponent(ulong addr) : base(addr) { }
        public Object OnTouchpadGestureStart { get { return this[nameof(OnTouchpadGestureStart)]; } set { this[nameof(OnTouchpadGestureStart)] = value; } }
        public Object OnTouchpadGestureContinue { get { return this[nameof(OnTouchpadGestureContinue)]; } set { this[nameof(OnTouchpadGestureContinue)] = value; } }
        public Object OnTouchpadGestureEnd { get { return this[nameof(OnTouchpadGestureEnd)]; } set { this[nameof(OnTouchpadGestureEnd)] = value; } }
    }
    public class MagicLeapTouchpadGesture : Object
    {
        public MagicLeapTouchpadGesture(ulong addr) : base(addr) { }
        public EControllerHand Hand { get { return (EControllerHand)this[nameof(Hand)].GetValue<int>(); } set { this[nameof(Hand)].SetValue<int>((int)value); } }
        public Object MotionSource { get { return this[nameof(MotionSource)]; } set { this[nameof(MotionSource)] = value; } }
        public EMagicLeapTouchpadGestureType Type { get { return (EMagicLeapTouchpadGestureType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public EMagicLeapTouchpadGestureDirection Direction { get { return (EMagicLeapTouchpadGestureDirection)this[nameof(Direction)].GetValue<int>(); } set { this[nameof(Direction)].SetValue<int>((int)value); } }
        public Vector PositionAndForce { get { return this[nameof(PositionAndForce)].As<Vector>(); } set { this["PositionAndForce"] = value; } }
        public float Speed { get { return this[nameof(Speed)].GetValue<float>(); } set { this[nameof(Speed)].SetValue<float>(value); } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public float FingerGap { get { return this[nameof(FingerGap)].GetValue<float>(); } set { this[nameof(FingerGap)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Angle { get { return this[nameof(Angle)].GetValue<float>(); } set { this[nameof(Angle)].SetValue<float>(value); } }
    }
    public enum EMagicLeapTouchpadGestureDirection : int
    {
        None = 0,
        Up = 1,
        Down = 2,
        Left = 3,
        Right = 4,
        In = 5,
        Out = 6,
        Clockwise = 7,
        CounterClockwise = 8,
        EMagicLeapTouchpadGestureDirection_MAX = 9,
    }
    public enum EMagicLeapTouchpadGestureType : int
    {
        None = 0,
        Tap = 1,
        ForceTapDown = 2,
        ForceTapUp = 3,
        ForceDwell = 4,
        SecondForceDown = 5,
        LongHold = 6,
        RadialScroll = 7,
        Swipe = 8,
        Scroll = 9,
        Pinch = 10,
        EMagicLeapTouchpadGestureType_MAX = 11,
    }
    public enum EMagicLeapControllerTrackingMode : int
    {
        InputService = 0,
        CoordinateFrameUID = 1,
        EMagicLeapControllerTrackingMode_MAX = 2,
    }
    public enum EMagicLeapControllerHapticIntensity : int
    {
        Low = 0,
        Medium = 1,
        High = 2,
        EMagicLeapControllerHapticIntensity_MAX = 3,
    }
    public enum EMagicLeapControllerHapticPattern : int
    {
        None = 0,
        Click = 1,
        Bump = 2,
        DoubleClick = 3,
        Buzz = 4,
        Tick = 5,
        ForceDown = 6,
        ForceUp = 7,
        ForceDwell = 8,
        SecondForceDown = 9,
        EMagicLeapControllerHapticPattern_MAX = 10,
    }
    public enum EMagicLeapControllerLEDSpeed : int
    {
        Slow = 0,
        Medium = 1,
        Fast = 2,
        EMagicLeapControllerLEDSpeed_MAX = 3,
    }
    public enum EMagicLeapControllerLEDColor : int
    {
        BrightMissionRed = 0,
        PastelMissionRed = 1,
        BrightFloridaOrange = 2,
        PastelFloridaOrange = 3,
        BrightLunaYellow = 4,
        PastelLunaYellow = 5,
        BrightNebulaPink = 6,
        PastelNebulaPink = 7,
        BrightCosmicPurple = 8,
        PastelCosmicPurple = 9,
        BrightMysticBlue = 10,
        PastelMysticBlue = 11,
        BrightCelestialBlue = 12,
        PastelCelestialBlue = 13,
        BrightShaggleGreen = 14,
        PastelShaggleGreen = 15,
        EMagicLeapControllerLEDColor_MAX = 16,
    }
    public enum EMagicLeapControllerLEDEffect : int
    {
        RotateCW = 0,
        RotateCCW = 1,
        Pulse = 2,
        PaintCW = 3,
        PaintCCW = 4,
        Blink = 5,
        EMagicLeapControllerLEDEffect_MAX = 6,
    }
    public enum EMagicLeapControllerLEDPattern : int
    {
        None = 0,
        Clock01 = 1,
        Clock02 = 2,
        Clock03 = 3,
        Clock04 = 4,
        Clock05 = 5,
        Clock06 = 6,
        Clock07 = 7,
        Clock08 = 8,
        Clock09 = 9,
        Clock10 = 10,
        Clock11 = 11,
        Clock12 = 12,
        Clock01_07 = 13,
        Clock02_08 = 14,
        Clock03_09 = 15,
        Clock04_11 = 16,
        Clock05_12 = 17,
        Clock06_13 = 18,
        EMagicLeapControllerLEDPattern_MAX = 19,
    }
    public enum EMagicLeapControllerType : int
    {
        None = 0,
        Device = 1,
        MobileApp = 2,
        EMagicLeapControllerType_MAX = 3,
    }
}
