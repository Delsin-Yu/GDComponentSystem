#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Label" />
[Tool, GlobalClass]
public abstract partial class LabelComponent : ControlComponent
{

    /// <inheritdoc cref="Label.SetHorizontalAlignment(HorizontalAlignment)" />
    public void SetHorizontalAlignment(HorizontalAlignment @alignment) => ((Label)_host).SetHorizontalAlignment(@alignment);

    /// <inheritdoc cref="Label.GetHorizontalAlignment()" />
    public HorizontalAlignment GetHorizontalAlignment() => ((Label)_host).GetHorizontalAlignment();

    /// <inheritdoc cref="Label.SetVerticalAlignment(VerticalAlignment)" />
    public void SetVerticalAlignment(VerticalAlignment @alignment) => ((Label)_host).SetVerticalAlignment(@alignment);

    /// <inheritdoc cref="Label.GetVerticalAlignment()" />
    public VerticalAlignment GetVerticalAlignment() => ((Label)_host).GetVerticalAlignment();

    /// <inheritdoc cref="Label.SetText(string)" />
    public void SetText(string @text) => ((Label)_host).SetText(@text);

    /// <inheritdoc cref="Label.GetText()" />
    public string GetText() => ((Label)_host).GetText();

    /// <inheritdoc cref="Label.SetLabelSettings(LabelSettings)" />
    public void SetLabelSettings(LabelSettings @settings) => ((Label)_host).SetLabelSettings(@settings);

    /// <inheritdoc cref="Label.GetLabelSettings()" />
    public LabelSettings GetLabelSettings() => ((Label)_host).GetLabelSettings();

    /// <inheritdoc cref="Label.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((Label)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="Label.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((Label)_host).GetTextDirection();

    /// <inheritdoc cref="Label.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((Label)_host).SetLanguage(@language);

    /// <inheritdoc cref="Label.GetLanguage()" />
    public string GetLanguage() => ((Label)_host).GetLanguage();

    /// <inheritdoc cref="Label.SetParagraphSeparator(string)" />
    public void SetParagraphSeparator(string @paragraphSeparator) => ((Label)_host).SetParagraphSeparator(@paragraphSeparator);

    /// <inheritdoc cref="Label.GetParagraphSeparator()" />
    public string GetParagraphSeparator() => ((Label)_host).GetParagraphSeparator();

    /// <inheritdoc cref="Label.SetAutowrapMode(TextServer.AutowrapMode)" />
    public void SetAutowrapMode(TextServer.AutowrapMode @autowrapMode) => ((Label)_host).SetAutowrapMode(@autowrapMode);

    /// <inheritdoc cref="Label.GetAutowrapMode()" />
    public TextServer.AutowrapMode GetAutowrapMode() => ((Label)_host).GetAutowrapMode();

    /// <inheritdoc cref="Label.SetAutowrapTrimFlags(TextServer.LineBreakFlag)" />
    public void SetAutowrapTrimFlags(TextServer.LineBreakFlag @autowrapTrimFlags) => ((Label)_host).SetAutowrapTrimFlags(@autowrapTrimFlags);

    /// <inheritdoc cref="Label.GetAutowrapTrimFlags()" />
    public TextServer.LineBreakFlag GetAutowrapTrimFlags() => ((Label)_host).GetAutowrapTrimFlags();

    /// <inheritdoc cref="Label.SetJustificationFlags(TextServer.JustificationFlag)" />
    public void SetJustificationFlags(TextServer.JustificationFlag @justificationFlags) => ((Label)_host).SetJustificationFlags(@justificationFlags);

    /// <inheritdoc cref="Label.GetJustificationFlags()" />
    public TextServer.JustificationFlag GetJustificationFlags() => ((Label)_host).GetJustificationFlags();

    /// <inheritdoc cref="Label.SetClipText(bool)" />
    public void SetClipText(bool @enable) => ((Label)_host).SetClipText(@enable);

    /// <inheritdoc cref="Label.IsClippingText()" />
    public bool IsClippingText() => ((Label)_host).IsClippingText();

    /// <inheritdoc cref="Label.SetTabStops(float[])" />
    public void SetTabStops(float[] @tabStops) => ((Label)_host).SetTabStops(@tabStops);

    /// <inheritdoc cref="Label.SetTabStops(ReadOnlySpan{float})" />
    public void SetTabStops(ReadOnlySpan<float> @tabStops) => ((Label)_host).SetTabStops(@tabStops);

    /// <inheritdoc cref="Label.GetTabStops()" />
    public float[] GetTabStops() => ((Label)_host).GetTabStops();

    /// <inheritdoc cref="Label.SetTextOverrunBehavior(TextServer.OverrunBehavior)" />
    public void SetTextOverrunBehavior(TextServer.OverrunBehavior @overrunBehavior) => ((Label)_host).SetTextOverrunBehavior(@overrunBehavior);

    /// <inheritdoc cref="Label.GetTextOverrunBehavior()" />
    public TextServer.OverrunBehavior GetTextOverrunBehavior() => ((Label)_host).GetTextOverrunBehavior();

    /// <inheritdoc cref="Label.SetEllipsisChar(string)" />
    public void SetEllipsisChar(string @char) => ((Label)_host).SetEllipsisChar(@char);

    /// <inheritdoc cref="Label.GetEllipsisChar()" />
    public string GetEllipsisChar() => ((Label)_host).GetEllipsisChar();

    /// <inheritdoc cref="Label.SetUppercase(bool)" />
    public void SetUppercase(bool @enable) => ((Label)_host).SetUppercase(@enable);

    /// <inheritdoc cref="Label.IsUppercase()" />
    public bool IsUppercase() => ((Label)_host).IsUppercase();

    /// <inheritdoc cref="Label.GetLineHeight(int)" />
    public int GetLineHeight(int @line) => ((Label)_host).GetLineHeight(@line);

    /// <inheritdoc cref="Label.GetLineCount()" />
    public int GetLineCount() => ((Label)_host).GetLineCount();

    /// <inheritdoc cref="Label.GetVisibleLineCount()" />
    public int GetVisibleLineCount() => ((Label)_host).GetVisibleLineCount();

    /// <inheritdoc cref="Label.GetTotalCharacterCount()" />
    public int GetTotalCharacterCount() => ((Label)_host).GetTotalCharacterCount();

    /// <inheritdoc cref="Label.SetVisibleCharacters(int)" />
    public void SetVisibleCharacters(int @amount) => ((Label)_host).SetVisibleCharacters(@amount);

    /// <inheritdoc cref="Label.GetVisibleCharacters()" />
    public int GetVisibleCharacters() => ((Label)_host).GetVisibleCharacters();

    /// <inheritdoc cref="Label.GetVisibleCharactersBehavior()" />
    public TextServer.VisibleCharactersBehavior GetVisibleCharactersBehavior() => ((Label)_host).GetVisibleCharactersBehavior();

    /// <inheritdoc cref="Label.SetVisibleCharactersBehavior(TextServer.VisibleCharactersBehavior)" />
    public void SetVisibleCharactersBehavior(TextServer.VisibleCharactersBehavior @behavior) => ((Label)_host).SetVisibleCharactersBehavior(@behavior);

    /// <inheritdoc cref="Label.SetVisibleRatio(float)" />
    public void SetVisibleRatio(float @ratio) => ((Label)_host).SetVisibleRatio(@ratio);

    /// <inheritdoc cref="Label.GetVisibleRatio()" />
    public float GetVisibleRatio() => ((Label)_host).GetVisibleRatio();

    /// <inheritdoc cref="Label.SetLinesSkipped(int)" />
    public void SetLinesSkipped(int @linesSkipped) => ((Label)_host).SetLinesSkipped(@linesSkipped);

    /// <inheritdoc cref="Label.GetLinesSkipped()" />
    public int GetLinesSkipped() => ((Label)_host).GetLinesSkipped();

    /// <inheritdoc cref="Label.SetMaxLinesVisible(int)" />
    public void SetMaxLinesVisible(int @linesVisible) => ((Label)_host).SetMaxLinesVisible(@linesVisible);

    /// <inheritdoc cref="Label.GetMaxLinesVisible()" />
    public int GetMaxLinesVisible() => ((Label)_host).GetMaxLinesVisible();

    /// <inheritdoc cref="Label.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((Label)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="Label.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((Label)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="Label.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((Label)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="Label.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((Label)_host).GetStructuredTextBidiOverrideOptions();

    /// <inheritdoc cref="Label.GetCharacterBounds(int)" />
    public Rect2 GetCharacterBounds(int @pos) => ((Label)_host).GetCharacterBounds(@pos);

}
