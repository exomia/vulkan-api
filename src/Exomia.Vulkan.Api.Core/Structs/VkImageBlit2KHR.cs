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
public unsafe struct VkImageBlit2KHR
{
    public const VkStructureType          STYPE = VkStructureType.IMAGE_BLIT_2_KHR;
    public       VkStructureType          sType;
    public       void*                    pNext;
    public       VkImageSubresourceLayers srcSubresource;
    public       VkOffset3D               srcOffsetsLeftTop;
    public       VkOffset3D               srcOffsetsRightBottom;
    public       VkImageSubresourceLayers dstSubresource;
    public       VkOffset3D               dstOffsetsLeftTop;
    public       VkOffset3D               dstOffsetsRightBottom;
}