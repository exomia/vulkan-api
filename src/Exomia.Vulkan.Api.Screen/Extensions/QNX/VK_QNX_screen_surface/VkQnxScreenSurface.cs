#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Screen.VkQnxScreenSurface;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VK_QNX_screen_surface - instance extension (nr. 379) - author 'QNX' [platform 'screen' | contact 'Mike Gorchak
///     @mgorchak-blackberry']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QNX_screen_surface.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QNX_screen_surface.html</a>
/// </summary>
[VkRequires("VK_KHR_surface")]
public static unsafe class VkQnxScreenSurface
{
    /// <summary> The spec version. </summary>
    public const uint VK_QNX_SCREEN_SURFACE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_QNX_SCREEN_SURFACE_EXTENSION_NAME = "VK_QNX_screen_surface";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_QNX_SCREEN_SURFACE_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_QNX_SCREEN_SURFACE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_QNX_SCREEN_SURFACE_EXTENSION_NAME_UTF8_NT = "\u4b56\u515f\u584e\u535f\u5243\u4545\u5f4e\u5553\u4652\u4341\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateScreenSurfaceQNX - Create a slink:VkSurfaceKHR object for a QNX Screen window -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateScreenSurfaceQNX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateScreenSurfaceQNX.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance to associate the surface with.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkScreenSurfaceCreateInfoQNXstructure containing parameters
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
        VkScreenSurfaceCreateInfoQNX* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSurfaceKHR* /*pSurface*/,
        VkResult> vkCreateScreenSurfaceQNX = null;

    /// <summary>
    ///     vkGetPhysicalDeviceScreenPresentationSupportQNX - Query physical device for presentation to QNX Screen -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceScreenPresentationSupportQNX.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceScreenPresentationSupportQNX.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device.</param>
    /// <param name="queueFamilyIndex">queueFamilyIndex is the queue family index.</param>
    /// <param name="window">window is the QNX Screen window object.</param>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        uint /*queueFamilyIndex*/,
        _screen_window* /*window*/,
        VkBool32> vkGetPhysicalDeviceScreenPresentationSupportQNX = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateScreenSurfaceQNX</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceScreenPresentationSupportQNX</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateScreenSurfaceQNX = &vkCreateScreenSurfaceQNX)
        {
            *pvkCreateScreenSurfaceQNX = (delegate*<VkInstance, VkScreenSurfaceCreateInfoQNX*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6353\u6572\u6e65\u7553\u6672\u6361\u5165\u584e\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, uint, _screen_window*, VkBool32>* pvkGetPhysicalDeviceScreenPresentationSupportQNX = &vkGetPhysicalDeviceScreenPresentationSupportQNX)
        {
            *pvkGetPhysicalDeviceScreenPresentationSupportQNX = (delegate*<VkPhysicalDevice, uint, _screen_window*, VkBool32>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u5365\u7263\u6565\u506e\u6572\u6573\u746e\u7461\u6f69\u536e\u7075\u6f70\u7472\u4e51\u0058");
        }
    }
}