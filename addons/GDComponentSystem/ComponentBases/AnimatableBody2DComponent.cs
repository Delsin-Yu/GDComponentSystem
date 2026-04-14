#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimatableBody2D" />
[Tool, GlobalClass]
public abstract partial class AnimatableBody2DComponent : StaticBody2DComponent
{

    /// <inheritdoc cref="AnimatableBody2D.SetSyncToPhysics(bool)" />
    public void SetSyncToPhysics(bool @enable) => ((AnimatableBody2D)_host).SetSyncToPhysics(@enable);

    /// <inheritdoc cref="AnimatableBody2D.IsSyncToPhysicsEnabled()" />
    public bool IsSyncToPhysicsEnabled() => ((AnimatableBody2D)_host).IsSyncToPhysicsEnabled();

}
