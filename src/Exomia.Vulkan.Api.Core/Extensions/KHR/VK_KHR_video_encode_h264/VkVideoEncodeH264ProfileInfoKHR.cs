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
///     VkVideoEncodeH264ProfileInfoKHR - Structure specifying H.264 encode-specific video profile parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264ProfileInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264ProfileInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoProfileInfoKHR,VkQueryPoolCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoProfileInfoKHR,VkQueryPoolCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH264ProfileInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stdProfileIdc is a StdVideoH264ProfileIdc value specifying the H.264 codec profile IDC, as defined in section
    ///     A.2 of the ITU-T H.264 Specification.
    /// </summary>
    public StdVideoH264ProfileIdc stdProfileIdc;
}