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
///     VkWriteDescriptorSetAccelerationStructureNV - Structure specifying acceleration structure descriptor information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetAccelerationStructureNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetAccelerationStructureNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkWriteDescriptorSet</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkWriteDescriptorSet")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>accelerationStructureCount is the number of elements in pAccelerationStructures.</summary>
    public uint accelerationStructureCount;

    /// <summary>
    ///     pAccelerationStructures is a pointer to an array of VkAccelerationStructureNV structures specifying the
    ///     acceleration structures to update.
    /// </summary>
    public VkAccelerationStructureNV* pAccelerationStructures;
}