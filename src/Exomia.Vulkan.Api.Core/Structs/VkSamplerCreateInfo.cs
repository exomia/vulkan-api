#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

using System.Runtime.InteropServices;

namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSamplerCreateInfo
    {
        public const VkStructureType         STYPE = VkStructureType.SAMPLER_CREATE_INFO;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       VkSamplerCreateFlagBits flags;
        public       VkFilter                magFilter;
        public       VkFilter                minFilter;
        public       VkSamplerMipmapMode     mipmapMode;
        public       VkSamplerAddressMode    addressModeU;
        public       VkSamplerAddressMode    addressModeV;
        public       VkSamplerAddressMode    addressModeW;
        public       float                   mipLodBias;
        public       VkBool32                anisotropyEnable;
        public       float                   maxAnisotropy;
        public       VkBool32                compareEnable;
        public       VkCompareOp             compareOp;
        public       float                   minLod;
        public       float                   maxLod;
        public       VkBorderColor           borderColor;
        public       VkBool32                unnormalizedCoordinates;
    }
}