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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkQueryPoolCreateInfo - Structure specifying parameters of a newly created query pool -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkQueryPoolCreateFlags flags;

    /// <summary>queryType is a VkQueryType value specifying the type of queries managed by the pool.</summary>
    public VkQueryType queryType;

    /// <summary>queryCount is the number of queries managed by the pool.</summary>
    public uint queryCount;

    /// <summary>
    ///     pipelineStatistics is a bitmask of VkQueryPipelineStatisticFlagBits specifying which counters will be returned
    ///     in queries on the new pool, as described below in
    ///     https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#queries-pipestats.
    /// </summary>
    public VkQueryPipelineStatisticFlags pipelineStatistics;
}