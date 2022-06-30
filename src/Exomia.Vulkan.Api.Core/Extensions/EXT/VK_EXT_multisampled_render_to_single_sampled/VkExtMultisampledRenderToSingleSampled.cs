#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtMultisampledRenderToSingleSampled;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_multisampled_render_to_single_sampled - device extension (nr. 377) - author 'EXT' [platform '' | contact
///     'Shahbaz Youssefi @syoussefi']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_multisampled_render_to_single_sampled.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_multisampled_render_to_single_sampled.html
///     </a>
/// </summary>
[VkRequires("VK_KHR_create_renderpass2,VK_KHR_depth_stencil_resolve")]
public static class VkExtMultisampledRenderToSingleSampled
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME = "VK_EXT_multisampled_render_to_single_sampled";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u4d5f\u4c55\u4954\u4153\u504d\u454c\u5f44\u4552\u444e\u5245\u545f\u5f4f\u4953\u474e\u454c\u535f\u4d41\u4c50\u4445\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}