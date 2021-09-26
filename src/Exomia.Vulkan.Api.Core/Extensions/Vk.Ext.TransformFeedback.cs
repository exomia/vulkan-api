#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtTransformFeedback
    {
        public const int    VK_EXT_TRANSFORM_FEEDBACK                = 1;
        public const int    VK_EXT_TRANSFORM_FEEDBACK_SPEC_VERSION   = 1;
        public const string VK_EXT_TRANSFORM_FEEDBACK_EXTENSION_NAME = "VK_EXT_transform_feedback";

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            void> vkCmdBindTransformFeedbackBuffersEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdBeginTransformFeedbackEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdEndTransformFeedbackEXT = null;

        public static readonly delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkQueryPool,            /* queryPool */
            uint,                   /* query */
            VkQueryControlFlagBits, /* FlagBits */
            uint,                   /* index */
            void> vkCmdBeginQueryIndexedEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkQueryPool,     /* queryPool */
            uint,            /* query */
            uint,            /* index */
            void> vkCmdEndQueryIndexedEXT = null;

        public static readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* instanceCount */
            uint,            /* firstInstance */
            VkBuffer,        /* counterBuffer */
            VkDeviceSize,    /* counterBufferOffset */
            uint,            /* counterOffset */
            uint,            /* vertexStride */
            void> vkCmdDrawIndirectByteCountEXT = null;

        public static partial void Load(VkDevice vkDevice);
    }

    [Flags]
    public enum VkPipelineRasterizationStateStreamCreateFlagsEXT : uint
    {
        /// <summary>
        ///     Reserved for future use
        /// </summary>
        Reserved = 0
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        transformFeedback;
        public       VkBool32        geometryStreams;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxTransformFeedbackStreams;
        public       uint            maxTransformFeedbackBuffers;
        public       VkDeviceSize    maxTransformFeedbackBufferSize;
        public       uint            maxTransformFeedbackStreamDataSize;
        public       uint            maxTransformFeedbackBufferDataSize;
        public       uint            maxTransformFeedbackBufferDataStride;
        public       VkBool32        transformFeedbackQueries;
        public       VkBool32        transformFeedbackStreamsLinesTriangles;
        public       VkBool32        transformFeedbackRasterizationStreamSelect;
        public       VkBool32        transformFeedbackDraw;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public const VkStructureType                                  STYPE = VkStructureType.PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT;
        public       VkStructureType                                  sType;
        public       void*                                            pNext;
        public       VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public       uint                                             rasterizationStream;
    }
}