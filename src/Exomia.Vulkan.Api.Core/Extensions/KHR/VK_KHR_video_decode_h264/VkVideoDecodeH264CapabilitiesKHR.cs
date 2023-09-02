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
///     VkVideoDecodeH264CapabilitiesKHR - Structure describing H.264 decode capabilities -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264CapabilitiesKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264CapabilitiesKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoCapabilitiesKHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoCapabilitiesKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     maxLevelIdc is a StdVideoH264LevelIdc value specifying the maximum H.264 level supported by the profile, where
    ///     enum constant STD_VIDEO_H264_LEVEL_IDC_&lt;major&gt;_&lt;minor&gt; identifies H.264 level &lt;major&gt;.&lt;minor
    ///     &gt; as defined in section A.3 of the ITU-T H.264 Specification.
    /// </summary>
    public StdVideoH264LevelIdc maxLevelIdc;

    /// <summary>
    ///     fieldOffsetGranularity is the minimum alignment for VkVideoPictureResourceInfoKHR::codedOffset specified for a
    ///     video picture resource when using the picture layout
    ///     VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR.
    /// </summary>
    public VkOffset2D fieldOffsetGranularity;
}