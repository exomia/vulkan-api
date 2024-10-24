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
///     VkVideoDecodeAV1ProfileInfoKHR - Structure specifying AV1 decode profile -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1ProfileInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeAV1ProfileInfoKHR.html</a>
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
public unsafe struct VkVideoDecodeAV1ProfileInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_AV1_PROFILE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stdProfile is a StdVideoAV1Profile value specifying the AV1 codec profile, as defined in section A.2 of the
    ///     AV1 Specification.
    /// </summary>
    public StdVideoAV1Profile stdProfile;

    /// <summary>
    ///     filmGrainSupport specifies whether AV1 film grain, as defined in section 7.8.3 of the AV1 Specification, can
    ///     be used with the video profile. When this member is VK_TRUE, video session objects created against the video
    ///     profile will be able to decode pictures that have film grain enabled.
    /// </summary>
    public VkBool32 filmGrainSupport;
}