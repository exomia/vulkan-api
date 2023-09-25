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
///     VkVideoEncodeH265QualityLevelPropertiesEXT - Structure describing the H.265 encode quality level properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QualityLevelPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265QualityLevelPropertiesEXT.html
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
public unsafe struct VkVideoEncodeH265QualityLevelPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     preferredRateControlFlags is a bitmask of VkVideoEncodeH265RateControlFlagBitsEXT values indicating the
    ///     preferred flags to use for VkVideoEncodeH265RateControlInfoEXT::flags.
    /// </summary>
    public VkVideoEncodeH265RateControlFlagsEXT preferredRateControlFlags;

    /// <summary>
    ///     preferredGopFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeH265RateControlInfoEXT::gopFrameCount.
    /// </summary>
    public uint preferredGopFrameCount;

    /// <summary>preferredIdrPeriod indicates the preferred value to use for VkVideoEncodeH265RateControlInfoEXT::idrPeriod.</summary>
    public uint preferredIdrPeriod;

    /// <summary>
    ///     preferredConsecutiveBFrameCount indicates the preferred value to use for
    ///     VkVideoEncodeH265RateControlInfoEXT::consecutiveBFrameCount.
    /// </summary>
    public uint preferredConsecutiveBFrameCount;

    /// <summary>
    ///     preferredSubLayerCount indicates the preferred value to use for
    ///     VkVideoEncodeH265RateControlInfoEXT::subLayerCount.
    /// </summary>
    public uint preferredSubLayerCount;

    /// <summary>
    ///     preferredConstantQp indicates the preferred values to use for
    ///     VkVideoEncodeH265NaluSliceSegmentInfoEXT::constantQp for each picture type when using rate control mode
    ///     VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR.
    /// </summary>
    public VkVideoEncodeH265QpEXT preferredConstantQp;

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
}