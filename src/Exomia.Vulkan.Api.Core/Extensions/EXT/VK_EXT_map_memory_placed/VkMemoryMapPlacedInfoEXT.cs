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
///     VkMemoryMapPlacedInfoEXT - Structure containing memory map placement parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapPlacedInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMemoryMapPlacedInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkMemoryMapInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkMemoryMapInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryMapPlacedInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MEMORY_MAP_PLACED_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pPlacedAddress is the virtual address at which to place the address. If VkMemoryMapInfoKHR::flags does not
    ///     contain VK_MEMORY_MAP_PLACED_BIT_EXT, this value is ignored.
    /// </summary>
    public void* pPlacedAddress;
}