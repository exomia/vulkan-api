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
///     VkLatencySleepInfoNV - Structure specifying the parameters of vkLatencySleepNV -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySleepInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySleepInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLatencySleepInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LATENCY_SLEEP_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     signalSemaphore is a semaphore that is signaled to indicate that the application should resume input sampling
    ///     work.
    /// </summary>
    public VkSemaphore signalSemaphore;

    /// <summary>value is the value that signalSemaphore is set to for resuming sampling work.</summary>
    public ulong value;
}