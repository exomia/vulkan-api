#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtPrimitiveTopologyListRestart;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_primitive_topology_list_restart - device extension (nr. 357) - author 'EXT' [platform '' | contact 'Shahbaz
///     Youssefi @syoussefi']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_primitive_topology_list_restart.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_primitive_topology_list_restart.html
///     </a>
/// </summary>
/// <remarks>
///     specialuse: glemulation
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkSpecialuse("glemulation")]
[VkDeviceExt]
public static class VkExtPrimitiveTopologyListRestart
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME = "VK_EXT_primitive_topology_list_restart";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_PRIMITIVE_TOPOLOGY_LIST_RESTART_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u505f\u4952\u494d\u4954\u4556\u545f\u504f\u4c4f\u474f\u5f59\u494c\u5453\u525f\u5345\u4154\u5452\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}