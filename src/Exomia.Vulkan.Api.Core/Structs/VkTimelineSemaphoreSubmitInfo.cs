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
///     VkTimelineSemaphoreSubmitInfo - Structure specifying signal and wait values for timeline semaphores -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTimelineSemaphoreSubmitInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkTimelineSemaphoreSubmitInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo,VkBindSparseInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo,VkBindSparseInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkTimelineSemaphoreSubmitInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>waitSemaphoreValueCount is the number of semaphore wait values specified in pWaitSemaphoreValues.</summary>
    public uint waitSemaphoreValueCount;

    /// <summary>
    ///     pWaitSemaphoreValues is a pointer to an array of waitSemaphoreValueCount values for the corresponding
    ///     semaphores in VkSubmitInfo::pWaitSemaphores to wait for.
    /// </summary>
    public ulong* pWaitSemaphoreValues;

    /// <summary>signalSemaphoreValueCount is the number of semaphore signal values specified in pSignalSemaphoreValues.</summary>
    public uint signalSemaphoreValueCount;

    /// <summary>
    ///     pSignalSemaphoreValues is a pointer to an array signalSemaphoreValueCount values for the corresponding
    ///     semaphores in VkSubmitInfo::pSignalSemaphores to set when signaled.
    /// </summary>
    public ulong* pSignalSemaphoreValues;
}