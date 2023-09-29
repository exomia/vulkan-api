#region License

// Copyright (c) 2018-2023, exomia
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
///     VkOutOfBandQueueTypeNV - Type of out of band queue -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOutOfBandQueueTypeNV.html</a>
/// </summary>
public enum VkOutOfBandQueueTypeNV
{
    /// <summary>VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV indicates that work will be submitted to this queue.</summary>
    VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV = 0,

    /// <summary>VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV indicates that this queue will be presented from.</summary>
    VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV = 1
}