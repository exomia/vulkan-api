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
///     VkVideoEncodeAV1SuperblockSizeFlagBitsKHR - Supported superblock sizes for AV1 video encode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SuperblockSizeFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SuperblockSizeFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoEncodeAV1SuperblockSizeFlagBitsKHR
{
    /// <summary>VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR specifies that a superblock size of 64x64 is supported.</summary>
    VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR = 0x1,

    /// <summary>VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR specifies that a superblock size of 128x128 is supported.</summary>
    VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR = 0x2
}