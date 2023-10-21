#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkNvLowLatency2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_NV_low_latency2 - device extension (nr. 506) - author 'NV' [platform '' | contact 'Charles Hansen @cshansen']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_low_latency2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_low_latency2.html</a>
/// </summary>
[VkDeviceExt]
public static unsafe class VkNvLowLatency2
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_LOW_LATENCY_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_NV_LOW_LATENCY_2_EXTENSION_NAME = "VK_NV_low_latency2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_NV_LOW_LATENCY_2_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_NV_LOW_LATENCY_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_LOW_LATENCY_2_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4f4c\u5f57\u414c\u4554\u434e\u5f59\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkSetLatencySleepModeNV - Enable or Disable low latency mode on a swapchain -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLatencySleepModeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLatencySleepModeNV.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to enable or disable low latency mode on.</param>
    /// <param name="pSleepModeInfo">
    ///     pSleepModeInfo is NULL or a pointer to a VkLatencySleepModeInfoNV structure specifying the
    ///     parameters of the latency sleep mode.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkLatencySleepModeInfoNV* /*pSleepModeInfo*/,
        VkResult> vkSetLatencySleepModeNV = null;

    /// <summary>
    ///     vkLatencySleepNV - Trigger low latency mode Sleep -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkLatencySleepNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkLatencySleepNV.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">
    ///     swapchain is the swapchain to delay associated CPU work based on VkLatencySubmissionPresentIdNV
    ///     submissions.
    /// </param>
    /// <param name="pSleepInfo">
    ///     pSleepInfo is a pointer to a VkLatencySleepInfoNV structure specifying the parameters of the
    ///     latency sleep.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_UNKNOWN</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkLatencySleepInfoNV* /*pSleepInfo*/,
        VkResult> vkLatencySleepNV = null;

    /// <summary>
    ///     vkSetLatencyMarkerNV - Pass in marker for timing info -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLatencyMarkerNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkSetLatencyMarkerNV.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to capture timestamps on.</param>
    /// <param name="pLatencyMarkerInfo">
    ///     VUID-vkSetLatencyMarkerNV-pLatencyMarkerInfo-parameter pLatencyMarkerInfo must be a
    ///     valid pointer to a valid VkSetLatencyMarkerInfoNV structure
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkSetLatencyMarkerInfoNV* /*pLatencyMarkerInfo*/,
        void> vkSetLatencyMarkerNV = null;

    /// <summary>
    ///     vkGetLatencyTimingsNV - Get latency marker results -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetLatencyTimingsNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetLatencyTimingsNV.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to return data from.</param>
    /// <param name="pTimingCount">
    ///     pTimingCount is a pointer to an integer related to the number of of previous frames of
    ///     latency data available or queried, as described below.
    /// </param>
    /// <param name="pLatencyMarkerInfo">
    ///     VUID-vkGetLatencyTimingsNV-pLatencyMarkerInfo-parameter pLatencyMarkerInfo must be a
    ///     valid pointer to a VkGetLatencyMarkerInfoNV structure
    /// </param>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        uint* /*pTimingCount*/,
        VkGetLatencyMarkerInfoNV* /*pLatencyMarkerInfo*/,
        void> vkGetLatencyTimingsNV = null;

    /// <summary>
    ///     vkQueueNotifyOutOfBandNV - Notify out of band queue -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueNotifyOutOfBandNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkQueueNotifyOutOfBandNV.html</a>
    /// </summary>
    /// <param name="queue">queue is the VkQueue to be marked as out of band.</param>
    /// <param name="pQueueTypeInfo">
    ///     pQueueTypeInfo is a pointer to a VkOutOfBandQueueTypeInfoNVstructure specifying the queue
    ///     type.
    /// </param>
    public static readonly delegate*<
        VkQueue /*queue*/,
        VkOutOfBandQueueTypeInfoNV* /*pQueueTypeInfo*/,
        void> vkQueueNotifyOutOfBandNV = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkSetLatencySleepModeNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkLatencySleepNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkSetLatencyMarkerNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetLatencyTimingsNV</description>
    ///         </item>
    ///         <item>
    ///             <description>vkQueueNotifyOutOfBandNV</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult>* pvkSetLatencySleepModeNV = &vkSetLatencySleepModeNV)
        {
            *pvkSetLatencySleepModeNV = (delegate*<VkDevice, VkSwapchainKHR, VkLatencySleepModeInfoNV*, VkResult>)GetVkFunction(
                device, "\u6b76\u6553\u4c74\u7461\u6e65\u7963\u6c53\u6565\u4d70\u646f\u4e65\u0056");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult>* pvkLatencySleepNV = &vkLatencySleepNV)
        {
            *pvkLatencySleepNV = (delegate*<VkDevice, VkSwapchainKHR, VkLatencySleepInfoNV*, VkResult>)GetVkFunction(device, "\u6b76\u614c\u6574\u636e\u5379\u656c\u7065\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void>* pvkSetLatencyMarkerNV = &vkSetLatencyMarkerNV)
        {
            *pvkSetLatencyMarkerNV = (delegate*<VkDevice, VkSwapchainKHR, VkSetLatencyMarkerInfoNV*, void>)GetVkFunction(device, "\u6b76\u6553\u4c74\u7461\u6e65\u7963\u614d\u6b72\u7265\u564e\u0000");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, uint*, VkGetLatencyMarkerInfoNV*, void>* pvkGetLatencyTimingsNV = &vkGetLatencyTimingsNV)
        {
            *pvkGetLatencyTimingsNV =
                (delegate*<VkDevice, VkSwapchainKHR, uint*, VkGetLatencyMarkerInfoNV*, void>)GetVkFunction(device, "\u6b76\u6547\u4c74\u7461\u6e65\u7963\u6954\u696d\u676e\u4e73\u0056");
        }

        fixed (delegate*<VkQueue, VkOutOfBandQueueTypeInfoNV*, void>* pvkQueueNotifyOutOfBandNV = &vkQueueNotifyOutOfBandNV)
        {
            *pvkQueueNotifyOutOfBandNV = (delegate*<VkQueue, VkOutOfBandQueueTypeInfoNV*, void>)GetVkFunction(device, "\u6b76\u7551\u7565\u4e65\u746f\u6669\u4f79\u7475\u664f\u6142\u646e\u564e\u0000");
        }
    }
}