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
///     VkPhysicalDeviceMemoryBudgetPropertiesEXT - Structure specifying physical device memory budget and usage -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryBudgetPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMemoryBudgetPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceMemoryProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceMemoryProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     heapBudget is an array of VK_MAX_MEMORY_HEAPSVkDeviceSize values in which memory budgets are returned, with
    ///     one element for each memory heap. A heap&#8217;s budget is a rough estimate of how much memory the process
    ///     canallocate from that heap before allocations may fail or cause performance degradation. The budget includes any
    ///     currently allocated device memory.
    /// </summary>
    public VkArray16<VkDeviceSize> heapBudget;

    /// <summary>
    ///     heapUsage is an array of VK_MAX_MEMORY_HEAPSVkDeviceSize values in which memory usages are returned, with one
    ///     element for each memory heap. A heap&#8217;s usage is an estimate of how much memory the process is currently using
    ///     in that heap.
    /// </summary>
    public VkArray16<VkDeviceSize> heapUsage;
}