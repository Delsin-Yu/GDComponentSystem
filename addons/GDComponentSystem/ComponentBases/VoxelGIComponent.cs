#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VoxelGI" />
[Tool, GlobalClass]
public abstract partial class VoxelGIComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="VoxelGI.SetProbeData(VoxelGIData)" />
    public void SetProbeData(VoxelGIData @data) => ((VoxelGI)_host).SetProbeData(@data);

    /// <inheritdoc cref="VoxelGI.GetProbeData()" />
    public VoxelGIData GetProbeData() => ((VoxelGI)_host).GetProbeData();

    /// <inheritdoc cref="VoxelGI.SetSubdiv(VoxelGI.SubdivEnum)" />
    public void SetSubdiv(VoxelGI.SubdivEnum @subdiv) => ((VoxelGI)_host).SetSubdiv(@subdiv);

    /// <inheritdoc cref="VoxelGI.GetSubdiv()" />
    public VoxelGI.SubdivEnum GetSubdiv() => ((VoxelGI)_host).GetSubdiv();

    /// <inheritdoc cref="VoxelGI.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((VoxelGI)_host).SetSize(@size);

    /// <inheritdoc cref="VoxelGI.GetSize()" />
    public Vector3 GetSize() => ((VoxelGI)_host).GetSize();

    /// <inheritdoc cref="VoxelGI.SetCameraAttributes(CameraAttributes)" />
    public void SetCameraAttributes(CameraAttributes @cameraAttributes) => ((VoxelGI)_host).SetCameraAttributes(@cameraAttributes);

    /// <inheritdoc cref="VoxelGI.GetCameraAttributes()" />
    public CameraAttributes GetCameraAttributes() => ((VoxelGI)_host).GetCameraAttributes();

    /// <inheritdoc cref="VoxelGI.Bake(Node, bool)" />
    public void Bake(Node @fromNode, bool @createVisualDebug) => ((VoxelGI)_host).Bake(@fromNode, @createVisualDebug);

    /// <inheritdoc cref="VoxelGI.DebugBake()" />
    public void DebugBake() => ((VoxelGI)_host).DebugBake();

}
