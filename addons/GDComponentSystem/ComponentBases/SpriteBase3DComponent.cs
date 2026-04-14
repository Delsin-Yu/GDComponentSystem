#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpriteBase3D" />
[Tool, GlobalClass]
public abstract partial class SpriteBase3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="SpriteBase3D.SetCentered(bool)" />
    public void SetCentered(bool @centered) => ((SpriteBase3D)_host).SetCentered(@centered);

    /// <inheritdoc cref="SpriteBase3D.IsCentered()" />
    public bool IsCentered() => ((SpriteBase3D)_host).IsCentered();

    /// <inheritdoc cref="SpriteBase3D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((SpriteBase3D)_host).SetOffset(@offset);

    /// <inheritdoc cref="SpriteBase3D.GetOffset()" />
    public Vector2 GetOffset() => ((SpriteBase3D)_host).GetOffset();

    /// <inheritdoc cref="SpriteBase3D.SetFlipH(bool)" />
    public void SetFlipH(bool @flipH) => ((SpriteBase3D)_host).SetFlipH(@flipH);

    /// <inheritdoc cref="SpriteBase3D.IsFlippedH()" />
    public bool IsFlippedH() => ((SpriteBase3D)_host).IsFlippedH();

    /// <inheritdoc cref="SpriteBase3D.SetFlipV(bool)" />
    public void SetFlipV(bool @flipV) => ((SpriteBase3D)_host).SetFlipV(@flipV);

    /// <inheritdoc cref="SpriteBase3D.IsFlippedV()" />
    public bool IsFlippedV() => ((SpriteBase3D)_host).IsFlippedV();

    /// <inheritdoc cref="SpriteBase3D.SetModulate(Color)" />
    public void SetModulate(Color @modulate) => ((SpriteBase3D)_host).SetModulate(@modulate);

    /// <inheritdoc cref="SpriteBase3D.GetModulate()" />
    public Color GetModulate() => ((SpriteBase3D)_host).GetModulate();

    /// <inheritdoc cref="SpriteBase3D.SetRenderPriority(int)" />
    public void SetRenderPriority(int @priority) => ((SpriteBase3D)_host).SetRenderPriority(@priority);

    /// <inheritdoc cref="SpriteBase3D.GetRenderPriority()" />
    public int GetRenderPriority() => ((SpriteBase3D)_host).GetRenderPriority();

    /// <inheritdoc cref="SpriteBase3D.SetPixelSize(float)" />
    public void SetPixelSize(float @pixelSize) => ((SpriteBase3D)_host).SetPixelSize(@pixelSize);

    /// <inheritdoc cref="SpriteBase3D.GetPixelSize()" />
    public float GetPixelSize() => ((SpriteBase3D)_host).GetPixelSize();

    /// <inheritdoc cref="SpriteBase3D.SetAxis(Vector3.Axis)" />
    public void SetAxis(Vector3.Axis @axis) => ((SpriteBase3D)_host).SetAxis(@axis);

    /// <inheritdoc cref="SpriteBase3D.GetAxis()" />
    public Vector3.Axis GetAxis() => ((SpriteBase3D)_host).GetAxis();

    /// <inheritdoc cref="SpriteBase3D.SetDrawFlag(SpriteBase3D.DrawFlags, bool)" />
    public void SetDrawFlag(SpriteBase3D.DrawFlags @flag, bool @enabled) => ((SpriteBase3D)_host).SetDrawFlag(@flag, @enabled);

    /// <inheritdoc cref="SpriteBase3D.GetDrawFlag(SpriteBase3D.DrawFlags)" />
    public bool GetDrawFlag(SpriteBase3D.DrawFlags @flag) => ((SpriteBase3D)_host).GetDrawFlag(@flag);

    /// <inheritdoc cref="SpriteBase3D.SetAlphaCutMode(SpriteBase3D.AlphaCutMode)" />
    public void SetAlphaCutMode(SpriteBase3D.AlphaCutMode @mode) => ((SpriteBase3D)_host).SetAlphaCutMode(@mode);

    /// <inheritdoc cref="SpriteBase3D.GetAlphaCutMode()" />
    public SpriteBase3D.AlphaCutMode GetAlphaCutMode() => ((SpriteBase3D)_host).GetAlphaCutMode();

    /// <inheritdoc cref="SpriteBase3D.SetAlphaScissorThreshold(float)" />
    public void SetAlphaScissorThreshold(float @threshold) => ((SpriteBase3D)_host).SetAlphaScissorThreshold(@threshold);

    /// <inheritdoc cref="SpriteBase3D.GetAlphaScissorThreshold()" />
    public float GetAlphaScissorThreshold() => ((SpriteBase3D)_host).GetAlphaScissorThreshold();

    /// <inheritdoc cref="SpriteBase3D.SetAlphaHashScale(float)" />
    public void SetAlphaHashScale(float @threshold) => ((SpriteBase3D)_host).SetAlphaHashScale(@threshold);

    /// <inheritdoc cref="SpriteBase3D.GetAlphaHashScale()" />
    public float GetAlphaHashScale() => ((SpriteBase3D)_host).GetAlphaHashScale();

    /// <inheritdoc cref="SpriteBase3D.SetAlphaAntialiasing(BaseMaterial3D.AlphaAntiAliasing)" />
    public void SetAlphaAntialiasing(BaseMaterial3D.AlphaAntiAliasing @alphaAA) => ((SpriteBase3D)_host).SetAlphaAntialiasing(@alphaAA);

    /// <inheritdoc cref="SpriteBase3D.GetAlphaAntialiasing()" />
    public BaseMaterial3D.AlphaAntiAliasing GetAlphaAntialiasing() => ((SpriteBase3D)_host).GetAlphaAntialiasing();

    /// <inheritdoc cref="SpriteBase3D.SetAlphaAntialiasingEdge(float)" />
    public void SetAlphaAntialiasingEdge(float @edge) => ((SpriteBase3D)_host).SetAlphaAntialiasingEdge(@edge);

    /// <inheritdoc cref="SpriteBase3D.GetAlphaAntialiasingEdge()" />
    public float GetAlphaAntialiasingEdge() => ((SpriteBase3D)_host).GetAlphaAntialiasingEdge();

    /// <inheritdoc cref="SpriteBase3D.SetBillboardMode(BaseMaterial3D.BillboardModeEnum)" />
    public void SetBillboardMode(BaseMaterial3D.BillboardModeEnum @mode) => ((SpriteBase3D)_host).SetBillboardMode(@mode);

    /// <inheritdoc cref="SpriteBase3D.GetBillboardMode()" />
    public BaseMaterial3D.BillboardModeEnum GetBillboardMode() => ((SpriteBase3D)_host).GetBillboardMode();

    /// <inheritdoc cref="SpriteBase3D.SetTextureFilter(BaseMaterial3D.TextureFilterEnum)" />
    public void SetTextureFilter(BaseMaterial3D.TextureFilterEnum @mode) => ((SpriteBase3D)_host).SetTextureFilter(@mode);

    /// <inheritdoc cref="SpriteBase3D.GetTextureFilter()" />
    public BaseMaterial3D.TextureFilterEnum GetTextureFilter() => ((SpriteBase3D)_host).GetTextureFilter();

    /// <inheritdoc cref="SpriteBase3D.GetItemRect()" />
    public Rect2 GetItemRect() => ((SpriteBase3D)_host).GetItemRect();

    /// <inheritdoc cref="SpriteBase3D.GenerateTriangleMesh()" />
    public TriangleMesh GenerateTriangleMesh() => ((SpriteBase3D)_host).GenerateTriangleMesh();

}
