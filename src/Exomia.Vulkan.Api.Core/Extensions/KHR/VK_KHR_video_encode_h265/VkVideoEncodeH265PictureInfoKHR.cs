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
///     VkVideoEncodeH265PictureInfoKHR - Structure specifies H.265 encode frame parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265PictureInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265PictureInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>naluSliceSegmentEntryCount is the number of elements in pNaluSliceSegmentEntries.</summary>
    public uint naluSliceSegmentEntryCount;

    /// <summary>
    ///     pNaluSliceSegmentEntries is a pointer to an array of
    ///     naluSliceSegmentEntryCountVkVideoEncodeH265NaluSliceSegmentInfoKHR structures specifying the parameters of the
    ///     individual H.265 slice segments to encode for the input picture.
    /// </summary>
    public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;

    /// <summary>
    ///     pStdPictureInfo is a pointer to a StdVideoEncodeH265PictureInfo structure specifying H.265 picture
    ///     information.
    /// </summary>
    public StdVideoEncodeH265PictureInfo* pStdPictureInfo;
}