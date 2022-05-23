#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDeviceDiagnosticsConfig;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_device_diagnostics_config - device extension (nr. 301) - author 'NV' [platform '' | contact 'Kedarnath
///     Thangudu @kthangudu']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_diagnostics_config.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_device_diagnostics_config.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static class VkNvDeviceDiagnosticsConfig
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME = "VK_NV_device_diagnostics_config";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4956\u4543\u445f\u4149\u4e47\u534f\u4954\u5343\u435f\u4e4f\u4946\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}