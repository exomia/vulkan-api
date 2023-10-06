#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDisplay;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_display - instance extension (nr. 3) - author 'KHR' [platform '' | contact 'James Jones @cubanismo,Norbert
///     Nopper @FslNopper']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_display.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_display.html</a>
/// </summary>
[VkDepends("VK_KHR_surface")]
[VkInstanceExt]
public static unsafe class VkKhrDisplay
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DISPLAY_SPEC_VERSION = 23;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DISPLAY_EXTENSION_NAME = "VK_KHR_display";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DISPLAY_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DISPLAY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DISPLAY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u445f\u5349\u4c50\u5941\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkGetPhysicalDeviceDisplayPropertiesKHR - Query information about the available displays -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is a physical device.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display devices
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkDisplayPropertiesKHR structures.</param>
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
        uint* /*pPropertyCount*/,
        VkDisplayPropertiesKHR* /*pProperties*/,
        VkResult> vkGetPhysicalDeviceDisplayPropertiesKHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceDisplayPlanePropertiesKHR - Query the plane properties -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlanePropertiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlanePropertiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is a physical device.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display planes
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is either NULL or a pointer to an array of VkDisplayPlanePropertiesKHR
    ///     structures.
    /// </param>
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
        uint* /*pPropertyCount*/,
        VkDisplayPlanePropertiesKHR* /*pProperties*/,
        VkResult> vkGetPhysicalDeviceDisplayPlanePropertiesKHR = null;

    /// <summary>
    ///     vkGetDisplayPlaneSupportedDisplaysKHR - Query the list of displays a plane supports -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneSupportedDisplaysKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneSupportedDisplaysKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is a physical device.</param>
    /// <param name="planeIndex">
    ///     planeIndex is the plane which the application wishes to use, and must be in the range [0,
    ///     physical device plane count - 1].
    /// </param>
    /// <param name="pDisplayCount">
    ///     pDisplayCount is a pointer to an integer related to the number of displays available or
    ///     queried, as described below.
    /// </param>
    /// <param name="pDisplays">pDisplays is either NULL or a pointer to an array of VkDisplayKHR handles.</param>
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
        uint /*planeIndex*/,
        uint* /*pDisplayCount*/,
        VkDisplayKHR* /*pDisplays*/,
        VkResult> vkGetDisplayPlaneSupportedDisplaysKHR = null;

    /// <summary>
    ///     vkGetDisplayModePropertiesKHR - Query the set of mode properties supported by the display -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModePropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModePropertiesKHR.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device associated with display.</param>
    /// <param name="display">display is the display to query.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display modes available
    ///     or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkDisplayModePropertiesKHR structures.</param>
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
        VkDisplayKHR /*display*/,
        uint* /*pPropertyCount*/,
        VkDisplayModePropertiesKHR* /*pProperties*/,
        VkResult> vkGetDisplayModePropertiesKHR = null;

    /// <summary>
    ///     vkCreateDisplayModeKHR - Create a display mode -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayModeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayModeKHR.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device associated with display.</param>
    /// <param name="display">display is the display to create an additional mode for.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDisplayModeCreateInfoKHRstructure describing the new mode to
    ///     create.
    /// </param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the display mode object when
    ///     there is no more specific allocator available (see Memory Allocation).
    /// </param>
    /// <param name="pMode">pMode is a pointer to a VkDisplayModeKHR handle in which the mode created is returned.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_OUT_OF_DEVICE_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        VkDisplayKHR /*display*/,
        VkDisplayModeCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkDisplayModeKHR* /*pMode*/,
        VkResult> vkCreateDisplayModeKHR = null;

    /// <summary>
    ///     vkGetDisplayPlaneCapabilitiesKHR - Query capabilities of a mode and plane combination -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilitiesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilitiesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device associated with the display specified by mode</param>
    /// <param name="mode">
    ///     mode is the display mode the application intends to program when using the specified plane. Note
    ///     this parameter also implicitly specifies a display.
    /// </param>
    /// <param name="planeIndex">
    ///     planeIndex is the plane which the application intends to use with the display, and is less
    ///     than the number of display planes supported by the device.
    /// </param>
    /// <param name="pCapabilities">
    ///     pCapabilities is a pointer to a VkDisplayPlaneCapabilitiesKHR structure in which the
    ///     capabilities are returned.
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
        VkPhysicalDevice /*physicalDevice*/,
        VkDisplayModeKHR /*mode*/,
        uint /*planeIndex*/,
        VkDisplayPlaneCapabilitiesKHR* /*pCapabilities*/,
        VkResult> vkGetDisplayPlaneCapabilitiesKHR = null;

    /// <summary>
    ///     vkCreateDisplayPlaneSurfaceKHR - Create a slink:VkSurfaceKHR structure representing a display plane and mode
    ///     -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayPlaneSurfaceKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDisplayPlaneSurfaceKHR.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance corresponding to the physical device the targeted display is on.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDisplaySurfaceCreateInfoKHRstructure specifying which mode,
    ///     plane, and other parameters to use, as described below.
    /// </param>
    /// <param name="pAllocator">
    ///     pAllocator is the allocator used for host memory allocated for the surface object when there
    ///     is no more specific allocator available (see Memory Allocation).
    /// </param>
    /// <param name="pSurface">pSurface is a pointer to a VkSurfaceKHR handle in which the created surface is returned.</param>
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
        VkDisplaySurfaceCreateInfoKHR* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkSurfaceKHR* /*pSurface*/,
        VkResult> vkCreateDisplayPlaneSurfaceKHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceDisplayPropertiesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceDisplayPlanePropertiesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDisplayPlaneSupportedDisplaysKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDisplayModePropertiesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateDisplayModeKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDisplayPlaneCapabilitiesKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCreateDisplayPlaneSurfaceKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult>* pvkGetPhysicalDeviceDisplayPropertiesKHR = &vkGetPhysicalDeviceDisplayPropertiesKHR)
        {
            *pvkGetPhysicalDeviceDisplayPropertiesKHR = (delegate*<VkPhysicalDevice, uint*, VkDisplayPropertiesKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4465\u7369\u6c70\u7961\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult>* pvkGetPhysicalDeviceDisplayPlanePropertiesKHR = &vkGetPhysicalDeviceDisplayPlanePropertiesKHR)
        {
            *pvkGetPhysicalDeviceDisplayPlanePropertiesKHR = (delegate*<VkPhysicalDevice, uint*, VkDisplayPlanePropertiesKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4465\u7369\u6c70\u7961\u6c50\u6e61\u5065\u6f72\u6570\u7472\u6569\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult>* pvkGetDisplayPlaneSupportedDisplaysKHR = &vkGetDisplayPlaneSupportedDisplaysKHR)
        {
            *pvkGetDisplayPlaneSupportedDisplaysKHR = (delegate*<VkPhysicalDevice, uint, uint*, VkDisplayKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u4474\u7369\u6c70\u7961\u6c50\u6e61\u5365\u7075\u6f70\u7472\u6465\u6944\u7073\u616c\u7379\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult>* pvkGetDisplayModePropertiesKHR = &vkGetDisplayModePropertiesKHR)
        {
            *pvkGetDisplayModePropertiesKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModePropertiesKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u4474\u7369\u6c70\u7961\u6f4d\u6564\u7250\u706f\u7265\u6974\u7365\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult>* pvkCreateDisplayModeKHR = &vkCreateDisplayModeKHR)
        {
            *pvkCreateDisplayModeKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, VkDisplayModeCreateInfoKHR*, VkAllocationCallbacks*, VkDisplayModeKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6944\u7073\u616c\u4d79\u646f\u4b65\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult>* pvkGetDisplayPlaneCapabilitiesKHR = &vkGetDisplayPlaneCapabilitiesKHR)
        {
            *pvkGetDisplayPlaneCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, VkDisplayPlaneCapabilitiesKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u4474\u7369\u6c70\u7961\u6c50\u6e61\u4365\u7061\u6261\u6c69\u7469\u6569\u4b73\u5248\u0000");
        }

        fixed (delegate*<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>* pvkCreateDisplayPlaneSurfaceKHR = &vkCreateDisplayPlaneSurfaceKHR)
        {
            *pvkCreateDisplayPlaneSurfaceKHR = (delegate*<VkInstance, VkDisplaySurfaceCreateInfoKHR*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6944\u7073\u616c\u5079\u616c\u656e\u7553\u6672\u6361\u4b65\u5248\u0000");
        }
    }
}