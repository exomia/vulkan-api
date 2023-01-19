#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPostDepthCoverage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_post_depth_coverage - device extension (nr. 156) - author 'NV' [platform '' | contact 'Daniel Koch @dgkoch']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_post_depth_coverage.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_post_depth_coverage.html</a>
/// </summary>
public static class VkExtPostDepthCoverage
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME = "VK_EXT_post_depth_coverage";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u505f\u534f\u5f54\u4544\u5450\u5f48\u4f43\u4556\u4152\u4547\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}