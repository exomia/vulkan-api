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
    public unsafe struct VkPhysicalDevice16BitStorageFeatures
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        storageBuffer16BitAccess;
        public       VkBool32        uniformAndStorageBuffer16BitAccess;
        public       VkBool32        storagePushConstant16;
        public       VkBool32        storageInputOutput16;
    }
}