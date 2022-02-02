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
///     VkPipelineExecutableInfoKHR - Structure describing a pipeline executable to query for associated statistics
///     or internal representations -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineExecutableInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pipeline is the pipeline to query.</summary>
    public VkPipeline pipeline;

    /// <summary>
    ///     executableIndex is the index of the pipeline executable to query in the array of executable properties
    ///     returned by vkGetPipelineExecutablePropertiesKHR.
    /// </summary>
    public uint executableIndex;
}