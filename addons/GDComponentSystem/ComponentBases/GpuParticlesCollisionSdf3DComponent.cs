#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesCollisionSdf3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesCollisionSdf3DComponent : GpuParticlesCollision3DComponent
{

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((GpuParticlesCollisionSdf3D)_host).SetSize(@size);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetSize()" />
    public Vector3 GetSize() => ((GpuParticlesCollisionSdf3D)_host).GetSize();

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetResolution(GpuParticlesCollisionSdf3D.ResolutionEnum)" />
    public void SetResolution(GpuParticlesCollisionSdf3D.ResolutionEnum @resolution) => ((GpuParticlesCollisionSdf3D)_host).SetResolution(@resolution);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetResolution()" />
    public GpuParticlesCollisionSdf3D.ResolutionEnum GetResolution() => ((GpuParticlesCollisionSdf3D)_host).GetResolution();

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetTexture(Texture3D)" />
    public void SetTexture(Texture3D @texture) => ((GpuParticlesCollisionSdf3D)_host).SetTexture(@texture);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetTexture()" />
    public Texture3D GetTexture() => ((GpuParticlesCollisionSdf3D)_host).GetTexture();

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetThickness(float)" />
    public void SetThickness(float @thickness) => ((GpuParticlesCollisionSdf3D)_host).SetThickness(@thickness);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetThickness()" />
    public float GetThickness() => ((GpuParticlesCollisionSdf3D)_host).GetThickness();

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetBakeMask(uint)" />
    public void SetBakeMask(uint @mask) => ((GpuParticlesCollisionSdf3D)_host).SetBakeMask(@mask);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetBakeMask()" />
    public uint GetBakeMask() => ((GpuParticlesCollisionSdf3D)_host).GetBakeMask();

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.SetBakeMaskValue(int, bool)" />
    public void SetBakeMaskValue(int @layerNumber, bool @value) => ((GpuParticlesCollisionSdf3D)_host).SetBakeMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="GpuParticlesCollisionSdf3D.GetBakeMaskValue(int)" />
    public bool GetBakeMaskValue(int @layerNumber) => ((GpuParticlesCollisionSdf3D)_host).GetBakeMaskValue(@layerNumber);

}
