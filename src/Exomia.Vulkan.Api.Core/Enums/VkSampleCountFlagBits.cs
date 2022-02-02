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
///     VkSampleCountFlagBits - Bitmask specifying sample counts supported for an image used for storage operations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleCountFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSampleCountFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSampleCountFlagBits
{
    /// <summary>VK_SAMPLE_COUNT_1_BIT specifies an image with one sample per pixel.</summary>
    VK_SAMPLE_COUNT_1_BIT = 0,

    /// <summary>VK_SAMPLE_COUNT_2_BIT specifies an image with 2 samples per pixel.</summary>
    VK_SAMPLE_COUNT_2_BIT = 1,

    /// <summary>VK_SAMPLE_COUNT_4_BIT specifies an image with 4 samples per pixel.</summary>
    VK_SAMPLE_COUNT_4_BIT = 2,

    /// <summary>VK_SAMPLE_COUNT_8_BIT specifies an image with 8 samples per pixel.</summary>
    VK_SAMPLE_COUNT_8_BIT = 3,

    /// <summary>VK_SAMPLE_COUNT_16_BIT specifies an image with 16 samples per pixel.</summary>
    VK_SAMPLE_COUNT_16_BIT = 4,

    /// <summary>VK_SAMPLE_COUNT_32_BIT specifies an image with 32 samples per pixel.</summary>
    VK_SAMPLE_COUNT_32_BIT = 5,

    /// <summary>VK_SAMPLE_COUNT_64_BIT specifies an image with 64 samples per pixel.</summary>
    VK_SAMPLE_COUNT_64_BIT = 6
}