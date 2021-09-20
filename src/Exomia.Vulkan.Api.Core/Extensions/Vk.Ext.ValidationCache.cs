#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtValidationCache
    {
        public const int    VK_EXT_VALIDATION_CACHE                = 1;
        public const int    VK_EXT_VALIDATION_CACHE_SPEC_VERSION   = 1;
        public const string VK_EXT_VALIDATION_CACHE_EXTENSION_NAME = "VK_EXT_validation_cache";

        public static delegate*<
            VkDevice,                        /* device */
            VkValidationCacheCreateInfoEXT*, /* pCreateInfo */
            VkAllocationCallbacks*,          /* pAllocator */
            VkValidationCacheEXT*,           /* pValidationCache */
            VkResult> vkCreateValidationCacheEXT;
        
        public static delegate*<
            VkDevice,               /* device */
            VkValidationCacheEXT,   /* validationCache */
            VkAllocationCallbacks*, /* pAllocator */
            void> vkDestroyValidationCacheEXT;
        
        public static delegate*<
            VkDevice,              /* device */
            VkValidationCacheEXT,  /* dstCache */
            uint,                  /* srcCacheCount */
            VkValidationCacheEXT*, /* pSrcCaches */
            VkResult> vkMergeValidationCachesEXT;

        public static delegate*<
            VkDevice,             /* device */
            VkValidationCacheEXT, /* validationCache */
            nuint*,               /* pDataSize */
            void*,                /* pData */
            VkResult> vkGetValidationCacheDataEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}