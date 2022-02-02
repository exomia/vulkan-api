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
///     VkCoverageModulationModeNV - Specify the coverage modulation mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoverageModulationModeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoverageModulationModeNV.html</a>
/// </summary>
public enum VkCoverageModulationModeNV
{
    /// <summary>VK_COVERAGE_MODULATION_MODE_NONE_NV specifies that no components are multiplied by the modulation factor.</summary>
    VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,

    /// <summary>
    ///     VK_COVERAGE_MODULATION_MODE_RGB_NV specifies that the red, green, and blue components are multiplied by the
    ///     modulation factor.
    /// </summary>
    VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,

    /// <summary>
    ///     VK_COVERAGE_MODULATION_MODE_ALPHA_NV specifies that the alpha component is multiplied by the modulation
    ///     factor.
    /// </summary>
    VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,

    /// <summary>VK_COVERAGE_MODULATION_MODE_RGBA_NV specifies that all components are multiplied by the modulation factor.</summary>
    VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3
}