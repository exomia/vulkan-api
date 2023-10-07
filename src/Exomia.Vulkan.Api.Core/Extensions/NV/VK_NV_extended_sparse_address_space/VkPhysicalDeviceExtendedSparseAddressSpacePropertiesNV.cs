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
///     VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV - Structure describing sparse address space limits of an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_SPARSE_ADDRESS_SPACE_PROPERTIES_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     extendedSparseAddressSpaceSize is the total amount of address space available, in bytes, for sparse memory
    ///     resources of all usages if the extendedSparseAddressSpace feature is enabled. This must be greater than or equal to
    ///     VkPhysicalDeviceLimits::sparseAddressSpaceSize, and the difference in space must only be used with usages allowed
    ///     below. This is an upper bound on the sum of the sizes of all sparse resources, regardless of whether any memory is
    ///     bound to them.
    /// </summary>
    public VkDeviceSize extendedSparseAddressSpaceSize;

    /// <summary>
    ///     extendedSparseImageUsageFlags is a bitmask of VkImageUsageFlagBits of usages which may allow an implementation
    ///     to use the full extendedSparseAddressSpaceSize space.
    /// </summary>
    public VkImageUsageFlags extendedSparseImageUsageFlags;

    /// <summary>
    ///     extendedSparseBufferUsageFlags is a bitmask of VkBufferUsageFlagBits of usages which may allow an
    ///     implementation to use the full extendedSparseAddressSpaceSize space.
    /// </summary>
    public VkBufferUsageFlags extendedSparseBufferUsageFlags;
}