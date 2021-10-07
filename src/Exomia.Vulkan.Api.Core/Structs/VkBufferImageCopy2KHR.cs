#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkBufferImageCopy2KHR
    {
        public const VkStructureType          STYPE = VkStructureType.BUFFER_IMAGE_COPY_2_KHR;
        public       VkStructureType          sType;
        public       void*                    pNext;
        public       VkDeviceSize             bufferOffset;
        public       uint                     bufferRowLength;
        public       uint                     bufferImageHeight;
        public       VkImageSubresourceLayers imageSubresource;
        public       VkOffset3D               imageOffset;
        public       VkExtent3D               imageExtent;
    }
}