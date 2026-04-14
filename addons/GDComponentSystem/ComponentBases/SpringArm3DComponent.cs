#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SpringArm3D" />
[Tool, GlobalClass]
public abstract partial class SpringArm3DComponent : Node3DComponent
{

    /// <inheritdoc cref="SpringArm3D.GetHitLength()" />
    public float GetHitLength() => ((SpringArm3D)_host).GetHitLength();

    /// <inheritdoc cref="SpringArm3D.SetLength(float)" />
    public void SetLength(float @length) => ((SpringArm3D)_host).SetLength(@length);

    /// <inheritdoc cref="SpringArm3D.GetLength()" />
    public float GetLength() => ((SpringArm3D)_host).GetLength();

    /// <inheritdoc cref="SpringArm3D.SetShape(Shape3D)" />
    public void SetShape(Shape3D @shape) => ((SpringArm3D)_host).SetShape(@shape);

    /// <inheritdoc cref="SpringArm3D.GetShape()" />
    public Shape3D GetShape() => ((SpringArm3D)_host).GetShape();

    /// <inheritdoc cref="SpringArm3D.AddExcludedObject(Rid)" />
    public void AddExcludedObject(Rid @rID) => ((SpringArm3D)_host).AddExcludedObject(@rID);

    /// <inheritdoc cref="SpringArm3D.RemoveExcludedObject(Rid)" />
    public bool RemoveExcludedObject(Rid @rID) => ((SpringArm3D)_host).RemoveExcludedObject(@rID);

    /// <inheritdoc cref="SpringArm3D.ClearExcludedObjects()" />
    public void ClearExcludedObjects() => ((SpringArm3D)_host).ClearExcludedObjects();

    /// <inheritdoc cref="SpringArm3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @mask) => ((SpringArm3D)_host).SetCollisionMask(@mask);

    /// <inheritdoc cref="SpringArm3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((SpringArm3D)_host).GetCollisionMask();

    /// <inheritdoc cref="SpringArm3D.SetMargin(float)" />
    public void SetMargin(float @margin) => ((SpringArm3D)_host).SetMargin(@margin);

    /// <inheritdoc cref="SpringArm3D.GetMargin()" />
    public float GetMargin() => ((SpringArm3D)_host).GetMargin();

}
