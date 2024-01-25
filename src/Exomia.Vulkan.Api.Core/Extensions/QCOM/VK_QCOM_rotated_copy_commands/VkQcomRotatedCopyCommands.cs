#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkQcomRotatedCopyCommands;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_QCOM_rotated_copy_commands - device extension (nr. 334) - author 'QCOM' [platform '' | contact 'Matthew Netsch
///     @mnetsch']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_rotated_copy_commands.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_rotated_copy_commands.html</a>
/// </summary>
[VkDepends("VK_KHR_copy_commands2")]
[VkDeviceExt]
public static class VkQcomRotatedCopyCommands
{
    /// <summary> The spec version. </summary>
    public const uint VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME = "VK_QCOM_rotated_copy_commands";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u515f\u4f43\u5f4d\u4f52\u4154\u4554\u5f44\u4f43\u5950\u435f\u4d4f\u414d\u444e\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}