#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Joint3D" />
[Tool, GlobalClass]
public abstract partial class Joint3DComponent : Node3DComponent
{

    /// <inheritdoc cref="Joint3D.SetNodeA(NodePath)" />
    public void SetNodeA(NodePath @node) => ((Joint3D)_host).SetNodeA(@node);

    /// <inheritdoc cref="Joint3D.GetNodeA()" />
    public NodePath GetNodeA() => ((Joint3D)_host).GetNodeA();

    /// <inheritdoc cref="Joint3D.SetNodeB(NodePath)" />
    public void SetNodeB(NodePath @node) => ((Joint3D)_host).SetNodeB(@node);

    /// <inheritdoc cref="Joint3D.GetNodeB()" />
    public NodePath GetNodeB() => ((Joint3D)_host).GetNodeB();

    /// <inheritdoc cref="Joint3D.SetSolverPriority(int)" />
    public void SetSolverPriority(int @priority) => ((Joint3D)_host).SetSolverPriority(@priority);

    /// <inheritdoc cref="Joint3D.GetSolverPriority()" />
    public int GetSolverPriority() => ((Joint3D)_host).GetSolverPriority();

    /// <inheritdoc cref="Joint3D.SetExcludeNodesFromCollision(bool)" />
    public void SetExcludeNodesFromCollision(bool @enable) => ((Joint3D)_host).SetExcludeNodesFromCollision(@enable);

    /// <inheritdoc cref="Joint3D.GetExcludeNodesFromCollision()" />
    public bool GetExcludeNodesFromCollision() => ((Joint3D)_host).GetExcludeNodesFromCollision();

    /// <inheritdoc cref="Joint3D.GetRid()" />
    public Rid GetRid() => ((Joint3D)_host).GetRid();

}
