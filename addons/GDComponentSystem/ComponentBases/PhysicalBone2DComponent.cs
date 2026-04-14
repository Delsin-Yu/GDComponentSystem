#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PhysicalBone2D" />
[Tool, GlobalClass]
public abstract partial class PhysicalBone2DComponent : RigidBody2DComponent
{

    /// <inheritdoc cref="PhysicalBone2D.GetJoint()" />
    public Joint2D GetJoint() => ((PhysicalBone2D)_host).GetJoint();

    /// <inheritdoc cref="PhysicalBone2D.GetAutoConfigureJoint()" />
    public bool GetAutoConfigureJoint() => ((PhysicalBone2D)_host).GetAutoConfigureJoint();

    /// <inheritdoc cref="PhysicalBone2D.SetAutoConfigureJoint(bool)" />
    public void SetAutoConfigureJoint(bool @autoConfigureJoint) => ((PhysicalBone2D)_host).SetAutoConfigureJoint(@autoConfigureJoint);

    /// <inheritdoc cref="PhysicalBone2D.SetSimulatePhysics(bool)" />
    public void SetSimulatePhysics(bool @simulatePhysics) => ((PhysicalBone2D)_host).SetSimulatePhysics(@simulatePhysics);

    /// <inheritdoc cref="PhysicalBone2D.GetSimulatePhysics()" />
    public bool GetSimulatePhysics() => ((PhysicalBone2D)_host).GetSimulatePhysics();

    /// <inheritdoc cref="PhysicalBone2D.IsSimulatingPhysics()" />
    public bool IsSimulatingPhysics() => ((PhysicalBone2D)_host).IsSimulatingPhysics();

    /// <inheritdoc cref="PhysicalBone2D.SetBone2DNodePath(NodePath)" />
    public void SetBone2DNodePath(NodePath @nodePath) => ((PhysicalBone2D)_host).SetBone2DNodePath(@nodePath);

    /// <inheritdoc cref="PhysicalBone2D.GetBone2DNodePath()" />
    public NodePath GetBone2DNodePath() => ((PhysicalBone2D)_host).GetBone2DNodePath();

    /// <inheritdoc cref="PhysicalBone2D.SetBone2DIndex(int)" />
    public void SetBone2DIndex(int @boneIndex) => ((PhysicalBone2D)_host).SetBone2DIndex(@boneIndex);

    /// <inheritdoc cref="PhysicalBone2D.GetBone2DIndex()" />
    public int GetBone2DIndex() => ((PhysicalBone2D)_host).GetBone2DIndex();

    /// <inheritdoc cref="PhysicalBone2D.SetFollowBoneWhenSimulating(bool)" />
    public void SetFollowBoneWhenSimulating(bool @followBone) => ((PhysicalBone2D)_host).SetFollowBoneWhenSimulating(@followBone);

    /// <inheritdoc cref="PhysicalBone2D.GetFollowBoneWhenSimulating()" />
    public bool GetFollowBoneWhenSimulating() => ((PhysicalBone2D)_host).GetFollowBoneWhenSimulating();

}
