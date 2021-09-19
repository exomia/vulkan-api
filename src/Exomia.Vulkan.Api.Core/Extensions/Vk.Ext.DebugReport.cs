#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtDebugReport
    {
        public const int    VK_EXT_DEBUG_REPORT                = 1;
        public const int    VK_EXT_DEBUG_REPORT_SPEC_VERSION   = 10;
        public const string VK_EXT_DEBUG_REPORT_EXTENSION_NAME = "VK_EXT_debug_report";
        
        public static delegate*<
            VkInstance,                          /* instance */
            VkDebugReportCallbackCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,              /* pAllocator */
            VkDebugReportCallbackEXT*,           /* pCallback */
            VkResult> vkCreateDebugReportCallbackEXT;
        
        public static delegate*<
            VkInstance,               /* instance */
            VkDebugReportCallbackEXT, /* callback */
            VkAllocationCallbacks*,   /* pAllocator */
            void> vkDestroyDebugReportCallbackEXT;
        
        public static delegate*<
            VkInstance,                 /* instance */
            VkDebugReportFlagsEXT,      /* FlagBits */
            VkDebugReportObjectTypeEXT, /* objectType */
            ulong,                      /* @object */
            nuint,                      /* location */
            int,                        /* messageCode */
            byte*,                      /* pLayerPrefix */
            byte*,                      /* pMessage */
            void> vkDebugReportMessageEXT;

        public static partial void Load(VkInstance vkInstance);
    }
}
