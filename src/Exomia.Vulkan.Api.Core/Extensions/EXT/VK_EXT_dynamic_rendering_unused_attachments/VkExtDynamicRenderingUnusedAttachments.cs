#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDynamicRenderingUnusedAttachments;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_dynamic_rendering_unused_attachments - device extension (nr. 500) - author 'EXT' [platform '' | contact
///     'Piers Daniell @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_dynamic_rendering_unused_attachments.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_dynamic_rendering_unused_attachments.html
///     </a>
/// </summary>
[VkDepends("((VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_dynamic_rendering),VK_VERSION_1_3")]
[VkDeviceExt]
public static class VkExtDynamicRenderingUnusedAttachments
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME = "VK_EXT_dynamic_rendering_unused_attachments";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u4e59\u4d41\u4349\u525f\u4e45\u4544\u4952\u474e\u555f\u554e\u4553\u5f44\u5441\u4154\u4843\u454d\u544e\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}