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
using Exomia.Vulkan.Api.Core.Extensions;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnassignedReadonlyField
namespace Exomia.Vulkan.Api.Core
{
    using VkMemoryRequirements2KHR = VkMemoryRequirements2;

    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe struct VkFunction
    {
        public static readonly VkFunction Null = null;

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
            VkPhysicalDevice, /* physicalDevice */
            int,              /* drmFd */
            VkDisplayKHR,     /* display */
            VkResult> vkAcquireDrmDisplayEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkPhysicalDevice, /* physicalDevice */
            int,              /* drmFd */
            uint,             /* connectorId */
            VkDisplayKHR*,    /* display */
            VkResult> vkGetDrmDisplayEXT;

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
            VkRenderPass, /* renderpass */
            VkExtent2D*,  /* pMaxWorkgroupSize */
            VkResult> vkGetSubpassShadingMaxWorkgroupSizeHUAWEI;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdSubpassShadingHUAWEI;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* attachmentCount */
            VkBool32*,       /* pColorWriteEnables */
            void> vkCmdSetColorWriteEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,     /* commandBuffer */
            uint,                /* drawCount */
            VkMultiDrawInfoEXT*, /* pVertexInfo */
            uint,                /* instanceCount */
            uint,                /* firstInstance */
            uint,                /* stride */
            void> vkCmdDrawMultiEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,            /* commandBuffer */
            uint,                       /* drawCount */
            VkMultiDrawIndexedInfoEXT*, /* pIndexInfo */
            uint,                       /* instanceCount */
            uint,                       /* firstInstance */
            uint,                       /* stride */
            int*,                       /* pVertexOffset */
            void> vkCmdDrawMultiIndexedEXT;

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

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            uint,            /* patchControlPoints */
            void> vkCmdSetPatchControlPointsEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* rasterizerDiscardEnable */
            void> vkCmdSetRasterizerDiscardEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* depthBiasEnable */
            void> vkCmdSetDepthBiasEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkLogicOp,       /* logicOp */
            void> vkCmdSetLogicOpEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer, /* commandBuffer */
            VkBool32,        /* primitiveRestartEnable */
            void> vkCmdSetPrimitiveRestartEnableEXT;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                 /* device */
            VkCuModuleCreateInfoNVX*, /* pCreateInfo */
            VkAllocationCallbacks*,   /* pAllocator */
            VkCuModuleNVX*,           /* pModule */
            VkResult> vkCreateCuModuleNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,                   /* device */
            VkCuFunctionCreateInfoNVX*, /* pCreateInfo */
            VkAllocationCallbacks*,     /* pAllocator */
            VkCuFunctionNVX*,           /* pFunction */
            VkResult> vkCreateCuFunctionNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkCuModuleNVX,          /* module */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyCuModuleNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkDevice,               /* device */
            VkCuFunctionNVX,        /* function */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyCuFunctionNVX;

        [FieldOffset(0)]
        public readonly delegate*<
            VkCommandBuffer,    /* commandBuffer */
            VkCuLaunchInfoNVX*, /* pLaunchInfo */
            void> vkCmdCuLaunchKernelNVX;

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
}