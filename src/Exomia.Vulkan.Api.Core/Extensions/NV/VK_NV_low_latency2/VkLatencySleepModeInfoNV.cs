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
///     VkLatencySleepModeInfoNV - Structure to set low latency mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySleepModeInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySleepModeInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLatencySleepModeInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LATENCY_SLEEP_MODE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>lowLatencyMode is the toggle to enable or disable low latency mode.</summary>
    public VkBool32 lowLatencyMode;

    /// <summary>
    ///     lowLatencyBoost allows an application to hint to the GPU to increase performance to provide additional latency
    ///     savings at a cost of increased power consumption.
    /// </summary>
    public VkBool32 lowLatencyBoost;

    /// <summary>
    ///     minimumIntervalUs is the microseconds between vkQueuePresentKHR calls for a given swapchain that
    ///     vkLatencySleepNV will enforce.
    /// </summary>
    public uint minimumIntervalUs;
}