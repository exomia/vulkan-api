﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkPipelineDepthStencilStateCreateInfo
    {
        public const VkStructureType                           STYPE = VkStructureType.PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO;
        public       VkStructureType                           sType;
        public       void*                                     pNext;
        public       VkPipelineDepthStencilStateCreateFlagBits flags;
        public       VkBool32                                  depthTestEnable;
        public       VkBool32                                  depthWriteEnable;
        public       VkCompareOp                               depthCompareOp;
        public       VkBool32                                  depthBoundsTestEnable;
        public       VkBool32                                  stencilTestEnable;
        public       VkStencilOpState                          front;
        public       VkStencilOpState                          back;
        public       float                                     minDepthBounds;
        public       float                                     maxDepthBounds;
    }
}