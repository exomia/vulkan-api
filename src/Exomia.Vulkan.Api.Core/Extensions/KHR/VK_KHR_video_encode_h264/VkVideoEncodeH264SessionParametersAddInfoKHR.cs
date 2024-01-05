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
///     VkVideoEncodeH264SessionParametersAddInfoKHR - Structure specifies H.264 encoder parameter set information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersAddInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersAddInfoKHR.html
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
public unsafe struct VkVideoEncodeH264SessionParametersAddInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stdSPSCount is the number of elements in the pStdSPSs array.</summary>
    public uint stdSPSCount;

    /// <summary>
    ///     pStdSPSs is a pointer to an array of StdVideoH264SequenceParameterSet structures describing the H.264 SPS
    ///     entries to add.
    /// </summary>
    public StdVideoH264SequenceParameterSet* pStdSPSs;

    /// <summary>stdPPSCount is the number of elements in the pStdPPSs array.</summary>
    public uint stdPPSCount;

    /// <summary>
    ///     pStdPPSs is a pointer to an array of StdVideoH264PictureParameterSet structures describing the H.264 PPS
    ///     entries to add.
    /// </summary>
    public StdVideoH264PictureParameterSet* pStdPPSs;
}