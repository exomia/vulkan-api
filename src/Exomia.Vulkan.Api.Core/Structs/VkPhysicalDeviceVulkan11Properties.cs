#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public const VkStructureType           STYPE = VkStructureType.PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES;
        public       VkStructureType           sType;
        public       void*                     pNext;
        public fixed byte                      deviceUUID[(int)Vk.VK_UUID_SIZE];
        public fixed byte                      driverUUID[(int)Vk.VK_UUID_SIZE];
        public fixed byte                      deviceLUID[(int)Vk.VK_LUID_SIZE];
        public       uint                      deviceNodeMask;
        public       VkBool32                  deviceLUIDValid;
        public       uint                      subgroupSize;
        public       VkShaderStageFlagBits     subgroupSupportedStages;
        public       VkSubgroupFeatureFlagBits subgroupSupportedOperations;
        public       VkBool32                  subgroupQuadOperationsInAllStages;
        public       VkPointClippingBehavior   pointClippingBehavior;
        public       uint                      maxMultiviewViewCount;
        public       uint                      maxMultiviewInstanceIndex;
        public       VkBool32                  protectedNoFault;
        public       uint                      maxPerSetDescriptors;
        public       VkDeviceSize              maxMemoryAllocationSize;
    }
}