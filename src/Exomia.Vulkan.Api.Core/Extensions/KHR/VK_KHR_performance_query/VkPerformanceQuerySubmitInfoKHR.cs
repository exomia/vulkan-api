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
///     VkPerformanceQuerySubmitInfoKHR - Structure indicating which counter pass index is active for performance
///     queries -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceQuerySubmitInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPerformanceQuerySubmitInfoKHR.html
///     </a>
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
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>counterPassIndex specifies which counter pass index is active.</summary>
    public uint counterPassIndex;
}