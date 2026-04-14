#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Window" />
[Tool, GlobalClass]
public abstract partial class WindowComponent : ViewportComponent
{

    /// <inheritdoc cref="Window._GetContentsMinimumSize()" />
    public virtual Vector2 _GetContentsMinimumSize() => ((Window)_host)._GetContentsMinimumSize();

    /// <inheritdoc cref="Window.SetTitle(string)" />
    public void SetTitle(string @title) => ((Window)_host).SetTitle(@title);

    /// <inheritdoc cref="Window.GetTitle()" />
    public string GetTitle() => ((Window)_host).GetTitle();

    /// <inheritdoc cref="Window.SetInitialPosition(Window.WindowInitialPosition)" />
    public void SetInitialPosition(Window.WindowInitialPosition @initialPosition) => ((Window)_host).SetInitialPosition(@initialPosition);

    /// <inheritdoc cref="Window.GetInitialPosition()" />
    public Window.WindowInitialPosition GetInitialPosition() => ((Window)_host).GetInitialPosition();

    /// <inheritdoc cref="Window.SetCurrentScreen(int)" />
    public void SetCurrentScreen(int @index) => ((Window)_host).SetCurrentScreen(@index);

    /// <inheritdoc cref="Window.GetCurrentScreen()" />
    public int GetCurrentScreen() => ((Window)_host).GetCurrentScreen();

    /// <inheritdoc cref="Window.SetPosition(Vector2I)" />
    public void SetPosition(Vector2I @position) => ((Window)_host).SetPosition(@position);

    /// <inheritdoc cref="Window.GetPosition()" />
    public Vector2I GetPosition() => ((Window)_host).GetPosition();

    /// <inheritdoc cref="Window.MoveToCenter()" />
    public void MoveToCenter() => ((Window)_host).MoveToCenter();

    /// <inheritdoc cref="Window.SetSize(Vector2I)" />
    public void SetSize(Vector2I @size) => ((Window)_host).SetSize(@size);

    /// <inheritdoc cref="Window.GetSize()" />
    public Vector2I GetSize() => ((Window)_host).GetSize();

    /// <inheritdoc cref="Window.ResetSize()" />
    public void ResetSize() => ((Window)_host).ResetSize();

    /// <inheritdoc cref="Window.GetPositionWithDecorations()" />
    public Vector2I GetPositionWithDecorations() => ((Window)_host).GetPositionWithDecorations();

    /// <inheritdoc cref="Window.GetSizeWithDecorations()" />
    public Vector2I GetSizeWithDecorations() => ((Window)_host).GetSizeWithDecorations();

    /// <inheritdoc cref="Window.SetMaxSize(Vector2I)" />
    public void SetMaxSize(Vector2I @maxSize) => ((Window)_host).SetMaxSize(@maxSize);

    /// <inheritdoc cref="Window.GetMaxSize()" />
    public Vector2I GetMaxSize() => ((Window)_host).GetMaxSize();

    /// <inheritdoc cref="Window.SetMinSize(Vector2I)" />
    public void SetMinSize(Vector2I @minSize) => ((Window)_host).SetMinSize(@minSize);

    /// <inheritdoc cref="Window.GetMinSize()" />
    public Vector2I GetMinSize() => ((Window)_host).GetMinSize();

    /// <inheritdoc cref="Window.SetMode(Window.ModeEnum)" />
    public void SetMode(Window.ModeEnum @mode) => ((Window)_host).SetMode(@mode);

    /// <inheritdoc cref="Window.GetMode()" />
    public Window.ModeEnum GetMode() => ((Window)_host).GetMode();

    /// <inheritdoc cref="Window.SetFlag(Window.Flags, bool)" />
    public void SetFlag(Window.Flags @flag, bool @enabled) => ((Window)_host).SetFlag(@flag, @enabled);

    /// <inheritdoc cref="Window.GetFlag(Window.Flags)" />
    public bool GetFlag(Window.Flags @flag) => ((Window)_host).GetFlag(@flag);

    /// <inheritdoc cref="Window.IsMaximizeAllowed()" />
    public bool IsMaximizeAllowed() => ((Window)_host).IsMaximizeAllowed();

    /// <inheritdoc cref="Window.RequestAttention()" />
    public void RequestAttention() => ((Window)_host).RequestAttention();

    /// <inheritdoc cref="Window.MoveToForeground()" />
    public void MoveToForeground() => ((Window)_host).MoveToForeground();

    /// <inheritdoc cref="Window.SetVisible(bool)" />
    public void SetVisible(bool @visible) => ((Window)_host).SetVisible(@visible);

    /// <inheritdoc cref="Window.IsVisible()" />
    public bool IsVisible() => ((Window)_host).IsVisible();

    /// <inheritdoc cref="Window.Hide()" />
    public void Hide() => ((Window)_host).Hide();

    /// <inheritdoc cref="Window.Show()" />
    public void Show() => ((Window)_host).Show();

    /// <inheritdoc cref="Window.SetTransient(bool)" />
    public void SetTransient(bool @transient) => ((Window)_host).SetTransient(@transient);

    /// <inheritdoc cref="Window.IsTransient()" />
    public bool IsTransient() => ((Window)_host).IsTransient();

    /// <inheritdoc cref="Window.SetTransientToFocused(bool)" />
    public void SetTransientToFocused(bool @enable) => ((Window)_host).SetTransientToFocused(@enable);

    /// <inheritdoc cref="Window.IsTransientToFocused()" />
    public bool IsTransientToFocused() => ((Window)_host).IsTransientToFocused();

    /// <inheritdoc cref="Window.SetExclusive(bool)" />
    public void SetExclusive(bool @exclusive) => ((Window)_host).SetExclusive(@exclusive);

    /// <inheritdoc cref="Window.IsExclusive()" />
    public bool IsExclusive() => ((Window)_host).IsExclusive();

    /// <inheritdoc cref="Window.SetUnparentWhenInvisible(bool)" />
    public void SetUnparentWhenInvisible(bool @unparent) => ((Window)_host).SetUnparentWhenInvisible(@unparent);

    /// <inheritdoc cref="Window.CanDraw()" />
    public bool CanDraw() => ((Window)_host).CanDraw();

    /// <inheritdoc cref="Window.HasFocus()" />
    public bool HasFocus() => ((Window)_host).HasFocus();

    /// <inheritdoc cref="Window.GrabFocus()" />
    public void GrabFocus() => ((Window)_host).GrabFocus();

    /// <inheritdoc cref="Window.StartDrag()" />
    public void StartDrag() => ((Window)_host).StartDrag();

    /// <inheritdoc cref="Window.StartResize(DisplayServer.WindowResizeEdge)" />
    public void StartResize(DisplayServer.WindowResizeEdge @edge) => ((Window)_host).StartResize(@edge);

    /// <inheritdoc cref="Window.SetImeActive(bool)" />
    public void SetImeActive(bool @active) => ((Window)_host).SetImeActive(@active);

    /// <inheritdoc cref="Window.SetImePosition(Vector2I)" />
    public void SetImePosition(Vector2I @position) => ((Window)_host).SetImePosition(@position);

    /// <inheritdoc cref="Window.IsEmbedded()" />
    public bool IsEmbedded() => ((Window)_host).IsEmbedded();

    /// <inheritdoc cref="Window.GetContentsMinimumSize()" />
    public Vector2 GetContentsMinimumSize() => ((Window)_host).GetContentsMinimumSize();

    /// <inheritdoc cref="Window.SetForceNative(bool)" />
    public void SetForceNative(bool @forceNative) => ((Window)_host).SetForceNative(@forceNative);

    /// <inheritdoc cref="Window.GetForceNative()" />
    public bool GetForceNative() => ((Window)_host).GetForceNative();

    /// <inheritdoc cref="Window.SetContentScaleSize(Vector2I)" />
    public void SetContentScaleSize(Vector2I @size) => ((Window)_host).SetContentScaleSize(@size);

    /// <inheritdoc cref="Window.GetContentScaleSize()" />
    public Vector2I GetContentScaleSize() => ((Window)_host).GetContentScaleSize();

    /// <inheritdoc cref="Window.SetContentScaleMode(Window.ContentScaleModeEnum)" />
    public void SetContentScaleMode(Window.ContentScaleModeEnum @mode) => ((Window)_host).SetContentScaleMode(@mode);

    /// <inheritdoc cref="Window.GetContentScaleMode()" />
    public Window.ContentScaleModeEnum GetContentScaleMode() => ((Window)_host).GetContentScaleMode();

    /// <inheritdoc cref="Window.SetContentScaleAspect(Window.ContentScaleAspectEnum)" />
    public void SetContentScaleAspect(Window.ContentScaleAspectEnum @aspect) => ((Window)_host).SetContentScaleAspect(@aspect);

    /// <inheritdoc cref="Window.GetContentScaleAspect()" />
    public Window.ContentScaleAspectEnum GetContentScaleAspect() => ((Window)_host).GetContentScaleAspect();

    /// <inheritdoc cref="Window.SetContentScaleStretch(Window.ContentScaleStretchEnum)" />
    public void SetContentScaleStretch(Window.ContentScaleStretchEnum @stretch) => ((Window)_host).SetContentScaleStretch(@stretch);

    /// <inheritdoc cref="Window.GetContentScaleStretch()" />
    public Window.ContentScaleStretchEnum GetContentScaleStretch() => ((Window)_host).GetContentScaleStretch();

    /// <inheritdoc cref="Window.SetNonclientArea(Rect2I)" />
    public void SetNonclientArea(Rect2I @area) => ((Window)_host).SetNonclientArea(@area);

    /// <inheritdoc cref="Window.GetNonclientArea()" />
    public Rect2I GetNonclientArea() => ((Window)_host).GetNonclientArea();

    /// <inheritdoc cref="Window.SetKeepTitleVisible(bool)" />
    public void SetKeepTitleVisible(bool @titleVisible) => ((Window)_host).SetKeepTitleVisible(@titleVisible);

    /// <inheritdoc cref="Window.GetKeepTitleVisible()" />
    public bool GetKeepTitleVisible() => ((Window)_host).GetKeepTitleVisible();

    /// <inheritdoc cref="Window.SetContentScaleFactor(float)" />
    public void SetContentScaleFactor(float @factor) => ((Window)_host).SetContentScaleFactor(@factor);

    /// <inheritdoc cref="Window.GetContentScaleFactor()" />
    public float GetContentScaleFactor() => ((Window)_host).GetContentScaleFactor();

    /// <inheritdoc cref="Window.SetMousePassthroughPolygon(Vector2[])" />
    public void SetMousePassthroughPolygon(Vector2[] @polygon) => ((Window)_host).SetMousePassthroughPolygon(@polygon);

    /// <inheritdoc cref="Window.SetMousePassthroughPolygon(ReadOnlySpan{Vector2})" />
    public void SetMousePassthroughPolygon(ReadOnlySpan<Vector2> @polygon) => ((Window)_host).SetMousePassthroughPolygon(@polygon);

    /// <inheritdoc cref="Window.GetMousePassthroughPolygon()" />
    public Vector2[] GetMousePassthroughPolygon() => ((Window)_host).GetMousePassthroughPolygon();

    /// <inheritdoc cref="Window.SetWrapControls(bool)" />
    public void SetWrapControls(bool @enable) => ((Window)_host).SetWrapControls(@enable);

    /// <inheritdoc cref="Window.IsWrappingControls()" />
    public bool IsWrappingControls() => ((Window)_host).IsWrappingControls();

    /// <inheritdoc cref="Window.ChildControlsChanged()" />
    public void ChildControlsChanged() => ((Window)_host).ChildControlsChanged();

    /// <inheritdoc cref="Window.SetTheme(Theme)" />
    public void SetTheme(Theme @theme) => ((Window)_host).SetTheme(@theme);

    /// <inheritdoc cref="Window.GetTheme()" />
    public Theme GetTheme() => ((Window)_host).GetTheme();

    /// <inheritdoc cref="Window.SetThemeTypeVariation(StringName)" />
    public void SetThemeTypeVariation(StringName @themeType) => ((Window)_host).SetThemeTypeVariation(@themeType);

    /// <inheritdoc cref="Window.GetThemeTypeVariation()" />
    public StringName GetThemeTypeVariation() => ((Window)_host).GetThemeTypeVariation();

    /// <inheritdoc cref="Window.BeginBulkThemeOverride()" />
    public void BeginBulkThemeOverride() => ((Window)_host).BeginBulkThemeOverride();

    /// <inheritdoc cref="Window.EndBulkThemeOverride()" />
    public void EndBulkThemeOverride() => ((Window)_host).EndBulkThemeOverride();

    /// <inheritdoc cref="Window.AddThemeIconOverride(StringName, Texture2D)" />
    public void AddThemeIconOverride(StringName @name, Texture2D @texture) => ((Window)_host).AddThemeIconOverride(@name, @texture);

    /// <inheritdoc cref="Window.AddThemeStyleboxOverride(StringName, StyleBox)" />
    public void AddThemeStyleboxOverride(StringName @name, StyleBox @stylebox) => ((Window)_host).AddThemeStyleboxOverride(@name, @stylebox);

    /// <inheritdoc cref="Window.AddThemeFontOverride(StringName, Font)" />
    public void AddThemeFontOverride(StringName @name, Font @font) => ((Window)_host).AddThemeFontOverride(@name, @font);

    /// <inheritdoc cref="Window.AddThemeFontSizeOverride(StringName, int)" />
    public void AddThemeFontSizeOverride(StringName @name, int @fontSize) => ((Window)_host).AddThemeFontSizeOverride(@name, @fontSize);

    /// <inheritdoc cref="Window.AddThemeColorOverride(StringName, Color)" />
    public void AddThemeColorOverride(StringName @name, Color @color) => ((Window)_host).AddThemeColorOverride(@name, @color);

    /// <inheritdoc cref="Window.AddThemeConstantOverride(StringName, int)" />
    public void AddThemeConstantOverride(StringName @name, int @constant) => ((Window)_host).AddThemeConstantOverride(@name, @constant);

    /// <inheritdoc cref="Window.RemoveThemeIconOverride(StringName)" />
    public void RemoveThemeIconOverride(StringName @name) => ((Window)_host).RemoveThemeIconOverride(@name);

    /// <inheritdoc cref="Window.RemoveThemeStyleboxOverride(StringName)" />
    public void RemoveThemeStyleboxOverride(StringName @name) => ((Window)_host).RemoveThemeStyleboxOverride(@name);

    /// <inheritdoc cref="Window.RemoveThemeFontOverride(StringName)" />
    public void RemoveThemeFontOverride(StringName @name) => ((Window)_host).RemoveThemeFontOverride(@name);

    /// <inheritdoc cref="Window.RemoveThemeFontSizeOverride(StringName)" />
    public void RemoveThemeFontSizeOverride(StringName @name) => ((Window)_host).RemoveThemeFontSizeOverride(@name);

    /// <inheritdoc cref="Window.RemoveThemeColorOverride(StringName)" />
    public void RemoveThemeColorOverride(StringName @name) => ((Window)_host).RemoveThemeColorOverride(@name);

    /// <inheritdoc cref="Window.RemoveThemeConstantOverride(StringName)" />
    public void RemoveThemeConstantOverride(StringName @name) => ((Window)_host).RemoveThemeConstantOverride(@name);

    /// <inheritdoc cref="Window.GetThemeIcon(StringName, StringName)" />
    public Texture2D GetThemeIcon(StringName @name, StringName @themeType) => ((Window)_host).GetThemeIcon(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeStylebox(StringName, StringName)" />
    public StyleBox GetThemeStylebox(StringName @name, StringName @themeType) => ((Window)_host).GetThemeStylebox(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeFont(StringName, StringName)" />
    public Font GetThemeFont(StringName @name, StringName @themeType) => ((Window)_host).GetThemeFont(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeFontSize(StringName, StringName)" />
    public int GetThemeFontSize(StringName @name, StringName @themeType) => ((Window)_host).GetThemeFontSize(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeColor(StringName, StringName)" />
    public Color GetThemeColor(StringName @name, StringName @themeType) => ((Window)_host).GetThemeColor(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeConstant(StringName, StringName)" />
    public int GetThemeConstant(StringName @name, StringName @themeType) => ((Window)_host).GetThemeConstant(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeIconOverride(StringName)" />
    public bool HasThemeIconOverride(StringName @name) => ((Window)_host).HasThemeIconOverride(@name);

    /// <inheritdoc cref="Window.HasThemeStyleboxOverride(StringName)" />
    public bool HasThemeStyleboxOverride(StringName @name) => ((Window)_host).HasThemeStyleboxOverride(@name);

    /// <inheritdoc cref="Window.HasThemeFontOverride(StringName)" />
    public bool HasThemeFontOverride(StringName @name) => ((Window)_host).HasThemeFontOverride(@name);

    /// <inheritdoc cref="Window.HasThemeFontSizeOverride(StringName)" />
    public bool HasThemeFontSizeOverride(StringName @name) => ((Window)_host).HasThemeFontSizeOverride(@name);

    /// <inheritdoc cref="Window.HasThemeColorOverride(StringName)" />
    public bool HasThemeColorOverride(StringName @name) => ((Window)_host).HasThemeColorOverride(@name);

    /// <inheritdoc cref="Window.HasThemeConstantOverride(StringName)" />
    public bool HasThemeConstantOverride(StringName @name) => ((Window)_host).HasThemeConstantOverride(@name);

    /// <inheritdoc cref="Window.HasThemeIcon(StringName, StringName)" />
    public bool HasThemeIcon(StringName @name, StringName @themeType) => ((Window)_host).HasThemeIcon(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeStylebox(StringName, StringName)" />
    public bool HasThemeStylebox(StringName @name, StringName @themeType) => ((Window)_host).HasThemeStylebox(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeFont(StringName, StringName)" />
    public bool HasThemeFont(StringName @name, StringName @themeType) => ((Window)_host).HasThemeFont(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeFontSize(StringName, StringName)" />
    public bool HasThemeFontSize(StringName @name, StringName @themeType) => ((Window)_host).HasThemeFontSize(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeColor(StringName, StringName)" />
    public bool HasThemeColor(StringName @name, StringName @themeType) => ((Window)_host).HasThemeColor(@name, @themeType);

    /// <inheritdoc cref="Window.HasThemeConstant(StringName, StringName)" />
    public bool HasThemeConstant(StringName @name, StringName @themeType) => ((Window)_host).HasThemeConstant(@name, @themeType);

    /// <inheritdoc cref="Window.GetThemeDefaultBaseScale()" />
    public float GetThemeDefaultBaseScale() => ((Window)_host).GetThemeDefaultBaseScale();

    /// <inheritdoc cref="Window.GetThemeDefaultFont()" />
    public Font GetThemeDefaultFont() => ((Window)_host).GetThemeDefaultFont();

    /// <inheritdoc cref="Window.GetThemeDefaultFontSize()" />
    public int GetThemeDefaultFontSize() => ((Window)_host).GetThemeDefaultFontSize();

    /// <inheritdoc cref="Window.GetWindowId()" />
    public int GetWindowId() => ((Window)_host).GetWindowId();

    /// <inheritdoc cref="Window.SetAccessibilityName(string)" />
    public void SetAccessibilityName(string @name) => ((Window)_host).SetAccessibilityName(@name);

    /// <inheritdoc cref="Window.GetAccessibilityName()" />
    public string GetAccessibilityName() => ((Window)_host).GetAccessibilityName();

    /// <inheritdoc cref="Window.SetAccessibilityDescription(string)" />
    public void SetAccessibilityDescription(string @description) => ((Window)_host).SetAccessibilityDescription(@description);

    /// <inheritdoc cref="Window.GetAccessibilityDescription()" />
    public string GetAccessibilityDescription() => ((Window)_host).GetAccessibilityDescription();

    /// <inheritdoc cref="Window.SetLayoutDirection(Window.LayoutDirection)" />
    public void SetLayoutDirection(Window.LayoutDirection @direction) => ((Window)_host).SetLayoutDirection(@direction);

    /// <inheritdoc cref="Window.GetLayoutDirection()" />
    public Window.LayoutDirection GetLayoutDirection() => ((Window)_host).GetLayoutDirection();

    /// <inheritdoc cref="Window.IsLayoutRtl()" />
    public bool IsLayoutRtl() => ((Window)_host).IsLayoutRtl();

    /// <inheritdoc cref="Window.SetAutoTranslate(bool)" />
    public void SetAutoTranslate(bool @enable) => ((Window)_host).SetAutoTranslate(@enable);

    /// <inheritdoc cref="Window.IsAutoTranslating()" />
    public bool IsAutoTranslating() => ((Window)_host).IsAutoTranslating();

    /// <inheritdoc cref="Window.SetUseFontOversampling(bool)" />
    public void SetUseFontOversampling(bool @enable) => ((Window)_host).SetUseFontOversampling(@enable);

    /// <inheritdoc cref="Window.IsUsingFontOversampling()" />
    public bool IsUsingFontOversampling() => ((Window)_host).IsUsingFontOversampling();

    /// <inheritdoc cref="Window.Popup(Rect2I?)" />
    public void Popup(Rect2I? @rect) => ((Window)_host).Popup(@rect);

    /// <inheritdoc cref="Window.PopupOnParent(Rect2I)" />
    public void PopupOnParent(Rect2I @parentRect) => ((Window)_host).PopupOnParent(@parentRect);

    /// <inheritdoc cref="Window.PopupCentered(Vector2I?)" />
    public void PopupCentered(Vector2I? @minsize) => ((Window)_host).PopupCentered(@minsize);

    /// <inheritdoc cref="Window.PopupCenteredRatio(float)" />
    public void PopupCenteredRatio(float @ratio) => ((Window)_host).PopupCenteredRatio(@ratio);

    /// <inheritdoc cref="Window.PopupCenteredClamped(Vector2I?, float)" />
    public void PopupCenteredClamped(Vector2I? @minsize, float @fallbackRatio) => ((Window)_host).PopupCenteredClamped(@minsize, @fallbackRatio);

    /// <inheritdoc cref="Window.PopupExclusive(Node, Rect2I?)" />
    public void PopupExclusive(Node @fromNode, Rect2I? @rect) => ((Window)_host).PopupExclusive(@fromNode, @rect);

    /// <inheritdoc cref="Window.PopupExclusiveOnParent(Node, Rect2I)" />
    public void PopupExclusiveOnParent(Node @fromNode, Rect2I @parentRect) => ((Window)_host).PopupExclusiveOnParent(@fromNode, @parentRect);

    /// <inheritdoc cref="Window.PopupExclusiveCentered(Node, Vector2I?)" />
    public void PopupExclusiveCentered(Node @fromNode, Vector2I? @minsize) => ((Window)_host).PopupExclusiveCentered(@fromNode, @minsize);

    /// <inheritdoc cref="Window.PopupExclusiveCenteredRatio(Node, float)" />
    public void PopupExclusiveCenteredRatio(Node @fromNode, float @ratio) => ((Window)_host).PopupExclusiveCenteredRatio(@fromNode, @ratio);

    /// <inheritdoc cref="Window.PopupExclusiveCenteredClamped(Node, Vector2I?, float)" />
    public void PopupExclusiveCenteredClamped(Node @fromNode, Vector2I? @minsize, float @fallbackRatio) => ((Window)_host).PopupExclusiveCenteredClamped(@fromNode, @minsize, @fallbackRatio);

}
