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
    public unsafe struct VkCommandBufferInheritanceInfo
    {
        public const VkStructureType                  STYPE = VkStructureType.COMMAND_BUFFER_INHERITANCE_INFO;
        public       VkStructureType                  sType;
        public       void*                            pNext;
        public       VkRenderPass                     renderPass;
        public       uint                             subpass;
        public       VkFramebuffer                    framebuffer;
        public       VkBool32                         occlusionQueryEnable;
        public       VkQueryControlFlagBits           queryFlags;
        public       VkQueryPipelineStatisticFlagBits pipelineStatistics;
    }
}