#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VkKhrDescriptorUpdateTemplate;

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VK_KHR_descriptor_update_template - device extension (nr. 86) - author 'KHR' [platform '' | contact 'Markus
///     Tavenrath @mtavenrath']<br />
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_descriptor_update_template.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_descriptor_update_template.html
///     </a>
/// </summary>
[Obsolete("promoted to VK_VERSION_1_1", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_KHR_descriptor_update_template.html#_deprecation_state")]
public static unsafe class VkKhrDescriptorUpdateTemplate
{
    /// <summary> The spec version. </summary>
    public const uint VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION = 1;

    /// <summary> The extension name. </summary>
    public const string VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME = "VK_KHR_descriptor_update_template";

    /// <summary>
    ///     An UTF8 null terminated version of <see cref="VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME" />
    ///     represented by an UTF16 string.
    /// </summary>
    /// <remarks>
    ///     Example usage:<br />
    ///     <br />
    ///     fixed(char* ptr = VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME_UTF8_NT) {<br />
    ///     sbyte* utf8NtPtr = (sbyte*)ptr; // utf8NtPtr - can now be passed and used directly as a utf8_nt string for
    ///     unmanaged code.<br />
    ///     }
    /// </remarks>
    public const string VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME_UTF8_NT =
        "\u4b56\u4b5f\u5248\u445f\u5345\u5243\u5049\u4f54\u5f52\u5055\u4144\u4554\u545f\u4d45\u4c50\u5441\u5f45\u5845\u4554\u534e\u4f49\u5f4e\u414e\u454d\u0000";

    /// vkCreateDescriptorUpdateTemplateKHR alias for vkCreateDescriptorUpdateTemplate
    /// <summary>
    ///     vkCreateDescriptorUpdateTemplate - Create a new descriptor update template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplateKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateDescriptorUpdateTemplateKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorUpdateTemplateCreateInfo* /*pCreateInfo*/,
        VkAllocationCallbacks* /*pAllocator*/,
        VkDescriptorUpdateTemplate* /*pDescriptorUpdateTemplate*/,
        VkResult> vkCreateDescriptorUpdateTemplateKHR = null;

    /// vkDestroyDescriptorUpdateTemplateKHR alias for vkDestroyDescriptorUpdateTemplate
    /// <summary>
    ///     vkDestroyDescriptorUpdateTemplate - Destroy a descriptor update template object -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplateKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkDestroyDescriptorUpdateTemplateKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorUpdateTemplate /*descriptorUpdateTemplate*/,
        VkAllocationCallbacks* /*pAllocator*/,
        void> vkDestroyDescriptorUpdateTemplateKHR = null;

    /// vkUpdateDescriptorSetWithTemplateKHR alias for vkUpdateDescriptorSetWithTemplate
    /// <summary>
    ///     vkUpdateDescriptorSetWithTemplate - Update the contents of a descriptor set object using an update template -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkUpdateDescriptorSetWithTemplateKHR.html
    ///     </a>
    /// </summary>
    public static readonly delegate*<
        VkDevice /*device*/,
        VkDescriptorSet /*descriptorSet*/,
        VkDescriptorUpdateTemplate /*descriptorUpdateTemplate*/,
        void* /*pData*/,
        void> vkUpdateDescriptorSetWithTemplateKHR = null;

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

    /// <summary> Loads all function pointer for this extension. </summary>
    /// <param name="instance"> The instance that the function pointers will be compatible with in fallback case. </param>
    /// <param name="device"> The device that the function pointers will be compatible with. </param>
    /// <remarks> The load method must always be executed first before a command of this extension can be used. </remarks>
    public static void Load(VkInstance instance, VkDevice device)
    {
        fixed (delegate*<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult>* pvkCreateDescriptorUpdateTemplateKHR =
                   &vkCreateDescriptorUpdateTemplateKHR)
        {
            *pvkCreateDescriptorUpdateTemplateKHR = (delegate*<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7243\u6165\u6574\u6544\u6373\u6972\u7470\u726f\u7055\u6164\u6574\u6554\u706d\u616c\u6574\u484b\u0052");
        }
        fixed (delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>* pvkDestroyDescriptorUpdateTemplateKHR = &vkDestroyDescriptorUpdateTemplateKHR)
        {
            *pvkDestroyDescriptorUpdateTemplateKHR = (delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6544\u7473\u6f72\u4479\u7365\u7263\u7069\u6f74\u5572\u6470\u7461\u5465\u6d65\u6c70\u7461\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>* pvkUpdateDescriptorSetWithTemplateKHR = &vkUpdateDescriptorSetWithTemplateKHR)
        {
            *pvkUpdateDescriptorSetWithTemplateKHR = (delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u7055\u6164\u6574\u6544\u6373\u6972\u7470\u726f\u6553\u5774\u7469\u5468\u6d65\u6c70\u7461\u4b65\u5248\u0000");
        }
        fixed (delegate*<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>* pvkCmdPushDescriptorSetWithTemplateKHR = &vkCmdPushDescriptorSetWithTemplateKHR)
        {
            *pvkCmdPushDescriptorSetWithTemplateKHR = (delegate*<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void>)Core.Vk.GetVkFunction(
                instance, device, "\u6b76\u6d43\u5064\u7375\u4468\u7365\u7263\u7069\u6f74\u5372\u7465\u6957\u6874\u6554\u706d\u616c\u6574\u484b\u0052");
        }
    }
}