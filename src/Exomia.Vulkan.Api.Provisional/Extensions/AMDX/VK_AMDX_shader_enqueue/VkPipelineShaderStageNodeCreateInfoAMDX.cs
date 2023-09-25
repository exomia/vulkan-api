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
///     VkPipelineShaderStageNodeCreateInfoAMDX - Structure specifying the shader name and index with an execution graph -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageNodeCreateInfoAMDX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineShaderStageNodeCreateInfoAMDX.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineShaderStageCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineShaderStageCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineShaderStageNodeCreateInfoAMDX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_NODE_CREATE_INFO_AMDX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pName is the shader name to use when creating a node in an execution graph. If pName is NULL, the name of the
    ///     entry point specified in SPIR-V is used as the shader name.
    /// </summary>
    public byte* pName;

    /// <summary>
    ///     index is the shader index to use when creating a node in an execution graph. If index is
    ///     VK_SHADER_INDEX_UNUSED_AMDX then the original index is used, either as specified by the ShaderIndexAMDX execution
    ///     mode, or 0 if that too is not specified.
    /// </summary>
    public uint index;
}