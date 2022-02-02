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
///     VkShaderStatisticsInfoAMD - Statistical information about a particular shader within a pipeline -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderStatisticsInfoAMD.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderStatisticsInfoAMD.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkShaderStatisticsInfoAMD
{
    /// <summary>shaderStageMask are the combination of logical shader stages contained within this shader.</summary>
    public VkShaderStageFlags shaderStageMask;

    /// <summary>
    ///     resourceUsage is a VkShaderResourceUsageAMD structure describing internal physical device resources used by
    ///     this shader.
    /// </summary>
    public VkShaderResourceUsageAMD resourceUsage;

    /// <summary>
    ///     numPhysicalVgprs is the maximum number of vector instruction general-purpose registers (VGPRs) available to
    ///     the physical device.
    /// </summary>
    public uint numPhysicalVgprs;

    /// <summary>
    ///     numPhysicalSgprs is the maximum number of scalar instruction general-purpose registers (SGPRs) available to
    ///     the physical device.
    /// </summary>
    public uint numPhysicalSgprs;

    /// <summary>numAvailableVgprs is the maximum limit of VGPRs made available to the shader compiler.</summary>
    public uint numAvailableVgprs;

    /// <summary>numAvailableSgprs is the maximum limit of SGPRs made available to the shader compiler.</summary>
    public uint numAvailableSgprs;

    /// <summary>computeWorkGroupSize is the local workgroup size of this shader in { X, Y, Z } dimensions.</summary>
    public VkArray3<uint> computeWorkGroupSize;
}