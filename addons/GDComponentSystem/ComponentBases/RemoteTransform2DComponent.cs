#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RemoteTransform2D" />
[Tool, GlobalClass]
public abstract partial class RemoteTransform2DComponent : Node2DComponent
{

    /// <inheritdoc cref="RemoteTransform2D.SetRemoteNode(NodePath)" />
    public void SetRemoteNode(NodePath @path) => ((RemoteTransform2D)_host).SetRemoteNode(@path);

    /// <inheritdoc cref="RemoteTransform2D.GetRemoteNode()" />
    public NodePath GetRemoteNode() => ((RemoteTransform2D)_host).GetRemoteNode();

    /// <inheritdoc cref="RemoteTransform2D.ForceUpdateCache()" />
    public void ForceUpdateCache() => ((RemoteTransform2D)_host).ForceUpdateCache();

    /// <inheritdoc cref="RemoteTransform2D.SetUseGlobalCoordinates(bool)" />
    public void SetUseGlobalCoordinates(bool @useGlobalCoordinates) => ((RemoteTransform2D)_host).SetUseGlobalCoordinates(@useGlobalCoordinates);

    /// <inheritdoc cref="RemoteTransform2D.GetUseGlobalCoordinates()" />
    public bool GetUseGlobalCoordinates() => ((RemoteTransform2D)_host).GetUseGlobalCoordinates();

    /// <inheritdoc cref="RemoteTransform2D.SetUpdatePosition(bool)" />
    public void SetUpdatePosition(bool @updateRemotePosition) => ((RemoteTransform2D)_host).SetUpdatePosition(@updateRemotePosition);

    /// <inheritdoc cref="RemoteTransform2D.GetUpdatePosition()" />
    public bool GetUpdatePosition() => ((RemoteTransform2D)_host).GetUpdatePosition();

    /// <inheritdoc cref="RemoteTransform2D.SetUpdateRotation(bool)" />
    public void SetUpdateRotation(bool @updateRemoteRotation) => ((RemoteTransform2D)_host).SetUpdateRotation(@updateRemoteRotation);

    /// <inheritdoc cref="RemoteTransform2D.GetUpdateRotation()" />
    public bool GetUpdateRotation() => ((RemoteTransform2D)_host).GetUpdateRotation();

    /// <inheritdoc cref="RemoteTransform2D.SetUpdateScale(bool)" />
    public void SetUpdateScale(bool @updateRemoteScale) => ((RemoteTransform2D)_host).SetUpdateScale(@updateRemoteScale);

    /// <inheritdoc cref="RemoteTransform2D.GetUpdateScale()" />
    public bool GetUpdateScale() => ((RemoteTransform2D)_host).GetUpdateScale();

}
