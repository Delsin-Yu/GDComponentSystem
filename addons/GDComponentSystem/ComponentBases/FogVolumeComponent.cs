#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="FogVolume" />
[Tool, GlobalClass]
public abstract partial class FogVolumeComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="FogVolume.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((FogVolume)_host).SetSize(@size);

    /// <inheritdoc cref="FogVolume.GetSize()" />
    public Vector3 GetSize() => ((FogVolume)_host).GetSize();

    /// <inheritdoc cref="FogVolume.SetShape(RenderingServer.FogVolumeShape)" />
    public void SetShape(RenderingServer.FogVolumeShape @shape) => ((FogVolume)_host).SetShape(@shape);

    /// <inheritdoc cref="FogVolume.GetShape()" />
    public RenderingServer.FogVolumeShape GetShape() => ((FogVolume)_host).GetShape();

    /// <inheritdoc cref="FogVolume.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((FogVolume)_host).SetMaterial(@material);

    /// <inheritdoc cref="FogVolume.GetMaterial()" />
    public Material GetMaterial() => ((FogVolume)_host).GetMaterial();

}
