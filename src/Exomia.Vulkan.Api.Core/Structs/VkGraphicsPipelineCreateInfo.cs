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
    public unsafe struct VkGraphicsPipelineCreateInfo
    {
        public const VkStructureType                         STYPE = VkStructureType.GRAPHICS_PIPELINE_CREATE_INFO;
        public       VkStructureType                         sType;
        public       void*                                   pNext;
        public       VkPipelineCreateFlagBits                flags;
        public       uint                                    stageCount;
        public       VkPipelineShaderStageCreateInfo*        pStages;
        public       VkPipelineVertexInputStateCreateInfo*   pVertexInputState;
        public       VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public       VkPipelineTessellationStateCreateInfo*  pTessellationState;
        public       VkPipelineViewportStateCreateInfo*      pViewportState;
        public       VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public       VkPipelineMultisampleStateCreateInfo*   pMultisampleState;
        public       VkPipelineDepthStencilStateCreateInfo*  pDepthStencilState;
        public       VkPipelineColorBlendStateCreateInfo*    pColorBlendState;
        public       VkPipelineDynamicStateCreateInfo*       pDynamicState;
        public       VkPipelineLayout                        layout;
        public       VkRenderPass                            renderPass;
        public       uint                                    subpass;
        public       VkPipeline                              basePipelineHandle;
        public       int                                     basePipelineIndex;
    }
}