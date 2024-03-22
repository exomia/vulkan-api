#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkExtAttachmentFeedbackLoopDynamicState;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_EXT_attachment_feedback_loop_dynamic_state - device extension (nr. 525) - author 'EXT' [platform '' | contact
///     'Mike Blumenkrantz @zmike']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_attachment_feedback_loop_dynamic_state.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_EXT_attachment_feedback_loop_dynamic_state.html
///     </a>
/// </summary>
[VkDepends("(VK_KHR_get_physical_device_properties2,VK_VERSION_1_1)+VK_EXT_attachment_feedback_loop_layout")]
[VkDeviceExt]
public static unsafe class VkExtAttachmentFeedbackLoopDynamicState
{
    /// <summary> The spec version. </summary>
    public const uint VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME = "VK_EXT_attachment_feedback_loop_dynamic_state";

    /// <summary>
    ///     An UTF8 null terminated version of
    ///     <see cref="VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME" /> represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_EXT_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u455f\u5458\u415f\u5454\u4341\u4d48\u4e45\u5f54\u4546\u4445\u4142\u4b43\u4c5f\u4f4f\u5f50\u5944\u414e\u494d\u5f43\u5453\u5441\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetAttachmentFeedbackLoopEnableEXT - Specify whether attachment feedback loops are enabled dynamically on a
    ///     command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAttachmentFeedbackLoopEnableEXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetAttachmentFeedbackLoopEnableEXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="aspectMask">
    ///     aspectMask specifies the types of attachments for which feedback loops will be enabled.
    ///     Attachment types whose aspects are not included in aspectMask will have feedback loops disabled.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkImageAspectFlags /*aspectMask*/,
        void> vkCmdSetAttachmentFeedbackLoopEnableEXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetAttachmentFeedbackLoopEnableEXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkImageAspectFlags, void>* pvkCmdSetAttachmentFeedbackLoopEnableEXT = &vkCmdSetAttachmentFeedbackLoopEnableEXT)
        {
            *pvkCmdSetAttachmentFeedbackLoopEnableEXT = (delegate*<VkCommandBuffer, VkImageAspectFlags, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u7441\u6174\u6863\u656d\u746e\u6546\u6465\u6162\u6b63\u6f4c\u706f\u6e45\u6261\u656c\u5845\u0054");
        }
    }
}