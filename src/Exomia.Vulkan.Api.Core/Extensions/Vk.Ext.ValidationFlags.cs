#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{
    [Obsolete("Deprecation by VK_EXT_validation_features", false, UrlFormat = "https://www.khronos.org/registry/vulkan/specs/1.2-extensions/man/html/VK_EXT_validation_flags.html#_deprecation_by_vk_ext_validation_features")]
    [VkExtGenerator]
    public static partial class VkExtValidationFlags
    {
        public const int    VK_EXT_VALIDATION_FLAGS                = 1;
        public const int    VK_EXT_VALIDATION_FLAGS_SPEC_VERSION   = 2;
        public const string VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME = "VK_EXT_validation_flags";
    }
}
