#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Node2D" />
[Tool, GlobalClass]
public abstract partial class Node2DComponent : CanvasItemComponent
{

    /// <inheritdoc cref="Node2D.SetPosition(Vector2)" />
    public void SetPosition(Vector2 @position) => ((Node2D)_host).SetPosition(@position);

    /// <inheritdoc cref="Node2D.SetRotation(float)" />
    public void SetRotation(float @radians) => ((Node2D)_host).SetRotation(@radians);

    /// <inheritdoc cref="Node2D.SetRotationDegrees(float)" />
    public void SetRotationDegrees(float @degrees) => ((Node2D)_host).SetRotationDegrees(@degrees);

    /// <inheritdoc cref="Node2D.SetSkew(float)" />
    public void SetSkew(float @radians) => ((Node2D)_host).SetSkew(@radians);

    /// <inheritdoc cref="Node2D.SetScale(Vector2)" />
    public void SetScale(Vector2 @scale) => ((Node2D)_host).SetScale(@scale);

    /// <inheritdoc cref="Node2D.GetPosition()" />
    public Vector2 GetPosition() => ((Node2D)_host).GetPosition();

    /// <inheritdoc cref="Node2D.GetRotation()" />
    public float GetRotation() => ((Node2D)_host).GetRotation();

    /// <inheritdoc cref="Node2D.GetRotationDegrees()" />
    public float GetRotationDegrees() => ((Node2D)_host).GetRotationDegrees();

    /// <inheritdoc cref="Node2D.GetSkew()" />
    public float GetSkew() => ((Node2D)_host).GetSkew();

    /// <inheritdoc cref="Node2D.GetScale()" />
    public Vector2 GetScale() => ((Node2D)_host).GetScale();

    /// <inheritdoc cref="Node2D.Rotate(float)" />
    public void Rotate(float @radians) => ((Node2D)_host).Rotate(@radians);

    /// <inheritdoc cref="Node2D.MoveLocalX(float, bool)" />
    public void MoveLocalX(float @delta, bool @scaled) => ((Node2D)_host).MoveLocalX(@delta, @scaled);

    /// <inheritdoc cref="Node2D.MoveLocalY(float, bool)" />
    public void MoveLocalY(float @delta, bool @scaled) => ((Node2D)_host).MoveLocalY(@delta, @scaled);

    /// <inheritdoc cref="Node2D.Translate(Vector2)" />
    public void Translate(Vector2 @offset) => ((Node2D)_host).Translate(@offset);

    /// <inheritdoc cref="Node2D.GlobalTranslate(Vector2)" />
    public void GlobalTranslate(Vector2 @offset) => ((Node2D)_host).GlobalTranslate(@offset);

    /// <inheritdoc cref="Node2D.ApplyScale(Vector2)" />
    public void ApplyScale(Vector2 @ratio) => ((Node2D)_host).ApplyScale(@ratio);

    /// <inheritdoc cref="Node2D.SetGlobalPosition(Vector2)" />
    public void SetGlobalPosition(Vector2 @position) => ((Node2D)_host).SetGlobalPosition(@position);

    /// <inheritdoc cref="Node2D.GetGlobalPosition()" />
    public Vector2 GetGlobalPosition() => ((Node2D)_host).GetGlobalPosition();

    /// <inheritdoc cref="Node2D.SetGlobalRotation(float)" />
    public void SetGlobalRotation(float @radians) => ((Node2D)_host).SetGlobalRotation(@radians);

    /// <inheritdoc cref="Node2D.SetGlobalRotationDegrees(float)" />
    public void SetGlobalRotationDegrees(float @degrees) => ((Node2D)_host).SetGlobalRotationDegrees(@degrees);

    /// <inheritdoc cref="Node2D.GetGlobalRotation()" />
    public float GetGlobalRotation() => ((Node2D)_host).GetGlobalRotation();

    /// <inheritdoc cref="Node2D.GetGlobalRotationDegrees()" />
    public float GetGlobalRotationDegrees() => ((Node2D)_host).GetGlobalRotationDegrees();

    /// <inheritdoc cref="Node2D.SetGlobalSkew(float)" />
    public void SetGlobalSkew(float @radians) => ((Node2D)_host).SetGlobalSkew(@radians);

    /// <inheritdoc cref="Node2D.GetGlobalSkew()" />
    public float GetGlobalSkew() => ((Node2D)_host).GetGlobalSkew();

    /// <inheritdoc cref="Node2D.SetGlobalScale(Vector2)" />
    public void SetGlobalScale(Vector2 @scale) => ((Node2D)_host).SetGlobalScale(@scale);

    /// <inheritdoc cref="Node2D.GetGlobalScale()" />
    public Vector2 GetGlobalScale() => ((Node2D)_host).GetGlobalScale();

    /// <inheritdoc cref="Node2D.SetTransform(Transform2D)" />
    public void SetTransform(Transform2D @xform) => ((Node2D)_host).SetTransform(@xform);

    /// <inheritdoc cref="Node2D.SetGlobalTransform(Transform2D)" />
    public void SetGlobalTransform(Transform2D @xform) => ((Node2D)_host).SetGlobalTransform(@xform);

    /// <inheritdoc cref="Node2D.LookAt(Vector2)" />
    public void LookAt(Vector2 @point) => ((Node2D)_host).LookAt(@point);

    /// <inheritdoc cref="Node2D.GetAngleTo(Vector2)" />
    public float GetAngleTo(Vector2 @point) => ((Node2D)_host).GetAngleTo(@point);

    /// <inheritdoc cref="Node2D.ToLocal(Vector2)" />
    public Vector2 ToLocal(Vector2 @globalPoint) => ((Node2D)_host).ToLocal(@globalPoint);

    /// <inheritdoc cref="Node2D.ToGlobal(Vector2)" />
    public Vector2 ToGlobal(Vector2 @localPoint) => ((Node2D)_host).ToGlobal(@localPoint);

    /// <inheritdoc cref="Node2D.GetRelativeTransformToParent(Node)" />
    public Transform2D GetRelativeTransformToParent(Node @parent) => ((Node2D)_host).GetRelativeTransformToParent(@parent);

}
