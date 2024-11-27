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
///     VkResolveModeFlagBits - Bitmask indicating supported depth and stencil resolve modes -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResolveModeFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkResolveModeFlagBits.html</a>
/// </summary>
[Flags]
public enum VkResolveModeFlagBits
{
    /// <summary>VK_RESOLVE_MODE_NONE specifies that no resolve operation is done.</summary>
    VK_RESOLVE_MODE_NONE = 0,

    /// <summary>
    ///     VK_RESOLVE_MODE_SAMPLE_ZERO_BIT specifies that result of the resolve operation is equal to the value of sample
    ///     0.
    /// </summary>
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 0x1,

    /// <summary>
    ///     VK_RESOLVE_MODE_AVERAGE_BIT specifies that result of the resolve operation is the average of the sample
    ///     values.
    /// </summary>
    VK_RESOLVE_MODE_AVERAGE_BIT = 0x2,

    /// <summary>VK_RESOLVE_MODE_MIN_BIT specifies that result of the resolve operation is the minimum of the sample values.</summary>
    VK_RESOLVE_MODE_MIN_BIT = 0x4,

    /// <summary>VK_RESOLVE_MODE_MAX_BIT specifies that result of the resolve operation is the maximum of the sample values.</summary>
    VK_RESOLVE_MODE_MAX_BIT = 0x8,

    /// <summary>
    ///     VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID specifies that rather than a multisample resolve, a single
    ///     sampled color attachment will be downsampled into a Y′CBCR format image specified by an external Android format.
    ///     Unlike other resolve modes, implementations can resolve multiple times during rendering, or even bypass writing to
    ///     the color attachment altogether, as long as the final value is resolved to the resolve attachment. Values in the G,
    ///     B, and R channels of the color attachment will be written to the Y, CB, and CRchannels of the external format
    ///     image, respectively. Chroma values are calculated as if sampling with a linear filter from the color attachment at
    ///     full rate, at the location the chroma values sit according to
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolvePropertiesANDROID.html">
    ///         VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
    ///     </a>
    ///     ::chromaOffsetX,
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolvePropertiesANDROID.html">
    ///         VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
    ///     </a>
    ///     ::chromaOffsetY, and the chroma sample rate of the resolved image.
    /// </summary>
    VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID = 0x10,

    /// <summary>VK_RESOLVE_MODE_NONE specifies that no resolve operation is done.</summary>
    VK_RESOLVE_MODE_NONE_KHR = VK_RESOLVE_MODE_NONE,

    /// <summary>
    ///     VK_RESOLVE_MODE_SAMPLE_ZERO_BIT specifies that result of the resolve operation is equal to the value of sample
    ///     0.
    /// </summary>
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = VK_RESOLVE_MODE_SAMPLE_ZERO_BIT,

    /// <summary>
    ///     VK_RESOLVE_MODE_AVERAGE_BIT specifies that result of the resolve operation is the average of the sample
    ///     values.
    /// </summary>
    VK_RESOLVE_MODE_AVERAGE_BIT_KHR = VK_RESOLVE_MODE_AVERAGE_BIT,

    /// <summary>VK_RESOLVE_MODE_MIN_BIT specifies that result of the resolve operation is the minimum of the sample values.</summary>
    VK_RESOLVE_MODE_MIN_BIT_KHR = VK_RESOLVE_MODE_MIN_BIT,

    /// <summary>VK_RESOLVE_MODE_MAX_BIT specifies that result of the resolve operation is the maximum of the sample values.</summary>
    VK_RESOLVE_MODE_MAX_BIT_KHR = VK_RESOLVE_MODE_MAX_BIT
}