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
///     VkVideoChromaSubsamplingFlagBitsKHR - Video format chroma subsampling bits -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoChromaSubsamplingFlagBitsKHR.html
///     </a>
/// </summary>
[Flags]
public enum VkVideoChromaSubsamplingFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoChromaSubsamplingFlagBitsKHR">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkVideoChromaSubsamplingFlagBitsKHR
    ///     </a>
    /// </summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR = 0,

    /// <summary>VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR specifies that the format is monochrome.</summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR specified that the format is 4:2:0 chroma subsampled, i.e. the two
    ///     chroma components are sampled horizontally and vertically at half the sample rate of the luma component.
    /// </summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = 0x2,

    /// <summary>
    ///     VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR - the format is 4:2:2 chroma subsampled, i.e. the two chroma
    ///     components are sampled horizontally at half the sample rate of luma component.
    /// </summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = 0x4,

    /// <summary>
    ///     VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR - the format is 4:4:4 chroma sampled, i.e. all three components of the
    ///     Y′CBCR format are sampled at the same rate, thus there is no chroma subsampling.
    /// </summary>
    VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = 0x8
}