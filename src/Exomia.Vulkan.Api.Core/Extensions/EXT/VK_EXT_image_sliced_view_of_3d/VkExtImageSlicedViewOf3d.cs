#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtImageSlicedViewOf3d;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_image_sliced_view_of_3d - device extension (nr. 419) - author 'EXT' [platform '' | contact 'Mike
///     Blumenkrantz @zmike']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_sliced_view_of_3d.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_image_sliced_view_of_3d.html</a>
/// </summary>
/// <remarks>
///     specialuse: d3demulation
/// </remarks>
[VkSpecialuse("d3demulation")]
public static class VkExtImageSlicedViewOf3d
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_IMAGE_SLICED_VIEW_OF_3D_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME = "VK_EXT_image_sliced_view_of_3d";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_IMAGE_SLICED_VIEW_OF_3D_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u495f\u414d\u4547\u535f\u494c\u4543\u5f44\u4956\u5745\u4f5f\u5f46\u4433\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    public const uint VK_REMAINING_3D_SLICES_EXT = (~0U);
}