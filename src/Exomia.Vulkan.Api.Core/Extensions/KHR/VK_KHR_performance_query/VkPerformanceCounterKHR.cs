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
///     VkPerformanceCounterKHR - Structure providing information about a counter -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>unit is a VkPerformanceCounterUnitKHR specifying the unit that the counter data will record.</summary>
    public VkPerformanceCounterUnitKHR unit;

    /// <summary>scope is a VkPerformanceCounterScopeKHR specifying the scope that the counter belongs to.</summary>
    public VkPerformanceCounterScopeKHR scope;

    /// <summary>storage is a VkPerformanceCounterStorageKHR specifying the storage type that the counter&#8217;s data uses.</summary>
    public VkPerformanceCounterStorageKHR storage;

    /// <summary>
    ///     uuid is an array of size VK_UUID_SIZE, containing 8-bit values that represent a universally unique identifier
    ///     for the counter of the physical device.
    /// </summary>
    public fixed byte uuid[(int)VK_UUID_SIZE];
}