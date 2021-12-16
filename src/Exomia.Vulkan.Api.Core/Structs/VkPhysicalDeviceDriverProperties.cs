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
public unsafe struct VkPhysicalDeviceDriverProperties
{
    public const VkStructureType      STYPE = VkStructureType.PHYSICAL_DEVICE_DRIVER_PROPERTIES;
    public       VkStructureType      sType;
    public       void*                pNext;
    public       VkDriverId           driverID;
    public fixed sbyte                driverName[(int)Vk.VK_MAX_DRIVER_NAME_SIZE];
    public fixed sbyte                driverInfo[(int)Vk.VK_MAX_DRIVER_INFO_SIZE];
    public       VkConformanceVersion conformanceVersion;
}