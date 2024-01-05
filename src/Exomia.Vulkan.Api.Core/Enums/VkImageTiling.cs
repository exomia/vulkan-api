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
///     VkImageTiling - Specifies the tiling arrangement of data in an image -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageTiling.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageTiling.html</a>
/// </summary>
public enum VkImageTiling
{
    /// <summary>
    ///     VK_IMAGE_TILING_OPTIMAL specifies optimal tiling (texels are laid out in an implementation-dependent
    ///     arrangement, for more efficient memory access).
    /// </summary>
    VK_IMAGE_TILING_OPTIMAL = 0,

    /// <summary>
    ///     VK_IMAGE_TILING_LINEAR specifies linear tiling (texels are laid out in memory in row-major order, possibly
    ///     with some padding on each row).
    /// </summary>
    VK_IMAGE_TILING_LINEAR = 1,

    /// <summary>
    ///     VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT indicates that the image&#8217;s tiling is defined by a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#glossary-drm-format-modifier">
    ///         Linux
    ///         DRM format modifier
    ///     </a>
    ///     . The modifier is specified at image creation with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierListCreateInfoEXT.html">
    ///         VkImageDrmFormatModifierListCreateInfoEXT
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageDrmFormatModifierExplicitCreateInfoEXT.html">
    ///         VkImageDrmFormatModifierExplicitCreateInfoEXT
    ///     </a>
    ///     , and can be queried with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageDrmFormatModifierPropertiesEXT.html">
    ///         vkGetImageDrmFormatModifierPropertiesEXT
    ///     </a>
    ///     .
    /// </summary>
    VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = 1000158000
}