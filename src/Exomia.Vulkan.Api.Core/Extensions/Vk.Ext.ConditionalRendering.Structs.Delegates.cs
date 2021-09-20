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
    public readonly unsafe struct VkCmdBeginConditionalRenderingEXT
    {
        public static readonly VkCmdBeginConditionalRenderingEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkConditionalRenderingBeginInfoEXT*, /* pConditionalRenderingBegin */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginConditionalRenderingEXT(void* ptr)
        {
            VkCmdBeginConditionalRenderingEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndConditionalRenderingEXT
    {
        public static readonly VkCmdEndConditionalRenderingEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndConditionalRenderingEXT(void* ptr)
        {
            VkCmdEndConditionalRenderingEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}