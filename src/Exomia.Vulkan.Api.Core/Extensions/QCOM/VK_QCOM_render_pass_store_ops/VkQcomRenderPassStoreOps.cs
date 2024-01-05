#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkQcomRenderPassStoreOps;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_QCOM_render_pass_store_ops - device extension (nr. 302) - author 'QCOM' [platform '' | contact 'Matthew Netsch
///     @mnetsch']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_render_pass_store_ops.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QCOM_render_pass_store_ops.html</a>
/// </summary>
[VkDeviceExt]
public static class VkQcomRenderPassStoreOps
{
    /// <summary> The spec version. </summary>
    public const uint VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME = "VK_QCOM_render_pass_store_ops";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u515f\u4f43\u5f4d\u4552\u444e\u5245\u505f\u5341\u5f53\u5453\u524f\u5f45\u504f\u5f53\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";
}