#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AudioStreamPlayer" />
[Tool, GlobalClass]
public abstract partial class AudioStreamPlayerComponent : NodeComponent
{

    /// <inheritdoc cref="AudioStreamPlayer.SetStream(AudioStream)" />
    public void SetStream(AudioStream @stream) => ((AudioStreamPlayer)_host).SetStream(@stream);

    /// <inheritdoc cref="AudioStreamPlayer.GetStream()" />
    public AudioStream GetStream() => ((AudioStreamPlayer)_host).GetStream();

    /// <inheritdoc cref="AudioStreamPlayer.SetVolumeDb(float)" />
    public void SetVolumeDb(float @volumeDb) => ((AudioStreamPlayer)_host).SetVolumeDb(@volumeDb);

    /// <inheritdoc cref="AudioStreamPlayer.GetVolumeDb()" />
    public float GetVolumeDb() => ((AudioStreamPlayer)_host).GetVolumeDb();

    /// <inheritdoc cref="AudioStreamPlayer.SetVolumeLinear(float)" />
    public void SetVolumeLinear(float @volumeLinear) => ((AudioStreamPlayer)_host).SetVolumeLinear(@volumeLinear);

    /// <inheritdoc cref="AudioStreamPlayer.GetVolumeLinear()" />
    public float GetVolumeLinear() => ((AudioStreamPlayer)_host).GetVolumeLinear();

    /// <inheritdoc cref="AudioStreamPlayer.SetPitchScale(float)" />
    public void SetPitchScale(float @pitchScale) => ((AudioStreamPlayer)_host).SetPitchScale(@pitchScale);

    /// <inheritdoc cref="AudioStreamPlayer.GetPitchScale()" />
    public float GetPitchScale() => ((AudioStreamPlayer)_host).GetPitchScale();

    /// <inheritdoc cref="AudioStreamPlayer.Play(float)" />
    public void Play(float @fromPosition) => ((AudioStreamPlayer)_host).Play(@fromPosition);

    /// <inheritdoc cref="AudioStreamPlayer.Seek(float)" />
    public void Seek(float @toPosition) => ((AudioStreamPlayer)_host).Seek(@toPosition);

    /// <inheritdoc cref="AudioStreamPlayer.Stop()" />
    public void Stop() => ((AudioStreamPlayer)_host).Stop();

    /// <inheritdoc cref="AudioStreamPlayer.IsPlaying()" />
    public bool IsPlaying() => ((AudioStreamPlayer)_host).IsPlaying();

    /// <inheritdoc cref="AudioStreamPlayer.GetPlaybackPosition()" />
    public float GetPlaybackPosition() => ((AudioStreamPlayer)_host).GetPlaybackPosition();

    /// <inheritdoc cref="AudioStreamPlayer.SetBus(StringName)" />
    public void SetBus(StringName @bus) => ((AudioStreamPlayer)_host).SetBus(@bus);

    /// <inheritdoc cref="AudioStreamPlayer.GetBus()" />
    public StringName GetBus() => ((AudioStreamPlayer)_host).GetBus();

    /// <inheritdoc cref="AudioStreamPlayer.SetAutoplay(bool)" />
    public void SetAutoplay(bool @enable) => ((AudioStreamPlayer)_host).SetAutoplay(@enable);

    /// <inheritdoc cref="AudioStreamPlayer.IsAutoplayEnabled()" />
    public bool IsAutoplayEnabled() => ((AudioStreamPlayer)_host).IsAutoplayEnabled();

    /// <inheritdoc cref="AudioStreamPlayer.SetMixTarget(AudioStreamPlayer.MixTargetEnum)" />
    public void SetMixTarget(AudioStreamPlayer.MixTargetEnum @mixTarget) => ((AudioStreamPlayer)_host).SetMixTarget(@mixTarget);

    /// <inheritdoc cref="AudioStreamPlayer.GetMixTarget()" />
    public AudioStreamPlayer.MixTargetEnum GetMixTarget() => ((AudioStreamPlayer)_host).GetMixTarget();

    /// <inheritdoc cref="AudioStreamPlayer.SetPlaying(bool)" />
    public void SetPlaying(bool @enable) => ((AudioStreamPlayer)_host).SetPlaying(@enable);

    /// <inheritdoc cref="AudioStreamPlayer.SetStreamPaused(bool)" />
    public void SetStreamPaused(bool @pause) => ((AudioStreamPlayer)_host).SetStreamPaused(@pause);

    /// <inheritdoc cref="AudioStreamPlayer.GetStreamPaused()" />
    public bool GetStreamPaused() => ((AudioStreamPlayer)_host).GetStreamPaused();

    /// <inheritdoc cref="AudioStreamPlayer.SetMaxPolyphony(int)" />
    public void SetMaxPolyphony(int @maxPolyphony) => ((AudioStreamPlayer)_host).SetMaxPolyphony(@maxPolyphony);

    /// <inheritdoc cref="AudioStreamPlayer.GetMaxPolyphony()" />
    public int GetMaxPolyphony() => ((AudioStreamPlayer)_host).GetMaxPolyphony();

    /// <inheritdoc cref="AudioStreamPlayer.HasStreamPlayback()" />
    public bool HasStreamPlayback() => ((AudioStreamPlayer)_host).HasStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer.GetStreamPlayback()" />
    public AudioStreamPlayback GetStreamPlayback() => ((AudioStreamPlayer)_host).GetStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer.SetPlaybackType(AudioServer.PlaybackType)" />
    public void SetPlaybackType(AudioServer.PlaybackType @playbackType) => ((AudioStreamPlayer)_host).SetPlaybackType(@playbackType);

    /// <inheritdoc cref="AudioStreamPlayer.GetPlaybackType()" />
    public AudioServer.PlaybackType GetPlaybackType() => ((AudioStreamPlayer)_host).GetPlaybackType();

}
