#region License

// Copyright (c) 2018-2022, exomia
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
///     VkObjectType - Specify an enumeration to track object handle types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkObjectType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkObjectType.html </a>
/// </summary>
public enum VkObjectType
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> Unknown/Undefined Handle </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_UNKNOWN = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkInstance </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_INSTANCE = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPhysicalDevice </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PHYSICAL_DEVICE = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDevice </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DEVICE = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkQueue </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_QUEUE = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSemaphore </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SEMAPHORE = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkCommandBuffer </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_COMMAND_BUFFER = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkFence </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_FENCE = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDeviceMemory </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DEVICE_MEMORY = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkBuffer </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_BUFFER = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkImage </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_IMAGE = 10,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkEvent </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_EVENT = 11,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkQueryPool </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_QUERY_POOL = 12,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkBufferView </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_BUFFER_VIEW = 13,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkImageView </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_IMAGE_VIEW = 14,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkShaderModule </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SHADER_MODULE = 15,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPipelineCache </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PIPELINE_CACHE = 16,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPipelineLayout </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PIPELINE_LAYOUT = 17,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkRenderPass </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_RENDER_PASS = 18,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPipeline </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PIPELINE = 19,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDescriptorSetLayout </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = 20,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSampler </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SAMPLER = 21,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDescriptorPool </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DESCRIPTOR_POOL = 22,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDescriptorSet </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DESCRIPTOR_SET = 23,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkFramebuffer </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_FRAMEBUFFER = 24,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkCommandPool </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_COMMAND_POOL = 25,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSamplerYcbcrConversion </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = 1000156000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDescriptorUpdateTemplate </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = 1000085000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPrivateDataSlot </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PRIVATE_DATA_SLOT = 1000295000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSurfaceKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SURFACE_KHR = 1000000000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSwapchainKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SWAPCHAIN_KHR = 1000001000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDisplayKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DISPLAY_KHR = 1000002000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDisplayModeKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DISPLAY_MODE_KHR = 1000002001,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDebugReportCallbackEXT </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = 1000011000,

    /// <summary>
    ///     VK_OBJECT_TYPE_VIDEO_SESSION_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType </a>
    /// </summary>
    VK_OBJECT_TYPE_VIDEO_SESSION_KHR = 1000023000,

    /// <summary>
    ///     VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType </a>
    /// </summary>
    VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR = 1000023001,

    /// <summary>
    ///     VK_OBJECT_TYPE_CU_MODULE_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType </a>
    /// </summary>
    VK_OBJECT_TYPE_CU_MODULE_NVX = 1000029000,

    /// <summary>
    ///     VK_OBJECT_TYPE_CU_FUNCTION_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType </a>
    /// </summary>
    VK_OBJECT_TYPE_CU_FUNCTION_NVX = 1000029001,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDebugUtilsMessengerEXT </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = 1000128000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkAccelerationStructureKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = 1000150000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkValidationCacheEXT </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = 1000160000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkAccelerationStructureNV </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = 1000165000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPerformanceConfigurationINTEL </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = 1000210000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDeferredOperationKHR </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = 1000268000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkIndirectCommandsLayoutNV </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = 1000277000,

    /// <summary>
    ///     VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkObjectType </a>
    /// </summary>
    VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA = 1000366000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkDescriptorUpdateTemplate </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_KHR = VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkSamplerYcbcrConversion </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_KHR = VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Vulkan Handle Type </term><description> VkPrivateDataSlot </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_OBJECT_TYPE_PRIVATE_DATA_SLOT_EXT = VK_OBJECT_TYPE_PRIVATE_DATA_SLOT
}