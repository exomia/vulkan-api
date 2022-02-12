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
///     VK_GOOGLE_surfaceless_query - instance extension (nr. 434) - author 'GOOGLE' [platform '' | contact 'Shahbaz
///     Youssefi @syoussefi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_surfaceless_query.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_surfaceless_query.html</a>
/// </summary>
/// <remarks>
///     specialuse: glemulation
/// </remarks>
[VkRequires("VK_KHR_surface")]
[VkSpecialuse("glemulation")]
public static class VkGoogleSurfacelessQuery
{
    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_SURFACELESS_QUERY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME = "VK_GOOGLE_surfaceless_query";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_SURFACELESS_QUERY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u475f\u4f4f\u4c47\u5f45\u5553\u4652\u4341\u4c45\u5345\u5f53\u5551\u5245\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}