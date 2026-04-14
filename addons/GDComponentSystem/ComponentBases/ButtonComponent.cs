#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Button" />
[Tool, GlobalClass]
public abstract partial class ButtonComponent : BaseButtonComponent
{

    /// <inheritdoc cref="Button.SetText(string)" />
    public void SetText(string @text) => ((Button)_host).SetText(@text);

    /// <inheritdoc cref="Button.GetText()" />
    public string GetText() => ((Button)_host).GetText();

    /// <inheritdoc cref="Button.SetTextOverrunBehavior(TextServer.OverrunBehavior)" />
    public void SetTextOverrunBehavior(TextServer.OverrunBehavior @overrunBehavior) => ((Button)_host).SetTextOverrunBehavior(@overrunBehavior);

    /// <inheritdoc cref="Button.GetTextOverrunBehavior()" />
    public TextServer.OverrunBehavior GetTextOverrunBehavior() => ((Button)_host).GetTextOverrunBehavior();

    /// <inheritdoc cref="Button.SetAutowrapMode(TextServer.AutowrapMode)" />
    public void SetAutowrapMode(TextServer.AutowrapMode @autowrapMode) => ((Button)_host).SetAutowrapMode(@autowrapMode);

    /// <inheritdoc cref="Button.GetAutowrapMode()" />
    public TextServer.AutowrapMode GetAutowrapMode() => ((Button)_host).GetAutowrapMode();

    /// <inheritdoc cref="Button.SetAutowrapTrimFlags(TextServer.LineBreakFlag)" />
    public void SetAutowrapTrimFlags(TextServer.LineBreakFlag @autowrapTrimFlags) => ((Button)_host).SetAutowrapTrimFlags(@autowrapTrimFlags);

    /// <inheritdoc cref="Button.GetAutowrapTrimFlags()" />
    public TextServer.LineBreakFlag GetAutowrapTrimFlags() => ((Button)_host).GetAutowrapTrimFlags();

    /// <inheritdoc cref="Button.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((Button)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="Button.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((Button)_host).GetTextDirection();

    /// <inheritdoc cref="Button.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((Button)_host).SetLanguage(@language);

    /// <inheritdoc cref="Button.GetLanguage()" />
    public string GetLanguage() => ((Button)_host).GetLanguage();

    /// <inheritdoc cref="Button.SetButtonIcon(Texture2D)" />
    public void SetButtonIcon(Texture2D @texture) => ((Button)_host).SetButtonIcon(@texture);

    /// <inheritdoc cref="Button.GetButtonIcon()" />
    public Texture2D GetButtonIcon() => ((Button)_host).GetButtonIcon();

    /// <inheritdoc cref="Button.SetFlat(bool)" />
    public void SetFlat(bool @enabled) => ((Button)_host).SetFlat(@enabled);

    /// <inheritdoc cref="Button.IsFlat()" />
    public bool IsFlat() => ((Button)_host).IsFlat();

    /// <inheritdoc cref="Button.SetClipText(bool)" />
    public void SetClipText(bool @enabled) => ((Button)_host).SetClipText(@enabled);

    /// <inheritdoc cref="Button.GetClipText()" />
    public bool GetClipText() => ((Button)_host).GetClipText();

    /// <inheritdoc cref="Button.SetTextAlignment(HorizontalAlignment)" />
    public void SetTextAlignment(HorizontalAlignment @alignment) => ((Button)_host).SetTextAlignment(@alignment);

    /// <inheritdoc cref="Button.GetTextAlignment()" />
    public HorizontalAlignment GetTextAlignment() => ((Button)_host).GetTextAlignment();

    /// <inheritdoc cref="Button.SetIconAlignment(HorizontalAlignment)" />
    public void SetIconAlignment(HorizontalAlignment @iconAlignment) => ((Button)_host).SetIconAlignment(@iconAlignment);

    /// <inheritdoc cref="Button.GetIconAlignment()" />
    public HorizontalAlignment GetIconAlignment() => ((Button)_host).GetIconAlignment();

    /// <inheritdoc cref="Button.SetVerticalIconAlignment(VerticalAlignment)" />
    public void SetVerticalIconAlignment(VerticalAlignment @verticalIconAlignment) => ((Button)_host).SetVerticalIconAlignment(@verticalIconAlignment);

    /// <inheritdoc cref="Button.GetVerticalIconAlignment()" />
    public VerticalAlignment GetVerticalIconAlignment() => ((Button)_host).GetVerticalIconAlignment();

    /// <inheritdoc cref="Button.SetExpandIcon(bool)" />
    public void SetExpandIcon(bool @enabled) => ((Button)_host).SetExpandIcon(@enabled);

    /// <inheritdoc cref="Button.IsExpandIcon()" />
    public bool IsExpandIcon() => ((Button)_host).IsExpandIcon();

}
