#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="MeshInstance3D" />
[Tool, GlobalClass]
public abstract partial class MeshInstance3DComponent : GeometryInstance3DComponent
{

    /// <inheritdoc cref="MeshInstance3D.CreateMultipleConvexCollisions()" />
    public void CreateMultipleConvexCollisions() => ((MeshInstance3D)_host).CreateMultipleConvexCollisions();

    /// <inheritdoc cref="MeshInstance3D.SetMesh(Mesh)" />
    public void SetMesh(Mesh @mesh) => ((MeshInstance3D)_host).SetMesh(@mesh);

    /// <inheritdoc cref="MeshInstance3D.GetMesh()" />
    public Mesh GetMesh() => ((MeshInstance3D)_host).GetMesh();

    /// <inheritdoc cref="MeshInstance3D.SetSkeletonPath(NodePath)" />
    public void SetSkeletonPath(NodePath @skeletonPath) => ((MeshInstance3D)_host).SetSkeletonPath(@skeletonPath);

    /// <inheritdoc cref="MeshInstance3D.GetSkeletonPath()" />
    public NodePath GetSkeletonPath() => ((MeshInstance3D)_host).GetSkeletonPath();

    /// <inheritdoc cref="MeshInstance3D.SetSkin(Skin)" />
    public void SetSkin(Skin @skin) => ((MeshInstance3D)_host).SetSkin(@skin);

    /// <inheritdoc cref="MeshInstance3D.GetSkin()" />
    public Skin GetSkin() => ((MeshInstance3D)_host).GetSkin();

    /// <inheritdoc cref="MeshInstance3D.GetSkinReference()" />
    public SkinReference GetSkinReference() => ((MeshInstance3D)_host).GetSkinReference();

    /// <inheritdoc cref="MeshInstance3D.GetSurfaceOverrideMaterialCount()" />
    public int GetSurfaceOverrideMaterialCount() => ((MeshInstance3D)_host).GetSurfaceOverrideMaterialCount();

    /// <inheritdoc cref="MeshInstance3D.SetSurfaceOverrideMaterial(int, Material)" />
    public void SetSurfaceOverrideMaterial(int @surface, Material @material) => ((MeshInstance3D)_host).SetSurfaceOverrideMaterial(@surface, @material);

    /// <inheritdoc cref="MeshInstance3D.GetSurfaceOverrideMaterial(int)" />
    public Material GetSurfaceOverrideMaterial(int @surface) => ((MeshInstance3D)_host).GetSurfaceOverrideMaterial(@surface);

    /// <inheritdoc cref="MeshInstance3D.GetActiveMaterial(int)" />
    public Material GetActiveMaterial(int @surface) => ((MeshInstance3D)_host).GetActiveMaterial(@surface);

    /// <inheritdoc cref="MeshInstance3D.CreateTrimeshCollision()" />
    public void CreateTrimeshCollision() => ((MeshInstance3D)_host).CreateTrimeshCollision();

    /// <inheritdoc cref="MeshInstance3D.CreateConvexCollision(bool, bool)" />
    public void CreateConvexCollision(bool @clean, bool @simplify) => ((MeshInstance3D)_host).CreateConvexCollision(@clean, @simplify);

    /// <inheritdoc cref="MeshInstance3D.CreateMultipleConvexCollisions(MeshConvexDecompositionSettings)" />
    public void CreateMultipleConvexCollisions(MeshConvexDecompositionSettings @settings) => ((MeshInstance3D)_host).CreateMultipleConvexCollisions(@settings);

    /// <inheritdoc cref="MeshInstance3D.GetBlendShapeCount()" />
    public int GetBlendShapeCount() => ((MeshInstance3D)_host).GetBlendShapeCount();

    /// <inheritdoc cref="MeshInstance3D.FindBlendShapeByName(StringName)" />
    public int FindBlendShapeByName(StringName @name) => ((MeshInstance3D)_host).FindBlendShapeByName(@name);

    /// <inheritdoc cref="MeshInstance3D.GetBlendShapeValue(int)" />
    public float GetBlendShapeValue(int @blendShapeIdx) => ((MeshInstance3D)_host).GetBlendShapeValue(@blendShapeIdx);

    /// <inheritdoc cref="MeshInstance3D.SetBlendShapeValue(int, float)" />
    public void SetBlendShapeValue(int @blendShapeIdx, float @value) => ((MeshInstance3D)_host).SetBlendShapeValue(@blendShapeIdx, @value);

    /// <inheritdoc cref="MeshInstance3D.CreateDebugTangents()" />
    public void CreateDebugTangents() => ((MeshInstance3D)_host).CreateDebugTangents();

    /// <inheritdoc cref="MeshInstance3D.BakeMeshFromCurrentBlendShapeMix(ArrayMesh)" />
    public ArrayMesh BakeMeshFromCurrentBlendShapeMix(ArrayMesh @existing) => ((MeshInstance3D)_host).BakeMeshFromCurrentBlendShapeMix(@existing);

    /// <inheritdoc cref="MeshInstance3D.BakeMeshFromCurrentSkeletonPose(ArrayMesh)" />
    public ArrayMesh BakeMeshFromCurrentSkeletonPose(ArrayMesh @existing) => ((MeshInstance3D)_host).BakeMeshFromCurrentSkeletonPose(@existing);

}
