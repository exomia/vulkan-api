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
///     VkResolveModeFlagBits - Bitmask indicating supported depth and stencil resolve modes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResolveModeFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResolveModeFlagBits.html</a>
/// </summary>
[Flags]
public enum VkResolveModeFlagBits
{
    /// <summary>VK_RESOLVE_MODE_NONE indicates that no resolve operation is done.</summary>
    VK_RESOLVE_MODE_NONE = 0,

    /// <summary>
    ///     VK_RESOLVE_MODE_SAMPLE_ZERO_BIT indicates that result of the resolve operation is equal to the value of sample
    ///     0.
    /// </summary>
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 1 << 0,

    /// <summary>
    ///     VK_RESOLVE_MODE_AVERAGE_BIT indicates that result of the resolve operation is the average of the sample
    ///     values.
    /// </summary>
    VK_RESOLVE_MODE_AVERAGE_BIT = 1 << 1,

    /// <summary>VK_RESOLVE_MODE_MIN_BIT indicates that result of the resolve operation is the minimum of the sample values.</summary>
    VK_RESOLVE_MODE_MIN_BIT = 1 << 2,

    /// <summary>VK_RESOLVE_MODE_MAX_BIT indicates that result of the resolve operation is the maximum of the sample values.</summary>
    VK_RESOLVE_MODE_MAX_BIT = 1 << 3,

    /// <summary>VK_RESOLVE_MODE_NONE indicates that no resolve operation is done.</summary>
    VK_RESOLVE_MODE_NONE_KHR = VK_RESOLVE_MODE_NONE,

    /// <summary>
    ///     VK_RESOLVE_MODE_SAMPLE_ZERO_BIT indicates that result of the resolve operation is equal to the value of sample
    ///     0.
    /// </summary>
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = VK_RESOLVE_MODE_SAMPLE_ZERO_BIT,

    /// <summary>
    ///     VK_RESOLVE_MODE_AVERAGE_BIT indicates that result of the resolve operation is the average of the sample
    ///     values.
    /// </summary>
    VK_RESOLVE_MODE_AVERAGE_BIT_KHR = VK_RESOLVE_MODE_AVERAGE_BIT,

    /// <summary>VK_RESOLVE_MODE_MIN_BIT indicates that result of the resolve operation is the minimum of the sample values.</summary>
    VK_RESOLVE_MODE_MIN_BIT_KHR = VK_RESOLVE_MODE_MIN_BIT,

    /// <summary>VK_RESOLVE_MODE_MAX_BIT indicates that result of the resolve operation is the maximum of the sample values.</summary>
    VK_RESOLVE_MODE_MAX_BIT_KHR = VK_RESOLVE_MODE_MAX_BIT
}