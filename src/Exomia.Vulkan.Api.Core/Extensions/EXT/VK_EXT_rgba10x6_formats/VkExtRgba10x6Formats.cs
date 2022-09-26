#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtRgba10x6Formats;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_rgba10x6_formats - device extension (nr. 345) - author 'EXT' [platform '' | contact 'Jan-Harald Fredriksen @janharaldfredriksen-arm']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_rgba10x6_formats.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_rgba10x6_formats.html </a>
/// </summary>
[VkRequires("VK_KHR_sampler_ycbcr_conversion")]
public static class VkExtRgba10x6Formats
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME = "VK_EXT_rgba10x6_formats";

    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u525f\u4247\u3141\u5830\u5f36\u4f46\u4d52\u5441\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}