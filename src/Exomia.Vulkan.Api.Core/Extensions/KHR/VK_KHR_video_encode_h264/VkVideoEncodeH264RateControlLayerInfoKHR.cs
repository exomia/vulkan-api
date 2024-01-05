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
///     VkVideoEncodeH264RateControlLayerInfoKHR - Structure describing H.264 per-layer rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlLayerInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264RateControlLayerInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeRateControlLayerInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeRateControlLayerInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264RateControlLayerInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useMinQp indicates whether the QP values determined by rate control will be clamped to the lower bounds on the
    ///     QP values specified in minQp.
    /// </summary>
    public VkBool32 useMinQp;

    /// <summary>
    ///     minQp specifies the lower bounds on the QP values, for each picture type, that the implementation&#8217;s rate
    ///     control algorithm will use when useMinQp is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeH264QpKHR minQp;

    /// <summary>
    ///     useMaxQp indicates whether the QP values determined by rate control will be clamped to the upper bounds on the
    ///     QP values specified in maxQp.
    /// </summary>
    public VkBool32 useMaxQp;

    /// <summary>
    ///     maxQp specifies the upper bounds on the QP values, for each picture type, that the implementation&#8217;s rate
    ///     control algorithm will use when useMaxQp is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeH264QpKHR maxQp;

    /// <summary>
    ///     useMaxFrameSize indicates whether the implementation&#8217;s rate control algorithm should use the values
    ///     specified in maxFrameSizeas the upper bounds on the encoded frame size for each picture type.
    /// </summary>
    public VkBool32 useMaxFrameSize;

    /// <summary>
    ///     maxFrameSize specifies the upper bounds on the encoded frame size, for each picture type, when useMaxFrameSize
    ///     is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
}