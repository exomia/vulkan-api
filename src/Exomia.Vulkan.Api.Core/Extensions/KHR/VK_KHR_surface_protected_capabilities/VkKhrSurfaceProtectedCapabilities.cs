#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_surface_protected_capabilities - instance extension (nr. 240) - author 'KHR' [platform '' | contact 'Sandeep
///     Shinde @sashinde']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_surface_protected_capabilities.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_surface_protected_capabilities.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_surface_capabilities2")]
public static class VkKhrSurfaceProtectedCapabilities
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME = "VK_KHR_surface_protected_capabilities";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u5255\u4146\u4543\u505f\u4f52\u4554\u5443\u4445\u435f\u5041\u4241\u4c49\u5449\u4549\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}