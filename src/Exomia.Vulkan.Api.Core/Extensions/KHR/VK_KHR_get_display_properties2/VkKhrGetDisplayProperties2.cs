#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrGetDisplayProperties2;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_get_display_properties2 - instance extension (nr. 122) - author 'KHR' [platform '' | contact 'James Jones
///     @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_display_properties2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_get_display_properties2.html</a>
/// </summary>
[VkDepends("VK_KHR_display")]
[VkInstanceExt]
public static unsafe class VkKhrGetDisplayProperties2
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME = "VK_KHR_get_display_properties2";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u475f\u5445\u445f\u5349\u4c50\u5941\u505f\u4f52\u4550\u5452\u4549\u5f53\u5f32\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkGetPhysicalDeviceDisplayProperties2KHR - Query information about the available displays -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayProperties2KHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is a physical device.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display devices
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">pProperties is either NULL or a pointer to an array of VkDisplayProperties2KHR structures.</param>
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
        VkDisplayProperties2KHR* /*pProperties*/,
        VkResult> vkGetPhysicalDeviceDisplayProperties2KHR = null;

    /// <summary>
    ///     vkGetPhysicalDeviceDisplayPlaneProperties2KHR - Query information about the available display planes. -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlaneProperties2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPhysicalDeviceDisplayPlaneProperties2KHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is a physical device.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display planes
    ///     available or queried, as described below.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is either NULL or a pointer to an array of VkDisplayPlaneProperties2KHR
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
        VkDisplayPlaneProperties2KHR* /*pProperties*/,
        VkResult> vkGetPhysicalDeviceDisplayPlaneProperties2KHR = null;

    /// <summary>
    ///     vkGetDisplayModeProperties2KHR - Query information about the available display modes. -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModeProperties2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayModeProperties2KHR.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device associated with display.</param>
    /// <param name="display">display is the display to query.</param>
    /// <param name="pPropertyCount">
    ///     pPropertyCount is a pointer to an integer related to the number of display modes available
    ///     or queried, as described below.
    /// </param>
    /// <param name="pProperties">
    ///     pProperties is either NULL or a pointer to an array of VkDisplayModeProperties2KHR
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
        VkDisplayKHR /*display*/,
        uint* /*pPropertyCount*/,
        VkDisplayModeProperties2KHR* /*pProperties*/,
        VkResult> vkGetDisplayModeProperties2KHR = null;

    /// <summary>
    ///     vkGetDisplayPlaneCapabilities2KHR - Query capabilities of a mode and plane combination -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilities2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDisplayPlaneCapabilities2KHR.html
    ///     </a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice is the physical device associated with pDisplayPlaneInfo.</param>
    /// <param name="pDisplayPlaneInfo">
    ///     pDisplayPlaneInfo is a pointer to a VkDisplayPlaneInfo2KHRstructure describing the
    ///     plane and mode.
    /// </param>
    /// <param name="pCapabilities">
    ///     pCapabilities is a pointer to a VkDisplayPlaneCapabilities2KHR structure in which the
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
        VkDisplayPlaneInfo2KHR* /*pDisplayPlaneInfo*/,
        VkDisplayPlaneCapabilities2KHR* /*pCapabilities*/,
        VkResult> vkGetDisplayPlaneCapabilities2KHR = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkGetPhysicalDeviceDisplayProperties2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetPhysicalDeviceDisplayPlaneProperties2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDisplayModeProperties2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDisplayPlaneCapabilities2KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult>* pvkGetPhysicalDeviceDisplayProperties2KHR = &vkGetPhysicalDeviceDisplayProperties2KHR)
        {
            *pvkGetPhysicalDeviceDisplayProperties2KHR = (delegate*<VkPhysicalDevice, uint*, VkDisplayProperties2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4465\u7369\u6c70\u7961\u7250\u706f\u7265\u6974\u7365\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult>* pvkGetPhysicalDeviceDisplayPlaneProperties2KHR = &vkGetPhysicalDeviceDisplayPlaneProperties2KHR)
        {
            *pvkGetPhysicalDeviceDisplayPlaneProperties2KHR = (delegate*<VkPhysicalDevice, uint*, VkDisplayPlaneProperties2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5074\u7968\u6973\u6163\u446c\u7665\u6369\u4465\u7369\u6c70\u7961\u6c50\u6e61\u5065\u6f72\u6570\u7472\u6569\u3273\u484b\u0052");
        }

        fixed (delegate*<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult>* pvkGetDisplayModeProperties2KHR = &vkGetDisplayModeProperties2KHR)
        {
            *pvkGetDisplayModeProperties2KHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, uint*, VkDisplayModeProperties2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u4474\u7369\u6c70\u7961\u6f4d\u6564\u7250\u706f\u7265\u6974\u7365\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult>* pvkGetDisplayPlaneCapabilities2KHR = &vkGetDisplayPlaneCapabilities2KHR)
        {
            *pvkGetDisplayPlaneCapabilities2KHR = (delegate*<VkPhysicalDevice, VkDisplayPlaneInfo2KHR*, VkDisplayPlaneCapabilities2KHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u4474\u7369\u6c70\u7961\u6c50\u6e61\u4365\u7061\u6261\u6c69\u7469\u6569\u3273\u484b\u0052");
        }
    }
}