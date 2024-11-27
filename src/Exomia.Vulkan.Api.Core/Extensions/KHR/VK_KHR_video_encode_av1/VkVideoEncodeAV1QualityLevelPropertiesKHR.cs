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
///     VkVideoEncodeAV1QualityLevelPropertiesKHR - Structure describing the AV1 encode quality level properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QualityLevelPropertiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1QualityLevelPropertiesKHR.html
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
public unsafe struct VkVideoEncodeAV1QualityLevelPropertiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_QUALITY_LEVEL_PROPERTIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     preferredRateControlFlags is a bitmask of VkVideoEncodeAV1RateControlFlagBitsKHR values indicating the
    ///     preferred flags to use for VkVideoEncodeAV1RateControlInfoKHR::flags.
    /// </summary>
    public VkVideoEncodeAV1RateControlFlagsKHR preferredRateControlFlags;

    /// <summary>
    ///     preferredGopFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeAV1RateControlInfoKHR::gopFrameCount.
    /// </summary>
    public uint preferredGopFrameCount;

    /// <summary>
    ///     preferredKeyFramePeriod indicates the preferred value to use for
    ///     VkVideoEncodeAV1RateControlInfoKHR::keyFramePeriod.
    /// </summary>
    public uint preferredKeyFramePeriod;

    /// <summary>
    ///     preferredConsecutiveBipredictiveFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeAV1RateControlInfoKHR::consecutiveBipredictiveFrameCount.
    /// </summary>
    public uint preferredConsecutiveBipredictiveFrameCount;

    /// <summary>
    ///     preferredTemporalLayerCount indicates the preferred value to use for
    ///     VkVideoEncodeAV1RateControlInfoKHR::temporalLayerCount.
    /// </summary>
    public uint preferredTemporalLayerCount;

    /// <summary>
    ///     preferredConstantQIndex indicates the preferred value to use for
    ///     VkVideoEncodeAV1PictureInfoKHR::constantQIndex when using rate control
    ///     modeVK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR.
    /// </summary>
    public VkVideoEncodeAV1QIndexKHR preferredConstantQIndex;

    /// <summary>
    ///     preferredMaxSingleReferenceCount indicates the preferred maximum number of reference pictures to use with
    ///     single reference prediction mode.
    /// </summary>
    public uint preferredMaxSingleReferenceCount;

    /// <summary>
    ///     preferredSingleReferenceNameMask is a bitmask of preferred AV1 reference names when using single reference
    ///     prediction mode.
    /// </summary>
    public uint preferredSingleReferenceNameMask;

    /// <summary>
    ///     preferredMaxUnidirectionalCompoundReferenceCount indicates the preferred maximum number of reference pictures
    ///     to use with unidirectional compound prediction mode.
    /// </summary>
    public uint preferredMaxUnidirectionalCompoundReferenceCount;

    /// <summary>
    ///     preferredMaxUnidirectionalCompoundGroup1ReferenceCount indicates the preferred maximum number of reference
    ///     pictures to use with unidirectional compound prediction modefrom reference frame group 1, as defined in section
    ///     6.10.24 of the AV1 Specification.
    /// </summary>
    public uint preferredMaxUnidirectionalCompoundGroup1ReferenceCount;

    /// <summary>
    ///     preferredUnidirectionalCompoundReferenceNameMask is a bitmask of preferred AV1 reference names when using
    ///     unidirectional compound prediction mode.
    /// </summary>
    public uint preferredUnidirectionalCompoundReferenceNameMask;

    /// <summary>
    ///     preferredMaxBidirectionalCompoundReferenceCount indicates the preferred maximum number of reference pictures
    ///     to use with bidirectional compound prediction mode.
    /// </summary>
    public uint preferredMaxBidirectionalCompoundReferenceCount;

    /// <summary>
    ///     preferredMaxBidirectionalCompoundGroup1ReferenceCount indicates the preferred maximum number of reference
    ///     pictures to use with bidirectional compound prediction modefrom reference frame group 1, as defined in section
    ///     6.10.24 of the AV1 Specification.
    /// </summary>
    public uint preferredMaxBidirectionalCompoundGroup1ReferenceCount;

    /// <summary>
    ///     preferredMaxBidirectionalCompoundGroup2ReferenceCount indicates the preferred maximum number of reference
    ///     pictures to use with bidirectional compound prediction modefrom reference frame group 2, as defined in section
    ///     6.10.24 of the AV1 Specification.
    /// </summary>
    public uint preferredMaxBidirectionalCompoundGroup2ReferenceCount;

    /// <summary>
    ///     preferredBidirectionalCompoundReferenceNameMask is a bitmask of preferred AV1 reference names when using
    ///     bidirectional compound prediction mode.
    /// </summary>
    public uint preferredBidirectionalCompoundReferenceNameMask;
}