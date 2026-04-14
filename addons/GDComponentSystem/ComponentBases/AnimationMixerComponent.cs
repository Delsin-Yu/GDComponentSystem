#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimationMixer" />
[Tool, GlobalClass]
public abstract partial class AnimationMixerComponent : NodeComponent
{

    /// <inheritdoc cref="AnimationMixer._PostProcessKeyValue(Animation, int, Variant, ulong, int)" />
    public virtual Variant _PostProcessKeyValue(Animation @animation, int @track, Variant @value, ulong @objectId, int @objectSubIdx) => ((AnimationMixer)_host)._PostProcessKeyValue(@animation, @track, @value, @objectId, @objectSubIdx);

    /// <inheritdoc cref="AnimationMixer.AddAnimationLibrary(StringName, AnimationLibrary)" />
    public Error AddAnimationLibrary(StringName @name, AnimationLibrary @library) => ((AnimationMixer)_host).AddAnimationLibrary(@name, @library);

    /// <inheritdoc cref="AnimationMixer.RemoveAnimationLibrary(StringName)" />
    public void RemoveAnimationLibrary(StringName @name) => ((AnimationMixer)_host).RemoveAnimationLibrary(@name);

    /// <inheritdoc cref="AnimationMixer.RenameAnimationLibrary(StringName, StringName)" />
    public void RenameAnimationLibrary(StringName @name, StringName @newname) => ((AnimationMixer)_host).RenameAnimationLibrary(@name, @newname);

    /// <inheritdoc cref="AnimationMixer.HasAnimationLibrary(StringName)" />
    public bool HasAnimationLibrary(StringName @name) => ((AnimationMixer)_host).HasAnimationLibrary(@name);

    /// <inheritdoc cref="AnimationMixer.GetAnimationLibrary(StringName)" />
    public AnimationLibrary GetAnimationLibrary(StringName @name) => ((AnimationMixer)_host).GetAnimationLibrary(@name);

    /// <inheritdoc cref="AnimationMixer.GetAnimationLibraryList()" />
    public Array<StringName> GetAnimationLibraryList() => ((AnimationMixer)_host).GetAnimationLibraryList();

    /// <inheritdoc cref="AnimationMixer.HasAnimation(StringName)" />
    public bool HasAnimation(StringName @name) => ((AnimationMixer)_host).HasAnimation(@name);

    /// <inheritdoc cref="AnimationMixer.GetAnimation(StringName)" />
    public Animation GetAnimation(StringName @name) => ((AnimationMixer)_host).GetAnimation(@name);

    /// <inheritdoc cref="AnimationMixer.GetAnimationList()" />
    public string[] GetAnimationList() => ((AnimationMixer)_host).GetAnimationList();

    /// <inheritdoc cref="AnimationMixer.SetActive(bool)" />
    public void SetActive(bool @active) => ((AnimationMixer)_host).SetActive(@active);

    /// <inheritdoc cref="AnimationMixer.IsActive()" />
    public bool IsActive() => ((AnimationMixer)_host).IsActive();

    /// <inheritdoc cref="AnimationMixer.SetDeterministic(bool)" />
    public void SetDeterministic(bool @deterministic) => ((AnimationMixer)_host).SetDeterministic(@deterministic);

    /// <inheritdoc cref="AnimationMixer.IsDeterministic()" />
    public bool IsDeterministic() => ((AnimationMixer)_host).IsDeterministic();

    /// <inheritdoc cref="AnimationMixer.SetRootNode(NodePath)" />
    public void SetRootNode(NodePath @path) => ((AnimationMixer)_host).SetRootNode(@path);

    /// <inheritdoc cref="AnimationMixer.GetRootNode()" />
    public NodePath GetRootNode() => ((AnimationMixer)_host).GetRootNode();

    /// <inheritdoc cref="AnimationMixer.SetCallbackModeProcess(AnimationMixer.AnimationCallbackModeProcess)" />
    public void SetCallbackModeProcess(AnimationMixer.AnimationCallbackModeProcess @mode) => ((AnimationMixer)_host).SetCallbackModeProcess(@mode);

    /// <inheritdoc cref="AnimationMixer.GetCallbackModeProcess()" />
    public AnimationMixer.AnimationCallbackModeProcess GetCallbackModeProcess() => ((AnimationMixer)_host).GetCallbackModeProcess();

    /// <inheritdoc cref="AnimationMixer.SetCallbackModeMethod(AnimationMixer.AnimationCallbackModeMethod)" />
    public void SetCallbackModeMethod(AnimationMixer.AnimationCallbackModeMethod @mode) => ((AnimationMixer)_host).SetCallbackModeMethod(@mode);

    /// <inheritdoc cref="AnimationMixer.GetCallbackModeMethod()" />
    public AnimationMixer.AnimationCallbackModeMethod GetCallbackModeMethod() => ((AnimationMixer)_host).GetCallbackModeMethod();

    /// <inheritdoc cref="AnimationMixer.SetCallbackModeDiscrete(AnimationMixer.AnimationCallbackModeDiscrete)" />
    public void SetCallbackModeDiscrete(AnimationMixer.AnimationCallbackModeDiscrete @mode) => ((AnimationMixer)_host).SetCallbackModeDiscrete(@mode);

    /// <inheritdoc cref="AnimationMixer.GetCallbackModeDiscrete()" />
    public AnimationMixer.AnimationCallbackModeDiscrete GetCallbackModeDiscrete() => ((AnimationMixer)_host).GetCallbackModeDiscrete();

    /// <inheritdoc cref="AnimationMixer.SetAudioMaxPolyphony(int)" />
    public void SetAudioMaxPolyphony(int @maxPolyphony) => ((AnimationMixer)_host).SetAudioMaxPolyphony(@maxPolyphony);

    /// <inheritdoc cref="AnimationMixer.GetAudioMaxPolyphony()" />
    public int GetAudioMaxPolyphony() => ((AnimationMixer)_host).GetAudioMaxPolyphony();

    /// <inheritdoc cref="AnimationMixer.SetRootMotionTrack(NodePath)" />
    public void SetRootMotionTrack(NodePath @path) => ((AnimationMixer)_host).SetRootMotionTrack(@path);

    /// <inheritdoc cref="AnimationMixer.GetRootMotionTrack()" />
    public NodePath GetRootMotionTrack() => ((AnimationMixer)_host).GetRootMotionTrack();

    /// <inheritdoc cref="AnimationMixer.SetRootMotionLocal(bool)" />
    public void SetRootMotionLocal(bool @enabled) => ((AnimationMixer)_host).SetRootMotionLocal(@enabled);

    /// <inheritdoc cref="AnimationMixer.IsRootMotionLocal()" />
    public bool IsRootMotionLocal() => ((AnimationMixer)_host).IsRootMotionLocal();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionPosition()" />
    public Vector3 GetRootMotionPosition() => ((AnimationMixer)_host).GetRootMotionPosition();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionRotation()" />
    public Quaternion GetRootMotionRotation() => ((AnimationMixer)_host).GetRootMotionRotation();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionScale()" />
    public Vector3 GetRootMotionScale() => ((AnimationMixer)_host).GetRootMotionScale();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionPositionAccumulator()" />
    public Vector3 GetRootMotionPositionAccumulator() => ((AnimationMixer)_host).GetRootMotionPositionAccumulator();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionRotationAccumulator()" />
    public Quaternion GetRootMotionRotationAccumulator() => ((AnimationMixer)_host).GetRootMotionRotationAccumulator();

    /// <inheritdoc cref="AnimationMixer.GetRootMotionScaleAccumulator()" />
    public Vector3 GetRootMotionScaleAccumulator() => ((AnimationMixer)_host).GetRootMotionScaleAccumulator();

    /// <inheritdoc cref="AnimationMixer.ClearCaches()" />
    public void ClearCaches() => ((AnimationMixer)_host).ClearCaches();

    /// <inheritdoc cref="AnimationMixer.Advance(double)" />
    public void Advance(double @delta) => ((AnimationMixer)_host).Advance(@delta);

    /// <inheritdoc cref="AnimationMixer.Capture(StringName, double, Tween.TransitionType, Tween.EaseType)" />
    public void Capture(StringName @name, double @duration, Tween.TransitionType @transType, Tween.EaseType @easeType) => ((AnimationMixer)_host).Capture(@name, @duration, @transType, @easeType);

    /// <inheritdoc cref="AnimationMixer.SetResetOnSaveEnabled(bool)" />
    public void SetResetOnSaveEnabled(bool @enabled) => ((AnimationMixer)_host).SetResetOnSaveEnabled(@enabled);

    /// <inheritdoc cref="AnimationMixer.IsResetOnSaveEnabled()" />
    public bool IsResetOnSaveEnabled() => ((AnimationMixer)_host).IsResetOnSaveEnabled();

    /// <inheritdoc cref="AnimationMixer.FindAnimation(Animation)" />
    public StringName FindAnimation(Animation @animation) => ((AnimationMixer)_host).FindAnimation(@animation);

    /// <inheritdoc cref="AnimationMixer.FindAnimationLibrary(Animation)" />
    public StringName FindAnimationLibrary(Animation @animation) => ((AnimationMixer)_host).FindAnimationLibrary(@animation);

    /// <inheritdoc cref="AnimationMixer._PostProcessKeyValue(Animation, int, Variant, GodotObject, int)" />
    public Variant _PostProcessKeyValue(Animation @animation, int @track, Variant @value, GodotObject @object, int @objectIdx) => ((AnimationMixer)_host)._PostProcessKeyValue(@animation, @track, @value, @object, @objectIdx);

}
