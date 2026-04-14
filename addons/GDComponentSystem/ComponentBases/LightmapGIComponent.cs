#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LightmapGI" />
[Tool, GlobalClass]
public abstract partial class LightmapGIComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="LightmapGI.SetLightData(LightmapGIData)" />
    public void SetLightData(LightmapGIData @data) => ((LightmapGI)_host).SetLightData(@data);

    /// <inheritdoc cref="LightmapGI.GetLightData()" />
    public LightmapGIData GetLightData() => ((LightmapGI)_host).GetLightData();

    /// <inheritdoc cref="LightmapGI.SetBakeQuality(LightmapGI.BakeQuality)" />
    public void SetBakeQuality(LightmapGI.BakeQuality @bakeQuality) => ((LightmapGI)_host).SetBakeQuality(@bakeQuality);

    /// <inheritdoc cref="LightmapGI.GetBakeQuality()" />
    public LightmapGI.BakeQuality GetBakeQuality() => ((LightmapGI)_host).GetBakeQuality();

    /// <inheritdoc cref="LightmapGI.SetBounces(int)" />
    public void SetBounces(int @bounces) => ((LightmapGI)_host).SetBounces(@bounces);

    /// <inheritdoc cref="LightmapGI.GetBounces()" />
    public int GetBounces() => ((LightmapGI)_host).GetBounces();

    /// <inheritdoc cref="LightmapGI.SetBounceIndirectEnergy(float)" />
    public void SetBounceIndirectEnergy(float @bounceIndirectEnergy) => ((LightmapGI)_host).SetBounceIndirectEnergy(@bounceIndirectEnergy);

    /// <inheritdoc cref="LightmapGI.GetBounceIndirectEnergy()" />
    public float GetBounceIndirectEnergy() => ((LightmapGI)_host).GetBounceIndirectEnergy();

    /// <inheritdoc cref="LightmapGI.SetGenerateProbes(LightmapGI.GenerateProbes)" />
    public void SetGenerateProbes(LightmapGI.GenerateProbes @subdivision) => ((LightmapGI)_host).SetGenerateProbes(@subdivision);

    /// <inheritdoc cref="LightmapGI.GetGenerateProbes()" />
    public LightmapGI.GenerateProbes GetGenerateProbes() => ((LightmapGI)_host).GetGenerateProbes();

    /// <inheritdoc cref="LightmapGI.SetBias(float)" />
    public void SetBias(float @bias) => ((LightmapGI)_host).SetBias(@bias);

    /// <inheritdoc cref="LightmapGI.GetBias()" />
    public float GetBias() => ((LightmapGI)_host).GetBias();

    /// <inheritdoc cref="LightmapGI.SetEnvironmentMode(LightmapGI.EnvironmentModeEnum)" />
    public void SetEnvironmentMode(LightmapGI.EnvironmentModeEnum @mode) => ((LightmapGI)_host).SetEnvironmentMode(@mode);

    /// <inheritdoc cref="LightmapGI.GetEnvironmentMode()" />
    public LightmapGI.EnvironmentModeEnum GetEnvironmentMode() => ((LightmapGI)_host).GetEnvironmentMode();

    /// <inheritdoc cref="LightmapGI.SetEnvironmentCustomSky(Sky)" />
    public void SetEnvironmentCustomSky(Sky @sky) => ((LightmapGI)_host).SetEnvironmentCustomSky(@sky);

    /// <inheritdoc cref="LightmapGI.GetEnvironmentCustomSky()" />
    public Sky GetEnvironmentCustomSky() => ((LightmapGI)_host).GetEnvironmentCustomSky();

    /// <inheritdoc cref="LightmapGI.SetEnvironmentCustomColor(Color)" />
    public void SetEnvironmentCustomColor(Color @color) => ((LightmapGI)_host).SetEnvironmentCustomColor(@color);

    /// <inheritdoc cref="LightmapGI.GetEnvironmentCustomColor()" />
    public Color GetEnvironmentCustomColor() => ((LightmapGI)_host).GetEnvironmentCustomColor();

    /// <inheritdoc cref="LightmapGI.SetEnvironmentCustomEnergy(float)" />
    public void SetEnvironmentCustomEnergy(float @energy) => ((LightmapGI)_host).SetEnvironmentCustomEnergy(@energy);

    /// <inheritdoc cref="LightmapGI.GetEnvironmentCustomEnergy()" />
    public float GetEnvironmentCustomEnergy() => ((LightmapGI)_host).GetEnvironmentCustomEnergy();

    /// <inheritdoc cref="LightmapGI.SetTexelScale(float)" />
    public void SetTexelScale(float @texelScale) => ((LightmapGI)_host).SetTexelScale(@texelScale);

    /// <inheritdoc cref="LightmapGI.GetTexelScale()" />
    public float GetTexelScale() => ((LightmapGI)_host).GetTexelScale();

    /// <inheritdoc cref="LightmapGI.SetMaxTextureSize(int)" />
    public void SetMaxTextureSize(int @maxTextureSize) => ((LightmapGI)_host).SetMaxTextureSize(@maxTextureSize);

    /// <inheritdoc cref="LightmapGI.GetMaxTextureSize()" />
    public int GetMaxTextureSize() => ((LightmapGI)_host).GetMaxTextureSize();

    /// <inheritdoc cref="LightmapGI.SetSupersamplingEnabled(bool)" />
    public void SetSupersamplingEnabled(bool @enable) => ((LightmapGI)_host).SetSupersamplingEnabled(@enable);

    /// <inheritdoc cref="LightmapGI.IsSupersamplingEnabled()" />
    public bool IsSupersamplingEnabled() => ((LightmapGI)_host).IsSupersamplingEnabled();

    /// <inheritdoc cref="LightmapGI.SetSupersamplingFactor(float)" />
    public void SetSupersamplingFactor(float @factor) => ((LightmapGI)_host).SetSupersamplingFactor(@factor);

    /// <inheritdoc cref="LightmapGI.GetSupersamplingFactor()" />
    public float GetSupersamplingFactor() => ((LightmapGI)_host).GetSupersamplingFactor();

    /// <inheritdoc cref="LightmapGI.SetUseDenoiser(bool)" />
    public void SetUseDenoiser(bool @useDenoiser) => ((LightmapGI)_host).SetUseDenoiser(@useDenoiser);

    /// <inheritdoc cref="LightmapGI.IsUsingDenoiser()" />
    public bool IsUsingDenoiser() => ((LightmapGI)_host).IsUsingDenoiser();

    /// <inheritdoc cref="LightmapGI.SetDenoiserStrength(float)" />
    public void SetDenoiserStrength(float @denoiserStrength) => ((LightmapGI)_host).SetDenoiserStrength(@denoiserStrength);

    /// <inheritdoc cref="LightmapGI.GetDenoiserStrength()" />
    public float GetDenoiserStrength() => ((LightmapGI)_host).GetDenoiserStrength();

    /// <inheritdoc cref="LightmapGI.SetDenoiserRange(int)" />
    public void SetDenoiserRange(int @denoiserRange) => ((LightmapGI)_host).SetDenoiserRange(@denoiserRange);

    /// <inheritdoc cref="LightmapGI.GetDenoiserRange()" />
    public int GetDenoiserRange() => ((LightmapGI)_host).GetDenoiserRange();

    /// <inheritdoc cref="LightmapGI.SetInterior(bool)" />
    public void SetInterior(bool @enable) => ((LightmapGI)_host).SetInterior(@enable);

    /// <inheritdoc cref="LightmapGI.IsInterior()" />
    public bool IsInterior() => ((LightmapGI)_host).IsInterior();

    /// <inheritdoc cref="LightmapGI.SetDirectional(bool)" />
    public void SetDirectional(bool @directional) => ((LightmapGI)_host).SetDirectional(@directional);

    /// <inheritdoc cref="LightmapGI.IsDirectional()" />
    public bool IsDirectional() => ((LightmapGI)_host).IsDirectional();

    /// <inheritdoc cref="LightmapGI.SetShadowmaskMode(LightmapGIData.ShadowmaskMode)" />
    public void SetShadowmaskMode(LightmapGIData.ShadowmaskMode @mode) => ((LightmapGI)_host).SetShadowmaskMode(@mode);

    /// <inheritdoc cref="LightmapGI.GetShadowmaskMode()" />
    public LightmapGIData.ShadowmaskMode GetShadowmaskMode() => ((LightmapGI)_host).GetShadowmaskMode();

    /// <inheritdoc cref="LightmapGI.SetUseTextureForBounces(bool)" />
    public void SetUseTextureForBounces(bool @useTextureForBounces) => ((LightmapGI)_host).SetUseTextureForBounces(@useTextureForBounces);

    /// <inheritdoc cref="LightmapGI.IsUsingTextureForBounces()" />
    public bool IsUsingTextureForBounces() => ((LightmapGI)_host).IsUsingTextureForBounces();

    /// <inheritdoc cref="LightmapGI.SetCameraAttributes(CameraAttributes)" />
    public void SetCameraAttributes(CameraAttributes @cameraAttributes) => ((LightmapGI)_host).SetCameraAttributes(@cameraAttributes);

    /// <inheritdoc cref="LightmapGI.GetCameraAttributes()" />
    public CameraAttributes GetCameraAttributes() => ((LightmapGI)_host).GetCameraAttributes();

}
