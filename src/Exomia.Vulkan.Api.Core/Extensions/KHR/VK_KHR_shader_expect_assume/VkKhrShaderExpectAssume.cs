#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrShaderExpectAssume;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_shader_expect_assume - device extension (nr. 545) - author 'KHR' [platform '' | contact 'Kevin Petit @kpet']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_expect_assume.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_expect_assume.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
public static class VkKhrShaderExpectAssume
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SHADER_EXPECT_ASSUME_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME = "VK_KHR_shader_expect_assume";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SHADER_EXPECT_ASSUME_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4148\u4544\u5f52\u5845\u4550\u5443\u415f\u5353\u4d55\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}