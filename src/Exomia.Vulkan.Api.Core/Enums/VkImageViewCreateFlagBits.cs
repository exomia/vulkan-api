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
///     VkImageViewCreateFlagBits - Bitmask specifying additional parameters of an image view -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageViewCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkImageViewCreateFlagBits
{
    /// <summary>
    ///     VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXTspecifies that the fragment density map will be read
    ///     by device during VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT
    /// </summary>
    VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXTspecifies that the image view can be used with
    ///     descriptor buffers when capturing and replaying (e.g. for trace capture and replay), see
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpaqueCaptureDescriptorDataCreateInfoEXT.html">
    ///         VkOpaqueCaptureDescriptorDataCreateInfoEXT
    ///     </a>
    ///     for more detail.
    /// </summary>
    VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXTspecifies that the fragment density map will be read
    ///     by the host during
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkEndCommandBuffer.html">vkEndCommandBuffer</a>
    ///     for the primary command buffer that the render pass is recorded into
    /// </summary>
    VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT = 0x2
}