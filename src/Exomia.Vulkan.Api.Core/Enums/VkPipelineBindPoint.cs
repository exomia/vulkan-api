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
///     VkPipelineBindPoint - Specify the bind point of a pipeline object to a command buffer -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBindPoint.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineBindPoint.html </a>
/// </summary>
public enum VkPipelineBindPoint
{
    /// <summary> VK_PIPELINE_BIND_POINT_GRAPHICS specifies binding as a graphics pipeline. </summary>
    VK_PIPELINE_BIND_POINT_GRAPHICS = 0,

    /// <summary> VK_PIPELINE_BIND_POINT_COMPUTE specifies binding as a compute pipeline. </summary>
    VK_PIPELINE_BIND_POINT_COMPUTE = 1,

    /// <summary> VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR specifies binding as a ray tracing pipeline. </summary>
    VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR = 1000165000,

    /// <summary> VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI specifies binding as a subpass shading pipeline. </summary>
    VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI = 1000369003,

    /// <summary> VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR specifies binding as a ray tracing pipeline. </summary>
    VK_PIPELINE_BIND_POINT_RAY_TRACING_NV = VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR
}