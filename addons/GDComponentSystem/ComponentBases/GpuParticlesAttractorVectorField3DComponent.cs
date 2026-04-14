#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesAttractorVectorField3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesAttractorVectorField3DComponent : GpuParticlesAttractor3DComponent
{

    /// <inheritdoc cref="GpuParticlesAttractorVectorField3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((GpuParticlesAttractorVectorField3D)_host).SetSize(@size);

    /// <inheritdoc cref="GpuParticlesAttractorVectorField3D.GetSize()" />
    public Vector3 GetSize() => ((GpuParticlesAttractorVectorField3D)_host).GetSize();

    /// <inheritdoc cref="GpuParticlesAttractorVectorField3D.SetTexture(Texture3D)" />
    public void SetTexture(Texture3D @texture) => ((GpuParticlesAttractorVectorField3D)_host).SetTexture(@texture);

    /// <inheritdoc cref="GpuParticlesAttractorVectorField3D.GetTexture()" />
    public Texture3D GetTexture() => ((GpuParticlesAttractorVectorField3D)_host).GetTexture();

}
