#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDeviceAddressBindingReport;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_device_address_binding_report - device extension (nr. 355) - author 'EXT' [platform '' | contact 'Ralph
///     Potter gitlab:@r_potter']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_address_binding_report.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_device_address_binding_report.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: debugging,devtools
/// </remarks>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_EXT_debug_utils")]
[VkSpecialuse("debugging,devtools")]
public static class VkExtDeviceAddressBindingReport
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME = "VK_EXT_device_address_binding_report";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEVICE_ADDRESS_BINDING_REPORT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5645\u4349\u5f45\u4441\u5244\u5345\u5f53\u4942\u444e\u4e49\u5f47\u4552\u4f50\u5452\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}