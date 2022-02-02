﻿global using static Exomia.Vulkan.Api.Win32.VkNvAcquireWinrtDisplay;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Win32;

/// <summary>
///    VK_NV_acquire_winrt_display - device extension (nr. 346) - author 'NV' [platform 'win32' | contact 'Jeff Juliano @jjuliano']<br/>
///    <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_acquire_winrt_display.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NV_acquire_winrt_display.html</a>
/// </summary>
[VkRequires("VK_EXT_direct_mode_display")]
public static unsafe partial class VkNvAcquireWinrtDisplay
{
    /// <summary> The spec version. </summary>
    public const uint VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = 1;
    /// <summary> The extension name. </summary>
    public const string VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME = "VK_NV_acquire_winrt_display";
    /// <summary> An UTF8 null terminated version of <see cref="VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME" /> represented by an UTF16 string. </summary>
    /// <remarks>
    ///     Example usage:<br/>
    ///     <br/>
    ///     fixed(char* ptr = VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME_UTF8_NT) {<br/>
    ///         sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME_UTF8_NT = "\u4b56\u4e5f\u5f56\u4341\u5551\u5249\u5f45\u4957\u524e\u5f54\u4944\u5053\u414c\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary> vkAcquireWinrtDisplayNV - Acquire access to a VkDisplayKHR - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireWinrtDisplayNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireWinrtDisplayNV.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice The physical device the display is on.</param>
    /// <param name="display">display The display the caller wishes to control in Vulkan.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_INITIALIZATION_FAILED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        VkDisplayKHR /*display*/, 
        VkResult> vkAcquireWinrtDisplayNV = null;

    /// <summary> vkGetWinrtDisplayNV - Query the VkDisplayKHR corresponding to a WinRT DisplayTarget - <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetWinrtDisplayNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetWinrtDisplayNV.html</a> </summary>
    /// <param name="physicalDevice">physicalDevice The physical device on which to query the display handle.</param>
    /// <param name="deviceRelativeId">deviceRelativeId The value of the &#8220;AdapterRelativeId&#8221;property of a &#8220;DisplayTarget&#8221;that is enumerated by a &#8220;DisplayAdapter&#8221;with an &#8220;Id&#8221;property matching the deviceLUID property of a VkPhysicalDeviceIDProperties for physicalDevice.</param>
    /// <param name="pDisplay">pDisplay The corresponding VkDisplayKHR handle will be returned here.</param>
    /// <remarks><list type="table">
    ///     <item><term>successcodes</term><description>VK_SUCCESS</description></item>
    ///     <item><term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_DEVICE_LOST,VK_ERROR_INITIALIZATION_FAILED</description></item>
    /// </list></remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/, 
        uint /*deviceRelativeId*/, 
        VkDisplayKHR* /*pDisplay*/, 
        VkResult> vkGetWinrtDisplayNV = null;

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkDevice device) {
        fixed(delegate*<VkPhysicalDevice, VkDisplayKHR, VkResult>* pvkAcquireWinrtDisplayNV = &vkAcquireWinrtDisplayNV) 
        {
            *pvkAcquireWinrtDisplayNV = (delegate*<VkPhysicalDevice, VkDisplayKHR, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6341\u7571\u7269\u5765\u6e69\u7472\u6944\u7073\u616c\u4e79\u0056");
        }
        fixed(delegate*<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult>* pvkGetWinrtDisplayNV = &vkGetWinrtDisplayNV) 
        {
            *pvkGetWinrtDisplayNV = (delegate*<VkPhysicalDevice, uint, VkDisplayKHR*, VkResult>)Exomia.Vulkan.Api.Core.Vk.GetVkFunction(device, "\u6b76\u6547\u5774\u6e69\u7472\u6944\u7073\u616c\u4e79\u0056");
        }
    }
}
