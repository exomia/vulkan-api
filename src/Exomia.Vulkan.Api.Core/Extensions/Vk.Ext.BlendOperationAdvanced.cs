#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [VkExtGenerator]
    public static partial class VkExtBlendOperationAdvanced
    {
        public const int    VK_EXT_BLEND_OPERATION_ADVANCED                = 1;
        public const int    VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION   = 2;
        public const string VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME = "VK_EXT_blend_operation_advanced";
    }
}
