﻿#region License

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
    public unsafe struct VkRenderPassCreateInfo2
    {
        public const VkStructureType            STYPE = VkStructureType.RENDER_PASS_CREATE_INFO_2;
        public       VkStructureType            sType;
        public       void*                      pNext;
        public       VkRenderPassCreateFlagBits flags;
        public       uint                       attachmentCount;
        public       VkAttachmentDescription2*  pAttachments;
        public       uint                       subpassCount;
        public       VkSubpassDescription2*     pSubpasses;
        public       uint                       dependencyCount;
        public       VkSubpassDependency2*      pDependencies;
        public       uint                       correlatedViewMaskCount;
        public       uint*                      pCorrelatedViewMasks;
    }
}