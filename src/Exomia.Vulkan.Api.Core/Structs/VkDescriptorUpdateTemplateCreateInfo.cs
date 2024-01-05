#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkDescriptorUpdateTemplateCreateInfo - Structure specifying parameters of a newly created descriptor update
///     template -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorUpdateTemplateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorUpdateTemplateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkDescriptorUpdateTemplateCreateFlags flags;

    /// <summary>descriptorUpdateEntryCount is the number of elements in the pDescriptorUpdateEntries array.</summary>
    public uint descriptorUpdateEntryCount;

    /// <summary>
    ///     pDescriptorUpdateEntries is a pointer to an array of VkDescriptorUpdateTemplateEntry structures describing the
    ///     descriptors to be updated by the descriptor update template.
    /// </summary>
    public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;

    /// <summary>
    ///     templateType Specifies the type of the descriptor update template. If set to
    ///     VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET it can only be used to update descriptor sets with a fixed
    ///     descriptorSetLayout. If set to VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHRit can only be used to push
    ///     descriptor sets using the provided pipelineBindPoint, pipelineLayout, and set number.
    /// </summary>
    public VkDescriptorUpdateTemplateType templateType;

    /// <summary>
    ///     descriptorSetLayout is the descriptor set layout used to build the descriptor update template. All descriptor
    ///     sets which are going to be updated through the newly created descriptor update template must be created with a
    ///     layout that matches (is the same as, or defined identically to) this layout. This parameter is ignored if
    ///     templateType is not VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET.
    /// </summary>
    public VkDescriptorSetLayout descriptorSetLayout;

    /// <summary>
    ///     pipelineBindPoint is a VkPipelineBindPoint indicating the type of the pipeline that will use the descriptors.
    ///     This parameter is ignored if templateType is not VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
    /// </summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary>
    ///     pipelineLayout is a VkPipelineLayout object used to program the bindings. This parameter is ignored if
    ///     templateType is not VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
    /// </summary>
    public VkPipelineLayout pipelineLayout;

    /// <summary>
    ///     set is the set number of the descriptor set in the pipeline layout that will be updated. This parameter is
    ///     ignored if templateType is not VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR
    /// </summary>
    public uint set;
}