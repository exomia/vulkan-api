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
    public unsafe struct VkSubpassDependency2
    {
        public const VkStructureType         STYPE = VkStructureType.SUBPASS_DEPENDENCY_2;
        public       VkStructureType         sType;
        public       void*                   pNext;
        public       uint                    srcSubpass;
        public       uint                    dstSubpass;
        public       VkPipelineStageFlagBits srcStageMask;
        public       VkPipelineStageFlagBits dstStageMask;
        public       VkAccessFlagBits        srcAccessMask;
        public       VkAccessFlagBits        dstAccessMask;
        public       VkDependencyFlagBits    dependencyFlags;
        public       int                     viewOffset;
    }
}