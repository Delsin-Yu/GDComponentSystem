#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="PhysicsBody2D" />
[Tool, GlobalClass]
public abstract partial class PhysicsBody2DComponent : CollisionObject2DComponent
{

    /// <inheritdoc cref="PhysicsBody2D.MoveAndCollide(Vector2, bool, float, bool)" />
    public KinematicCollision2D MoveAndCollide(Vector2 @motion, bool @testOnly, float @safeMargin, bool @recoveryAsCollision) => ((PhysicsBody2D)_host).MoveAndCollide(@motion, @testOnly, @safeMargin, @recoveryAsCollision);

    /// <inheritdoc cref="PhysicsBody2D.TestMove(Transform2D, Vector2, KinematicCollision2D, float, bool)" />
    public bool TestMove(Transform2D @from, Vector2 @motion, KinematicCollision2D @collision, float @safeMargin, bool @recoveryAsCollision) => ((PhysicsBody2D)_host).TestMove(@from, @motion, @collision, @safeMargin, @recoveryAsCollision);

    /// <inheritdoc cref="PhysicsBody2D.GetGravity()" />
    public Vector2 GetGravity() => ((PhysicsBody2D)_host).GetGravity();

    /// <inheritdoc cref="PhysicsBody2D.GetCollisionExceptions()" />
    public Array<PhysicsBody2D> GetCollisionExceptions() => ((PhysicsBody2D)_host).GetCollisionExceptions();

    /// <inheritdoc cref="PhysicsBody2D.AddCollisionExceptionWith(Node)" />
    public void AddCollisionExceptionWith(Node @body) => ((PhysicsBody2D)_host).AddCollisionExceptionWith(@body);

    /// <inheritdoc cref="PhysicsBody2D.RemoveCollisionExceptionWith(Node)" />
    public void RemoveCollisionExceptionWith(Node @body) => ((PhysicsBody2D)_host).RemoveCollisionExceptionWith(@body);

}
