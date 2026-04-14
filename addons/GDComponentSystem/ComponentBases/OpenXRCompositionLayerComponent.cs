#nullable disable

using System;
using Godot.Components.Hosts;
using Godot.Collections;
using Godot;
using Array = Godot.Collections.Array;

namespace Godot.Components;

/// <inheritdoc cref="OpenXRCompositionLayer" />
[Tool, GlobalClass]
public abstract partial class OpenXRCompositionLayerComponent : Node3DComponent
{

    /// <inheritdoc cref="OpenXRCompositionLayer.SetLayerViewport(SubViewport)" />
    public void SetLayerViewport(SubViewport @viewport) => ((OpenXRCompositionLayer)_host).SetLayerViewport(@viewport);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetLayerViewport()" />
    public SubViewport GetLayerViewport() => ((OpenXRCompositionLayer)_host).GetLayerViewport();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetUseAndroidSurface(bool)" />
    public void SetUseAndroidSurface(bool @enable) => ((OpenXRCompositionLayer)_host).SetUseAndroidSurface(@enable);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetUseAndroidSurface()" />
    public bool GetUseAndroidSurface() => ((OpenXRCompositionLayer)_host).GetUseAndroidSurface();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetAndroidSurfaceSize(Vector2I)" />
    public void SetAndroidSurfaceSize(Vector2I @size) => ((OpenXRCompositionLayer)_host).SetAndroidSurfaceSize(@size);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetAndroidSurfaceSize()" />
    public Vector2I GetAndroidSurfaceSize() => ((OpenXRCompositionLayer)_host).GetAndroidSurfaceSize();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetEnableHolePunch(bool)" />
    public void SetEnableHolePunch(bool @enable) => ((OpenXRCompositionLayer)_host).SetEnableHolePunch(@enable);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetEnableHolePunch()" />
    public bool GetEnableHolePunch() => ((OpenXRCompositionLayer)_host).GetEnableHolePunch();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetSortOrder(int)" />
    public void SetSortOrder(int @order) => ((OpenXRCompositionLayer)_host).SetSortOrder(@order);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetSortOrder()" />
    public int GetSortOrder() => ((OpenXRCompositionLayer)_host).GetSortOrder();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetAlphaBlend(bool)" />
    public void SetAlphaBlend(bool @enabled) => ((OpenXRCompositionLayer)_host).SetAlphaBlend(@enabled);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetAlphaBlend()" />
    public bool GetAlphaBlend() => ((OpenXRCompositionLayer)_host).GetAlphaBlend();

    /// <inheritdoc cref="OpenXRCompositionLayer.GetAndroidSurface()" />
    public JavaObject GetAndroidSurface() => ((OpenXRCompositionLayer)_host).GetAndroidSurface();

    /// <inheritdoc cref="OpenXRCompositionLayer.IsNativelySupported()" />
    public bool IsNativelySupported() => ((OpenXRCompositionLayer)_host).IsNativelySupported();

    /// <inheritdoc cref="OpenXRCompositionLayer.IsProtectedContent()" />
    public bool IsProtectedContent() => ((OpenXRCompositionLayer)_host).IsProtectedContent();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetProtectedContent(bool)" />
    public void SetProtectedContent(bool @protectedContent) => ((OpenXRCompositionLayer)_host).SetProtectedContent(@protectedContent);

    /// <inheritdoc cref="OpenXRCompositionLayer.SetMinFilter(OpenXRCompositionLayer.Filter)" />
    public void SetMinFilter(OpenXRCompositionLayer.Filter @mode) => ((OpenXRCompositionLayer)_host).SetMinFilter(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetMinFilter()" />
    public OpenXRCompositionLayer.Filter GetMinFilter() => ((OpenXRCompositionLayer)_host).GetMinFilter();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetMagFilter(OpenXRCompositionLayer.Filter)" />
    public void SetMagFilter(OpenXRCompositionLayer.Filter @mode) => ((OpenXRCompositionLayer)_host).SetMagFilter(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetMagFilter()" />
    public OpenXRCompositionLayer.Filter GetMagFilter() => ((OpenXRCompositionLayer)_host).GetMagFilter();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetMipmapMode(OpenXRCompositionLayer.MipmapMode)" />
    public void SetMipmapMode(OpenXRCompositionLayer.MipmapMode @mode) => ((OpenXRCompositionLayer)_host).SetMipmapMode(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetMipmapMode()" />
    public OpenXRCompositionLayer.MipmapMode GetMipmapMode() => ((OpenXRCompositionLayer)_host).GetMipmapMode();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetHorizontalWrap(OpenXRCompositionLayer.Wrap)" />
    public void SetHorizontalWrap(OpenXRCompositionLayer.Wrap @mode) => ((OpenXRCompositionLayer)_host).SetHorizontalWrap(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetHorizontalWrap()" />
    public OpenXRCompositionLayer.Wrap GetHorizontalWrap() => ((OpenXRCompositionLayer)_host).GetHorizontalWrap();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetVerticalWrap(OpenXRCompositionLayer.Wrap)" />
    public void SetVerticalWrap(OpenXRCompositionLayer.Wrap @mode) => ((OpenXRCompositionLayer)_host).SetVerticalWrap(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetVerticalWrap()" />
    public OpenXRCompositionLayer.Wrap GetVerticalWrap() => ((OpenXRCompositionLayer)_host).GetVerticalWrap();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetRedSwizzle(OpenXRCompositionLayer.Swizzle)" />
    public void SetRedSwizzle(OpenXRCompositionLayer.Swizzle @mode) => ((OpenXRCompositionLayer)_host).SetRedSwizzle(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetRedSwizzle()" />
    public OpenXRCompositionLayer.Swizzle GetRedSwizzle() => ((OpenXRCompositionLayer)_host).GetRedSwizzle();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetGreenSwizzle(OpenXRCompositionLayer.Swizzle)" />
    public void SetGreenSwizzle(OpenXRCompositionLayer.Swizzle @mode) => ((OpenXRCompositionLayer)_host).SetGreenSwizzle(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetGreenSwizzle()" />
    public OpenXRCompositionLayer.Swizzle GetGreenSwizzle() => ((OpenXRCompositionLayer)_host).GetGreenSwizzle();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetBlueSwizzle(OpenXRCompositionLayer.Swizzle)" />
    public void SetBlueSwizzle(OpenXRCompositionLayer.Swizzle @mode) => ((OpenXRCompositionLayer)_host).SetBlueSwizzle(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetBlueSwizzle()" />
    public OpenXRCompositionLayer.Swizzle GetBlueSwizzle() => ((OpenXRCompositionLayer)_host).GetBlueSwizzle();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetAlphaSwizzle(OpenXRCompositionLayer.Swizzle)" />
    public void SetAlphaSwizzle(OpenXRCompositionLayer.Swizzle @mode) => ((OpenXRCompositionLayer)_host).SetAlphaSwizzle(@mode);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetAlphaSwizzle()" />
    public OpenXRCompositionLayer.Swizzle GetAlphaSwizzle() => ((OpenXRCompositionLayer)_host).GetAlphaSwizzle();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetMaxAnisotropy(float)" />
    public void SetMaxAnisotropy(float @value) => ((OpenXRCompositionLayer)_host).SetMaxAnisotropy(@value);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetMaxAnisotropy()" />
    public float GetMaxAnisotropy() => ((OpenXRCompositionLayer)_host).GetMaxAnisotropy();

    /// <inheritdoc cref="OpenXRCompositionLayer.SetBorderColor(Color)" />
    public void SetBorderColor(Color @color) => ((OpenXRCompositionLayer)_host).SetBorderColor(@color);

    /// <inheritdoc cref="OpenXRCompositionLayer.GetBorderColor()" />
    public Color GetBorderColor() => ((OpenXRCompositionLayer)_host).GetBorderColor();

    /// <inheritdoc cref="OpenXRCompositionLayer.IntersectsRay(Vector3, Vector3)" />
    public Vector2 IntersectsRay(Vector3 @origin, Vector3 @direction) => ((OpenXRCompositionLayer)_host).IntersectsRay(@origin, @direction);

}
