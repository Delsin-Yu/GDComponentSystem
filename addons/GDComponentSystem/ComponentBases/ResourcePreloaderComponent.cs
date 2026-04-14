#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="ResourcePreloader" />
[Tool, GlobalClass]
public abstract partial class ResourcePreloaderComponent : NodeComponent
{

    /// <inheritdoc cref="ResourcePreloader.AddResource(StringName, Resource)" />
    public void AddResource(StringName @name, Resource @resource) => ((ResourcePreloader)_host).AddResource(@name, @resource);

    /// <inheritdoc cref="ResourcePreloader.RemoveResource(StringName)" />
    public void RemoveResource(StringName @name) => ((ResourcePreloader)_host).RemoveResource(@name);

    /// <inheritdoc cref="ResourcePreloader.RenameResource(StringName, StringName)" />
    public void RenameResource(StringName @name, StringName @newname) => ((ResourcePreloader)_host).RenameResource(@name, @newname);

    /// <inheritdoc cref="ResourcePreloader.HasResource(StringName)" />
    public bool HasResource(StringName @name) => ((ResourcePreloader)_host).HasResource(@name);

    /// <inheritdoc cref="ResourcePreloader.GetResource(StringName)" />
    public Resource GetResource(StringName @name) => ((ResourcePreloader)_host).GetResource(@name);

    /// <inheritdoc cref="ResourcePreloader.GetResourceList()" />
    public string[] GetResourceList() => ((ResourcePreloader)_host).GetResourceList();

}
