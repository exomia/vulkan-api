#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvLowLatency;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_low_latency - device extension (nr. 311) - author 'NV' [platform '' | contact 'Charles Hansen @cshansen']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_low_latency.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_low_latency.html</a>
/// </summary>
[VkDeviceExt]
public static class VkNvLowLatency
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_LOW_LATENCY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_LOW_LATENCY_EXTENSION_NAME = "VK_NV_low_latency";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_LOW_LATENCY_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_LOW_LATENCY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_LOW_LATENCY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4f4c\u5f57\u414c\u4554\u434e\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}