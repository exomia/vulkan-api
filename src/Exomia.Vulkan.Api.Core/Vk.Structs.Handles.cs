#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
using System;

namespace Exomia.Vulkan.Api.Core
{
    public readonly unsafe struct VkDeviceAddress
    {
#pragma warning disable 649
        private readonly ulong _address;
#pragma warning restore 649

        public static explicit operator VkDeviceAddress(ulong address)
        {
            VkDeviceAddress value;
            *(ulong*)&value = address;
            return value;
        }

        public static bool operator ==(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address == right._address;
        }

        public static bool operator !=(VkDeviceAddress left, VkDeviceAddress right)
        {
            return left._address != right._address;
        }

        public readonly bool Equals(in VkDeviceAddress obj)
        {
            return obj._address == _address;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDeviceAddress vkDeviceAddress && this.Equals(in vkDeviceAddress);
        }

        public readonly override int GetHashCode()
        {
            return _address.GetHashCode();
        }

        public static explicit operator ulong(VkDeviceAddress value)
        {
            return value._address;
        }

        public override string ToString()
        {
            return _address.ToString();
        }
    }

    public readonly unsafe struct VkDeviceSize
    {
#pragma warning disable 649
        private readonly ulong _size;
#pragma warning restore 649

        public static explicit operator VkDeviceSize(ulong size)
        {
            VkDeviceSize value;
            *(ulong*)&value = size;
            return value;
        }

        public static bool operator ==(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size == right._size;
        }

        public static bool operator !=(VkDeviceSize left, VkDeviceSize right)
        {
            return left._size != right._size;
        }

        public readonly bool Equals(in VkDeviceSize obj)
        {
            return obj._size == _size;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDeviceSize vkDeviceSize && this.Equals(in vkDeviceSize);
        }

        public readonly override int GetHashCode()
        {
            return _size.GetHashCode();
        }

        public static explicit operator ulong(VkDeviceSize value)
        {
            return value._size;
        }

        public override string ToString()
        {
            return _size.ToString();
        }
    }

    public unsafe struct VkDevice
    {
        public static readonly VkDevice Zero = new VkDevice();
                private                void*    _ptr;

        public static explicit operator VkDevice(void* ptr)
        {
            VkDevice value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDevice obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDevice vkDevice && this.Equals(in vkDevice);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDevice value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDebugReportCallbackEXT
    {
        public static readonly VkDebugReportCallbackEXT Zero = new VkDebugReportCallbackEXT();
                private                void*                    _ptr;

        public static explicit operator VkDebugReportCallbackEXT(void* ptr)
        {
            VkDebugReportCallbackEXT value;
            value._ptr = ptr;
            return value;
        }

        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr != right._ptr;
        }

        public readonly bool Equals(in VkDebugReportCallbackEXT obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDebugReportCallbackEXT vkDebugReportCallbackEXT && this.Equals(in vkDebugReportCallbackEXT);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugReportCallbackEXT value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDebugUtilsMessengerEXT
    {
        public static readonly VkDebugUtilsMessengerEXT Zero = new VkDebugUtilsMessengerEXT();
                private                void*                    _ptr;

        public static explicit operator VkDebugUtilsMessengerEXT(void* ptr)
        {
            VkDebugUtilsMessengerEXT value;
            value._ptr = ptr;
            return value;
        }

        public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
        {
            return left._ptr != right._ptr;
        }

        public readonly bool Equals(in VkDebugUtilsMessengerEXT obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDebugUtilsMessengerEXT vkDebugUtilsMessengerEXT && this.Equals(in vkDebugUtilsMessengerEXT);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugUtilsMessengerEXT value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDeferredOperationKHR
    {
        public static readonly VkDeferredOperationKHR Zero = new VkDeferredOperationKHR();
                private                void*                  _ptr;

        public static explicit operator VkDeferredOperationKHR(void* ptr)
        {
            VkDeferredOperationKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDeferredOperationKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDeferredOperationKHR vkDeferredOperationKHR && this.Equals(in vkDeferredOperationKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDeferredOperationKHR value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPerformanceConfigurationINTEL
    {
        public static readonly VkPerformanceConfigurationINTEL Zero = new VkPerformanceConfigurationINTEL();
                private                void*                           _ptr;

        public static explicit operator VkPerformanceConfigurationINTEL(void* ptr)
        {
            VkPerformanceConfigurationINTEL value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkPerformanceConfigurationINTEL obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPerformanceConfigurationINTEL vkPerformanceConfigurationINTEL && this.Equals(in vkPerformanceConfigurationINTEL);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPerformanceConfigurationINTEL value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDescriptorUpdateTemplate
    {
        public static readonly VkDescriptorUpdateTemplate Zero = new VkDescriptorUpdateTemplate();
                private                void*                      _ptr;

        public static explicit operator VkDescriptorUpdateTemplate(void* ptr)
        {
            VkDescriptorUpdateTemplate value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDescriptorUpdateTemplate obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDescriptorUpdateTemplate vkDescriptorUpdateTemplate && this.Equals(in vkDescriptorUpdateTemplate);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorUpdateTemplate value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPrivateDataSlotEXT
    {
        public static readonly VkPrivateDataSlotEXT Zero = new VkPrivateDataSlotEXT();
                private                void*                _ptr;

        public static explicit operator VkPrivateDataSlotEXT(void* ptr)
        {
            VkPrivateDataSlotEXT value;
            value._ptr = ptr;
            return value;
        }

        public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr != right._ptr;
        }

        public readonly bool Equals(in VkPrivateDataSlotEXT obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPrivateDataSlotEXT vkPrivateDataSlotEXT && this.Equals(in vkPrivateDataSlotEXT);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPrivateDataSlotEXT value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkInstance
    {
        public static readonly VkInstance Zero = new VkInstance();
                private                void*      _ptr;

        public static explicit operator VkInstance(void* ptr)
        {
            VkInstance value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkInstance obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkInstance vkInstance && this.Equals(in vkInstance);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkInstance value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkEvent
    {
        public static readonly VkEvent Zero = new VkEvent();
                private                void*   _ptr;

        public static explicit operator VkEvent(void* ptr)
        {
            VkEvent value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkEvent obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkEvent vkEvent && this.Equals(in vkEvent);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkEvent value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkQueue
    {
        public static readonly VkQueue Zero = new VkQueue();
                private                void*   _ptr;

        public static explicit operator VkQueue(void* ptr)
        {
            VkQueue value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkQueue obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkQueue vkQueue && this.Equals(in vkQueue);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkQueue value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkQueryPool
    {
        public static readonly VkQueryPool Zero = new VkQueryPool();
                private                void*       _ptr;

        public static explicit operator VkQueryPool(void* ptr)
        {
            VkQueryPool value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkQueryPool obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkQueryPool vkQueryPool && this.Equals(in vkQueryPool);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkQueryPool value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPipelineCache
    {
        public static readonly VkPipelineCache Zero = new VkPipelineCache();
                private                void*           _ptr;

        public static explicit operator VkPipelineCache(void* ptr)
        {
            VkPipelineCache value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkPipelineCache obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPipelineCache vkPipelineCache && this.Equals(in vkPipelineCache);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipelineCache value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPhysicalDevice
    {
        public static readonly VkPhysicalDevice Zero = new VkPhysicalDevice();
                private                void*            _ptr;

        public static explicit operator VkPhysicalDevice(void* ptr)
        {
            VkPhysicalDevice value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkPhysicalDevice obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPhysicalDevice vkPhysicalDevice && this.Equals(in vkPhysicalDevice);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPhysicalDevice value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkBuffer
    {
        public static readonly VkBuffer Zero = new VkBuffer();
                private                void*    _ptr;

        public static explicit operator VkBuffer(void* ptr)
        {
            VkBuffer value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkBuffer obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkBuffer vkBuffer && this.Equals(in vkBuffer);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkBuffer value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkCommandBuffer
    {
        public static readonly VkCommandBuffer Zero = new VkCommandBuffer();
                private                void*           _ptr;

        public static explicit operator VkCommandBuffer(void* ptr)
        {
            VkCommandBuffer value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkCommandBuffer obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkCommandBuffer vkCommandBuffer && this.Equals(in vkCommandBuffer);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCommandBuffer value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkImage
    {
        public static readonly VkImage Zero = new VkImage();
                private                void*   _ptr;

        public static explicit operator VkImage(void* ptr)
        {
            VkImage value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkImage obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkImage vkImage && this.Equals(in vkImage);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkImage value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkSemaphore
    {
        public static readonly VkSemaphore Zero = new VkSemaphore();
                private                void*       _ptr;

        public static explicit operator VkSemaphore(void* ptr)
        {
            VkSemaphore value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkSemaphore obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkSemaphore vkSemaphore && this.Equals(in vkSemaphore);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSemaphore value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkFence
    {
        public static readonly VkFence Zero = new VkFence();
                private                void*   _ptr;

        public static explicit operator VkFence(void* ptr)
        {
            VkFence value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkFence obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkFence vkFence && this.Equals(in vkFence);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkFence value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDeviceMemory
    {
        public static readonly VkDeviceMemory Zero = new VkDeviceMemory();
                private                void*          _ptr;

        public static explicit operator VkDeviceMemory(void* ptr)
        {
            VkDeviceMemory value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDeviceMemory obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDeviceMemory vkDeviceMemory && this.Equals(in vkDeviceMemory);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDeviceMemory value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkBufferView
    {
        public static readonly VkBufferView Zero = new VkBufferView();
                private                void*        _ptr;

        public static explicit operator VkBufferView(void* ptr)
        {
            VkBufferView value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkBufferView obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkBufferView vkBufferView && this.Equals(in vkBufferView);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkBufferView value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkImageView
    {
        public static readonly VkImageView Zero = new VkImageView();
                private                void*       _ptr;

        public static explicit operator VkImageView(void* ptr)
        {
            VkImageView value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkImageView obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkImageView vkImageView && this.Equals(in vkImageView);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkImageView value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkShaderModule
    {
        public static readonly VkShaderModule Zero = new VkShaderModule();
                private                void*          _ptr;

        public static explicit operator VkShaderModule(void* ptr)
        {
            VkShaderModule value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkShaderModule obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkShaderModule vkShaderModule && this.Equals(in vkShaderModule);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkShaderModule value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPipelineLayout
    {
        public static readonly VkPipelineLayout Zero = new VkPipelineLayout();
                private                void*            _ptr;

        public static explicit operator VkPipelineLayout(void* ptr)
        {
            VkPipelineLayout value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkPipelineLayout obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPipelineLayout vkPipelineLayout && this.Equals(in vkPipelineLayout);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipelineLayout value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkPipeline
    {
        public static readonly VkPipeline Zero = new VkPipeline();
                private                void*      _ptr;

        public static explicit operator VkPipeline(void* ptr)
        {
            VkPipeline value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkPipeline obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkPipeline vkPipeline && this.Equals(in vkPipeline);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPipeline value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkRenderPass
    {
        public static readonly VkRenderPass Zero = new VkRenderPass();
                private                void*        _ptr;

        public static explicit operator VkRenderPass(void* ptr)
        {
            VkRenderPass value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkRenderPass obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkRenderPass vkRenderPass && this.Equals(in vkRenderPass);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkRenderPass value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDescriptorSetLayout
    {
        public static readonly VkDescriptorSetLayout Zero = new VkDescriptorSetLayout();
                private                void*                 _ptr;

        public static explicit operator VkDescriptorSetLayout(void* ptr)
        {
            VkDescriptorSetLayout value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDescriptorSetLayout obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDescriptorSetLayout vkDescriptorSetLayout && this.Equals(in vkDescriptorSetLayout);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorSetLayout value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkSampler
    {
        public static readonly VkSampler Zero = new VkSampler();
                private                void*     _ptr;

        public static explicit operator VkSampler(void* ptr)
        {
            VkSampler value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkSampler obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkSampler vkSampler && this.Equals(in vkSampler);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSampler value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDescriptorSet
    {
        public static readonly VkDescriptorSet Zero = new VkDescriptorSet();
                private                void*           _ptr;

        public static explicit operator VkDescriptorSet(void* ptr)
        {
            VkDescriptorSet value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDescriptorSet obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDescriptorSet vkDescriptorSet && this.Equals(in vkDescriptorSet);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorSet value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDescriptorPool
    {
        public static readonly VkDescriptorPool Zero = new VkDescriptorPool();
                private                void*            _ptr;

        public static explicit operator VkDescriptorPool(void* ptr)
        {
            VkDescriptorPool value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDescriptorPool obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDescriptorPool vkDescriptorPool && this.Equals(in vkDescriptorPool);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDescriptorPool value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkFramebuffer
    {
        public static readonly VkFramebuffer Zero = new VkFramebuffer();
                private                void*         _ptr;

        public static explicit operator VkFramebuffer(void* ptr)
        {
            VkFramebuffer value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkFramebuffer obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkFramebuffer vkFramebuffer && this.Equals(in vkFramebuffer);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkFramebuffer value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkCommandPool
    {
        public static readonly VkCommandPool Zero = new VkCommandPool();
                private                void*         _ptr;

        public static explicit operator VkCommandPool(void* ptr)
        {
            VkCommandPool value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkCommandPool obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkCommandPool vkCommandPool && this.Equals(in vkCommandPool);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkCommandPool value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkSamplerYcbcrConversion
    {
        public static readonly VkSamplerYcbcrConversion Zero = new VkSamplerYcbcrConversion();
                private                void*                    _ptr;

        public static explicit operator VkSamplerYcbcrConversion(void* ptr)
        {
            VkSamplerYcbcrConversion value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkSamplerYcbcrConversion obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkSamplerYcbcrConversion vkSamplerYcbcrConversion && this.Equals(in vkSamplerYcbcrConversion);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSamplerYcbcrConversion value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkSurfaceKHR
    {
        public static readonly VkSurfaceKHR Zero = new VkSurfaceKHR();
                private                void*        _ptr;

        public static explicit operator VkSurfaceKHR(void* ptr)
        {
            VkSurfaceKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkSurfaceKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkSurfaceKHR vkSurfaceKHR && this.Equals(in vkSurfaceKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSurfaceKHR value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkSwapchainKHR
    {
        public static readonly VkSwapchainKHR Zero = new VkSwapchainKHR();
                private                void*          _ptr;

        public static explicit operator VkSwapchainKHR(void* ptr)
        {
            VkSwapchainKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkSwapchainKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkSwapchainKHR vkSwapchainKHR && this.Equals(in vkSwapchainKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkSwapchainKHR value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDisplayKHR
    {
        public static readonly VkDisplayKHR Zero = new VkDisplayKHR();
                private                void*        _ptr;

        public static explicit operator VkDisplayKHR(void* ptr)
        {
            VkDisplayKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDisplayKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDisplayKHR vkDisplayKHR && this.Equals(in vkDisplayKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDisplayKHR value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkDisplayModeKHR
    {
        public static readonly VkDisplayModeKHR Zero = new VkDisplayModeKHR();
                private                void*            _ptr;

        public static explicit operator VkDisplayModeKHR(void* ptr)
        {
            VkDisplayModeKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkDisplayModeKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkDisplayModeKHR vkDisplayModeKHR && this.Equals(in vkDisplayModeKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDisplayModeKHR value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkValidationCacheEXT
    {
        public static readonly VkValidationCacheEXT Zero = new VkValidationCacheEXT();
                private                void*                _ptr;

        public static explicit operator VkValidationCacheEXT(void* ptr)
        {
            VkValidationCacheEXT value;
            value._ptr = ptr;
            return value;
        }

        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr != right._ptr;
        }

        public readonly bool Equals(in VkValidationCacheEXT obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkValidationCacheEXT vkValidationCacheEXT && this.Equals(in vkValidationCacheEXT);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkValidationCacheEXT value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkAccelerationStructureNV
    {
        public static readonly VkAccelerationStructureNV Zero = new VkAccelerationStructureNV();
                private                void*                     _ptr;

        public static explicit operator VkAccelerationStructureNV(void* ptr)
        {
            VkAccelerationStructureNV value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkAccelerationStructureNV obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkAccelerationStructureNV vkAccelerationStructureNV && this.Equals(in vkAccelerationStructureNV);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkAccelerationStructureNV value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkIndirectCommandsLayoutNV
    {
        public static readonly VkIndirectCommandsLayoutNV Zero = new VkIndirectCommandsLayoutNV();
                private                void*                      _ptr;

        public static explicit operator VkIndirectCommandsLayoutNV(void* ptr)
        {
            VkIndirectCommandsLayoutNV value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkIndirectCommandsLayoutNV obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkIndirectCommandsLayoutNV vkIndirectCommandsLayoutNV && this.Equals(in vkIndirectCommandsLayoutNV);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkIndirectCommandsLayoutNV value)
        {
            return value._ptr;
        }
    }

    public unsafe struct VkAccelerationStructureKHR
    {
        public static readonly VkAccelerationStructureKHR Zero = new VkAccelerationStructureKHR();
                private                void*                      _ptr;

        public static explicit operator VkAccelerationStructureKHR(void* ptr)
        {
            VkAccelerationStructureKHR value;
            value._ptr = ptr;
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

        public readonly bool Equals(in VkAccelerationStructureKHR obj)
        {
             return obj._ptr == _ptr;
        }

        public readonly override bool Equals(object? obj)
        {
            return obj is VkAccelerationStructureKHR vkAccelerationStructureKHR && this.Equals(in vkAccelerationStructureKHR);
        }

        public readonly override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkAccelerationStructureKHR value)
        {
            return value._ptr;
        }
    }
}