#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkArmShaderCoreProperties;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_ARM_shader_core_properties - device extension (nr. 416) - author 'ARM' [platform '' | contact 'Jan-Harald
///     Fredriksen @janharaldfredriksen-arm']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_shader_core_properties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_shader_core_properties.html</a>
/// </summary>
[VkDepends("VK_VERSION_1_1")]
[VkDeviceExt]
public static class VkArmShaderCoreProperties
{
    /// <summary> The spec version. </summary>
    public const uint VK_ARM_SHADER_CORE_PROPERTIES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME = "VK_ARM_shader_core_properties";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_ARM_SHADER_CORE_PROPERTIES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u4d52\u535f\u4148\u4544\u5f52\u4f43\u4552\u505f\u4f52\u4550\u5452\u4549\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}