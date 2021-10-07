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
    public unsafe struct VkPipelineRasterizationStateCreateInfo
    {
        public const VkStructureType                            STYPE = VkStructureType.PIPELINE_RASTERIZATION_STATE_CREATE_INFO;
        public       VkStructureType                            sType;
        public       void*                                      pNext;
        public       VkPipelineRasterizationStateCreateFlagBits flags;
        public       VkBool32                                   depthClampEnable;
        public       VkBool32                                   rasterizerDiscardEnable;
        public       VkPolygonMode                              polygonMode;
        public       VkCullModeFlagBits                         cullMode;
        public       VkFrontFace                                frontFace;
        public       VkBool32                                   depthBiasEnable;
        public       float                                      depthBiasConstantFactor;
        public       float                                      depthBiasClamp;
        public       float                                      depthBiasSlopeFactor;
        public       float                                      lineWidth;
    }
}