#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CanvasLayer" />
[Tool, GlobalClass]
public abstract partial class CanvasLayerComponent : NodeComponent
{

    /// <inheritdoc cref="CanvasLayer.SetLayer(int)" />
    public void SetLayer(int @layer) => ((CanvasLayer)_host).SetLayer(@layer);

    /// <inheritdoc cref="CanvasLayer.GetLayer()" />
    public int GetLayer() => ((CanvasLayer)_host).GetLayer();

    /// <inheritdoc cref="CanvasLayer.SetVisible(bool)" />
    public void SetVisible(bool @visible) => ((CanvasLayer)_host).SetVisible(@visible);

    /// <inheritdoc cref="CanvasLayer.IsVisible()" />
    public bool IsVisible() => ((CanvasLayer)_host).IsVisible();

    /// <inheritdoc cref="CanvasLayer.Show()" />
    public void Show() => ((CanvasLayer)_host).Show();

    /// <inheritdoc cref="CanvasLayer.Hide()" />
    public void Hide() => ((CanvasLayer)_host).Hide();

    /// <inheritdoc cref="CanvasLayer.SetTransform(Transform2D)" />
    public void SetTransform(Transform2D @transform) => ((CanvasLayer)_host).SetTransform(@transform);

    /// <inheritdoc cref="CanvasLayer.GetTransform()" />
    public Transform2D GetTransform() => ((CanvasLayer)_host).GetTransform();

    /// <inheritdoc cref="CanvasLayer.GetFinalTransform()" />
    public Transform2D GetFinalTransform() => ((CanvasLayer)_host).GetFinalTransform();

    /// <inheritdoc cref="CanvasLayer.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((CanvasLayer)_host).SetOffset(@offset);

    /// <inheritdoc cref="CanvasLayer.GetOffset()" />
    public Vector2 GetOffset() => ((CanvasLayer)_host).GetOffset();

    /// <inheritdoc cref="CanvasLayer.SetRotation(float)" />
    public void SetRotation(float @radians) => ((CanvasLayer)_host).SetRotation(@radians);

    /// <inheritdoc cref="CanvasLayer.GetRotation()" />
    public float GetRotation() => ((CanvasLayer)_host).GetRotation();

    /// <inheritdoc cref="CanvasLayer.SetScale(Vector2)" />
    public void SetScale(Vector2 @scale) => ((CanvasLayer)_host).SetScale(@scale);

    /// <inheritdoc cref="CanvasLayer.GetScale()" />
    public Vector2 GetScale() => ((CanvasLayer)_host).GetScale();

    /// <inheritdoc cref="CanvasLayer.SetFollowViewport(bool)" />
    public void SetFollowViewport(bool @enable) => ((CanvasLayer)_host).SetFollowViewport(@enable);

    /// <inheritdoc cref="CanvasLayer.IsFollowingViewport()" />
    public bool IsFollowingViewport() => ((CanvasLayer)_host).IsFollowingViewport();

    /// <inheritdoc cref="CanvasLayer.SetFollowViewportScale(float)" />
    public void SetFollowViewportScale(float @scale) => ((CanvasLayer)_host).SetFollowViewportScale(@scale);

    /// <inheritdoc cref="CanvasLayer.GetFollowViewportScale()" />
    public float GetFollowViewportScale() => ((CanvasLayer)_host).GetFollowViewportScale();

    /// <inheritdoc cref="CanvasLayer.SetCustomViewport(Node)" />
    public void SetCustomViewport(Node @viewport) => ((CanvasLayer)_host).SetCustomViewport(@viewport);

    /// <inheritdoc cref="CanvasLayer.GetCustomViewport()" />
    public Node GetCustomViewport() => ((CanvasLayer)_host).GetCustomViewport();

    /// <inheritdoc cref="CanvasLayer.GetCanvas()" />
    public Rid GetCanvas() => ((CanvasLayer)_host).GetCanvas();

}
