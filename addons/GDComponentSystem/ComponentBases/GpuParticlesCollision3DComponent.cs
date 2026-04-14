#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesCollision3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesCollision3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="GpuParticlesCollision3D.SetCullMask(uint)" />
    public void SetCullMask(uint @mask) => ((GpuParticlesCollision3D)_host).SetCullMask(@mask);

    /// <inheritdoc cref="GpuParticlesCollision3D.GetCullMask()" />
    public uint GetCullMask() => ((GpuParticlesCollision3D)_host).GetCullMask();

}
