#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="SoftBody3D" />
[Tool, GlobalClass]
public abstract partial class SoftBody3DComponent : MeshInstance3DComponent
{

    /// <inheritdoc cref="SoftBody3D.GetPhysicsRid()" />
    public Rid GetPhysicsRid() => ((SoftBody3D)_host).GetPhysicsRid();

    /// <inheritdoc cref="SoftBody3D.SetCollisionMask(uint)" />
    public void SetCollisionMask(uint @collisionMask) => ((SoftBody3D)_host).SetCollisionMask(@collisionMask);

    /// <inheritdoc cref="SoftBody3D.GetCollisionMask()" />
    public uint GetCollisionMask() => ((SoftBody3D)_host).GetCollisionMask();

    /// <inheritdoc cref="SoftBody3D.SetCollisionLayer(uint)" />
    public void SetCollisionLayer(uint @collisionLayer) => ((SoftBody3D)_host).SetCollisionLayer(@collisionLayer);

    /// <inheritdoc cref="SoftBody3D.GetCollisionLayer()" />
    public uint GetCollisionLayer() => ((SoftBody3D)_host).GetCollisionLayer();

    /// <inheritdoc cref="SoftBody3D.SetCollisionMaskValue(int, bool)" />
    public void SetCollisionMaskValue(int @layerNumber, bool @value) => ((SoftBody3D)_host).SetCollisionMaskValue(@layerNumber, @value);

    /// <inheritdoc cref="SoftBody3D.GetCollisionMaskValue(int)" />
    public bool GetCollisionMaskValue(int @layerNumber) => ((SoftBody3D)_host).GetCollisionMaskValue(@layerNumber);

    /// <inheritdoc cref="SoftBody3D.SetCollisionLayerValue(int, bool)" />
    public void SetCollisionLayerValue(int @layerNumber, bool @value) => ((SoftBody3D)_host).SetCollisionLayerValue(@layerNumber, @value);

    /// <inheritdoc cref="SoftBody3D.GetCollisionLayerValue(int)" />
    public bool GetCollisionLayerValue(int @layerNumber) => ((SoftBody3D)_host).GetCollisionLayerValue(@layerNumber);

    /// <inheritdoc cref="SoftBody3D.SetParentCollisionIgnore(NodePath)" />
    public void SetParentCollisionIgnore(NodePath @parentCollisionIgnore) => ((SoftBody3D)_host).SetParentCollisionIgnore(@parentCollisionIgnore);

    /// <inheritdoc cref="SoftBody3D.GetParentCollisionIgnore()" />
    public NodePath GetParentCollisionIgnore() => ((SoftBody3D)_host).GetParentCollisionIgnore();

    /// <inheritdoc cref="SoftBody3D.SetDisableMode(SoftBody3D.DisableModeEnum)" />
    public void SetDisableMode(SoftBody3D.DisableModeEnum @mode) => ((SoftBody3D)_host).SetDisableMode(@mode);

    /// <inheritdoc cref="SoftBody3D.GetDisableMode()" />
    public SoftBody3D.DisableModeEnum GetDisableMode() => ((SoftBody3D)_host).GetDisableMode();

    /// <inheritdoc cref="SoftBody3D.GetCollisionExceptions()" />
    public Array<PhysicsBody3D> GetCollisionExceptions() => ((SoftBody3D)_host).GetCollisionExceptions();

    /// <inheritdoc cref="SoftBody3D.AddCollisionExceptionWith(Node)" />
    public void AddCollisionExceptionWith(Node @body) => ((SoftBody3D)_host).AddCollisionExceptionWith(@body);

    /// <inheritdoc cref="SoftBody3D.RemoveCollisionExceptionWith(Node)" />
    public void RemoveCollisionExceptionWith(Node @body) => ((SoftBody3D)_host).RemoveCollisionExceptionWith(@body);

    /// <inheritdoc cref="SoftBody3D.SetSimulationPrecision(int)" />
    public void SetSimulationPrecision(int @simulationPrecision) => ((SoftBody3D)_host).SetSimulationPrecision(@simulationPrecision);

    /// <inheritdoc cref="SoftBody3D.GetSimulationPrecision()" />
    public int GetSimulationPrecision() => ((SoftBody3D)_host).GetSimulationPrecision();

    /// <inheritdoc cref="SoftBody3D.SetTotalMass(float)" />
    public void SetTotalMass(float @mass) => ((SoftBody3D)_host).SetTotalMass(@mass);

    /// <inheritdoc cref="SoftBody3D.GetTotalMass()" />
    public float GetTotalMass() => ((SoftBody3D)_host).GetTotalMass();

    /// <inheritdoc cref="SoftBody3D.SetLinearStiffness(float)" />
    public void SetLinearStiffness(float @linearStiffness) => ((SoftBody3D)_host).SetLinearStiffness(@linearStiffness);

    /// <inheritdoc cref="SoftBody3D.GetLinearStiffness()" />
    public float GetLinearStiffness() => ((SoftBody3D)_host).GetLinearStiffness();

    /// <inheritdoc cref="SoftBody3D.SetShrinkingFactor(float)" />
    public void SetShrinkingFactor(float @shrinkingFactor) => ((SoftBody3D)_host).SetShrinkingFactor(@shrinkingFactor);

    /// <inheritdoc cref="SoftBody3D.GetShrinkingFactor()" />
    public float GetShrinkingFactor() => ((SoftBody3D)_host).GetShrinkingFactor();

    /// <inheritdoc cref="SoftBody3D.SetPressureCoefficient(float)" />
    public void SetPressureCoefficient(float @pressureCoefficient) => ((SoftBody3D)_host).SetPressureCoefficient(@pressureCoefficient);

    /// <inheritdoc cref="SoftBody3D.GetPressureCoefficient()" />
    public float GetPressureCoefficient() => ((SoftBody3D)_host).GetPressureCoefficient();

    /// <inheritdoc cref="SoftBody3D.SetDampingCoefficient(float)" />
    public void SetDampingCoefficient(float @dampingCoefficient) => ((SoftBody3D)_host).SetDampingCoefficient(@dampingCoefficient);

    /// <inheritdoc cref="SoftBody3D.GetDampingCoefficient()" />
    public float GetDampingCoefficient() => ((SoftBody3D)_host).GetDampingCoefficient();

    /// <inheritdoc cref="SoftBody3D.SetDragCoefficient(float)" />
    public void SetDragCoefficient(float @dragCoefficient) => ((SoftBody3D)_host).SetDragCoefficient(@dragCoefficient);

    /// <inheritdoc cref="SoftBody3D.GetDragCoefficient()" />
    public float GetDragCoefficient() => ((SoftBody3D)_host).GetDragCoefficient();

    /// <inheritdoc cref="SoftBody3D.GetPointTransform(int)" />
    public Vector3 GetPointTransform(int @pointIndex) => ((SoftBody3D)_host).GetPointTransform(@pointIndex);

    /// <inheritdoc cref="SoftBody3D.ApplyImpulse(int, Vector3)" />
    public void ApplyImpulse(int @pointIndex, Vector3 @impulse) => ((SoftBody3D)_host).ApplyImpulse(@pointIndex, @impulse);

    /// <inheritdoc cref="SoftBody3D.ApplyForce(int, Vector3)" />
    public void ApplyForce(int @pointIndex, Vector3 @force) => ((SoftBody3D)_host).ApplyForce(@pointIndex, @force);

    /// <inheritdoc cref="SoftBody3D.ApplyCentralImpulse(Vector3)" />
    public void ApplyCentralImpulse(Vector3 @impulse) => ((SoftBody3D)_host).ApplyCentralImpulse(@impulse);

    /// <inheritdoc cref="SoftBody3D.ApplyCentralForce(Vector3)" />
    public void ApplyCentralForce(Vector3 @force) => ((SoftBody3D)_host).ApplyCentralForce(@force);

    /// <inheritdoc cref="SoftBody3D.SetPointPinned(int, bool, NodePath, int)" />
    public void SetPointPinned(int @pointIndex, bool @pinned, NodePath @attachmentPath, int @insertAt) => ((SoftBody3D)_host).SetPointPinned(@pointIndex, @pinned, @attachmentPath, @insertAt);

    /// <inheritdoc cref="SoftBody3D.IsPointPinned(int)" />
    public bool IsPointPinned(int @pointIndex) => ((SoftBody3D)_host).IsPointPinned(@pointIndex);

    /// <inheritdoc cref="SoftBody3D.SetRayPickable(bool)" />
    public void SetRayPickable(bool @rayPickable) => ((SoftBody3D)_host).SetRayPickable(@rayPickable);

    /// <inheritdoc cref="SoftBody3D.IsRayPickable()" />
    public bool IsRayPickable() => ((SoftBody3D)_host).IsRayPickable();

    /// <inheritdoc cref="SoftBody3D.SetPointPinned(int, bool, NodePath)" />
    public void SetPointPinned(int @pointIndex, bool @pinned, NodePath @attachmentPath) => ((SoftBody3D)_host).SetPointPinned(@pointIndex, @pinned, @attachmentPath);

}
