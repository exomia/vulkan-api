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
///     VK_KHR_draw_indirect_count - device extension (nr. 170) - author 'KHR' [platform '' | contact 'Piers Daniell
///     @pdaniell-nv']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_draw_indirect_count.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_draw_indirect_count.html</a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_draw_indirect_count.html#_deprecation_state")]
public static unsafe class VkKhrDrawIndirectCount
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME = "VK_KHR_draw_indirect_count";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u4152\u5f57\u4e49\u4944\u4552\u5443\u435f\u554f\u544e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// vkCmdDrawIndirectCountKHR alias for vkCmdDrawIndirectCount
    /// <summary>
    ///     vkCmdDrawIndirectCount - Draw primitives with indirect parameters and draw count -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndirectCountKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        VkBuffer /*countBuffer*/,
        VkDeviceSize /*countBufferOffset*/,
        uint /*maxDrawCount*/,
        uint /*stride*/,
        void> vkCmdDrawIndirectCountKHR = null;

    /// vkCmdDrawIndexedIndirectCountKHR alias for vkCmdDrawIndexedIndirectCount
    /// <summary>
    ///     vkCmdDrawIndexedIndirectCount - Draw parameters with indirect parameters, indexed vertices, and draw count -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDrawIndexedIndirectCountKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        VkBuffer /*countBuffer*/,
        VkDeviceSize /*countBufferOffset*/,
        uint /*maxDrawCount*/,
        uint /*stride*/,
        void> vkCmdDrawIndexedIndirectCountKHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawIndirectCountKHR = &vkCmdDrawIndirectCountKHR)
        {
            *pvkCmdDrawIndirectCountKHR = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4977\u646e\u7269\u6365\u4374\u756f\u746e\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>* pvkCmdDrawIndexedIndirectCountKHR = &vkCmdDrawIndexedIndirectCountKHR)
        {
            *pvkCmdDrawIndexedIndirectCountKHR = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkBuffer, VkDeviceSize, uint, uint, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6172\u4977\u646e\u7865\u6465\u6e49\u6964\u6572\u7463\u6f43\u6e75\u4b74\u5248\u0000");
        }
    }
}