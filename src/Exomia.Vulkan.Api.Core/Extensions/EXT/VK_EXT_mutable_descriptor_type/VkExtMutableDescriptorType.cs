#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtMutableDescriptorType;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_mutable_descriptor_type - device extension (nr. 495) - author 'EXT' [platform '' | contact 'Joshua Ashton
///     @Joshua-Ashton,Hans-Kristian Arntzen @HansKristian-Work']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_mutable_descriptor_type.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_mutable_descriptor_type.html</a>
/// </summary>
/// <remarks>
///     specialuse: d3demulation
/// </remarks>
[VkDepends("VK_KHR_maintenance3")]
[VkSpecialuse("d3demulation")]
[VkDeviceExt]
public static class VkExtMutableDescriptorType
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME = "VK_EXT_mutable_descriptor_type";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u4d5f\u5455\u4241\u454c\u445f\u5345\u5243\u5049\u4f54\u5f52\u5954\u4550\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}