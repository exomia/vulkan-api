#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtSwapchainMaintenance1;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_swapchain_maintenance1 - device extension (nr. 276) - author 'EXT' [platform '' | contact 'Shahbaz Youssefi
///     @syoussefi']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_swapchain_maintenance1.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_swapchain_maintenance1.html</a>
/// </summary>
[VkDepends("VK_KHR_swapchain+VK_EXT_surface_maintenance1+(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)")]
[VkDeviceExt]
public static unsafe class VkExtSwapchainMaintenance1
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_SWAPCHAIN_MAINTENANCE_1_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME = "VK_EXT_swapchain_maintenance1";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME" /> represented
    ///     by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_SWAPCHAIN_MAINTENANCE_1_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u535f\u4157\u4350\u4148\u4e49\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u315f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkReleaseSwapchainImagesEXT - Release previously acquired but unused images -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkReleaseSwapchainImagesEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device associated with VkReleaseSwapchainImagesInfoEXT::swapchain.</param>
    /// <param name="pReleaseInfo">
    ///     pReleaseInfo is a pointer to a VkReleaseSwapchainImagesInfoEXT structure containing
    ///     parameters of the release.
    /// </param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_SURFACE_LOST_KHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkReleaseSwapchainImagesInfoEXT* /*pReleaseInfo*/,
        VkResult> vkReleaseSwapchainImagesEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkReleaseSwapchainImagesEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult>* pvkReleaseSwapchainImagesEXT = &vkReleaseSwapchainImagesEXT)
        {
            *pvkReleaseSwapchainImagesEXT = (delegate*<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6552\u656c\u7361\u5365\u6177\u6370\u6168\u6e69\u6d49\u6761\u7365\u5845\u0054");
        }
    }
}