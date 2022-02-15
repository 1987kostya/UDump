using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.MovieSceneSDK;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.TemplateSequenceSDK
{
    public class TemplateSequence : MovieSceneSequence
    {
        public TemplateSequence(ulong addr) : base(addr) { }
        public MovieScene MovieScene { get { return this[nameof(MovieScene)].As<MovieScene>(); } set { this["MovieScene"] = value; } }
        public Object BoundActorClass { get { return this[nameof(BoundActorClass)]; } set { this[nameof(BoundActorClass)] = value; } }
        public Object BoundPreviewActor { get { return this[nameof(BoundPreviewActor)]; } set { this[nameof(BoundPreviewActor)] = value; } }
        public Object BoundActorComponents { get { return this[nameof(BoundActorComponents)]; } set { this[nameof(BoundActorComponents)] = value; } }
    }
    public class CameraAnimationSequence : TemplateSequence
    {
        public CameraAnimationSequence(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceActor : Actor
    {
        public TemplateSequenceActor(ulong addr) : base(addr) { }
        public MovieSceneSequencePlaybackSettings PlaybackSettings { get { return this[nameof(PlaybackSettings)].As<MovieSceneSequencePlaybackSettings>(); } set { this["PlaybackSettings"] = value; } }
        public TemplateSequencePlayer SequencePlayer { get { return this[nameof(SequencePlayer)].As<TemplateSequencePlayer>(); } set { this["SequencePlayer"] = value; } }
        public SoftObjectPath TemplateSequence { get { return this[nameof(TemplateSequence)].As<SoftObjectPath>(); } set { this["TemplateSequence"] = value; } }
        public TemplateSequenceBindingOverrideData BindingOverride { get { return this[nameof(BindingOverride)].As<TemplateSequenceBindingOverrideData>(); } set { this["BindingOverride"] = value; } }
        public void SetSequence(TemplateSequence InSequence) { Invoke(nameof(SetSequence), InSequence); }
        public void SetBinding(Actor Actor) { Invoke(nameof(SetBinding), Actor); }
        public TemplateSequence LoadSequence() { return Invoke<TemplateSequence>(nameof(LoadSequence)); }
        public TemplateSequencePlayer GetSequencePlayer() { return Invoke<TemplateSequencePlayer>(nameof(GetSequencePlayer)); }
        public TemplateSequence GetSequence() { return Invoke<TemplateSequence>(nameof(GetSequence)); }
    }
    public class TemplateSequencePlayer : MovieSceneSequencePlayer
    {
        public TemplateSequencePlayer(ulong addr) : base(addr) { }
        public TemplateSequencePlayer CreateTemplateSequencePlayer(Object WorldContextObject, TemplateSequence TemplateSequence, MovieSceneSequencePlaybackSettings Settings, TemplateSequenceActor OutActor) { return Invoke<TemplateSequencePlayer>(nameof(CreateTemplateSequencePlayer), WorldContextObject, TemplateSequence, Settings, OutActor); }
    }
    public class TemplateSequenceSection : MovieSceneSubSection
    {
        public TemplateSequenceSection(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceTrack : MovieSceneSubTrack
    {
        public TemplateSequenceTrack(ulong addr) : base(addr) { }
    }
    public class TemplateSequenceBindingOverrideData : Object
    {
        public TemplateSequenceBindingOverrideData(ulong addr) : base(addr) { }
        public Object Object { get { return this[nameof(Object)]; } set { this[nameof(Object)] = value; } }
        public bool bOverridesDefault { get { return this[nameof(bOverridesDefault)].Flag; } set { this[nameof(bOverridesDefault)].Flag = value; } }
    }
    public class TemplateSequenceInstanceData : MovieSceneSequenceInstanceData
    {
        public TemplateSequenceInstanceData(ulong addr) : base(addr) { }
        public MovieSceneEvaluationOperand Operand { get { return this[nameof(Operand)].As<MovieSceneEvaluationOperand>(); } set { this["Operand"] = value; } }
    }
    public class TemplateSequenceSectionTemplate : MovieSceneEvalTemplate
    {
        public TemplateSequenceSectionTemplate(ulong addr) : base(addr) { }
        public FrameNumber SectionStartTime { get { return this[nameof(SectionStartTime)].As<FrameNumber>(); } set { this["SectionStartTime"] = value; } }
        public Guid OuterBindingId { get { return this[nameof(OuterBindingId)].As<Guid>(); } set { this["OuterBindingId"] = value; } }
        public MovieSceneEvaluationOperand InnerOperand { get { return this[nameof(InnerOperand)].As<MovieSceneEvaluationOperand>(); } set { this["InnerOperand"] = value; } }
    }
}
