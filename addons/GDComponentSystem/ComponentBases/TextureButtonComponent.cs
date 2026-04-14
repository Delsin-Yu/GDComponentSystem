#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TextureButton" />
[Tool, GlobalClass]
public abstract partial class TextureButtonComponent : BaseButtonComponent
{

    /// <inheritdoc cref="TextureButton.SetTextureNormal(Texture2D)" />
    public void SetTextureNormal(Texture2D @texture) => ((TextureButton)_host).SetTextureNormal(@texture);

    /// <inheritdoc cref="TextureButton.SetTexturePressed(Texture2D)" />
    public void SetTexturePressed(Texture2D @texture) => ((TextureButton)_host).SetTexturePressed(@texture);

    /// <inheritdoc cref="TextureButton.SetTextureHover(Texture2D)" />
    public void SetTextureHover(Texture2D @texture) => ((TextureButton)_host).SetTextureHover(@texture);

    /// <inheritdoc cref="TextureButton.SetTextureDisabled(Texture2D)" />
    public void SetTextureDisabled(Texture2D @texture) => ((TextureButton)_host).SetTextureDisabled(@texture);

    /// <inheritdoc cref="TextureButton.SetTextureFocused(Texture2D)" />
    public void SetTextureFocused(Texture2D @texture) => ((TextureButton)_host).SetTextureFocused(@texture);

    /// <inheritdoc cref="TextureButton.SetClickMask(Bitmap)" />
    public void SetClickMask(Bitmap @mask) => ((TextureButton)_host).SetClickMask(@mask);

    /// <inheritdoc cref="TextureButton.SetIgnoreTextureSize(bool)" />
    public void SetIgnoreTextureSize(bool @ignore) => ((TextureButton)_host).SetIgnoreTextureSize(@ignore);

    /// <inheritdoc cref="TextureButton.SetStretchMode(TextureButton.StretchModeEnum)" />
    public void SetStretchMode(TextureButton.StretchModeEnum @mode) => ((TextureButton)_host).SetStretchMode(@mode);

    /// <inheritdoc cref="TextureButton.SetFlipH(bool)" />
    public void SetFlipH(bool @enable) => ((TextureButton)_host).SetFlipH(@enable);

    /// <inheritdoc cref="TextureButton.IsFlippedH()" />
    public bool IsFlippedH() => ((TextureButton)_host).IsFlippedH();

    /// <inheritdoc cref="TextureButton.SetFlipV(bool)" />
    public void SetFlipV(bool @enable) => ((TextureButton)_host).SetFlipV(@enable);

    /// <inheritdoc cref="TextureButton.IsFlippedV()" />
    public bool IsFlippedV() => ((TextureButton)_host).IsFlippedV();

    /// <inheritdoc cref="TextureButton.GetTextureNormal()" />
    public Texture2D GetTextureNormal() => ((TextureButton)_host).GetTextureNormal();

    /// <inheritdoc cref="TextureButton.GetTexturePressed()" />
    public Texture2D GetTexturePressed() => ((TextureButton)_host).GetTexturePressed();

    /// <inheritdoc cref="TextureButton.GetTextureHover()" />
    public Texture2D GetTextureHover() => ((TextureButton)_host).GetTextureHover();

    /// <inheritdoc cref="TextureButton.GetTextureDisabled()" />
    public Texture2D GetTextureDisabled() => ((TextureButton)_host).GetTextureDisabled();

    /// <inheritdoc cref="TextureButton.GetTextureFocused()" />
    public Texture2D GetTextureFocused() => ((TextureButton)_host).GetTextureFocused();

    /// <inheritdoc cref="TextureButton.GetClickMask()" />
    public Bitmap GetClickMask() => ((TextureButton)_host).GetClickMask();

    /// <inheritdoc cref="TextureButton.GetIgnoreTextureSize()" />
    public bool GetIgnoreTextureSize() => ((TextureButton)_host).GetIgnoreTextureSize();

    /// <inheritdoc cref="TextureButton.GetStretchMode()" />
    public TextureButton.StretchModeEnum GetStretchMode() => ((TextureButton)_host).GetStretchMode();

}
