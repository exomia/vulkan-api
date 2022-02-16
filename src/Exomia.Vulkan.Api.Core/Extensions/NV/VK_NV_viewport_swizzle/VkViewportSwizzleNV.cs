#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkViewportSwizzleNV - Structure specifying a viewport swizzle -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportSwizzleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportSwizzleNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkViewportSwizzleNV
{
    /// <summary>
    ///     x is a VkViewportCoordinateSwizzleNV value specifying the swizzle operation to apply to the x component of the
    ///     primitive
    /// </summary>
    public VkViewportCoordinateSwizzleNV x;

    /// <summary>
    ///     y is a VkViewportCoordinateSwizzleNV value specifying the swizzle operation to apply to the y component of the
    ///     primitive
    /// </summary>
    public VkViewportCoordinateSwizzleNV y;

    /// <summary>
    ///     z is a VkViewportCoordinateSwizzleNV value specifying the swizzle operation to apply to the z component of the
    ///     primitive
    /// </summary>
    public VkViewportCoordinateSwizzleNV z;

    /// <summary>
    ///     w is a VkViewportCoordinateSwizzleNV value specifying the swizzle operation to apply to the w component of the
    ///     primitive
    /// </summary>
    public VkViewportCoordinateSwizzleNV w;
}