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
///     VkOpticalFlowSessionCreateFlagBitsNV - Bits specifying flags for optical flow session -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionCreateFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkOpticalFlowSessionCreateFlagBitsNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV specifies that a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageView.html">VkImageView</a>
    ///     with external flow vectors will be used as hints in performing the motion search and must be bound to
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV = 0x1,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV specifies that the cost for the forward flow is generated in
    ///     a <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageView.html">VkImageView</a>
    ///     which must be bound to VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV. Additionally, if
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV is also set, the cost for backward flow is generated in a
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageView.html">VkImageView</a>
    ///     which must be bound to VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV. The cost is the confidence level of
    ///     the flow vector for each grid in the frame. The Cost implies how (in)accurate the flow vector is. Higher cost value
    ///     implies the flow vector to be less accurate and vice-versa.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV = 0x2,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV specifies that a global flow vector is estimated from
    ///     forward flow in a single pixel
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageView.html">VkImageView</a>
    ///     which must be bound to VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV = 0x4,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV specifies that regions of interest can be specified in
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowExecuteInfoNV.html">VkOpticalFlowExecuteInfoNV</a>
    ///     .
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV = 0x8,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV specifies that backward flow is generated in addition to
    ///     forward flow which is always generated.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV = 0x10
}