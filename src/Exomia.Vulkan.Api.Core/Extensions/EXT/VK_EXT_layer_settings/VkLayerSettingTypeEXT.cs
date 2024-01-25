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
///     VkLayerSettingTypeEXT - Type of the values that can be passed to a layer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLayerSettingTypeEXT.html</a>
/// </summary>
public enum VkLayerSettingTypeEXT
{
    /// <summary>
    ///     VK_LAYER_SETTING_TYPE_BOOL32_EXT specifies that the layer setting&#8217;s type is
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBool32.html">VkBool32</a>.
    /// </summary>
    VK_LAYER_SETTING_TYPE_BOOL32_EXT = 0,

    /// <summary>VK_LAYER_SETTING_TYPE_INT32_EXT specifies that the layer setting&#8217;s type is signed 32-bit integer.</summary>
    VK_LAYER_SETTING_TYPE_INT32_EXT = 1,

    /// <summary>VK_LAYER_SETTING_TYPE_INT64_EXT specifies that the layer setting&#8217;s type is signed 64-bit integer.</summary>
    VK_LAYER_SETTING_TYPE_INT64_EXT = 2,

    /// <summary>VK_LAYER_SETTING_TYPE_UINT32_EXT specifies that the layer setting&#8217;s type is unsigned 32-bit integer.</summary>
    VK_LAYER_SETTING_TYPE_UINT32_EXT = 3,

    /// <summary>VK_LAYER_SETTING_TYPE_UINT64_EXT specifies that the layer setting&#8217;s type is unsigned 64-bit integer.</summary>
    VK_LAYER_SETTING_TYPE_UINT64_EXT = 4,

    /// <summary>VK_LAYER_SETTING_TYPE_FLOAT32_EXT specifies that the layer setting&#8217;s type is 32-bit floating-point.</summary>
    VK_LAYER_SETTING_TYPE_FLOAT32_EXT = 5,

    /// <summary>VK_LAYER_SETTING_TYPE_FLOAT64_EXT specifies that the layer setting&#8217;s type is 64-bit floating-point.</summary>
    VK_LAYER_SETTING_TYPE_FLOAT64_EXT = 6,

    /// <summary>
    ///     VK_LAYER_SETTING_TYPE_STRING_EXT specifies that the layer setting&#8217;s type is a pointer to a
    ///     null-terminated UTF-8 string.
    /// </summary>
    VK_LAYER_SETTING_TYPE_STRING_EXT = 7
}