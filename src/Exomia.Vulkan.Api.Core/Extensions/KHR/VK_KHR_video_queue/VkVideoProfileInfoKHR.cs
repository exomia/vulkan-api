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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkVideoProfileInfoKHR - Structure specifying a video profile -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoProfileInfoKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkQueryPoolCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkQueryPoolCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>videoCodecOperation is a VkVideoCodecOperationFlagBitsKHRvalue specifying a video codec operation.</summary>
    public VkVideoCodecOperationFlagBitsKHR videoCodecOperation;

    /// <summary>
    ///     chromaSubsampling is a bitmask of VkVideoChromaSubsamplingFlagBitsKHR specifying video chroma subsampling
    ///     information.
    /// </summary>
    public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;

    /// <summary>lumaBitDepth is a bitmask of VkVideoComponentBitDepthFlagBitsKHR specifying video luma bit depth information.</summary>
    public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;

    /// <summary>
    ///     chromaBitDepth is a bitmask of VkVideoComponentBitDepthFlagBitsKHR specifying video chroma bit depth
    ///     information.
    /// </summary>
    public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
}