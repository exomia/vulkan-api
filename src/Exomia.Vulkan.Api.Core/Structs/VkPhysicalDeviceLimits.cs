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
    public unsafe struct VkPhysicalDeviceLimits
    {
        public       uint                  maxImageDimension1D;
        public       uint                  maxImageDimension2D;
        public       uint                  maxImageDimension3D;
        public       uint                  maxImageDimensionCube;
        public       uint                  maxImageArrayLayers;
        public       uint                  maxTexelBufferElements;
        public       uint                  maxUniformBufferRange;
        public       uint                  maxStorageBufferRange;
        public       uint                  maxPushConstantsSize;
        public       uint                  maxMemoryAllocationCount;
        public       uint                  maxSamplerAllocationCount;
        public       VkDeviceSize          bufferImageGranularity;
        public       VkDeviceSize          sparseAddressSpaceSize;
        public       uint                  maxBoundDescriptorSets;
        public       uint                  maxPerStageDescriptorSamplers;
        public       uint                  maxPerStageDescriptorUniformBuffers;
        public       uint                  maxPerStageDescriptorStorageBuffers;
        public       uint                  maxPerStageDescriptorSampledImages;
        public       uint                  maxPerStageDescriptorStorageImages;
        public       uint                  maxPerStageDescriptorInputAttachments;
        public       uint                  maxPerStageResources;
        public       uint                  maxDescriptorSetSamplers;
        public       uint                  maxDescriptorSetUniformBuffers;
        public       uint                  maxDescriptorSetUniformBuffersDynamic;
        public       uint                  maxDescriptorSetStorageBuffers;
        public       uint                  maxDescriptorSetStorageBuffersDynamic;
        public       uint                  maxDescriptorSetSampledImages;
        public       uint                  maxDescriptorSetStorageImages;
        public       uint                  maxDescriptorSetInputAttachments;
        public       uint                  maxVertexInputAttributes;
        public       uint                  maxVertexInputBindings;
        public       uint                  maxVertexInputAttributeOffset;
        public       uint                  maxVertexInputBindingStride;
        public       uint                  maxVertexOutputComponents;
        public       uint                  maxTessellationGenerationLevel;
        public       uint                  maxTessellationPatchSize;
        public       uint                  maxTessellationControlPerVertexInputComponents;
        public       uint                  maxTessellationControlPerVertexOutputComponents;
        public       uint                  maxTessellationControlPerPatchOutputComponents;
        public       uint                  maxTessellationControlTotalOutputComponents;
        public       uint                  maxTessellationEvaluationInputComponents;
        public       uint                  maxTessellationEvaluationOutputComponents;
        public       uint                  maxGeometryShaderInvocations;
        public       uint                  maxGeometryInputComponents;
        public       uint                  maxGeometryOutputComponents;
        public       uint                  maxGeometryOutputVertices;
        public       uint                  maxGeometryTotalOutputComponents;
        public       uint                  maxFragmentInputComponents;
        public       uint                  maxFragmentOutputAttachments;
        public       uint                  maxFragmentDualSrcAttachments;
        public       uint                  maxFragmentCombinedOutputResources;
        public       uint                  maxComputeSharedMemorySize;
        public fixed uint                  maxComputeWorkGroupCount[3];
        public       uint                  maxComputeWorkGroupInvocations;
        public fixed uint                  maxComputeWorkGroupSize[3];
        public       uint                  subPixelPrecisionBits;
        public       uint                  subTexelPrecisionBits;
        public       uint                  mipmapPrecisionBits;
        public       uint                  maxDrawIndexedIndexValue;
        public       uint                  maxDrawIndirectCount;
        public       float                 maxSamplerLodBias;
        public       float                 maxSamplerAnisotropy;
        public       uint                  maxViewports;
        public fixed uint                  maxViewportDimensions[2];
        public fixed float                 viewportBoundsRange[2];
        public       uint                  viewportSubPixelBits;
        public       nuint                 minMemoryMapAlignment;
        public       VkDeviceSize          minTexelBufferOffsetAlignment;
        public       VkDeviceSize          minUniformBufferOffsetAlignment;
        public       VkDeviceSize          minStorageBufferOffsetAlignment;
        public       int                   minTexelOffset;
        public       uint                  maxTexelOffset;
        public       int                   minTexelGatherOffset;
        public       uint                  maxTexelGatherOffset;
        public       float                 minInterpolationOffset;
        public       float                 maxInterpolationOffset;
        public       uint                  subPixelInterpolationOffsetBits;
        public       uint                  maxFramebufferWidth;
        public       uint                  maxFramebufferHeight;
        public       uint                  maxFramebufferLayers;
        public       VkSampleCountFlagBits framebufferColorSampleCounts;
        public       VkSampleCountFlagBits framebufferDepthSampleCounts;
        public       VkSampleCountFlagBits framebufferStencilSampleCounts;
        public       VkSampleCountFlagBits framebufferNoAttachmentsSampleCounts;
        public       uint                  maxColorAttachments;
        public       VkSampleCountFlagBits sampledImageColorSampleCounts;
        public       VkSampleCountFlagBits sampledImageIntegerSampleCounts;
        public       VkSampleCountFlagBits sampledImageDepthSampleCounts;
        public       VkSampleCountFlagBits sampledImageStencilSampleCounts;
        public       VkSampleCountFlagBits storageImageSampleCounts;
        public       uint                  maxSampleMaskWords;
        public       VkBool32              timestampComputeAndGraphics;
        public       float                 timestampPeriod;
        public       uint                  maxClipDistances;
        public       uint                  maxCullDistances;
        public       uint                  maxCombinedClipAndCullDistances;
        public       uint                  discreteQueuePriorities;
        public fixed float                 pointSizeRange[2];
        public fixed float                 lineWidthRange[2];
        public       float                 pointSizeGranularity;
        public       float                 lineWidthGranularity;
        public       VkBool32              strictLines;
        public       VkBool32              standardSampleLocations;
        public       VkDeviceSize          optimalBufferCopyOffsetAlignment;
        public       VkDeviceSize          optimalBufferCopyRowPitchAlignment;
        public       VkDeviceSize          nonCoherentAtomSize;
    }
}