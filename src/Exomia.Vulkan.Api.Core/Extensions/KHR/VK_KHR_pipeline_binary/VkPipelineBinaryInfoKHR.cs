#region License

// Copyright (c) 2018-2024, exomia
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
///     VkPipelineBinaryInfoKHR - Structure specifying pipeline binaries to use during pipeline creation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryInfoKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkRayTracingPipelineCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGraphicsPipelineCreateInfo,VkComputePipelineCreateInfo,VkRayTracingPipelineCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineBinaryInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_BINARY_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>binaryCount is the number of elements in the pPipelineBinaries array.</summary>
    public uint binaryCount;

    /// <summary>pPipelineBinaries is a pointer to an array of VkPipelineBinaryKHR handles.</summary>
    public VkPipelineBinaryKHR* pPipelineBinaries;
}