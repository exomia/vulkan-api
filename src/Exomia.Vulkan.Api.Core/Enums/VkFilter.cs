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
///     VkFilter - Specify filters used for texture lookups -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFilter.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFilter.html</a>
/// </summary>
public enum VkFilter
{
    /// <summary>VK_FILTER_NEAREST specifies nearest filtering.</summary>
    VK_FILTER_NEAREST = 0,

    /// <summary>VK_FILTER_LINEAR specifies linear filtering.</summary>
    VK_FILTER_LINEAR = 1,

    /// <summary>
    ///     VK_FILTER_CUBIC_IMG<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFilter">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFilter</a>
    /// </summary>
    VK_FILTER_CUBIC_IMG = 1000015000,

    /// <summary>
    ///     VK_FILTER_CUBIC_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFilter">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkFilter</a>
    /// </summary>
    VK_FILTER_CUBIC_EXT = VK_FILTER_CUBIC_IMG
}