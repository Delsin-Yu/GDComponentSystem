#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="Polygon2D" />
[Tool, GlobalClass]
public abstract partial class Polygon2DComponent : Node2DComponent
{

    /// <inheritdoc cref="Polygon2D.SetPolygon(Vector2[])" />
    public void SetPolygon(Vector2[] @polygon) => ((Polygon2D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="Polygon2D.SetPolygon(ReadOnlySpan{Vector2})" />
    public void SetPolygon(ReadOnlySpan<Vector2> @polygon) => ((Polygon2D)_host).SetPolygon(@polygon);

    /// <inheritdoc cref="Polygon2D.GetPolygon()" />
    public Vector2[] GetPolygon() => ((Polygon2D)_host).GetPolygon();

    /// <inheritdoc cref="Polygon2D.SetUV(Vector2[])" />
    public void SetUV(Vector2[] @uV) => ((Polygon2D)_host).SetUV(@uV);

    /// <inheritdoc cref="Polygon2D.SetUV(ReadOnlySpan{Vector2})" />
    public void SetUV(ReadOnlySpan<Vector2> @uV) => ((Polygon2D)_host).SetUV(@uV);

    /// <inheritdoc cref="Polygon2D.GetUV()" />
    public Vector2[] GetUV() => ((Polygon2D)_host).GetUV();

    /// <inheritdoc cref="Polygon2D.SetColor(Color)" />
    public void SetColor(Color @color) => ((Polygon2D)_host).SetColor(@color);

    /// <inheritdoc cref="Polygon2D.GetColor()" />
    public Color GetColor() => ((Polygon2D)_host).GetColor();

    /// <inheritdoc cref="Polygon2D.SetPolygons(Array)" />
    public void SetPolygons(Array @polygons) => ((Polygon2D)_host).SetPolygons(@polygons);

    /// <inheritdoc cref="Polygon2D.GetPolygons()" />
    public Array GetPolygons() => ((Polygon2D)_host).GetPolygons();

    /// <inheritdoc cref="Polygon2D.SetVertexColors(Color[])" />
    public void SetVertexColors(Color[] @vertexColors) => ((Polygon2D)_host).SetVertexColors(@vertexColors);

    /// <inheritdoc cref="Polygon2D.SetVertexColors(ReadOnlySpan{Color})" />
    public void SetVertexColors(ReadOnlySpan<Color> @vertexColors) => ((Polygon2D)_host).SetVertexColors(@vertexColors);

    /// <inheritdoc cref="Polygon2D.GetVertexColors()" />
    public Color[] GetVertexColors() => ((Polygon2D)_host).GetVertexColors();

    /// <inheritdoc cref="Polygon2D.SetTexture(Texture2D)" />
    public void SetTexture(Texture2D @texture) => ((Polygon2D)_host).SetTexture(@texture);

    /// <inheritdoc cref="Polygon2D.GetTexture()" />
    public Texture2D GetTexture() => ((Polygon2D)_host).GetTexture();

    /// <inheritdoc cref="Polygon2D.SetTextureOffset(Vector2)" />
    public void SetTextureOffset(Vector2 @textureOffset) => ((Polygon2D)_host).SetTextureOffset(@textureOffset);

    /// <inheritdoc cref="Polygon2D.GetTextureOffset()" />
    public Vector2 GetTextureOffset() => ((Polygon2D)_host).GetTextureOffset();

    /// <inheritdoc cref="Polygon2D.SetTextureRotation(float)" />
    public void SetTextureRotation(float @textureRotation) => ((Polygon2D)_host).SetTextureRotation(@textureRotation);

    /// <inheritdoc cref="Polygon2D.GetTextureRotation()" />
    public float GetTextureRotation() => ((Polygon2D)_host).GetTextureRotation();

    /// <inheritdoc cref="Polygon2D.SetTextureScale(Vector2)" />
    public void SetTextureScale(Vector2 @textureScale) => ((Polygon2D)_host).SetTextureScale(@textureScale);

    /// <inheritdoc cref="Polygon2D.GetTextureScale()" />
    public Vector2 GetTextureScale() => ((Polygon2D)_host).GetTextureScale();

    /// <inheritdoc cref="Polygon2D.SetInvertEnabled(bool)" />
    public void SetInvertEnabled(bool @invert) => ((Polygon2D)_host).SetInvertEnabled(@invert);

    /// <inheritdoc cref="Polygon2D.GetInvertEnabled()" />
    public bool GetInvertEnabled() => ((Polygon2D)_host).GetInvertEnabled();

    /// <inheritdoc cref="Polygon2D.SetAntialiased(bool)" />
    public void SetAntialiased(bool @antialiased) => ((Polygon2D)_host).SetAntialiased(@antialiased);

    /// <inheritdoc cref="Polygon2D.GetAntialiased()" />
    public bool GetAntialiased() => ((Polygon2D)_host).GetAntialiased();

    /// <inheritdoc cref="Polygon2D.SetInvertBorder(float)" />
    public void SetInvertBorder(float @invertBorder) => ((Polygon2D)_host).SetInvertBorder(@invertBorder);

    /// <inheritdoc cref="Polygon2D.GetInvertBorder()" />
    public float GetInvertBorder() => ((Polygon2D)_host).GetInvertBorder();

    /// <inheritdoc cref="Polygon2D.SetOffset(Vector2)" />
    public void SetOffset(Vector2 @offset) => ((Polygon2D)_host).SetOffset(@offset);

    /// <inheritdoc cref="Polygon2D.GetOffset()" />
    public Vector2 GetOffset() => ((Polygon2D)_host).GetOffset();

    /// <inheritdoc cref="Polygon2D.AddBone(NodePath, float[])" />
    public void AddBone(NodePath @path, float[] @weights) => ((Polygon2D)_host).AddBone(@path, @weights);

    /// <inheritdoc cref="Polygon2D.AddBone(NodePath, ReadOnlySpan{float})" />
    public void AddBone(NodePath @path, ReadOnlySpan<float> @weights) => ((Polygon2D)_host).AddBone(@path, @weights);

    /// <inheritdoc cref="Polygon2D.GetBoneCount()" />
    public int GetBoneCount() => ((Polygon2D)_host).GetBoneCount();

    /// <inheritdoc cref="Polygon2D.GetBonePath(int)" />
    public NodePath GetBonePath(int @index) => ((Polygon2D)_host).GetBonePath(@index);

    /// <inheritdoc cref="Polygon2D.GetBoneWeights(int)" />
    public float[] GetBoneWeights(int @index) => ((Polygon2D)_host).GetBoneWeights(@index);

    /// <inheritdoc cref="Polygon2D.EraseBone(int)" />
    public void EraseBone(int @index) => ((Polygon2D)_host).EraseBone(@index);

    /// <inheritdoc cref="Polygon2D.ClearBones()" />
    public void ClearBones() => ((Polygon2D)_host).ClearBones();

    /// <inheritdoc cref="Polygon2D.SetBonePath(int, NodePath)" />
    public void SetBonePath(int @index, NodePath @path) => ((Polygon2D)_host).SetBonePath(@index, @path);

    /// <inheritdoc cref="Polygon2D.SetBoneWeights(int, float[])" />
    public void SetBoneWeights(int @index, float[] @weights) => ((Polygon2D)_host).SetBoneWeights(@index, @weights);

    /// <inheritdoc cref="Polygon2D.SetBoneWeights(int, ReadOnlySpan{float})" />
    public void SetBoneWeights(int @index, ReadOnlySpan<float> @weights) => ((Polygon2D)_host).SetBoneWeights(@index, @weights);

    /// <inheritdoc cref="Polygon2D.SetSkeleton(NodePath)" />
    public void SetSkeleton(NodePath @skeleton) => ((Polygon2D)_host).SetSkeleton(@skeleton);

    /// <inheritdoc cref="Polygon2D.GetSkeleton()" />
    public NodePath GetSkeleton() => ((Polygon2D)_host).GetSkeleton();

    /// <inheritdoc cref="Polygon2D.SetInternalVertexCount(int)" />
    public void SetInternalVertexCount(int @internalVertexCount) => ((Polygon2D)_host).SetInternalVertexCount(@internalVertexCount);

    /// <inheritdoc cref="Polygon2D.GetInternalVertexCount()" />
    public int GetInternalVertexCount() => ((Polygon2D)_host).GetInternalVertexCount();

}
