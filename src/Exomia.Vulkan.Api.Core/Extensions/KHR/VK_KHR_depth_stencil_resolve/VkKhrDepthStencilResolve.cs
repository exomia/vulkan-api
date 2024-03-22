#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDepthStencilResolve;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_depth_stencil_resolve - device extension (nr. 200) - author 'KHR' [platform '' | contact 'Jan-Harald
///     Fredriksen @janharald']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_depth_stencil_resolve.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_depth_stencil_resolve.html</a>
/// </summary>
[VkDepends("VK_KHR_create_renderpass2,VK_VERSION_1_2")]
[VkDeviceExt]
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_depth_stencil_resolve.html#_deprecation_state")]
public static class VkKhrDepthStencilResolve
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME = "VK_KHR_depth_stencil_resolve";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u5045\u4854\u535f\u4554\u434e\u4c49\u525f\u5345\u4c4f\u4556\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}