#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="GridContainer" />
[Tool, GlobalClass]
public abstract partial class GridContainerComponent : ContainerComponent
{

    /// <inheritdoc cref="GridContainer.SetColumns(int)" />
    public void SetColumns(int @columns) => ((GridContainer)_host).SetColumns(@columns);

    /// <inheritdoc cref="GridContainer.GetColumns()" />
    public int GetColumns() => ((GridContainer)_host).GetColumns();

}
