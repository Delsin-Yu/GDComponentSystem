#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpringBoneCollisionSphere3D" />
[Tool, GlobalClass]
public abstract partial class SpringBoneCollisionSphere3DComponent : SpringBoneCollision3DComponent
{

    /// <inheritdoc cref="SpringBoneCollisionSphere3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((SpringBoneCollisionSphere3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="SpringBoneCollisionSphere3D.GetRadius()" />
    public float GetRadius() => ((SpringBoneCollisionSphere3D)_host).GetRadius();

    /// <inheritdoc cref="SpringBoneCollisionSphere3D.SetInside(bool)" />
    public void SetInside(bool @enabled) => ((SpringBoneCollisionSphere3D)_host).SetInside(@enabled);

    /// <inheritdoc cref="SpringBoneCollisionSphere3D.IsInside()" />
    public bool IsInside() => ((SpringBoneCollisionSphere3D)_host).IsInside();

}
