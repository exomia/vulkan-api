#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecH265stdEncodeDefines;

// ReSharper disable ShiftExpressionZeroLeftOperand
namespace Exomia.Vulkan.Api.Core;

/// <summary>The VulkanVideoCodecH265stdEncodeDefines class.</summary>
public static class VulkanVideoCodecH265stdEncodeDefines
{
    /// <summary>The VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0.</summary>
    public const uint VK_STD_VULKAN_VIDEO_CODEC_H265_ENCODE_API_VERSION_1_0_0 = (1 << 22) | (0 << 12) | 0;
}