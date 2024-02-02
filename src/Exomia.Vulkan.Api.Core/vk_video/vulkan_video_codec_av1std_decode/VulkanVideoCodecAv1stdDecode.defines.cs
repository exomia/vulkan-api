#region License

// Copyright (c) 2018-2024, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

global using static Exomia.Vulkan.Api.Core.VulkanVideoCodecAv1stdDecodeDefines;

// ReSharper disable ShiftExpressionZeroLeftOperand
namespace Exomia.Vulkan.Api.Core;

/// <summary>The VulkanVideoCodecAv1stdDecodeDefines class.</summary>
public static class VulkanVideoCodecAv1stdDecodeDefines
{
    /// <summary>The VK_STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0.</summary>
    public const uint VK_STD_VULKAN_VIDEO_CODEC_AV1_DECODE_API_VERSION_1_0_0 = (1 << 22) | (0 << 12) | 0;
}