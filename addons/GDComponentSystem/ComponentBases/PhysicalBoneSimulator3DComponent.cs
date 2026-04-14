#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PhysicalBoneSimulator3D" />
[Tool, GlobalClass]
public abstract partial class PhysicalBoneSimulator3DComponent : SkeletonModifier3DComponent
{

    /// <inheritdoc cref="PhysicalBoneSimulator3D.IsSimulatingPhysics()" />
    public bool IsSimulatingPhysics() => ((PhysicalBoneSimulator3D)_host).IsSimulatingPhysics();

    /// <inheritdoc cref="PhysicalBoneSimulator3D.PhysicalBonesStopSimulation()" />
    public void PhysicalBonesStopSimulation() => ((PhysicalBoneSimulator3D)_host).PhysicalBonesStopSimulation();

    /// <inheritdoc cref="PhysicalBoneSimulator3D.PhysicalBonesStartSimulation(Array{StringName})" />
    public void PhysicalBonesStartSimulation(Array<StringName> @bones) => ((PhysicalBoneSimulator3D)_host).PhysicalBonesStartSimulation(@bones);

    /// <inheritdoc cref="PhysicalBoneSimulator3D.PhysicalBonesAddCollisionException(Rid)" />
    public void PhysicalBonesAddCollisionException(Rid @exception) => ((PhysicalBoneSimulator3D)_host).PhysicalBonesAddCollisionException(@exception);

    /// <inheritdoc cref="PhysicalBoneSimulator3D.PhysicalBonesRemoveCollisionException(Rid)" />
    public void PhysicalBonesRemoveCollisionException(Rid @exception) => ((PhysicalBoneSimulator3D)_host).PhysicalBonesRemoveCollisionException(@exception);

}
