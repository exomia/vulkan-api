#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrPresentWait;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_present_wait - device extension (nr. 249) - author 'KHR' [platform '' | contact 'Keith Packard @keithp']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_present_wait.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_present_wait.html</a>
/// </summary>
[VkRequires("VK_KHR_swapchain,VK_KHR_present_id")]
public static unsafe class VkKhrPresentWait
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PRESENT_WAIT_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PRESENT_WAIT_EXTENSION_NAME = "VK_KHR_present_wait";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PRESENT_WAIT_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PRESENT_WAIT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PRESENT_WAIT_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u505f\u4552\u4553\u544e\u575f\u4941\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkWaitForPresentKHR - Wait for presentation -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitForPresentKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWaitForPresentKHR.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the non-retired swapchain on which an image was queued for presentation.</param>
    /// <param name="presentId">presentId is the presentation presentId to wait for.</param>
    /// <param name="timeout">
    ///     timeout is the timeout period in units of nanoseconds. timeout is adjusted to the closest value
    ///     allowed by the implementation-dependent timeout accuracy, which may be substantially longer than one nanosecond,
    ///     and may be longer than the requested period.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_TIMEOUT,VK_SUBOPTIMAL_KHR</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR,VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        ulong /*presentId*/,
        ulong /*timeout*/,
        VkResult> vkWaitForPresentKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkWaitForPresentKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult>* pvkWaitForPresentKHR = &vkWaitForPresentKHR)
        {
            *pvkWaitForPresentKHR = (delegate*<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult>)GetVkFunction(device, "\u6b76\u6157\u7469\u6f46\u5072\u6572\u6573\u746e\u484b\u0052");
        }
    }
}