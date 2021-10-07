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
    public unsafe struct VkRenderPassMultiviewCreateInfo
    {
        public const VkStructureType STYPE = VkStructureType.RENDER_PASS_MULTIVIEW_CREATE_INFO;
        public       VkStructureType sType;
        public       void*           pNext;
        public       uint            subpassCount;
        public       uint*           pViewMasks;
        public       uint            dependencyCount;
        public       int*            pViewOffsets;
        public       uint            correlationMaskCount;
        public       uint*           pCorrelationMasks;
    }
}