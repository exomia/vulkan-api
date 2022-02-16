#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDebugReport;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_debug_report - instance extension (nr. 12) - author 'GOOGLE' [platform '' | contact 'Courtney
///     Goeltzenleuchter @courtney-g']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_report.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_report.html</a>
/// </summary>
/// <remarks>
///     specialuse: debugging
/// </remarks>
[VkSpecialuse("debugging")]
[Obsolete("deprecated by VK_EXT_debug_utils", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_report.html#_deprecation_state")]
public static unsafe class VkExtDebugReport
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEBUG_REPORT_SPEC_VERSION = 10;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEBUG_REPORT_EXTENSION_NAME = "VK_EXT_debug_report";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEBUG_REPORT_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEBUG_REPORT_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEBUG_REPORT_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u4245\u4755\u525f\u5045\u524f\u5f54\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCreateDebugReportCallbackEXT - Create a debug report callback object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDebugReportCallbackEXT.html</a>
    /// </summary>
    /// <param name="instance">instance is the instance the callback will be logged on.</param>
    /// <param name="pCreateInfo">
    ///     pCreateInfo is a pointer to a VkDebugReportCallbackCreateInfoEXT structure defining the
    ///     conditions under which this callback will be called.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    /// <param name="pCallback">
    ///     pCallback is a pointer to a VkDebugReportCallbackEXT handle in which the created object is
    ///     returned.
    /// </param>
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
        VkInstance /*instance*/,
        VkDebugReportCallbackCreateInfoEXT* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkDebugReportCallbackEXT* /*pCallback*/,
        VkResult> vkCreateDebugReportCallbackEXT = null;

    /// <summary>
    ///     vkDestroyDebugReportCallbackEXT - Destroy a debug report callback object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugReportCallbackEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDebugReportCallbackEXT.html
    ///     </a>
    /// </summary>
    /// <param name="instance">instance is the instance where the callback was created.</param>
    /// <param name="callback">
    ///     callback is the VkDebugReportCallbackEXT object to destroy. callback is an externally
    ///     synchronized object and must not be used on more than one thread at a time. This means that
    ///     vkDestroyDebugReportCallbackEXT must not be called when a callback is active.
    /// </param>
    /// <param name="pAllocator">pAllocator controls host memory allocation as described in the Memory Allocation chapter.</param>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkDebugReportCallbackEXT /*callback*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyDebugReportCallbackEXT = null;

    /// <summary>
    ///     vkDebugReportMessageEXT - Inject a message into a debug stream -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugReportMessageEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugReportMessageEXT.html</a>
    /// </summary>
    /// <param name="instance">instance is the debug stream&#8217;s VkInstance.</param>
    /// <param name="flags">flags specifies the VkDebugReportFlagBitsEXT classification of this event/message.</param>
    /// <param name="objectType">
    ///     objectType is a VkDebugReportObjectTypeEXT specifying the type of object being used or created
    ///     at the time the event was triggered.
    /// </param>
    /// <param name="object">
    ///     object is the object where the issue was detected. object can be VK_NULL_HANDLE if there is no
    ///     object associated with the event.
    /// </param>
    /// <param name="location">location is an application defined value.</param>
    /// <param name="messageCode">messageCode is an application defined value.</param>
    /// <param name="pLayerPrefix">pLayerPrefix is the abbreviation of the component making this event/message.</param>
    /// <param name="pMessage">pMessage is a null-terminated string detailing the trigger conditions.</param>
    public static readonly delegate*<
        VkInstance /*instance*/,
        VkDebugReportFlagsEXT /*flags*/,
        VkDebugReportObjectTypeEXT /*objectType*/,
        ulong /*object*/,
        nuint /*location*/,
        int /*messageCode*/,
        byte* /*pLayerPrefix*/,
        byte* /*pMessage*/,
        void> vkDebugReportMessageEXT = null;

    /// <summary> Loads all function pointer based on the instance for this extension. (see remarks!) </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCreateDebugReportCallbackEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDestroyDebugReportCallbackEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDebugReportMessageEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkInstance instance)
    {
        fixed (delegate*<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult>* pvkCreateDebugReportCallbackEXT =
                   &vkCreateDebugReportCallbackEXT)
        {
            *pvkCreateDebugReportCallbackEXT = (delegate*<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u7243\u6165\u6574\u6544\u7562\u5267\u7065\u726f\u4374\u6c61\u626c\u6361\u456b\u5458\u0000");
        }

        fixed (delegate*<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void>* pvkDestroyDebugReportCallbackEXT = &vkDestroyDebugReportCallbackEXT)
        {
            *pvkDestroyDebugReportCallbackEXT = (delegate*<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6544\u7473\u6f72\u4479\u6265\u6775\u6552\u6f70\u7472\u6143\u6c6c\u6162\u6b63\u5845\u0054");
        }

        fixed (delegate*<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void>* pvkDebugReportMessageEXT = &vkDebugReportMessageEXT)
        {
            *pvkDebugReportMessageEXT = (delegate*<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*, void>)Core.Vk.GetVkFunction(
                instance, "\u6b76\u6544\u7562\u5267\u7065\u726f\u4d74\u7365\u6173\u6567\u5845\u0054");
        }
    }
}