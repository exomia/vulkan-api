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
///     VkPhysicalDeviceAccelerationStructurePropertiesKHR - Properties of the physical device for acceleration structure -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructurePropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceAccelerationStructurePropertiesKHR.html
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
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary> maxGeometryCount is the maximum number of geometries in the bottom level acceleration structure.</summary>
    public ulong maxGeometryCount;

    /// <summary> maxInstanceCount is the maximum number of instances in the top level acceleration structure.</summary>
    public ulong maxInstanceCount;

    /// <summary>
    ///     maxPrimitiveCount is the maximum number of triangles or AABBs in all geometries in the bottom level
    ///     acceleration structure.
    /// </summary>
    public ulong maxPrimitiveCount;

    /// <summary>
    ///     maxPerStageDescriptorAccelerationStructures is the maximum number of acceleration structure bindings that can
    ///     be accessible to a single shader stage in a pipeline layout. Descriptor bindings with a descriptor type of
    ///     VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR count against this limit. Only descriptor bindings in descriptor set
    ///     layouts created without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this
    ///     limit.
    /// </summary>
    public uint maxPerStageDescriptorAccelerationStructures;

    /// <summary>
    ///     maxPerStageDescriptorUpdateAfterBindAccelerationStructures is similar to
    ///     maxPerStageDescriptorAccelerationStructures but counts descriptor bindings from descriptor sets created with or
    ///     without the VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;

    /// <summary>
    ///     maxDescriptorSetAccelerationStructures is the maximum number of acceleration structure descriptors that can be
    ///     included in descriptor bindings in a pipeline layout across all pipeline shader stages and descriptor set numbers.
    ///     Descriptor bindings with a descriptor type of VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR count against this
    ///     limit. Only descriptor bindings in descriptor set layouts created without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set count against this limit.
    /// </summary>
    public uint maxDescriptorSetAccelerationStructures;

    /// <summary>
    ///     maxDescriptorSetUpdateAfterBindAccelerationStructures is similar to maxDescriptorSetAccelerationStructures but
    ///     counts descriptor bindings from descriptor sets created with or without the
    ///     VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT bit set.
    /// </summary>
    public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;

    /// <summary>
    ///     minAccelerationStructureScratchOffsetAlignment is the minimum required alignment, in bytes, for scratch data
    ///     passed in to an acceleration structure build command. The value must be a power of two.
    /// </summary>
    public uint minAccelerationStructureScratchOffsetAlignment;
}