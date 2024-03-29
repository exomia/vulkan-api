#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkGoogleUserType;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_GOOGLE_user_type - device extension (nr. 290) - author 'GOOGLE' [platform '' | contact 'Kaye Mason @chaleur']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_user_type.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_user_type.html</a>
/// </summary>
[VkDeviceExt]
public static class VkGoogleUserType
{
    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_USER_TYPE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_USER_TYPE_EXTENSION_NAME = "VK_GOOGLE_user_type";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_USER_TYPE_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_USER_TYPE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_USER_TYPE_EXTENSION_NAME_UTF8_NT = "\u4b56\u475f\u4f4f\u4c47\u5f45\u5355\u5245\u545f\u5059\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}