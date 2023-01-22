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
///     VkOpticalFlowSessionBindingPointNV - Binding points of an optical flow session -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionBindingPointNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkOpticalFlowSessionBindingPointNV.html
///     </a>
/// </summary>
public enum VkOpticalFlowSessionBindingPointNV
{
    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowSessionBindingPointNV">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkOpticalFlowSessionBindingPointNV
    ///     </a>
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV = 0,

    /// <summary>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV specifies the binding point for the input frame.</summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV = 1,

    /// <summary>VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV specifies the binding point for the input reference frame.</summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV = 2,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV specifies the binding point for the optional external hint flow
    ///     vectors.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV = 3,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV specifies the binding point for output flow vectors of
    ///     default forward flow calcution.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV = 4,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NVspecifies the binding point for the optional
    ///     output flow vector map of optional backward flow calcution.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV = 5,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV specifies the binding point for the optional output cost map of
    ///     default forward flow calcution.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV = 6,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV specifies the binding point for the optional output
    ///     cost map of optional backward flow calcution.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV = 7,

    /// <summary>
    ///     VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV specifies the binding point for the optional global flow
    ///     value of default forward flow calcution.
    /// </summary>
    VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV = 8
}