#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="AnimationTree" />
[Tool, GlobalClass]
public abstract partial class AnimationTreeComponent : AnimationMixerComponent
{

    /// <inheritdoc cref="AnimationTree.SetTreeRoot(AnimationRootNode)" />
    public void SetTreeRoot(AnimationRootNode @animationNode) => ((AnimationTree)_host).SetTreeRoot(@animationNode);

    /// <inheritdoc cref="AnimationTree.GetTreeRoot()" />
    public AnimationRootNode GetTreeRoot() => ((AnimationTree)_host).GetTreeRoot();

    /// <inheritdoc cref="AnimationTree.SetAdvanceExpressionBaseNode(NodePath)" />
    public void SetAdvanceExpressionBaseNode(NodePath @path) => ((AnimationTree)_host).SetAdvanceExpressionBaseNode(@path);

    /// <inheritdoc cref="AnimationTree.GetAdvanceExpressionBaseNode()" />
    public NodePath GetAdvanceExpressionBaseNode() => ((AnimationTree)_host).GetAdvanceExpressionBaseNode();

    /// <inheritdoc cref="AnimationTree.SetAnimationPlayer(NodePath)" />
    public void SetAnimationPlayer(NodePath @path) => ((AnimationTree)_host).SetAnimationPlayer(@path);

    /// <inheritdoc cref="AnimationTree.GetAnimationPlayer()" />
    public NodePath GetAnimationPlayer() => ((AnimationTree)_host).GetAnimationPlayer();

    /// <inheritdoc cref="AnimationTree.SetProcessCallback(AnimationTree.AnimationProcessCallback)" />
    public void SetProcessCallback(AnimationTree.AnimationProcessCallback @mode) => ((AnimationTree)_host).SetProcessCallback(@mode);

    /// <inheritdoc cref="AnimationTree.GetProcessCallback()" />
    public AnimationTree.AnimationProcessCallback GetProcessCallback() => ((AnimationTree)_host).GetProcessCallback();

    /// <inheritdoc cref="AnimationTree.SetTreeRoot(AnimationNode)" />
    public void SetTreeRoot(AnimationNode @root) => ((AnimationTree)_host).SetTreeRoot(@root);

}
