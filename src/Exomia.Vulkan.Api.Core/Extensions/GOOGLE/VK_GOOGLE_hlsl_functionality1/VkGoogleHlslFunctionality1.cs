#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkGoogleHlslFunctionality1;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_GOOGLE_hlsl_functionality1 - device extension (nr. 224) - author 'GOOGLE' [platform '' | contact 'Hai Nguyen
///     @chaoticbob']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_hlsl_functionality1.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_hlsl_functionality1.html</a>
/// </summary>
[VkDeviceExt]
public static class VkGoogleHlslFunctionality1
{
    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME = "VK_GOOGLE_hlsl_functionality1";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u475f\u4f4f\u4c47\u5f45\u4c48\u4c53\u465f\u4e55\u5443\u4f49\u414e\u494c\u5954\u315f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME = VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME;

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u475f\u4f4f\u4c47\u5f45\u4c48\u4c53\u465f\u4e55\u5443\u4f49\u414e\u494c\u5954\u5f31\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}