#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TextureRect" />
[Tool, GlobalClass]
public abstract partial class TextureRectComponent : ControlComponent
{

    /// <inheritdoc cref="TextureRect.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((TextureRect)_host).SetTexture(@texture);

    /// <inheritdoc cref="TextureRect.GetTexture()" />
    public Texture2D GetTexture() => ((TextureRect)_host).GetTexture();

    /// <inheritdoc cref="TextureRect.SetExpandMode(TextureRect.ExpandModeEnum)" />
    public void SetExpandMode(TextureRect.ExpandModeEnum @expandMode) => ((TextureRect)_host).SetExpandMode(@expandMode);

    /// <inheritdoc cref="TextureRect.GetExpandMode()" />
    public TextureRect.ExpandModeEnum GetExpandMode() => ((TextureRect)_host).GetExpandMode();

    /// <inheritdoc cref="TextureRect.SetFlipH(bool)" />
    public void SetFlipH(bool @enable) => ((TextureRect)_host).SetFlipH(@enable);

    /// <inheritdoc cref="TextureRect.IsFlippedH()" />
    public bool IsFlippedH() => ((TextureRect)_host).IsFlippedH();

    /// <inheritdoc cref="TextureRect.SetFlipV(bool)" />
    public void SetFlipV(bool @enable) => ((TextureRect)_host).SetFlipV(@enable);

    /// <inheritdoc cref="TextureRect.IsFlippedV()" />
    public bool IsFlippedV() => ((TextureRect)_host).IsFlippedV();

    /// <inheritdoc cref="TextureRect.SetStretchMode(TextureRect.StretchModeEnum)" />
    public void SetStretchMode(TextureRect.StretchModeEnum @stretchMode) => ((TextureRect)_host).SetStretchMode(@stretchMode);

    /// <inheritdoc cref="TextureRect.GetStretchMode()" />
    public TextureRect.StretchModeEnum GetStretchMode() => ((TextureRect)_host).GetStretchMode();

}
