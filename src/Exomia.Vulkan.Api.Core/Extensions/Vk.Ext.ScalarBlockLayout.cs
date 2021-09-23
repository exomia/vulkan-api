#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_scalar_block_layout.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtScalarBlockLayout
    {
        public const int VK_EXT_SCALAR_BLOCK_LAYOUT              = 1;
        public const int VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = 1;

        [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_scalar_block_layout.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME = "VK_EXT_scalar_block_layout";
    }
}