#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvSampleMaskOverrideCoverage;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_sample_mask_override_coverage - device extension (nr. 95) - author 'NV' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_sample_mask_override_coverage.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_sample_mask_override_coverage.html
///     </a>
/// </summary>
public static class VkNvSampleMaskOverrideCoverage
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME = "VK_NV_sample_mask_override_coverage";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4153\u504d\u454c\u4d5f\u5341\u5f4b\u564f\u5245\u4952\u4544\u435f\u564f\u5245\u4741\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}