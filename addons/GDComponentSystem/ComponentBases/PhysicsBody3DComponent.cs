#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PhysicsBody3D" />
[Tool, GlobalClass]
public abstract partial class PhysicsBody3DComponent : CollisionObject3DComponent
{

    /// <inheritdoc cref="PhysicsBody3D.MoveAndCollide(Vector3, bool, float, bool, int)" />
    public KinematicCollision3D MoveAndCollide(Vector3 @motion, bool @testOnly, float @safeMargin, bool @recoveryAsCollision, int @maxCollisions) => ((PhysicsBody3D)_host).MoveAndCollide(@motion, @testOnly, @safeMargin, @recoveryAsCollision, @maxCollisions);

    /// <inheritdoc cref="PhysicsBody3D.TestMove(Transform3D, Vector3, KinematicCollision3D, float, bool, int)" />
    public bool TestMove(Transform3D @from, Vector3 @motion, KinematicCollision3D @collision, float @safeMargin, bool @recoveryAsCollision, int @maxCollisions) => ((PhysicsBody3D)_host).TestMove(@from, @motion, @collision, @safeMargin, @recoveryAsCollision, @maxCollisions);

    /// <inheritdoc cref="PhysicsBody3D.GetGravity()" />
    public Vector3 GetGravity() => ((PhysicsBody3D)_host).GetGravity();

    /// <inheritdoc cref="PhysicsBody3D.SetAxisLock(PhysicsServer3D.BodyAxis, bool)" />
    public void SetAxisLock(PhysicsServer3D.BodyAxis @axis, bool @lock) => ((PhysicsBody3D)_host).SetAxisLock(@axis, @lock);

    /// <inheritdoc cref="PhysicsBody3D.GetAxisLock(PhysicsServer3D.BodyAxis)" />
    public bool GetAxisLock(PhysicsServer3D.BodyAxis @axis) => ((PhysicsBody3D)_host).GetAxisLock(@axis);

    /// <inheritdoc cref="PhysicsBody3D.GetCollisionExceptions()" />
    public Array<PhysicsBody3D> GetCollisionExceptions() => ((PhysicsBody3D)_host).GetCollisionExceptions();

    /// <inheritdoc cref="PhysicsBody3D.AddCollisionExceptionWith(Node)" />
    public void AddCollisionExceptionWith(Node @body) => ((PhysicsBody3D)_host).AddCollisionExceptionWith(@body);

    /// <inheritdoc cref="PhysicsBody3D.RemoveCollisionExceptionWith(Node)" />
    public void RemoveCollisionExceptionWith(Node @body) => ((PhysicsBody3D)_host).RemoveCollisionExceptionWith(@body);

}
