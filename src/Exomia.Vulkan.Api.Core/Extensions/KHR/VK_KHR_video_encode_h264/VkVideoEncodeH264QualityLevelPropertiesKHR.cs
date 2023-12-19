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
///     VkVideoEncodeH264QualityLevelPropertiesKHR - Structure describing the H.264 encode quality level properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QualityLevelPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264QualityLevelPropertiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeQualityLevelPropertiesKHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeQualityLevelPropertiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264QualityLevelPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     preferredRateControlFlags is a bitmask of VkVideoEncodeH264RateControlFlagBitsKHR values indicating the
    ///     preferred flags to use for VkVideoEncodeH264RateControlInfoKHR::flags.
    /// </summary>
    public VkVideoEncodeH264RateControlFlagsKHR preferredRateControlFlags;

    /// <summary>
    ///     preferredGopFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeH264RateControlInfoKHR::gopFrameCount.
    /// </summary>
    public uint preferredGopFrameCount;

    /// <summary>preferredIdrPeriod indicates the preferred value to use for VkVideoEncodeH264RateControlInfoKHR::idrPeriod.</summary>
    public uint preferredIdrPeriod;

    /// <summary>
    ///     preferredConsecutiveBFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeH264RateControlInfoKHR::consecutiveBFrameCount.
    /// </summary>
    public uint preferredConsecutiveBFrameCount;

    /// <summary>
    ///     preferredTemporalLayerCount indicates the preferred value to use for
    ///     VkVideoEncodeH264RateControlInfoKHR::temporalLayerCount.
    /// </summary>
    public uint preferredTemporalLayerCount;

    /// <summary>
    ///     preferredConstantQp indicates the preferred values to use for VkVideoEncodeH264NaluSliceInfoKHR::constantQp
    ///     for each picture type when using rate control modeVK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR.
    /// </summary>
    public VkVideoEncodeH264QpKHR preferredConstantQp;

    /// <summary>
    ///     preferredMaxL0ReferenceCount indicates the preferred maximum number of reference pictures to use in the
    ///     reference list L0.
    /// </summary>
    public uint preferredMaxL0ReferenceCount;

    /// <summary>
    ///     preferredMaxL1ReferenceCount indicates the preferred maximum number of reference pictures to use in the
    ///     reference list L1.
    /// </summary>
    public uint preferredMaxL1ReferenceCount;

    /// <summary>
    ///     preferredStdEntropyCodingModeFlag indicates the preferred value to use for entropy_coding_mode_flag in
    ///     StdVideoH264PpsFlags.
    /// </summary>
    public VkBool32 preferredStdEntropyCodingModeFlag;
}