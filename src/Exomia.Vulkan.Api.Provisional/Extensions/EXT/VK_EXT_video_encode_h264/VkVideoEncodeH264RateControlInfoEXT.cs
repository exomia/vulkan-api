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
namespace Exomia.Vulkan.Api.Provisional;

/// <summary>
///     VkVideoEncodeH264RateControlInfoEXT - Structure describing H.264 stream rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlInfoEXT.html
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
public unsafe struct VkVideoEncodeH264RateControlInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkVideoEncodeH264RateControlFlagBitsEXT specifying H.264 rate control flags.</summary>
    public VkVideoEncodeH264RateControlFlagsEXT flags;

    /// <summary>
    ///     gopFrameCount is the number of frames contained within the group of pictures (GOP), starting from an intra
    ///     frame and until the next intra frame. If it is set to 0, the implementation chooses a suitable value. If it is set
    ///     to UINT32_MAX, the GOP length is treated as infinite.
    /// </summary>
    public uint gopFrameCount;

    /// <summary>
    ///     idrPeriod is the interval, in terms of number of frames, between two IDR frames. If it is set to 0, the
    ///     implementation chooses a suitable value. If it is set to UINT32_MAX, the IDR period is treated as infinite.
    /// </summary>
    public uint idrPeriod;

    /// <summary>consecutiveBFrameCount is the number of consecutive B-frames between I- and/or P-frames within the GOP.</summary>
    public uint consecutiveBFrameCount;

    /// <summary>temporalLayerCount specifies the number of temporal layers enabled in the stream.</summary>
    public uint temporalLayerCount;
}