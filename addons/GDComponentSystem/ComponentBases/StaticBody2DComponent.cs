#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="StaticBody2D" />
[Tool, GlobalClass]
public abstract partial class StaticBody2DComponent : PhysicsBody2DComponent
{

    /// <inheritdoc cref="StaticBody2D.SetConstantLinearVelocity(Vector2)" />
    public void SetConstantLinearVelocity(Vector2 @vel) => ((StaticBody2D)_host).SetConstantLinearVelocity(@vel);

    /// <inheritdoc cref="StaticBody2D.SetConstantAngularVelocity(float)" />
    public void SetConstantAngularVelocity(float @vel) => ((StaticBody2D)_host).SetConstantAngularVelocity(@vel);

    /// <inheritdoc cref="StaticBody2D.GetConstantLinearVelocity()" />
    public Vector2 GetConstantLinearVelocity() => ((StaticBody2D)_host).GetConstantLinearVelocity();

    /// <inheritdoc cref="StaticBody2D.GetConstantAngularVelocity()" />
    public float GetConstantAngularVelocity() => ((StaticBody2D)_host).GetConstantAngularVelocity();

    /// <inheritdoc cref="StaticBody2D.SetPhysicsMaterialOverride(PhysicsMaterial)" />
    public void SetPhysicsMaterialOverride(PhysicsMaterial @physicsMaterialOverride) => ((StaticBody2D)_host).SetPhysicsMaterialOverride(@physicsMaterialOverride);

    /// <inheritdoc cref="StaticBody2D.GetPhysicsMaterialOverride()" />
    public PhysicsMaterial GetPhysicsMaterialOverride() => ((StaticBody2D)_host).GetPhysicsMaterialOverride();

}
