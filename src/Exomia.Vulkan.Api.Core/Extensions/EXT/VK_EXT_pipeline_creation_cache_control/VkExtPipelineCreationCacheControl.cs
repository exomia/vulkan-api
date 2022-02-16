﻿#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPipelineCreationCacheControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_pipeline_creation_cache_control - device extension (nr. 298) - author 'AMD' [platform '' | contact 'Gregory
///     Grebe @grgrebe_amd']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pipeline_creation_cache_control.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pipeline_creation_cache_control.html
///     </a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_3", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_pipeline_creation_cache_control.html#_deprecation_state")]
public static class VkExtPipelineCreationCacheControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = 3;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME = "VK_EXT_pipeline_creation_cache_control";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u505f\u5049\u4c45\u4e49\u5f45\u5243\u4145\u4954\u4e4f\u435f\u4341\u4548\u435f\u4e4f\u5254\u4c4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}