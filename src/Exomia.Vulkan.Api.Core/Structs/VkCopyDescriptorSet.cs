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
    public unsafe struct VkCopyDescriptorSet
    {
        public const VkStructureType STYPE = VkStructureType.COPY_DESCRIPTOR_SET;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkDescriptorSet srcSet;
        public       uint            srcBinding;
        public       uint            srcArrayElement;
        public       VkDescriptorSet dstSet;
        public       uint            dstBinding;
        public       uint            dstArrayElement;
        public       uint            descriptorCount;
    }
}