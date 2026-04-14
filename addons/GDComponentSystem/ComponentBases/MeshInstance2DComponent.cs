#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MeshInstance2D" />
[Tool, GlobalClass]
public abstract partial class MeshInstance2DComponent : Node2DComponent
{

    /// <inheritdoc cref="MeshInstance2D.SetMesh(Mesh)" />
    public void SetMesh(Mesh @mesh) => ((MeshInstance2D)_host).SetMesh(@mesh);

    /// <inheritdoc cref="MeshInstance2D.GetMesh()" />
    public Mesh GetMesh() => ((MeshInstance2D)_host).GetMesh();

    /// <inheritdoc cref="MeshInstance2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((MeshInstance2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="MeshInstance2D.GetTexture()" />
    public Texture2D GetTexture() => ((MeshInstance2D)_host).GetTexture();

}
