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
///     VkPipelineShaderStageCreateInfo - Structure specifying parameters of a newly created pipeline shader stage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkPipelineShaderStageCreateFlagBitsspecifying how the pipeline shader stage will be
    ///     generated.
    /// </summary>
    public VkPipelineShaderStageCreateFlags flags;

    /// <summary>stage is a VkShaderStageFlagBits value specifying a single pipeline stage.</summary>
    public VkShaderStageFlagBits stage;

    /// <summary>module is optionally a VkShaderModule object containing the shader code for this stage.</summary>
    public VkShaderModule module;

    /// <summary>
    ///     pName is a pointer to a null-terminated UTF-8 string specifying the entry point name of the shader for this
    ///     stage.
    /// </summary>
    public byte* pName;

    /// <summary>
    ///     pSpecializationInfo is a pointer to a VkSpecializationInfostructure, as described in Specialization Constants,
    ///     or NULL.
    /// </summary>
    public VkSpecializationInfo* pSpecializationInfo;
}