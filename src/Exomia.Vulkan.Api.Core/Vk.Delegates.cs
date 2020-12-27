#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    using size_t = nuint;
    using VkMemoryRequirements2KHR = VkMemoryRequirements2;

    public unsafe delegate void* AllocationFunction(
        void*                   pUserData,
        size_t                  size,
        size_t                  alignment,
        VkSystemAllocationScope allocationScope);

    public unsafe delegate void FreeFunction(
        void* pUserData,
        void* pMemory);

    public unsafe delegate void InternalAllocationNotification(
        void*                    pUserData,
        size_t                   size,
        VkInternalAllocationType allocationType,
        VkSystemAllocationScope  allocationScope);

    public unsafe delegate void InternalFreeNotification(
        void*                    pUserData,
        size_t                   size,
        VkInternalAllocationType allocationType,
        VkSystemAllocationScope  allocationScope);

    public unsafe delegate void* ReallocationFunction(
        void*                   pUserData,
        void*                   pOriginal,
        size_t                  size,
        size_t                  alignment,
        VkSystemAllocationScope allocationScope);

    public unsafe delegate VkResult CreateInstance(
        VkInstanceCreateInfo*  pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkInstance*            pInstance);

    public unsafe delegate void DestroyInstance(
        VkInstance             instance,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult EnumeratePhysicalDevices(
        VkInstance        instance,
        uint*             pPhysicalDeviceCount,
        VkPhysicalDevice* pPhysicalDevices);

    public unsafe delegate void GetPhysicalDeviceFeatures(
        VkPhysicalDevice          physicalDevice,
        VkPhysicalDeviceFeatures* pFeatures);

    public unsafe delegate void GetPhysicalDeviceFormatProperties(
        VkPhysicalDevice    physicalDevice,
        VkFormat            format,
        VkFormatProperties* pFormatProperties);

    public unsafe delegate VkResult GetPhysicalDeviceImageFormatProperties(
        VkPhysicalDevice         physicalDevice,
        VkFormat                 format,
        VkImageType              type,
        VkImageTiling            tiling,
        VkImageUsageFlags        usage,
        VkImageCreateFlags       flags,
        VkImageFormatProperties* pImageFormatProperties);

    public unsafe delegate void GetPhysicalDeviceProperties(
        VkPhysicalDevice            physicalDevice,
        VkPhysicalDeviceProperties* pProperties);

    public unsafe delegate void GetPhysicalDeviceQueueFamilyProperties(
        VkPhysicalDevice         physicalDevice,
        uint*                    pQueueFamilyPropertyCount,
        VkQueueFamilyProperties* pQueueFamilyProperties);

    public unsafe delegate void GetPhysicalDeviceMemoryProperties(
        VkPhysicalDevice                  physicalDevice,
        VkPhysicalDeviceMemoryProperties* pMemoryProperties);

    public unsafe delegate void* GetInstanceProcAddr(
        VkInstance instance,
        sbyte*     pName);

    public unsafe delegate void* GetDeviceProcAddr(
        VkDevice device,
        sbyte*   pName);

    public unsafe delegate VkResult CreateDevice(
        VkPhysicalDevice       physicalDevice,
        VkDeviceCreateInfo*    pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkDevice*              pDevice);

    public unsafe delegate void DestroyDevice(
        VkDevice               device,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult EnumerateInstanceExtensionProperties(
        sbyte*                 pLayerName,
        uint*                  pPropertyCount,
        VkExtensionProperties* pProperties);

    public unsafe delegate VkResult EnumerateDeviceExtensionProperties(
        VkPhysicalDevice       physicalDevice,
        sbyte*                 pLayerName,
        uint*                  pPropertyCount,
        VkExtensionProperties* pProperties);

    public unsafe delegate VkResult EnumerateInstanceLayerProperties(
        uint*              pPropertyCount,
        VkLayerProperties* pProperties);

    public unsafe delegate VkResult EnumerateDeviceLayerProperties(
        VkPhysicalDevice   physicalDevice,
        uint*              pPropertyCount,
        VkLayerProperties* pProperties);

    public unsafe delegate void GetDeviceQueue(
        VkDevice device,
        uint     queueFamilyIndex,
        uint     queueIndex,
        VkQueue* pQueue);

    public unsafe delegate VkResult QueueSubmit(
        VkQueue       queue,
        uint          submitCount,
        VkSubmitInfo* pSubmits,
        VkFence       fence);

    public delegate VkResult QueueWaitIdle(VkQueue queue);

    public delegate VkResult DeviceWaitIdle(VkDevice device);

    public unsafe delegate VkResult AllocateMemory(
        VkDevice               device,
        VkMemoryAllocateInfo*  pAllocateInfo,
        VkAllocationCallbacks* pAllocator,
        VkDeviceMemory*        pMemory);

    public unsafe delegate void FreeMemory(
        VkDevice               device,
        VkDeviceMemory         memory,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult MapMemory(
        VkDevice         device,
        VkDeviceMemory   memory,
        VkDeviceSize     offset,
        VkDeviceSize     size,
        VkMemoryMapFlags flags,
        void**           ppData);

    public delegate void UnmapMemory(
        VkDevice       device,
        VkDeviceMemory memory);

    public unsafe delegate VkResult FlushMappedMemoryRanges(
        VkDevice             device,
        uint                 memoryRangeCount,
        VkMappedMemoryRange* pMemoryRanges);

    public unsafe delegate VkResult InvalidateMappedMemoryRanges(
        VkDevice             device,
        uint                 memoryRangeCount,
        VkMappedMemoryRange* pMemoryRanges);

    public unsafe delegate void GetDeviceMemoryCommitment(
        VkDevice       device,
        VkDeviceMemory memory,
        VkDeviceSize*  pCommittedMemoryInBytes);

    public delegate VkResult BindBufferMemory(
        VkDevice       device,
        VkBuffer       buffer,
        VkDeviceMemory memory,
        VkDeviceSize   memoryOffset);

    public delegate VkResult BindImageMemory(
        VkDevice       device,
        VkImage        image,
        VkDeviceMemory memory,
        VkDeviceSize   memoryOffset);

    public unsafe delegate void GetBufferMemoryRequirements(
        VkDevice              device,
        VkBuffer              buffer,
        VkMemoryRequirements* pMemoryRequirements);

    public unsafe delegate void GetImageMemoryRequirements(
        VkDevice              device,
        VkImage               image,
        VkMemoryRequirements* pMemoryRequirements);

    public unsafe delegate void GetImageSparseMemoryRequirements(
        VkDevice                         device,
        VkImage                          image,
        uint*                            pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

    public unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties(
        VkPhysicalDevice               physicalDevice,
        VkFormat                       format,
        VkImageType                    type,
        VkSampleCountFlags             samples,
        VkImageUsageFlags              usage,
        VkImageTiling                  tiling,
        uint*                          pPropertyCount,
        VkSparseImageFormatProperties* pProperties);

    public unsafe delegate VkResult QueueBindSparse(
        VkQueue           queue,
        uint              bindInfoCount,
        VkBindSparseInfo* pBindInfo,
        VkFence           fence);

    public unsafe delegate VkResult CreateFence(
        VkDevice               device,
        VkFenceCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkFence*               pFence);

    public unsafe delegate void DestroyFence(
        VkDevice               device,
        VkFence                fence,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult ResetFences(
        VkDevice device,
        uint     fenceCount,
        VkFence* pFences);

    public delegate VkResult GetFenceStatus(
        VkDevice device,
        VkFence  fence);

    public unsafe delegate VkResult WaitForFences(
        VkDevice device,
        uint     fenceCount,
        VkFence* pFences,
        uint     waitAll,
        ulong    timeout);

    public unsafe delegate VkResult CreateSemaphore(
        VkDevice               device,
        VkSemaphoreCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkSemaphore*           pSemaphore);

    public unsafe delegate void DestroySemaphore(
        VkDevice               device,
        VkSemaphore            semaphore,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateEvent(
        VkDevice               device,
        VkEventCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkEvent*               pEvent);

    public unsafe delegate void DestroyEvent(
        VkDevice               device,
        VkEvent                @event,
        VkAllocationCallbacks* pAllocator);

    public delegate VkResult GetEventStatus(
        VkDevice device,
        VkEvent  @event);

    public delegate VkResult SetEvent(
        VkDevice device,
        VkEvent  @event);

    public delegate VkResult ResetEvent(
        VkDevice device,
        VkEvent  @event);

    public unsafe delegate VkResult CreateQueryPool(
        VkDevice               device,
        VkQueryPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkQueryPool*           pQueryPool);

    public unsafe delegate void DestroyQueryPool(
        VkDevice               device,
        VkQueryPool            queryPool,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult GetQueryPoolResults(
        VkDevice           device,
        VkQueryPool        queryPool,
        uint               firstQuery,
        uint               queryCount,
        size_t             dataSize,
        void*              pData,
        VkDeviceSize       stride,
        VkQueryResultFlags flags);

    public unsafe delegate VkResult CreateBuffer(
        VkDevice               device,
        VkBufferCreateInfo*    pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkBuffer*              pBuffer);

    public unsafe delegate void DestroyBuffer(
        VkDevice               device,
        VkBuffer               buffer,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateBufferView(
        VkDevice                device,
        VkBufferViewCreateInfo* pCreateInfo,
        VkAllocationCallbacks*  pAllocator,
        VkBufferView*           pView);

    public unsafe delegate void DestroyBufferView(
        VkDevice               device,
        VkBufferView           bufferView,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateImage(
        VkDevice               device,
        VkImageCreateInfo*     pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkImage*               pImage);

    public unsafe delegate void DestroyImage(
        VkDevice               device,
        VkImage                image,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate void GetImageSubresourceLayout(
        VkDevice             device,
        VkImage              image,
        VkImageSubresource*  pSubresource,
        VkSubresourceLayout* pLayout);

    public unsafe delegate VkResult CreateImageView(
        VkDevice               device,
        VkImageViewCreateInfo* pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkImageView*           pView);

    public unsafe delegate void DestroyImageView(
        VkDevice               device,
        VkImageView            imageView,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateShaderModule(
        VkDevice                  device,
        VkShaderModuleCreateInfo* pCreateInfo,
        VkAllocationCallbacks*    pAllocator,
        VkShaderModule*           pShaderModule);

    public unsafe delegate void DestroyShaderModule(
        VkDevice               device,
        VkShaderModule         shaderModule,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreatePipelineCache(
        VkDevice                   device,
        VkPipelineCacheCreateInfo* pCreateInfo,
        VkAllocationCallbacks*     pAllocator,
        VkPipelineCache*           pPipelineCache);

    public unsafe delegate void DestroyPipelineCache(
        VkDevice               device,
        VkPipelineCache        pipelineCache,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult GetPipelineCacheData(
        VkDevice        device,
        VkPipelineCache pipelineCache,
        size_t*         pDataSize,
        void*           pData);

    public unsafe delegate VkResult MergePipelineCaches(
        VkDevice         device,
        VkPipelineCache  dstCache,
        uint             srcCacheCount,
        VkPipelineCache* pSrcCaches);

    public unsafe delegate VkResult CreateGraphicsPipelines(
        VkDevice                      device,
        VkPipelineCache               pipelineCache,
        uint                          createInfoCount,
        VkGraphicsPipelineCreateInfo* pCreateInfos,
        VkAllocationCallbacks*        pAllocator,
        VkPipeline*                   pPipelines);

    public unsafe delegate VkResult CreateComputePipelines(
        VkDevice                     device,
        VkPipelineCache              pipelineCache,
        uint                         createInfoCount,
        VkComputePipelineCreateInfo* pCreateInfos,
        VkAllocationCallbacks*       pAllocator,
        VkPipeline*                  pPipelines);

    public unsafe delegate void DestroyPipeline(
        VkDevice               device,
        VkPipeline             pipeline,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreatePipelineLayout(
        VkDevice                    device,
        VkPipelineLayoutCreateInfo* pCreateInfo,
        VkAllocationCallbacks*      pAllocator,
        VkPipelineLayout*           pPipelineLayout);

    public unsafe delegate void DestroyPipelineLayout(
        VkDevice               device,
        VkPipelineLayout       pipelineLayout,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateSampler(
        VkDevice               device,
        VkSamplerCreateInfo*   pCreateInfo,
        VkAllocationCallbacks* pAllocator,
        VkSampler*             pSampler);

    public unsafe delegate void DestroySampler(
        VkDevice               device,
        VkSampler              sampler,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateDescriptorSetLayout(
        VkDevice                         device,
        VkDescriptorSetLayoutCreateInfo* pCreateInfo,
        VkAllocationCallbacks*           pAllocator,
        VkDescriptorSetLayout*           pSetLayout);

    public unsafe delegate void DestroyDescriptorSetLayout(
        VkDevice               device,
        VkDescriptorSetLayout  descriptorSetLayout,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateDescriptorPool(
        VkDevice                    device,
        VkDescriptorPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks*      pAllocator,
        VkDescriptorPool*           pDescriptorPool);

    public unsafe delegate void DestroyDescriptorPool(
        VkDevice               device,
        VkDescriptorPool       descriptorPool,
        VkAllocationCallbacks* pAllocator);

    public delegate VkResult ResetDescriptorPool(
        VkDevice                   device,
        VkDescriptorPool           descriptorPool,
        VkDescriptorPoolResetFlags flags);

    public unsafe delegate VkResult AllocateDescriptorSets(
        VkDevice                     device,
        VkDescriptorSetAllocateInfo* pAllocateInfo,
        VkDescriptorSet*             pDescriptorSets);

    public unsafe delegate VkResult FreeDescriptorSets(
        VkDevice         device,
        VkDescriptorPool descriptorPool,
        uint             descriptorSetCount,
        VkDescriptorSet* pDescriptorSets);

    public unsafe delegate void UpdateDescriptorSets(
        VkDevice              device,
        uint                  descriptorWriteCount,
        VkWriteDescriptorSet* pDescriptorWrites,
        uint                  descriptorCopyCount,
        VkCopyDescriptorSet*  pDescriptorCopies);

    public unsafe delegate VkResult CreateFramebuffer(
        VkDevice                 device,
        VkFramebufferCreateInfo* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkFramebuffer*           pFramebuffer);

    public unsafe delegate void DestroyFramebuffer(
        VkDevice               device,
        VkFramebuffer          framebuffer,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult CreateRenderPass(
        VkDevice                device,
        VkRenderPassCreateInfo* pCreateInfo,
        VkAllocationCallbacks*  pAllocator,
        VkRenderPass*           pRenderPass);

    public unsafe delegate void DestroyRenderPass(
        VkDevice               device,
        VkRenderPass           renderPass,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate void GetRenderAreaGranularity(
        VkDevice     device,
        VkRenderPass renderPass,
        VkExtent2D*  pGranularity);

    public unsafe delegate VkResult CreateCommandPool(
        VkDevice                 device,
        VkCommandPoolCreateInfo* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkCommandPool*           pCommandPool);

    public unsafe delegate void DestroyCommandPool(
        VkDevice               device,
        VkCommandPool          commandPool,
        VkAllocationCallbacks* pAllocator);

    public delegate VkResult ResetCommandPool(
        VkDevice                device,
        VkCommandPool           commandPool,
        VkCommandPoolResetFlags flags);

    public unsafe delegate VkResult AllocateCommandBuffers(
        VkDevice                     device,
        VkCommandBufferAllocateInfo* pAllocateInfo,
        VkCommandBuffer*             pCommandBuffers);

    public unsafe delegate void FreeCommandBuffers(
        VkDevice         device,
        VkCommandPool    commandPool,
        uint             commandBufferCount,
        VkCommandBuffer* pCommandBuffers);

    public unsafe delegate VkResult BeginCommandBuffer(
        VkCommandBuffer           commandBuffer,
        VkCommandBufferBeginInfo* pBeginInfo);

    public delegate VkResult EndCommandBuffer(VkCommandBuffer commandBuffer);

    public delegate VkResult ResetCommandBuffer(
        VkCommandBuffer           commandBuffer,
        VkCommandBufferResetFlags flags);

    public delegate void CmdBindPipeline(
        VkCommandBuffer     commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipeline          pipeline);

    public unsafe delegate void CmdSetViewport(
        VkCommandBuffer commandBuffer,
        uint            firstViewport,
        uint            viewportCount,
        VkViewport*     pViewports);

    public unsafe delegate void CmdSetScissor(
        VkCommandBuffer commandBuffer,
        uint            firstScissor,
        uint            scissorCount,
        VkRect2D*       pScissors);

    public delegate void CmdSetLineWidth(
        VkCommandBuffer commandBuffer,
        float           lineWidth);

    public delegate void CmdSetDepthBias(
        VkCommandBuffer commandBuffer,
        float           depthBiasConstantFactor,
        float           depthBiasClamp,
        float           depthBiasSlopeFactor);

    public unsafe delegate void CmdSetBlendConstants(
        VkCommandBuffer commandBuffer,
        BlendConstants* blendConstants);

    public delegate void CmdSetDepthBounds(
        VkCommandBuffer commandBuffer,
        float           minDepthBounds,
        float           maxDepthBounds);

    public delegate void CmdSetStencilCompareMask(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               compareMask);

    public delegate void CmdSetStencilWriteMask(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               writeMask);

    public delegate void CmdSetStencilReference(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        uint               reference);

    public unsafe delegate void CmdBindDescriptorSets(
        VkCommandBuffer     commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipelineLayout    layout,
        uint                firstSet,
        uint                descriptorSetCount,
        VkDescriptorSet*    pDescriptorSets,
        uint                dynamicOffsetCount,
        uint*               pDynamicOffsets);

    public delegate void CmdBindIndexBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkIndexType     indexType);

    public unsafe delegate void CmdBindVertexBuffers(
        VkCommandBuffer commandBuffer,
        uint            firstBinding,
        uint            bindingCount,
        VkBuffer*       pBuffers,
        VkDeviceSize*   pOffsets);

    public delegate void CmdDraw(
        VkCommandBuffer commandBuffer,
        uint            vertexCount,
        uint            instanceCount,
        uint            firstVertex,
        uint            firstInstance);

    public delegate void CmdDrawIndexed(
        VkCommandBuffer commandBuffer,
        uint            indexCount,
        uint            instanceCount,
        uint            firstIndex,
        int             vertexOffset,
        uint            firstInstance);

    public delegate void CmdDrawIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        uint            drawCount,
        uint            stride);

    public delegate void CmdDrawIndexedIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        uint            drawCount,
        uint            stride);

    public delegate void CmdDispatch(
        VkCommandBuffer commandBuffer,
        uint            groupCountX,
        uint            groupCountY,
        uint            groupCountZ);

    public delegate void CmdDispatchIndirect(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset);

    public unsafe delegate void CmdCopyBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        srcBuffer,
        VkBuffer        dstBuffer,
        uint            regionCount,
        VkBufferCopy*   pRegions);

    public unsafe delegate void CmdCopyImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageCopy*    pRegions);

    public unsafe delegate void CmdBlitImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageBlit*    pRegions,
        VkFilter        filter);

    public unsafe delegate void CmdCopyBufferToImage(
        VkCommandBuffer    commandBuffer,
        VkBuffer           srcBuffer,
        VkImage            dstImage,
        VkImageLayout      dstImageLayout,
        uint               regionCount,
        VkBufferImageCopy* pRegions);

    public unsafe delegate void CmdCopyImageToBuffer(
        VkCommandBuffer    commandBuffer,
        VkImage            srcImage,
        VkImageLayout      srcImageLayout,
        VkBuffer           dstBuffer,
        uint               regionCount,
        VkBufferImageCopy* pRegions);

    public unsafe delegate void CmdUpdateBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        dstBuffer,
        VkDeviceSize    dstOffset,
        VkDeviceSize    dataSize,
        void*           pData);

    public delegate void CmdFillBuffer(
        VkCommandBuffer commandBuffer,
        VkBuffer        dstBuffer,
        VkDeviceSize    dstOffset,
        VkDeviceSize    size,
        uint            data);

    public unsafe delegate void CmdClearColorImage(
        VkCommandBuffer          commandBuffer,
        VkImage                  image,
        VkImageLayout            imageLayout,
        VkClearColorValue*       pColor,
        uint                     rangeCount,
        VkImageSubresourceRange* pRanges);

    public unsafe delegate void CmdClearDepthStencilImage(
        VkCommandBuffer           commandBuffer,
        VkImage                   image,
        VkImageLayout             imageLayout,
        VkClearDepthStencilValue* pDepthStencil,
        uint                      rangeCount,
        VkImageSubresourceRange*  pRanges);

    public unsafe delegate void CmdClearAttachments(
        VkCommandBuffer    commandBuffer,
        uint               attachmentCount,
        VkClearAttachment* pAttachments,
        uint               rectCount,
        VkClearRect*       pRects);

    public unsafe delegate void CmdResolveImage(
        VkCommandBuffer commandBuffer,
        VkImage         srcImage,
        VkImageLayout   srcImageLayout,
        VkImage         dstImage,
        VkImageLayout   dstImageLayout,
        uint            regionCount,
        VkImageResolve* pRegions);

    public delegate void CmdSetEvent(
        VkCommandBuffer      commandBuffer,
        VkEvent              @event,
        VkPipelineStageFlags stageMask);

    public delegate void CmdResetEvent(
        VkCommandBuffer      commandBuffer,
        VkEvent              @event,
        VkPipelineStageFlags stageMask);

    public unsafe delegate void CmdWaitEvents(
        VkCommandBuffer        commandBuffer,
        uint                   eventCount,
        VkEvent*               pEvents,
        VkPipelineStageFlags   srcStageMask,
        VkPipelineStageFlags   dstStageMask,
        uint                   memoryBarrierCount,
        VkMemoryBarrier*       pMemoryBarriers,
        uint                   bufferMemoryBarrierCount,
        VkBufferMemoryBarrier* pBufferMemoryBarriers,
        uint                   imageMemoryBarrierCount,
        VkImageMemoryBarrier*  pImageMemoryBarriers);

    public unsafe delegate void CmdPipelineBarrier(
        VkCommandBuffer        commandBuffer,
        VkPipelineStageFlags   srcStageMask,
        VkPipelineStageFlags   dstStageMask,
        VkDependencyFlags      dependencyFlags,
        uint                   memoryBarrierCount,
        VkMemoryBarrier*       pMemoryBarriers,
        uint                   bufferMemoryBarrierCount,
        VkBufferMemoryBarrier* pBufferMemoryBarriers,
        uint                   imageMemoryBarrierCount,
        VkImageMemoryBarrier*  pImageMemoryBarriers);

    public delegate void CmdBeginQuery(
        VkCommandBuffer     commandBuffer,
        VkQueryPool         queryPool,
        uint                query,
        VkQueryControlFlags flags);

    public delegate void CmdEndQuery(
        VkCommandBuffer commandBuffer,
        VkQueryPool     queryPool,
        uint            query);

    public delegate void CmdResetQueryPool(
        VkCommandBuffer commandBuffer,
        VkQueryPool     queryPool,
        uint            firstQuery,
        uint            queryCount);

    public delegate void CmdWriteTimestamp(
        VkCommandBuffer      commandBuffer,
        VkPipelineStageFlags pipelineStage,
        VkQueryPool          queryPool,
        uint                 query);

    public delegate void CmdCopyQueryPoolResults(
        VkCommandBuffer    commandBuffer,
        VkQueryPool        queryPool,
        uint               firstQuery,
        uint               queryCount,
        VkBuffer           dstBuffer,
        VkDeviceSize       dstOffset,
        VkDeviceSize       stride,
        VkQueryResultFlags flags);

    public unsafe delegate void CmdPushConstants(
        VkCommandBuffer    commandBuffer,
        VkPipelineLayout   layout,
        VkShaderStageFlags stageFlags,
        uint               offset,
        uint               size,
        void*              pValues);

    public unsafe delegate void CmdBeginRenderPass(
        VkCommandBuffer        commandBuffer,
        VkRenderPassBeginInfo* pRenderPassBegin,
        VkSubpassContents      contents);

    public delegate void CmdNextSubpass(
        VkCommandBuffer   commandBuffer,
        VkSubpassContents contents);

    public delegate void CmdEndRenderPass(VkCommandBuffer commandBuffer);

    public unsafe delegate void CmdExecuteCommands(
        VkCommandBuffer  commandBuffer,
        uint             commandBufferCount,
        VkCommandBuffer* pCommandBuffers);

    public unsafe delegate VkResult EnumerateInstanceVersion(uint* pApiVersion);

    public unsafe delegate VkResult BindBufferMemory2(
        VkDevice                device,
        uint                    bindInfoCount,
        VkBindBufferMemoryInfo* pBindInfos);

    public unsafe delegate VkResult BindImageMemory2(
        VkDevice               device,
        uint                   bindInfoCount,
        VkBindImageMemoryInfo* pBindInfos);

    public unsafe delegate void GetDeviceGroupPeerMemoryFeatures(
        VkDevice                  device,
        uint                      heapIndex,
        uint                      localDeviceIndex,
        uint                      remoteDeviceIndex,
        VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

    public delegate void CmdSetDeviceMask(
        VkCommandBuffer commandBuffer,
        uint            deviceMask);

    public delegate void CmdDispatchBase(
        VkCommandBuffer commandBuffer,
        uint            baseGroupX,
        uint            baseGroupY,
        uint            baseGroupZ,
        uint            groupCountX,
        uint            groupCountY,
        uint            groupCountZ);

    public unsafe delegate VkResult EnumeratePhysicalDeviceGroups(
        VkInstance                       instance,
        uint*                            pPhysicalDeviceGroupCount,
        VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

    public unsafe delegate void GetImageMemoryRequirements2(
        VkDevice                        device,
        VkImageMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*          pMemoryRequirements);

    public unsafe delegate void GetBufferMemoryRequirements2(
        VkDevice                         device,
        VkBufferMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*           pMemoryRequirements);

    public unsafe delegate void GetImageSparseMemoryRequirements2(
        VkDevice                              device,
        VkImageSparseMemoryRequirementsInfo2* pInfo,
        uint*                                 pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements2*     pSparseMemoryRequirements);

    public unsafe delegate void GetPhysicalDeviceFeatures2(
        VkPhysicalDevice           physicalDevice,
        VkPhysicalDeviceFeatures2* pFeatures);

    public unsafe delegate void GetPhysicalDeviceProperties2(
        VkPhysicalDevice             physicalDevice,
        VkPhysicalDeviceProperties2* pProperties);

    public unsafe delegate void GetPhysicalDeviceFormatProperties2(
        VkPhysicalDevice     physicalDevice,
        VkFormat             format,
        VkFormatProperties2* pFormatProperties);

    public unsafe delegate VkResult GetPhysicalDeviceImageFormatProperties2(
        VkPhysicalDevice                  physicalDevice,
        VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo,
        VkImageFormatProperties2*         pImageFormatProperties);

    public unsafe delegate void GetPhysicalDeviceQueueFamilyProperties2(
        VkPhysicalDevice          physicalDevice,
        uint*                     pQueueFamilyPropertyCount,
        VkQueueFamilyProperties2* pQueueFamilyProperties);

    public unsafe delegate void GetPhysicalDeviceMemoryProperties2(
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

    public unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2(
        VkPhysicalDevice                        physicalDevice,
        VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
        uint*                                   pPropertyCount,
        VkSparseImageFormatProperties2*         pProperties);

    public delegate void TrimCommandPool(
        VkDevice               device,
        VkCommandPool          commandPool,
        VkCommandPoolTrimFlags flags);

    public unsafe delegate void GetDeviceQueue2(
        VkDevice            device,
        VkDeviceQueueInfo2* pQueueInfo,
        VkQueue*            pQueue);

    public unsafe delegate VkResult CreateSamplerYcbcrConversion(
        VkDevice                            device,
        VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkSamplerYcbcrConversion*           pYcbcrConversion);

    public unsafe delegate void DestroySamplerYcbcrConversion(
        VkDevice                 device,
        VkSamplerYcbcrConversion ycbcrConversion,
        VkAllocationCallbacks*   pAllocator);

    public unsafe delegate VkResult CreateDescriptorUpdateTemplate(
        VkDevice                              device,
        VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
        VkAllocationCallbacks*                pAllocator,
        VkDescriptorUpdateTemplate*           pDescriptorUpdateTemplate);

    public unsafe delegate void DestroyDescriptorUpdateTemplate(
        VkDevice                   device,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        VkAllocationCallbacks*     pAllocator);

    public unsafe delegate void UpdateDescriptorSetWithTemplate(
        VkDevice                   device,
        VkDescriptorSet            descriptorSet,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        void*                      pData);

    public unsafe delegate void GetPhysicalDeviceExternalBufferProperties(
        VkPhysicalDevice                    physicalDevice,
        VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
        VkExternalBufferProperties*         pExternalBufferProperties);

    public unsafe delegate void GetPhysicalDeviceExternalFenceProperties(
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
        VkExternalFenceProperties*         pExternalFenceProperties);

    public unsafe delegate void GetPhysicalDeviceExternalSemaphoreProperties(
        VkPhysicalDevice                       physicalDevice,
        VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
        VkExternalSemaphoreProperties*         pExternalSemaphoreProperties);

    public unsafe delegate void GetDescriptorSetLayoutSupport(
        VkDevice                         device,
        VkDescriptorSetLayoutCreateInfo* pCreateInfo,
        VkDescriptorSetLayoutSupport*    pSupport);

    public delegate void CmdDrawIndirectCount(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public delegate void CmdDrawIndexedIndirectCount(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public unsafe delegate VkResult CreateRenderPass2(
        VkDevice                 device,
        VkRenderPassCreateInfo2* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkRenderPass*            pRenderPass);

    public unsafe delegate void CmdBeginRenderPass2(
        VkCommandBuffer        commandBuffer,
        VkRenderPassBeginInfo* pRenderPassBegin,
        VkSubpassBeginInfo*    pSubpassBeginInfo);

    public unsafe delegate void CmdNextSubpass2(
        VkCommandBuffer     commandBuffer,
        VkSubpassBeginInfo* pSubpassBeginInfo,
        VkSubpassEndInfo*   pSubpassEndInfo);

    public unsafe delegate void CmdEndRenderPass2(
        VkCommandBuffer   commandBuffer,
        VkSubpassEndInfo* pSubpassEndInfo);

    public delegate void ResetQueryPool(
        VkDevice    device,
        VkQueryPool queryPool,
        uint        firstQuery,
        uint        queryCount);

    public unsafe delegate VkResult GetSemaphoreCounterValue(
        VkDevice    device,
        VkSemaphore semaphore,
        ulong*      pValue);

    public unsafe delegate VkResult WaitSemaphores(
        VkDevice             device,
        VkSemaphoreWaitInfo* pWaitInfo,
        ulong                timeout);

    public unsafe delegate VkResult SignalSemaphore(
        VkDevice               device,
        VkSemaphoreSignalInfo* pSignalInfo);

    public unsafe delegate VkDeviceAddress GetBufferDeviceAddress(
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    public unsafe delegate ulong GetBufferOpaqueCaptureAddress(
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    public unsafe delegate ulong GetDeviceMemoryOpaqueCaptureAddress(
        VkDevice                                device,
        VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

    public unsafe delegate void DestroySurfaceKHR(
        VkInstance             instance,
        VkSurfaceKHR           surface,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceSupportKHR(
        VkPhysicalDevice physicalDevice,
        uint             queueFamilyIndex,
        VkSurfaceKHR     surface,
        uint*            pSupported);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(
        VkPhysicalDevice          physicalDevice,
        VkSurfaceKHR              surface,
        VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceFormatsKHR(
        VkPhysicalDevice    physicalDevice,
        VkSurfaceKHR        surface,
        uint*               pSurfaceFormatCount,
        VkSurfaceFormatKHR* pSurfaceFormats);

    public unsafe delegate VkResult GetPhysicalDeviceSurfacePresentModesKHR(
        VkPhysicalDevice  physicalDevice,
        VkSurfaceKHR      surface,
        uint*             pPresentModeCount,
        VkPresentModeKHR* pPresentModes);

    public unsafe delegate VkResult CreateSwapchainKHR(
        VkDevice                  device,
        VkSwapchainCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*    pAllocator,
        VkSwapchainKHR*           pSwapchain);

    public unsafe delegate void DestroySwapchainKHR(
        VkDevice               device,
        VkSwapchainKHR         swapchain,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult GetSwapchainImagesKHR(
        VkDevice       device,
        VkSwapchainKHR swapchain,
        uint*          pSwapchainImageCount,
        VkImage*       pSwapchainImages);

    public unsafe delegate VkResult AcquireNextImageKHR(
        VkDevice       device,
        VkSwapchainKHR swapchain,
        ulong          timeout,
        VkSemaphore    semaphore,
        VkFence        fence,
        uint*          pImageIndex);

    public unsafe delegate VkResult QueuePresentKHR(
        VkQueue           queue,
        VkPresentInfoKHR* pPresentInfo);

    public unsafe delegate VkResult GetDeviceGroupPresentCapabilitiesKHR(
        VkDevice                             device,
        VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

    public unsafe delegate VkResult GetDeviceGroupSurfacePresentModesKHR(
        VkDevice                          device,
        VkSurfaceKHR                      surface,
        VkDeviceGroupPresentModeFlagsKHR* pModes);

    public unsafe delegate VkResult GetPhysicalDevicePresentRectanglesKHR(
        VkPhysicalDevice physicalDevice,
        VkSurfaceKHR     surface,
        uint*            pRectCount,
        VkRect2D*        pRects);

    public unsafe delegate VkResult AcquireNextImage2KHR(
        VkDevice                   device,
        VkAcquireNextImageInfoKHR* pAcquireInfo,
        uint*                      pImageIndex);

    public unsafe delegate VkResult GetPhysicalDeviceDisplayPropertiesKHR(
        VkPhysicalDevice        physicalDevice,
        uint*                   pPropertyCount,
        VkDisplayPropertiesKHR* pProperties);

    public unsafe delegate VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(
        VkPhysicalDevice             physicalDevice,
        uint*                        pPropertyCount,
        VkDisplayPlanePropertiesKHR* pProperties);

    public unsafe delegate VkResult GetDisplayPlaneSupportedDisplaysKHR(
        VkPhysicalDevice physicalDevice,
        uint             planeIndex,
        uint*            pDisplayCount,
        VkDisplayKHR*    pDisplays);

    public unsafe delegate VkResult GetDisplayModePropertiesKHR(
        VkPhysicalDevice            physicalDevice,
        VkDisplayKHR                display,
        uint*                       pPropertyCount,
        VkDisplayModePropertiesKHR* pProperties);

    public unsafe delegate VkResult CreateDisplayModeKHR(
        VkPhysicalDevice            physicalDevice,
        VkDisplayKHR                display,
        VkDisplayModeCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*      pAllocator,
        VkDisplayModeKHR*           pMode);

    public unsafe delegate VkResult GetDisplayPlaneCapabilitiesKHR(
        VkPhysicalDevice               physicalDevice,
        VkDisplayModeKHR               mode,
        uint                           planeIndex,
        VkDisplayPlaneCapabilitiesKHR* pCapabilities);

    public unsafe delegate VkResult CreateDisplayPlaneSurfaceKHR(
        VkInstance                     instance,
        VkDisplaySurfaceCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*         pAllocator,
        VkSurfaceKHR*                  pSurface);

    public unsafe delegate VkResult CreateSharedSwapchainsKHR(
        VkDevice                  device,
        uint                      swapchainCount,
        VkSwapchainCreateInfoKHR* pCreateInfos,
        VkAllocationCallbacks*    pAllocator,
        VkSwapchainKHR*           pSwapchains);

    public unsafe delegate void GetPhysicalDeviceFeatures2KHR(
        VkPhysicalDevice           physicalDevice,
        VkPhysicalDeviceFeatures2* pFeatures);

    public unsafe delegate void GetPhysicalDeviceProperties2KHR(
        VkPhysicalDevice             physicalDevice,
        VkPhysicalDeviceProperties2* pProperties);

    public unsafe delegate void GetPhysicalDeviceFormatProperties2KHR(
        VkPhysicalDevice     physicalDevice,
        VkFormat             format,
        VkFormatProperties2* pFormatProperties);

    public unsafe delegate VkResult GetPhysicalDeviceImageFormatProperties2KHR(
        VkPhysicalDevice                  physicalDevice,
        VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo,
        VkImageFormatProperties2*         pImageFormatProperties);

    public unsafe delegate void GetPhysicalDeviceQueueFamilyProperties2KHR(
        VkPhysicalDevice          physicalDevice,
        uint*                     pQueueFamilyPropertyCount,
        VkQueueFamilyProperties2* pQueueFamilyProperties);

    public unsafe delegate void GetPhysicalDeviceMemoryProperties2KHR(
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

    public unsafe delegate void GetPhysicalDeviceSparseImageFormatProperties2KHR(
        VkPhysicalDevice                        physicalDevice,
        VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
        uint*                                   pPropertyCount,
        VkSparseImageFormatProperties2*         pProperties);

    public unsafe delegate void GetDeviceGroupPeerMemoryFeaturesKHR(
        VkDevice                  device,
        uint                      heapIndex,
        uint                      localDeviceIndex,
        uint                      remoteDeviceIndex,
        VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

    public delegate void CmdSetDeviceMaskKHR(
        VkCommandBuffer commandBuffer,
        uint            deviceMask);

    public delegate void CmdDispatchBaseKHR(
        VkCommandBuffer commandBuffer,
        uint            baseGroupX,
        uint            baseGroupY,
        uint            baseGroupZ,
        uint            groupCountX,
        uint            groupCountY,
        uint            groupCountZ);

    public delegate void TrimCommandPoolKHR(
        VkDevice               device,
        VkCommandPool          commandPool,
        VkCommandPoolTrimFlags flags);

    public unsafe delegate VkResult EnumeratePhysicalDeviceGroupsKHR(
        VkInstance                       instance,
        uint*                            pPhysicalDeviceGroupCount,
        VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

    public unsafe delegate void GetPhysicalDeviceExternalBufferPropertiesKHR(
        VkPhysicalDevice                    physicalDevice,
        VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
        VkExternalBufferProperties*         pExternalBufferProperties);

    public unsafe delegate VkResult GetMemoryFdKHR(
        VkDevice              device,
        VkMemoryGetFdInfoKHR* pGetFdInfo,
        int*                  pFd);

    public unsafe delegate VkResult GetMemoryFdPropertiesKHR(
        VkDevice                        device,
        VkExternalMemoryHandleTypeFlags handleType,
        int                             fd,
        VkMemoryFdPropertiesKHR*        pMemoryFdProperties);

    public unsafe delegate void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
        VkPhysicalDevice                       physicalDevice,
        VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
        VkExternalSemaphoreProperties*         pExternalSemaphoreProperties);

    public unsafe delegate VkResult ImportSemaphoreFdKHR(
        VkDevice                    device,
        VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

    public unsafe delegate VkResult GetSemaphoreFdKHR(
        VkDevice                 device,
        VkSemaphoreGetFdInfoKHR* pGetFdInfo,
        int*                     pFd);

    public unsafe delegate void CmdPushDescriptorSetKHR(
        VkCommandBuffer       commandBuffer,
        VkPipelineBindPoint   pipelineBindPoint,
        VkPipelineLayout      layout,
        uint                  set,
        uint                  descriptorWriteCount,
        VkWriteDescriptorSet* pDescriptorWrites);

    public unsafe delegate void CmdPushDescriptorSetWithTemplateKHR(
        VkCommandBuffer            commandBuffer,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        VkPipelineLayout           layout,
        uint                       set,
        void*                      pData);

    public unsafe delegate VkResult CreateDescriptorUpdateTemplateKHR(
        VkDevice                              device,
        VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
        VkAllocationCallbacks*                pAllocator,
        VkDescriptorUpdateTemplate*           pDescriptorUpdateTemplate);

    public unsafe delegate void DestroyDescriptorUpdateTemplateKHR(
        VkDevice                   device,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        VkAllocationCallbacks*     pAllocator);

    public unsafe delegate void UpdateDescriptorSetWithTemplateKHR(
        VkDevice                   device,
        VkDescriptorSet            descriptorSet,
        VkDescriptorUpdateTemplate descriptorUpdateTemplate,
        void*                      pData);

    public unsafe delegate VkResult CreateRenderPass2KHR(
        VkDevice                 device,
        VkRenderPassCreateInfo2* pCreateInfo,
        VkAllocationCallbacks*   pAllocator,
        VkRenderPass*            pRenderPass);

    public unsafe delegate void CmdBeginRenderPass2KHR(
        VkCommandBuffer        commandBuffer,
        VkRenderPassBeginInfo* pRenderPassBegin,
        VkSubpassBeginInfo*    pSubpassBeginInfo);

    public unsafe delegate void CmdNextSubpass2KHR(
        VkCommandBuffer     commandBuffer,
        VkSubpassBeginInfo* pSubpassBeginInfo,
        VkSubpassEndInfo*   pSubpassEndInfo);

    public unsafe delegate void CmdEndRenderPass2KHR(
        VkCommandBuffer   commandBuffer,
        VkSubpassEndInfo* pSubpassEndInfo);

    public delegate VkResult GetSwapchainStatusKHR(
        VkDevice       device,
        VkSwapchainKHR swapchain);

    public unsafe delegate void GetPhysicalDeviceExternalFencePropertiesKHR(
        VkPhysicalDevice                   physicalDevice,
        VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
        VkExternalFenceProperties*         pExternalFenceProperties);

    public unsafe delegate VkResult ImportFenceFdKHR(
        VkDevice                device,
        VkImportFenceFdInfoKHR* pImportFenceFdInfo);

    public unsafe delegate VkResult GetFenceFdKHR(
        VkDevice             device,
        VkFenceGetFdInfoKHR* pGetFdInfo,
        int*                 pFd);

    public unsafe delegate VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
        VkPhysicalDevice                    physicalDevice,
        uint                                queueFamilyIndex,
        uint*                               pCounterCount,
        VkPerformanceCounterKHR*            pCounters,
        VkPerformanceCounterDescriptionKHR* pCounterDescriptions);

    public unsafe delegate void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
        VkPhysicalDevice                     physicalDevice,
        VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo,
        uint*                                pNumPasses);

    public unsafe delegate VkResult AcquireProfilingLockKHR(
        VkDevice                       device,
        VkAcquireProfilingLockInfoKHR* pInfo);

    public delegate void ReleaseProfilingLockKHR(VkDevice device);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(
        VkPhysicalDevice                 physicalDevice,
        VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        VkSurfaceCapabilities2KHR*       pSurfaceCapabilities);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceFormats2KHR(
        VkPhysicalDevice                 physicalDevice,
        VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
        uint*                            pSurfaceFormatCount,
        VkSurfaceFormat2KHR*             pSurfaceFormats);

    public unsafe delegate VkResult GetPhysicalDeviceDisplayProperties2KHR(
        VkPhysicalDevice         physicalDevice,
        uint*                    pPropertyCount,
        VkDisplayProperties2KHR* pProperties);

    public unsafe delegate VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(
        VkPhysicalDevice              physicalDevice,
        uint*                         pPropertyCount,
        VkDisplayPlaneProperties2KHR* pProperties);

    public unsafe delegate VkResult GetDisplayModeProperties2KHR(
        VkPhysicalDevice             physicalDevice,
        VkDisplayKHR                 display,
        uint*                        pPropertyCount,
        VkDisplayModeProperties2KHR* pProperties);

    public unsafe delegate VkResult GetDisplayPlaneCapabilities2KHR(
        VkPhysicalDevice                physicalDevice,
        VkDisplayPlaneInfo2KHR*         pDisplayPlaneInfo,
        VkDisplayPlaneCapabilities2KHR* pCapabilities);

    public unsafe delegate void GetImageMemoryRequirements2KHR(
        VkDevice                        device,
        VkImageMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*          pMemoryRequirements);

    public unsafe delegate void GetBufferMemoryRequirements2KHR(
        VkDevice                         device,
        VkBufferMemoryRequirementsInfo2* pInfo,
        VkMemoryRequirements2*           pMemoryRequirements);

    public unsafe delegate void GetImageSparseMemoryRequirements2KHR(
        VkDevice                              device,
        VkImageSparseMemoryRequirementsInfo2* pInfo,
        uint*                                 pSparseMemoryRequirementCount,
        VkSparseImageMemoryRequirements2*     pSparseMemoryRequirements);

    public unsafe delegate VkResult CreateSamplerYcbcrConversionKHR(
        VkDevice                            device,
        VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkSamplerYcbcrConversion*           pYcbcrConversion);

    public unsafe delegate void DestroySamplerYcbcrConversionKHR(
        VkDevice                 device,
        VkSamplerYcbcrConversion ycbcrConversion,
        VkAllocationCallbacks*   pAllocator);

    public unsafe delegate VkResult BindBufferMemory2KHR(
        VkDevice                device,
        uint                    bindInfoCount,
        VkBindBufferMemoryInfo* pBindInfos);

    public unsafe delegate VkResult BindImageMemory2KHR(
        VkDevice               device,
        uint                   bindInfoCount,
        VkBindImageMemoryInfo* pBindInfos);

    public unsafe delegate void GetDescriptorSetLayoutSupportKHR(
        VkDevice                         device,
        VkDescriptorSetLayoutCreateInfo* pCreateInfo,
        VkDescriptorSetLayoutSupport*    pSupport);

    public delegate void CmdDrawIndirectCountKHR(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public delegate void CmdDrawIndexedIndirectCountKHR(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public unsafe delegate VkResult GetSemaphoreCounterValueKHR(
        VkDevice    device,
        VkSemaphore semaphore,
        ulong*      pValue);

    public unsafe delegate VkResult WaitSemaphoresKHR(
        VkDevice             device,
        VkSemaphoreWaitInfo* pWaitInfo,
        ulong                timeout);

    public unsafe delegate VkResult SignalSemaphoreKHR(
        VkDevice               device,
        VkSemaphoreSignalInfo* pSignalInfo);

    public unsafe delegate VkResult GetPhysicalDeviceFragmentShadingRatesKHR(
        VkPhysicalDevice                        physicalDevice,
        uint*                                   pFragmentShadingRateCount,
        VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);

    public unsafe delegate void CmdSetFragmentShadingRateKHR(
        VkCommandBuffer                    commandBuffer,
        VkExtent2D*                        pFragmentSize,
        VkFragmentShadingRateCombinerOpKHR combinerOps1,
        VkFragmentShadingRateCombinerOpKHR combinerOps2);

    public unsafe delegate VkDeviceAddress GetBufferDeviceAddressKHR(
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    public unsafe delegate ulong GetBufferOpaqueCaptureAddressKHR(
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    public unsafe delegate ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
        VkDevice                                device,
        VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

    public unsafe delegate VkResult CreateDeferredOperationKHR(
        VkDevice                device,
        VkAllocationCallbacks*  pAllocator,
        VkDeferredOperationKHR* pDeferredOperation);

    public unsafe delegate void DestroyDeferredOperationKHR(
        VkDevice               device,
        VkDeferredOperationKHR operation,
        VkAllocationCallbacks* pAllocator);

    public delegate uint GetDeferredOperationMaxConcurrencyKHR(
        VkDevice               device,
        VkDeferredOperationKHR operation);

    public delegate VkResult GetDeferredOperationResultKHR(
        VkDevice               device,
        VkDeferredOperationKHR operation);

    public delegate VkResult DeferredOperationJoinKHR(
        VkDevice               device,
        VkDeferredOperationKHR operation);

    public unsafe delegate VkResult GetPipelineExecutablePropertiesKHR(
        VkDevice                           device,
        VkPipelineInfoKHR*                 pPipelineInfo,
        uint*                              pExecutableCount,
        VkPipelineExecutablePropertiesKHR* pProperties);

    public unsafe delegate VkResult GetPipelineExecutableStatisticsKHR(
        VkDevice                          device,
        VkPipelineExecutableInfoKHR*      pExecutableInfo,
        uint*                             pStatisticCount,
        VkPipelineExecutableStatisticKHR* pStatistics);

    public unsafe delegate VkResult GetPipelineExecutableInternalRepresentationsKHR(
        VkDevice                                       device,
        VkPipelineExecutableInfoKHR*                   pExecutableInfo,
        uint*                                          pInternalRepresentationCount,
        VkPipelineExecutableInternalRepresentationKHR* pInternalRepresentations);

    public unsafe delegate void CmdCopyBuffer2KHR(
        VkCommandBuffer       commandBuffer,
        VkCopyBufferInfo2KHR* pCopyBufferInfo);

    public unsafe delegate void CmdCopyImage2KHR(
        VkCommandBuffer      commandBuffer,
        VkCopyImageInfo2KHR* pCopyImageInfo);

    public unsafe delegate void CmdCopyBufferToImage2KHR(
        VkCommandBuffer              commandBuffer,
        VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);

    public unsafe delegate void CmdCopyImageToBuffer2KHR(
        VkCommandBuffer              commandBuffer,
        VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);

    public unsafe delegate void CmdBlitImage2KHR(
        VkCommandBuffer      commandBuffer,
        VkBlitImageInfo2KHR* pBlitImageInfo);

    public unsafe delegate void CmdResolveImage2KHR(
        VkCommandBuffer         commandBuffer,
        VkResolveImageInfo2KHR* pResolveImageInfo);

    [return: MarshalAs(UnmanagedType.Bool)]
    public unsafe delegate VkBool32 DebugReportCallbackEXT(
        [MarshalAs(UnmanagedType.U4)] VkDebugReportFlagsEXT      flags,
        [MarshalAs(UnmanagedType.U4)] VkDebugReportObjectTypeEXT objectType,
        ulong                                                    @object,
        nuint                                                    location,
        int                                                      messageCode,
        sbyte*                                                   pLayerPrefix,
        sbyte*                                                   pMessage,
        void*                                                    pUserData);

    public unsafe delegate VkResult CreateDebugReportCallbackEXT(
        VkInstance                          instance,
        VkDebugReportCallbackCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkDebugReportCallbackEXT*           pCallback);

    public unsafe delegate void DestroyDebugReportCallbackEXT(
        VkInstance               instance,
        VkDebugReportCallbackEXT callback,
        VkAllocationCallbacks*   pAllocator);

    public unsafe delegate void DebugReportMessageEXT(
        VkInstance                 instance,
        VkDebugReportFlagsEXT      flags,
        VkDebugReportObjectTypeEXT objectType,
        ulong                      @object,
        size_t                     location,
        int                        messageCode,
        sbyte*                     pLayerPrefix,
        sbyte*                     pMessage);

    public unsafe delegate VkResult DebugMarkerSetObjectTagEXT(
        VkDevice                       device,
        VkDebugMarkerObjectTagInfoEXT* pTagInfo);

    public unsafe delegate VkResult DebugMarkerSetObjectNameEXT(
        VkDevice                        device,
        VkDebugMarkerObjectNameInfoEXT* pNameInfo);

    public unsafe delegate void CmdDebugMarkerBeginEXT(
        VkCommandBuffer             commandBuffer,
        VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

    public delegate void CmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer);

    public unsafe delegate void CmdDebugMarkerInsertEXT(
        VkCommandBuffer             commandBuffer,
        VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

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
        VkCommandBuffer     commandBuffer,
        VkQueryPool         queryPool,
        uint                query,
        VkQueryControlFlags flags,
        uint                index);

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

    public unsafe delegate uint GetImageViewHandleNVX(
        VkDevice                  device,
        VkImageViewHandleInfoNVX* pInfo);

    public unsafe delegate VkResult GetImageViewAddressNVX(
        VkDevice                         device,
        VkImageView                      imageView,
        VkImageViewAddressPropertiesNVX* pProperties);

    public delegate void CmdDrawIndirectCountAMD(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public delegate void CmdDrawIndexedIndirectCountAMD(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public unsafe delegate VkResult GetShaderInfoAMD(
        VkDevice            device,
        VkPipeline          pipeline,
        VkShaderStageFlags  shaderStage,
        VkShaderInfoTypeAMD infoType,
        size_t*             pInfoSize,
        void*               pInfo);

    public unsafe delegate VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(
        VkPhysicalDevice                   physicalDevice,
        VkFormat                           format,
        VkImageType                        type,
        VkImageTiling                      tiling,
        VkImageUsageFlags                  usage,
        VkImageCreateFlags                 flags,
        VkExternalMemoryHandleTypeFlagsNV  externalHandleType,
        VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

    public unsafe delegate void CmdBeginConditionalRenderingEXT(
        VkCommandBuffer                     commandBuffer,
        VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

    public delegate void CmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer);

    public unsafe delegate void CmdSetViewportWScalingNV(
        VkCommandBuffer       commandBuffer,
        uint                  firstViewport,
        uint                  viewportCount,
        VkViewportWScalingNV* pViewportWScalings);

    public delegate VkResult ReleaseDisplayEXT(
        VkPhysicalDevice physicalDevice,
        VkDisplayKHR     display);

    public unsafe delegate VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(
        VkPhysicalDevice           physicalDevice,
        VkSurfaceKHR               surface,
        VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

    public unsafe delegate VkResult DisplayPowerControlEXT(
        VkDevice               device,
        VkDisplayKHR           display,
        VkDisplayPowerInfoEXT* pDisplayPowerInfo);

    public unsafe delegate VkResult RegisterDeviceEventEXT(
        VkDevice               device,
        VkDeviceEventInfoEXT*  pDeviceEventInfo,
        VkAllocationCallbacks* pAllocator,
        VkFence*               pFence);

    public unsafe delegate VkResult RegisterDisplayEventEXT(
        VkDevice               device,
        VkDisplayKHR           display,
        VkDisplayEventInfoEXT* pDisplayEventInfo,
        VkAllocationCallbacks* pAllocator,
        VkFence*               pFence);

    public unsafe delegate VkResult GetSwapchainCounterEXT(
        VkDevice                 device,
        VkSwapchainKHR           swapchain,
        VkSurfaceCounterFlagsEXT counter,
        ulong*                   pCounterValue);

    public unsafe delegate VkResult GetRefreshCycleDurationGOOGLE(
        VkDevice                      device,
        VkSwapchainKHR                swapchain,
        VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

    public unsafe delegate VkResult GetPastPresentationTimingGOOGLE(
        VkDevice                        device,
        VkSwapchainKHR                  swapchain,
        uint*                           pPresentationTimingCount,
        VkPastPresentationTimingGOOGLE* pPresentationTimings);

    public unsafe delegate void CmdSetDiscardRectangleEXT(
        VkCommandBuffer commandBuffer,
        uint            firstDiscardRectangle,
        uint            discardRectangleCount,
        VkRect2D*       pDiscardRectangles);

    public unsafe delegate void SetHdrMetadataEXT(
        VkDevice          device,
        uint              swapchainCount,
        VkSwapchainKHR*   pSwapchains,
        VkHdrMetadataEXT* pMetadata);

    [return: MarshalAs(UnmanagedType.Bool)]
    public unsafe delegate VkBool32 DebugUtilsMessengerCallbackEXT(
        [MarshalAs(UnmanagedType.U4)] VkDebugUtilsMessageSeverityFlagsEXT messageSeverity,
        [MarshalAs(UnmanagedType.U4)] VkDebugUtilsMessageTypeFlagsEXT     messageTypes,
        VkDebugUtilsMessengerCallbackDataEXT*                             pCallbackData,
        void*                                                             pUserData);

    public unsafe delegate VkResult SetDebugUtilsObjectNameEXT(
        VkDevice                       device,
        VkDebugUtilsObjectNameInfoEXT* pNameInfo);

    public unsafe delegate VkResult SetDebugUtilsObjectTagEXT(
        VkDevice                      device,
        VkDebugUtilsObjectTagInfoEXT* pTagInfo);

    public unsafe delegate void QueueBeginDebugUtilsLabelEXT(
        VkQueue               queue,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public delegate void QueueEndDebugUtilsLabelEXT(VkQueue queue);

    public unsafe delegate void QueueInsertDebugUtilsLabelEXT(
        VkQueue               queue,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public unsafe delegate void CmdBeginDebugUtilsLabelEXT(
        VkCommandBuffer       commandBuffer,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public delegate void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer);

    public unsafe delegate void CmdInsertDebugUtilsLabelEXT(
        VkCommandBuffer       commandBuffer,
        VkDebugUtilsLabelEXT* pLabelInfo);

    public unsafe delegate VkResult CreateDebugUtilsMessengerEXT(
        VkInstance                          instance,
        VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*              pAllocator,
        VkDebugUtilsMessengerEXT*           pMessenger);

    public unsafe delegate void DestroyDebugUtilsMessengerEXT(
        VkInstance               instance,
        VkDebugUtilsMessengerEXT messenger,
        VkAllocationCallbacks*   pAllocator);

    public unsafe delegate void SubmitDebugUtilsMessageEXT(
        VkInstance                            instance,
        VkDebugUtilsMessageSeverityFlagsEXT   messageSeverity,
        VkDebugUtilsMessageTypeFlagsEXT       messageTypes,
        VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

    public unsafe delegate void CmdSetSampleLocationsEXT(
        VkCommandBuffer           commandBuffer,
        VkSampleLocationsInfoEXT* pSampleLocationsInfo);

    public unsafe delegate void GetPhysicalDeviceMultisamplePropertiesEXT(
        VkPhysicalDevice            physicalDevice,
        VkSampleCountFlags          samples,
        VkMultisamplePropertiesEXT* pMultisampleProperties);

    public unsafe delegate VkResult GetImageDrmFormatModifierPropertiesEXT(
        VkDevice                               device,
        VkImage                                image,
        VkImageDrmFormatModifierPropertiesEXT* pProperties);

    public unsafe delegate VkResult CreateValidationCacheEXT(
        VkDevice                        device,
        VkValidationCacheCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*          pAllocator,
        VkValidationCacheEXT*           pValidationCache);

    public unsafe delegate void DestroyValidationCacheEXT(
        VkDevice               device,
        VkValidationCacheEXT   validationCache,
        VkAllocationCallbacks* pAllocator);

    public unsafe delegate VkResult MergeValidationCachesEXT(
        VkDevice              device,
        VkValidationCacheEXT  dstCache,
        uint                  srcCacheCount,
        VkValidationCacheEXT* pSrcCaches);

    public unsafe delegate VkResult GetValidationCacheDataEXT(
        VkDevice             device,
        VkValidationCacheEXT validationCache,
        size_t*              pDataSize,
        void*                pData);

    public delegate void CmdBindShadingRateImageNV(
        VkCommandBuffer commandBuffer,
        VkImageView     imageView,
        VkImageLayout   imageLayout);

    public unsafe delegate void CmdSetViewportShadingRatePaletteNV(
        VkCommandBuffer         commandBuffer,
        uint                    firstViewport,
        uint                    viewportCount,
        VkShadingRatePaletteNV* pShadingRatePalettes);

    public unsafe delegate void CmdSetCoarseSampleOrderNV(
        VkCommandBuffer              commandBuffer,
        VkCoarseSampleOrderTypeNV    sampleOrderType,
        uint                         customSampleOrderCount,
        VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

    public unsafe delegate VkResult CreateAccelerationStructureNV(
        VkDevice                             device,
        VkAccelerationStructureCreateInfoNV* pCreateInfo,
        VkAllocationCallbacks*               pAllocator,
        VkAccelerationStructureNV*           pAccelerationStructure);

    public unsafe delegate void DestroyAccelerationStructureNV(
        VkDevice                  device,
        VkAccelerationStructureNV accelerationStructure,
        VkAllocationCallbacks*    pAllocator);

    public unsafe delegate void GetAccelerationStructureMemoryRequirementsNV(
        VkDevice                                         device,
        VkAccelerationStructureMemoryRequirementsInfoNV* pInfo,
        VkMemoryRequirements2KHR*                        pMemoryRequirements);

    public unsafe delegate VkResult BindAccelerationStructureMemoryNV(
        VkDevice                                 device,
        uint                                     bindInfoCount,
        VkBindAccelerationStructureMemoryInfoNV* pBindInfos);

    public unsafe delegate void CmdBuildAccelerationStructureNV(
        VkCommandBuffer                commandBuffer,
        VkAccelerationStructureInfoNV* pInfo,
        VkBuffer                       instanceData,
        VkDeviceSize                   instanceOffset,
        uint                           update,
        VkAccelerationStructureNV      dst,
        VkAccelerationStructureNV      src,
        VkBuffer                       scratch,
        VkDeviceSize                   scratchOffset);

    public delegate void CmdCopyAccelerationStructureNV(
        VkCommandBuffer                    commandBuffer,
        VkAccelerationStructureNV          dst,
        VkAccelerationStructureNV          src,
        VkCopyAccelerationStructureModeKHR mode);

    public delegate void CmdTraceRaysNV(
        VkCommandBuffer commandBuffer,
        VkBuffer        raygenShaderBindingTableBuffer,
        VkDeviceSize    raygenShaderBindingOffset,
        VkBuffer        missShaderBindingTableBuffer,
        VkDeviceSize    missShaderBindingOffset,
        VkDeviceSize    missShaderBindingStride,
        VkBuffer        hitShaderBindingTableBuffer,
        VkDeviceSize    hitShaderBindingOffset,
        VkDeviceSize    hitShaderBindingStride,
        VkBuffer        callableShaderBindingTableBuffer,
        VkDeviceSize    callableShaderBindingOffset,
        VkDeviceSize    callableShaderBindingStride,
        uint            width,
        uint            height,
        uint            depth);

    public unsafe delegate VkResult CreateRayTracingPipelinesNV(
        VkDevice                          device,
        VkPipelineCache                   pipelineCache,
        uint                              createInfoCount,
        VkRayTracingPipelineCreateInfoNV* pCreateInfos,
        VkAllocationCallbacks*            pAllocator,
        VkPipeline*                       pPipelines);

    public unsafe delegate VkResult GetRayTracingShaderGroupHandlesKHR(
        VkDevice   device,
        VkPipeline pipeline,
        uint       firstGroup,
        uint       groupCount,
        size_t     dataSize,
        void*      pData);

    public unsafe delegate VkResult GetRayTracingShaderGroupHandlesNV(
        VkDevice   device,
        VkPipeline pipeline,
        uint       firstGroup,
        uint       groupCount,
        size_t     dataSize,
        void*      pData);

    public unsafe delegate VkResult GetAccelerationStructureHandleNV(
        VkDevice                  device,
        VkAccelerationStructureNV accelerationStructure,
        size_t                    dataSize,
        void*                     pData);

    public unsafe delegate void CmdWriteAccelerationStructuresPropertiesNV(
        VkCommandBuffer            commandBuffer,
        uint                       accelerationStructureCount,
        VkAccelerationStructureNV* pAccelerationStructures,
        VkQueryType                queryType,
        VkQueryPool                queryPool,
        uint                       firstQuery);

    public delegate VkResult CompileDeferredNV(
        VkDevice   device,
        VkPipeline pipeline,
        uint       shader);

    public unsafe delegate VkResult GetMemoryHostPointerPropertiesEXT(
        VkDevice                          device,
        VkExternalMemoryHandleTypeFlags   handleType,
        void*                             pHostPointer,
        VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

    public delegate void CmdWriteBufferMarkerAMD(
        VkCommandBuffer      commandBuffer,
        VkPipelineStageFlags pipelineStage,
        VkBuffer             dstBuffer,
        VkDeviceSize         dstOffset,
        uint                 marker);

    public unsafe delegate VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(
        VkPhysicalDevice physicalDevice,
        uint*            pTimeDomainCount,
        VkTimeDomainEXT* pTimeDomains);

    public unsafe delegate VkResult GetCalibratedTimestampsEXT(
        VkDevice                      device,
        uint                          timestampCount,
        VkCalibratedTimestampInfoEXT* pTimestampInfos,
        ulong*                        pTimestamps,
        ulong*                        pMaxDeviation);

    public delegate void CmdDrawMeshTasksNV(
        VkCommandBuffer commandBuffer,
        uint            taskCount,
        uint            firstTask);

    public delegate void CmdDrawMeshTasksIndirectNV(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        uint            drawCount,
        uint            stride);

    public delegate void CmdDrawMeshTasksIndirectCountNV(
        VkCommandBuffer commandBuffer,
        VkBuffer        buffer,
        VkDeviceSize    offset,
        VkBuffer        countBuffer,
        VkDeviceSize    countBufferOffset,
        uint            maxDrawCount,
        uint            stride);

    public unsafe delegate void CmdSetExclusiveScissorNV(
        VkCommandBuffer commandBuffer,
        uint            firstExclusiveScissor,
        uint            exclusiveScissorCount,
        VkRect2D*       pExclusiveScissors);

    public unsafe delegate void CmdSetCheckpointNV(
        VkCommandBuffer commandBuffer,
        void*           pCheckpointMarker);

    public unsafe delegate void GetQueueCheckpointDataNV(
        VkQueue             queue,
        uint*               pCheckpointDataCount,
        VkCheckpointDataNV* pCheckpointData);

    public unsafe delegate VkResult InitializePerformanceApiINTEL(
        VkDevice                             device,
        VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

    public delegate void UninitializePerformanceApiINTEL(VkDevice device);

    public unsafe delegate VkResult CmdSetPerformanceMarkerINTEL(
        VkCommandBuffer               commandBuffer,
        VkPerformanceMarkerInfoINTEL* pMarkerInfo);

    public unsafe delegate VkResult CmdSetPerformanceStreamMarkerINTEL(
        VkCommandBuffer                     commandBuffer,
        VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

    public unsafe delegate VkResult CmdSetPerformanceOverrideINTEL(
        VkCommandBuffer                 commandBuffer,
        VkPerformanceOverrideInfoINTEL* pOverrideInfo);

    public unsafe delegate VkResult AcquirePerformanceConfigurationINTEL(
        VkDevice                                    device,
        VkPerformanceConfigurationAcquireInfoINTEL* pAcquireInfo,
        VkPerformanceConfigurationINTEL*            pConfiguration);

    public delegate VkResult ReleasePerformanceConfigurationINTEL(
        VkDevice                        device,
        VkPerformanceConfigurationINTEL configuration);

    public delegate VkResult QueueSetPerformanceConfigurationINTEL(
        VkQueue                         queue,
        VkPerformanceConfigurationINTEL configuration);

    public unsafe delegate VkResult GetPerformanceParameterINTEL(
        VkDevice                        device,
        VkPerformanceParameterTypeINTEL parameter,
        VkPerformanceValueINTEL*        pValue);

    public delegate void SetLocalDimmingAMD(
        VkDevice       device,
        VkSwapchainKHR swapChain,
        uint           localDimmingEnable);

    public unsafe delegate VkDeviceAddress GetBufferDeviceAddressEXT(
        VkDevice                   device,
        VkBufferDeviceAddressInfo* pInfo);

    public unsafe delegate VkResult GetPhysicalDeviceToolPropertiesEXT(
        VkPhysicalDevice                   physicalDevice,
        uint*                              pToolCount,
        VkPhysicalDeviceToolPropertiesEXT* pToolProperties);

    public unsafe delegate VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(
        VkPhysicalDevice                 physicalDevice,
        uint*                            pPropertyCount,
        VkCooperativeMatrixPropertiesNV* pProperties);

    public unsafe delegate VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
        VkPhysicalDevice                        physicalDevice,
        uint*                                   pCombinationCount,
        VkFramebufferMixedSamplesCombinationNV* pCombinations);

    public unsafe delegate VkResult CreateHeadlessSurfaceEXT(
        VkInstance                      instance,
        VkHeadlessSurfaceCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*          pAllocator,
        VkSurfaceKHR*                   pSurface);

    public delegate void CmdSetLineStippleEXT(
        VkCommandBuffer commandBuffer,
        uint            lineStippleFactor,
        ushort          lineStipplePattern);

    public delegate void ResetQueryPoolEXT(
        VkDevice    device,
        VkQueryPool queryPool,
        uint        firstQuery,
        uint        queryCount);

    public delegate void CmdSetCullModeEXT(
        VkCommandBuffer commandBuffer,
        VkCullModeFlags cullMode);

    public delegate void CmdSetFrontFaceEXT(
        VkCommandBuffer commandBuffer,
        VkFrontFace     frontFace);

    public delegate void CmdSetPrimitiveTopologyEXT(
        VkCommandBuffer     commandBuffer,
        VkPrimitiveTopology primitiveTopology);

    public unsafe delegate void CmdSetViewportWithCountEXT(
        VkCommandBuffer commandBuffer,
        uint            viewportCount,
        VkViewport*     pViewports);

    public unsafe delegate void CmdSetScissorWithCountEXT(
        VkCommandBuffer commandBuffer,
        uint            scissorCount,
        VkRect2D*       pScissors);

    public unsafe delegate void CmdBindVertexBuffers2EXT(
        VkCommandBuffer commandBuffer,
        uint            firstBinding,
        uint            bindingCount,
        VkBuffer*       pBuffers,
        VkDeviceSize*   pOffsets,
        VkDeviceSize*   pSizes,
        VkDeviceSize*   pStrides);

    public delegate void CmdSetDepthTestEnableEXT(
        VkCommandBuffer commandBuffer,
        uint            depthTestEnable);

    public delegate void CmdSetDepthWriteEnableEXT(
        VkCommandBuffer commandBuffer,
        uint            depthWriteEnable);

    public delegate void CmdSetDepthCompareOpEXT(
        VkCommandBuffer commandBuffer,
        VkCompareOp     depthCompareOp);

    public delegate void CmdSetDepthBoundsTestEnableEXT(
        VkCommandBuffer commandBuffer,
        uint            depthBoundsTestEnable);

    public delegate void CmdSetStencilTestEnableEXT(
        VkCommandBuffer commandBuffer,
        uint            stencilTestEnable);

    public delegate void CmdSetStencilOpEXT(
        VkCommandBuffer    commandBuffer,
        VkStencilFaceFlags faceMask,
        VkStencilOp        failOp,
        VkStencilOp        passOp,
        VkStencilOp        depthFailOp,
        VkCompareOp        compareOp);

    public unsafe delegate void GetGeneratedCommandsMemoryRequirementsNV(
        VkDevice                                     device,
        VkGeneratedCommandsMemoryRequirementsInfoNV* pInfo,
        VkMemoryRequirements2*                       pMemoryRequirements);

    public unsafe delegate void CmdPreprocessGeneratedCommandsNV(
        VkCommandBuffer            commandBuffer,
        VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

    public unsafe delegate void CmdExecuteGeneratedCommandsNV(
        VkCommandBuffer            commandBuffer,
        uint                       isPreprocessed,
        VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

    public delegate void CmdBindPipelineShaderGroupNV(
        VkCommandBuffer     commandBuffer,
        VkPipelineBindPoint pipelineBindPoint,
        VkPipeline          pipeline,
        uint                groupIndex);

    public unsafe delegate VkResult CreateIndirectCommandsLayoutNV(
        VkDevice                              device,
        VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo,
        VkAllocationCallbacks*                pAllocator,
        VkIndirectCommandsLayoutNV*           pIndirectCommandsLayout);

    public unsafe delegate void DestroyIndirectCommandsLayoutNV(
        VkDevice                   device,
        VkIndirectCommandsLayoutNV indirectCommandsLayout,
        VkAllocationCallbacks*     pAllocator);

    public unsafe delegate void DeviceMemoryReportCallbackEXT(
        VkDeviceMemoryReportCallbackDataEXT* pCallbackData,
        void*                                pUserData);

    public unsafe delegate VkResult CreatePrivateDataSlotEXT(
        VkDevice                        device,
        VkPrivateDataSlotCreateInfoEXT* pCreateInfo,
        VkAllocationCallbacks*          pAllocator,
        VkPrivateDataSlotEXT*           pPrivateDataSlot);

    public unsafe delegate void DestroyPrivateDataSlotEXT(
        VkDevice               device,
        VkPrivateDataSlotEXT   privateDataSlot,
        VkAllocationCallbacks* pAllocator);

    public delegate VkResult SetPrivateDataEXT(
        VkDevice             device,
        VkObjectType         objectType,
        ulong                objectHandle,
        VkPrivateDataSlotEXT privateDataSlot,
        ulong                data);

    public unsafe delegate void GetPrivateDataEXT(
        VkDevice             device,
        VkObjectType         objectType,
        ulong                objectHandle,
        VkPrivateDataSlotEXT privateDataSlot,
        ulong*               pData);

    public delegate void CmdSetFragmentShadingRateEnumNV(
        VkCommandBuffer                    commandBuffer,
        VkFragmentShadingRateNV            shadingRate,
        VkFragmentShadingRateCombinerOpKHR combinerOps1,
        VkFragmentShadingRateCombinerOpKHR combinerOps2);

    public delegate VkResult AcquireWinrtDisplayNV(
        VkPhysicalDevice physicalDevice,
        VkDisplayKHR     display);

    public unsafe delegate VkResult GetWinrtDisplayNV(
        VkPhysicalDevice physicalDevice,
        uint             deviceRelativeId,
        VkDisplayKHR*    pDisplay);

    public unsafe delegate VkResult CreateAccelerationStructureKHR(
        VkDevice                              device,
        VkAccelerationStructureCreateInfoKHR* pCreateInfo,
        VkAllocationCallbacks*                pAllocator,
        VkAccelerationStructureKHR*           pAccelerationStructure);

    public unsafe delegate void DestroyAccelerationStructureKHR(
        VkDevice                   device,
        VkAccelerationStructureKHR accelerationStructure,
        VkAllocationCallbacks*     pAllocator);

    public unsafe delegate void CmdBuildAccelerationStructuresKHR(
        VkCommandBuffer                              commandBuffer,
        uint                                         infoCount,
        VkAccelerationStructureBuildGeometryInfoKHR* pInfos,
        VkAccelerationStructureBuildRangeInfoKHR**   ppBuildRangeInfos);

    public unsafe delegate void CmdBuildAccelerationStructuresIndirectKHR(
        VkCommandBuffer                              commandBuffer,
        uint                                         infoCount,
        VkAccelerationStructureBuildGeometryInfoKHR* pInfos,
        VkDeviceAddress*                             pIndirectDeviceAddresses,
        uint*                                        pIndirectStrides,
        uint**                                       ppMaxPrimitiveCounts);

    public unsafe delegate VkResult BuildAccelerationStructuresKHR(
        VkDevice                                     device,
        VkDeferredOperationKHR                       deferredOperation,
        uint                                         infoCount,
        VkAccelerationStructureBuildGeometryInfoKHR* pInfos,
        VkAccelerationStructureBuildRangeInfoKHR**   ppBuildRangeInfos);

    public unsafe delegate VkResult CopyAccelerationStructureKHR(
        VkDevice                            device,
        VkDeferredOperationKHR              deferredOperation,
        VkCopyAccelerationStructureInfoKHR* pInfo);

    public unsafe delegate VkResult CopyAccelerationStructureToMemoryKHR(
        VkDevice                                    device,
        VkDeferredOperationKHR                      deferredOperation,
        VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

    public unsafe delegate VkResult CopyMemoryToAccelerationStructureKHR(
        VkDevice                                    device,
        VkDeferredOperationKHR                      deferredOperation,
        VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

    public unsafe delegate VkResult WriteAccelerationStructuresPropertiesKHR(
        VkDevice                    device,
        uint                        accelerationStructureCount,
        VkAccelerationStructureKHR* pAccelerationStructures,
        VkQueryType                 queryType,
        size_t                      dataSize,
        void*                       pData,
        size_t                      stride);

    public unsafe delegate void CmdCopyAccelerationStructureKHR(
        VkCommandBuffer                     commandBuffer,
        VkCopyAccelerationStructureInfoKHR* pInfo);

    public unsafe delegate void CmdCopyAccelerationStructureToMemoryKHR(
        VkCommandBuffer                             commandBuffer,
        VkCopyAccelerationStructureToMemoryInfoKHR* pInfo);

    public unsafe delegate void CmdCopyMemoryToAccelerationStructureKHR(
        VkCommandBuffer                             commandBuffer,
        VkCopyMemoryToAccelerationStructureInfoKHR* pInfo);

    public unsafe delegate VkDeviceAddress GetAccelerationStructureDeviceAddressKHR(
        VkDevice                                     device,
        VkAccelerationStructureDeviceAddressInfoKHR* pInfo);

    public unsafe delegate void CmdWriteAccelerationStructuresPropertiesKHR(
        VkCommandBuffer             commandBuffer,
        uint                        accelerationStructureCount,
        VkAccelerationStructureKHR* pAccelerationStructures,
        VkQueryType                 queryType,
        VkQueryPool                 queryPool,
        uint                        firstQuery);

    public unsafe delegate void GetDeviceAccelerationStructureCompatibilityKHR(
        VkDevice                                 device,
        VkAccelerationStructureVersionInfoKHR*   pVersionInfo,
        VkAccelerationStructureCompatibilityKHR* pCompatibility);

    public unsafe delegate void GetAccelerationStructureBuildSizesKHR(
        VkDevice                                     device,
        VkAccelerationStructureBuildTypeKHR          buildType,
        VkAccelerationStructureBuildGeometryInfoKHR* pBuildInfo,
        uint*                                        pMaxPrimitiveCounts,
        VkAccelerationStructureBuildSizesInfoKHR*    pSizeInfo);

    public unsafe delegate void CmdTraceRaysKHR(
        VkCommandBuffer                  commandBuffer,
        VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
        uint                             width,
        uint                             height,
        uint                             depth);

    public unsafe delegate VkResult CreateRayTracingPipelinesKHR(
        VkDevice                           device,
        VkDeferredOperationKHR             deferredOperation,
        VkPipelineCache                    pipelineCache,
        uint                               createInfoCount,
        VkRayTracingPipelineCreateInfoKHR* pCreateInfos,
        VkAllocationCallbacks*             pAllocator,
        VkPipeline*                        pPipelines);

    public unsafe delegate VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(
        VkDevice   device,
        VkPipeline pipeline,
        uint       firstGroup,
        uint       groupCount,
        size_t     dataSize,
        void*      pData);

    public unsafe delegate void CmdTraceRaysIndirectKHR(
        VkCommandBuffer                  commandBuffer,
        VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable,
        VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
        VkDeviceAddress                  indirectDeviceAddress);

    public delegate VkDeviceSize GetRayTracingShaderGroupStackSizeKHR(
        VkDevice               device,
        VkPipeline             pipeline,
        uint                   group,
        VkShaderGroupShaderKHR groupShader);

    public delegate void CmdSetRayTracingPipelineStackSizeKHR(
        VkCommandBuffer commandBuffer,
        uint            pipelineStackSize);
}