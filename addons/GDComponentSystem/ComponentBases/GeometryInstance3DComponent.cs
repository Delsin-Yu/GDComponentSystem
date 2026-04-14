#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GeometryInstance3D" />
[Tool, GlobalClass]
public abstract partial class GeometryInstance3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="GeometryInstance3D.SetMaterialOverride(Material)" />
    public void SetMaterialOverride(Material @material) => ((GeometryInstance3D)_host).SetMaterialOverride(@material);

    /// <inheritdoc cref="GeometryInstance3D.GetMaterialOverride()" />
    public Material GetMaterialOverride() => ((GeometryInstance3D)_host).GetMaterialOverride();

    /// <inheritdoc cref="GeometryInstance3D.SetMaterialOverlay(Material)" />
    public void SetMaterialOverlay(Material @material) => ((GeometryInstance3D)_host).SetMaterialOverlay(@material);

    /// <inheritdoc cref="GeometryInstance3D.GetMaterialOverlay()" />
    public Material GetMaterialOverlay() => ((GeometryInstance3D)_host).GetMaterialOverlay();

    /// <inheritdoc cref="GeometryInstance3D.SetCastShadowsSetting(GeometryInstance3D.ShadowCastingSetting)" />
    public void SetCastShadowsSetting(GeometryInstance3D.ShadowCastingSetting @shadowCastingSetting) => ((GeometryInstance3D)_host).SetCastShadowsSetting(@shadowCastingSetting);

    /// <inheritdoc cref="GeometryInstance3D.GetCastShadowsSetting()" />
    public GeometryInstance3D.ShadowCastingSetting GetCastShadowsSetting() => ((GeometryInstance3D)_host).GetCastShadowsSetting();

    /// <inheritdoc cref="GeometryInstance3D.SetLodBias(float)" />
    public void SetLodBias(float @bias) => ((GeometryInstance3D)_host).SetLodBias(@bias);

    /// <inheritdoc cref="GeometryInstance3D.GetLodBias()" />
    public float GetLodBias() => ((GeometryInstance3D)_host).GetLodBias();

    /// <inheritdoc cref="GeometryInstance3D.SetTransparency(float)" />
    public void SetTransparency(float @transparency) => ((GeometryInstance3D)_host).SetTransparency(@transparency);

    /// <inheritdoc cref="GeometryInstance3D.GetTransparency()" />
    public float GetTransparency() => ((GeometryInstance3D)_host).GetTransparency();

    /// <inheritdoc cref="GeometryInstance3D.SetVisibilityRangeEndMargin(float)" />
    public void SetVisibilityRangeEndMargin(float @distance) => ((GeometryInstance3D)_host).SetVisibilityRangeEndMargin(@distance);

    /// <inheritdoc cref="GeometryInstance3D.GetVisibilityRangeEndMargin()" />
    public float GetVisibilityRangeEndMargin() => ((GeometryInstance3D)_host).GetVisibilityRangeEndMargin();

    /// <inheritdoc cref="GeometryInstance3D.SetVisibilityRangeEnd(float)" />
    public void SetVisibilityRangeEnd(float @distance) => ((GeometryInstance3D)_host).SetVisibilityRangeEnd(@distance);

    /// <inheritdoc cref="GeometryInstance3D.GetVisibilityRangeEnd()" />
    public float GetVisibilityRangeEnd() => ((GeometryInstance3D)_host).GetVisibilityRangeEnd();

    /// <inheritdoc cref="GeometryInstance3D.SetVisibilityRangeBeginMargin(float)" />
    public void SetVisibilityRangeBeginMargin(float @distance) => ((GeometryInstance3D)_host).SetVisibilityRangeBeginMargin(@distance);

    /// <inheritdoc cref="GeometryInstance3D.GetVisibilityRangeBeginMargin()" />
    public float GetVisibilityRangeBeginMargin() => ((GeometryInstance3D)_host).GetVisibilityRangeBeginMargin();

    /// <inheritdoc cref="GeometryInstance3D.SetVisibilityRangeBegin(float)" />
    public void SetVisibilityRangeBegin(float @distance) => ((GeometryInstance3D)_host).SetVisibilityRangeBegin(@distance);

    /// <inheritdoc cref="GeometryInstance3D.GetVisibilityRangeBegin()" />
    public float GetVisibilityRangeBegin() => ((GeometryInstance3D)_host).GetVisibilityRangeBegin();

    /// <inheritdoc cref="GeometryInstance3D.SetVisibilityRangeFadeMode(GeometryInstance3D.VisibilityRangeFadeModeEnum)" />
    public void SetVisibilityRangeFadeMode(GeometryInstance3D.VisibilityRangeFadeModeEnum @mode) => ((GeometryInstance3D)_host).SetVisibilityRangeFadeMode(@mode);

    /// <inheritdoc cref="GeometryInstance3D.GetVisibilityRangeFadeMode()" />
    public GeometryInstance3D.VisibilityRangeFadeModeEnum GetVisibilityRangeFadeMode() => ((GeometryInstance3D)_host).GetVisibilityRangeFadeMode();

    /// <inheritdoc cref="GeometryInstance3D.SetInstanceShaderParameter(StringName, Variant)" />
    public void SetInstanceShaderParameter(StringName @name, Variant @value) => ((GeometryInstance3D)_host).SetInstanceShaderParameter(@name, @value);

    /// <inheritdoc cref="GeometryInstance3D.GetInstanceShaderParameter(StringName)" />
    public Variant GetInstanceShaderParameter(StringName @name) => ((GeometryInstance3D)_host).GetInstanceShaderParameter(@name);

    /// <inheritdoc cref="GeometryInstance3D.SetExtraCullMargin(float)" />
    public void SetExtraCullMargin(float @margin) => ((GeometryInstance3D)_host).SetExtraCullMargin(@margin);

    /// <inheritdoc cref="GeometryInstance3D.GetExtraCullMargin()" />
    public float GetExtraCullMargin() => ((GeometryInstance3D)_host).GetExtraCullMargin();

    /// <inheritdoc cref="GeometryInstance3D.SetLightmapTexelScale(float)" />
    public void SetLightmapTexelScale(float @scale) => ((GeometryInstance3D)_host).SetLightmapTexelScale(@scale);

    /// <inheritdoc cref="GeometryInstance3D.GetLightmapTexelScale()" />
    public float GetLightmapTexelScale() => ((GeometryInstance3D)_host).GetLightmapTexelScale();

    /// <inheritdoc cref="GeometryInstance3D.SetLightmapScale(GeometryInstance3D.LightmapScale)" />
    public void SetLightmapScale(GeometryInstance3D.LightmapScale @scale) => ((GeometryInstance3D)_host).SetLightmapScale(@scale);

    /// <inheritdoc cref="GeometryInstance3D.GetLightmapScale()" />
    public GeometryInstance3D.LightmapScale GetLightmapScale() => ((GeometryInstance3D)_host).GetLightmapScale();

    /// <inheritdoc cref="GeometryInstance3D.SetGIMode(GeometryInstance3D.GIModeEnum)" />
    public void SetGIMode(GeometryInstance3D.GIModeEnum @mode) => ((GeometryInstance3D)_host).SetGIMode(@mode);

    /// <inheritdoc cref="GeometryInstance3D.GetGIMode()" />
    public GeometryInstance3D.GIModeEnum GetGIMode() => ((GeometryInstance3D)_host).GetGIMode();

    /// <inheritdoc cref="GeometryInstance3D.SetIgnoreOcclusionCulling(bool)" />
    public void SetIgnoreOcclusionCulling(bool @ignoreCulling) => ((GeometryInstance3D)_host).SetIgnoreOcclusionCulling(@ignoreCulling);

    /// <inheritdoc cref="GeometryInstance3D.IsIgnoringOcclusionCulling()" />
    public bool IsIgnoringOcclusionCulling() => ((GeometryInstance3D)_host).IsIgnoringOcclusionCulling();

    /// <inheritdoc cref="GeometryInstance3D.SetCustomAabb(Aabb)" />
    public void SetCustomAabb(Aabb @aabb) => ((GeometryInstance3D)_host).SetCustomAabb(@aabb);

    /// <inheritdoc cref="GeometryInstance3D.GetCustomAabb()" />
    public Aabb GetCustomAabb() => ((GeometryInstance3D)_host).GetCustomAabb();

}
