#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvCopyMemoryIndirect;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_copy_memory_indirect - device extension (nr. 427) - author 'NV' [platform '' | contact 'Vikram Kushwaha
///     @vkushwaha-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_copy_memory_indirect.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_copy_memory_indirect.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address")]
[VkDeviceExt]
public static unsafe class VkNvCopyMemoryIndirect
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_COPY_MEMORY_INDIRECT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME = "VK_NV_copy_memory_indirect";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_COPY_MEMORY_INDIRECT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u4f43\u5950\u4d5f\u4d45\u524f\u5f59\u4e49\u4944\u4552\u5443\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdCopyMemoryIndirectNV - Copy data between memory regions -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryIndirectNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="copyBufferAddress">
    ///     copyBufferAddress is the buffer address specifying the copy parameters. This buffer is
    ///     laid out in memory as an array of VkCopyMemoryIndirectCommandNV structures.
    /// </param>
    /// <param name="copyCount">copyCount is the number of copies to execute, and can be zero.</param>
    /// <param name="stride">stride is the stride in bytes between successive sets of copy parameters.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*copyBufferAddress*/,
        uint /*copyCount*/,
        uint /*stride*/,
        void> vkCmdCopyMemoryIndirectNV = null;

    /// <summary>
    ///     vkCmdCopyMemoryToImageIndirectNV - Copy data from a memory region into an image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdCopyMemoryToImageIndirectNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="copyBufferAddress">
    ///     copyBufferAddress is the buffer address specifying the copy parameters. This buffer is
    ///     laid out in memory as an array of VkCopyMemoryToImageIndirectCommandNV structures.
    /// </param>
    /// <param name="copyCount">copyCount is the number of copies to execute, and can be zero.</param>
    /// <param name="stride">stride is the byte stride between successive sets of copy parameters.</param>
    /// <param name="dstImage">dstImage is the destination image.</param>
    /// <param name="dstImageLayout">dstImageLayout is the layout of the destination image subresources for the copy.</param>
    /// <param name="pImageSubresources">
    ///     pImageSubresources is a pointer to an array of size copyCount of
    ///     VkImageSubresourceLayers used to specify the specific image subresource of the destination image data for that
    ///     copy.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*copyBufferAddress*/,
        uint /*copyCount*/,
        uint /*stride*/,
        VkImage /*dstImage*/,
        VkImageLayout /*dstImageLayout*/,
        VkImageSubresourceLayers* /*pImageSubresources*/,
        void> vkCmdCopyMemoryToImageIndirectNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdCopyMemoryIndirectNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdCopyMemoryToImageIndirectNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, uint, uint, void>* pvkCmdCopyMemoryIndirectNV = &vkCmdCopyMemoryIndirectNV)
        {
            *pvkCmdCopyMemoryIndirectNV = (delegate*<VkCommandBuffer, VkDeviceAddress, uint, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4d79\u6d65\u726f\u4979\u646e\u7269\u6365\u4e74\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>* pvkCmdCopyMemoryToImageIndirectNV = &vkCmdCopyMemoryToImageIndirectNV)
        {
            *pvkCmdCopyMemoryToImageIndirectNV = (delegate*<VkCommandBuffer, VkDeviceAddress, uint, uint, VkImage, VkImageLayout, VkImageSubresourceLayers*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4364\u706f\u4d79\u6d65\u726f\u5479\u496f\u616d\u6567\u6e49\u6964\u6572\u7463\u564e\u0000");
        }
    }
}