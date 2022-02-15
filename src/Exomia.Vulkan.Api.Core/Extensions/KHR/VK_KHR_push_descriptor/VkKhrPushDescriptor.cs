#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrPushDescriptor;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_push_descriptor - device extension (nr. 81) - author 'KHR' [platform '' | contact 'Jeff Bolz @jeffbolznv']
///     <br />
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_push_descriptor.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_push_descriptor.html</a>
/// </summary>
[VkRequires("VK_KHR_get_physical_device_properties2")]
public static unsafe class VkKhrPushDescriptor
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = 2;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME = "VK_KHR_push_descriptor";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME" /> represented by an
    ///     UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME_UTF8_NT = "\u4b56\u4b5f\u5248\u505f\u5355\u5f48\u4544\u4353\u4952\u5450\u524f\u455f\u5458\u4e45\u4953\u4e4f\u4e5f\u4d41\u0045";

    /// <summary>
    ///     vkCmdPushDescriptorSetKHR - Pushes descriptor updates into a command buffer -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetKHR.html</a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptors will be recorded in.</param>
    /// <param name="pipelineBindPoint">
    ///     pipelineBindPoint is a VkPipelineBindPoint indicating the type of the pipeline that
    ///     will use the descriptors. There is a separate set of push descriptor bindings for each pipeline type, so binding
    ///     one does not disturb the others.
    /// </param>
    /// <param name="layout">layout is a VkPipelineLayout object used to program the bindings.</param>
    /// <param name="set">set is the set number of the descriptor set in the pipeline layout that will be updated.</param>
    /// <param name="descriptorWriteCount">descriptorWriteCount is the number of elements in the pDescriptorWrites array.</param>
    /// <param name="pDescriptorWrites">
    ///     pDescriptorWrites is a pointer to an array of VkWriteDescriptorSet structures
    ///     describing the descriptors to be updated.
    /// </param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkPipelineBindPoint /*pipelineBindPoint*/,
        VkPipelineLayout /*layout*/,
        uint /*set*/,
        uint /*descriptorWriteCount*/,
        VkWriteDescriptorSet* /*pDescriptorWrites*/,
        void> vkCmdPushDescriptorSetKHR = null;

    /// <summary>
    ///     vkCmdPushDescriptorSetWithTemplateKHR - Pushes descriptor updates into a command buffer using a descriptor update
    ///     template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplateKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdPushDescriptorSetWithTemplateKHR.html
    ///     </a>
    /// </summary>
    /// <param name="commandBuffer">commandBuffer is the command buffer that the descriptors will be recorded in.</param>
    /// <param name="descriptorUpdateTemplate">
    ///     descriptorUpdateTemplate is a descriptor update template defining how to
    ///     interpret the descriptor information in pData.
    /// </param>
    /// <param name="layout">
    ///     layout is a VkPipelineLayout object used to program the bindings. It must be compatible with the
    ///     layout used to create the descriptorUpdateTemplate handle.
    /// </param>
    /// <param name="set">
    ///     set is the set number of the descriptor set in the pipeline layout that will be updated. This must be
    ///     the same number used to create the descriptorUpdateTemplate handle.
    /// </param>
    /// <param name="pData">pData is a pointer to memory containing descriptors for the templated update.</param>
    public static readonly delegate*<
        VkCommandBuffer /*commandBuffer*/,
        VkDescriptorUpdateTemplate /*descriptorUpdateTemplate*/,
        VkPipelineLayout /*layout*/,
        uint /*set*/,
        void* /*pData*/,
        void> vkCmdPushDescriptorSetWithTemplateKHR = null;

    /// <summary> Loads all function pointer based on the device for this extension. (see remarks!) </summary>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks>
    ///     This load method makes the following function pointers available:<br />
    ///     <list type="bullet">
    ///         <item>
    ///             <description>vkCmdPushDescriptorSetKHR</description>
    ///         </item>
    ///         <item>
    ///             <description>vkCmdPushDescriptorSetWithTemplateKHR</description>
    ///         </item>
    ///     </list>
    /// </remarks>
    public static void Load(VkDevice device)
    {
        fixed (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>* pvkCmdPushDescriptorSetKHR = &vkCmdPushDescriptorSetKHR)
        {
            *pvkCmdPushDescriptorSetKHR = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5064\u7375\u4468\u7365\u7263\u7069\u6f74\u5372\u7465\u484b\u0052");
        }

        fixed (delegate*<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>* pvkCmdPushDescriptorSetWithTemplateKHR = &vkCmdPushDescriptorSetWithTemplateKHR)
        {
            *pvkCmdPushDescriptorSetWithTemplateKHR = (delegate*<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)Core.Vk.GetVkFunction(
                device, "\u6b76\u6d43\u5064\u7375\u4468\u7365\u7263\u7069\u6f74\u5372\u7465\u6957\u6874\u6554\u706d\u616c\u6574\u484b\u0052");
        }
    }
}