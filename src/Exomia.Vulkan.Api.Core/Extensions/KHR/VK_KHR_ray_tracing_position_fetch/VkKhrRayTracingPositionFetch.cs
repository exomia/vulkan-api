#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrRayTracingPositionFetch;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_ray_tracing_position_fetch - device extension (nr. 482) - author 'KHR' [platform '' | contact 'Eric
///     Werness']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_position_fetch.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_ray_tracing_position_fetch.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_acceleration_structure")]
[VkDeviceExt]
public static class VkKhrRayTracingPositionFetch
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_RAY_TRACING_POSITION_FETCH_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME = "VK_KHR_ray_tracing_position_fetch";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_RAY_TRACING_POSITION_FETCH_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u525f\u5941\u545f\u4152\u4943\u474e\u505f\u534f\u5449\u4f49\u5f4e\u4546\u4354\u5f48\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}