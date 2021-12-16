#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR;
    public       VkStructureType sType;
    public       void*           pNext;
    public       ulong           maxGeometryCount;
    public       ulong           maxInstanceCount;
    public       ulong           maxPrimitiveCount;
    public       uint            maxPerStageDescriptorAccelerationStructures;
    public       uint            maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
    public       uint            maxDescriptorSetAccelerationStructures;
    public       uint            maxDescriptorSetUpdateAfterBindAccelerationStructures;
    public       uint            minAccelerationStructureScratchOffsetAlignment;
}