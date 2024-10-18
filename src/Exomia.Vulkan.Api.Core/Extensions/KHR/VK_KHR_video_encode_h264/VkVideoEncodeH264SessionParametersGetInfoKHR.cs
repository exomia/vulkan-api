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
///     VkVideoEncodeH264SessionParametersGetInfoKHR - Structure specifying parameters for retrieving encoded H.264
///     parameter set data -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersGetInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH264SessionParametersGetInfoKHR.html
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
public unsafe struct VkVideoEncodeH264SessionParametersGetInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     writeStdSPS indicates whether the encoded H.264 sequence parameter set identified by stdSPSId is requested to
    ///     be retrieved.
    /// </summary>
    public VkBool32 writeStdSPS;

    /// <summary>
    ///     writeStdPPS indicates whether the encoded H.264 picture parameter set identified by the pair constructed from
    ///     stdSPSId and stdPPSId is requested to be retrieved.
    /// </summary>
    public VkBool32 writeStdPPS;

    /// <summary>
    ///     stdSPSId specifies the H.264 sequence parameter set ID used to identify the retrieved H.264 sequence and/or
    ///     picture parameter set(s).
    /// </summary>
    public uint stdSPSId;

    /// <summary>
    ///     stdPPSId specifies the H.264 picture parameter set ID used to identify the retrieved H.264 picture parameter
    ///     set when writeStdPPS is VK_TRUE.
    /// </summary>
    public uint stdPPSId;
}