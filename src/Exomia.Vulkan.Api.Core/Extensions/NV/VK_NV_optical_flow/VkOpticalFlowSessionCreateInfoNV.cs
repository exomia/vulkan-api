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
///     VkOpticalFlowSessionCreateInfoNV - Structure specifying parameters of a newly created optical flow session -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>width is the width in pixels of the input or reference frame to be bound to this optical flow session.</summary>
    public uint width;

    /// <summary>height is the height in pixels of the input or reference frame to be bound to this optical flow session.</summary>
    public uint height;

    /// <summary>imageFormat is the VkFormat of the input and reference frame to be bound to this optical flow session.</summary>
    public VkFormat imageFormat;

    /// <summary>
    ///     flowVectorFormat is the VkFormat of the flow vector maps (output or hint) to be bound to this optical flow
    ///     session.
    /// </summary>
    public VkFormat flowVectorFormat;

    /// <summary>costFormat is the VkFormat of the cost maps to be bound to this optical flow session.</summary>
    public VkFormat costFormat;

    /// <summary>
    ///     outputGridSize is exactly one bit of VkOpticalFlowGridSizeFlagsNV specifying the grid size of the output flow
    ///     and cost maps to be bound to this optical flow session. The size of the output flow and cost maps is determined by
    ///     VkOpticalFlowSessionCreateInfoNV::width and VkOpticalFlowSessionCreateInfoNV::height divided by
    ///     VkOpticalFlowSessionCreateInfoNV::outputGridSize.
    /// </summary>
    public VkOpticalFlowGridSizeFlagsNV outputGridSize;

    /// <summary>
    ///     hintGridSize is one exactly bit of VkOpticalFlowGridSizeFlagsNV specifying the grid size of the hint flow
    ///     vector maps to be bound to this optical flow session. The size of the hint maps is determined by
    ///     VkOpticalFlowSessionCreateInfoNV::width and VkOpticalFlowSessionCreateInfoNV::height divided by
    ///     VkOpticalFlowSessionCreateInfoNV::hintGridSize.
    /// </summary>
    public VkOpticalFlowGridSizeFlagsNV hintGridSize;

    /// <summary>performanceLevel is the VkOpticalFlowPerformanceLevelNV used for this optical flow session.</summary>
    public VkOpticalFlowPerformanceLevelNV performanceLevel;

    /// <summary>flags are the VkOpticalFlowSessionCreateFlagsNV used for this optical flow session.</summary>
    public VkOpticalFlowSessionCreateFlagsNV flags;
}