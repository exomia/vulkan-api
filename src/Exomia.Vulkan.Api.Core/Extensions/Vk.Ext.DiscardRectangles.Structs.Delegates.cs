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
    public readonly unsafe struct VkCmdSetDiscardRectangleEXT
    {
        public static readonly VkCmdSetDiscardRectangleEXT Null = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstDiscardRectangle */
            uint,            /* discardRectangleCount */
            VkRect2D*,       /* pDiscardRectangles */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDiscardRectangleEXT(void* ptr)
        {
            VkCmdSetDiscardRectangleEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }
}
