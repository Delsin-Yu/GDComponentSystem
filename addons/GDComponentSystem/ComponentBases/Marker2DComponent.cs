#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Marker2D" />
[Tool, GlobalClass]
public abstract partial class Marker2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Marker2D.SetGizmoExtents(float)" />
    public void SetGizmoExtents(float @extents) => ((Marker2D)_host).SetGizmoExtents(@extents);

    /// <inheritdoc cref="Marker2D.GetGizmoExtents()" />
    public float GetGizmoExtents() => ((Marker2D)_host).GetGizmoExtents();

}
