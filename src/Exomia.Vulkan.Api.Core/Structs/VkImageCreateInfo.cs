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
public unsafe struct VkImageCreateInfo
{
    public const VkStructureType       STYPE = VkStructureType.IMAGE_CREATE_INFO;
    public       VkStructureType       sType;
    public       void*                 pNext;
    public       VkImageCreateFlagBits flags;
    public       VkImageType           imageType;
    public       VkFormat              format;
    public       VkExtent3D            extent;
    public       uint                  mipLevels;
    public       uint                  arrayLayers;
    public       VkSampleCountFlagBits samples;
    public       VkImageTiling         tiling;
    public       VkImageUsageFlagBits  usage;
    public       VkSharingMode         sharingMode;
    public       uint                  queueFamilyIndexCount;
    public       uint*                 pQueueFamilyIndices;
    public       VkImageLayout         initialLayout;
}