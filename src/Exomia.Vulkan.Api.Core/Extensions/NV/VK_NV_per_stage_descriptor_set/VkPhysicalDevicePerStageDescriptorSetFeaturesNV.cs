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
///     VkPhysicalDevicePerStageDescriptorSetFeaturesNV - Structure describing feature to allow descriptor set layout
///     bindings to be per-stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerStageDescriptorSetFeaturesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDevicePerStageDescriptorSetFeaturesNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PER_STAGE_DESCRIPTOR_SET_FEATURES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     perStageDescriptorSet indicates that the implementation allows the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_PER_STAGE_BIT_NV descriptor set layout creation flag to be used so the bindings are
    ///     specified per-stage rather than across all stages.
    /// </summary>
    public VkBool32 perStageDescriptorSet;

    /// <summary>
    ///     dynamicPipelineLayout indicates the implementation allows the layout member of VkBindDescriptorSetsInfoKHR,
    ///     VkPushConstantsInfoKHR, VkPushDescriptorSetInfoKHR, VkPushDescriptorSetWithTemplateInfoKHR,
    ///     VkSetDescriptorBufferOffsetsInfoEXT and VkBindDescriptorBufferEmbeddedSamplersInfoEXT to be VK_NULL_HANDLE and
    ///     VkPipelineLayoutCreateInfo can be chained off those structures' pNext instead.
    /// </summary>
    public VkBool32 dynamicPipelineLayout;
}