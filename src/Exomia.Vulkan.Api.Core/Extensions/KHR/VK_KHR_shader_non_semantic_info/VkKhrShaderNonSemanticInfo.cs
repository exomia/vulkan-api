#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrShaderNonSemanticInfo;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_shader_non_semantic_info - device extension (nr. 294) - author 'KHR' [platform '' | contact 'Baldur Karlsson
///     @baldurk']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_non_semantic_info.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_non_semantic_info.html
///     </a>
/// </summary>
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_non_semantic_info.html#_deprecation_state")]
public static class VkKhrShaderNonSemanticInfo
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME = "VK_KHR_shader_non_semantic_info";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4148\u4544\u5f52\u4f4e\u5f4e\u4553\u414d\u544e\u4349\u495f\u464e\u5f4f\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}