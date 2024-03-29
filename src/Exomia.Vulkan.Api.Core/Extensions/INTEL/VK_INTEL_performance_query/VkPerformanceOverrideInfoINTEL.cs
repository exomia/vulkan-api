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
///     VkPerformanceOverrideInfoINTEL - Performance override information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideInfoINTEL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceOverrideInfoINTEL.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceOverrideInfoINTEL
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceOverrideInfoINTEL">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPerformanceOverrideInfoINTEL
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>type is the particular VkPerformanceOverrideTypeINTEL to set.</summary>
    public VkPerformanceOverrideTypeINTEL type;

    /// <summary>enable defines whether the override is enabled.</summary>
    public VkBool32 enable;

    /// <summary>parameter is a potential required parameter for the override.</summary>
    public ulong parameter;
}