#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{ 
    [VkExtGenerator]
    public static unsafe partial class VkExtDebugUtils
    { 
        public const int VK_EXT_DEBUG_UTILS = 1;
        public const int VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;
        public const string VK_EXT_DEBUG_UTILS_EXTENSION_NAME = "VK_EXT_debug_utils";
        
        public static delegate*<
            VkDevice,                       /* device */
            VkDebugUtilsObjectNameInfoEXT*, /* pNameInfo */
            VkResult> vkSetDebugUtilsObjectNameEXT;

        public static delegate*<
            VkDevice,                      /* device */
            VkDebugUtilsObjectTagInfoEXT*, /* pTagInfo */
            VkResult> vkSetDebugUtilsObjectTagEXT;

        public static delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkQueueBeginDebugUtilsLabelEXT;

        public static delegate*<
            VkQueue, /* queue */
            void> vkQueueEndDebugUtilsLabelEXT;

        public static delegate*<
            VkQueue,               /* queue */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkQueueInsertDebugUtilsLabelEXT;

        public static delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkCmdBeginDebugUtilsLabelEXT;

        public static delegate*<
            VkCommandBuffer, /* commandBuffer */
            void> vkCmdEndDebugUtilsLabelEXT;

        public static delegate*<
            VkCommandBuffer,       /* commandBuffer */
            VkDebugUtilsLabelEXT*, /* pLabelInfo */
            void> vkCmdInsertDebugUtilsLabelEXT;

        public static delegate*<
            VkInstance,                          /* instance */
            VkDebugUtilsMessengerCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugUtilsMessengerEXT*,           /* pMessenger */
            VkResult> vkCreateDebugUtilsMessengerEXT;

        public static delegate*<
            VkInstance,               /* instance */
            VkDebugUtilsMessengerEXT, /* messenger */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroyDebugUtilsMessengerEXT;

        public static delegate*<
            VkInstance,                            /* instance */
            VkDebugUtilsMessageSeverityFlagsEXT,   /* messageSeverity */
            VkDebugUtilsMessageTypeFlagsEXT,       /* messageTypes */
            VkDebugUtilsMessengerCallbackDataEXT*, /* pCallbackData */
            void> vkSubmitDebugUtilsMessageEXT;
        
        public static partial void Load(VkInstance vkInstance);
    }
}
