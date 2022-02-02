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
///     VkSparseImageFormatFlagBits - Bitmask specifying additional information about a sparse image resource -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseImageFormatFlagBits.html</a>
/// </summary>
[Flags]
public enum VkSparseImageFormatFlagBits
{
    /// <summary>
    ///     VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT specifies that the image uses a single mip tail region for all array
    ///     layers.
    /// </summary>
    VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = 0,

    /// <summary>
    ///     VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT specifies that the first mip level whose dimensions are not
    ///     integer multiples of the corresponding dimensions of the sparse image block begins the mip tail region.
    /// </summary>
    VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = 1,

    /// <summary>
    ///     VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT specifies that the image uses non-standard sparse image
    ///     block dimensions, and the imageGranularity values do not match the standard sparse image block dimensions for the
    ///     given format.
    /// </summary>
    VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = 2
}