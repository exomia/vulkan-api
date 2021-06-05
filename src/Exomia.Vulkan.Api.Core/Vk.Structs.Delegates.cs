#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core
{
    using VkMemoryRequirements2KHR = VkMemoryRequirements2;

    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe struct VkFunction
    {
        public static readonly VkFunction Zero = null;

        [FieldOffset(0)]
        private readonly void* _ptr;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkPhysicalDeviceFeatures2*, /* pFeatures */
            void> vkGetPhysicalDeviceFeatures2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,             /* physicalDevice */
            VkPhysicalDeviceProperties2*, /* pProperties */
            void> vkGetPhysicalDeviceProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,     /* physicalDevice */
            VkFormat,             /* format */
            VkFormatProperties2*, /* pFormatProperties */
            void> vkGetPhysicalDeviceFormatProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                  /* physicalDevice */
            VkPhysicalDeviceImageFormatInfo2*, /* pImageFormatInfo */
            VkImageFormatProperties2*,         /* pImageFormatProperties */
            VkResult> vkGetPhysicalDeviceImageFormatProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,          /* physicalDevice */
            uint*,                     /* pQueueFamilyPropertyCount */
            VkQueueFamilyProperties2*, /* pQueueFamilyProperties */
            void> vkGetPhysicalDeviceQueueFamilyProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkPhysicalDeviceMemoryProperties2*, /* pMemoryProperties */
            void> vkGetPhysicalDeviceMemoryProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            VkPhysicalDeviceSparseImageFormatInfo2*, /* pFormatInfo */
            uint*,                                   /* pPropertyCount */
            VkSparseImageFormatProperties2*,         /* pProperties */
            void> vkGetPhysicalDeviceSparseImageFormatProperties2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                     /* device */
            uint,                         /* heapIndex */
            uint,                         /* localDeviceIndex */
            uint,                         /* remoteDeviceIndex */
            VkPeerMemoryFeatureFlagBits*, /* pPeerMemoryFeatures */
            void> vkGetDeviceGroupPeerMemoryFeaturesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* deviceMask */
            void> vkCmdSetDeviceMaskKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* baseGroupX */
            uint,            /* baseGroupY */
            uint,            /* baseGroupZ */
            uint,            /* groupCountX */
            uint,            /* groupCountY */
            uint,            /* groupCountZ */
            void> vkCmdDispatchBaseKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                  /* device */
            VkCommandPool,             /* commandPool */
            VkCommandPoolTrimFlagBits, /* FlagBits */
            void> vkTrimCommandPoolKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                       /* instance */
            uint*,                            /* pPhysicalDeviceGroupCount */
            VkPhysicalDeviceGroupProperties*, /* pPhysicalDeviceGroupProperties */
            VkResult> vkEnumeratePhysicalDeviceGroupsKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                    /* physicalDevice */
            VkPhysicalDeviceExternalBufferInfo*, /* pExternalBufferInfo */
            VkExternalBufferProperties*,         /* pExternalBufferProperties */
            void> vkGetPhysicalDeviceExternalBufferPropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,              /* device */
            VkMemoryGetFdInfoKHR*, /* pGetFdInfo */
            int*,                  /* pFd */
            VkResult> vkGetMemoryFdKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            int,                                /* fd */
            VkMemoryFdPropertiesKHR*,           /* pMemoryFdProperties */
            VkResult> vkGetMemoryFdPropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                       /* physicalDevice */
            VkPhysicalDeviceExternalSemaphoreInfo*, /* pExternalSemaphoreInfo */
            VkExternalSemaphoreProperties*,         /* pExternalSemaphoreProperties */
            void> vkGetPhysicalDeviceExternalSemaphorePropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                    /* device */
            VkImportSemaphoreFdInfoKHR*, /* pImportSemaphoreFdInfo */
            VkResult> vkImportSemaphoreFdKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                 /* device */
            VkSemaphoreGetFdInfoKHR*, /* pGetFdInfo */
            int*,                     /* pFd */
            VkResult> vkGetSemaphoreFdKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkPipelineBindPoint,   /* pipelineBindPoint */
            VkPipelineLayout,      /* layout */
            uint,                  /* set */
            uint,                  /* descriptorWriteCount */
            VkWriteDescriptorSet*, /* pDescriptorWrites */
            void> vkCmdPushDescriptorSetKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            VkPipelineLayout,           /* layout */
            uint,                       /* set */
            void*,                      /* pData */
            void> vkCmdPushDescriptorSetWithTemplateKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                              /* device */
            VkDescriptorUpdateTemplateCreateInfo*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkDescriptorUpdateTemplate*,           /* pDescriptorUpdateTemplate */
            VkResult> vkCreateDescriptorUpdateTemplateKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            VkAllocationCallbacks*,     /* pAllocator */
            void> vkDestroyDescriptorUpdateTemplateKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkDescriptorSet,            /* descriptorSet */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            void*,                      /* pData */
            void> vkUpdateDescriptorSetWithTemplateKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                 /* device */
            VkRenderPassCreateInfo2*, /* pCreateInfo */
            VkAllocationCallbacks*,   /* pAllocator */
            VkRenderPass*,            /* pRenderPass */
            VkResult> vkCreateRenderPass2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkRenderPassBeginInfo*, /* pRenderPassBegin */
            VkSubpassBeginInfo*,    /* pSubpassBeginInfo */
            void> vkCmdBeginRenderPass2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkSubpassBeginInfo*, /* pSubpassBeginInfo */
            VkSubpassEndInfo*,   /* pSubpassEndInfo */
            void> vkCmdNextSubpass2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,   /* commandBuffer */
            VkSubpassEndInfo*, /* pSubpassEndInfo */
            void> vkCmdEndRenderPass2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapchain */
            VkResult> vkGetSwapchainStatusKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkPhysicalDeviceExternalFenceInfo*, /* pExternalFenceInfo */
            VkExternalFenceProperties*,         /* pExternalFenceProperties */
            void> vkGetPhysicalDeviceExternalFencePropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                /* device */
            VkImportFenceFdInfoKHR*, /* pImportFenceFdInfo */
            VkResult> vkImportFenceFdKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,             /* device */
            VkFenceGetFdInfoKHR*, /* pGetFdInfo */
            int*,                 /* pFd */
            VkResult> vkGetFenceFdKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                    /* physicalDevice */
            uint,                                /* queueFamilyIndex */
            uint*,                               /* pCounterCount */
            VkPerformanceCounterKHR*,            /* pCounters */
            VkPerformanceCounterDescriptionKHR*, /* pCounterDescriptions */
            VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                     /* physicalDevice */
            VkQueryPoolPerformanceCreateInfoKHR*, /* pPerformanceQueryCreateInfo */
            uint*,                                /* pNumPasses */
            void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                       /* device */
            VkAcquireProfilingLockInfoKHR*, /* pInfo */
            VkResult> vkAcquireProfilingLockKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice, /* device */
            void> vkReleaseProfilingLockKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkImageMemoryRequirementsInfo2*, /* pInfo */
            VkMemoryRequirements2*,          /* pMemoryRequirements */
            void> vkGetImageMemoryRequirements2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                         /* device */
            VkBufferMemoryRequirementsInfo2*, /* pInfo */
            VkMemoryRequirements2*,           /* pMemoryRequirements */
            void> vkGetBufferMemoryRequirements2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                              /* device */
            VkImageSparseMemoryRequirementsInfo2*, /* pInfo */
            uint*,                                 /* pSparseMemoryRequirementCount */
            VkSparseImageMemoryRequirements2*,     /* pSparseMemoryRequirements */
            void> vkGetImageSparseMemoryRequirements2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                            /* device */
            VkSamplerYcbcrConversionCreateInfo*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkSamplerYcbcrConversion*,           /* pYcbcrConversion */
            VkResult> vkCreateSamplerYcbcrConversionKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                 /* device */
            VkSamplerYcbcrConversion, /* ycbcrConversion */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroySamplerYcbcrConversionKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                /* device */
            uint,                    /* bindInfoCount */
            VkBindBufferMemoryInfo*, /* pBindInfos */
            VkResult> vkBindBufferMemory2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            uint,                   /* bindInfoCount */
            VkBindImageMemoryInfo*, /* pBindInfos */
            VkResult> vkBindImageMemory2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                         /* device */
            VkDescriptorSetLayoutCreateInfo*, /* pCreateInfo */
            VkDescriptorSetLayoutSupport*,    /* pSupport */
            void> vkGetDescriptorSetLayoutSupportKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> vkCmdDrawIndirectCountKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> vkCmdDrawIndexedIndirectCountKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,    /* device */
            VkSemaphore, /* semaphore */
            ulong*,      /* pValue */
            VkResult> vkGetSemaphoreCounterValueKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,             /* device */
            VkSemaphoreWaitInfo*, /* pWaitInfo */
            ulong,                /* timeout */
            VkResult> vkWaitSemaphoresKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkSemaphoreSignalInfo*, /* pSignalInfo */
            VkResult> vkSignalSemaphoreKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            uint*,                                   /* pFragmentShadingRateCount */
            VkPhysicalDeviceFragmentShadingRateKHR*, /* pFragmentShadingRates */
            VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkExtent2D*,                        /* pFragmentSize */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps1 */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps2 */
            void> vkCmdSetFragmentShadingRateKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            VkDeviceAddress> vkGetBufferDeviceAddressKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            ulong> vkGetBufferOpaqueCaptureAddressKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                /* device */
            VkDeviceMemoryOpaqueCaptureAddressInfo*, /* pInfo */
            ulong> vkGetDeviceMemoryOpaqueCaptureAddressKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                /* device */
            VkAllocationCallbacks*,  /* pAllocator */
            VkDeferredOperationKHR*, /* pDeferredOperation */
            VkResult> vkCreateDeferredOperationKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyDeferredOperationKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            uint> vkGetDeferredOperationMaxConcurrencyKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkResult> vkGetDeferredOperationResultKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkResult> vkDeferredOperationJoinKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                           /* device */
            VkPipelineInfoKHR*,                 /* pPipelineInfo */
            uint*,                              /* pExecutableCount */
            VkPipelineExecutablePropertiesKHR*, /* pProperties */
            VkResult> vkGetPipelineExecutablePropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                          /* device */
            VkPipelineExecutableInfoKHR*,      /* pExecutableInfo */
            uint*,                             /* pStatisticCount */
            VkPipelineExecutableStatisticKHR*, /* pStatistics */
            VkResult> vkGetPipelineExecutableStatisticsKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                       /* device */
            VkPipelineExecutableInfoKHR*,                   /* pExecutableInfo */
            uint*,                                          /* pInternalRepresentationCount */
            VkPipelineExecutableInternalRepresentationKHR*, /* pInternalRepresentations */
            VkResult> vkGetPipelineExecutableInternalRepresentationsKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkCopyBufferInfo2KHR*, /* pCopyBufferInfo */
            void> vkCmdCopyBuffer2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkCopyImageInfo2KHR*, /* pCopyImageInfo */
            void> vkCmdCopyImage2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCopyBufferToImageInfo2KHR*, /* pCopyBufferToImageInfo */
            void> vkCmdCopyBufferToImage2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCopyImageToBufferInfo2KHR*, /* pCopyImageToBufferInfo */
            void> vkCmdCopyImageToBuffer2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkBlitImageInfo2KHR*, /* pBlitImageInfo */
            void> vkCmdBlitImage2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            VkResolveImageInfo2KHR*, /* pResolveImageInfo */
            void> vkCmdResolveImage2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugReportCallbackCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugReportCallbackEXT*,           /* pCallback */
            VkResult> vkCreateDebugReportCallbackEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugReportCallbackEXT, /* callback */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroyDebugReportCallbackEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                 /* instance */
            VkDebugReportFlagsEXT,      /* FlagBits */
            VkDebugReportObjectTypeEXT, /* objectType */
            ulong,                      /* @object */
            nuint,                      /* location */
            int,                        /* messageCode */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage */
            void> vkDebugReportMessageEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                       /* device */
            VkDebugMarkerObjectTagInfoEXT*, /* pTagInfo */
            VkResult> vkDebugMarkerSetObjectTagEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkDebugMarkerObjectNameInfoEXT*, /* pNameInfo */
            VkResult> vkDebugMarkerSetObjectNameEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> vkCmdDebugMarkerBeginEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdDebugMarkerEndEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkDebugMarkerMarkerInfoEXT*, /* pMarkerInfo */
            void> vkCmdDebugMarkerInsertEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            void> vkCmdBindTransformFeedbackBuffersEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdBeginTransformFeedbackEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstCounterBuffer */
            uint,            /* counterBufferCount */
            VkBuffer*,       /* pCounterBuffers */
            VkDeviceSize*,   /* pCounterBufferOffsets */
            void> vkCmdEndTransformFeedbackEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkQueryPool,            /* queryPool */
            uint,                   /* query */
            VkQueryControlFlagBits, /* FlagBits */
            uint,                   /* index */
            void> vkCmdBeginQueryIndexedEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkQueryPool,     /* queryPool */
            uint,            /* query */
            uint,            /* index */
            void> vkCmdEndQueryIndexedEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* instanceCount */
            uint,            /* firstInstance */
            VkBuffer,        /* counterBuffer */
            VkDeviceSize,    /* counterBufferOffset */
            uint,            /* counterOffset */
            uint,            /* vertexStride */
            void> vkCmdDrawIndirectByteCountEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                  /* device */
            VkImageViewHandleInfoNVX*, /* pInfo */
            uint> vkGetImageViewHandleNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                         /* device */
            VkImageView,                      /* imageView */
            VkImageViewAddressPropertiesNVX*, /* pProperties */
            VkResult> vkGetImageViewAddressNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> vkCmdDrawIndirectCountAMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> vkCmdDrawIndexedIndirectCountAMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,              /* device */
            VkPipeline,            /* pipeline */
            VkShaderStageFlagBits, /* shaderStage */
            VkShaderInfoTypeAMD,   /* infoType */
            nuint*,                /* pInfoSize */
            void*,                 /* pInfo */
            VkResult> vkGetShaderInfoAMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkFormat,                           /* format */
            VkImageType,                        /* type */
            VkImageTiling,                      /* tiling */
            VkImageUsageFlagBits,               /* usage */
            VkImageCreateFlagBits,              /* FlagBits */
            VkExternalMemoryHandleTypeFlagsNV,  /* externalHandleType */
            VkExternalImageFormatPropertiesNV*, /* pExternalImageFormatProperties */
            VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkConditionalRenderingBeginInfoEXT*, /* pConditionalRenderingBegin */
            void> vkCmdBeginConditionalRenderingEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdEndConditionalRenderingEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            uint,                  /* firstViewport */
            uint,                  /* viewportCount */
            VkViewportWScalingNV*, /* pViewportWScalings */
            void> vkCmdSetViewportWScalingNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            VkDisplayKHR,     /* display */
            VkResult> vkReleaseDisplayEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkSurfaceKHR,               /* surface */
            VkSurfaceCapabilities2EXT*, /* pSurfaceCapabilities */
            VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayPowerInfoEXT*, /* pDisplayPowerInfo */
            VkResult> vkDisplayPowerControlEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDeviceEventInfoEXT*,  /* pDeviceEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDeviceEventEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayEventInfoEXT*, /* pDisplayEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> vkRegisterDisplayEventEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                 /* device */
            VkSwapchainKHR,           /* swapchain */
            VkSurfaceCounterFlagsEXT, /* counter */
            ulong*,                   /* pCounterValue */
            VkResult> vkGetSwapchainCounterEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                      /* device */
            VkSwapchainKHR,                /* swapchain */
            VkRefreshCycleDurationGOOGLE*, /* pDisplayTimingProperties */
            VkResult> vkGetRefreshCycleDurationGOOGLE;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkSwapchainKHR,                  /* swapchain */
            uint*,                           /* pPresentationTimingCount */
            VkPastPresentationTimingGOOGLE*, /* pPresentationTimings */
            VkResult> vkGetPastPresentationTimingGOOGLE;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstDiscardRectangle */
            uint,            /* discardRectangleCount */
            VkRect2D*,       /* pDiscardRectangles */
            void> vkCmdSetDiscardRectangleEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,          /* device */
            uint,              /* swapchainCount */
            VkSwapchainKHR*,   /* pSwapchains */
            VkHdrMetadataEXT*, /* pMetadata */
            void> vkSetHdrMetadataEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                       /* device */
            VkDebugUtilsObjectNameInfoEXT*, /* pNameInfo */
            VkResult> vkSetDebugUtilsObjectNameEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                      /* device */
            VkDebugUtilsObjectTagInfoEXT*, /* pTagInfo */
            VkResult> vkSetDebugUtilsObjectTagEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkQueueBeginDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue, /* queue */
            void> vkQueueEndDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkQueueInsertDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkCmdBeginDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdEndDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkCmdInsertDebugUtilsLabelEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugUtilsMessengerCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugUtilsMessengerEXT*,           /* pMessenger */
            VkResult> vkCreateDebugUtilsMessengerEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugUtilsMessengerEXT, /* messenger */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroyDebugUtilsMessengerEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                            /* instance */
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData */
            void> vkSubmitDebugUtilsMessageEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,           /* commandBuffer */
            VkSampleLocationsInfoEXT*, /* pSampleLocationsInfo */
            void> vkCmdSetSampleLocationsEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,            /* physicalDevice */
            VkSampleCountFlagBits,       /* samples */
            VkMultisamplePropertiesEXT*, /* pMultisampleProperties */
            void> vkGetPhysicalDeviceMultisamplePropertiesEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                               /* device */
            VkImage,                                /* image */
            VkImageDrmFormatModifierPropertiesEXT*, /* pProperties */
            VkResult> vkGetImageDrmFormatModifierPropertiesEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkValidationCacheCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkValidationCacheEXT*,           /* pValidationCache */
            VkResult> vkCreateValidationCacheEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkValidationCacheEXT,   /* validationCache */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyValidationCacheEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,              /* device */
            VkValidationCacheEXT,  /* dstCache */
            uint,                  /* srcCacheCount */
            VkValidationCacheEXT*, /* pSrcCaches */
            VkResult> vkMergeValidationCachesEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,             /* device */
            VkValidationCacheEXT, /* validationCache */
            nuint*,               /* pDataSize */
            void*,                /* pData */
            VkResult> vkGetValidationCacheDataEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkImageView,     /* imageView */
            VkImageLayout,   /* imageLayout */
            void> vkCmdBindShadingRateImageNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            uint,                    /* firstViewport */
            uint,                    /* viewportCount */
            VkShadingRatePaletteNV*, /* pShadingRatePalettes */
            void> vkCmdSetViewportShadingRatePaletteNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCoarseSampleOrderTypeNV,    /* sampleOrderType */
            uint,                         /* customSampleOrderCount */
            VkCoarseSampleOrderCustomNV*, /* pCustomSampleOrders */
            void> vkCmdSetCoarseSampleOrderNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                             /* device */
            VkAccelerationStructureCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,               /* pAllocator */
            VkAccelerationStructureNV*,           /* pAccelerationStructure */
            VkResult> vkCreateAccelerationStructureNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            VkAllocationCallbacks*,    /* pAllocator */
            void> vkDestroyAccelerationStructureNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                         /* device */
            VkAccelerationStructureMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2KHR*,                        /* pMemoryRequirements */
            void> vkGetAccelerationStructureMemoryRequirementsNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                 /* device */
            uint,                                     /* bindInfoCount */
            VkBindAccelerationStructureMemoryInfoNV*, /* pBindInfos */
            VkResult> vkBindAccelerationStructureMemoryNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                /* commandBuffer */
            VkAccelerationStructureInfoNV*, /* pInfo */
            VkBuffer,                       /* instanceData */
            VkDeviceSize,                   /* instanceOffset */
            uint,                           /* update */
            VkAccelerationStructureNV,      /* dst */
            VkAccelerationStructureNV,      /* src */
            VkBuffer,                       /* scratch */
            VkDeviceSize,                   /* scratchOffset */
            void> vkCmdBuildAccelerationStructureNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkAccelerationStructureNV,          /* dst */
            VkAccelerationStructureNV,          /* src */
            VkCopyAccelerationStructureModeKHR, /* mode */
            void> vkCmdCopyAccelerationStructureNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* raygenShaderBindingTableBuffer */
            VkDeviceSize,    /* raygenShaderBindingOffset */
            VkBuffer,        /* missShaderBindingTableBuffer */
            VkDeviceSize,    /* missShaderBindingOffset */
            VkDeviceSize,    /* missShaderBindingStride */
            VkBuffer,        /* hitShaderBindingTableBuffer */
            VkDeviceSize,    /* hitShaderBindingOffset */
            VkDeviceSize,    /* hitShaderBindingStride */
            VkBuffer,        /* callableShaderBindingTableBuffer */
            VkDeviceSize,    /* callableShaderBindingOffset */
            VkDeviceSize,    /* callableShaderBindingStride */
            uint,            /* width */
            uint,            /* height */
            uint,            /* depth */
            void> vkCmdTraceRaysNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                          /* device */
            VkPipelineCache,                   /* pipelineCache */
            uint,                              /* createInfoCount */
            VkRayTracingPipelineCreateInfoNV*, /* pCreateInfos */
            VkAllocationCallbacks*,            /* pAllocator */
            VkPipeline*,                       /* pPipelines */
            VkResult> vkCreateRayTracingPipelinesNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> vkGetRayTracingShaderGroupHandlesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> vkGetRayTracingShaderGroupHandlesNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            nuint,                     /* dataSize */
            void*,                     /* pData */
            VkResult> vkGetAccelerationStructureHandleNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* accelerationStructureCount */
            VkAccelerationStructureNV*, /* pAccelerationStructures */
            VkQueryType,                /* queryType */
            VkQueryPool,                /* queryPool */
            uint,                       /* firstQuery */
            void> vkCmdWriteAccelerationStructuresPropertiesNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* shader */
            VkResult> vkCompileDeferredNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            void*,                              /* pHostPointer */
            VkMemoryHostPointerPropertiesEXT*,  /* pMemoryHostPointerProperties */
            VkResult> vkGetMemoryHostPointerPropertiesEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            VkPipelineStageFlagBits, /* pipelineStage */
            VkBuffer,                /* dstBuffer */
            VkDeviceSize,            /* dstOffset */
            uint,                    /* marker */
            void> vkCmdWriteBufferMarkerAMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint*,            /* pTimeDomainCount */
            VkTimeDomainEXT*, /* pTimeDomains */
            VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                      /* device */
            uint,                          /* timestampCount */
            VkCalibratedTimestampInfoEXT*, /* pTimestampInfos */
            ulong*,                        /* pTimestamps */
            ulong*,                        /* pMaxDeviation */
            VkResult> vkGetCalibratedTimestampsEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* taskCount */
            uint,            /* firstTask */
            void> vkCmdDrawMeshTasksNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            uint,            /* drawCount */
            uint,            /* stride */
            void> vkCmdDrawMeshTasksIndirectNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> vkCmdDrawMeshTasksIndirectCountNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstExclusiveScissor */
            uint,            /* exclusiveScissorCount */
            VkRect2D*,       /* pExclusiveScissors */
            void> vkCmdSetExclusiveScissorNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void*,           /* pCheckpointMarker */
            void> vkCmdSetCheckpointNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,             /* queue */
            uint*,               /* pCheckpointDataCount */
            VkCheckpointDataNV*, /* pCheckpointData */
            void> vkGetQueueCheckpointDataNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                             /* device */
            VkInitializePerformanceApiInfoINTEL*, /* pInitializeInfo */
            VkResult> vkInitializePerformanceApiINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice, /* device */
            void> vkUninitializePerformanceApiINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,               /* commandBuffer */
            VkPerformanceMarkerInfoINTEL*, /* pMarkerInfo */
            VkResult> vkCmdSetPerformanceMarkerINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkPerformanceStreamMarkerInfoINTEL*, /* pMarkerInfo */
            VkResult> vkCmdSetPerformanceStreamMarkerINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                 /* commandBuffer */
            VkPerformanceOverrideInfoINTEL*, /* pOverrideInfo */
            VkResult> vkCmdSetPerformanceOverrideINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                    /* device */
            VkPerformanceConfigurationAcquireInfoINTEL*, /* pAcquireInfo */
            VkPerformanceConfigurationINTEL*,            /* pConfiguration */
            VkResult> vkAcquirePerformanceConfigurationINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkPerformanceConfigurationINTEL, /* configuration */
            VkResult> vkReleasePerformanceConfigurationINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,                         /* queue */
            VkPerformanceConfigurationINTEL, /* configuration */
            VkResult> vkQueueSetPerformanceConfigurationINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkPerformanceParameterTypeINTEL, /* parameter */
            VkPerformanceValueINTEL*,        /* pValue */
            VkResult> vkGetPerformanceParameterINTEL;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapChain */
            uint,           /* localDimmingEnable */
            void> vkSetLocalDimmingAMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            VkDeviceAddress> vkGetBufferDeviceAddressEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            uint*,                              /* pToolCount */
            VkPhysicalDeviceToolPropertiesEXT*, /* pToolProperties */
            VkResult> vkGetPhysicalDeviceToolPropertiesEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                 /* physicalDevice */
            uint*,                            /* pPropertyCount */
            VkCooperativeMatrixPropertiesNV*, /* pProperties */
            VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            uint*,                                   /* pCombinationCount */
            VkFramebufferMixedSamplesCombinationNV*, /* pCombinations */
            VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkInstance,                      /* instance */
            VkHeadlessSurfaceCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkSurfaceKHR*,                   /* pSurface */
            VkResult> vkCreateHeadlessSurfaceEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* lineStippleFactor */
            ushort,          /* lineStipplePattern */
            void> vkCmdSetLineStippleEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,    /* device */
            VkQueryPool, /* queryPool */
            uint,        /* firstQuery */
            uint,        /* queryCount */
            void> vkResetQueryPoolEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,    /* commandBuffer */
            VkCullModeFlagBits, /* cullMode */
            void> vkCmdSetCullModeEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkFrontFace,     /* frontFace */
            void> vkCmdSetFrontFaceEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkPrimitiveTopology, /* primitiveTopology */
            void> vkCmdSetPrimitiveTopologyEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* viewportCount */
            VkViewport*,     /* pViewports */
            void> vkCmdSetViewportWithCountEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* scissorCount */
            VkRect2D*,       /* pScissors */
            void> vkCmdSetScissorWithCountEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            VkDeviceSize*,   /* pStrides */
            void> vkCmdBindVertexBuffers2EXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthTestEnable */
            void> vkCmdSetDepthTestEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthWriteEnable */
            void> vkCmdSetDepthWriteEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkCompareOp,     /* depthCompareOp */
            void> vkCmdSetDepthCompareOpEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthBoundsTestEnable */
            void> vkCmdSetDepthBoundsTestEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* stencilTestEnable */
            void> vkCmdSetStencilTestEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkStencilFaceFlagBits, /* faceMask */
            VkStencilOp,           /* failOp */
            VkStencilOp,           /* passOp */
            VkStencilOp,           /* depthFailOp */
            VkCompareOp,           /* compareOp */
            void> vkCmdSetStencilOpEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                     /* device */
            VkGeneratedCommandsMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2*,                       /* pMemoryRequirements */
            void> vkGetGeneratedCommandsMemoryRequirementsNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> vkCmdPreprocessGeneratedCommandsNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* isPreprocessed */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> vkCmdExecuteGeneratedCommandsNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkPipelineBindPoint, /* pipelineBindPoint */
            VkPipeline,          /* pipeline */
            uint,                /* groupIndex */
            void> vkCmdBindPipelineShaderGroupNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                              /* device */
            VkIndirectCommandsLayoutCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkIndirectCommandsLayoutNV*,           /* pIndirectCommandsLayout */
            VkResult> vkCreateIndirectCommandsLayoutNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkIndirectCommandsLayoutNV, /* indirectCommandsLayout */
            VkAllocationCallbacks*,     /* pAllocator */
            void> vkDestroyIndirectCommandsLayoutNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                        /* device */
            VkPrivateDataSlotCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkPrivateDataSlotEXT*,           /* pPrivateDataSlot */
            VkResult> vkCreatePrivateDataSlotEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkPrivateDataSlotEXT,   /* privateDataSlot */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyPrivateDataSlotEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong,                /* data */
            VkResult> vkSetPrivateDataEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong*,               /* pData */
            void> vkGetPrivateDataEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkFragmentShadingRateNV,            /* shadingRate */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps1 */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps2 */
            void> vkCmdSetFragmentShadingRateEnumNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            VkDisplayKHR,     /* display */
            VkResult> vkAcquireWinrtDisplayNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint,             /* deviceRelativeId */
            VkDisplayKHR*,    /* pDisplay */
            VkResult> vkGetWinrtDisplayNV;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                        /* commandBuffer */
            uint,                                   /* vertexBindingDescriptionCount */
            VkVertexInputBindingDescription2EXT*,   /* pVertexBindingDescriptions */
            uint,                                   /* vertexAttributeDescriptionCount */
            VkVertexInputAttributeDescription2EXT*, /* pVertexAttributeDescriptions */
            void> vkCmdSetVertexInputEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* attachmentCount */
            VkBool32*,       /* pColorWriteEnables */
            void> vkCmdSetColorWriteEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                              /* device */
            VkAccelerationStructureCreateInfoKHR*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkAccelerationStructureKHR*,           /* pAccelerationStructure */
            VkResult> vkCreateAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkAccelerationStructureKHR, /* accelerationStructure */
            VkAllocationCallbacks*,     /* pAllocator */
            void> vkDestroyAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                              /* commandBuffer */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkAccelerationStructureBuildRangeInfoKHR**,   /* ppBuildRangeInfos */
            void> vkCmdBuildAccelerationStructuresKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                              /* commandBuffer */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkDeviceAddress*,                             /* pIndirectDeviceAddresses */
            uint*,                                        /* pIndirectStrides */
            uint**,                                       /* ppMaxPrimitiveCounts */
            void> vkCmdBuildAccelerationStructuresIndirectKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                     /* device */
            VkDeferredOperationKHR,                       /* deferredOperation */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkAccelerationStructureBuildRangeInfoKHR**,   /* ppBuildRangeInfos */
            VkResult> vkBuildAccelerationStructuresKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                            /* device */
            VkDeferredOperationKHR,              /* deferredOperation */
            VkCopyAccelerationStructureInfoKHR*, /* pInfo */
            VkResult> vkCopyAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                    /* device */
            VkDeferredOperationKHR,                      /* deferredOperation */
            VkCopyAccelerationStructureToMemoryInfoKHR*, /* nfo */
            VkResult> vkCopyAccelerationStructureToMemoryKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                    /* device */
            VkDeferredOperationKHR,                      /* deferredOperation */
            VkCopyMemoryToAccelerationStructureInfoKHR*, /* pInfo */
            VkResult> vkCopyMemoryToAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                    /* device */
            uint,                        /* accelerationStructureCount */
            VkAccelerationStructureKHR*, /* pAccelerationStructures */
            VkQueryType,                 /* queryType */
            nuint,                       /* dataSize */
            void*,                       /* pData */
            nuint,                       /* stride */
            VkResult> vkWriteAccelerationStructuresPropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkCopyAccelerationStructureInfoKHR*, /* pInfo */
            void> vkCmdCopyAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                             /* commandBuffer */
            VkCopyAccelerationStructureToMemoryInfoKHR*, /* pInfo */
            void> vkCmdCopyAccelerationStructureToMemoryKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                             /* commandBuffer */
            VkCopyMemoryToAccelerationStructureInfoKHR*, /* pInfo */
            void> vkCmdCopyMemoryToAccelerationStructureKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                     /* device */
            VkAccelerationStructureDeviceAddressInfoKHR*, /* pInfo */
            VkDeviceAddress> vkGetAccelerationStructureDeviceAddressKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            uint,                        /* accelerationStructureCount */
            VkAccelerationStructureKHR*, /* pAccelerationStructures */
            VkQueryType,                 /* queryType */
            VkQueryPool,                 /* queryPool */
            uint,                        /* firstQuery */
            void> vkCmdWriteAccelerationStructuresPropertiesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                 /* device */
            VkAccelerationStructureVersionInfoKHR*,   /* pVersionInfo */
            VkAccelerationStructureCompatibilityKHR*, /* pCompatibility */
            void> vkGetDeviceAccelerationStructureCompatibilityKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                                     /* device */
            VkAccelerationStructureBuildTypeKHR,          /* buildType */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pBuildInfo */
            uint*,                                        /* pMaxPrimitiveCounts */
            VkAccelerationStructureBuildSizesInfoKHR*,    /* pSizeInfo */
            void> vkGetAccelerationStructureBuildSizesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                  /* commandBuffer */
            VkStridedDeviceAddressRegionKHR*, /* pRaygenShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pMissShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pHitShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pCallableShaderBindingTable */
            uint,                             /* width */
            uint,                             /* height */
            uint,                             /* depth */
            void> vkCmdTraceRaysKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                           /* device */
            VkDeferredOperationKHR,             /* deferredOperation */
            VkPipelineCache,                    /* pipelineCache */
            uint,                               /* createInfoCount */
            VkRayTracingPipelineCreateInfoKHR*, /* pCreateInfos */
            VkAllocationCallbacks*,             /* pAllocator */
            VkPipeline*,                        /* pPipelines */
            VkResult> vkCreateRayTracingPipelinesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,                  /* commandBuffer */
            VkStridedDeviceAddressRegionKHR*, /* pRaygenShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pMissShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pHitShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pCallableShaderBindingTable */
            VkDeviceAddress,                  /* indirectDeviceAddress */
            void> vkCmdTraceRaysIndirectKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkPipeline,             /* pipeline */
            uint,                   /* group */
            VkShaderGroupShaderKHR, /* groupShader */
            VkDeviceSize> vkGetRayTracingShaderGroupStackSizeKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* pipelineStackSize */
            void> vkCmdSetRayTracingPipelineStackSizeKHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkEvent,              /* event */
            VkDependencyInfoKHR*, /* pDependencyInfo */
            void> vkCmdSetEvent2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkEvent,                     /* event */
            VkPipelineStageFlagBits2KHR, /* stageMask */
            void> vkCmdResetEvent2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            uint,                 /* eventCount */
            VkEvent*,             /* pEvents */
            VkDependencyInfoKHR*, /* pDependencyInfos*/
            void> vkCmdWaitEvents2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkDependencyInfoKHR*, /* pDependencyInfo */
            void> vkCmdPipelineBarrier2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkPipelineStageFlagBits2KHR, /* stage */
            VkQueryPool,                 /* queryPool */
            uint,                        /* query */
            void> vkCmdWriteTimestamp2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,           /* queue */
            uint,              /* submitCount */
            VkSubmitInfo2KHR*, /* pSubmits */
            VkFence,           /* fence */
            VkResult> vkQueueSubmit2KHR;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer*/
            VkPipelineStageFlagBits2KHR, /* stage */
            VkBuffer,                    /* dstBuffer */
            VkDeviceSize,                /* dstOffset */
            uint,                        /* marker */
            void> vkCmdWriteBufferMarker2AMD;

        [FieldOffset(0)]
        public readonly delegate*<
            VkQueue,              /* queue */
            uint*,                /* pCheckpointDataCount */
            VkCheckpointData2NV*, /* pCheckpointData */
            void> vkGetQueueCheckpointData2NV;

        public static implicit operator VkFunction(void* ptr)
        {
            VkFunction value;
            *(void**)&value = ptr;
            return value;
        }

        public static implicit operator void*(VkFunction vkFunc)
        {
            return vkFunc._ptr;
        }

        public static implicit operator IntPtr(VkFunction vkFunc)
        {
            return (IntPtr)vkFunc._ptr;
        }

        public static bool operator ==(VkFunction left, VkFunction right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkFunction left, VkFunction right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkFunction obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkFunction vkFunction && Equals(in vkFunction);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFeatures2KHR
    {
        public static readonly VkGetPhysicalDeviceFeatures2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkPhysicalDeviceFeatures2*, /* pFeatures */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceFeatures2KHR(void* ptr)
        {
            VkGetPhysicalDeviceFeatures2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,             /* physicalDevice */
            VkPhysicalDeviceProperties2*, /* pProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFormatProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceFormatProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,     /* physicalDevice */
            VkFormat,             /* format */
            VkFormatProperties2*, /* pFormatProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceFormatProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceFormatProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceImageFormatProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceImageFormatProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                  /* physicalDevice */
            VkPhysicalDeviceImageFormatInfo2*, /* pImageFormatInfo */
            VkImageFormatProperties2*,         /* pImageFormatProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceImageFormatProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceImageFormatProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceQueueFamilyProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,          /* physicalDevice */
            uint*,                     /* pQueueFamilyPropertyCount */
            VkQueueFamilyProperties2*, /* pQueueFamilyProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceQueueFamilyProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceQueueFamilyProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMemoryProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceMemoryProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkPhysicalDeviceMemoryProperties2*, /* pMemoryProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceMemoryProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceMemoryProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSparseImageFormatProperties2KHR
    {
        public static readonly VkGetPhysicalDeviceSparseImageFormatProperties2KHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            VkPhysicalDeviceSparseImageFormatInfo2*, /* pFormatInfo */
            uint*,                                   /* pPropertyCount */
            VkSparseImageFormatProperties2*,         /* pProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceSparseImageFormatProperties2KHR(void* ptr)
        {
            VkGetPhysicalDeviceSparseImageFormatProperties2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDeviceGroupPeerMemoryFeaturesKHR
    {
        public static readonly VkGetDeviceGroupPeerMemoryFeaturesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                     /* device */
            uint,                         /* heapIndex */
            uint,                         /* localDeviceIndex */
            uint,                         /* remoteDeviceIndex */
            VkPeerMemoryFeatureFlagBits*, /* pPeerMemoryFeatures */
            void> UnsafeInvoke;

        public static implicit operator VkGetDeviceGroupPeerMemoryFeaturesKHR(void* ptr)
        {
            VkGetDeviceGroupPeerMemoryFeaturesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDeviceMaskKHR
    {
        public static readonly VkCmdSetDeviceMaskKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* deviceMask */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDeviceMaskKHR(void* ptr)
        {
            VkCmdSetDeviceMaskKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDispatchBaseKHR
    {
        public static readonly VkCmdDispatchBaseKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* baseGroupX */
            uint,            /* baseGroupY */
            uint,            /* baseGroupZ */
            uint,            /* groupCountX */
            uint,            /* groupCountY */
            uint,            /* groupCountZ */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDispatchBaseKHR(void* ptr)
        {
            VkCmdDispatchBaseKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkTrimCommandPoolKHR
    {
        public static readonly VkTrimCommandPoolKHR Zero = null;

        public readonly delegate*<
            VkDevice,                  /* device */
            VkCommandPool,             /* commandPool */
            VkCommandPoolTrimFlagBits, /* FlagBits */
            void> UnsafeInvoke;

        public static implicit operator VkTrimCommandPoolKHR(void* ptr)
        {
            VkTrimCommandPoolKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceGroupsKHR
    {
        public static readonly VkEnumeratePhysicalDeviceGroupsKHR Zero = null;

        public readonly delegate*<
            VkInstance,                       /* instance */
            uint*,                            /* pPhysicalDeviceGroupCount */
            VkPhysicalDeviceGroupProperties*, /* pPhysicalDeviceGroupProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkEnumeratePhysicalDeviceGroupsKHR(void* ptr)
        {
            VkEnumeratePhysicalDeviceGroupsKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalBufferPropertiesKHR
    {
        public static readonly VkGetPhysicalDeviceExternalBufferPropertiesKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                    /* physicalDevice */
            VkPhysicalDeviceExternalBufferInfo*, /* pExternalBufferInfo */
            VkExternalBufferProperties*,         /* pExternalBufferProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceExternalBufferPropertiesKHR(void* ptr)
        {
            VkGetPhysicalDeviceExternalBufferPropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetMemoryFdKHR
    {
        public static readonly VkGetMemoryFdKHR Zero = null;

        public readonly delegate*<
            VkDevice,              /* device */
            VkMemoryGetFdInfoKHR*, /* pGetFdInfo */
            int*,                  /* pFd */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetMemoryFdKHR(void* ptr)
        {
            VkGetMemoryFdKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetMemoryFdPropertiesKHR
    {
        public static readonly VkGetMemoryFdPropertiesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            int,                                /* fd */
            VkMemoryFdPropertiesKHR*,           /* pMemoryFdProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetMemoryFdPropertiesKHR(void* ptr)
        {
            VkGetMemoryFdPropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalSemaphorePropertiesKHR
    {
        public static readonly VkGetPhysicalDeviceExternalSemaphorePropertiesKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                       /* physicalDevice */
            VkPhysicalDeviceExternalSemaphoreInfo*, /* pExternalSemaphoreInfo */
            VkExternalSemaphoreProperties*,         /* pExternalSemaphoreProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceExternalSemaphorePropertiesKHR(void* ptr)
        {
            VkGetPhysicalDeviceExternalSemaphorePropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkImportSemaphoreFdKHR
    {
        public static readonly VkImportSemaphoreFdKHR Zero = null;

        public readonly delegate*<
            VkDevice,                    /* device */
            VkImportSemaphoreFdInfoKHR*, /* pImportSemaphoreFdInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkImportSemaphoreFdKHR(void* ptr)
        {
            VkImportSemaphoreFdKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetSemaphoreFdKHR
    {
        public static readonly VkGetSemaphoreFdKHR Zero = null;

        public readonly delegate*<
            VkDevice,                 /* device */
            VkSemaphoreGetFdInfoKHR*, /* pGetFdInfo */
            int*,                     /* pFd */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetSemaphoreFdKHR(void* ptr)
        {
            VkGetSemaphoreFdKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetKHR
    {
        public static readonly VkCmdPushDescriptorSetKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkPipelineBindPoint,   /* pipelineBindPoint */
            VkPipelineLayout,      /* layout */
            uint,                  /* set */
            uint,                  /* descriptorWriteCount */
            VkWriteDescriptorSet*, /* pDescriptorWrites */
            void> UnsafeInvoke;

        public static implicit operator VkCmdPushDescriptorSetKHR(void* ptr)
        {
            VkCmdPushDescriptorSetKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdPushDescriptorSetWithTemplateKHR
    {
        public static readonly VkCmdPushDescriptorSetWithTemplateKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            VkPipelineLayout,           /* layout */
            uint,                       /* set */
            void*,                      /* pData */
            void> UnsafeInvoke;

        public static implicit operator VkCmdPushDescriptorSetWithTemplateKHR(void* ptr)
        {
            VkCmdPushDescriptorSetWithTemplateKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateDescriptorUpdateTemplateKHR
    {
        public static readonly VkCreateDescriptorUpdateTemplateKHR Zero = null;

        public readonly delegate*<
            VkDevice,                              /* device */
            VkDescriptorUpdateTemplateCreateInfo*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkDescriptorUpdateTemplate*,           /* pDescriptorUpdateTemplate */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDescriptorUpdateTemplateKHR(void* ptr)
        {
            VkCreateDescriptorUpdateTemplateKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDescriptorUpdateTemplateKHR
    {
        public static readonly VkDestroyDescriptorUpdateTemplateKHR Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            VkAllocationCallbacks*,     /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDescriptorUpdateTemplateKHR(void* ptr)
        {
            VkDestroyDescriptorUpdateTemplateKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkUpdateDescriptorSetWithTemplateKHR
    {
        public static readonly VkUpdateDescriptorSetWithTemplateKHR Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkDescriptorSet,            /* descriptorSet */
            VkDescriptorUpdateTemplate, /* descriptorUpdateTemplate */
            void*,                      /* pData */
            void> UnsafeInvoke;

        public static implicit operator VkUpdateDescriptorSetWithTemplateKHR(void* ptr)
        {
            VkUpdateDescriptorSetWithTemplateKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateRenderPass2KHR
    {
        public static readonly VkCreateRenderPass2KHR Zero = null;

        public readonly delegate*<
            VkDevice,                 /* device */
            VkRenderPassCreateInfo2*, /* pCreateInfo */
            VkAllocationCallbacks*,   /* pAllocator */
            VkRenderPass*,            /* pRenderPass */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateRenderPass2KHR(void* ptr)
        {
            VkCreateRenderPass2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginRenderPass2KHR
    {
        public static readonly VkCmdBeginRenderPass2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,        /* commandBuffer */
            VkRenderPassBeginInfo*, /* pRenderPassBegin */
            VkSubpassBeginInfo*,    /* pSubpassBeginInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginRenderPass2KHR(void* ptr)
        {
            VkCmdBeginRenderPass2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdNextSubpass2KHR
    {
        public static readonly VkCmdNextSubpass2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkSubpassBeginInfo*, /* pSubpassBeginInfo */
            VkSubpassEndInfo*,   /* pSubpassEndInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdNextSubpass2KHR(void* ptr)
        {
            VkCmdNextSubpass2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndRenderPass2KHR
    {
        public static readonly VkCmdEndRenderPass2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,   /* commandBuffer */
            VkSubpassEndInfo*, /* pSubpassEndInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndRenderPass2KHR(void* ptr)
        {
            VkCmdEndRenderPass2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetSwapchainStatusKHR
    {
        public static readonly VkGetSwapchainStatusKHR Zero = null;

        public readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapchain */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetSwapchainStatusKHR(void* ptr)
        {
            VkGetSwapchainStatusKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalFencePropertiesKHR
    {
        public static readonly VkGetPhysicalDeviceExternalFencePropertiesKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkPhysicalDeviceExternalFenceInfo*, /* pExternalFenceInfo */
            VkExternalFenceProperties*,         /* pExternalFenceProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceExternalFencePropertiesKHR(void* ptr)
        {
            VkGetPhysicalDeviceExternalFencePropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkImportFenceFdKHR
    {
        public static readonly VkImportFenceFdKHR Zero = null;

        public readonly delegate*<
            VkDevice,                /* device */
            VkImportFenceFdInfoKHR*, /* pImportFenceFdInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkImportFenceFdKHR(void* ptr)
        {
            VkImportFenceFdKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetFenceFdKHR
    {
        public static readonly VkGetFenceFdKHR Zero = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkFenceGetFdInfoKHR*, /* pGetFdInfo */
            int*,                 /* pFd */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetFenceFdKHR(void* ptr)
        {
            VkGetFenceFdKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR
    {
        public static readonly VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                    /* physicalDevice */
            uint,                                /* queueFamilyIndex */
            uint*,                               /* pCounterCount */
            VkPerformanceCounterKHR*,            /* pCounters */
            VkPerformanceCounterDescriptionKHR*, /* pCounterDescriptions */
            VkResult> UnsafeInvoke;

        public static implicit operator VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(void* ptr)
        {
            VkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR
    {
        public static readonly VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                     /* physicalDevice */
            VkQueryPoolPerformanceCreateInfoKHR*, /* pPerformanceQueryCreateInfo */
            uint*,                                /* pNumPasses */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(void* ptr)
        {
            VkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkAcquireProfilingLockKHR
    {
        public static readonly VkAcquireProfilingLockKHR Zero = null;

        public readonly delegate*<
            VkDevice,                       /* device */
            VkAcquireProfilingLockInfoKHR*, /* pInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkAcquireProfilingLockKHR(void* ptr)
        {
            VkAcquireProfilingLockKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkReleaseProfilingLockKHR
    {
        public static readonly VkReleaseProfilingLockKHR Zero = null;

        public readonly delegate*<
            VkDevice, /* device */
            void> UnsafeInvoke;

        public static implicit operator VkReleaseProfilingLockKHR(void* ptr)
        {
            VkReleaseProfilingLockKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetImageMemoryRequirements2KHR
    {
        public static readonly VkGetImageMemoryRequirements2KHR Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkImageMemoryRequirementsInfo2*, /* pInfo */
            VkMemoryRequirements2*,          /* pMemoryRequirements */
            void> UnsafeInvoke;

        public static implicit operator VkGetImageMemoryRequirements2KHR(void* ptr)
        {
            VkGetImageMemoryRequirements2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetBufferMemoryRequirements2KHR
    {
        public static readonly VkGetBufferMemoryRequirements2KHR Zero = null;

        public readonly delegate*<
            VkDevice,                         /* device */
            VkBufferMemoryRequirementsInfo2*, /* pInfo */
            VkMemoryRequirements2*,           /* pMemoryRequirements */
            void> UnsafeInvoke;

        public static implicit operator VkGetBufferMemoryRequirements2KHR(void* ptr)
        {
            VkGetBufferMemoryRequirements2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetImageSparseMemoryRequirements2KHR
    {
        public static readonly VkGetImageSparseMemoryRequirements2KHR Zero = null;

        public readonly delegate*<
            VkDevice,                              /* device */
            VkImageSparseMemoryRequirementsInfo2*, /* pInfo */
            uint*,                                 /* pSparseMemoryRequirementCount */
            VkSparseImageMemoryRequirements2*,     /* pSparseMemoryRequirements */
            void> UnsafeInvoke;

        public static implicit operator VkGetImageSparseMemoryRequirements2KHR(void* ptr)
        {
            VkGetImageSparseMemoryRequirements2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateSamplerYcbcrConversionKHR
    {
        public static readonly VkCreateSamplerYcbcrConversionKHR Zero = null;

        public readonly delegate*<
            VkDevice,                            /* device */
            VkSamplerYcbcrConversionCreateInfo*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkSamplerYcbcrConversion*,           /* pYcbcrConversion */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateSamplerYcbcrConversionKHR(void* ptr)
        {
            VkCreateSamplerYcbcrConversionKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroySamplerYcbcrConversionKHR
    {
        public static readonly VkDestroySamplerYcbcrConversionKHR Zero = null;

        public readonly delegate*<
            VkDevice,                 /* device */
            VkSamplerYcbcrConversion, /* ycbcrConversion */
            VkAllocationCallbacks*,   /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroySamplerYcbcrConversionKHR(void* ptr)
        {
            VkDestroySamplerYcbcrConversionKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkBindBufferMemory2KHR
    {
        public static readonly VkBindBufferMemory2KHR Zero = null;

        public readonly delegate*<
            VkDevice,                /* device */
            uint,                    /* bindInfoCount */
            VkBindBufferMemoryInfo*, /* pBindInfos */
            VkResult> UnsafeInvoke;

        public static implicit operator VkBindBufferMemory2KHR(void* ptr)
        {
            VkBindBufferMemory2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkBindImageMemory2KHR
    {
        public static readonly VkBindImageMemory2KHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            uint,                   /* bindInfoCount */
            VkBindImageMemoryInfo*, /* pBindInfos */
            VkResult> UnsafeInvoke;

        public static implicit operator VkBindImageMemory2KHR(void* ptr)
        {
            VkBindImageMemory2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDescriptorSetLayoutSupportKHR
    {
        public static readonly VkGetDescriptorSetLayoutSupportKHR Zero = null;

        public readonly delegate*<
            VkDevice,                         /* device */
            VkDescriptorSetLayoutCreateInfo*, /* pCreateInfo */
            VkDescriptorSetLayoutSupport*,    /* pSupport */
            void> UnsafeInvoke;

        public static implicit operator VkGetDescriptorSetLayoutSupportKHR(void* ptr)
        {
            VkGetDescriptorSetLayoutSupportKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCountKHR
    {
        public static readonly VkCmdDrawIndirectCountKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawIndirectCountKHR(void* ptr)
        {
            VkCmdDrawIndirectCountKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCountKHR
    {
        public static readonly VkCmdDrawIndexedIndirectCountKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawIndexedIndirectCountKHR(void* ptr)
        {
            VkCmdDrawIndexedIndirectCountKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetSemaphoreCounterValueKHR
    {
        public static readonly VkGetSemaphoreCounterValueKHR Zero = null;

        public readonly delegate*<
            VkDevice,    /* device */
            VkSemaphore, /* semaphore */
            ulong*,      /* pValue */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetSemaphoreCounterValueKHR(void* ptr)
        {
            VkGetSemaphoreCounterValueKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkWaitSemaphoresKHR
    {
        public static readonly VkWaitSemaphoresKHR Zero = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkSemaphoreWaitInfo*, /* pWaitInfo */
            ulong,                /* timeout */
            VkResult> UnsafeInvoke;

        public static implicit operator VkWaitSemaphoresKHR(void* ptr)
        {
            VkWaitSemaphoresKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSignalSemaphoreKHR
    {
        public static readonly VkSignalSemaphoreKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkSemaphoreSignalInfo*, /* pSignalInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSignalSemaphoreKHR(void* ptr)
        {
            VkSignalSemaphoreKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceFragmentShadingRatesKHR
    {
        public static readonly VkGetPhysicalDeviceFragmentShadingRatesKHR Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            uint*,                                   /* pFragmentShadingRateCount */
            VkPhysicalDeviceFragmentShadingRateKHR*, /* pFragmentShadingRates */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceFragmentShadingRatesKHR(void* ptr)
        {
            VkGetPhysicalDeviceFragmentShadingRatesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetFragmentShadingRateKHR
    {
        public static readonly VkCmdSetFragmentShadingRateKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkExtent2D*,                        /* pFragmentSize */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps1 */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps2 */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetFragmentShadingRateKHR(void* ptr)
        {
            VkCmdSetFragmentShadingRateKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetBufferDeviceAddressKHR
    {
        public static readonly VkGetBufferDeviceAddressKHR Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            VkDeviceAddress> UnsafeInvoke;

        public static implicit operator VkGetBufferDeviceAddressKHR(void* ptr)
        {
            VkGetBufferDeviceAddressKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetBufferOpaqueCaptureAddressKHR
    {
        public static readonly VkGetBufferOpaqueCaptureAddressKHR Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            ulong> UnsafeInvoke;

        public static implicit operator VkGetBufferOpaqueCaptureAddressKHR(void* ptr)
        {
            VkGetBufferOpaqueCaptureAddressKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDeviceMemoryOpaqueCaptureAddressKHR
    {
        public static readonly VkGetDeviceMemoryOpaqueCaptureAddressKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                /* device */
            VkDeviceMemoryOpaqueCaptureAddressInfo*, /* pInfo */
            ulong> UnsafeInvoke;

        public static implicit operator VkGetDeviceMemoryOpaqueCaptureAddressKHR(void* ptr)
        {
            VkGetDeviceMemoryOpaqueCaptureAddressKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateDeferredOperationKHR
    {
        public static readonly VkCreateDeferredOperationKHR Zero = null;

        public readonly delegate*<
            VkDevice,                /* device */
            VkAllocationCallbacks*,  /* pAllocator */
            VkDeferredOperationKHR*, /* pDeferredOperation */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDeferredOperationKHR(void* ptr)
        {
            VkCreateDeferredOperationKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDeferredOperationKHR
    {
        public static readonly VkDestroyDeferredOperationKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkAllocationCallbacks*, /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDeferredOperationKHR(void* ptr)
        {
            VkDestroyDeferredOperationKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDeferredOperationMaxConcurrencyKHR
    {
        public static readonly VkGetDeferredOperationMaxConcurrencyKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            uint> UnsafeInvoke;

        public static implicit operator VkGetDeferredOperationMaxConcurrencyKHR(void* ptr)
        {
            VkGetDeferredOperationMaxConcurrencyKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDeferredOperationResultKHR
    {
        public static readonly VkGetDeferredOperationResultKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetDeferredOperationResultKHR(void* ptr)
        {
            VkGetDeferredOperationResultKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDeferredOperationJoinKHR
    {
        public static readonly VkDeferredOperationJoinKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeferredOperationKHR, /* operation */
            VkResult> UnsafeInvoke;

        public static implicit operator VkDeferredOperationJoinKHR(void* ptr)
        {
            VkDeferredOperationJoinKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPipelineExecutablePropertiesKHR
    {
        public static readonly VkGetPipelineExecutablePropertiesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                           /* device */
            VkPipelineInfoKHR*,                 /* pPipelineInfo */
            uint*,                              /* pExecutableCount */
            VkPipelineExecutablePropertiesKHR*, /* pProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPipelineExecutablePropertiesKHR(void* ptr)
        {
            VkGetPipelineExecutablePropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPipelineExecutableStatisticsKHR
    {
        public static readonly VkGetPipelineExecutableStatisticsKHR Zero = null;

        public readonly delegate*<
            VkDevice,                          /* device */
            VkPipelineExecutableInfoKHR*,      /* pExecutableInfo */
            uint*,                             /* pStatisticCount */
            VkPipelineExecutableStatisticKHR*, /* pStatistics */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPipelineExecutableStatisticsKHR(void* ptr)
        {
            VkGetPipelineExecutableStatisticsKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPipelineExecutableInternalRepresentationsKHR
    {
        public static readonly VkGetPipelineExecutableInternalRepresentationsKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                       /* device */
            VkPipelineExecutableInfoKHR*,                   /* pExecutableInfo */
            uint*,                                          /* pInternalRepresentationCount */
            VkPipelineExecutableInternalRepresentationKHR*, /* pInternalRepresentations */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPipelineExecutableInternalRepresentationsKHR(void* ptr)
        {
            VkGetPipelineExecutableInternalRepresentationsKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyBuffer2KHR
    {
        public static readonly VkCmdCopyBuffer2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkCopyBufferInfo2KHR*, /* pCopyBufferInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyBuffer2KHR(void* ptr)
        {
            VkCmdCopyBuffer2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyImage2KHR
    {
        public static readonly VkCmdCopyImage2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkCopyImageInfo2KHR*, /* pCopyImageInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyImage2KHR(void* ptr)
        {
            VkCmdCopyImage2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyBufferToImage2KHR
    {
        public static readonly VkCmdCopyBufferToImage2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCopyBufferToImageInfo2KHR*, /* pCopyBufferToImageInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyBufferToImage2KHR(void* ptr)
        {
            VkCmdCopyBufferToImage2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyImageToBuffer2KHR
    {
        public static readonly VkCmdCopyImageToBuffer2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCopyImageToBufferInfo2KHR*, /* pCopyImageToBufferInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyImageToBuffer2KHR(void* ptr)
        {
            VkCmdCopyImageToBuffer2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBlitImage2KHR
    {
        public static readonly VkCmdBlitImage2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkBlitImageInfo2KHR*, /* pBlitImageInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBlitImage2KHR(void* ptr)
        {
            VkCmdBlitImage2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdResolveImage2KHR
    {
        public static readonly VkCmdResolveImage2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            VkResolveImageInfo2KHR*, /* pResolveImageInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdResolveImage2KHR(void* ptr)
        {
            VkCmdResolveImage2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateDebugReportCallbackEXT
    {
        public static readonly VkCreateDebugReportCallbackEXT Zero = null;

        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugReportCallbackCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugReportCallbackEXT*,           /* pCallback */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDebugReportCallbackEXT(void* ptr)
        {
            VkCreateDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDebugReportCallbackEXT
    {
        public static readonly VkDestroyDebugReportCallbackEXT Zero = null;

        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugReportCallbackEXT, /* callback */
            VkAllocationCallbacks*,   /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDebugReportCallbackEXT(void* ptr)
        {
            VkDestroyDebugReportCallbackEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDebugReportMessageEXT
    {
        public static readonly VkDebugReportMessageEXT Zero = null;

        public readonly delegate*<
            VkInstance,                 /* instance */
            VkDebugReportFlagsEXT,      /* FlagBits */
            VkDebugReportObjectTypeEXT, /* objectType */
            ulong,                      /* @object */
            nuint,                      /* location */
            int,                        /* messageCode */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage */
            void> UnsafeInvoke;

        public static implicit operator VkDebugReportMessageEXT(void* ptr)
        {
            VkDebugReportMessageEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDebugMarkerSetObjectTagEXT
    {
        public static readonly VkDebugMarkerSetObjectTagEXT Zero = null;

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
        public static readonly VkDebugMarkerSetObjectNameEXT Zero = null;

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
        public static readonly VkCmdDebugMarkerBeginEXT Zero = null;

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
        public static readonly VkCmdDebugMarkerEndEXT Zero = null;

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
        public static readonly VkCmdDebugMarkerInsertEXT Zero = null;

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

    public readonly unsafe struct VkCmdBindTransformFeedbackBuffersEXT
    {
        public static readonly VkCmdBindTransformFeedbackBuffersEXT Zero = null;

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
        public static readonly VkCmdBeginTransformFeedbackEXT Zero = null;

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
        public static readonly VkCmdEndTransformFeedbackEXT Zero = null;

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
        public static readonly VkCmdBeginQueryIndexedEXT Zero = null;

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
        public static readonly VkCmdEndQueryIndexedEXT Zero = null;

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
        public static readonly VkCmdDrawIndirectByteCountEXT Zero = null;

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

    public readonly unsafe struct VkGetImageViewHandleNVX
    {
        public static readonly VkGetImageViewHandleNVX Zero = null;

        public readonly delegate*<
            VkDevice,                  /* device */
            VkImageViewHandleInfoNVX*, /* pInfo */
            uint> UnsafeInvoke;

        public static implicit operator VkGetImageViewHandleNVX(void* ptr)
        {
            VkGetImageViewHandleNVX value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetImageViewAddressNVX
    {
        public static readonly VkGetImageViewAddressNVX Zero = null;

        public readonly delegate*<
            VkDevice,                         /* device */
            VkImageView,                      /* imageView */
            VkImageViewAddressPropertiesNVX*, /* pProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetImageViewAddressNVX(void* ptr)
        {
            VkGetImageViewAddressNVX value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawIndirectCountAMD
    {
        public static readonly VkCmdDrawIndirectCountAMD Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawIndirectCountAMD(void* ptr)
        {
            VkCmdDrawIndirectCountAMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawIndexedIndirectCountAMD
    {
        public static readonly VkCmdDrawIndexedIndirectCountAMD Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawIndexedIndirectCountAMD(void* ptr)
        {
            VkCmdDrawIndexedIndirectCountAMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetShaderInfoAMD
    {
        public static readonly VkGetShaderInfoAMD Zero = null;

        public readonly delegate*<
            VkDevice,              /* device */
            VkPipeline,            /* pipeline */
            VkShaderStageFlagBits, /* shaderStage */
            VkShaderInfoTypeAMD,   /* infoType */
            nuint*,                /* pInfoSize */
            void*,                 /* pInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetShaderInfoAMD(void* ptr)
        {
            VkGetShaderInfoAMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceExternalImageFormatPropertiesNV
    {
        public static readonly VkGetPhysicalDeviceExternalImageFormatPropertiesNV Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            VkFormat,                           /* format */
            VkImageType,                        /* type */
            VkImageTiling,                      /* tiling */
            VkImageUsageFlagBits,               /* usage */
            VkImageCreateFlagBits,              /* FlagBits */
            VkExternalMemoryHandleTypeFlagsNV,  /* externalHandleType */
            VkExternalImageFormatPropertiesNV*, /* pExternalImageFormatProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceExternalImageFormatPropertiesNV(void* ptr)
        {
            VkGetPhysicalDeviceExternalImageFormatPropertiesNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginConditionalRenderingEXT
    {
        public static readonly VkCmdBeginConditionalRenderingEXT Zero = null;

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
        public static readonly VkCmdEndConditionalRenderingEXT Zero = null;

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

    public readonly unsafe struct VkCmdSetViewportWScalingNV
    {
        public static readonly VkCmdSetViewportWScalingNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            uint,                  /* firstViewport */
            uint,                  /* viewportCount */
            VkViewportWScalingNV*, /* pViewportWScalings */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetViewportWScalingNV(void* ptr)
        {
            VkCmdSetViewportWScalingNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkReleaseDisplayEXT
    {
        public static readonly VkReleaseDisplayEXT Zero = null;

        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            VkDisplayKHR,     /* display */
            VkResult> UnsafeInvoke;

        public static implicit operator VkReleaseDisplayEXT(void* ptr)
        {
            VkReleaseDisplayEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSurfaceCapabilities2EXT
    {
        public static readonly VkGetPhysicalDeviceSurfaceCapabilities2EXT Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,           /* physicalDevice */
            VkSurfaceKHR,               /* surface */
            VkSurfaceCapabilities2EXT*, /* pSurfaceCapabilities */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceSurfaceCapabilities2EXT(void* ptr)
        {
            VkGetPhysicalDeviceSurfaceCapabilities2EXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDisplayPowerControlEXT
    {
        public static readonly VkDisplayPowerControlEXT Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayPowerInfoEXT*, /* pDisplayPowerInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkDisplayPowerControlEXT(void* ptr)
        {
            VkDisplayPowerControlEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkRegisterDeviceEventEXT
    {
        public static readonly VkRegisterDeviceEventEXT Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDeviceEventInfoEXT*,  /* pDeviceEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> UnsafeInvoke;

        public static implicit operator VkRegisterDeviceEventEXT(void* ptr)
        {
            VkRegisterDeviceEventEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkRegisterDisplayEventEXT
    {
        public static readonly VkRegisterDisplayEventEXT Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkDisplayKHR,           /* display */
            VkDisplayEventInfoEXT*, /* pDisplayEventInfo */
            VkAllocationCallbacks*, /* pAllocator */
            VkFence*,               /* pFence */
            VkResult> UnsafeInvoke;

        public static implicit operator VkRegisterDisplayEventEXT(void* ptr)
        {
            VkRegisterDisplayEventEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetSwapchainCounterEXT
    {
        public static readonly VkGetSwapchainCounterEXT Zero = null;

        public readonly delegate*<
            VkDevice,                 /* device */
            VkSwapchainKHR,           /* swapchain */
            VkSurfaceCounterFlagsEXT, /* counter */
            ulong*,                   /* pCounterValue */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetSwapchainCounterEXT(void* ptr)
        {
            VkGetSwapchainCounterEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetRefreshCycleDurationGOOGLE
    {
        public static readonly VkGetRefreshCycleDurationGOOGLE Zero = null;

        public readonly delegate*<
            VkDevice,                      /* device */
            VkSwapchainKHR,                /* swapchain */
            VkRefreshCycleDurationGOOGLE*, /* pDisplayTimingProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetRefreshCycleDurationGOOGLE(void* ptr)
        {
            VkGetRefreshCycleDurationGOOGLE value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPastPresentationTimingGOOGLE
    {
        public static readonly VkGetPastPresentationTimingGOOGLE Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkSwapchainKHR,                  /* swapchain */
            uint*,                           /* pPresentationTimingCount */
            VkPastPresentationTimingGOOGLE*, /* pPresentationTimings */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPastPresentationTimingGOOGLE(void* ptr)
        {
            VkGetPastPresentationTimingGOOGLE value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDiscardRectangleEXT
    {
        public static readonly VkCmdSetDiscardRectangleEXT Zero = null;

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

    public readonly unsafe struct VkSetHdrMetadataEXT
    {
        public static readonly VkSetHdrMetadataEXT Zero = null;

        public readonly delegate*<
            VkDevice,          /* device */
            uint,              /* swapchainCount */
            VkSwapchainKHR*,   /* pSwapchains */
            VkHdrMetadataEXT*, /* pMetadata */
            void> UnsafeInvoke;

        public static implicit operator VkSetHdrMetadataEXT(void* ptr)
        {
            VkSetHdrMetadataEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSetDebugUtilsObjectNameEXT
    {
        public static readonly VkSetDebugUtilsObjectNameEXT Zero = null;

        public readonly delegate*<
            VkDevice,                       /* device */
            VkDebugUtilsObjectNameInfoEXT*, /* pNameInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSetDebugUtilsObjectNameEXT(void* ptr)
        {
            VkSetDebugUtilsObjectNameEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSetDebugUtilsObjectTagEXT
    {
        public static readonly VkSetDebugUtilsObjectTagEXT Zero = null;

        public readonly delegate*<
            VkDevice,                      /* device */
            VkDebugUtilsObjectTagInfoEXT*, /* pTagInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSetDebugUtilsObjectTagEXT(void* ptr)
        {
            VkSetDebugUtilsObjectTagEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueBeginDebugUtilsLabelEXT
    {
        public static readonly VkQueueBeginDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkQueueBeginDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueBeginDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueEndDebugUtilsLabelEXT
    {
        public static readonly VkQueueEndDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkQueue, /* queue */
            void> UnsafeInvoke;

        public static implicit operator VkQueueEndDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueEndDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueInsertDebugUtilsLabelEXT
    {
        public static readonly VkQueueInsertDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkQueueInsertDebugUtilsLabelEXT(void* ptr)
        {
            VkQueueInsertDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBeginDebugUtilsLabelEXT
    {
        public static readonly VkCmdBeginDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBeginDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdBeginDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdEndDebugUtilsLabelEXT
    {
        public static readonly VkCmdEndDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> UnsafeInvoke;

        public static implicit operator VkCmdEndDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdEndDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdInsertDebugUtilsLabelEXT
    {
        public static readonly VkCmdInsertDebugUtilsLabelEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdInsertDebugUtilsLabelEXT(void* ptr)
        {
            VkCmdInsertDebugUtilsLabelEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateDebugUtilsMessengerEXT
    {
        public static readonly VkCreateDebugUtilsMessengerEXT Zero = null;

        public readonly delegate*<
            VkInstance,                          /* instance */
            VkDebugUtilsMessengerCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugUtilsMessengerEXT*,           /* pMessenger */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateDebugUtilsMessengerEXT(void* ptr)
        {
            VkCreateDebugUtilsMessengerEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyDebugUtilsMessengerEXT
    {
        public static readonly VkDestroyDebugUtilsMessengerEXT Zero = null;

        public readonly delegate*<
            VkInstance,               /* instance */
            VkDebugUtilsMessengerEXT, /* messenger */
            VkAllocationCallbacks*,   /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyDebugUtilsMessengerEXT(void* ptr)
        {
            VkDestroyDebugUtilsMessengerEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSubmitDebugUtilsMessageEXT
    {
        public static readonly VkSubmitDebugUtilsMessageEXT Zero = null;

        public readonly delegate*<
            VkInstance,                            /* instance */
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData */
            void> UnsafeInvoke;

        public static implicit operator VkSubmitDebugUtilsMessageEXT(void* ptr)
        {
            VkSubmitDebugUtilsMessageEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetSampleLocationsEXT
    {
        public static readonly VkCmdSetSampleLocationsEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,           /* commandBuffer */
            VkSampleLocationsInfoEXT*, /* pSampleLocationsInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetSampleLocationsEXT(void* ptr)
        {
            VkCmdSetSampleLocationsEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceMultisamplePropertiesEXT
    {
        public static readonly VkGetPhysicalDeviceMultisamplePropertiesEXT Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,            /* physicalDevice */
            VkSampleCountFlagBits,       /* samples */
            VkMultisamplePropertiesEXT*, /* pMultisampleProperties */
            void> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceMultisamplePropertiesEXT(void* ptr)
        {
            VkGetPhysicalDeviceMultisamplePropertiesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetImageDrmFormatModifierPropertiesEXT
    {
        public static readonly VkGetImageDrmFormatModifierPropertiesEXT Zero = null;

        public readonly delegate*<
            VkDevice,                               /* device */
            VkImage,                                /* image */
            VkImageDrmFormatModifierPropertiesEXT*, /* pProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetImageDrmFormatModifierPropertiesEXT(void* ptr)
        {
            VkGetImageDrmFormatModifierPropertiesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateValidationCacheEXT
    {
        public static readonly VkCreateValidationCacheEXT Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkValidationCacheCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkValidationCacheEXT*,           /* pValidationCache */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateValidationCacheEXT(void* ptr)
        {
            VkCreateValidationCacheEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyValidationCacheEXT
    {
        public static readonly VkDestroyValidationCacheEXT Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkValidationCacheEXT,   /* validationCache */
            VkAllocationCallbacks*, /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyValidationCacheEXT(void* ptr)
        {
            VkDestroyValidationCacheEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkMergeValidationCachesEXT
    {
        public static readonly VkMergeValidationCachesEXT Zero = null;

        public readonly delegate*<
            VkDevice,              /* device */
            VkValidationCacheEXT,  /* dstCache */
            uint,                  /* srcCacheCount */
            VkValidationCacheEXT*, /* pSrcCaches */
            VkResult> UnsafeInvoke;

        public static implicit operator VkMergeValidationCachesEXT(void* ptr)
        {
            VkMergeValidationCachesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetValidationCacheDataEXT
    {
        public static readonly VkGetValidationCacheDataEXT Zero = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkValidationCacheEXT, /* validationCache */
            nuint*,               /* pDataSize */
            void*,                /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetValidationCacheDataEXT(void* ptr)
        {
            VkGetValidationCacheDataEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBindShadingRateImageNV
    {
        public static readonly VkCmdBindShadingRateImageNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkImageView,     /* imageView */
            VkImageLayout,   /* imageLayout */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBindShadingRateImageNV(void* ptr)
        {
            VkCmdBindShadingRateImageNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetViewportShadingRatePaletteNV
    {
        public static readonly VkCmdSetViewportShadingRatePaletteNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            uint,                    /* firstViewport */
            uint,                    /* viewportCount */
            VkShadingRatePaletteNV*, /* pShadingRatePalettes */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetViewportShadingRatePaletteNV(void* ptr)
        {
            VkCmdSetViewportShadingRatePaletteNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetCoarseSampleOrderNV
    {
        public static readonly VkCmdSetCoarseSampleOrderNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,              /* commandBuffer */
            VkCoarseSampleOrderTypeNV,    /* sampleOrderType */
            uint,                         /* customSampleOrderCount */
            VkCoarseSampleOrderCustomNV*, /* pCustomSampleOrders */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetCoarseSampleOrderNV(void* ptr)
        {
            VkCmdSetCoarseSampleOrderNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateAccelerationStructureNV
    {
        public static readonly VkCreateAccelerationStructureNV Zero = null;

        public readonly delegate*<
            VkDevice,                             /* device */
            VkAccelerationStructureCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,               /* pAllocator */
            VkAccelerationStructureNV*,           /* pAccelerationStructure */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateAccelerationStructureNV(void* ptr)
        {
            VkCreateAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyAccelerationStructureNV
    {
        public static readonly VkDestroyAccelerationStructureNV Zero = null;

        public readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            VkAllocationCallbacks*,    /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyAccelerationStructureNV(void* ptr)
        {
            VkDestroyAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureMemoryRequirementsNV
    {
        public static readonly VkGetAccelerationStructureMemoryRequirementsNV Zero = null;

        public readonly delegate*<
            VkDevice,                                         /* device */
            VkAccelerationStructureMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2KHR*,                        /* pMemoryRequirements */
            void> UnsafeInvoke;

        public static implicit operator VkGetAccelerationStructureMemoryRequirementsNV(void* ptr)
        {
            VkGetAccelerationStructureMemoryRequirementsNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkBindAccelerationStructureMemoryNV
    {
        public static readonly VkBindAccelerationStructureMemoryNV Zero = null;

        public readonly delegate*<
            VkDevice,                                 /* device */
            uint,                                     /* bindInfoCount */
            VkBindAccelerationStructureMemoryInfoNV*, /* pBindInfos */
            VkResult> UnsafeInvoke;

        public static implicit operator VkBindAccelerationStructureMemoryNV(void* ptr)
        {
            VkBindAccelerationStructureMemoryNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructureNV
    {
        public static readonly VkCmdBuildAccelerationStructureNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                /* commandBuffer */
            VkAccelerationStructureInfoNV*, /* pInfo */
            VkBuffer,                       /* instanceData */
            VkDeviceSize,                   /* instanceOffset */
            uint,                           /* update */
            VkAccelerationStructureNV,      /* dst */
            VkAccelerationStructureNV,      /* src */
            VkBuffer,                       /* scratch */
            VkDeviceSize,                   /* scratchOffset */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBuildAccelerationStructureNV(void* ptr)
        {
            VkCmdBuildAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureNV
    {
        public static readonly VkCmdCopyAccelerationStructureNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkAccelerationStructureNV,          /* dst */
            VkAccelerationStructureNV,          /* src */
            VkCopyAccelerationStructureModeKHR, /* mode */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyAccelerationStructureNV(void* ptr)
        {
            VkCmdCopyAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdTraceRaysNV
    {
        public static readonly VkCmdTraceRaysNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* raygenShaderBindingTableBuffer */
            VkDeviceSize,    /* raygenShaderBindingOffset */
            VkBuffer,        /* missShaderBindingTableBuffer */
            VkDeviceSize,    /* missShaderBindingOffset */
            VkDeviceSize,    /* missShaderBindingStride */
            VkBuffer,        /* hitShaderBindingTableBuffer */
            VkDeviceSize,    /* hitShaderBindingOffset */
            VkDeviceSize,    /* hitShaderBindingStride */
            VkBuffer,        /* callableShaderBindingTableBuffer */
            VkDeviceSize,    /* callableShaderBindingOffset */
            VkDeviceSize,    /* callableShaderBindingStride */
            uint,            /* width */
            uint,            /* height */
            uint,            /* depth */
            void> UnsafeInvoke;

        public static implicit operator VkCmdTraceRaysNV(void* ptr)
        {
            VkCmdTraceRaysNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateRayTracingPipelinesNV
    {
        public static readonly VkCreateRayTracingPipelinesNV Zero = null;

        public readonly delegate*<
            VkDevice,                          /* device */
            VkPipelineCache,                   /* pipelineCache */
            uint,                              /* createInfoCount */
            VkRayTracingPipelineCreateInfoNV*, /* pCreateInfos */
            VkAllocationCallbacks*,            /* pAllocator */
            VkPipeline*,                       /* pPipelines */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateRayTracingPipelinesNV(void* ptr)
        {
            VkCreateRayTracingPipelinesNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupHandlesKHR
    {
        public static readonly VkGetRayTracingShaderGroupHandlesKHR Zero = null;

        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetRayTracingShaderGroupHandlesKHR(void* ptr)
        {
            VkGetRayTracingShaderGroupHandlesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupHandlesNV
    {
        public static readonly VkGetRayTracingShaderGroupHandlesNV Zero = null;

        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetRayTracingShaderGroupHandlesNV(void* ptr)
        {
            VkGetRayTracingShaderGroupHandlesNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureHandleNV
    {
        public static readonly VkGetAccelerationStructureHandleNV Zero = null;

        public readonly delegate*<
            VkDevice,                  /* device */
            VkAccelerationStructureNV, /* accelerationStructure */
            nuint,                     /* dataSize */
            void*,                     /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetAccelerationStructureHandleNV(void* ptr)
        {
            VkGetAccelerationStructureHandleNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWriteAccelerationStructuresPropertiesNV
    {
        public static readonly VkCmdWriteAccelerationStructuresPropertiesNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* accelerationStructureCount */
            VkAccelerationStructureNV*, /* pAccelerationStructures */
            VkQueryType,                /* queryType */
            VkQueryPool,                /* queryPool */
            uint,                       /* firstQuery */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWriteAccelerationStructuresPropertiesNV(void* ptr)
        {
            VkCmdWriteAccelerationStructuresPropertiesNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCompileDeferredNV
    {
        public static readonly VkCompileDeferredNV Zero = null;

        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* shader */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCompileDeferredNV(void* ptr)
        {
            VkCompileDeferredNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetMemoryHostPointerPropertiesEXT
    {
        public static readonly VkGetMemoryHostPointerPropertiesEXT Zero = null;

        public readonly delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            void*,                              /* pHostPointer */
            VkMemoryHostPointerPropertiesEXT*,  /* pMemoryHostPointerProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetMemoryHostPointerPropertiesEXT(void* ptr)
        {
            VkGetMemoryHostPointerPropertiesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWriteBufferMarkerAMD
    {
        public static readonly VkCmdWriteBufferMarkerAMD Zero = null;

        public readonly delegate*<
            VkCommandBuffer,         /* commandBuffer */
            VkPipelineStageFlagBits, /* pipelineStage */
            VkBuffer,                /* dstBuffer */
            VkDeviceSize,            /* dstOffset */
            uint,                    /* marker */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWriteBufferMarkerAMD(void* ptr)
        {
            VkCmdWriteBufferMarkerAMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCalibrateableTimeDomainsEXT
    {
        public static readonly VkGetPhysicalDeviceCalibrateableTimeDomainsEXT Zero = null;

        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint*,            /* pTimeDomainCount */
            VkTimeDomainEXT*, /* pTimeDomains */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceCalibrateableTimeDomainsEXT(void* ptr)
        {
            VkGetPhysicalDeviceCalibrateableTimeDomainsEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetCalibratedTimestampsEXT
    {
        public static readonly VkGetCalibratedTimestampsEXT Zero = null;

        public readonly delegate*<
            VkDevice,                      /* device */
            uint,                          /* timestampCount */
            VkCalibratedTimestampInfoEXT*, /* pTimestampInfos */
            ulong*,                        /* pTimestamps */
            ulong*,                        /* pMaxDeviation */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetCalibratedTimestampsEXT(void* ptr)
        {
            VkGetCalibratedTimestampsEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksNV
    {
        public static readonly VkCmdDrawMeshTasksNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* taskCount */
            uint,            /* firstTask */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawMeshTasksNV(void* ptr)
        {
            VkCmdDrawMeshTasksNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectNV
    {
        public static readonly VkCmdDrawMeshTasksIndirectNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            uint,            /* drawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawMeshTasksIndirectNV(void* ptr)
        {
            VkCmdDrawMeshTasksIndirectNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdDrawMeshTasksIndirectCountNV
    {
        public static readonly VkCmdDrawMeshTasksIndirectCountNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBuffer,        /* buffer */
            VkDeviceSize,    /* offset */
            VkBuffer,        /* countBuffer */
            VkDeviceSize,    /* countBufferOffset */
            uint,            /* maxDrawCount */
            uint,            /* stride */
            void> UnsafeInvoke;

        public static implicit operator VkCmdDrawMeshTasksIndirectCountNV(void* ptr)
        {
            VkCmdDrawMeshTasksIndirectCountNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetExclusiveScissorNV
    {
        public static readonly VkCmdSetExclusiveScissorNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstExclusiveScissor */
            uint,            /* exclusiveScissorCount */
            VkRect2D*,       /* pExclusiveScissors */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetExclusiveScissorNV(void* ptr)
        {
            VkCmdSetExclusiveScissorNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetCheckpointNV
    {
        public static readonly VkCmdSetCheckpointNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void*,           /* pCheckpointMarker */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetCheckpointNV(void* ptr)
        {
            VkCmdSetCheckpointNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetQueueCheckpointDataNV
    {
        public static readonly VkGetQueueCheckpointDataNV Zero = null;

        public readonly delegate*<
            VkQueue,             /* queue */
            uint*,               /* pCheckpointDataCount */
            VkCheckpointDataNV*, /* pCheckpointData */
            void> UnsafeInvoke;

        public static implicit operator VkGetQueueCheckpointDataNV(void* ptr)
        {
            VkGetQueueCheckpointDataNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkInitializePerformanceApiINTEL
    {
        public static readonly VkInitializePerformanceApiINTEL Zero = null;

        public readonly delegate*<
            VkDevice,                             /* device */
            VkInitializePerformanceApiInfoINTEL*, /* pInitializeInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkInitializePerformanceApiINTEL(void* ptr)
        {
            VkInitializePerformanceApiINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkUninitializePerformanceApiINTEL
    {
        public static readonly VkUninitializePerformanceApiINTEL Zero = null;

        public readonly delegate*<
            VkDevice, /* device */
            void> UnsafeInvoke;

        public static implicit operator VkUninitializePerformanceApiINTEL(void* ptr)
        {
            VkUninitializePerformanceApiINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceMarkerINTEL
    {
        public static readonly VkCmdSetPerformanceMarkerINTEL Zero = null;

        public readonly delegate*<
            VkCommandBuffer,               /* commandBuffer */
            VkPerformanceMarkerInfoINTEL*, /* pMarkerInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCmdSetPerformanceMarkerINTEL(void* ptr)
        {
            VkCmdSetPerformanceMarkerINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceStreamMarkerINTEL
    {
        public static readonly VkCmdSetPerformanceStreamMarkerINTEL Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkPerformanceStreamMarkerInfoINTEL*, /* pMarkerInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCmdSetPerformanceStreamMarkerINTEL(void* ptr)
        {
            VkCmdSetPerformanceStreamMarkerINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetPerformanceOverrideINTEL
    {
        public static readonly VkCmdSetPerformanceOverrideINTEL Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                 /* commandBuffer */
            VkPerformanceOverrideInfoINTEL*, /* pOverrideInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCmdSetPerformanceOverrideINTEL(void* ptr)
        {
            VkCmdSetPerformanceOverrideINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkAcquirePerformanceConfigurationINTEL
    {
        public static readonly VkAcquirePerformanceConfigurationINTEL Zero = null;

        public readonly delegate*<
            VkDevice,                                    /* device */
            VkPerformanceConfigurationAcquireInfoINTEL*, /* pAcquireInfo */
            VkPerformanceConfigurationINTEL*,            /* pConfiguration */
            VkResult> UnsafeInvoke;

        public static implicit operator VkAcquirePerformanceConfigurationINTEL(void* ptr)
        {
            VkAcquirePerformanceConfigurationINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkReleasePerformanceConfigurationINTEL
    {
        public static readonly VkReleasePerformanceConfigurationINTEL Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkPerformanceConfigurationINTEL, /* configuration */
            VkResult> UnsafeInvoke;

        public static implicit operator VkReleasePerformanceConfigurationINTEL(void* ptr)
        {
            VkReleasePerformanceConfigurationINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueSetPerformanceConfigurationINTEL
    {
        public static readonly VkQueueSetPerformanceConfigurationINTEL Zero = null;

        public readonly delegate*<
            VkQueue,                         /* queue */
            VkPerformanceConfigurationINTEL, /* configuration */
            VkResult> UnsafeInvoke;

        public static implicit operator VkQueueSetPerformanceConfigurationINTEL(void* ptr)
        {
            VkQueueSetPerformanceConfigurationINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPerformanceParameterINTEL
    {
        public static readonly VkGetPerformanceParameterINTEL Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkPerformanceParameterTypeINTEL, /* parameter */
            VkPerformanceValueINTEL*,        /* pValue */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPerformanceParameterINTEL(void* ptr)
        {
            VkGetPerformanceParameterINTEL value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSetLocalDimmingAMD
    {
        public static readonly VkSetLocalDimmingAMD Zero = null;

        public readonly delegate*<
            VkDevice,       /* device */
            VkSwapchainKHR, /* swapChain */
            uint,           /* localDimmingEnable */
            void> UnsafeInvoke;

        public static implicit operator VkSetLocalDimmingAMD(void* ptr)
        {
            VkSetLocalDimmingAMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetBufferDeviceAddressEXT
    {
        public static readonly VkGetBufferDeviceAddressEXT Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkBufferDeviceAddressInfo*, /* pInfo */
            VkDeviceAddress> UnsafeInvoke;

        public static implicit operator VkGetBufferDeviceAddressEXT(void* ptr)
        {
            VkGetBufferDeviceAddressEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceToolPropertiesEXT
    {
        public static readonly VkGetPhysicalDeviceToolPropertiesEXT Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                   /* physicalDevice */
            uint*,                              /* pToolCount */
            VkPhysicalDeviceToolPropertiesEXT*, /* pToolProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceToolPropertiesEXT(void* ptr)
        {
            VkGetPhysicalDeviceToolPropertiesEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public static readonly VkGetPhysicalDeviceCooperativeMatrixPropertiesNV Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                 /* physicalDevice */
            uint*,                            /* pPropertyCount */
            VkCooperativeMatrixPropertiesNV*, /* pProperties */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceCooperativeMatrixPropertiesNV(void* ptr)
        {
            VkGetPhysicalDeviceCooperativeMatrixPropertiesNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV
    {
        public static readonly VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV Zero = null;

        public readonly delegate*<
            VkPhysicalDevice,                        /* physicalDevice */
            uint*,                                   /* pCombinationCount */
            VkFramebufferMixedSamplesCombinationNV*, /* pCombinations */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(void* ptr)
        {
            VkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateHeadlessSurfaceEXT
    {
        public static readonly VkCreateHeadlessSurfaceEXT Zero = null;

        public readonly delegate*<
            VkInstance,                      /* instance */
            VkHeadlessSurfaceCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkSurfaceKHR*,                   /* pSurface */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateHeadlessSurfaceEXT(void* ptr)
        {
            VkCreateHeadlessSurfaceEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetLineStippleEXT
    {
        public static readonly VkCmdSetLineStippleEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* lineStippleFactor */
            ushort,          /* lineStipplePattern */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetLineStippleEXT(void* ptr)
        {
            VkCmdSetLineStippleEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkResetQueryPoolEXT
    {
        public static readonly VkResetQueryPoolEXT Zero = null;

        public readonly delegate*<
            VkDevice,    /* device */
            VkQueryPool, /* queryPool */
            uint,        /* firstQuery */
            uint,        /* queryCount */
            void> UnsafeInvoke;

        public static implicit operator VkResetQueryPoolEXT(void* ptr)
        {
            VkResetQueryPoolEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetCullModeEXT
    {
        public static readonly VkCmdSetCullModeEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,    /* commandBuffer */
            VkCullModeFlagBits, /* cullMode */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetCullModeEXT(void* ptr)
        {
            VkCmdSetCullModeEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetFrontFaceEXT
    {
        public static readonly VkCmdSetFrontFaceEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkFrontFace,     /* frontFace */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetFrontFaceEXT(void* ptr)
        {
            VkCmdSetFrontFaceEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetPrimitiveTopologyEXT
    {
        public static readonly VkCmdSetPrimitiveTopologyEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkPrimitiveTopology, /* primitiveTopology */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetPrimitiveTopologyEXT(void* ptr)
        {
            VkCmdSetPrimitiveTopologyEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetViewportWithCountEXT
    {
        public static readonly VkCmdSetViewportWithCountEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* viewportCount */
            VkViewport*,     /* pViewports */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetViewportWithCountEXT(void* ptr)
        {
            VkCmdSetViewportWithCountEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetScissorWithCountEXT
    {
        public static readonly VkCmdSetScissorWithCountEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* scissorCount */
            VkRect2D*,       /* pScissors */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetScissorWithCountEXT(void* ptr)
        {
            VkCmdSetScissorWithCountEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBindVertexBuffers2EXT
    {
        public static readonly VkCmdBindVertexBuffers2EXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* firstBinding */
            uint,            /* bindingCount */
            VkBuffer*,       /* pBuffers */
            VkDeviceSize*,   /* pOffsets */
            VkDeviceSize*,   /* pSizes */
            VkDeviceSize*,   /* pStrides */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBindVertexBuffers2EXT(void* ptr)
        {
            VkCmdBindVertexBuffers2EXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDepthTestEnableEXT
    {
        public static readonly VkCmdSetDepthTestEnableEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthTestEnable */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDepthTestEnableEXT(void* ptr)
        {
            VkCmdSetDepthTestEnableEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDepthWriteEnableEXT
    {
        public static readonly VkCmdSetDepthWriteEnableEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthWriteEnable */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDepthWriteEnableEXT(void* ptr)
        {
            VkCmdSetDepthWriteEnableEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDepthCompareOpEXT
    {
        public static readonly VkCmdSetDepthCompareOpEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkCompareOp,     /* depthCompareOp */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDepthCompareOpEXT(void* ptr)
        {
            VkCmdSetDepthCompareOpEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetDepthBoundsTestEnableEXT
    {
        public static readonly VkCmdSetDepthBoundsTestEnableEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* depthBoundsTestEnable */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetDepthBoundsTestEnableEXT(void* ptr)
        {
            VkCmdSetDepthBoundsTestEnableEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetStencilTestEnableEXT
    {
        public static readonly VkCmdSetStencilTestEnableEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* stencilTestEnable */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetStencilTestEnableEXT(void* ptr)
        {
            VkCmdSetStencilTestEnableEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetStencilOpEXT
    {
        public static readonly VkCmdSetStencilOpEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkStencilFaceFlagBits, /* faceMask */
            VkStencilOp,           /* failOp */
            VkStencilOp,           /* passOp */
            VkStencilOp,           /* depthFailOp */
            VkCompareOp,           /* compareOp */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetStencilOpEXT(void* ptr)
        {
            VkCmdSetStencilOpEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetGeneratedCommandsMemoryRequirementsNV
    {
        public static readonly VkGetGeneratedCommandsMemoryRequirementsNV Zero = null;

        public readonly delegate*<
            VkDevice,                                     /* device */
            VkGeneratedCommandsMemoryRequirementsInfoNV*, /* pInfo */
            VkMemoryRequirements2*,                       /* pMemoryRequirements */
            void> UnsafeInvoke;

        public static implicit operator VkGetGeneratedCommandsMemoryRequirementsNV(void* ptr)
        {
            VkGetGeneratedCommandsMemoryRequirementsNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdPreprocessGeneratedCommandsNV
    {
        public static readonly VkCmdPreprocessGeneratedCommandsNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdPreprocessGeneratedCommandsNV(void* ptr)
        {
            VkCmdPreprocessGeneratedCommandsNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdExecuteGeneratedCommandsNV
    {
        public static readonly VkCmdExecuteGeneratedCommandsNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* isPreprocessed */
            VkGeneratedCommandsInfoNV*, /* pGeneratedCommandsInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdExecuteGeneratedCommandsNV(void* ptr)
        {
            VkCmdExecuteGeneratedCommandsNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBindPipelineShaderGroupNV
    {
        public static readonly VkCmdBindPipelineShaderGroupNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            VkPipelineBindPoint, /* pipelineBindPoint */
            VkPipeline,          /* pipeline */
            uint,                /* groupIndex */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBindPipelineShaderGroupNV(void* ptr)
        {
            VkCmdBindPipelineShaderGroupNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateIndirectCommandsLayoutNV
    {
        public static readonly VkCreateIndirectCommandsLayoutNV Zero = null;

        public readonly delegate*<
            VkDevice,                              /* device */
            VkIndirectCommandsLayoutCreateInfoNV*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkIndirectCommandsLayoutNV*,           /* pIndirectCommandsLayout */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateIndirectCommandsLayoutNV(void* ptr)
        {
            VkCreateIndirectCommandsLayoutNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyIndirectCommandsLayoutNV
    {
        public static readonly VkDestroyIndirectCommandsLayoutNV Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkIndirectCommandsLayoutNV, /* indirectCommandsLayout */
            VkAllocationCallbacks*,     /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyIndirectCommandsLayoutNV(void* ptr)
        {
            VkDestroyIndirectCommandsLayoutNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreatePrivateDataSlotEXT
    {
        public static readonly VkCreatePrivateDataSlotEXT Zero = null;

        public readonly delegate*<
            VkDevice,                        /* device */
            VkPrivateDataSlotCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkPrivateDataSlotEXT*,           /* pPrivateDataSlot */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreatePrivateDataSlotEXT(void* ptr)
        {
            VkCreatePrivateDataSlotEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyPrivateDataSlotEXT
    {
        public static readonly VkDestroyPrivateDataSlotEXT Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkPrivateDataSlotEXT,   /* privateDataSlot */
            VkAllocationCallbacks*, /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyPrivateDataSlotEXT(void* ptr)
        {
            VkDestroyPrivateDataSlotEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkSetPrivateDataEXT
    {
        public static readonly VkSetPrivateDataEXT Zero = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong,                /* data */
            VkResult> UnsafeInvoke;

        public static implicit operator VkSetPrivateDataEXT(void* ptr)
        {
            VkSetPrivateDataEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetPrivateDataEXT
    {
        public static readonly VkGetPrivateDataEXT Zero = null;

        public readonly delegate*<
            VkDevice,             /* device */
            VkObjectType,         /* objectType */
            ulong,                /* objectHandle */
            VkPrivateDataSlotEXT, /* privateDataSlot */
            ulong*,               /* pData */
            void> UnsafeInvoke;

        public static implicit operator VkGetPrivateDataEXT(void* ptr)
        {
            VkGetPrivateDataEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetFragmentShadingRateEnumNV
    {
        public static readonly VkCmdSetFragmentShadingRateEnumNV Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                    /* commandBuffer */
            VkFragmentShadingRateNV,            /* shadingRate */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps1 */
            VkFragmentShadingRateCombinerOpKHR, /* combinerOps2 */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetFragmentShadingRateEnumNV(void* ptr)
        {
            VkCmdSetFragmentShadingRateEnumNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkAcquireWinrtDisplayNV
    {
        public static readonly VkAcquireWinrtDisplayNV Zero = null;

        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            VkDisplayKHR,     /* display */
            VkResult> UnsafeInvoke;

        public static implicit operator VkAcquireWinrtDisplayNV(void* ptr)
        {
            VkAcquireWinrtDisplayNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetWinrtDisplayNV
    {
        public static readonly VkGetWinrtDisplayNV Zero = null;

        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            uint,             /* deviceRelativeId */
            VkDisplayKHR*,    /* pDisplay */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetWinrtDisplayNV(void* ptr)
        {
            VkGetWinrtDisplayNV value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetVertexInputEXT
    {
        public static readonly VkCmdSetVertexInputEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                        /* commandBuffer */
            uint,                                   /* vertexBindingDescriptionCount */
            VkVertexInputBindingDescription2EXT*,   /* pVertexBindingDescriptions */
            uint,                                   /* vertexAttributeDescriptionCount */
            VkVertexInputAttributeDescription2EXT*, /* pVertexAttributeDescriptions */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetVertexInputEXT(void* ptr)
        {
            VkCmdSetVertexInputEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetColorWriteEnableEXT
    {
        public static readonly VkCmdSetColorWriteEnableEXT Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* attachmentCount */
            VkBool32*,       /* pColorWriteEnables */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetColorWriteEnableEXT(void* ptr)
        {
            VkCmdSetColorWriteEnableEXT value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateAccelerationStructureKHR
    {
        public static readonly VkCreateAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkDevice,                              /* device */
            VkAccelerationStructureCreateInfoKHR*, /* pCreateInfo */
            VkAllocationCallbacks*,                /* pAllocator */
            VkAccelerationStructureKHR*,           /* pAccelerationStructure */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateAccelerationStructureKHR(void* ptr)
        {
            VkCreateAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkDestroyAccelerationStructureKHR
    {
        public static readonly VkDestroyAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkDevice,                   /* device */
            VkAccelerationStructureKHR, /* accelerationStructure */
            VkAllocationCallbacks*,     /* pAllocator */
            void> UnsafeInvoke;

        public static implicit operator VkDestroyAccelerationStructureKHR(void* ptr)
        {
            VkDestroyAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructuresKHR
    {
        public static readonly VkCmdBuildAccelerationStructuresKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                              /* commandBuffer */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkAccelerationStructureBuildRangeInfoKHR**,   /* ppBuildRangeInfos */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBuildAccelerationStructuresKHR(void* ptr)
        {
            VkCmdBuildAccelerationStructuresKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdBuildAccelerationStructuresIndirectKHR
    {
        public static readonly VkCmdBuildAccelerationStructuresIndirectKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                              /* commandBuffer */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkDeviceAddress*,                             /* pIndirectDeviceAddresses */
            uint*,                                        /* pIndirectStrides */
            uint**,                                       /* ppMaxPrimitiveCounts */
            void> UnsafeInvoke;

        public static implicit operator VkCmdBuildAccelerationStructuresIndirectKHR(void* ptr)
        {
            VkCmdBuildAccelerationStructuresIndirectKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkBuildAccelerationStructuresKHR
    {
        public static readonly VkBuildAccelerationStructuresKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                     /* device */
            VkDeferredOperationKHR,                       /* deferredOperation */
            uint,                                         /* infoCount */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pInfos */
            VkAccelerationStructureBuildRangeInfoKHR**,   /* ppBuildRangeInfos */
            VkResult> UnsafeInvoke;

        public static implicit operator VkBuildAccelerationStructuresKHR(void* ptr)
        {
            VkBuildAccelerationStructuresKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCopyAccelerationStructureKHR
    {
        public static readonly VkCopyAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkDevice,                            /* device */
            VkDeferredOperationKHR,              /* deferredOperation */
            VkCopyAccelerationStructureInfoKHR*, /* pInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCopyAccelerationStructureKHR(void* ptr)
        {
            VkCopyAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCopyAccelerationStructureToMemoryKHR
    {
        public static readonly VkCopyAccelerationStructureToMemoryKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                    /* device */
            VkDeferredOperationKHR,                      /* deferredOperation */
            VkCopyAccelerationStructureToMemoryInfoKHR*, /* nfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCopyAccelerationStructureToMemoryKHR(void* ptr)
        {
            VkCopyAccelerationStructureToMemoryKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCopyMemoryToAccelerationStructureKHR
    {
        public static readonly VkCopyMemoryToAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                    /* device */
            VkDeferredOperationKHR,                      /* deferredOperation */
            VkCopyMemoryToAccelerationStructureInfoKHR*, /* pInfo */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCopyMemoryToAccelerationStructureKHR(void* ptr)
        {
            VkCopyMemoryToAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkWriteAccelerationStructuresPropertiesKHR
    {
        public static readonly VkWriteAccelerationStructuresPropertiesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                    /* device */
            uint,                        /* accelerationStructureCount */
            VkAccelerationStructureKHR*, /* pAccelerationStructures */
            VkQueryType,                 /* queryType */
            nuint,                       /* dataSize */
            void*,                       /* pData */
            nuint,                       /* stride */
            VkResult> UnsafeInvoke;

        public static implicit operator VkWriteAccelerationStructuresPropertiesKHR(void* ptr)
        {
            VkWriteAccelerationStructuresPropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureKHR
    {
        public static readonly VkCmdCopyAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                     /* commandBuffer */
            VkCopyAccelerationStructureInfoKHR*, /* pInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyAccelerationStructureKHR(void* ptr)
        {
            VkCmdCopyAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyAccelerationStructureToMemoryKHR
    {
        public static readonly VkCmdCopyAccelerationStructureToMemoryKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                             /* commandBuffer */
            VkCopyAccelerationStructureToMemoryInfoKHR*, /* pInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyAccelerationStructureToMemoryKHR(void* ptr)
        {
            VkCmdCopyAccelerationStructureToMemoryKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdCopyMemoryToAccelerationStructureKHR
    {
        public static readonly VkCmdCopyMemoryToAccelerationStructureKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                             /* commandBuffer */
            VkCopyMemoryToAccelerationStructureInfoKHR*, /* pInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdCopyMemoryToAccelerationStructureKHR(void* ptr)
        {
            VkCmdCopyMemoryToAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureDeviceAddressKHR
    {
        public static readonly VkGetAccelerationStructureDeviceAddressKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                     /* device */
            VkAccelerationStructureDeviceAddressInfoKHR*, /* pInfo */
            VkDeviceAddress> UnsafeInvoke;

        public static implicit operator VkGetAccelerationStructureDeviceAddressKHR(void* ptr)
        {
            VkGetAccelerationStructureDeviceAddressKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWriteAccelerationStructuresPropertiesKHR
    {
        public static readonly VkCmdWriteAccelerationStructuresPropertiesKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            uint,                        /* accelerationStructureCount */
            VkAccelerationStructureKHR*, /* pAccelerationStructures */
            VkQueryType,                 /* queryType */
            VkQueryPool,                 /* queryPool */
            uint,                        /* firstQuery */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWriteAccelerationStructuresPropertiesKHR(void* ptr)
        {
            VkCmdWriteAccelerationStructuresPropertiesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetDeviceAccelerationStructureCompatibilityKHR
    {
        public static readonly VkGetDeviceAccelerationStructureCompatibilityKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                 /* device */
            VkAccelerationStructureVersionInfoKHR*,   /* pVersionInfo */
            VkAccelerationStructureCompatibilityKHR*, /* pCompatibility */
            void> UnsafeInvoke;

        public static implicit operator VkGetDeviceAccelerationStructureCompatibilityKHR(void* ptr)
        {
            VkGetDeviceAccelerationStructureCompatibilityKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetAccelerationStructureBuildSizesKHR
    {
        public static readonly VkGetAccelerationStructureBuildSizesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                                     /* device */
            VkAccelerationStructureBuildTypeKHR,          /* buildType */
            VkAccelerationStructureBuildGeometryInfoKHR*, /* pBuildInfo */
            uint*,                                        /* pMaxPrimitiveCounts */
            VkAccelerationStructureBuildSizesInfoKHR*,    /* pSizeInfo */
            void> UnsafeInvoke;

        public static implicit operator VkGetAccelerationStructureBuildSizesKHR(void* ptr)
        {
            VkGetAccelerationStructureBuildSizesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdTraceRaysKHR
    {
        public static readonly VkCmdTraceRaysKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                  /* commandBuffer */
            VkStridedDeviceAddressRegionKHR*, /* pRaygenShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pMissShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pHitShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pCallableShaderBindingTable */
            uint,                             /* width */
            uint,                             /* height */
            uint,                             /* depth */
            void> UnsafeInvoke;

        public static implicit operator VkCmdTraceRaysKHR(void* ptr)
        {
            VkCmdTraceRaysKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCreateRayTracingPipelinesKHR
    {
        public static readonly VkCreateRayTracingPipelinesKHR Zero = null;

        public readonly delegate*<
            VkDevice,                           /* device */
            VkDeferredOperationKHR,             /* deferredOperation */
            VkPipelineCache,                    /* pipelineCache */
            uint,                               /* createInfoCount */
            VkRayTracingPipelineCreateInfoKHR*, /* pCreateInfos */
            VkAllocationCallbacks*,             /* pAllocator */
            VkPipeline*,                        /* pPipelines */
            VkResult> UnsafeInvoke;

        public static implicit operator VkCreateRayTracingPipelinesKHR(void* ptr)
        {
            VkCreateRayTracingPipelinesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetRayTracingCaptureReplayShaderGroupHandlesKHR
    {
        public static readonly VkGetRayTracingCaptureReplayShaderGroupHandlesKHR Zero = null;

        public readonly delegate*<
            VkDevice,   /* device */
            VkPipeline, /* pipeline */
            uint,       /* firstGroup */
            uint,       /* groupCount */
            nuint,      /* dataSize */
            void*,      /* pData */
            VkResult> UnsafeInvoke;

        public static implicit operator VkGetRayTracingCaptureReplayShaderGroupHandlesKHR(void* ptr)
        {
            VkGetRayTracingCaptureReplayShaderGroupHandlesKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdTraceRaysIndirectKHR
    {
        public static readonly VkCmdTraceRaysIndirectKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,                  /* commandBuffer */
            VkStridedDeviceAddressRegionKHR*, /* pRaygenShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pMissShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pHitShaderBindingTable */
            VkStridedDeviceAddressRegionKHR*, /* pCallableShaderBindingTable */
            VkDeviceAddress,                  /* indirectDeviceAddress */
            void> UnsafeInvoke;

        public static implicit operator VkCmdTraceRaysIndirectKHR(void* ptr)
        {
            VkCmdTraceRaysIndirectKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetRayTracingShaderGroupStackSizeKHR
    {
        public static readonly VkGetRayTracingShaderGroupStackSizeKHR Zero = null;

        public readonly delegate*<
            VkDevice,               /* device */
            VkPipeline,             /* pipeline */
            uint,                   /* group */
            VkShaderGroupShaderKHR, /* groupShader */
            VkDeviceSize> UnsafeInvoke;

        public static implicit operator VkGetRayTracingShaderGroupStackSizeKHR(void* ptr)
        {
            VkGetRayTracingShaderGroupStackSizeKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetRayTracingPipelineStackSizeKHR
    {
        public static readonly VkCmdSetRayTracingPipelineStackSizeKHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* pipelineStackSize */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetRayTracingPipelineStackSizeKHR(void* ptr)
        {
            VkCmdSetRayTracingPipelineStackSizeKHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdSetEvent2KHR
    {
        public static readonly VkCmdSetEvent2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkEvent,              /* event */
            VkDependencyInfoKHR*, /* pDependencyInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdSetEvent2KHR(void* ptr)
        {
            VkCmdSetEvent2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdResetEvent2KHR
    {
        public static readonly VkCmdResetEvent2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkEvent,                     /* event */
            VkPipelineStageFlagBits2KHR, /* stageMask */
            void> UnsafeInvoke;

        public static implicit operator VkCmdResetEvent2KHR(void* ptr)
        {
            VkCmdResetEvent2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWaitEvents2KHR
    {
        public static readonly VkCmdWaitEvents2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            uint,                 /* eventCount */
            VkEvent*,             /* pEvents */
            VkDependencyInfoKHR*, /* pDependencyInfos */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWaitEvents2KHR(void* ptr)
        {
            VkCmdWaitEvents2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdPipelineBarrier2KHR
    {
        public static readonly VkCmdPipelineBarrier2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,      /* commandBuffer */
            VkDependencyInfoKHR*, /* pDependencyInfo */
            void> UnsafeInvoke;

        public static implicit operator VkCmdPipelineBarrier2KHR(void* ptr)
        {
            VkCmdPipelineBarrier2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWriteTimestamp2KHR
    {
        public static readonly VkCmdWriteTimestamp2KHR Zero = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkPipelineStageFlagBits2KHR, /* stage */
            VkQueryPool,                 /* queryPool */
            uint,                        /* query */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWriteTimestamp2KHR(void* ptr)
        {
            VkCmdWriteTimestamp2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkQueueSubmit2KHR
    {
        public static readonly VkQueueSubmit2KHR Zero = null;

        public readonly delegate*<
            VkQueue,           /* queue */
            uint,              /* submitCount */
            VkSubmitInfo2KHR*, /* pSubmits */
            VkFence,           /* fence */
            VkResult> UnsafeInvoke;

        public static implicit operator VkQueueSubmit2KHR(void* ptr)
        {
            VkQueueSubmit2KHR value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkCmdWriteBufferMarker2AMD
    {
        public static readonly VkCmdWriteBufferMarker2AMD Zero = null;

        public readonly delegate*<
            VkCommandBuffer,             /* commandBuffer */
            VkPipelineStageFlagBits2KHR, /* stage */
            VkBuffer,                    /* dstBuffer */
            VkDeviceSize,                /* dstOffset */
            uint,                        /* marker */
            void> UnsafeInvoke;

        public static implicit operator VkCmdWriteBufferMarker2AMD(void* ptr)
        {
            VkCmdWriteBufferMarker2AMD value;
            *(void**)&value = ptr;
            return value;
        }
    }

    public readonly unsafe struct VkGetQueueCheckpointData2NV
    {
        public static readonly VkGetQueueCheckpointData2NV Zero = null;

        public readonly delegate*<
            VkQueue,              /* queue */
            uint*,                /* pCheckpointDataCount */
            VkCheckpointData2NV*, /* pCheckpointData */
            void> UnsafeInvoke;

        public static implicit operator VkGetQueueCheckpointData2NV(void* ptr)
        {
            VkGetQueueCheckpointData2NV value;
            *(void**)&value = ptr;
            return value;
        }
    }
}