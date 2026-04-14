#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AudioStreamPlayer3D" />
[Tool, GlobalClass]
public abstract partial class AudioStreamPlayer3DComponent : Node3DComponent
{

    /// <inheritdoc cref="AudioStreamPlayer3D.SetStream(AudioStream)" />
    public void SetStream(AudioStream @stream) => ((AudioStreamPlayer3D)_host).SetStream(@stream);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetStream()" />
    public AudioStream GetStream() => ((AudioStreamPlayer3D)_host).GetStream();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetVolumeDb(float)" />
    public void SetVolumeDb(float @volumeDb) => ((AudioStreamPlayer3D)_host).SetVolumeDb(@volumeDb);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetVolumeDb()" />
    public float GetVolumeDb() => ((AudioStreamPlayer3D)_host).GetVolumeDb();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetVolumeLinear(float)" />
    public void SetVolumeLinear(float @volumeLinear) => ((AudioStreamPlayer3D)_host).SetVolumeLinear(@volumeLinear);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetVolumeLinear()" />
    public float GetVolumeLinear() => ((AudioStreamPlayer3D)_host).GetVolumeLinear();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetUnitSize(float)" />
    public void SetUnitSize(float @unitSize) => ((AudioStreamPlayer3D)_host).SetUnitSize(@unitSize);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetUnitSize()" />
    public float GetUnitSize() => ((AudioStreamPlayer3D)_host).GetUnitSize();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetMaxDb(float)" />
    public void SetMaxDb(float @maxDb) => ((AudioStreamPlayer3D)_host).SetMaxDb(@maxDb);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetMaxDb()" />
    public float GetMaxDb() => ((AudioStreamPlayer3D)_host).GetMaxDb();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetPitchScale(float)" />
    public void SetPitchScale(float @pitchScale) => ((AudioStreamPlayer3D)_host).SetPitchScale(@pitchScale);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetPitchScale()" />
    public float GetPitchScale() => ((AudioStreamPlayer3D)_host).GetPitchScale();

    /// <inheritdoc cref="AudioStreamPlayer3D.Play(float)" />
    public void Play(float @fromPosition) => ((AudioStreamPlayer3D)_host).Play(@fromPosition);

    /// <inheritdoc cref="AudioStreamPlayer3D.Seek(float)" />
    public void Seek(float @toPosition) => ((AudioStreamPlayer3D)_host).Seek(@toPosition);

    /// <inheritdoc cref="AudioStreamPlayer3D.Stop()" />
    public void Stop() => ((AudioStreamPlayer3D)_host).Stop();

    /// <inheritdoc cref="AudioStreamPlayer3D.IsPlaying()" />
    public bool IsPlaying() => ((AudioStreamPlayer3D)_host).IsPlaying();

    /// <inheritdoc cref="AudioStreamPlayer3D.GetPlaybackPosition()" />
    public float GetPlaybackPosition() => ((AudioStreamPlayer3D)_host).GetPlaybackPosition();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetBus(StringName)" />
    public void SetBus(StringName @bus) => ((AudioStreamPlayer3D)_host).SetBus(@bus);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetBus()" />
    public StringName GetBus() => ((AudioStreamPlayer3D)_host).GetBus();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetAutoplay(bool)" />
    public void SetAutoplay(bool @enable) => ((AudioStreamPlayer3D)_host).SetAutoplay(@enable);

    /// <inheritdoc cref="AudioStreamPlayer3D.IsAutoplayEnabled()" />
    public bool IsAutoplayEnabled() => ((AudioStreamPlayer3D)_host).IsAutoplayEnabled();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetPlaying(bool)" />
    public void SetPlaying(bool @enable) => ((AudioStreamPlayer3D)_host).SetPlaying(@enable);

    /// <inheritdoc cref="AudioStreamPlayer3D.SetMaxDistance(float)" />
    public void SetMaxDistance(float @meters) => ((AudioStreamPlayer3D)_host).SetMaxDistance(@meters);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetMaxDistance()" />
    public float GetMaxDistance() => ((AudioStreamPlayer3D)_host).GetMaxDistance();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetAreaMask(uint)" />
    public void SetAreaMask(uint @mask) => ((AudioStreamPlayer3D)_host).SetAreaMask(@mask);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetAreaMask()" />
    public uint GetAreaMask() => ((AudioStreamPlayer3D)_host).GetAreaMask();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetEmissionAngle(float)" />
    public void SetEmissionAngle(float @degrees) => ((AudioStreamPlayer3D)_host).SetEmissionAngle(@degrees);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetEmissionAngle()" />
    public float GetEmissionAngle() => ((AudioStreamPlayer3D)_host).GetEmissionAngle();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetEmissionAngleEnabled(bool)" />
    public void SetEmissionAngleEnabled(bool @enabled) => ((AudioStreamPlayer3D)_host).SetEmissionAngleEnabled(@enabled);

    /// <inheritdoc cref="AudioStreamPlayer3D.IsEmissionAngleEnabled()" />
    public bool IsEmissionAngleEnabled() => ((AudioStreamPlayer3D)_host).IsEmissionAngleEnabled();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetEmissionAngleFilterAttenuationDb(float)" />
    public void SetEmissionAngleFilterAttenuationDb(float @db) => ((AudioStreamPlayer3D)_host).SetEmissionAngleFilterAttenuationDb(@db);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetEmissionAngleFilterAttenuationDb()" />
    public float GetEmissionAngleFilterAttenuationDb() => ((AudioStreamPlayer3D)_host).GetEmissionAngleFilterAttenuationDb();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetAttenuationFilterCutoffHz(float)" />
    public void SetAttenuationFilterCutoffHz(float @degrees) => ((AudioStreamPlayer3D)_host).SetAttenuationFilterCutoffHz(@degrees);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetAttenuationFilterCutoffHz()" />
    public float GetAttenuationFilterCutoffHz() => ((AudioStreamPlayer3D)_host).GetAttenuationFilterCutoffHz();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetAttenuationFilterDb(float)" />
    public void SetAttenuationFilterDb(float @db) => ((AudioStreamPlayer3D)_host).SetAttenuationFilterDb(@db);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetAttenuationFilterDb()" />
    public float GetAttenuationFilterDb() => ((AudioStreamPlayer3D)_host).GetAttenuationFilterDb();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetAttenuationModel(AudioStreamPlayer3D.AttenuationModelEnum)" />
    public void SetAttenuationModel(AudioStreamPlayer3D.AttenuationModelEnum @model) => ((AudioStreamPlayer3D)_host).SetAttenuationModel(@model);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetAttenuationModel()" />
    public AudioStreamPlayer3D.AttenuationModelEnum GetAttenuationModel() => ((AudioStreamPlayer3D)_host).GetAttenuationModel();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetDopplerTracking(AudioStreamPlayer3D.DopplerTrackingEnum)" />
    public void SetDopplerTracking(AudioStreamPlayer3D.DopplerTrackingEnum @mode) => ((AudioStreamPlayer3D)_host).SetDopplerTracking(@mode);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetDopplerTracking()" />
    public AudioStreamPlayer3D.DopplerTrackingEnum GetDopplerTracking() => ((AudioStreamPlayer3D)_host).GetDopplerTracking();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetStreamPaused(bool)" />
    public void SetStreamPaused(bool @pause) => ((AudioStreamPlayer3D)_host).SetStreamPaused(@pause);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetStreamPaused()" />
    public bool GetStreamPaused() => ((AudioStreamPlayer3D)_host).GetStreamPaused();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetMaxPolyphony(int)" />
    public void SetMaxPolyphony(int @maxPolyphony) => ((AudioStreamPlayer3D)_host).SetMaxPolyphony(@maxPolyphony);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetMaxPolyphony()" />
    public int GetMaxPolyphony() => ((AudioStreamPlayer3D)_host).GetMaxPolyphony();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetPanningStrength(float)" />
    public void SetPanningStrength(float @panningStrength) => ((AudioStreamPlayer3D)_host).SetPanningStrength(@panningStrength);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetPanningStrength()" />
    public float GetPanningStrength() => ((AudioStreamPlayer3D)_host).GetPanningStrength();

    /// <inheritdoc cref="AudioStreamPlayer3D.HasStreamPlayback()" />
    public bool HasStreamPlayback() => ((AudioStreamPlayer3D)_host).HasStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer3D.GetStreamPlayback()" />
    public AudioStreamPlayback GetStreamPlayback() => ((AudioStreamPlayer3D)_host).GetStreamPlayback();

    /// <inheritdoc cref="AudioStreamPlayer3D.SetPlaybackType(AudioServer.PlaybackType)" />
    public void SetPlaybackType(AudioServer.PlaybackType @playbackType) => ((AudioStreamPlayer3D)_host).SetPlaybackType(@playbackType);

    /// <inheritdoc cref="AudioStreamPlayer3D.GetPlaybackType()" />
    public AudioServer.PlaybackType GetPlaybackType() => ((AudioStreamPlayer3D)_host).GetPlaybackType();

}
