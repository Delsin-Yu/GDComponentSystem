#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Path2D" />
[Tool, GlobalClass]
public abstract partial class Path2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Path2D.SetCurve(Curve2D)" />
    public void SetCurve(Curve2D @curve) => ((Path2D)_host).SetCurve(@curve);

    /// <inheritdoc cref="Path2D.GetCurve()" />
    public Curve2D GetCurve() => ((Path2D)_host).GetCurve();

}
