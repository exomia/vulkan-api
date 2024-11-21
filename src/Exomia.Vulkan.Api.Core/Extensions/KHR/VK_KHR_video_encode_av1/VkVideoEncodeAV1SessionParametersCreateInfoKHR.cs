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
///     VkVideoEncodeAV1SessionParametersCreateInfoKHR - Structure specifies AV1 encoder parameter set information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionParametersCreateInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeAV1SessionParametersCreateInfoKHR.html
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
public unsafe struct VkVideoEncodeAV1SessionParametersCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_AV1_SESSION_PARAMETERS_CREATE_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pStdSequenceHeader is a pointer to a StdVideoAV1SequenceHeader structure describing parameters of the AV1
    ///     sequence header entry to store in the created object.
    /// </summary>
    public StdVideoAV1SequenceHeader* pStdSequenceHeader;

    /// <summary>
    ///     pStdDecoderModelInfo is NULL or a pointer to a StdVideoEncodeAV1DecoderModelInfo structure specifying the AV1
    ///     decoder model information to store in the created object.
    /// </summary>
    public StdVideoEncodeAV1DecoderModelInfo* pStdDecoderModelInfo;

    /// <summary>stdOperatingPointCount is the number of elements in the pStdOperatingPoints array.</summary>
    public uint stdOperatingPointCount;

    /// <summary>
    ///     pStdOperatingPoints is NULL or a pointer to an array of stdOperatingPointCount number of
    ///     StdVideoEncodeAV1OperatingPointInfo structures specifying the AV1 operating point information to store in the
    ///     created object. Each element i specifies the parameter values corresponding to element i of the syntax elements
    ///     defined in section 6.4 of the AV1 Specification.
    /// </summary>
    public StdVideoEncodeAV1OperatingPointInfo* pStdOperatingPoints;
}