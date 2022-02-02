#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdNegativeViewportHeight;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_negative_viewport_height - device extension (nr. 36) - author 'AMD' [platform '' | contact 'Matthaeus G.
///     Chajdas @anteru']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_negative_viewport_height.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_negative_viewport_height.html
///     </a>
/// </summary>
[Obsolete("obsoleted by VK_KHR_maintenance1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_negative_viewport_height.html#_deprecation_state")]
public static class VkAmdNegativeViewportHeight
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME = "VK_AMD_negative_viewport_height";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u4e5f\u4745\u5441\u5649\u5f45\u4956\u5745\u4f50\u5452\u485f\u4945\u4847\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}