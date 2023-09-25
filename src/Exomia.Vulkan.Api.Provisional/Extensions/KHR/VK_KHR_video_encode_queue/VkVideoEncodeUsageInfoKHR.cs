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
///     VkVideoEncodeUsageInfoKHR - Structure specifying video encode usage information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeUsageInfoKHR.html</a>
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
public unsafe struct VkVideoEncodeUsageInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     videoUsageHints is a bitmask of VkVideoEncodeUsageFlagBitsKHR specifying hints about the intended use of the
    ///     video encode profile.
    /// </summary>
    public VkVideoEncodeUsageFlagsKHR videoUsageHints;

    /// <summary>
    ///     videoContentHints is a bitmask of VkVideoEncodeContentFlagBitsKHR specifying hints about the content to be
    ///     encoded using the video encode profile.
    /// </summary>
    public VkVideoEncodeContentFlagsKHR videoContentHints;

    /// <summary>
    ///     tuningMode is a VkVideoEncodeTuningModeKHR value specifying the tuning mode to use when encoding with the
    ///     video profile.
    /// </summary>
    public VkVideoEncodeTuningModeKHR tuningMode;
}