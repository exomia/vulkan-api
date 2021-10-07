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
    public unsafe struct VkPipelineShaderStageCreateInfo
    {
        public const VkStructureType                     STYPE = VkStructureType.PIPELINE_SHADER_STAGE_CREATE_INFO;
        public       VkStructureType                     sType;
        public       void*                               pNext;
        public       VkPipelineShaderStageCreateFlagBits flags;
        public       VkShaderStageFlagBits               stage;
        public       VkShaderModule                      module;
        public       sbyte*                              pName;
        public       VkSpecializationInfo*               pSpecializationInfo;
    }
}