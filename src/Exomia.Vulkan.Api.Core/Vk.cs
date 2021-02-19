#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// https://github.com/KhronosGroup/Vulkan-Headers/tree/master

[module: SkipLocalsInit]

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    using size_t = nuint;
    using VkMemoryRequirements2KHR = VkMemoryRequirements2;

    public static partial class Vk
    {
        private const string IMPORT = "vulkan-1";

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateInstance")]
        public static extern unsafe VkResult CreateInstance(
            VkInstanceCreateInfo*  pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkInstance*            pInstance);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyInstance")]
        public static extern unsafe void DestroyInstance(
            VkInstance             instance,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumeratePhysicalDevices")]
        public static extern unsafe VkResult EnumeratePhysicalDevices(
            VkInstance        instance,
            uint*             pPhysicalDeviceCount,
            VkPhysicalDevice* pPhysicalDevices);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumeratePhysicalDevices")]
        public static extern unsafe VkResult EnumeratePhysicalDevices(
            VkInstance           instance,
            uint*                pPhysicalDeviceCount,
            ref VkPhysicalDevice pPhysicalDevices);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures")]
        public static extern unsafe void GetPhysicalDeviceFeatures(
            VkPhysicalDevice          physicalDevice,
            VkPhysicalDeviceFeatures* pFeatures);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        public static extern unsafe void GetPhysicalDeviceFormatProperties(
            VkPhysicalDevice    physicalDevice,
            VkFormat            format,
            VkFormatProperties* pFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        public static extern unsafe VkResult GetPhysicalDeviceImageFormatProperties(
            VkPhysicalDevice         physicalDevice,
            VkFormat                 format,
            VkImageType              type,
            VkImageTiling            tiling,
            VkImageUsageFlags        usage,
            VkImageCreateFlags       flags,
            VkImageFormatProperties* pImageFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties")]
        public static extern unsafe void GetPhysicalDeviceProperties(
            VkPhysicalDevice            physicalDevice,
            VkPhysicalDeviceProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        public static extern unsafe void GetPhysicalDeviceQueueFamilyProperties(
            VkPhysicalDevice         physicalDevice,
            uint*                    pQueueFamilyPropertyCount,
            VkQueueFamilyProperties* pQueueFamilyProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        public static extern unsafe void GetPhysicalDeviceMemoryProperties(
            VkPhysicalDevice                  physicalDevice,
            VkPhysicalDeviceMemoryProperties* pMemoryProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetInstanceProcAddr")]
        public static extern unsafe void* GetInstanceProcAddr(
            VkInstance instance,
            sbyte*     pName);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceProcAddr")]
        public static extern unsafe void* GetDeviceProcAddr(
            VkDevice device,
            sbyte*   pName);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDevice")]
        public static extern unsafe VkResult CreateDevice(
            VkPhysicalDevice       physicalDevice,
            VkDeviceCreateInfo*    pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkDevice*              pDevice);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDevice")]
        public static extern unsafe void DestroyDevice(
            VkDevice               device,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumerateInstanceExtensionProperties")]
        public static extern unsafe VkResult EnumerateInstanceExtensionProperties(
            byte*                  pLayerName,
            uint*                  pPropertyCount,
            VkExtensionProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumerateDeviceExtensionProperties")]
        public static extern unsafe VkResult EnumerateDeviceExtensionProperties(
            VkPhysicalDevice       physicalDevice,
            byte*                  pLayerName,
            uint*                  pPropertyCount,
            VkExtensionProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumerateInstanceLayerProperties")]
        public static extern unsafe VkResult EnumerateInstanceLayerProperties(
            uint*              pPropertyCount,
            VkLayerProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumerateDeviceLayerProperties")]
        public static extern unsafe VkResult EnumerateDeviceLayerProperties(
            VkPhysicalDevice   physicalDevice,
            uint*              pPropertyCount,
            VkLayerProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceQueue")]
        public static extern unsafe void GetDeviceQueue(
            VkDevice device,
            uint     queueFamilyIndex,
            uint     queueIndex,
            VkQueue* pQueue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueSubmit")]
        public static extern unsafe VkResult QueueSubmit(
            VkQueue       queue,
            uint          submitCount,
            VkSubmitInfo* pSubmits,
            VkFence       fence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueWaitIdle")]
        public static extern VkResult QueueWaitIdle(VkQueue queue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDeviceWaitIdle")]
        public static extern VkResult DeviceWaitIdle(VkDevice device);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAllocateMemory")]
        public static extern unsafe VkResult AllocateMemory(
            VkDevice               device,
            VkMemoryAllocateInfo*  pAllocateInfo,
            VkAllocationCallbacks* pAllocator,
            VkDeviceMemory*        pMemory);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkFreeMemory")]
        public static extern unsafe void FreeMemory(
            VkDevice               device,
            VkDeviceMemory         memory,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkMapMemory")]
        public static extern unsafe VkResult MapMemory(
            VkDevice         device,
            VkDeviceMemory   memory,
            VkDeviceSize     offset,
            VkDeviceSize     size,
            VkMemoryMapFlags flags,
            void**           ppData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUnmapMemory")]
        public static extern void UnmapMemory(
            VkDevice       device,
            VkDeviceMemory memory);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkFlushMappedMemoryRanges")]
        public static extern unsafe VkResult FlushMappedMemoryRanges(
            VkDevice             device,
            uint                 memoryRangeCount,
            VkMappedMemoryRange* pMemoryRanges);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkInvalidateMappedMemoryRanges")]
        public static extern unsafe VkResult InvalidateMappedMemoryRanges(
            VkDevice             device,
            uint                 memoryRangeCount,
            VkMappedMemoryRange* pMemoryRanges);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceMemoryCommitment")]
        public static extern unsafe void GetDeviceMemoryCommitment(
            VkDevice       device,
            VkDeviceMemory memory,
            VkDeviceSize*  pCommittedMemoryInBytes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindBufferMemory")]
        public static extern VkResult BindBufferMemory(
            VkDevice       device,
            VkBuffer       buffer,
            VkDeviceMemory memory,
            VkDeviceSize   memoryOffset);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindImageMemory")]
        public static extern VkResult BindImageMemory(
            VkDevice       device,
            VkImage        image,
            VkDeviceMemory memory,
            VkDeviceSize   memoryOffset);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferMemoryRequirements")]
        public static extern unsafe void GetBufferMemoryRequirements(
            VkDevice              device,
            VkBuffer              buffer,
            VkMemoryRequirements* pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageMemoryRequirements")]
        public static extern unsafe void GetImageMemoryRequirements(
            VkDevice              device,
            VkImage               image,
            VkMemoryRequirements* pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements")]
        public static extern unsafe void GetImageSparseMemoryRequirements(
            VkDevice                         device,
            VkImage                          image,
            uint*                            pSparseMemoryRequirementCount,
            VkSparseImageMemoryRequirements* pSparseMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        public static extern unsafe void GetPhysicalDeviceSparseImageFormatProperties(
            VkPhysicalDevice               physicalDevice,
            VkFormat                       format,
            VkImageType                    type,
            VkSampleCountFlags             samples,
            VkImageUsageFlags              usage,
            VkImageTiling                  tiling,
            uint*                          pPropertyCount,
            VkSparseImageFormatProperties* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueBindSparse")]
        public static extern unsafe VkResult QueueBindSparse(
            VkQueue           queue,
            uint              bindInfoCount,
            VkBindSparseInfo* pBindInfo,
            VkFence           fence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateFence")]
        public static extern unsafe VkResult CreateFence(
            VkDevice               device,
            VkFenceCreateInfo*     pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkFence*               pFence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyFence")]
        public static extern unsafe void DestroyFence(
            VkDevice               device,
            VkFence                fence,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetFences")]
        public static extern unsafe VkResult ResetFences(
            VkDevice device,
            uint     fenceCount,
            VkFence* pFences);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetFenceStatus")]
        public static extern VkResult GetFenceStatus(
            VkDevice device,
            VkFence  fence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkWaitForFences")]
        public static extern unsafe VkResult WaitForFences(
            VkDevice device,
            uint     fenceCount,
            VkFence* pFences,
            uint     waitAll,
            ulong    timeout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSemaphore")]
        public static extern unsafe VkResult CreateSemaphore(
            VkDevice               device,
            VkSemaphoreCreateInfo* pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkSemaphore*           pSemaphore);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySemaphore")]
        public static extern unsafe void DestroySemaphore(
            VkDevice               device,
            VkSemaphore            semaphore,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateEvent")]
        public static extern unsafe VkResult CreateEvent(
            VkDevice               device,
            VkEventCreateInfo*     pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkEvent*               pEvent);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyEvent")]
        public static extern unsafe void DestroyEvent(
            VkDevice               device,
            VkEvent                @event,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetEventStatus")]
        public static extern VkResult GetEventStatus(
            VkDevice device,
            VkEvent  @event);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetEvent")]
        public static extern VkResult SetEvent(
            VkDevice device,
            VkEvent  @event);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetEvent")]
        public static extern VkResult ResetEvent(
            VkDevice device,
            VkEvent  @event);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateQueryPool")]
        public static extern unsafe VkResult CreateQueryPool(
            VkDevice               device,
            VkQueryPoolCreateInfo* pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkQueryPool*           pQueryPool);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyQueryPool")]
        public static extern unsafe void DestroyQueryPool(
            VkDevice               device,
            VkQueryPool            queryPool,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetQueryPoolResults")]
        public static extern unsafe VkResult GetQueryPoolResults(
            VkDevice           device,
            VkQueryPool        queryPool,
            uint               firstQuery,
            uint               queryCount,
            size_t             dataSize,
            void*              pData,
            VkDeviceSize       stride,
            VkQueryResultFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateBuffer")]
        public static extern unsafe VkResult CreateBuffer(
            VkDevice               device,
            VkBufferCreateInfo*    pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkBuffer*              pBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyBuffer")]
        public static extern unsafe void DestroyBuffer(
            VkDevice               device,
            VkBuffer               buffer,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateBufferView")]
        public static extern unsafe VkResult CreateBufferView(
            VkDevice                device,
            VkBufferViewCreateInfo* pCreateInfo,
            VkAllocationCallbacks*  pAllocator,
            VkBufferView*           pView);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyBufferView")]
        public static extern unsafe void DestroyBufferView(
            VkDevice               device,
            VkBufferView           bufferView,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateImage")]
        public static extern unsafe VkResult CreateImage(
            VkDevice               device,
            VkImageCreateInfo*     pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkImage*               pImage);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyImage")]
        public static extern unsafe void DestroyImage(
            VkDevice               device,
            VkImage                image,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageSubresourceLayout")]
        public static extern unsafe void GetImageSubresourceLayout(
            VkDevice             device,
            VkImage              image,
            VkImageSubresource*  pSubresource,
            VkSubresourceLayout* pLayout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateImageView")]
        public static extern unsafe VkResult CreateImageView(
            VkDevice               device,
            VkImageViewCreateInfo* pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkImageView*           pView);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyImageView")]
        public static extern unsafe void DestroyImageView(
            VkDevice               device,
            VkImageView            imageView,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateShaderModule")]
        public static extern unsafe VkResult CreateShaderModule(
            VkDevice                  device,
            VkShaderModuleCreateInfo* pCreateInfo,
            VkAllocationCallbacks*    pAllocator,
            VkShaderModule*           pShaderModule);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyShaderModule")]
        public static extern unsafe void DestroyShaderModule(
            VkDevice               device,
            VkShaderModule         shaderModule,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreatePipelineCache")]
        public static extern unsafe VkResult CreatePipelineCache(
            VkDevice                   device,
            VkPipelineCacheCreateInfo* pCreateInfo,
            VkAllocationCallbacks*     pAllocator,
            VkPipelineCache*           pPipelineCache);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyPipelineCache")]
        public static extern unsafe void DestroyPipelineCache(
            VkDevice               device,
            VkPipelineCache        pipelineCache,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPipelineCacheData")]
        public static extern unsafe VkResult GetPipelineCacheData(
            VkDevice        device,
            VkPipelineCache pipelineCache,
            size_t*         pDataSize,
            void*           pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkMergePipelineCaches")]
        public static extern unsafe VkResult MergePipelineCaches(
            VkDevice         device,
            VkPipelineCache  dstCache,
            uint             srcCacheCount,
            VkPipelineCache* pSrcCaches);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateGraphicsPipelines")]
        public static extern unsafe VkResult CreateGraphicsPipelines(
            VkDevice                      device,
            VkPipelineCache               pipelineCache,
            uint                          createInfoCount,
            VkGraphicsPipelineCreateInfo* pCreateInfos,
            VkAllocationCallbacks*        pAllocator,
            VkPipeline*                   pPipelines);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateComputePipelines")]
        public static extern unsafe VkResult CreateComputePipelines(
            VkDevice                     device,
            VkPipelineCache              pipelineCache,
            uint                         createInfoCount,
            VkComputePipelineCreateInfo* pCreateInfos,
            VkAllocationCallbacks*       pAllocator,
            VkPipeline*                  pPipelines);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyPipeline")]
        public static extern unsafe void DestroyPipeline(
            VkDevice               device,
            VkPipeline             pipeline,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreatePipelineLayout")]
        public static extern unsafe VkResult CreatePipelineLayout(
            VkDevice                    device,
            VkPipelineLayoutCreateInfo* pCreateInfo,
            VkAllocationCallbacks*      pAllocator,
            VkPipelineLayout*           pPipelineLayout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyPipelineLayout")]
        public static extern unsafe void DestroyPipelineLayout(
            VkDevice               device,
            VkPipelineLayout       pipelineLayout,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSampler")]
        public static extern unsafe VkResult CreateSampler(
            VkDevice               device,
            VkSamplerCreateInfo*   pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            VkSampler*             pSampler);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySampler")]
        public static extern unsafe void DestroySampler(
            VkDevice               device,
            VkSampler              sampler,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDescriptorSetLayout")]
        public static extern unsafe VkResult CreateDescriptorSetLayout(
            VkDevice                         device,
            VkDescriptorSetLayoutCreateInfo* pCreateInfo,
            VkAllocationCallbacks*           pAllocator,
            VkDescriptorSetLayout*           pSetLayout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDescriptorSetLayout")]
        public static extern unsafe void DestroyDescriptorSetLayout(
            VkDevice               device,
            VkDescriptorSetLayout  descriptorSetLayout,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDescriptorPool")]
        public static extern unsafe VkResult CreateDescriptorPool(
            VkDevice                    device,
            VkDescriptorPoolCreateInfo* pCreateInfo,
            VkAllocationCallbacks*      pAllocator,
            VkDescriptorPool*           pDescriptorPool);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDescriptorPool")]
        public static extern unsafe void DestroyDescriptorPool(
            VkDevice               device,
            VkDescriptorPool       descriptorPool,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetDescriptorPool")]
        public static extern VkResult ResetDescriptorPool(
            VkDevice                   device,
            VkDescriptorPool           descriptorPool,
            VkDescriptorPoolResetFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAllocateDescriptorSets")]
        public static extern unsafe VkResult AllocateDescriptorSets(
            VkDevice                     device,
            VkDescriptorSetAllocateInfo* pAllocateInfo,
            VkDescriptorSet*             pDescriptorSets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkFreeDescriptorSets")]
        public static extern unsafe VkResult FreeDescriptorSets(
            VkDevice         device,
            VkDescriptorPool descriptorPool,
            uint             descriptorSetCount,
            VkDescriptorSet* pDescriptorSets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUpdateDescriptorSets")]
        public static extern unsafe void UpdateDescriptorSets(
            VkDevice              device,
            uint                  descriptorWriteCount,
            VkWriteDescriptorSet* pDescriptorWrites,
            uint                  descriptorCopyCount,
            VkCopyDescriptorSet*  pDescriptorCopies);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateFramebuffer")]
        public static extern unsafe VkResult CreateFramebuffer(
            VkDevice                 device,
            VkFramebufferCreateInfo* pCreateInfo,
            VkAllocationCallbacks*   pAllocator,
            VkFramebuffer*           pFramebuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyFramebuffer")]
        public static extern unsafe void DestroyFramebuffer(
            VkDevice               device,
            VkFramebuffer          framebuffer,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateRenderPass")]
        public static extern unsafe VkResult CreateRenderPass(
            VkDevice                device,
            VkRenderPassCreateInfo* pCreateInfo,
            VkAllocationCallbacks*  pAllocator,
            VkRenderPass*           pRenderPass);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyRenderPass")]
        public static extern unsafe void DestroyRenderPass(
            VkDevice               device,
            VkRenderPass           renderPass,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRenderAreaGranularity")]
        public static extern unsafe void GetRenderAreaGranularity(
            VkDevice     device,
            VkRenderPass renderPass,
            VkExtent2D*  pGranularity);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateCommandPool")]
        public static extern unsafe VkResult CreateCommandPool(
            VkDevice                 device,
            VkCommandPoolCreateInfo* pCreateInfo,
            VkAllocationCallbacks*   pAllocator,
            VkCommandPool*           pCommandPool);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyCommandPool")]
        public static extern unsafe void DestroyCommandPool(
            VkDevice               device,
            VkCommandPool          commandPool,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetCommandPool")]
        public static extern VkResult ResetCommandPool(
            VkDevice                device,
            VkCommandPool           commandPool,
            VkCommandPoolResetFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAllocateCommandBuffers")]
        public static extern unsafe VkResult AllocateCommandBuffers(
            VkDevice                     device,
            VkCommandBufferAllocateInfo* pAllocateInfo,
            VkCommandBuffer*             pCommandBuffers);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkFreeCommandBuffers")]
        public static extern unsafe void FreeCommandBuffers(
            VkDevice         device,
            VkCommandPool    commandPool,
            uint             commandBufferCount,
            VkCommandBuffer* pCommandBuffers);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBeginCommandBuffer")]
        public static extern unsafe VkResult BeginCommandBuffer(
            VkCommandBuffer           commandBuffer,
            VkCommandBufferBeginInfo* pBeginInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEndCommandBuffer")]
        public static extern VkResult EndCommandBuffer(VkCommandBuffer commandBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetCommandBuffer")]
        public static extern VkResult ResetCommandBuffer(
            VkCommandBuffer           commandBuffer,
            VkCommandBufferResetFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindPipeline")]
        public static extern void CmdBindPipeline(
            VkCommandBuffer     commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipeline          pipeline);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetViewport")]
        public static extern unsafe void CmdSetViewport(
            VkCommandBuffer commandBuffer,
            uint            firstViewport,
            uint            viewportCount,
            VkViewport*     pViewports);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetScissor")]
        public static extern unsafe void CmdSetScissor(
            VkCommandBuffer commandBuffer,
            uint            firstScissor,
            uint            scissorCount,
            VkRect2D*       pScissors);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetLineWidth")]
        public static extern void CmdSetLineWidth(
            VkCommandBuffer commandBuffer,
            float           lineWidth);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthBias")]
        public static extern void CmdSetDepthBias(
            VkCommandBuffer commandBuffer,
            float           depthBiasConstantFactor,
            float           depthBiasClamp,
            float           depthBiasSlopeFactor);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetBlendConstants")]
        public static extern void CmdSetBlendConstants(
            VkCommandBuffer commandBuffer,
            BlendConstants  blendConstants);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthBounds")]
        public static extern void CmdSetDepthBounds(
            VkCommandBuffer commandBuffer,
            float           minDepthBounds,
            float           maxDepthBounds);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetStencilCompareMask")]
        public static extern void CmdSetStencilCompareMask(
            VkCommandBuffer    commandBuffer,
            VkStencilFaceFlags faceMask,
            uint               compareMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetStencilWriteMask")]
        public static extern void CmdSetStencilWriteMask(
            VkCommandBuffer    commandBuffer,
            VkStencilFaceFlags faceMask,
            uint               writeMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetStencilReference")]
        public static extern void CmdSetStencilReference(
            VkCommandBuffer    commandBuffer,
            VkStencilFaceFlags faceMask,
            uint               reference);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindDescriptorSets")]
        public static extern unsafe void CmdBindDescriptorSets(
            VkCommandBuffer     commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipelineLayout    layout,
            uint                firstSet,
            uint                descriptorSetCount,
            VkDescriptorSet*    pDescriptorSets,
            uint                dynamicOffsetCount,
            uint*               pDynamicOffsets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindIndexBuffer")]
        public static extern void CmdBindIndexBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkIndexType     indexType);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindVertexBuffers")]
        public static extern unsafe void CmdBindVertexBuffers(
            VkCommandBuffer commandBuffer,
            uint            firstBinding,
            uint            bindingCount,
            VkBuffer*       pBuffers,
            VkDeviceSize*   pOffsets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDraw")]
        public static extern void CmdDraw(
            VkCommandBuffer commandBuffer,
            uint            vertexCount,
            uint            instanceCount,
            uint            firstVertex,
            uint            firstInstance);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndexed")]
        public static extern void CmdDrawIndexed(
            VkCommandBuffer commandBuffer,
            uint            indexCount,
            uint            instanceCount,
            uint            firstIndex,
            int             vertexOffset,
            uint            firstInstance);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndirect")]
        public static extern void CmdDrawIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            uint            drawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndexedIndirect")]
        public static extern void CmdDrawIndexedIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            uint            drawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDispatch")]
        public static extern void CmdDispatch(
            VkCommandBuffer commandBuffer,
            uint            groupCountX,
            uint            groupCountY,
            uint            groupCountZ);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDispatchIndirect")]
        public static extern void CmdDispatchIndirect(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyBuffer")]
        public static extern unsafe void CmdCopyBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer        srcBuffer,
            VkBuffer        dstBuffer,
            uint            regionCount,
            VkBufferCopy*   pRegions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyImage")]
        public static extern unsafe void CmdCopyImage(
            VkCommandBuffer commandBuffer,
            VkImage         srcImage,
            VkImageLayout   srcImageLayout,
            VkImage         dstImage,
            VkImageLayout   dstImageLayout,
            uint            regionCount,
            VkImageCopy*    pRegions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBlitImage")]
        public static extern unsafe void CmdBlitImage(
            VkCommandBuffer commandBuffer,
            VkImage         srcImage,
            VkImageLayout   srcImageLayout,
            VkImage         dstImage,
            VkImageLayout   dstImageLayout,
            uint            regionCount,
            VkImageBlit*    pRegions,
            VkFilter        filter);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyBufferToImage")]
        public static extern unsafe void CmdCopyBufferToImage(
            VkCommandBuffer    commandBuffer,
            VkBuffer           srcBuffer,
            VkImage            dstImage,
            VkImageLayout      dstImageLayout,
            uint               regionCount,
            VkBufferImageCopy* pRegions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyImageToBuffer")]
        public static extern unsafe void CmdCopyImageToBuffer(
            VkCommandBuffer    commandBuffer,
            VkImage            srcImage,
            VkImageLayout      srcImageLayout,
            VkBuffer           dstBuffer,
            uint               regionCount,
            VkBufferImageCopy* pRegions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdUpdateBuffer")]
        public static extern unsafe void CmdUpdateBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer        dstBuffer,
            VkDeviceSize    dstOffset,
            VkDeviceSize    dataSize,
            void*           pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdFillBuffer")]
        public static extern void CmdFillBuffer(
            VkCommandBuffer commandBuffer,
            VkBuffer        dstBuffer,
            VkDeviceSize    dstOffset,
            VkDeviceSize    size,
            uint            data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdClearColorImage")]
        public static extern unsafe void CmdClearColorImage(
            VkCommandBuffer          commandBuffer,
            VkImage                  image,
            VkImageLayout            imageLayout,
            VkClearColorValue*       pColor,
            uint                     rangeCount,
            VkImageSubresourceRange* pRanges);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdClearDepthStencilImage")]
        public static extern unsafe void CmdClearDepthStencilImage(
            VkCommandBuffer           commandBuffer,
            VkImage                   image,
            VkImageLayout             imageLayout,
            VkClearDepthStencilValue* pDepthStencil,
            uint                      rangeCount,
            VkImageSubresourceRange*  pRanges);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdClearAttachments")]
        public static extern unsafe void CmdClearAttachments(
            VkCommandBuffer    commandBuffer,
            uint               attachmentCount,
            VkClearAttachment* pAttachments,
            uint               rectCount,
            VkClearRect*       pRects);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdResolveImage")]
        public static extern unsafe void CmdResolveImage(
            VkCommandBuffer commandBuffer,
            VkImage         srcImage,
            VkImageLayout   srcImageLayout,
            VkImage         dstImage,
            VkImageLayout   dstImageLayout,
            uint            regionCount,
            VkImageResolve* pRegions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetEvent")]
        public static extern void CmdSetEvent(
            VkCommandBuffer      commandBuffer,
            VkEvent              @event,
            VkPipelineStageFlags stageMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdResetEvent")]
        public static extern void CmdResetEvent(
            VkCommandBuffer      commandBuffer,
            VkEvent              @event,
            VkPipelineStageFlags stageMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdWaitEvents")]
        public static extern unsafe void CmdWaitEvents(
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

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdPipelineBarrier")]
        public static extern unsafe void CmdPipelineBarrier(
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

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginQuery")]
        public static extern void CmdBeginQuery(
            VkCommandBuffer     commandBuffer,
            VkQueryPool         queryPool,
            uint                query,
            VkQueryControlFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndQuery")]
        public static extern void CmdEndQuery(
            VkCommandBuffer commandBuffer,
            VkQueryPool     queryPool,
            uint            query);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdResetQueryPool")]
        public static extern void CmdResetQueryPool(
            VkCommandBuffer commandBuffer,
            VkQueryPool     queryPool,
            uint            firstQuery,
            uint            queryCount);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdWriteTimestamp")]
        public static extern void CmdWriteTimestamp(
            VkCommandBuffer      commandBuffer,
            VkPipelineStageFlags pipelineStage,
            VkQueryPool          queryPool,
            uint                 query);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyQueryPoolResults")]
        public static extern void CmdCopyQueryPoolResults(
            VkCommandBuffer    commandBuffer,
            VkQueryPool        queryPool,
            uint               firstQuery,
            uint               queryCount,
            VkBuffer           dstBuffer,
            VkDeviceSize       dstOffset,
            VkDeviceSize       stride,
            VkQueryResultFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdPushConstants")]
        public static extern unsafe void CmdPushConstants(
            VkCommandBuffer    commandBuffer,
            VkPipelineLayout   layout,
            VkShaderStageFlags stageFlags,
            uint               offset,
            uint               size,
            void*              pValues);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginRenderPass")]
        public static extern unsafe void CmdBeginRenderPass(
            VkCommandBuffer        commandBuffer,
            VkRenderPassBeginInfo* pRenderPassBegin,
            VkSubpassContents      contents);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdNextSubpass")]
        public static extern void CmdNextSubpass(
            VkCommandBuffer   commandBuffer,
            VkSubpassContents contents);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndRenderPass")]
        public static extern void CmdEndRenderPass(VkCommandBuffer commandBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdExecuteCommands")]
        public static extern unsafe void CmdExecuteCommands(
            VkCommandBuffer  commandBuffer,
            uint             commandBufferCount,
            VkCommandBuffer* pCommandBuffers);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumerateInstanceVersion")]
        public static extern unsafe VkResult EnumerateInstanceVersion(VkVersion* pApiVersion);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindBufferMemory2")]
        public static extern unsafe VkResult BindBufferMemory2(
            VkDevice                device,
            uint                    bindInfoCount,
            VkBindBufferMemoryInfo* pBindInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindImageMemory2")]
        public static extern unsafe VkResult BindImageMemory2(
            VkDevice               device,
            uint                   bindInfoCount,
            VkBindImageMemoryInfo* pBindInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceGroupPeerMemoryFeatures")]
        public static extern unsafe void GetDeviceGroupPeerMemoryFeatures(
            VkDevice                  device,
            uint                      heapIndex,
            uint                      localDeviceIndex,
            uint                      remoteDeviceIndex,
            VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDeviceMask")]
        public static extern void CmdSetDeviceMask(
            VkCommandBuffer commandBuffer,
            uint            deviceMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDispatchBase")]
        public static extern void CmdDispatchBase(
            VkCommandBuffer commandBuffer,
            uint            baseGroupX,
            uint            baseGroupY,
            uint            baseGroupZ,
            uint            groupCountX,
            uint            groupCountY,
            uint            groupCountZ);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumeratePhysicalDeviceGroups")]
        public static extern unsafe VkResult EnumeratePhysicalDeviceGroups(
            VkInstance                       instance,
            uint*                            pPhysicalDeviceGroupCount,
            VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageMemoryRequirements2")]
        public static extern unsafe void GetImageMemoryRequirements2(
            VkDevice                        device,
            VkImageMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2*          pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferMemoryRequirements2")]
        public static extern unsafe void GetBufferMemoryRequirements2(
            VkDevice                         device,
            VkBufferMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2*           pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements2")]
        public static extern unsafe void GetImageSparseMemoryRequirements2(
            VkDevice                              device,
            VkImageSparseMemoryRequirementsInfo2* pInfo,
            uint*                                 pSparseMemoryRequirementCount,
            VkSparseImageMemoryRequirements2*     pSparseMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures2")]
        public static extern unsafe void GetPhysicalDeviceFeatures2(
            VkPhysicalDevice           physicalDevice,
            VkPhysicalDeviceFeatures2* pFeatures);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties2")]
        public static extern unsafe void GetPhysicalDeviceProperties2(
            VkPhysicalDevice             physicalDevice,
            VkPhysicalDeviceProperties2* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties2")]
        public static extern unsafe void GetPhysicalDeviceFormatProperties2(
            VkPhysicalDevice     physicalDevice,
            VkFormat             format,
            VkFormatProperties2* pFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2")]
        public static extern unsafe VkResult GetPhysicalDeviceImageFormatProperties2(
            VkPhysicalDevice                  physicalDevice,
            VkPhysicalDeviceImageFormatInfo2* pImageFormatInfo,
            VkImageFormatProperties2*         pImageFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2")]
        public static extern unsafe void GetPhysicalDeviceQueueFamilyProperties2(
            VkPhysicalDevice          physicalDevice,
            uint*                     pQueueFamilyPropertyCount,
            VkQueueFamilyProperties2* pQueueFamilyProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2")]
        public static extern unsafe void GetPhysicalDeviceMemoryProperties2(
            VkPhysicalDevice                   physicalDevice,
            VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2")]
        public static extern unsafe void GetPhysicalDeviceSparseImageFormatProperties2(
            VkPhysicalDevice                        physicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
            uint*                                   pPropertyCount,
            VkSparseImageFormatProperties2*         pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkTrimCommandPool")]
        public static extern void TrimCommandPool(
            VkDevice               device,
            VkCommandPool          commandPool,
            VkCommandPoolTrimFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceQueue2")]
        public static extern unsafe void GetDeviceQueue2(
            VkDevice            device,
            VkDeviceQueueInfo2* pQueueInfo,
            VkQueue*            pQueue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSamplerYcbcrConversion")]
        public static extern unsafe VkResult CreateSamplerYcbcrConversion(
            VkDevice                            device,
            VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
            VkAllocationCallbacks*              pAllocator,
            VkSamplerYcbcrConversion*           pYcbcrConversion);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySamplerYcbcrConversion")]
        public static extern unsafe void DestroySamplerYcbcrConversion(
            VkDevice                 device,
            VkSamplerYcbcrConversion ycbcrConversion,
            VkAllocationCallbacks*   pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDescriptorUpdateTemplate")]
        public static extern unsafe VkResult CreateDescriptorUpdateTemplate(
            VkDevice                              device,
            VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
            VkAllocationCallbacks*                pAllocator,
            VkDescriptorUpdateTemplate*           pDescriptorUpdateTemplate);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDescriptorUpdateTemplate")]
        public static extern unsafe void DestroyDescriptorUpdateTemplate(
            VkDevice                   device,
            VkDescriptorUpdateTemplate descriptorUpdateTemplate,
            VkAllocationCallbacks*     pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public static extern unsafe void UpdateDescriptorSetWithTemplate(
            VkDevice                   device,
            VkDescriptorSet            descriptorSet,
            VkDescriptorUpdateTemplate descriptorUpdateTemplate,
            void*                      pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalBufferProperties")]
        public static extern unsafe void GetPhysicalDeviceExternalBufferProperties(
            VkPhysicalDevice                    physicalDevice,
            VkPhysicalDeviceExternalBufferInfo* pExternalBufferInfo,
            VkExternalBufferProperties*         pExternalBufferProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalFenceProperties")]
        public static extern unsafe void GetPhysicalDeviceExternalFenceProperties(
            VkPhysicalDevice                   physicalDevice,
            VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
            VkExternalFenceProperties*         pExternalFenceProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalSemaphoreProperties")]
        public static extern unsafe void GetPhysicalDeviceExternalSemaphoreProperties(
            VkPhysicalDevice                       physicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
            VkExternalSemaphoreProperties*         pExternalSemaphoreProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDescriptorSetLayoutSupport")]
        public static extern unsafe void GetDescriptorSetLayoutSupport(
            VkDevice                         device,
            VkDescriptorSetLayoutCreateInfo* pCreateInfo,
            VkDescriptorSetLayoutSupport*    pSupport);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndirectCount")]
        public static extern void CmdDrawIndirectCount(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndexedIndirectCount")]
        public static extern void CmdDrawIndexedIndirectCount(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateRenderPass2")]
        public static extern unsafe VkResult CreateRenderPass2(
            VkDevice                 device,
            VkRenderPassCreateInfo2* pCreateInfo,
            VkAllocationCallbacks*   pAllocator,
            VkRenderPass*            pRenderPass);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginRenderPass2")]
        public static extern unsafe void CmdBeginRenderPass2(
            VkCommandBuffer        commandBuffer,
            VkRenderPassBeginInfo* pRenderPassBegin,
            VkSubpassBeginInfo*    pSubpassBeginInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdNextSubpass2")]
        public static extern unsafe void CmdNextSubpass2(
            VkCommandBuffer     commandBuffer,
            VkSubpassBeginInfo* pSubpassBeginInfo,
            VkSubpassEndInfo*   pSubpassEndInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndRenderPass2")]
        public static extern unsafe void CmdEndRenderPass2(
            VkCommandBuffer   commandBuffer,
            VkSubpassEndInfo* pSubpassEndInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetQueryPool")]
        public static extern void ResetQueryPool(
            VkDevice    device,
            VkQueryPool queryPool,
            uint        firstQuery,
            uint        queryCount);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSemaphoreCounterValue")]
        public static extern unsafe VkResult GetSemaphoreCounterValue(
            VkDevice    device,
            VkSemaphore semaphore,
            ulong*      pValue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkWaitSemaphores")]
        public static extern unsafe VkResult WaitSemaphores(
            VkDevice             device,
            VkSemaphoreWaitInfo* pWaitInfo,
            ulong                timeout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSignalSemaphore")]
        public static extern unsafe VkResult SignalSemaphore(
            VkDevice               device,
            VkSemaphoreSignalInfo* pSignalInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferDeviceAddress")]
        public static extern unsafe VkDeviceAddress GetBufferDeviceAddress(
            VkDevice                   device,
            VkBufferDeviceAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferOpaqueCaptureAddress")]
        public static extern unsafe ulong GetBufferOpaqueCaptureAddress(
            VkDevice                   device,
            VkBufferDeviceAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddress")]
        public static extern unsafe ulong GetDeviceMemoryOpaqueCaptureAddress(
            VkDevice                                device,
            VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySurfaceKHR")]
        public static extern unsafe void DestroySurfaceKHR(
            VkInstance             instance,
            VkSurfaceKHR           surface,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceSupportKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceSupportKHR(
            VkPhysicalDevice physicalDevice,
            uint             queueFamilyIndex,
            VkSurfaceKHR     surface,
            VkBool32*        pSupported);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilitiesKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceCapabilitiesKHR(
            VkPhysicalDevice          physicalDevice,
            VkSurfaceKHR              surface,
            VkSurfaceCapabilitiesKHR* pSurfaceCapabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceFormatsKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceFormatsKHR(
            VkPhysicalDevice    physicalDevice,
            VkSurfaceKHR        surface,
            uint*               pSurfaceFormatCount,
            VkSurfaceFormatKHR* pSurfaceFormats);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfacePresentModesKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfacePresentModesKHR(
            VkPhysicalDevice  physicalDevice,
            VkSurfaceKHR      surface,
            uint*             pPresentModeCount,
            VkPresentModeKHR* pPresentModes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSwapchainKHR")]
        public static extern unsafe VkResult CreateSwapchainKHR(
            VkDevice                  device,
            VkSwapchainCreateInfoKHR* pCreateInfo,
            VkAllocationCallbacks*    pAllocator,
            VkSwapchainKHR*           pSwapchain);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySwapchainKHR")]
        public static extern unsafe void DestroySwapchainKHR(
            VkDevice               device,
            VkSwapchainKHR         swapchain,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSwapchainImagesKHR")]
        public static extern unsafe VkResult GetSwapchainImagesKHR(
            VkDevice       device,
            VkSwapchainKHR swapchain,
            uint*          pSwapchainImageCount,
            VkImage*       pSwapchainImages);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquireNextImageKHR")]
        public static extern unsafe VkResult AcquireNextImageKHR(
            VkDevice       device,
            VkSwapchainKHR swapchain,
            ulong          timeout,
            VkSemaphore    semaphore,
            VkFence        fence,
            uint*          pImageIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueuePresentKHR")]
        public static extern unsafe VkResult QueuePresentKHR(
            VkQueue           queue,
            VkPresentInfoKHR* pPresentInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceGroupPresentCapabilitiesKHR")]
        public static extern unsafe VkResult GetDeviceGroupPresentCapabilitiesKHR(
            VkDevice                             device,
            VkDeviceGroupPresentCapabilitiesKHR* pDeviceGroupPresentCapabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceGroupSurfacePresentModesKHR")]
        public static extern unsafe VkResult GetDeviceGroupSurfacePresentModesKHR(
            VkDevice                          device,
            VkSurfaceKHR                      surface,
            VkDeviceGroupPresentModeFlagsKHR* pModes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDevicePresentRectanglesKHR")]
        public static extern unsafe VkResult GetPhysicalDevicePresentRectanglesKHR(
            VkPhysicalDevice physicalDevice,
            VkSurfaceKHR     surface,
            uint*            pRectCount,
            VkRect2D*        pRects);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquireNextImage2KHR")]
        public static extern unsafe VkResult AcquireNextImage2KHR(
            VkDevice                   device,
            VkAcquireNextImageInfoKHR* pAcquireInfo,
            uint*                      pImageIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceDisplayPropertiesKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceDisplayPropertiesKHR(
            VkPhysicalDevice        physicalDevice,
            uint*                   pPropertyCount,
            VkDisplayPropertiesKHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceDisplayPlanePropertiesKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceDisplayPlanePropertiesKHR(
            VkPhysicalDevice             physicalDevice,
            uint*                        pPropertyCount,
            VkDisplayPlanePropertiesKHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDisplayPlaneSupportedDisplaysKHR")]
        public static extern unsafe VkResult GetDisplayPlaneSupportedDisplaysKHR(
            VkPhysicalDevice physicalDevice,
            uint             planeIndex,
            uint*            pDisplayCount,
            VkDisplayKHR*    pDisplays);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDisplayModePropertiesKHR")]
        public static extern unsafe VkResult GetDisplayModePropertiesKHR(
            VkPhysicalDevice            physicalDevice,
            VkDisplayKHR                display,
            uint*                       pPropertyCount,
            VkDisplayModePropertiesKHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDisplayModeKHR")]
        public static extern unsafe VkResult CreateDisplayModeKHR(
            VkPhysicalDevice            physicalDevice,
            VkDisplayKHR                display,
            VkDisplayModeCreateInfoKHR* pCreateInfo,
            VkAllocationCallbacks*      pAllocator,
            VkDisplayModeKHR*           pMode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDisplayPlaneCapabilitiesKHR")]
        public static extern unsafe VkResult GetDisplayPlaneCapabilitiesKHR(
            VkPhysicalDevice               physicalDevice,
            VkDisplayModeKHR               mode,
            uint                           planeIndex,
            VkDisplayPlaneCapabilitiesKHR* pCapabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDisplayPlaneSurfaceKHR")]
        public static extern unsafe VkResult CreateDisplayPlaneSurfaceKHR(
            VkInstance                     instance,
            VkDisplaySurfaceCreateInfoKHR* pCreateInfo,
            VkAllocationCallbacks*         pAllocator,
            VkSurfaceKHR*                  pSurface);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSharedSwapchainsKHR")]
        public static extern unsafe VkResult CreateSharedSwapchainsKHR(
            VkDevice                  device,
            uint                      swapchainCount,
            VkSwapchainCreateInfoKHR* pCreateInfos,
            VkAllocationCallbacks*    pAllocator,
            VkSwapchainKHR*           pSwapchains);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2KHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceCapabilities2KHR(
            VkPhysicalDevice                 physicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            VkSurfaceCapabilities2KHR*       pSurfaceCapabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceFormats2KHR")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceFormats2KHR(
            VkPhysicalDevice                 physicalDevice,
            VkPhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo,
            uint*                            pSurfaceFormatCount,
            VkSurfaceFormat2KHR*             pSurfaceFormats);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceDisplayProperties2KHR")]
        public static extern unsafe VkResult GetPhysicalDeviceDisplayProperties2KHR(
            VkPhysicalDevice         physicalDevice,
            uint*                    pPropertyCount,
            VkDisplayProperties2KHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceDisplayPlaneProperties2KHR")]
        public static extern unsafe VkResult GetPhysicalDeviceDisplayPlaneProperties2KHR(
            VkPhysicalDevice              physicalDevice,
            uint*                         pPropertyCount,
            VkDisplayPlaneProperties2KHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDisplayModeProperties2KHR")]
        public static extern unsafe VkResult GetDisplayModeProperties2KHR(
            VkPhysicalDevice             physicalDevice,
            VkDisplayKHR                 display,
            uint*                        pPropertyCount,
            VkDisplayModeProperties2KHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDisplayPlaneCapabilities2KHR")]
        public static extern unsafe VkResult GetDisplayPlaneCapabilities2KHR(
            VkPhysicalDevice                physicalDevice,
            VkDisplayPlaneInfo2KHR*         pDisplayPlaneInfo,
            VkDisplayPlaneCapabilities2KHR* pCapabilities);
    }
}