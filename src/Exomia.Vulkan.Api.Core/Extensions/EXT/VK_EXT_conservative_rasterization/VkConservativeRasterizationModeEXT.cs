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
///     VkConservativeRasterizationModeEXT - Specify the conservative rasterization mode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConservativeRasterizationModeEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConservativeRasterizationModeEXT.html
///     </a>
/// </summary>
public enum VkConservativeRasterizationModeEXT
{
    /// <summary>
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT specifies that conservative rasterization is disabled and
    ///     rasterization proceeds as normal.
    /// </summary>
    VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT = 0,

    /// <summary>
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT specifies that conservative rasterization is enabled in
    ///     overestimation mode.
    /// </summary>
    VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT = 1,

    /// <summary>
    ///     VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT specifies that conservative rasterization is enabled in
    ///     underestimation mode.
    /// </summary>
    VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT = 2
}