#region License

// Copyright (c) 2018-2024, exomia
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
///     VkViewportCoordinateSwizzleNV - Specify how a viewport coordinate is swizzled -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportCoordinateSwizzleNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViewportCoordinateSwizzleNV.html</a>
/// </summary>
public enum VkViewportCoordinateSwizzleNV
{
    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,

    /// <summary>
    ///     VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkViewportCoordinateSwizzleNV
    ///     </a>
    /// </summary>
    VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7
}