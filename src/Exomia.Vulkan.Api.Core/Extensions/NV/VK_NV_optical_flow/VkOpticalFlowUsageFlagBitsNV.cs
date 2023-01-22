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
///     VkOpticalFlowUsageFlagBitsNV - Bits specifying usage for optical flow operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowUsageFlagBitsNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowUsageFlagBitsNV.html</a>
/// </summary>
[Flags]
public enum VkOpticalFlowUsageFlagBitsNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowUsageFlagBitsNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowUsageFlagBitsNV
    ///     </a>
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV = 0,

    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV specifies that the image canbe used as input or reference frame for an
    ///     optical flow operation.
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV = 0x1,

    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV specifies that the image canbe used as output flow vector map for an
    ///     optical flow operation.
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV = 0x2,

    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV specifies that the image can be used as hint flow vector map for an optical
    ///     flow operation.
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV = 0x4,

    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_COST_BIT_NV specifies that the image can be used as output cost map for an optical flow
    ///     operation.
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_COST_BIT_NV = 0x8,

    /// <summary>
    ///     VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV specifies that the image can be used as global flow vector for an
    ///     optical flow operation.
    /// </summary>
    VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV = 0x10
}