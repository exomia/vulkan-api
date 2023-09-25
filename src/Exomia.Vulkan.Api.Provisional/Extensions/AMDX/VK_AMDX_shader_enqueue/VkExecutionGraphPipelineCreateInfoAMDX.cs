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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkExecutionGraphPipelineCreateInfoAMDX - Structure specifying parameters of a newly created execution graph
///     pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExecutionGraphPipelineCreateInfoAMDX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExecutionGraphPipelineCreateInfoAMDX.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExecutionGraphPipelineCreateInfoAMDX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_CREATE_INFO_AMDX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkPipelineCreateFlagBits specifying how the pipeline will be generated.</summary>
    public VkPipelineCreateFlags flags;

    /// <summary>stageCount is the number of entries in the pStages array.</summary>
    public uint stageCount;

    /// <summary>
    ///     pStages is a pointer to an array of stageCountVkPipelineShaderStageCreateInfo structures describing the set of
    ///     the shader stages to be included in the execution graph pipeline.
    /// </summary>
    public VkPipelineShaderStageCreateInfo* pStages;

    /// <summary>
    ///     pLibraryInfo is a pointer to a VkPipelineLibraryCreateInfoKHR structure defining pipeline libraries to
    ///     include.
    /// </summary>
    public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;

    /// <summary>
    ///     layout is the description of binding locations used by both the pipeline and descriptor sets used with the
    ///     pipeline.
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>basePipelineHandle is a pipeline to derive from</summary>
    public VkPipeline basePipelineHandle;

    /// <summary>basePipelineIndex is an index into the pCreateInfosparameter to use as a pipeline to derive from</summary>
    public int basePipelineIndex;
}