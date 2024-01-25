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
///     VkVideoEncodeH264PictureInfoKHR - Structure specifies H.264 encode frame parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264PictureInfoKHR.html
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
public unsafe struct VkVideoEncodeH264PictureInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>naluSliceEntryCount is the number of elements in pNaluSliceEntries.</summary>
    public uint naluSliceEntryCount;

    /// <summary>
    ///     pNaluSliceEntries is a pointer to an array of naluSliceEntryCount VkVideoEncodeH264NaluSliceInfoKHRstructures
    ///     specifying the parameters of the individual H.264 slices to encode for the input picture.
    /// </summary>
    public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;

    /// <summary>
    ///     pStdPictureInfo is a pointer to a StdVideoEncodeH264PictureInfo structure specifying H.264 picture
    ///     information.
    /// </summary>
    public StdVideoEncodeH264PictureInfo* pStdPictureInfo;

    /// <summary>
    ///     generatePrefixNalu controls whether prefix NALUs are generated before slice NALUs into the target bitstream,
    ///     as defined in sections 7.3.2.12 and 7.4.2.12 of the ITU-T H.264 Specification.
    /// </summary>
    public VkBool32 generatePrefixNalu;
}