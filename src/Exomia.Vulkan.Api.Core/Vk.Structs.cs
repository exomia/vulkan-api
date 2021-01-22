#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    using static Vk;
    using size_t = nuint;
    using VkSampleMask = UInt32;
    using VkAccelerationStructureTypeNV = VkAccelerationStructureTypeKHR;

    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent2D
    {
        public uint width;
        public uint height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkExtent3D
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset2D
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkOffset3D
    {
        public int x;
        public int y;
        public int z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkRect2D
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBaseInStructure
    {
        public VkStructureType    sType;
        public VkBaseInStructure* pNext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBaseOutStructure
    {
        public VkStructureType     sType;
        public VkBaseOutStructure* pNext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferMemoryBarrier
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkAccessFlags   srcAccessMask;
        public VkAccessFlags   dstAccessMask;
        public uint            srcQueueFamilyIndex;
        public uint            dstQueueFamilyIndex;
        public VkBuffer        buffer;
        public VkDeviceSize    offset;
        public VkDeviceSize    size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDispatchIndirectCommand
    {
        public uint x;
        public uint y;
        public uint z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndexedIndirectCommand
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int  vertexOffset;
        public uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndirectCommand
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceRange
    {
        public VkImageAspectFlags aspectMask;
        public uint               baseMipLevel;
        public uint               levelCount;
        public uint               baseArrayLayer;
        public uint               layerCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageMemoryBarrier
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkAccessFlags           srcAccessMask;
        public VkAccessFlags           dstAccessMask;
        public VkImageLayout           oldLayout;
        public VkImageLayout           newLayout;
        public uint                    srcQueueFamilyIndex;
        public uint                    dstQueueFamilyIndex;
        public VkImage                 image;
        public VkImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryBarrier
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkAccessFlags   srcAccessMask;
        public VkAccessFlags   dstAccessMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAllocationCallbacks
    {
        public void* pUserData;

        public delegate*<            /*vkAllocationFunction*/
            void*,                   /* pUserData          */
            size_t,                  /* size               */
            size_t,                  /* alignment          */
            VkSystemAllocationScope, /* allocationScope    */
            void*> pfnAllocation;

        public delegate*<            /*vkReallocationFunction*/
            void*,                   /* pUserData            */
            void*,                   /* pOriginal            */
            size_t,                  /* size                 */
            size_t,                  /* alignment            */
            VkSystemAllocationScope, /* allocationScope      */
            void*> pfnReallocation;

        public delegate*< /*FreeFunction*/
            void*,        /* pUserData  */
            void*,        /* pMemory    */
            void> pfnFree;

        public delegate*<             /*vkInternalAllocationNotification*/
            void*,                    /* pUserData                      */
            size_t,                   /* size                           */
            VkInternalAllocationType, /* allocationType                 */
            VkSystemAllocationScope,  /* allocationScope                */
            void> pfnInternalAllocation;

        public delegate*<             /*vkInternalFreeNotification*/
            void*,                    /* pUserData                */
            size_t,                   /* size                     */
            VkInternalAllocationType, /* allocationType           */
            VkSystemAllocationScope,  /* allocationScope          */
            void> pfnInternalFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public sbyte*          pApplicationName;
        public VkVersion       applicationVersion;
        public sbyte*          pEngineName;
        public VkVersion       engineVersion;
        public VkVersion       apiVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkFormatProperties
    {
        public VkFormatFeatureFlags linearTilingFeatures;
        public VkFormatFeatureFlags optimalTilingFeatures;
        public VkFormatFeatureFlags bufferFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageFormatProperties
    {
        public VkExtent3D         maxExtent;
        public uint               maxMipLevels;
        public uint               maxArrayLayers;
        public VkSampleCountFlags sampleCounts;
        public VkDeviceSize       maxResourceSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkInstanceCreateInfo
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkInstanceCreateFlags flags;
        public VkApplicationInfo*    pApplicationInfo;
        public uint                  enabledLayerCount;
        public sbyte**               ppEnabledLayerNames;
        public uint                  enabledExtensionCount;
        public sbyte**               ppEnabledExtensionNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryHeap
    {
        public VkDeviceSize      size;
        public VkMemoryHeapFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryType
    {
        public VkMemoryPropertyFlags propertyFlags;
        public uint                  heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        public VkBool32 robustBufferAccess;
        public VkBool32 fullDrawIndexUint32;
        public VkBool32 imageCubeArray;
        public VkBool32 independentBlend;
        public VkBool32 geometryShader;
        public VkBool32 tessellationShader;
        public VkBool32 sampleRateShading;
        public VkBool32 dualSrcBlend;
        public VkBool32 logicOp;
        public VkBool32 multiDrawIndirect;
        public VkBool32 drawIndirectFirstInstance;
        public VkBool32 depthClamp;
        public VkBool32 depthBiasClamp;
        public VkBool32 fillModeNonSolid;
        public VkBool32 depthBounds;
        public VkBool32 wideLines;
        public VkBool32 largePoints;
        public VkBool32 alphaToOne;
        public VkBool32 multiViewport;
        public VkBool32 samplerAnisotropy;
        public VkBool32 textureCompressionETC2;
        public VkBool32 textureCompressionASTC_LDR;
        public VkBool32 textureCompressionBC;
        public VkBool32 occlusionQueryPrecise;
        public VkBool32 pipelineStatisticsQuery;
        public VkBool32 vertexPipelineStoresAndAtomics;
        public VkBool32 fragmentStoresAndAtomics;
        public VkBool32 shaderTessellationAndGeometryPointSize;
        public VkBool32 shaderImageGatherExtended;
        public VkBool32 shaderStorageImageExtendedFormats;
        public VkBool32 shaderStorageImageMultisample;
        public VkBool32 shaderStorageImageReadWithoutFormat;
        public VkBool32 shaderStorageImageWriteWithoutFormat;
        public VkBool32 shaderUniformBufferArrayDynamicIndexing;
        public VkBool32 shaderSampledImageArrayDynamicIndexing;
        public VkBool32 shaderStorageBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageImageArrayDynamicIndexing;
        public VkBool32 shaderClipDistance;
        public VkBool32 shaderCullDistance;
        public VkBool32 shaderFloat64;
        public VkBool32 shaderInt64;
        public VkBool32 shaderInt16;
        public VkBool32 shaderResourceResidency;
        public VkBool32 shaderResourceMinLod;
        public VkBool32 sparseBinding;
        public VkBool32 sparseResidencyBuffer;
        public VkBool32 sparseResidencyImage2D;
        public VkBool32 sparseResidencyImage3D;
        public VkBool32 sparseResidency2Samples;
        public VkBool32 sparseResidency4Samples;
        public VkBool32 sparseResidency8Samples;
        public VkBool32 sparseResidency16Samples;
        public VkBool32 sparseResidencyAliased;
        public VkBool32 variableMultisampleRate;
        public VkBool32 inheritedQueries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceLimits
    {
        public       uint               maxImageDimension1D;
        public       uint               maxImageDimension2D;
        public       uint               maxImageDimension3D;
        public       uint               maxImageDimensionCube;
        public       uint               maxImageArrayLayers;
        public       uint               maxTexelBufferElements;
        public       uint               maxUniformBufferRange;
        public       uint               maxStorageBufferRange;
        public       uint               maxPushConstantsSize;
        public       uint               maxMemoryAllocationCount;
        public       uint               maxSamplerAllocationCount;
        public       VkDeviceSize       bufferImageGranularity;
        public       VkDeviceSize       sparseAddressSpaceSize;
        public       uint               maxBoundDescriptorSets;
        public       uint               maxPerStageDescriptorSamplers;
        public       uint               maxPerStageDescriptorUniformBuffers;
        public       uint               maxPerStageDescriptorStorageBuffers;
        public       uint               maxPerStageDescriptorSampledImages;
        public       uint               maxPerStageDescriptorStorageImages;
        public       uint               maxPerStageDescriptorInputAttachments;
        public       uint               maxPerStageResources;
        public       uint               maxDescriptorSetSamplers;
        public       uint               maxDescriptorSetUniformBuffers;
        public       uint               maxDescriptorSetUniformBuffersDynamic;
        public       uint               maxDescriptorSetStorageBuffers;
        public       uint               maxDescriptorSetStorageBuffersDynamic;
        public       uint               maxDescriptorSetSampledImages;
        public       uint               maxDescriptorSetStorageImages;
        public       uint               maxDescriptorSetInputAttachments;
        public       uint               maxVertexInputAttributes;
        public       uint               maxVertexInputBindings;
        public       uint               maxVertexInputAttributeOffset;
        public       uint               maxVertexInputBindingStride;
        public       uint               maxVertexOutputComponents;
        public       uint               maxTessellationGenerationLevel;
        public       uint               maxTessellationPatchSize;
        public       uint               maxTessellationControlPerVertexInputComponents;
        public       uint               maxTessellationControlPerVertexOutputComponents;
        public       uint               maxTessellationControlPerPatchOutputComponents;
        public       uint               maxTessellationControlTotalOutputComponents;
        public       uint               maxTessellationEvaluationInputComponents;
        public       uint               maxTessellationEvaluationOutputComponents;
        public       uint               maxGeometryShaderInvocations;
        public       uint               maxGeometryInputComponents;
        public       uint               maxGeometryOutputComponents;
        public       uint               maxGeometryOutputVertices;
        public       uint               maxGeometryTotalOutputComponents;
        public       uint               maxFragmentInputComponents;
        public       uint               maxFragmentOutputAttachments;
        public       uint               maxFragmentDualSrcAttachments;
        public       uint               maxFragmentCombinedOutputResources;
        public       uint               maxComputeSharedMemorySize;
        public fixed uint               maxComputeWorkGroupCount[3];
        public       uint               maxComputeWorkGroupInvocations;
        public fixed uint               maxComputeWorkGroupSize[3];
        public       uint               subPixelPrecisionBits;
        public       uint               subTexelPrecisionBits;
        public       uint               mipmapPrecisionBits;
        public       uint               maxDrawIndexedIndexValue;
        public       uint               maxDrawIndirectCount;
        public       float              maxSamplerLodBias;
        public       float              maxSamplerAnisotropy;
        public       uint               maxViewports;
        public fixed uint               maxViewportDimensions[2];
        public fixed float              viewportBoundsRange[2];
        public       uint               viewportSubPixelBits;
        public       nuint              minMemoryMapAlignment;
        public       VkDeviceSize       minTexelBufferOffsetAlignment;
        public       VkDeviceSize       minUniformBufferOffsetAlignment;
        public       VkDeviceSize       minStorageBufferOffsetAlignment;
        public       int                minTexelOffset;
        public       uint               maxTexelOffset;
        public       int                minTexelGatherOffset;
        public       uint               maxTexelGatherOffset;
        public       float              minInterpolationOffset;
        public       float              maxInterpolationOffset;
        public       uint               subPixelInterpolationOffsetBits;
        public       uint               maxFramebufferWidth;
        public       uint               maxFramebufferHeight;
        public       uint               maxFramebufferLayers;
        public       VkSampleCountFlags framebufferColorSampleCounts;
        public       VkSampleCountFlags framebufferDepthSampleCounts;
        public       VkSampleCountFlags framebufferStencilSampleCounts;
        public       VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
        public       uint               maxColorAttachments;
        public       VkSampleCountFlags sampledImageColorSampleCounts;
        public       VkSampleCountFlags sampledImageIntegerSampleCounts;
        public       VkSampleCountFlags sampledImageDepthSampleCounts;
        public       VkSampleCountFlags sampledImageStencilSampleCounts;
        public       VkSampleCountFlags storageImageSampleCounts;
        public       uint               maxSampleMaskWords;
        public       VkBool32           timestampComputeAndGraphics;
        public       float              timestampPeriod;
        public       uint               maxClipDistances;
        public       uint               maxCullDistances;
        public       uint               maxCombinedClipAndCullDistances;
        public       uint               discreteQueuePriorities;
        public fixed float              pointSizeRange[2];
        public fixed float              lineWidthRange[2];
        public       float              pointSizeGranularity;
        public       float              lineWidthGranularity;
        public       VkBool32           strictLines;
        public       VkBool32           standardSampleLocations;
        public       VkDeviceSize       optimalBufferCopyOffsetAlignment;
        public       VkDeviceSize       optimalBufferCopyRowPitchAlignment;
        public       VkDeviceSize       nonCoherentAtomSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryProperties
    {
        public uint                    memoryTypeCount;
        public VkArray32<VkMemoryType> memoryTypes;
        public uint                    memoryHeapCount;
        public VkArray16<VkMemoryHeap> memoryHeaps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseProperties
    {
        public VkBool32 residencyStandard2DBlockShape;
        public VkBool32 residencyStandard2DMultisampleBlockShape;
        public VkBool32 residencyStandard3DBlockShape;
        public VkBool32 residencyAlignedMipSize;
        public VkBool32 residencyNonResidentStrict;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProperties
    {
        public       VkVersion                        apiVersion;
        public       uint                             driverVersion;
        public       uint                             vendorID;
        public       uint                             deviceID;
        public       VkPhysicalDeviceType             deviceType;
        public fixed sbyte                            deviceName[VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
        public fixed byte                             pipelineCacheUUID[VK_UUID_SIZE];
        public       VkPhysicalDeviceLimits           limits;
        public       VkPhysicalDeviceSparseProperties sparseProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyProperties
    {
        public VkQueueFlags queueFlags;
        public uint         queueCount;
        public uint         timestampValidBits;
        public VkExtent3D   minImageTransferGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceQueueCreateInfo
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint                     queueFamilyIndex;
        public uint                     queueCount;
        public float*                   pQueuePriorities;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceCreateInfo
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkDeviceCreateFlags       flags;
        public uint                      queueCreateInfoCount;
        public VkDeviceQueueCreateInfo*  pQueueCreateInfos;
        public uint                      enabledLayerCount;
        public sbyte**                   ppEnabledLayerNames;
        public uint                      enabledExtensionCount;
        public sbyte**                   ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExtensionProperties
    {
        public fixed sbyte extensionName[VK_MAX_EXTENSION_NAME_SIZE];
        public       uint  specVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkLayerProperties
    {
        public fixed sbyte     layerName[VK_MAX_EXTENSION_NAME_SIZE];
        public       VkVersion specVersion;
        public       uint      implementationVersion;
        public fixed sbyte     description[VK_MAX_DESCRIPTION_SIZE];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubmitInfo
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public uint                  waitSemaphoreCount;
        public VkSemaphore*          pWaitSemaphores;
        public VkPipelineStageFlags* pWaitDstStageMask;
        public uint                  commandBufferCount;
        public VkCommandBuffer*      pCommandBuffers;
        public uint                  signalSemaphoreCount;
        public VkSemaphore*          pSignalSemaphores;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMappedMemoryRange
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceMemory  memory;
        public VkDeviceSize    offset;
        public VkDeviceSize    size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    allocationSize;
        public uint            memoryTypeIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryRequirements
    {
        public VkDeviceSize size;
        public VkDeviceSize alignment;
        public uint         memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseMemoryBind
    {
        public VkDeviceSize            resourceOffset;
        public VkDeviceSize            size;
        public VkDeviceMemory          memory;
        public VkDeviceSize            memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer            buffer;
        public uint                bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage             image;
        public uint                bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresource
    {
        public VkImageAspectFlags aspectMask;
        public uint               mipLevel;
        public uint               arrayLayer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryBind
    {
        public VkImageSubresource      subresource;
        public VkOffset3D              offset;
        public VkExtent3D              extent;
        public VkDeviceMemory          memory;
        public VkDeviceSize            memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSparseImageMemoryBindInfo
    {
        public VkImage                  image;
        public uint                     bindCount;
        public VkSparseImageMemoryBind* pBinds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindSparseInfo
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public uint                               waitSemaphoreCount;
        public VkSemaphore*                       pWaitSemaphores;
        public uint                               bufferBindCount;
        public VkSparseBufferMemoryBindInfo*      pBufferBinds;
        public uint                               imageOpaqueBindCount;
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        public uint                               imageBindCount;
        public VkSparseImageMemoryBindInfo*       pImageBinds;
        public uint                               signalSemaphoreCount;
        public VkSemaphore*                       pSignalSemaphores;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlags       aspectMask;
        public VkExtent3D               imageGranularity;
        public VkSparseImageFormatFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties formatProperties;
        public uint                          imageMipTailFirstLod;
        public VkDeviceSize                  imageMipTailSize;
        public VkDeviceSize                  imageMipTailOffset;
        public VkDeviceSize                  imageMipTailStride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFenceCreateInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkFenceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSemaphoreCreateInfo
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkSemaphoreCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkEventCreateInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkEventCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueryPoolCreateInfo
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkQueryPoolCreateFlags        flags;
        public VkQueryType                   queryType;
        public uint                          queryCount;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferCreateInfo
    {
        public VkStructureType     sType;
        public void*               pNext;
        public VkBufferCreateFlags flags;
        public VkDeviceSize        size;
        public VkBufferUsageFlags  usage;
        public VkSharingMode       sharingMode;
        public uint                queueFamilyIndexCount;
        public uint*               pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferViewCreateInfo
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkBufferViewCreateFlags flags;
        public VkBuffer                buffer;
        public VkFormat                format;
        public VkDeviceSize            offset;
        public VkDeviceSize            range;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageCreateInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkImageCreateFlags flags;
        public VkImageType        imageType;
        public VkFormat           format;
        public VkExtent3D         extent;
        public uint               mipLevels;
        public uint               arrayLayers;
        public VkSampleCountFlags samples;
        public VkImageTiling      tiling;
        public VkImageUsageFlags  usage;
        public VkSharingMode      sharingMode;
        public uint               queueFamilyIndexCount;
        public uint*              pQueueFamilyIndices;
        public VkImageLayout      initialLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubresourceLayout
    {
        public VkDeviceSize offset;
        public VkDeviceSize size;
        public VkDeviceSize rowPitch;
        public VkDeviceSize arrayPitch;
        public VkDeviceSize depthPitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkComponentMapping
    {
        public VkComponentSwizzle r;
        public VkComponentSwizzle g;
        public VkComponentSwizzle b;
        public VkComponentSwizzle a;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewCreateInfo
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkImageViewCreateFlags  flags;
        public VkImage                 image;
        public VkImageViewType         viewType;
        public VkFormat                format;
        public VkComponentMapping      components;
        public VkImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShaderModuleCreateInfo
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkShaderModuleCreateFlags flags;
        public nuint                     codeSize;
        public uint*                     pCode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCacheCreateInfo
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkPipelineCacheCreateFlags flags;
        public nuint                      initialDataSize;
        public void*                      pInitialData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSpecializationMapEntry
    {
        public uint  constantID;
        public uint  offset;
        public nuint size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSpecializationInfo
    {
        public uint                      mapEntryCount;
        public VkSpecializationMapEntry* pMapEntries;
        public nuint                     dataSize;
        public void*                     pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkPipelineShaderStageCreateFlags flags;
        public VkShaderStageFlags               stage;
        public VkShaderModule                   module;
        public sbyte*                           pName;
        public VkSpecializationInfo*            pSpecializationInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkComputePipelineCreateInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkPipelineCreateFlags           flags;
        public VkPipelineShaderStageCreateInfo stage;
        public VkPipelineLayout                layout;
        public VkPipeline                      basePipelineHandle;
        public int                             basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDescription
    {
        public uint              binding;
        public uint              stride;
        public VkVertexInputRate inputRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputAttributeDescription
    {
        public uint     location;
        public uint     binding;
        public VkFormat format;
        public uint     offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType                       sType;
        public void*                                 pNext;
        public VkPipelineVertexInputStateCreateFlags flags;
        public uint                                  vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription*      pVertexBindingDescriptions;
        public uint                                  vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription*    pVertexAttributeDescriptions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType                         sType;
        public void*                                   pNext;
        public VkPipelineInputAssemblyStateCreateFlags flags;
        public VkPrimitiveTopology                     topology;
        public VkBool32                                primitiveRestartEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType                        sType;
        public void*                                  pNext;
        public VkPipelineTessellationStateCreateFlags flags;
        public uint                                   patchControlPoints;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewport
    {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkPipelineViewportStateCreateFlags flags;
        public uint                               viewportCount;
        public VkViewport*                        pViewports;
        public uint                               scissorCount;
        public VkRect2D*                          pScissors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType                         sType;
        public void*                                   pNext;
        public VkPipelineRasterizationStateCreateFlags flags;
        public VkBool32                                depthClampEnable;
        public VkBool32                                rasterizerDiscardEnable;
        public VkPolygonMode                           polygonMode;
        public VkCullModeFlags                         cullMode;
        public VkFrontFace                             frontFace;
        public VkBool32                                depthBiasEnable;
        public float                                   depthBiasConstantFactor;
        public float                                   depthBiasClamp;
        public float                                   depthBiasSlopeFactor;
        public float                                   lineWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType                       sType;
        public void*                                 pNext;
        public VkPipelineMultisampleStateCreateFlags flags;
        public VkSampleCountFlags                    rasterizationSamples;
        public VkBool32                              sampleShadingEnable;
        public float                                 minSampleShading;
        public uint*                                 pSampleMask;
        public VkBool32                              alphaToCoverageEnable;
        public VkBool32                              alphaToOneEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkStencilOpState
    {
        public VkStencilOp failOp;
        public VkStencilOp passOp;
        public VkStencilOp depthFailOp;
        public VkCompareOp compareOp;
        public uint        compareMask;
        public uint        writeMask;
        public uint        reference;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType                        sType;
        public void*                                  pNext;
        public VkPipelineDepthStencilStateCreateFlags flags;
        public VkBool32                               depthTestEnable;
        public VkBool32                               depthWriteEnable;
        public VkCompareOp                            depthCompareOp;
        public VkBool32                               depthBoundsTestEnable;
        public VkBool32                               stencilTestEnable;
        public VkStencilOpState                       front;
        public VkStencilOpState                       back;
        public float                                  minDepthBounds;
        public float                                  maxDepthBounds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAttachmentState
    {
        public VkBool32              blendEnable;
        public VkBlendFactor         srcColorBlendFactor;
        public VkBlendFactor         dstColorBlendFactor;
        public VkBlendOp             colorBlendOp;
        public VkBlendFactor         srcAlphaBlendFactor;
        public VkBlendFactor         dstAlphaBlendFactor;
        public VkBlendOp             alphaBlendOp;
        public VkColorComponentFlags colorWriteMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorBlendStateCreateInfo
    {
        public       VkStructureType                      sType;
        public       void*                                pNext;
        public       VkPipelineColorBlendStateCreateFlags flags;
        public       VkBool32                             logicOpEnable;
        public       VkLogicOp                            logicOp;
        public       uint                                 attachmentCount;
        public       VkPipelineColorBlendAttachmentState* pAttachments;
        public fixed float                                blendConstants[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkPipelineDynamicStateCreateFlags flags;
        public uint                              dynamicStateCount;
        public VkDynamicState*                   pDynamicStates;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType                         sType;
        public void*                                   pNext;
        public VkPipelineCreateFlags                   flags;
        public uint                                    stageCount;
        public VkPipelineShaderStageCreateInfo*        pStages;
        public VkPipelineVertexInputStateCreateInfo*   pVertexInputState;
        public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public VkPipelineTessellationStateCreateInfo*  pTessellationState;
        public VkPipelineViewportStateCreateInfo*      pViewportState;
        public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public VkPipelineMultisampleStateCreateInfo*   pMultisampleState;
        public VkPipelineDepthStencilStateCreateInfo*  pDepthStencilState;
        public VkPipelineColorBlendStateCreateInfo*    pColorBlendState;
        public VkPipelineDynamicStateCreateInfo*       pDynamicState;
        public VkPipelineLayout                        layout;
        public VkRenderPass                            renderPass;
        public uint                                    subpass;
        public VkPipeline                              basePipelineHandle;
        public int                                     basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPushConstantRange
    {
        public VkShaderStageFlags stageFlags;
        public uint               offset;
        public uint               size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public VkPipelineLayoutCreateFlags flags;
        public uint                        setLayoutCount;
        public VkDescriptorSetLayout*      pSetLayouts;
        public uint                        pushConstantRangeCount;
        public VkPushConstantRange*        pPushConstantRanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerCreateInfo
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkSamplerCreateFlags flags;
        public VkFilter             magFilter;
        public VkFilter             minFilter;
        public VkSamplerMipmapMode  mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float                mipLodBias;
        public VkBool32             anisotropyEnable;
        public float                maxAnisotropy;
        public VkBool32             compareEnable;
        public VkCompareOp          compareOp;
        public float                minLod;
        public float                maxLod;
        public VkBorderColor        borderColor;
        public VkBool32             unnormalizedCoordinates;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyDescriptorSet
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDescriptorSet srcSet;
        public uint            srcBinding;
        public uint            srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint            dstBinding;
        public uint            dstArrayElement;
        public uint            descriptorCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorBufferInfo
    {
        public VkBuffer     buffer;
        public VkDeviceSize offset;
        public VkDeviceSize range;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorImageInfo
    {
        public VkSampler     sampler;
        public VkImageView   imageView;
        public VkImageLayout imageLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorPoolSize
    {
        public VkDescriptorType type;
        public uint             descriptorCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public VkDescriptorPoolCreateFlags flags;
        public uint                        maxSets;
        public uint                        poolSizeCount;
        public VkDescriptorPoolSize*       pPoolSizes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkDescriptorPool       descriptorPool;
        public uint                   descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetLayoutBinding
    {
        public uint               binding;
        public VkDescriptorType   descriptorType;
        public uint               descriptorCount;
        public VkShaderStageFlags stageFlags;
        public VkSampler*         pImmutableSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkDescriptorSetLayoutCreateFlags flags;
        public uint                             bindingCount;
        public VkDescriptorSetLayoutBinding*    pBindings;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSet
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkDescriptorSet         dstSet;
        public uint                    dstBinding;
        public uint                    dstArrayElement;
        public uint                    descriptorCount;
        public VkDescriptorType        descriptorType;
        public VkDescriptorImageInfo*  pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView*           pTexelBufferView;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlags flags;
        public VkFormat                     format;
        public VkSampleCountFlags           samples;
        public VkAttachmentLoadOp           loadOp;
        public VkAttachmentStoreOp          storeOp;
        public VkAttachmentLoadOp           stencilLoadOp;
        public VkAttachmentStoreOp          stencilStoreOp;
        public VkImageLayout                initialLayout;
        public VkImageLayout                finalLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReference
    {
        public uint          attachment;
        public VkImageLayout layout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFramebufferCreateInfo
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkFramebufferCreateFlags flags;
        public VkRenderPass             renderPass;
        public uint                     attachmentCount;
        public VkImageView*             pAttachments;
        public uint                     width;
        public uint                     height;
        public uint                     layers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint       pipelineBindPoint;
        public uint                      inputAttachmentCount;
        public VkAttachmentReference*    pInputAttachments;
        public uint                      colorAttachmentCount;
        public VkAttachmentReference*    pColorAttachments;
        public VkAttachmentReference*    pResolveAttachments;
        public VkAttachmentReference*    pDepthStencilAttachment;
        public uint                      preserveAttachmentCount;
        public uint*                     pPreserveAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDependency
    {
        public uint                 srcSubpass;
        public uint                 dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags        srcAccessMask;
        public VkAccessFlags        dstAccessMask;
        public VkDependencyFlags    dependencyFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassCreateInfo
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkRenderPassCreateFlags  flags;
        public uint                     attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint                     subpassCount;
        public VkSubpassDescription*    pSubpasses;
        public uint                     dependencyCount;
        public VkSubpassDependency*     pDependencies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandPoolCreateInfo
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkCommandPoolCreateFlags flags;
        public uint                     queueFamilyIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferAllocateInfo
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkCommandPool        commandPool;
        public VkCommandBufferLevel level;
        public uint                 commandBufferCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkRenderPass                  renderPass;
        public uint                          subpass;
        public VkFramebuffer                 framebuffer;
        public VkBool32                      occlusionQueryEnable;
        public VkQueryControlFlags           queryFlags;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferBeginInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkCommandBufferUsageFlags       flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferCopy
    {
        public VkDeviceSize srcOffset;
        public VkDeviceSize dstOffset;
        public VkDeviceSize size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceLayers
    {
        public VkImageAspectFlags aspectMask;
        public uint               mipLevel;
        public uint               baseArrayLayer;
        public uint               layerCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferImageCopy
    {
        public VkDeviceSize             bufferOffset;
        public uint                     bufferRowLength;
        public uint                     bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D               imageOffset;
        public VkExtent3D               imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearDepthStencilValue
    {
        public float depth;
        public uint  stencil;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearAttachment
    {
        public VkImageAspectFlags aspectMask;
        public uint               colorAttachment;
        public VkClearValue       clearValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearRect
    {
        public VkRect2D rect;
        public uint     baseArrayLayer;
        public uint     layerCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffsetsLeftTop;
        public VkOffset3D               srcOffsetsRightBottom;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffsetsLeftTop;
        public VkOffset3D               dstOffsetsRightBottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffset;
        public VkExtent3D               extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffset;
        public VkExtent3D               extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkRenderPass    renderPass;
        public VkFramebuffer   framebuffer;
        public VkRect2D        renderArea;
        public uint            clearValueCount;
        public VkClearValue*   pClearValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public uint                   subgroupSize;
        public VkShaderStageFlags     supportedStages;
        public VkSubgroupFeatureFlags supportedOperations;
        public VkBool32               quadOperationsInAllStages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBuffer        buffer;
        public VkDeviceMemory  memory;
        public VkDeviceSize    memoryOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindImageMemoryInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImage         image;
        public VkDeviceMemory  memory;
        public VkDeviceSize    memoryOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        storageBuffer16BitAccess;
        public VkBool32        uniformAndStorageBuffer16BitAccess;
        public VkBool32        storagePushConstant16;
        public VkBool32        storageInputOutput16;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        prefersDedicatedAllocation;
        public VkBool32        requiresDedicatedAllocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImage         image;
        public VkBuffer        buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkMemoryAllocateFlags flags;
        public uint                  deviceMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            deviceMask;
        public uint            deviceRenderAreaCount;
        public VkRect2D*       pDeviceRenderAreas;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            deviceMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            waitSemaphoreCount;
        public uint*           pWaitSemaphoreDeviceIndices;
        public uint            commandBufferCount;
        public uint*           pCommandBufferDeviceMasks;
        public uint            signalSemaphoreCount;
        public uint*           pSignalSemaphoreDeviceIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            resourceDeviceIndex;
        public uint            memoryDeviceIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            deviceIndexCount;
        public uint*           pDeviceIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            deviceIndexCount;
        public uint*           pDeviceIndices;
        public uint            splitInstanceBindRegionCount;
        public VkRect2D*       pSplitInstanceBindRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public uint                        physicalDeviceCount;
        public VkArray32<VkPhysicalDevice> physicalDevices;
        public VkBool32                    subsetAllocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType   sType;
        public void*             pNext;
        public uint              physicalDeviceCount;
        public VkPhysicalDevice* pPhysicalDevices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBuffer        buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImage         image;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageSparseMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImage         image;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryRequirements2
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkMemoryRequirements memoryRequirements;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkSparseImageMemoryRequirements memoryRequirements;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkPhysicalDeviceFeatures features;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProperties2
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkPhysicalDeviceProperties properties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFormatProperties2
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkFormatProperties formatProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageFormatProperties2
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkImageFormatProperties imageFormatProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkFormat           format;
        public VkImageType        type;
        public VkImageTiling      tiling;
        public VkImageUsageFlags  usage;
        public VkImageCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueueFamilyProperties2
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkQueueFamilyProperties queueFamilyProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSparseImageFormatProperties2
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkSparseImageFormatProperties properties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkFormat           format;
        public VkImageType        type;
        public VkSampleCountFlags samples;
        public VkImageUsageFlags  usage;
        public VkImageTiling      tiling;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkPointClippingBehavior pointClippingBehavior;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkInputAttachmentAspectReference
    {
        public uint               subpass;
        public uint               inputAttachmentIndex;
        public VkImageAspectFlags aspectMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public uint                              aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewUsageCreateInfo
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkImageUsageFlags usage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkTessellationDomainOrigin domainOrigin;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            subpassCount;
        public uint*           pViewMasks;
        public uint            dependencyCount;
        public int*            pViewOffsets;
        public uint            correlationMaskCount;
        public uint*           pCorrelationMasks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        multiview;
        public VkBool32        multiviewGeometryShader;
        public VkBool32        multiviewTessellationShader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxMultiviewViewCount;
        public uint            maxMultiviewInstanceIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        variablePointersStorageBuffer;
        public VkBool32        variablePointers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        protectedMemory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        protectedNoFault;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceQueueInfo2
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint                     queueFamilyIndex;
        public uint                     queueIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkProtectedSubmitInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        protectedSubmit;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkFormat                      format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange           ycbcrRange;
        public VkComponentMapping            components;
        public VkChromaLocation              xChromaOffset;
        public VkChromaLocation              yChromaOffset;
        public VkFilter                      chromaFilter;
        public VkBool32                      forceExplicitReconstruction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkSamplerYcbcrConversion conversion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkImageAspectFlags planeAspect;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkImageAspectFlags planeAspect;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        samplerYcbcrConversion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            combinedImageSamplerDescriptorCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorUpdateTemplateEntry
    {
        public uint             dstBinding;
        public uint             dstArrayElement;
        public uint             descriptorCount;
        public VkDescriptorType descriptorType;
        public nuint            offset;
        public nuint            stride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType                       sType;
        public void*                                 pNext;
        public VkDescriptorUpdateTemplateCreateFlags flags;
        public uint                                  descriptorUpdateEntryCount;
        public VkDescriptorUpdateTemplateEntry*      pDescriptorUpdateEntries;
        public VkDescriptorUpdateTemplateType        templateType;
        public VkDescriptorSetLayout                 descriptorSetLayout;
        public VkPipelineBindPoint                   pipelineBindPoint;
        public VkPipelineLayout                      pipelineLayout;
        public uint                                  set;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlags    externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalImageFormatProperties
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkBufferCreateFlags             flags;
        public VkBufferUsageFlags              usage;
        public VkExternalMemoryHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalBufferProperties
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceIDProperties
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public fixed byte            deviceUUID[VK_UUID_SIZE];
        public fixed byte            driverUUID[VK_UUID_SIZE];
        public fixed byte            deviceLUID[VK_LUID_SIZE];
        public       uint            deviceNodeMask;
        public       VkBool32        deviceLUIDValid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalMemoryImageCreateInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExportMemoryAllocateInfo
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkExternalFenceHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalFenceProperties
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
        public VkExternalFenceFeatureFlags    externalFenceFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExportFenceCreateInfo
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkExternalFenceHandleTypeFlags handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkExternalSemaphoreHandleTypeFlags handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkExternalSemaphoreHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalSemaphoreProperties
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
        public VkExternalSemaphoreFeatureFlags    externalSemaphoreFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxPerSetDescriptors;
        public VkDeviceSize    maxMemoryAllocationSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        supported;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderDrawParameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        storageBuffer16BitAccess;
        public VkBool32        uniformAndStorageBuffer16BitAccess;
        public VkBool32        storagePushConstant16;
        public VkBool32        storageInputOutput16;
        public VkBool32        multiview;
        public VkBool32        multiviewGeometryShader;
        public VkBool32        multiviewTessellationShader;
        public VkBool32        variablePointersStorageBuffer;
        public VkBool32        variablePointers;
        public VkBool32        protectedMemory;
        public VkBool32        samplerYcbcrConversion;
        public VkBool32        shaderDrawParameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public       VkStructureType         sType;
        public       void*                   pNext;
        public fixed byte                    deviceUUID[VK_UUID_SIZE];
        public fixed byte                    driverUUID[VK_UUID_SIZE];
        public fixed byte                    deviceLUID[VK_LUID_SIZE];
        public       uint                    deviceNodeMask;
        public       VkBool32                deviceLUIDValid;
        public       uint                    subgroupSize;
        public       VkShaderStageFlags      subgroupSupportedStages;
        public       VkSubgroupFeatureFlags  subgroupSupportedOperations;
        public       VkBool32                subgroupQuadOperationsInAllStages;
        public       VkPointClippingBehavior pointClippingBehavior;
        public       uint                    maxMultiviewViewCount;
        public       uint                    maxMultiviewInstanceIndex;
        public       VkBool32                protectedNoFault;
        public       uint                    maxPerSetDescriptors;
        public       VkDeviceSize            maxMemoryAllocationSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        samplerMirrorClampToEdge;
        public VkBool32        drawIndirectCount;
        public VkBool32        storageBuffer8BitAccess;
        public VkBool32        uniformAndStorageBuffer8BitAccess;
        public VkBool32        storagePushConstant8;
        public VkBool32        shaderBufferInt64Atomics;
        public VkBool32        shaderSharedInt64Atomics;
        public VkBool32        shaderFloat16;
        public VkBool32        shaderInt8;
        public VkBool32        descriptorIndexing;
        public VkBool32        shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32        shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32        shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32        shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32        shaderSampledImageArrayNonUniformIndexing;
        public VkBool32        shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32        shaderStorageImageArrayNonUniformIndexing;
        public VkBool32        shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32        shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32        shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32        descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32        descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32        descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32        descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32        descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32        descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32        descriptorBindingUpdateUnusedWhilePending;
        public VkBool32        descriptorBindingPartiallyBound;
        public VkBool32        descriptorBindingVariableDescriptorCount;
        public VkBool32        runtimeDescriptorArray;
        public VkBool32        samplerFilterMinmax;
        public VkBool32        scalarBlockLayout;
        public VkBool32        imagelessFramebuffer;
        public VkBool32        uniformBufferStandardLayout;
        public VkBool32        shaderSubgroupExtendedTypes;
        public VkBool32        separateDepthStencilLayouts;
        public VkBool32        hostQueryReset;
        public VkBool32        timelineSemaphore;
        public VkBool32        bufferDeviceAddress;
        public VkBool32        bufferDeviceAddressCaptureReplay;
        public VkBool32        bufferDeviceAddressMultiDevice;
        public VkBool32        vulkanMemoryModel;
        public VkBool32        vulkanMemoryModelDeviceScope;
        public VkBool32        vulkanMemoryModelAvailabilityVisibilityChains;
        public VkBool32        shaderOutputViewportIndex;
        public VkBool32        shaderOutputLayer;
        public VkBool32        subgroupBroadcastDynamicId;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkConformanceVersion
    {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public       VkStructureType                   sType;
        public       void*                             pNext;
        public       VkDriverId                        driverID;
        public fixed sbyte                             driverName[VK_MAX_DRIVER_NAME_SIZE];
        public fixed sbyte                             driverInfo[VK_MAX_DRIVER_INFO_SIZE];
        public       VkConformanceVersion              conformanceVersion;
        public       VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public       VkShaderFloatControlsIndependence roundingModeIndependence;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat16;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat32;
        public       VkBool32                          shaderSignedZeroInfNanPreserveFloat64;
        public       VkBool32                          shaderDenormPreserveFloat16;
        public       VkBool32                          shaderDenormPreserveFloat32;
        public       VkBool32                          shaderDenormPreserveFloat64;
        public       VkBool32                          shaderDenormFlushToZeroFloat16;
        public       VkBool32                          shaderDenormFlushToZeroFloat32;
        public       VkBool32                          shaderDenormFlushToZeroFloat64;
        public       VkBool32                          shaderRoundingModeRTEFloat16;
        public       VkBool32                          shaderRoundingModeRTEFloat32;
        public       VkBool32                          shaderRoundingModeRTEFloat64;
        public       VkBool32                          shaderRoundingModeRTZFloat16;
        public       VkBool32                          shaderRoundingModeRTZFloat32;
        public       VkBool32                          shaderRoundingModeRTZFloat64;
        public       uint                              maxUpdateAfterBindDescriptorsInAllPools;
        public       VkBool32                          shaderUniformBufferArrayNonUniformIndexingNative;
        public       VkBool32                          shaderSampledImageArrayNonUniformIndexingNative;
        public       VkBool32                          shaderStorageBufferArrayNonUniformIndexingNative;
        public       VkBool32                          shaderStorageImageArrayNonUniformIndexingNative;
        public       VkBool32                          shaderInputAttachmentArrayNonUniformIndexingNative;
        public       VkBool32                          robustBufferAccessUpdateAfterBind;
        public       VkBool32                          quadDivergentImplicitLod;
        public       uint                              maxPerStageDescriptorUpdateAfterBindSamplers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public       uint                              maxPerStageDescriptorUpdateAfterBindSampledImages;
        public       uint                              maxPerStageDescriptorUpdateAfterBindStorageImages;
        public       uint                              maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public       uint                              maxPerStageUpdateAfterBindResources;
        public       uint                              maxDescriptorSetUpdateAfterBindSamplers;
        public       uint                              maxDescriptorSetUpdateAfterBindUniformBuffers;
        public       uint                              maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageBuffers;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public       uint                              maxDescriptorSetUpdateAfterBindSampledImages;
        public       uint                              maxDescriptorSetUpdateAfterBindStorageImages;
        public       uint                              maxDescriptorSetUpdateAfterBindInputAttachments;
        public       VkResolveModeFlags                supportedDepthResolveModes;
        public       VkResolveModeFlags                supportedStencilResolveModes;
        public       VkBool32                          independentResolveNone;
        public       VkBool32                          independentResolve;
        public       VkBool32                          filterMinmaxSingleComponentFormats;
        public       VkBool32                          filterMinmaxImageComponentMapping;
        public       ulong                             maxTimelineSemaphoreValueDifference;
        public       VkSampleCountFlags                framebufferIntegerColorSampleCounts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageFormatListCreateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            viewFormatCount;
        public VkFormat*       pViewFormats;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAttachmentDescription2
    {
        public VkStructureType              sType;
        public void*                        pNext;
        public VkAttachmentDescriptionFlags flags;
        public VkFormat                     format;
        public VkSampleCountFlags           samples;
        public VkAttachmentLoadOp           loadOp;
        public VkAttachmentStoreOp          storeOp;
        public VkAttachmentLoadOp           stencilLoadOp;
        public VkAttachmentStoreOp          stencilStoreOp;
        public VkImageLayout                initialLayout;
        public VkImageLayout                finalLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAttachmentReference2
    {
        public VkStructureType    sType;
        public void*              pNext;
        public uint               attachment;
        public VkImageLayout      layout;
        public VkImageAspectFlags aspectMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassDescription2
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint       pipelineBindPoint;
        public uint                      viewMask;
        public uint                      inputAttachmentCount;
        public VkAttachmentReference2*   pInputAttachments;
        public uint                      colorAttachmentCount;
        public VkAttachmentReference2*   pColorAttachments;
        public VkAttachmentReference2*   pResolveAttachments;
        public VkAttachmentReference2*   pDepthStencilAttachment;
        public uint                      preserveAttachmentCount;
        public uint*                     pPreserveAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassDependency2
    {
        public VkStructureType      sType;
        public void*                pNext;
        public uint                 srcSubpass;
        public uint                 dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags        srcAccessMask;
        public VkAccessFlags        dstAccessMask;
        public VkDependencyFlags    dependencyFlags;
        public int                  viewOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassCreateInfo2
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkRenderPassCreateFlags   flags;
        public uint                      attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint                      subpassCount;
        public VkSubpassDescription2*    pSubpasses;
        public uint                      dependencyCount;
        public VkSubpassDependency2*     pDependencies;
        public uint                      correlatedViewMaskCount;
        public uint*                     pCorrelatedViewMasks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassBeginInfo
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkSubpassContents contents;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassEndInfo
    {
        public VkStructureType sType;
        public void*           pNext;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        storageBuffer8BitAccess;
        public VkBool32        uniformAndStorageBuffer8BitAccess;
        public VkBool32        storagePushConstant8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public       VkStructureType      sType;
        public       void*                pNext;
        public       VkDriverId           driverID;
        public fixed sbyte                driverName[VK_MAX_DRIVER_NAME_SIZE];
        public fixed sbyte                driverInfo[VK_MAX_DRIVER_INFO_SIZE];
        public       VkConformanceVersion conformanceVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderBufferInt64Atomics;
        public VkBool32        shaderSharedInt64Atomics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderFloat16;
        public VkBool32        shaderInt8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32                          shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32                          shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32                          shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32                          shaderDenormPreserveFloat16;
        public VkBool32                          shaderDenormPreserveFloat32;
        public VkBool32                          shaderDenormPreserveFloat64;
        public VkBool32                          shaderDenormFlushToZeroFloat16;
        public VkBool32                          shaderDenormFlushToZeroFloat32;
        public VkBool32                          shaderDenormFlushToZeroFloat64;
        public VkBool32                          shaderRoundingModeRTEFloat16;
        public VkBool32                          shaderRoundingModeRTEFloat32;
        public VkBool32                          shaderRoundingModeRTEFloat64;
        public VkBool32                          shaderRoundingModeRTZFloat16;
        public VkBool32                          shaderRoundingModeRTZFloat32;
        public VkBool32                          shaderRoundingModeRTZFloat64;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public uint                      bindingCount;
        public VkDescriptorBindingFlags* pBindingFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32        shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32        shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32        shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32        shaderSampledImageArrayNonUniformIndexing;
        public VkBool32        shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32        shaderStorageImageArrayNonUniformIndexing;
        public VkBool32        shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32        shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32        shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32        descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32        descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32        descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32        descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32        descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32        descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32        descriptorBindingUpdateUnusedWhilePending;
        public VkBool32        descriptorBindingPartiallyBound;
        public VkBool32        descriptorBindingVariableDescriptorCount;
        public VkBool32        runtimeDescriptorArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32        shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32        shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32        shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32        shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32        shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32        robustBufferAccessUpdateAfterBind;
        public VkBool32        quadDivergentImplicitLod;
        public uint            maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint            maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint            maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint            maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint            maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint            maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint            maxPerStageUpdateAfterBindResources;
        public uint            maxDescriptorSetUpdateAfterBindSamplers;
        public uint            maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint            maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint            maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint            maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint            maxDescriptorSetUpdateAfterBindSampledImages;
        public uint            maxDescriptorSetUpdateAfterBindStorageImages;
        public uint            maxDescriptorSetUpdateAfterBindInputAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            descriptorSetCount;
        public uint*           pDescriptorCounts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxVariableDescriptorCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkResolveModeFlags      depthResolveMode;
        public VkResolveModeFlags      stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32           independentResolveNone;
        public VkBool32           independentResolve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        scalarBlockLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkImageUsageFlags stencilUsage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkSamplerReductionMode reductionMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        filterMinmaxSingleComponentFormats;
        public VkBool32        filterMinmaxImageComponentMapping;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        vulkanMemoryModel;
        public VkBool32        vulkanMemoryModelDeviceScope;
        public VkBool32        vulkanMemoryModelAvailabilityVisibilityChains;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        imagelessFramebuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkImageCreateFlags flags;
        public VkImageUsageFlags  usage;
        public uint               width;
        public uint               height;
        public uint               layerCount;
        public uint               viewFormatCount;
        public VkFormat*          pViewFormats;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public uint                              attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            attachmentCount;
        public VkImageView*    pAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        uniformBufferStandardLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderSubgroupExtendedTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        separateDepthStencilLayouts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImageLayout   stencilLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImageLayout   stencilInitialLayout;
        public VkImageLayout   stencilFinalLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        hostQueryReset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        timelineSemaphore;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           maxTimelineSemaphoreValueDifference;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSemaphoreType semaphoreType;
        public ulong           initialValue;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            waitSemaphoreValueCount;
        public ulong*          pWaitSemaphoreValues;
        public uint            signalSemaphoreValueCount;
        public ulong*          pSignalSemaphoreValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSemaphoreWaitInfo
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkSemaphoreWaitFlags flags;
        public uint                 semaphoreCount;
        public VkSemaphore*         pSemaphores;
        public ulong*               pValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSemaphore     semaphore;
        public ulong           value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        bufferDeviceAddress;
        public VkBool32        bufferDeviceAddressCaptureReplay;
        public VkBool32        bufferDeviceAddressMultiDevice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBuffer        buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           opaqueCaptureAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           opaqueCaptureAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceMemory  memory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceCapabilitiesKHR
    {
        public uint                       minImageCount;
        public uint                       maxImageCount;
        public VkExtent2D                 currentExtent;
        public VkExtent2D                 minImageExtent;
        public VkExtent2D                 maxImageExtent;
        public uint                       maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR   supportedCompositeAlpha;
        public VkImageUsageFlags          supportedUsageFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSurfaceFormatKHR
    {
        public VkFormat        format;
        public VkColorSpaceKHR colorSpace;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkSwapchainCreateFlagsKHR  flags;
        public VkSurfaceKHR               surface;
        public uint                       minImageCount;
        public VkFormat                   imageFormat;
        public VkColorSpaceKHR            imageColorSpace;
        public VkExtent2D                 imageExtent;
        public uint                       imageArrayLayers;
        public VkImageUsageFlags          imageUsage;
        public VkSharingMode              imageSharingMode;
        public uint                       queueFamilyIndexCount;
        public uint*                      pQueueFamilyIndices;
        public VkSurfaceTransformFlagsKHR preTransform;
        public VkCompositeAlphaFlagsKHR   compositeAlpha;
        public VkPresentModeKHR           presentMode;
        public VkBool32                   clipped;
        public VkSwapchainKHR             oldSwapchain;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPresentInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            waitSemaphoreCount;
        public VkSemaphore*    pWaitSemaphores;
        public uint            swapchainCount;
        public VkSwapchainKHR* pSwapchains;
        public uint*           pImageIndices;
        public VkResult*       pResults;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSwapchainKHR  swapchain;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSwapchainKHR  swapchain;
        public uint            imageIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSwapchainKHR  swapchain;
        public ulong           timeout;
        public VkSemaphore     semaphore;
        public VkFence         fence;
        public uint            deviceMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public       VkStructureType                  sType;
        public       void*                            pNext;
        public fixed uint                             presentMask[VK_MAX_DEVICE_GROUP_SIZE];
        public       VkDeviceGroupPresentModeFlagsKHR modes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public uint                             swapchainCount;
        public uint*                            pDeviceMasks;
        public VkDeviceGroupPresentModeFlagsKHR mode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceGroupSwapchainCreateInfoKHR
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkDeviceGroupPresentModeFlagsKHR modes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeParametersKHR
    {
        public VkExtent2D visibleRegion;
        public uint       refreshRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public VkDisplayModeCreateFlagsKHR flags;
        public VkDisplayModeParametersKHR  parameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModePropertiesKHR
    {
        public VkDisplayModeKHR           displayMode;
        public VkDisplayModeParametersKHR parameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneCapabilitiesKHR
    {
        public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
        public VkOffset2D                  minSrcPosition;
        public VkOffset2D                  maxSrcPosition;
        public VkExtent2D                  minSrcExtent;
        public VkExtent2D                  maxSrcExtent;
        public VkOffset2D                  minDstPosition;
        public VkOffset2D                  maxDstPosition;
        public VkExtent2D                  minDstExtent;
        public VkExtent2D                  maxDstExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlanePropertiesKHR
    {
        public VkDisplayKHR currentDisplay;
        public uint         currentStackIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR               display;
        public sbyte*                     displayName;
        public VkExtent2D                 physicalDimensions;
        public VkExtent2D                 physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkBool32                   planeReorderPossible;
        public VkBool32                   persistentContent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkDisplaySurfaceCreateFlagsKHR flags;
        public VkDisplayModeKHR               displayMode;
        public uint                           planeIndex;
        public uint                           planeStackIndex;
        public VkSurfaceTransformFlagsKHR     transform;
        public float                          globalAlpha;
        public VkDisplayPlaneAlphaFlagsKHR    alphaMode;
        public VkExtent2D                     imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPresentInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkRect2D        srcRect;
        public VkRect2D        dstRect;
        public VkBool32        persistent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public int                             fd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkDeviceMemory                  memory;
        public VkExternalMemoryHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkSemaphore                        semaphore;
        public VkSemaphoreImportFlags             flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public int                                fd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkSemaphore                        semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxPushDescriptors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkRectLayerKHR
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public uint       layer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPresentRegionKHR
    {
        public uint            rectangleCount;
        public VkRectLayerKHR* pRectangles;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPresentRegionsKHR
    {
        public VkStructureType     sType;
        public void*               pNext;
        public uint                swapchainCount;
        public VkPresentRegionKHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkImageUsageFlags sharedPresentSupportedUsageFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImportFenceFdInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkFence                        fence;
        public VkFenceImportFlags             flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public int                            fd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFenceGetFdInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkFence                        fence;
        public VkExternalFenceHandleTypeFlags handleType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        performanceCounterQueryPools;
        public VkBool32        performanceCounterMultipleQueryPools;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        allowCommandBufferQueryCopies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceCounterKHR
    {
        public       VkStructureType                sType;
        public       void*                          pNext;
        public       VkPerformanceCounterUnitKHR    unit;
        public       VkPerformanceCounterScopeKHR   scope;
        public       VkPerformanceCounterStorageKHR storage;
        public fixed byte                           uuid[VK_UUID_SIZE];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceCounterDescriptionKHR
    {
        public       VkStructureType                         sType;
        public       void*                                   pNext;
        public       VkPerformanceCounterDescriptionFlagsKHR flags;
        public fixed sbyte                                   name[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                                   category[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                                   description[VK_MAX_DESCRIPTION_SIZE];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            queueFamilyIndex;
        public uint            counterIndexCount;
        public uint*           pCounterIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkAcquireProfilingLockFlagsKHR flags;
        public ulong                          timeout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            counterPassIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkSurfaceKHR    surface;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSurfaceFormat2KHR
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkSurfaceFormatKHR surfaceFormat;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayProperties2KHR
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkDisplayPropertiesKHR displayProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayModeProperties2KHR
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType  sType;
        public void*            pNext;
        public VkDisplayModeKHR mode;
        public uint             planeIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkDisplayPlaneCapabilitiesKHR capabilities;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderSubgroupClock;
        public VkBool32        shaderDeviceClock;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderTerminateInvocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D              shadingRateAttachmentTexelSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkExtent2D                         fragmentSize;
        public VkFragmentShadingRateCombinerOpKHR combinerOps1;
        public VkFragmentShadingRateCombinerOpKHR combinerOps2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        pipelineFragmentShadingRate;
        public VkBool32        primitiveFragmentShadingRate;
        public VkBool32        attachmentFragmentShadingRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkExtent2D         minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D         maxFragmentShadingRateAttachmentTexelSize;
        public uint               maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public VkBool32           primitiveFragmentShadingRateWithMultipleViewports;
        public VkBool32           layeredShadingRateAttachments;
        public VkBool32           fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D         maxFragmentSize;
        public uint               maxFragmentSizeAspectRatio;
        public uint               maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
        public VkBool32           fragmentShadingRateWithShaderDepthStencilWrites;
        public VkBool32           fragmentShadingRateWithSampleMask;
        public VkBool32           fragmentShadingRateWithShaderSampleMask;
        public VkBool32           fragmentShadingRateWithConservativeRasterization;
        public VkBool32           fragmentShadingRateWithFragmentShaderInterlock;
        public VkBool32           fragmentShadingRateWithCustomSampleLocations;
        public VkBool32           fragmentShadingRateStrictMultiplyCombiner;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkSampleCountFlags sampleCounts;
        public VkExtent2D         fragmentSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        supportsProtected;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        pipelineExecutableInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkPipeline      pipeline;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public       VkStructureType    sType;
        public       void*              pNext;
        public       VkShaderStageFlags stages;
        public fixed sbyte              name[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte              description[VK_MAX_DESCRIPTION_SIZE];
        public       uint               subgroupSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkPipeline      pipeline;
        public uint            executableIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineExecutableStatisticKHR
    {
        public       VkStructureType                        sType;
        public       void*                                  pNext;
        public fixed sbyte                                  name[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                                  description[VK_MAX_DESCRIPTION_SIZE];
        public       VkPipelineExecutableStatisticFormatKHR format;
        public       VkPipelineExecutableStatisticValueKHR  value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public fixed sbyte           name[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte           description[VK_MAX_DESCRIPTION_SIZE];
        public       VkBool32        isText;
        public       nuint           dataSize;
        public       void*           pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            libraryCount;
        public VkPipeline*     pLibraries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferCopy2KHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    srcOffset;
        public VkDeviceSize    dstOffset;
        public VkDeviceSize    size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyBufferInfo2KHR
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkBuffer          srcBuffer;
        public VkBuffer          dstBuffer;
        public uint              regionCount;
        public VkBufferCopy2KHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageCopy2KHR
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffset;
        public VkExtent3D               extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyImageInfo2KHR
    {
        public VkStructureType  sType;
        public void*            pNext;
        public VkImage          srcImage;
        public VkImageLayout    srcImageLayout;
        public VkImage          dstImage;
        public VkImageLayout    dstImageLayout;
        public uint             regionCount;
        public VkImageCopy2KHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferImageCopy2KHR
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkDeviceSize             bufferOffset;
        public uint                     bufferRowLength;
        public uint                     bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D               imageOffset;
        public VkExtent3D               imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyBufferToImageInfo2KHR
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkBuffer               srcBuffer;
        public VkImage                dstImage;
        public VkImageLayout          dstImageLayout;
        public uint                   regionCount;
        public VkBufferImageCopy2KHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyImageToBufferInfo2KHR
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkImage                srcImage;
        public VkImageLayout          srcImageLayout;
        public VkBuffer               dstBuffer;
        public uint                   regionCount;
        public VkBufferImageCopy2KHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageBlit2KHR
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffsetsLeftTop;
        public VkOffset3D               srcOffsetsRightBottom;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffsetsLeftTop;
        public VkOffset3D               dstOffsetsRightBottom;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBlitImageInfo2KHR
    {
        public VkStructureType  sType;
        public void*            pNext;
        public VkImage          srcImage;
        public VkImageLayout    srcImageLayout;
        public VkImage          dstImage;
        public VkImageLayout    dstImageLayout;
        public uint             regionCount;
        public VkImageBlit2KHR* pRegions;
        public VkFilter         filter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageResolve2KHR
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D               srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D               dstOffset;
        public VkExtent3D               extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkResolveImageInfo2KHR
    {
        public VkStructureType     sType;
        public void*               pNext;
        public VkImage             srcImage;
        public VkImageLayout       srcImageLayout;
        public VkImage             dstImage;
        public VkImageLayout       dstImageLayout;
        public uint                regionCount;
        public VkImageResolve2KHR* pRegions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkDebugReportFlagsEXT flags;

        public delegate*<               /*vkDebugReportCallbackEXT*/
            VkDebugReportFlagsEXT,      /* flags                  */
            VkDebugReportObjectTypeEXT, /* objectType             */
            ulong,                      /* @object                */
            nuint,                      /* location               */
            int,                        /* messageCode            */
            sbyte*,                     /* pLayerPrefix           */
            sbyte*,                     /* pMessage               */
            void*,                      /* pUserData              */
            VkBool32> pfnCallback;

        public void* pUserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong                      @object;
        public sbyte*                     pObjectName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong                      @object;
        public ulong                      tagName;
        public nuint                      tagSize;
        public void*                      pTag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public       sbyte*          pMarkerName;
        public fixed float           color[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        dedicatedAllocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        dedicatedAllocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImage         image;
        public VkBuffer        buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        transformFeedback;
        public VkBool32        geometryStreams;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxTransformFeedbackStreams;
        public uint            maxTransformFeedbackBuffers;
        public VkDeviceSize    maxTransformFeedbackBufferSize;
        public uint            maxTransformFeedbackStreamDataSize;
        public uint            maxTransformFeedbackBufferDataSize;
        public uint            maxTransformFeedbackBufferDataStride;
        public VkBool32        transformFeedbackQueries;
        public VkBool32        transformFeedbackStreamsLinesTriangles;
        public VkBool32        transformFeedbackRasterizationStreamSelect;
        public VkBool32        transformFeedbackDraw;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType                                  sType;
        public void*                                            pNext;
        public VkPipelineRasterizationStateStreamCreateFlagsEXT flags;
        public uint                                             rasterizationStream;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewHandleInfoNVX
    {
        public VkStructureType  sType;
        public void*            pNext;
        public VkImageView      imageView;
        public VkDescriptorType descriptorType;
        public VkSampler        sampler;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceAddress deviceAddress;
        public VkDeviceSize    size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkTextureLODGatherFormatPropertiesAMD
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        supportsTextureGatherLODBiasAMD;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderResourceUsageAMD
    {
        public uint  numUsedVgprs;
        public uint  numUsedSgprs;
        public uint  ldsSizePerLocalWorkGroup;
        public nuint ldsUsageSizeInBytes;
        public nuint scratchMemUsageInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShaderStatisticsInfoAMD
    {
        public       VkShaderStageFlags       shaderStageMask;
        public       VkShaderResourceUsageAMD resourceUsage;
        public       uint                     numPhysicalVgprs;
        public       uint                     numPhysicalSgprs;
        public       uint                     numAvailableVgprs;
        public       uint                     numAvailableSgprs;
        public fixed uint                     computeWorkGroupSize[3];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        cornerSampledImage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties           imageFormatProperties;
        public VkExternalMemoryFeatureFlagsNV    externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExternalMemoryImageCreateInfoNV
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExportMemoryAllocateInfoNV
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkValidationFlagsEXT
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public uint                  disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        textureCompressionASTC_HDR;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkFormat        decodeMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        decodeModeSharedExponent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkBuffer                       buffer;
        public VkDeviceSize                   offset;
        public VkConditionalRenderingFlagsEXT flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        conditionalRendering;
        public VkBool32        inheritedConditionalRendering;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        conditionalRenderingEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkBool32              viewportWScalingEnable;
        public uint                  viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public uint                       minImageCount;
        public uint                       maxImageCount;
        public VkExtent2D                 currentExtent;
        public VkExtent2D                 minImageExtent;
        public VkExtent2D                 maxImageExtent;
        public uint                       maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR   supportedCompositeAlpha;
        public VkImageUsageFlags          supportedUsageFlags;
        public VkSurfaceCounterFlagsEXT   supportedSurfaceCounters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayPowerInfoEXT
    {
        public VkStructureType        sType;
        public void*                  pNext;
        public VkDisplayPowerStateEXT powerState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceEventInfoEXT
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkDeviceEventTypeEXT deviceEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayEventInfoEXT
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkDisplayEventTypeEXT displayEvent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkSurfaceCounterFlagsEXT surfaceCounters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPastPresentationTimingGOOGLE
    {
        public uint  presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentTimeGOOGLE
    {
        public uint  presentID;
        public ulong desiredPresentTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType      sType;
        public void*                pNext;
        public uint                 swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        perViewPositionAllComponents;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType                             sType;
        public void*                                       pNext;
        public VkPipelineViewportSwizzleStateCreateFlagsNV flags;
        public uint                                        viewportCount;
        public VkViewportSwizzleNV*                        pViewportSwizzles;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxDiscardRectangles;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType                               sType;
        public void*                                         pNext;
        public VkPipelineDiscardRectangleStateCreateFlagsEXT flags;
        public VkDiscardRectangleModeEXT                     discardRectangleMode;
        public uint                                          discardRectangleCount;
        public VkRect2D*                                     pDiscardRectangles;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public float           primitiveOverestimationSize;
        public float           maxExtraPrimitiveOverestimationSize;
        public float           extraPrimitiveOverestimationSizeGranularity;
        public VkBool32        primitiveUnderestimation;
        public VkBool32        conservativePointAndLineRasterization;
        public VkBool32        degenerateTrianglesRasterized;
        public VkBool32        degenerateLinesRasterized;
        public VkBool32        fullyCoveredFragmentShaderInputVariable;
        public VkBool32        conservativeRasterizationPostDepthCoverage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType                                        sType;
        public void*                                                  pNext;
        public VkPipelineRasterizationConservativeStateCreateFlagsEXT flags;
        public VkConservativeRasterizationModeEXT                     conservativeRasterizationMode;
        public float                                                  extraPrimitiveOverestimationSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        depthClipEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType                                     sType;
        public void*                                               pNext;
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;
        public VkBool32                                            depthClipEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkXYColorEXT
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkHdrMetadataEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkXYColorEXT    displayPrimaryRed;
        public VkXYColorEXT    displayPrimaryGreen;
        public VkXYColorEXT    displayPrimaryBlue;
        public VkXYColorEXT    whitePoint;
        public float           maxLuminance;
        public float           minLuminance;
        public float           maxContentLightLevel;
        public float           maxFrameAverageLightLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public sbyte*          pLabelName;
        public VkColor         color;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkObjectType    objectType;
        public ulong           objectHandle;
        public sbyte*          pObjectName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public uint                           flags; //reserved for future use
        public sbyte*                         pMessageIdName;
        public int                            messageIdNumber;
        public sbyte*                         pMessage;
        public uint                           queueLabelCount;
        public VkDebugUtilsLabelEXT*          pQueueLabels;
        public uint                           cmdBufLabelCount;
        public VkDebugUtilsLabelEXT*          pCmdBufLabels;
        public uint                           objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType                     sType;
        public void*                               pNext;
        public uint                                flags; //reserved for future use
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagsEXT     messageType;

        public delegate*<                          /*vkDebugUtilsMessengerCallbackEXT*/
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity                */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes                   */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData                  */
            void*,                                 /* pUserData                      */
            VkBool32> pfnUserCallback;

        public void* pUserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkObjectType    objectType;
        public ulong           objectHandle;
        public ulong           tagName;
        public nuint           tagSize;
        public void*           pTag;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        inlineUniformBlock;
        public VkBool32        descriptorBindingInlineUniformBlockUpdateAfterBind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxInlineUniformBlockSize;
        public uint            maxPerStageDescriptorInlineUniformBlocks;
        public uint            maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint            maxDescriptorSetInlineUniformBlocks;
        public uint            maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            dataSize;
        public void*           pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxInlineUniformBlockBindings;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSampleLocationEXT
    {
        public float x;
        public float y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSampleLocationsInfoEXT
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkSampleCountFlags   sampleLocationsPerPixel;
        public VkExtent2D           sampleLocationGridSize;
        public uint                 sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentSampleLocationsEXT
    {
        public uint                     attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassSampleLocationsEXT
    {
        public uint                     subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public uint                            attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint                            postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT*    pPostSubpassSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkBool32                 sampleLocationsEnable;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public       VkStructureType    sType;
        public       void*              pNext;
        public       VkSampleCountFlags sampleLocationSampleCounts;
        public       VkExtent2D         maxSampleLocationGridSize;
        public fixed float              sampleLocationCoordinateRange[2];
        public       uint               sampleLocationSubPixelBits;
        public       VkBool32           variableSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkExtent2D      maxSampleLocationGridSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        advancedBlendCoherentOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            advancedBlendMaxColorAttachments;
        public VkBool32        advancedBlendIndependentBlend;
        public VkBool32        advancedBlendNonPremultipliedSrcColor;
        public VkBool32        advancedBlendNonPremultipliedDstColor;
        public VkBool32        advancedBlendCorrelatedOverlap;
        public VkBool32        advancedBlendAllOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkBool32          srcPremultiplied;
        public VkBool32          dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType                             sType;
        public void*                                       pNext;
        public VkPipelineCoverageToColorStateCreateFlagsNV flags;
        public VkBool32                                    coverageToColorEnable;
        public uint                                        coverageToColorLocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType                                sType;
        public void*                                          pNext;
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        public VkCoverageModulationModeNV                     coverageModulationMode;
        public VkBool32                                       coverageModulationTableEnable;
        public uint                                           coverageModulationTableCount;
        public float*                                         pCoverageModulationTable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            shaderSMCount;
        public uint            shaderWarpsPerSM;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderSMBuiltins;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong                drmFormatModifier;
        public uint                 drmFormatModifierPlaneCount;
        public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public uint                              drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           drmFormatModifier;
        public VkSharingMode   sharingMode;
        public uint            queueFamilyIndexCount;
        public uint*           pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            drmFormatModifierCount;
        public ulong*          pDrmFormatModifiers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType      sType;
        public void*                pNext;
        public ulong                drmFormatModifier;
        public uint                 drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImageDrmFormatModifierPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           drmFormatModifier;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkValidationCacheCreateFlagsEXT flags;
        public nuint                           initialDataSize;
        public void*                           pInitialData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkValidationCacheEXT validationCache;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkShadingRatePaletteNV
    {
        public uint                         shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkBool32                shadingRateImageEnable;
        public uint                    viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shadingRateImage;
        public VkBool32        shadingRateCoarseSampleOrder;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkExtent2D      shadingRateTexelSize;
        public uint            shadingRatePaletteSize;
        public uint            shadingRateMaxCoarseSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint                        sampleCount;
        public uint                        sampleLocationCount;
        public VkCoarseSampleLocationNV*   pSampleLocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType              sType;
        public void*                        pNext;
        public VkCoarseSampleOrderTypeNV    sampleOrderType;
        public uint                         customSampleOrderCount;
        public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint                           generalShader;
        public uint                           closestHitShader;
        public uint                           anyHitShader;
        public uint                           intersectionShader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType                      sType;
        public void*                                pNext;
        public VkPipelineCreateFlags                flags;
        public uint                                 stageCount;
        public VkPipelineShaderStageCreateInfo*     pStages;
        public uint                                 groupCount;
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public uint                                 maxRecursionDepth;
        public VkPipelineLayout                     layout;
        public VkPipeline                           basePipelineHandle;
        public int                                  basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBuffer        vertexData;
        public VkDeviceSize    vertexOffset;
        public uint            vertexCount;
        public VkDeviceSize    vertexStride;
        public VkFormat        vertexFormat;
        public VkBuffer        indexData;
        public VkDeviceSize    indexOffset;
        public uint            indexCount;
        public VkIndexType     indexType;
        public VkBuffer        transformData;
        public VkDeviceSize    transformOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryAABBNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBuffer        aabbData;
        public uint            numAABBs;
        public uint            stride;
        public VkDeviceSize    offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV      aabbs;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeometryNV
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkGeometryTypeKHR  geometryType;
        public VkGeometryDataNV   geometry;
        public VkGeometryFlagsKHR flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureInfoNV
    {
        public VkStructureType                     sType;
        public void*                               pNext;
        public VkAccelerationStructureTypeNV       type;
        public VkBuildAccelerationStructureFlagsNV flags;
        public uint                                instanceCount;
        public uint                                geometryCount;
        public VkGeometryNV*                       pGeometries;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkDeviceSize                  compactedSize;
        public VkAccelerationStructureInfoNV info;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory            memory;
        public VkDeviceSize              memoryOffset;
        public uint                      deviceIndexCount;
        public uint*                     pDeviceIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public uint                       accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType                                 sType;
        public void*                                           pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV                       accelerationStructure;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            shaderGroupHandleSize;
        public uint            maxRecursionDepth;
        public uint            maxShaderGroupStride;
        public uint            shaderGroupBaseAlignment;
        public ulong           maxGeometryCount;
        public ulong           maxInstanceCount;
        public ulong           maxTriangleCount;
        public uint            maxDescriptorSetAccelerationStructures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkTransformMatrixKHR
    {
        public float M11;
        public float M12;
        public float M13;
        public float M14;
        public float M21;
        public float M22;
        public float M23;
        public float M24;
        public float M31;
        public float M32;
        public float M33;
        public float M34;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureInstanceKHR
    {
        public  VkTransformMatrixKHR transform;
        private uint                 value1;
        private uint                 value2;
        public  ulong                accelerationStructureReference;

        public uint InstanceCustomIndex
        {
            get { return value1 & 0x00FFFFFF; }
            set { value1 = (value1 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public uint Mask
        {
            get { return value1 >> 24; }
            set { value1 = (value << 24) | (value1 & 0x00FFFFFF); }
        }

        public uint InstanceShaderBindingTableRecordOffset
        {
            get { return value2 & 0x00FFFFFF; }
            set { value2 = (value2 & 0xFF000000) | (value & 0x00FFFFFF); }
        }

        public VkGeometryInstanceFlagsKHR Flags
        {
            get { return (VkGeometryInstanceFlagsKHR)(value2 >> 24); }
            set { value2 = ((uint)value << 24) | (value2 & 0x00FFFFFF); }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        representativeFragmentTest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        representativeFragmentTestEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkImageViewType imageViewType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        filterCubic;
        public VkBool32        filterCubicMinmax;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
        public VkStructureType          sType;
        public void*                    pNext;
        public VkQueueGlobalPriorityEXT globalPriority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public void*                           pHostPointer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryHostPointerPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    minImportedHostPointerAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCalibratedTimestampInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkTimeDomainEXT timeDomain;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            shaderEngineCount;
        public uint            shaderArraysPerEngineCount;
        public uint            computeUnitsPerShaderArray;
        public uint            simdPerComputeUnit;
        public uint            wavefrontsPerSimd;
        public uint            wavefrontSize;
        public uint            sgprsPerSimd;
        public uint            minSgprAllocation;
        public uint            maxSgprAllocation;
        public uint            sgprAllocationGranularity;
        public uint            vgprsPerSimd;
        public uint            minVgprAllocation;
        public uint            maxVgprAllocation;
        public uint            vgprAllocationGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxVertexAttribDivisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDivisorDescriptionEXT
    {
        public uint binding;
        public uint divisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public VkStructureType                            sType;
        public void*                                      pNext;
        public uint                                       vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescriptionEXT* pVertexBindingDivisors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        vertexAttributeInstanceRateDivisor;
        public VkBool32        vertexAttributeInstanceRateZeroDivisor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCreationFeedbackEXT
    {
        public VkPipelineCreationFeedbackFlagsEXT flags;
        public ulong                              duration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCreationFeedbackCreateInfoEXT
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkPipelineCreationFeedbackEXT* pPipelineCreationFeedback;
        public uint                           pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedbackEXT* pPipelineStageCreationFeedbacks;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        computeDerivativeGroupQuads;
        public VkBool32        computeDerivativeGroupLinear;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        taskShader;
        public VkBool32        meshShader;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            maxDrawMeshTasksCount;
        public       uint            maxTaskWorkGroupInvocations;
        public fixed uint            maxTaskWorkGroupSize[3];
        public       uint            maxTaskTotalMemorySize;
        public       uint            maxTaskOutputCount;
        public       uint            maxMeshWorkGroupInvocations;
        public fixed uint            maxMeshWorkGroupSize[3];
        public       uint            maxMeshTotalMemorySize;
        public       uint            maxMeshOutputVertices;
        public       uint            maxMeshOutputPrimitives;
        public       uint            maxMeshMultiviewViewCount;
        public       uint            meshOutputPerVertexGranularity;
        public       uint            meshOutputPerPrimitiveGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        fragmentShaderBarycentric;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        imageFootprint;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            exclusiveScissorCount;
        public VkRect2D*       pExclusiveScissors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        exclusiveScissor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkPipelineStageFlags checkpointExecutionStageMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCheckpointDataNV
    {
        public VkStructureType      sType;
        public void*                pNext;
        public VkPipelineStageFlags stage;
        public void*                pCheckpointMarker;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderIntegerFunctions2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType;
        public void*           pNext;
        public void*           pUserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType              sType;
        public void*                        pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           marker;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            marker;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkPerformanceOverrideTypeINTEL type;
        public VkBool32                       enable;
        public ulong                          parameter;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType                     sType;
        public void*                               pNext;
        public VkPerformanceConfigurationTypeINTEL type;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            pciDomain;
        public uint            pciBus;
        public uint            pciDevice;
        public uint            pciFunction;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        localDimmingSupport;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        localDimmingEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        fragmentDensityMap;
        public VkBool32        fragmentDensityMapDynamic;
        public VkBool32        fragmentDensityMapNonSubsampledImages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkExtent2D      minFragmentDensityTexelSize;
        public VkExtent2D      maxFragmentDensityTexelSize;
        public VkBool32        fragmentDensityInvocations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType       sType;
        public void*                 pNext;
        public VkAttachmentReference fragmentDensityMapAttachment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        subgroupSizeControl;
        public VkBool32        computeFullSubgroups;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public VkStructureType    sType;
        public void*              pNext;
        public uint               minSubgroupSize;
        public uint               maxSubgroupSize;
        public uint               maxComputeWorkgroupSubgroups;
        public VkShaderStageFlags requiredSubgroupSizeStages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            requiredSubgroupSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
        public uint                           activeComputeUnitCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        deviceCoherentMemory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderImageInt64Atomics;
        public VkBool32        sparseImageInt64Atomics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType         sType;
        public void*                   pNext;
        public VkArray16<VkDeviceSize> heapBudget;
        public VkArray16<VkDeviceSize> heapUsage;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        memoryPriority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryPriorityAllocateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public float           priority;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        dedicatedAllocationImageAliasing;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        bufferDeviceAddress;
        public VkBool32        bufferDeviceAddressCaptureReplay;
        public VkBool32        bufferDeviceAddressMultiDevice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferDeviceAddressCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceAddress deviceAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
        public       VkStructureType       sType;
        public       void*                 pNext;
        public fixed sbyte                 name[VK_MAX_EXTENSION_NAME_SIZE];
        public fixed sbyte                 version[VK_MAX_EXTENSION_NAME_SIZE];
        public       VkToolPurposeFlagsEXT purposes;
        public fixed sbyte                 description[VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                 layer[VK_MAX_EXTENSION_NAME_SIZE];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkValidationFeaturesEXT
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public uint                           enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT*  pEnabledValidationFeatures;
        public uint                           disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType   sType;
        public void*             pNext;
        public uint              MSize;
        public uint              NSize;
        public uint              KSize;
        public VkComponentTypeNV AType;
        public VkComponentTypeNV BType;
        public VkComponentTypeNV CType;
        public VkComponentTypeNV DType;
        public VkScopeNV         scope;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        cooperativeMatrix;
        public VkBool32        cooperativeMatrixRobustBufferAccess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkShaderStageFlags cooperativeMatrixSupportedStages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        coverageReductionMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType                               sType;
        public void*                                         pNext;
        public VkPipelineCoverageReductionStateCreateFlagsNV flags;
        public VkCoverageReductionModeNV                     coverageReductionMode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType           sType;
        public void*                     pNext;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkSampleCountFlags        rasterizationSamples;
        public VkSampleCountFlags        depthStencilSamples;
        public VkSampleCountFlags        colorSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        fragmentShaderSampleInterlock;
        public VkBool32        fragmentShaderPixelInterlock;
        public VkBool32        fragmentShaderShadingRateInterlock;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        ycbcrImageArrays;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkHeadlessSurfaceCreateFlagsEXT flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        rectangularLines;
        public VkBool32        bresenhamLines;
        public VkBool32        smoothLines;
        public VkBool32        stippledRectangularLines;
        public VkBool32        stippledBresenhamLines;
        public VkBool32        stippledSmoothLines;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            lineSubPixelPrecisionBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkLineRasterizationModeEXT lineRasterizationMode;
        public VkBool32                   stippledLineEnable;
        public uint                       lineStippleFactor;
        public ushort                     lineStipplePattern;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderBufferFloat32Atomics;
        public VkBool32        shaderBufferFloat32AtomicAdd;
        public VkBool32        shaderBufferFloat64Atomics;
        public VkBool32        shaderBufferFloat64AtomicAdd;
        public VkBool32        shaderSharedFloat32Atomics;
        public VkBool32        shaderSharedFloat32AtomicAdd;
        public VkBool32        shaderSharedFloat64Atomics;
        public VkBool32        shaderSharedFloat64AtomicAdd;
        public VkBool32        shaderImageFloat32Atomics;
        public VkBool32        shaderImageFloat32AtomicAdd;
        public VkBool32        sparseImageFloat32Atomics;
        public VkBool32        sparseImageFloat32AtomicAdd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        indexTypeUint8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        extendedDynamicState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        shaderDemoteToHelperInvocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxGraphicsShaderGroupCount;
        public uint            maxIndirectSequenceCount;
        public uint            maxIndirectCommandsTokenCount;
        public uint            maxIndirectCommandsStreamCount;
        public uint            maxIndirectCommandsTokenOffset;
        public uint            maxIndirectCommandsStreamStride;
        public uint            minSequencesCountBufferOffsetAlignment;
        public uint            minSequencesIndexBufferOffsetAlignment;
        public uint            minIndirectCommandsBufferOffsetAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        deviceGeneratedCommands;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType                        sType;
        public void*                                  pNext;
        public uint                                   stageCount;
        public VkPipelineShaderStageCreateInfo*       pStages;
        public VkPipelineVertexInputStateCreateInfo*  pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public uint                               groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint                               pipelineCount;
        public VkPipeline*                        pPipelines;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindIndexBufferIndirectCommandNV
    {
        public VkDeviceAddress bufferAddress;
        public uint            size;
        public VkIndexType     indexType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindVertexBufferIndirectCommandNV
    {
        public VkDeviceAddress bufferAddress;
        public uint            size;
        public uint            stride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkIndirectCommandsStreamNV
    {
        public VkBuffer     buffer;
        public VkDeviceSize offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint                          stream;
        public uint                          offset;
        public uint                          vertexBindingUnit;
        public VkBool32                      vertexDynamicStride;
        public VkPipelineLayout              pushconstantPipelineLayout;
        public VkShaderStageFlags            pushconstantShaderStageFlags;
        public uint                          pushconstantOffset;
        public uint                          pushconstantSize;
        public VkIndirectStateFlagsNV        indirectStateFlags;
        public uint                          indexTypeCount;
        public VkIndexType*                  pIndexTypes;
        public uint*                         pIndexTypeValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType                      sType;
        public void*                                pNext;
        public VkIndirectCommandsLayoutUsageFlagsNV flags;
        public VkPipelineBindPoint                  pipelineBindPoint;
        public uint                                 tokenCount;
        public VkIndirectCommandsLayoutTokenNV*     pTokens;
        public uint                                 streamCount;
        public uint*                                pStreamStrides;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public VkPipelineBindPoint         pipelineBindPoint;
        public VkPipeline                  pipeline;
        public VkIndirectCommandsLayoutNV  indirectCommandsLayout;
        public uint                        streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint                        sequencesCount;
        public VkBuffer                    preprocessBuffer;
        public VkDeviceSize                preprocessOffset;
        public VkDeviceSize                preprocessSize;
        public VkBuffer                    sequencesCountBuffer;
        public VkDeviceSize                sequencesCountOffset;
        public VkBuffer                    sequencesIndexBuffer;
        public VkDeviceSize                sequencesIndexOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkPipelineBindPoint        pipelineBindPoint;
        public VkPipeline                 pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint                       maxSequencesCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        texelBufferAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    storageTexelBufferOffsetAlignmentBytes;
        public VkBool32        storageTexelBufferOffsetSingleTexelAlignment;
        public VkDeviceSize    uniformTexelBufferOffsetAlignmentBytes;
        public VkBool32        uniformTexelBufferOffsetSingleTexelAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkSurfaceTransformFlagsKHR transform;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public VkRect2D                   renderArea;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        deviceMemoryReport;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkDeviceMemoryReportFlagsEXT     flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong                            memoryObjectId;
        public VkDeviceSize                     size;
        public VkObjectType                     objectType;
        public ulong                            objectHandle;
        public uint                             heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkDeviceMemoryReportFlagsEXT  flags;
        public DeviceMemoryReportCallbackEXT pfnUserCallback;
        public void*                         pUserData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        robustBufferAccess2;
        public VkBool32        robustImageAccess2;
        public VkBool32        nullDescriptor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    robustStorageBufferAccessSizeAlignment;
        public VkDeviceSize    robustUniformBufferAccessSizeAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
    {
        public VkStructureType   sType;
        public void*             pNext;
        public VkClearColorValue customBorderColor;
        public VkFormat          format;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxCustomBorderColorSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        customBorderColors;
        public VkBool32        customBorderColorWithoutFormat;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        privateData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDevicePrivateDataCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            privateDataSlotRequestCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPrivateDataSlotCreateInfoEXT
    {
        public VkStructureType                 sType;
        public void*                           pNext;
        public VkPrivateDataSlotCreateFlagsEXT flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        pipelineCreationCacheControl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        diagnosticsConfig;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType                  sType;
        public void*                            pNext;
        public VkDeviceDiagnosticsConfigFlagsNV flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        fragmentShadingRateEnums;
        public VkBool32        supersampleFragmentShadingRates;
        public VkBool32        noInvocationFragmentShadingRates;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType    sType;
        public void*              pNext;
        public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkFragmentShadingRateTypeNV        shadingRateType;
        public VkFragmentShadingRateNV            shadingRate;
        public VkFragmentShadingRateCombinerOpKHR combinerOps1;
        public VkFragmentShadingRateCombinerOpKHR combinerOps2;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        fragmentDensityMapDeferred;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        subsampledLoads;
        public VkBool32        subsampledCoarseReconstructionEarlyAccess;

        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkSurfaceTransformFlagsKHR transform;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        robustImageAccess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        formatA4R4G4B4;
        public VkBool32        formatA4B4G4R4;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        mutableDescriptorType;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMutableDescriptorTypeListVALVE
    {
        public uint              descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMutableDescriptorTypeCreateInfoVALVE
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public uint                              mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListVALVE* pMutableDescriptorTypeLists;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureBuildRangeInfoKHR
    {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkFormat                      vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public VkDeviceSize                  vertexStride;
        public uint                          maxVertex;
        public VkIndexType                   indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType               sType;
        public void*                         pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public VkDeviceSize                  stride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        arrayOfPointers;

        public VkDeviceOrHostAddressConstKHR data;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType                        sType;
        public void*                                  pNext;
        public VkGeometryTypeKHR                      geometryType;
        public VkAccelerationStructureGeometryDataKHR geometry;
        public VkGeometryFlagsKHR                     flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType                      sType;
        public void*                                pNext;
        public VkAccelerationStructureTypeKHR       type;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public VkBuildAccelerationStructureModeKHR  mode;
        public VkAccelerationStructureKHR           srcAccelerationStructure;
        public VkAccelerationStructureKHR           dstAccelerationStructure;
        public uint                                 geometryCount;
        public VkAccelerationStructureGeometryKHR*  pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR             scratchData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType                       sType;
        public void*                                 pNext;
        public VkAccelerationStructureCreateFlagsKHR createFlags;
        public VkBuffer                              buffer;
        public VkDeviceSize                          offset;
        public VkDeviceSize                          size;
        public VkAccelerationStructureTypeKHR        type;
        public VkDeviceAddress                       deviceAddress;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType             sType;
        public void*                       pNext;
        public uint                        accelerationStructureCount;
        public VkAccelerationStructureKHR* pAccelerationStructures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        accelerationStructure;
        public VkBool32        accelerationStructureCaptureReplay;
        public VkBool32        accelerationStructureIndirectBuild;
        public VkBool32        accelerationStructureHostCommands;
        public VkBool32        descriptorBindingAccelerationStructureUpdateAfterBind;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public ulong           maxGeometryCount;
        public ulong           maxInstanceCount;
        public ulong           maxPrimitiveCount;
        public uint            maxPerStageDescriptorAccelerationStructures;
        public uint            maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        public uint            maxDescriptorSetAccelerationStructures;
        public uint            maxDescriptorSetUpdateAfterBindAccelerationStructures;
        public uint            minAccelerationStructureScratchOffsetAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType            sType;
        public void*                      pNext;
        public VkAccelerationStructureKHR accelerationStructure;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public byte*           pVersionData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkAccelerationStructureKHR         src;
        public VkDeviceOrHostAddressKHR           dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkDeviceOrHostAddressConstKHR      src;
        public VkAccelerationStructureKHR         dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType                    sType;
        public void*                              pNext;
        public VkAccelerationStructureKHR         src;
        public VkAccelerationStructureKHR         dst;
        public VkCopyAccelerationStructureModeKHR mode;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    accelerationStructureSize;
        public VkDeviceSize    updateScratchSize;
        public VkDeviceSize    buildScratchSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType                sType;
        public void*                          pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint                           generalShader;
        public uint                           closestHitShader;
        public uint                           anyHitShader;
        public uint                           intersectionShader;
        public void*                          pShaderGroupCaptureReplayHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxPipelineRayPayloadSize;
        public uint            maxPipelineRayHitAttributeSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType                             sType;
        public void*                                       pNext;
        public VkPipelineCreateFlags                       flags;
        public uint                                        stageCount;
        public VkPipelineShaderStageCreateInfo*            pStages;
        public uint                                        groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR*       pGroups;
        public uint                                        maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR*             pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo*           pDynamicState;
        public VkPipelineLayout                            layout;
        public VkPipeline                                  basePipelineHandle;
        public int                                         basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        rayTracingPipeline;
        public VkBool32        rayTracingPipelineShaderGroupHandleCaptureReplay;
        public VkBool32        rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public VkBool32        rayTracingPipelineTraceRaysIndirect;
        public VkBool32        rayTraversalPrimitiveCulling;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            shaderGroupHandleSize;
        public uint            maxRayRecursionDepth;
        public uint            maxShaderGroupStride;
        public uint            shaderGroupBaseAlignment;
        public uint            shaderGroupHandleCaptureReplaySize;
        public uint            maxRayDispatchInvocationCount;
        public uint            shaderGroupHandleAlignment;
        public uint            maxRayHitAttributeSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkStridedDeviceAddressRegionKHR
    {
        public VkDeviceAddress deviceAddress;
        public VkDeviceSize    stride;
        public VkDeviceSize    size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkTraceRaysIndirectCommandKHR
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkBool32        rayQuery;
    }
}