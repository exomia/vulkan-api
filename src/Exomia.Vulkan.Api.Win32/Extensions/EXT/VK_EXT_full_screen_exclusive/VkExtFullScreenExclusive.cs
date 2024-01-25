#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Win32.VkExtFullScreenExclusive;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///     VK_EXT_full_screen_exclusive - device extension (nr. 256) - author 'EXT' [platform 'win32' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_full_screen_exclusive.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_full_screen_exclusive.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2+VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain")]
[VkDeviceExt]
public static unsafe class VkExtFullScreenExclusive
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME = "VK_EXT_full_screen_exclusive";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u465f\u4c55\u5f4c\u4353\u4552\u4e45\u455f\u4358\u554c\u4953\u4556\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceSurfacePresentModes2EXT - Query supported presentation modes -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModes2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModes2EXT.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device that will be associated with the swapchain to be
    ///     created, as described for vkCreateSwapchainKHR.
    /// </param>
    /// <param name="pSurfaceInfo">
    ///     pSurfaceInfo is a pointer to a VkPhysicalDeviceSurfaceInfo2KHR structure describing the
    ///     surface and other fixed parameters that would be consumed by vkCreateSwapchainKHR.
    /// </param>
    /// <param name="pPresentModeCount">
    ///     pPresentModeCount is a pointer to an integer related to the number of presentation
    ///     modes available or queried, as described below.
    /// </param>
    /// <param name="pPresentModes">
    ///     pPresentModes is either NULL or a pointer to an array of VkPresentModeKHR values,
    ///     indicating the supported presentation modes.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS,VK_INCOMPLETE</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkPhysicalDeviceSurfaceInfo2KHR* /*pSurfaceInfo*/,
        uint* /*pPresentModeCount*/,
        VkPresentModeKHR* /*pPresentModes*/,
        VkResult> vkGetPhysicalDeviceSurfacePresentModes2EXT = null;

    /// <summary>
    ///     vkAcquireFullScreenExclusiveModeEXT - Acquire full-screen exclusive mode for a swapchain -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireFullScreenExclusiveModeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to acquire exclusive full-screen access for.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkSwapchainKHR /*swapchain*/,
        VkResult> vkAcquireFullScreenExclusiveModeEXT = null;

    /// <summary>
    ///     vkReleaseFullScreenExclusiveModeEXT - Release full-screen exclusive mode from a swapchain -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseFullScreenExclusiveModeEXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the device associated with swapchain.</param>
    /// <param name="swapchain">swapchain is the swapchain to release exclusive full-screen access from.</param>
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
        VkSwapchainKHR /*swapchain*/,
        VkResult> vkReleaseFullScreenExclusiveModeEXT = null;

    /// <summary>
    ///     vkGetDeviceGroupSurfacePresentModes2EXT - Query device group present capabilities for a surface -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModes2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDeviceGroupSurfacePresentModes2EXT.html
    ///     </a>
    /// </summary>
    /// <param name="device">device is the logical device.</param>
    /// <param name="pSurfaceInfo">
    ///     pSurfaceInfo is a pointer to a VkPhysicalDeviceSurfaceInfo2KHR structure describing the
    ///     surface and other fixed parameters that would be consumed by vkCreateSwapchainKHR.
    /// </param>
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
        VkPhysicalDeviceSurfaceInfo2KHR* /*pSurfaceInfo*/,
        VkDeviceGroupPresentModeFlagsKHR* /*pModes*/,
        VkResult> vkGetDeviceGroupSurfacePresentModes2EXT = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfacePresentModes2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult>* pvkGetPhysicalDeviceSurfacePresentModes2EXT =
            &vkGetPhysicalDeviceSurfacePresentModes2EXT)
        {
            *pvkGetPhysicalDeviceSurfacePresentModes2EXT = (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkPresentModeKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u7250\u7365\u6e65\u4d74\u646f\u7365\u4532\u5458\u0000");
        }
    }

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkAcquireFullScreenExclusiveModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkReleaseFullScreenExclusiveModeEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDeviceGroupSurfacePresentModes2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkSwapchainKHR, VkResult>* pvkAcquireFullScreenExclusiveModeEXT = &vkAcquireFullScreenExclusiveModeEXT)
        {
            *pvkAcquireFullScreenExclusiveModeEXT = (delegate*<VkDevice, VkSwapchainKHR, VkResult>)GetVkFunction(
                device, "\u6b76\u6341\u7571\u7269\u4665\u6c75\u536c\u7263\u6565\u456e\u6378\u756c\u6973\u6576\u6f4d\u6564\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkSwapchainKHR, VkResult>* pvkReleaseFullScreenExclusiveModeEXT = &vkReleaseFullScreenExclusiveModeEXT)
        {
            *pvkReleaseFullScreenExclusiveModeEXT = (delegate*<VkDevice, VkSwapchainKHR, VkResult>)GetVkFunction(
                device, "\u6b76\u6552\u656c\u7361\u4665\u6c75\u536c\u7263\u6565\u456e\u6378\u756c\u6973\u6576\u6f4d\u6564\u5845\u0054");
        }

        fixed (delegate*<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult>* pvkGetDeviceGroupSurfacePresentModes2EXT = &vkGetDeviceGroupSurfacePresentModes2EXT)
        {
            *pvkGetDeviceGroupSurfacePresentModes2EXT = (delegate*<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult>)GetVkFunction(
                device, "\u6b76\u6547\u4474\u7665\u6369\u4765\u6f72\u7075\u7553\u6672\u6361\u5065\u6572\u6573\u746e\u6f4d\u6564\u3273\u5845\u0054");
        }
    }
}