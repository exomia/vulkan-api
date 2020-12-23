#region License

// Copyright (c) 2018-2020, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
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

        public static explicit operator void*(VkAccelerationStructureKHR value)
        {
            return value._ptr;
        }
    }
}