#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDeviceGroup;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_device_group - device extension (nr. 61) - author 'KHR' [platform '' | contact 'Jeff Bolz @jeffbolznv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group.html</a>
/// </summary>
[VkRequires("VK_KHR_device_group_creation")]
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_device_group.html#_deprecation_state")]
public static unsafe class VkKhrDeviceGroup
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DEVICE_GROUP_SPEC_VERSION = 4;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DEVICE_GROUP_EXTENSION_NAME = "VK_KHR_device_group";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DEVICE_GROUP_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DEVICE_GROUP_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DEVICE_GROUP_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u445f\u5645\u4349\u5f45\u5247\u554f\u5f50\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkGetDeviceGroupPeerMemoryFeaturesKHR alias for vkGetDeviceGroupPeerMemoryFeatures
    /// <summary>
    ///     vkGetDeviceGroupPeerMemoryFeatures - Query supported peer memory features of a device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeaturesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPeerMemoryFeaturesKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        uint /*heapIndex*/,
        uint /*localDeviceIndex*/,
        uint /*remoteDeviceIndex*/,
        VkPeerMemoryFeatureFlags* /*pPeerMemoryFeatures*/,
        void> vkGetDeviceGroupPeerMemoryFeaturesKHR = null;

    /// vkCmdSetDeviceMaskKHR alias for vkCmdSetDeviceMask
    /// <summary>
    ///     vkCmdSetDeviceMask - Modify device mask of a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMaskKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDeviceMaskKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*deviceMask*/,
        void> vkCmdSetDeviceMaskKHR = null;

    /// vkCmdDispatchBaseKHR alias for vkCmdDispatchBase
    /// <summary>
    ///     vkCmdDispatchBase - Dispatch compute work items with non-zero base values for the workgroup IDs -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBaseKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBaseKHR.html</a>
    /// </summary>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        uint /*baseGroupX*/,
        uint /*baseGroupY*/,
        uint /*baseGroupZ*/,
        uint /*groupCountX*/,
        uint /*groupCountY*/,
        uint /*groupCountZ*/,
        void> vkCmdDispatchBaseKHR = null;

    /// <summary>
    ///     vkGetDeviceGroupPresentCapabilitiesKHR - Query present capabilities from other physical devices -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupPresentCapabilitiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device.</param>
    /// <param name="pDeviceGroupPresentCapabilities">
    ///     pDeviceGroupPresentCapabilities is a pointer to a
    ///     VkDeviceGroupPresentCapabilitiesKHR structure in which the device&#8217;s capabilities are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceGroupPresentCapabilitiesKHR* /*pDeviceGroupPresentCapabilities*/,
        VkResult> vkGetDeviceGroupPresentCapabilitiesKHR = null;

    /// <summary>
    ///     vkGetDeviceGroupSurfacePresentModesKHR - Query present capabilities for a surface -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device.</param>
    /// <param name="surface">surface is the surface.</param>
    /// <param name="pModes">
    ///     pModes is a pointer to a VkDeviceGroupPresentModeFlagsKHR in which the supported device group
    ///     present modes for the surface are returned.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSurfaceKHR /*surface*/,
        VkDeviceGroupPresentModeFlagsKHR* /*pModes*/,
        VkResult> vkGetDeviceGroupSurfacePresentModesKHR = null;

    /// <summary>
    ///     vkGetPhysicalDevicePresentRectanglesKHR - Query present rectangles for a surface on a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDevicePresentRectanglesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="surface">surface is the surface.</param>
    /// <param name="pRectCount">
    ///     pRectCount is a pointer to an integer related to the number of rectangles available or
    ///     queried, as described below.
    /// </param>
    /// <param name="pRects">pRects is either NULL or a pointer to an array of VkRect2Dstructures.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkSurfaceKHR /*surface*/,
        uint* /*pRectCount*/,
        VkRect2D* /*pRects*/,
        VkResult> vkGetPhysicalDevicePresentRectanglesKHR = null;

    /// <summary>
    ///     vkAcquireNextImage2KHR - Retrieve the index of the next available presentable image -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireNextImage2KHR.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="pAcquireInfo">
    ///     pAcquireInfo is a pointer to a VkAcquireNextImageInfoKHRstructure containing parameters of
    ///     the acquire.
    /// </param>
    /// <param name="pImageIndex">pImageIndex is a pointer to a uint32_t that is set to the index of the next image to use.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_TIMEOUT,VK_NOT_READY,VK_SUBOPTIMAL_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkAcquireNextImageInfoKHR* /*pAcquireInfo*/,
        uint* /*pImageIndex*/,
        VkResult> vkAcquireNextImage2KHR = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void>* pvkGetDeviceGroupPeerMemoryFeaturesKHR = &vkGetDeviceGroupPeerMemoryFeaturesKHR)
        {
            *pvkGetDeviceGroupPeerMemoryFeaturesKHR = (delegate*<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u6550\u7265\u654d\u6f6d\u7972\u6546\u7461\u7275\u7365\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, uint, void>* pvkCmdSetDeviceMaskKHR = &vkCmdSetDeviceMaskKHR)
        {
            *pvkCmdSetDeviceMaskKHR = (delegate*<VkCommandBuffer, uint, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u6976\u6563\u614d\u6b73\u484b\u0052");
        }
        fixed (delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>* pvkCmdDispatchBaseKHR = &vkCmdDispatchBaseKHR)
        {
            *pvkCmdDispatchBaseKHR = (delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)GetVkFunction(device, "\u6b76\u6d43\u4464\u7369\u6170\u6374\u4268\u7361\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>* pvkGetDeviceGroupPresentCapabilitiesKHR = &vkGetDeviceGroupPresentCapabilitiesKHR)
        {
            *pvkGetDeviceGroupPresentCapabilitiesKHR = (delegate*<VkDevice, VkDeviceGroupPresentCapabilitiesKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u7250\u7365\u6e65\u4374\u7061\u6261\u6c69\u7469\u6569\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>* pvkGetDeviceGroupSurfacePresentModesKHR = &vkGetDeviceGroupSurfacePresentModesKHR)
        {
            *pvkGetDeviceGroupSurfacePresentModesKHR = (delegate*<VkDevice, VkSurfaceKHR, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u7553\u6672\u6361\u5065\u6572\u6573\u746e\u6f4d\u6564\u4b73\u5248\u0000");
        }
        fixed (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>* pvkGetPhysicalDevicePresentRectanglesKHR = &vkGetPhysicalDevicePresentRectanglesKHR)
        {
            *pvkGetPhysicalDevicePresentRectanglesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkRect2D*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5065\u6572\u6573\u746e\u6552\u7463\u6e61\u6c67\u7365\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>* pvkAcquireNextImage2KHR = &vkAcquireNextImage2KHR)
        {
            *pvkAcquireNextImage2KHR = (delegate*<VkDevice, VkAcquireNextImageInfoKHR*, uint*, VkResult>)GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u4e65\u7865\u4974\u616d\u6567\u4b32\u5248\u0000");
        }
    }
}