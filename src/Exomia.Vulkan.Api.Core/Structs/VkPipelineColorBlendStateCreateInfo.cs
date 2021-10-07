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
    public unsafe struct VkPipelineColorBlendStateCreateInfo
    {
        public const VkStructureType                         STYPE = VkStructureType.PIPELINE_COLOR_BLEND_STATE_CREATE_INFO;
        public       VkStructureType                         sType;
        public       void*                                   pNext;
        public       VkPipelineColorBlendStateCreateFlagBits flags;
        public       VkBool32                                logicOpEnable;
        public       VkLogicOp                               logicOp;
        public       uint                                    attachmentCount;
        public       VkPipelineColorBlendAttachmentState*    pAttachments;
        public fixed float                                   blendConstants[4];
    }
}