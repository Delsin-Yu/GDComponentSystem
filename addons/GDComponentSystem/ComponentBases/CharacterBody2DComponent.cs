#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CharacterBody2D" />
[Tool, GlobalClass]
public abstract partial class CharacterBody2DComponent : PhysicsBody2DComponent
{

    /// <inheritdoc cref="CharacterBody2D.MoveAndSlide()" />
    public bool MoveAndSlide() => ((CharacterBody2D)_host).MoveAndSlide();

    /// <inheritdoc cref="CharacterBody2D.ApplyFloorSnap()" />
    public void ApplyFloorSnap() => ((CharacterBody2D)_host).ApplyFloorSnap();

    /// <inheritdoc cref="CharacterBody2D.SetVelocity(Vector2)" />
    public void SetVelocity(Vector2 @velocity) => ((CharacterBody2D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="CharacterBody2D.GetVelocity()" />
    public Vector2 GetVelocity() => ((CharacterBody2D)_host).GetVelocity();

    /// <inheritdoc cref="CharacterBody2D.SetSafeMargin(float)" />
    public void SetSafeMargin(float @margin) => ((CharacterBody2D)_host).SetSafeMargin(@margin);

    /// <inheritdoc cref="CharacterBody2D.GetSafeMargin()" />
    public float GetSafeMargin() => ((CharacterBody2D)_host).GetSafeMargin();

    /// <inheritdoc cref="CharacterBody2D.IsFloorStopOnSlopeEnabled()" />
    public bool IsFloorStopOnSlopeEnabled() => ((CharacterBody2D)_host).IsFloorStopOnSlopeEnabled();

    /// <inheritdoc cref="CharacterBody2D.SetFloorStopOnSlopeEnabled(bool)" />
    public void SetFloorStopOnSlopeEnabled(bool @enabled) => ((CharacterBody2D)_host).SetFloorStopOnSlopeEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody2D.SetFloorConstantSpeedEnabled(bool)" />
    public void SetFloorConstantSpeedEnabled(bool @enabled) => ((CharacterBody2D)_host).SetFloorConstantSpeedEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody2D.IsFloorConstantSpeedEnabled()" />
    public bool IsFloorConstantSpeedEnabled() => ((CharacterBody2D)_host).IsFloorConstantSpeedEnabled();

    /// <inheritdoc cref="CharacterBody2D.SetFloorBlockOnWallEnabled(bool)" />
    public void SetFloorBlockOnWallEnabled(bool @enabled) => ((CharacterBody2D)_host).SetFloorBlockOnWallEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody2D.IsFloorBlockOnWallEnabled()" />
    public bool IsFloorBlockOnWallEnabled() => ((CharacterBody2D)_host).IsFloorBlockOnWallEnabled();

    /// <inheritdoc cref="CharacterBody2D.SetSlideOnCeilingEnabled(bool)" />
    public void SetSlideOnCeilingEnabled(bool @enabled) => ((CharacterBody2D)_host).SetSlideOnCeilingEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody2D.IsSlideOnCeilingEnabled()" />
    public bool IsSlideOnCeilingEnabled() => ((CharacterBody2D)_host).IsSlideOnCeilingEnabled();

    /// <inheritdoc cref="CharacterBody2D.SetPlatformFloorLayers(uint)" />
    public void SetPlatformFloorLayers(uint @excludeLayer) => ((CharacterBody2D)_host).SetPlatformFloorLayers(@excludeLayer);

    /// <inheritdoc cref="CharacterBody2D.GetPlatformFloorLayers()" />
    public uint GetPlatformFloorLayers() => ((CharacterBody2D)_host).GetPlatformFloorLayers();

    /// <inheritdoc cref="CharacterBody2D.SetPlatformWallLayers(uint)" />
    public void SetPlatformWallLayers(uint @excludeLayer) => ((CharacterBody2D)_host).SetPlatformWallLayers(@excludeLayer);

    /// <inheritdoc cref="CharacterBody2D.GetPlatformWallLayers()" />
    public uint GetPlatformWallLayers() => ((CharacterBody2D)_host).GetPlatformWallLayers();

    /// <inheritdoc cref="CharacterBody2D.GetMaxSlides()" />
    public int GetMaxSlides() => ((CharacterBody2D)_host).GetMaxSlides();

    /// <inheritdoc cref="CharacterBody2D.SetMaxSlides(int)" />
    public void SetMaxSlides(int @maxSlides) => ((CharacterBody2D)_host).SetMaxSlides(@maxSlides);

    /// <inheritdoc cref="CharacterBody2D.GetFloorMaxAngle()" />
    public float GetFloorMaxAngle() => ((CharacterBody2D)_host).GetFloorMaxAngle();

    /// <inheritdoc cref="CharacterBody2D.SetFloorMaxAngle(float)" />
    public void SetFloorMaxAngle(float @radians) => ((CharacterBody2D)_host).SetFloorMaxAngle(@radians);

    /// <inheritdoc cref="CharacterBody2D.GetFloorSnapLength()" />
    public float GetFloorSnapLength() => ((CharacterBody2D)_host).GetFloorSnapLength();

    /// <inheritdoc cref="CharacterBody2D.SetFloorSnapLength(float)" />
    public void SetFloorSnapLength(float @floorSnapLength) => ((CharacterBody2D)_host).SetFloorSnapLength(@floorSnapLength);

    /// <inheritdoc cref="CharacterBody2D.GetWallMinSlideAngle()" />
    public float GetWallMinSlideAngle() => ((CharacterBody2D)_host).GetWallMinSlideAngle();

    /// <inheritdoc cref="CharacterBody2D.SetWallMinSlideAngle(float)" />
    public void SetWallMinSlideAngle(float @radians) => ((CharacterBody2D)_host).SetWallMinSlideAngle(@radians);

    /// <inheritdoc cref="CharacterBody2D.GetUpDirection()" />
    public Vector2 GetUpDirection() => ((CharacterBody2D)_host).GetUpDirection();

    /// <inheritdoc cref="CharacterBody2D.SetUpDirection(Vector2)" />
    public void SetUpDirection(Vector2 @upDirection) => ((CharacterBody2D)_host).SetUpDirection(@upDirection);

    /// <inheritdoc cref="CharacterBody2D.SetMotionMode(CharacterBody2D.MotionModeEnum)" />
    public void SetMotionMode(CharacterBody2D.MotionModeEnum @mode) => ((CharacterBody2D)_host).SetMotionMode(@mode);

    /// <inheritdoc cref="CharacterBody2D.GetMotionMode()" />
    public CharacterBody2D.MotionModeEnum GetMotionMode() => ((CharacterBody2D)_host).GetMotionMode();

    /// <inheritdoc cref="CharacterBody2D.SetPlatformOnLeave(CharacterBody2D.PlatformOnLeaveEnum)" />
    public void SetPlatformOnLeave(CharacterBody2D.PlatformOnLeaveEnum @onLeaveApplyVelocity) => ((CharacterBody2D)_host).SetPlatformOnLeave(@onLeaveApplyVelocity);

    /// <inheritdoc cref="CharacterBody2D.GetPlatformOnLeave()" />
    public CharacterBody2D.PlatformOnLeaveEnum GetPlatformOnLeave() => ((CharacterBody2D)_host).GetPlatformOnLeave();

    /// <inheritdoc cref="CharacterBody2D.IsOnFloor()" />
    public bool IsOnFloor() => ((CharacterBody2D)_host).IsOnFloor();

    /// <inheritdoc cref="CharacterBody2D.IsOnFloorOnly()" />
    public bool IsOnFloorOnly() => ((CharacterBody2D)_host).IsOnFloorOnly();

    /// <inheritdoc cref="CharacterBody2D.IsOnCeiling()" />
    public bool IsOnCeiling() => ((CharacterBody2D)_host).IsOnCeiling();

    /// <inheritdoc cref="CharacterBody2D.IsOnCeilingOnly()" />
    public bool IsOnCeilingOnly() => ((CharacterBody2D)_host).IsOnCeilingOnly();

    /// <inheritdoc cref="CharacterBody2D.IsOnWall()" />
    public bool IsOnWall() => ((CharacterBody2D)_host).IsOnWall();

    /// <inheritdoc cref="CharacterBody2D.IsOnWallOnly()" />
    public bool IsOnWallOnly() => ((CharacterBody2D)_host).IsOnWallOnly();

    /// <inheritdoc cref="CharacterBody2D.GetFloorNormal()" />
    public Vector2 GetFloorNormal() => ((CharacterBody2D)_host).GetFloorNormal();

    /// <inheritdoc cref="CharacterBody2D.GetWallNormal()" />
    public Vector2 GetWallNormal() => ((CharacterBody2D)_host).GetWallNormal();

    /// <inheritdoc cref="CharacterBody2D.GetLastMotion()" />
    public Vector2 GetLastMotion() => ((CharacterBody2D)_host).GetLastMotion();

    /// <inheritdoc cref="CharacterBody2D.GetPositionDelta()" />
    public Vector2 GetPositionDelta() => ((CharacterBody2D)_host).GetPositionDelta();

    /// <inheritdoc cref="CharacterBody2D.GetRealVelocity()" />
    public Vector2 GetRealVelocity() => ((CharacterBody2D)_host).GetRealVelocity();

    /// <inheritdoc cref="CharacterBody2D.GetFloorAngle(Vector2?)" />
    public float GetFloorAngle(Vector2? @upDirection) => ((CharacterBody2D)_host).GetFloorAngle(@upDirection);

    /// <inheritdoc cref="CharacterBody2D.GetPlatformVelocity()" />
    public Vector2 GetPlatformVelocity() => ((CharacterBody2D)_host).GetPlatformVelocity();

    /// <inheritdoc cref="CharacterBody2D.GetSlideCollisionCount()" />
    public int GetSlideCollisionCount() => ((CharacterBody2D)_host).GetSlideCollisionCount();

    /// <inheritdoc cref="CharacterBody2D.GetSlideCollision(int)" />
    public KinematicCollision2D GetSlideCollision(int @slideIdx) => ((CharacterBody2D)_host).GetSlideCollision(@slideIdx);

    /// <inheritdoc cref="CharacterBody2D.GetLastSlideCollision()" />
    public KinematicCollision2D GetLastSlideCollision() => ((CharacterBody2D)_host).GetLastSlideCollision();

}
