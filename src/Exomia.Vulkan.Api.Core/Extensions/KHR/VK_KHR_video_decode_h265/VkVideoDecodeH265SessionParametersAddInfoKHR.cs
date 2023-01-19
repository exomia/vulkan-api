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
///     VkVideoDecodeH265SessionParametersAddInfoKHR - Structure specifies H.265 decoder parameter set information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersAddInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoDecodeH265SessionParametersAddInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoSessionParametersUpdateInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoSessionParametersUpdateInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stdVPSCount is the number of elements in the pStdVPSs array.</summary>
    public uint stdVPSCount;

    /// <summary>
    ///     pStdVPSs is a pointer to an array of StdVideoH265VideoParameterSet structures describing the H.265 VPS entries
    ///     to add.
    /// </summary>
    public StdVideoH265VideoParameterSet* pStdVPSs;

    /// <summary>stdSPSCount is the number of elements in the pStdSPSs array.</summary>
    public uint stdSPSCount;

    /// <summary>
    ///     pStdSPSs is a pointer to an array of StdVideoH265SequenceParameterSet structures describing the H.265 SPS
    ///     entries to add.
    /// </summary>
    public StdVideoH265SequenceParameterSet* pStdSPSs;

    /// <summary>stdPPSCount is the number of elements in the pStdPPSs array.</summary>
    public uint stdPPSCount;

    /// <summary>
    ///     pStdPPSs is a pointer to an array of StdVideoH265PictureParameterSet structures describing the H.265 PPS
    ///     entries to add.
    /// </summary>
    public StdVideoH265PictureParameterSet* pStdPPSs;
}