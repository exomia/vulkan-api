#region License

// Copyright (c) 2018-2023, exomia
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
///     VkFragmentShadingRateTypeNV - Enumeration with fragment shading rate types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateTypeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFragmentShadingRateTypeNV.html</a>
/// </summary>
public enum VkFragmentShadingRateTypeNV
{
    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV specifies that a graphics pipeline should obtain its pipeline
    ///     fragment shading rate and shading rate combiner state from the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateStateCreateInfoKHR.html">
    ///         VkPipelineFragmentShadingRateStateCreateInfoKHR
    ///     </a>
    ///     structure and that any state specified by the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateEnumStateCreateInfoNV.html">
    ///         VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    ///     </a>
    ///     structure should be ignored.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = 0,

    /// <summary>
    ///     VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV specifies that a graphics pipeline should obtain its pipeline fragment
    ///     shading rate and shading rate combiner state from the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateEnumStateCreateInfoNV.html">
    ///         VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    ///     </a>
    ///     structure and that any state specified by the
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineFragmentShadingRateStateCreateInfoKHR.html">
    ///         VkPipelineFragmentShadingRateStateCreateInfoKHR
    ///     </a>
    ///     structure should be ignored.
    /// </summary>
    VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = 1
}