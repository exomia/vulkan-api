#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtRasterizationOrderAttachmentAccess;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_rasterization_order_attachment_access - device extension (nr. 464) - author 'ARM' [platform '' | contact
///     'Jan-Harald Fredriksen @janharaldfredriksen-arm']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_rasterization_order_attachment_access.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_rasterization_order_attachment_access.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2")]
[VkDeviceExt]
public static class VkExtRasterizationOrderAttachmentAccess
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME = "VK_EXT_rasterization_order_attachment_access";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u525f\u5341\u4554\u4952\u415a\u4954\u4e4f\u4f5f\u4452\u5245\u415f\u5454\u4341\u4d48\u4e45\u5f54\u4341\u4543\u5353\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}