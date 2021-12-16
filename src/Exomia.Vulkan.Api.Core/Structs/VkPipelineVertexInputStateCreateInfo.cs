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
public unsafe struct VkPipelineVertexInputStateCreateInfo
{
    public const VkStructureType                          STYPE = VkStructureType.PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO;
    public       VkStructureType                          sType;
    public       void*                                    pNext;
    public       VkPipelineVertexInputStateCreateFlagBits flags;
    public       uint                                     vertexBindingDescriptionCount;
    public       VkVertexInputBindingDescription*         pVertexBindingDescriptions;
    public       uint                                     vertexAttributeDescriptionCount;
    public       VkVertexInputAttributeDescription*       pVertexAttributeDescriptions;
}