#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Decal" />
[Tool, GlobalClass]
public abstract partial class DecalComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="Decal.SetSize(Vector3)" />
    public void SetSize(Vector3 @size) => ((Decal)_host).SetSize(@size);

    /// <inheritdoc cref="Decal.GetSize()" />
    public Vector3 GetSize() => ((Decal)_host).GetSize();

    /// <inheritdoc cref="Decal.SetTexture(Decal.DecalTexture, Texture2D)" />
    public void SetTexture(Decal.DecalTexture @type, Texture2D @texture) => ((Decal)_host).SetTexture(@type, @texture);

    /// <inheritdoc cref="Decal.GetTexture(Decal.DecalTexture)" />
    public Texture2D GetTexture(Decal.DecalTexture @type) => ((Decal)_host).GetTexture(@type);

    /// <inheritdoc cref="Decal.SetEmissionEnergy(float)" />
    public void SetEmissionEnergy(float @energy) => ((Decal)_host).SetEmissionEnergy(@energy);

    /// <inheritdoc cref="Decal.GetEmissionEnergy()" />
    public float GetEmissionEnergy() => ((Decal)_host).GetEmissionEnergy();

    /// <inheritdoc cref="Decal.SetAlbedoMix(float)" />
    public void SetAlbedoMix(float @energy) => ((Decal)_host).SetAlbedoMix(@energy);

    /// <inheritdoc cref="Decal.GetAlbedoMix()" />
    public float GetAlbedoMix() => ((Decal)_host).GetAlbedoMix();

    /// <inheritdoc cref="Decal.SetModulate(Color)" />
    public void SetModulate(Color @color) => ((Decal)_host).SetModulate(@color);

    /// <inheritdoc cref="Decal.GetModulate()" />
    public Color GetModulate() => ((Decal)_host).GetModulate();

    /// <inheritdoc cref="Decal.SetUpperFade(float)" />
    public void SetUpperFade(float @fade) => ((Decal)_host).SetUpperFade(@fade);

    /// <inheritdoc cref="Decal.GetUpperFade()" />
    public float GetUpperFade() => ((Decal)_host).GetUpperFade();

    /// <inheritdoc cref="Decal.SetLowerFade(float)" />
    public void SetLowerFade(float @fade) => ((Decal)_host).SetLowerFade(@fade);

    /// <inheritdoc cref="Decal.GetLowerFade()" />
    public float GetLowerFade() => ((Decal)_host).GetLowerFade();

    /// <inheritdoc cref="Decal.SetNormalFade(float)" />
    public void SetNormalFade(float @fade) => ((Decal)_host).SetNormalFade(@fade);

    /// <inheritdoc cref="Decal.GetNormalFade()" />
    public float GetNormalFade() => ((Decal)_host).GetNormalFade();

    /// <inheritdoc cref="Decal.SetEnableDistanceFade(bool)" />
    public void SetEnableDistanceFade(bool @enable) => ((Decal)_host).SetEnableDistanceFade(@enable);

    /// <inheritdoc cref="Decal.IsDistanceFadeEnabled()" />
    public bool IsDistanceFadeEnabled() => ((Decal)_host).IsDistanceFadeEnabled();

    /// <inheritdoc cref="Decal.SetDistanceFadeBegin(float)" />
    public void SetDistanceFadeBegin(float @distance) => ((Decal)_host).SetDistanceFadeBegin(@distance);

    /// <inheritdoc cref="Decal.GetDistanceFadeBegin()" />
    public float GetDistanceFadeBegin() => ((Decal)_host).GetDistanceFadeBegin();

    /// <inheritdoc cref="Decal.SetDistanceFadeLength(float)" />
    public void SetDistanceFadeLength(float @distance) => ((Decal)_host).SetDistanceFadeLength(@distance);

    /// <inheritdoc cref="Decal.GetDistanceFadeLength()" />
    public float GetDistanceFadeLength() => ((Decal)_host).GetDistanceFadeLength();

    /// <inheritdoc cref="Decal.SetCullMask(uint)" />
    public void SetCullMask(uint @mask) => ((Decal)_host).SetCullMask(@mask);

    /// <inheritdoc cref="Decal.GetCullMask()" />
    public uint GetCullMask() => ((Decal)_host).GetCullMask();

}
