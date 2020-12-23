#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.CompilerServices;
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

        public delegate* unmanaged<  /*AllocationFunction*/
            void*,                   /* pUserData        */
            size_t,                  /* size             */
            size_t,                  /* alignment        */
            VkSystemAllocationScope, /* allocationScope  */
            void*> pfnAllocation;

        public delegate* unmanaged<  /*ReallocationFunction*/
            void*,                   /* pUserData          */
            void*,                   /* pOriginal          */
            size_t,                  /* size               */
            size_t,                  /* alignment          */
            VkSystemAllocationScope, /* allocationScope    */
            void*> pfnReallocation;

        public delegate* unmanaged< /*FreeFunction        */
            void*,                  /* pUserData          */
            void*,                  /* pMemory            */
            void> pfnFree;

        public delegate* unmanaged<   /*InternalAllocationNotification*/
            void*,                    /* pUserData                    */
            size_t,                   /* size                         */
            VkInternalAllocationType, /* allocationType               */
            VkSystemAllocationScope,  /* allocationScope              */
            void> pfnInternalAllocation;

        public delegate* unmanaged<   /*InternalFreeNotification*/
            void*,                    /* pUserData              */
            size_t,                   /* size                   */
            VkInternalAllocationType, /* allocationType         */
            VkSystemAllocationScope,  /* allocationScope        */
            void> pfnInternalFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void*           pNext;
        public byte*           pApplicationName;
        public VkVersion       applicationVersion;
        public byte*           pEngineName;
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
        public byte**                ppEnabledLayerNames;
        public uint                  enabledExtensionCount;
        public byte**                ppEnabledExtensionNames;
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
    public unsafe struct VkMemoryTypeArray
    {
        public VkMemoryType this[int index]
        {
            get { return *((VkMemoryType*)Unsafe.AsPointer(ref this) + index); }
            //set { *((VkMemoryType*)Unsafe.AsPointer(ref this) + index) = value; }
        }

        private readonly VkMemoryType M01;
        private readonly VkMemoryType M02;
        private readonly VkMemoryType M03;
        private readonly VkMemoryType M04;
        private readonly VkMemoryType M05;
        private readonly VkMemoryType M06;
        private readonly VkMemoryType M07;
        private readonly VkMemoryType M08;
        private readonly VkMemoryType M09;
        private readonly VkMemoryType M10;
        private readonly VkMemoryType M11;
        private readonly VkMemoryType M12;
        private readonly VkMemoryType M13;
        private readonly VkMemoryType M14;
        private readonly VkMemoryType M15;
        private readonly VkMemoryType M16;
        private readonly VkMemoryType M17;
        private readonly VkMemoryType M18;
        private readonly VkMemoryType M19;
        private readonly VkMemoryType M20;
        private readonly VkMemoryType M21;
        private readonly VkMemoryType M22;
        private readonly VkMemoryType M23;
        private readonly VkMemoryType M24;
        private readonly VkMemoryType M25;
        private readonly VkMemoryType M26;
        private readonly VkMemoryType M27;
        private readonly VkMemoryType M28;
        private readonly VkMemoryType M29;
        private readonly VkMemoryType M30;
        private readonly VkMemoryType M31;
        private readonly VkMemoryType M32;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool robustBufferAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fullDrawIndexUint32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool imageCubeArray;

        [MarshalAs(UnmanagedType.Bool)]
        public bool independentBlend;

        [MarshalAs(UnmanagedType.Bool)]
        public bool geometryShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool tessellationShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sampleRateShading;

        [MarshalAs(UnmanagedType.Bool)]
        public bool dualSrcBlend;

        [MarshalAs(UnmanagedType.Bool)]
        public bool logicOp;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiDrawIndirect;

        [MarshalAs(UnmanagedType.Bool)]
        public bool drawIndirectFirstInstance;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthClamp;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthBiasClamp;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fillModeNonSolid;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthBounds;

        [MarshalAs(UnmanagedType.Bool)]
        public bool wideLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool largePoints;

        [MarshalAs(UnmanagedType.Bool)]
        public bool alphaToOne;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiViewport;

        [MarshalAs(UnmanagedType.Bool)]
        public bool samplerAnisotropy;

        [MarshalAs(UnmanagedType.Bool)]
        public bool textureCompressionETC2;

        [MarshalAs(UnmanagedType.Bool)]
        public bool textureCompressionASTC_LDR;

        [MarshalAs(UnmanagedType.Bool)]
        public bool textureCompressionBC;

        [MarshalAs(UnmanagedType.Bool)]
        public bool occlusionQueryPrecise;

        [MarshalAs(UnmanagedType.Bool)]
        public bool pipelineStatisticsQuery;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vertexPipelineStoresAndAtomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentStoresAndAtomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderTessellationAndGeometryPointSize;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderImageGatherExtended;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageExtendedFormats;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageMultisample;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageReadWithoutFormat;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageWriteWithoutFormat;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSampledImageArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderClipDistance;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderCullDistance;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInt64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInt16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderResourceResidency;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderResourceMinLod;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseBinding;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidencyBuffer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidencyImage2D;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidencyImage3D;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidency2Samples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidency4Samples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidency8Samples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidency16Samples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseResidencyAliased;

        [MarshalAs(UnmanagedType.Bool)]
        public bool variableMultisampleRate;

        [MarshalAs(UnmanagedType.Bool)]
        public bool inheritedQueries;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool timestampComputeAndGraphics;

        public       float timestampPeriod;
        public       uint  maxClipDistances;
        public       uint  maxCullDistances;
        public       uint  maxCombinedClipAndCullDistances;
        public       uint  discreteQueuePriorities;
        public fixed float pointSizeRange[2];
        public fixed float lineWidthRange[2];
        public       float pointSizeGranularity;
        public       float lineWidthGranularity;

        [MarshalAs(UnmanagedType.Bool)]
        public bool strictLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool standardSampleLocations;

        public VkDeviceSize optimalBufferCopyOffsetAlignment;
        public VkDeviceSize optimalBufferCopyRowPitchAlignment;
        public VkDeviceSize nonCoherentAtomSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryProperties
    {
        public uint                    memoryTypeCount;
        public VkMemoryTypeArray       memoryTypes;
        public uint                    memoryHeapCount;
        public VkArray16<VkMemoryHeap> memoryHeaps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseProperties
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool residencyStandard2DBlockShape;

        [MarshalAs(UnmanagedType.Bool)]
        public bool residencyStandard2DMultisampleBlockShape;

        [MarshalAs(UnmanagedType.Bool)]
        public bool residencyStandard3DBlockShape;

        [MarshalAs(UnmanagedType.Bool)]
        public bool residencyAlignedMipSize;

        [MarshalAs(UnmanagedType.Bool)]
        public bool residencyNonResidentStrict;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProperties
    {
        public       VkVersion                        apiVersion;
        public       uint                             driverVersion;
        public       uint                             vendorID;
        public       uint                             deviceID;
        public       VkPhysicalDeviceType             deviceType;
        public fixed char                             deviceName[VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
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
        public byte**                    ppEnabledLayerNames;
        public uint                      enabledExtensionCount;
        public byte**                    ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkExtensionProperties
    {
        public fixed byte extensionName[VK_MAX_EXTENSION_NAME_SIZE];
        public       uint specVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkLayerProperties
    {
        public fixed byte      layerName[VK_MAX_EXTENSION_NAME_SIZE];
        public       VkVersion specVersion;
        public       uint      implementationVersion;
        public fixed byte      description[VK_MAX_DESCRIPTION_SIZE];
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
        public byte*                            pName;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool primitiveRestartEnable;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthClampEnable;

        [MarshalAs(UnmanagedType.Bool)]
        public bool rasterizerDiscardEnable;

        public VkPolygonMode   polygonMode;
        public VkCullModeFlags cullMode;
        public VkFrontFace     frontFace;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthBiasEnable;

        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType                       sType;
        public void*                                 pNext;
        public VkPipelineMultisampleStateCreateFlags flags;
        public VkSampleCountFlags                    rasterizationSamples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sampleShadingEnable;

        public float minSampleShading;
        public uint* pSampleMask;

        [MarshalAs(UnmanagedType.Bool)]
        public bool alphaToCoverageEnable;

        [MarshalAs(UnmanagedType.Bool)]
        public bool alphaToOneEnable;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthTestEnable;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthWriteEnable;

        public VkCompareOp depthCompareOp;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthBoundsTestEnable;

        [MarshalAs(UnmanagedType.Bool)]
        public bool stencilTestEnable;

        public VkStencilOpState front;
        public VkStencilOpState back;
        public float            minDepthBounds;
        public float            maxDepthBounds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineColorBlendAttachmentState
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool blendEnable;

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
        public VkStructureType                      sType;
        public void*                                pNext;
        public VkPipelineColorBlendStateCreateFlags flags;

        [MarshalAs(UnmanagedType.Bool)]
        public bool logicOpEnable;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool anisotropyEnable;

        public float maxAnisotropy;

        [MarshalAs(UnmanagedType.Bool)]
        public bool compareEnable;

        public VkCompareOp   compareOp;
        public float         minLod;
        public float         maxLod;
        public VkBorderColor borderColor;

        [MarshalAs(UnmanagedType.Bool)]
        public bool unnormalizedCoordinates;
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
        public VkStructureType sType;
        public void*           pNext;
        public VkRenderPass    renderPass;
        public uint            subpass;
        public VkFramebuffer   framebuffer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool occlusionQueryEnable;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool quadOperationsInAllStages;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageBuffer16BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformAndStorageBuffer16BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storagePushConstant16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageInputOutput16;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool prefersDedicatedAllocation;

        [MarshalAs(UnmanagedType.Bool)]
        public bool requiresDedicatedAllocation;
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
        public VkStructureType       sType;
        public void*                 pNext;
        public uint                  physicalDeviceCount;
        public VkPhysicalDeviceArray physicalDevices;

        [MarshalAs(UnmanagedType.Bool)]
        public bool subsetAllocation;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiview;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiviewGeometryShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiviewTessellationShader;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool variablePointersStorageBuffer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool variablePointers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool protectedMemory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool protectedNoFault;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool protectedSubmit;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool forceExplicitReconstruction;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool samplerYcbcrConversion;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool deviceLUIDValid;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool supported;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDrawParameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageBuffer16BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformAndStorageBuffer16BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storagePushConstant16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageInputOutput16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiview;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiviewGeometryShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool multiviewTessellationShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool variablePointersStorageBuffer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool variablePointers;

        [MarshalAs(UnmanagedType.Bool)]
        public bool protectedMemory;

        [MarshalAs(UnmanagedType.Bool)]
        public bool samplerYcbcrConversion;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDrawParameters;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public fixed byte            deviceUUID[VK_UUID_SIZE];
        public fixed byte            driverUUID[VK_UUID_SIZE];
        public fixed byte            deviceLUID[VK_LUID_SIZE];
        public       uint            deviceNodeMask;

        [MarshalAs(UnmanagedType.Bool)]
        public bool deviceLUIDValid;

        public uint                   subgroupSize;
        public VkShaderStageFlags     subgroupSupportedStages;
        public VkSubgroupFeatureFlags subgroupSupportedOperations;

        [MarshalAs(UnmanagedType.Bool)]
        public bool subgroupQuadOperationsInAllStages;

        public VkPointClippingBehavior pointClippingBehavior;
        public uint                    maxMultiviewViewCount;
        public uint                    maxMultiviewInstanceIndex;

        [MarshalAs(UnmanagedType.Bool)]
        public bool protectedNoFault;

        public uint         maxPerSetDescriptors;
        public VkDeviceSize maxMemoryAllocationSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool samplerMirrorClampToEdge;

        [MarshalAs(UnmanagedType.Bool)]
        public bool drawIndirectCount;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageBuffer8BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformAndStorageBuffer8BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storagePushConstant8;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferInt64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedInt64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInt8;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformTexelBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageTexelBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSampledImageArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformTexelBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageTexelBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUniformBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingSampledImageUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageImageUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUniformTexelBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageTexelBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUpdateUnusedWhilePending;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingPartiallyBound;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingVariableDescriptorCount;

        [MarshalAs(UnmanagedType.Bool)]
        public bool runtimeDescriptorArray;

        [MarshalAs(UnmanagedType.Bool)]
        public bool samplerFilterMinmax;

        [MarshalAs(UnmanagedType.Bool)]
        public bool scalarBlockLayout;

        [MarshalAs(UnmanagedType.Bool)]
        public bool imagelessFramebuffer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformBufferStandardLayout;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSubgroupExtendedTypes;

        [MarshalAs(UnmanagedType.Bool)]
        public bool separateDepthStencilLayouts;

        [MarshalAs(UnmanagedType.Bool)]
        public bool hostQueryReset;

        [MarshalAs(UnmanagedType.Bool)]
        public bool timelineSemaphore;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddress;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressCaptureReplay;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressMultiDevice;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModel;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModelDeviceScope;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModelAvailabilityVisibilityChains;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderOutputViewportIndex;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderOutputLayer;

        [MarshalAs(UnmanagedType.Bool)]
        public bool subgroupBroadcastDynamicId;
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
        public fixed char                              driverName[VK_MAX_DRIVER_NAME_SIZE];
        public fixed char                              driverInfo[VK_MAX_DRIVER_INFO_SIZE];
        public       VkConformanceVersion              conformanceVersion;
        public       VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public       VkShaderFloatControlsIndependence roundingModeIndependence;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat64;

        public uint maxUpdateAfterBindDescriptorsInAllPools;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformBufferArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSampledImageArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageBufferArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool robustBufferAccessUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool quadDivergentImplicitLod;

        public uint               maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint               maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint               maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint               maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint               maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint               maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint               maxPerStageUpdateAfterBindResources;
        public uint               maxDescriptorSetUpdateAfterBindSamplers;
        public uint               maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint               maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint               maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint               maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint               maxDescriptorSetUpdateAfterBindSampledImages;
        public uint               maxDescriptorSetUpdateAfterBindStorageImages;
        public uint               maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;

        [MarshalAs(UnmanagedType.Bool)]
        public bool independentResolveNone;

        [MarshalAs(UnmanagedType.Bool)]
        public bool independentResolve;

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterMinmaxSingleComponentFormats;

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterMinmaxImageComponentMapping;

        public ulong              maxTimelineSemaphoreValueDifference;
        public VkSampleCountFlags framebufferIntegerColorSampleCounts;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageBuffer8BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformAndStorageBuffer8BitAccess;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storagePushConstant8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public       VkStructureType      sType;
        public       void*                pNext;
        public       VkDriverId           driverID;
        public fixed char                 driverName[VK_MAX_DRIVER_NAME_SIZE];
        public fixed char                 driverInfo[VK_MAX_DRIVER_INFO_SIZE];
        public       VkConformanceVersion conformanceVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferInt64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedInt64Atomics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInt8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType                   sType;
        public void*                             pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSignedZeroInfNanPreserveFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormPreserveFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDenormFlushToZeroFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTEFloat64;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat16;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat32;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderRoundingModeRTZFloat64;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformTexelBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageTexelBufferArrayDynamicIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSampledImageArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformTexelBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageTexelBufferArrayNonUniformIndexing;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUniformBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingSampledImageUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageImageUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUniformTexelBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingStorageTexelBufferUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingUpdateUnusedWhilePending;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingPartiallyBound;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingVariableDescriptorCount;

        [MarshalAs(UnmanagedType.Bool)]
        public bool runtimeDescriptorArray;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            maxUpdateAfterBindDescriptorsInAllPools;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderUniformBufferArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSampledImageArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageBufferArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderStorageImageArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderInputAttachmentArrayNonUniformIndexingNative;

        [MarshalAs(UnmanagedType.Bool)]
        public bool robustBufferAccessUpdateAfterBind;

        [MarshalAs(UnmanagedType.Bool)]
        public bool quadDivergentImplicitLod;

        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool independentResolveNone;

        [MarshalAs(UnmanagedType.Bool)]
        public bool independentResolve;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool scalarBlockLayout;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterMinmaxSingleComponentFormats;

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterMinmaxImageComponentMapping;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModel;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModelDeviceScope;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vulkanMemoryModelAvailabilityVisibilityChains;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool imagelessFramebuffer;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformBufferStandardLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSubgroupExtendedTypes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool separateDepthStencilLayouts;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool hostQueryReset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool timelineSemaphore;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddress;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressCaptureReplay;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressMultiDevice;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool clipped;

        public VkSwapchainKHR oldSwapchain;
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
        public byte*                      displayName;
        public VkExtent2D                 physicalDimensions;
        public VkExtent2D                 physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;

        [MarshalAs(UnmanagedType.Bool)]
        public bool planeReorderPossible;

        [MarshalAs(UnmanagedType.Bool)]
        public bool persistentContent;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool persistent;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool performanceCounterQueryPools;

        [MarshalAs(UnmanagedType.Bool)]
        public bool performanceCounterMultipleQueryPools;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool allowCommandBufferQueryCopies;
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
        public fixed char                                    name[VK_MAX_DESCRIPTION_SIZE];
        public fixed char                                    category[VK_MAX_DESCRIPTION_SIZE];
        public fixed char                                    description[VK_MAX_DESCRIPTION_SIZE];
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSubgroupClock;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDeviceClock;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderTerminateInvocation;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool pipelineFragmentShadingRate;

        [MarshalAs(UnmanagedType.Bool)]
        public bool primitiveFragmentShadingRate;

        [MarshalAs(UnmanagedType.Bool)]
        public bool attachmentFragmentShadingRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkExtent2D      minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D      maxFragmentShadingRateAttachmentTexelSize;
        public uint            maxFragmentShadingRateAttachmentTexelSizeAspectRatio;

        [MarshalAs(UnmanagedType.Bool)]
        public bool primitiveFragmentShadingRateWithMultipleViewports;

        [MarshalAs(UnmanagedType.Bool)]
        public bool layeredShadingRateAttachments;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateNonTrivialCombinerOps;

        public VkExtent2D         maxFragmentSize;
        public uint               maxFragmentSizeAspectRatio;
        public uint               maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithShaderDepthStencilWrites;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithSampleMask;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithShaderSampleMask;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithConservativeRasterization;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithFragmentShaderInterlock;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateWithCustomSampleLocations;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateStrictMultiplyCombiner;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool supportsProtected;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool pipelineExecutableInfo;
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
        public fixed char               name[VK_MAX_DESCRIPTION_SIZE];
        public fixed char               description[VK_MAX_DESCRIPTION_SIZE];
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
        public fixed char                                   name[VK_MAX_DESCRIPTION_SIZE];
        public fixed char                                   description[VK_MAX_DESCRIPTION_SIZE];
        public       VkPipelineExecutableStatisticFormatKHR format;
        public       VkPipelineExecutableStatisticValueKHR  value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public       VkStructureType sType;
        public       void*           pNext;
        public fixed char            name[VK_MAX_DESCRIPTION_SIZE];
        public fixed char            description[VK_MAX_DESCRIPTION_SIZE];

        [MarshalAs(UnmanagedType.Bool)]
        public bool isText;

        public nuint dataSize;
        public void* pData;
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
        [MarshalAs(UnmanagedType.U4)]
        public VkStructureType sType;

        public void* pNext;

        [MarshalAs(UnmanagedType.U4)]
        public VkDebugReportFlagsEXT flags;

        public delegate* unmanaged<
            VkDebugReportFlagsEXT,      /* flags        */
            VkDebugReportObjectTypeEXT, /* objectType   */
            ulong,                      /* @object      */
            nuint,                      /* location     */
            int,                        /* messageCode  */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage     */
            void*,                      /* flags        */
            bool> pfnCallback;

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
        public byte*                      pObjectName;
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
        public       byte*           pMarkerName;
        public fixed float           color[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool dedicatedAllocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool dedicatedAllocation;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool transformFeedback;

        [MarshalAs(UnmanagedType.Bool)]
        public bool geometryStreams;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool transformFeedbackQueries;

        [MarshalAs(UnmanagedType.Bool)]
        public bool transformFeedbackStreamsLinesTriangles;

        [MarshalAs(UnmanagedType.Bool)]
        public bool transformFeedbackRasterizationStreamSelect;

        [MarshalAs(UnmanagedType.Bool)]
        public bool transformFeedbackDraw;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool supportsTextureGatherLODBiasAMD;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool cornerSampledImage;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool textureCompressionASTC_HDR;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool decodeModeSharedExponent;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool conditionalRendering;

        [MarshalAs(UnmanagedType.Bool)]
        public bool inheritedConditionalRendering;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool conditionalRenderingEnable;
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
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool viewportWScalingEnable;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool perViewPositionAllComponents;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool primitiveUnderestimation;

        [MarshalAs(UnmanagedType.Bool)]
        public bool conservativePointAndLineRasterization;

        [MarshalAs(UnmanagedType.Bool)]
        public bool degenerateTrianglesRasterized;

        [MarshalAs(UnmanagedType.Bool)]
        public bool degenerateLinesRasterized;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fullyCoveredFragmentShaderInputVariable;

        [MarshalAs(UnmanagedType.Bool)]
        public bool conservativeRasterizationPostDepthCoverage;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthClipEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType                                     sType;
        public void*                                               pNext;
        public VkPipelineRasterizationDepthClipStateCreateFlagsEXT flags;

        [MarshalAs(UnmanagedType.Bool)]
        public bool depthClipEnable;
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
        public byte*           pLabelName;
        public VkColor         color;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkObjectType    objectType;
        public ulong           objectHandle;
        public byte*           pObjectName;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        /// <summary>
        ///     0 and is reserved for future use.
        /// </summary>
        public uint flags;

        public byte*                          pMessageIdName;
        public int                            messageIdNumber;
        public byte*                          pMessage;
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
        [MarshalAs(UnmanagedType.U4)]
        public VkStructureType sType;

        public void* pNext;

        /// <summary>
        ///     Is 0 and is reserved for future use.
        /// </summary>
        public uint flags;

        [MarshalAs(UnmanagedType.U4)]
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;

        [MarshalAs(UnmanagedType.U4)]
        public VkDebugUtilsMessageTypeFlagsEXT messageType;

        public delegate* unmanaged<
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes    */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData   */
            void*,                                 /* pUserData       */
            bool> pfnUserCallback;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool inlineUniformBlock;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingInlineUniformBlockUpdateAfterBind;
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
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sampleLocationsEnable;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool variableSampleLocations;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendCoherentOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public uint            advancedBlendMaxColorAttachments;

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendIndependentBlend;

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendNonPremultipliedSrcColor;

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendNonPremultipliedDstColor;

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendCorrelatedOverlap;

        [MarshalAs(UnmanagedType.Bool)]
        public bool advancedBlendAllOperations;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool srcPremultiplied;

        [MarshalAs(UnmanagedType.Bool)]
        public bool dstPremultiplied;

        public VkBlendOverlapEXT blendOverlap;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType                             sType;
        public void*                                       pNext;
        public VkPipelineCoverageToColorStateCreateFlagsNV flags;

        [MarshalAs(UnmanagedType.Bool)]
        public bool coverageToColorEnable;

        public uint coverageToColorLocation;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType                                sType;
        public void*                                          pNext;
        public VkPipelineCoverageModulationStateCreateFlagsNV flags;
        public VkCoverageModulationModeNV                     coverageModulationMode;

        [MarshalAs(UnmanagedType.Bool)]
        public bool coverageModulationTableEnable;

        public uint   coverageModulationTableCount;
        public float* pCoverageModulationTable;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSMBuiltins;
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
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shadingRateImageEnable;

        public uint                    viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shadingRateImage;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shadingRateCoarseSampleOrder;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool representativeFragmentTest;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool representativeFragmentTestEnable;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterCubic;

        [MarshalAs(UnmanagedType.Bool)]
        public bool filterCubicMinmax;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool vertexAttributeInstanceRateDivisor;

        [MarshalAs(UnmanagedType.Bool)]
        public bool vertexAttributeInstanceRateZeroDivisor;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool computeDerivativeGroupQuads;

        [MarshalAs(UnmanagedType.Bool)]
        public bool computeDerivativeGroupLinear;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool taskShader;

        [MarshalAs(UnmanagedType.Bool)]
        public bool meshShader;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShaderBarycentric;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool imageFootprint;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool exclusiveScissor;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderIntegerFunctions2;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool enable;

        public ulong parameter;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool localDimmingSupport;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool localDimmingEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentDensityMap;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentDensityMapDynamic;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentDensityMapNonSubsampledImages;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkExtent2D      minFragmentDensityTexelSize;
        public VkExtent2D      maxFragmentDensityTexelSize;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentDensityInvocations;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool subgroupSizeControl;

        [MarshalAs(UnmanagedType.Bool)]
        public bool computeFullSubgroups;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool deviceCoherentMemory;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderImageInt64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseImageInt64Atomics;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool memoryPriority;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool dedicatedAllocationImageAliasing;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddress;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressCaptureReplay;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bufferDeviceAddressMultiDevice;
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
        public fixed char                  name[VK_MAX_EXTENSION_NAME_SIZE];
        public fixed char                  version[VK_MAX_EXTENSION_NAME_SIZE];
        public       VkToolPurposeFlagsEXT purposes;
        public fixed char                  description[VK_MAX_DESCRIPTION_SIZE];
        public fixed char                  layer[VK_MAX_EXTENSION_NAME_SIZE];
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool cooperativeMatrix;

        [MarshalAs(UnmanagedType.Bool)]
        public bool cooperativeMatrixRobustBufferAccess;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool coverageReductionMode;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShaderSampleInterlock;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShaderPixelInterlock;

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShaderShadingRateInterlock;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool ycbcrImageArrays;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool rectangularLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool bresenhamLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool smoothLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool stippledRectangularLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool stippledBresenhamLines;

        [MarshalAs(UnmanagedType.Bool)]
        public bool stippledSmoothLines;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool stippledLineEnable;

        public uint   lineStippleFactor;
        public ushort lineStipplePattern;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferFloat32Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferFloat32AtomicAdd;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferFloat64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderBufferFloat64AtomicAdd;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedFloat32Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedFloat32AtomicAdd;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedFloat64Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderSharedFloat64AtomicAdd;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderImageFloat32Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderImageFloat32AtomicAdd;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseImageFloat32Atomics;

        [MarshalAs(UnmanagedType.Bool)]
        public bool sparseImageFloat32AtomicAdd;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool indexTypeUint8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool extendedDynamicState;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool shaderDemoteToHelperInvocation;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool deviceGeneratedCommands;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool vertexDynamicStride;

        public VkPipelineLayout       pushconstantPipelineLayout;
        public VkShaderStageFlags     pushconstantShaderStageFlags;
        public uint                   pushconstantOffset;
        public uint                   pushconstantSize;
        public VkIndirectStateFlagsNV indirectStateFlags;
        public uint                   indexTypeCount;
        public VkIndexType*           pIndexTypes;
        public uint*                  pIndexTypeValues;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool texelBufferAlignment;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;
        public VkDeviceSize    storageTexelBufferOffsetAlignmentBytes;

        [MarshalAs(UnmanagedType.Bool)]
        public bool storageTexelBufferOffsetSingleTexelAlignment;

        public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;

        [MarshalAs(UnmanagedType.Bool)]
        public bool uniformTexelBufferOffsetSingleTexelAlignment;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool deviceMemoryReport;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool robustBufferAccess2;

        [MarshalAs(UnmanagedType.Bool)]
        public bool robustImageAccess2;

        [MarshalAs(UnmanagedType.Bool)]
        public bool nullDescriptor;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool customBorderColors;

        [MarshalAs(UnmanagedType.Bool)]
        public bool customBorderColorWithoutFormat;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool privateData;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool pipelineCreationCacheControl;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool diagnosticsConfig;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentShadingRateEnums;

        [MarshalAs(UnmanagedType.Bool)]
        public bool supersampleFragmentShadingRates;

        [MarshalAs(UnmanagedType.Bool)]
        public bool noInvocationFragmentShadingRates;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool fragmentDensityMapDeferred;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool subsampledLoads;

        [MarshalAs(UnmanagedType.Bool)]
        public bool subsampledCoarseReconstructionEarlyAccess;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool robustImageAccess;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool formatA4R4G4B4;

        [MarshalAs(UnmanagedType.Bool)]
        public bool formatA4B4G4R4;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
        public VkStructureType sType;
        public void*           pNext;

        [MarshalAs(UnmanagedType.Bool)]
        public bool mutableDescriptorType;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool arrayOfPointers;

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

        [MarshalAs(UnmanagedType.Bool)]
        public bool accelerationStructure;

        [MarshalAs(UnmanagedType.Bool)]
        public bool accelerationStructureCaptureReplay;

        [MarshalAs(UnmanagedType.Bool)]
        public bool accelerationStructureIndirectBuild;

        [MarshalAs(UnmanagedType.Bool)]
        public bool accelerationStructureHostCommands;

        [MarshalAs(UnmanagedType.Bool)]
        public bool descriptorBindingAccelerationStructureUpdateAfterBind;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayTracingPipeline;

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayTracingPipelineShaderGroupHandleCaptureReplay;

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayTracingPipelineShaderGroupHandleCaptureReplayMixed;

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayTracingPipelineTraceRaysIndirect;

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayTraversalPrimitiveCulling;
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

        [MarshalAs(UnmanagedType.Bool)]
        public bool rayQuery;
    }
}