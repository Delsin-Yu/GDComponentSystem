#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Path3D" />
[Tool, GlobalClass]
public abstract partial class Path3DComponent : Node3DComponent
{

    /// <inheritdoc cref="Path3D.SetCurve(Curve3D)" />
    public void SetCurve(Curve3D @curve) => ((Path3D)_host).SetCurve(@curve);

    /// <inheritdoc cref="Path3D.GetCurve()" />
    public Curve3D GetCurve() => ((Path3D)_host).GetCurve();

    /// <inheritdoc cref="Path3D.SetDebugCustomColor(Color)" />
    public void SetDebugCustomColor(Color @debugCustomColor) => ((Path3D)_host).SetDebugCustomColor(@debugCustomColor);

    /// <inheritdoc cref="Path3D.GetDebugCustomColor()" />
    public Color GetDebugCustomColor() => ((Path3D)_host).GetDebugCustomColor();

}
