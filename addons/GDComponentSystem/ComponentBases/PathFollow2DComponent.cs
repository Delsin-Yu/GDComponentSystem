#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PathFollow2D" />
[Tool, GlobalClass]
public abstract partial class PathFollow2DComponent : Node2DComponent
{

    /// <inheritdoc cref="PathFollow2D.SetProgress(float)" />
    public void SetProgress(float @progress) => ((PathFollow2D)_host).SetProgress(@progress);

    /// <inheritdoc cref="PathFollow2D.GetProgress()" />
    public float GetProgress() => ((PathFollow2D)_host).GetProgress();

    /// <inheritdoc cref="PathFollow2D.SetHOffset(float)" />
    public void SetHOffset(float @hOffset) => ((PathFollow2D)_host).SetHOffset(@hOffset);

    /// <inheritdoc cref="PathFollow2D.GetHOffset()" />
    public float GetHOffset() => ((PathFollow2D)_host).GetHOffset();

    /// <inheritdoc cref="PathFollow2D.SetVOffset(float)" />
    public void SetVOffset(float @vOffset) => ((PathFollow2D)_host).SetVOffset(@vOffset);

    /// <inheritdoc cref="PathFollow2D.GetVOffset()" />
    public float GetVOffset() => ((PathFollow2D)_host).GetVOffset();

    /// <inheritdoc cref="PathFollow2D.SetProgressRatio(float)" />
    public void SetProgressRatio(float @ratio) => ((PathFollow2D)_host).SetProgressRatio(@ratio);

    /// <inheritdoc cref="PathFollow2D.GetProgressRatio()" />
    public float GetProgressRatio() => ((PathFollow2D)_host).GetProgressRatio();

    /// <inheritdoc cref="PathFollow2D.SetRotates(bool)" />
    public void SetRotates(bool @enabled) => ((PathFollow2D)_host).SetRotates(@enabled);

    /// <inheritdoc cref="PathFollow2D.IsRotating()" />
    public bool IsRotating() => ((PathFollow2D)_host).IsRotating();

    /// <inheritdoc cref="PathFollow2D.SetCubicInterpolation(bool)" />
    public void SetCubicInterpolation(bool @enabled) => ((PathFollow2D)_host).SetCubicInterpolation(@enabled);

    /// <inheritdoc cref="PathFollow2D.GetCubicInterpolation()" />
    public bool GetCubicInterpolation() => ((PathFollow2D)_host).GetCubicInterpolation();

    /// <inheritdoc cref="PathFollow2D.SetLoop(bool)" />
    public void SetLoop(bool @loop) => ((PathFollow2D)_host).SetLoop(@loop);

    /// <inheritdoc cref="PathFollow2D.HasLoop()" />
    public bool HasLoop() => ((PathFollow2D)_host).HasLoop();

}
