#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesAttractor3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesAttractor3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="GpuParticlesAttractor3D.SetCullMask(uint)" />
    public void SetCullMask(uint @mask) => ((GpuParticlesAttractor3D)_host).SetCullMask(@mask);

    /// <inheritdoc cref="GpuParticlesAttractor3D.GetCullMask()" />
    public uint GetCullMask() => ((GpuParticlesAttractor3D)_host).GetCullMask();

    /// <inheritdoc cref="GpuParticlesAttractor3D.SetStrength(float)" />
    public void SetStrength(float @strength) => ((GpuParticlesAttractor3D)_host).SetStrength(@strength);

    /// <inheritdoc cref="GpuParticlesAttractor3D.GetStrength()" />
    public float GetStrength() => ((GpuParticlesAttractor3D)_host).GetStrength();

    /// <inheritdoc cref="GpuParticlesAttractor3D.SetAttenuation(float)" />
    public void SetAttenuation(float @attenuation) => ((GpuParticlesAttractor3D)_host).SetAttenuation(@attenuation);

    /// <inheritdoc cref="GpuParticlesAttractor3D.GetAttenuation()" />
    public float GetAttenuation() => ((GpuParticlesAttractor3D)_host).GetAttenuation();

    /// <inheritdoc cref="GpuParticlesAttractor3D.SetDirectionality(float)" />
    public void SetDirectionality(float @amount) => ((GpuParticlesAttractor3D)_host).SetDirectionality(@amount);

    /// <inheritdoc cref="GpuParticlesAttractor3D.GetDirectionality()" />
    public float GetDirectionality() => ((GpuParticlesAttractor3D)_host).GetDirectionality();

}
