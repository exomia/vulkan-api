#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtQueueFamilyForeign;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_queue_family_foreign - device extension (nr. 127) - author 'EXT' [platform '' | contact 'Lina Versace
///     @versalinyaa']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_queue_family_foreign.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_queue_family_foreign.html</a>
/// </summary>
[VkDepends("VK_KHR_external_memory,VK_VERSION_1_1")]
[VkDeviceExt]
public static class VkExtQueueFamilyForeign
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME = "VK_EXT_queue_family_foreign";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u515f\u4555\u4555\u465f\u4d41\u4c49\u5f59\u4f46\u4552\u4749\u5f4e\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     VK_QUEUE_FAMILY_FOREIGN_EXT - Foreign queue family index sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_FOREIGN_EXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_FOREIGN_EXT.html</a>
    /// </summary>
    public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);
}