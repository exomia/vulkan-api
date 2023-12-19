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
///     VkVideoEncodeH265SessionParametersFeedbackInfoKHR - Structure providing feedback about the requested H.265 video
///     session parameters -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersFeedbackInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVideoEncodeH265SessionParametersFeedbackInfoKHR.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkVideoEncodeSessionParametersFeedbackInfoKHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkVideoEncodeSessionParametersFeedbackInfoKHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     hasStdVPSOverrides indicates whether any of the parameters of the requested H.265 video parameter set, if one
    ///     was requested via VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdVPS, were overridden by the implementation.
    /// </summary>
    public VkBool32 hasStdVPSOverrides;

    /// <summary>
    ///     hasStdSPSOverrides indicates whether any of the parameters of the requested H.265 sequence parameter set, if
    ///     one was requested via VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdSPS, were overridden by the
    ///     implementation.
    /// </summary>
    public VkBool32 hasStdSPSOverrides;

    /// <summary>
    ///     hasStdPPSOverrides indicates whether any of the parameters of the requested H.265 picture parameter set, if
    ///     one was requested via VkVideoEncodeH265SessionParametersGetInfoKHR::writeStdPPS, were overridden by the
    ///     implementation.
    /// </summary>
    public VkBool32 hasStdPPSOverrides;
}