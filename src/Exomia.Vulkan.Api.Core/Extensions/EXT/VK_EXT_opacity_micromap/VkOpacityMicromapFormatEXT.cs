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
///     VkOpacityMicromapFormatEXT - Format enum for opacity micromaps -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapFormatEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapFormatEXT.html</a>
/// </summary>
public enum VkOpacityMicromapFormatEXT
{
    /// <summary>
    ///     VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT indicates that the given micromap format has one bit per subtriangle
    ///     encoding either fully opaque or fully transparent.
    /// </summary>
    VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT = 1,

    /// <summary>
    ///     VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT indicates that the given micromap format has two bits per subtriangle
    ///     encoding four modes which can be interpreted as described in
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#ray-opacity-micromap">
    ///         ray
    ///         traversal
    ///     </a>
    ///     .
    /// </summary>
    VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT = 2
}