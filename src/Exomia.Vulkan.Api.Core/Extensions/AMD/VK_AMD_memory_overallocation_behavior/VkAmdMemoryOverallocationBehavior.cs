#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdMemoryOverallocationBehavior;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_memory_overallocation_behavior - device extension (nr. 190) - author 'AMD' [platform '' | contact 'Martin
///     Dinkov @mdinkov']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_memory_overallocation_behavior.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_memory_overallocation_behavior.html
///     </a>
/// </summary>
public static class VkAmdMemoryOverallocationBehavior
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME = "VK_AMD_memory_overallocation_behavior";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u4d5f\u4d45\u524f\u5f59\u564f\u5245\u4c41\u4f4c\u4143\u4954\u4e4f\u425f\u4845\u5641\u4f49\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}