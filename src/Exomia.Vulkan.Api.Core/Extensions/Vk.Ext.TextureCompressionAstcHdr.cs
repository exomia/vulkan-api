#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core.Extensions;

[VkExtGenerator]
public static partial class VkExtTextureCompressionAstcHdr
{
    public const int    VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR                = 1;
    public const int    VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION   = 1;
    public const string VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME = "VK_EXT_texture_compression_astc_hdr";
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
{
    public const VkStructureType STYPE = VkStructureType.PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT;
    public       VkStructureType sType;
    public       void*           pNext;
    public       VkBool32        textureCompressionASTC_HDR;
}