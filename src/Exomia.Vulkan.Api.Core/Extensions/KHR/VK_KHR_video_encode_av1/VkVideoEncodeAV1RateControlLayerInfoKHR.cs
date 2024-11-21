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
///     VkVideoEncodeAV1RateControlLayerInfoKHR - Structure describing AV1 per-layer rate control parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlLayerInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1RateControlLayerInfoKHR.html
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
public unsafe struct VkVideoEncodeAV1RateControlLayerInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_RATE_CONTROL_LAYER_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useMinQIndex indicates whether the quantizer index values determined by rate control will be clamped to the
    ///     lower bounds on the quantizer index values specified in minQIndex.
    /// </summary>
    public VkBool32 useMinQIndex;

    /// <summary>
    ///     minQIndex specifies the lower bounds on the quantizer index values, for each rate control group, that the
    ///     implementation&#8217;s rate control algorithm will use when useMinQIndex is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeAV1QIndexKHR minQIndex;

    /// <summary>
    ///     useMaxQIndex indicates whether the quantizer index values determined by rate control will be clamped to the
    ///     upper bounds on the quantizer index values specified in maxQIndex.
    /// </summary>
    public VkBool32 useMaxQIndex;

    /// <summary>
    ///     maxQIndex specifies the upper bounds on the quantizer index values, for each rate control group, that the
    ///     implementation&#8217;s rate control algorithm will use when useMaxQIndex is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeAV1QIndexKHR maxQIndex;

    /// <summary>
    ///     useMaxFrameSize indicates whether the implementation&#8217;s rate control algorithm should use the values
    ///     specified in maxFrameSizeas the upper bounds on the encoded frame size for each rate control group.
    /// </summary>
    public VkBool32 useMaxFrameSize;

    /// <summary>
    ///     maxFrameSize specifies the upper bounds on the encoded frame size, for each rate control group, when
    ///     useMaxFrameSize is set to VK_TRUE.
    /// </summary>
    public VkVideoEncodeAV1FrameSizeKHR maxFrameSize;
}