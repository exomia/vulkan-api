#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkAmdRasterizationOrder;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_AMD_rasterization_order - device extension (nr. 19) - author 'AMD' [platform '' | contact 'Daniel Rakos
///     @drakos-amd']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_rasterization_order.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_AMD_rasterization_order.html</a>
/// </summary>
[VkDeviceExt]
public static class VkAmdRasterizationOrder
{
    /// <summary> The spec version. </summary>
    public const uint VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME = "VK_AMD_rasterization_order";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u415f\u444d\u525f\u5341\u4554\u4952\u415a\u4954\u4e4f\u4f5f\u4452\u5245\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}