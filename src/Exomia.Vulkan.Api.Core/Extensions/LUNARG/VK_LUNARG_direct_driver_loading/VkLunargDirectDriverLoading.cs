#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkLunargDirectDriverLoading;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_LUNARG_direct_driver_loading - instance extension (nr. 460) - author 'LUNARG' [platform '' | contact 'Charles
///     Giessen @charles-lunarg']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUNARG_direct_driver_loading.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUNARG_direct_driver_loading.html
///     </a>
/// </summary>
[VkInstanceExt]
public static class VkLunargDirectDriverLoading
{
    /// <summary> The spec version. </summary>
    public const uint VK_LUNARG_DIRECT_DRIVER_LOADING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME = "VK_LUNARG_direct_driver_loading";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_LUNARG_DIRECT_DRIVER_LOADING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4c5f\u4e55\u5241\u5f47\u4944\u4552\u5443\u445f\u4952\u4556\u5f52\u4f4c\u4441\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}