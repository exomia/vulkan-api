#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    public unsafe delegate void CmdBindTransformFeedbackBuffersEXT(
        VkCommandBuffer commandBuffer,
        uint            firstBinding,
        uint            bindingCount,
        VkBuffer*       pBuffers,
        VkDeviceSize*   pOffsets,
        VkDeviceSize*   pSizes);

    public unsafe delegate void CmdBeginTransformFeedbackEXT(
        VkCommandBuffer commandBuffer,
        uint            firstCounterBuffer,
        uint            counterBufferCount,
        VkBuffer*       pCounterBuffers,
        VkDeviceSize*   pCounterBufferOffsets);

    public unsafe delegate void CmdEndTransformFeedbackEXT(
        VkCommandBuffer commandBuffer,
        uint            firstCounterBuffer,
        uint            counterBufferCount,
        VkBuffer*       pCounterBuffers,
        VkDeviceSize*   pCounterBufferOffsets);

    public delegate void CmdBeginQueryIndexedEXT(
        VkCommandBuffer        commandBuffer,
        VkQueryPool            queryPool,
        uint                   query,
        VkQueryControlFlagBits flags,
        uint                   index);

    public delegate void CmdEndQueryIndexedEXT(
        VkCommandBuffer commandBuffer,
        VkQueryPool     queryPool,
        uint            query,
        uint            index);

    public delegate void CmdDrawIndirectByteCountEXT(
        VkCommandBuffer commandBuffer,
        uint            instanceCount,
        uint            firstInstance,
        VkBuffer        counterBuffer,
        VkDeviceSize    counterBufferOffset,
        uint            counterOffset,
        uint            vertexStride);
}
