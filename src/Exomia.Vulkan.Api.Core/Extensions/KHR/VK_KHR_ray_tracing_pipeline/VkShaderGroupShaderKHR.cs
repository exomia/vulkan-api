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
///     VkShaderGroupShaderKHR - Shader group shaders -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderGroupShaderKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderGroupShaderKHR.html</a>
/// </summary>
public enum VkShaderGroupShaderKHR
{
    /// <summary>
    ///     VK_SHADER_GROUP_SHADER_GENERAL_KHR uses the shader specified in the group with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoKHR.html">
    ///         VkRayTracingShaderGroupCreateInfoKHR
    ///     </a>
    ///     ::generalShader
    /// </summary>
    VK_SHADER_GROUP_SHADER_GENERAL_KHR = 0,

    /// <summary>
    ///     VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR uses the shader specified in the group with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoKHR.html">
    ///         VkRayTracingShaderGroupCreateInfoKHR
    ///     </a>
    ///     ::closestHitShader
    /// </summary>
    VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR = 1,

    /// <summary>
    ///     VK_SHADER_GROUP_SHADER_ANY_HIT_KHR uses the shader specified in the group with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoKHR.html">
    ///         VkRayTracingShaderGroupCreateInfoKHR
    ///     </a>
    ///     ::anyHitShader
    /// </summary>
    VK_SHADER_GROUP_SHADER_ANY_HIT_KHR = 2,

    /// <summary>
    ///     VK_SHADER_GROUP_SHADER_INTERSECTION_KHR uses the shader specified in the group with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoKHR.html">
    ///         VkRayTracingShaderGroupCreateInfoKHR
    ///     </a>
    ///     ::intersectionShader
    /// </summary>
    VK_SHADER_GROUP_SHADER_INTERSECTION_KHR = 3
}