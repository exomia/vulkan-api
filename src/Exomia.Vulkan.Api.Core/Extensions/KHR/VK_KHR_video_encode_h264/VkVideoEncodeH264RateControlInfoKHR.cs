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
///     VkVideoEncodeH264RateControlInfoKHR - Structure describing H.264 stream rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoCodingControlInfoKHR,VkVideoBeginCodingInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoCodingControlInfoKHR,VkVideoBeginCodingInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264RateControlInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeH264RateControlFlagBitsKHR specifying H.264 rate control flags.</summary>
    public VkVideoEncodeH264RateControlFlagsKHR flags;

    /// <summary>
    ///     gopFrameCount is the number of frames within a group of pictures (GOP) intended to be used by the application.
    ///     If it is 0, the rate control algorithm may assume an implementation-dependent GOP length. If it is UINT32_MAX, the
    ///     GOP length is treated as infinite.
    /// </summary>
    public uint gopFrameCount;

    /// <summary>
    ///     idrPeriod is the interval, in terms of number of frames, between two IDR frames (see IDR period). If it is 0,
    ///     the rate control algorithm may assume an implementation-dependent IDR period. If it is UINT32_MAX, the IDR period
    ///     is treated as infinite.
    /// </summary>
    public uint idrPeriod;

    /// <summary>consecutiveBFrameCount is the number of consecutive B frames between I and/or P frames within the GOP.</summary>
    public uint consecutiveBFrameCount;

    /// <summary>temporalLayerCount specifies the number of H.264 temporal layers that the application intends to use.</summary>
    public uint temporalLayerCount;
}