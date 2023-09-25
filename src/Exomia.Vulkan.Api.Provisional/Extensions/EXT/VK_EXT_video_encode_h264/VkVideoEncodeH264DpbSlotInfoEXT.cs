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
///     VkVideoEncodeH264DpbSlotInfoEXT - Structure specifies H.264 encode DPB picture information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264DpbSlotInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264DpbSlotInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoReferenceSlotInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoReferenceSlotInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264DpbSlotInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pStdReferenceInfo is a pointer to a StdVideoEncodeH264ReferenceInfo structure specifying the syntax and other
    ///     codec-specific information from the H.264 specification associated with this reference picture.
    /// </summary>
    public StdVideoEncodeH264ReferenceInfo* pStdReferenceInfo;
}