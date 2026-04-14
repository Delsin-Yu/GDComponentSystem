#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="InstancePlaceholder" />
[Tool, GlobalClass]
public abstract partial class InstancePlaceholderComponent : NodeComponent
{

    /// <inheritdoc cref="InstancePlaceholder.GetStoredValues(bool)" />
    public Dictionary GetStoredValues(bool @withOrder) => ((InstancePlaceholder)_host).GetStoredValues(@withOrder);

    /// <inheritdoc cref="InstancePlaceholder.CreateInstance(bool, PackedScene)" />
    public Node CreateInstance(bool @replace, PackedScene @customScene) => ((InstancePlaceholder)_host).CreateInstance(@replace, @customScene);

    /// <inheritdoc cref="InstancePlaceholder.GetInstancePath()" />
    public string GetInstancePath() => ((InstancePlaceholder)_host).GetInstancePath();

}
