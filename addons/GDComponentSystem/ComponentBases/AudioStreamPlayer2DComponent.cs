#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AudioStreamPlayer2D" />
[Tool, GlobalClass]
public abstract partial class AudioStreamPlayer2DComponent : Node2DComponent
{

    /// <inheritdoc cref="AudioStreamPlayer2D.SetStream(AudioStream)" />
    public void SetStream(AudioStream @stream) => ((AudioStreamPlayer2D)_host).SetStream(@stream);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetStream()" />
    public AudioStream GetStream() => ((AudioStreamPlayer2D)_host).GetStream();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetVolumeDb(float)" />
    public void SetVolumeDb(float @volumeDb) => ((AudioStreamPlayer2D)_host).SetVolumeDb(@volumeDb);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetVolumeDb()" />
    public float GetVolumeDb() => ((AudioStreamPlayer2D)_host).GetVolumeDb();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetVolumeLinear(float)" />
    public void SetVolumeLinear(float @volumeLinear) => ((AudioStreamPlayer2D)_host).SetVolumeLinear(@volumeLinear);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetVolumeLinear()" />
    public float GetVolumeLinear() => ((AudioStreamPlayer2D)_host).GetVolumeLinear();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetPitchScale(float)" />
    public void SetPitchScale(float @pitchScale) => ((AudioStreamPlayer2D)_host).SetPitchScale(@pitchScale);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetPitchScale()" />
    public float GetPitchScale() => ((AudioStreamPlayer2D)_host).GetPitchScale();

    /// <inheritdoc cref="AudioStreamPlayer2D.Play(float)" />
    public void Play(float @fromPosition) => ((AudioStreamPlayer2D)_host).Play(@fromPosition);

    /// <inheritdoc cref="AudioStreamPlayer2D.Seek(float)" />
    public void Seek(float @toPosition) => ((AudioStreamPlayer2D)_host).Seek(@toPosition);

    /// <inheritdoc cref="AudioStreamPlayer2D.Stop()" />
    public void Stop() => ((AudioStreamPlayer2D)_host).Stop();

    /// <inheritdoc cref="AudioStreamPlayer2D.IsPlaying()" />
    public bool IsPlaying() => ((AudioStreamPlayer2D)_host).IsPlaying();

    /// <inheritdoc cref="AudioStreamPlayer2D.GetPlaybackPosition()" />
    public float GetPlaybackPosition() => ((AudioStreamPlayer2D)_host).GetPlaybackPosition();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetBus(StringName)" />
    public void SetBus(StringName @bus) => ((AudioStreamPlayer2D)_host).SetBus(@bus);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetBus()" />
    public StringName GetBus() => ((AudioStreamPlayer2D)_host).GetBus();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetAutoplay(bool)" />
    public void SetAutoplay(bool @enable) => ((AudioStreamPlayer2D)_host).SetAutoplay(@enable);

    /// <inheritdoc cref="AudioStreamPlayer2D.IsAutoplayEnabled()" />
    public bool IsAutoplayEnabled() => ((AudioStreamPlayer2D)_host).IsAutoplayEnabled();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetPlaying(bool)" />
    public void SetPlaying(bool @enable) => ((AudioStreamPlayer2D)_host).SetPlaying(@enable);

    /// <inheritdoc cref="AudioStreamPlayer2D.SetMaxDistance(float)" />
    public void SetMaxDistance(float @pixels) => ((AudioStreamPlayer2D)_host).SetMaxDistance(@pixels);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetMaxDistance()" />
    public float GetMaxDistance() => ((AudioStreamPlayer2D)_host).GetMaxDistance();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetAttenuation(float)" />
    public void SetAttenuation(float @curve) => ((AudioStreamPlayer2D)_host).SetAttenuation(@curve);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetAttenuation()" />
    public float GetAttenuation() => ((AudioStreamPlayer2D)_host).GetAttenuation();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetAreaMask(uint)" />
    public void SetAreaMask(uint @mask) => ((AudioStreamPlayer2D)_host).SetAreaMask(@mask);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetAreaMask()" />
    public uint GetAreaMask() => ((AudioStreamPlayer2D)_host).GetAreaMask();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetStreamPaused(bool)" />
    public void SetStreamPaused(bool @pause) => ((AudioStreamPlayer2D)_host).SetStreamPaused(@pause);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetStreamPaused()" />
    public bool GetStreamPaused() => ((AudioStreamPlayer2D)_host).GetStreamPaused();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetMaxPolyphony(int)" />
    public void SetMaxPolyphony(int @maxPolyphony) => ((AudioStreamPlayer2D)_host).SetMaxPolyphony(@maxPolyphony);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetMaxPolyphony()" />
    public int GetMaxPolyphony() => ((AudioStreamPlayer2D)_host).GetMaxPolyphony();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetPanningStrength(float)" />
    public void SetPanningStrength(float @panningStrength) => ((AudioStreamPlayer2D)_host).SetPanningStrength(@panningStrength);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetPanningStrength()" />
    public float GetPanningStrength() => ((AudioStreamPlayer2D)_host).GetPanningStrength();

    /// <inheritdoc cref="AudioStreamPlayer2D.HasStreamPlayback()" />
    public bool HasStreamPlayback() => ((AudioStreamPlayer2D)_host).HasStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer2D.GetStreamPlayback()" />
    public AudioStreamPlayback GetStreamPlayback() => ((AudioStreamPlayer2D)_host).GetStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer2D.SetPlaybackType(AudioServer.PlaybackType)" />
    public void SetPlaybackType(AudioServer.PlaybackType @playbackType) => ((AudioStreamPlayer2D)_host).SetPlaybackType(@playbackType);

    /// <inheritdoc cref="AudioStreamPlayer2D.GetPlaybackType()" />
    public AudioServer.PlaybackType GetPlaybackType() => ((AudioStreamPlayer2D)_host).GetPlaybackType();

}
