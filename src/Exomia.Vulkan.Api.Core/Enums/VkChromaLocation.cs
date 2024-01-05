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
///     VkChromaLocation - Position of downsampled chroma samples -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkChromaLocation.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkChromaLocation.html</a>
/// </summary>
public enum VkChromaLocation
{
    /// <summary>
    ///     VK_CHROMA_LOCATION_COSITED_EVEN specifies that downsampled chroma samples are aligned with luma samples with
    ///     even coordinates.
    /// </summary>
    VK_CHROMA_LOCATION_COSITED_EVEN = 0,

    /// <summary>
    ///     VK_CHROMA_LOCATION_MIDPOINT specifies that downsampled chroma samples are located half way between each even
    ///     luma sample and the nearest higher odd luma sample.
    /// </summary>
    VK_CHROMA_LOCATION_MIDPOINT = 1,

    /// <summary>
    ///     VK_CHROMA_LOCATION_COSITED_EVEN specifies that downsampled chroma samples are aligned with luma samples with
    ///     even coordinates.
    /// </summary>
    VK_CHROMA_LOCATION_COSITED_EVEN_KHR = VK_CHROMA_LOCATION_COSITED_EVEN,

    /// <summary>
    ///     VK_CHROMA_LOCATION_MIDPOINT specifies that downsampled chroma samples are located half way between each even
    ///     luma sample and the nearest higher odd luma sample.
    /// </summary>
    VK_CHROMA_LOCATION_MIDPOINT_KHR = VK_CHROMA_LOCATION_MIDPOINT
}