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
///     VkVideoComponentBitDepthFlagBitsKHR - Video format component bit depth -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoComponentBitDepthFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoComponentBitDepthFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoComponentBitDepthFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoComponentBitDepthFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoComponentBitDepthFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = 0,

    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR specifies a component bit depth of 8 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = 0x1,

    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR specifies a component bit depth of 10 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = 0x4,

    /// <summary>VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR specifies a component bit depth of 12 bits.</summary>
    VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = 0x10
}