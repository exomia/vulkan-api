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
///     VkPerformanceCounterDescriptionKHR - Structure providing more detailed information about a counter -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceCounterDescriptionKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceCounterDescriptionKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     flags is a bitmask of VkPerformanceCounterDescriptionFlagBitsKHR indicating the usage behavior for the
    ///     counter.
    /// </summary>
    public VkPerformanceCounterDescriptionFlagsKHR flags;

    /// <summary>
    ///     name is an array of size VK_MAX_DESCRIPTION_SIZE, containing a null-terminated UTF-8 string specifying the
    ///     name of the counter.
    /// </summary>
    public fixed byte name[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     category is an array of size VK_MAX_DESCRIPTION_SIZE, containing a null-terminated UTF-8 string specifying the
    ///     category of the counter.
    /// </summary>
    public fixed byte category[(int)VK_MAX_DESCRIPTION_SIZE];

    /// <summary>
    ///     description is an array of size VK_MAX_DESCRIPTION_SIZE, containing a null-terminated UTF-8 string specifying
    ///     the description of the counter.
    /// </summary>
    public fixed byte description[(int)VK_MAX_DESCRIPTION_SIZE];
}