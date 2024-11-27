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
///     VkVideoEncodeAV1RateControlInfoKHR - Structure describing AV1 stream rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlInfoKHR.html
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
public unsafe struct VkVideoEncodeAV1RateControlInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeAV1RateControlFlagBitsKHRspecifying AV1 rate control flags.</summary>
    public VkVideoEncodeAV1RateControlFlagsKHR flags;

    /// <summary>
    ///     gopFrameCount is the number of frames within a group of pictures (GOP) intended to be used by the application.
    ///     If it is set to 0, the rate control algorithm may assume an implementation-dependent GOP length. If it is set to
    ///     UINT32_MAX, the GOP length is treated as infinite.
    /// </summary>
    public uint gopFrameCount;

    /// <summary>
    ///     keyFramePeriod is the interval, in terms of number of frames, between two frames with the AV1 frame type
    ///     STD_VIDEO_AV1_FRAME_TYPE_KEY (see key frame period). If it is set to 0, the rate control algorithm may assume an
    ///     implementation-dependent key frame period. If it is set to UINT32_MAX, the key frame period is treated as infinite.
    /// </summary>
    public uint keyFramePeriod;

    /// <summary>
    ///     consecutiveBipredictiveFrameCount is the number of consecutive frames encoded with
    ///     VK_VIDEO_ENCODE_AV1_RATE_CONTROL_GROUP_BIPREDICTIVE_KHR between frames encoded with other rate control groups
    ///     within the GOP.
    /// </summary>
    public uint consecutiveBipredictiveFrameCount;

    /// <summary>temporalLayerCount specifies the number of AV1 temporal layers that the application intends to use.</summary>
    public uint temporalLayerCount;
}