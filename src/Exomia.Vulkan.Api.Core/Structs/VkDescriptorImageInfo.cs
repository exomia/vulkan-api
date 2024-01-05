#region License

// Copyright (c) 2018-2024, exomia
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
///     VkDescriptorImageInfo - Structure specifying descriptor image information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorImageInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorImageInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDescriptorImageInfo
{
    /// <summary>
    ///     sampler is a sampler handle, and is used in descriptor updates for types VK_DESCRIPTOR_TYPE_SAMPLER and
    ///     VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER if the binding being updated does not use immutable samplers.
    /// </summary>
    public VkSampler sampler;

    /// <summary>
    ///     imageView is VK_NULL_HANDLE or an image view handle, and is used in descriptor updates for types
    ///     VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE, VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
    /// </summary>
    public VkImageView imageView;

    /// <summary>
    ///     imageLayout is the layout that the image subresources accessible from imageView will be in at the time this
    ///     descriptor is accessed. imageLayout is used in descriptor updates for types VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE,
    ///     VK_DESCRIPTOR_TYPE_STORAGE_IMAGE, VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER, and
    ///     VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT.
    /// </summary>
    public VkImageLayout imageLayout;
}