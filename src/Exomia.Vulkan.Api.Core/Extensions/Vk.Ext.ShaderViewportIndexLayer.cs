#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Exomia.Vulkan.Api.SourceGenerator;
using System;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_shader_viewport_index_layer.html#_deprecation_state")]
    [VkExtGenerator]
    public static partial class VkExtShaderViewportIndexLayer
    {
        public const int    VK_EXT_SHADER_VIEWPORT_INDEX_LAYER                = 1;
        public const int    VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION   = 1;
        [Obsolete("Promoted to Vulkan 1.2", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_shader_viewport_index_layer.html#_promotion_to_vulkan_1_2")]
        public const string VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME = "VK_EXT_shader_viewport_index_layer";
    }
}
