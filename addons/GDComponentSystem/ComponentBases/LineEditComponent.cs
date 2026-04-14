#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="LineEdit" />
[Tool, GlobalClass]
public abstract partial class LineEditComponent : ControlComponent
{

    /// <inheritdoc cref="LineEdit.HasImeText()" />
    public bool HasImeText() => ((LineEdit)_host).HasImeText();

    /// <inheritdoc cref="LineEdit.CancelIme()" />
    public void CancelIme() => ((LineEdit)_host).CancelIme();

    /// <inheritdoc cref="LineEdit.ApplyIme()" />
    public void ApplyIme() => ((LineEdit)_host).ApplyIme();

    /// <inheritdoc cref="LineEdit.SetHorizontalAlignment(HorizontalAlignment)" />
    public void SetHorizontalAlignment(HorizontalAlignment @alignment) => ((LineEdit)_host).SetHorizontalAlignment(@alignment);

    /// <inheritdoc cref="LineEdit.GetHorizontalAlignment()" />
    public HorizontalAlignment GetHorizontalAlignment() => ((LineEdit)_host).GetHorizontalAlignment();

    /// <inheritdoc cref="LineEdit.Edit(bool)" />
    public void Edit(bool @hideFocus) => ((LineEdit)_host).Edit(@hideFocus);

    /// <inheritdoc cref="LineEdit.Unedit()" />
    public void Unedit() => ((LineEdit)_host).Unedit();

    /// <inheritdoc cref="LineEdit.IsEditing()" />
    public bool IsEditing() => ((LineEdit)_host).IsEditing();

    /// <inheritdoc cref="LineEdit.SetKeepEditingOnTextSubmit(bool)" />
    public void SetKeepEditingOnTextSubmit(bool @enable) => ((LineEdit)_host).SetKeepEditingOnTextSubmit(@enable);

    /// <inheritdoc cref="LineEdit.IsEditingKeptOnTextSubmit()" />
    public bool IsEditingKeptOnTextSubmit() => ((LineEdit)_host).IsEditingKeptOnTextSubmit();

    /// <inheritdoc cref="LineEdit.Clear()" />
    public void Clear() => ((LineEdit)_host).Clear();

    /// <inheritdoc cref="LineEdit.Select(int, int)" />
    public void Select(int @from, int @to) => ((LineEdit)_host).Select(@from, @to);

    /// <inheritdoc cref="LineEdit.SelectAll()" />
    public void SelectAll() => ((LineEdit)_host).SelectAll();

    /// <inheritdoc cref="LineEdit.Deselect()" />
    public void Deselect() => ((LineEdit)_host).Deselect();

    /// <inheritdoc cref="LineEdit.HasUndo()" />
    public bool HasUndo() => ((LineEdit)_host).HasUndo();

    /// <inheritdoc cref="LineEdit.HasRedo()" />
    public bool HasRedo() => ((LineEdit)_host).HasRedo();

    /// <inheritdoc cref="LineEdit.HasSelection()" />
    public bool HasSelection() => ((LineEdit)_host).HasSelection();

    /// <inheritdoc cref="LineEdit.GetSelectedText()" />
    public string GetSelectedText() => ((LineEdit)_host).GetSelectedText();

    /// <inheritdoc cref="LineEdit.GetSelectionFromColumn()" />
    public int GetSelectionFromColumn() => ((LineEdit)_host).GetSelectionFromColumn();

    /// <inheritdoc cref="LineEdit.GetSelectionToColumn()" />
    public int GetSelectionToColumn() => ((LineEdit)_host).GetSelectionToColumn();

    /// <inheritdoc cref="LineEdit.SetText(string)" />
    public void SetText(string @text) => ((LineEdit)_host).SetText(@text);

    /// <inheritdoc cref="LineEdit.GetText()" />
    public string GetText() => ((LineEdit)_host).GetText();

    /// <inheritdoc cref="LineEdit.GetDrawControlChars()" />
    public bool GetDrawControlChars() => ((LineEdit)_host).GetDrawControlChars();

    /// <inheritdoc cref="LineEdit.SetDrawControlChars(bool)" />
    public void SetDrawControlChars(bool @enable) => ((LineEdit)_host).SetDrawControlChars(@enable);

    /// <inheritdoc cref="LineEdit.SetTextDirection(Control.TextDirection)" />
    public void SetTextDirection(Control.TextDirection @direction) => ((LineEdit)_host).SetTextDirection(@direction);

    /// <inheritdoc cref="LineEdit.GetTextDirection()" />
    public Control.TextDirection GetTextDirection() => ((LineEdit)_host).GetTextDirection();

    /// <inheritdoc cref="LineEdit.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((LineEdit)_host).SetLanguage(@language);

    /// <inheritdoc cref="LineEdit.GetLanguage()" />
    public string GetLanguage() => ((LineEdit)_host).GetLanguage();

    /// <inheritdoc cref="LineEdit.SetStructuredTextBidiOverride(TextServer.StructuredTextParser)" />
    public void SetStructuredTextBidiOverride(TextServer.StructuredTextParser @parser) => ((LineEdit)_host).SetStructuredTextBidiOverride(@parser);

    /// <inheritdoc cref="LineEdit.GetStructuredTextBidiOverride()" />
    public TextServer.StructuredTextParser GetStructuredTextBidiOverride() => ((LineEdit)_host).GetStructuredTextBidiOverride();

    /// <inheritdoc cref="LineEdit.SetStructuredTextBidiOverrideOptions(Array)" />
    public void SetStructuredTextBidiOverrideOptions(Array @args) => ((LineEdit)_host).SetStructuredTextBidiOverrideOptions(@args);

    /// <inheritdoc cref="LineEdit.GetStructuredTextBidiOverrideOptions()" />
    public Array GetStructuredTextBidiOverrideOptions() => ((LineEdit)_host).GetStructuredTextBidiOverrideOptions();

    /// <inheritdoc cref="LineEdit.SetPlaceholder(string)" />
    public void SetPlaceholder(string @text) => ((LineEdit)_host).SetPlaceholder(@text);

    /// <inheritdoc cref="LineEdit.GetPlaceholder()" />
    public string GetPlaceholder() => ((LineEdit)_host).GetPlaceholder();

    /// <inheritdoc cref="LineEdit.SetCaretColumn(int)" />
    public void SetCaretColumn(int @position) => ((LineEdit)_host).SetCaretColumn(@position);

    /// <inheritdoc cref="LineEdit.GetCaretColumn()" />
    public int GetCaretColumn() => ((LineEdit)_host).GetCaretColumn();

    /// <inheritdoc cref="LineEdit.GetNextCompositeCharacterColumn(int)" />
    public int GetNextCompositeCharacterColumn(int @column) => ((LineEdit)_host).GetNextCompositeCharacterColumn(@column);

    /// <inheritdoc cref="LineEdit.GetPreviousCompositeCharacterColumn(int)" />
    public int GetPreviousCompositeCharacterColumn(int @column) => ((LineEdit)_host).GetPreviousCompositeCharacterColumn(@column);

    /// <inheritdoc cref="LineEdit.GetScrollOffset()" />
    public float GetScrollOffset() => ((LineEdit)_host).GetScrollOffset();

    /// <inheritdoc cref="LineEdit.SetExpandToTextLengthEnabled(bool)" />
    public void SetExpandToTextLengthEnabled(bool @enabled) => ((LineEdit)_host).SetExpandToTextLengthEnabled(@enabled);

    /// <inheritdoc cref="LineEdit.IsExpandToTextLengthEnabled()" />
    public bool IsExpandToTextLengthEnabled() => ((LineEdit)_host).IsExpandToTextLengthEnabled();

    /// <inheritdoc cref="LineEdit.SetCaretBlinkEnabled(bool)" />
    public void SetCaretBlinkEnabled(bool @enabled) => ((LineEdit)_host).SetCaretBlinkEnabled(@enabled);

    /// <inheritdoc cref="LineEdit.IsCaretBlinkEnabled()" />
    public bool IsCaretBlinkEnabled() => ((LineEdit)_host).IsCaretBlinkEnabled();

    /// <inheritdoc cref="LineEdit.SetCaretMidGraphemeEnabled(bool)" />
    public void SetCaretMidGraphemeEnabled(bool @enabled) => ((LineEdit)_host).SetCaretMidGraphemeEnabled(@enabled);

    /// <inheritdoc cref="LineEdit.IsCaretMidGraphemeEnabled()" />
    public bool IsCaretMidGraphemeEnabled() => ((LineEdit)_host).IsCaretMidGraphemeEnabled();

    /// <inheritdoc cref="LineEdit.SetCaretForceDisplayed(bool)" />
    public void SetCaretForceDisplayed(bool @enabled) => ((LineEdit)_host).SetCaretForceDisplayed(@enabled);

    /// <inheritdoc cref="LineEdit.IsCaretForceDisplayed()" />
    public bool IsCaretForceDisplayed() => ((LineEdit)_host).IsCaretForceDisplayed();

    /// <inheritdoc cref="LineEdit.SetCaretBlinkInterval(float)" />
    public void SetCaretBlinkInterval(float @interval) => ((LineEdit)_host).SetCaretBlinkInterval(@interval);

    /// <inheritdoc cref="LineEdit.GetCaretBlinkInterval()" />
    public float GetCaretBlinkInterval() => ((LineEdit)_host).GetCaretBlinkInterval();

    /// <inheritdoc cref="LineEdit.SetMaxLength(int)" />
    public void SetMaxLength(int @chars) => ((LineEdit)_host).SetMaxLength(@chars);

    /// <inheritdoc cref="LineEdit.GetMaxLength()" />
    public int GetMaxLength() => ((LineEdit)_host).GetMaxLength();

    /// <inheritdoc cref="LineEdit.InsertTextAtCaret(string)" />
    public void InsertTextAtCaret(string @text) => ((LineEdit)_host).InsertTextAtCaret(@text);

    /// <inheritdoc cref="LineEdit.DeleteCharAtCaret()" />
    public void DeleteCharAtCaret() => ((LineEdit)_host).DeleteCharAtCaret();

    /// <inheritdoc cref="LineEdit.DeleteText(int, int)" />
    public void DeleteText(int @fromColumn, int @toColumn) => ((LineEdit)_host).DeleteText(@fromColumn, @toColumn);

    /// <inheritdoc cref="LineEdit.SetEditable(bool)" />
    public void SetEditable(bool @enabled) => ((LineEdit)_host).SetEditable(@enabled);

    /// <inheritdoc cref="LineEdit.IsEditable()" />
    public bool IsEditable() => ((LineEdit)_host).IsEditable();

    /// <inheritdoc cref="LineEdit.SetSecret(bool)" />
    public void SetSecret(bool @enabled) => ((LineEdit)_host).SetSecret(@enabled);

    /// <inheritdoc cref="LineEdit.IsSecret()" />
    public bool IsSecret() => ((LineEdit)_host).IsSecret();

    /// <inheritdoc cref="LineEdit.SetSecretCharacter(string)" />
    public void SetSecretCharacter(string @character) => ((LineEdit)_host).SetSecretCharacter(@character);

    /// <inheritdoc cref="LineEdit.GetSecretCharacter()" />
    public string GetSecretCharacter() => ((LineEdit)_host).GetSecretCharacter();

    /// <inheritdoc cref="LineEdit.MenuOption(int)" />
    public void MenuOption(int @option) => ((LineEdit)_host).MenuOption(@option);

    /// <inheritdoc cref="LineEdit.GetMenu()" />
    public PopupMenu GetMenu() => ((LineEdit)_host).GetMenu();

    /// <inheritdoc cref="LineEdit.IsMenuVisible()" />
    public bool IsMenuVisible() => ((LineEdit)_host).IsMenuVisible();

    /// <inheritdoc cref="LineEdit.SetContextMenuEnabled(bool)" />
    public void SetContextMenuEnabled(bool @enable) => ((LineEdit)_host).SetContextMenuEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsContextMenuEnabled()" />
    public bool IsContextMenuEnabled() => ((LineEdit)_host).IsContextMenuEnabled();

    /// <inheritdoc cref="LineEdit.SetEmojiMenuEnabled(bool)" />
    public void SetEmojiMenuEnabled(bool @enable) => ((LineEdit)_host).SetEmojiMenuEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsEmojiMenuEnabled()" />
    public bool IsEmojiMenuEnabled() => ((LineEdit)_host).IsEmojiMenuEnabled();

    /// <inheritdoc cref="LineEdit.SetBackspaceDeletesCompositeCharacterEnabled(bool)" />
    public void SetBackspaceDeletesCompositeCharacterEnabled(bool @enable) => ((LineEdit)_host).SetBackspaceDeletesCompositeCharacterEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsBackspaceDeletesCompositeCharacterEnabled()" />
    public bool IsBackspaceDeletesCompositeCharacterEnabled() => ((LineEdit)_host).IsBackspaceDeletesCompositeCharacterEnabled();

    /// <inheritdoc cref="LineEdit.SetVirtualKeyboardEnabled(bool)" />
    public void SetVirtualKeyboardEnabled(bool @enable) => ((LineEdit)_host).SetVirtualKeyboardEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsVirtualKeyboardEnabled()" />
    public bool IsVirtualKeyboardEnabled() => ((LineEdit)_host).IsVirtualKeyboardEnabled();

    /// <inheritdoc cref="LineEdit.SetVirtualKeyboardShowOnFocus(bool)" />
    public void SetVirtualKeyboardShowOnFocus(bool @showOnFocus) => ((LineEdit)_host).SetVirtualKeyboardShowOnFocus(@showOnFocus);

    /// <inheritdoc cref="LineEdit.GetVirtualKeyboardShowOnFocus()" />
    public bool GetVirtualKeyboardShowOnFocus() => ((LineEdit)_host).GetVirtualKeyboardShowOnFocus();

    /// <inheritdoc cref="LineEdit.SetVirtualKeyboardType(LineEdit.VirtualKeyboardTypeEnum)" />
    public void SetVirtualKeyboardType(LineEdit.VirtualKeyboardTypeEnum @type) => ((LineEdit)_host).SetVirtualKeyboardType(@type);

    /// <inheritdoc cref="LineEdit.GetVirtualKeyboardType()" />
    public LineEdit.VirtualKeyboardTypeEnum GetVirtualKeyboardType() => ((LineEdit)_host).GetVirtualKeyboardType();

    /// <inheritdoc cref="LineEdit.SetClearButtonEnabled(bool)" />
    public void SetClearButtonEnabled(bool @enable) => ((LineEdit)_host).SetClearButtonEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsClearButtonEnabled()" />
    public bool IsClearButtonEnabled() => ((LineEdit)_host).IsClearButtonEnabled();

    /// <inheritdoc cref="LineEdit.SetShortcutKeysEnabled(bool)" />
    public void SetShortcutKeysEnabled(bool @enable) => ((LineEdit)_host).SetShortcutKeysEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsShortcutKeysEnabled()" />
    public bool IsShortcutKeysEnabled() => ((LineEdit)_host).IsShortcutKeysEnabled();

    /// <inheritdoc cref="LineEdit.SetMiddleMousePasteEnabled(bool)" />
    public void SetMiddleMousePasteEnabled(bool @enable) => ((LineEdit)_host).SetMiddleMousePasteEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsMiddleMousePasteEnabled()" />
    public bool IsMiddleMousePasteEnabled() => ((LineEdit)_host).IsMiddleMousePasteEnabled();

    /// <inheritdoc cref="LineEdit.SetSelectingEnabled(bool)" />
    public void SetSelectingEnabled(bool @enable) => ((LineEdit)_host).SetSelectingEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsSelectingEnabled()" />
    public bool IsSelectingEnabled() => ((LineEdit)_host).IsSelectingEnabled();

    /// <inheritdoc cref="LineEdit.SetDeselectOnFocusLossEnabled(bool)" />
    public void SetDeselectOnFocusLossEnabled(bool @enable) => ((LineEdit)_host).SetDeselectOnFocusLossEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsDeselectOnFocusLossEnabled()" />
    public bool IsDeselectOnFocusLossEnabled() => ((LineEdit)_host).IsDeselectOnFocusLossEnabled();

    /// <inheritdoc cref="LineEdit.SetDragAndDropSelectionEnabled(bool)" />
    public void SetDragAndDropSelectionEnabled(bool @enable) => ((LineEdit)_host).SetDragAndDropSelectionEnabled(@enable);

    /// <inheritdoc cref="LineEdit.IsDragAndDropSelectionEnabled()" />
    public bool IsDragAndDropSelectionEnabled() => ((LineEdit)_host).IsDragAndDropSelectionEnabled();

    /// <inheritdoc cref="LineEdit.SetRightIcon(Texture2D)" />
    public void SetRightIcon(Texture2D @icon) => ((LineEdit)_host).SetRightIcon(@icon);

    /// <inheritdoc cref="LineEdit.GetRightIcon()" />
    public Texture2D GetRightIcon() => ((LineEdit)_host).GetRightIcon();

    /// <inheritdoc cref="LineEdit.SetIconExpandMode(LineEdit.ExpandMode)" />
    public void SetIconExpandMode(LineEdit.ExpandMode @mode) => ((LineEdit)_host).SetIconExpandMode(@mode);

    /// <inheritdoc cref="LineEdit.GetIconExpandMode()" />
    public LineEdit.ExpandMode GetIconExpandMode() => ((LineEdit)_host).GetIconExpandMode();

    /// <inheritdoc cref="LineEdit.SetRightIconScale(float)" />
    public void SetRightIconScale(float @scale) => ((LineEdit)_host).SetRightIconScale(@scale);

    /// <inheritdoc cref="LineEdit.GetRightIconScale()" />
    public float GetRightIconScale() => ((LineEdit)_host).GetRightIconScale();

    /// <inheritdoc cref="LineEdit.SetFlat(bool)" />
    public void SetFlat(bool @enabled) => ((LineEdit)_host).SetFlat(@enabled);

    /// <inheritdoc cref="LineEdit.IsFlat()" />
    public bool IsFlat() => ((LineEdit)_host).IsFlat();

    /// <inheritdoc cref="LineEdit.SetSelectAllOnFocus(bool)" />
    public void SetSelectAllOnFocus(bool @enabled) => ((LineEdit)_host).SetSelectAllOnFocus(@enabled);

    /// <inheritdoc cref="LineEdit.IsSelectAllOnFocus()" />
    public bool IsSelectAllOnFocus() => ((LineEdit)_host).IsSelectAllOnFocus();

    /// <inheritdoc cref="LineEdit.Edit()" />
    public void Edit() => ((LineEdit)_host).Edit();

}
