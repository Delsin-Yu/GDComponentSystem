#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="FileDialog" />
[Tool, GlobalClass]
public abstract partial class FileDialogComponent : ConfirmationDialogComponent
{

    /// <inheritdoc cref="FileDialog.ClearFilters()" />
    public void ClearFilters() => ((FileDialog)_host).ClearFilters();

    /// <inheritdoc cref="FileDialog.AddFilter(string, string, string)" />
    public void AddFilter(string @filter, string @description, string @mimeType) => ((FileDialog)_host).AddFilter(@filter, @description, @mimeType);

    /// <inheritdoc cref="FileDialog.SetFilters(string[])" />
    public void SetFilters(string[] @filters) => ((FileDialog)_host).SetFilters(@filters);

    /// <inheritdoc cref="FileDialog.SetFilters(ReadOnlySpan{string})" />
    public void SetFilters(ReadOnlySpan<string> @filters) => ((FileDialog)_host).SetFilters(@filters);

    /// <inheritdoc cref="FileDialog.GetFilters()" />
    public string[] GetFilters() => ((FileDialog)_host).GetFilters();

    /// <inheritdoc cref="FileDialog.ClearFileNameFilter()" />
    public void ClearFileNameFilter() => ((FileDialog)_host).ClearFileNameFilter();

    /// <inheritdoc cref="FileDialog.SetFileNameFilter(string)" />
    public void SetFileNameFilter(string @filter) => ((FileDialog)_host).SetFileNameFilter(@filter);

    /// <inheritdoc cref="FileDialog.GetFileNameFilter()" />
    public string GetFileNameFilter() => ((FileDialog)_host).GetFileNameFilter();

    /// <inheritdoc cref="FileDialog.GetOptionName(int)" />
    public string GetOptionName(int @option) => ((FileDialog)_host).GetOptionName(@option);

    /// <inheritdoc cref="FileDialog.GetOptionValues(int)" />
    public string[] GetOptionValues(int @option) => ((FileDialog)_host).GetOptionValues(@option);

    /// <inheritdoc cref="FileDialog.GetOptionDefault(int)" />
    public int GetOptionDefault(int @option) => ((FileDialog)_host).GetOptionDefault(@option);

    /// <inheritdoc cref="FileDialog.SetOptionName(int, string)" />
    public void SetOptionName(int @option, string @name) => ((FileDialog)_host).SetOptionName(@option, @name);

    /// <inheritdoc cref="FileDialog.SetOptionValues(int, string[])" />
    public void SetOptionValues(int @option, string[] @values) => ((FileDialog)_host).SetOptionValues(@option, @values);

    /// <inheritdoc cref="FileDialog.SetOptionValues(int, ReadOnlySpan{string})" />
    public void SetOptionValues(int @option, ReadOnlySpan<string> @values) => ((FileDialog)_host).SetOptionValues(@option, @values);

    /// <inheritdoc cref="FileDialog.SetOptionDefault(int, int)" />
    public void SetOptionDefault(int @option, int @defaultValueIndex) => ((FileDialog)_host).SetOptionDefault(@option, @defaultValueIndex);

    /// <inheritdoc cref="FileDialog.SetOptionCount(int)" />
    public void SetOptionCount(int @count) => ((FileDialog)_host).SetOptionCount(@count);

    /// <inheritdoc cref="FileDialog.GetOptionCount()" />
    public int GetOptionCount() => ((FileDialog)_host).GetOptionCount();

    /// <inheritdoc cref="FileDialog.AddOption(string, string[], int)" />
    public void AddOption(string @name, string[] @values, int @defaultValueIndex) => ((FileDialog)_host).AddOption(@name, @values, @defaultValueIndex);

    /// <inheritdoc cref="FileDialog.AddOption(string, ReadOnlySpan{string}, int)" />
    public void AddOption(string @name, ReadOnlySpan<string> @values, int @defaultValueIndex) => ((FileDialog)_host).AddOption(@name, @values, @defaultValueIndex);

    /// <inheritdoc cref="FileDialog.GetSelectedOptions()" />
    public Dictionary GetSelectedOptions() => ((FileDialog)_host).GetSelectedOptions();

    /// <inheritdoc cref="FileDialog.GetCurrentDir()" />
    public string GetCurrentDir() => ((FileDialog)_host).GetCurrentDir();

    /// <inheritdoc cref="FileDialog.GetCurrentFile()" />
    public string GetCurrentFile() => ((FileDialog)_host).GetCurrentFile();

    /// <inheritdoc cref="FileDialog.GetCurrentPath()" />
    public string GetCurrentPath() => ((FileDialog)_host).GetCurrentPath();

    /// <inheritdoc cref="FileDialog.SetCurrentDir(string)" />
    public void SetCurrentDir(string @dir) => ((FileDialog)_host).SetCurrentDir(@dir);

    /// <inheritdoc cref="FileDialog.SetCurrentFile(string)" />
    public void SetCurrentFile(string @file) => ((FileDialog)_host).SetCurrentFile(@file);

    /// <inheritdoc cref="FileDialog.SetCurrentPath(string)" />
    public void SetCurrentPath(string @path) => ((FileDialog)_host).SetCurrentPath(@path);

    /// <inheritdoc cref="FileDialog.SetModeOverridesTitle(bool)" />
    public void SetModeOverridesTitle(bool @override) => ((FileDialog)_host).SetModeOverridesTitle(@override);

    /// <inheritdoc cref="FileDialog.IsModeOverridingTitle()" />
    public bool IsModeOverridingTitle() => ((FileDialog)_host).IsModeOverridingTitle();

    /// <inheritdoc cref="FileDialog.SetFileMode(FileDialog.FileModeEnum)" />
    public void SetFileMode(FileDialog.FileModeEnum @mode) => ((FileDialog)_host).SetFileMode(@mode);

    /// <inheritdoc cref="FileDialog.GetFileMode()" />
    public FileDialog.FileModeEnum GetFileMode() => ((FileDialog)_host).GetFileMode();

    /// <inheritdoc cref="FileDialog.SetDisplayMode(FileDialog.DisplayModeEnum)" />
    public void SetDisplayMode(FileDialog.DisplayModeEnum @mode) => ((FileDialog)_host).SetDisplayMode(@mode);

    /// <inheritdoc cref="FileDialog.GetDisplayMode()" />
    public FileDialog.DisplayModeEnum GetDisplayMode() => ((FileDialog)_host).GetDisplayMode();

    /// <inheritdoc cref="FileDialog.GetVBox()" />
    public VBoxContainer GetVBox() => ((FileDialog)_host).GetVBox();

    /// <inheritdoc cref="FileDialog.GetLineEdit()" />
    public LineEdit GetLineEdit() => ((FileDialog)_host).GetLineEdit();

    /// <inheritdoc cref="FileDialog.SetAccess(FileDialog.AccessEnum)" />
    public void SetAccess(FileDialog.AccessEnum @access) => ((FileDialog)_host).SetAccess(@access);

    /// <inheritdoc cref="FileDialog.GetAccess()" />
    public FileDialog.AccessEnum GetAccess() => ((FileDialog)_host).GetAccess();

    /// <inheritdoc cref="FileDialog.SetRootSubfolder(string)" />
    public void SetRootSubfolder(string @dir) => ((FileDialog)_host).SetRootSubfolder(@dir);

    /// <inheritdoc cref="FileDialog.GetRootSubfolder()" />
    public string GetRootSubfolder() => ((FileDialog)_host).GetRootSubfolder();

    /// <inheritdoc cref="FileDialog.SetShowHiddenFiles(bool)" />
    public void SetShowHiddenFiles(bool @show) => ((FileDialog)_host).SetShowHiddenFiles(@show);

    /// <inheritdoc cref="FileDialog.IsShowingHiddenFiles()" />
    public bool IsShowingHiddenFiles() => ((FileDialog)_host).IsShowingHiddenFiles();

    /// <inheritdoc cref="FileDialog.SetUseNativeDialog(bool)" />
    public void SetUseNativeDialog(bool @native) => ((FileDialog)_host).SetUseNativeDialog(@native);

    /// <inheritdoc cref="FileDialog.GetUseNativeDialog()" />
    public bool GetUseNativeDialog() => ((FileDialog)_host).GetUseNativeDialog();

    /// <inheritdoc cref="FileDialog.SetCustomizationFlagEnabled(FileDialog.Customization, bool)" />
    public void SetCustomizationFlagEnabled(FileDialog.Customization @flag, bool @enabled) => ((FileDialog)_host).SetCustomizationFlagEnabled(@flag, @enabled);

    /// <inheritdoc cref="FileDialog.IsCustomizationFlagEnabled(FileDialog.Customization)" />
    public bool IsCustomizationFlagEnabled(FileDialog.Customization @flag) => ((FileDialog)_host).IsCustomizationFlagEnabled(@flag);

    /// <inheritdoc cref="FileDialog.DeselectAll()" />
    public void DeselectAll() => ((FileDialog)_host).DeselectAll();

    /// <inheritdoc cref="FileDialog.PopupFileDialog()" />
    public void PopupFileDialog() => ((FileDialog)_host).PopupFileDialog();

    /// <inheritdoc cref="FileDialog.Invalidate()" />
    public void Invalidate() => ((FileDialog)_host).Invalidate();

    /// <inheritdoc cref="FileDialog.AddFilter(string, string)" />
    public void AddFilter(string @filter, string @description) => ((FileDialog)_host).AddFilter(@filter, @description);

}
