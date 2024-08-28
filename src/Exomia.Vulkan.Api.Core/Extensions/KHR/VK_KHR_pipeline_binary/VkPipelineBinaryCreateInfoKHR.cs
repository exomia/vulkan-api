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
///     VkPipelineBinaryCreateInfoKHR - Structure specifying where to retrieve data for pipeline binary creation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBinaryCreateInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineBinaryCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_BINARY_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pKeysAndDataInfo is NULL or a pointer to a VkPipelineBinaryKeysAndDataKHR structure that contains keys and
    ///     data to create the pipeline binaries from.
    /// </summary>
    public VkPipelineBinaryKeysAndDataKHR* pKeysAndDataInfo;

    /// <summary>pipeline is VK_NULL_HANDLE or a VkPipeline that contains data to create the pipeline binaries from.</summary>
    public VkPipeline pipeline;

    /// <summary>
    ///     pPipelineCreateInfo is NULL or a pointer to a VkPipelineCreateInfoKHR structure with the pipeline creation
    ///     info. This is used to probe the implementation&#8217;s internal cache for pipeline binaries.
    /// </summary>
    public VkPipelineCreateInfoKHR* pPipelineCreateInfo;
}