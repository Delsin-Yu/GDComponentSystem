#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Node3D" />
[Tool, GlobalClass]
public abstract partial class Node3DComponent : NodeComponent
{

    /// <inheritdoc cref="Node3D.LookAt(Vector3, Vector3?)" />
    public void LookAt(Vector3 @target, Vector3? @up) => ((Node3D)_host).LookAt(@target, @up);

    /// <inheritdoc cref="Node3D.LookAtFromPosition(Vector3, Vector3, Vector3?)" />
    public void LookAtFromPosition(Vector3 @position, Vector3 @target, Vector3? @up) => ((Node3D)_host).LookAtFromPosition(@position, @target, @up);

    /// <inheritdoc cref="Node3D.SetTransform(Transform3D)" />
    public void SetTransform(Transform3D @local) => ((Node3D)_host).SetTransform(@local);

    /// <inheritdoc cref="Node3D.GetTransform()" />
    public Transform3D GetTransform() => ((Node3D)_host).GetTransform();

    /// <inheritdoc cref="Node3D.SetPosition(Vector3)" />
    public void SetPosition(Vector3 @position) => ((Node3D)_host).SetPosition(@position);

    /// <inheritdoc cref="Node3D.GetPosition()" />
    public Vector3 GetPosition() => ((Node3D)_host).GetPosition();

    /// <inheritdoc cref="Node3D.SetRotation(Vector3)" />
    public void SetRotation(Vector3 @eulerRadians) => ((Node3D)_host).SetRotation(@eulerRadians);

    /// <inheritdoc cref="Node3D.GetRotation()" />
    public Vector3 GetRotation() => ((Node3D)_host).GetRotation();

    /// <inheritdoc cref="Node3D.SetRotationDegrees(Vector3)" />
    public void SetRotationDegrees(Vector3 @eulerDegrees) => ((Node3D)_host).SetRotationDegrees(@eulerDegrees);

    /// <inheritdoc cref="Node3D.GetRotationDegrees()" />
    public Vector3 GetRotationDegrees() => ((Node3D)_host).GetRotationDegrees();

    /// <inheritdoc cref="Node3D.SetRotationOrder(EulerOrder)" />
    public void SetRotationOrder(EulerOrder @order) => ((Node3D)_host).SetRotationOrder(@order);

    /// <inheritdoc cref="Node3D.GetRotationOrder()" />
    public EulerOrder GetRotationOrder() => ((Node3D)_host).GetRotationOrder();

    /// <inheritdoc cref="Node3D.SetRotationEditMode(Node3D.RotationEditModeEnum)" />
    public void SetRotationEditMode(Node3D.RotationEditModeEnum @editMode) => ((Node3D)_host).SetRotationEditMode(@editMode);

    /// <inheritdoc cref="Node3D.GetRotationEditMode()" />
    public Node3D.RotationEditModeEnum GetRotationEditMode() => ((Node3D)_host).GetRotationEditMode();

    /// <inheritdoc cref="Node3D.SetScale(Vector3)" />
    public void SetScale(Vector3 @scale) => ((Node3D)_host).SetScale(@scale);

    /// <inheritdoc cref="Node3D.GetScale()" />
    public Vector3 GetScale() => ((Node3D)_host).GetScale();

    /// <inheritdoc cref="Node3D.SetQuaternion(Quaternion)" />
    public void SetQuaternion(Quaternion @quaternion) => ((Node3D)_host).SetQuaternion(@quaternion);

    /// <inheritdoc cref="Node3D.GetQuaternion()" />
    public Quaternion GetQuaternion() => ((Node3D)_host).GetQuaternion();

    /// <inheritdoc cref="Node3D.SetBasis(Basis)" />
    public void SetBasis(Basis @basis) => ((Node3D)_host).SetBasis(@basis);

    /// <inheritdoc cref="Node3D.GetBasis()" />
    public Basis GetBasis() => ((Node3D)_host).GetBasis();

    /// <inheritdoc cref="Node3D.SetGlobalTransform(Transform3D)" />
    public void SetGlobalTransform(Transform3D @global) => ((Node3D)_host).SetGlobalTransform(@global);

    /// <inheritdoc cref="Node3D.GetGlobalTransform()" />
    public Transform3D GetGlobalTransform() => ((Node3D)_host).GetGlobalTransform();

    /// <inheritdoc cref="Node3D.GetGlobalTransformInterpolated()" />
    public Transform3D GetGlobalTransformInterpolated() => ((Node3D)_host).GetGlobalTransformInterpolated();

    /// <inheritdoc cref="Node3D.SetGlobalPosition(Vector3)" />
    public void SetGlobalPosition(Vector3 @position) => ((Node3D)_host).SetGlobalPosition(@position);

    /// <inheritdoc cref="Node3D.GetGlobalPosition()" />
    public Vector3 GetGlobalPosition() => ((Node3D)_host).GetGlobalPosition();

    /// <inheritdoc cref="Node3D.SetGlobalBasis(Basis)" />
    public void SetGlobalBasis(Basis @basis) => ((Node3D)_host).SetGlobalBasis(@basis);

    /// <inheritdoc cref="Node3D.GetGlobalBasis()" />
    public Basis GetGlobalBasis() => ((Node3D)_host).GetGlobalBasis();

    /// <inheritdoc cref="Node3D.SetGlobalRotation(Vector3)" />
    public void SetGlobalRotation(Vector3 @eulerRadians) => ((Node3D)_host).SetGlobalRotation(@eulerRadians);

    /// <inheritdoc cref="Node3D.GetGlobalRotation()" />
    public Vector3 GetGlobalRotation() => ((Node3D)_host).GetGlobalRotation();

    /// <inheritdoc cref="Node3D.SetGlobalRotationDegrees(Vector3)" />
    public void SetGlobalRotationDegrees(Vector3 @eulerDegrees) => ((Node3D)_host).SetGlobalRotationDegrees(@eulerDegrees);

    /// <inheritdoc cref="Node3D.GetGlobalRotationDegrees()" />
    public Vector3 GetGlobalRotationDegrees() => ((Node3D)_host).GetGlobalRotationDegrees();

    /// <inheritdoc cref="Node3D.GetParentNode3D()" />
    public Node3D GetParentNode3D() => ((Node3D)_host).GetParentNode3D();

    /// <inheritdoc cref="Node3D.SetIgnoreTransformNotification(bool)" />
    public void SetIgnoreTransformNotification(bool @enabled) => ((Node3D)_host).SetIgnoreTransformNotification(@enabled);

    /// <inheritdoc cref="Node3D.SetAsTopLevel(bool)" />
    public void SetAsTopLevel(bool @enable) => ((Node3D)_host).SetAsTopLevel(@enable);

    /// <inheritdoc cref="Node3D.IsSetAsTopLevel()" />
    public bool IsSetAsTopLevel() => ((Node3D)_host).IsSetAsTopLevel();

    /// <inheritdoc cref="Node3D.SetDisableScale(bool)" />
    public void SetDisableScale(bool @disable) => ((Node3D)_host).SetDisableScale(@disable);

    /// <inheritdoc cref="Node3D.IsScaleDisabled()" />
    public bool IsScaleDisabled() => ((Node3D)_host).IsScaleDisabled();

    /// <inheritdoc cref="Node3D.GetWorld3D()" />
    public World3D GetWorld3D() => ((Node3D)_host).GetWorld3D();

    /// <inheritdoc cref="Node3D.ForceUpdateTransform()" />
    public void ForceUpdateTransform() => ((Node3D)_host).ForceUpdateTransform();

    /// <inheritdoc cref="Node3D.SetVisibilityParent(NodePath)" />
    public void SetVisibilityParent(NodePath @path) => ((Node3D)_host).SetVisibilityParent(@path);

    /// <inheritdoc cref="Node3D.GetVisibilityParent()" />
    public NodePath GetVisibilityParent() => ((Node3D)_host).GetVisibilityParent();

    /// <inheritdoc cref="Node3D.UpdateGizmos()" />
    public void UpdateGizmos() => ((Node3D)_host).UpdateGizmos();

    /// <inheritdoc cref="Node3D.AddGizmo(Node3DGizmo)" />
    public void AddGizmo(Node3DGizmo @gizmo) => ((Node3D)_host).AddGizmo(@gizmo);

    /// <inheritdoc cref="Node3D.GetGizmos()" />
    public Array<Node3DGizmo> GetGizmos() => ((Node3D)_host).GetGizmos();

    /// <inheritdoc cref="Node3D.ClearGizmos()" />
    public void ClearGizmos() => ((Node3D)_host).ClearGizmos();

    /// <inheritdoc cref="Node3D.SetSubgizmoSelection(Node3DGizmo, int, Transform3D)" />
    public void SetSubgizmoSelection(Node3DGizmo @gizmo, int @id, Transform3D @transform) => ((Node3D)_host).SetSubgizmoSelection(@gizmo, @id, @transform);

    /// <inheritdoc cref="Node3D.ClearSubgizmoSelection()" />
    public void ClearSubgizmoSelection() => ((Node3D)_host).ClearSubgizmoSelection();

    /// <inheritdoc cref="Node3D.SetVisible(bool)" />
    public void SetVisible(bool @visible) => ((Node3D)_host).SetVisible(@visible);

    /// <inheritdoc cref="Node3D.IsVisible()" />
    public bool IsVisible() => ((Node3D)_host).IsVisible();

    /// <inheritdoc cref="Node3D.IsVisibleInTree()" />
    public bool IsVisibleInTree() => ((Node3D)_host).IsVisibleInTree();

    /// <inheritdoc cref="Node3D.Show()" />
    public void Show() => ((Node3D)_host).Show();

    /// <inheritdoc cref="Node3D.Hide()" />
    public void Hide() => ((Node3D)_host).Hide();

    /// <inheritdoc cref="Node3D.SetNotifyLocalTransform(bool)" />
    public void SetNotifyLocalTransform(bool @enable) => ((Node3D)_host).SetNotifyLocalTransform(@enable);

    /// <inheritdoc cref="Node3D.IsLocalTransformNotificationEnabled()" />
    public bool IsLocalTransformNotificationEnabled() => ((Node3D)_host).IsLocalTransformNotificationEnabled();

    /// <inheritdoc cref="Node3D.SetNotifyTransform(bool)" />
    public void SetNotifyTransform(bool @enable) => ((Node3D)_host).SetNotifyTransform(@enable);

    /// <inheritdoc cref="Node3D.IsTransformNotificationEnabled()" />
    public bool IsTransformNotificationEnabled() => ((Node3D)_host).IsTransformNotificationEnabled();

    /// <inheritdoc cref="Node3D.Rotate(Vector3, float)" />
    public void Rotate(Vector3 @axis, float @angle) => ((Node3D)_host).Rotate(@axis, @angle);

    /// <inheritdoc cref="Node3D.GlobalRotate(Vector3, float)" />
    public void GlobalRotate(Vector3 @axis, float @angle) => ((Node3D)_host).GlobalRotate(@axis, @angle);

    /// <inheritdoc cref="Node3D.GlobalScale(Vector3)" />
    public void GlobalScale(Vector3 @scale) => ((Node3D)_host).GlobalScale(@scale);

    /// <inheritdoc cref="Node3D.GlobalTranslate(Vector3)" />
    public void GlobalTranslate(Vector3 @offset) => ((Node3D)_host).GlobalTranslate(@offset);

    /// <inheritdoc cref="Node3D.RotateObjectLocal(Vector3, float)" />
    public void RotateObjectLocal(Vector3 @axis, float @angle) => ((Node3D)_host).RotateObjectLocal(@axis, @angle);

    /// <inheritdoc cref="Node3D.ScaleObjectLocal(Vector3)" />
    public void ScaleObjectLocal(Vector3 @scale) => ((Node3D)_host).ScaleObjectLocal(@scale);

    /// <inheritdoc cref="Node3D.TranslateObjectLocal(Vector3)" />
    public void TranslateObjectLocal(Vector3 @offset) => ((Node3D)_host).TranslateObjectLocal(@offset);

    /// <inheritdoc cref="Node3D.RotateX(float)" />
    public void RotateX(float @angle) => ((Node3D)_host).RotateX(@angle);

    /// <inheritdoc cref="Node3D.RotateY(float)" />
    public void RotateY(float @angle) => ((Node3D)_host).RotateY(@angle);

    /// <inheritdoc cref="Node3D.RotateZ(float)" />
    public void RotateZ(float @angle) => ((Node3D)_host).RotateZ(@angle);

    /// <inheritdoc cref="Node3D.Translate(Vector3)" />
    public void Translate(Vector3 @offset) => ((Node3D)_host).Translate(@offset);

    /// <inheritdoc cref="Node3D.Orthonormalize()" />
    public void Orthonormalize() => ((Node3D)_host).Orthonormalize();

    /// <inheritdoc cref="Node3D.SetIdentity()" />
    public void SetIdentity() => ((Node3D)_host).SetIdentity();

    /// <inheritdoc cref="Node3D.LookAt(Vector3, Vector3?, bool)" />
    public void LookAt(Vector3 @target, Vector3? @up, bool @useModelFront) => ((Node3D)_host).LookAt(@target, @up, @useModelFront);

    /// <inheritdoc cref="Node3D.LookAtFromPosition(Vector3, Vector3, Vector3?, bool)" />
    public void LookAtFromPosition(Vector3 @position, Vector3 @target, Vector3? @up, bool @useModelFront) => ((Node3D)_host).LookAtFromPosition(@position, @target, @up, @useModelFront);

    /// <inheritdoc cref="Node3D.ToLocal(Vector3)" />
    public Vector3 ToLocal(Vector3 @globalPoint) => ((Node3D)_host).ToLocal(@globalPoint);

    /// <inheritdoc cref="Node3D.ToGlobal(Vector3)" />
    public Vector3 ToGlobal(Vector3 @localPoint) => ((Node3D)_host).ToGlobal(@localPoint);

}
