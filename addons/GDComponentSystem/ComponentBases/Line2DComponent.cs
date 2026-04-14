#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Line2D" />
[Tool, GlobalClass]
public abstract partial class Line2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Line2D.SetPoints(Vector2[])" />
    public void SetPoints(Vector2[] @points) => ((Line2D)_host).SetPoints(@points);

    /// <inheritdoc cref="Line2D.SetPoints(ReadOnlySpan{Vector2})" />
    public void SetPoints(ReadOnlySpan<Vector2> @points) => ((Line2D)_host).SetPoints(@points);

    /// <inheritdoc cref="Line2D.GetPoints()" />
    public Vector2[] GetPoints() => ((Line2D)_host).GetPoints();

    /// <inheritdoc cref="Line2D.SetPointPosition(int, Vector2)" />
    public void SetPointPosition(int @index, Vector2 @position) => ((Line2D)_host).SetPointPosition(@index, @position);

    /// <inheritdoc cref="Line2D.GetPointPosition(int)" />
    public Vector2 GetPointPosition(int @index) => ((Line2D)_host).GetPointPosition(@index);

    /// <inheritdoc cref="Line2D.GetPointCount()" />
    public int GetPointCount() => ((Line2D)_host).GetPointCount();

    /// <inheritdoc cref="Line2D.AddPoint(Vector2, int)" />
    public void AddPoint(Vector2 @position, int @index) => ((Line2D)_host).AddPoint(@position, @index);

    /// <inheritdoc cref="Line2D.RemovePoint(int)" />
    public void RemovePoint(int @index) => ((Line2D)_host).RemovePoint(@index);

    /// <inheritdoc cref="Line2D.ClearPoints()" />
    public void ClearPoints() => ((Line2D)_host).ClearPoints();

    /// <inheritdoc cref="Line2D.SetClosed(bool)" />
    public void SetClosed(bool @closed) => ((Line2D)_host).SetClosed(@closed);

    /// <inheritdoc cref="Line2D.IsClosed()" />
    public bool IsClosed() => ((Line2D)_host).IsClosed();

    /// <inheritdoc cref="Line2D.SetWidth(float)" />
    public void SetWidth(float @width) => ((Line2D)_host).SetWidth(@width);

    /// <inheritdoc cref="Line2D.GetWidth()" />
    public float GetWidth() => ((Line2D)_host).GetWidth();

    /// <inheritdoc cref="Line2D.SetCurve(Curve)" />
    public void SetCurve(Curve @curve) => ((Line2D)_host).SetCurve(@curve);

    /// <inheritdoc cref="Line2D.GetCurve()" />
    public Curve GetCurve() => ((Line2D)_host).GetCurve();

    /// <inheritdoc cref="Line2D.SetDefaultColor(Color)" />
    public void SetDefaultColor(Color @color) => ((Line2D)_host).SetDefaultColor(@color);

    /// <inheritdoc cref="Line2D.GetDefaultColor()" />
    public Color GetDefaultColor() => ((Line2D)_host).GetDefaultColor();

    /// <inheritdoc cref="Line2D.SetGradient(Gradient)" />
    public void SetGradient(Gradient @color) => ((Line2D)_host).SetGradient(@color);

    /// <inheritdoc cref="Line2D.GetGradient()" />
    public Gradient GetGradient() => ((Line2D)_host).GetGradient();

    /// <inheritdoc cref="Line2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((Line2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="Line2D.GetTexture()" />
    public Texture2D GetTexture() => ((Line2D)_host).GetTexture();

    /// <inheritdoc cref="Line2D.SetTextureMode(Line2D.LineTextureMode)" />
    public void SetTextureMode(Line2D.LineTextureMode @mode) => ((Line2D)_host).SetTextureMode(@mode);

    /// <inheritdoc cref="Line2D.GetTextureMode()" />
    public Line2D.LineTextureMode GetTextureMode() => ((Line2D)_host).GetTextureMode();

    /// <inheritdoc cref="Line2D.SetJointMode(Line2D.LineJointMode)" />
    public void SetJointMode(Line2D.LineJointMode @mode) => ((Line2D)_host).SetJointMode(@mode);

    /// <inheritdoc cref="Line2D.GetJointMode()" />
    public Line2D.LineJointMode GetJointMode() => ((Line2D)_host).GetJointMode();

    /// <inheritdoc cref="Line2D.SetBeginCapMode(Line2D.LineCapMode)" />
    public void SetBeginCapMode(Line2D.LineCapMode @mode) => ((Line2D)_host).SetBeginCapMode(@mode);

    /// <inheritdoc cref="Line2D.GetBeginCapMode()" />
    public Line2D.LineCapMode GetBeginCapMode() => ((Line2D)_host).GetBeginCapMode();

    /// <inheritdoc cref="Line2D.SetEndCapMode(Line2D.LineCapMode)" />
    public void SetEndCapMode(Line2D.LineCapMode @mode) => ((Line2D)_host).SetEndCapMode(@mode);

    /// <inheritdoc cref="Line2D.GetEndCapMode()" />
    public Line2D.LineCapMode GetEndCapMode() => ((Line2D)_host).GetEndCapMode();

    /// <inheritdoc cref="Line2D.SetSharpLimit(float)" />
    public void SetSharpLimit(float @limit) => ((Line2D)_host).SetSharpLimit(@limit);

    /// <inheritdoc cref="Line2D.GetSharpLimit()" />
    public float GetSharpLimit() => ((Line2D)_host).GetSharpLimit();

    /// <inheritdoc cref="Line2D.SetRoundPrecision(int)" />
    public void SetRoundPrecision(int @precision) => ((Line2D)_host).SetRoundPrecision(@precision);

    /// <inheritdoc cref="Line2D.GetRoundPrecision()" />
    public int GetRoundPrecision() => ((Line2D)_host).GetRoundPrecision();

    /// <inheritdoc cref="Line2D.SetAntialiased(bool)" />
    public void SetAntialiased(bool @antialiased) => ((Line2D)_host).SetAntialiased(@antialiased);

    /// <inheritdoc cref="Line2D.GetAntialiased()" />
    public bool GetAntialiased() => ((Line2D)_host).GetAntialiased();

}
