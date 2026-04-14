#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Camera3D" />
[Tool, GlobalClass]
public abstract partial class Camera3DComponent : Node3DComponent
{

    /// <inheritdoc cref="Camera3D.ProjectRayNormal(Vector2)" />
    public Vector3 ProjectRayNormal(Vector2 @screenPoint) => ((Camera3D)_host).ProjectRayNormal(@screenPoint);

    /// <inheritdoc cref="Camera3D.ProjectLocalRayNormal(Vector2)" />
    public Vector3 ProjectLocalRayNormal(Vector2 @screenPoint) => ((Camera3D)_host).ProjectLocalRayNormal(@screenPoint);

    /// <inheritdoc cref="Camera3D.ProjectRayOrigin(Vector2)" />
    public Vector3 ProjectRayOrigin(Vector2 @screenPoint) => ((Camera3D)_host).ProjectRayOrigin(@screenPoint);

    /// <inheritdoc cref="Camera3D.UnprojectPosition(Vector3)" />
    public Vector2 UnprojectPosition(Vector3 @worldPoint) => ((Camera3D)_host).UnprojectPosition(@worldPoint);

    /// <inheritdoc cref="Camera3D.IsPositionBehind(Vector3)" />
    public bool IsPositionBehind(Vector3 @worldPoint) => ((Camera3D)_host).IsPositionBehind(@worldPoint);

    /// <inheritdoc cref="Camera3D.ProjectPosition(Vector2, float)" />
    public Vector3 ProjectPosition(Vector2 @screenPoint, float @zDepth) => ((Camera3D)_host).ProjectPosition(@screenPoint, @zDepth);

    /// <inheritdoc cref="Camera3D.SetPerspective(float, float, float)" />
    public void SetPerspective(float @fov, float @zNear, float @zFar) => ((Camera3D)_host).SetPerspective(@fov, @zNear, @zFar);

    /// <inheritdoc cref="Camera3D.SetOrthogonal(float, float, float)" />
    public void SetOrthogonal(float @size, float @zNear, float @zFar) => ((Camera3D)_host).SetOrthogonal(@size, @zNear, @zFar);

    /// <inheritdoc cref="Camera3D.SetFrustum(float, Vector2, float, float)" />
    public void SetFrustum(float @size, Vector2 @offset, float @zNear, float @zFar) => ((Camera3D)_host).SetFrustum(@size, @offset, @zNear, @zFar);

    /// <inheritdoc cref="Camera3D.MakeCurrent()" />
    public void MakeCurrent() => ((Camera3D)_host).MakeCurrent();

    /// <inheritdoc cref="Camera3D.ClearCurrent(bool)" />
    public void ClearCurrent(bool @enableNext) => ((Camera3D)_host).ClearCurrent(@enableNext);

    /// <inheritdoc cref="Camera3D.SetCurrent(bool)" />
    public void SetCurrent(bool @enabled) => ((Camera3D)_host).SetCurrent(@enabled);

    /// <inheritdoc cref="Camera3D.IsCurrent()" />
    public bool IsCurrent() => ((Camera3D)_host).IsCurrent();

    /// <inheritdoc cref="Camera3D.GetCameraTransform()" />
    public Transform3D GetCameraTransform() => ((Camera3D)_host).GetCameraTransform();

    /// <inheritdoc cref="Camera3D.GetCameraProjection()" />
    public Projection GetCameraProjection() => ((Camera3D)_host).GetCameraProjection();

    /// <inheritdoc cref="Camera3D.GetFov()" />
    public float GetFov() => ((Camera3D)_host).GetFov();

    /// <inheritdoc cref="Camera3D.GetFrustumOffset()" />
    public Vector2 GetFrustumOffset() => ((Camera3D)_host).GetFrustumOffset();

    /// <inheritdoc cref="Camera3D.GetSize()" />
    public float GetSize() => ((Camera3D)_host).GetSize();

    /// <inheritdoc cref="Camera3D.GetFar()" />
    public float GetFar() => ((Camera3D)_host).GetFar();

    /// <inheritdoc cref="Camera3D.GetNear()" />
    public float GetNear() => ((Camera3D)_host).GetNear();

    /// <inheritdoc cref="Camera3D.SetFov(float)" />
    public void SetFov(float @fov) => ((Camera3D)_host).SetFov(@fov);

    /// <inheritdoc cref="Camera3D.SetFrustumOffset(Vector2)" />
    public void SetFrustumOffset(Vector2 @offset) => ((Camera3D)_host).SetFrustumOffset(@offset);

    /// <inheritdoc cref="Camera3D.SetSize(float)" />
    public void SetSize(float @size) => ((Camera3D)_host).SetSize(@size);

    /// <inheritdoc cref="Camera3D.SetFar(float)" />
    public void SetFar(float @far) => ((Camera3D)_host).SetFar(@far);

    /// <inheritdoc cref="Camera3D.SetNear(float)" />
    public void SetNear(float @near) => ((Camera3D)_host).SetNear(@near);

    /// <inheritdoc cref="Camera3D.GetProjection()" />
    public Camera3D.ProjectionType GetProjection() => ((Camera3D)_host).GetProjection();

    /// <inheritdoc cref="Camera3D.SetProjection(Camera3D.ProjectionType)" />
    public void SetProjection(Camera3D.ProjectionType @mode) => ((Camera3D)_host).SetProjection(@mode);

    /// <inheritdoc cref="Camera3D.SetHOffset(float)" />
    public void SetHOffset(float @offset) => ((Camera3D)_host).SetHOffset(@offset);

    /// <inheritdoc cref="Camera3D.GetHOffset()" />
    public float GetHOffset() => ((Camera3D)_host).GetHOffset();

    /// <inheritdoc cref="Camera3D.SetVOffset(float)" />
    public void SetVOffset(float @offset) => ((Camera3D)_host).SetVOffset(@offset);

    /// <inheritdoc cref="Camera3D.GetVOffset()" />
    public float GetVOffset() => ((Camera3D)_host).GetVOffset();

    /// <inheritdoc cref="Camera3D.SetCullMask(uint)" />
    public void SetCullMask(uint @mask) => ((Camera3D)_host).SetCullMask(@mask);

    /// <inheritdoc cref="Camera3D.GetCullMask()" />
    public uint GetCullMask() => ((Camera3D)_host).GetCullMask();

    /// <inheritdoc cref="Camera3D.SetEnvironment(Environment)" />
    public void SetEnvironment(Environment @env) => ((Camera3D)_host).SetEnvironment(@env);

    /// <inheritdoc cref="Camera3D.GetEnvironment()" />
    public Environment GetEnvironment() => ((Camera3D)_host).GetEnvironment();

    /// <inheritdoc cref="Camera3D.SetAttributes(CameraAttributes)" />
    public void SetAttributes(CameraAttributes @env) => ((Camera3D)_host).SetAttributes(@env);

    /// <inheritdoc cref="Camera3D.GetAttributes()" />
    public CameraAttributes GetAttributes() => ((Camera3D)_host).GetAttributes();

    /// <inheritdoc cref="Camera3D.SetCompositor(Compositor)" />
    public void SetCompositor(Compositor @compositor) => ((Camera3D)_host).SetCompositor(@compositor);

    /// <inheritdoc cref="Camera3D.GetCompositor()" />
    public Compositor GetCompositor() => ((Camera3D)_host).GetCompositor();

    /// <inheritdoc cref="Camera3D.SetKeepAspectMode(Camera3D.KeepAspectEnum)" />
    public void SetKeepAspectMode(Camera3D.KeepAspectEnum @mode) => ((Camera3D)_host).SetKeepAspectMode(@mode);

    /// <inheritdoc cref="Camera3D.GetKeepAspectMode()" />
    public Camera3D.KeepAspectEnum GetKeepAspectMode() => ((Camera3D)_host).GetKeepAspectMode();

    /// <inheritdoc cref="Camera3D.SetDopplerTracking(Camera3D.DopplerTrackingEnum)" />
    public void SetDopplerTracking(Camera3D.DopplerTrackingEnum @mode) => ((Camera3D)_host).SetDopplerTracking(@mode);

    /// <inheritdoc cref="Camera3D.GetDopplerTracking()" />
    public Camera3D.DopplerTrackingEnum GetDopplerTracking() => ((Camera3D)_host).GetDopplerTracking();

    /// <inheritdoc cref="Camera3D.GetFrustum()" />
    public Array<Plane> GetFrustum() => ((Camera3D)_host).GetFrustum();

    /// <inheritdoc cref="Camera3D.IsPositionInFrustum(Vector3)" />
    public bool IsPositionInFrustum(Vector3 @worldPoint) => ((Camera3D)_host).IsPositionInFrustum(@worldPoint);

    /// <inheritdoc cref="Camera3D.GetCameraRid()" />
    public Rid GetCameraRid() => ((Camera3D)_host).GetCameraRid();

    /// <inheritdoc cref="Camera3D.GetPyramidShapeRid()" />
    public Rid GetPyramidShapeRid() => ((Camera3D)_host).GetPyramidShapeRid();

    /// <inheritdoc cref="Camera3D.SetCullMaskValue(int, bool)" />
    public void SetCullMaskValue(int @layerNumber, bool @value) => ((Camera3D)_host).SetCullMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="Camera3D.GetCullMaskValue(int)" />
    public bool GetCullMaskValue(int @layerNumber) => ((Camera3D)_host).GetCullMaskValue(@layerNumber);

}
