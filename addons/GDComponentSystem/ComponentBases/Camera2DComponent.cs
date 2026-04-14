#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Camera2D" />
[Tool, GlobalClass]
public abstract partial class Camera2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Camera2D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((Camera2D)_host).SetOffset(@offset);

    /// <inheritdoc cref="Camera2D.GetOffset()" />
    public Vector2 GetOffset() => ((Camera2D)_host).GetOffset();

    /// <inheritdoc cref="Camera2D.SetAnchorMode(Camera2D.AnchorModeEnum)" />
    public void SetAnchorMode(Camera2D.AnchorModeEnum @anchorMode) => ((Camera2D)_host).SetAnchorMode(@anchorMode);

    /// <inheritdoc cref="Camera2D.GetAnchorMode()" />
    public Camera2D.AnchorModeEnum GetAnchorMode() => ((Camera2D)_host).GetAnchorMode();

    /// <inheritdoc cref="Camera2D.SetIgnoreRotation(bool)" />
    public void SetIgnoreRotation(bool @ignore) => ((Camera2D)_host).SetIgnoreRotation(@ignore);

    /// <inheritdoc cref="Camera2D.IsIgnoringRotation()" />
    public bool IsIgnoringRotation() => ((Camera2D)_host).IsIgnoringRotation();

    /// <inheritdoc cref="Camera2D.SetProcessCallback(Camera2D.Camera2DProcessCallback)" />
    public void SetProcessCallback(Camera2D.Camera2DProcessCallback @mode) => ((Camera2D)_host).SetProcessCallback(@mode);

    /// <inheritdoc cref="Camera2D.GetProcessCallback()" />
    public Camera2D.Camera2DProcessCallback GetProcessCallback() => ((Camera2D)_host).GetProcessCallback();

    /// <inheritdoc cref="Camera2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((Camera2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="Camera2D.IsEnabled()" />
    public bool IsEnabled() => ((Camera2D)_host).IsEnabled();

    /// <inheritdoc cref="Camera2D.MakeCurrent()" />
    public void MakeCurrent() => ((Camera2D)_host).MakeCurrent();

    /// <inheritdoc cref="Camera2D.IsCurrent()" />
    public bool IsCurrent() => ((Camera2D)_host).IsCurrent();

    /// <inheritdoc cref="Camera2D.SetLimitEnabled(bool)" />
    public void SetLimitEnabled(bool @limitEnabled) => ((Camera2D)_host).SetLimitEnabled(@limitEnabled);

    /// <inheritdoc cref="Camera2D.IsLimitEnabled()" />
    public bool IsLimitEnabled() => ((Camera2D)_host).IsLimitEnabled();

    /// <inheritdoc cref="Camera2D.SetLimit(Side, int)" />
    public void SetLimit(Side @margin, int @limit) => ((Camera2D)_host).SetLimit(@margin, @limit);

    /// <inheritdoc cref="Camera2D.GetLimit(Side)" />
    public int GetLimit(Side @margin) => ((Camera2D)_host).GetLimit(@margin);

    /// <inheritdoc cref="Camera2D.SetLimitSmoothingEnabled(bool)" />
    public void SetLimitSmoothingEnabled(bool @limitSmoothingEnabled) => ((Camera2D)_host).SetLimitSmoothingEnabled(@limitSmoothingEnabled);

    /// <inheritdoc cref="Camera2D.IsLimitSmoothingEnabled()" />
    public bool IsLimitSmoothingEnabled() => ((Camera2D)_host).IsLimitSmoothingEnabled();

    /// <inheritdoc cref="Camera2D.SetDragVerticalEnabled(bool)" />
    public void SetDragVerticalEnabled(bool @enabled) => ((Camera2D)_host).SetDragVerticalEnabled(@enabled);

    /// <inheritdoc cref="Camera2D.IsDragVerticalEnabled()" />
    public bool IsDragVerticalEnabled() => ((Camera2D)_host).IsDragVerticalEnabled();

    /// <inheritdoc cref="Camera2D.SetDragHorizontalEnabled(bool)" />
    public void SetDragHorizontalEnabled(bool @enabled) => ((Camera2D)_host).SetDragHorizontalEnabled(@enabled);

    /// <inheritdoc cref="Camera2D.IsDragHorizontalEnabled()" />
    public bool IsDragHorizontalEnabled() => ((Camera2D)_host).IsDragHorizontalEnabled();

    /// <inheritdoc cref="Camera2D.SetDragVerticalOffset(float)" />
    public void SetDragVerticalOffset(float @offset) => ((Camera2D)_host).SetDragVerticalOffset(@offset);

    /// <inheritdoc cref="Camera2D.GetDragVerticalOffset()" />
    public float GetDragVerticalOffset() => ((Camera2D)_host).GetDragVerticalOffset();

    /// <inheritdoc cref="Camera2D.SetDragHorizontalOffset(float)" />
    public void SetDragHorizontalOffset(float @offset) => ((Camera2D)_host).SetDragHorizontalOffset(@offset);

    /// <inheritdoc cref="Camera2D.GetDragHorizontalOffset()" />
    public float GetDragHorizontalOffset() => ((Camera2D)_host).GetDragHorizontalOffset();

    /// <inheritdoc cref="Camera2D.SetDragMargin(Side, float)" />
    public void SetDragMargin(Side @margin, float @dragMargin) => ((Camera2D)_host).SetDragMargin(@margin, @dragMargin);

    /// <inheritdoc cref="Camera2D.GetDragMargin(Side)" />
    public float GetDragMargin(Side @margin) => ((Camera2D)_host).GetDragMargin(@margin);

    /// <inheritdoc cref="Camera2D.GetTargetPosition()" />
    public Vector2 GetTargetPosition() => ((Camera2D)_host).GetTargetPosition();

    /// <inheritdoc cref="Camera2D.GetScreenCenterPosition()" />
    public Vector2 GetScreenCenterPosition() => ((Camera2D)_host).GetScreenCenterPosition();

    /// <inheritdoc cref="Camera2D.GetScreenRotation()" />
    public float GetScreenRotation() => ((Camera2D)_host).GetScreenRotation();

    /// <inheritdoc cref="Camera2D.SetZoom(Vector2)" />
    public void SetZoom(Vector2 @zoom) => ((Camera2D)_host).SetZoom(@zoom);

    /// <inheritdoc cref="Camera2D.GetZoom()" />
    public Vector2 GetZoom() => ((Camera2D)_host).GetZoom();

    /// <inheritdoc cref="Camera2D.SetCustomViewport(Node)" />
    public void SetCustomViewport(Node @viewport) => ((Camera2D)_host).SetCustomViewport(@viewport);

    /// <inheritdoc cref="Camera2D.GetCustomViewport()" />
    public Node GetCustomViewport() => ((Camera2D)_host).GetCustomViewport();

    /// <inheritdoc cref="Camera2D.SetPositionSmoothingSpeed(float)" />
    public void SetPositionSmoothingSpeed(float @positionSmoothingSpeed) => ((Camera2D)_host).SetPositionSmoothingSpeed(@positionSmoothingSpeed);

    /// <inheritdoc cref="Camera2D.GetPositionSmoothingSpeed()" />
    public float GetPositionSmoothingSpeed() => ((Camera2D)_host).GetPositionSmoothingSpeed();

    /// <inheritdoc cref="Camera2D.SetPositionSmoothingEnabled(bool)" />
    public void SetPositionSmoothingEnabled(bool @enabled) => ((Camera2D)_host).SetPositionSmoothingEnabled(@enabled);

    /// <inheritdoc cref="Camera2D.IsPositionSmoothingEnabled()" />
    public bool IsPositionSmoothingEnabled() => ((Camera2D)_host).IsPositionSmoothingEnabled();

    /// <inheritdoc cref="Camera2D.SetRotationSmoothingEnabled(bool)" />
    public void SetRotationSmoothingEnabled(bool @enabled) => ((Camera2D)_host).SetRotationSmoothingEnabled(@enabled);

    /// <inheritdoc cref="Camera2D.IsRotationSmoothingEnabled()" />
    public bool IsRotationSmoothingEnabled() => ((Camera2D)_host).IsRotationSmoothingEnabled();

    /// <inheritdoc cref="Camera2D.SetRotationSmoothingSpeed(float)" />
    public void SetRotationSmoothingSpeed(float @speed) => ((Camera2D)_host).SetRotationSmoothingSpeed(@speed);

    /// <inheritdoc cref="Camera2D.GetRotationSmoothingSpeed()" />
    public float GetRotationSmoothingSpeed() => ((Camera2D)_host).GetRotationSmoothingSpeed();

    /// <inheritdoc cref="Camera2D.ForceUpdateScroll()" />
    public void ForceUpdateScroll() => ((Camera2D)_host).ForceUpdateScroll();

    /// <inheritdoc cref="Camera2D.ResetSmoothing()" />
    public void ResetSmoothing() => ((Camera2D)_host).ResetSmoothing();

    /// <inheritdoc cref="Camera2D.Align()" />
    public void Align() => ((Camera2D)_host).Align();

    /// <inheritdoc cref="Camera2D.SetScreenDrawingEnabled(bool)" />
    public void SetScreenDrawingEnabled(bool @screenDrawingEnabled) => ((Camera2D)_host).SetScreenDrawingEnabled(@screenDrawingEnabled);

    /// <inheritdoc cref="Camera2D.IsScreenDrawingEnabled()" />
    public bool IsScreenDrawingEnabled() => ((Camera2D)_host).IsScreenDrawingEnabled();

    /// <inheritdoc cref="Camera2D.SetLimitDrawingEnabled(bool)" />
    public void SetLimitDrawingEnabled(bool @limitDrawingEnabled) => ((Camera2D)_host).SetLimitDrawingEnabled(@limitDrawingEnabled);

    /// <inheritdoc cref="Camera2D.IsLimitDrawingEnabled()" />
    public bool IsLimitDrawingEnabled() => ((Camera2D)_host).IsLimitDrawingEnabled();

    /// <inheritdoc cref="Camera2D.SetMarginDrawingEnabled(bool)" />
    public void SetMarginDrawingEnabled(bool @marginDrawingEnabled) => ((Camera2D)_host).SetMarginDrawingEnabled(@marginDrawingEnabled);

    /// <inheritdoc cref="Camera2D.IsMarginDrawingEnabled()" />
    public bool IsMarginDrawingEnabled() => ((Camera2D)_host).IsMarginDrawingEnabled();

}
