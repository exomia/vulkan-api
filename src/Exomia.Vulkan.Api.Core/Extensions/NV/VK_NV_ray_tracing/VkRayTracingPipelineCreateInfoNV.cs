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
///     VkRayTracingPipelineCreateInfoNV - Structure specifying parameters of a newly created ray tracing pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingPipelineCreateInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingPipelineCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkPipelineCreateFlagBits specifying how the pipeline will be generated.</summary>
    public VkPipelineCreateFlags flags;

    /// <summary>stageCount is the number of entries in the pStages array.</summary>
    public uint stageCount;

    /// <summary>
    ///     pStages is a pointer to an array of VkPipelineShaderStageCreateInfo structures specifying the set of the
    ///     shader stages to be included in the ray tracing pipeline.
    /// </summary>
    public VkPipelineShaderStageCreateInfo* pStages;

    /// <summary>groupCount is the number of entries in the pGroups array.</summary>
    public uint groupCount;

    /// <summary>
    ///     pGroups is a pointer to an array of VkRayTracingShaderGroupCreateInfoNV structures describing the set of the
    ///     shader stages to be included in each shader group in the ray tracing pipeline.
    /// </summary>
    public VkRayTracingShaderGroupCreateInfoNV* pGroups;

    /// <summary>maxRecursionDepth is the maximum recursion depth of shaders executed by this pipeline.</summary>
    public uint maxRecursionDepth;

    /// <summary>
    ///     layout is the description of binding locations used by both the pipeline and descriptor sets used with the
    ///     pipeline.
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>basePipelineHandle is a pipeline to derive from.</summary>
    public VkPipeline basePipelineHandle;

    /// <summary>basePipelineIndex is an index into the pCreateInfosparameter to use as a pipeline to derive from.</summary>
    public int basePipelineIndex;
}