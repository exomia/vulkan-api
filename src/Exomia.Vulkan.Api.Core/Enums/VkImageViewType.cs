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
///     VkImageViewType - Image view types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewType.html </a>
/// </summary>
public enum VkImageViewType
{
    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_1D<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_1D = 0,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_2D<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_2D = 1,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_3D<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_3D = 2,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_CUBE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_CUBE = 3,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_1D_ARRAY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_1D_ARRAY = 4,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_2D_ARRAY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_2D_ARRAY = 5,

    /// <summary>
    ///     VK_IMAGE_VIEW_TYPE_CUBE_ARRAY<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkImageViewType </a>
    /// </summary>
    VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = 6
}