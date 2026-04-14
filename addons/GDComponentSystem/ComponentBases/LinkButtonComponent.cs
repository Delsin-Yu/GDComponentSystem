#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LinkButton" />
[Tool, GlobalClass]
public abstract partial class LinkButtonComponent : BaseButtonComponent
{

    /// <inheritdoc cref="LinkButton.SetText(string)" />
    public void SetText(string @text) => ((LinkButton)_host).SetText(@text);

    /// <inheritdoc cref="LinkButton.GetText()" />
    public string GetText() => ((LinkButton)_host).GetText();

    /// <inheritdoc cref="LinkButton.SetTextOverrunBehavior(TextServer.OverrunBehavior)" />
    public void SetTextOverrunBehavior(TextServer.OverrunBehavior @overrunBehavior) => ((LinkButton)_host).SetTextOverrunBehavior(@overrunBehavior);

    /// <inheritdoc cref="LinkButton.GetTextOverrunBehavior()" />
    public TextServer.OverrunBehavior GetTextOverrunBehavior() => ((LinkButton)_host).GetTextOverrunBehavior();

    /// <inheritdoc cref="LinkButton.SetEllipsisChar(string)" />
    public void SetEllipsisChar(string @char) => ((LinkButton)_host).SetEllipsisChar(@char);

    /// <inheritdoc cref="LinkButton.GetEllipsisChar()" />
    public string GetEllipsisChar() => ((LinkButton)_host).GetEllipsisChar();

    /// <inheritdoc cref="LinkButton.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((LinkButton)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="LinkButton.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((LinkButton)_host).GetTextDirection();

    /// <inheritdoc cref="LinkButton.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((LinkButton)_host).SetLanguage(@language);

    /// <inheritdoc cref="LinkButton.GetLanguage()" />
    public string GetLanguage() => ((LinkButton)_host).GetLanguage();

    /// <inheritdoc cref="LinkButton.SetUri(string)" />
    public void SetUri(string @uri) => ((LinkButton)_host).SetUri(@uri);

    /// <inheritdoc cref="LinkButton.GetUri()" />
    public string GetUri() => ((LinkButton)_host).GetUri();

    /// <inheritdoc cref="LinkButton.SetUnderlineMode(LinkButton.UnderlineMode)" />
    public void SetUnderlineMode(LinkButton.UnderlineMode @underlineMode) => ((LinkButton)_host).SetUnderlineMode(@underlineMode);

    /// <inheritdoc cref="LinkButton.GetUnderlineMode()" />
    public LinkButton.UnderlineMode GetUnderlineMode() => ((LinkButton)_host).GetUnderlineMode();

    /// <inheritdoc cref="LinkButton.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((LinkButton)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="LinkButton.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((LinkButton)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="LinkButton.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((LinkButton)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="LinkButton.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((LinkButton)_host).GetStructuredTextBidiOverrideOptions();

}
