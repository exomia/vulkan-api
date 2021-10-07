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
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public const VkStructureType       STYPE = VkStructureType.PIPELINE_EXECUTABLE_PROPERTIES_KHR;
        public       VkStructureType       sType;
        public       void*                 pNext;
        public       VkShaderStageFlagBits stages;
        public fixed sbyte                 name[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
        public fixed sbyte                 description[(int)Vk.VK_MAX_DESCRIPTION_SIZE];
        public       uint                  subgroupSize;
    }
}