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
///     VkQueryPoolPerformanceCreateInfoKHR - Structure specifying parameters of a newly created performance query pool -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolPerformanceCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPoolPerformanceCreateInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkQueryPoolCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkQueryPoolCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>queueFamilyIndex is the queue family index to create this performance query pool for.</summary>
    public uint queueFamilyIndex;

    /// <summary>counterIndexCount is the length of the pCounterIndicesarray.</summary>
    public uint counterIndexCount;

    /// <summary>
    ///     pCounterIndices is a pointer to an array of indices into the
    ///     vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR::pCountersto enable in this performance query pool.
    /// </summary>
    public uint* pCounterIndices;
}