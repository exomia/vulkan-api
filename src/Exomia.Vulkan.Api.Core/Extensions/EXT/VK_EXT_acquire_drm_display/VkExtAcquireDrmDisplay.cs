#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtAcquireDrmDisplay;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_acquire_drm_display - instance extension (nr. 286) - author 'EXT' [platform '' | contact 'Drew DeVault
///     sir@cmpwn.com']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_acquire_drm_display.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_acquire_drm_display.html</a>
/// </summary>
[VkRequires("VK_EXT_direct_mode_display")]
public static unsafe class VkExtAcquireDrmDisplay
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME = "VK_EXT_acquire_drm_display";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u415f\u5143\u4955\u4552\u445f\u4d52\u445f\u5349\u4c50\u5941\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkAcquireDrmDisplayEXT - Acquire access to a VkDisplayKHR using DRM -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireDrmDisplayEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireDrmDisplayEXT.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice The physical device the display is on.</param>
    /// <param name="drmFd">drmFd DRM primary file descriptor.</param>
    /// <param name="display">display The display the caller wishes Vulkan to control.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        int /*drmFd*/,
        VkDisplayKHR /*display*/,
        VkResult> vkAcquireDrmDisplayEXT = null;

    /// <summary>
    ///     vkGetDrmDisplayEXT - Query the VkDisplayKHR corresponding to a DRM connector ID -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDrmDisplayEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetDrmDisplayEXT.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice The physical device to query the display from.</param>
    /// <param name="drmFd">drmFd DRM primary file descriptor.</param>
    /// <param name="connectorId">connectorId Identifier of the specified DRM connector.</param>
    /// <param name="display">display The corresponding VkDisplayKHR handle will be returned here.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_INITIALIZATION_FAILED,VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        int /*drmFd*/,
        uint /*connectorId*/,
        VkDisplayKHR* /*display*/,
        VkResult> vkGetDrmDisplayEXT = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkAcquireDrmDisplayEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetDrmDisplayEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, int, VkDisplayKHR, VkResult>* pvkAcquireDrmDisplayEXT = &vkAcquireDrmDisplayEXT)
        {
            *pvkAcquireDrmDisplayEXT = (delegate*<VkPhysicalDevice, int, VkDisplayKHR, VkResult>)GetVkFunction(instance, "\u6b76\u6341\u7571\u7269\u4465\u6d72\u6944\u7073\u616c\u4579\u5458\u0000");
        }

        fixed (delegate*<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult>* pvkGetDrmDisplayEXT = &vkGetDrmDisplayEXT)
        {
            *pvkGetDrmDisplayEXT = (delegate*<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult>)GetVkFunction(instance, "\u6b76\u6547\u4474\u6d72\u6944\u7073\u616c\u4579\u5458\u0000");
        }
    }
}