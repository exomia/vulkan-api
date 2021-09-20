#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public readonly unsafe struct VkCmdSetSampleLocationsEXT
    {
        public static readonly VkCmdSetSampleLocationsEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,           /* commandBuffer */
            VkSampleLocationsInfoEXT*, /* pSampleLocationsInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetSampleLocationsEXT(void* ptr)
        {
            VkCmdSetSampleLocationsEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMultisamplePropertiesEXT
    {
        public static readonly VkGetPhysicalDeviceMultisamplePropertiesEXT Null = null;

        public readonly delegate*<
            VkPhysicalDevice,            /* physicalDevice */
            VkSampleCountFlagBits,       /* samples */
            VkMultisamplePropertiesEXT*, /* pMultisampleProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceMultisamplePropertiesEXT(void* ptr)
        {
            VkGetPhysicalDeviceMultisamplePropertiesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
