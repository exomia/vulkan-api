#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_surface - instance extension (nr. 1) - author 'KHR' [platform '' | contact 'James Jones @cubanismo,Ian
///     Elliott @ianelliottus']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_surface.html</a>
/// </summary>
public static unsafe class VkKhrSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_SURFACE_SPEC_VERSION = 25;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_SURFACE_EXTENSION_NAME = "VK_KHR_surface";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_SURFACE_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_SURFACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkDestroySurfaceKHR - Destroy a VkSurfaceKHR object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySurfaceKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroySurfaceKHR.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance used to create the surface.</param>
    /// <param name="surface">surface is the surface to destroy.</param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the surface object when there
    ///     is no more specific allocator available (see Memory Allocation).
    /// </param>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkSurfaceKHR /*surface*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroySurfaceKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceSurfaceSupportKHR - Query if presentation is supported -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceSupportKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceSupportKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the queue family.</param>
    /// <param name="surface">surface is the surface.</param>
    /// <param name="pSupported">
    ///     pSupported is a pointer to a VkBool32, which is set to VK_TRUE to indicate support, and
    ///     VK_FALSE otherwise.
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
        VkPhysicalDevice /*physicalDevice*/,
        uint /*queueFamilyIndex*/,
        VkSurfaceKHR /*surface*/,
        VkBool32* /*pSupported*/,
        VkResult> vkGetPhysicalDeviceSurfaceSupportKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceSurfaceCapabilitiesKHR - Query surface capabilities -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilitiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilitiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device that will be associated with the swapchain to be
    ///     created, as described for vkCreateSwapchainKHR.
    /// </param>
    /// <param name="surface">surface is the surface that will be associated with the swapchain.</param>
    /// <param name="pSurfaceCapabilities">
    ///     pSurfaceCapabilities is a pointer to a VkSurfaceCapabilitiesKHR structure in which
    ///     the capabilities are returned.
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
        VkPhysicalDevice /*physicalDevice*/,
        VkSurfaceKHR /*surface*/,
        VkSurfaceCapabilitiesKHR* /*pSurfaceCapabilities*/,
        VkResult> vkGetPhysicalDeviceSurfaceCapabilitiesKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceSurfaceFormatsKHR - Query color formats supported by surface -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormatsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormatsKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device that will be associated with the swapchain to be
    ///     created, as described for vkCreateSwapchainKHR.
    /// </param>
    /// <param name="surface">surface is the surface that will be associated with the swapchain.</param>
    /// <param name="pSurfaceFormatCount">
    ///     pSurfaceFormatCount is a pointer to an integer related to the number of format pairs
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pSurfaceFormats">pSurfaceFormats is either NULL or a pointer to an array of VkSurfaceFormatKHR structures.</param>
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
        VkSurfaceKHR /*surface*/,
        uint* /*pSurfaceFormatCount*/,
        VkSurfaceFormatKHR* /*pSurfaceFormats*/,
        VkResult> vkGetPhysicalDeviceSurfaceFormatsKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceSurfacePresentModesKHR - Query supported presentation modes -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfacePresentModesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">
    ///     physicalDevice is the physical device that will be associated with the swapchain to be
    ///     created, as described for vkCreateSwapchainKHR.
    /// </param>
    /// <param name="surface">surface is the surface that will be associated with the swapchain.</param>
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
        VkSurfaceKHR /*surface*/,
        uint* /*pPresentModeCount*/,
        VkPresentModeKHR* /*pPresentModes*/,
        VkResult> vkGetPhysicalDeviceSurfacePresentModesKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkDestroySurfaceKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfaceSupportKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfaceCapabilitiesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfaceFormatsKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfacePresentModesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>* pvkDestroySurfaceKHR = &vkDestroySurfaceKHR)
        {
            *pvkDestroySurfaceKHR = (delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(instance, "\u6b76\u6544\u7473\u6f72\u5379\u7275\u6166\u6563\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, VkBool32*, VkResult>* pvkGetPhysicalDeviceSurfaceSupportKHR = &vkGetPhysicalDeviceSurfaceSupportKHR)
        {
            *pvkGetPhysicalDeviceSurfaceSupportKHR = (delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, VkBool32*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u7553\u7070\u726f\u4b74\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>* pvkGetPhysicalDeviceSurfaceCapabilitiesKHR = &vkGetPhysicalDeviceSurfaceCapabilitiesKHR)
        {
            *pvkGetPhysicalDeviceSurfaceCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilitiesKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u6143\u6170\u6962\u696c\u6974\u7365\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult>* pvkGetPhysicalDeviceSurfaceFormatsKHR = &vkGetPhysicalDeviceSurfaceFormatsKHR)
        {
            *pvkGetPhysicalDeviceSurfaceFormatsKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkSurfaceFormatKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u6f46\u6d72\u7461\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult>* pvkGetPhysicalDeviceSurfacePresentModesKHR = &vkGetPhysicalDeviceSurfacePresentModesKHR)
        {
            *pvkGetPhysicalDeviceSurfacePresentModesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, uint*, VkPresentModeKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u7250\u7365\u6e65\u4d74\u646f\u7365\u484b\u0052");
        }
    }
}