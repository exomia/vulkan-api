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
    public unsafe struct VkResolveImageInfo2KHR
    {
        public const VkStructureType     STYPE = VkStructureType.RESOLVE_IMAGE_INFO_2_KHR;
        public       VkStructureType     sType;
        public       void*               pNext;
        public       VkImage             srcImage;
        public       VkImageLayout       srcImageLayout;
        public       VkImage             dstImage;
        public       VkImageLayout       dstImageLayout;
        public       uint                regionCount;
        public       VkImageResolve2KHR* pRegions;
    }
}