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
///     VkVideoEncodeAV1FrameSizeKHR - Structure describing frame size values per AV1 prediction mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1FrameSizeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1FrameSizeKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVideoEncodeAV1FrameSizeKHR
{
    /// <summary>
    ///     intraFrameSize is the size in bytes to be used for frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_INTRA_KHR.
    /// </summary>
    public uint intraFrameSize;

    /// <summary>
    ///     predictiveFrameSize is the size in bytes to be used for frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_PREDICTIVE_KHR.
    /// </summary>
    public uint predictiveFrameSize;

    /// <summary>
    ///     bipredictiveFrameSize is the size in bytes to be used for frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR.
    /// </summary>
    public uint bipredictiveFrameSize;
}