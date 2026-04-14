#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Label3D" />
[Tool, GlobalClass]
public abstract partial class Label3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="Label3D.SetHorizontalAlignment(HorizontalAlignment)" />
    public void SetHorizontalAlignment(HorizontalAlignment @alignment) => ((Label3D)_host).SetHorizontalAlignment(@alignment);

    /// <inheritdoc cref="Label3D.GetHorizontalAlignment()" />
    public HorizontalAlignment GetHorizontalAlignment() => ((Label3D)_host).GetHorizontalAlignment();

    /// <inheritdoc cref="Label3D.SetVerticalAlignment(VerticalAlignment)" />
    public void SetVerticalAlignment(VerticalAlignment @alignment) => ((Label3D)_host).SetVerticalAlignment(@alignment);

    /// <inheritdoc cref="Label3D.GetVerticalAlignment()" />
    public VerticalAlignment GetVerticalAlignment() => ((Label3D)_host).GetVerticalAlignment();

    /// <inheritdoc cref="Label3D.SetModulate(Color)" />
    public void SetModulate(Color @modulate) => ((Label3D)_host).SetModulate(@modulate);

    /// <inheritdoc cref="Label3D.GetModulate()" />
    public Color GetModulate() => ((Label3D)_host).GetModulate();

    /// <inheritdoc cref="Label3D.SetOutlineModulate(Color)" />
    public void SetOutlineModulate(Color @modulate) => ((Label3D)_host).SetOutlineModulate(@modulate);

    /// <inheritdoc cref="Label3D.GetOutlineModulate()" />
    public Color GetOutlineModulate() => ((Label3D)_host).GetOutlineModulate();

    /// <inheritdoc cref="Label3D.SetText(string)" />
    public void SetText(string @text) => ((Label3D)_host).SetText(@text);

    /// <inheritdoc cref="Label3D.GetText()" />
    public string GetText() => ((Label3D)_host).GetText();

    /// <inheritdoc cref="Label3D.SetTextDirection(TextServer.Direction)" />
    public void SetTextDirection(TextServer.Direction @direction) => ((Label3D)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="Label3D.GetTextDirection()" />
    public TextServer.Direction GetTextDirection() => ((Label3D)_host).GetTextDirection();

    /// <inheritdoc cref="Label3D.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((Label3D)_host).SetLanguage(@language);

    /// <inheritdoc cref="Label3D.GetLanguage()" />
    public string GetLanguage() => ((Label3D)_host).GetLanguage();

    /// <inheritdoc cref="Label3D.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((Label3D)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="Label3D.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((Label3D)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="Label3D.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((Label3D)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="Label3D.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((Label3D)_host).GetStructuredTextBidiOverrideOptions();

    /// <inheritdoc cref="Label3D.SetUppercase(bool)" />
    public void SetUppercase(bool @enable) => ((Label3D)_host).SetUppercase(@enable);

    /// <inheritdoc cref="Label3D.IsUppercase()" />
    public bool IsUppercase() => ((Label3D)_host).IsUppercase();

    /// <inheritdoc cref="Label3D.SetRenderPriority(int)" />
    public void SetRenderPriority(int @priority) => ((Label3D)_host).SetRenderPriority(@priority);

    /// <inheritdoc cref="Label3D.GetRenderPriority()" />
    public int GetRenderPriority() => ((Label3D)_host).GetRenderPriority();

    /// <inheritdoc cref="Label3D.SetOutlineRenderPriority(int)" />
    public void SetOutlineRenderPriority(int @priority) => ((Label3D)_host).SetOutlineRenderPriority(@priority);

    /// <inheritdoc cref="Label3D.GetOutlineRenderPriority()" />
    public int GetOutlineRenderPriority() => ((Label3D)_host).GetOutlineRenderPriority();

    /// <inheritdoc cref="Label3D.SetFont(Font)" />
    public void SetFont(Font @font) => ((Label3D)_host).SetFont(@font);

    /// <inheritdoc cref="Label3D.GetFont()" />
    public Font GetFont() => ((Label3D)_host).GetFont();

    /// <inheritdoc cref="Label3D.SetFontSize(int)" />
    public void SetFontSize(int @size) => ((Label3D)_host).SetFontSize(@size);

    /// <inheritdoc cref="Label3D.GetFontSize()" />
    public int GetFontSize() => ((Label3D)_host).GetFontSize();

    /// <inheritdoc cref="Label3D.SetOutlineSize(int)" />
    public void SetOutlineSize(int @outlineSize) => ((Label3D)_host).SetOutlineSize(@outlineSize);

    /// <inheritdoc cref="Label3D.GetOutlineSize()" />
    public int GetOutlineSize() => ((Label3D)_host).GetOutlineSize();

    /// <inheritdoc cref="Label3D.SetLineSpacing(float)" />
    public void SetLineSpacing(float @lineSpacing) => ((Label3D)_host).SetLineSpacing(@lineSpacing);

    /// <inheritdoc cref="Label3D.GetLineSpacing()" />
    public float GetLineSpacing() => ((Label3D)_host).GetLineSpacing();

    /// <inheritdoc cref="Label3D.SetAutowrapMode(TextServer.AutowrapMode)" />
    public void SetAutowrapMode(TextServer.AutowrapMode @autowrapMode) => ((Label3D)_host).SetAutowrapMode(@autowrapMode);

    /// <inheritdoc cref="Label3D.GetAutowrapMode()" />
    public TextServer.AutowrapMode GetAutowrapMode() => ((Label3D)_host).GetAutowrapMode();

    /// <inheritdoc cref="Label3D.SetAutowrapTrimFlags(TextServer.LineBreakFlag)" />
    public void SetAutowrapTrimFlags(TextServer.LineBreakFlag @autowrapTrimFlags) => ((Label3D)_host).SetAutowrapTrimFlags(@autowrapTrimFlags);

    /// <inheritdoc cref="Label3D.GetAutowrapTrimFlags()" />
    public TextServer.LineBreakFlag GetAutowrapTrimFlags() => ((Label3D)_host).GetAutowrapTrimFlags();

    /// <inheritdoc cref="Label3D.SetJustificationFlags(TextServer.JustificationFlag)" />
    public void SetJustificationFlags(TextServer.JustificationFlag @justificationFlags) => ((Label3D)_host).SetJustificationFlags(@justificationFlags);

    /// <inheritdoc cref="Label3D.GetJustificationFlags()" />
    public TextServer.JustificationFlag GetJustificationFlags() => ((Label3D)_host).GetJustificationFlags();

    /// <inheritdoc cref="Label3D.SetWidth(float)" />
    public void SetWidth(float @width) => ((Label3D)_host).SetWidth(@width);

    /// <inheritdoc cref="Label3D.GetWidth()" />
    public float GetWidth() => ((Label3D)_host).GetWidth();

    /// <inheritdoc cref="Label3D.SetPixelSize(float)" />
    public void SetPixelSize(float @pixelSize) => ((Label3D)_host).SetPixelSize(@pixelSize);

    /// <inheritdoc cref="Label3D.GetPixelSize()" />
    public float GetPixelSize() => ((Label3D)_host).GetPixelSize();

    /// <inheritdoc cref="Label3D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((Label3D)_host).SetOffset(@offset);

    /// <inheritdoc cref="Label3D.GetOffset()" />
    public Vector2 GetOffset() => ((Label3D)_host).GetOffset();

    /// <inheritdoc cref="Label3D.SetDrawFlag(Label3D.DrawFlags, bool)" />
    public void SetDrawFlag(Label3D.DrawFlags @flag, bool @enabled) => ((Label3D)_host).SetDrawFlag(@flag, @enabled);

    /// <inheritdoc cref="Label3D.GetDrawFlag(Label3D.DrawFlags)" />
    public bool GetDrawFlag(Label3D.DrawFlags @flag) => ((Label3D)_host).GetDrawFlag(@flag);

    /// <inheritdoc cref="Label3D.SetBillboardMode(BaseMaterial3D.BillboardModeEnum)" />
    public void SetBillboardMode(BaseMaterial3D.BillboardModeEnum @mode) => ((Label3D)_host).SetBillboardMode(@mode);

    /// <inheritdoc cref="Label3D.GetBillboardMode()" />
    public BaseMaterial3D.BillboardModeEnum GetBillboardMode() => ((Label3D)_host).GetBillboardMode();

    /// <inheritdoc cref="Label3D.SetAlphaCutMode(Label3D.AlphaCutMode)" />
    public void SetAlphaCutMode(Label3D.AlphaCutMode @mode) => ((Label3D)_host).SetAlphaCutMode(@mode);

    /// <inheritdoc cref="Label3D.GetAlphaCutMode()" />
    public Label3D.AlphaCutMode GetAlphaCutMode() => ((Label3D)_host).GetAlphaCutMode();

    /// <inheritdoc cref="Label3D.SetAlphaScissorThreshold(float)" />
    public void SetAlphaScissorThreshold(float @threshold) => ((Label3D)_host).SetAlphaScissorThreshold(@threshold);

    /// <inheritdoc cref="Label3D.GetAlphaScissorThreshold()" />
    public float GetAlphaScissorThreshold() => ((Label3D)_host).GetAlphaScissorThreshold();

    /// <inheritdoc cref="Label3D.SetAlphaHashScale(float)" />
    public void SetAlphaHashScale(float @threshold) => ((Label3D)_host).SetAlphaHashScale(@threshold);

    /// <inheritdoc cref="Label3D.GetAlphaHashScale()" />
    public float GetAlphaHashScale() => ((Label3D)_host).GetAlphaHashScale();

    /// <inheritdoc cref="Label3D.SetAlphaAntialiasing(BaseMaterial3D.AlphaAntiAliasing)" />
    public void SetAlphaAntialiasing(BaseMaterial3D.AlphaAntiAliasing @alphaAA) => ((Label3D)_host).SetAlphaAntialiasing(@alphaAA);

    /// <inheritdoc cref="Label3D.GetAlphaAntialiasing()" />
    public BaseMaterial3D.AlphaAntiAliasing GetAlphaAntialiasing() => ((Label3D)_host).GetAlphaAntialiasing();

    /// <inheritdoc cref="Label3D.SetAlphaAntialiasingEdge(float)" />
    public void SetAlphaAntialiasingEdge(float @edge) => ((Label3D)_host).SetAlphaAntialiasingEdge(@edge);

    /// <inheritdoc cref="Label3D.GetAlphaAntialiasingEdge()" />
    public float GetAlphaAntialiasingEdge() => ((Label3D)_host).GetAlphaAntialiasingEdge();

    /// <inheritdoc cref="Label3D.SetTextureFilter(BaseMaterial3D.TextureFilterEnum)" />
    public void SetTextureFilter(BaseMaterial3D.TextureFilterEnum @mode) => ((Label3D)_host).SetTextureFilter(@mode);

    /// <inheritdoc cref="Label3D.GetTextureFilter()" />
    public BaseMaterial3D.TextureFilterEnum GetTextureFilter() => ((Label3D)_host).GetTextureFilter();

    /// <inheritdoc cref="Label3D.GenerateTriangleMesh()" />
    public TriangleMesh GenerateTriangleMesh() => ((Label3D)_host).GenerateTriangleMesh();

}
