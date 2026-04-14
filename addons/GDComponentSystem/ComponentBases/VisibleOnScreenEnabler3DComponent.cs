#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VisibleOnScreenEnabler3D" />
[Tool, GlobalClass]
public abstract partial class VisibleOnScreenEnabler3DComponent : VisibleOnScreenNotifier3DComponent
{

    /// <inheritdoc cref="VisibleOnScreenEnabler3D.SetEnableMode(VisibleOnScreenEnabler3D.EnableModeEnum)" />
    public void SetEnableMode(VisibleOnScreenEnabler3D.EnableModeEnum @mode) => ((VisibleOnScreenEnabler3D)_host).SetEnableMode(@mode);

    /// <inheritdoc cref="VisibleOnScreenEnabler3D.GetEnableMode()" />
    public VisibleOnScreenEnabler3D.EnableModeEnum GetEnableMode() => ((VisibleOnScreenEnabler3D)_host).GetEnableMode();

    /// <inheritdoc cref="VisibleOnScreenEnabler3D.SetEnableNodePath(NodePath)" />
    public void SetEnableNodePath(NodePath @path) => ((VisibleOnScreenEnabler3D)_host).SetEnableNodePath(@path);

    /// <inheritdoc cref="VisibleOnScreenEnabler3D.GetEnableNodePath()" />
    public NodePath GetEnableNodePath() => ((VisibleOnScreenEnabler3D)_host).GetEnableNodePath();

}
