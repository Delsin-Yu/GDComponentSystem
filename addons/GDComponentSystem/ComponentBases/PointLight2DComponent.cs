#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PointLight2D" />
[Tool, GlobalClass]
public abstract partial class PointLight2DComponent : Light2DComponent
{

    /// <inheritdoc cref="PointLight2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((PointLight2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="PointLight2D.GetTexture()" />
    public Texture2D GetTexture() => ((PointLight2D)_host).GetTexture();

    /// <inheritdoc cref="PointLight2D.SetTextureOffset(Vector2)" />
    public void SetTextureOffset(Vector2 @textureOffset) => ((PointLight2D)_host).SetTextureOffset(@textureOffset);

    /// <inheritdoc cref="PointLight2D.GetTextureOffset()" />
    public Vector2 GetTextureOffset() => ((PointLight2D)_host).GetTextureOffset();

    /// <inheritdoc cref="PointLight2D.SetTextureScale(float)" />
    public void SetTextureScale(float @textureScale) => ((PointLight2D)_host).SetTextureScale(@textureScale);

    /// <inheritdoc cref="PointLight2D.GetTextureScale()" />
    public float GetTextureScale() => ((PointLight2D)_host).GetTextureScale();

}
