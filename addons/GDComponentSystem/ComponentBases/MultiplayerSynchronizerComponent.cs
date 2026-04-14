#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MultiplayerSynchronizer" />
[Tool, GlobalClass]
public abstract partial class MultiplayerSynchronizerComponent : NodeComponent
{

    /// <inheritdoc cref="MultiplayerSynchronizer.SetRootPath(NodePath)" />
    public void SetRootPath(NodePath @path) => ((MultiplayerSynchronizer)_host).SetRootPath(@path);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetRootPath()" />
    public NodePath GetRootPath() => ((MultiplayerSynchronizer)_host).GetRootPath();

    /// <inheritdoc cref="MultiplayerSynchronizer.SetReplicationInterval(double)" />
    public void SetReplicationInterval(double @milliseconds) => ((MultiplayerSynchronizer)_host).SetReplicationInterval(@milliseconds);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetReplicationInterval()" />
    public double GetReplicationInterval() => ((MultiplayerSynchronizer)_host).GetReplicationInterval();

    /// <inheritdoc cref="MultiplayerSynchronizer.SetDeltaInterval(double)" />
    public void SetDeltaInterval(double @milliseconds) => ((MultiplayerSynchronizer)_host).SetDeltaInterval(@milliseconds);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetDeltaInterval()" />
    public double GetDeltaInterval() => ((MultiplayerSynchronizer)_host).GetDeltaInterval();

    /// <inheritdoc cref="MultiplayerSynchronizer.SetReplicationConfig(SceneReplicationConfig)" />
    public void SetReplicationConfig(SceneReplicationConfig @config) => ((MultiplayerSynchronizer)_host).SetReplicationConfig(@config);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetReplicationConfig()" />
    public SceneReplicationConfig GetReplicationConfig() => ((MultiplayerSynchronizer)_host).GetReplicationConfig();

    /// <inheritdoc cref="MultiplayerSynchronizer.SetVisibilityUpdateMode(MultiplayerSynchronizer.VisibilityUpdateModeEnum)" />
    public void SetVisibilityUpdateMode(MultiplayerSynchronizer.VisibilityUpdateModeEnum @mode) => ((MultiplayerSynchronizer)_host).SetVisibilityUpdateMode(@mode);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetVisibilityUpdateMode()" />
    public MultiplayerSynchronizer.VisibilityUpdateModeEnum GetVisibilityUpdateMode() => ((MultiplayerSynchronizer)_host).GetVisibilityUpdateMode();

    /// <inheritdoc cref="MultiplayerSynchronizer.UpdateVisibility(int)" />
    public void UpdateVisibility(int @forPeer) => ((MultiplayerSynchronizer)_host).UpdateVisibility(@forPeer);

    /// <inheritdoc cref="MultiplayerSynchronizer.SetVisibilityPublic(bool)" />
    public void SetVisibilityPublic(bool @visible) => ((MultiplayerSynchronizer)_host).SetVisibilityPublic(@visible);

    /// <inheritdoc cref="MultiplayerSynchronizer.IsVisibilityPublic()" />
    public bool IsVisibilityPublic() => ((MultiplayerSynchronizer)_host).IsVisibilityPublic();

    /// <inheritdoc cref="MultiplayerSynchronizer.AddVisibilityFilter(Callable)" />
    public void AddVisibilityFilter(Callable @filter) => ((MultiplayerSynchronizer)_host).AddVisibilityFilter(@filter);

    /// <inheritdoc cref="MultiplayerSynchronizer.RemoveVisibilityFilter(Callable)" />
    public void RemoveVisibilityFilter(Callable @filter) => ((MultiplayerSynchronizer)_host).RemoveVisibilityFilter(@filter);

    /// <inheritdoc cref="MultiplayerSynchronizer.SetVisibilityFor(int, bool)" />
    public void SetVisibilityFor(int @peer, bool @visible) => ((MultiplayerSynchronizer)_host).SetVisibilityFor(@peer, @visible);

    /// <inheritdoc cref="MultiplayerSynchronizer.GetVisibilityFor(int)" />
    public bool GetVisibilityFor(int @peer) => ((MultiplayerSynchronizer)_host).GetVisibilityFor(@peer);

}
