#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        workgroupMemoryExplicitLayout;
        public       VkBool32        workgroupMemoryExplicitLayoutScalarBlockLayout;
        public       VkBool32        workgroupMemoryExplicitLayout8BitAccess;
        public       VkBool32        workgroupMemoryExplicitLayout16BitAccess;
    }
}