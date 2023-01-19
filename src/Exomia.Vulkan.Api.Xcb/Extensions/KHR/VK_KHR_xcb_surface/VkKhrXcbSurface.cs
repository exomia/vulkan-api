#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Xcb.VkKhrXcbSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Xcb;

/// <summary>
///     VK_KHR_xcb_surface - instance extension (nr. 6) - author 'KHR' [platform 'xcb' | contact 'Jesse Hall @critsec,Ian
///     Elliott @ianelliottus']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_xcb_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_xcb_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe class VkKhrXcbSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_XCB_SURFACE_SPEC_VERSION = 6;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_XCB_SURFACE_EXTENSION_NAME = "VK_KHR_xcb_surface";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_XCB_SURFACE_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_XCB_SURFACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_XCB_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u585f\u4243\u535f\u5255\u4146\u4543\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCreateXcbSurfaceKHR - Create a slink:VkSurfaceKHR object for a X11 window, using the XCB client-side
    ///     library -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateXcbSurfaceKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateXcbSurfaceKHR.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance to associate the surface with.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkXcbSurfaceCreateInfoKHRstructure containing parameters
    ///     affecting the creation of the surface object.
    /// </param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the surface object when there
    ///     is no more specific allocator available (see Memory Allocation).
    /// </param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface object is returned.</param>
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
        VkInstance /*instance*/,
        VkXcbSurfaceCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSurfaceKHR* /*pSurface*/,
        VkResult> vkCreateXcbSurfaceKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceXcbPresentationSupportKHR - Query physical device for presentation to X11 server using XCB -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXcbPresentationSupportKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceXcbPresentationSupportKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the queue family index.</param>
    /// <param name="connection">connection is a pointer to an xcb_connection_t to the X server.</param>
    /// <param name="visual_id">visual_id is an X11 visual (xcb_visualid_t).</param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint /*queueFamilyIndex*/,
        xcb_connection_t* /*connection*/,
        xcb_visualid_t /*visual_id*/,
        VkBool32> vkGetPhysicalDeviceXcbPresentationSupportKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateXcbSurfaceKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceXcbPresentationSupportKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateXcbSurfaceKHR = &vkCreateXcbSurfaceKHR)
        {
            *pvkCreateXcbSurfaceKHR = (delegate*<VkInstance, VkXcbSurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6358\u5362\u7275\u6166\u6563\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, uint, xcb_connection_t*, xcb_visualid_t /*visual_id*/, VkBool32>* pvkGetPhysicalDeviceXcbPresentationSupportKHR =
            &vkGetPhysicalDeviceXcbPresentationSupportKHR)
        {
            *pvkGetPhysicalDeviceXcbPresentationSupportKHR = (delegate*<VkPhysicalDevice, uint, xcb_connection_t*, xcb_visualid_t /*visual_id*/, VkBool32>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5865\u6263\u7250\u7365\u6e65\u6174\u6974\u6e6f\u7553\u7070\u726f\u4b74\u5248\u0000");
        }
    }
}