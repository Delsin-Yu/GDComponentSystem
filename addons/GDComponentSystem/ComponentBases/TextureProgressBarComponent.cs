#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TextureProgressBar" />
[Tool, GlobalClass]
public abstract partial class TextureProgressBarComponent : RangeComponent
{

    /// <inheritdoc cref="TextureProgressBar.SetUnderTexture(Texture2D)" />
    public void SetUnderTexture(Texture2D @tex) => ((TextureProgressBar)_host).SetUnderTexture(@tex);

    /// <inheritdoc cref="TextureProgressBar.GetUnderTexture()" />
    public Texture2D GetUnderTexture() => ((TextureProgressBar)_host).GetUnderTexture();

    /// <inheritdoc cref="TextureProgressBar.SetProgressTexture(Texture2D)" />
    public void SetProgressTexture(Texture2D @tex) => ((TextureProgressBar)_host).SetProgressTexture(@tex);

    /// <inheritdoc cref="TextureProgressBar.GetProgressTexture()" />
    public Texture2D GetProgressTexture() => ((TextureProgressBar)_host).GetProgressTexture();

    /// <inheritdoc cref="TextureProgressBar.SetOverTexture(Texture2D)" />
    public void SetOverTexture(Texture2D @tex) => ((TextureProgressBar)_host).SetOverTexture(@tex);

    /// <inheritdoc cref="TextureProgressBar.GetOverTexture()" />
    public Texture2D GetOverTexture() => ((TextureProgressBar)_host).GetOverTexture();

    /// <inheritdoc cref="TextureProgressBar.SetFillMode(int)" />
    public void SetFillMode(int @mode) => ((TextureProgressBar)_host).SetFillMode(@mode);

    /// <inheritdoc cref="TextureProgressBar.GetFillMode()" />
    public int GetFillMode() => ((TextureProgressBar)_host).GetFillMode();

    /// <inheritdoc cref="TextureProgressBar.SetTintUnder(Color)" />
    public void SetTintUnder(Color @tint) => ((TextureProgressBar)_host).SetTintUnder(@tint);

    /// <inheritdoc cref="TextureProgressBar.GetTintUnder()" />
    public Color GetTintUnder() => ((TextureProgressBar)_host).GetTintUnder();

    /// <inheritdoc cref="TextureProgressBar.SetTintProgress(Color)" />
    public void SetTintProgress(Color @tint) => ((TextureProgressBar)_host).SetTintProgress(@tint);

    /// <inheritdoc cref="TextureProgressBar.GetTintProgress()" />
    public Color GetTintProgress() => ((TextureProgressBar)_host).GetTintProgress();

    /// <inheritdoc cref="TextureProgressBar.SetTintOver(Color)" />
    public void SetTintOver(Color @tint) => ((TextureProgressBar)_host).SetTintOver(@tint);

    /// <inheritdoc cref="TextureProgressBar.GetTintOver()" />
    public Color GetTintOver() => ((TextureProgressBar)_host).GetTintOver();

    /// <inheritdoc cref="TextureProgressBar.SetTextureProgressOffset(Vector2)" />
    public void SetTextureProgressOffset(Vector2 @offset) => ((TextureProgressBar)_host).SetTextureProgressOffset(@offset);

    /// <inheritdoc cref="TextureProgressBar.GetTextureProgressOffset()" />
    public Vector2 GetTextureProgressOffset() => ((TextureProgressBar)_host).GetTextureProgressOffset();

    /// <inheritdoc cref="TextureProgressBar.SetRadialInitialAngle(float)" />
    public void SetRadialInitialAngle(float @mode) => ((TextureProgressBar)_host).SetRadialInitialAngle(@mode);

    /// <inheritdoc cref="TextureProgressBar.GetRadialInitialAngle()" />
    public float GetRadialInitialAngle() => ((TextureProgressBar)_host).GetRadialInitialAngle();

    /// <inheritdoc cref="TextureProgressBar.SetRadialCenterOffset(Vector2)" />
    public void SetRadialCenterOffset(Vector2 @mode) => ((TextureProgressBar)_host).SetRadialCenterOffset(@mode);

    /// <inheritdoc cref="TextureProgressBar.GetRadialCenterOffset()" />
    public Vector2 GetRadialCenterOffset() => ((TextureProgressBar)_host).GetRadialCenterOffset();

    /// <inheritdoc cref="TextureProgressBar.SetFillDegrees(float)" />
    public void SetFillDegrees(float @mode) => ((TextureProgressBar)_host).SetFillDegrees(@mode);

    /// <inheritdoc cref="TextureProgressBar.GetFillDegrees()" />
    public float GetFillDegrees() => ((TextureProgressBar)_host).GetFillDegrees();

    /// <inheritdoc cref="TextureProgressBar.SetStretchMargin(Side, int)" />
    public void SetStretchMargin(Side @margin, int @value) => ((TextureProgressBar)_host).SetStretchMargin(@margin, @value);

    /// <inheritdoc cref="TextureProgressBar.GetStretchMargin(Side)" />
    public int GetStretchMargin(Side @margin) => ((TextureProgressBar)_host).GetStretchMargin(@margin);

    /// <inheritdoc cref="TextureProgressBar.SetNinePatchStretch(bool)" />
    public void SetNinePatchStretch(bool @stretch) => ((TextureProgressBar)_host).SetNinePatchStretch(@stretch);

    /// <inheritdoc cref="TextureProgressBar.GetNinePatchStretch()" />
    public bool GetNinePatchStretch() => ((TextureProgressBar)_host).GetNinePatchStretch();

}
