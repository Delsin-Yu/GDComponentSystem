#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VehicleWheel3D" />
[Tool, GlobalClass]
public abstract partial class VehicleWheel3DComponent : Node3DComponent
{

    /// <inheritdoc cref="VehicleWheel3D.SetRadius(float)" />
    public void SetRadius(float @length) => ((VehicleWheel3D)_host).SetRadius(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetRadius()" />
    public float GetRadius() => ((VehicleWheel3D)_host).GetRadius();

    /// <inheritdoc cref="VehicleWheel3D.SetSuspensionRestLength(float)" />
    public void SetSuspensionRestLength(float @length) => ((VehicleWheel3D)_host).SetSuspensionRestLength(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetSuspensionRestLength()" />
    public float GetSuspensionRestLength() => ((VehicleWheel3D)_host).GetSuspensionRestLength();

    /// <inheritdoc cref="VehicleWheel3D.SetSuspensionTravel(float)" />
    public void SetSuspensionTravel(float @length) => ((VehicleWheel3D)_host).SetSuspensionTravel(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetSuspensionTravel()" />
    public float GetSuspensionTravel() => ((VehicleWheel3D)_host).GetSuspensionTravel();

    /// <inheritdoc cref="VehicleWheel3D.SetSuspensionStiffness(float)" />
    public void SetSuspensionStiffness(float @length) => ((VehicleWheel3D)_host).SetSuspensionStiffness(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetSuspensionStiffness()" />
    public float GetSuspensionStiffness() => ((VehicleWheel3D)_host).GetSuspensionStiffness();

    /// <inheritdoc cref="VehicleWheel3D.SetSuspensionMaxForce(float)" />
    public void SetSuspensionMaxForce(float @length) => ((VehicleWheel3D)_host).SetSuspensionMaxForce(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetSuspensionMaxForce()" />
    public float GetSuspensionMaxForce() => ((VehicleWheel3D)_host).GetSuspensionMaxForce();

    /// <inheritdoc cref="VehicleWheel3D.SetDampingCompression(float)" />
    public void SetDampingCompression(float @length) => ((VehicleWheel3D)_host).SetDampingCompression(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetDampingCompression()" />
    public float GetDampingCompression() => ((VehicleWheel3D)_host).GetDampingCompression();

    /// <inheritdoc cref="VehicleWheel3D.SetDampingRelaxation(float)" />
    public void SetDampingRelaxation(float @length) => ((VehicleWheel3D)_host).SetDampingRelaxation(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetDampingRelaxation()" />
    public float GetDampingRelaxation() => ((VehicleWheel3D)_host).GetDampingRelaxation();

    /// <inheritdoc cref="VehicleWheel3D.SetUseAsTraction(bool)" />
    public void SetUseAsTraction(bool @enable) => ((VehicleWheel3D)_host).SetUseAsTraction(@enable);

    /// <inheritdoc cref="VehicleWheel3D.IsUsedAsTraction()" />
    public bool IsUsedAsTraction() => ((VehicleWheel3D)_host).IsUsedAsTraction();

    /// <inheritdoc cref="VehicleWheel3D.SetUseAsSteering(bool)" />
    public void SetUseAsSteering(bool @enable) => ((VehicleWheel3D)_host).SetUseAsSteering(@enable);

    /// <inheritdoc cref="VehicleWheel3D.IsUsedAsSteering()" />
    public bool IsUsedAsSteering() => ((VehicleWheel3D)_host).IsUsedAsSteering();

    /// <inheritdoc cref="VehicleWheel3D.SetFrictionSlip(float)" />
    public void SetFrictionSlip(float @length) => ((VehicleWheel3D)_host).SetFrictionSlip(@length);

    /// <inheritdoc cref="VehicleWheel3D.GetFrictionSlip()" />
    public float GetFrictionSlip() => ((VehicleWheel3D)_host).GetFrictionSlip();

    /// <inheritdoc cref="VehicleWheel3D.IsInContact()" />
    public bool IsInContact() => ((VehicleWheel3D)_host).IsInContact();

    /// <inheritdoc cref="VehicleWheel3D.GetContactBody()" />
    public Node3D GetContactBody() => ((VehicleWheel3D)_host).GetContactBody();

    /// <inheritdoc cref="VehicleWheel3D.GetContactPoint()" />
    public Vector3 GetContactPoint() => ((VehicleWheel3D)_host).GetContactPoint();

    /// <inheritdoc cref="VehicleWheel3D.GetContactNormal()" />
    public Vector3 GetContactNormal() => ((VehicleWheel3D)_host).GetContactNormal();

    /// <inheritdoc cref="VehicleWheel3D.SetRollInfluence(float)" />
    public void SetRollInfluence(float @rollInfluence) => ((VehicleWheel3D)_host).SetRollInfluence(@rollInfluence);

    /// <inheritdoc cref="VehicleWheel3D.GetRollInfluence()" />
    public float GetRollInfluence() => ((VehicleWheel3D)_host).GetRollInfluence();

    /// <inheritdoc cref="VehicleWheel3D.GetSkidinfo()" />
    public float GetSkidinfo() => ((VehicleWheel3D)_host).GetSkidinfo();

    /// <inheritdoc cref="VehicleWheel3D.GetRpm()" />
    public float GetRpm() => ((VehicleWheel3D)_host).GetRpm();

    /// <inheritdoc cref="VehicleWheel3D.SetEngineForce(float)" />
    public void SetEngineForce(float @engineForce) => ((VehicleWheel3D)_host).SetEngineForce(@engineForce);

    /// <inheritdoc cref="VehicleWheel3D.GetEngineForce()" />
    public float GetEngineForce() => ((VehicleWheel3D)_host).GetEngineForce();

    /// <inheritdoc cref="VehicleWheel3D.SetBrake(float)" />
    public void SetBrake(float @brake) => ((VehicleWheel3D)_host).SetBrake(@brake);

    /// <inheritdoc cref="VehicleWheel3D.GetBrake()" />
    public float GetBrake() => ((VehicleWheel3D)_host).GetBrake();

    /// <inheritdoc cref="VehicleWheel3D.SetSteering(float)" />
    public void SetSteering(float @steering) => ((VehicleWheel3D)_host).SetSteering(@steering);

    /// <inheritdoc cref="VehicleWheel3D.GetSteering()" />
    public float GetSteering() => ((VehicleWheel3D)_host).GetSteering();

}
