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
///     VkCubicFilterWeightsQCOM - Specify cubic weights for texture filtering -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCubicFilterWeightsQCOM.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCubicFilterWeightsQCOM.html</a>
/// </summary>
public enum VkCubicFilterWeightsQCOM
{
    /// <summary>VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM specifies Catmull-Rom weights.</summary>
    VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM = 0,

    /// <summary>VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM specifies Zero Tangent Cardinal weights.</summary>
    VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM = 1,

    /// <summary>VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM specifies B-Spline weights.</summary>
    VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM = 2,

    /// <summary>VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM specifies Mitchell-Netravali weights.</summary>
    VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM = 3
}