#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="TextEdit" />
[Tool, GlobalClass]
public abstract partial class TextEditComponent : ControlComponent
{

    /// <inheritdoc cref="TextEdit._Backspace(int)" />
    public virtual void _Backspace(int @caretIndex) { }

    /// <inheritdoc cref="TextEdit._Copy(int)" />
    public virtual void _Copy(int @caretIndex) { }

    /// <inheritdoc cref="TextEdit._Cut(int)" />
    public virtual void _Cut(int @caretIndex) { }

    /// <inheritdoc cref="TextEdit._HandleUnicodeInput(int, int)" />
    public virtual void _HandleUnicodeInput(int @unicodeChar, int @caretIndex) { }

    /// <inheritdoc cref="TextEdit._Paste(int)" />
    public virtual void _Paste(int @caretIndex) { }

    /// <inheritdoc cref="TextEdit._PastePrimaryClipboard(int)" />
    public virtual void _PastePrimaryClipboard(int @caretIndex) { }

    /// <inheritdoc cref="TextEdit.HasImeText()" />
    public bool HasImeText() => ((TextEdit)_host).HasImeText();

    /// <inheritdoc cref="TextEdit.CancelIme()" />
    public void CancelIme() => ((TextEdit)_host).CancelIme();

    /// <inheritdoc cref="TextEdit.ApplyIme()" />
    public void ApplyIme() => ((TextEdit)_host).ApplyIme();

    /// <inheritdoc cref="TextEdit.SetEditable(bool)" />
    public void SetEditable(bool @enabled) => ((TextEdit)_host).SetEditable(@enabled);

    /// <inheritdoc cref="TextEdit.IsEditable()" />
    public bool IsEditable() => ((TextEdit)_host).IsEditable();

    /// <inheritdoc cref="TextEdit.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((TextEdit)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="TextEdit.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((TextEdit)_host).GetTextDirection();

    /// <inheritdoc cref="TextEdit.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((TextEdit)_host).SetLanguage(@language);

    /// <inheritdoc cref="TextEdit.GetLanguage()" />
    public string GetLanguage() => ((TextEdit)_host).GetLanguage();

    /// <inheritdoc cref="TextEdit.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((TextEdit)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="TextEdit.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((TextEdit)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="TextEdit.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((TextEdit)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="TextEdit.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((TextEdit)_host).GetStructuredTextBidiOverrideOptions();

    /// <inheritdoc cref="TextEdit.SetTabSize(int)" />
    public void SetTabSize(int @size) => ((TextEdit)_host).SetTabSize(@size);

    /// <inheritdoc cref="TextEdit.GetTabSize()" />
    public int GetTabSize() => ((TextEdit)_host).GetTabSize();

    /// <inheritdoc cref="TextEdit.SetIndentWrappedLines(bool)" />
    public void SetIndentWrappedLines(bool @enabled) => ((TextEdit)_host).SetIndentWrappedLines(@enabled);

    /// <inheritdoc cref="TextEdit.IsIndentWrappedLines()" />
    public bool IsIndentWrappedLines() => ((TextEdit)_host).IsIndentWrappedLines();

    /// <inheritdoc cref="TextEdit.SetTabInputMode(bool)" />
    public void SetTabInputMode(bool @enabled) => ((TextEdit)_host).SetTabInputMode(@enabled);

    /// <inheritdoc cref="TextEdit.GetTabInputMode()" />
    public bool GetTabInputMode() => ((TextEdit)_host).GetTabInputMode();

    /// <inheritdoc cref="TextEdit.SetOvertypeModeEnabled(bool)" />
    public void SetOvertypeModeEnabled(bool @enabled) => ((TextEdit)_host).SetOvertypeModeEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsOvertypeModeEnabled()" />
    public bool IsOvertypeModeEnabled() => ((TextEdit)_host).IsOvertypeModeEnabled();

    /// <inheritdoc cref="TextEdit.SetContextMenuEnabled(bool)" />
    public void SetContextMenuEnabled(bool @enabled) => ((TextEdit)_host).SetContextMenuEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsContextMenuEnabled()" />
    public bool IsContextMenuEnabled() => ((TextEdit)_host).IsContextMenuEnabled();

    /// <inheritdoc cref="TextEdit.SetEmojiMenuEnabled(bool)" />
    public void SetEmojiMenuEnabled(bool @enable) => ((TextEdit)_host).SetEmojiMenuEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsEmojiMenuEnabled()" />
    public bool IsEmojiMenuEnabled() => ((TextEdit)_host).IsEmojiMenuEnabled();

    /// <inheritdoc cref="TextEdit.SetBackspaceDeletesCompositeCharacterEnabled(bool)" />
    public void SetBackspaceDeletesCompositeCharacterEnabled(bool @enable) => ((TextEdit)_host).SetBackspaceDeletesCompositeCharacterEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsBackspaceDeletesCompositeCharacterEnabled()" />
    public bool IsBackspaceDeletesCompositeCharacterEnabled() => ((TextEdit)_host).IsBackspaceDeletesCompositeCharacterEnabled();

    /// <inheritdoc cref="TextEdit.SetShortcutKeysEnabled(bool)" />
    public void SetShortcutKeysEnabled(bool @enabled) => ((TextEdit)_host).SetShortcutKeysEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsShortcutKeysEnabled()" />
    public bool IsShortcutKeysEnabled() => ((TextEdit)_host).IsShortcutKeysEnabled();

    /// <inheritdoc cref="TextEdit.SetVirtualKeyboardEnabled(bool)" />
    public void SetVirtualKeyboardEnabled(bool @enabled) => ((TextEdit)_host).SetVirtualKeyboardEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsVirtualKeyboardEnabled()" />
    public bool IsVirtualKeyboardEnabled() => ((TextEdit)_host).IsVirtualKeyboardEnabled();

    /// <inheritdoc cref="TextEdit.SetVirtualKeyboardShowOnFocus(bool)" />
    public void SetVirtualKeyboardShowOnFocus(bool @showOnFocus) => ((TextEdit)_host).SetVirtualKeyboardShowOnFocus(@showOnFocus);

    /// <inheritdoc cref="TextEdit.GetVirtualKeyboardShowOnFocus()" />
    public bool GetVirtualKeyboardShowOnFocus() => ((TextEdit)_host).GetVirtualKeyboardShowOnFocus();

    /// <inheritdoc cref="TextEdit.SetMiddleMousePasteEnabled(bool)" />
    public void SetMiddleMousePasteEnabled(bool @enabled) => ((TextEdit)_host).SetMiddleMousePasteEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsMiddleMousePasteEnabled()" />
    public bool IsMiddleMousePasteEnabled() => ((TextEdit)_host).IsMiddleMousePasteEnabled();

    /// <inheritdoc cref="TextEdit.SetEmptySelectionClipboardEnabled(bool)" />
    public void SetEmptySelectionClipboardEnabled(bool @enabled) => ((TextEdit)_host).SetEmptySelectionClipboardEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsEmptySelectionClipboardEnabled()" />
    public bool IsEmptySelectionClipboardEnabled() => ((TextEdit)_host).IsEmptySelectionClipboardEnabled();

    /// <inheritdoc cref="TextEdit.Clear()" />
    public void Clear() => ((TextEdit)_host).Clear();

    /// <inheritdoc cref="TextEdit.SetText(string)" />
    public void SetText(string @text) => ((TextEdit)_host).SetText(@text);

    /// <inheritdoc cref="TextEdit.GetText()" />
    public string GetText() => ((TextEdit)_host).GetText();

    /// <inheritdoc cref="TextEdit.GetLineCount()" />
    public int GetLineCount() => ((TextEdit)_host).GetLineCount();

    /// <inheritdoc cref="TextEdit.SetPlaceholder(string)" />
    public void SetPlaceholder(string @text) => ((TextEdit)_host).SetPlaceholder(@text);

    /// <inheritdoc cref="TextEdit.GetPlaceholder()" />
    public string GetPlaceholder() => ((TextEdit)_host).GetPlaceholder();

    /// <inheritdoc cref="TextEdit.SetLine(int, string)" />
    public void SetLine(int @line, string @newText) => ((TextEdit)_host).SetLine(@line, @newText);

    /// <inheritdoc cref="TextEdit.GetLine(int)" />
    public string GetLine(int @line) => ((TextEdit)_host).GetLine(@line);

    /// <inheritdoc cref="TextEdit.GetLineWithIme(int)" />
    public string GetLineWithIme(int @line) => ((TextEdit)_host).GetLineWithIme(@line);

    /// <inheritdoc cref="TextEdit.GetLineWidth(int, int)" />
    public int GetLineWidth(int @line, int @wrapIndex) => ((TextEdit)_host).GetLineWidth(@line, @wrapIndex);

    /// <inheritdoc cref="TextEdit.GetLineHeight()" />
    public int GetLineHeight() => ((TextEdit)_host).GetLineHeight();

    /// <inheritdoc cref="TextEdit.GetIndentLevel(int)" />
    public int GetIndentLevel(int @line) => ((TextEdit)_host).GetIndentLevel(@line);

    /// <inheritdoc cref="TextEdit.GetFirstNonWhiteSpaceColumn(int)" />
    public int GetFirstNonWhiteSpaceColumn(int @line) => ((TextEdit)_host).GetFirstNonWhiteSpaceColumn(@line);

    /// <inheritdoc cref="TextEdit.SwapLines(int, int)" />
    public void SwapLines(int @fromLine, int @toLine) => ((TextEdit)_host).SwapLines(@fromLine, @toLine);

    /// <inheritdoc cref="TextEdit.InsertLineAt(int, string)" />
    public void InsertLineAt(int @line, string @text) => ((TextEdit)_host).InsertLineAt(@line, @text);

    /// <inheritdoc cref="TextEdit.RemoveLineAt(int, bool)" />
    public void RemoveLineAt(int @line, bool @moveCaretsDown) => ((TextEdit)_host).RemoveLineAt(@line, @moveCaretsDown);

    /// <inheritdoc cref="TextEdit.InsertTextAtCaret(string, int)" />
    public void InsertTextAtCaret(string @text, int @caretIndex) => ((TextEdit)_host).InsertTextAtCaret(@text, @caretIndex);

    /// <inheritdoc cref="TextEdit.InsertText(string, int, int, bool, bool)" />
    public void InsertText(string @text, int @line, int @column, bool @beforeSelectionBegin, bool @beforeSelectionEnd) => ((TextEdit)_host).InsertText(@text, @line, @column, @beforeSelectionBegin, @beforeSelectionEnd);

    /// <inheritdoc cref="TextEdit.RemoveText(int, int, int, int)" />
    public void RemoveText(int @fromLine, int @fromColumn, int @toLine, int @toColumn) => ((TextEdit)_host).RemoveText(@fromLine, @fromColumn, @toLine, @toColumn);

    /// <inheritdoc cref="TextEdit.GetLastUnhiddenLine()" />
    public int GetLastUnhiddenLine() => ((TextEdit)_host).GetLastUnhiddenLine();

    /// <inheritdoc cref="TextEdit.GetNextVisibleLineOffsetFrom(int, int)" />
    public int GetNextVisibleLineOffsetFrom(int @line, int @visibleAmount) => ((TextEdit)_host).GetNextVisibleLineOffsetFrom(@line, @visibleAmount);

    /// <inheritdoc cref="TextEdit.GetNextVisibleLineIndexOffsetFrom(int, int, int)" />
    public Vector2I GetNextVisibleLineIndexOffsetFrom(int @line, int @wrapIndex, int @visibleAmount) => ((TextEdit)_host).GetNextVisibleLineIndexOffsetFrom(@line, @wrapIndex, @visibleAmount);

    /// <inheritdoc cref="TextEdit.Backspace(int)" />
    public void Backspace(int @caretIndex) => ((TextEdit)_host).Backspace(@caretIndex);

    /// <inheritdoc cref="TextEdit.Cut(int)" />
    public void Cut(int @caretIndex) => ((TextEdit)_host).Cut(@caretIndex);

    /// <inheritdoc cref="TextEdit.Copy(int)" />
    public void Copy(int @caretIndex) => ((TextEdit)_host).Copy(@caretIndex);

    /// <inheritdoc cref="TextEdit.Paste(int)" />
    public void Paste(int @caretIndex) => ((TextEdit)_host).Paste(@caretIndex);

    /// <inheritdoc cref="TextEdit.PastePrimaryClipboard(int)" />
    public void PastePrimaryClipboard(int @caretIndex) => ((TextEdit)_host).PastePrimaryClipboard(@caretIndex);

    /// <inheritdoc cref="TextEdit.StartAction(TextEdit.EditAction)" />
    public void StartAction(TextEdit.EditAction @action) => ((TextEdit)_host).StartAction(@action);

    /// <inheritdoc cref="TextEdit.EndAction()" />
    public void EndAction() => ((TextEdit)_host).EndAction();

    /// <inheritdoc cref="TextEdit.BeginComplexOperation()" />
    public void BeginComplexOperation() => ((TextEdit)_host).BeginComplexOperation();

    /// <inheritdoc cref="TextEdit.EndComplexOperation()" />
    public void EndComplexOperation() => ((TextEdit)_host).EndComplexOperation();

    /// <inheritdoc cref="TextEdit.HasUndo()" />
    public bool HasUndo() => ((TextEdit)_host).HasUndo();

    /// <inheritdoc cref="TextEdit.HasRedo()" />
    public bool HasRedo() => ((TextEdit)_host).HasRedo();

    /// <inheritdoc cref="TextEdit.Undo()" />
    public void Undo() => ((TextEdit)_host).Undo();

    /// <inheritdoc cref="TextEdit.Redo()" />
    public void Redo() => ((TextEdit)_host).Redo();

    /// <inheritdoc cref="TextEdit.ClearUndoHistory()" />
    public void ClearUndoHistory() => ((TextEdit)_host).ClearUndoHistory();

    /// <inheritdoc cref="TextEdit.TagSavedVersion()" />
    public void TagSavedVersion() => ((TextEdit)_host).TagSavedVersion();

    /// <inheritdoc cref="TextEdit.GetVersion()" />
    public uint GetVersion() => ((TextEdit)_host).GetVersion();

    /// <inheritdoc cref="TextEdit.GetSavedVersion()" />
    public uint GetSavedVersion() => ((TextEdit)_host).GetSavedVersion();

    /// <inheritdoc cref="TextEdit.SetSearchText(string)" />
    public void SetSearchText(string @searchText) => ((TextEdit)_host).SetSearchText(@searchText);

    /// <inheritdoc cref="TextEdit.SetSearchFlags(uint)" />
    public void SetSearchFlags(uint @flags) => ((TextEdit)_host).SetSearchFlags(@flags);

    /// <inheritdoc cref="TextEdit.Search(string, uint, int, int)" />
    public Vector2I Search(string @text, uint @flags, int @fromLine, int @fromColumn) => ((TextEdit)_host).Search(@text, @flags, @fromLine, @fromColumn);

    /// <inheritdoc cref="TextEdit.SetTooltipRequestFunc(Callable)" />
    public void SetTooltipRequestFunc(Callable @callback) => ((TextEdit)_host).SetTooltipRequestFunc(@callback);

    /// <inheritdoc cref="TextEdit.GetLocalMousePos()" />
    public Vector2 GetLocalMousePos() => ((TextEdit)_host).GetLocalMousePos();

    /// <inheritdoc cref="TextEdit.GetWordAtPos(Vector2)" />
    public string GetWordAtPos(Vector2 @position) => ((TextEdit)_host).GetWordAtPos(@position);

    /// <inheritdoc cref="TextEdit.GetLineColumnAtPos(Vector2I, bool, bool)" />
    public Vector2I GetLineColumnAtPos(Vector2I @position, bool @clampLine, bool @clampColumn) => ((TextEdit)_host).GetLineColumnAtPos(@position, @clampLine, @clampColumn);

    /// <inheritdoc cref="TextEdit.GetPosAtLineColumn(int, int)" />
    public Vector2I GetPosAtLineColumn(int @line, int @column) => ((TextEdit)_host).GetPosAtLineColumn(@line, @column);

    /// <inheritdoc cref="TextEdit.GetRectAtLineColumn(int, int)" />
    public Rect2I GetRectAtLineColumn(int @line, int @column) => ((TextEdit)_host).GetRectAtLineColumn(@line, @column);

    /// <inheritdoc cref="TextEdit.GetMinimapLineAtPos(Vector2I)" />
    public int GetMinimapLineAtPos(Vector2I @position) => ((TextEdit)_host).GetMinimapLineAtPos(@position);

    /// <inheritdoc cref="TextEdit.IsDraggingCursor()" />
    public bool IsDraggingCursor() => ((TextEdit)_host).IsDraggingCursor();

    /// <inheritdoc cref="TextEdit.IsMouseOverSelection(bool, int)" />
    public bool IsMouseOverSelection(bool @edges, int @caretIndex) => ((TextEdit)_host).IsMouseOverSelection(@edges, @caretIndex);

    /// <inheritdoc cref="TextEdit.SetCaretType(TextEdit.CaretTypeEnum)" />
    public void SetCaretType(TextEdit.CaretTypeEnum @type) => ((TextEdit)_host).SetCaretType(@type);

    /// <inheritdoc cref="TextEdit.GetCaretType()" />
    public TextEdit.CaretTypeEnum GetCaretType() => ((TextEdit)_host).GetCaretType();

    /// <inheritdoc cref="TextEdit.SetCaretBlinkEnabled(bool)" />
    public void SetCaretBlinkEnabled(bool @enable) => ((TextEdit)_host).SetCaretBlinkEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsCaretBlinkEnabled()" />
    public bool IsCaretBlinkEnabled() => ((TextEdit)_host).IsCaretBlinkEnabled();

    /// <inheritdoc cref="TextEdit.SetCaretBlinkInterval(float)" />
    public void SetCaretBlinkInterval(float @interval) => ((TextEdit)_host).SetCaretBlinkInterval(@interval);

    /// <inheritdoc cref="TextEdit.GetCaretBlinkInterval()" />
    public float GetCaretBlinkInterval() => ((TextEdit)_host).GetCaretBlinkInterval();

    /// <inheritdoc cref="TextEdit.SetDrawCaretWhenEditableDisabled(bool)" />
    public void SetDrawCaretWhenEditableDisabled(bool @enable) => ((TextEdit)_host).SetDrawCaretWhenEditableDisabled(@enable);

    /// <inheritdoc cref="TextEdit.IsDrawingCaretWhenEditableDisabled()" />
    public bool IsDrawingCaretWhenEditableDisabled() => ((TextEdit)_host).IsDrawingCaretWhenEditableDisabled();

    /// <inheritdoc cref="TextEdit.SetMoveCaretOnRightClickEnabled(bool)" />
    public void SetMoveCaretOnRightClickEnabled(bool @enable) => ((TextEdit)_host).SetMoveCaretOnRightClickEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsMoveCaretOnRightClickEnabled()" />
    public bool IsMoveCaretOnRightClickEnabled() => ((TextEdit)_host).IsMoveCaretOnRightClickEnabled();

    /// <inheritdoc cref="TextEdit.SetCaretMidGraphemeEnabled(bool)" />
    public void SetCaretMidGraphemeEnabled(bool @enabled) => ((TextEdit)_host).SetCaretMidGraphemeEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsCaretMidGraphemeEnabled()" />
    public bool IsCaretMidGraphemeEnabled() => ((TextEdit)_host).IsCaretMidGraphemeEnabled();

    /// <inheritdoc cref="TextEdit.SetMultipleCaretsEnabled(bool)" />
    public void SetMultipleCaretsEnabled(bool @enabled) => ((TextEdit)_host).SetMultipleCaretsEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsMultipleCaretsEnabled()" />
    public bool IsMultipleCaretsEnabled() => ((TextEdit)_host).IsMultipleCaretsEnabled();

    /// <inheritdoc cref="TextEdit.AddCaret(int, int)" />
    public int AddCaret(int @line, int @column) => ((TextEdit)_host).AddCaret(@line, @column);

    /// <inheritdoc cref="TextEdit.RemoveCaret(int)" />
    public void RemoveCaret(int @caret) => ((TextEdit)_host).RemoveCaret(@caret);

    /// <inheritdoc cref="TextEdit.RemoveSecondaryCarets()" />
    public void RemoveSecondaryCarets() => ((TextEdit)_host).RemoveSecondaryCarets();

    /// <inheritdoc cref="TextEdit.GetCaretCount()" />
    public int GetCaretCount() => ((TextEdit)_host).GetCaretCount();

    /// <inheritdoc cref="TextEdit.AddCaretAtCarets(bool)" />
    public void AddCaretAtCarets(bool @below) => ((TextEdit)_host).AddCaretAtCarets(@below);

    /// <inheritdoc cref="TextEdit.GetSortedCarets(bool)" />
    public int[] GetSortedCarets(bool @includeIgnoredCarets) => ((TextEdit)_host).GetSortedCarets(@includeIgnoredCarets);

    /// <inheritdoc cref="TextEdit.CollapseCarets(int, int, int, int, bool)" />
    public void CollapseCarets(int @fromLine, int @fromColumn, int @toLine, int @toColumn, bool @inclusive) => ((TextEdit)_host).CollapseCarets(@fromLine, @fromColumn, @toLine, @toColumn, @inclusive);

    /// <inheritdoc cref="TextEdit.MergeOverlappingCarets()" />
    public void MergeOverlappingCarets() => ((TextEdit)_host).MergeOverlappingCarets();

    /// <inheritdoc cref="TextEdit.BeginMulticaretEdit()" />
    public void BeginMulticaretEdit() => ((TextEdit)_host).BeginMulticaretEdit();

    /// <inheritdoc cref="TextEdit.EndMulticaretEdit()" />
    public void EndMulticaretEdit() => ((TextEdit)_host).EndMulticaretEdit();

    /// <inheritdoc cref="TextEdit.IsInMulitcaretEdit()" />
    public bool IsInMulitcaretEdit() => ((TextEdit)_host).IsInMulitcaretEdit();

    /// <inheritdoc cref="TextEdit.MulticaretEditIgnoreCaret(int)" />
    public bool MulticaretEditIgnoreCaret(int @caretIndex) => ((TextEdit)_host).MulticaretEditIgnoreCaret(@caretIndex);

    /// <inheritdoc cref="TextEdit.IsCaretVisible(int)" />
    public bool IsCaretVisible(int @caretIndex) => ((TextEdit)_host).IsCaretVisible(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetCaretDrawPos(int)" />
    public Vector2 GetCaretDrawPos(int @caretIndex) => ((TextEdit)_host).GetCaretDrawPos(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetCaretLine(int, bool, bool, int, int)" />
    public void SetCaretLine(int @line, bool @adjustViewport, bool @canBeHidden, int @wrapIndex, int @caretIndex) => ((TextEdit)_host).SetCaretLine(@line, @adjustViewport, @canBeHidden, @wrapIndex, @caretIndex);

    /// <inheritdoc cref="TextEdit.GetCaretLine(int)" />
    public int GetCaretLine(int @caretIndex) => ((TextEdit)_host).GetCaretLine(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetCaretColumn(int, bool, int)" />
    public void SetCaretColumn(int @column, bool @adjustViewport, int @caretIndex) => ((TextEdit)_host).SetCaretColumn(@column, @adjustViewport, @caretIndex);

    /// <inheritdoc cref="TextEdit.GetCaretColumn(int)" />
    public int GetCaretColumn(int @caretIndex) => ((TextEdit)_host).GetCaretColumn(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetNextCompositeCharacterColumn(int, int)" />
    public int GetNextCompositeCharacterColumn(int @line, int @column) => ((TextEdit)_host).GetNextCompositeCharacterColumn(@line, @column);

    /// <inheritdoc cref="TextEdit.GetPreviousCompositeCharacterColumn(int, int)" />
    public int GetPreviousCompositeCharacterColumn(int @line, int @column) => ((TextEdit)_host).GetPreviousCompositeCharacterColumn(@line, @column);

    /// <inheritdoc cref="TextEdit.GetCaretWrapIndex(int)" />
    public int GetCaretWrapIndex(int @caretIndex) => ((TextEdit)_host).GetCaretWrapIndex(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetWordUnderCaret(int)" />
    public string GetWordUnderCaret(int @caretIndex) => ((TextEdit)_host).GetWordUnderCaret(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetUseDefaultWordSeparators(bool)" />
    public void SetUseDefaultWordSeparators(bool @enabled) => ((TextEdit)_host).SetUseDefaultWordSeparators(@enabled);

    /// <inheritdoc cref="TextEdit.IsDefaultWordSeparatorsEnabled()" />
    public bool IsDefaultWordSeparatorsEnabled() => ((TextEdit)_host).IsDefaultWordSeparatorsEnabled();

    /// <inheritdoc cref="TextEdit.SetUseCustomWordSeparators(bool)" />
    public void SetUseCustomWordSeparators(bool @enabled) => ((TextEdit)_host).SetUseCustomWordSeparators(@enabled);

    /// <inheritdoc cref="TextEdit.IsCustomWordSeparatorsEnabled()" />
    public bool IsCustomWordSeparatorsEnabled() => ((TextEdit)_host).IsCustomWordSeparatorsEnabled();

    /// <inheritdoc cref="TextEdit.SetCustomWordSeparators(string)" />
    public void SetCustomWordSeparators(string @customWordSeparators) => ((TextEdit)_host).SetCustomWordSeparators(@customWordSeparators);

    /// <inheritdoc cref="TextEdit.GetCustomWordSeparators()" />
    public string GetCustomWordSeparators() => ((TextEdit)_host).GetCustomWordSeparators();

    /// <inheritdoc cref="TextEdit.SetSelectingEnabled(bool)" />
    public void SetSelectingEnabled(bool @enable) => ((TextEdit)_host).SetSelectingEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsSelectingEnabled()" />
    public bool IsSelectingEnabled() => ((TextEdit)_host).IsSelectingEnabled();

    /// <inheritdoc cref="TextEdit.SetDeselectOnFocusLossEnabled(bool)" />
    public void SetDeselectOnFocusLossEnabled(bool @enable) => ((TextEdit)_host).SetDeselectOnFocusLossEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsDeselectOnFocusLossEnabled()" />
    public bool IsDeselectOnFocusLossEnabled() => ((TextEdit)_host).IsDeselectOnFocusLossEnabled();

    /// <inheritdoc cref="TextEdit.SetDragAndDropSelectionEnabled(bool)" />
    public void SetDragAndDropSelectionEnabled(bool @enable) => ((TextEdit)_host).SetDragAndDropSelectionEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsDragAndDropSelectionEnabled()" />
    public bool IsDragAndDropSelectionEnabled() => ((TextEdit)_host).IsDragAndDropSelectionEnabled();

    /// <inheritdoc cref="TextEdit.SetSelectionMode(TextEdit.SelectionMode)" />
    public void SetSelectionMode(TextEdit.SelectionMode @mode) => ((TextEdit)_host).SetSelectionMode(@mode);

    /// <inheritdoc cref="TextEdit.GetSelectionMode()" />
    public TextEdit.SelectionMode GetSelectionMode() => ((TextEdit)_host).GetSelectionMode();

    /// <inheritdoc cref="TextEdit.SelectAll()" />
    public void SelectAll() => ((TextEdit)_host).SelectAll();

    /// <inheritdoc cref="TextEdit.SelectWordUnderCaret(int)" />
    public void SelectWordUnderCaret(int @caretIndex) => ((TextEdit)_host).SelectWordUnderCaret(@caretIndex);

    /// <inheritdoc cref="TextEdit.AddSelectionForNextOccurrence()" />
    public void AddSelectionForNextOccurrence() => ((TextEdit)_host).AddSelectionForNextOccurrence();

    /// <inheritdoc cref="TextEdit.SkipSelectionForNextOccurrence()" />
    public void SkipSelectionForNextOccurrence() => ((TextEdit)_host).SkipSelectionForNextOccurrence();

    /// <inheritdoc cref="TextEdit.Select(int, int, int, int, int)" />
    public void Select(int @originLine, int @originColumn, int @caretLine, int @caretColumn, int @caretIndex) => ((TextEdit)_host).Select(@originLine, @originColumn, @caretLine, @caretColumn, @caretIndex);

    /// <inheritdoc cref="TextEdit.HasSelection(int)" />
    public bool HasSelection(int @caretIndex) => ((TextEdit)_host).HasSelection(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectedText(int)" />
    public string GetSelectedText(int @caretIndex) => ((TextEdit)_host).GetSelectedText(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionAtLineColumn(int, int, bool, bool)" />
    public int GetSelectionAtLineColumn(int @line, int @column, bool @includeEdges, bool @onlySelections) => ((TextEdit)_host).GetSelectionAtLineColumn(@line, @column, @includeEdges, @onlySelections);

    /// <inheritdoc cref="TextEdit.GetLineRangesFromCarets(bool, bool)" />
    public Array<Vector2I> GetLineRangesFromCarets(bool @onlySelections, bool @mergeAdjacent) => ((TextEdit)_host).GetLineRangesFromCarets(@onlySelections, @mergeAdjacent);

    /// <inheritdoc cref="TextEdit.GetSelectionOriginLine(int)" />
    public int GetSelectionOriginLine(int @caretIndex) => ((TextEdit)_host).GetSelectionOriginLine(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionOriginColumn(int)" />
    public int GetSelectionOriginColumn(int @caretIndex) => ((TextEdit)_host).GetSelectionOriginColumn(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetSelectionOriginLine(int, bool, int, int)" />
    public void SetSelectionOriginLine(int @line, bool @canBeHidden, int @wrapIndex, int @caretIndex) => ((TextEdit)_host).SetSelectionOriginLine(@line, @canBeHidden, @wrapIndex, @caretIndex);

    /// <inheritdoc cref="TextEdit.SetSelectionOriginColumn(int, int)" />
    public void SetSelectionOriginColumn(int @column, int @caretIndex) => ((TextEdit)_host).SetSelectionOriginColumn(@column, @caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionFromLine(int)" />
    public int GetSelectionFromLine(int @caretIndex) => ((TextEdit)_host).GetSelectionFromLine(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionFromColumn(int)" />
    public int GetSelectionFromColumn(int @caretIndex) => ((TextEdit)_host).GetSelectionFromColumn(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionToLine(int)" />
    public int GetSelectionToLine(int @caretIndex) => ((TextEdit)_host).GetSelectionToLine(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionToColumn(int)" />
    public int GetSelectionToColumn(int @caretIndex) => ((TextEdit)_host).GetSelectionToColumn(@caretIndex);

    /// <inheritdoc cref="TextEdit.IsCaretAfterSelectionOrigin(int)" />
    public bool IsCaretAfterSelectionOrigin(int @caretIndex) => ((TextEdit)_host).IsCaretAfterSelectionOrigin(@caretIndex);

    /// <inheritdoc cref="TextEdit.Deselect(int)" />
    public void Deselect(int @caretIndex) => ((TextEdit)_host).Deselect(@caretIndex);

    /// <inheritdoc cref="TextEdit.DeleteSelection(int)" />
    public void DeleteSelection(int @caretIndex) => ((TextEdit)_host).DeleteSelection(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetLineWrappingMode(TextEdit.LineWrappingMode)" />
    public void SetLineWrappingMode(TextEdit.LineWrappingMode @mode) => ((TextEdit)_host).SetLineWrappingMode(@mode);

    /// <inheritdoc cref="TextEdit.GetLineWrappingMode()" />
    public TextEdit.LineWrappingMode GetLineWrappingMode() => ((TextEdit)_host).GetLineWrappingMode();

    /// <inheritdoc cref="TextEdit.SetAutowrapMode(TextServer.AutowrapMode)" />
    public void SetAutowrapMode(TextServer.AutowrapMode @autowrapMode) => ((TextEdit)_host).SetAutowrapMode(@autowrapMode);

    /// <inheritdoc cref="TextEdit.GetAutowrapMode()" />
    public TextServer.AutowrapMode GetAutowrapMode() => ((TextEdit)_host).GetAutowrapMode();

    /// <inheritdoc cref="TextEdit.IsLineWrapped(int)" />
    public bool IsLineWrapped(int @line) => ((TextEdit)_host).IsLineWrapped(@line);

    /// <inheritdoc cref="TextEdit.GetLineWrapCount(int)" />
    public int GetLineWrapCount(int @line) => ((TextEdit)_host).GetLineWrapCount(@line);

    /// <inheritdoc cref="TextEdit.GetLineWrapIndexAtColumn(int, int)" />
    public int GetLineWrapIndexAtColumn(int @line, int @column) => ((TextEdit)_host).GetLineWrapIndexAtColumn(@line, @column);

    /// <inheritdoc cref="TextEdit.GetLineWrappedText(int)" />
    public string[] GetLineWrappedText(int @line) => ((TextEdit)_host).GetLineWrappedText(@line);

    /// <inheritdoc cref="TextEdit.SetSmoothScrollEnabled(bool)" />
    public void SetSmoothScrollEnabled(bool @enable) => ((TextEdit)_host).SetSmoothScrollEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsSmoothScrollEnabled()" />
    public bool IsSmoothScrollEnabled() => ((TextEdit)_host).IsSmoothScrollEnabled();

    /// <inheritdoc cref="TextEdit.GetVScrollBar()" />
    public VScrollBar GetVScrollBar() => ((TextEdit)_host).GetVScrollBar();

    /// <inheritdoc cref="TextEdit.GetHScrollBar()" />
    public HScrollBar GetHScrollBar() => ((TextEdit)_host).GetHScrollBar();

    /// <inheritdoc cref="TextEdit.SetVScroll(double)" />
    public void SetVScroll(double @value) => ((TextEdit)_host).SetVScroll(@value);

    /// <inheritdoc cref="TextEdit.GetVScroll()" />
    public double GetVScroll() => ((TextEdit)_host).GetVScroll();

    /// <inheritdoc cref="TextEdit.SetHScroll(int)" />
    public void SetHScroll(int @value) => ((TextEdit)_host).SetHScroll(@value);

    /// <inheritdoc cref="TextEdit.GetHScroll()" />
    public int GetHScroll() => ((TextEdit)_host).GetHScroll();

    /// <inheritdoc cref="TextEdit.SetScrollPastEndOfFileEnabled(bool)" />
    public void SetScrollPastEndOfFileEnabled(bool @enable) => ((TextEdit)_host).SetScrollPastEndOfFileEnabled(@enable);

    /// <inheritdoc cref="TextEdit.IsScrollPastEndOfFileEnabled()" />
    public bool IsScrollPastEndOfFileEnabled() => ((TextEdit)_host).IsScrollPastEndOfFileEnabled();

    /// <inheritdoc cref="TextEdit.SetVScrollSpeed(float)" />
    public void SetVScrollSpeed(float @speed) => ((TextEdit)_host).SetVScrollSpeed(@speed);

    /// <inheritdoc cref="TextEdit.GetVScrollSpeed()" />
    public float GetVScrollSpeed() => ((TextEdit)_host).GetVScrollSpeed();

    /// <inheritdoc cref="TextEdit.SetFitContentHeightEnabled(bool)" />
    public void SetFitContentHeightEnabled(bool @enabled) => ((TextEdit)_host).SetFitContentHeightEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsFitContentHeightEnabled()" />
    public bool IsFitContentHeightEnabled() => ((TextEdit)_host).IsFitContentHeightEnabled();

    /// <inheritdoc cref="TextEdit.SetFitContentWidthEnabled(bool)" />
    public void SetFitContentWidthEnabled(bool @enabled) => ((TextEdit)_host).SetFitContentWidthEnabled(@enabled);

    /// <inheritdoc cref="TextEdit.IsFitContentWidthEnabled()" />
    public bool IsFitContentWidthEnabled() => ((TextEdit)_host).IsFitContentWidthEnabled();

    /// <inheritdoc cref="TextEdit.GetScrollPosForLine(int, int)" />
    public double GetScrollPosForLine(int @line, int @wrapIndex) => ((TextEdit)_host).GetScrollPosForLine(@line, @wrapIndex);

    /// <inheritdoc cref="TextEdit.SetLineAsFirstVisible(int, int)" />
    public void SetLineAsFirstVisible(int @line, int @wrapIndex) => ((TextEdit)_host).SetLineAsFirstVisible(@line, @wrapIndex);

    /// <inheritdoc cref="TextEdit.GetFirstVisibleLine()" />
    public int GetFirstVisibleLine() => ((TextEdit)_host).GetFirstVisibleLine();

    /// <inheritdoc cref="TextEdit.SetLineAsCenterVisible(int, int)" />
    public void SetLineAsCenterVisible(int @line, int @wrapIndex) => ((TextEdit)_host).SetLineAsCenterVisible(@line, @wrapIndex);

    /// <inheritdoc cref="TextEdit.SetLineAsLastVisible(int, int)" />
    public void SetLineAsLastVisible(int @line, int @wrapIndex) => ((TextEdit)_host).SetLineAsLastVisible(@line, @wrapIndex);

    /// <inheritdoc cref="TextEdit.GetLastFullVisibleLine()" />
    public int GetLastFullVisibleLine() => ((TextEdit)_host).GetLastFullVisibleLine();

    /// <inheritdoc cref="TextEdit.GetLastFullVisibleLineWrapIndex()" />
    public int GetLastFullVisibleLineWrapIndex() => ((TextEdit)_host).GetLastFullVisibleLineWrapIndex();

    /// <inheritdoc cref="TextEdit.GetVisibleLineCount()" />
    public int GetVisibleLineCount() => ((TextEdit)_host).GetVisibleLineCount();

    /// <inheritdoc cref="TextEdit.GetVisibleLineCountInRange(int, int)" />
    public int GetVisibleLineCountInRange(int @fromLine, int @toLine) => ((TextEdit)_host).GetVisibleLineCountInRange(@fromLine, @toLine);

    /// <inheritdoc cref="TextEdit.GetTotalVisibleLineCount()" />
    public int GetTotalVisibleLineCount() => ((TextEdit)_host).GetTotalVisibleLineCount();

    /// <inheritdoc cref="TextEdit.AdjustViewportToCaret(int)" />
    public void AdjustViewportToCaret(int @caretIndex) => ((TextEdit)_host).AdjustViewportToCaret(@caretIndex);

    /// <inheritdoc cref="TextEdit.CenterViewportToCaret(int)" />
    public void CenterViewportToCaret(int @caretIndex) => ((TextEdit)_host).CenterViewportToCaret(@caretIndex);

    /// <inheritdoc cref="TextEdit.SetDrawMinimap(bool)" />
    public void SetDrawMinimap(bool @enabled) => ((TextEdit)_host).SetDrawMinimap(@enabled);

    /// <inheritdoc cref="TextEdit.IsDrawingMinimap()" />
    public bool IsDrawingMinimap() => ((TextEdit)_host).IsDrawingMinimap();

    /// <inheritdoc cref="TextEdit.SetMinimapWidth(int)" />
    public void SetMinimapWidth(int @width) => ((TextEdit)_host).SetMinimapWidth(@width);

    /// <inheritdoc cref="TextEdit.GetMinimapWidth()" />
    public int GetMinimapWidth() => ((TextEdit)_host).GetMinimapWidth();

    /// <inheritdoc cref="TextEdit.GetMinimapVisibleLines()" />
    public int GetMinimapVisibleLines() => ((TextEdit)_host).GetMinimapVisibleLines();

    /// <inheritdoc cref="TextEdit.AddGutter(int)" />
    public void AddGutter(int @at) => ((TextEdit)_host).AddGutter(@at);

    /// <inheritdoc cref="TextEdit.RemoveGutter(int)" />
    public void RemoveGutter(int @gutter) => ((TextEdit)_host).RemoveGutter(@gutter);

    /// <inheritdoc cref="TextEdit.GetGutterCount()" />
    public int GetGutterCount() => ((TextEdit)_host).GetGutterCount();

    /// <inheritdoc cref="TextEdit.SetGutterName(int, string)" />
    public void SetGutterName(int @gutter, string @name) => ((TextEdit)_host).SetGutterName(@gutter, @name);

    /// <inheritdoc cref="TextEdit.GetGutterName(int)" />
    public string GetGutterName(int @gutter) => ((TextEdit)_host).GetGutterName(@gutter);

    /// <inheritdoc cref="TextEdit.SetGutterType(int, TextEdit.GutterType)" />
    public void SetGutterType(int @gutter, TextEdit.GutterType @type) => ((TextEdit)_host).SetGutterType(@gutter, @type);

    /// <inheritdoc cref="TextEdit.GetGutterType(int)" />
    public TextEdit.GutterType GetGutterType(int @gutter) => ((TextEdit)_host).GetGutterType(@gutter);

    /// <inheritdoc cref="TextEdit.SetGutterWidth(int, int)" />
    public void SetGutterWidth(int @gutter, int @width) => ((TextEdit)_host).SetGutterWidth(@gutter, @width);

    /// <inheritdoc cref="TextEdit.GetGutterWidth(int)" />
    public int GetGutterWidth(int @gutter) => ((TextEdit)_host).GetGutterWidth(@gutter);

    /// <inheritdoc cref="TextEdit.SetGutterDraw(int, bool)" />
    public void SetGutterDraw(int @gutter, bool @draw) => ((TextEdit)_host).SetGutterDraw(@gutter, @draw);

    /// <inheritdoc cref="TextEdit.IsGutterDrawn(int)" />
    public bool IsGutterDrawn(int @gutter) => ((TextEdit)_host).IsGutterDrawn(@gutter);

    /// <inheritdoc cref="TextEdit.SetGutterClickable(int, bool)" />
    public void SetGutterClickable(int @gutter, bool @clickable) => ((TextEdit)_host).SetGutterClickable(@gutter, @clickable);

    /// <inheritdoc cref="TextEdit.IsGutterClickable(int)" />
    public bool IsGutterClickable(int @gutter) => ((TextEdit)_host).IsGutterClickable(@gutter);

    /// <inheritdoc cref="TextEdit.SetGutterOverwritable(int, bool)" />
    public void SetGutterOverwritable(int @gutter, bool @overwritable) => ((TextEdit)_host).SetGutterOverwritable(@gutter, @overwritable);

    /// <inheritdoc cref="TextEdit.IsGutterOverwritable(int)" />
    public bool IsGutterOverwritable(int @gutter) => ((TextEdit)_host).IsGutterOverwritable(@gutter);

    /// <inheritdoc cref="TextEdit.MergeGutters(int, int)" />
    public void MergeGutters(int @fromLine, int @toLine) => ((TextEdit)_host).MergeGutters(@fromLine, @toLine);

    /// <inheritdoc cref="TextEdit.SetGutterCustomDraw(int, Callable)" />
    public void SetGutterCustomDraw(int @column, Callable @drawCallback) => ((TextEdit)_host).SetGutterCustomDraw(@column, @drawCallback);

    /// <inheritdoc cref="TextEdit.GetTotalGutterWidth()" />
    public int GetTotalGutterWidth() => ((TextEdit)_host).GetTotalGutterWidth();

    /// <inheritdoc cref="TextEdit.SetLineGutterMetadata(int, int, Variant)" />
    public void SetLineGutterMetadata(int @line, int @gutter, Variant @metadata) => ((TextEdit)_host).SetLineGutterMetadata(@line, @gutter, @metadata);

    /// <inheritdoc cref="TextEdit.GetLineGutterMetadata(int, int)" />
    public Variant GetLineGutterMetadata(int @line, int @gutter) => ((TextEdit)_host).GetLineGutterMetadata(@line, @gutter);

    /// <inheritdoc cref="TextEdit.SetLineGutterText(int, int, string)" />
    public void SetLineGutterText(int @line, int @gutter, string @text) => ((TextEdit)_host).SetLineGutterText(@line, @gutter, @text);

    /// <inheritdoc cref="TextEdit.GetLineGutterText(int, int)" />
    public string GetLineGutterText(int @line, int @gutter) => ((TextEdit)_host).GetLineGutterText(@line, @gutter);

    /// <inheritdoc cref="TextEdit.SetLineGutterIcon(int, int, Texture2D)" />
    public void SetLineGutterIcon(int @line, int @gutter, Texture2D @icon) => ((TextEdit)_host).SetLineGutterIcon(@line, @gutter, @icon);

    /// <inheritdoc cref="TextEdit.GetLineGutterIcon(int, int)" />
    public Texture2D GetLineGutterIcon(int @line, int @gutter) => ((TextEdit)_host).GetLineGutterIcon(@line, @gutter);

    /// <inheritdoc cref="TextEdit.SetLineGutterItemColor(int, int, Color)" />
    public void SetLineGutterItemColor(int @line, int @gutter, Color @color) => ((TextEdit)_host).SetLineGutterItemColor(@line, @gutter, @color);

    /// <inheritdoc cref="TextEdit.GetLineGutterItemColor(int, int)" />
    public Color GetLineGutterItemColor(int @line, int @gutter) => ((TextEdit)_host).GetLineGutterItemColor(@line, @gutter);

    /// <inheritdoc cref="TextEdit.SetLineGutterClickable(int, int, bool)" />
    public void SetLineGutterClickable(int @line, int @gutter, bool @clickable) => ((TextEdit)_host).SetLineGutterClickable(@line, @gutter, @clickable);

    /// <inheritdoc cref="TextEdit.IsLineGutterClickable(int, int)" />
    public bool IsLineGutterClickable(int @line, int @gutter) => ((TextEdit)_host).IsLineGutterClickable(@line, @gutter);

    /// <inheritdoc cref="TextEdit.SetLineBackgroundColor(int, Color)" />
    public void SetLineBackgroundColor(int @line, Color @color) => ((TextEdit)_host).SetLineBackgroundColor(@line, @color);

    /// <inheritdoc cref="TextEdit.GetLineBackgroundColor(int)" />
    public Color GetLineBackgroundColor(int @line) => ((TextEdit)_host).GetLineBackgroundColor(@line);

    /// <inheritdoc cref="TextEdit.SetSyntaxHighlighter(SyntaxHighlighter)" />
    public void SetSyntaxHighlighter(SyntaxHighlighter @syntaxHighlighter) => ((TextEdit)_host).SetSyntaxHighlighter(@syntaxHighlighter);

    /// <inheritdoc cref="TextEdit.GetSyntaxHighlighter()" />
    public SyntaxHighlighter GetSyntaxHighlighter() => ((TextEdit)_host).GetSyntaxHighlighter();

    /// <inheritdoc cref="TextEdit.SetHighlightCurrentLine(bool)" />
    public void SetHighlightCurrentLine(bool @enabled) => ((TextEdit)_host).SetHighlightCurrentLine(@enabled);

    /// <inheritdoc cref="TextEdit.IsHighlightCurrentLineEnabled()" />
    public bool IsHighlightCurrentLineEnabled() => ((TextEdit)_host).IsHighlightCurrentLineEnabled();

    /// <inheritdoc cref="TextEdit.SetHighlightAllOccurrences(bool)" />
    public void SetHighlightAllOccurrences(bool @enabled) => ((TextEdit)_host).SetHighlightAllOccurrences(@enabled);

    /// <inheritdoc cref="TextEdit.IsHighlightAllOccurrencesEnabled()" />
    public bool IsHighlightAllOccurrencesEnabled() => ((TextEdit)_host).IsHighlightAllOccurrencesEnabled();

    /// <inheritdoc cref="TextEdit.GetDrawControlChars()" />
    public bool GetDrawControlChars() => ((TextEdit)_host).GetDrawControlChars();

    /// <inheritdoc cref="TextEdit.SetDrawControlChars(bool)" />
    public void SetDrawControlChars(bool @enabled) => ((TextEdit)_host).SetDrawControlChars(@enabled);

    /// <inheritdoc cref="TextEdit.SetDrawTabs(bool)" />
    public void SetDrawTabs(bool @enabled) => ((TextEdit)_host).SetDrawTabs(@enabled);

    /// <inheritdoc cref="TextEdit.IsDrawingTabs()" />
    public bool IsDrawingTabs() => ((TextEdit)_host).IsDrawingTabs();

    /// <inheritdoc cref="TextEdit.SetDrawSpaces(bool)" />
    public void SetDrawSpaces(bool @enabled) => ((TextEdit)_host).SetDrawSpaces(@enabled);

    /// <inheritdoc cref="TextEdit.IsDrawingSpaces()" />
    public bool IsDrawingSpaces() => ((TextEdit)_host).IsDrawingSpaces();

    /// <inheritdoc cref="TextEdit.GetMenu()" />
    public PopupMenu GetMenu() => ((TextEdit)_host).GetMenu();

    /// <inheritdoc cref="TextEdit.IsMenuVisible()" />
    public bool IsMenuVisible() => ((TextEdit)_host).IsMenuVisible();

    /// <inheritdoc cref="TextEdit.MenuOption(int)" />
    public void MenuOption(int @option) => ((TextEdit)_host).MenuOption(@option);

    /// <inheritdoc cref="TextEdit.AdjustCaretsAfterEdit(int, int, int, int, int)" />
    public void AdjustCaretsAfterEdit(int @caret, int @fromLine, int @fromCol, int @toLine, int @toCol) => ((TextEdit)_host).AdjustCaretsAfterEdit(@caret, @fromLine, @fromCol, @toLine, @toCol);

    /// <inheritdoc cref="TextEdit.GetCaretIndexEditOrder()" />
    public int[] GetCaretIndexEditOrder() => ((TextEdit)_host).GetCaretIndexEditOrder();

    /// <inheritdoc cref="TextEdit.GetSelectionLine(int)" />
    public int GetSelectionLine(int @caretIndex) => ((TextEdit)_host).GetSelectionLine(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetSelectionColumn(int)" />
    public int GetSelectionColumn(int @caretIndex) => ((TextEdit)_host).GetSelectionColumn(@caretIndex);

    /// <inheritdoc cref="TextEdit.GetLineColumnAtPos(Vector2I, bool)" />
    public Vector2I GetLineColumnAtPos(Vector2I @position, bool @allowOutOfBounds) => ((TextEdit)_host).GetLineColumnAtPos(@position, @allowOutOfBounds);

    /// <inheritdoc cref="TextEdit.SetSelectionMode(TextEdit.SelectionMode, int, int, int)" />
    public void SetSelectionMode(TextEdit.SelectionMode @mode, int @line, int @column, int @caretIndex) => ((TextEdit)_host).SetSelectionMode(@mode, @line, @column, @caretIndex);

}
