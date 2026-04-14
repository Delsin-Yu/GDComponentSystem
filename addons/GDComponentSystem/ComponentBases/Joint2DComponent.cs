#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Joint2D" />
[Tool, GlobalClass]
public abstract partial class Joint2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Joint2D.SetNodeA(NodePath)" />
    public void SetNodeA(NodePath @node) => ((Joint2D)_host).SetNodeA(@node);

    /// <inheritdoc cref="Joint2D.GetNodeA()" />
    public NodePath GetNodeA() => ((Joint2D)_host).GetNodeA();

    /// <inheritdoc cref="Joint2D.SetNodeB(NodePath)" />
    public void SetNodeB(NodePath @node) => ((Joint2D)_host).SetNodeB(@node);

    /// <inheritdoc cref="Joint2D.GetNodeB()" />
    public NodePath GetNodeB() => ((Joint2D)_host).GetNodeB();

    /// <inheritdoc cref="Joint2D.SetBias(float)" />
    public void SetBias(float @bias) => ((Joint2D)_host).SetBias(@bias);

    /// <inheritdoc cref="Joint2D.GetBias()" />
    public float GetBias() => ((Joint2D)_host).GetBias();

    /// <inheritdoc cref="Joint2D.SetExcludeNodesFromCollision(bool)" />
    public void SetExcludeNodesFromCollision(bool @enable) => ((Joint2D)_host).SetExcludeNodesFromCollision(@enable);

    /// <inheritdoc cref="Joint2D.GetExcludeNodesFromCollision()" />
    public bool GetExcludeNodesFromCollision() => ((Joint2D)_host).GetExcludeNodesFromCollision();

    /// <inheritdoc cref="Joint2D.GetRid()" />
    public Rid GetRid() => ((Joint2D)_host).GetRid();

}
