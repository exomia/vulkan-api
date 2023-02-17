#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvRayTracingMotionBlur;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_ray_tracing_motion_blur - device extension (nr. 328) - author 'NV' [platform '' | contact 'Eric Werness']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_ray_tracing_motion_blur.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_ray_tracing_motion_blur.html</a>
/// </summary>
public static class VkNvRayTracingMotionBlur
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME = "VK_NV_ray_tracing_motion_blur";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4152\u5f59\u5254\u4341\u4e49\u5f47\u4f4d\u4954\u4e4f\u425f\u554c\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}