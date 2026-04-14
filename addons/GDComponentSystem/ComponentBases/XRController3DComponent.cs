#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRController3D" />
[Tool, GlobalClass]
public abstract partial class XRController3DComponent : XRNode3DComponent
{

    /// <inheritdoc cref="XRController3D.IsButtonPressed(StringName)" />
    public bool IsButtonPressed(StringName @name) => ((XRController3D)_host).IsButtonPressed(@name);

    /// <inheritdoc cref="XRController3D.GetInput(StringName)" />
    public Variant GetInput(StringName @name) => ((XRController3D)_host).GetInput(@name);

    /// <inheritdoc cref="XRController3D.GetFloat(StringName)" />
    public float GetFloat(StringName @name) => ((XRController3D)_host).GetFloat(@name);

    /// <inheritdoc cref="XRController3D.GetVector2(StringName)" />
    public Vector2 GetVector2(StringName @name) => ((XRController3D)_host).GetVector2(@name);

    /// <inheritdoc cref="XRController3D.GetTrackerHand()" />
    public XRPositionalTracker.TrackerHand GetTrackerHand() => ((XRController3D)_host).GetTrackerHand();

}
