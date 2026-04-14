#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CanvasItem" />
[Tool, GlobalClass]
public abstract partial class CanvasItemComponent : NodeComponent
{

    /// <inheritdoc cref="CanvasItem._Draw()" />
    public virtual void _Draw() { }

    /// <inheritdoc cref="CanvasItem.GetCanvasItem()" />
    public Rid GetCanvasItem() => ((CanvasItem)_host).GetCanvasItem();

    /// <inheritdoc cref="CanvasItem.SetVisible(bool)" />
    public void SetVisible(bool @visible) => ((CanvasItem)_host).SetVisible(@visible);

    /// <inheritdoc cref="CanvasItem.IsVisible()" />
    public bool IsVisible() => ((CanvasItem)_host).IsVisible();

    /// <inheritdoc cref="CanvasItem.IsVisibleInTree()" />
    public bool IsVisibleInTree() => ((CanvasItem)_host).IsVisibleInTree();

    /// <inheritdoc cref="CanvasItem.Show()" />
    public void Show() => ((CanvasItem)_host).Show();

    /// <inheritdoc cref="CanvasItem.Hide()" />
    public void Hide() => ((CanvasItem)_host).Hide();

    /// <inheritdoc cref="CanvasItem.QueueRedraw()" />
    public void QueueRedraw() => ((CanvasItem)_host).QueueRedraw();

    /// <inheritdoc cref="CanvasItem.MoveToFront()" />
    public void MoveToFront() => ((CanvasItem)_host).MoveToFront();

    /// <inheritdoc cref="CanvasItem.SetAsTopLevel(bool)" />
    public void SetAsTopLevel(bool @enable) => ((CanvasItem)_host).SetAsTopLevel(@enable);

    /// <inheritdoc cref="CanvasItem.IsSetAsTopLevel()" />
    public bool IsSetAsTopLevel() => ((CanvasItem)_host).IsSetAsTopLevel();

    /// <inheritdoc cref="CanvasItem.SetLightMask(int)" />
    public void SetLightMask(int @lightMask) => ((CanvasItem)_host).SetLightMask(@lightMask);

    /// <inheritdoc cref="CanvasItem.GetLightMask()" />
    public int GetLightMask() => ((CanvasItem)_host).GetLightMask();

    /// <inheritdoc cref="CanvasItem.SetModulate(Color)" />
    public void SetModulate(Color @modulate) => ((CanvasItem)_host).SetModulate(@modulate);

    /// <inheritdoc cref="CanvasItem.GetModulate()" />
    public Color GetModulate() => ((CanvasItem)_host).GetModulate();

    /// <inheritdoc cref="CanvasItem.SetSelfModulate(Color)" />
    public void SetSelfModulate(Color @selfModulate) => ((CanvasItem)_host).SetSelfModulate(@selfModulate);

    /// <inheritdoc cref="CanvasItem.GetSelfModulate()" />
    public Color GetSelfModulate() => ((CanvasItem)_host).GetSelfModulate();

    /// <inheritdoc cref="CanvasItem.SetZIndex(int)" />
    public void SetZIndex(int @zIndex) => ((CanvasItem)_host).SetZIndex(@zIndex);

    /// <inheritdoc cref="CanvasItem.GetZIndex()" />
    public int GetZIndex() => ((CanvasItem)_host).GetZIndex();

    /// <inheritdoc cref="CanvasItem.SetZAsRelative(bool)" />
    public void SetZAsRelative(bool @enable) => ((CanvasItem)_host).SetZAsRelative(@enable);

    /// <inheritdoc cref="CanvasItem.IsZRelative()" />
    public bool IsZRelative() => ((CanvasItem)_host).IsZRelative();

    /// <inheritdoc cref="CanvasItem.SetYSortEnabled(bool)" />
    public void SetYSortEnabled(bool @enabled) => ((CanvasItem)_host).SetYSortEnabled(@enabled);

    /// <inheritdoc cref="CanvasItem.IsYSortEnabled()" />
    public bool IsYSortEnabled() => ((CanvasItem)_host).IsYSortEnabled();

    /// <inheritdoc cref="CanvasItem.SetDrawBehindParent(bool)" />
    public void SetDrawBehindParent(bool @enable) => ((CanvasItem)_host).SetDrawBehindParent(@enable);

    /// <inheritdoc cref="CanvasItem.IsDrawBehindParentEnabled()" />
    public bool IsDrawBehindParentEnabled() => ((CanvasItem)_host).IsDrawBehindParentEnabled();

    /// <inheritdoc cref="CanvasItem.DrawLine(Vector2, Vector2, Color, float, bool)" />
    public void DrawLine(Vector2 @from, Vector2 @to, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawLine(@from, @to, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawDashedLine(Vector2, Vector2, Color, float, float, bool, bool)" />
    public void DrawDashedLine(Vector2 @from, Vector2 @to, Color @color, float @width, float @dash, bool @aligned, bool @antialiased) => ((CanvasItem)_host).DrawDashedLine(@from, @to, @color, @width, @dash, @aligned, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawPolyline(Vector2[], Color, float, bool)" />
    public void DrawPolyline(Vector2[] @points, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawPolyline(@points, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawPolyline(ReadOnlySpan{Vector2}, Color, float, bool)" />
    public void DrawPolyline(ReadOnlySpan<Vector2> @points, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawPolyline(@points, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawPolylineColors(Vector2[], Color[], float, bool)" />
    public void DrawPolylineColors(Vector2[] @points, Color[] @colors, float @width, bool @antialiased) => ((CanvasItem)_host).DrawPolylineColors(@points, @colors, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawPolylineColors(ReadOnlySpan{Vector2}, ReadOnlySpan{Color}, float, bool)" />
    public void DrawPolylineColors(ReadOnlySpan<Vector2> @points, ReadOnlySpan<Color> @colors, float @width, bool @antialiased) => ((CanvasItem)_host).DrawPolylineColors(@points, @colors, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawEllipseArc(Vector2, float, float, float, float, int, Color, float, bool)" />
    public void DrawEllipseArc(Vector2 @center, float @major, float @minor, float @startAngle, float @endAngle, int @pointCount, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawEllipseArc(@center, @major, @minor, @startAngle, @endAngle, @pointCount, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawArc(Vector2, float, float, float, int, Color, float, bool)" />
    public void DrawArc(Vector2 @center, float @radius, float @startAngle, float @endAngle, int @pointCount, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawArc(@center, @radius, @startAngle, @endAngle, @pointCount, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawMultiline(Vector2[], Color, float, bool)" />
    public void DrawMultiline(Vector2[] @points, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawMultiline(@points, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawMultiline(ReadOnlySpan{Vector2}, Color, float, bool)" />
    public void DrawMultiline(ReadOnlySpan<Vector2> @points, Color @color, float @width, bool @antialiased) => ((CanvasItem)_host).DrawMultiline(@points, @color, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawMultilineColors(Vector2[], Color[], float, bool)" />
    public void DrawMultilineColors(Vector2[] @points, Color[] @colors, float @width, bool @antialiased) => ((CanvasItem)_host).DrawMultilineColors(@points, @colors, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawMultilineColors(ReadOnlySpan{Vector2}, ReadOnlySpan{Color}, float, bool)" />
    public void DrawMultilineColors(ReadOnlySpan<Vector2> @points, ReadOnlySpan<Color> @colors, float @width, bool @antialiased) => ((CanvasItem)_host).DrawMultilineColors(@points, @colors, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawRect(Rect2, Color, bool, float, bool)" />
    public void DrawRect(Rect2 @rect, Color @color, bool @filled, float @width, bool @antialiased) => ((CanvasItem)_host).DrawRect(@rect, @color, @filled, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawCircle(Vector2, float, Color, bool, float, bool)" />
    public void DrawCircle(Vector2 @position, float @radius, Color @color, bool @filled, float @width, bool @antialiased) => ((CanvasItem)_host).DrawCircle(@position, @radius, @color, @filled, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawEllipse(Vector2, float, float, Color, bool, float, bool)" />
    public void DrawEllipse(Vector2 @position, float @major, float @minor, Color @color, bool @filled, float @width, bool @antialiased) => ((CanvasItem)_host).DrawEllipse(@position, @major, @minor, @color, @filled, @width, @antialiased);

    /// <inheritdoc cref="CanvasItem.DrawTexture(Texture2D, Vector2, Color?)" />
    public void DrawTexture(Texture2D @texture, Vector2 @position, Color? @modulate) => ((CanvasItem)_host).DrawTexture(@texture, @position, @modulate);

    /// <inheritdoc cref="CanvasItem.DrawTextureRect(Texture2D, Rect2, bool, Color?, bool)" />
    public void DrawTextureRect(Texture2D @texture, Rect2 @rect, bool @tile, Color? @modulate, bool @transpose) => ((CanvasItem)_host).DrawTextureRect(@texture, @rect, @tile, @modulate, @transpose);

    /// <inheritdoc cref="CanvasItem.DrawTextureRectRegion(Texture2D, Rect2, Rect2, Color?, bool, bool)" />
    public void DrawTextureRectRegion(Texture2D @texture, Rect2 @rect, Rect2 @srcRect, Color? @modulate, bool @transpose, bool @clipUV) => ((CanvasItem)_host).DrawTextureRectRegion(@texture, @rect, @srcRect, @modulate, @transpose, @clipUV);

    /// <inheritdoc cref="CanvasItem.DrawMsdfTextureRectRegion(Texture2D, Rect2, Rect2, Color?, double, double, double)" />
    public void DrawMsdfTextureRectRegion(Texture2D @texture, Rect2 @rect, Rect2 @srcRect, Color? @modulate, double @outline, double @pixelRange, double @scale) => ((CanvasItem)_host).DrawMsdfTextureRectRegion(@texture, @rect, @srcRect, @modulate, @outline, @pixelRange, @scale);

    /// <inheritdoc cref="CanvasItem.DrawLcdTextureRectRegion(Texture2D, Rect2, Rect2, Color?)" />
    public void DrawLcdTextureRectRegion(Texture2D @texture, Rect2 @rect, Rect2 @srcRect, Color? @modulate) => ((CanvasItem)_host).DrawLcdTextureRectRegion(@texture, @rect, @srcRect, @modulate);

    /// <inheritdoc cref="CanvasItem.DrawStyleBox(StyleBox, Rect2)" />
    public void DrawStyleBox(StyleBox @styleBox, Rect2 @rect) => ((CanvasItem)_host).DrawStyleBox(@styleBox, @rect);

    /// <inheritdoc cref="CanvasItem.DrawPrimitive(Vector2[], Color[], Vector2[], Texture2D)" />
    public void DrawPrimitive(Vector2[] @points, Color[] @colors, Vector2[] @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawPrimitive(@points, @colors, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawPrimitive(ReadOnlySpan{Vector2}, ReadOnlySpan{Color}, ReadOnlySpan{Vector2}, Texture2D)" />
    public void DrawPrimitive(ReadOnlySpan<Vector2> @points, ReadOnlySpan<Color> @colors, ReadOnlySpan<Vector2> @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawPrimitive(@points, @colors, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawPolygon(Vector2[], Color[], Vector2[], Texture2D)" />
    public void DrawPolygon(Vector2[] @points, Color[] @colors, Vector2[] @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawPolygon(@points, @colors, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawPolygon(ReadOnlySpan{Vector2}, ReadOnlySpan{Color}, ReadOnlySpan{Vector2}, Texture2D)" />
    public void DrawPolygon(ReadOnlySpan<Vector2> @points, ReadOnlySpan<Color> @colors, ReadOnlySpan<Vector2> @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawPolygon(@points, @colors, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawColoredPolygon(Vector2[], Color, Vector2[], Texture2D)" />
    public void DrawColoredPolygon(Vector2[] @points, Color @color, Vector2[] @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawColoredPolygon(@points, @color, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawColoredPolygon(ReadOnlySpan{Vector2}, Color, ReadOnlySpan{Vector2}, Texture2D)" />
    public void DrawColoredPolygon(ReadOnlySpan<Vector2> @points, Color @color, ReadOnlySpan<Vector2> @uvs, Texture2D @texture) => ((CanvasItem)_host).DrawColoredPolygon(@points, @color, @uvs, @texture);

    /// <inheritdoc cref="CanvasItem.DrawString(Font, Vector2, string, HorizontalAlignment, float, int, Color?, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation, float)" />
    public void DrawString(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, Color? @modulate, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation, float @oversampling) => ((CanvasItem)_host).DrawString(@font, @pos, @text, @alignment, @width, @fontSize, @modulate, @justificationFlags, @direction, @orientation, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawMultilineString(Font, Vector2, string, HorizontalAlignment, float, int, int, Color?, TextServer.LineBreakFlag, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation, float)" />
    public void DrawMultilineString(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @maxLines, Color? @modulate, TextServer.LineBreakFlag @brkFlags, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation, float @oversampling) => ((CanvasItem)_host).DrawMultilineString(@font, @pos, @text, @alignment, @width, @fontSize, @maxLines, @modulate, @brkFlags, @justificationFlags, @direction, @orientation, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawStringOutline(Font, Vector2, string, HorizontalAlignment, float, int, int, Color?, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation, float)" />
    public void DrawStringOutline(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @size, Color? @modulate, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation, float @oversampling) => ((CanvasItem)_host).DrawStringOutline(@font, @pos, @text, @alignment, @width, @fontSize, @size, @modulate, @justificationFlags, @direction, @orientation, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawMultilineStringOutline(Font, Vector2, string, HorizontalAlignment, float, int, int, int, Color?, TextServer.LineBreakFlag, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation, float)" />
    public void DrawMultilineStringOutline(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @maxLines, int @size, Color? @modulate, TextServer.LineBreakFlag @brkFlags, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation, float @oversampling) => ((CanvasItem)_host).DrawMultilineStringOutline(@font, @pos, @text, @alignment, @width, @fontSize, @maxLines, @size, @modulate, @brkFlags, @justificationFlags, @direction, @orientation, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawChar(Font, Vector2, string, int, Color?, float)" />
    public void DrawChar(Font @font, Vector2 @pos, string @char, int @fontSize, Color? @modulate, float @oversampling) => ((CanvasItem)_host).DrawChar(@font, @pos, @char, @fontSize, @modulate, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawCharOutline(Font, Vector2, string, int, int, Color?, float)" />
    public void DrawCharOutline(Font @font, Vector2 @pos, string @char, int @fontSize, int @size, Color? @modulate, float @oversampling) => ((CanvasItem)_host).DrawCharOutline(@font, @pos, @char, @fontSize, @size, @modulate, @oversampling);

    /// <inheritdoc cref="CanvasItem.DrawMesh(Mesh, Texture2D, Transform2D?, Color?)" />
    public void DrawMesh(Mesh @mesh, Texture2D @texture, Transform2D? @transform, Color? @modulate) => ((CanvasItem)_host).DrawMesh(@mesh, @texture, @transform, @modulate);

    /// <inheritdoc cref="CanvasItem.DrawMultimesh(MultiMesh, Texture2D)" />
    public void DrawMultimesh(MultiMesh @multimesh, Texture2D @texture) => ((CanvasItem)_host).DrawMultimesh(@multimesh, @texture);

    /// <inheritdoc cref="CanvasItem.DrawSetTransform(Vector2, float, Vector2?)" />
    public void DrawSetTransform(Vector2 @position, float @rotation, Vector2? @scale) => ((CanvasItem)_host).DrawSetTransform(@position, @rotation, @scale);

    /// <inheritdoc cref="CanvasItem.DrawSetTransformMatrix(Transform2D)" />
    public void DrawSetTransformMatrix(Transform2D @xform) => ((CanvasItem)_host).DrawSetTransformMatrix(@xform);

    /// <inheritdoc cref="CanvasItem.DrawAnimationSlice(double, double, double, double)" />
    public void DrawAnimationSlice(double @animationLength, double @sliceBegin, double @sliceEnd, double @offset) => ((CanvasItem)_host).DrawAnimationSlice(@animationLength, @sliceBegin, @sliceEnd, @offset);

    /// <inheritdoc cref="CanvasItem.DrawEndAnimation()" />
    public void DrawEndAnimation() => ((CanvasItem)_host).DrawEndAnimation();

    /// <inheritdoc cref="CanvasItem.GetTransform()" />
    public Transform2D GetTransform() => ((CanvasItem)_host).GetTransform();

    /// <inheritdoc cref="CanvasItem.GetGlobalTransform()" />
    public Transform2D GetGlobalTransform() => ((CanvasItem)_host).GetGlobalTransform();

    /// <inheritdoc cref="CanvasItem.GetGlobalTransformWithCanvas()" />
    public Transform2D GetGlobalTransformWithCanvas() => ((CanvasItem)_host).GetGlobalTransformWithCanvas();

    /// <inheritdoc cref="CanvasItem.GetViewportTransform()" />
    public Transform2D GetViewportTransform() => ((CanvasItem)_host).GetViewportTransform();

    /// <inheritdoc cref="CanvasItem.GetViewportRect()" />
    public Rect2 GetViewportRect() => ((CanvasItem)_host).GetViewportRect();

    /// <inheritdoc cref="CanvasItem.GetCanvasTransform()" />
    public Transform2D GetCanvasTransform() => ((CanvasItem)_host).GetCanvasTransform();

    /// <inheritdoc cref="CanvasItem.GetScreenTransform()" />
    public Transform2D GetScreenTransform() => ((CanvasItem)_host).GetScreenTransform();

    /// <inheritdoc cref="CanvasItem.GetLocalMousePosition()" />
    public Vector2 GetLocalMousePosition() => ((CanvasItem)_host).GetLocalMousePosition();

    /// <inheritdoc cref="CanvasItem.GetGlobalMousePosition()" />
    public Vector2 GetGlobalMousePosition() => ((CanvasItem)_host).GetGlobalMousePosition();

    /// <inheritdoc cref="CanvasItem.GetCanvas()" />
    public Rid GetCanvas() => ((CanvasItem)_host).GetCanvas();

    /// <inheritdoc cref="CanvasItem.GetCanvasLayerNode()" />
    public CanvasLayer GetCanvasLayerNode() => ((CanvasItem)_host).GetCanvasLayerNode();

    /// <inheritdoc cref="CanvasItem.GetWorld2D()" />
    public World2D GetWorld2D() => ((CanvasItem)_host).GetWorld2D();

    /// <inheritdoc cref="CanvasItem.SetMaterial(Material)" />
    public void SetMaterial(Material @material) => ((CanvasItem)_host).SetMaterial(@material);

    /// <inheritdoc cref="CanvasItem.GetMaterial()" />
    public Material GetMaterial() => ((CanvasItem)_host).GetMaterial();

    /// <inheritdoc cref="CanvasItem.SetInstanceShaderParameter(StringName, Variant)" />
    public void SetInstanceShaderParameter(StringName @name, Variant @value) => ((CanvasItem)_host).SetInstanceShaderParameter(@name, @value);

    /// <inheritdoc cref="CanvasItem.GetInstanceShaderParameter(StringName)" />
    public Variant GetInstanceShaderParameter(StringName @name) => ((CanvasItem)_host).GetInstanceShaderParameter(@name);

    /// <inheritdoc cref="CanvasItem.SetUseParentMaterial(bool)" />
    public void SetUseParentMaterial(bool @enable) => ((CanvasItem)_host).SetUseParentMaterial(@enable);

    /// <inheritdoc cref="CanvasItem.GetUseParentMaterial()" />
    public bool GetUseParentMaterial() => ((CanvasItem)_host).GetUseParentMaterial();

    /// <inheritdoc cref="CanvasItem.SetNotifyLocalTransform(bool)" />
    public void SetNotifyLocalTransform(bool @enable) => ((CanvasItem)_host).SetNotifyLocalTransform(@enable);

    /// <inheritdoc cref="CanvasItem.IsLocalTransformNotificationEnabled()" />
    public bool IsLocalTransformNotificationEnabled() => ((CanvasItem)_host).IsLocalTransformNotificationEnabled();

    /// <inheritdoc cref="CanvasItem.SetNotifyTransform(bool)" />
    public void SetNotifyTransform(bool @enable) => ((CanvasItem)_host).SetNotifyTransform(@enable);

    /// <inheritdoc cref="CanvasItem.IsTransformNotificationEnabled()" />
    public bool IsTransformNotificationEnabled() => ((CanvasItem)_host).IsTransformNotificationEnabled();

    /// <inheritdoc cref="CanvasItem.ForceUpdateTransform()" />
    public void ForceUpdateTransform() => ((CanvasItem)_host).ForceUpdateTransform();

    /// <inheritdoc cref="CanvasItem.MakeCanvasPositionLocal(Vector2)" />
    public Vector2 MakeCanvasPositionLocal(Vector2 @viewportPoint) => ((CanvasItem)_host).MakeCanvasPositionLocal(@viewportPoint);

    /// <inheritdoc cref="CanvasItem.MakeInputLocal(InputEvent)" />
    public InputEvent MakeInputLocal(InputEvent @event) => ((CanvasItem)_host).MakeInputLocal(@event);

    /// <inheritdoc cref="CanvasItem.SetVisibilityLayer(uint)" />
    public void SetVisibilityLayer(uint @layer) => ((CanvasItem)_host).SetVisibilityLayer(@layer);

    /// <inheritdoc cref="CanvasItem.GetVisibilityLayer()" />
    public uint GetVisibilityLayer() => ((CanvasItem)_host).GetVisibilityLayer();

    /// <inheritdoc cref="CanvasItem.SetVisibilityLayerBit(uint, bool)" />
    public void SetVisibilityLayerBit(uint @layer, bool @enabled) => ((CanvasItem)_host).SetVisibilityLayerBit(@layer, @enabled);

    /// <inheritdoc cref="CanvasItem.GetVisibilityLayerBit(uint)" />
    public bool GetVisibilityLayerBit(uint @layer) => ((CanvasItem)_host).GetVisibilityLayerBit(@layer);

    /// <inheritdoc cref="CanvasItem.SetTextureFilter(CanvasItem.TextureFilterEnum)" />
    public void SetTextureFilter(CanvasItem.TextureFilterEnum @mode) => ((CanvasItem)_host).SetTextureFilter(@mode);

    /// <inheritdoc cref="CanvasItem.GetTextureFilter()" />
    public CanvasItem.TextureFilterEnum GetTextureFilter() => ((CanvasItem)_host).GetTextureFilter();

    /// <inheritdoc cref="CanvasItem.SetTextureRepeat(CanvasItem.TextureRepeatEnum)" />
    public void SetTextureRepeat(CanvasItem.TextureRepeatEnum @mode) => ((CanvasItem)_host).SetTextureRepeat(@mode);

    /// <inheritdoc cref="CanvasItem.GetTextureRepeat()" />
    public CanvasItem.TextureRepeatEnum GetTextureRepeat() => ((CanvasItem)_host).GetTextureRepeat();

    /// <inheritdoc cref="CanvasItem.SetClipChildrenMode(CanvasItem.ClipChildrenMode)" />
    public void SetClipChildrenMode(CanvasItem.ClipChildrenMode @mode) => ((CanvasItem)_host).SetClipChildrenMode(@mode);

    /// <inheritdoc cref="CanvasItem.GetClipChildrenMode()" />
    public CanvasItem.ClipChildrenMode GetClipChildrenMode() => ((CanvasItem)_host).GetClipChildrenMode();

    /// <inheritdoc cref="CanvasItem.DrawMultilineColors(Vector2[], Color[], float)" />
    public void DrawMultilineColors(Vector2[] @points, Color[] @colors, float @width) => ((CanvasItem)_host).DrawMultilineColors(@points, @colors, @width);

    /// <inheritdoc cref="CanvasItem.DrawMultilineColors(ReadOnlySpan{Vector2}, ReadOnlySpan{Color}, float)" />
    public void DrawMultilineColors(ReadOnlySpan<Vector2> @points, ReadOnlySpan<Color> @colors, float @width) => ((CanvasItem)_host).DrawMultilineColors(@points, @colors, @width);

    /// <inheritdoc cref="CanvasItem.DrawMultiline(Vector2[], Color, float)" />
    public void DrawMultiline(Vector2[] @points, Color @color, float @width) => ((CanvasItem)_host).DrawMultiline(@points, @color, @width);

    /// <inheritdoc cref="CanvasItem.DrawMultiline(ReadOnlySpan{Vector2}, Color, float)" />
    public void DrawMultiline(ReadOnlySpan<Vector2> @points, Color @color, float @width) => ((CanvasItem)_host).DrawMultiline(@points, @color, @width);

    /// <inheritdoc cref="CanvasItem.DrawDashedLine(Vector2, Vector2, Color, float, float, bool)" />
    public void DrawDashedLine(Vector2 @from, Vector2 @to, Color @color, float @width, float @dash, bool @aligned) => ((CanvasItem)_host).DrawDashedLine(@from, @to, @color, @width, @dash, @aligned);

    /// <inheritdoc cref="CanvasItem.DrawRect(Rect2, Color, bool, float)" />
    public void DrawRect(Rect2 @rect, Color @color, bool @filled, float @width) => ((CanvasItem)_host).DrawRect(@rect, @color, @filled, @width);

    /// <inheritdoc cref="CanvasItem.DrawCircle(Vector2, float, Color)" />
    public void DrawCircle(Vector2 @position, float @radius, Color @color) => ((CanvasItem)_host).DrawCircle(@position, @radius, @color);

    /// <inheritdoc cref="CanvasItem.DrawCharOutline(Font, Vector2, string, int, int, Color?)" />
    public void DrawCharOutline(Font @font, Vector2 @pos, string @char, int @fontSize, int @size, Color? @modulate) => ((CanvasItem)_host).DrawCharOutline(@font, @pos, @char, @fontSize, @size, @modulate);

    /// <inheritdoc cref="CanvasItem.DrawChar(Font, Vector2, string, int, Color?)" />
    public void DrawChar(Font @font, Vector2 @pos, string @char, int @fontSize, Color? @modulate) => ((CanvasItem)_host).DrawChar(@font, @pos, @char, @fontSize, @modulate);

    /// <inheritdoc cref="CanvasItem.DrawMultilineStringOutline(Font, Vector2, string, HorizontalAlignment, float, int, int, int, Color?, TextServer.LineBreakFlag, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation)" />
    public void DrawMultilineStringOutline(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @maxLines, int @size, Color? @modulate, TextServer.LineBreakFlag @brkFlags, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation) => ((CanvasItem)_host).DrawMultilineStringOutline(@font, @pos, @text, @alignment, @width, @fontSize, @maxLines, @size, @modulate, @brkFlags, @justificationFlags, @direction, @orientation);

    /// <inheritdoc cref="CanvasItem.DrawStringOutline(Font, Vector2, string, HorizontalAlignment, float, int, int, Color?, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation)" />
    public void DrawStringOutline(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @size, Color? @modulate, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation) => ((CanvasItem)_host).DrawStringOutline(@font, @pos, @text, @alignment, @width, @fontSize, @size, @modulate, @justificationFlags, @direction, @orientation);

    /// <inheritdoc cref="CanvasItem.DrawMultilineString(Font, Vector2, string, HorizontalAlignment, float, int, int, Color?, TextServer.LineBreakFlag, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation)" />
    public void DrawMultilineString(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, int @maxLines, Color? @modulate, TextServer.LineBreakFlag @brkFlags, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation) => ((CanvasItem)_host).DrawMultilineString(@font, @pos, @text, @alignment, @width, @fontSize, @maxLines, @modulate, @brkFlags, @justificationFlags, @direction, @orientation);

    /// <inheritdoc cref="CanvasItem.DrawString(Font, Vector2, string, HorizontalAlignment, float, int, Color?, TextServer.JustificationFlag, TextServer.Direction, TextServer.Orientation)" />
    public void DrawString(Font @font, Vector2 @pos, string @text, HorizontalAlignment @alignment, float @width, int @fontSize, Color? @modulate, TextServer.JustificationFlag @justificationFlags, TextServer.Direction @direction, TextServer.Orientation @orientation) => ((CanvasItem)_host).DrawString(@font, @pos, @text, @alignment, @width, @fontSize, @modulate, @justificationFlags, @direction, @orientation);

}
