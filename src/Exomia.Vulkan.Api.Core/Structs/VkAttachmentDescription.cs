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
public struct VkAttachmentDescription
{
    public VkAttachmentDescriptionFlagBits flags;
    public VkFormat                        format;
    public VkSampleCountFlagBits           samples;
    public VkAttachmentLoadOp              loadOp;
    public VkAttachmentStoreOp             storeOp;
    public VkAttachmentLoadOp              stencilLoadOp;
    public VkAttachmentStoreOp             stencilStoreOp;
    public VkImageLayout                   initialLayout;
    public VkImageLayout                   finalLayout;
}