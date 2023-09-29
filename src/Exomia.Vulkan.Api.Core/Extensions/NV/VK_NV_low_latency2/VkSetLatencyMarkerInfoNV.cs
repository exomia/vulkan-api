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
///     VkSetLatencyMarkerInfoNV -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSetLatencyMarkerInfoNV">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkSetLatencyMarkerInfoNV</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSetLatencyMarkerInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SET_LATENCY_MARKER_INFO_NV;

    public VkStructureType sType;

    public void* pNext;

    public ulong presentID;

    public VkLatencyMarkerNV marker;
}