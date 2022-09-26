#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDisplayControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_display_control - device extension (nr. 92) - author 'NV' [platform '' | contact 'James Jones @cubanismo']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_display_control.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_display_control.html </a>
/// </summary>
[VkRequires("VK_EXT_display_surface_counter,VK_KHR_swapchain")]
public static unsafe class VkExtDisplayControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME = "VK_EXT_display_control";

    /// <summary> An UTF8 null terminated version of <see cref="VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.
    ///     <br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u5349\u4c50\u5941\u435f\u4e4f\u5254\u4c4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkDisplayPowerControlEXT - Set the power state of a display -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDisplayPowerControlEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDisplayPowerControlEXT.html </a>
    /// </summary>
    /// <param name="device"> device is a logical device associated with display. </param>
    /// <param name="display"> display is the display whose power state is modified. </param>
    /// <param name="pDisplayPowerInfo"> pDisplayPowerInfo is a pointer to a VkDisplayPowerInfoEXTstructure specifying the new power state of display. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDisplayKHR /*display*/,
        VkDisplayPowerInfoEXT* /*pDisplayPowerInfo*/,
        VkResult> vkDisplayPowerControlEXT = null;

    /// <summary>
    ///     vkRegisterDeviceEventEXT - Signal a fence when a device event occurs -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkRegisterDeviceEventEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkRegisterDeviceEventEXT.html </a>
    /// </summary>
    /// <param name="device"> device is a logical device on which the event may occur. </param>
    /// <param name="pDeviceEventInfo"> pDeviceEventInfo is a pointer to a VkDeviceEventInfoEXTstructure describing the event of interest to the application. </param>
    /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the Memory Allocation chapter. </param>
    /// <param name="pFence"> pFence is a pointer to a handle in which the resulting fence object is returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDeviceEventInfoEXT* /*pDeviceEventInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkFence* /*pFence*/,
        VkResult> vkRegisterDeviceEventEXT = null;

    /// <summary>
    ///     vkRegisterDisplayEventEXT - Signal a fence when a display event occurs -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkRegisterDisplayEventEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkRegisterDisplayEventEXT.html </a>
    /// </summary>
    /// <param name="device"> device is a logical device associated with display </param>
    /// <param name="display"> display is the display on which the event may occur. </param>
    /// <param name="pDisplayEventInfo"> pDisplayEventInfo is a pointer to a VkDisplayEventInfoEXTstructure describing the event of interest to the application. </param>
    /// <param name="pAllocator"> pAllocator controls host memory allocation as described in the Memory Allocation chapter. </param>
    /// <param name="pFence"> pFence is a pointer to a handle in which the resulting fence object is returned. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term><description> VK_ERROR_OUT_OF_HOST_MEMORY </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDisplayKHR /*display*/,
        VkDisplayEventInfoEXT* /*pDisplayEventInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkFence* /*pFence*/,
        VkResult> vkRegisterDisplayEventEXT = null;

    /// <summary>
    ///     vkGetSwapchainCounterEXT - Query the current value of a surface counter -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainCounterEXT.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetSwapchainCounterEXT.html </a>
    /// </summary>
    /// <param name="device"> device is the VkDevice associated with swapchain. </param>
    /// <param name="swapchain"> swapchain is the swapchain from which to query the counter value. </param>
    /// <param name="counter"> counter is a VkSurfaceCounterFlagBitsEXT value specifying the counter to query. </param>
    /// <param name="pCounterValue"> pCounterValue will return the current value of the counter. </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term> successcodes </term><description> VK_SUCCESS </description>
    ///         </item>
    ///         <item>
    ///             <term> errorcodes </term>
    ///             <description> VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkSurfaceCounterFlagBitsEXT /*counter*/,
        ulong* /*pCounterValue*/,
        VkResult> vkGetSwapchainCounterEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description> vkDisplayPowerControlEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkRegisterDeviceEventEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkRegisterDisplayEventEXT </description>
    ///         </item>
    ///         <item>
    ///             <description> vkGetSwapchainCounterEXT </description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>* pvkDisplayPowerControlEXT = &vkDisplayPowerControlEXT)
        {
            *pvkDisplayPowerControlEXT = (delegate*<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6944\u7073\u616c\u5079\u776f\u7265\u6f43\u746e\u6f72\u456c\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>* pvkRegisterDeviceEventEXT = &vkRegisterDeviceEventEXT)
        {
            *pvkRegisterDeviceEventEXT = (delegate*<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)GetVkFunction(
                device, "\u6b76\u6552\u6967\u7473\u7265\u6544\u6976\u6563\u7645\u6e65\u4574\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>* pvkRegisterDisplayEventEXT = &vkRegisterDisplayEventEXT)
        {
            *pvkRegisterDisplayEventEXT = (delegate*<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult>)GetVkFunction(
                device, "\u6b76\u6552\u6967\u7473\u7265\u6944\u7073\u616c\u4579\u6576\u746e\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult>* pvkGetSwapchainCounterEXT = &vkGetSwapchainCounterEXT)
        {
            *pvkGetSwapchainCounterEXT = (delegate*<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagBitsEXT, ulong*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5374\u6177\u6370\u6168\u6e69\u6f43\u6e75\u6574\u4572\u5458\u0000");
        }
    }
}