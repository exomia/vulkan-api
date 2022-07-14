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
///     VkPipelineInputAssemblyStateCreateInfo - Structure specifying parameters of a newly created pipeline input assembly
///     state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineInputAssemblyStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkPipelineInputAssemblyStateCreateFlags flags;

    /// <summary>topology is a VkPrimitiveTopology defining the primitive topology, as described below.</summary>
    public VkPrimitiveTopology topology;

    /// <summary>
    ///     primitiveRestartEnable controls whether a special vertex index value is treated as restarting the assembly of
    ///     primitives. This enable only applies to indexed draws (vkCmdDrawIndexed, vkCmdDrawMultiIndexedEXT, and
    ///     vkCmdDrawIndexedIndirect), and the special index value is either 0xFFFFFFFF when the indexType parameter of
    ///     vkCmdBindIndexBuffer is equal to VK_INDEX_TYPE_UINT32, 0xFF when indexType is equal to VK_INDEX_TYPE_UINT8_EXT, or
    ///     0xFFFF when indexType is equal to VK_INDEX_TYPE_UINT16. Primitive restart is not allowed for &#8220;list&#8221;
    ///     topologies, unless one of the features primitiveTopologyPatchListRestart (for VK_PRIMITIVE_TOPOLOGY_PATCH_LIST) or
    ///     primitiveTopologyListRestart (for all other list topologies) is enabled.
    /// </summary>
    public VkBool32 primitiveRestartEnable;
}