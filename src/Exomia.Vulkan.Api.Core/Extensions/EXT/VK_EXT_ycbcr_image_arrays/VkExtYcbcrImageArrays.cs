﻿#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtYcbcrImageArrays;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_ycbcr_image_arrays - device extension (nr. 253) - author 'EXT' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_ycbcr_image_arrays.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_ycbcr_image_arrays.html</a>
/// </summary>
[VkRequires("VK_KHR_sampler_ycbcr_conversion")]
public static class VkExtYcbcrImageArrays
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME = "VK_EXT_ycbcr_image_arrays";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u595f\u4243\u5243\u495f\u414d\u4547\u415f\u5252\u5941\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}