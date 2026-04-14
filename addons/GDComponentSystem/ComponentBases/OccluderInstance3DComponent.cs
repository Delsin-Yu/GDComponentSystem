#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OccluderInstance3D" />
[Tool, GlobalClass]
public abstract partial class OccluderInstance3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="OccluderInstance3D.SetBakeMask(uint)" />
    public void SetBakeMask(uint @mask) => ((OccluderInstance3D)_host).SetBakeMask(@mask);

    /// <inheritdoc cref="OccluderInstance3D.GetBakeMask()" />
    public uint GetBakeMask() => ((OccluderInstance3D)_host).GetBakeMask();

    /// <inheritdoc cref="OccluderInstance3D.SetBakeMaskValue(int, bool)" />
    public void SetBakeMaskValue(int @layerNumber, bool @value) => ((OccluderInstance3D)_host).SetBakeMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="OccluderInstance3D.GetBakeMaskValue(int)" />
    public bool GetBakeMaskValue(int @layerNumber) => ((OccluderInstance3D)_host).GetBakeMaskValue(@layerNumber);

    /// <inheritdoc cref="OccluderInstance3D.SetBakeSimplificationDistance(float)" />
    public void SetBakeSimplificationDistance(float @simplificationDistance) => ((OccluderInstance3D)_host).SetBakeSimplificationDistance(@simplificationDistance);

    /// <inheritdoc cref="OccluderInstance3D.GetBakeSimplificationDistance()" />
    public float GetBakeSimplificationDistance() => ((OccluderInstance3D)_host).GetBakeSimplificationDistance();

    /// <inheritdoc cref="OccluderInstance3D.SetOccluder(Occluder3D)" />
    public void SetOccluder(Occluder3D @occluder) => ((OccluderInstance3D)_host).SetOccluder(@occluder);

    /// <inheritdoc cref="OccluderInstance3D.GetOccluder()" />
    public Occluder3D GetOccluder() => ((OccluderInstance3D)_host).GetOccluder();

}
