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
///     VkGetLatencyMarkerInfoNV - Structure specifying the parameters of vkGetLatencyTimingsNV -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGetLatencyMarkerInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGetLatencyMarkerInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGetLatencyMarkerInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GET_LATENCY_MARKER_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is either NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     timingCount is an integer related to the number of of previous frames of latency data available or queried, as
    ///     described below.
    /// </summary>
    public uint timingCount;

    /// <summary>pTimings is either NULL or a pointer to an array of VkLatencyTimingsFrameReportNV structures.</summary>
    public VkLatencyTimingsFrameReportNV* pTimings;
}