#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkInputAttachmentAspectReference - Structure specifying a subpass/input attachment pair and an aspect mask
///     that can: be read. -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInputAttachmentAspectReference.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkInputAttachmentAspectReference.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkInputAttachmentAspectReference
{
    /// <summary>subpass is an index into the pSubpasses array of the parent VkRenderPassCreateInfo structure.</summary>
    public uint subpass;

    /// <summary>inputAttachmentIndex is an index into the pInputAttachmentsof the specified subpass.</summary>
    public uint inputAttachmentIndex;

    /// <summary>aspectMask is a mask of which aspect(s) can be accessed within the specified subpass.</summary>
    public VkImageAspectFlags aspectMask;
}