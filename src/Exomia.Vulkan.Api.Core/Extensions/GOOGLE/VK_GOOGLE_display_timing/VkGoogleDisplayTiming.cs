#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkGoogleDisplayTiming;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_GOOGLE_display_timing - device extension (nr. 93) - author 'GOOGLE' [platform '' | contact 'Ian Elliott
///     @ianelliottus']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_display_timing.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_GOOGLE_display_timing.html</a>
/// </summary>
public static unsafe class VkGoogleDisplayTiming
{
    /// <summary> The spec version. </summary>
    public const uint VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME = "VK_GOOGLE_display_timing";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME_UTF8_NT = "\u4b56\u475f\u4f4f\u4c47\u5f45\u4944\u5053\u414c\u5f59\u4954\u494d\u474e\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetRefreshCycleDurationGOOGLE - Obtain the RC duration of the PE's display -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRefreshCycleDurationGOOGLE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRefreshCycleDurationGOOGLE.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to obtain the refresh duration for.</param>
    /// <param name="pDisplayTimingProperties">
    ///     pDisplayTimingProperties is a pointer to a VkRefreshCycleDurationGOOGLE
    ///     structure.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkRefreshCycleDurationGOOGLE* /*pDisplayTimingProperties*/,
        VkResult> vkGetRefreshCycleDurationGOOGLE = null;

    /// <summary>
    ///     vkGetPastPresentationTimingGOOGLE - Obtain timing of a previously-presented image -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingGOOGLE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPastPresentationTimingGOOGLE.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to obtain presentation timing information duration for.</param>
    /// <param name="pPresentationTimingCount">
    ///     pPresentationTimingCount is a pointer to an integer related to the number of
    ///     VkPastPresentationTimingGOOGLE structures to query, as described below.
    /// </param>
    /// <param name="pPresentationTimings">
    ///     pPresentationTimings is either NULL or a pointer to an array of
    ///     VkPastPresentationTimingGOOGLE structures.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_OUT_OF_DATE_KHR,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        uint* /*pPresentationTimingCount*/,
        VkPastPresentationTimingGOOGLE* /*pPresentationTimings*/,
        VkResult> vkGetPastPresentationTimingGOOGLE = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetRefreshCycleDurationGOOGLE</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPastPresentationTimingGOOGLE</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>* pvkGetRefreshCycleDurationGOOGLE = &vkGetRefreshCycleDurationGOOGLE)
        {
            *pvkGetRefreshCycleDurationGOOGLE = (delegate*<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5274\u6665\u6572\u6873\u7943\u6c63\u4465\u7275\u7461\u6f69\u476e\u4f4f\u4c47\u0045");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult>* pvkGetPastPresentationTimingGOOGLE = &vkGetPastPresentationTimingGOOGLE)
        {
            *pvkGetPastPresentationTimingGOOGLE = (delegate*<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u5074\u7361\u5074\u6572\u6573\u746e\u7461\u6f69\u546e\u6d69\u6e69\u4767\u4f4f\u4c47\u0045");
        }
    }
}