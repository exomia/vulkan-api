#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Ggp.VkGgpFrameToken;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Ggp;

/// <summary>
///     VK_GGP_frame_token - device extension (nr. 192) - author 'GGP' [platform 'ggp' | contact 'Jean-Francois Roy
///     @jfroy']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GGP_frame_token.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GGP_frame_token.html</a>
/// </summary>
[VkDepends("VK_KHR_swapchain+VK_GGP_stream_descriptor_surface")]
[VkDeviceExt]
public static class VkGgpFrameToken
{
    /// <summary> The spec version. </summary>
    public const uint VK_GGP_FRAME_TOKEN_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GGP_FRAME_TOKEN_EXTENSION_NAME = "VK_GGP_frame_token";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GGP_FRAME_TOKEN_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GGP_FRAME_TOKEN_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GGP_FRAME_TOKEN_EXTENSION_NAME_UTF8_NT = "\u4b56\u475f\u5047\u465f\u4152\u454d\u545f\u4b4f\u4e45\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}