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
///     VkQueryLowLatencySupportNV - Structure used for NVIDIA Reflex Support -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryLowLatencySupportNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryLowLatencySupportNV.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSemaphoreCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSemaphoreCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueryLowLatencySupportNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>pQueriedLowLatencyData is used for NVIDIA Reflex Support.</summary>
    public void* pQueriedLowLatencyData;
}