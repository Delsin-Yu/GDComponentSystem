#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VisibleOnScreenEnabler2D" />
[Tool, GlobalClass]
public abstract partial class VisibleOnScreenEnabler2DComponent : VisibleOnScreenNotifier2DComponent
{

    /// <inheritdoc cref="VisibleOnScreenEnabler2D.SetEnableMode(VisibleOnScreenEnabler2D.EnableModeEnum)" />
    public void SetEnableMode(VisibleOnScreenEnabler2D.EnableModeEnum @mode) => ((VisibleOnScreenEnabler2D)_host).SetEnableMode(@mode);

    /// <inheritdoc cref="VisibleOnScreenEnabler2D.GetEnableMode()" />
    public VisibleOnScreenEnabler2D.EnableModeEnum GetEnableMode() => ((VisibleOnScreenEnabler2D)_host).GetEnableMode();

    /// <inheritdoc cref="VisibleOnScreenEnabler2D.SetEnableNodePath(NodePath)" />
    public void SetEnableNodePath(NodePath @path) => ((VisibleOnScreenEnabler2D)_host).SetEnableNodePath(@path);

    /// <inheritdoc cref="VisibleOnScreenEnabler2D.GetEnableNodePath()" />
    public NodePath GetEnableNodePath() => ((VisibleOnScreenEnabler2D)_host).GetEnableNodePath();

}
