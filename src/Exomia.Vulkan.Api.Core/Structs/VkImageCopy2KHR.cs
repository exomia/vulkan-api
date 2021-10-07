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
    public unsafe struct VkImageCopy2KHR
    {
        public const VkStructureType          STYPE = VkStructureType.IMAGE_COPY_2_KHR;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkImageSubresourceLayers srcSubresource;
        public       VkOffset3D               srcOffset;
        public       VkImageSubresourceLayers dstSubresource;
        public       VkOffset3D               dstOffset;
        public       VkExtent3D               extent;
    }
}