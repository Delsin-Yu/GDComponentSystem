#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="FoldableContainer" />
[Tool, GlobalClass]
public abstract partial class FoldableContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="FoldableContainer.Fold()" />
    public void Fold() => ((FoldableContainer)_host).Fold();

    /// <inheritdoc cref="FoldableContainer.Expand()" />
    public void Expand() => ((FoldableContainer)_host).Expand();

    /// <inheritdoc cref="FoldableContainer.SetFolded(bool)" />
    public void SetFolded(bool @folded) => ((FoldableContainer)_host).SetFolded(@folded);

    /// <inheritdoc cref="FoldableContainer.IsFolded()" />
    public bool IsFolded() => ((FoldableContainer)_host).IsFolded();

    /// <inheritdoc cref="FoldableContainer.SetFoldableGroup(FoldableGroup)" />
    public void SetFoldableGroup(FoldableGroup @buttonGroup) => ((FoldableContainer)_host).SetFoldableGroup(@buttonGroup);

    /// <inheritdoc cref="FoldableContainer.GetFoldableGroup()" />
    public FoldableGroup GetFoldableGroup() => ((FoldableContainer)_host).GetFoldableGroup();

    /// <inheritdoc cref="FoldableContainer.SetTitle(string)" />
    public void SetTitle(string @text) => ((FoldableContainer)_host).SetTitle(@text);

    /// <inheritdoc cref="FoldableContainer.GetTitle()" />
    public string GetTitle() => ((FoldableContainer)_host).GetTitle();

    /// <inheritdoc cref="FoldableContainer.SetTitleAlignment(HorizontalAlignment)" />
    public void SetTitleAlignment(HorizontalAlignment @alignment) => ((FoldableContainer)_host).SetTitleAlignment(@alignment);

    /// <inheritdoc cref="FoldableContainer.GetTitleAlignment()" />
    public HorizontalAlignment GetTitleAlignment() => ((FoldableContainer)_host).GetTitleAlignment();

    /// <inheritdoc cref="FoldableContainer.SetLanguage(string)" />
    public void SetLanguage(string @language) => ((FoldableContainer)_host).SetLanguage(@language);

    /// <inheritdoc cref="FoldableContainer.GetLanguage()" />
    public string GetLanguage() => ((FoldableContainer)_host).GetLanguage();

    /// <inheritdoc cref="FoldableContainer.SetTitleTextDirection(Control.TextDirection)" />
    public void SetTitleTextDirection(Control.TextDirection @textDirection) => ((FoldableContainer)_host).SetTitleTextDirection(@textDirection);

    /// <inheritdoc cref="FoldableContainer.GetTitleTextDirection()" />
    public Control.TextDirection GetTitleTextDirection() => ((FoldableContainer)_host).GetTitleTextDirection();

    /// <inheritdoc cref="FoldableContainer.SetTitleTextOverrunBehavior(TextServer.OverrunBehavior)" />
    public void SetTitleTextOverrunBehavior(TextServer.OverrunBehavior @overrunBehavior) => ((FoldableContainer)_host).SetTitleTextOverrunBehavior(@overrunBehavior);

    /// <inheritdoc cref="FoldableContainer.GetTitleTextOverrunBehavior()" />
    public TextServer.OverrunBehavior GetTitleTextOverrunBehavior() => ((FoldableContainer)_host).GetTitleTextOverrunBehavior();

    /// <inheritdoc cref="FoldableContainer.SetTitlePosition(FoldableContainer.TitlePositionEnum)" />
    public void SetTitlePosition(FoldableContainer.TitlePositionEnum @titlePosition) => ((FoldableContainer)_host).SetTitlePosition(@titlePosition);

    /// <inheritdoc cref="FoldableContainer.GetTitlePosition()" />
    public FoldableContainer.TitlePositionEnum GetTitlePosition() => ((FoldableContainer)_host).GetTitlePosition();

    /// <inheritdoc cref="FoldableContainer.AddTitleBarControl(Control)" />
    public void AddTitleBarControl(Control @control) => ((FoldableContainer)_host).AddTitleBarControl(@control);

    /// <inheritdoc cref="FoldableContainer.RemoveTitleBarControl(Control)" />
    public void RemoveTitleBarControl(Control @control) => ((FoldableContainer)_host).RemoveTitleBarControl(@control);

}
