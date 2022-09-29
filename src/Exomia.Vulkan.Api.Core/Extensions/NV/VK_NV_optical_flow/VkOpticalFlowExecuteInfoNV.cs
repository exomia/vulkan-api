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
///     VkOpticalFlowExecuteInfoNV - Structure specifying parameters of a optical flow vector calculation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteInfoNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteInfoNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowExecuteInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags are the VkOpticalFlowExecuteFlagsNV used for this command.</summary>
    public VkOpticalFlowExecuteFlagsNV flags;

    /// <summary>regionCount is the number of regions of interest specified in pRegions.</summary>
    public uint regionCount;

    /// <summary>pRegions is a pointer to regionCount VkRect2D regions of interest.</summary>
    public VkRect2D* pRegions;
}