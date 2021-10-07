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
    public unsafe struct VkPipelineExecutableStatisticKHR
    {
        public const VkStructureType                        STYPE = VkStructureType.PIPELINE_EXECUTABLE_STATISTIC_KHR;
        public       VkStructureType                        sType;
        public       void*                                  pNext;
        public fixed sbyte                                  name[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                                  description[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
        public       VkPipelineExecutableStatisticFormatKHR format;
        public       VkPipelineExecutableStatisticValueKHR  value;
    }
}