#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RichTextLabel" />
[Tool, GlobalClass]
public abstract partial class RichTextLabelComponent : ControlComponent
{

    /// <inheritdoc cref="RichTextLabel.PushList(int, RichTextLabel.ListType, bool)" />
    public void PushList(int @level, RichTextLabel.ListType @type, bool @capitalize) => ((RichTextLabel)_host).PushList(@level, @type, @capitalize);

    /// <inheritdoc cref="RichTextLabel.PushParagraph(HorizontalAlignment, Control.TextDirection, string, TextServer.StructuredTextParser)" />
    public void PushParagraph(HorizontalAlignment @alignment, Control.TextDirection @baseDirection, string @language, TextServer.StructuredTextParser @stParser) => ((RichTextLabel)_host).PushParagraph(@alignment, @baseDirection, @language, @stParser);

    /// <inheritdoc cref="RichTextLabel.GetParsedText()" />
    public string GetParsedText() => ((RichTextLabel)_host).GetParsedText();

    /// <inheritdoc cref="RichTextLabel.AddText(string)" />
    public void AddText(string @text) => ((RichTextLabel)_host).AddText(@text);

    /// <inheritdoc cref="RichTextLabel.SetText(string)" />
    public void SetText(string @text) => ((RichTextLabel)_host).SetText(@text);

    /// <inheritdoc cref="RichTextLabel.AddHr(int, int, Color?, HorizontalAlignment, bool, bool)" />
    public void AddHr(int @width, int @height, Color? @color, HorizontalAlignment @alignment, bool @widthInPercent, bool @heightInPercent) => ((RichTextLabel)_host).AddHr(@width, @height, @color, @alignment, @widthInPercent, @heightInPercent);

    /// <inheritdoc cref="RichTextLabel.AddImage(Texture2D, int, int, Color?, InlineAlignment, Rect2?, Variant, bool, string, bool, bool, string)" />
    public void AddImage(Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region, Variant @key, bool @pad, string @tooltip, bool @widthInPercent, bool @heightInPercent, string @altText) => ((RichTextLabel)_host).AddImage(@image, @width, @height, @color, @inlineAlign, @region, @key, @pad, @tooltip, @widthInPercent, @heightInPercent, @altText);

    /// <inheritdoc cref="RichTextLabel.UpdateImage(Variant, RichTextLabel.ImageUpdateMask, Texture2D, int, int, Color?, InlineAlignment, Rect2?, bool, string, bool, bool)" />
    public void UpdateImage(Variant @key, RichTextLabel.ImageUpdateMask @mask, Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region, bool @pad, string @tooltip, bool @widthInPercent, bool @heightInPercent) => ((RichTextLabel)_host).UpdateImage(@key, @mask, @image, @width, @height, @color, @inlineAlign, @region, @pad, @tooltip, @widthInPercent, @heightInPercent);

    /// <inheritdoc cref="RichTextLabel.Newline()" />
    public void Newline() => ((RichTextLabel)_host).Newline();

    /// <inheritdoc cref="RichTextLabel.RemoveParagraph(int, bool)" />
    public bool RemoveParagraph(int @paragraph, bool @noInvalidate) => ((RichTextLabel)_host).RemoveParagraph(@paragraph, @noInvalidate);

    /// <inheritdoc cref="RichTextLabel.InvalidateParagraph(int)" />
    public bool InvalidateParagraph(int @paragraph) => ((RichTextLabel)_host).InvalidateParagraph(@paragraph);

    /// <inheritdoc cref="RichTextLabel.PushFont(Font, int)" />
    public void PushFont(Font @font, int @fontSize) => ((RichTextLabel)_host).PushFont(@font, @fontSize);

    /// <inheritdoc cref="RichTextLabel.PushFontSize(int)" />
    public void PushFontSize(int @fontSize) => ((RichTextLabel)_host).PushFontSize(@fontSize);

    /// <inheritdoc cref="RichTextLabel.PushNormal()" />
    public void PushNormal() => ((RichTextLabel)_host).PushNormal();

    /// <inheritdoc cref="RichTextLabel.PushBold()" />
    public void PushBold() => ((RichTextLabel)_host).PushBold();

    /// <inheritdoc cref="RichTextLabel.PushBoldItalics()" />
    public void PushBoldItalics() => ((RichTextLabel)_host).PushBoldItalics();

    /// <inheritdoc cref="RichTextLabel.PushItalics()" />
    public void PushItalics() => ((RichTextLabel)_host).PushItalics();

    /// <inheritdoc cref="RichTextLabel.PushMono()" />
    public void PushMono() => ((RichTextLabel)_host).PushMono();

    /// <inheritdoc cref="RichTextLabel.PushColor(Color)" />
    public void PushColor(Color @color) => ((RichTextLabel)_host).PushColor(@color);

    /// <inheritdoc cref="RichTextLabel.PushOutlineSize(int)" />
    public void PushOutlineSize(int @outlineSize) => ((RichTextLabel)_host).PushOutlineSize(@outlineSize);

    /// <inheritdoc cref="RichTextLabel.PushOutlineColor(Color)" />
    public void PushOutlineColor(Color @color) => ((RichTextLabel)_host).PushOutlineColor(@color);

    /// <inheritdoc cref="RichTextLabel.PushParagraph(HorizontalAlignment, Control.TextDirection, string, TextServer.StructuredTextParser, TextServer.JustificationFlag, float[])" />
    public void PushParagraph(HorizontalAlignment @alignment, Control.TextDirection @baseDirection, string @language, TextServer.StructuredTextParser @stParser, TextServer.JustificationFlag @justificationFlags, float[] @tabStops) => ((RichTextLabel)_host).PushParagraph(@alignment, @baseDirection, @language, @stParser, @justificationFlags, @tabStops);

    /// <inheritdoc cref="RichTextLabel.PushParagraph(HorizontalAlignment, Control.TextDirection, string, TextServer.StructuredTextParser, TextServer.JustificationFlag, ReadOnlySpan{float})" />
    public void PushParagraph(HorizontalAlignment @alignment, Control.TextDirection @baseDirection, string @language, TextServer.StructuredTextParser @stParser, TextServer.JustificationFlag @justificationFlags, ReadOnlySpan<float> @tabStops) => ((RichTextLabel)_host).PushParagraph(@alignment, @baseDirection, @language, @stParser, @justificationFlags, @tabStops);

    /// <inheritdoc cref="RichTextLabel.PushIndent(int)" />
    public void PushIndent(int @level) => ((RichTextLabel)_host).PushIndent(@level);

    /// <inheritdoc cref="RichTextLabel.PushList(int, RichTextLabel.ListType, bool, string)" />
    public void PushList(int @level, RichTextLabel.ListType @type, bool @capitalize, string @bullet) => ((RichTextLabel)_host).PushList(@level, @type, @capitalize, @bullet);

    /// <inheritdoc cref="RichTextLabel.PushMeta(Variant, RichTextLabel.MetaUnderline, string)" />
    public void PushMeta(Variant @data, RichTextLabel.MetaUnderline @underlineMode, string @tooltip) => ((RichTextLabel)_host).PushMeta(@data, @underlineMode, @tooltip);

    /// <inheritdoc cref="RichTextLabel.PushHint(string)" />
    public void PushHint(string @description) => ((RichTextLabel)_host).PushHint(@description);

    /// <inheritdoc cref="RichTextLabel.PushLanguage(string)" />
    public void PushLanguage(string @language) => ((RichTextLabel)_host).PushLanguage(@language);

    /// <inheritdoc cref="RichTextLabel.PushUnderline(Color?)" />
    public void PushUnderline(Color? @color) => ((RichTextLabel)_host).PushUnderline(@color);

    /// <inheritdoc cref="RichTextLabel.PushStrikethrough(Color?)" />
    public void PushStrikethrough(Color? @color) => ((RichTextLabel)_host).PushStrikethrough(@color);

    /// <inheritdoc cref="RichTextLabel.PushTable(int, InlineAlignment, int, string)" />
    public void PushTable(int @columns, InlineAlignment @inlineAlign, int @alignToRow, string @name) => ((RichTextLabel)_host).PushTable(@columns, @inlineAlign, @alignToRow, @name);

    /// <inheritdoc cref="RichTextLabel.PushDropcap(string, Font, int, Rect2?, Color?, int, Color?)" />
    public void PushDropcap(string @string, Font @font, int @size, Rect2? @dropcapMargins, Color? @color, int @outlineSize, Color? @outlineColor) => ((RichTextLabel)_host).PushDropcap(@string, @font, @size, @dropcapMargins, @color, @outlineSize, @outlineColor);

    /// <inheritdoc cref="RichTextLabel.SetTableColumnExpand(int, bool, int, bool)" />
    public void SetTableColumnExpand(int @column, bool @expand, int @ratio, bool @shrink) => ((RichTextLabel)_host).SetTableColumnExpand(@column, @expand, @ratio, @shrink);

    /// <inheritdoc cref="RichTextLabel.SetTableColumnName(int, string)" />
    public void SetTableColumnName(int @column, string @name) => ((RichTextLabel)_host).SetTableColumnName(@column, @name);

    /// <inheritdoc cref="RichTextLabel.SetCellRowBackgroundColor(Color, Color)" />
    public void SetCellRowBackgroundColor(Color @oddRowBg, Color @evenRowBg) => ((RichTextLabel)_host).SetCellRowBackgroundColor(@oddRowBg, @evenRowBg);

    /// <inheritdoc cref="RichTextLabel.SetCellBorderColor(Color)" />
    public void SetCellBorderColor(Color @color) => ((RichTextLabel)_host).SetCellBorderColor(@color);

    /// <inheritdoc cref="RichTextLabel.SetCellSizeOverride(Vector2, Vector2)" />
    public void SetCellSizeOverride(Vector2 @minSize, Vector2 @maxSize) => ((RichTextLabel)_host).SetCellSizeOverride(@minSize, @maxSize);

    /// <inheritdoc cref="RichTextLabel.SetCellPadding(Rect2)" />
    public void SetCellPadding(Rect2 @padding) => ((RichTextLabel)_host).SetCellPadding(@padding);

    /// <inheritdoc cref="RichTextLabel.PushCell()" />
    public void PushCell() => ((RichTextLabel)_host).PushCell();

    /// <inheritdoc cref="RichTextLabel.PushFgcolor(Color)" />
    public void PushFgcolor(Color @fgcolor) => ((RichTextLabel)_host).PushFgcolor(@fgcolor);

    /// <inheritdoc cref="RichTextLabel.PushBgcolor(Color)" />
    public void PushBgcolor(Color @bgcolor) => ((RichTextLabel)_host).PushBgcolor(@bgcolor);

    /// <inheritdoc cref="RichTextLabel.PushCustomfx(RichTextEffect, Dictionary)" />
    public void PushCustomfx(RichTextEffect @effect, Dictionary @env) => ((RichTextLabel)_host).PushCustomfx(@effect, @env);

    /// <inheritdoc cref="RichTextLabel.PushContext()" />
    public void PushContext() => ((RichTextLabel)_host).PushContext();

    /// <inheritdoc cref="RichTextLabel.PopContext()" />
    public void PopContext() => ((RichTextLabel)_host).PopContext();

    /// <inheritdoc cref="RichTextLabel.Pop()" />
    public void Pop() => ((RichTextLabel)_host).Pop();

    /// <inheritdoc cref="RichTextLabel.PopAll()" />
    public void PopAll() => ((RichTextLabel)_host).PopAll();

    /// <inheritdoc cref="RichTextLabel.Clear()" />
    public void Clear() => ((RichTextLabel)_host).Clear();

    /// <inheritdoc cref="RichTextLabel.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((RichTextLabel)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="RichTextLabel.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((RichTextLabel)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="RichTextLabel.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((RichTextLabel)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="RichTextLabel.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((RichTextLabel)_host).GetStructuredTextBidiOverrideOptions();

    /// <inheritdoc cref="RichTextLabel.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((RichTextLabel)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="RichTextLabel.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((RichTextLabel)_host).GetTextDirection();

    /// <inheritdoc cref="RichTextLabel.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((RichTextLabel)_host).SetLanguage(@language);

    /// <inheritdoc cref="RichTextLabel.GetLanguage()" />
    public string GetLanguage() => ((RichTextLabel)_host).GetLanguage();

    /// <inheritdoc cref="RichTextLabel.SetHorizontalAlignment(HorizontalAlignment)" />
    public void SetHorizontalAlignment(HorizontalAlignment @alignment) => ((RichTextLabel)_host).SetHorizontalAlignment(@alignment);

    /// <inheritdoc cref="RichTextLabel.GetHorizontalAlignment()" />
    public HorizontalAlignment GetHorizontalAlignment() => ((RichTextLabel)_host).GetHorizontalAlignment();

    /// <inheritdoc cref="RichTextLabel.SetVerticalAlignment(VerticalAlignment)" />
    public void SetVerticalAlignment(VerticalAlignment @alignment) => ((RichTextLabel)_host).SetVerticalAlignment(@alignment);

    /// <inheritdoc cref="RichTextLabel.GetVerticalAlignment()" />
    public VerticalAlignment GetVerticalAlignment() => ((RichTextLabel)_host).GetVerticalAlignment();

    /// <inheritdoc cref="RichTextLabel.SetJustificationFlags(TextServer.JustificationFlag)" />
    public void SetJustificationFlags(TextServer.JustificationFlag @justificationFlags) => ((RichTextLabel)_host).SetJustificationFlags(@justificationFlags);

    /// <inheritdoc cref="RichTextLabel.GetJustificationFlags()" />
    public TextServer.JustificationFlag GetJustificationFlags() => ((RichTextLabel)_host).GetJustificationFlags();

    /// <inheritdoc cref="RichTextLabel.SetTabStops(float[])" />
    public void SetTabStops(float[] @tabStops) => ((RichTextLabel)_host).SetTabStops(@tabStops);

    /// <inheritdoc cref="RichTextLabel.SetTabStops(ReadOnlySpan{float})" />
    public void SetTabStops(ReadOnlySpan<float> @tabStops) => ((RichTextLabel)_host).SetTabStops(@tabStops);

    /// <inheritdoc cref="RichTextLabel.GetTabStops()" />
    public float[] GetTabStops() => ((RichTextLabel)_host).GetTabStops();

    /// <inheritdoc cref="RichTextLabel.SetAutowrapMode(TextServer.AutowrapMode)" />
    public void SetAutowrapMode(TextServer.AutowrapMode @autowrapMode) => ((RichTextLabel)_host).SetAutowrapMode(@autowrapMode);

    /// <inheritdoc cref="RichTextLabel.GetAutowrapMode()" />
    public TextServer.AutowrapMode GetAutowrapMode() => ((RichTextLabel)_host).GetAutowrapMode();

    /// <inheritdoc cref="RichTextLabel.SetAutowrapTrimFlags(TextServer.LineBreakFlag)" />
    public void SetAutowrapTrimFlags(TextServer.LineBreakFlag @autowrapTrimFlags) => ((RichTextLabel)_host).SetAutowrapTrimFlags(@autowrapTrimFlags);

    /// <inheritdoc cref="RichTextLabel.GetAutowrapTrimFlags()" />
    public TextServer.LineBreakFlag GetAutowrapTrimFlags() => ((RichTextLabel)_host).GetAutowrapTrimFlags();

    /// <inheritdoc cref="RichTextLabel.SetMetaUnderline(bool)" />
    public void SetMetaUnderline(bool @enable) => ((RichTextLabel)_host).SetMetaUnderline(@enable);

    /// <inheritdoc cref="RichTextLabel.IsMetaUnderlined()" />
    public bool IsMetaUnderlined() => ((RichTextLabel)_host).IsMetaUnderlined();

    /// <inheritdoc cref="RichTextLabel.SetHintUnderline(bool)" />
    public void SetHintUnderline(bool @enable) => ((RichTextLabel)_host).SetHintUnderline(@enable);

    /// <inheritdoc cref="RichTextLabel.IsHintUnderlined()" />
    public bool IsHintUnderlined() => ((RichTextLabel)_host).IsHintUnderlined();

    /// <inheritdoc cref="RichTextLabel.SetScrollActive(bool)" />
    public void SetScrollActive(bool @active) => ((RichTextLabel)_host).SetScrollActive(@active);

    /// <inheritdoc cref="RichTextLabel.IsScrollActive()" />
    public bool IsScrollActive() => ((RichTextLabel)_host).IsScrollActive();

    /// <inheritdoc cref="RichTextLabel.SetScrollFollowVisibleCharacters(bool)" />
    public void SetScrollFollowVisibleCharacters(bool @follow) => ((RichTextLabel)_host).SetScrollFollowVisibleCharacters(@follow);

    /// <inheritdoc cref="RichTextLabel.IsScrollFollowingVisibleCharacters()" />
    public bool IsScrollFollowingVisibleCharacters() => ((RichTextLabel)_host).IsScrollFollowingVisibleCharacters();

    /// <inheritdoc cref="RichTextLabel.SetScrollFollow(bool)" />
    public void SetScrollFollow(bool @follow) => ((RichTextLabel)_host).SetScrollFollow(@follow);

    /// <inheritdoc cref="RichTextLabel.IsScrollFollowing()" />
    public bool IsScrollFollowing() => ((RichTextLabel)_host).IsScrollFollowing();

    /// <inheritdoc cref="RichTextLabel.GetVScrollBar()" />
    public VScrollBar GetVScrollBar() => ((RichTextLabel)_host).GetVScrollBar();

    /// <inheritdoc cref="RichTextLabel.ScrollToLine(int)" />
    public void ScrollToLine(int @line) => ((RichTextLabel)_host).ScrollToLine(@line);

    /// <inheritdoc cref="RichTextLabel.ScrollToParagraph(int)" />
    public void ScrollToParagraph(int @paragraph) => ((RichTextLabel)_host).ScrollToParagraph(@paragraph);

    /// <inheritdoc cref="RichTextLabel.ScrollToSelection()" />
    public void ScrollToSelection() => ((RichTextLabel)_host).ScrollToSelection();

    /// <inheritdoc cref="RichTextLabel.SetTabSize(int)" />
    public void SetTabSize(int @spaces) => ((RichTextLabel)_host).SetTabSize(@spaces);

    /// <inheritdoc cref="RichTextLabel.GetTabSize()" />
    public int GetTabSize() => ((RichTextLabel)_host).GetTabSize();

    /// <inheritdoc cref="RichTextLabel.SetFitContent(bool)" />
    public void SetFitContent(bool @enabled) => ((RichTextLabel)_host).SetFitContent(@enabled);

    /// <inheritdoc cref="RichTextLabel.IsFitContentEnabled()" />
    public bool IsFitContentEnabled() => ((RichTextLabel)_host).IsFitContentEnabled();

    /// <inheritdoc cref="RichTextLabel.SetSelectionEnabled(bool)" />
    public void SetSelectionEnabled(bool @enabled) => ((RichTextLabel)_host).SetSelectionEnabled(@enabled);

    /// <inheritdoc cref="RichTextLabel.IsSelectionEnabled()" />
    public bool IsSelectionEnabled() => ((RichTextLabel)_host).IsSelectionEnabled();

    /// <inheritdoc cref="RichTextLabel.SetContextMenuEnabled(bool)" />
    public void SetContextMenuEnabled(bool @enabled) => ((RichTextLabel)_host).SetContextMenuEnabled(@enabled);

    /// <inheritdoc cref="RichTextLabel.IsContextMenuEnabled()" />
    public bool IsContextMenuEnabled() => ((RichTextLabel)_host).IsContextMenuEnabled();

    /// <inheritdoc cref="RichTextLabel.SetShortcutKeysEnabled(bool)" />
    public void SetShortcutKeysEnabled(bool @enabled) => ((RichTextLabel)_host).SetShortcutKeysEnabled(@enabled);

    /// <inheritdoc cref="RichTextLabel.IsShortcutKeysEnabled()" />
    public bool IsShortcutKeysEnabled() => ((RichTextLabel)_host).IsShortcutKeysEnabled();

    /// <inheritdoc cref="RichTextLabel.SetDeselectOnFocusLossEnabled(bool)" />
    public void SetDeselectOnFocusLossEnabled(bool @enable) => ((RichTextLabel)_host).SetDeselectOnFocusLossEnabled(@enable);

    /// <inheritdoc cref="RichTextLabel.IsDeselectOnFocusLossEnabled()" />
    public bool IsDeselectOnFocusLossEnabled() => ((RichTextLabel)_host).IsDeselectOnFocusLossEnabled();

    /// <inheritdoc cref="RichTextLabel.SetDragAndDropSelectionEnabled(bool)" />
    public void SetDragAndDropSelectionEnabled(bool @enable) => ((RichTextLabel)_host).SetDragAndDropSelectionEnabled(@enable);

    /// <inheritdoc cref="RichTextLabel.IsDragAndDropSelectionEnabled()" />
    public bool IsDragAndDropSelectionEnabled() => ((RichTextLabel)_host).IsDragAndDropSelectionEnabled();

    /// <inheritdoc cref="RichTextLabel.GetSelectionFrom()" />
    public int GetSelectionFrom() => ((RichTextLabel)_host).GetSelectionFrom();

    /// <inheritdoc cref="RichTextLabel.GetSelectionTo()" />
    public int GetSelectionTo() => ((RichTextLabel)_host).GetSelectionTo();

    /// <inheritdoc cref="RichTextLabel.GetSelectionLineOffset()" />
    public float GetSelectionLineOffset() => ((RichTextLabel)_host).GetSelectionLineOffset();

    /// <inheritdoc cref="RichTextLabel.SelectAll()" />
    public void SelectAll() => ((RichTextLabel)_host).SelectAll();

    /// <inheritdoc cref="RichTextLabel.GetSelectedText()" />
    public string GetSelectedText() => ((RichTextLabel)_host).GetSelectedText();

    /// <inheritdoc cref="RichTextLabel.Deselect()" />
    public void Deselect() => ((RichTextLabel)_host).Deselect();

    /// <inheritdoc cref="RichTextLabel.ParseBbcode(string)" />
    public void ParseBbcode(string @bbcode) => ((RichTextLabel)_host).ParseBbcode(@bbcode);

    /// <inheritdoc cref="RichTextLabel.AppendText(string)" />
    public void AppendText(string @bbcode) => ((RichTextLabel)_host).AppendText(@bbcode);

    /// <inheritdoc cref="RichTextLabel.GetText()" />
    public string GetText() => ((RichTextLabel)_host).GetText();

    /// <inheritdoc cref="RichTextLabel.IsReady()" />
    public bool IsReady() => ((RichTextLabel)_host).IsReady();

    /// <inheritdoc cref="RichTextLabel.IsFinished()" />
    public bool IsFinished() => ((RichTextLabel)_host).IsFinished();

    /// <inheritdoc cref="RichTextLabel.SetThreaded(bool)" />
    public void SetThreaded(bool @threaded) => ((RichTextLabel)_host).SetThreaded(@threaded);

    /// <inheritdoc cref="RichTextLabel.IsThreaded()" />
    public bool IsThreaded() => ((RichTextLabel)_host).IsThreaded();

    /// <inheritdoc cref="RichTextLabel.SetProgressBarDelay(int)" />
    public void SetProgressBarDelay(int @delayMs) => ((RichTextLabel)_host).SetProgressBarDelay(@delayMs);

    /// <inheritdoc cref="RichTextLabel.GetProgressBarDelay()" />
    public int GetProgressBarDelay() => ((RichTextLabel)_host).GetProgressBarDelay();

    /// <inheritdoc cref="RichTextLabel.SetVisibleCharacters(int)" />
    public void SetVisibleCharacters(int @amount) => ((RichTextLabel)_host).SetVisibleCharacters(@amount);

    /// <inheritdoc cref="RichTextLabel.GetVisibleCharacters()" />
    public int GetVisibleCharacters() => ((RichTextLabel)_host).GetVisibleCharacters();

    /// <inheritdoc cref="RichTextLabel.GetVisibleCharactersBehavior()" />
    public TextServer.VisibleCharactersBehavior GetVisibleCharactersBehavior() => ((RichTextLabel)_host).GetVisibleCharactersBehavior();

    /// <inheritdoc cref="RichTextLabel.SetVisibleCharactersBehavior(TextServer.VisibleCharactersBehavior)" />
    public void SetVisibleCharactersBehavior(TextServer.VisibleCharactersBehavior @behavior) => ((RichTextLabel)_host).SetVisibleCharactersBehavior(@behavior);

    /// <inheritdoc cref="RichTextLabel.SetVisibleRatio(float)" />
    public void SetVisibleRatio(float @ratio) => ((RichTextLabel)_host).SetVisibleRatio(@ratio);

    /// <inheritdoc cref="RichTextLabel.GetVisibleRatio()" />
    public float GetVisibleRatio() => ((RichTextLabel)_host).GetVisibleRatio();

    /// <inheritdoc cref="RichTextLabel.GetCharacterLine(int)" />
    public int GetCharacterLine(int @character) => ((RichTextLabel)_host).GetCharacterLine(@character);

    /// <inheritdoc cref="RichTextLabel.GetCharacterParagraph(int)" />
    public int GetCharacterParagraph(int @character) => ((RichTextLabel)_host).GetCharacterParagraph(@character);

    /// <inheritdoc cref="RichTextLabel.GetTotalCharacterCount()" />
    public int GetTotalCharacterCount() => ((RichTextLabel)_host).GetTotalCharacterCount();

    /// <inheritdoc cref="RichTextLabel.SetUseBbcode(bool)" />
    public void SetUseBbcode(bool @enable) => ((RichTextLabel)_host).SetUseBbcode(@enable);

    /// <inheritdoc cref="RichTextLabel.IsUsingBbcode()" />
    public bool IsUsingBbcode() => ((RichTextLabel)_host).IsUsingBbcode();

    /// <inheritdoc cref="RichTextLabel.GetLineCount()" />
    public int GetLineCount() => ((RichTextLabel)_host).GetLineCount();

    /// <inheritdoc cref="RichTextLabel.GetLineRange(int)" />
    public Vector2I GetLineRange(int @line) => ((RichTextLabel)_host).GetLineRange(@line);

    /// <inheritdoc cref="RichTextLabel.GetVisibleLineCount()" />
    public int GetVisibleLineCount() => ((RichTextLabel)_host).GetVisibleLineCount();

    /// <inheritdoc cref="RichTextLabel.GetParagraphCount()" />
    public int GetParagraphCount() => ((RichTextLabel)_host).GetParagraphCount();

    /// <inheritdoc cref="RichTextLabel.GetVisibleParagraphCount()" />
    public int GetVisibleParagraphCount() => ((RichTextLabel)_host).GetVisibleParagraphCount();

    /// <inheritdoc cref="RichTextLabel.GetContentHeight()" />
    public int GetContentHeight() => ((RichTextLabel)_host).GetContentHeight();

    /// <inheritdoc cref="RichTextLabel.GetContentWidth()" />
    public int GetContentWidth() => ((RichTextLabel)_host).GetContentWidth();

    /// <inheritdoc cref="RichTextLabel.GetLineHeight(int)" />
    public int GetLineHeight(int @line) => ((RichTextLabel)_host).GetLineHeight(@line);

    /// <inheritdoc cref="RichTextLabel.GetLineWidth(int)" />
    public int GetLineWidth(int @line) => ((RichTextLabel)_host).GetLineWidth(@line);

    /// <inheritdoc cref="RichTextLabel.GetVisibleContentRect()" />
    public Rect2I GetVisibleContentRect() => ((RichTextLabel)_host).GetVisibleContentRect();

    /// <inheritdoc cref="RichTextLabel.GetLineOffset(int)" />
    public float GetLineOffset(int @line) => ((RichTextLabel)_host).GetLineOffset(@line);

    /// <inheritdoc cref="RichTextLabel.GetParagraphOffset(int)" />
    public float GetParagraphOffset(int @paragraph) => ((RichTextLabel)_host).GetParagraphOffset(@paragraph);

    /// <inheritdoc cref="RichTextLabel.ParseExpressionsForValues(string[])" />
    public Dictionary ParseExpressionsForValues(string[] @expressions) => ((RichTextLabel)_host).ParseExpressionsForValues(@expressions);

    /// <inheritdoc cref="RichTextLabel.ParseExpressionsForValues(ReadOnlySpan{string})" />
    public Dictionary ParseExpressionsForValues(ReadOnlySpan<string> @expressions) => ((RichTextLabel)_host).ParseExpressionsForValues(@expressions);

    /// <inheritdoc cref="RichTextLabel.SetEffects(Array)" />
    public void SetEffects(Array @effects) => ((RichTextLabel)_host).SetEffects(@effects);

    /// <inheritdoc cref="RichTextLabel.GetEffects()" />
    public Array GetEffects() => ((RichTextLabel)_host).GetEffects();

    /// <inheritdoc cref="RichTextLabel.InstallEffect(Variant)" />
    public void InstallEffect(Variant @effect) => ((RichTextLabel)_host).InstallEffect(@effect);

    /// <inheritdoc cref="RichTextLabel.ReloadEffects()" />
    public void ReloadEffects() => ((RichTextLabel)_host).ReloadEffects();

    /// <inheritdoc cref="RichTextLabel.GetMenu()" />
    public PopupMenu GetMenu() => ((RichTextLabel)_host).GetMenu();

    /// <inheritdoc cref="RichTextLabel.IsMenuVisible()" />
    public bool IsMenuVisible() => ((RichTextLabel)_host).IsMenuVisible();

    /// <inheritdoc cref="RichTextLabel.MenuOption(int)" />
    public void MenuOption(int @option) => ((RichTextLabel)_host).MenuOption(@option);

    /// <inheritdoc cref="RichTextLabel.UpdateImage(Variant, RichTextLabel.ImageUpdateMask, Texture2D, int, int, Color?, InlineAlignment, Rect2?, bool, string, bool)" />
    public void UpdateImage(Variant @key, RichTextLabel.ImageUpdateMask @mask, Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region, bool @pad, string @tooltip, bool @sizeInPercent) => ((RichTextLabel)_host).UpdateImage(@key, @mask, @image, @width, @height, @color, @inlineAlign, @region, @pad, @tooltip, @sizeInPercent);

    /// <inheritdoc cref="RichTextLabel.AddImage(Texture2D, int, int, Color?, InlineAlignment, Rect2?, Variant, bool, string, bool, string)" />
    public void AddImage(Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region, Variant @key, bool @pad, string @tooltip, bool @sizeInPercent, string @altText) => ((RichTextLabel)_host).AddImage(@image, @width, @height, @color, @inlineAlign, @region, @key, @pad, @tooltip, @sizeInPercent, @altText);

    /// <inheritdoc cref="RichTextLabel.PushStrikethrough()" />
    public void PushStrikethrough() => ((RichTextLabel)_host).PushStrikethrough();

    /// <inheritdoc cref="RichTextLabel.PushUnderline()" />
    public void PushUnderline() => ((RichTextLabel)_host).PushUnderline();

    /// <inheritdoc cref="RichTextLabel.RemoveParagraph(int)" />
    public bool RemoveParagraph(int @paragraph) => ((RichTextLabel)_host).RemoveParagraph(@paragraph);

    /// <inheritdoc cref="RichTextLabel.PushTable(int, InlineAlignment, int)" />
    public void PushTable(int @columns, InlineAlignment @inlineAlign, int @alignToRow) => ((RichTextLabel)_host).PushTable(@columns, @inlineAlign, @alignToRow);

    /// <inheritdoc cref="RichTextLabel.AddImage(Texture2D, int, int, Color?, InlineAlignment, Rect2?, Variant, bool, string, bool)" />
    public void AddImage(Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region, Variant @key, bool @pad, string @tooltip, bool @sizeInPercent) => ((RichTextLabel)_host).AddImage(@image, @width, @height, @color, @inlineAlign, @region, @key, @pad, @tooltip, @sizeInPercent);

    /// <inheritdoc cref="RichTextLabel.AddImage(Texture2D, int, int, Color?, InlineAlignment, Rect2?)" />
    public void AddImage(Texture2D @image, int @width, int @height, Color? @color, InlineAlignment @inlineAlign, Rect2? @region) => ((RichTextLabel)_host).AddImage(@image, @width, @height, @color, @inlineAlign, @region);

    /// <inheritdoc cref="RichTextLabel.PushMeta(Variant)" />
    public void PushMeta(Variant @data) => ((RichTextLabel)_host).PushMeta(@data);

    /// <inheritdoc cref="RichTextLabel.PushMeta(Variant, RichTextLabel.MetaUnderline)" />
    public void PushMeta(Variant @data, RichTextLabel.MetaUnderline @underlineMode) => ((RichTextLabel)_host).PushMeta(@data, @underlineMode);

    /// <inheritdoc cref="RichTextLabel.SetTableColumnExpand(int, bool, int)" />
    public void SetTableColumnExpand(int @column, bool @expand, int @ratio) => ((RichTextLabel)_host).SetTableColumnExpand(@column, @expand, @ratio);

}
