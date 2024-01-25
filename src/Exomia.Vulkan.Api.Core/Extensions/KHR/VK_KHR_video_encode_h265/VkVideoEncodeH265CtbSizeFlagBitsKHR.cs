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
///     VkVideoEncodeH265CtbSizeFlagBitsKHR - Supported CTB sizes for H.265 video encode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CtbSizeFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265CtbSizeFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeH265CtbSizeFlagBitsKHR
{
    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR specifies that a CTB size of 16x16 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_KHR = 0x1,

    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR specifies that a CTB size of 32x32 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_KHR = 0x2,

    /// <summary>VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR specifies that a CTB size of 64x64 is supported.</summary>
    VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_KHR = 0x4
}