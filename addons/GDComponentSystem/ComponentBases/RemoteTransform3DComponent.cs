#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="RemoteTransform3D" />
[Tool, GlobalClass]
public abstract partial class RemoteTransform3DComponent : Node3DComponent
{

    /// <inheritdoc cref="RemoteTransform3D.SetRemoteNode(NodePath)" />
    public void SetRemoteNode(NodePath @path) => ((RemoteTransform3D)_host).SetRemoteNode(@path);

    /// <inheritdoc cref="RemoteTransform3D.GetRemoteNode()" />
    public NodePath GetRemoteNode() => ((RemoteTransform3D)_host).GetRemoteNode();

    /// <inheritdoc cref="RemoteTransform3D.ForceUpdateCache()" />
    public void ForceUpdateCache() => ((RemoteTransform3D)_host).ForceUpdateCache();

    /// <inheritdoc cref="RemoteTransform3D.SetUseGlobalCoordinates(bool)" />
    public void SetUseGlobalCoordinates(bool @useGlobalCoordinates) => ((RemoteTransform3D)_host).SetUseGlobalCoordinates(@useGlobalCoordinates);

    /// <inheritdoc cref="RemoteTransform3D.GetUseGlobalCoordinates()" />
    public bool GetUseGlobalCoordinates() => ((RemoteTransform3D)_host).GetUseGlobalCoordinates();

    /// <inheritdoc cref="RemoteTransform3D.SetUpdatePosition(bool)" />
    public void SetUpdatePosition(bool @updateRemotePosition) => ((RemoteTransform3D)_host).SetUpdatePosition(@updateRemotePosition);

    /// <inheritdoc cref="RemoteTransform3D.GetUpdatePosition()" />
    public bool GetUpdatePosition() => ((RemoteTransform3D)_host).GetUpdatePosition();

    /// <inheritdoc cref="RemoteTransform3D.SetUpdateRotation(bool)" />
    public void SetUpdateRotation(bool @updateRemoteRotation) => ((RemoteTransform3D)_host).SetUpdateRotation(@updateRemoteRotation);

    /// <inheritdoc cref="RemoteTransform3D.GetUpdateRotation()" />
    public bool GetUpdateRotation() => ((RemoteTransform3D)_host).GetUpdateRotation();

    /// <inheritdoc cref="RemoteTransform3D.SetUpdateScale(bool)" />
    public void SetUpdateScale(bool @updateRemoteScale) => ((RemoteTransform3D)_host).SetUpdateScale(@updateRemoteScale);

    /// <inheritdoc cref="RemoteTransform3D.GetUpdateScale()" />
    public bool GetUpdateScale() => ((RemoteTransform3D)_host).GetUpdateScale();

}
