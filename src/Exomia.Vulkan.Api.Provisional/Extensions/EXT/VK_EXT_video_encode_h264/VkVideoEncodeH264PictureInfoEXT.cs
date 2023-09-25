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
///     VkVideoEncodeH264PictureInfoEXT - Structure specifies H.264 encode frame parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoEXT.html
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
public unsafe struct VkVideoEncodeH264PictureInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>naluSliceEntryCount is the number of slice NALUs in the frame.</summary>
    public uint naluSliceEntryCount;

    /// <summary>
    ///     pNaluSliceEntries is a pointer to an array of naluSliceEntryCount VkVideoEncodeH264NaluSliceInfoEXTstructures
    ///     specifying the division of the current picture into slices and the properties of these slices. This is an ordered
    ///     sequence; the NALUs are generated consecutively in VkVideoEncodeInfoKHR::dstBuffer in the same order as in this
    ///     array.
    /// </summary>
    public VkVideoEncodeH264NaluSliceInfoEXT* pNaluSliceEntries;

    /// <summary>
    ///     pStdPictureInfo is a pointer to a StdVideoEncodeH264PictureInfo structure specifying the syntax and other
    ///     codec-specific information from the H.264 specification associated with this picture. The information provided must
    ///     reflect the decoded picture marking operations that are applicable to this frame.
    /// </summary>
    public StdVideoEncodeH264PictureInfo* pStdPictureInfo;

    /// <summary>generatePrefixNalu controls whether prefix NALUs are generated before slice NALUs into the target bitstream.</summary>
    public VkBool32 generatePrefixNalu;
}