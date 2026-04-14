#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GpuParticlesCollisionHeightField3D" />
[Tool, GlobalClass]
public abstract partial class GpuParticlesCollisionHeightField3DComponent : GpuParticlesCollision3DComponent
{

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((GpuParticlesCollisionHeightField3D)_host).SetSize(@size);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.GetSize()" />
    public Vector3 GetSize() => ((GpuParticlesCollisionHeightField3D)_host).GetSize();

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetResolution(GpuParticlesCollisionHeightField3D.ResolutionEnum)" />
    public void SetResolution(GpuParticlesCollisionHeightField3D.ResolutionEnum @resolution) => ((GpuParticlesCollisionHeightField3D)_host).SetResolution(@resolution);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.GetResolution()" />
    public GpuParticlesCollisionHeightField3D.ResolutionEnum GetResolution() => ((GpuParticlesCollisionHeightField3D)_host).GetResolution();

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetUpdateMode(GpuParticlesCollisionHeightField3D.UpdateModeEnum)" />
    public void SetUpdateMode(GpuParticlesCollisionHeightField3D.UpdateModeEnum @updateMode) => ((GpuParticlesCollisionHeightField3D)_host).SetUpdateMode(@updateMode);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.GetUpdateMode()" />
    public GpuParticlesCollisionHeightField3D.UpdateModeEnum GetUpdateMode() => ((GpuParticlesCollisionHeightField3D)_host).GetUpdateMode();

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetHeightfieldMask(uint)" />
    public void SetHeightfieldMask(uint @heightfieldMask) => ((GpuParticlesCollisionHeightField3D)_host).SetHeightfieldMask(@heightfieldMask);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.GetHeightfieldMask()" />
    public uint GetHeightfieldMask() => ((GpuParticlesCollisionHeightField3D)_host).GetHeightfieldMask();

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetHeightfieldMaskValue(int, bool)" />
    public void SetHeightfieldMaskValue(int @layerNumber, bool @value) => ((GpuParticlesCollisionHeightField3D)_host).SetHeightfieldMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.GetHeightfieldMaskValue(int)" />
    public bool GetHeightfieldMaskValue(int @layerNumber) => ((GpuParticlesCollisionHeightField3D)_host).GetHeightfieldMaskValue(@layerNumber);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.SetFollowCameraEnabled(bool)" />
    public void SetFollowCameraEnabled(bool @enabled) => ((GpuParticlesCollisionHeightField3D)_host).SetFollowCameraEnabled(@enabled);

    /// <inheritdoc cref="GpuParticlesCollisionHeightField3D.IsFollowCameraEnabled()" />
    public bool IsFollowCameraEnabled() => ((GpuParticlesCollisionHeightField3D)_host).IsFollowCameraEnabled();

}
