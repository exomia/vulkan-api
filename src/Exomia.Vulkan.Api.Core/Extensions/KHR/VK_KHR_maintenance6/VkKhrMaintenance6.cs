#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrMaintenance6;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_maintenance6 - device extension (nr. 546) - author 'KHR' [platform '' | contact 'Jon Leech @oddhack']<br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance6.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_maintenance6.html</a>
/// </summary>
[VkDepends("VK_VERSION_1_1")]
[VkDeviceExt]
public static unsafe class VkKhrMaintenance6
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_MAINTENANCE_6_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_MAINTENANCE_6_EXTENSION_NAME = "VK_KHR_maintenance6";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_MAINTENANCE_6_EXTENSION_NAME" /> represented by an UTF16
    ///     string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_MAINTENANCE_6_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_MAINTENANCE_6_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u4d5f\u4941\u544e\u4e45\u4e41\u4543\u365f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdBindDescriptorSets2KHR - Binds descriptor sets to a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorSets2KHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptor sets will be bound to.</param>
    /// <param name="pBindDescriptorSetsInfo">pBindDescriptorSetsInfo is a pointer to a VkBindDescriptorSetsInfoKHR structure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBindDescriptorSetsInfoKHR* /*pBindDescriptorSetsInfo*/,
        void> vkCmdBindDescriptorSets2KHR = null;

    /// <summary>
    ///     vkCmdPushConstants2KHR - Update the values of push constants -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushConstants2KHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which the push constant update will be recorded.</param>
    /// <param name="pPushConstantsInfo">pPushConstantsInfo is a pointer to a VkPushConstantsInfoKHRstructure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPushConstantsInfoKHR* /*pPushConstantsInfo*/,
        void> vkCmdPushConstants2KHR = null;

    /// <summary>
    ///     vkCmdPushDescriptorSet2KHR - Pushes descriptor updates into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2KHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSet2KHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptors will be recorded in.</param>
    /// <param name="pPushDescriptorSetInfo">pPushDescriptorSetInfo is a pointer to a VkPushDescriptorSetInfoKHR structure.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPushDescriptorSetInfoKHR* /*pPushDescriptorSetInfo*/,
        void> vkCmdPushDescriptorSet2KHR = null;

    /// <summary>
    ///     vkCmdPushDescriptorSetWithTemplate2KHR - Pushes descriptor updates into a command buffer using a descriptor update
    ///     template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2KHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplate2KHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptors will be recorded in.</param>
    /// <param name="pPushDescriptorSetWithTemplateInfo">
    ///     pPushDescriptorSetWithTemplateInfo is a pointer to a
    ///     VkPushDescriptorSetWithTemplateInfoKHR structure.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPushDescriptorSetWithTemplateInfoKHR* /*pPushDescriptorSetWithTemplateInfo*/,
        void> vkCmdPushDescriptorSetWithTemplate2KHR = null;

    /// <summary>
    ///     vkCmdSetDescriptorBufferOffsets2EXT - Setting descriptor buffer offsets in a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsets2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdSetDescriptorBufferOffsets2EXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer in which the descriptor buffer offsets will be set.</param>
    /// <param name="pSetDescriptorBufferOffsetsInfo">
    ///     pSetDescriptorBufferOffsetsInfo is a pointer to a
    ///     VkSetDescriptorBufferOffsetsInfoEXT structure.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkSetDescriptorBufferOffsetsInfoEXT* /*pSetDescriptorBufferOffsetsInfo*/,
        void> vkCmdSetDescriptorBufferOffsets2EXT = null;

    /// <summary>
    ///     vkCmdBindDescriptorBufferEmbeddedSamplers2EXT - Setting embedded immutable samplers offsets in a command buffer -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplers2EXT.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdBindDescriptorBufferEmbeddedSamplers2EXT.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the embedded immutable samplers will be bound to.</param>
    /// <param name="pBindDescriptorBufferEmbeddedSamplersInfo">
    ///     pBindDescriptorBufferEmbeddedSamplersInfo is a pointer to a
    ///     VkBindDescriptorBufferEmbeddedSamplersInfoEXT structure.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkBindDescriptorBufferEmbeddedSamplersInfoEXT* /*pBindDescriptorBufferEmbeddedSamplersInfo*/,
        void> vkCmdBindDescriptorBufferEmbeddedSamplers2EXT = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdBindDescriptorSets2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPushConstants2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPushDescriptorSet2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPushDescriptorSetWithTemplate2KHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdSetDescriptorBufferOffsets2EXT</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdBindDescriptorBufferEmbeddedSamplers2EXT</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkBindDescriptorSetsInfoKHR*, void>* pvkCmdBindDescriptorSets2KHR = &vkCmdBindDescriptorSets2KHR)
        {
            *pvkCmdBindDescriptorSets2KHR = (delegate*<VkCommandBuffer, VkBindDescriptorSetsInfoKHR*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4464\u7365\u7263\u7069\u6f74\u5372\u7465\u3273\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkPushConstantsInfoKHR*, void>* pvkCmdPushConstants2KHR = &vkCmdPushConstants2KHR)
        {
            *pvkCmdPushConstants2KHR = (delegate*<VkCommandBuffer, VkPushConstantsInfoKHR*, void>)GetVkFunction(device, "\u6b76\u6d43\u5064\u7375\u4368\u6e6f\u7473\u6e61\u7374\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPushDescriptorSetInfoKHR*, void>* pvkCmdPushDescriptorSet2KHR = &vkCmdPushDescriptorSet2KHR)
        {
            *pvkCmdPushDescriptorSet2KHR = (delegate*<VkCommandBuffer, VkPushDescriptorSetInfoKHR*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5064\u7375\u4468\u7365\u7263\u7069\u6f74\u5372\u7465\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfoKHR*, void>* pvkCmdPushDescriptorSetWithTemplate2KHR = &vkCmdPushDescriptorSetWithTemplate2KHR)
        {
            *pvkCmdPushDescriptorSetWithTemplate2KHR = (delegate*<VkCommandBuffer, VkPushDescriptorSetWithTemplateInfoKHR*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5064\u7375\u4468\u7365\u7263\u7069\u6f74\u5372\u7465\u6957\u6874\u6554\u706d\u616c\u6574\u4b32\u5248\u0000");
        }

        fixed (delegate*<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void>* pvkCmdSetDescriptorBufferOffsets2EXT = &vkCmdSetDescriptorBufferOffsets2EXT)
        {
            *pvkCmdSetDescriptorBufferOffsets2EXT = (delegate*<VkCommandBuffer, VkSetDescriptorBufferOffsetsInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u5364\u7465\u6544\u6373\u6972\u7470\u726f\u7542\u6666\u7265\u664f\u7366\u7465\u3273\u5845\u0054");
        }

        fixed (delegate*<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void>* pvkCmdBindDescriptorBufferEmbeddedSamplers2EXT = &vkCmdBindDescriptorBufferEmbeddedSamplers2EXT)
        {
            *pvkCmdBindDescriptorBufferEmbeddedSamplers2EXT = (delegate*<VkCommandBuffer, VkBindDescriptorBufferEmbeddedSamplersInfoEXT*, void>)GetVkFunction(
                device, "\u6b76\u6d43\u4264\u6e69\u4464\u7365\u7263\u7069\u6f74\u4272\u6675\u6566\u4572\u626d\u6465\u6564\u5364\u6d61\u6c70\u7265\u3273\u5845\u0054");
        }
    }
}