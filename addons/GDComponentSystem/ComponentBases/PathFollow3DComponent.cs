#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PathFollow3D" />
[Tool, GlobalClass]
public abstract partial class PathFollow3DComponent : Node3DComponent
{

    /// <inheritdoc cref="PathFollow3D.SetProgress(float)" />
    public void SetProgress(float @progress) => ((PathFollow3D)_host).SetProgress(@progress);

    /// <inheritdoc cref="PathFollow3D.GetProgress()" />
    public float GetProgress() => ((PathFollow3D)_host).GetProgress();

    /// <inheritdoc cref="PathFollow3D.SetHOffset(float)" />
    public void SetHOffset(float @hOffset) => ((PathFollow3D)_host).SetHOffset(@hOffset);

    /// <inheritdoc cref="PathFollow3D.GetHOffset()" />
    public float GetHOffset() => ((PathFollow3D)_host).GetHOffset();

    /// <inheritdoc cref="PathFollow3D.SetVOffset(float)" />
    public void SetVOffset(float @vOffset) => ((PathFollow3D)_host).SetVOffset(@vOffset);

    /// <inheritdoc cref="PathFollow3D.GetVOffset()" />
    public float GetVOffset() => ((PathFollow3D)_host).GetVOffset();

    /// <inheritdoc cref="PathFollow3D.SetProgressRatio(float)" />
    public void SetProgressRatio(float @ratio) => ((PathFollow3D)_host).SetProgressRatio(@ratio);

    /// <inheritdoc cref="PathFollow3D.GetProgressRatio()" />
    public float GetProgressRatio() => ((PathFollow3D)_host).GetProgressRatio();

    /// <inheritdoc cref="PathFollow3D.SetRotationMode(PathFollow3D.RotationModeEnum)" />
    public void SetRotationMode(PathFollow3D.RotationModeEnum @rotationMode) => ((PathFollow3D)_host).SetRotationMode(@rotationMode);

    /// <inheritdoc cref="PathFollow3D.GetRotationMode()" />
    public PathFollow3D.RotationModeEnum GetRotationMode() => ((PathFollow3D)_host).GetRotationMode();

    /// <inheritdoc cref="PathFollow3D.SetCubicInterpolation(bool)" />
    public void SetCubicInterpolation(bool @enabled) => ((PathFollow3D)_host).SetCubicInterpolation(@enabled);

    /// <inheritdoc cref="PathFollow3D.GetCubicInterpolation()" />
    public bool GetCubicInterpolation() => ((PathFollow3D)_host).GetCubicInterpolation();

    /// <inheritdoc cref="PathFollow3D.SetUseModelFront(bool)" />
    public void SetUseModelFront(bool @enabled) => ((PathFollow3D)_host).SetUseModelFront(@enabled);

    /// <inheritdoc cref="PathFollow3D.IsUsingModelFront()" />
    public bool IsUsingModelFront() => ((PathFollow3D)_host).IsUsingModelFront();

    /// <inheritdoc cref="PathFollow3D.SetLoop(bool)" />
    public void SetLoop(bool @loop) => ((PathFollow3D)_host).SetLoop(@loop);

    /// <inheritdoc cref="PathFollow3D.HasLoop()" />
    public bool HasLoop() => ((PathFollow3D)_host).HasLoop();

    /// <inheritdoc cref="PathFollow3D.SetTiltEnabled(bool)" />
    public void SetTiltEnabled(bool @enabled) => ((PathFollow3D)_host).SetTiltEnabled(@enabled);

    /// <inheritdoc cref="PathFollow3D.IsTiltEnabled()" />
    public bool IsTiltEnabled() => ((PathFollow3D)_host).IsTiltEnabled();

}
