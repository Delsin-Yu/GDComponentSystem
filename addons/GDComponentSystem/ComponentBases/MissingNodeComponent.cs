#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MissingNode" />
[Tool, GlobalClass]
public abstract partial class MissingNodeComponent : NodeComponent
{

    /// <inheritdoc cref="MissingNode.SetOriginalClass(string)" />
    public void SetOriginalClass(string @name) => ((MissingNode)_host).SetOriginalClass(@name);

    /// <inheritdoc cref="MissingNode.GetOriginalClass()" />
    public string GetOriginalClass() => ((MissingNode)_host).GetOriginalClass();

    /// <inheritdoc cref="MissingNode.SetOriginalScene(string)" />
    public void SetOriginalScene(string @name) => ((MissingNode)_host).SetOriginalScene(@name);

    /// <inheritdoc cref="MissingNode.GetOriginalScene()" />
    public string GetOriginalScene() => ((MissingNode)_host).GetOriginalScene();

    /// <inheritdoc cref="MissingNode.SetRecordingProperties(bool)" />
    public void SetRecordingProperties(bool @enable) => ((MissingNode)_host).SetRecordingProperties(@enable);

    /// <inheritdoc cref="MissingNode.IsRecordingProperties()" />
    public bool IsRecordingProperties() => ((MissingNode)_host).IsRecordingProperties();

    /// <inheritdoc cref="MissingNode.SetRecordingSignals(bool)" />
    public void SetRecordingSignals(bool @enable) => ((MissingNode)_host).SetRecordingSignals(@enable);

    /// <inheritdoc cref="MissingNode.IsRecordingSignals()" />
    public bool IsRecordingSignals() => ((MissingNode)_host).IsRecordingSignals();

}
