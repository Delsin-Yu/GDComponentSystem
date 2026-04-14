#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Sprite2D" />
[Tool, GlobalClass]
public abstract partial class Sprite2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Sprite2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((Sprite2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="Sprite2D.GetTexture()" />
    public Texture2D GetTexture() => ((Sprite2D)_host).GetTexture();

    /// <inheritdoc cref="Sprite2D.SetCentered(bool)" />
    public void SetCentered(bool @centered) => ((Sprite2D)_host).SetCentered(@centered);

    /// <inheritdoc cref="Sprite2D.IsCentered()" />
    public bool IsCentered() => ((Sprite2D)_host).IsCentered();

    /// <inheritdoc cref="Sprite2D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((Sprite2D)_host).SetOffset(@offset);

    /// <inheritdoc cref="Sprite2D.GetOffset()" />
    public Vector2 GetOffset() => ((Sprite2D)_host).GetOffset();

    /// <inheritdoc cref="Sprite2D.SetFlipH(bool)" />
    public void SetFlipH(bool @flipH) => ((Sprite2D)_host).SetFlipH(@flipH);

    /// <inheritdoc cref="Sprite2D.IsFlippedH()" />
    public bool IsFlippedH() => ((Sprite2D)_host).IsFlippedH();

    /// <inheritdoc cref="Sprite2D.SetFlipV(bool)" />
    public void SetFlipV(bool @flipV) => ((Sprite2D)_host).SetFlipV(@flipV);

    /// <inheritdoc cref="Sprite2D.IsFlippedV()" />
    public bool IsFlippedV() => ((Sprite2D)_host).IsFlippedV();

    /// <inheritdoc cref="Sprite2D.SetRegionEnabled(bool)" />
    public void SetRegionEnabled(bool @enabled) => ((Sprite2D)_host).SetRegionEnabled(@enabled);

    /// <inheritdoc cref="Sprite2D.IsRegionEnabled()" />
    public bool IsRegionEnabled() => ((Sprite2D)_host).IsRegionEnabled();

    /// <inheritdoc cref="Sprite2D.IsPixelOpaque(Vector2)" />
    public bool IsPixelOpaque(Vector2 @pos) => ((Sprite2D)_host).IsPixelOpaque(@pos);

    /// <inheritdoc cref="Sprite2D.SetRegionRect(Rect2)" />
    public void SetRegionRect(Rect2 @rect) => ((Sprite2D)_host).SetRegionRect(@rect);

    /// <inheritdoc cref="Sprite2D.GetRegionRect()" />
    public Rect2 GetRegionRect() => ((Sprite2D)_host).GetRegionRect();

    /// <inheritdoc cref="Sprite2D.SetRegionFilterClipEnabled(bool)" />
    public void SetRegionFilterClipEnabled(bool @enabled) => ((Sprite2D)_host).SetRegionFilterClipEnabled(@enabled);

    /// <inheritdoc cref="Sprite2D.IsRegionFilterClipEnabled()" />
    public bool IsRegionFilterClipEnabled() => ((Sprite2D)_host).IsRegionFilterClipEnabled();

    /// <inheritdoc cref="Sprite2D.SetFrame(int)" />
    public void SetFrame(int @frame) => ((Sprite2D)_host).SetFrame(@frame);

    /// <inheritdoc cref="Sprite2D.GetFrame()" />
    public int GetFrame() => ((Sprite2D)_host).GetFrame();

    /// <inheritdoc cref="Sprite2D.SetFrameCoords(Vector2I)" />
    public void SetFrameCoords(Vector2I @coords) => ((Sprite2D)_host).SetFrameCoords(@coords);

    /// <inheritdoc cref="Sprite2D.GetFrameCoords()" />
    public Vector2I GetFrameCoords() => ((Sprite2D)_host).GetFrameCoords();

    /// <inheritdoc cref="Sprite2D.SetVframes(int)" />
    public void SetVframes(int @vframes) => ((Sprite2D)_host).SetVframes(@vframes);

    /// <inheritdoc cref="Sprite2D.GetVframes()" />
    public int GetVframes() => ((Sprite2D)_host).GetVframes();

    /// <inheritdoc cref="Sprite2D.SetHframes(int)" />
    public void SetHframes(int @hframes) => ((Sprite2D)_host).SetHframes(@hframes);

    /// <inheritdoc cref="Sprite2D.GetHframes()" />
    public int GetHframes() => ((Sprite2D)_host).GetHframes();

    /// <inheritdoc cref="Sprite2D.GetRect()" />
    public Rect2 GetRect() => ((Sprite2D)_host).GetRect();

}
