#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ReflectionProbe" />
[Tool, GlobalClass]
public abstract partial class ReflectionProbeComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="ReflectionProbe.SetIntensity(float)" />
    public void SetIntensity(float @intensity) => ((ReflectionProbe)_host).SetIntensity(@intensity);

    /// <inheritdoc cref="ReflectionProbe.GetIntensity()" />
    public float GetIntensity() => ((ReflectionProbe)_host).GetIntensity();

    /// <inheritdoc cref="ReflectionProbe.SetBlendDistance(float)" />
    public void SetBlendDistance(float @blendDistance) => ((ReflectionProbe)_host).SetBlendDistance(@blendDistance);

    /// <inheritdoc cref="ReflectionProbe.GetBlendDistance()" />
    public float GetBlendDistance() => ((ReflectionProbe)_host).GetBlendDistance();

    /// <inheritdoc cref="ReflectionProbe.SetAmbientMode(ReflectionProbe.AmbientModeEnum)" />
    public void SetAmbientMode(ReflectionProbe.AmbientModeEnum @ambient) => ((ReflectionProbe)_host).SetAmbientMode(@ambient);

    /// <inheritdoc cref="ReflectionProbe.GetAmbientMode()" />
    public ReflectionProbe.AmbientModeEnum GetAmbientMode() => ((ReflectionProbe)_host).GetAmbientMode();

    /// <inheritdoc cref="ReflectionProbe.SetAmbientColor(Color)" />
    public void SetAmbientColor(Color @ambient) => ((ReflectionProbe)_host).SetAmbientColor(@ambient);

    /// <inheritdoc cref="ReflectionProbe.GetAmbientColor()" />
    public Color GetAmbientColor() => ((ReflectionProbe)_host).GetAmbientColor();

    /// <inheritdoc cref="ReflectionProbe.SetAmbientColorEnergy(float)" />
    public void SetAmbientColorEnergy(float @ambientEnergy) => ((ReflectionProbe)_host).SetAmbientColorEnergy(@ambientEnergy);

    /// <inheritdoc cref="ReflectionProbe.GetAmbientColorEnergy()" />
    public float GetAmbientColorEnergy() => ((ReflectionProbe)_host).GetAmbientColorEnergy();

    /// <inheritdoc cref="ReflectionProbe.SetMaxDistance(float)" />
    public void SetMaxDistance(float @maxDistance) => ((ReflectionProbe)_host).SetMaxDistance(@maxDistance);

    /// <inheritdoc cref="ReflectionProbe.GetMaxDistance()" />
    public float GetMaxDistance() => ((ReflectionProbe)_host).GetMaxDistance();

    /// <inheritdoc cref="ReflectionProbe.SetMeshLodThreshold(float)" />
    public void SetMeshLodThreshold(float @ratio) => ((ReflectionProbe)_host).SetMeshLodThreshold(@ratio);

    /// <inheritdoc cref="ReflectionProbe.GetMeshLodThreshold()" />
    public float GetMeshLodThreshold() => ((ReflectionProbe)_host).GetMeshLodThreshold();

    /// <inheritdoc cref="ReflectionProbe.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((ReflectionProbe)_host).SetSize(@size);

    /// <inheritdoc cref="ReflectionProbe.GetSize()" />
    public Vector3 GetSize() => ((ReflectionProbe)_host).GetSize();

    /// <inheritdoc cref="ReflectionProbe.SetOriginOffset(Vector3)" />
    public void SetOriginOffset(Vector3 @originOffset) => ((ReflectionProbe)_host).SetOriginOffset(@originOffset);

    /// <inheritdoc cref="ReflectionProbe.GetOriginOffset()" />
    public Vector3 GetOriginOffset() => ((ReflectionProbe)_host).GetOriginOffset();

    /// <inheritdoc cref="ReflectionProbe.SetAsInterior(bool)" />
    public void SetAsInterior(bool @enable) => ((ReflectionProbe)_host).SetAsInterior(@enable);

    /// <inheritdoc cref="ReflectionProbe.IsSetAsInterior()" />
    public bool IsSetAsInterior() => ((ReflectionProbe)_host).IsSetAsInterior();

    /// <inheritdoc cref="ReflectionProbe.SetEnableBoxProjection(bool)" />
    public void SetEnableBoxProjection(bool @enable) => ((ReflectionProbe)_host).SetEnableBoxProjection(@enable);

    /// <inheritdoc cref="ReflectionProbe.IsBoxProjectionEnabled()" />
    public bool IsBoxProjectionEnabled() => ((ReflectionProbe)_host).IsBoxProjectionEnabled();

    /// <inheritdoc cref="ReflectionProbe.SetEnableShadows(bool)" />
    public void SetEnableShadows(bool @enable) => ((ReflectionProbe)_host).SetEnableShadows(@enable);

    /// <inheritdoc cref="ReflectionProbe.AreShadowsEnabled()" />
    public bool AreShadowsEnabled() => ((ReflectionProbe)_host).AreShadowsEnabled();

    /// <inheritdoc cref="ReflectionProbe.SetCullMask(uint)" />
    public void SetCullMask(uint @layers) => ((ReflectionProbe)_host).SetCullMask(@layers);

    /// <inheritdoc cref="ReflectionProbe.GetCullMask()" />
    public uint GetCullMask() => ((ReflectionProbe)_host).GetCullMask();

    /// <inheritdoc cref="ReflectionProbe.SetReflectionMask(uint)" />
    public void SetReflectionMask(uint @layers) => ((ReflectionProbe)_host).SetReflectionMask(@layers);

    /// <inheritdoc cref="ReflectionProbe.GetReflectionMask()" />
    public uint GetReflectionMask() => ((ReflectionProbe)_host).GetReflectionMask();

    /// <inheritdoc cref="ReflectionProbe.SetUpdateMode(ReflectionProbe.UpdateModeEnum)" />
    public void SetUpdateMode(ReflectionProbe.UpdateModeEnum @mode) => ((ReflectionProbe)_host).SetUpdateMode(@mode);

    /// <inheritdoc cref="ReflectionProbe.GetUpdateMode()" />
    public ReflectionProbe.UpdateModeEnum GetUpdateMode() => ((ReflectionProbe)_host).GetUpdateMode();

}
