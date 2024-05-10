#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkMesaImageAlignmentControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_MESA_image_alignment_control - device extension (nr. 576) - author 'MESA' [platform '' | contact 'Hans-Kristian
///     Arntzen @HansKristian-Work']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MESA_image_alignment_control.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MESA_image_alignment_control.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: d3demulation
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkSpecialuse("d3demulation")]
[VkDeviceExt]
public static class VkMesaImageAlignmentControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_MESA_IMAGE_ALIGNMENT_CONTROL_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME = "VK_MESA_image_alignment_control";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_MESA_IMAGE_ALIGNMENT_CONTROL_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4d5f\u5345\u5f41\u4d49\u4741\u5f45\u4c41\u4749\u4d4e\u4e45\u5f54\u4f43\u544e\u4f52\u5f4c\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}