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
///     VkOpticalFlowGridSizeFlagBitsNV - Bits specifying grid sizes for optical flow operations -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowGridSizeFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowGridSizeFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkOpticalFlowGridSizeFlagBitsNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowGridSizeFlagBitsNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowGridSizeFlagBitsNV
    ///     </a>
    /// </summary>
    VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = 0,

    /// <summary>VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV specifies that grid is 1x1 pixel.</summary>
    VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = 0x1,

    /// <summary>VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV specifies that grid is 2x2 pixel.</summary>
    VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = 0x2,

    /// <summary>VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV specifies that grid is 4x4 pixel.</summary>
    VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = 0x4,

    /// <summary>VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV specifies that grid is 8x8 pixel.</summary>
    VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = 0x8
}