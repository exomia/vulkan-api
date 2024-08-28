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
///     VkSetLatencyMarkerInfoNV - Structure specifying the parameters of vkSetLatencyMarkerNV -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetLatencyMarkerInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSetLatencyMarkerInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSetLatencyMarkerInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     presentID is an application provided value that is used to associate the timestamp with a vkQueuePresentKHR
    ///     command using VkPresentIdKHR::pPresentIds for a given present.
    /// </summary>
    public ulong presentID;

    /// <summary>marker is the type of timestamp to be recorded.</summary>
    public VkLatencyMarkerNV marker;
}