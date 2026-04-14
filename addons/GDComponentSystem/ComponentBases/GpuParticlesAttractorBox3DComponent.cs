#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesAttractorBox3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesAttractorBox3DComponent : GpuParticlesAttractor3DComponent
{

    /// <inheritdoc cref="GpuParticlesAttractorBox3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((GpuParticlesAttractorBox3D)_host).SetSize(@size);

    /// <inheritdoc cref="GpuParticlesAttractorBox3D.GetSize()" />
    public Vector3 GetSize() => ((GpuParticlesAttractorBox3D)_host).GetSize();

}
