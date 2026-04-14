#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="VehicleBody3D" />
[Tool, GlobalClass]
public abstract partial class VehicleBody3DComponent : RigidBody3DComponent
{

    /// <inheritdoc cref="VehicleBody3D.SetEngineForce(float)" />
    public void SetEngineForce(float @engineForce) => ((VehicleBody3D)_host).SetEngineForce(@engineForce);

    /// <inheritdoc cref="VehicleBody3D.GetEngineForce()" />
    public float GetEngineForce() => ((VehicleBody3D)_host).GetEngineForce();

    /// <inheritdoc cref="VehicleBody3D.SetBrake(float)" />
    public void SetBrake(float @brake) => ((VehicleBody3D)_host).SetBrake(@brake);

    /// <inheritdoc cref="VehicleBody3D.GetBrake()" />
    public float GetBrake() => ((VehicleBody3D)_host).GetBrake();

    /// <inheritdoc cref="VehicleBody3D.SetSteering(float)" />
    public void SetSteering(float @steering) => ((VehicleBody3D)_host).SetSteering(@steering);

    /// <inheritdoc cref="VehicleBody3D.GetSteering()" />
    public float GetSteering() => ((VehicleBody3D)_host).GetSteering();

}
