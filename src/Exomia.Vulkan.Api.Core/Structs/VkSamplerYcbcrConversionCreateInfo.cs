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
    public unsafe struct VkSamplerYcbcrConversionCreateInfo
    {
        public const VkStructureType               STYPE = VkStructureType.SAMPLER_YCBCR_CONVERSION_CREATE_INFO;
        public       VkStructureType               sType;
        public       void*                         pNext;
        public       VkFormat                      format;
        public       VkSamplerYcbcrModelConversion ycbcrModel;
        public       VkSamplerYcbcrRange           ycbcrRange;
        public       VkComponentMapping            components;
        public       VkChromaLocation              xChromaOffset;
        public       VkChromaLocation              yChromaOffset;
        public       VkFilter                      chromaFilter;
        public       VkBool32                      forceExplicitReconstruction;
    }
}