#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkHuaweiHdrVivid;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_HUAWEI_hdr_vivid - device extension (nr. 591) - author 'HUAWEI' [platform '' | contact 'Zehui Lin @bactlink']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_hdr_vivid.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_HUAWEI_hdr_vivid.html</a>
/// </summary>
[VkDepends("(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_KHR_swapchain+VK_EXT_hdr_metadata")]
[VkDeviceExt]
public static class VkHuaweiHdrVivid
{
    /// <summary> The spec version. </summary>
    public const uint VK_HUAWEI_HDR_VIVID_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_HUAWEI_HDR_VIVID_EXTENSION_NAME = "VK_HUAWEI_hdr_vivid";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_HUAWEI_HDR_VIVID_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_HUAWEI_HDR_VIVID_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_HUAWEI_HDR_VIVID_EXTENSION_NAME_UTF8_NT = "\u4b56\u485f\u4155\u4557\u5f49\u4448\u5f52\u4956\u4956\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}