#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="XRFaceModifier3D" />
[Tool, GlobalClass]
public abstract partial class XRFaceModifier3DComponent : Node3DComponent
{

    /// <inheritdoc cref="XRFaceModifier3D.SetFaceTracker(StringName)" />
    public void SetFaceTracker(StringName @trackerName) => ((XRFaceModifier3D)_host).SetFaceTracker(@trackerName);

    /// <inheritdoc cref="XRFaceModifier3D.GetFaceTracker()" />
    public StringName GetFaceTracker() => ((XRFaceModifier3D)_host).GetFaceTracker();

    /// <inheritdoc cref="XRFaceModifier3D.SetTarget(NodePath)" />
    public void SetTarget(NodePath @target) => ((XRFaceModifier3D)_host).SetTarget(@target);

    /// <inheritdoc cref="XRFaceModifier3D.GetTarget()" />
    public NodePath GetTarget() => ((XRFaceModifier3D)_host).GetTarget();

}
