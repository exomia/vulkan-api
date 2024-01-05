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
///     VkPushDescriptorSetWithTemplateInfoKHR - Structure specifying a descriptor set push operation using a descriptor
///     update template -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetWithTemplateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushDescriptorSetWithTemplateInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPushDescriptorSetWithTemplateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PUSH_DESCRIPTOR_SET_WITH_TEMPLATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     descriptorUpdateTemplate is a descriptor update template defining how to interpret the descriptor information
    ///     in pData.
    /// </summary>
    public VkDescriptorUpdateTemplate descriptorUpdateTemplate;

    /// <summary>
    ///     layout is a VkPipelineLayout object used to program the bindings. It must be compatible with the layout used
    ///     to create the descriptorUpdateTemplate handle. If the dynamicPipelineLayoutfeature is enabled, layout can be
    ///     VK_NULL_HANDLE and the layout must be specified by chaining VkPipelineLayoutCreateInfostructure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>
    ///     set is the set number of the descriptor set in the pipeline layout that will be updated. This must be the same
    ///     number used to create the descriptorUpdateTemplate handle.
    /// </summary>
    public uint set;

    /// <summary>pData is a pointer to memory containing descriptors for the templated update.</summary>
    public void* pData;
}