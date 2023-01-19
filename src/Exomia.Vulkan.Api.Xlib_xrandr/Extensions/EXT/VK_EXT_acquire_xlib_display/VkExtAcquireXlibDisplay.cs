#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Xlib_xrandr.VkExtAcquireXlibDisplay;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Xlib_xrandr;

/// <summary>
///     VK_EXT_acquire_xlib_display - instance extension (nr. 90) - author 'NV' [platform 'xlib_xrandr' | contact 'James
///     Jones @cubanismo']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_acquire_xlib_display.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_acquire_xlib_display.html</a>
/// </summary>
[VkRequires("VK_EXT_direct_mode_display")]
public static unsafe class VkExtAcquireXlibDisplay
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_ACQUIRE_XLIB_DISPLAY_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME = "VK_EXT_acquire_xlib_display";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME" /> represented by
    ///     an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_ACQUIRE_XLIB_DISPLAY_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u415f\u5143\u4955\u4552\u585f\u494c\u5f42\u4944\u5053\u414c\u5f59\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkAcquireXlibDisplayEXT - Acquire access to a VkDisplayKHR using Xlib -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireXlibDisplayEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkAcquireXlibDisplayEXT.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice The physical device the display is on.</param>
    /// <param name="dpy">dpy A connection to the X11 server that currently owns display.</param>
    /// <param name="display">display The display the caller wishes to control in Vulkan.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term>
    ///             <description>VK_ERROR_OUT_OF_HOST_MEMORY,VK_ERROR_INITIALIZATION_FAILED</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        Display* /*dpy*/,
        VkDisplayKHR /*display*/,
        VkResult> vkAcquireXlibDisplayEXT = null;

    /// <summary>
    ///     vkGetRandROutputDisplayEXT - Query the VkDisplayKHR corresponding to an X11 RandR Output -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRandROutputDisplayEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetRandROutputDisplayEXT.html</a>
    /// </summary>
    /// <param name="physicalDevice">physicalDevice The physical device to query the display handle on.</param>
    /// <param name="dpy">dpy A connection to the X11 server from which rrOutput was queried.</param>
    /// <param name="rrOutput">rrOutput An X11 RandR output ID.</param>
    /// <param name="pDisplay">pDisplay The corresponding VkDisplayKHR handle will be returned here.</param>
    /// <remarks>
    ///     <list type="table">
    ///         <item>
    ///             <term>successcodes</term><description>VK_SUCCESS</description>
    ///         </item>
    ///         <item>
    ///             <term>errorcodes</term><description>VK_ERROR_OUT_OF_HOST_MEMORY</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static readonly delegate*<
        VkPhysicalDevice /*physicalDevice*/,
        Display* /*dpy*/,
        RROutput /*rrOutput*/,
        VkDisplayKHR* /*pDisplay*/,
        VkResult> vkGetRandROutputDisplayEXT = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkAcquireXlibDisplayEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkGetRandROutputDisplayEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkPhysicalDevice, Display*, VkDisplayKHR, VkResult>* pvkAcquireXlibDisplayEXT = &vkAcquireXlibDisplayEXT)
        {
            *pvkAcquireXlibDisplayEXT = (delegate*<VkPhysicalDevice, Display*, VkDisplayKHR, VkResult>)GetVkFunction(
                instance, "\u6b76\u6341\u7571\u7269\u5865\u696c\u4462\u7369\u6c70\u7961\u5845\u0054");
        }

        fixed (delegate*<VkPhysicalDevice, Display*, RROutput, VkDisplayKHR*, VkResult>* pvkGetRandROutputDisplayEXT = &vkGetRandROutputDisplayEXT)
        {
            *pvkGetRandROutputDisplayEXT = (delegate*<VkPhysicalDevice, Display*, RROutput, VkDisplayKHR*, VkResult>)GetVkFunction(
                instance, "\u6b76\u6547\u5274\u6e61\u5264\u754f\u7074\u7475\u6944\u7073\u616c\u4579\u5458\u0000");
        }
    }
}