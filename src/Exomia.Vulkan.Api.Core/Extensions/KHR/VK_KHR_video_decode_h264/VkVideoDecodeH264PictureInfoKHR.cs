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
///     VkVideoDecodeH264PictureInfoKHR - Structure specifies H.264 decode picture parameters when decoding a picture
///     -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264PictureInfoKHR.html
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
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pStdPictureInfo is a pointer to a StdVideoDecodeH264PictureInfo structure specifying H.264 picture
    ///     information.
    /// </summary>
    public StdVideoDecodeH264PictureInfo* pStdPictureInfo;

    /// <summary>sliceCount is the number of elements in pSliceOffsets.</summary>
    public uint sliceCount;

    /// <summary>
    ///     pSliceOffsets is a pointer to an array of sliceCount offsets specifying the start offset of the slices of the
    ///     picture within the video bitstream buffer range specified in VkVideoDecodeInfoKHR.
    /// </summary>
    public uint* pSliceOffsets;
}