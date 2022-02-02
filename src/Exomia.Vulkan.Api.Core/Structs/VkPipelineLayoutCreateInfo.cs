#region License

// Copyright (c) 2018-2022, exomia
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
///     VkPipelineLayoutCreateInfo - Structure specifying the parameters of a newly created pipeline layout object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLayoutCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineLayoutCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineLayoutCreateFlags flags;

    /// <summary>setLayoutCount is the number of descriptor sets included in the pipeline layout.</summary>
    public uint setLayoutCount;

    /// <summary>pSetLayouts is a pointer to an array of VkDescriptorSetLayout objects.</summary>
    public VkDescriptorSetLayout* pSetLayouts;

    /// <summary>pushConstantRangeCount is the number of push constant ranges included in the pipeline layout.</summary>
    public uint pushConstantRangeCount;

    /// <summary>
    ///     pPushConstantRanges is a pointer to an array of VkPushConstantRange structures defining a set of push constant
    ///     ranges for use in a single pipeline layout. In addition to descriptor set layouts, a pipeline layout also describes
    ///     how many push constants can be accessed by each stage of the pipeline.NotePush constants represent a high speed
    ///     path to modify constant data in pipelines that is expected to outperform memory-backed resource updates.
    /// </summary>
    public VkPushConstantRange* pPushConstantRanges;
}