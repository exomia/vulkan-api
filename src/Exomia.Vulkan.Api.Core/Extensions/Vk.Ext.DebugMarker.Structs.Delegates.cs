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
    public readonly unsafe struct VkDebugMarkerSetObjectTagEXT
    {
        public static readonly VkDebugMarkerSetObjectTagEXT Null = null;

        public readonly delegate*<
            VkDevice,                       /* device */
            VkDebugMarkerObjectTagInfoEXT*, /* pTagInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkDebugMarkerSetObjectTagEXT(void* ptr)
        {
            VkDebugMarkerSetObjectTagEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDebugMarkerSetObjectNameEXT
    {
        public static readonly VkDebugMarkerSetObjectNameEXT Null = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkDebugMarkerObjectNameInfoEXT*, /* pNameInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkDebugMarkerSetObjectNameEXT(void* ptr)
        {
            VkDebugMarkerSetObjectNameEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerBeginEXT
    {
        public static readonly VkCmdDebugMarkerBeginEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDebugMarkerBeginEXT(void* ptr)
        {
            VkCmdDebugMarkerBeginEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerEndEXT
    {
        public static readonly VkCmdDebugMarkerEndEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDebugMarkerEndEXT(void* ptr)
        {
            VkCmdDebugMarkerEndEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDebugMarkerInsertEXT
    {
        public static readonly VkCmdDebugMarkerInsertEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDebugMarkerInsertEXT(void* ptr)
        {
            VkCmdDebugMarkerInsertEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
