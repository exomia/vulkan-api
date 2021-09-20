#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static unsafe partial class VkExtHdrMetadata
    {
        public const int    VK_EXT_HDR_METADATA                = 1;
        public const int    VK_EXT_HDR_METADATA_SPEC_VERSION   = 2;
        public const string VK_EXT_HDR_METADATA_EXTENSION_NAME = "VK_EXT_hdr_metadata";

        public static delegate*<
            VkDevice,          /* device */
            uint,              /* swapchainCount */
            VkSwapchainKHR*,   /* pSwapchains */
            VkHdrMetadataEXT*, /* pMetadata */
            void> vkSetHdrMetadataEXT;

        public static partial void Load(VkDevice vkDevice);
    }
}
