#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrMaintenance5;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_maintenance5 - device extension (nr. 471) - author 'KHR' [platform '' | contact 'Stu Smith @stu-s']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance5.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance5.html</a>
/// </summary>
[VkDepends("VK_VERSION_1_1+VK_KHR_dynamic_rendering")]
[VkDeviceExt]
public static unsafe class VkKhrMaintenance5
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAINTENANCE_5_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAINTENANCE_5_EXTENSION_NAME = "VK_KHR_maintenance5";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAINTENANCE_5_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAINTENANCE_5_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAINTENANCE_5_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u355f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdBindIndexBuffer2KHR - Bind an index buffer to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindIndexBuffer2KHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="buffer">buffer is the buffer being bound.</param>
    /// <param name="offset">offset is the starting offset in bytes within buffer used in index buffer address calculations.</param>
    /// <param name="size">size is the size in bytes of index data bound from buffer.</param>
    /// <param name="indexType">indexType is a VkIndexType value specifying the size of the indices.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBuffer /*buffer*/,
        VkDeviceSize /*offset*/,
        VkDeviceSize /*size*/,
        VkIndexType /*indexType*/,
        void> vkCmdBindIndexBuffer2KHR = null;

    /// <summary>
    ///     vkGetRenderingAreaGranularityKHR - Returns the granularity for dynamic rendering optimal render area -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularityKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRenderingAreaGranularityKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the render pass instance.</param>
    /// <param name="pRenderingAreaInfo">
    ///     pRenderingAreaInfo is a pointer to a VkRenderingAreaInfoKHRstructure specifying
    ///     details of the render pass instance to query the render area granularity for.
    /// </param>
    /// <param name="pGranularity">pGranularity is a pointer to a VkExtent2D structure in which the granularity is returned.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkRenderingAreaInfoKHR* /*pRenderingAreaInfo*/,
        VkExtent2D* /*pGranularity*/,
        void> vkGetRenderingAreaGranularityKHR = null;

    /// <summary>
    ///     vkGetDeviceImageSubresourceLayoutKHR - Retrieve information about an image subresource without an image object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayoutKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceImageSubresourceLayoutKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="pInfo">
    ///     pInfo is a pointer to a VkDeviceImageSubresourceInfoKHRstructure containing parameters required for
    ///     the subresource layout query.
    /// </param>
    /// <param name="pLayout">pLayout is a pointer to a VkSubresourceLayout2KHR structure in which the layout is returned.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceImageSubresourceInfoKHR* /*pInfo*/,
        VkSubresourceLayout2KHR* /*pLayout*/,
        void> vkGetDeviceImageSubresourceLayoutKHR = null;

    /// <summary>
    ///     vkGetImageSubresourceLayout2KHR - Retrieve information about an image subresource -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetImageSubresourceLayout2KHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device that owns the image.</param>
    /// <param name="image">image is the image whose layout is being queried.</param>
    /// <param name="pSubresource">
    ///     pSubresource is a pointer to a VkImageSubresource2KHRstructure selecting a specific image
    ///     for the image subresource.
    /// </param>
    /// <param name="pLayout">pLayout is a pointer to a VkSubresourceLayout2KHR structure in which the layout is returned.</param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkImage /*image*/,
        VkImageSubresource2KHR* /*pSubresource*/,
        VkSubresourceLayout2KHR* /*pLayout*/,
        void> vkGetImageSubresourceLayout2KHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBindIndexBuffer2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetRenderingAreaGranularityKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDeviceImageSubresourceLayoutKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetImageSubresourceLayout2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, VkIndexType, void>* pvkCmdBindIndexBuffer2KHR = &vkCmdBindIndexBuffer2KHR)
        {
            *pvkCmdBindIndexBuffer2KHR = (delegate*<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, VkIndexType, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4964\u646e\u7865\u7542\u6666\u7265\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void>* pvkGetRenderingAreaGranularityKHR = &vkGetRenderingAreaGranularityKHR)
        {
            *pvkGetRenderingAreaGranularityKHR = (delegate*<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void>)GetVkFunction(
                device, "\u6b76\u6547\u5274\u6e65\u6564\u6972\u676e\u7241\u6165\u7247\u6e61\u6c75\u7261\u7469\u4b79\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void>* pvkGetDeviceImageSubresourceLayoutKHR = &vkGetDeviceImageSubresourceLayoutKHR)
        {
            *pvkGetDeviceImageSubresourceLayoutKHR = (delegate*<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4965\u616d\u6567\u7553\u7262\u7365\u756f\u6372\u4c65\u7961\u756f\u4b74\u5248\u0000");
        }

        fixed (delegate*<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>* pvkGetImageSubresourceLayout2KHR = &vkGetImageSubresourceLayout2KHR)
        {
            *pvkGetImageSubresourceLayout2KHR = (delegate*<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4974\u616d\u6567\u7553\u7262\u7365\u756f\u6372\u4c65\u7961\u756f\u3274\u484b\u0052");
        }
    }
}