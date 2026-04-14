#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesCollisionSphere3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesCollisionSphere3DComponent : GpuParticlesCollision3DComponent
{

    /// <inheritdoc cref="GpuParticlesCollisionSphere3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((GpuParticlesCollisionSphere3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="GpuParticlesCollisionSphere3D.GetRadius()" />
    public float GetRadius() => ((GpuParticlesCollisionSphere3D)_host).GetRadius();

}
