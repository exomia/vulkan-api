#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.NV
{
    [VkExtGenerator]
    public static unsafe partial class VkNvExternalMemoryRdma
    {
        public const int VK_NV_EXTERNAL_MEMORY_RDMA = 1;
        public const int VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;
        public const string VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME = "VK_NV_external_memory_rdma";

        public static readonly delegate*<
            VkDevice,                         /* device */
            VkMemoryGetRemoteAddressInfoNV*,  /* getMemoryRemoteAddressInfo */
            void*,                            /* pAddress */
            VkResult> vkGetMemoryRemoteAddressNV = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryGetRemoteAddressInfoNV
    {
        public const VkStructureType STYPE = VkStructureType.MEMORY_GET_REMOTE_ADDRESS_INFO_NV;
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlagBits handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV;
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 externalMemoryRDMA;
    }
}