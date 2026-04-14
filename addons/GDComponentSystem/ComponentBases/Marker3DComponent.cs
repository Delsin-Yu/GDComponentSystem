#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Marker3D" />
[Tool, GlobalClass]
public abstract partial class Marker3DComponent : Node3DComponent
{

    /// <inheritdoc cref="Marker3D.SetGizmoExtents(float)" />
    public void SetGizmoExtents(float @extents) => ((Marker3D)_host).SetGizmoExtents(@extents);

    /// <inheritdoc cref="Marker3D.GetGizmoExtents()" />
    public float GetGizmoExtents() => ((Marker3D)_host).GetGizmoExtents();

}
