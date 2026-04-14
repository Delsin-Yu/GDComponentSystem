#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimationPlayer" />
[Tool, GlobalClass]
public abstract partial class AnimationPlayerComponent : AnimationMixerComponent
{

    /// <inheritdoc cref="AnimationPlayer.AnimationSetNext(StringName, StringName)" />
    public void AnimationSetNext(StringName @animationFrom, StringName @animationTo) => ((AnimationPlayer)_host).AnimationSetNext(@animationFrom, @animationTo);

    /// <inheritdoc cref="AnimationPlayer.AnimationGetNext(StringName)" />
    public StringName AnimationGetNext(StringName @animationFrom) => ((AnimationPlayer)_host).AnimationGetNext(@animationFrom);

    /// <inheritdoc cref="AnimationPlayer.SetBlendTime(StringName, StringName, double)" />
    public void SetBlendTime(StringName @animationFrom, StringName @animationTo, double @sec) => ((AnimationPlayer)_host).SetBlendTime(@animationFrom, @animationTo, @sec);

    /// <inheritdoc cref="AnimationPlayer.GetBlendTime(StringName, StringName)" />
    public double GetBlendTime(StringName @animationFrom, StringName @animationTo) => ((AnimationPlayer)_host).GetBlendTime(@animationFrom, @animationTo);

    /// <inheritdoc cref="AnimationPlayer.SetDefaultBlendTime(double)" />
    public void SetDefaultBlendTime(double @sec) => ((AnimationPlayer)_host).SetDefaultBlendTime(@sec);

    /// <inheritdoc cref="AnimationPlayer.GetDefaultBlendTime()" />
    public double GetDefaultBlendTime() => ((AnimationPlayer)_host).GetDefaultBlendTime();

    /// <inheritdoc cref="AnimationPlayer.SetAutoCapture(bool)" />
    public void SetAutoCapture(bool @autoCapture) => ((AnimationPlayer)_host).SetAutoCapture(@autoCapture);

    /// <inheritdoc cref="AnimationPlayer.IsAutoCapture()" />
    public bool IsAutoCapture() => ((AnimationPlayer)_host).IsAutoCapture();

    /// <inheritdoc cref="AnimationPlayer.SetAutoCaptureDuration(double)" />
    public void SetAutoCaptureDuration(double @autoCaptureDuration) => ((AnimationPlayer)_host).SetAutoCaptureDuration(@autoCaptureDuration);

    /// <inheritdoc cref="AnimationPlayer.GetAutoCaptureDuration()" />
    public double GetAutoCaptureDuration() => ((AnimationPlayer)_host).GetAutoCaptureDuration();

    /// <inheritdoc cref="AnimationPlayer.SetAutoCaptureTransitionType(Tween.TransitionType)" />
    public void SetAutoCaptureTransitionType(Tween.TransitionType @autoCaptureTransitionType) => ((AnimationPlayer)_host).SetAutoCaptureTransitionType(@autoCaptureTransitionType);

    /// <inheritdoc cref="AnimationPlayer.GetAutoCaptureTransitionType()" />
    public Tween.TransitionType GetAutoCaptureTransitionType() => ((AnimationPlayer)_host).GetAutoCaptureTransitionType();

    /// <inheritdoc cref="AnimationPlayer.SetAutoCaptureEaseType(Tween.EaseType)" />
    public void SetAutoCaptureEaseType(Tween.EaseType @autoCaptureEaseType) => ((AnimationPlayer)_host).SetAutoCaptureEaseType(@autoCaptureEaseType);

    /// <inheritdoc cref="AnimationPlayer.GetAutoCaptureEaseType()" />
    public Tween.EaseType GetAutoCaptureEaseType() => ((AnimationPlayer)_host).GetAutoCaptureEaseType();

    /// <inheritdoc cref="AnimationPlayer.Play(StringName, double, float, bool)" />
    public void Play(StringName @name, double @customBlend, float @customSpeed, bool @fromEnd) => ((AnimationPlayer)_host).Play(@name, @customBlend, @customSpeed, @fromEnd);

    /// <inheritdoc cref="AnimationPlayer.PlaySectionWithMarkers(StringName, StringName, StringName, double, float, bool)" />
    public void PlaySectionWithMarkers(StringName @name, StringName @startMarker, StringName @endMarker, double @customBlend, float @customSpeed, bool @fromEnd) => ((AnimationPlayer)_host).PlaySectionWithMarkers(@name, @startMarker, @endMarker, @customBlend, @customSpeed, @fromEnd);

    /// <inheritdoc cref="AnimationPlayer.PlaySection(StringName, double, double, double, float, bool)" />
    public void PlaySection(StringName @name, double @startTime, double @endTime, double @customBlend, float @customSpeed, bool @fromEnd) => ((AnimationPlayer)_host).PlaySection(@name, @startTime, @endTime, @customBlend, @customSpeed, @fromEnd);

    /// <inheritdoc cref="AnimationPlayer.PlayBackwards(StringName, double)" />
    public void PlayBackwards(StringName @name, double @customBlend) => ((AnimationPlayer)_host).PlayBackwards(@name, @customBlend);

    /// <inheritdoc cref="AnimationPlayer.PlaySectionWithMarkersBackwards(StringName, StringName, StringName, double)" />
    public void PlaySectionWithMarkersBackwards(StringName @name, StringName @startMarker, StringName @endMarker, double @customBlend) => ((AnimationPlayer)_host).PlaySectionWithMarkersBackwards(@name, @startMarker, @endMarker, @customBlend);

    /// <inheritdoc cref="AnimationPlayer.PlaySectionBackwards(StringName, double, double, double)" />
    public void PlaySectionBackwards(StringName @name, double @startTime, double @endTime, double @customBlend) => ((AnimationPlayer)_host).PlaySectionBackwards(@name, @startTime, @endTime, @customBlend);

    /// <inheritdoc cref="AnimationPlayer.PlayWithCapture(StringName, double, double, float, bool, Tween.TransitionType, Tween.EaseType)" />
    public void PlayWithCapture(StringName @name, double @duration, double @customBlend, float @customSpeed, bool @fromEnd, Tween.TransitionType @transType, Tween.EaseType @easeType) => ((AnimationPlayer)_host).PlayWithCapture(@name, @duration, @customBlend, @customSpeed, @fromEnd, @transType, @easeType);

    /// <inheritdoc cref="AnimationPlayer.Pause()" />
    public void Pause() => ((AnimationPlayer)_host).Pause();

    /// <inheritdoc cref="AnimationPlayer.Stop(bool)" />
    public void Stop(bool @keepState) => ((AnimationPlayer)_host).Stop(@keepState);

    /// <inheritdoc cref="AnimationPlayer.IsPlaying()" />
    public bool IsPlaying() => ((AnimationPlayer)_host).IsPlaying();

    /// <inheritdoc cref="AnimationPlayer.IsAnimationActive()" />
    public bool IsAnimationActive() => ((AnimationPlayer)_host).IsAnimationActive();

    /// <inheritdoc cref="AnimationPlayer.SetCurrentAnimation(StringName)" />
    public void SetCurrentAnimation(StringName @animation) => ((AnimationPlayer)_host).SetCurrentAnimation(@animation);

    /// <inheritdoc cref="AnimationPlayer.GetCurrentAnimation()" />
    public StringName GetCurrentAnimation() => ((AnimationPlayer)_host).GetCurrentAnimation();

    /// <inheritdoc cref="AnimationPlayer.SetAssignedAnimation(StringName)" />
    public void SetAssignedAnimation(StringName @animation) => ((AnimationPlayer)_host).SetAssignedAnimation(@animation);

    /// <inheritdoc cref="AnimationPlayer.GetAssignedAnimation()" />
    public StringName GetAssignedAnimation() => ((AnimationPlayer)_host).GetAssignedAnimation();

    /// <inheritdoc cref="AnimationPlayer.Queue(StringName)" />
    public void Queue(StringName @name) => ((AnimationPlayer)_host).Queue(@name);

    /// <inheritdoc cref="AnimationPlayer.GetQueue()" />
    public Array<StringName> GetQueue() => ((AnimationPlayer)_host).GetQueue();

    /// <inheritdoc cref="AnimationPlayer.ClearQueue()" />
    public void ClearQueue() => ((AnimationPlayer)_host).ClearQueue();

    /// <inheritdoc cref="AnimationPlayer.SetSpeedScale(float)" />
    public void SetSpeedScale(float @speed) => ((AnimationPlayer)_host).SetSpeedScale(@speed);

    /// <inheritdoc cref="AnimationPlayer.GetSpeedScale()" />
    public float GetSpeedScale() => ((AnimationPlayer)_host).GetSpeedScale();

    /// <inheritdoc cref="AnimationPlayer.GetPlayingSpeed()" />
    public float GetPlayingSpeed() => ((AnimationPlayer)_host).GetPlayingSpeed();

    /// <inheritdoc cref="AnimationPlayer.SetAutoplay(StringName)" />
    public void SetAutoplay(StringName @name) => ((AnimationPlayer)_host).SetAutoplay(@name);

    /// <inheritdoc cref="AnimationPlayer.GetAutoplay()" />
    public StringName GetAutoplay() => ((AnimationPlayer)_host).GetAutoplay();

    /// <inheritdoc cref="AnimationPlayer.SetMovieQuitOnFinishEnabled(bool)" />
    public void SetMovieQuitOnFinishEnabled(bool @enabled) => ((AnimationPlayer)_host).SetMovieQuitOnFinishEnabled(@enabled);

    /// <inheritdoc cref="AnimationPlayer.IsMovieQuitOnFinishEnabled()" />
    public bool IsMovieQuitOnFinishEnabled() => ((AnimationPlayer)_host).IsMovieQuitOnFinishEnabled();

    /// <inheritdoc cref="AnimationPlayer.GetCurrentAnimationPosition()" />
    public double GetCurrentAnimationPosition() => ((AnimationPlayer)_host).GetCurrentAnimationPosition();

    /// <inheritdoc cref="AnimationPlayer.GetCurrentAnimationLength()" />
    public double GetCurrentAnimationLength() => ((AnimationPlayer)_host).GetCurrentAnimationLength();

    /// <inheritdoc cref="AnimationPlayer.SetSectionWithMarkers(StringName, StringName)" />
    public void SetSectionWithMarkers(StringName @startMarker, StringName @endMarker) => ((AnimationPlayer)_host).SetSectionWithMarkers(@startMarker, @endMarker);

    /// <inheritdoc cref="AnimationPlayer.SetSection(double, double)" />
    public void SetSection(double @startTime, double @endTime) => ((AnimationPlayer)_host).SetSection(@startTime, @endTime);

    /// <inheritdoc cref="AnimationPlayer.ResetSection()" />
    public void ResetSection() => ((AnimationPlayer)_host).ResetSection();

    /// <inheritdoc cref="AnimationPlayer.GetSectionStartTime()" />
    public double GetSectionStartTime() => ((AnimationPlayer)_host).GetSectionStartTime();

    /// <inheritdoc cref="AnimationPlayer.GetSectionEndTime()" />
    public double GetSectionEndTime() => ((AnimationPlayer)_host).GetSectionEndTime();

    /// <inheritdoc cref="AnimationPlayer.HasSection()" />
    public bool HasSection() => ((AnimationPlayer)_host).HasSection();

    /// <inheritdoc cref="AnimationPlayer.Seek(double, bool, bool)" />
    public void Seek(double @seconds, bool @update, bool @updateOnly) => ((AnimationPlayer)_host).Seek(@seconds, @update, @updateOnly);

    /// <inheritdoc cref="AnimationPlayer.SetProcessCallback(AnimationPlayer.AnimationProcessCallback)" />
    public void SetProcessCallback(AnimationPlayer.AnimationProcessCallback @mode) => ((AnimationPlayer)_host).SetProcessCallback(@mode);

    /// <inheritdoc cref="AnimationPlayer.GetProcessCallback()" />
    public AnimationPlayer.AnimationProcessCallback GetProcessCallback() => ((AnimationPlayer)_host).GetProcessCallback();

    /// <inheritdoc cref="AnimationPlayer.SetMethodCallMode(AnimationPlayer.AnimationMethodCallMode)" />
    public void SetMethodCallMode(AnimationPlayer.AnimationMethodCallMode @mode) => ((AnimationPlayer)_host).SetMethodCallMode(@mode);

    /// <inheritdoc cref="AnimationPlayer.GetMethodCallMode()" />
    public AnimationPlayer.AnimationMethodCallMode GetMethodCallMode() => ((AnimationPlayer)_host).GetMethodCallMode();

    /// <inheritdoc cref="AnimationPlayer.SetRoot(NodePath)" />
    public void SetRoot(NodePath @path) => ((AnimationPlayer)_host).SetRoot(@path);

    /// <inheritdoc cref="AnimationPlayer.GetRoot()" />
    public NodePath GetRoot() => ((AnimationPlayer)_host).GetRoot();

    /// <inheritdoc cref="AnimationPlayer.Seek(double, bool)" />
    public void Seek(double @seconds, bool @update) => ((AnimationPlayer)_host).Seek(@seconds, @update);

    /// <inheritdoc cref="AnimationPlayer.SetAutoplay(string)" />
    public void SetAutoplay(string @name) => ((AnimationPlayer)_host).SetAutoplay(@name);

    /// <inheritdoc cref="AnimationPlayer.SetAssignedAnimation(string)" />
    public void SetAssignedAnimation(string @animation) => ((AnimationPlayer)_host).SetAssignedAnimation(@animation);

    /// <inheritdoc cref="AnimationPlayer.SetCurrentAnimation(string)" />
    public void SetCurrentAnimation(string @animation) => ((AnimationPlayer)_host).SetCurrentAnimation(@animation);

}
