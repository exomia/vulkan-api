#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrGlobalPriority;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_global_priority - device extension (nr. 189) - author 'KHR' [platform '' | contact 'Tobias Hector @tobski']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_global_priority.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_global_priority.html</a>
/// </summary>
public static class VkKhrGlobalPriority
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_GLOBAL_PRIORITY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME = "VK_KHR_global_priority";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_GLOBAL_PRIORITY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u475f\u4f4c\u4142\u5f4c\u5250\u4f49\u4952\u5954\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     VK_MAX_GLOBAL_PRIORITY_SIZE_KHR - Length of an array of global queue priorities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_GLOBAL_PRIORITY_SIZE_KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_GLOBAL_PRIORITY_SIZE_KHR.html
    ///     </a>
    /// </summary>
    public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_KHR = 16;
}