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
///     VkPipelineVertexInputStateCreateInfo - Structure specifying parameters of a newly created pipeline vertex input state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkPipelineVertexInputStateCreateFlags flags;

    /// <summary> vertexBindingDescriptionCount is the number of vertex binding descriptions provided in pVertexBindingDescriptions. </summary>
    public uint vertexBindingDescriptionCount;

    /// <summary> pVertexBindingDescriptions is a pointer to an array of VkVertexInputBindingDescription structures. </summary>
    public VkVertexInputBindingDescription* pVertexBindingDescriptions;

    /// <summary> vertexAttributeDescriptionCount is the number of vertex attribute descriptions provided in pVertexAttributeDescriptions. </summary>
    public uint vertexAttributeDescriptionCount;

    /// <summary> pVertexAttributeDescriptions is a pointer to an array of VkVertexInputAttributeDescription structures. </summary>
    public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
}