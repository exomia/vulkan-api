#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDepthClampControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_depth_clamp_control - device extension (nr. 583) - author 'EXT' [platform '' | contact 'Jules Blok @jules']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_clamp_control.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_clamp_control.html</a>
/// </summary>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkDeviceExt]
public static unsafe class VkExtDepthClampControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEPTH_CLAMP_CONTROL_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME = "VK_EXT_depth_clamp_control";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEPTH_CLAMP_CONTROL_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5045\u4854\u435f\u414c\u504d\u435f\u4e4f\u5254\u4c4f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdSetDepthClampRangeEXT - Set the viewport depth clamp range dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampRangeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthClampRangeEXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="depthClampMode">depthClampMode determines how the clamp range is determined for each viewport.</param>
    /// <param name="pDepthClampRange">
    ///     pDepthClampRange sets the depth clamp range for all viewports if depthClampMode is
    ///     VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDepthClampModeEXT /*depthClampMode*/,
        VkDepthClampRangeEXT* /*pDepthClampRange*/,
        void> vkCmdSetDepthClampRangeEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetDepthClampRangeEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void>* pvkCmdSetDepthClampRangeEXT = &vkCmdSetDepthClampRangeEXT)
        {
            *pvkCmdSetDepthClampRangeEXT = (delegate*<VkCommandBuffer, VkDepthClampModeEXT, VkDepthClampRangeEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4368\u616c\u706d\u6152\u676e\u4565\u5458\u0000");
        }
    }
}