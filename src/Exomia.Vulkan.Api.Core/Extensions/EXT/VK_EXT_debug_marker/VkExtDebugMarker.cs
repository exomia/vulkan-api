#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDebugMarker;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_debug_marker - device extension (nr. 23) - author 'Baldur Karlsson' [platform '' | contact 'Baldur Karlsson
///     @baldurk']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_marker.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_marker.html</a>
/// </summary>
/// <remarks>
///     specialuse: debugging
/// </remarks>
[VkDepends("VK_EXT_debug_report")]
[VkSpecialuse("debugging")]
[VkDeviceExt]
[Obsolete("promoted to VK_EXT_debug_utils", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_debug_marker.html#_deprecation_state")]
public static unsafe class VkExtDebugMarker
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEBUG_MARKER_SPEC_VERSION = 4;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEBUG_MARKER_EXTENSION_NAME = "VK_EXT_debug_marker";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEBUG_MARKER_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEBUG_MARKER_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEBUG_MARKER_EXTENSION_NAME_UTF8_NT = "\u4b56\u455f\u5458\u445f\u4245\u4755\u4d5f\u5241\u454b\u5f52\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkDebugMarkerSetObjectTagEXT - Attach arbitrary data to an object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectTagEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectTagEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device that created the object.</param>
    /// <param name="pTagInfo">
    ///     pTagInfo is a pointer to a VkDebugMarkerObjectTagInfoEXTstructure specifying the parameters of
    ///     the tag to attach to the object.
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
        VkDevice /*device*/,
        VkDebugMarkerObjectTagInfoEXT* /*pTagInfo*/,
        VkResult> vkDebugMarkerSetObjectTagEXT = null;

    /// <summary>
    ///     vkDebugMarkerSetObjectNameEXT - Give a user-friendly name to an object -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectNameEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDebugMarkerSetObjectNameEXT.html</a>
    /// </summary>
    /// <param name="device">device is the device that created the object.</param>
    /// <param name="pNameInfo">
    ///     pNameInfo is a pointer to a VkDebugMarkerObjectNameInfoEXTstructure specifying the parameters
    ///     of the name to set on the object.
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
        VkDevice /*device*/,
        VkDebugMarkerObjectNameInfoEXT* /*pNameInfo*/,
        VkResult> vkDebugMarkerSetObjectNameEXT = null;

    /// <summary>
    ///     vkCmdDebugMarkerBeginEXT - Open a command buffer marker region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerBeginEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerBeginEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="pMarkerInfo">
    ///     pMarkerInfo is a pointer to a VkDebugMarkerMarkerInfoEXTstructure specifying the parameters
    ///     of the marker region to open.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDebugMarkerMarkerInfoEXT* /*pMarkerInfo*/,
        void> vkCmdDebugMarkerBeginEXT = null;

    /// <summary>
    ///     vkCmdDebugMarkerEndEXT - Close a command buffer marker region -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerEndEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerEndEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        void> vkCmdDebugMarkerEndEXT = null;

    /// <summary>
    ///     vkCmdDebugMarkerInsertEXT - Insert a marker label into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerInsertEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDebugMarkerInsertEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command is recorded.</param>
    /// <param name="pMarkerInfo">
    ///     pMarkerInfo is a pointer to a VkDebugMarkerMarkerInfoEXTstructure specifying the parameters
    ///     of the marker to insert.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDebugMarkerMarkerInfoEXT* /*pMarkerInfo*/,
        void> vkCmdDebugMarkerInsertEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkDebugMarkerSetObjectTagEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkDebugMarkerSetObjectNameEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDebugMarkerBeginEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDebugMarkerEndEXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdDebugMarkerInsertEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>* pvkDebugMarkerSetObjectTagEXT = &vkDebugMarkerSetObjectTagEXT)
        {
            *pvkDebugMarkerSetObjectTagEXT = (delegate*<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6544\u7562\u4d67\u7261\u656b\u5372\u7465\u624f\u656a\u7463\u6154\u4567\u5458\u0000");
        }

        fixed (delegate*<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>* pvkDebugMarkerSetObjectNameEXT = &vkDebugMarkerSetObjectNameEXT)
        {
            *pvkDebugMarkerSetObjectNameEXT = (delegate*<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult>)GetVkFunction(
                device, "\u6b76\u6544\u7562\u4d67\u7261\u656b\u5372\u7465\u624f\u656a\u7463\u614e\u656d\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>* pvkCmdDebugMarkerBeginEXT = &vkCmdDebugMarkerBeginEXT)
        {
            *pvkCmdDebugMarkerBeginEXT = (delegate*<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6265\u6775\u614d\u6b72\u7265\u6542\u6967\u456e\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, void>* pvkCmdDebugMarkerEndEXT = &vkCmdDebugMarkerEndEXT)
        {
            *pvkCmdDebugMarkerEndEXT = (delegate*<VkCommandBuffer, void>)GetVkFunction(device, "\u6b76\u6d43\u4464\u6265\u6775\u614d\u6b72\u7265\u6e45\u4564\u5458\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>* pvkCmdDebugMarkerInsertEXT = &vkCmdDebugMarkerInsertEXT)
        {
            *pvkCmdDebugMarkerInsertEXT = (delegate*<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4464\u6265\u6775\u614d\u6b72\u7265\u6e49\u6573\u7472\u5845\u0054");
        }
    }
}