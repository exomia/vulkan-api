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

    /// <summary>VK_FILTER_CUBIC_EXT specifies cubic filtering.</summary>
    VK_FILTER_CUBIC_EXT = 1000015000,

    /// <summary>VK_FILTER_CUBIC_EXT specifies cubic filtering.</summary>
    VK_FILTER_CUBIC_IMG = VK_FILTER_CUBIC_EXT
}