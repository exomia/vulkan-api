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

        public bool Equals(in VkDeviceAddress obj)
        {
            return obj._address == _address;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeviceAddress vkDeviceAddress && Equals(in vkDeviceAddress);
        }

        public override int GetHashCode()
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

        public bool Equals(in VkDeviceSize obj)
        {
            return obj._size == _size;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDeviceSize vkDeviceSize && Equals(in vkDeviceSize);
        }

        public override int GetHashCode()
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

    public readonly unsafe struct VkDevice
    {
        public static readonly VkDevice Zero = new VkDevice();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDevice(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDevice(void* ptr)
        {
            return new VkDevice(ptr);
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

    public readonly unsafe struct VkDebugReportCallbackEXT
    {
        public static readonly VkDebugReportCallbackEXT Zero = new VkDebugReportCallbackEXT();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDebugReportCallbackEXT(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDebugReportCallbackEXT(void* ptr)
        {
            return new VkDebugReportCallbackEXT(ptr);
        }

        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDebugReportCallbackEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDebugReportCallbackEXT vkDebugReportCallbackEXT && Equals(in vkDebugReportCallbackEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugReportCallbackEXT value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDebugUtilsMessengerEXT
    {
        public static readonly VkDebugUtilsMessengerEXT Zero = new VkDebugUtilsMessengerEXT();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDebugUtilsMessengerEXT(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDebugUtilsMessengerEXT(void* ptr)
        {
            return new VkDebugUtilsMessengerEXT(ptr);
        }

        public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkDebugUtilsMessengerEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkDebugUtilsMessengerEXT vkDebugUtilsMessengerEXT && Equals(in vkDebugUtilsMessengerEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkDebugUtilsMessengerEXT value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkDeferredOperationKHR
    {
        public static readonly VkDeferredOperationKHR Zero = new VkDeferredOperationKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDeferredOperationKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDeferredOperationKHR(void* ptr)
        {
            return new VkDeferredOperationKHR(ptr);
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
        public static readonly VkPerformanceConfigurationINTEL Zero = new VkPerformanceConfigurationINTEL();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPerformanceConfigurationINTEL(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPerformanceConfigurationINTEL(void* ptr)
        {
            return new VkPerformanceConfigurationINTEL(ptr);
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
        public static readonly VkDescriptorUpdateTemplate Zero = new VkDescriptorUpdateTemplate();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDescriptorUpdateTemplate(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDescriptorUpdateTemplate(void* ptr)
        {
            return new VkDescriptorUpdateTemplate(ptr);
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

    public readonly unsafe struct VkPrivateDataSlotEXT
    {
        public static readonly VkPrivateDataSlotEXT Zero = new VkPrivateDataSlotEXT();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPrivateDataSlotEXT(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPrivateDataSlotEXT(void* ptr)
        {
            return new VkPrivateDataSlotEXT(ptr);
        }

        public static bool operator ==(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkPrivateDataSlotEXT left, VkPrivateDataSlotEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkPrivateDataSlotEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkPrivateDataSlotEXT vkPrivateDataSlotEXT && Equals(in vkPrivateDataSlotEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkPrivateDataSlotEXT value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkInstance
    {
        public static readonly VkInstance Zero = new VkInstance();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkInstance(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkInstance(void* ptr)
        {
            return new VkInstance(ptr);
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
        public static readonly VkEvent Zero = new VkEvent();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkEvent(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkEvent(void* ptr)
        {
            return new VkEvent(ptr);
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
        public static readonly VkQueue Zero = new VkQueue();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkQueue(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkQueue(void* ptr)
        {
            return new VkQueue(ptr);
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
        public static readonly VkQueryPool Zero = new VkQueryPool();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkQueryPool(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkQueryPool(void* ptr)
        {
            return new VkQueryPool(ptr);
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
        public static readonly VkPipelineCache Zero = new VkPipelineCache();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPipelineCache(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPipelineCache(void* ptr)
        {
            return new VkPipelineCache(ptr);
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
        public static readonly VkPhysicalDevice Zero = new VkPhysicalDevice();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPhysicalDevice(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPhysicalDevice(void* ptr)
        {
            return new VkPhysicalDevice(ptr);
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
        public static readonly VkBuffer Zero = new VkBuffer();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkBuffer(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkBuffer(void* ptr)
        {
            return new VkBuffer(ptr);
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
        public static readonly VkCommandBuffer Zero = new VkCommandBuffer();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkCommandBuffer(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkCommandBuffer(void* ptr)
        {
            return new VkCommandBuffer(ptr);
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
        public static readonly VkImage Zero = new VkImage();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkImage(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkImage(void* ptr)
        {
            return new VkImage(ptr);
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
        public static readonly VkSemaphore Zero = new VkSemaphore();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkSemaphore(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkSemaphore(void* ptr)
        {
            return new VkSemaphore(ptr);
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
        public static readonly VkFence Zero = new VkFence();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkFence(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkFence(void* ptr)
        {
            return new VkFence(ptr);
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
        public static readonly VkDeviceMemory Zero = new VkDeviceMemory();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDeviceMemory(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDeviceMemory(void* ptr)
        {
            return new VkDeviceMemory(ptr);
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
        public static readonly VkBufferView Zero = new VkBufferView();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkBufferView(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkBufferView(void* ptr)
        {
            return new VkBufferView(ptr);
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
        public static readonly VkImageView Zero = new VkImageView();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkImageView(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkImageView(void* ptr)
        {
            return new VkImageView(ptr);
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
        public static readonly VkShaderModule Zero = new VkShaderModule();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkShaderModule(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkShaderModule(void* ptr)
        {
            return new VkShaderModule(ptr);
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
        public static readonly VkPipelineLayout Zero = new VkPipelineLayout();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPipelineLayout(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPipelineLayout(void* ptr)
        {
            return new VkPipelineLayout(ptr);
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
        public static readonly VkPipeline Zero = new VkPipeline();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkPipeline(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkPipeline(void* ptr)
        {
            return new VkPipeline(ptr);
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
        public static readonly VkRenderPass Zero = new VkRenderPass();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkRenderPass(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkRenderPass(void* ptr)
        {
            return new VkRenderPass(ptr);
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
        public static readonly VkDescriptorSetLayout Zero = new VkDescriptorSetLayout();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDescriptorSetLayout(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDescriptorSetLayout(void* ptr)
        {
            return new VkDescriptorSetLayout(ptr);
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
        public static readonly VkSampler Zero = new VkSampler();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkSampler(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkSampler(void* ptr)
        {
            return new VkSampler(ptr);
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
        public static readonly VkDescriptorSet Zero = new VkDescriptorSet();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDescriptorSet(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDescriptorSet(void* ptr)
        {
            return new VkDescriptorSet(ptr);
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
        public static readonly VkDescriptorPool Zero = new VkDescriptorPool();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDescriptorPool(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDescriptorPool(void* ptr)
        {
            return new VkDescriptorPool(ptr);
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
        public static readonly VkFramebuffer Zero = new VkFramebuffer();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkFramebuffer(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkFramebuffer(void* ptr)
        {
            return new VkFramebuffer(ptr);
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
        public static readonly VkCommandPool Zero = new VkCommandPool();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkCommandPool(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkCommandPool(void* ptr)
        {
            return new VkCommandPool(ptr);
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
        public static readonly VkSamplerYcbcrConversion Zero = new VkSamplerYcbcrConversion();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkSamplerYcbcrConversion(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkSamplerYcbcrConversion(void* ptr)
        {
            return new VkSamplerYcbcrConversion(ptr);
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
        public static readonly VkSurfaceKHR Zero = new VkSurfaceKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkSurfaceKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkSurfaceKHR(void* ptr)
        {
            return new VkSurfaceKHR(ptr);
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
        public static readonly VkSwapchainKHR Zero = new VkSwapchainKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkSwapchainKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkSwapchainKHR(void* ptr)
        {
            return new VkSwapchainKHR(ptr);
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
        public static readonly VkDisplayKHR Zero = new VkDisplayKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDisplayKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDisplayKHR(void* ptr)
        {
            return new VkDisplayKHR(ptr);
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
        public static readonly VkDisplayModeKHR Zero = new VkDisplayModeKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkDisplayModeKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkDisplayModeKHR(void* ptr)
        {
            return new VkDisplayModeKHR(ptr);
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

    public readonly unsafe struct VkValidationCacheEXT
    {
        public static readonly VkValidationCacheEXT Zero = new VkValidationCacheEXT();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkValidationCacheEXT(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkValidationCacheEXT(void* ptr)
        {
            return new VkValidationCacheEXT(ptr);
        }

        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr == right._ptr;
        }

        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right)
        {
            return left._ptr != right._ptr;
        }

        public bool Equals(in VkValidationCacheEXT obj)
        {
            return obj._ptr == _ptr;
        }

        public override bool Equals(object? obj)
        {
            return obj is VkValidationCacheEXT vkValidationCacheEXT && Equals(in vkValidationCacheEXT);
        }

        public override int GetHashCode()
        {
            return ((IntPtr)_ptr).GetHashCode();
        }

        public static explicit operator void*(VkValidationCacheEXT value)
        {
            return value._ptr;
        }
    }

    public readonly unsafe struct VkAccelerationStructureNV
    {
        public static readonly VkAccelerationStructureNV Zero = new VkAccelerationStructureNV();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkAccelerationStructureNV(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkAccelerationStructureNV(void* ptr)
        {
            return new VkAccelerationStructureNV(ptr);
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
        public static readonly VkIndirectCommandsLayoutNV Zero = new VkIndirectCommandsLayoutNV();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkIndirectCommandsLayoutNV(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkIndirectCommandsLayoutNV(void* ptr)
        {
            return new VkIndirectCommandsLayoutNV(ptr);
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
        public static readonly VkAccelerationStructureKHR Zero = new VkAccelerationStructureKHR();
#pragma warning disable 649
        private readonly void* _ptr;
#pragma warning restore 649

        private VkAccelerationStructureKHR(void* ptr)
        {
            _ptr = ptr;
        }

        public static explicit operator VkAccelerationStructureKHR(void* ptr)
        {
            return new VkAccelerationStructureKHR(ptr);
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
}