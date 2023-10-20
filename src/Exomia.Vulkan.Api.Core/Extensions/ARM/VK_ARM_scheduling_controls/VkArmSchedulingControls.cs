#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkArmSchedulingControls;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_ARM_scheduling_controls - device extension (nr. 418) - author 'ARM' [platform '' | contact 'Kevin Petit @kpet']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_scheduling_controls.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ARM_scheduling_controls.html</a>
/// </summary>
[VkDepends("VK_ARM_shader_core_builtins")]
[VkDeviceExt]
public static class VkArmSchedulingControls
{
    /// <summary> The spec version. </summary>
    public const uint VK_ARM_SCHEDULING_CONTROLS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME = "VK_ARM_scheduling_controls";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_ARM_SCHEDULING_CONTROLS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u4d52\u535f\u4843\u4445\u4c55\u4e49\u5f47\u4f43\u544e\u4f52\u534c\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}