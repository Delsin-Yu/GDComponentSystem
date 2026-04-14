#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Sprite3D" />
[Tool, GlobalClass]
public abstract partial class Sprite3DComponent : SpriteBase3DComponent
{

    /// <inheritdoc cref="Sprite3D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((Sprite3D)_host).SetTexture(@texture);

    /// <inheritdoc cref="Sprite3D.GetTexture()" />
    public Texture2D GetTexture() => ((Sprite3D)_host).GetTexture();

    /// <inheritdoc cref="Sprite3D.SetRegionEnabled(bool)" />
    public void SetRegionEnabled(bool @enabled) => ((Sprite3D)_host).SetRegionEnabled(@enabled);

    /// <inheritdoc cref="Sprite3D.IsRegionEnabled()" />
    public bool IsRegionEnabled() => ((Sprite3D)_host).IsRegionEnabled();

    /// <inheritdoc cref="Sprite3D.SetRegionRect(Rect2)" />
    public void SetRegionRect(Rect2 @rect) => ((Sprite3D)_host).SetRegionRect(@rect);

    /// <inheritdoc cref="Sprite3D.GetRegionRect()" />
    public Rect2 GetRegionRect() => ((Sprite3D)_host).GetRegionRect();

    /// <inheritdoc cref="Sprite3D.SetFrame(int)" />
    public void SetFrame(int @frame) => ((Sprite3D)_host).SetFrame(@frame);

    /// <inheritdoc cref="Sprite3D.GetFrame()" />
    public int GetFrame() => ((Sprite3D)_host).GetFrame();

    /// <inheritdoc cref="Sprite3D.SetFrameCoords(Vector2I)" />
    public void SetFrameCoords(Vector2I @coords) => ((Sprite3D)_host).SetFrameCoords(@coords);

    /// <inheritdoc cref="Sprite3D.GetFrameCoords()" />
    public Vector2I GetFrameCoords() => ((Sprite3D)_host).GetFrameCoords();

    /// <inheritdoc cref="Sprite3D.SetVframes(int)" />
    public void SetVframes(int @vframes) => ((Sprite3D)_host).SetVframes(@vframes);

    /// <inheritdoc cref="Sprite3D.GetVframes()" />
    public int GetVframes() => ((Sprite3D)_host).GetVframes();

    /// <inheritdoc cref="Sprite3D.SetHframes(int)" />
    public void SetHframes(int @hframes) => ((Sprite3D)_host).SetHframes(@hframes);

    /// <inheritdoc cref="Sprite3D.GetHframes()" />
    public int GetHframes() => ((Sprite3D)_host).GetHframes();

}
