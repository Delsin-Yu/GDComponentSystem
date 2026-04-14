#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimatableBody3D" />
[Tool, GlobalClass]
public abstract partial class AnimatableBody3DComponent : StaticBody3DComponent
{

    /// <inheritdoc cref="AnimatableBody3D.SetSyncToPhysics(bool)" />
    public void SetSyncToPhysics(bool @enable) => ((AnimatableBody3D)_host).SetSyncToPhysics(@enable);

    /// <inheritdoc cref="AnimatableBody3D.IsSyncToPhysicsEnabled()" />
    public bool IsSyncToPhysicsEnabled() => ((AnimatableBody3D)_host).IsSyncToPhysicsEnabled();

}
