#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CA2211 // Non-constant fields should not be visible
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;
using System.Runtime.InteropServices;
using Exomia.Vulkan.Api.SourceGenerator;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core.Extensions.AMD
{
    [VkExtGenerator]
    public static unsafe partial class VKAmdTextureGatherBiasLod
    {
        public const int    VK_AMD_TEXTURE_GATHER_BIAS_LOD                = 1;
        public const int    VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION   = 1;
        public const string VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME = "VK_AMD_texture_gather_bias_lod";
        
        

        public static partial void Load(VkInstance vkInstance);
    }




    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkTextureLODGatherFormatPropertiesAMD
    {
        public const VkStructureType STYPE = VkStructureType.TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkBool32        supportsTextureGatherLODBiasAMD;
    }




}