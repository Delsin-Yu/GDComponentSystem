#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="NinePatchRect" />
[Tool, GlobalClass]
public abstract partial class NinePatchRectComponent : ControlComponent
{

    /// <inheritdoc cref="NinePatchRect.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((NinePatchRect)_host).SetTexture(@texture);

    /// <inheritdoc cref="NinePatchRect.GetTexture()" />
    public Texture2D GetTexture() => ((NinePatchRect)_host).GetTexture();

    /// <inheritdoc cref="NinePatchRect.SetPatchMargin(Side, int)" />
    public void SetPatchMargin(Side @margin, int @value) => ((NinePatchRect)_host).SetPatchMargin(@margin, @value);

    /// <inheritdoc cref="NinePatchRect.GetPatchMargin(Side)" />
    public int GetPatchMargin(Side @margin) => ((NinePatchRect)_host).GetPatchMargin(@margin);

    /// <inheritdoc cref="NinePatchRect.SetRegionRect(Rect2)" />
    public void SetRegionRect(Rect2 @rect) => ((NinePatchRect)_host).SetRegionRect(@rect);

    /// <inheritdoc cref="NinePatchRect.GetRegionRect()" />
    public Rect2 GetRegionRect() => ((NinePatchRect)_host).GetRegionRect();

    /// <inheritdoc cref="NinePatchRect.SetDrawCenter(bool)" />
    public void SetDrawCenter(bool @drawCenter) => ((NinePatchRect)_host).SetDrawCenter(@drawCenter);

    /// <inheritdoc cref="NinePatchRect.IsDrawCenterEnabled()" />
    public bool IsDrawCenterEnabled() => ((NinePatchRect)_host).IsDrawCenterEnabled();

    /// <inheritdoc cref="NinePatchRect.SetHAxisStretchMode(NinePatchRect.AxisStretchMode)" />
    public void SetHAxisStretchMode(NinePatchRect.AxisStretchMode @mode) => ((NinePatchRect)_host).SetHAxisStretchMode(@mode);

    /// <inheritdoc cref="NinePatchRect.GetHAxisStretchMode()" />
    public NinePatchRect.AxisStretchMode GetHAxisStretchMode() => ((NinePatchRect)_host).GetHAxisStretchMode();

    /// <inheritdoc cref="NinePatchRect.SetVAxisStretchMode(NinePatchRect.AxisStretchMode)" />
    public void SetVAxisStretchMode(NinePatchRect.AxisStretchMode @mode) => ((NinePatchRect)_host).SetVAxisStretchMode(@mode);

    /// <inheritdoc cref="NinePatchRect.GetVAxisStretchMode()" />
    public NinePatchRect.AxisStretchMode GetVAxisStretchMode() => ((NinePatchRect)_host).GetVAxisStretchMode();

}
