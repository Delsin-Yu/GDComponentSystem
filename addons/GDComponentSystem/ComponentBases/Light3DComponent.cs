#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Light3D" />
[Tool, GlobalClass]
public abstract partial class Light3DComponent : VisualInstance3DComponent
{

    /// <inheritdoc cref="Light3D.SetEditorOnly(bool)" />
    public void SetEditorOnly(bool @editorOnly) => ((Light3D)_host).SetEditorOnly(@editorOnly);

    /// <inheritdoc cref="Light3D.IsEditorOnly()" />
    public bool IsEditorOnly() => ((Light3D)_host).IsEditorOnly();

    /// <inheritdoc cref="Light3D.SetParam(Light3D.Param, float)" />
    public void SetParam(Light3D.Param @param, float @value) => ((Light3D)_host).SetParam(@param, @value);

    /// <inheritdoc cref="Light3D.GetParam(Light3D.Param)" />
    public float GetParam(Light3D.Param @param) => ((Light3D)_host).GetParam(@param);

    /// <inheritdoc cref="Light3D.SetShadow(bool)" />
    public void SetShadow(bool @enabled) => ((Light3D)_host).SetShadow(@enabled);

    /// <inheritdoc cref="Light3D.HasShadow()" />
    public bool HasShadow() => ((Light3D)_host).HasShadow();

    /// <inheritdoc cref="Light3D.SetNegative(bool)" />
    public void SetNegative(bool @enabled) => ((Light3D)_host).SetNegative(@enabled);

    /// <inheritdoc cref="Light3D.IsNegative()" />
    public bool IsNegative() => ((Light3D)_host).IsNegative();

    /// <inheritdoc cref="Light3D.SetCullMask(uint)" />
    public void SetCullMask(uint @cullMask) => ((Light3D)_host).SetCullMask(@cullMask);

    /// <inheritdoc cref="Light3D.GetCullMask()" />
    public uint GetCullMask() => ((Light3D)_host).GetCullMask();

    /// <inheritdoc cref="Light3D.SetEnableDistanceFade(bool)" />
    public void SetEnableDistanceFade(bool @enable) => ((Light3D)_host).SetEnableDistanceFade(@enable);

    /// <inheritdoc cref="Light3D.IsDistanceFadeEnabled()" />
    public bool IsDistanceFadeEnabled() => ((Light3D)_host).IsDistanceFadeEnabled();

    /// <inheritdoc cref="Light3D.SetDistanceFadeBegin(float)" />
    public void SetDistanceFadeBegin(float @distance) => ((Light3D)_host).SetDistanceFadeBegin(@distance);

    /// <inheritdoc cref="Light3D.GetDistanceFadeBegin()" />
    public float GetDistanceFadeBegin() => ((Light3D)_host).GetDistanceFadeBegin();

    /// <inheritdoc cref="Light3D.SetDistanceFadeShadow(float)" />
    public void SetDistanceFadeShadow(float @distance) => ((Light3D)_host).SetDistanceFadeShadow(@distance);

    /// <inheritdoc cref="Light3D.GetDistanceFadeShadow()" />
    public float GetDistanceFadeShadow() => ((Light3D)_host).GetDistanceFadeShadow();

    /// <inheritdoc cref="Light3D.SetDistanceFadeLength(float)" />
    public void SetDistanceFadeLength(float @distance) => ((Light3D)_host).SetDistanceFadeLength(@distance);

    /// <inheritdoc cref="Light3D.GetDistanceFadeLength()" />
    public float GetDistanceFadeLength() => ((Light3D)_host).GetDistanceFadeLength();

    /// <inheritdoc cref="Light3D.SetColor(Color)" />
    public void SetColor(Color @color) => ((Light3D)_host).SetColor(@color);

    /// <inheritdoc cref="Light3D.GetColor()" />
    public Color GetColor() => ((Light3D)_host).GetColor();

    /// <inheritdoc cref="Light3D.SetShadowReverseCullFace(bool)" />
    public void SetShadowReverseCullFace(bool @enable) => ((Light3D)_host).SetShadowReverseCullFace(@enable);

    /// <inheritdoc cref="Light3D.GetShadowReverseCullFace()" />
    public bool GetShadowReverseCullFace() => ((Light3D)_host).GetShadowReverseCullFace();

    /// <inheritdoc cref="Light3D.SetShadowCasterMask(uint)" />
    public void SetShadowCasterMask(uint @casterMask) => ((Light3D)_host).SetShadowCasterMask(@casterMask);

    /// <inheritdoc cref="Light3D.GetShadowCasterMask()" />
    public uint GetShadowCasterMask() => ((Light3D)_host).GetShadowCasterMask();

    /// <inheritdoc cref="Light3D.SetBakeMode(Light3D.BakeMode)" />
    public void SetBakeMode(Light3D.BakeMode @bakeMode) => ((Light3D)_host).SetBakeMode(@bakeMode);

    /// <inheritdoc cref="Light3D.GetBakeMode()" />
    public Light3D.BakeMode GetBakeMode() => ((Light3D)_host).GetBakeMode();

    /// <inheritdoc cref="Light3D.SetProjector(Texture2D)" />
    public void SetProjector(Texture2D @projector) => ((Light3D)_host).SetProjector(@projector);

    /// <inheritdoc cref="Light3D.GetProjector()" />
    public Texture2D GetProjector() => ((Light3D)_host).GetProjector();

    /// <inheritdoc cref="Light3D.SetTemperature(float)" />
    public void SetTemperature(float @temperature) => ((Light3D)_host).SetTemperature(@temperature);

    /// <inheritdoc cref="Light3D.GetTemperature()" />
    public float GetTemperature() => ((Light3D)_host).GetTemperature();

    /// <inheritdoc cref="Light3D.GetCorrelatedColor()" />
    public Color GetCorrelatedColor() => ((Light3D)_host).GetCorrelatedColor();

}
