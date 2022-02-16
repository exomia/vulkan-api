#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtRobustness2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_robustness2 - device extension (nr. 287) - author 'EXT' [platform '' | contact 'Liam Middlebrook
///     @liam-middlebrook']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_robustness2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_robustness2.html</a>
/// </summary>
public static class VkExtRobustness2
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_ROBUSTNESS_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_ROBUSTNESS_2_EXTENSION_NAME = "VK_EXT_robustness2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_ROBUSTNESS_2_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_ROBUSTNESS_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_ROBUSTNESS_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u525f\u424f\u5355\u4e54\u5345\u5f53\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}