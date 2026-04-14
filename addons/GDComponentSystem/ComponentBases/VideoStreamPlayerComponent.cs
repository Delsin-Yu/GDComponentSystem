#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VideoStreamPlayer" />
[Tool, GlobalClass]
public abstract partial class VideoStreamPlayerComponent : ControlComponent
{

    /// <inheritdoc cref="VideoStreamPlayer.SetStream(VideoStream)" />
    public void SetStream(VideoStream @stream) => ((VideoStreamPlayer)_host).SetStream(@stream);

    /// <inheritdoc cref="VideoStreamPlayer.GetStream()" />
    public VideoStream GetStream() => ((VideoStreamPlayer)_host).GetStream();

    /// <inheritdoc cref="VideoStreamPlayer.Play()" />
    public void Play() => ((VideoStreamPlayer)_host).Play();

    /// <inheritdoc cref="VideoStreamPlayer.Stop()" />
    public void Stop() => ((VideoStreamPlayer)_host).Stop();

    /// <inheritdoc cref="VideoStreamPlayer.IsPlaying()" />
    public bool IsPlaying() => ((VideoStreamPlayer)_host).IsPlaying();

    /// <inheritdoc cref="VideoStreamPlayer.SetPaused(bool)" />
    public void SetPaused(bool @paused) => ((VideoStreamPlayer)_host).SetPaused(@paused);

    /// <inheritdoc cref="VideoStreamPlayer.IsPaused()" />
    public bool IsPaused() => ((VideoStreamPlayer)_host).IsPaused();

    /// <inheritdoc cref="VideoStreamPlayer.SetLoop(bool)" />
    public void SetLoop(bool @loop) => ((VideoStreamPlayer)_host).SetLoop(@loop);

    /// <inheritdoc cref="VideoStreamPlayer.HasLoop()" />
    public bool HasLoop() => ((VideoStreamPlayer)_host).HasLoop();

    /// <inheritdoc cref="VideoStreamPlayer.SetVolume(float)" />
    public void SetVolume(float @volume) => ((VideoStreamPlayer)_host).SetVolume(@volume);

    /// <inheritdoc cref="VideoStreamPlayer.GetVolume()" />
    public float GetVolume() => ((VideoStreamPlayer)_host).GetVolume();

    /// <inheritdoc cref="VideoStreamPlayer.SetVolumeDb(float)" />
    public void SetVolumeDb(float @db) => ((VideoStreamPlayer)_host).SetVolumeDb(@db);

    /// <inheritdoc cref="VideoStreamPlayer.GetVolumeDb()" />
    public float GetVolumeDb() => ((VideoStreamPlayer)_host).GetVolumeDb();

    /// <inheritdoc cref="VideoStreamPlayer.SetSpeedScale(float)" />
    public void SetSpeedScale(float @speedScale) => ((VideoStreamPlayer)_host).SetSpeedScale(@speedScale);

    /// <inheritdoc cref="VideoStreamPlayer.GetSpeedScale()" />
    public float GetSpeedScale() => ((VideoStreamPlayer)_host).GetSpeedScale();

    /// <inheritdoc cref="VideoStreamPlayer.SetAudioTrack(int)" />
    public void SetAudioTrack(int @track) => ((VideoStreamPlayer)_host).SetAudioTrack(@track);

    /// <inheritdoc cref="VideoStreamPlayer.GetAudioTrack()" />
    public int GetAudioTrack() => ((VideoStreamPlayer)_host).GetAudioTrack();

    /// <inheritdoc cref="VideoStreamPlayer.GetStreamName()" />
    public string GetStreamName() => ((VideoStreamPlayer)_host).GetStreamName();

    /// <inheritdoc cref="VideoStreamPlayer.GetStreamLength()" />
    public double GetStreamLength() => ((VideoStreamPlayer)_host).GetStreamLength();

    /// <inheritdoc cref="VideoStreamPlayer.SetStreamPosition(double)" />
    public void SetStreamPosition(double @position) => ((VideoStreamPlayer)_host).SetStreamPosition(@position);

    /// <inheritdoc cref="VideoStreamPlayer.GetStreamPosition()" />
    public double GetStreamPosition() => ((VideoStreamPlayer)_host).GetStreamPosition();

    /// <inheritdoc cref="VideoStreamPlayer.SetAutoplay(bool)" />
    public void SetAutoplay(bool @enabled) => ((VideoStreamPlayer)_host).SetAutoplay(@enabled);

    /// <inheritdoc cref="VideoStreamPlayer.HasAutoplay()" />
    public bool HasAutoplay() => ((VideoStreamPlayer)_host).HasAutoplay();

    /// <inheritdoc cref="VideoStreamPlayer.SetExpand(bool)" />
    public void SetExpand(bool @enable) => ((VideoStreamPlayer)_host).SetExpand(@enable);

    /// <inheritdoc cref="VideoStreamPlayer.HasExpand()" />
    public bool HasExpand() => ((VideoStreamPlayer)_host).HasExpand();

    /// <inheritdoc cref="VideoStreamPlayer.SetBufferingMsec(int)" />
    public void SetBufferingMsec(int @msec) => ((VideoStreamPlayer)_host).SetBufferingMsec(@msec);

    /// <inheritdoc cref="VideoStreamPlayer.GetBufferingMsec()" />
    public int GetBufferingMsec() => ((VideoStreamPlayer)_host).GetBufferingMsec();

    /// <inheritdoc cref="VideoStreamPlayer.SetBus(StringName)" />
    public void SetBus(StringName @bus) => ((VideoStreamPlayer)_host).SetBus(@bus);

    /// <inheritdoc cref="VideoStreamPlayer.GetBus()" />
    public StringName GetBus() => ((VideoStreamPlayer)_host).GetBus();

    /// <inheritdoc cref="VideoStreamPlayer.GetVideoTexture()" />
    public Texture2D GetVideoTexture() => ((VideoStreamPlayer)_host).GetVideoTexture();

}
