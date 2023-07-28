#region License

// Copyright (c) 2018-2023, exomia
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
///     VkPipelineCreationFeedbackCreateInfo - Request for feedback about the creation of a pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreationFeedbackCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkRayTracingPipelineCreateInfoNV,VkRayTracingPipelineCreateInfoKHR,VkExecutionGraphPipelineCreateInfoAMDX</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkRayTracingPipelineCreateInfoNV,VkRayTracingPipelineCreateInfoKHR,VkExecutionGraphPipelineCreateInfoAMDX")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreationFeedbackCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pPipelineCreationFeedback is a pointer to a VkPipelineCreationFeedback structure.</summary>
    public VkPipelineCreationFeedback* pPipelineCreationFeedback;

    /// <summary>pipelineStageCreationFeedbackCount is the number of elements in pPipelineStageCreationFeedbacks.</summary>
    public uint pipelineStageCreationFeedbackCount;

    /// <summary>
    ///     pPipelineStageCreationFeedbacks is a pointer to an array of
    ///     pipelineStageCreationFeedbackCountVkPipelineCreationFeedback structures.
    /// </summary>
    public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
}