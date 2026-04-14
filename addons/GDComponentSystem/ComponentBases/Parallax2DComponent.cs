#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Parallax2D" />
[Tool, GlobalClass]
public abstract partial class Parallax2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Parallax2D.SetScrollScale(Vector2)" />
    public void SetScrollScale(Vector2 @scale) => ((Parallax2D)_host).SetScrollScale(@scale);

    /// <inheritdoc cref="Parallax2D.GetScrollScale()" />
    public Vector2 GetScrollScale() => ((Parallax2D)_host).GetScrollScale();

    /// <inheritdoc cref="Parallax2D.SetRepeatSize(Vector2)" />
    public void SetRepeatSize(Vector2 @repeatSize) => ((Parallax2D)_host).SetRepeatSize(@repeatSize);

    /// <inheritdoc cref="Parallax2D.GetRepeatSize()" />
    public Vector2 GetRepeatSize() => ((Parallax2D)_host).GetRepeatSize();

    /// <inheritdoc cref="Parallax2D.SetRepeatTimes(int)" />
    public void SetRepeatTimes(int @repeatTimes) => ((Parallax2D)_host).SetRepeatTimes(@repeatTimes);

    /// <inheritdoc cref="Parallax2D.GetRepeatTimes()" />
    public int GetRepeatTimes() => ((Parallax2D)_host).GetRepeatTimes();

    /// <inheritdoc cref="Parallax2D.SetAutoscroll(Vector2)" />
    public void SetAutoscroll(Vector2 @autoscroll) => ((Parallax2D)_host).SetAutoscroll(@autoscroll);

    /// <inheritdoc cref="Parallax2D.GetAutoscroll()" />
    public Vector2 GetAutoscroll() => ((Parallax2D)_host).GetAutoscroll();

    /// <inheritdoc cref="Parallax2D.SetScrollOffset(Vector2)" />
    public void SetScrollOffset(Vector2 @offset) => ((Parallax2D)_host).SetScrollOffset(@offset);

    /// <inheritdoc cref="Parallax2D.GetScrollOffset()" />
    public Vector2 GetScrollOffset() => ((Parallax2D)_host).GetScrollOffset();

    /// <inheritdoc cref="Parallax2D.SetScreenOffset(Vector2)" />
    public void SetScreenOffset(Vector2 @offset) => ((Parallax2D)_host).SetScreenOffset(@offset);

    /// <inheritdoc cref="Parallax2D.GetScreenOffset()" />
    public Vector2 GetScreenOffset() => ((Parallax2D)_host).GetScreenOffset();

    /// <inheritdoc cref="Parallax2D.SetLimitBegin(Vector2)" />
    public void SetLimitBegin(Vector2 @offset) => ((Parallax2D)_host).SetLimitBegin(@offset);

    /// <inheritdoc cref="Parallax2D.GetLimitBegin()" />
    public Vector2 GetLimitBegin() => ((Parallax2D)_host).GetLimitBegin();

    /// <inheritdoc cref="Parallax2D.SetLimitEnd(Vector2)" />
    public void SetLimitEnd(Vector2 @offset) => ((Parallax2D)_host).SetLimitEnd(@offset);

    /// <inheritdoc cref="Parallax2D.GetLimitEnd()" />
    public Vector2 GetLimitEnd() => ((Parallax2D)_host).GetLimitEnd();

    /// <inheritdoc cref="Parallax2D.SetFollowViewport(bool)" />
    public void SetFollowViewport(bool @follow) => ((Parallax2D)_host).SetFollowViewport(@follow);

    /// <inheritdoc cref="Parallax2D.GetFollowViewport()" />
    public bool GetFollowViewport() => ((Parallax2D)_host).GetFollowViewport();

    /// <inheritdoc cref="Parallax2D.SetIgnoreCameraScroll(bool)" />
    public void SetIgnoreCameraScroll(bool @ignore) => ((Parallax2D)_host).SetIgnoreCameraScroll(@ignore);

    /// <inheritdoc cref="Parallax2D.IsIgnoreCameraScroll()" />
    public bool IsIgnoreCameraScroll() => ((Parallax2D)_host).IsIgnoreCameraScroll();

}
