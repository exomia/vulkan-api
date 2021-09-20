#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtQueueFamilyForeign
    {
        public const int    VK_EXT_QUEUE_FAMILY_FOREIGN                = 1;
        public const int    VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION   = 1;
        public const string VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME = "VK_EXT_queue_family_foreign";
        public const uint   VK_QUEUE_FAMILY_FOREIGN_EXT                = ~2U;
    }
}
