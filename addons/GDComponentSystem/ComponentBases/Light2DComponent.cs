#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Light2D" />
[Tool, GlobalClass]
public abstract partial class Light2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Light2D.SetEnabled(bool)" />
    public void SetEnabled(bool @enabled) => ((Light2D)_host).SetEnabled(@enabled);

    /// <inheritdoc cref="Light2D.IsEnabled()" />
    public bool IsEnabled() => ((Light2D)_host).IsEnabled();

    /// <inheritdoc cref="Light2D.SetEditorOnly(bool)" />
    public void SetEditorOnly(bool @editorOnly) => ((Light2D)_host).SetEditorOnly(@editorOnly);

    /// <inheritdoc cref="Light2D.IsEditorOnly()" />
    public bool IsEditorOnly() => ((Light2D)_host).IsEditorOnly();

    /// <inheritdoc cref="Light2D.SetColor(Color)" />
    public void SetColor(Color @color) => ((Light2D)_host).SetColor(@color);

    /// <inheritdoc cref="Light2D.GetColor()" />
    public Color GetColor() => ((Light2D)_host).GetColor();

    /// <inheritdoc cref="Light2D.SetEnergy(float)" />
    public void SetEnergy(float @energy) => ((Light2D)_host).SetEnergy(@energy);

    /// <inheritdoc cref="Light2D.GetEnergy()" />
    public float GetEnergy() => ((Light2D)_host).GetEnergy();

    /// <inheritdoc cref="Light2D.SetZRangeMin(int)" />
    public void SetZRangeMin(int @z) => ((Light2D)_host).SetZRangeMin(@z);

    /// <inheritdoc cref="Light2D.GetZRangeMin()" />
    public int GetZRangeMin() => ((Light2D)_host).GetZRangeMin();

    /// <inheritdoc cref="Light2D.SetZRangeMax(int)" />
    public void SetZRangeMax(int @z) => ((Light2D)_host).SetZRangeMax(@z);

    /// <inheritdoc cref="Light2D.GetZRangeMax()" />
    public int GetZRangeMax() => ((Light2D)_host).GetZRangeMax();

    /// <inheritdoc cref="Light2D.SetLayerRangeMin(int)" />
    public void SetLayerRangeMin(int @layer) => ((Light2D)_host).SetLayerRangeMin(@layer);

    /// <inheritdoc cref="Light2D.GetLayerRangeMin()" />
    public int GetLayerRangeMin() => ((Light2D)_host).GetLayerRangeMin();

    /// <inheritdoc cref="Light2D.SetLayerRangeMax(int)" />
    public void SetLayerRangeMax(int @layer) => ((Light2D)_host).SetLayerRangeMax(@layer);

    /// <inheritdoc cref="Light2D.GetLayerRangeMax()" />
    public int GetLayerRangeMax() => ((Light2D)_host).GetLayerRangeMax();

    /// <inheritdoc cref="Light2D.SetItemCullMask(int)" />
    public void SetItemCullMask(int @itemCullMask) => ((Light2D)_host).SetItemCullMask(@itemCullMask);

    /// <inheritdoc cref="Light2D.GetItemCullMask()" />
    public int GetItemCullMask() => ((Light2D)_host).GetItemCullMask();

    /// <inheritdoc cref="Light2D.SetItemShadowCullMask(int)" />
    public void SetItemShadowCullMask(int @itemShadowCullMask) => ((Light2D)_host).SetItemShadowCullMask(@itemShadowCullMask);

    /// <inheritdoc cref="Light2D.GetItemShadowCullMask()" />
    public int GetItemShadowCullMask() => ((Light2D)_host).GetItemShadowCullMask();

    /// <inheritdoc cref="Light2D.SetShadowEnabled(bool)" />
    public void SetShadowEnabled(bool @enabled) => ((Light2D)_host).SetShadowEnabled(@enabled);

    /// <inheritdoc cref="Light2D.IsShadowEnabled()" />
    public bool IsShadowEnabled() => ((Light2D)_host).IsShadowEnabled();

    /// <inheritdoc cref="Light2D.SetShadowSmooth(float)" />
    public void SetShadowSmooth(float @smooth) => ((Light2D)_host).SetShadowSmooth(@smooth);

    /// <inheritdoc cref="Light2D.GetShadowSmooth()" />
    public float GetShadowSmooth() => ((Light2D)_host).GetShadowSmooth();

    /// <inheritdoc cref="Light2D.SetShadowFilter(Light2D.ShadowFilterEnum)" />
    public void SetShadowFilter(Light2D.ShadowFilterEnum @filter) => ((Light2D)_host).SetShadowFilter(@filter);

    /// <inheritdoc cref="Light2D.GetShadowFilter()" />
    public Light2D.ShadowFilterEnum GetShadowFilter() => ((Light2D)_host).GetShadowFilter();

    /// <inheritdoc cref="Light2D.SetShadowColor(Color)" />
    public void SetShadowColor(Color @shadowColor) => ((Light2D)_host).SetShadowColor(@shadowColor);

    /// <inheritdoc cref="Light2D.GetShadowColor()" />
    public Color GetShadowColor() => ((Light2D)_host).GetShadowColor();

    /// <inheritdoc cref="Light2D.SetBlendMode(Light2D.BlendModeEnum)" />
    public void SetBlendMode(Light2D.BlendModeEnum @mode) => ((Light2D)_host).SetBlendMode(@mode);

    /// <inheritdoc cref="Light2D.GetBlendMode()" />
    public Light2D.BlendModeEnum GetBlendMode() => ((Light2D)_host).GetBlendMode();

    /// <inheritdoc cref="Light2D.SetHeight(float)" />
    public void SetHeight(float @height) => ((Light2D)_host).SetHeight(@height);

    /// <inheritdoc cref="Light2D.GetHeight()" />
    public float GetHeight() => ((Light2D)_host).GetHeight();

}
