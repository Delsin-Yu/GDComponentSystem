#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ImporterMeshInstance3D" />
[Tool, GlobalClass]
public abstract partial class ImporterMeshInstance3DComponent : Node3DComponent
{

    /// <inheritdoc cref="ImporterMeshInstance3D.SetMesh(ImporterMesh)" />
    public void SetMesh(ImporterMesh @mesh) => ((ImporterMeshInstance3D)_host).SetMesh(@mesh);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetMesh()" />
    public ImporterMesh GetMesh() => ((ImporterMeshInstance3D)_host).GetMesh();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetSkin(Skin)" />
    public void SetSkin(Skin @skin) => ((ImporterMeshInstance3D)_host).SetSkin(@skin);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetSkin()" />
    public Skin GetSkin() => ((ImporterMeshInstance3D)_host).GetSkin();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetSkeletonPath(NodePath)" />
    public void SetSkeletonPath(NodePath @skeletonPath) => ((ImporterMeshInstance3D)_host).SetSkeletonPath(@skeletonPath);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetSkeletonPath()" />
    public NodePath GetSkeletonPath() => ((ImporterMeshInstance3D)_host).GetSkeletonPath();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetLayerMask(uint)" />
    public void SetLayerMask(uint @layerMask) => ((ImporterMeshInstance3D)_host).SetLayerMask(@layerMask);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetLayerMask()" />
    public uint GetLayerMask() => ((ImporterMeshInstance3D)_host).GetLayerMask();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetCastShadowsSetting(GeometryInstance3D.ShadowCastingSetting)" />
    public void SetCastShadowsSetting(GeometryInstance3D.ShadowCastingSetting @shadowCastingSetting) => ((ImporterMeshInstance3D)_host).SetCastShadowsSetting(@shadowCastingSetting);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetCastShadowsSetting()" />
    public GeometryInstance3D.ShadowCastingSetting GetCastShadowsSetting() => ((ImporterMeshInstance3D)_host).GetCastShadowsSetting();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetVisibilityRangeEndMargin(float)" />
    public void SetVisibilityRangeEndMargin(float @distance) => ((ImporterMeshInstance3D)_host).SetVisibilityRangeEndMargin(@distance);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetVisibilityRangeEndMargin()" />
    public float GetVisibilityRangeEndMargin() => ((ImporterMeshInstance3D)_host).GetVisibilityRangeEndMargin();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetVisibilityRangeEnd(float)" />
    public void SetVisibilityRangeEnd(float @distance) => ((ImporterMeshInstance3D)_host).SetVisibilityRangeEnd(@distance);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetVisibilityRangeEnd()" />
    public float GetVisibilityRangeEnd() => ((ImporterMeshInstance3D)_host).GetVisibilityRangeEnd();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetVisibilityRangeBeginMargin(float)" />
    public void SetVisibilityRangeBeginMargin(float @distance) => ((ImporterMeshInstance3D)_host).SetVisibilityRangeBeginMargin(@distance);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetVisibilityRangeBeginMargin()" />
    public float GetVisibilityRangeBeginMargin() => ((ImporterMeshInstance3D)_host).GetVisibilityRangeBeginMargin();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetVisibilityRangeBegin(float)" />
    public void SetVisibilityRangeBegin(float @distance) => ((ImporterMeshInstance3D)_host).SetVisibilityRangeBegin(@distance);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetVisibilityRangeBegin()" />
    public float GetVisibilityRangeBegin() => ((ImporterMeshInstance3D)_host).GetVisibilityRangeBegin();

    /// <inheritdoc cref="ImporterMeshInstance3D.SetVisibilityRangeFadeMode(GeometryInstance3D.VisibilityRangeFadeModeEnum)" />
    public void SetVisibilityRangeFadeMode(GeometryInstance3D.VisibilityRangeFadeModeEnum @mode) => ((ImporterMeshInstance3D)_host).SetVisibilityRangeFadeMode(@mode);

    /// <inheritdoc cref="ImporterMeshInstance3D.GetVisibilityRangeFadeMode()" />
    public GeometryInstance3D.VisibilityRangeFadeModeEnum GetVisibilityRangeFadeMode() => ((ImporterMeshInstance3D)_host).GetVisibilityRangeFadeMode();

}
