#region License

// Copyright (c) 2018-2022, exomia
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
///     VkVideoDecodeH264SessionParametersCreateInfoKHR - Structure specifies H.264 decoder parameter set information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionParametersCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH264SessionParametersCreateInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoSessionParametersCreateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoSessionParametersCreateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxStdSPSCount is the maximum number of H.264 SPS entries the created VkVideoSessionParametersKHR cancontain.</summary>
    public uint maxStdSPSCount;

    /// <summary>maxStdPPSCount is the maximum number of H.264 PPS entries the created VkVideoSessionParametersKHR cancontain.</summary>
    public uint maxStdPPSCount;

    /// <summary>
    ///     pParametersAddInfo is NULL or a pointer to a VkVideoDecodeH264SessionParametersAddInfoKHR structure specifying
    ///     H.264 parameters to add upon object creation.
    /// </summary>
    public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
}