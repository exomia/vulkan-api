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
///     VkPipelineDynamicStateCreateInfo - Structure specifying parameters of a newly created pipeline dynamic state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDynamicStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineDynamicStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDynamicStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkPipelineDynamicStateCreateFlags flags;

    /// <summary> dynamicStateCount is the number of elements in the pDynamicStates array. </summary>
    public uint dynamicStateCount;

    /// <summary> pDynamicStates is a pointer to an array of VkDynamicStatevalues specifying which pieces of pipeline state will use the values from dynamic state commands rather than from pipeline state creation information. </summary>
    public VkDynamicState* pDynamicStates;
}