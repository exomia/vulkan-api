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
///     VkVideoEncodeH265SessionCreateInfoKHR - Structure specifies H.265 encode session parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionCreateInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoSessionCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoSessionCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useMaxLevelIdc indicates whether the value of maxLevelIdcshould be used by the implementation. When it is set
    ///     to VK_FALSE, the implementation ignores the value of maxLevelIdc and uses the value of
    ///     VkVideoEncodeH265CapabilitiesKHR::maxLevelIdc, as reported by vkGetPhysicalDeviceVideoCapabilitiesKHR for the video
    ///     profile.
    /// </summary>
    public VkBool32 useMaxLevelIdc;

    /// <summary>
    ///     maxLevelIdc is a StdVideoH265LevelIdc value specifying the upper bound on the H.265 level for the video
    ///     bitstreams produced by the created video session, where enum constant STD_VIDEO_H265_LEVEL_IDC_&lt;major&gt;_&lt;
    ///     minor&gt; identifies H.265 level &lt;major&gt;.&lt;minor&gt; as defined in section A.4 of the ITU-T H.265
    ///     Specification.
    /// </summary>
    public StdVideoH265LevelIdc maxLevelIdc;
}