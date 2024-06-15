#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrShaderRelaxedExtendedInstruction;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_shader_relaxed_extended_instruction - device extension (nr. 559) - author 'KHR' [platform '' | contact
///     'Nathan Gauër @Keenuts']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_relaxed_extended_instruction.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_shader_relaxed_extended_instruction.html
///     </a>
/// </summary>
[VkDeviceExt]
public static class VkKhrShaderRelaxedExtendedInstruction
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME = "VK_KHR_shader_relaxed_extended_instruction";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SHADER_RELAXED_EXTENDED_INSTRUCTION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u535f\u4148\u4544\u5f52\u4552\u414c\u4558\u5f44\u5845\u4554\u444e\u4445\u495f\u534e\u5254\u4355\u4954\u4e4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}