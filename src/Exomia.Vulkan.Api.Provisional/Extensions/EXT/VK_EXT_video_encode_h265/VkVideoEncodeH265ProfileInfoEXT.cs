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
///     VkVideoEncodeH265ProfileInfoEXT - Structure specifying H.265 encode profile -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265ProfileInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265ProfileInfoEXT.html
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
public unsafe struct VkVideoEncodeH265ProfileInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stdProfileIdc is a StdVideoH265ProfileIdc value specifying the H.265 codec profile IDC.</summary>
    public StdVideoH265ProfileIdc stdProfileIdc;
}