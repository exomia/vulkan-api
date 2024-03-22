#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkArmRenderPassStriped;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_ARM_render_pass_striped - device extension (nr. 425) - author 'ARM' [platform '' | contact 'Jan-Harald
///     Fredriksen @janharaldfredriksen-arm']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_render_pass_striped.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_render_pass_striped.html</a>
/// </summary>
[VkDepends("((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_synchronization2),VK_VERSION_1_3")]
[VkDeviceExt]
public static class VkArmRenderPassStriped
{
    /// <summary> The spec version. </summary>
    public const uint VK_ARM_RENDER_PASS_STRIPED_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME = "VK_ARM_render_pass_striped";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_ARM_RENDER_PASS_STRIPED_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u4d52\u525f\u4e45\u4544\u5f52\u4150\u5353\u535f\u5254\u5049\u4445\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}