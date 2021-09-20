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
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 transformFeedback;
        public VkBool32 geometryStreams;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT;
        public VkStructureType sType;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public VkDeviceSize maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public VkBool32 transformFeedbackQueries;
        public VkBool32 transformFeedbackStreamsLinesTriangles;
        public VkBool32 transformFeedbackRasterizationStreamSelect;
        public VkBool32 transformFeedbackDraw;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public const VkStructureType STYPE = VkStructureType.PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT;
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint rasterizationStream;
    }
}
