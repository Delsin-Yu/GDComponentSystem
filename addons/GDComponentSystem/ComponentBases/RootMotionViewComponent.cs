#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RootMotionView" />
[Tool, GlobalClass]
public abstract partial class RootMotionViewComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="RootMotionView.SetAnimationPath(NodePath)" />
    public void SetAnimationPath(NodePath @path) => ((RootMotionView)_host).SetAnimationPath(@path);

    /// <inheritdoc cref="RootMotionView.GetAnimationPath()" />
    public NodePath GetAnimationPath() => ((RootMotionView)_host).GetAnimationPath();

    /// <inheritdoc cref="RootMotionView.SetColor(Color)" />
    public void SetColor(Color @color) => ((RootMotionView)_host).SetColor(@color);

    /// <inheritdoc cref="RootMotionView.GetColor()" />
    public Color GetColor() => ((RootMotionView)_host).GetColor();

    /// <inheritdoc cref="RootMotionView.SetCellSize(float)" />
    public void SetCellSize(float @size) => ((RootMotionView)_host).SetCellSize(@size);

    /// <inheritdoc cref="RootMotionView.GetCellSize()" />
    public float GetCellSize() => ((RootMotionView)_host).GetCellSize();

    /// <inheritdoc cref="RootMotionView.SetRadius(float)" />
    public void SetRadius(float @size) => ((RootMotionView)_host).SetRadius(@size);

    /// <inheritdoc cref="RootMotionView.GetRadius()" />
    public float GetRadius() => ((RootMotionView)_host).GetRadius();

    /// <inheritdoc cref="RootMotionView.SetZeroY(bool)" />
    public void SetZeroY(bool @enable) => ((RootMotionView)_host).SetZeroY(@enable);

    /// <inheritdoc cref="RootMotionView.GetZeroY()" />
    public bool GetZeroY() => ((RootMotionView)_host).GetZeroY();

}
