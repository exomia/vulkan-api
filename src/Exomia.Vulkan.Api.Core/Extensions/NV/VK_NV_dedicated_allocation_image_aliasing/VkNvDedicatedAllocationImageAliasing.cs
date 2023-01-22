#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvDedicatedAllocationImageAliasing;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_dedicated_allocation_image_aliasing - device extension (nr. 241) - author 'NVIDIA' [platform '' | contact
///     'Nuno Subtil @nsubtil']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_dedicated_allocation_image_aliasing.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_dedicated_allocation_image_aliasing.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_dedicated_allocation")]
public static class VkNvDedicatedAllocationImageAliasing
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME = "VK_NV_dedicated_allocation_image_aliasing";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4544\u4944\u4143\u4554\u5f44\u4c41\u4f4c\u4143\u4954\u4e4f\u495f\u414d\u4547\u415f\u494c\u5341\u4e49\u5f47\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}