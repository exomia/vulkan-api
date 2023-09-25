#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Provisional.VkNvDisplacementMicromap;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VK_NV_displacement_micromap - device extension (nr. 398) - author 'NV' [platform 'provisional' | contact 'Christoph
///     Kubisch @pixeljetstream, Eric Werness @ewerness-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_displacement_micromap.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_displacement_micromap.html</a>
/// </summary>
/// <remarks>
///     provisional: true
/// </remarks>
[VkDepends("VK_EXT_opacity_micromap")]
[VkProvisional("true")]
[VkDeviceExt]
public static class VkNvDisplacementMicromap
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DISPLACEMENT_MICROMAP_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME = "VK_NV_displacement_micromap";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DISPLACEMENT_MICROMAP_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4944\u5053\u414c\u4543\u454d\u544e\u4d5f\u4349\u4f52\u414d\u5f50\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}