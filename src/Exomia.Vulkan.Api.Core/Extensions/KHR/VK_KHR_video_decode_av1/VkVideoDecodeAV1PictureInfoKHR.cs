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
///     VkVideoDecodeAV1PictureInfoKHR - Structure specifies AV1 picture information when decoding a frame -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1PictureInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1PictureInfoKHR.html</a>
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
public unsafe struct VkVideoDecodeAV1PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PICTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pStdPictureInfo is a pointer to a StdVideoDecodeAV1PictureInfo structure specifying AV1 picture information.</summary>
    public StdVideoDecodeAV1PictureInfo* pStdPictureInfo;

    /// <summary>
    ///     referenceNameSlotIndices is an array of seven (VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR, which is equal to
    ///     the Video Std definition STD_VIDEO_AV1_REFS_PER_FRAME) signed integer values specifying the index of the DPB slot
    ///     or a negative integer value for each AV1 reference nameused for inter coding. In particular, the DPB slot index for
    ///     the AV1 reference name frameis specified in referenceNameSlotIndices[frame -
    ///     STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME].
    /// </summary>
    public fixed int referenceNameSlotIndices[(int)VK_MAX_VIDEO_AV1_REFERENCES_PER_FRAME_KHR];

    /// <summary>
    ///     frameHeaderOffset is the byte offset of the AV1 frame header OBU, as defined in section 5.9 of the AV1
    ///     Specification, within the video bitstream buffer range specified in VkVideoDecodeInfoKHR.
    /// </summary>
    public uint frameHeaderOffset;

    /// <summary>tileCount is the number of elements in pTileOffsets and pTileSizes.</summary>
    public uint tileCount;

    /// <summary>
    ///     pTileOffsets is a pointer to an array of tileCount integers specifying the byte offset of the tiles of the
    ///     picture within the video bitstream buffer range specified in VkVideoDecodeInfoKHR.
    /// </summary>
    public uint* pTileOffsets;

    /// <summary>
    ///     pTileSizes is a pointer to an array of tileCount integers specifying the byte size of the tiles of the picture
    ///     within the video bitstream buffer range specified in VkVideoDecodeInfoKHR.
    /// </summary>
    public uint* pTileSizes;
}