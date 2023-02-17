#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrGetSurfaceCapabilities2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_get_surface_capabilities2 - instance extension (nr. 120) - author 'KHR' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_surface_capabilities2.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_surface_capabilities2.html
///     </a>
/// </summary>
public static unsafe class VkKhrGetSurfaceCapabilities2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME = "VK_KHR_get_surface_capabilities2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u475f\u5445\u535f\u5255\u4146\u4543\u435f\u5041\u4241\u4c49\u5449\u4549\u5f53\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPhysicalDeviceSurfaceCapabilities2KHR - Reports capabilities of a surface on a physical device -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceCapabilities2KHR.html
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
    /// <param name="pSurfaceCapabilities">
    ///     pSurfaceCapabilities is a pointer to a VkSurfaceCapabilities2KHR structure in which
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
        VkPhysicalDeviceSurfaceInfo2KHR* /*pSurfaceInfo*/,
        VkSurfaceCapabilities2KHR* /*pSurfaceCapabilities*/,
        VkResult> vkGetPhysicalDeviceSurfaceCapabilities2KHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceSurfaceFormats2KHR - Query color formats supported by surface -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormats2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceSurfaceFormats2KHR.html
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
    /// <param name="pSurfaceFormatCount">
    ///     pSurfaceFormatCount is a pointer to an integer related to the number of format tuples
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pSurfaceFormats">
    ///     pSurfaceFormats is either NULL or a pointer to an array of VkSurfaceFormat2KHR
    ///     structures.
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
        uint* /*pSurfaceFormatCount*/,
        VkSurfaceFormat2KHR* /*pSurfaceFormats*/,
        VkResult> vkGetPhysicalDeviceSurfaceFormats2KHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfaceCapabilities2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceSurfaceFormats2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult>* pvkGetPhysicalDeviceSurfaceCapabilities2KHR =
            &vkGetPhysicalDeviceSurfaceCapabilities2KHR)
        {
            *pvkGetPhysicalDeviceSurfaceCapabilities2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u6143\u6170\u6962\u696c\u6974\u7365\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult>* pvkGetPhysicalDeviceSurfaceFormats2KHR = &vkGetPhysicalDeviceSurfaceFormats2KHR)
        {
            *pvkGetPhysicalDeviceSurfaceFormats2KHR = (delegate*<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7275\u6166\u6563\u6f46\u6d72\u7461\u3273\u484b\u0052");
        }
    }
}