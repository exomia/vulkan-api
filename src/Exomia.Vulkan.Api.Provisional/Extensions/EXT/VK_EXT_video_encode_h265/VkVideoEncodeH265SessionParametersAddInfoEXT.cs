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
///     VkVideoEncodeH265SessionParametersAddInfoEXT - Structure specifies H.265 encoder parameter set info -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersAddInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersAddInfoEXT.html
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
public unsafe struct VkVideoEncodeH265SessionParametersAddInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>stdVPSCount is the number of VPS elements in pStdVPSs.</summary>
    public uint stdVPSCount;

    /// <summary>
    ///     pStdVPSs is a pointer to an array of stdVPSCountStdVideoH265VideoParameterSet structures representing H.265
    ///     video parameter sets.
    /// </summary>
    public StdVideoH265VideoParameterSet* pStdVPSs;

    /// <summary>stdSPSCount is the number of SPS elements in pStdSPSs.</summary>
    public uint stdSPSCount;

    /// <summary>
    ///     pStdSPSs is a pointer to an array of stdSPSCountStdVideoH265SequenceParameterSet structures representing H.265
    ///     sequence parameter sets.
    /// </summary>
    public StdVideoH265SequenceParameterSet* pStdSPSs;

    /// <summary>stdPPSCount is the number of PPS elements in pStdPPSs.</summary>
    public uint stdPPSCount;

    /// <summary>
    ///     pStdPPSs is a pointer to an array of stdPPSCountStdVideoH265PictureParameterSet structures representing H.265
    ///     picture parameter sets.
    /// </summary>
    public StdVideoH265PictureParameterSet* pStdPPSs;
}