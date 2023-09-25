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
///     VkVideoEncodeH264SessionParametersAddInfoEXT - Structure specifies H.264 encoder parameter set information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersAddInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersAddInfoEXT.html
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
public unsafe struct VkVideoEncodeH264SessionParametersAddInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stdSPSCount is the number of SPS elements in the pStdSPSs. Its value must be less than or equal to the value
    ///     of maxStdSPSCount.
    /// </summary>
    public uint stdSPSCount;

    /// <summary>
    ///     pStdSPSs is a pointer to an array of StdVideoH264SequenceParameterSet structures representing H.264 sequence
    ///     parameter sets. Each element of the array must have a unique H.264 SPS ID.
    /// </summary>
    public StdVideoH264SequenceParameterSet* pStdSPSs;

    /// <summary>
    ///     stdPPSCount is the number of PPS provided in pStdPPSs. Its value must be less than or equal to the value of
    ///     maxStdPPSCount.
    /// </summary>
    public uint stdPPSCount;

    /// <summary>
    ///     pStdPPSs is a pointer to an array of StdVideoH264PictureParameterSet structures representing H.264 picture
    ///     parameter sets. Each element of the array must have a unique H.264 SPS-PPS ID pair.
    /// </summary>
    public StdVideoH264PictureParameterSet* pStdPPSs;
}