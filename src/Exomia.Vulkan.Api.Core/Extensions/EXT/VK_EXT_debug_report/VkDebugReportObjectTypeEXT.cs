#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkDebugReportObjectTypeEXT - Specify the type of an object handle -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportObjectTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDebugReportObjectTypeEXT.html</a>
/// </summary>
public enum VkDebugReportObjectTypeEXT
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>Unknown/Undefined Handle</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkInstance</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkPhysicalDevice</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDevice</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkQueue</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkSemaphore</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkCommandBuffer</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkFence</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDeviceMemory</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkBuffer</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkImage</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = 10,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkEvent</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = 11,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkQueryPool</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = 12,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkBufferView</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = 13,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkImageView</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = 14,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkShaderModule</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = 15,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkPipelineCache</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = 16,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkPipelineLayout</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = 17,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkRenderPass</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = 18,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkPipeline</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = 19,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDescriptorSetLayout</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = 20,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkSampler</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = 21,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDescriptorPool</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = 22,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDescriptorSet</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = 23,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkFramebuffer</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = 24,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkCommandPool</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = 25,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkSurfaceKHR</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = 26,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkSwapchainKHR</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = 27,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDebugReportCallbackEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = 28,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDisplayKHR</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = 29,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDisplayModeKHR</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = 30,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = 33,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = 1000156000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDescriptorUpdateTemplate</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = 1000085000,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT = 1000029000,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT = 1000029001,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = 1000150000,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = 1000165000,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_MODULE_NV = 1000307000,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_CUDA_FUNCTION_NV = 1000307001,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT = 1000366000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDebugReportCallbackEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Vulkan Handle Type</term><description>VkDescriptorUpdateTemplate</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT,

    /// <summary>
    ///     VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkDebugReportObjectTypeEXT</a>
    /// </summary>
    VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR_EXT = VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT
}