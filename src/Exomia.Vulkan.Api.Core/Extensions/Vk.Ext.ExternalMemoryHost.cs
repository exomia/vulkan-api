#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtExternalMemoryHost
    {
        public const int    VK_EXT_EXTERNAL_MEMORY_HOST                = 1;
        public const int    VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION   = 1;
        public const string VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME = "VK_EXT_external_memory_host";
        
        public static delegate*<
            VkDevice,                           /* device */
            VkExternalMemoryHandleTypeFlagBits, /* handleType */
            void*,                              /* pHostPointer */
            VkMemoryHostPointerPropertiesEXT*,  /* pMemoryHostPointerProperties */
            VkResult> vkGetMemoryHostPointerPropertiesEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
