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
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_KHR_win32_keyed_mutex - device extension (nr. 76) - author 'KHR' [platform 'win32' | contact 'Carsten Rohde
///     @crohde']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_win32_keyed_mutex.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_win32_keyed_mutex.html</a>
/// </summary>
[VkRequires("VK_KHR_external_memory_win32")]
public static class VkKhrWin32KeyedMutex
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME = "VK_KHR_win32_keyed_mutex";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u575f\u4e49\u3233\u4b5f\u5945\u4445\u4d5f\u5455\u5845\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}