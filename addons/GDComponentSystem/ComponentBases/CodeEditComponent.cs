#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CodeEdit" />
[Tool, GlobalClass]
public abstract partial class CodeEditComponent : TextEditComponent
{

    /// <inheritdoc cref="CodeEdit.AddCodeCompletionOption(CodeEdit.CodeCompletionKind, string, string, Color?, Resource, Variant?)" />
    public void AddCodeCompletionOption(CodeEdit.CodeCompletionKind @type, string @displayText, string @insertText, Color? @textColor, Resource @icon, Variant? @value) => ((CodeEdit)_host).AddCodeCompletionOption(@type, @displayText, @insertText, @textColor, @icon, @value);

    /// <inheritdoc cref="CodeEdit._ConfirmCodeCompletion(bool)" />
    public virtual void _ConfirmCodeCompletion(bool @replace) { }

    /// <inheritdoc cref="CodeEdit._FilterCodeCompletionCandidates(Array{Dictionary})" />
    public virtual Array<Dictionary> _FilterCodeCompletionCandidates(Array<Dictionary> @candidates) => ((CodeEdit)_host)._FilterCodeCompletionCandidates(@candidates);

    /// <inheritdoc cref="CodeEdit._RequestCodeCompletion(bool)" />
    public virtual void _RequestCodeCompletion(bool @force) { }

    /// <inheritdoc cref="CodeEdit.SetIndentSize(int)" />
    public void SetIndentSize(int @size) => ((CodeEdit)_host).SetIndentSize(@size);

    /// <inheritdoc cref="CodeEdit.GetIndentSize()" />
    public int GetIndentSize() => ((CodeEdit)_host).GetIndentSize();

    /// <inheritdoc cref="CodeEdit.SetIndentUsingSpaces(bool)" />
    public void SetIndentUsingSpaces(bool @useSpaces) => ((CodeEdit)_host).SetIndentUsingSpaces(@useSpaces);

    /// <inheritdoc cref="CodeEdit.IsIndentUsingSpaces()" />
    public bool IsIndentUsingSpaces() => ((CodeEdit)_host).IsIndentUsingSpaces();

    /// <inheritdoc cref="CodeEdit.SetAutoIndentEnabled(bool)" />
    public void SetAutoIndentEnabled(bool @enable) => ((CodeEdit)_host).SetAutoIndentEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsAutoIndentEnabled()" />
    public bool IsAutoIndentEnabled() => ((CodeEdit)_host).IsAutoIndentEnabled();

    /// <inheritdoc cref="CodeEdit.SetAutoIndentPrefixes(Array{string})" />
    public void SetAutoIndentPrefixes(Array<string> @prefixes) => ((CodeEdit)_host).SetAutoIndentPrefixes(@prefixes);

    /// <inheritdoc cref="CodeEdit.GetAutoIndentPrefixes()" />
    public Array<string> GetAutoIndentPrefixes() => ((CodeEdit)_host).GetAutoIndentPrefixes();

    /// <inheritdoc cref="CodeEdit.DoIndent()" />
    public void DoIndent() => ((CodeEdit)_host).DoIndent();

    /// <inheritdoc cref="CodeEdit.IndentLines()" />
    public void IndentLines() => ((CodeEdit)_host).IndentLines();

    /// <inheritdoc cref="CodeEdit.UnindentLines()" />
    public void UnindentLines() => ((CodeEdit)_host).UnindentLines();

    /// <inheritdoc cref="CodeEdit.ConvertIndent(int, int)" />
    public void ConvertIndent(int @fromLine, int @toLine) => ((CodeEdit)_host).ConvertIndent(@fromLine, @toLine);

    /// <inheritdoc cref="CodeEdit.SetAutoBraceCompletionEnabled(bool)" />
    public void SetAutoBraceCompletionEnabled(bool @enable) => ((CodeEdit)_host).SetAutoBraceCompletionEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsAutoBraceCompletionEnabled()" />
    public bool IsAutoBraceCompletionEnabled() => ((CodeEdit)_host).IsAutoBraceCompletionEnabled();

    /// <inheritdoc cref="CodeEdit.SetHighlightMatchingBracesEnabled(bool)" />
    public void SetHighlightMatchingBracesEnabled(bool @enable) => ((CodeEdit)_host).SetHighlightMatchingBracesEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsHighlightMatchingBracesEnabled()" />
    public bool IsHighlightMatchingBracesEnabled() => ((CodeEdit)_host).IsHighlightMatchingBracesEnabled();

    /// <inheritdoc cref="CodeEdit.AddAutoBraceCompletionPair(string, string)" />
    public void AddAutoBraceCompletionPair(string @startKey, string @endKey) => ((CodeEdit)_host).AddAutoBraceCompletionPair(@startKey, @endKey);

    /// <inheritdoc cref="CodeEdit.SetAutoBraceCompletionPairs(Dictionary)" />
    public void SetAutoBraceCompletionPairs(Dictionary @pairs) => ((CodeEdit)_host).SetAutoBraceCompletionPairs(@pairs);

    /// <inheritdoc cref="CodeEdit.GetAutoBraceCompletionPairs()" />
    public Dictionary GetAutoBraceCompletionPairs() => ((CodeEdit)_host).GetAutoBraceCompletionPairs();

    /// <inheritdoc cref="CodeEdit.HasAutoBraceCompletionOpenKey(string)" />
    public bool HasAutoBraceCompletionOpenKey(string @openKey) => ((CodeEdit)_host).HasAutoBraceCompletionOpenKey(@openKey);

    /// <inheritdoc cref="CodeEdit.HasAutoBraceCompletionCloseKey(string)" />
    public bool HasAutoBraceCompletionCloseKey(string @closeKey) => ((CodeEdit)_host).HasAutoBraceCompletionCloseKey(@closeKey);

    /// <inheritdoc cref="CodeEdit.GetAutoBraceCompletionCloseKey(string)" />
    public string GetAutoBraceCompletionCloseKey(string @openKey) => ((CodeEdit)_host).GetAutoBraceCompletionCloseKey(@openKey);

    /// <inheritdoc cref="CodeEdit.SetDrawBreakpointsGutter(bool)" />
    public void SetDrawBreakpointsGutter(bool @enable) => ((CodeEdit)_host).SetDrawBreakpointsGutter(@enable);

    /// <inheritdoc cref="CodeEdit.IsDrawingBreakpointsGutter()" />
    public bool IsDrawingBreakpointsGutter() => ((CodeEdit)_host).IsDrawingBreakpointsGutter();

    /// <inheritdoc cref="CodeEdit.SetDrawBookmarksGutter(bool)" />
    public void SetDrawBookmarksGutter(bool @enable) => ((CodeEdit)_host).SetDrawBookmarksGutter(@enable);

    /// <inheritdoc cref="CodeEdit.IsDrawingBookmarksGutter()" />
    public bool IsDrawingBookmarksGutter() => ((CodeEdit)_host).IsDrawingBookmarksGutter();

    /// <inheritdoc cref="CodeEdit.SetDrawExecutingLinesGutter(bool)" />
    public void SetDrawExecutingLinesGutter(bool @enable) => ((CodeEdit)_host).SetDrawExecutingLinesGutter(@enable);

    /// <inheritdoc cref="CodeEdit.IsDrawingExecutingLinesGutter()" />
    public bool IsDrawingExecutingLinesGutter() => ((CodeEdit)_host).IsDrawingExecutingLinesGutter();

    /// <inheritdoc cref="CodeEdit.SetLineAsBreakpoint(int, bool)" />
    public void SetLineAsBreakpoint(int @line, bool @breakpointed) => ((CodeEdit)_host).SetLineAsBreakpoint(@line, @breakpointed);

    /// <inheritdoc cref="CodeEdit.IsLineBreakpointed(int)" />
    public bool IsLineBreakpointed(int @line) => ((CodeEdit)_host).IsLineBreakpointed(@line);

    /// <inheritdoc cref="CodeEdit.ClearBreakpointedLines()" />
    public void ClearBreakpointedLines() => ((CodeEdit)_host).ClearBreakpointedLines();

    /// <inheritdoc cref="CodeEdit.GetBreakpointedLines()" />
    public int[] GetBreakpointedLines() => ((CodeEdit)_host).GetBreakpointedLines();

    /// <inheritdoc cref="CodeEdit.SetLineAsBookmarked(int, bool)" />
    public void SetLineAsBookmarked(int @line, bool @bookmarked) => ((CodeEdit)_host).SetLineAsBookmarked(@line, @bookmarked);

    /// <inheritdoc cref="CodeEdit.IsLineBookmarked(int)" />
    public bool IsLineBookmarked(int @line) => ((CodeEdit)_host).IsLineBookmarked(@line);

    /// <inheritdoc cref="CodeEdit.ClearBookmarkedLines()" />
    public void ClearBookmarkedLines() => ((CodeEdit)_host).ClearBookmarkedLines();

    /// <inheritdoc cref="CodeEdit.GetBookmarkedLines()" />
    public int[] GetBookmarkedLines() => ((CodeEdit)_host).GetBookmarkedLines();

    /// <inheritdoc cref="CodeEdit.SetLineAsExecuting(int, bool)" />
    public void SetLineAsExecuting(int @line, bool @executing) => ((CodeEdit)_host).SetLineAsExecuting(@line, @executing);

    /// <inheritdoc cref="CodeEdit.IsLineExecuting(int)" />
    public bool IsLineExecuting(int @line) => ((CodeEdit)_host).IsLineExecuting(@line);

    /// <inheritdoc cref="CodeEdit.ClearExecutingLines()" />
    public void ClearExecutingLines() => ((CodeEdit)_host).ClearExecutingLines();

    /// <inheritdoc cref="CodeEdit.GetExecutingLines()" />
    public int[] GetExecutingLines() => ((CodeEdit)_host).GetExecutingLines();

    /// <inheritdoc cref="CodeEdit.SetDrawLineNumbers(bool)" />
    public void SetDrawLineNumbers(bool @enable) => ((CodeEdit)_host).SetDrawLineNumbers(@enable);

    /// <inheritdoc cref="CodeEdit.IsDrawLineNumbersEnabled()" />
    public bool IsDrawLineNumbersEnabled() => ((CodeEdit)_host).IsDrawLineNumbersEnabled();

    /// <inheritdoc cref="CodeEdit.SetLineNumbersZeroPadded(bool)" />
    public void SetLineNumbersZeroPadded(bool @enable) => ((CodeEdit)_host).SetLineNumbersZeroPadded(@enable);

    /// <inheritdoc cref="CodeEdit.IsLineNumbersZeroPadded()" />
    public bool IsLineNumbersZeroPadded() => ((CodeEdit)_host).IsLineNumbersZeroPadded();

    /// <inheritdoc cref="CodeEdit.SetLineNumbersMinDigits(int)" />
    public void SetLineNumbersMinDigits(int @count) => ((CodeEdit)_host).SetLineNumbersMinDigits(@count);

    /// <inheritdoc cref="CodeEdit.GetLineNumbersMinDigits()" />
    public int GetLineNumbersMinDigits() => ((CodeEdit)_host).GetLineNumbersMinDigits();

    /// <inheritdoc cref="CodeEdit.SetDrawFoldGutter(bool)" />
    public void SetDrawFoldGutter(bool @enable) => ((CodeEdit)_host).SetDrawFoldGutter(@enable);

    /// <inheritdoc cref="CodeEdit.IsDrawingFoldGutter()" />
    public bool IsDrawingFoldGutter() => ((CodeEdit)_host).IsDrawingFoldGutter();

    /// <inheritdoc cref="CodeEdit.SetLineFoldingEnabled(bool)" />
    public void SetLineFoldingEnabled(bool @enabled) => ((CodeEdit)_host).SetLineFoldingEnabled(@enabled);

    /// <inheritdoc cref="CodeEdit.IsLineFoldingEnabled()" />
    public bool IsLineFoldingEnabled() => ((CodeEdit)_host).IsLineFoldingEnabled();

    /// <inheritdoc cref="CodeEdit.CanFoldLine(int)" />
    public bool CanFoldLine(int @line) => ((CodeEdit)_host).CanFoldLine(@line);

    /// <inheritdoc cref="CodeEdit.FoldLine(int)" />
    public void FoldLine(int @line) => ((CodeEdit)_host).FoldLine(@line);

    /// <inheritdoc cref="CodeEdit.UnfoldLine(int)" />
    public void UnfoldLine(int @line) => ((CodeEdit)_host).UnfoldLine(@line);

    /// <inheritdoc cref="CodeEdit.FoldAllLines()" />
    public void FoldAllLines() => ((CodeEdit)_host).FoldAllLines();

    /// <inheritdoc cref="CodeEdit.UnfoldAllLines()" />
    public void UnfoldAllLines() => ((CodeEdit)_host).UnfoldAllLines();

    /// <inheritdoc cref="CodeEdit.ToggleFoldableLine(int)" />
    public void ToggleFoldableLine(int @line) => ((CodeEdit)_host).ToggleFoldableLine(@line);

    /// <inheritdoc cref="CodeEdit.ToggleFoldableLinesAtCarets()" />
    public void ToggleFoldableLinesAtCarets() => ((CodeEdit)_host).ToggleFoldableLinesAtCarets();

    /// <inheritdoc cref="CodeEdit.IsLineFolded(int)" />
    public bool IsLineFolded(int @line) => ((CodeEdit)_host).IsLineFolded(@line);

    /// <inheritdoc cref="CodeEdit.GetFoldedLines()" />
    public Array<int> GetFoldedLines() => ((CodeEdit)_host).GetFoldedLines();

    /// <inheritdoc cref="CodeEdit.CreateCodeRegion()" />
    public void CreateCodeRegion() => ((CodeEdit)_host).CreateCodeRegion();

    /// <inheritdoc cref="CodeEdit.GetCodeRegionStartTag()" />
    public string GetCodeRegionStartTag() => ((CodeEdit)_host).GetCodeRegionStartTag();

    /// <inheritdoc cref="CodeEdit.GetCodeRegionEndTag()" />
    public string GetCodeRegionEndTag() => ((CodeEdit)_host).GetCodeRegionEndTag();

    /// <inheritdoc cref="CodeEdit.SetCodeRegionTags(string, string)" />
    public void SetCodeRegionTags(string @start, string @end) => ((CodeEdit)_host).SetCodeRegionTags(@start, @end);

    /// <inheritdoc cref="CodeEdit.IsLineCodeRegionStart(int)" />
    public bool IsLineCodeRegionStart(int @line) => ((CodeEdit)_host).IsLineCodeRegionStart(@line);

    /// <inheritdoc cref="CodeEdit.IsLineCodeRegionEnd(int)" />
    public bool IsLineCodeRegionEnd(int @line) => ((CodeEdit)_host).IsLineCodeRegionEnd(@line);

    /// <inheritdoc cref="CodeEdit.AddStringDelimiter(string, string, bool)" />
    public void AddStringDelimiter(string @startKey, string @endKey, bool @lineOnly) => ((CodeEdit)_host).AddStringDelimiter(@startKey, @endKey, @lineOnly);

    /// <inheritdoc cref="CodeEdit.RemoveStringDelimiter(string)" />
    public void RemoveStringDelimiter(string @startKey) => ((CodeEdit)_host).RemoveStringDelimiter(@startKey);

    /// <inheritdoc cref="CodeEdit.HasStringDelimiter(string)" />
    public bool HasStringDelimiter(string @startKey) => ((CodeEdit)_host).HasStringDelimiter(@startKey);

    /// <inheritdoc cref="CodeEdit.SetStringDelimiters(Array{string})" />
    public void SetStringDelimiters(Array<string> @stringDelimiters) => ((CodeEdit)_host).SetStringDelimiters(@stringDelimiters);

    /// <inheritdoc cref="CodeEdit.ClearStringDelimiters()" />
    public void ClearStringDelimiters() => ((CodeEdit)_host).ClearStringDelimiters();

    /// <inheritdoc cref="CodeEdit.GetStringDelimiters()" />
    public Array<string> GetStringDelimiters() => ((CodeEdit)_host).GetStringDelimiters();

    /// <inheritdoc cref="CodeEdit.IsInString(int, int)" />
    public int IsInString(int @line, int @column) => ((CodeEdit)_host).IsInString(@line, @column);

    /// <inheritdoc cref="CodeEdit.AddCommentDelimiter(string, string, bool)" />
    public void AddCommentDelimiter(string @startKey, string @endKey, bool @lineOnly) => ((CodeEdit)_host).AddCommentDelimiter(@startKey, @endKey, @lineOnly);

    /// <inheritdoc cref="CodeEdit.RemoveCommentDelimiter(string)" />
    public void RemoveCommentDelimiter(string @startKey) => ((CodeEdit)_host).RemoveCommentDelimiter(@startKey);

    /// <inheritdoc cref="CodeEdit.HasCommentDelimiter(string)" />
    public bool HasCommentDelimiter(string @startKey) => ((CodeEdit)_host).HasCommentDelimiter(@startKey);

    /// <inheritdoc cref="CodeEdit.SetCommentDelimiters(Array{string})" />
    public void SetCommentDelimiters(Array<string> @commentDelimiters) => ((CodeEdit)_host).SetCommentDelimiters(@commentDelimiters);

    /// <inheritdoc cref="CodeEdit.ClearCommentDelimiters()" />
    public void ClearCommentDelimiters() => ((CodeEdit)_host).ClearCommentDelimiters();

    /// <inheritdoc cref="CodeEdit.GetCommentDelimiters()" />
    public Array<string> GetCommentDelimiters() => ((CodeEdit)_host).GetCommentDelimiters();

    /// <inheritdoc cref="CodeEdit.IsInComment(int, int)" />
    public int IsInComment(int @line, int @column) => ((CodeEdit)_host).IsInComment(@line, @column);

    /// <inheritdoc cref="CodeEdit.GetDelimiterStartKey(int)" />
    public string GetDelimiterStartKey(int @delimiterIndex) => ((CodeEdit)_host).GetDelimiterStartKey(@delimiterIndex);

    /// <inheritdoc cref="CodeEdit.GetDelimiterEndKey(int)" />
    public string GetDelimiterEndKey(int @delimiterIndex) => ((CodeEdit)_host).GetDelimiterEndKey(@delimiterIndex);

    /// <inheritdoc cref="CodeEdit.GetDelimiterStartPosition(int, int)" />
    public Vector2 GetDelimiterStartPosition(int @line, int @column) => ((CodeEdit)_host).GetDelimiterStartPosition(@line, @column);

    /// <inheritdoc cref="CodeEdit.GetDelimiterEndPosition(int, int)" />
    public Vector2 GetDelimiterEndPosition(int @line, int @column) => ((CodeEdit)_host).GetDelimiterEndPosition(@line, @column);

    /// <inheritdoc cref="CodeEdit.SetCodeHint(string)" />
    public void SetCodeHint(string @codeHint) => ((CodeEdit)_host).SetCodeHint(@codeHint);

    /// <inheritdoc cref="CodeEdit.SetCodeHintDrawBelow(bool)" />
    public void SetCodeHintDrawBelow(bool @drawBelow) => ((CodeEdit)_host).SetCodeHintDrawBelow(@drawBelow);

    /// <inheritdoc cref="CodeEdit.GetTextForCodeCompletion()" />
    public string GetTextForCodeCompletion() => ((CodeEdit)_host).GetTextForCodeCompletion();

    /// <inheritdoc cref="CodeEdit.RequestCodeCompletion(bool)" />
    public void RequestCodeCompletion(bool @force) => ((CodeEdit)_host).RequestCodeCompletion(@force);

    /// <inheritdoc cref="CodeEdit.AddCodeCompletionOption(CodeEdit.CodeCompletionKind, string, string, Color?, Resource, Variant, int)" />
    public void AddCodeCompletionOption(CodeEdit.CodeCompletionKind @type, string @displayText, string @insertText, Color? @textColor, Resource @icon, Variant @value, int @location) => ((CodeEdit)_host).AddCodeCompletionOption(@type, @displayText, @insertText, @textColor, @icon, @value, @location);

    /// <inheritdoc cref="CodeEdit.UpdateCodeCompletionOptions(bool)" />
    public void UpdateCodeCompletionOptions(bool @force) => ((CodeEdit)_host).UpdateCodeCompletionOptions(@force);

    /// <inheritdoc cref="CodeEdit.GetCodeCompletionOptions()" />
    public Array<Dictionary> GetCodeCompletionOptions() => ((CodeEdit)_host).GetCodeCompletionOptions();

    /// <inheritdoc cref="CodeEdit.GetCodeCompletionOption(int)" />
    public Dictionary GetCodeCompletionOption(int @index) => ((CodeEdit)_host).GetCodeCompletionOption(@index);

    /// <inheritdoc cref="CodeEdit.GetCodeCompletionSelectedIndex()" />
    public int GetCodeCompletionSelectedIndex() => ((CodeEdit)_host).GetCodeCompletionSelectedIndex();

    /// <inheritdoc cref="CodeEdit.SetCodeCompletionSelectedIndex(int)" />
    public void SetCodeCompletionSelectedIndex(int @index) => ((CodeEdit)_host).SetCodeCompletionSelectedIndex(@index);

    /// <inheritdoc cref="CodeEdit.ConfirmCodeCompletion(bool)" />
    public void ConfirmCodeCompletion(bool @replace) => ((CodeEdit)_host).ConfirmCodeCompletion(@replace);

    /// <inheritdoc cref="CodeEdit.CancelCodeCompletion()" />
    public void CancelCodeCompletion() => ((CodeEdit)_host).CancelCodeCompletion();

    /// <inheritdoc cref="CodeEdit.SetCodeCompletionEnabled(bool)" />
    public void SetCodeCompletionEnabled(bool @enable) => ((CodeEdit)_host).SetCodeCompletionEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsCodeCompletionEnabled()" />
    public bool IsCodeCompletionEnabled() => ((CodeEdit)_host).IsCodeCompletionEnabled();

    /// <inheritdoc cref="CodeEdit.SetCodeCompletionPrefixes(Array{string})" />
    public void SetCodeCompletionPrefixes(Array<string> @prefixes) => ((CodeEdit)_host).SetCodeCompletionPrefixes(@prefixes);

    /// <inheritdoc cref="CodeEdit.GetCodeCompletionPrefixes()" />
    public Array<string> GetCodeCompletionPrefixes() => ((CodeEdit)_host).GetCodeCompletionPrefixes();

    /// <inheritdoc cref="CodeEdit.SetLineLengthGuidelines(Array{int})" />
    public void SetLineLengthGuidelines(Array<int> @guidelineColumns) => ((CodeEdit)_host).SetLineLengthGuidelines(@guidelineColumns);

    /// <inheritdoc cref="CodeEdit.GetLineLengthGuidelines()" />
    public Array<int> GetLineLengthGuidelines() => ((CodeEdit)_host).GetLineLengthGuidelines();

    /// <inheritdoc cref="CodeEdit.SetSymbolLookupOnClickEnabled(bool)" />
    public void SetSymbolLookupOnClickEnabled(bool @enable) => ((CodeEdit)_host).SetSymbolLookupOnClickEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsSymbolLookupOnClickEnabled()" />
    public bool IsSymbolLookupOnClickEnabled() => ((CodeEdit)_host).IsSymbolLookupOnClickEnabled();

    /// <inheritdoc cref="CodeEdit.GetTextForSymbolLookup()" />
    public string GetTextForSymbolLookup() => ((CodeEdit)_host).GetTextForSymbolLookup();

    /// <inheritdoc cref="CodeEdit.GetTextWithCursorChar(int, int)" />
    public string GetTextWithCursorChar(int @line, int @column) => ((CodeEdit)_host).GetTextWithCursorChar(@line, @column);

    /// <inheritdoc cref="CodeEdit.SetSymbolLookupWordAsValid(bool)" />
    public void SetSymbolLookupWordAsValid(bool @valid) => ((CodeEdit)_host).SetSymbolLookupWordAsValid(@valid);

    /// <inheritdoc cref="CodeEdit.SetSymbolTooltipOnHoverEnabled(bool)" />
    public void SetSymbolTooltipOnHoverEnabled(bool @enable) => ((CodeEdit)_host).SetSymbolTooltipOnHoverEnabled(@enable);

    /// <inheritdoc cref="CodeEdit.IsSymbolTooltipOnHoverEnabled()" />
    public bool IsSymbolTooltipOnHoverEnabled() => ((CodeEdit)_host).IsSymbolTooltipOnHoverEnabled();

    /// <inheritdoc cref="CodeEdit.MoveLinesUp()" />
    public void MoveLinesUp() => ((CodeEdit)_host).MoveLinesUp();

    /// <inheritdoc cref="CodeEdit.MoveLinesDown()" />
    public void MoveLinesDown() => ((CodeEdit)_host).MoveLinesDown();

    /// <inheritdoc cref="CodeEdit.DeleteLines()" />
    public void DeleteLines() => ((CodeEdit)_host).DeleteLines();

    /// <inheritdoc cref="CodeEdit.DuplicateSelection()" />
    public void DuplicateSelection() => ((CodeEdit)_host).DuplicateSelection();

    /// <inheritdoc cref="CodeEdit.DuplicateLines()" />
    public void DuplicateLines() => ((CodeEdit)_host).DuplicateLines();

    /// <inheritdoc cref="CodeEdit.AddCodeCompletionOption(CodeEdit.CodeCompletionKind, string, string, Color?, Resource, Variant?, int)" />
    public void AddCodeCompletionOption(CodeEdit.CodeCompletionKind @type, string @displayText, string @insertText, Color? @textColor, Resource @icon, Variant? @value, int @location) => ((CodeEdit)_host).AddCodeCompletionOption(@type, @displayText, @insertText, @textColor, @icon, @value, @location);

}
