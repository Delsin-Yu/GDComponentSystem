#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="StaticBody3D" />
[Tool, GlobalClass]
public abstract partial class StaticBody3DComponent : PhysicsBody3DComponent
{

    /// <inheritdoc cref="StaticBody3D.SetConstantLinearVelocity(Vector3)" />
    public void SetConstantLinearVelocity(Vector3 @vel) => ((StaticBody3D)_host).SetConstantLinearVelocity(@vel);

    /// <inheritdoc cref="StaticBody3D.SetConstantAngularVelocity(Vector3)" />
    public void SetConstantAngularVelocity(Vector3 @vel) => ((StaticBody3D)_host).SetConstantAngularVelocity(@vel);

    /// <inheritdoc cref="StaticBody3D.GetConstantLinearVelocity()" />
    public Vector3 GetConstantLinearVelocity() => ((StaticBody3D)_host).GetConstantLinearVelocity();

    /// <inheritdoc cref="StaticBody3D.GetConstantAngularVelocity()" />
    public Vector3 GetConstantAngularVelocity() => ((StaticBody3D)_host).GetConstantAngularVelocity();

    /// <inheritdoc cref="StaticBody3D.SetPhysicsMaterialOverride(PhysicsMaterial)" />
    public void SetPhysicsMaterialOverride(PhysicsMaterial @physicsMaterialOverride) => ((StaticBody3D)_host).SetPhysicsMaterialOverride(@physicsMaterialOverride);

    /// <inheritdoc cref="StaticBody3D.GetPhysicsMaterialOverride()" />
    public PhysicsMaterial GetPhysicsMaterialOverride() => ((StaticBody3D)_host).GetPhysicsMaterialOverride();

}
