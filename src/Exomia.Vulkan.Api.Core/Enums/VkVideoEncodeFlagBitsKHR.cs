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
///     VkVideoEncodeFlagBitsKHR - Video encode flags -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFlagBitsKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeFlagBitsKHR.html</a>
/// </summary>
[Flags]
public enum VkVideoEncodeFlagBitsKHR
{
    /// <summary>
    ///     VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR specifies the use of a
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-quantization-delta-map">
    ///         quantization
    ///         delta map
    ///     </a>
    ///     in the issued
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR specifies the use of an
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#encode-emphasis-map">
    ///         emphasis
    ///         map
    ///     </a>
    ///     in the issued
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#video-encode-operations">
    ///         video
    ///         encode operations
    ///     </a>
    ///     .
    /// </summary>
    VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR = 0x2
}