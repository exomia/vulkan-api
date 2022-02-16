#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecH264stdDefines;

// ReSharper disable ShiftExpressionZeroLeftOperand
namespace Exomia.Vulkan.Api.Core;

/// <summary>The VulkanVideoCodecH264stdDefines class.</summary>
public static class VulkanVideoCodecH264stdDefines
{
    /// <summary>The VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5.</summary>
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H264_API_VERSION_0_9_5 = (0 << 22) | (9 << 12) | 5;
}