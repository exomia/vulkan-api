#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDynamicRenderingLocalRead;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_dynamic_rendering_local_read - device extension (nr. 233) - author 'AMD' [platform '' | contact 'Tobias
///     Hector @tobski']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_dynamic_rendering_local_read.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_dynamic_rendering_local_read.html
///     </a>
/// </summary>
[VkDepends("VK_KHR_dynamic_rendering")]
[VkDeviceExt]
public static unsafe class VkKhrDynamicRenderingLocalRead
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME = "VK_KHR_dynamic_rendering_local_read";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DYNAMIC_RENDERING_LOCAL_READ_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u4e59\u4d41\u4349\u525f\u4e45\u4544\u4952\u474e\u4c5f\u434f\u4c41\u525f\u4145\u5f44\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// <summary>
    ///     vkCmdSetRenderingAttachmentLocationsKHR - Set color attachment location mappings for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocationsKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingAttachmentLocationsKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pLocationInfo">
    ///     pLocationInfo is a VkRenderingAttachmentLocationInfoKHRstructure indicating the new
    ///     mappings.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkRenderingAttachmentLocationInfoKHR* /*pLocationInfo*/,
        void> vkCmdSetRenderingAttachmentLocationsKHR = null;

    /// <summary>
    ///     vkCmdSetRenderingInputAttachmentIndicesKHR - Set input attachment index mappings for a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer into which the command will be recorded.</param>
    /// <param name="pLocationInfo">
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetRenderingInputAttachmentIndicesKHR.html
    ///     </a>
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkRenderingInputAttachmentIndexInfoKHR* /*pLocationInfo*/,
        void> vkCmdSetRenderingInputAttachmentIndicesKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdSetRenderingAttachmentLocationsKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetRenderingInputAttachmentIndicesKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkRenderingAttachmentLocationInfoKHR*, void>* pvkCmdSetRenderingAttachmentLocationsKHR = &vkCmdSetRenderingAttachmentLocationsKHR)
        {
            *pvkCmdSetRenderingAttachmentLocationsKHR = (delegate*<VkCommandBuffer, VkRenderingAttachmentLocationInfoKHR*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6552\u646e\u7265\u6e69\u4167\u7474\u6361\u6d68\u6e65\u4c74\u636f\u7461\u6f69\u736e\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkRenderingInputAttachmentIndexInfoKHR*, void>* pvkCmdSetRenderingInputAttachmentIndicesKHR = &vkCmdSetRenderingInputAttachmentIndicesKHR)
        {
            *pvkCmdSetRenderingInputAttachmentIndicesKHR = (delegate*<VkCommandBuffer, VkRenderingInputAttachmentIndexInfoKHR*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6552\u646e\u7265\u6e69\u4967\u706e\u7475\u7441\u6174\u6863\u656d\u746e\u6e49\u6964\u6563\u4b73\u5248\u0000");
        }
    }
}