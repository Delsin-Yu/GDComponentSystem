#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="CpuParticles3D" />
[Tool, GlobalClass]
public abstract partial class CpuParticles3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="CpuParticles3D.SetEmitting(bool)" />
    public void SetEmitting(bool @emitting) => ((CpuParticles3D)_host).SetEmitting(@emitting);

    /// <inheritdoc cref="CpuParticles3D.SetAmount(int)" />
    public void SetAmount(int @amount) => ((CpuParticles3D)_host).SetAmount(@amount);

    /// <inheritdoc cref="CpuParticles3D.SetLifetime(double)" />
    public void SetLifetime(double @secs) => ((CpuParticles3D)_host).SetLifetime(@secs);

    /// <inheritdoc cref="CpuParticles3D.SetOneShot(bool)" />
    public void SetOneShot(bool @enable) => ((CpuParticles3D)_host).SetOneShot(@enable);

    /// <inheritdoc cref="CpuParticles3D.SetPreProcessTime(double)" />
    public void SetPreProcessTime(double @secs) => ((CpuParticles3D)_host).SetPreProcessTime(@secs);

    /// <inheritdoc cref="CpuParticles3D.SetExplosivenessRatio(float)" />
    public void SetExplosivenessRatio(float @ratio) => ((CpuParticles3D)_host).SetExplosivenessRatio(@ratio);

    /// <inheritdoc cref="CpuParticles3D.SetRandomnessRatio(float)" />
    public void SetRandomnessRatio(float @ratio) => ((CpuParticles3D)_host).SetRandomnessRatio(@ratio);

    /// <inheritdoc cref="CpuParticles3D.SetVisibilityAabb(Aabb)" />
    public void SetVisibilityAabb(Aabb @aabb) => ((CpuParticles3D)_host).SetVisibilityAabb(@aabb);

    /// <inheritdoc cref="CpuParticles3D.SetLifetimeRandomness(double)" />
    public void SetLifetimeRandomness(double @random) => ((CpuParticles3D)_host).SetLifetimeRandomness(@random);

    /// <inheritdoc cref="CpuParticles3D.SetUseLocalCoordinates(bool)" />
    public void SetUseLocalCoordinates(bool @enable) => ((CpuParticles3D)_host).SetUseLocalCoordinates(@enable);

    /// <inheritdoc cref="CpuParticles3D.SetFixedFps(int)" />
    public void SetFixedFps(int @fps) => ((CpuParticles3D)_host).SetFixedFps(@fps);

    /// <inheritdoc cref="CpuParticles3D.SetFractionalDelta(bool)" />
    public void SetFractionalDelta(bool @enable) => ((CpuParticles3D)_host).SetFractionalDelta(@enable);

    /// <inheritdoc cref="CpuParticles3D.SetSpeedScale(double)" />
    public void SetSpeedScale(double @scale) => ((CpuParticles3D)_host).SetSpeedScale(@scale);

    /// <inheritdoc cref="CpuParticles3D.IsEmitting()" />
    public bool IsEmitting() => ((CpuParticles3D)_host).IsEmitting();

    /// <inheritdoc cref="CpuParticles3D.GetAmount()" />
    public int GetAmount() => ((CpuParticles3D)_host).GetAmount();

    /// <inheritdoc cref="CpuParticles3D.GetLifetime()" />
    public double GetLifetime() => ((CpuParticles3D)_host).GetLifetime();

    /// <inheritdoc cref="CpuParticles3D.GetOneShot()" />
    public bool GetOneShot() => ((CpuParticles3D)_host).GetOneShot();

    /// <inheritdoc cref="CpuParticles3D.GetPreProcessTime()" />
    public double GetPreProcessTime() => ((CpuParticles3D)_host).GetPreProcessTime();

    /// <inheritdoc cref="CpuParticles3D.GetExplosivenessRatio()" />
    public float GetExplosivenessRatio() => ((CpuParticles3D)_host).GetExplosivenessRatio();

    /// <inheritdoc cref="CpuParticles3D.GetRandomnessRatio()" />
    public float GetRandomnessRatio() => ((CpuParticles3D)_host).GetRandomnessRatio();

    /// <inheritdoc cref="CpuParticles3D.GetVisibilityAabb()" />
    public Aabb GetVisibilityAabb() => ((CpuParticles3D)_host).GetVisibilityAabb();

    /// <inheritdoc cref="CpuParticles3D.GetLifetimeRandomness()" />
    public double GetLifetimeRandomness() => ((CpuParticles3D)_host).GetLifetimeRandomness();

    /// <inheritdoc cref="CpuParticles3D.GetUseLocalCoordinates()" />
    public bool GetUseLocalCoordinates() => ((CpuParticles3D)_host).GetUseLocalCoordinates();

    /// <inheritdoc cref="CpuParticles3D.GetFixedFps()" />
    public int GetFixedFps() => ((CpuParticles3D)_host).GetFixedFps();

    /// <inheritdoc cref="CpuParticles3D.GetFractionalDelta()" />
    public bool GetFractionalDelta() => ((CpuParticles3D)_host).GetFractionalDelta();

    /// <inheritdoc cref="CpuParticles3D.GetSpeedScale()" />
    public double GetSpeedScale() => ((CpuParticles3D)_host).GetSpeedScale();

    /// <inheritdoc cref="CpuParticles3D.SetDrawOrder(CpuParticles3D.DrawOrderEnum)" />
    public void SetDrawOrder(CpuParticles3D.DrawOrderEnum @order) => ((CpuParticles3D)_host).SetDrawOrder(@order);

    /// <inheritdoc cref="CpuParticles3D.GetDrawOrder()" />
    public CpuParticles3D.DrawOrderEnum GetDrawOrder() => ((CpuParticles3D)_host).GetDrawOrder();

    /// <inheritdoc cref="CpuParticles3D.SetMesh(Mesh)" />
    public void SetMesh(Mesh @mesh) => ((CpuParticles3D)_host).SetMesh(@mesh);

    /// <inheritdoc cref="CpuParticles3D.GetMesh()" />
    public Mesh GetMesh() => ((CpuParticles3D)_host).GetMesh();

    /// <inheritdoc cref="CpuParticles3D.SetUseFixedSeed(bool)" />
    public void SetUseFixedSeed(bool @useFixedSeed) => ((CpuParticles3D)_host).SetUseFixedSeed(@useFixedSeed);

    /// <inheritdoc cref="CpuParticles3D.GetUseFixedSeed()" />
    public bool GetUseFixedSeed() => ((CpuParticles3D)_host).GetUseFixedSeed();

    /// <inheritdoc cref="CpuParticles3D.SetSeed(uint)" />
    public void SetSeed(uint @seed) => ((CpuParticles3D)_host).SetSeed(@seed);

    /// <inheritdoc cref="CpuParticles3D.GetSeed()" />
    public uint GetSeed() => ((CpuParticles3D)_host).GetSeed();

    /// <inheritdoc cref="CpuParticles3D.Restart(bool)" />
    public void Restart(bool @keepSeed) => ((CpuParticles3D)_host).Restart(@keepSeed);

    /// <inheritdoc cref="CpuParticles3D.RequestParticlesProcess(float)" />
    public void RequestParticlesProcess(float @processTime) => ((CpuParticles3D)_host).RequestParticlesProcess(@processTime);

    /// <inheritdoc cref="CpuParticles3D.CaptureAabb()" />
    public Aabb CaptureAabb() => ((CpuParticles3D)_host).CaptureAabb();

    /// <inheritdoc cref="CpuParticles3D.SetDirection(Vector3)" />
    public void SetDirection(Vector3 @direction) => ((CpuParticles3D)_host).SetDirection(@direction);

    /// <inheritdoc cref="CpuParticles3D.GetDirection()" />
    public Vector3 GetDirection() => ((CpuParticles3D)_host).GetDirection();

    /// <inheritdoc cref="CpuParticles3D.SetSpread(float)" />
    public void SetSpread(float @degrees) => ((CpuParticles3D)_host).SetSpread(@degrees);

    /// <inheritdoc cref="CpuParticles3D.GetSpread()" />
    public float GetSpread() => ((CpuParticles3D)_host).GetSpread();

    /// <inheritdoc cref="CpuParticles3D.SetFlatness(float)" />
    public void SetFlatness(float @amount) => ((CpuParticles3D)_host).SetFlatness(@amount);

    /// <inheritdoc cref="CpuParticles3D.GetFlatness()" />
    public float GetFlatness() => ((CpuParticles3D)_host).GetFlatness();

    /// <inheritdoc cref="CpuParticles3D.SetParamMin(CpuParticles3D.Parameter, float)" />
    public void SetParamMin(CpuParticles3D.Parameter @param, float @value) => ((CpuParticles3D)_host).SetParamMin(@param, @value);

    /// <inheritdoc cref="CpuParticles3D.GetParamMin(CpuParticles3D.Parameter)" />
    public float GetParamMin(CpuParticles3D.Parameter @param) => ((CpuParticles3D)_host).GetParamMin(@param);

    /// <inheritdoc cref="CpuParticles3D.SetParamMax(CpuParticles3D.Parameter, float)" />
    public void SetParamMax(CpuParticles3D.Parameter @param, float @value) => ((CpuParticles3D)_host).SetParamMax(@param, @value);

    /// <inheritdoc cref="CpuParticles3D.GetParamMax(CpuParticles3D.Parameter)" />
    public float GetParamMax(CpuParticles3D.Parameter @param) => ((CpuParticles3D)_host).GetParamMax(@param);

    /// <inheritdoc cref="CpuParticles3D.SetParamCurve(CpuParticles3D.Parameter, Curve)" />
    public void SetParamCurve(CpuParticles3D.Parameter @param, Curve @curve) => ((CpuParticles3D)_host).SetParamCurve(@param, @curve);

    /// <inheritdoc cref="CpuParticles3D.GetParamCurve(CpuParticles3D.Parameter)" />
    public Curve GetParamCurve(CpuParticles3D.Parameter @param) => ((CpuParticles3D)_host).GetParamCurve(@param);

    /// <inheritdoc cref="CpuParticles3D.SetColor(Color)" />
    public void SetColor(Color @color) => ((CpuParticles3D)_host).SetColor(@color);

    /// <inheritdoc cref="CpuParticles3D.GetColor()" />
    public Color GetColor() => ((CpuParticles3D)_host).GetColor();

    /// <inheritdoc cref="CpuParticles3D.SetColorRamp(Gradient)" />
    public void SetColorRamp(Gradient @ramp) => ((CpuParticles3D)_host).SetColorRamp(@ramp);

    /// <inheritdoc cref="CpuParticles3D.GetColorRamp()" />
    public Gradient GetColorRamp() => ((CpuParticles3D)_host).GetColorRamp();

    /// <inheritdoc cref="CpuParticles3D.SetColorInitialRamp(Gradient)" />
    public void SetColorInitialRamp(Gradient @ramp) => ((CpuParticles3D)_host).SetColorInitialRamp(@ramp);

    /// <inheritdoc cref="CpuParticles3D.GetColorInitialRamp()" />
    public Gradient GetColorInitialRamp() => ((CpuParticles3D)_host).GetColorInitialRamp();

    /// <inheritdoc cref="CpuParticles3D.SetParticleFlag(CpuParticles3D.ParticleFlags, bool)" />
    public void SetParticleFlag(CpuParticles3D.ParticleFlags @particleFlag, bool @enable) => ((CpuParticles3D)_host).SetParticleFlag(@particleFlag, @enable);

    /// <inheritdoc cref="CpuParticles3D.GetParticleFlag(CpuParticles3D.ParticleFlags)" />
    public bool GetParticleFlag(CpuParticles3D.ParticleFlags @particleFlag) => ((CpuParticles3D)_host).GetParticleFlag(@particleFlag);

    /// <inheritdoc cref="CpuParticles3D.SetEmissionShape(CpuParticles3D.EmissionShapeEnum)" />
    public void SetEmissionShape(CpuParticles3D.EmissionShapeEnum @shape) => ((CpuParticles3D)_host).SetEmissionShape(@shape);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionShape()" />
    public CpuParticles3D.EmissionShapeEnum GetEmissionShape() => ((CpuParticles3D)_host).GetEmissionShape();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionSphereRadius(float)" />
    public void SetEmissionSphereRadius(float @radius) => ((CpuParticles3D)_host).SetEmissionSphereRadius(@radius);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionSphereRadius()" />
    public float GetEmissionSphereRadius() => ((CpuParticles3D)_host).GetEmissionSphereRadius();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionBoxExtents(Vector3)" />
    public void SetEmissionBoxExtents(Vector3 @extents) => ((CpuParticles3D)_host).SetEmissionBoxExtents(@extents);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionBoxExtents()" />
    public Vector3 GetEmissionBoxExtents() => ((CpuParticles3D)_host).GetEmissionBoxExtents();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionPoints(Vector3[])" />
    public void SetEmissionPoints(Vector3[] @array) => ((CpuParticles3D)_host).SetEmissionPoints(@array);

    /// <inheritdoc cref="CpuParticles3D.SetEmissionPoints(ReadOnlySpan{Vector3})" />
    public void SetEmissionPoints(ReadOnlySpan<Vector3> @array) => ((CpuParticles3D)_host).SetEmissionPoints(@array);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionPoints()" />
    public Vector3[] GetEmissionPoints() => ((CpuParticles3D)_host).GetEmissionPoints();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionNormals(Vector3[])" />
    public void SetEmissionNormals(Vector3[] @array) => ((CpuParticles3D)_host).SetEmissionNormals(@array);

    /// <inheritdoc cref="CpuParticles3D.SetEmissionNormals(ReadOnlySpan{Vector3})" />
    public void SetEmissionNormals(ReadOnlySpan<Vector3> @array) => ((CpuParticles3D)_host).SetEmissionNormals(@array);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionNormals()" />
    public Vector3[] GetEmissionNormals() => ((CpuParticles3D)_host).GetEmissionNormals();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionColors(Color[])" />
    public void SetEmissionColors(Color[] @array) => ((CpuParticles3D)_host).SetEmissionColors(@array);

    /// <inheritdoc cref="CpuParticles3D.SetEmissionColors(ReadOnlySpan{Color})" />
    public void SetEmissionColors(ReadOnlySpan<Color> @array) => ((CpuParticles3D)_host).SetEmissionColors(@array);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionColors()" />
    public Color[] GetEmissionColors() => ((CpuParticles3D)_host).GetEmissionColors();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionRingAxis(Vector3)" />
    public void SetEmissionRingAxis(Vector3 @axis) => ((CpuParticles3D)_host).SetEmissionRingAxis(@axis);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionRingAxis()" />
    public Vector3 GetEmissionRingAxis() => ((CpuParticles3D)_host).GetEmissionRingAxis();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionRingHeight(float)" />
    public void SetEmissionRingHeight(float @height) => ((CpuParticles3D)_host).SetEmissionRingHeight(@height);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionRingHeight()" />
    public float GetEmissionRingHeight() => ((CpuParticles3D)_host).GetEmissionRingHeight();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionRingRadius(float)" />
    public void SetEmissionRingRadius(float @radius) => ((CpuParticles3D)_host).SetEmissionRingRadius(@radius);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionRingRadius()" />
    public float GetEmissionRingRadius() => ((CpuParticles3D)_host).GetEmissionRingRadius();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionRingInnerRadius(float)" />
    public void SetEmissionRingInnerRadius(float @innerRadius) => ((CpuParticles3D)_host).SetEmissionRingInnerRadius(@innerRadius);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionRingInnerRadius()" />
    public float GetEmissionRingInnerRadius() => ((CpuParticles3D)_host).GetEmissionRingInnerRadius();

    /// <inheritdoc cref="CpuParticles3D.SetEmissionRingConeAngle(float)" />
    public void SetEmissionRingConeAngle(float @coneAngle) => ((CpuParticles3D)_host).SetEmissionRingConeAngle(@coneAngle);

    /// <inheritdoc cref="CpuParticles3D.GetEmissionRingConeAngle()" />
    public float GetEmissionRingConeAngle() => ((CpuParticles3D)_host).GetEmissionRingConeAngle();

    /// <inheritdoc cref="CpuParticles3D.GetGravity()" />
    public Vector3 GetGravity() => ((CpuParticles3D)_host).GetGravity();

    /// <inheritdoc cref="CpuParticles3D.SetGravity(Vector3)" />
    public void SetGravity(Vector3 @accelVec) => ((CpuParticles3D)_host).SetGravity(@accelVec);

    /// <inheritdoc cref="CpuParticles3D.GetSplitScale()" />
    public bool GetSplitScale() => ((CpuParticles3D)_host).GetSplitScale();

    /// <inheritdoc cref="CpuParticles3D.SetSplitScale(bool)" />
    public void SetSplitScale(bool @splitScale) => ((CpuParticles3D)_host).SetSplitScale(@splitScale);

    /// <inheritdoc cref="CpuParticles3D.GetScaleCurveX()" />
    public Curve GetScaleCurveX() => ((CpuParticles3D)_host).GetScaleCurveX();

    /// <inheritdoc cref="CpuParticles3D.SetScaleCurveX(Curve)" />
    public void SetScaleCurveX(Curve @scaleCurve) => ((CpuParticles3D)_host).SetScaleCurveX(@scaleCurve);

    /// <inheritdoc cref="CpuParticles3D.GetScaleCurveY()" />
    public Curve GetScaleCurveY() => ((CpuParticles3D)_host).GetScaleCurveY();

    /// <inheritdoc cref="CpuParticles3D.SetScaleCurveY(Curve)" />
    public void SetScaleCurveY(Curve @scaleCurve) => ((CpuParticles3D)_host).SetScaleCurveY(@scaleCurve);

    /// <inheritdoc cref="CpuParticles3D.GetScaleCurveZ()" />
    public Curve GetScaleCurveZ() => ((CpuParticles3D)_host).GetScaleCurveZ();

    /// <inheritdoc cref="CpuParticles3D.SetScaleCurveZ(Curve)" />
    public void SetScaleCurveZ(Curve @scaleCurve) => ((CpuParticles3D)_host).SetScaleCurveZ(@scaleCurve);

    /// <inheritdoc cref="CpuParticles3D.ConvertFromParticles(Node)" />
    public void ConvertFromParticles(Node @particles) => ((CpuParticles3D)_host).ConvertFromParticles(@particles);

    /// <inheritdoc cref="CpuParticles3D.Restart()" />
    public void Restart() => ((CpuParticles3D)_host).Restart();

}
