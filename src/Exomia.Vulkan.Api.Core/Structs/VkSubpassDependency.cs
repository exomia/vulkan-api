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
///     VkSubpassDependency - Structure specifying a subpass dependency -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDependency.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubpassDependency.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSubpassDependency
{
    /// <summary>srcSubpass is the subpass index of the first subpass in the dependency, or VK_SUBPASS_EXTERNAL.</summary>
    public uint srcSubpass;

    /// <summary>dstSubpass is the subpass index of the second subpass in the dependency, or VK_SUBPASS_EXTERNAL.</summary>
    public uint dstSubpass;

    /// <summary>srcStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the source stage mask.</summary>
    public VkPipelineStageFlags srcStageMask;

    /// <summary>dstStageMask is a bitmask of VkPipelineStageFlagBitsspecifying the destination stage mask</summary>
    public VkPipelineStageFlags dstStageMask;

    /// <summary>srcAccessMask is a bitmask of VkAccessFlagBits specifying a source access mask.</summary>
    public VkAccessFlags srcAccessMask;

    /// <summary>dstAccessMask is a bitmask of VkAccessFlagBits specifying a destination access mask.</summary>
    public VkAccessFlags dstAccessMask;

    /// <summary>dependencyFlags is a bitmask of VkDependencyFlagBits.</summary>
    public VkDependencyFlags dependencyFlags;
}