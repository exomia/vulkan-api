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
///     VkOpacityMicromapSpecialIndexEXT - Enum for special indices in the opacity micromap -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapSpecialIndexEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpacityMicromapSpecialIndexEXT.html
///     </a>
/// </summary>
public enum VkOpacityMicromapSpecialIndexEXT
{
    /// <summary>
    ///     VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT specifies that the entire triangle is fully
    ///     transparent.
    /// </summary>
    VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT = -1,

    /// <summary>VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT specifies that the entire triangle is fully opaque.</summary>
    VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT = -2,

    /// <summary>
    ///     VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXTspecifies that the entire triangle is
    ///     unknown-transparent.
    /// </summary>
    VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT = -3,

    /// <summary>
    ///     VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXTspecifies that the entire triangle is
    ///     unknown-opaque.
    /// </summary>
    VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT = -4
}