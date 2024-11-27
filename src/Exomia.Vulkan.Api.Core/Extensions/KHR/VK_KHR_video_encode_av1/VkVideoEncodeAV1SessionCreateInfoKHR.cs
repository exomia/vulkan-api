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
///     VkVideoEncodeAV1SessionCreateInfoKHR - Structure specifies AV1 encode session parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionCreateInfoKHR.html
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
public unsafe struct VkVideoEncodeAV1SessionCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     useMaxLevel indicates whether the value of maxLevel should be used by the implementation. When it is set to
    ///     VK_FALSE, the implementation ignores the value of maxLevel and uses the value of
    ///     VkVideoEncodeAV1CapabilitiesKHR::maxLevel, as reported by vkGetPhysicalDeviceVideoCapabilitiesKHR for the video
    ///     profile.
    /// </summary>
    public VkBool32 useMaxLevel;

    /// <summary>
    ///     maxLevel is a StdVideoAV1Level value specifying the upper bound on the AV1 level for the video bitstreams
    ///     produced by the created video session.
    /// </summary>
    public StdVideoAV1Level maxLevel;
}