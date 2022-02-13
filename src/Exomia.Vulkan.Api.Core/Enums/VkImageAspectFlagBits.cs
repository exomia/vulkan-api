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
///     VkImageAspectFlagBits - Bitmask specifying which aspects of an image are included in a view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageAspectFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageAspectFlagBits.html</a>
/// </summary>
[Flags]
public enum VkImageAspectFlagBits
{
    /// <summary>VK_IMAGE_ASPECT_COLOR_BIT specifies the color aspect.</summary>
    VK_IMAGE_ASPECT_COLOR_BIT = 0x1,

    /// <summary>VK_IMAGE_ASPECT_DEPTH_BIT specifies the depth aspect.</summary>
    VK_IMAGE_ASPECT_DEPTH_BIT = 0x2,

    /// <summary>VK_IMAGE_ASPECT_STENCIL_BIT specifies the stencil aspect.</summary>
    VK_IMAGE_ASPECT_STENCIL_BIT = 0x4,

    /// <summary>
    ///     VK_IMAGE_ASPECT_METADATA_BIT specifies the metadata aspect, used for
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#sparsememory">
    ///         sparse
    ///         resource
    ///     </a>
    ///     operations.
    /// </summary>
    VK_IMAGE_ASPECT_METADATA_BIT = 0x8,

    /// <summary>VK_IMAGE_ASPECT_PLANE_0_BIT specifies plane 0 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_0_BIT = 0x10,

    /// <summary>VK_IMAGE_ASPECT_PLANE_1_BIT specifies plane 1 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_1_BIT = 0x20,

    /// <summary>VK_IMAGE_ASPECT_PLANE_2_BIT specifies plane 2 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_2_BIT = 0x40,

    /// <summary>VK_IMAGE_ASPECT_NONE specifies no image aspect, or the image aspect is not applicable.</summary>
    VK_IMAGE_ASPECT_NONE = 0,

    /// <summary>VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT specifies memory plane 0.</summary>
    VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = 0x80,

    /// <summary>VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT specifies memory plane 1.</summary>
    VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = 0x100,

    /// <summary>VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT specifies memory plane 2.</summary>
    VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = 0x200,

    /// <summary>VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT specifies memory plane 3.</summary>
    VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = 0x400,

    /// <summary>VK_IMAGE_ASPECT_PLANE_0_BIT specifies plane 0 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_0_BIT_KHR = VK_IMAGE_ASPECT_PLANE_0_BIT,

    /// <summary>VK_IMAGE_ASPECT_PLANE_1_BIT specifies plane 1 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_1_BIT_KHR = VK_IMAGE_ASPECT_PLANE_1_BIT,

    /// <summary>VK_IMAGE_ASPECT_PLANE_2_BIT specifies plane 2 of a multi-planarimage format.</summary>
    VK_IMAGE_ASPECT_PLANE_2_BIT_KHR = VK_IMAGE_ASPECT_PLANE_2_BIT,

    /// <summary>VK_IMAGE_ASPECT_NONE specifies no image aspect, or the image aspect is not applicable.</summary>
    VK_IMAGE_ASPECT_NONE_KHR = VK_IMAGE_ASPECT_NONE
}