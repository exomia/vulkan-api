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
///     VkVideoEncodeH264SessionCreateInfoEXT - Structure specifies H.264 encode session parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionCreateInfoEXT.html
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
public unsafe struct VkVideoEncodeH264SessionCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useMaxLevelIdc indicates whether the value of maxLevelIdcshould be used by the implementation. When it is set
    ///     to VK_FALSE, the implementation ignores the value of maxLevelIdc and uses the value of
    ///     VkVideoEncodeH264CapabilitiesEXT::maxLevelIdc, as reported by vkGetPhysicalDeviceVideoCapabilitiesKHR for the video
    ///     profile.
    /// </summary>
    public VkBool32 useMaxLevelIdc;

    /// <summary>
    ///     maxLevelIdc provides the upper bound on the H.264 level for the video bitstreams produced by the created video
    ///     session.
    /// </summary>
    public StdVideoH264LevelIdc maxLevelIdc;
}