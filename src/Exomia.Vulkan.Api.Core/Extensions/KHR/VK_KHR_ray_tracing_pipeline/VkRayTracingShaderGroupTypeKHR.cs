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
///     VkRayTracingShaderGroupTypeKHR - Shader group types -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupTypeKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupTypeKHR.html</a>
/// </summary>
public enum VkRayTracingShaderGroupTypeKHR
{
    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR indicates a shader group with a single
    ///     VK_SHADER_STAGE_RAYGEN_BIT_KHR, VK_SHADER_STAGE_MISS_BIT_KHR, or VK_SHADER_STAGE_CALLABLE_BIT_KHR shader in it.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = 0,

    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR specifies a shader group that only hits triangles and
    ///     must not contain an intersection shader, only closest hit and any-hit shaders.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = 1,

    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHRspecifies a shader group that only intersects with
    ///     custom geometry and must contain an intersection shader and may contain closest hit and any-hit shaders.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = 2,

    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR indicates a shader group with a single
    ///     VK_SHADER_STAGE_RAYGEN_BIT_KHR, VK_SHADER_STAGE_MISS_BIT_KHR, or VK_SHADER_STAGE_CALLABLE_BIT_KHR shader in it.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR,

    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR specifies a shader group that only hits triangles and
    ///     must not contain an intersection shader, only closest hit and any-hit shaders.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR,

    /// <summary>
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHRspecifies a shader group that only intersects with
    ///     custom geometry and must contain an intersection shader and may contain closest hit and any-hit shaders.
    /// </summary>
    VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV = VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR
}