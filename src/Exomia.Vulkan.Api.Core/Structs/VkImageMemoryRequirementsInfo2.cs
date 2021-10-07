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
    public unsafe struct VkImageMemoryRequirementsInfo2
    {
        public const VkStructureType STYPE = VkStructureType.IMAGE_MEMORY_REQUIREMENTS_INFO_2;
        public       VkStructureType sType;
        public       void*           pNext;
        public       VkImage         image;
    }
}