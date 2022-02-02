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
///     VkBorderColor - Specify border color used for texture lookups -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBorderColor.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBorderColor.html</a>
/// </summary>
public enum VkBorderColor
{
    /// <summary>VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK specifies a transparent, floating-point format, black color.</summary>
    VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0,

    /// <summary>VK_BORDER_COLOR_INT_TRANSPARENT_BLACK specifies a transparent, integer format, black color.</summary>
    VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1,

    /// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK specifies an opaque, floating-point format, black color.</summary>
    VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2,

    /// <summary>VK_BORDER_COLOR_INT_OPAQUE_BLACK specifies an opaque, integer format, black color.</summary>
    VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3,

    /// <summary>VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE specifies an opaque, floating-point format, white color.</summary>
    VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4,

    /// <summary>VK_BORDER_COLOR_INT_OPAQUE_WHITE specifies an opaque, integer format, white color.</summary>
    VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5,

    /// <summary>
    ///     VK_BORDER_COLOR_FLOAT_CUSTOM_EXT indicates that a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorCreateInfoEXT.html">
    ///         VkSamplerCustomBorderColorCreateInfoEXT
    ///     </a>
    ///     structure is included in the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateInfo.html">VkSamplerCreateInfo</a>
    ///     ::pNext chain containing the color data in floating-point format.
    /// </summary>
    VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = 1000287003,

    /// <summary>
    ///     VK_BORDER_COLOR_INT_CUSTOM_EXT indicates that a
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCustomBorderColorCreateInfoEXT.html">
    ///         VkSamplerCustomBorderColorCreateInfoEXT
    ///     </a>
    ///     structure is included in the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSamplerCreateInfo.html">VkSamplerCreateInfo</a>
    ///     ::pNext chain containing the color data in integer format.
    /// </summary>
    VK_BORDER_COLOR_INT_CUSTOM_EXT = 1000287004
}