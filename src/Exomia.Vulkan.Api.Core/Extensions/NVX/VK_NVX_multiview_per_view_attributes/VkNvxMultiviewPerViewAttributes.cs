#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvxMultiviewPerViewAttributes;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NVX_multiview_per_view_attributes - device extension (nr. 98) - author 'NVX' [platform '' | contact 'Jeff Bolz
///     @jeffbolznv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_multiview_per_view_attributes.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NVX_multiview_per_view_attributes.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_multiview")]
public static class VkNvxMultiviewPerViewAttributes
{
    /// <summary> The spec version. </summary>
    public const uint VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME = "VK_NVX_multiview_per_view_attributes";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5856\u4d5f\u4c55\u4954\u4956\u5745\u505f\u5245\u565f\u4549\u5f57\u5441\u5254\u4249\u5455\u5345\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}