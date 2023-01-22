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
///     VkCoarseSampleOrderTypeNV - Shading rate image sample ordering types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderTypeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCoarseSampleOrderTypeNV.html</a>
/// </summary>
public enum VkCoarseSampleOrderTypeNV
{
    /// <summary>
    ///     VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV specifies that coverage samples will be ordered in an
    ///     implementation-dependent manner.
    /// </summary>
    VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,

    /// <summary>
    ///     VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV specifies that coverage samples will be ordered according to the array
    ///     of custom orderings provided in either the pCustomSampleOrders member of
    ///     VkPipelineViewportCoarseSampleOrderStateCreateInfoNV or the pCustomSampleOrders member of
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetCoarseSampleOrderNV.html">vkCmdSetCoarseSampleOrderNV</a>
    ///     .
    /// </summary>
    VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,

    /// <summary>
    ///     VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV specifies that coverage samples will be ordered sequentially, sorted
    ///     first by pixel coordinate (in row-major order) and then by
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-multisampling-coverage-mask">
    ///         sample
    ///         index
    ///     </a>
    ///     .
    /// </summary>
    VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,

    /// <summary>
    ///     VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV specifies that coverage samples will be ordered sequentially, sorted
    ///     first by
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#primsrast-multisampling-coverage-mask">
    ///         sample
    ///         index
    ///     </a>
    ///     and then by pixel coordinate (in row-major order).
    /// </summary>
    VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3
}