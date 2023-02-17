#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Win32.VkNvWin32KeyedMutex;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_NV_win32_keyed_mutex - device extension (nr. 59) - author 'NV' [platform 'win32' | contact 'Carsten Rohde
///     @crohde']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_win32_keyed_mutex.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_win32_keyed_mutex.html</a>
/// </summary>
[Obsolete("promoted to VK_KHR_win32_keyed_mutex", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_win32_keyed_mutex.html#_deprecation_state")]
public static class VkNvWin32KeyedMutex
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME = "VK_NV_win32_keyed_mutex";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4957\u334e\u5f32\u454b\u4559\u5f44\u554d\u4554\u5f58\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}