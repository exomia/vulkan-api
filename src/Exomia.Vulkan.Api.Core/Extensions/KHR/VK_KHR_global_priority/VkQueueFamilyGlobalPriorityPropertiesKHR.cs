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
///     VkQueueFamilyGlobalPriorityPropertiesKHR - Return structure for queue family global priority information query -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyGlobalPriorityPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueueFamilyGlobalPriorityPropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkQueueFamilyProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkQueueFamilyProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyGlobalPriorityPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     priorityCount is the number of supported global queue priorities in this queue family, and it must be greater
    ///     than 0.
    /// </summary>
    public uint priorityCount;

    /// <summary>
    ///     priorities is an array of VK_MAX_GLOBAL_PRIORITY_SIZE_EXTVkQueueGlobalPriorityEXT enums representing all
    ///     supported global queue priorities in this queue family. The first priorityCount elements of the array will be
    ///     valid.
    /// </summary>
    public VkArray16<VkQueueGlobalPriorityKHR> priorities;
}