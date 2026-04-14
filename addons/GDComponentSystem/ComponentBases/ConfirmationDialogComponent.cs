#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ConfirmationDialog" />
[Tool, GlobalClass]
public abstract partial class ConfirmationDialogComponent : AcceptDialogComponent
{

    /// <inheritdoc cref="ConfirmationDialog.GetCancelButton()" />
    public Button GetCancelButton() => ((ConfirmationDialog)_host).GetCancelButton();

    /// <inheritdoc cref="ConfirmationDialog.SetCancelButtonText(string)" />
    public void SetCancelButtonText(string @text) => ((ConfirmationDialog)_host).SetCancelButtonText(@text);

    /// <inheritdoc cref="ConfirmationDialog.GetCancelButtonText()" />
    public string GetCancelButtonText() => ((ConfirmationDialog)_host).GetCancelButtonText();

}
