#region License

// Copyright (c) 2018-2020, exomia
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
        [DllImport(IMPORT, EntryPoint = "vkCreateDevice")]
        public static extern unsafe VkResult CreateDevice(
            VkPhysicalDevice       physicalDevice,
            VkDeviceCreateInfo*    pCreateInfo,
            VkAllocationCallbacks* pAllocator,
            out VkDevice           pDevice);

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
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2
                * pFormatInfo,
            uint*                           pPropertyCount,
            VkSparseImageFormatProperties2* pProperties);

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
            VkDevice device,
            VkDescriptorUpdateTemplate
                descriptorUpdateTemplate,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUpdateDescriptorSetWithTemplate")]
        public static extern unsafe void UpdateDescriptorSetWithTemplate(
            VkDevice        device,
            VkDescriptorSet descriptorSet,
            VkDescriptorUpdateTemplate
                descriptorUpdateTemplate,
            void* pData);

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
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo
                * pExternalSemaphoreInfo,
            VkExternalSemaphoreProperties* pExternalSemaphoreProperties);

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
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        public static extern unsafe void GetPhysicalDeviceFeatures2KHR(
            VkPhysicalDevice           physicalDevice,
            VkPhysicalDeviceFeatures2* pFeatures);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        public static extern unsafe void GetPhysicalDeviceProperties2KHR(
            VkPhysicalDevice             physicalDevice,
            VkPhysicalDeviceProperties2* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        public static extern unsafe void GetPhysicalDeviceFormatProperties2KHR(
            VkPhysicalDevice     physicalDevice,
            VkFormat             format,
            VkFormatProperties2* pFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        public static extern unsafe VkResult GetPhysicalDeviceImageFormatProperties2KHR(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceImageFormatInfo2
                * pImageFormatInfo,
            VkImageFormatProperties2* pImageFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        public static extern unsafe void GetPhysicalDeviceQueueFamilyProperties2KHR(
            VkPhysicalDevice          physicalDevice,
            uint*                     pQueueFamilyPropertyCount,
            VkQueueFamilyProperties2* pQueueFamilyProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        public static extern unsafe void GetPhysicalDeviceMemoryProperties2KHR(
            VkPhysicalDevice                   physicalDevice,
            VkPhysicalDeviceMemoryProperties2* pMemoryProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        public static extern unsafe void GetPhysicalDeviceSparseImageFormatProperties2KHR(
            VkPhysicalDevice                        physicalDevice,
            VkPhysicalDeviceSparseImageFormatInfo2* pFormatInfo,
            uint*                                   pPropertyCount,
            VkSparseImageFormatProperties2*         pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceGroupPeerMemoryFeaturesKHR")]
        public static extern unsafe void GetDeviceGroupPeerMemoryFeaturesKHR(
            VkDevice                  device,
            uint                      heapIndex,
            uint                      localDeviceIndex,
            uint                      remoteDeviceIndex,
            VkPeerMemoryFeatureFlags* pPeerMemoryFeatures);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDeviceMaskKHR")]
        public static extern void CmdSetDeviceMaskKHR(
            VkCommandBuffer commandBuffer,
            uint            deviceMask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDispatchBaseKHR")]
        public static extern void CmdDispatchBaseKHR(
            VkCommandBuffer commandBuffer,
            uint            baseGroupX,
            uint            baseGroupY,
            uint            baseGroupZ,
            uint            groupCountX,
            uint            groupCountY,
            uint            groupCountZ);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkTrimCommandPoolKHR")]
        public static extern void TrimCommandPoolKHR(
            VkDevice               device,
            VkCommandPool          commandPool,
            VkCommandPoolTrimFlags flags);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR")]
        public static extern unsafe VkResult EnumeratePhysicalDeviceGroupsKHR(
            VkInstance                       instance,
            uint*                            pPhysicalDeviceGroupCount,
            VkPhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        public static extern unsafe void GetPhysicalDeviceExternalBufferPropertiesKHR(
            VkPhysicalDevice physicalDevice,
            VkPhysicalDeviceExternalBufferInfo
                * pExternalBufferInfo,
            VkExternalBufferProperties* pExternalBufferProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryFdKHR")]
        public static extern unsafe VkResult GetMemoryFdKHR(
            VkDevice              device,
            VkMemoryGetFdInfoKHR* pGetFdInfo,
            int*                  pFd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        public static extern unsafe VkResult GetMemoryFdPropertiesKHR(
            VkDevice                        device,
            VkExternalMemoryHandleTypeFlags handleType,
            int                             fd,
            VkMemoryFdPropertiesKHR*        pMemoryFdProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        public static extern unsafe void GetPhysicalDeviceExternalSemaphorePropertiesKHR(
            VkPhysicalDevice                       physicalDevice,
            VkPhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo,
            VkExternalSemaphoreProperties*         pExternalSemaphoreProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkImportSemaphoreFdKHR")]
        public static extern unsafe VkResult ImportSemaphoreFdKHR(
            VkDevice                    device,
            VkImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSemaphoreFdKHR")]
        public static extern unsafe VkResult GetSemaphoreFdKHR(
            VkDevice                 device,
            VkSemaphoreGetFdInfoKHR* pGetFdInfo,
            int*                     pFd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdPushDescriptorSetKHR")]
        public static extern unsafe void CmdPushDescriptorSetKHR(
            VkCommandBuffer       commandBuffer,
            VkPipelineBindPoint   pipelineBindPoint,
            VkPipelineLayout      layout,
            uint                  set,
            uint                  descriptorWriteCount,
            VkWriteDescriptorSet* pDescriptorWrites);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdPushDescriptorSetWithTemplateKHR")]
        public static extern unsafe void CmdPushDescriptorSetWithTemplateKHR(
            VkCommandBuffer commandBuffer,
            VkDescriptorUpdateTemplate
                descriptorUpdateTemplate,
            VkPipelineLayout layout,
            uint             set,
            void*            pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDescriptorUpdateTemplateKHR")]
        public static extern unsafe VkResult CreateDescriptorUpdateTemplateKHR(
            VkDevice                              device,
            VkDescriptorUpdateTemplateCreateInfo* pCreateInfo,
            VkAllocationCallbacks*                pAllocator,
            VkDescriptorUpdateTemplate*           pDescriptorUpdateTemplate);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDescriptorUpdateTemplateKHR")]
        public static extern unsafe void DestroyDescriptorUpdateTemplateKHR(
            VkDevice device,
            VkDescriptorUpdateTemplate
                descriptorUpdateTemplate,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUpdateDescriptorSetWithTemplateKHR")]
        public static extern unsafe void UpdateDescriptorSetWithTemplateKHR(
            VkDevice        device,
            VkDescriptorSet descriptorSet,
            VkDescriptorUpdateTemplate
                descriptorUpdateTemplate,
            void* pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateRenderPass2KHR")]
        public static extern unsafe VkResult CreateRenderPass2KHR(
            VkDevice                 device,
            VkRenderPassCreateInfo2* pCreateInfo,
            VkAllocationCallbacks*   pAllocator,
            VkRenderPass*            pRenderPass);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginRenderPass2KHR")]
        public static extern unsafe void CmdBeginRenderPass2KHR(
            VkCommandBuffer        commandBuffer,
            VkRenderPassBeginInfo* pRenderPassBegin,
            VkSubpassBeginInfo*    pSubpassBeginInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdNextSubpass2KHR")]
        public static extern unsafe void CmdNextSubpass2KHR(
            VkCommandBuffer     commandBuffer,
            VkSubpassBeginInfo* pSubpassBeginInfo,
            VkSubpassEndInfo*   pSubpassEndInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndRenderPass2KHR")]
        public static extern unsafe void CmdEndRenderPass2KHR(
            VkCommandBuffer   commandBuffer,
            VkSubpassEndInfo* pSubpassEndInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSwapchainStatusKHR")]
        public static extern VkResult GetSwapchainStatusKHR(
            VkDevice       device,
            VkSwapchainKHR swapchain);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR")]
        public static extern unsafe void GetPhysicalDeviceExternalFencePropertiesKHR(
            VkPhysicalDevice                   physicalDevice,
            VkPhysicalDeviceExternalFenceInfo* pExternalFenceInfo,
            VkExternalFenceProperties*         pExternalFenceProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkImportFenceFdKHR")]
        public static extern unsafe VkResult ImportFenceFdKHR(
            VkDevice                device,
            VkImportFenceFdInfoKHR* pImportFenceFdInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetFenceFdKHR")]
        public static extern unsafe VkResult GetFenceFdKHR(
            VkDevice             device,
            VkFenceGetFdInfoKHR* pGetFdInfo,
            int*                 pFd);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR")]
        public static extern unsafe VkResult EnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(
            VkPhysicalDevice                    physicalDevice,
            uint                                queueFamilyIndex,
            uint*                               pCounterCount,
            VkPerformanceCounterKHR*            pCounters,
            VkPerformanceCounterDescriptionKHR* pCounterDescriptions);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR")]
        public static extern unsafe void GetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(
            VkPhysicalDevice                     physicalDevice,
            VkQueryPoolPerformanceCreateInfoKHR* pPerformanceQueryCreateInfo,
            uint*                                pNumPasses);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquireProfilingLockKHR")]
        public static extern unsafe VkResult AcquireProfilingLockKHR(
            VkDevice                       device,
            VkAcquireProfilingLockInfoKHR* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkReleaseProfilingLockKHR")]
        public static extern void ReleaseProfilingLockKHR(VkDevice device);

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

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageMemoryRequirements2KHR")]
        public static extern unsafe void GetImageMemoryRequirements2KHR(
            VkDevice                        device,
            VkImageMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2*          pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferMemoryRequirements2KHR")]
        public static extern unsafe void GetBufferMemoryRequirements2KHR(
            VkDevice                         device,
            VkBufferMemoryRequirementsInfo2* pInfo,
            VkMemoryRequirements2*           pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageSparseMemoryRequirements2KHR")]
        public static extern unsafe void GetImageSparseMemoryRequirements2KHR(
            VkDevice                              device,
            VkImageSparseMemoryRequirementsInfo2* pInfo,
            uint*                                 pSparseMemoryRequirementCount,
            VkSparseImageMemoryRequirements2*     pSparseMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateSamplerYcbcrConversionKHR")]
        public static extern unsafe VkResult CreateSamplerYcbcrConversionKHR(
            VkDevice                            device,
            VkSamplerYcbcrConversionCreateInfo* pCreateInfo,
            VkAllocationCallbacks*              pAllocator,
            VkSamplerYcbcrConversion*           pYcbcrConversion);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroySamplerYcbcrConversionKHR")]
        public static extern unsafe void DestroySamplerYcbcrConversionKHR(
            VkDevice                 device,
            VkSamplerYcbcrConversion ycbcrConversion,
            VkAllocationCallbacks*   pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindBufferMemory2KHR")]
        public static extern unsafe VkResult BindBufferMemory2KHR(
            VkDevice                device,
            uint                    bindInfoCount,
            VkBindBufferMemoryInfo* pBindInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindImageMemory2KHR")]
        public static extern unsafe VkResult BindImageMemory2KHR(
            VkDevice               device,
            uint                   bindInfoCount,
            VkBindImageMemoryInfo* pBindInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDescriptorSetLayoutSupportKHR")]
        public static extern unsafe void GetDescriptorSetLayoutSupportKHR(
            VkDevice                         device,
            VkDescriptorSetLayoutCreateInfo* pCreateInfo,
            VkDescriptorSetLayoutSupport*    pSupport);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndirectCountKHR")]
        public static extern void CmdDrawIndirectCountKHR(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndexedIndirectCountKHR")]
        public static extern void CmdDrawIndexedIndirectCountKHR(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSemaphoreCounterValueKHR")]
        public static extern unsafe VkResult GetSemaphoreCounterValueKHR(
            VkDevice    device,
            VkSemaphore semaphore,
            ulong*      pValue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkWaitSemaphoresKHR")]
        public static extern unsafe VkResult WaitSemaphoresKHR(
            VkDevice             device,
            VkSemaphoreWaitInfo* pWaitInfo,
            ulong                timeout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSignalSemaphoreKHR")]
        public static extern unsafe VkResult SignalSemaphoreKHR(
            VkDevice               device,
            VkSemaphoreSignalInfo* pSignalInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        public static extern unsafe VkResult GetPhysicalDeviceFragmentShadingRatesKHR(
            VkPhysicalDevice physicalDevice,
            uint*            pFragmentShadingRateCount,
            VkPhysicalDeviceFragmentShadingRateKHR
                * pFragmentShadingRates);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
        public static extern unsafe void CmdSetFragmentShadingRateKHR(
            VkCommandBuffer                    commandBuffer,
            VkExtent2D*                        pFragmentSize,
            VkFragmentShadingRateCombinerOpKHR combinerOps1,
            VkFragmentShadingRateCombinerOpKHR combinerOps2);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferDeviceAddressKHR")]
        public static extern unsafe VkDeviceAddress GetBufferDeviceAddressKHR(
            VkDevice                   device,
            VkBufferDeviceAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
        public static extern unsafe ulong GetBufferOpaqueCaptureAddressKHR(
            VkDevice                   device,
            VkBufferDeviceAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        public static extern unsafe ulong GetDeviceMemoryOpaqueCaptureAddressKHR(
            VkDevice                                device,
            VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDeferredOperationKHR")]
        public static extern unsafe VkResult CreateDeferredOperationKHR(
            VkDevice                device,
            VkAllocationCallbacks*  pAllocator,
            VkDeferredOperationKHR* pDeferredOperation);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDeferredOperationKHR")]
        public static extern unsafe void DestroyDeferredOperationKHR(
            VkDevice               device,
            VkDeferredOperationKHR operation,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR")]
        public static extern uint GetDeferredOperationMaxConcurrencyKHR(
            VkDevice               device,
            VkDeferredOperationKHR operation);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeferredOperationResultKHR")]
        public static extern VkResult GetDeferredOperationResultKHR(
            VkDevice               device,
            VkDeferredOperationKHR operation);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDeferredOperationJoinKHR")]
        public static extern VkResult DeferredOperationJoinKHR(
            VkDevice               device,
            VkDeferredOperationKHR operation);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPipelineExecutablePropertiesKHR")]
        public static extern unsafe VkResult GetPipelineExecutablePropertiesKHR(
            VkDevice                           device,
            VkPipelineInfoKHR*                 pPipelineInfo,
            uint*                              pExecutableCount,
            VkPipelineExecutablePropertiesKHR* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPipelineExecutableStatisticsKHR")]
        public static extern unsafe VkResult GetPipelineExecutableStatisticsKHR(
            VkDevice                          device,
            VkPipelineExecutableInfoKHR*      pExecutableInfo,
            uint*                             pStatisticCount,
            VkPipelineExecutableStatisticKHR* pStatistics);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPipelineExecutableInternalRepresentationsKHR")]
        public static extern unsafe VkResult GetPipelineExecutableInternalRepresentationsKHR(
            VkDevice device,
            VkPipelineExecutableInfoKHR
                * pExecutableInfo,
            uint* pInternalRepresentationCount,
            VkPipelineExecutableInternalRepresentationKHR
                * pInternalRepresentations);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyBuffer2KHR")]
        public static extern unsafe void CmdCopyBuffer2KHR(
            VkCommandBuffer       commandBuffer,
            VkCopyBufferInfo2KHR* pCopyBufferInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyImage2KHR")]
        public static extern unsafe void CmdCopyImage2KHR(
            VkCommandBuffer      commandBuffer,
            VkCopyImageInfo2KHR* pCopyImageInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyBufferToImage2KHR")]
        public static extern unsafe void CmdCopyBufferToImage2KHR(
            VkCommandBuffer              commandBuffer,
            VkCopyBufferToImageInfo2KHR* pCopyBufferToImageInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyImageToBuffer2KHR")]
        public static extern unsafe void CmdCopyImageToBuffer2KHR(
            VkCommandBuffer              commandBuffer,
            VkCopyImageToBufferInfo2KHR* pCopyImageToBufferInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBlitImage2KHR")]
        public static extern unsafe void CmdBlitImage2KHR(
            VkCommandBuffer      commandBuffer,
            VkBlitImageInfo2KHR* pBlitImageInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdResolveImage2KHR")]
        public static extern unsafe void CmdResolveImage2KHR(
            VkCommandBuffer         commandBuffer,
            VkResolveImageInfo2KHR* pResolveImageInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public static extern unsafe VkResult CreateDebugReportCallbackEXT(
            VkInstance                          instance,
            VkDebugReportCallbackCreateInfoEXT* pCreateInfo,
            VkAllocationCallbacks*              pAllocator,
            VkDebugReportCallbackEXT*           pCallback);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public static extern unsafe void DestroyDebugReportCallbackEXT(
            VkInstance               instance,
            VkDebugReportCallbackEXT callback,
            VkAllocationCallbacks*   pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDebugReportMessageEXT")]
        public static extern unsafe void DebugReportMessageEXT(
            VkInstance                 instance,
            VkDebugReportFlagsEXT      flags,
            VkDebugReportObjectTypeEXT objectType,
            ulong                      @object,
            size_t                     location,
            int                        messageCode,
            byte*                      pLayerPrefix,
            byte*                      pMessage);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        public static extern unsafe VkResult DebugMarkerSetObjectTagEXT(
            VkDevice                       device,
            VkDebugMarkerObjectTagInfoEXT* pTagInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        public static extern unsafe VkResult DebugMarkerSetObjectNameEXT(
            VkDevice                        device,
            VkDebugMarkerObjectNameInfoEXT* pNameInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        public static extern unsafe void CmdDebugMarkerBeginEXT(
            VkCommandBuffer             commandBuffer,
            VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDebugMarkerEndEXT")]
        public static extern void CmdDebugMarkerEndEXT(VkCommandBuffer commandBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        public static extern unsafe void CmdDebugMarkerInsertEXT(
            VkCommandBuffer             commandBuffer,
            VkDebugMarkerMarkerInfoEXT* pMarkerInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindTransformFeedbackBuffersEXT")]
        public static extern unsafe void CmdBindTransformFeedbackBuffersEXT(
            VkCommandBuffer commandBuffer,
            uint            firstBinding,
            uint            bindingCount,
            VkBuffer*       pBuffers,
            VkDeviceSize*   pOffsets,
            VkDeviceSize*   pSizes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginTransformFeedbackEXT")]
        public static extern unsafe void CmdBeginTransformFeedbackEXT(
            VkCommandBuffer commandBuffer,
            uint            firstCounterBuffer,
            uint            counterBufferCount,
            VkBuffer*       pCounterBuffers,
            VkDeviceSize*   pCounterBufferOffsets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndTransformFeedbackEXT")]
        public static extern unsafe void CmdEndTransformFeedbackEXT(
            VkCommandBuffer commandBuffer,
            uint            firstCounterBuffer,
            uint            counterBufferCount,
            VkBuffer*       pCounterBuffers,
            VkDeviceSize*   pCounterBufferOffsets);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginQueryIndexedEXT")]
        public static extern void CmdBeginQueryIndexedEXT(
            VkCommandBuffer     commandBuffer,
            VkQueryPool         queryPool,
            uint                query,
            VkQueryControlFlags flags,
            uint                index);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndQueryIndexedEXT")]
        public static extern void CmdEndQueryIndexedEXT(
            VkCommandBuffer commandBuffer,
            VkQueryPool     queryPool,
            uint            query,
            uint            index);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndirectByteCountEXT")]
        public static extern void CmdDrawIndirectByteCountEXT(
            VkCommandBuffer commandBuffer,
            uint            instanceCount,
            uint            firstInstance,
            VkBuffer        counterBuffer,
            VkDeviceSize    counterBufferOffset,
            uint            counterOffset,
            uint            vertexStride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageViewHandleNVX")]
        public static extern unsafe uint GetImageViewHandleNVX(
            VkDevice                  device,
            VkImageViewHandleInfoNVX* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageViewAddressNVX")]
        public static extern unsafe VkResult GetImageViewAddressNVX(
            VkDevice                         device,
            VkImageView                      imageView,
            VkImageViewAddressPropertiesNVX* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndirectCountAMD")]
        public static extern void CmdDrawIndirectCountAMD(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawIndexedIndirectCountAMD")]
        public static extern void CmdDrawIndexedIndirectCountAMD(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetShaderInfoAMD")]
        public static extern unsafe VkResult GetShaderInfoAMD(
            VkDevice            device,
            VkPipeline          pipeline,
            VkShaderStageFlags  shaderStage,
            VkShaderInfoTypeAMD infoType,
            size_t*             pInfoSize,
            void*               pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceExternalImageFormatPropertiesNV")]
        public static extern unsafe VkResult GetPhysicalDeviceExternalImageFormatPropertiesNV(
            VkPhysicalDevice                   physicalDevice,
            VkFormat                           format,
            VkImageType                        type,
            VkImageTiling                      tiling,
            VkImageUsageFlags                  usage,
            VkImageCreateFlags                 flags,
            VkExternalMemoryHandleTypeFlagsNV  externalHandleType,
            VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        public static extern unsafe void CmdBeginConditionalRenderingEXT(
            VkCommandBuffer                     commandBuffer,
            VkConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndConditionalRenderingEXT")]
        public static extern void CmdEndConditionalRenderingEXT(VkCommandBuffer commandBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetViewportWScalingNV")]
        public static extern unsafe void CmdSetViewportWScalingNV(
            VkCommandBuffer       commandBuffer,
            uint                  firstViewport,
            uint                  viewportCount,
            VkViewportWScalingNV* pViewportWScalings);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkReleaseDisplayEXT")]
        public static extern VkResult ReleaseDisplayEXT(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR     display);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSurfaceCapabilities2EXT")]
        public static extern unsafe VkResult GetPhysicalDeviceSurfaceCapabilities2EXT(
            VkPhysicalDevice           physicalDevice,
            VkSurfaceKHR               surface,
            VkSurfaceCapabilities2EXT* pSurfaceCapabilities);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDisplayPowerControlEXT")]
        public static extern unsafe VkResult DisplayPowerControlEXT(
            VkDevice               device,
            VkDisplayKHR           display,
            VkDisplayPowerInfoEXT* pDisplayPowerInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkRegisterDeviceEventEXT")]
        public static extern unsafe VkResult RegisterDeviceEventEXT(
            VkDevice               device,
            VkDeviceEventInfoEXT*  pDeviceEventInfo,
            VkAllocationCallbacks* pAllocator,
            VkFence*               pFence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkRegisterDisplayEventEXT")]
        public static extern unsafe VkResult RegisterDisplayEventEXT(
            VkDevice               device,
            VkDisplayKHR           display,
            VkDisplayEventInfoEXT* pDisplayEventInfo,
            VkAllocationCallbacks* pAllocator,
            VkFence*               pFence);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetSwapchainCounterEXT")]
        public static extern unsafe VkResult GetSwapchainCounterEXT(
            VkDevice                 device,
            VkSwapchainKHR           swapchain,
            VkSurfaceCounterFlagsEXT counter,
            ulong*                   pCounterValue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRefreshCycleDurationGOOGLE")]
        public static extern unsafe VkResult GetRefreshCycleDurationGOOGLE(
            VkDevice                      device,
            VkSwapchainKHR                swapchain,
            VkRefreshCycleDurationGOOGLE* pDisplayTimingProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPastPresentationTimingGOOGLE")]
        public static extern unsafe VkResult GetPastPresentationTimingGOOGLE(
            VkDevice                        device,
            VkSwapchainKHR                  swapchain,
            uint*                           pPresentationTimingCount,
            VkPastPresentationTimingGOOGLE* pPresentationTimings);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDiscardRectangleEXT")]
        public static extern unsafe void CmdSetDiscardRectangleEXT(
            VkCommandBuffer commandBuffer,
            uint            firstDiscardRectangle,
            uint            discardRectangleCount,
            VkRect2D*       pDiscardRectangles);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetHdrMetadataEXT")]
        public static extern unsafe void SetHdrMetadataEXT(
            VkDevice          device,
            uint              swapchainCount,
            VkSwapchainKHR*   pSwapchains,
            VkHdrMetadataEXT* pMetadata);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        public static extern unsafe VkResult SetDebugUtilsObjectNameEXT(
            VkDevice                       device,
            VkDebugUtilsObjectNameInfoEXT* pNameInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        public static extern unsafe VkResult SetDebugUtilsObjectTagEXT(
            VkDevice                      device,
            VkDebugUtilsObjectTagInfoEXT* pTagInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        public static extern unsafe void QueueBeginDebugUtilsLabelEXT(
            VkQueue               queue,
            VkDebugUtilsLabelEXT* pLabelInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
        public static extern void QueueEndDebugUtilsLabelEXT(VkQueue queue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        public static extern unsafe void QueueInsertDebugUtilsLabelEXT(
            VkQueue               queue,
            VkDebugUtilsLabelEXT* pLabelInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        public static extern unsafe void CmdBeginDebugUtilsLabelEXT(
            VkCommandBuffer       commandBuffer,
            VkDebugUtilsLabelEXT* pLabelInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
        public static extern void CmdEndDebugUtilsLabelEXT(VkCommandBuffer commandBuffer);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        public static extern unsafe void CmdInsertDebugUtilsLabelEXT(
            VkCommandBuffer       commandBuffer,
            VkDebugUtilsLabelEXT* pLabelInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public static extern unsafe VkResult CreateDebugUtilsMessengerEXT(
            VkInstance                          instance,
            VkDebugUtilsMessengerCreateInfoEXT* pCreateInfo,
            VkAllocationCallbacks*              pAllocator,
            VkDebugUtilsMessengerEXT*           pMessenger);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        public static extern unsafe void DestroyDebugUtilsMessengerEXT(
            VkInstance               instance,
            VkDebugUtilsMessengerEXT messenger,
            VkAllocationCallbacks*   pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        public static extern unsafe void SubmitDebugUtilsMessageEXT(
            VkInstance                            instance,
            VkDebugUtilsMessageSeverityFlagsEXT   messageSeverity,
            VkDebugUtilsMessageTypeFlagsEXT       messageTypes,
            VkDebugUtilsMessengerCallbackDataEXT* pCallbackData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetSampleLocationsEXT")]
        public static extern unsafe void CmdSetSampleLocationsEXT(
            VkCommandBuffer           commandBuffer,
            VkSampleLocationsInfoEXT* pSampleLocationsInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceMultisamplePropertiesEXT")]
        public static extern unsafe void GetPhysicalDeviceMultisamplePropertiesEXT(
            VkPhysicalDevice            physicalDevice,
            VkSampleCountFlags          samples,
            VkMultisamplePropertiesEXT* pMultisampleProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetImageDrmFormatModifierPropertiesEXT")]
        public static extern unsafe VkResult GetImageDrmFormatModifierPropertiesEXT(
            VkDevice device,
            VkImage  image,
            VkImageDrmFormatModifierPropertiesEXT
                * pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateValidationCacheEXT")]
        public static extern unsafe VkResult CreateValidationCacheEXT(
            VkDevice                        device,
            VkValidationCacheCreateInfoEXT* pCreateInfo,
            VkAllocationCallbacks*          pAllocator,
            VkValidationCacheEXT*           pValidationCache);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyValidationCacheEXT")]
        public static extern unsafe void DestroyValidationCacheEXT(
            VkDevice               device,
            VkValidationCacheEXT   validationCache,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkMergeValidationCachesEXT")]
        public static extern unsafe VkResult MergeValidationCachesEXT(
            VkDevice              device,
            VkValidationCacheEXT  dstCache,
            uint                  srcCacheCount,
            VkValidationCacheEXT* pSrcCaches);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetValidationCacheDataEXT")]
        public static extern unsafe VkResult GetValidationCacheDataEXT(
            VkDevice             device,
            VkValidationCacheEXT validationCache,
            size_t*              pDataSize,
            void*                pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindShadingRateImageNV")]
        public static extern void CmdBindShadingRateImageNV(
            VkCommandBuffer commandBuffer,
            VkImageView     imageView,
            VkImageLayout   imageLayout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        public static extern unsafe void CmdSetViewportShadingRatePaletteNV(
            VkCommandBuffer         commandBuffer,
            uint                    firstViewport,
            uint                    viewportCount,
            VkShadingRatePaletteNV* pShadingRatePalettes);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        public static extern unsafe void CmdSetCoarseSampleOrderNV(
            VkCommandBuffer              commandBuffer,
            VkCoarseSampleOrderTypeNV    sampleOrderType,
            uint                         customSampleOrderCount,
            VkCoarseSampleOrderCustomNV* pCustomSampleOrders);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateAccelerationStructureNV")]
        public static extern unsafe VkResult CreateAccelerationStructureNV(
            VkDevice                             device,
            VkAccelerationStructureCreateInfoNV* pCreateInfo,
            VkAllocationCallbacks*               pAllocator,
            VkAccelerationStructureNV*           pAccelerationStructure);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyAccelerationStructureNV")]
        public static extern unsafe void DestroyAccelerationStructureNV(
            VkDevice                  device,
            VkAccelerationStructureNV accelerationStructure,
            VkAllocationCallbacks*    pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetAccelerationStructureMemoryRequirementsNV")]
        public static extern unsafe void GetAccelerationStructureMemoryRequirementsNV(
            VkDevice device,
            VkAccelerationStructureMemoryRequirementsInfoNV
                * pInfo,
            VkMemoryRequirements2KHR* pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBindAccelerationStructureMemoryNV")]
        public static extern unsafe VkResult BindAccelerationStructureMemoryNV(
            VkDevice                                 device,
            uint                                     bindInfoCount,
            VkBindAccelerationStructureMemoryInfoNV* pBindInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBuildAccelerationStructureNV")]
        public static extern unsafe void CmdBuildAccelerationStructureNV(
            VkCommandBuffer                commandBuffer,
            VkAccelerationStructureInfoNV* pInfo,
            VkBuffer                       instanceData,
            VkDeviceSize                   instanceOffset,
            uint                           update,
            VkAccelerationStructureNV      dst,
            VkAccelerationStructureNV      src,
            VkBuffer                       scratch,
            VkDeviceSize                   scratchOffset);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyAccelerationStructureNV")]
        public static extern void CmdCopyAccelerationStructureNV(
            VkCommandBuffer                    commandBuffer,
            VkAccelerationStructureNV          dst,
            VkAccelerationStructureNV          src,
            VkCopyAccelerationStructureModeKHR mode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdTraceRaysNV")]
        public static extern void CmdTraceRaysNV(
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

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateRayTracingPipelinesNV")]
        public static extern unsafe VkResult CreateRayTracingPipelinesNV(
            VkDevice                          device,
            VkPipelineCache                   pipelineCache,
            uint                              createInfoCount,
            VkRayTracingPipelineCreateInfoNV* pCreateInfos,
            VkAllocationCallbacks*            pAllocator,
            VkPipeline*                       pPipelines);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRayTracingShaderGroupHandlesKHR")]
        public static extern unsafe VkResult GetRayTracingShaderGroupHandlesKHR(
            VkDevice   device,
            VkPipeline pipeline,
            uint       firstGroup,
            uint       groupCount,
            size_t     dataSize,
            void*      pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRayTracingShaderGroupHandlesNV")]
        public static extern unsafe VkResult GetRayTracingShaderGroupHandlesNV(
            VkDevice   device,
            VkPipeline pipeline,
            uint       firstGroup,
            uint       groupCount,
            size_t     dataSize,
            void*      pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetAccelerationStructureHandleNV")]
        public static extern unsafe VkResult GetAccelerationStructureHandleNV(
            VkDevice device,
            VkAccelerationStructureNV
                accelerationStructure,
            size_t dataSize,
            void*  pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesNV")]
        public static extern unsafe void CmdWriteAccelerationStructuresPropertiesNV(
            VkCommandBuffer            commandBuffer,
            uint                       accelerationStructureCount,
            VkAccelerationStructureNV* pAccelerationStructures,
            VkQueryType                queryType,
            VkQueryPool                queryPool,
            uint                       firstQuery);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCompileDeferredNV")]
        public static extern VkResult CompileDeferredNV(
            VkDevice   device,
            VkPipeline pipeline,
            uint       shader);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public static extern unsafe VkResult GetMemoryHostPointerPropertiesEXT(
            VkDevice device,
            VkExternalMemoryHandleTypeFlags
                handleType,
            void*                             pHostPointer,
            VkMemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdWriteBufferMarkerAMD")]
        public static extern void CmdWriteBufferMarkerAMD(
            VkCommandBuffer      commandBuffer,
            VkPipelineStageFlags pipelineStage,
            VkBuffer             dstBuffer,
            VkDeviceSize         dstOffset,
            uint                 marker);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceCalibrateableTimeDomainsEXT")]
        public static extern unsafe VkResult GetPhysicalDeviceCalibrateableTimeDomainsEXT(
            VkPhysicalDevice physicalDevice,
            uint*            pTimeDomainCount,
            VkTimeDomainEXT* pTimeDomains);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetCalibratedTimestampsEXT")]
        public static extern unsafe VkResult GetCalibratedTimestampsEXT(
            VkDevice                      device,
            uint                          timestampCount,
            VkCalibratedTimestampInfoEXT* pTimestampInfos,
            ulong*                        pTimestamps,
            ulong*                        pMaxDeviation);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawMeshTasksNV")]
        public static extern void CmdDrawMeshTasksNV(
            VkCommandBuffer commandBuffer,
            uint            taskCount,
            uint            firstTask);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawMeshTasksIndirectNV")]
        public static extern void CmdDrawMeshTasksIndirectNV(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            uint            drawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdDrawMeshTasksIndirectCountNV")]
        public static extern void CmdDrawMeshTasksIndirectCountNV(
            VkCommandBuffer commandBuffer,
            VkBuffer        buffer,
            VkDeviceSize    offset,
            VkBuffer        countBuffer,
            VkDeviceSize    countBufferOffset,
            uint            maxDrawCount,
            uint            stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetExclusiveScissorNV")]
        public static extern unsafe void CmdSetExclusiveScissorNV(
            VkCommandBuffer commandBuffer,
            uint            firstExclusiveScissor,
            uint            exclusiveScissorCount,
            VkRect2D*       pExclusiveScissors);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetCheckpointNV")]
        public static extern unsafe void CmdSetCheckpointNV(
            VkCommandBuffer commandBuffer,
            void*           pCheckpointMarker);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetQueueCheckpointDataNV")]
        public static extern unsafe void GetQueueCheckpointDataNV(
            VkQueue             queue,
            uint*               pCheckpointDataCount,
            VkCheckpointDataNV* pCheckpointData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkInitializePerformanceApiINTEL")]
        public static extern unsafe VkResult InitializePerformanceApiINTEL(
            VkDevice                             device,
            VkInitializePerformanceApiInfoINTEL* pInitializeInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkUninitializePerformanceApiINTEL")]
        public static extern void UninitializePerformanceApiINTEL(VkDevice device);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetPerformanceMarkerINTEL")]
        public static extern unsafe VkResult CmdSetPerformanceMarkerINTEL(
            VkCommandBuffer               commandBuffer,
            VkPerformanceMarkerInfoINTEL* pMarkerInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetPerformanceStreamMarkerINTEL")]
        public static extern unsafe VkResult CmdSetPerformanceStreamMarkerINTEL(
            VkCommandBuffer                     commandBuffer,
            VkPerformanceStreamMarkerInfoINTEL* pMarkerInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetPerformanceOverrideINTEL")]
        public static extern unsafe VkResult CmdSetPerformanceOverrideINTEL(
            VkCommandBuffer                 commandBuffer,
            VkPerformanceOverrideInfoINTEL* pOverrideInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquirePerformanceConfigurationINTEL")]
        public static extern unsafe VkResult AcquirePerformanceConfigurationINTEL(
            VkDevice device,
            VkPerformanceConfigurationAcquireInfoINTEL
                * pAcquireInfo,
            VkPerformanceConfigurationINTEL* pConfiguration);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkReleasePerformanceConfigurationINTEL")]
        public static extern VkResult ReleasePerformanceConfigurationINTEL(
            VkDevice device,
            VkPerformanceConfigurationINTEL
                configuration);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkQueueSetPerformanceConfigurationINTEL")]
        public static extern VkResult QueueSetPerformanceConfigurationINTEL(
            VkQueue queue,
            VkPerformanceConfigurationINTEL
                configuration);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPerformanceParameterINTEL")]
        public static extern unsafe VkResult GetPerformanceParameterINTEL(
            VkDevice                        device,
            VkPerformanceParameterTypeINTEL parameter,
            VkPerformanceValueINTEL*        pValue);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetLocalDimmingAMD")]
        public static extern void SetLocalDimmingAMD(
            VkDevice       device,
            VkSwapchainKHR swapChain,
            uint           localDimmingEnable);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetBufferDeviceAddressEXT")]
        public static extern unsafe VkDeviceAddress GetBufferDeviceAddressEXT(
            VkDevice                   device,
            VkBufferDeviceAddressInfo* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public static extern unsafe VkResult GetPhysicalDeviceToolPropertiesEXT(
            VkPhysicalDevice                   physicalDevice,
            uint*                              pToolCount,
            VkPhysicalDeviceToolPropertiesEXT* pToolProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public static extern unsafe VkResult GetPhysicalDeviceCooperativeMatrixPropertiesNV(
            VkPhysicalDevice                 physicalDevice,
            uint*                            pPropertyCount,
            VkCooperativeMatrixPropertiesNV* pProperties);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV")]
        public static extern unsafe VkResult GetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(
            VkPhysicalDevice                        physicalDevice,
            uint*                                   pCombinationCount,
            VkFramebufferMixedSamplesCombinationNV* pCombinations);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateHeadlessSurfaceEXT")]
        public static extern unsafe VkResult CreateHeadlessSurfaceEXT(
            VkInstance                      instance,
            VkHeadlessSurfaceCreateInfoEXT* pCreateInfo,
            VkAllocationCallbacks*          pAllocator,
            VkSurfaceKHR*                   pSurface);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetLineStippleEXT")]
        public static extern void CmdSetLineStippleEXT(
            VkCommandBuffer commandBuffer,
            uint            lineStippleFactor,
            ushort          lineStipplePattern);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkResetQueryPoolEXT")]
        public static extern void ResetQueryPoolEXT(
            VkDevice    device,
            VkQueryPool queryPool,
            uint        firstQuery,
            uint        queryCount);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetCullModeEXT")]
        public static extern void CmdSetCullModeEXT(
            VkCommandBuffer commandBuffer,
            VkCullModeFlags cullMode);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetFrontFaceEXT")]
        public static extern void CmdSetFrontFaceEXT(
            VkCommandBuffer commandBuffer,
            VkFrontFace     frontFace);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetPrimitiveTopologyEXT")]
        public static extern void CmdSetPrimitiveTopologyEXT(
            VkCommandBuffer     commandBuffer,
            VkPrimitiveTopology primitiveTopology);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetViewportWithCountEXT")]
        public static extern unsafe void CmdSetViewportWithCountEXT(
            VkCommandBuffer commandBuffer,
            uint            viewportCount,
            VkViewport*     pViewports);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetScissorWithCountEXT")]
        public static extern unsafe void CmdSetScissorWithCountEXT(
            VkCommandBuffer commandBuffer,
            uint            scissorCount,
            VkRect2D*       pScissors);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindVertexBuffers2EXT")]
        public static extern unsafe void CmdBindVertexBuffers2EXT(
            VkCommandBuffer commandBuffer,
            uint            firstBinding,
            uint            bindingCount,
            VkBuffer*       pBuffers,
            VkDeviceSize*   pOffsets,
            VkDeviceSize*   pSizes,
            VkDeviceSize*   pStrides);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthTestEnableEXT")]
        public static extern void CmdSetDepthTestEnableEXT(
            VkCommandBuffer commandBuffer,
            uint            depthTestEnable);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthWriteEnableEXT")]
        public static extern void CmdSetDepthWriteEnableEXT(
            VkCommandBuffer commandBuffer,
            uint            depthWriteEnable);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthCompareOpEXT")]
        public static extern void CmdSetDepthCompareOpEXT(
            VkCommandBuffer commandBuffer,
            VkCompareOp     depthCompareOp);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetDepthBoundsTestEnableEXT")]
        public static extern void CmdSetDepthBoundsTestEnableEXT(
            VkCommandBuffer commandBuffer,
            uint            depthBoundsTestEnable);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetStencilTestEnableEXT")]
        public static extern void CmdSetStencilTestEnableEXT(
            VkCommandBuffer commandBuffer,
            uint            stencilTestEnable);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetStencilOpEXT")]
        public static extern void CmdSetStencilOpEXT(
            VkCommandBuffer    commandBuffer,
            VkStencilFaceFlags faceMask,
            VkStencilOp        failOp,
            VkStencilOp        passOp,
            VkStencilOp        depthFailOp,
            VkCompareOp        compareOp);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetGeneratedCommandsMemoryRequirementsNV")]
        public static extern unsafe void GetGeneratedCommandsMemoryRequirementsNV(
            VkDevice device,
            VkGeneratedCommandsMemoryRequirementsInfoNV
                * pInfo,
            VkMemoryRequirements2* pMemoryRequirements);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdPreprocessGeneratedCommandsNV")]
        public static extern unsafe void CmdPreprocessGeneratedCommandsNV(
            VkCommandBuffer            commandBuffer,
            VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdExecuteGeneratedCommandsNV")]
        public static extern unsafe void CmdExecuteGeneratedCommandsNV(
            VkCommandBuffer            commandBuffer,
            uint                       isPreprocessed,
            VkGeneratedCommandsInfoNV* pGeneratedCommandsInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBindPipelineShaderGroupNV")]
        public static extern void CmdBindPipelineShaderGroupNV(
            VkCommandBuffer     commandBuffer,
            VkPipelineBindPoint pipelineBindPoint,
            VkPipeline          pipeline,
            uint                groupIndex);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateIndirectCommandsLayoutNV")]
        public static extern unsafe VkResult CreateIndirectCommandsLayoutNV(
            VkDevice                              device,
            VkIndirectCommandsLayoutCreateInfoNV* pCreateInfo,
            VkAllocationCallbacks*                pAllocator,
            VkIndirectCommandsLayoutNV*           pIndirectCommandsLayout);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyIndirectCommandsLayoutNV")]
        public static extern unsafe void DestroyIndirectCommandsLayoutNV(
            VkDevice device,
            VkIndirectCommandsLayoutNV
                indirectCommandsLayout,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public static extern unsafe VkResult CreatePrivateDataSlotEXT(
            VkDevice                        device,
            VkPrivateDataSlotCreateInfoEXT* pCreateInfo,
            VkAllocationCallbacks*          pAllocator,
            VkPrivateDataSlotEXT*           pPrivateDataSlot);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        public static extern unsafe void DestroyPrivateDataSlotEXT(
            VkDevice               device,
            VkPrivateDataSlotEXT   privateDataSlot,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkSetPrivateDataEXT")]
        public static extern VkResult SetPrivateDataEXT(
            VkDevice             device,
            VkObjectType         objectType,
            ulong                objectHandle,
            VkPrivateDataSlotEXT privateDataSlot,
            ulong                data);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetPrivateDataEXT")]
        public static extern unsafe void GetPrivateDataEXT(
            VkDevice             device,
            VkObjectType         objectType,
            ulong                objectHandle,
            VkPrivateDataSlotEXT privateDataSlot,
            ulong*               pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetFragmentShadingRateEnumNV")]
        public static extern void CmdSetFragmentShadingRateEnumNV(
            VkCommandBuffer                    commandBuffer,
            VkFragmentShadingRateNV            shadingRate,
            VkFragmentShadingRateCombinerOpKHR combinerOps1,
            VkFragmentShadingRateCombinerOpKHR combinerOps2);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkAcquireWinrtDisplayNV")]
        public static extern VkResult AcquireWinrtDisplayNV(
            VkPhysicalDevice physicalDevice,
            VkDisplayKHR     display);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetWinrtDisplayNV")]
        public static extern unsafe VkResult GetWinrtDisplayNV(
            VkPhysicalDevice physicalDevice,
            uint             deviceRelativeId,
            VkDisplayKHR*    pDisplay);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateAccelerationStructureKHR")]
        public static extern unsafe VkResult CreateAccelerationStructureKHR(
            VkDevice                              device,
            VkAccelerationStructureCreateInfoKHR* pCreateInfo,
            VkAllocationCallbacks*                pAllocator,
            VkAccelerationStructureKHR*           pAccelerationStructure);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkDestroyAccelerationStructureKHR")]
        public static extern unsafe void DestroyAccelerationStructureKHR(
            VkDevice device,
            VkAccelerationStructureKHR
                accelerationStructure,
            VkAllocationCallbacks* pAllocator);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBuildAccelerationStructuresKHR")]
        public static extern unsafe void CmdBuildAccelerationStructuresKHR(
            VkCommandBuffer                              commandBuffer,
            uint                                         infoCount,
            VkAccelerationStructureBuildGeometryInfoKHR* pInfos,
            VkAccelerationStructureBuildRangeInfoKHR**   ppBuildRangeInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdBuildAccelerationStructuresIndirectKHR")]
        public static extern unsafe void CmdBuildAccelerationStructuresIndirectKHR(
            VkCommandBuffer commandBuffer,
            uint            infoCount,
            VkAccelerationStructureBuildGeometryInfoKHR
                * pInfos,
            VkDeviceAddress* pIndirectDeviceAddresses,
            uint*            pIndirectStrides,
            uint**           ppMaxPrimitiveCounts);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkBuildAccelerationStructuresKHR")]
        public static extern unsafe VkResult BuildAccelerationStructuresKHR(
            VkDevice                                     device,
            VkDeferredOperationKHR                       deferredOperation,
            uint                                         infoCount,
            VkAccelerationStructureBuildGeometryInfoKHR* pInfos,
            VkAccelerationStructureBuildRangeInfoKHR**   ppBuildRangeInfos);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCopyAccelerationStructureKHR")]
        public static extern unsafe VkResult CopyAccelerationStructureKHR(
            VkDevice                            device,
            VkDeferredOperationKHR              deferredOperation,
            VkCopyAccelerationStructureInfoKHR* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCopyAccelerationStructureToMemoryKHR")]
        public static extern unsafe VkResult CopyAccelerationStructureToMemoryKHR(
            VkDevice device,
            VkDeferredOperationKHR
                deferredOperation,
            VkCopyAccelerationStructureToMemoryInfoKHR
                * pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCopyMemoryToAccelerationStructureKHR")]
        public static extern unsafe VkResult CopyMemoryToAccelerationStructureKHR(
            VkDevice device,
            VkDeferredOperationKHR
                deferredOperation,
            VkCopyMemoryToAccelerationStructureInfoKHR
                * pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkWriteAccelerationStructuresPropertiesKHR")]
        public static extern unsafe VkResult WriteAccelerationStructuresPropertiesKHR(
            VkDevice                    device,
            uint                        accelerationStructureCount,
            VkAccelerationStructureKHR* pAccelerationStructures,
            VkQueryType                 queryType,
            size_t                      dataSize,
            void*                       pData,
            size_t                      stride);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyAccelerationStructureKHR")]
        public static extern unsafe void CmdCopyAccelerationStructureKHR(
            VkCommandBuffer                     commandBuffer,
            VkCopyAccelerationStructureInfoKHR* pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyAccelerationStructureToMemoryKHR")]
        public static extern unsafe void CmdCopyAccelerationStructureToMemoryKHR(
            VkCommandBuffer commandBuffer,
            VkCopyAccelerationStructureToMemoryInfoKHR
                * pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdCopyMemoryToAccelerationStructureKHR")]
        public static extern unsafe void CmdCopyMemoryToAccelerationStructureKHR(
            VkCommandBuffer commandBuffer,
            VkCopyMemoryToAccelerationStructureInfoKHR
                * pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetAccelerationStructureDeviceAddressKHR")]
        public static extern unsafe VkDeviceAddress GetAccelerationStructureDeviceAddressKHR(
            VkDevice device,
            VkAccelerationStructureDeviceAddressInfoKHR
                * pInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdWriteAccelerationStructuresPropertiesKHR")]
        public static extern unsafe void CmdWriteAccelerationStructuresPropertiesKHR(
            VkCommandBuffer             commandBuffer,
            uint                        accelerationStructureCount,
            VkAccelerationStructureKHR* pAccelerationStructures,
            VkQueryType                 queryType,
            VkQueryPool                 queryPool,
            uint                        firstQuery);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetDeviceAccelerationStructureCompatibilityKHR")]
        public static extern unsafe void GetDeviceAccelerationStructureCompatibilityKHR(
            VkDevice device,
            VkAccelerationStructureVersionInfoKHR
                * pVersionInfo,
            VkAccelerationStructureCompatibilityKHR
                * pCompatibility);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetAccelerationStructureBuildSizesKHR")]
        public static extern unsafe void GetAccelerationStructureBuildSizesKHR(
            VkDevice device,
            VkAccelerationStructureBuildTypeKHR
                buildType,
            VkAccelerationStructureBuildGeometryInfoKHR
                * pBuildInfo,
            uint*                                     pMaxPrimitiveCounts,
            VkAccelerationStructureBuildSizesInfoKHR* pSizeInfo);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdTraceRaysKHR")]
        public static extern unsafe void CmdTraceRaysKHR(
            VkCommandBuffer                  commandBuffer,
            VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
            uint                             width,
            uint                             height,
            uint                             depth);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCreateRayTracingPipelinesKHR")]
        public static extern unsafe VkResult CreateRayTracingPipelinesKHR(
            VkDevice                           device,
            VkDeferredOperationKHR             deferredOperation,
            VkPipelineCache                    pipelineCache,
            uint                               createInfoCount,
            VkRayTracingPipelineCreateInfoKHR* pCreateInfos,
            VkAllocationCallbacks*             pAllocator,
            VkPipeline*                        pPipelines);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRayTracingCaptureReplayShaderGroupHandlesKHR")]
        public static extern unsafe VkResult GetRayTracingCaptureReplayShaderGroupHandlesKHR(
            VkDevice   device,
            VkPipeline pipeline,
            uint       firstGroup,
            uint       groupCount,
            size_t     dataSize,
            void*      pData);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdTraceRaysIndirectKHR")]
        public static extern unsafe void CmdTraceRaysIndirectKHR(
            VkCommandBuffer                  commandBuffer,
            VkStridedDeviceAddressRegionKHR* pRaygenShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pMissShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pHitShaderBindingTable,
            VkStridedDeviceAddressRegionKHR* pCallableShaderBindingTable,
            VkDeviceAddress                  indirectDeviceAddress);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkGetRayTracingShaderGroupStackSizeKHR")]
        public static extern VkDeviceSize GetRayTracingShaderGroupStackSizeKHR(
            VkDevice               device,
            VkPipeline             pipeline,
            uint                   group,
            VkShaderGroupShaderKHR groupShader);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(IMPORT, EntryPoint = "vkCmdSetRayTracingPipelineStackSizeKHR")]
        public static extern void CmdSetRayTracingPipelineStackSizeKHR(
            VkCommandBuffer commandBuffer,
            uint            pipelineStackSize);
    }
}