#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtExternalMemoryDmaBuf;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_external_memory_dma_buf - device extension (nr. 126) - author 'EXT' [platform '' | contact 'Lina Versace
///     @linyaa-kiwi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_external_memory_dma_buf.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_external_memory_dma_buf.html</a>
/// </summary>
[VkDepends("VK_KHR_external_memory_fd")]
[VkDeviceExt]
public static class VkExtExternalMemoryDmaBuf
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME = "VK_EXT_external_memory_dma_buf";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u455f\u5458\u5245\u414e\u5f4c\u454d\u4f4d\u5952\u445f\u414d\u425f\u4655\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";
}