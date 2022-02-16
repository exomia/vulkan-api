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
///     VkGraphicsShaderGroupCreateInfoNV - Structure specifying override parameters for each shader group -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsShaderGroupCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGraphicsShaderGroupCreateInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsShaderGroupCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stageCount is the number of entries in the pStages array.</summary>
    public uint stageCount;

    /// <summary>
    ///     pStages is a pointer to an array VkPipelineShaderStageCreateInfo structures specifying the set of the shader
    ///     stages to be included in this shader group.
    /// </summary>
    public VkPipelineShaderStageCreateInfo* pStages;

    /// <summary>pVertexInputState is a pointer to a VkPipelineVertexInputStateCreateInfo structure.</summary>
    public VkPipelineVertexInputStateCreateInfo* pVertexInputState;

    /// <summary>
    ///     pTessellationState is a pointer to a VkPipelineTessellationStateCreateInfo structure, and is ignored if the
    ///     shader group does not include a tessellation control shader stage and tessellation evaluation shader stage.
    /// </summary>
    public VkPipelineTessellationStateCreateInfo* pTessellationState;
}