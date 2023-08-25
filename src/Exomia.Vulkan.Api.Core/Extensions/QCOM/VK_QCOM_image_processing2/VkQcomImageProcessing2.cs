#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkQcomImageProcessing2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_QCOM_image_processing2 - device extension (nr. 519) - author 'QCOM' [platform '' | contact 'Jeff Leger
///     @jackohound']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_image_processing2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_image_processing2.html</a>
/// </summary>
[VkDepends("VK_QCOM_image_processing")]
public static class VkQcomImageProcessing2
{
    /// <summary> The spec version. </summary>
    public const uint VK_QCOM_IMAGE_PROCESSING_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME = "VK_QCOM_image_processing2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QCOM_IMAGE_PROCESSING_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u515f\u4f43\u5f4d\u4d49\u4741\u5f45\u5250\u434f\u5345\u4953\u474e\u325f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}