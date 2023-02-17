#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrUniformBufferStandardLayout;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_uniform_buffer_standard_layout - device extension (nr. 254) - author 'KHR' [platform '' | contact 'Graeme
///     Leese @gnl21']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_uniform_buffer_standard_layout.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_uniform_buffer_standard_layout.html
///     </a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_uniform_buffer_standard_layout.html#_deprecation_state")]
public static class VkKhrUniformBufferStandardLayout
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME = "VK_KHR_uniform_buffer_standard_layout";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u555f\u494e\u4f46\u4d52\u425f\u4655\u4546\u5f52\u5453\u4e41\u4144\u4452\u4c5f\u5941\u554f\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}