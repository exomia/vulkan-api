#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineMultisampleStateCreateInfo
{
    public const VkStructureType                          STYPE = VkStructureType.PIPELINE_MULTISAMPLE_STATE_CREATE_INFO;
    public       VkStructureType                          sType;
    public       void*                                    pNext;
    public       VkPipelineMultisampleStateCreateFlagBits flags;
    public       VkSampleCountFlagBits                    rasterizationSamples;
    public       VkBool32                                 sampleShadingEnable;
    public       float                                    minSampleShading;
    public       uint*                                    pSampleMask;
    public       VkBool32                                 alphaToCoverageEnable;
    public       VkBool32                                 alphaToOneEnable;
}