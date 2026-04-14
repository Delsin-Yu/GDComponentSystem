#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AcceptDialog" />
[Tool, GlobalClass]
public abstract partial class AcceptDialogComponent : WindowComponent
{

    /// <inheritdoc cref="AcceptDialog.GetOkButton()" />
    public Button GetOkButton() => ((AcceptDialog)_host).GetOkButton();

    /// <inheritdoc cref="AcceptDialog.GetLabel()" />
    public Label GetLabel() => ((AcceptDialog)_host).GetLabel();

    /// <inheritdoc cref="AcceptDialog.SetHideOnOk(bool)" />
    public void SetHideOnOk(bool @enabled) => ((AcceptDialog)_host).SetHideOnOk(@enabled);

    /// <inheritdoc cref="AcceptDialog.GetHideOnOk()" />
    public bool GetHideOnOk() => ((AcceptDialog)_host).GetHideOnOk();

    /// <inheritdoc cref="AcceptDialog.SetCloseOnEscape(bool)" />
    public void SetCloseOnEscape(bool @enabled) => ((AcceptDialog)_host).SetCloseOnEscape(@enabled);

    /// <inheritdoc cref="AcceptDialog.GetCloseOnEscape()" />
    public bool GetCloseOnEscape() => ((AcceptDialog)_host).GetCloseOnEscape();

    /// <inheritdoc cref="AcceptDialog.AddButton(string, bool, string)" />
    public Button AddButton(string @text, bool @right, string @action) => ((AcceptDialog)_host).AddButton(@text, @right, @action);

    /// <inheritdoc cref="AcceptDialog.AddCancelButton(string)" />
    public Button AddCancelButton(string @name) => ((AcceptDialog)_host).AddCancelButton(@name);

    /// <inheritdoc cref="AcceptDialog.RemoveButton(Button)" />
    public void RemoveButton(Button @button) => ((AcceptDialog)_host).RemoveButton(@button);

    /// <inheritdoc cref="AcceptDialog.RegisterTextEnter(LineEdit)" />
    public void RegisterTextEnter(LineEdit @lineEdit) => ((AcceptDialog)_host).RegisterTextEnter(@lineEdit);

    /// <inheritdoc cref="AcceptDialog.SetText(string)" />
    public void SetText(string @text) => ((AcceptDialog)_host).SetText(@text);

    /// <inheritdoc cref="AcceptDialog.GetText()" />
    public string GetText() => ((AcceptDialog)_host).GetText();

    /// <inheritdoc cref="AcceptDialog.SetAutowrap(bool)" />
    public void SetAutowrap(bool @autowrap) => ((AcceptDialog)_host).SetAutowrap(@autowrap);

    /// <inheritdoc cref="AcceptDialog.HasAutowrap()" />
    public bool HasAutowrap() => ((AcceptDialog)_host).HasAutowrap();

    /// <inheritdoc cref="AcceptDialog.SetOkButtonText(string)" />
    public void SetOkButtonText(string @text) => ((AcceptDialog)_host).SetOkButtonText(@text);

    /// <inheritdoc cref="AcceptDialog.GetOkButtonText()" />
    public string GetOkButtonText() => ((AcceptDialog)_host).GetOkButtonText();

    /// <inheritdoc cref="AcceptDialog.RemoveButton(Control)" />
    public void RemoveButton(Control @quadrantSize) => ((AcceptDialog)_host).RemoveButton(@quadrantSize);

    /// <inheritdoc cref="AcceptDialog.RegisterTextEnter(Control)" />
    public void RegisterTextEnter(Control @_UnnamedArg0) => ((AcceptDialog)_host).RegisterTextEnter(@_UnnamedArg0);

}
