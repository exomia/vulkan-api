#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvMemoryDecompression;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_memory_decompression - device extension (nr. 428) - author 'NV' [platform '' | contact 'Vikram Kushwaha
///     @vkushwaha-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_memory_decompression.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_memory_decompression.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2,VK_KHR_buffer_device_address")]
public static unsafe class VkNvMemoryDecompression
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_MEMORY_DECOMPRESSION_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME = "VK_NV_memory_decompression";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_MEMORY_DECOMPRESSION_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4e5f\u5f56\u454d\u4f4d\u5952\u445f\u4345\u4d4f\u5250\u5345\u4953\u4e4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdDecompressMemoryNV - Decompress data between memory regions -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryNV.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="decompressRegionCount">decompressRegionCount is the number of memory regions to decompress.</param>
    /// <param name="pDecompressMemoryRegions">
    ///     pDecompressMemoryRegions is a pointer to an array of decompressRegionCount
    ///     VkDecompressMemoryRegionNV structures specifying decompression parameters.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*decompressRegionCount*/,
        VkDecompressMemoryRegionNV* /*pDecompressMemoryRegions*/,
        void> vkCmdDecompressMemoryNV = null;

    /// <summary>
    ///     vkCmdDecompressMemoryIndirectCountNV - Indirect decompress data between memory regions -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountNV.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDecompressMemoryIndirectCountNV.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="indirectCommandsAddress">
    ///     indirectCommandsAddress is the device address containing decompression parameters
    ///     laid out as an array of VkDecompressMemoryRegionNV structures.
    /// </param>
    /// <param name="indirectCommandsCountAddress">
    ///     indirectCommandsCountAddress is the device address containing the
    ///     decompression count.
    /// </param>
    /// <param name="stride">
    ///     stride is the byte stride between successive sets of decompression parameters located starting
    ///     from indirectCommandsAddress.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDeviceAddress /*indirectCommandsAddress*/,
        VkDeviceAddress /*indirectCommandsCountAddress*/,
        uint /*stride*/,
        void> vkCmdDecompressMemoryIndirectCountNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdDecompressMemoryNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDecompressMemoryIndirectCountNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void>* pvkCmdDecompressMemoryNV = &vkCmdDecompressMemoryNV)
        {
            *pvkCmdDecompressMemoryNV = (delegate*<VkCommandBuffer, uint, VkDecompressMemoryRegionNV*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6365\u6d6f\u7270\u7365\u4d73\u6d65\u726f\u4e79\u0056");
        }

        fixed (delegate*<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void>* pvkCmdDecompressMemoryIndirectCountNV = &vkCmdDecompressMemoryIndirectCountNV)
        {
            *pvkCmdDecompressMemoryIndirectCountNV = (delegate*<VkCommandBuffer, VkDeviceAddress, VkDeviceAddress, uint, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6365\u6d6f\u7270\u7365\u4d73\u6d65\u726f\u4979\u646e\u7269\u6365\u4374\u756f\u746e\u564e\u0000");
        }
    }
}