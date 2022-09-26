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
///     VkPipelineVertexInputDivisorStateCreateInfoEXT - Structure specifying vertex attributes assignment during instanced rendering -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputDivisorStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineVertexInputDivisorStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkPipelineVertexInputStateCreateInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineVertexInputStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> vertexBindingDivisorCount is the number of elements in the pVertexBindingDivisors array. </summary>
    public uint vertexBindingDivisorCount;

    /// <summary> pVertexBindingDivisors is a pointer to an array of VkVertexInputBindingDivisorDescriptionEXT structures specifying the divisor value for each binding. </summary>
    public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
}