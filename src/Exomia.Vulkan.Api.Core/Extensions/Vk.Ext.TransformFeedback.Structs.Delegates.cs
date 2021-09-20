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
    public readonly unsafe struct VkCmdBindTransformFeedbackBuffersEXT
    {
        public static readonly VkCmdBindTransformFeedbackBuffersEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBindTransformFeedbackBuffersEXT(void* ptr)
        {
            VkCmdBindTransformFeedbackBuffersEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginTransformFeedbackEXT
    {
        public static readonly VkCmdBeginTransformFeedbackEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginTransformFeedbackEXT(void* ptr)
        {
            VkCmdBeginTransformFeedbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndTransformFeedbackEXT
    {
        public static readonly VkCmdEndTransformFeedbackEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndTransformFeedbackEXT(void* ptr)
        {
            VkCmdEndTransformFeedbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginQueryIndexedEXT
    {
        public static readonly VkCmdBeginQueryIndexedEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkQueryPool,            /* queryPool */
            uint,                   /* query */
            VkQueryControlFlagBits, /* FlagBits */
            uint,                   /* index */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginQueryIndexedEXT(void* ptr)
        {
            VkCmdBeginQueryIndexedEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndQueryIndexedEXT
    {
        public static readonly VkCmdEndQueryIndexedEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkQueryPool,     /* queryPool */
            uint,            /* query */
            uint,            /* index */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndQueryIndexedEXT(void* ptr)
        {
            VkCmdEndQueryIndexedEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectByteCountEXT
    {
        public static readonly VkCmdDrawIndirectByteCountEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* instanceCount */
            uint,            /* firstInstance */
            VkBuffer,        /* counterBuffer */
            VkDeviceSize,    /* counterBufferOffset */
            uint,            /* counterOffset */
            uint,            /* vertexStride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawIndirectByteCountEXT(void* ptr)
        {
            VkCmdDrawIndirectByteCountEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
