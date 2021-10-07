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
    public struct VkSparseImageMemoryBind
    {
        public VkImageSubresource         subresource;
        public VkOffset3D                 offset;
        public VkExtent3D                 extent;
        public VkDeviceMemory             memory;
        public VkDeviceSize               memoryOffset;
        public VkSparseMemoryBindFlagBits flags;
    }
}