#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="DampedSpringJoint2D" />
[Tool, GlobalClass]
public abstract partial class DampedSpringJoint2DComponent : Joint2DComponent
{

    /// <inheritdoc cref="DampedSpringJoint2D.SetLength(float)" />
    public void SetLength(float @length) => ((DampedSpringJoint2D)_host).SetLength(@length);

    /// <inheritdoc cref="DampedSpringJoint2D.GetLength()" />
    public float GetLength() => ((DampedSpringJoint2D)_host).GetLength();

    /// <inheritdoc cref="DampedSpringJoint2D.SetRestLength(float)" />
    public void SetRestLength(float @restLength) => ((DampedSpringJoint2D)_host).SetRestLength(@restLength);

    /// <inheritdoc cref="DampedSpringJoint2D.GetRestLength()" />
    public float GetRestLength() => ((DampedSpringJoint2D)_host).GetRestLength();

    /// <inheritdoc cref="DampedSpringJoint2D.SetStiffness(float)" />
    public void SetStiffness(float @stiffness) => ((DampedSpringJoint2D)_host).SetStiffness(@stiffness);

    /// <inheritdoc cref="DampedSpringJoint2D.GetStiffness()" />
    public float GetStiffness() => ((DampedSpringJoint2D)_host).GetStiffness();

    /// <inheritdoc cref="DampedSpringJoint2D.SetDamping(float)" />
    public void SetDamping(float @damping) => ((DampedSpringJoint2D)_host).SetDamping(@damping);

    /// <inheritdoc cref="DampedSpringJoint2D.GetDamping()" />
    public float GetDamping() => ((DampedSpringJoint2D)_host).GetDamping();

}
