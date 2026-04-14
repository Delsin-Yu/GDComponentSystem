#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesCollisionBox3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesCollisionBox3DComponent : GpuParticlesCollision3DComponent
{

    /// <inheritdoc cref="GpuParticlesCollisionBox3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((GpuParticlesCollisionBox3D)_host).SetSize(@size);

    /// <inheritdoc cref="GpuParticlesCollisionBox3D.GetSize()" />
    public Vector3 GetSize() => ((GpuParticlesCollisionBox3D)_host).GetSize();

}
