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
    public unsafe struct VkRayTracingPipelineCreateInfoKHR
    {
        public const VkStructureType                             STYPE = VkStructureType.RAY_TRACING_PIPELINE_CREATE_INFO_KHR;
        public       VkStructureType                             sType;
        public       void*                                       pNext;
        public       VkPipelineCreateFlagBits                    flags;
        public       uint                                        stageCount;
        public       VkPipelineShaderStageCreateInfo*            pStages;
        public       uint                                        groupCount;
        public       VkRayTracingShaderGroupCreateInfoKHR*       pGroups;
        public       uint                                        maxPipelineRayRecursionDepth;
        public       VkPipelineLibraryCreateInfoKHR*             pLibraryInfo;
        public       VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public       VkPipelineDynamicStateCreateInfo*           pDynamicState;
        public       VkPipelineLayout                            layout;
        public       VkPipeline                                  basePipelineHandle;
        public       int                                         basePipelineIndex;
    }
}