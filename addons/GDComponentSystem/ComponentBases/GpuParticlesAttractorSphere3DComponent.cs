#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesAttractorSphere3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesAttractorSphere3DComponent : GpuParticlesAttractor3DComponent
{

    /// <inheritdoc cref="GpuParticlesAttractorSphere3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((GpuParticlesAttractorSphere3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="GpuParticlesAttractorSphere3D.GetRadius()" />
    public float GetRadius() => ((GpuParticlesAttractorSphere3D)_host).GetRadius();

}
