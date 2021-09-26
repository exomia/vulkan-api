#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    public readonly unsafe struct VkDevice
    {
        public static readonly VkDevice Null = (VkDevice)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDevice(void* ptr)
        {
            VkDevice value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDevice left, VkDevice right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDevice left, VkDevice right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDevice obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDevice vkDevice && Equals(in vkDevice);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDevice value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDeferredOperationKHR
    {
        public static readonly VkDeferredOperationKHR Null = (VkDeferredOperationKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDeferredOperationKHR(void* ptr)
        {
            VkDeferredOperationKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDeferredOperationKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeferredOperationKHR vkDeferredOperationKHR && Equals(in vkDeferredOperationKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDeferredOperationKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkPerformanceConfigurationINTEL
    {
        public static readonly VkPerformanceConfigurationINTEL Null = (VkPerformanceConfigurationINTEL)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPerformanceConfigurationINTEL(void* ptr)
        {
            VkPerformanceConfigurationINTEL value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPerformanceConfigurationINTEL obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPerformanceConfigurationINTEL vkPerformanceConfigurationINTEL && Equals(in vkPerformanceConfigurationINTEL);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPerformanceConfigurationINTEL value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDescriptorUpdateTemplate
    {
        public static readonly VkDescriptorUpdateTemplate Null = (VkDescriptorUpdateTemplate)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDescriptorUpdateTemplate(void* ptr)
        {
            VkDescriptorUpdateTemplate value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDescriptorUpdateTemplate obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorUpdateTemplate vkDescriptorUpdateTemplate && Equals(in vkDescriptorUpdateTemplate);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorUpdateTemplate value)
        {
            return value._ptr;
        }
    }
    

    public readonly unsafe struct VkInstance
    {
        public static readonly VkInstance Null = (VkInstance)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkInstance(void* ptr)
        {
            VkInstance value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkInstance left, VkInstance right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkInstance left, VkInstance right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkInstance obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkInstance vkInstance && Equals(in vkInstance);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkInstance value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkEvent
    {
        public static readonly VkEvent Null = (VkEvent)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkEvent(void* ptr)
        {
            VkEvent value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkEvent left, VkEvent right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkEvent left, VkEvent right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkEvent obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkEvent vkEvent && Equals(in vkEvent);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkEvent value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkQueue
    {
        public static readonly VkQueue Null = (VkQueue)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkQueue(void* ptr)
        {
            VkQueue value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkQueue left, VkQueue right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkQueue left, VkQueue right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkQueue obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkQueue vkQueue && Equals(in vkQueue);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkQueue value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkQueryPool
    {
        public static readonly VkQueryPool Null = (VkQueryPool)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkQueryPool(void* ptr)
        {
            VkQueryPool value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkQueryPool left, VkQueryPool right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkQueryPool left, VkQueryPool right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkQueryPool obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkQueryPool vkQueryPool && Equals(in vkQueryPool);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkQueryPool value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkPipelineCache
    {
        public static readonly VkPipelineCache Null = (VkPipelineCache)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPipelineCache(void* ptr)
        {
            VkPipelineCache value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPipelineCache left, VkPipelineCache right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPipelineCache left, VkPipelineCache right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPipelineCache obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPipelineCache vkPipelineCache && Equals(in vkPipelineCache);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipelineCache value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkPhysicalDevice
    {
        public static readonly VkPhysicalDevice Null = (VkPhysicalDevice)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPhysicalDevice(void* ptr)
        {
            VkPhysicalDevice value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPhysicalDevice obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPhysicalDevice vkPhysicalDevice && Equals(in vkPhysicalDevice);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPhysicalDevice value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkBuffer
    {
        public static readonly VkBuffer Null = (VkBuffer)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkBuffer(void* ptr)
        {
            VkBuffer value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkBuffer left, VkBuffer right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkBuffer left, VkBuffer right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkBuffer obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkBuffer vkBuffer && Equals(in vkBuffer);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkBuffer value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkCommandBuffer
    {
        public static readonly VkCommandBuffer Null = (VkCommandBuffer)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCommandBuffer(void* ptr)
        {
            VkCommandBuffer value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCommandBuffer obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCommandBuffer vkCommandBuffer && Equals(in vkCommandBuffer);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCommandBuffer value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkImage
    {
        public static readonly VkImage Null = (VkImage)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkImage(void* ptr)
        {
            VkImage value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkImage left, VkImage right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkImage left, VkImage right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkImage obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkImage vkImage && Equals(in vkImage);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkImage value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkSemaphore
    {
        public static readonly VkSemaphore Null = (VkSemaphore)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSemaphore(void* ptr)
        {
            VkSemaphore value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSemaphore left, VkSemaphore right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSemaphore left, VkSemaphore right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSemaphore obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSemaphore vkSemaphore && Equals(in vkSemaphore);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSemaphore value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkFence
    {
        public static readonly VkFence Null = (VkFence)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkFence(void* ptr)
        {
            VkFence value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkFence left, VkFence right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkFence left, VkFence right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkFence obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkFence vkFence && Equals(in vkFence);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkFence value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDeviceMemory
    {
        public static readonly VkDeviceMemory Null = (VkDeviceMemory)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDeviceMemory(void* ptr)
        {
            VkDeviceMemory value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDeviceMemory obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeviceMemory vkDeviceMemory && Equals(in vkDeviceMemory);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDeviceMemory value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkBufferView
    {
        public static readonly VkBufferView Null = (VkBufferView)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkBufferView(void* ptr)
        {
            VkBufferView value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkBufferView left, VkBufferView right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkBufferView left, VkBufferView right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkBufferView obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkBufferView vkBufferView && Equals(in vkBufferView);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkBufferView value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkImageView
    {
        public static readonly VkImageView Null = (VkImageView)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkImageView(void* ptr)
        {
            VkImageView value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkImageView left, VkImageView right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkImageView left, VkImageView right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkImageView obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkImageView vkImageView && Equals(in vkImageView);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkImageView value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkShaderModule
    {
        public static readonly VkShaderModule Null = (VkShaderModule)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkShaderModule(void* ptr)
        {
            VkShaderModule value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkShaderModule left, VkShaderModule right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkShaderModule left, VkShaderModule right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkShaderModule obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkShaderModule vkShaderModule && Equals(in vkShaderModule);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkShaderModule value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkPipelineLayout
    {
        public static readonly VkPipelineLayout Null = (VkPipelineLayout)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPipelineLayout(void* ptr)
        {
            VkPipelineLayout value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPipelineLayout obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPipelineLayout vkPipelineLayout && Equals(in vkPipelineLayout);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipelineLayout value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkPipeline
    {
        public static readonly VkPipeline Null = (VkPipeline)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkPipeline(void* ptr)
        {
            VkPipeline value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkPipeline left, VkPipeline right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPipeline left, VkPipeline right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPipeline obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPipeline vkPipeline && Equals(in vkPipeline);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipeline value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkRenderPass
    {
        public static readonly VkRenderPass Null = (VkRenderPass)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkRenderPass(void* ptr)
        {
            VkRenderPass value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkRenderPass left, VkRenderPass right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkRenderPass left, VkRenderPass right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkRenderPass obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkRenderPass vkRenderPass && Equals(in vkRenderPass);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkRenderPass value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDescriptorSetLayout
    {
        public static readonly VkDescriptorSetLayout Null = (VkDescriptorSetLayout)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDescriptorSetLayout(void* ptr)
        {
            VkDescriptorSetLayout value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDescriptorSetLayout obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorSetLayout vkDescriptorSetLayout && Equals(in vkDescriptorSetLayout);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorSetLayout value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkSampler
    {
        public static readonly VkSampler Null = (VkSampler)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSampler(void* ptr)
        {
            VkSampler value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSampler left, VkSampler right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSampler left, VkSampler right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSampler obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSampler vkSampler && Equals(in vkSampler);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSampler value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDescriptorSet
    {
        public static readonly VkDescriptorSet Null = (VkDescriptorSet)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDescriptorSet(void* ptr)
        {
            VkDescriptorSet value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDescriptorSet obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorSet vkDescriptorSet && Equals(in vkDescriptorSet);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorSet value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDescriptorPool
    {
        public static readonly VkDescriptorPool Null = (VkDescriptorPool)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDescriptorPool(void* ptr)
        {
            VkDescriptorPool value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDescriptorPool obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorPool vkDescriptorPool && Equals(in vkDescriptorPool);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorPool value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkFramebuffer
    {
        public static readonly VkFramebuffer Null = (VkFramebuffer)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkFramebuffer(void* ptr)
        {
            VkFramebuffer value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkFramebuffer left, VkFramebuffer right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkFramebuffer left, VkFramebuffer right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkFramebuffer obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkFramebuffer vkFramebuffer && Equals(in vkFramebuffer);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkFramebuffer value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkCommandPool
    {
        public static readonly VkCommandPool Null = (VkCommandPool)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCommandPool(void* ptr)
        {
            VkCommandPool value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCommandPool left, VkCommandPool right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCommandPool left, VkCommandPool right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCommandPool obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCommandPool vkCommandPool && Equals(in vkCommandPool);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCommandPool value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkSamplerYcbcrConversion
    {
        public static readonly VkSamplerYcbcrConversion Null = (VkSamplerYcbcrConversion)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSamplerYcbcrConversion(void* ptr)
        {
            VkSamplerYcbcrConversion value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSamplerYcbcrConversion obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSamplerYcbcrConversion vkSamplerYcbcrConversion && Equals(in vkSamplerYcbcrConversion);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSamplerYcbcrConversion value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkSurfaceKHR
    {
        public static readonly VkSurfaceKHR Null = (VkSurfaceKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSurfaceKHR(void* ptr)
        {
            VkSurfaceKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSurfaceKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSurfaceKHR vkSurfaceKHR && Equals(in vkSurfaceKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSurfaceKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkSwapchainKHR
    {
        public static readonly VkSwapchainKHR Null = (VkSwapchainKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkSwapchainKHR(void* ptr)
        {
            VkSwapchainKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkSwapchainKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkSwapchainKHR vkSwapchainKHR && Equals(in vkSwapchainKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSwapchainKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDisplayKHR
    {
        public static readonly VkDisplayKHR Null = (VkDisplayKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDisplayKHR(void* ptr)
        {
            VkDisplayKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDisplayKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDisplayKHR vkDisplayKHR && Equals(in vkDisplayKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDisplayKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDisplayModeKHR
    {
        public static readonly VkDisplayModeKHR Null = (VkDisplayModeKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkDisplayModeKHR(void* ptr)
        {
            VkDisplayModeKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDisplayModeKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDisplayModeKHR vkDisplayModeKHR && Equals(in vkDisplayModeKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDisplayModeKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkAccelerationStructureNV
    {
        public static readonly VkAccelerationStructureNV Null = (VkAccelerationStructureNV)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkAccelerationStructureNV(void* ptr)
        {
            VkAccelerationStructureNV value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkAccelerationStructureNV obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkAccelerationStructureNV vkAccelerationStructureNV && Equals(in vkAccelerationStructureNV);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkAccelerationStructureNV value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkIndirectCommandsLayoutNV
    {
        public static readonly VkIndirectCommandsLayoutNV Null = (VkIndirectCommandsLayoutNV)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkIndirectCommandsLayoutNV(void* ptr)
        {
            VkIndirectCommandsLayoutNV value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkIndirectCommandsLayoutNV obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkIndirectCommandsLayoutNV vkIndirectCommandsLayoutNV && Equals(in vkIndirectCommandsLayoutNV);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkIndirectCommandsLayoutNV value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkAccelerationStructureKHR
    {
        public static readonly VkAccelerationStructureKHR Null = (VkAccelerationStructureKHR)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkAccelerationStructureKHR(void* ptr)
        {
            VkAccelerationStructureKHR value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkAccelerationStructureKHR obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkAccelerationStructureKHR vkAccelerationStructureKHR && Equals(in vkAccelerationStructureKHR);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkAccelerationStructureKHR value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkCuModuleNVX
    {
        public static readonly VkCuModuleNVX Null = (VkCuModuleNVX)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCuModuleNVX(void* ptr)
        {
            VkCuModuleNVX value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCuModuleNVX obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCuModuleNVX vkCuModuleNVX && Equals(in vkCuModuleNVX);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCuModuleNVX value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkCuFunctionNVX
    {
        public static readonly VkCuFunctionNVX Null = (VkCuFunctionNVX)null;
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        public static explicit operator VkCuFunctionNVX(void* ptr)
        {
            VkCuFunctionNVX value;
            *(void**)&value = ptr;
            return value;
        }

        public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkCuFunctionNVX obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkCuFunctionNVX vkCuFunctionNVX && Equals(in vkCuFunctionNVX);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCuFunctionNVX value)
        {
            return value._ptr;
        }
    }
}