#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtDepthBiasControl;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_depth_bias_control - device extension (nr. 284) - author 'EXT' [platform '' | contact 'Joshua Ashton
///     @Joshua-Ashton']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_bias_control.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_depth_bias_control.html</a>
/// </summary>
/// <remarks>
///     specialuse: d3demulation
/// </remarks>
[VkDepends("VK_KHR_get_physical_device_properties2,VK_VERSION_1_1")]
[VkSpecialuse("d3demulation")]
[VkDeviceExt]
public static unsafe class VkExtDepthBiasControl
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_DEPTH_BIAS_CONTROL_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME = "VK_EXT_depth_bias_control";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_DEPTH_BIAS_CONTROL_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u445f\u5045\u4854\u425f\u4149\u5f53\u4f43\u544e\u4f52\u5f4c\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetDepthBias2EXT - Set depth bias factors and clamp dynamically for a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias2EXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDepthBias2EXT.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pDepthBiasInfo">
    ///     pDepthBiasInfo is a pointer to a VkDepthBiasInfoEXTstructure specifying depth bias
    ///     parameters.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDepthBiasInfoEXT* /*pDepthBiasInfo*/,
        void> vkCmdSetDepthBias2EXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetDepthBias2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkDepthBiasInfoEXT*, void>* pvkCmdSetDepthBias2EXT = &vkCmdSetDepthBias2EXT)
        {
            *pvkCmdSetDepthBias2EXT = (delegate*<VkCommandBuffer, VkDepthBiasInfoEXT*, void>)GetVkFunction(device, "\u6b76\u6d43\u5364\u7465\u6544\u7470\u4268\u6169\u3273\u5845\u0054");
        }
    }
}