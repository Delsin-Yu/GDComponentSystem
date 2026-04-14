#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CharacterBody3D" />
[Tool, GlobalClass]
public abstract partial class CharacterBody3DComponent : PhysicsBody3DComponent
{

    /// <inheritdoc cref="CharacterBody3D.MoveAndSlide()" />
    public bool MoveAndSlide() => ((CharacterBody3D)_host).MoveAndSlide();

    /// <inheritdoc cref="CharacterBody3D.ApplyFloorSnap()" />
    public void ApplyFloorSnap() => ((CharacterBody3D)_host).ApplyFloorSnap();

    /// <inheritdoc cref="CharacterBody3D.SetVelocity(Vector3)" />
    public void SetVelocity(Vector3 @velocity) => ((CharacterBody3D)_host).SetVelocity(@velocity);

    /// <inheritdoc cref="CharacterBody3D.GetVelocity()" />
    public Vector3 GetVelocity() => ((CharacterBody3D)_host).GetVelocity();

    /// <inheritdoc cref="CharacterBody3D.SetSafeMargin(float)" />
    public void SetSafeMargin(float @margin) => ((CharacterBody3D)_host).SetSafeMargin(@margin);

    /// <inheritdoc cref="CharacterBody3D.GetSafeMargin()" />
    public float GetSafeMargin() => ((CharacterBody3D)_host).GetSafeMargin();

    /// <inheritdoc cref="CharacterBody3D.IsFloorStopOnSlopeEnabled()" />
    public bool IsFloorStopOnSlopeEnabled() => ((CharacterBody3D)_host).IsFloorStopOnSlopeEnabled();

    /// <inheritdoc cref="CharacterBody3D.SetFloorStopOnSlopeEnabled(bool)" />
    public void SetFloorStopOnSlopeEnabled(bool @enabled) => ((CharacterBody3D)_host).SetFloorStopOnSlopeEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody3D.SetFloorConstantSpeedEnabled(bool)" />
    public void SetFloorConstantSpeedEnabled(bool @enabled) => ((CharacterBody3D)_host).SetFloorConstantSpeedEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody3D.IsFloorConstantSpeedEnabled()" />
    public bool IsFloorConstantSpeedEnabled() => ((CharacterBody3D)_host).IsFloorConstantSpeedEnabled();

    /// <inheritdoc cref="CharacterBody3D.SetFloorBlockOnWallEnabled(bool)" />
    public void SetFloorBlockOnWallEnabled(bool @enabled) => ((CharacterBody3D)_host).SetFloorBlockOnWallEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody3D.IsFloorBlockOnWallEnabled()" />
    public bool IsFloorBlockOnWallEnabled() => ((CharacterBody3D)_host).IsFloorBlockOnWallEnabled();

    /// <inheritdoc cref="CharacterBody3D.SetSlideOnCeilingEnabled(bool)" />
    public void SetSlideOnCeilingEnabled(bool @enabled) => ((CharacterBody3D)_host).SetSlideOnCeilingEnabled(@enabled);

    /// <inheritdoc cref="CharacterBody3D.IsSlideOnCeilingEnabled()" />
    public bool IsSlideOnCeilingEnabled() => ((CharacterBody3D)_host).IsSlideOnCeilingEnabled();

    /// <inheritdoc cref="CharacterBody3D.SetPlatformFloorLayers(uint)" />
    public void SetPlatformFloorLayers(uint @excludeLayer) => ((CharacterBody3D)_host).SetPlatformFloorLayers(@excludeLayer);

    /// <inheritdoc cref="CharacterBody3D.GetPlatformFloorLayers()" />
    public uint GetPlatformFloorLayers() => ((CharacterBody3D)_host).GetPlatformFloorLayers();

    /// <inheritdoc cref="CharacterBody3D.SetPlatformWallLayers(uint)" />
    public void SetPlatformWallLayers(uint @excludeLayer) => ((CharacterBody3D)_host).SetPlatformWallLayers(@excludeLayer);

    /// <inheritdoc cref="CharacterBody3D.GetPlatformWallLayers()" />
    public uint GetPlatformWallLayers() => ((CharacterBody3D)_host).GetPlatformWallLayers();

    /// <inheritdoc cref="CharacterBody3D.GetMaxSlides()" />
    public int GetMaxSlides() => ((CharacterBody3D)_host).GetMaxSlides();

    /// <inheritdoc cref="CharacterBody3D.SetMaxSlides(int)" />
    public void SetMaxSlides(int @maxSlides) => ((CharacterBody3D)_host).SetMaxSlides(@maxSlides);

    /// <inheritdoc cref="CharacterBody3D.GetFloorMaxAngle()" />
    public float GetFloorMaxAngle() => ((CharacterBody3D)_host).GetFloorMaxAngle();

    /// <inheritdoc cref="CharacterBody3D.SetFloorMaxAngle(float)" />
    public void SetFloorMaxAngle(float @radians) => ((CharacterBody3D)_host).SetFloorMaxAngle(@radians);

    /// <inheritdoc cref="CharacterBody3D.GetFloorSnapLength()" />
    public float GetFloorSnapLength() => ((CharacterBody3D)_host).GetFloorSnapLength();

    /// <inheritdoc cref="CharacterBody3D.SetFloorSnapLength(float)" />
    public void SetFloorSnapLength(float @floorSnapLength) => ((CharacterBody3D)_host).SetFloorSnapLength(@floorSnapLength);

    /// <inheritdoc cref="CharacterBody3D.GetWallMinSlideAngle()" />
    public float GetWallMinSlideAngle() => ((CharacterBody3D)_host).GetWallMinSlideAngle();

    /// <inheritdoc cref="CharacterBody3D.SetWallMinSlideAngle(float)" />
    public void SetWallMinSlideAngle(float @radians) => ((CharacterBody3D)_host).SetWallMinSlideAngle(@radians);

    /// <inheritdoc cref="CharacterBody3D.GetUpDirection()" />
    public Vector3 GetUpDirection() => ((CharacterBody3D)_host).GetUpDirection();

    /// <inheritdoc cref="CharacterBody3D.SetUpDirection(Vector3)" />
    public void SetUpDirection(Vector3 @upDirection) => ((CharacterBody3D)_host).SetUpDirection(@upDirection);

    /// <inheritdoc cref="CharacterBody3D.SetMotionMode(CharacterBody3D.MotionModeEnum)" />
    public void SetMotionMode(CharacterBody3D.MotionModeEnum @mode) => ((CharacterBody3D)_host).SetMotionMode(@mode);

    /// <inheritdoc cref="CharacterBody3D.GetMotionMode()" />
    public CharacterBody3D.MotionModeEnum GetMotionMode() => ((CharacterBody3D)_host).GetMotionMode();

    /// <inheritdoc cref="CharacterBody3D.SetPlatformOnLeave(CharacterBody3D.PlatformOnLeaveEnum)" />
    public void SetPlatformOnLeave(CharacterBody3D.PlatformOnLeaveEnum @onLeaveApplyVelocity) => ((CharacterBody3D)_host).SetPlatformOnLeave(@onLeaveApplyVelocity);

    /// <inheritdoc cref="CharacterBody3D.GetPlatformOnLeave()" />
    public CharacterBody3D.PlatformOnLeaveEnum GetPlatformOnLeave() => ((CharacterBody3D)_host).GetPlatformOnLeave();

    /// <inheritdoc cref="CharacterBody3D.IsOnFloor()" />
    public bool IsOnFloor() => ((CharacterBody3D)_host).IsOnFloor();

    /// <inheritdoc cref="CharacterBody3D.IsOnFloorOnly()" />
    public bool IsOnFloorOnly() => ((CharacterBody3D)_host).IsOnFloorOnly();

    /// <inheritdoc cref="CharacterBody3D.IsOnCeiling()" />
    public bool IsOnCeiling() => ((CharacterBody3D)_host).IsOnCeiling();

    /// <inheritdoc cref="CharacterBody3D.IsOnCeilingOnly()" />
    public bool IsOnCeilingOnly() => ((CharacterBody3D)_host).IsOnCeilingOnly();

    /// <inheritdoc cref="CharacterBody3D.IsOnWall()" />
    public bool IsOnWall() => ((CharacterBody3D)_host).IsOnWall();

    /// <inheritdoc cref="CharacterBody3D.IsOnWallOnly()" />
    public bool IsOnWallOnly() => ((CharacterBody3D)_host).IsOnWallOnly();

    /// <inheritdoc cref="CharacterBody3D.GetFloorNormal()" />
    public Vector3 GetFloorNormal() => ((CharacterBody3D)_host).GetFloorNormal();

    /// <inheritdoc cref="CharacterBody3D.GetWallNormal()" />
    public Vector3 GetWallNormal() => ((CharacterBody3D)_host).GetWallNormal();

    /// <inheritdoc cref="CharacterBody3D.GetLastMotion()" />
    public Vector3 GetLastMotion() => ((CharacterBody3D)_host).GetLastMotion();

    /// <inheritdoc cref="CharacterBody3D.GetPositionDelta()" />
    public Vector3 GetPositionDelta() => ((CharacterBody3D)_host).GetPositionDelta();

    /// <inheritdoc cref="CharacterBody3D.GetRealVelocity()" />
    public Vector3 GetRealVelocity() => ((CharacterBody3D)_host).GetRealVelocity();

    /// <inheritdoc cref="CharacterBody3D.GetFloorAngle(Vector3?)" />
    public float GetFloorAngle(Vector3? @upDirection) => ((CharacterBody3D)_host).GetFloorAngle(@upDirection);

    /// <inheritdoc cref="CharacterBody3D.GetPlatformVelocity()" />
    public Vector3 GetPlatformVelocity() => ((CharacterBody3D)_host).GetPlatformVelocity();

    /// <inheritdoc cref="CharacterBody3D.GetPlatformAngularVelocity()" />
    public Vector3 GetPlatformAngularVelocity() => ((CharacterBody3D)_host).GetPlatformAngularVelocity();

    /// <inheritdoc cref="CharacterBody3D.GetSlideCollisionCount()" />
    public int GetSlideCollisionCount() => ((CharacterBody3D)_host).GetSlideCollisionCount();

    /// <inheritdoc cref="CharacterBody3D.GetSlideCollision(int)" />
    public KinematicCollision3D GetSlideCollision(int @slideIdx) => ((CharacterBody3D)_host).GetSlideCollision(@slideIdx);

    /// <inheritdoc cref="CharacterBody3D.GetLastSlideCollision()" />
    public KinematicCollision3D GetLastSlideCollision() => ((CharacterBody3D)_host).GetLastSlideCollision();

}
