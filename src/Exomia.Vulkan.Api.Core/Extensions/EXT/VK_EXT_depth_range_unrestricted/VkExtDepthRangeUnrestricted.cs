#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_depth_range_unrestricted - device extension (nr. 14) - author 'NV' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_range_unrestricted.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_range_unrestricted.html
///     </a>
/// </summary>
public static class VkExtDepthRangeUnrestricted
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME = "VK_EXT_depth_range_unrestricted";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5045\u4854\u525f\u4e41\u4547\u555f\u524e\u5345\u5254\u4349\u4554\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}