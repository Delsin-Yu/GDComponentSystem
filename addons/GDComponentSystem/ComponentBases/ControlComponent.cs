#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Control" />
[Tool, GlobalClass]
public abstract partial class ControlComponent : CanvasItemComponent
{

    /// <inheritdoc cref="Control._AccessibilityGetContextualInfo()" />
    public virtual string _AccessibilityGetContextualInfo() => ((Control)_host)._AccessibilityGetContextualInfo();

    /// <inheritdoc cref="Control._CanDropData(Vector2, Variant)" />
    public virtual bool _CanDropData(Vector2 @atPosition, Variant @data) => ((Control)_host)._CanDropData(@atPosition, @data);

    /// <inheritdoc cref="Control._DropData(Vector2, Variant)" />
    public virtual void _DropData(Vector2 @atPosition, Variant @data) { }

    /// <inheritdoc cref="Control._GetAccessibilityContainerName(Node)" />
    public virtual string _GetAccessibilityContainerName(Node @node) => ((Control)_host)._GetAccessibilityContainerName(@node);

    /// <inheritdoc cref="Control._GetDragData(Vector2)" />
    public virtual Variant _GetDragData(Vector2 @atPosition) => ((Control)_host)._GetDragData(@atPosition);

    /// <inheritdoc cref="Control._GetMinimumSize()" />
    public virtual Vector2 _GetMinimumSize() => ((Control)_host)._GetMinimumSize();

    /// <inheritdoc cref="Control._GetTooltip(Vector2)" />
    public virtual string _GetTooltip(Vector2 @atPosition) => ((Control)_host)._GetTooltip(@atPosition);

    /// <inheritdoc cref="Control._GuiInput(InputEvent)" />
    public virtual void _GuiInput(InputEvent @event) { }

    /// <inheritdoc cref="Control._HasPoint(Vector2)" />
    public virtual bool _HasPoint(Vector2 @point) => ((Control)_host)._HasPoint(@point);

    /// <inheritdoc cref="Control._MakeCustomTooltip(string)" />
    public virtual GodotObject _MakeCustomTooltip(string @forText) => ((Control)_host)._MakeCustomTooltip(@forText);

    /// <inheritdoc cref="Control._StructuredTextParser(Array, string)" />
    public virtual Array<Vector3I> _StructuredTextParser(Array @args, string @text) => ((Control)_host)._StructuredTextParser(@args, @text);

    /// <inheritdoc cref="Control.AcceptEvent()" />
    public void AcceptEvent() => ((Control)_host).AcceptEvent();

    /// <inheritdoc cref="Control.GetMinimumSize()" />
    public Vector2 GetMinimumSize() => ((Control)_host).GetMinimumSize();

    /// <inheritdoc cref="Control.GetCombinedMinimumSize()" />
    public Vector2 GetCombinedMinimumSize() => ((Control)_host).GetCombinedMinimumSize();

    /// <inheritdoc cref="Control.SetAnchorsPreset(Control.LayoutPreset, bool)" />
    public void SetAnchorsPreset(Control.LayoutPreset @preset, bool @keepOffsets) => ((Control)_host).SetAnchorsPreset(@preset, @keepOffsets);

    /// <inheritdoc cref="Control.SetOffsetsPreset(Control.LayoutPreset, Control.LayoutPresetMode, int)" />
    public void SetOffsetsPreset(Control.LayoutPreset @preset, Control.LayoutPresetMode @resizeMode, int @margin) => ((Control)_host).SetOffsetsPreset(@preset, @resizeMode, @margin);

    /// <inheritdoc cref="Control.SetAnchorsAndOffsetsPreset(Control.LayoutPreset, Control.LayoutPresetMode, int)" />
    public void SetAnchorsAndOffsetsPreset(Control.LayoutPreset @preset, Control.LayoutPresetMode @resizeMode, int @margin) => ((Control)_host).SetAnchorsAndOffsetsPreset(@preset, @resizeMode, @margin);

    /// <inheritdoc cref="Control.SetAnchor(Side, float, bool, bool)" />
    public void SetAnchor(Side @side, float @anchor, bool @keepOffset, bool @pushOppositeAnchor) => ((Control)_host).SetAnchor(@side, @anchor, @keepOffset, @pushOppositeAnchor);

    /// <inheritdoc cref="Control.GetAnchor(Side)" />
    public float GetAnchor(Side @side) => ((Control)_host).GetAnchor(@side);

    /// <inheritdoc cref="Control.SetOffset(Side, float)" />
    public void SetOffset(Side @side, float @offset) => ((Control)_host).SetOffset(@side, @offset);

    /// <inheritdoc cref="Control.GetOffset(Side)" />
    public float GetOffset(Side @offset) => ((Control)_host).GetOffset(@offset);

    /// <inheritdoc cref="Control.SetAnchorAndOffset(Side, float, float, bool)" />
    public void SetAnchorAndOffset(Side @side, float @anchor, float @offset, bool @pushOppositeAnchor) => ((Control)_host).SetAnchorAndOffset(@side, @anchor, @offset, @pushOppositeAnchor);

    /// <inheritdoc cref="Control.SetBegin(Vector2)" />
    public void SetBegin(Vector2 @position) => ((Control)_host).SetBegin(@position);

    /// <inheritdoc cref="Control.SetEnd(Vector2)" />
    public void SetEnd(Vector2 @position) => ((Control)_host).SetEnd(@position);

    /// <inheritdoc cref="Control.SetPosition(Vector2, bool)" />
    public void SetPosition(Vector2 @position, bool @keepOffsets) => ((Control)_host).SetPosition(@position, @keepOffsets);

    /// <inheritdoc cref="Control.SetSize(Vector2, bool)" />
    public void SetSize(Vector2 @size, bool @keepOffsets) => ((Control)_host).SetSize(@size, @keepOffsets);

    /// <inheritdoc cref="Control.ResetSize()" />
    public void ResetSize() => ((Control)_host).ResetSize();

    /// <inheritdoc cref="Control.SetCustomMinimumSize(Vector2)" />
    public void SetCustomMinimumSize(Vector2 @size) => ((Control)_host).SetCustomMinimumSize(@size);

    /// <inheritdoc cref="Control.SetGlobalPosition(Vector2, bool)" />
    public void SetGlobalPosition(Vector2 @position, bool @keepOffsets) => ((Control)_host).SetGlobalPosition(@position, @keepOffsets);

    /// <inheritdoc cref="Control.SetRotation(float)" />
    public void SetRotation(float @radians) => ((Control)_host).SetRotation(@radians);

    /// <inheritdoc cref="Control.SetRotationDegrees(float)" />
    public void SetRotationDegrees(float @degrees) => ((Control)_host).SetRotationDegrees(@degrees);

    /// <inheritdoc cref="Control.SetScale(Vector2)" />
    public void SetScale(Vector2 @scale) => ((Control)_host).SetScale(@scale);

    /// <inheritdoc cref="Control.SetPivotOffset(Vector2)" />
    public void SetPivotOffset(Vector2 @pivotOffset) => ((Control)_host).SetPivotOffset(@pivotOffset);

    /// <inheritdoc cref="Control.SetPivotOffsetRatio(Vector2)" />
    public void SetPivotOffsetRatio(Vector2 @ratio) => ((Control)_host).SetPivotOffsetRatio(@ratio);

    /// <inheritdoc cref="Control.GetBegin()" />
    public Vector2 GetBegin() => ((Control)_host).GetBegin();

    /// <inheritdoc cref="Control.GetEnd()" />
    public Vector2 GetEnd() => ((Control)_host).GetEnd();

    /// <inheritdoc cref="Control.GetPosition()" />
    public Vector2 GetPosition() => ((Control)_host).GetPosition();

    /// <inheritdoc cref="Control.GetSize()" />
    public Vector2 GetSize() => ((Control)_host).GetSize();

    /// <inheritdoc cref="Control.GetRotation()" />
    public float GetRotation() => ((Control)_host).GetRotation();

    /// <inheritdoc cref="Control.GetRotationDegrees()" />
    public float GetRotationDegrees() => ((Control)_host).GetRotationDegrees();

    /// <inheritdoc cref="Control.GetScale()" />
    public Vector2 GetScale() => ((Control)_host).GetScale();

    /// <inheritdoc cref="Control.GetPivotOffset()" />
    public Vector2 GetPivotOffset() => ((Control)_host).GetPivotOffset();

    /// <inheritdoc cref="Control.GetPivotOffsetRatio()" />
    public Vector2 GetPivotOffsetRatio() => ((Control)_host).GetPivotOffsetRatio();

    /// <inheritdoc cref="Control.GetCombinedPivotOffset()" />
    public Vector2 GetCombinedPivotOffset() => ((Control)_host).GetCombinedPivotOffset();

    /// <inheritdoc cref="Control.GetCustomMinimumSize()" />
    public Vector2 GetCustomMinimumSize() => ((Control)_host).GetCustomMinimumSize();

    /// <inheritdoc cref="Control.GetParentAreaSize()" />
    public Vector2 GetParentAreaSize() => ((Control)_host).GetParentAreaSize();

    /// <inheritdoc cref="Control.GetGlobalPosition()" />
    public Vector2 GetGlobalPosition() => ((Control)_host).GetGlobalPosition();

    /// <inheritdoc cref="Control.GetScreenPosition()" />
    public Vector2 GetScreenPosition() => ((Control)_host).GetScreenPosition();

    /// <inheritdoc cref="Control.GetRect()" />
    public Rect2 GetRect() => ((Control)_host).GetRect();

    /// <inheritdoc cref="Control.GetGlobalRect()" />
    public Rect2 GetGlobalRect() => ((Control)_host).GetGlobalRect();

    /// <inheritdoc cref="Control.SetFocusMode(Control.FocusModeEnum)" />
    public void SetFocusMode(Control.FocusModeEnum @mode) => ((Control)_host).SetFocusMode(@mode);

    /// <inheritdoc cref="Control.GetFocusMode()" />
    public Control.FocusModeEnum GetFocusMode() => ((Control)_host).GetFocusMode();

    /// <inheritdoc cref="Control.GetFocusModeWithOverride()" />
    public Control.FocusModeEnum GetFocusModeWithOverride() => ((Control)_host).GetFocusModeWithOverride();

    /// <inheritdoc cref="Control.SetFocusBehaviorRecursive(Control.FocusBehaviorRecursiveEnum)" />
    public void SetFocusBehaviorRecursive(Control.FocusBehaviorRecursiveEnum @focusBehaviorRecursive) => ((Control)_host).SetFocusBehaviorRecursive(@focusBehaviorRecursive);

    /// <inheritdoc cref="Control.GetFocusBehaviorRecursive()" />
    public Control.FocusBehaviorRecursiveEnum GetFocusBehaviorRecursive() => ((Control)_host).GetFocusBehaviorRecursive();

    /// <inheritdoc cref="Control.HasFocus(bool)" />
    public bool HasFocus(bool @ignoreHiddenFocus) => ((Control)_host).HasFocus(@ignoreHiddenFocus);

    /// <inheritdoc cref="Control.GrabFocus(bool)" />
    public void GrabFocus(bool @hideFocus) => ((Control)_host).GrabFocus(@hideFocus);

    /// <inheritdoc cref="Control.ReleaseFocus()" />
    public void ReleaseFocus() => ((Control)_host).ReleaseFocus();

    /// <inheritdoc cref="Control.FindPrevValidFocus()" />
    public Control FindPrevValidFocus() => ((Control)_host).FindPrevValidFocus();

    /// <inheritdoc cref="Control.FindNextValidFocus()" />
    public Control FindNextValidFocus() => ((Control)_host).FindNextValidFocus();

    /// <inheritdoc cref="Control.FindValidFocusNeighbor(Side)" />
    public Control FindValidFocusNeighbor(Side @side) => ((Control)_host).FindValidFocusNeighbor(@side);

    /// <inheritdoc cref="Control.SetHSizeFlags(Control.SizeFlags)" />
    public void SetHSizeFlags(Control.SizeFlags @flags) => ((Control)_host).SetHSizeFlags(@flags);

    /// <inheritdoc cref="Control.GetHSizeFlags()" />
    public Control.SizeFlags GetHSizeFlags() => ((Control)_host).GetHSizeFlags();

    /// <inheritdoc cref="Control.SetStretchRatio(float)" />
    public void SetStretchRatio(float @ratio) => ((Control)_host).SetStretchRatio(@ratio);

    /// <inheritdoc cref="Control.GetStretchRatio()" />
    public float GetStretchRatio() => ((Control)_host).GetStretchRatio();

    /// <inheritdoc cref="Control.SetVSizeFlags(Control.SizeFlags)" />
    public void SetVSizeFlags(Control.SizeFlags @flags) => ((Control)_host).SetVSizeFlags(@flags);

    /// <inheritdoc cref="Control.GetVSizeFlags()" />
    public Control.SizeFlags GetVSizeFlags() => ((Control)_host).GetVSizeFlags();

    /// <inheritdoc cref="Control.SetTheme(Theme)" />
    public void SetTheme(Theme @theme) => ((Control)_host).SetTheme(@theme);

    /// <inheritdoc cref="Control.GetTheme()" />
    public Theme GetTheme() => ((Control)_host).GetTheme();

    /// <inheritdoc cref="Control.SetThemeTypeVariation(StringName)" />
    public void SetThemeTypeVariation(StringName @themeType) => ((Control)_host).SetThemeTypeVariation(@themeType);

    /// <inheritdoc cref="Control.GetThemeTypeVariation()" />
    public StringName GetThemeTypeVariation() => ((Control)_host).GetThemeTypeVariation();

    /// <inheritdoc cref="Control.BeginBulkThemeOverride()" />
    public void BeginBulkThemeOverride() => ((Control)_host).BeginBulkThemeOverride();

    /// <inheritdoc cref="Control.EndBulkThemeOverride()" />
    public void EndBulkThemeOverride() => ((Control)_host).EndBulkThemeOverride();

    /// <inheritdoc cref="Control.AddThemeIconOverride(StringName, Texture2D)" />
    public void AddThemeIconOverride(StringName @name, Texture2D @texture) => ((Control)_host).AddThemeIconOverride(@name, @texture);

    /// <inheritdoc cref="Control.AddThemeStyleboxOverride(StringName, StyleBox)" />
    public void AddThemeStyleboxOverride(StringName @name, StyleBox @stylebox) => ((Control)_host).AddThemeStyleboxOverride(@name, @stylebox);

    /// <inheritdoc cref="Control.AddThemeFontOverride(StringName, Font)" />
    public void AddThemeFontOverride(StringName @name, Font @font) => ((Control)_host).AddThemeFontOverride(@name, @font);

    /// <inheritdoc cref="Control.AddThemeFontSizeOverride(StringName, int)" />
    public void AddThemeFontSizeOverride(StringName @name, int @fontSize) => ((Control)_host).AddThemeFontSizeOverride(@name, @fontSize);

    /// <inheritdoc cref="Control.AddThemeColorOverride(StringName, Color)" />
    public void AddThemeColorOverride(StringName @name, Color @color) => ((Control)_host).AddThemeColorOverride(@name, @color);

    /// <inheritdoc cref="Control.AddThemeConstantOverride(StringName, int)" />
    public void AddThemeConstantOverride(StringName @name, int @constant) => ((Control)_host).AddThemeConstantOverride(@name, @constant);

    /// <inheritdoc cref="Control.RemoveThemeIconOverride(StringName)" />
    public void RemoveThemeIconOverride(StringName @name) => ((Control)_host).RemoveThemeIconOverride(@name);

    /// <inheritdoc cref="Control.RemoveThemeStyleboxOverride(StringName)" />
    public void RemoveThemeStyleboxOverride(StringName @name) => ((Control)_host).RemoveThemeStyleboxOverride(@name);

    /// <inheritdoc cref="Control.RemoveThemeFontOverride(StringName)" />
    public void RemoveThemeFontOverride(StringName @name) => ((Control)_host).RemoveThemeFontOverride(@name);

    /// <inheritdoc cref="Control.RemoveThemeFontSizeOverride(StringName)" />
    public void RemoveThemeFontSizeOverride(StringName @name) => ((Control)_host).RemoveThemeFontSizeOverride(@name);

    /// <inheritdoc cref="Control.RemoveThemeColorOverride(StringName)" />
    public void RemoveThemeColorOverride(StringName @name) => ((Control)_host).RemoveThemeColorOverride(@name);

    /// <inheritdoc cref="Control.RemoveThemeConstantOverride(StringName)" />
    public void RemoveThemeConstantOverride(StringName @name) => ((Control)_host).RemoveThemeConstantOverride(@name);

    /// <inheritdoc cref="Control.GetThemeIcon(StringName, StringName)" />
    public Texture2D GetThemeIcon(StringName @name, StringName @themeType) => ((Control)_host).GetThemeIcon(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeStylebox(StringName, StringName)" />
    public StyleBox GetThemeStylebox(StringName @name, StringName @themeType) => ((Control)_host).GetThemeStylebox(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeFont(StringName, StringName)" />
    public Font GetThemeFont(StringName @name, StringName @themeType) => ((Control)_host).GetThemeFont(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeFontSize(StringName, StringName)" />
    public int GetThemeFontSize(StringName @name, StringName @themeType) => ((Control)_host).GetThemeFontSize(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeColor(StringName, StringName)" />
    public Color GetThemeColor(StringName @name, StringName @themeType) => ((Control)_host).GetThemeColor(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeConstant(StringName, StringName)" />
    public int GetThemeConstant(StringName @name, StringName @themeType) => ((Control)_host).GetThemeConstant(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeIconOverride(StringName)" />
    public bool HasThemeIconOverride(StringName @name) => ((Control)_host).HasThemeIconOverride(@name);

    /// <inheritdoc cref="Control.HasThemeStyleboxOverride(StringName)" />
    public bool HasThemeStyleboxOverride(StringName @name) => ((Control)_host).HasThemeStyleboxOverride(@name);

    /// <inheritdoc cref="Control.HasThemeFontOverride(StringName)" />
    public bool HasThemeFontOverride(StringName @name) => ((Control)_host).HasThemeFontOverride(@name);

    /// <inheritdoc cref="Control.HasThemeFontSizeOverride(StringName)" />
    public bool HasThemeFontSizeOverride(StringName @name) => ((Control)_host).HasThemeFontSizeOverride(@name);

    /// <inheritdoc cref="Control.HasThemeColorOverride(StringName)" />
    public bool HasThemeColorOverride(StringName @name) => ((Control)_host).HasThemeColorOverride(@name);

    /// <inheritdoc cref="Control.HasThemeConstantOverride(StringName)" />
    public bool HasThemeConstantOverride(StringName @name) => ((Control)_host).HasThemeConstantOverride(@name);

    /// <inheritdoc cref="Control.HasThemeIcon(StringName, StringName)" />
    public bool HasThemeIcon(StringName @name, StringName @themeType) => ((Control)_host).HasThemeIcon(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeStylebox(StringName, StringName)" />
    public bool HasThemeStylebox(StringName @name, StringName @themeType) => ((Control)_host).HasThemeStylebox(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeFont(StringName, StringName)" />
    public bool HasThemeFont(StringName @name, StringName @themeType) => ((Control)_host).HasThemeFont(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeFontSize(StringName, StringName)" />
    public bool HasThemeFontSize(StringName @name, StringName @themeType) => ((Control)_host).HasThemeFontSize(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeColor(StringName, StringName)" />
    public bool HasThemeColor(StringName @name, StringName @themeType) => ((Control)_host).HasThemeColor(@name, @themeType);

    /// <inheritdoc cref="Control.HasThemeConstant(StringName, StringName)" />
    public bool HasThemeConstant(StringName @name, StringName @themeType) => ((Control)_host).HasThemeConstant(@name, @themeType);

    /// <inheritdoc cref="Control.GetThemeDefaultBaseScale()" />
    public float GetThemeDefaultBaseScale() => ((Control)_host).GetThemeDefaultBaseScale();

    /// <inheritdoc cref="Control.GetThemeDefaultFont()" />
    public Font GetThemeDefaultFont() => ((Control)_host).GetThemeDefaultFont();

    /// <inheritdoc cref="Control.GetThemeDefaultFontSize()" />
    public int GetThemeDefaultFontSize() => ((Control)_host).GetThemeDefaultFontSize();

    /// <inheritdoc cref="Control.GetParentControl()" />
    public Control GetParentControl() => ((Control)_host).GetParentControl();

    /// <inheritdoc cref="Control.SetHGrowDirection(Control.GrowDirection)" />
    public void SetHGrowDirection(Control.GrowDirection @direction) => ((Control)_host).SetHGrowDirection(@direction);

    /// <inheritdoc cref="Control.GetHGrowDirection()" />
    public Control.GrowDirection GetHGrowDirection() => ((Control)_host).GetHGrowDirection();

    /// <inheritdoc cref="Control.SetVGrowDirection(Control.GrowDirection)" />
    public void SetVGrowDirection(Control.GrowDirection @direction) => ((Control)_host).SetVGrowDirection(@direction);

    /// <inheritdoc cref="Control.GetVGrowDirection()" />
    public Control.GrowDirection GetVGrowDirection() => ((Control)_host).GetVGrowDirection();

    /// <inheritdoc cref="Control.SetTooltipAutoTranslateMode(Node.AutoTranslateModeEnum)" />
    public void SetTooltipAutoTranslateMode(Node.AutoTranslateModeEnum @mode) => ((Control)_host).SetTooltipAutoTranslateMode(@mode);

    /// <inheritdoc cref="Control.GetTooltipAutoTranslateMode()" />
    public Node.AutoTranslateModeEnum GetTooltipAutoTranslateMode() => ((Control)_host).GetTooltipAutoTranslateMode();

    /// <inheritdoc cref="Control.SetTooltipText(string)" />
    public void SetTooltipText(string @hint) => ((Control)_host).SetTooltipText(@hint);

    /// <inheritdoc cref="Control.GetTooltipText()" />
    public string GetTooltipText() => ((Control)_host).GetTooltipText();

    /// <inheritdoc cref="Control.GetTooltip(Vector2?)" />
    public string GetTooltip(Vector2? @atPosition) => ((Control)_host).GetTooltip(@atPosition);

    /// <inheritdoc cref="Control.SetDefaultCursorShape(Control.CursorShape)" />
    public void SetDefaultCursorShape(Control.CursorShape @shape) => ((Control)_host).SetDefaultCursorShape(@shape);

    /// <inheritdoc cref="Control.GetDefaultCursorShape()" />
    public Control.CursorShape GetDefaultCursorShape() => ((Control)_host).GetDefaultCursorShape();

    /// <inheritdoc cref="Control.GetCursorShape(Vector2?)" />
    public Control.CursorShape GetCursorShape(Vector2? @position) => ((Control)_host).GetCursorShape(@position);

    /// <inheritdoc cref="Control.SetFocusNeighbor(Side, NodePath)" />
    public void SetFocusNeighbor(Side @side, NodePath @neighbor) => ((Control)_host).SetFocusNeighbor(@side, @neighbor);

    /// <inheritdoc cref="Control.GetFocusNeighbor(Side)" />
    public NodePath GetFocusNeighbor(Side @side) => ((Control)_host).GetFocusNeighbor(@side);

    /// <inheritdoc cref="Control.SetFocusNext(NodePath)" />
    public void SetFocusNext(NodePath @next) => ((Control)_host).SetFocusNext(@next);

    /// <inheritdoc cref="Control.GetFocusNext()" />
    public NodePath GetFocusNext() => ((Control)_host).GetFocusNext();

    /// <inheritdoc cref="Control.SetFocusPrevious(NodePath)" />
    public void SetFocusPrevious(NodePath @previous) => ((Control)_host).SetFocusPrevious(@previous);

    /// <inheritdoc cref="Control.GetFocusPrevious()" />
    public NodePath GetFocusPrevious() => ((Control)_host).GetFocusPrevious();

    /// <inheritdoc cref="Control.ForceDrag(Variant, Control)" />
    public void ForceDrag(Variant @data, Control @preview) => ((Control)_host).ForceDrag(@data, @preview);

    /// <inheritdoc cref="Control.AccessibilityDrag()" />
    public void AccessibilityDrag() => ((Control)_host).AccessibilityDrag();

    /// <inheritdoc cref="Control.AccessibilityDrop()" />
    public void AccessibilityDrop() => ((Control)_host).AccessibilityDrop();

    /// <inheritdoc cref="Control.SetAccessibilityName(string)" />
    public void SetAccessibilityName(string @name) => ((Control)_host).SetAccessibilityName(@name);

    /// <inheritdoc cref="Control.GetAccessibilityName()" />
    public string GetAccessibilityName() => ((Control)_host).GetAccessibilityName();

    /// <inheritdoc cref="Control.SetAccessibilityDescription(string)" />
    public void SetAccessibilityDescription(string @description) => ((Control)_host).SetAccessibilityDescription(@description);

    /// <inheritdoc cref="Control.GetAccessibilityDescription()" />
    public string GetAccessibilityDescription() => ((Control)_host).GetAccessibilityDescription();

    /// <inheritdoc cref="Control.SetAccessibilityLive(DisplayServer.AccessibilityLiveMode)" />
    public void SetAccessibilityLive(DisplayServer.AccessibilityLiveMode @mode) => ((Control)_host).SetAccessibilityLive(@mode);

    /// <inheritdoc cref="Control.GetAccessibilityLive()" />
    public DisplayServer.AccessibilityLiveMode GetAccessibilityLive() => ((Control)_host).GetAccessibilityLive();

    /// <inheritdoc cref="Control.SetAccessibilityControlsNodes(Array{NodePath})" />
    public void SetAccessibilityControlsNodes(Array<NodePath> @nodePath) => ((Control)_host).SetAccessibilityControlsNodes(@nodePath);

    /// <inheritdoc cref="Control.GetAccessibilityControlsNodes()" />
    public Array<NodePath> GetAccessibilityControlsNodes() => ((Control)_host).GetAccessibilityControlsNodes();

    /// <inheritdoc cref="Control.SetAccessibilityDescribedByNodes(Array{NodePath})" />
    public void SetAccessibilityDescribedByNodes(Array<NodePath> @nodePath) => ((Control)_host).SetAccessibilityDescribedByNodes(@nodePath);

    /// <inheritdoc cref="Control.GetAccessibilityDescribedByNodes()" />
    public Array<NodePath> GetAccessibilityDescribedByNodes() => ((Control)_host).GetAccessibilityDescribedByNodes();

    /// <inheritdoc cref="Control.SetAccessibilityLabeledByNodes(Array{NodePath})" />
    public void SetAccessibilityLabeledByNodes(Array<NodePath> @nodePath) => ((Control)_host).SetAccessibilityLabeledByNodes(@nodePath);

    /// <inheritdoc cref="Control.GetAccessibilityLabeledByNodes()" />
    public Array<NodePath> GetAccessibilityLabeledByNodes() => ((Control)_host).GetAccessibilityLabeledByNodes();

    /// <inheritdoc cref="Control.SetAccessibilityFlowToNodes(Array{NodePath})" />
    public void SetAccessibilityFlowToNodes(Array<NodePath> @nodePath) => ((Control)_host).SetAccessibilityFlowToNodes(@nodePath);

    /// <inheritdoc cref="Control.GetAccessibilityFlowToNodes()" />
    public Array<NodePath> GetAccessibilityFlowToNodes() => ((Control)_host).GetAccessibilityFlowToNodes();

    /// <inheritdoc cref="Control.SetMouseFilter(Control.MouseFilterEnum)" />
    public void SetMouseFilter(Control.MouseFilterEnum @filter) => ((Control)_host).SetMouseFilter(@filter);

    /// <inheritdoc cref="Control.GetMouseFilter()" />
    public Control.MouseFilterEnum GetMouseFilter() => ((Control)_host).GetMouseFilter();

    /// <inheritdoc cref="Control.GetMouseFilterWithOverride()" />
    public Control.MouseFilterEnum GetMouseFilterWithOverride() => ((Control)_host).GetMouseFilterWithOverride();

    /// <inheritdoc cref="Control.SetMouseBehaviorRecursive(Control.MouseBehaviorRecursiveEnum)" />
    public void SetMouseBehaviorRecursive(Control.MouseBehaviorRecursiveEnum @mouseBehaviorRecursive) => ((Control)_host).SetMouseBehaviorRecursive(@mouseBehaviorRecursive);

    /// <inheritdoc cref="Control.GetMouseBehaviorRecursive()" />
    public Control.MouseBehaviorRecursiveEnum GetMouseBehaviorRecursive() => ((Control)_host).GetMouseBehaviorRecursive();

    /// <inheritdoc cref="Control.SetForcePassScrollEvents(bool)" />
    public void SetForcePassScrollEvents(bool @forcePassScrollEvents) => ((Control)_host).SetForcePassScrollEvents(@forcePassScrollEvents);

    /// <inheritdoc cref="Control.IsForcePassScrollEvents()" />
    public bool IsForcePassScrollEvents() => ((Control)_host).IsForcePassScrollEvents();

    /// <inheritdoc cref="Control.SetClipContents(bool)" />
    public void SetClipContents(bool @enable) => ((Control)_host).SetClipContents(@enable);

    /// <inheritdoc cref="Control.IsClippingContents()" />
    public bool IsClippingContents() => ((Control)_host).IsClippingContents();

    /// <inheritdoc cref="Control.GrabClickFocus()" />
    public void GrabClickFocus() => ((Control)_host).GrabClickFocus();

    /// <inheritdoc cref="Control.SetDragForwarding(Callable, Callable, Callable)" />
    public void SetDragForwarding(Callable @dragFunc, Callable @canDropFunc, Callable @dropFunc) => ((Control)_host).SetDragForwarding(@dragFunc, @canDropFunc, @dropFunc);

    /// <inheritdoc cref="Control.SetDragPreview(Control)" />
    public void SetDragPreview(Control @control) => ((Control)_host).SetDragPreview(@control);

    /// <inheritdoc cref="Control.IsDragSuccessful()" />
    public bool IsDragSuccessful() => ((Control)_host).IsDragSuccessful();

    /// <inheritdoc cref="Control.WarpMouse(Vector2)" />
    public void WarpMouse(Vector2 @position) => ((Control)_host).WarpMouse(@position);

    /// <inheritdoc cref="Control.SetShortcutContext(Node)" />
    public void SetShortcutContext(Node @node) => ((Control)_host).SetShortcutContext(@node);

    /// <inheritdoc cref="Control.GetShortcutContext()" />
    public Node GetShortcutContext() => ((Control)_host).GetShortcutContext();

    /// <inheritdoc cref="Control.UpdateMinimumSize()" />
    public void UpdateMinimumSize() => ((Control)_host).UpdateMinimumSize();

    /// <inheritdoc cref="Control.SetLayoutDirection(Control.LayoutDirectionEnum)" />
    public void SetLayoutDirection(Control.LayoutDirectionEnum @direction) => ((Control)_host).SetLayoutDirection(@direction);

    /// <inheritdoc cref="Control.GetLayoutDirection()" />
    public Control.LayoutDirectionEnum GetLayoutDirection() => ((Control)_host).GetLayoutDirection();

    /// <inheritdoc cref="Control.IsLayoutRtl()" />
    public bool IsLayoutRtl() => ((Control)_host).IsLayoutRtl();

    /// <inheritdoc cref="Control.SetAutoTranslate(bool)" />
    public void SetAutoTranslate(bool @enable) => ((Control)_host).SetAutoTranslate(@enable);

    /// <inheritdoc cref="Control.IsAutoTranslating()" />
    public bool IsAutoTranslating() => ((Control)_host).IsAutoTranslating();

    /// <inheritdoc cref="Control.SetLocalizeNumeralSystem(bool)" />
    public void SetLocalizeNumeralSystem(bool @enable) => ((Control)_host).SetLocalizeNumeralSystem(@enable);

    /// <inheritdoc cref="Control.IsLocalizingNumeralSystem()" />
    public bool IsLocalizingNumeralSystem() => ((Control)_host).IsLocalizingNumeralSystem();

    /// <inheritdoc cref="Control.GrabFocus()" />
    public void GrabFocus() => ((Control)_host).GrabFocus();

    /// <inheritdoc cref="Control.HasFocus()" />
    public bool HasFocus() => ((Control)_host).HasFocus();

}
