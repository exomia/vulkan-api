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
///     VkVideoEncodeRateControlLayerInfoKHR - Structure to set encode per-layer rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlLayerInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeRateControlLayerInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeRateControlLayerInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>averageBitrate is the average bitrate to be targeted by the implementation&#8217;s rate control algorithm.</summary>
    public ulong averageBitrate;

    /// <summary>maxBitrate is the peak bitrate to be targeted by the implementation&#8217;s rate control algorithm.</summary>
    public ulong maxBitrate;

    /// <summary>
    ///     frameRateNumerator is the numerator of the frame rate assumed by the implementation&#8217;s rate control
    ///     algorithm.
    /// </summary>
    public uint frameRateNumerator;

    /// <summary>
    ///     frameRateDenominator is the denominator of the frame rate assumed by the implementation&#8217;s rate control
    ///     algorithm.
    /// </summary>
    public uint frameRateDenominator;
}