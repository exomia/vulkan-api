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
///     VkLatencySubmissionPresentIdNV - Structure used to associate a queueSubmit with a presentId -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySubmissionPresentIdNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkLatencySubmissionPresentIdNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubmitInfo,VkSubmitInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubmitInfo,VkSubmitInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkLatencySubmissionPresentIdNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_LATENCY_SUBMISSION_PRESENT_ID_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     presentId is used to associate the vkQueueSubmit with the presentId used for a given vkQueuePresentKHR via
    ///     VkPresentIdKHR::pPresentIds.
    /// </summary>
    public ulong presentID;
}