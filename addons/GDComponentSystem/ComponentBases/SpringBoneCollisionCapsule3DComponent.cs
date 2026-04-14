#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpringBoneCollisionCapsule3D" />
[Tool, GlobalClass]
public abstract partial class SpringBoneCollisionCapsule3DComponent : SpringBoneCollision3DComponent
{

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.SetRadius(float)" />
    public void SetRadius(float @radius) => ((SpringBoneCollisionCapsule3D)_host).SetRadius(@radius);

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.GetRadius()" />
    public float GetRadius() => ((SpringBoneCollisionCapsule3D)_host).GetRadius();

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.SetHeight(float)" />
    public void SetHeight(float @height) => ((SpringBoneCollisionCapsule3D)_host).SetHeight(@height);

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.GetHeight()" />
    public float GetHeight() => ((SpringBoneCollisionCapsule3D)_host).GetHeight();

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.SetMidHeight(float)" />
    public void SetMidHeight(float @midHeight) => ((SpringBoneCollisionCapsule3D)_host).SetMidHeight(@midHeight);

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.GetMidHeight()" />
    public float GetMidHeight() => ((SpringBoneCollisionCapsule3D)_host).GetMidHeight();

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.SetInside(bool)" />
    public void SetInside(bool @enabled) => ((SpringBoneCollisionCapsule3D)_host).SetInside(@enabled);

    /// <inheritdoc cref="SpringBoneCollisionCapsule3D.IsInside()" />
    public bool IsInside() => ((SpringBoneCollisionCapsule3D)_host).IsInside();

}
