#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions
{ 
    [VkExtGenerator]
    public static partial class VkExtTextureCompressionAstcHdr
    {
        public const int    VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR                = 1;
        public const int    VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION   = 1;
        public const string VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME = "VK_EXT_texture_compression_astc_hdr";
    }
}
