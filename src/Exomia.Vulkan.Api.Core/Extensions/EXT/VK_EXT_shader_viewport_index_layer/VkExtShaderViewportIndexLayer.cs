#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtShaderViewportIndexLayer;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_shader_viewport_index_layer - device extension (nr. 163) - author 'NV' [platform '' | contact 'Daniel Koch
///     @dgkoch']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_viewport_index_layer.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_viewport_index_layer.html
///     </a>
/// </summary>
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_shader_viewport_index_layer.html#_deprecation_state")]
public static class VkExtShaderViewportIndexLayer
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME = "VK_EXT_shader_viewport_index_layer";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u535f\u4148\u4544\u5f52\u4956\u5745\u4f50\u5452\u495f\u444e\u5845\u4c5f\u5941\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}