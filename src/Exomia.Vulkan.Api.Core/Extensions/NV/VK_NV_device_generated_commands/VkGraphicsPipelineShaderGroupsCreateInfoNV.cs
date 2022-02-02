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
///     VkGraphicsPipelineShaderGroupsCreateInfoNV - Structure specifying parameters of a newly created multi shader group
///     pipeline -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineShaderGroupsCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsPipelineShaderGroupsCreateInfoNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkGraphicsPipelineCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>groupCount is the number of elements in the pGroups array.</summary>
    public uint groupCount;

    /// <summary>
    ///     pGroups is a pointer to an array of VkGraphicsShaderGroupCreateInfoNV structures specifying which state of the
    ///     original VkGraphicsPipelineCreateInfo each shader group overrides.
    /// </summary>
    public VkGraphicsShaderGroupCreateInfoNV* pGroups;

    /// <summary>pipelineCount is the number of elements in the pPipelinesarray.</summary>
    public uint pipelineCount;

    /// <summary>
    ///     pPipelines is a pointer to an array of graphics VkPipelinestructures which are referenced within the created
    ///     pipeline, including all their shader groups.
    /// </summary>
    public VkPipeline* pPipelines;
}