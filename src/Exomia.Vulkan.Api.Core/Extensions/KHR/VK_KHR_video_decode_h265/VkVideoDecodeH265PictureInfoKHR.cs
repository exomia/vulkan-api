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
///     VkVideoDecodeH265PictureInfoKHR - Structure specifies H.265 picture information when decoding a frame -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265PictureInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265PictureInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoDecodeInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoDecodeInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pStdPictureInfo is a pointer to a StdVideoDecodeH265PictureInfo structure specifying H.265 picture
    ///     information.
    /// </summary>
    public StdVideoDecodeH265PictureInfo* pStdPictureInfo;

    /// <summary>sliceSegmentCount is the number of elements in pSliceSegmentOffsets.</summary>
    public uint sliceSegmentCount;

    /// <summary>
    ///     pSliceSegmentOffsets is a pointer to an array of sliceSegmentCount offsets specifying the start offset of the
    ///     slice segments of the picture within the video bitstream buffer range specified in VkVideoDecodeInfoKHR.
    /// </summary>
    public uint* pSliceSegmentOffsets;
}