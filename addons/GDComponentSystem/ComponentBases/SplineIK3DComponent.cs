#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SplineIK3D" />
[Tool, GlobalClass]
public abstract partial class SplineIK3DComponent : ChainIK3DComponent
{

    /// <inheritdoc cref="SplineIK3D.SetPath3D(int, NodePath)" />
    public void SetPath3D(int @index, NodePath @path3D) => ((SplineIK3D)_host).SetPath3D(@index, @path3D);

    /// <inheritdoc cref="SplineIK3D.GetPath3D(int)" />
    public NodePath GetPath3D(int @index) => ((SplineIK3D)_host).GetPath3D(@index);

    /// <inheritdoc cref="SplineIK3D.SetTiltEnabled(int, bool)" />
    public void SetTiltEnabled(int @index, bool @enabled) => ((SplineIK3D)_host).SetTiltEnabled(@index, @enabled);

    /// <inheritdoc cref="SplineIK3D.IsTiltEnabled(int)" />
    public bool IsTiltEnabled(int @index) => ((SplineIK3D)_host).IsTiltEnabled(@index);

    /// <inheritdoc cref="SplineIK3D.SetTiltFadeIn(int, int)" />
    public void SetTiltFadeIn(int @index, int @size) => ((SplineIK3D)_host).SetTiltFadeIn(@index, @size);

    /// <inheritdoc cref="SplineIK3D.GetTiltFadeIn(int)" />
    public int GetTiltFadeIn(int @index) => ((SplineIK3D)_host).GetTiltFadeIn(@index);

    /// <inheritdoc cref="SplineIK3D.SetTiltFadeOut(int, int)" />
    public void SetTiltFadeOut(int @index, int @size) => ((SplineIK3D)_host).SetTiltFadeOut(@index, @size);

    /// <inheritdoc cref="SplineIK3D.GetTiltFadeOut(int)" />
    public int GetTiltFadeOut(int @index) => ((SplineIK3D)_host).GetTiltFadeOut(@index);

}
