#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDescriptorPoolOverallocation;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_descriptor_pool_overallocation - device extension (nr. 547) - author 'NV' [platform '' | contact 'Piers
///     Daniell @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_descriptor_pool_overallocation.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_descriptor_pool_overallocation.html
///     </a>
/// </summary>
[VkDepends("VK_VERSION_1_1")]
public static class VkNvDescriptorPoolOverallocation
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME = "VK_NV_descriptor_pool_overallocation";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DESCRIPTOR_POOL_OVERALLOCATION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4353\u4952\u5450\u524f\u505f\u4f4f\u5f4c\u564f\u5245\u4c41\u4f4c\u4143\u4954\u4e4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}