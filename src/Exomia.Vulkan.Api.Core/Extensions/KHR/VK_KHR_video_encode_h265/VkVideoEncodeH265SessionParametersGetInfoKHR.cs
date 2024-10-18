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
///     VkVideoEncodeH265SessionParametersGetInfoKHR - Structure specifying parameters for retrieving encoded H.265
///     parameter set data -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersGetInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersGetInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeSessionParametersGetInfoKHR</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeSessionParametersGetInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionParametersGetInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     writeStdVPS indicates whether the encoded H.265 video parameter set identified by stdVPSId is requested to be
    ///     retrieved.
    /// </summary>
    public VkBool32 writeStdVPS;

    /// <summary>
    ///     writeStdSPS indicates whether the encoded H.265 sequence parameter set identified by the pair constructed from
    ///     stdVPSId and stdSPSId is requested to be retrieved.
    /// </summary>
    public VkBool32 writeStdSPS;

    /// <summary>
    ///     writeStdPPS indicates whether the encoded H.265 picture parameter set identified by the triplet constructed
    ///     from stdVPSId, stdSPSId, and stdPPSId is requested to be retrieved.
    /// </summary>
    public VkBool32 writeStdPPS;

    /// <summary>
    ///     stdVPSId specifies the H.265 video parameter set ID used to identify the retrieved H.265 video, sequence,
    ///     and/or picture parameter set(s).
    /// </summary>
    public uint stdVPSId;

    /// <summary>
    ///     stdSPSId specifies the H.265 sequence parameter set ID used to identify the retrieved H.265 sequence and/or
    ///     picture parameter set(s) when writeStdSPS and/or writeStdPPS is VK_TRUE.
    /// </summary>
    public uint stdSPSId;

    /// <summary>
    ///     stdPPSId specifies the H.265 picture parameter set ID used to identify the retrieved H.265 picture parameter
    ///     set when writeStdPPS is VK_TRUE.
    /// </summary>
    public uint stdPPSId;
}