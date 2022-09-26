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
///     VkShaderStageFlagBits - Bitmask specifying a pipeline stage -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderStageFlagBits.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderStageFlagBits.html </a>
/// </summary>
[Flags]
public enum VkShaderStageFlagBits
{
    /// <summary> VK_SHADER_STAGE_VERTEX_BIT specifies the vertex stage. </summary>
    VK_SHADER_STAGE_VERTEX_BIT = 0x1,

    /// <summary> VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT specifies the tessellation control stage. </summary>
    VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = 0x2,

    /// <summary> VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT specifies the tessellation evaluation stage. </summary>
    VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = 0x4,

    /// <summary> VK_SHADER_STAGE_GEOMETRY_BIT specifies the geometry stage. </summary>
    VK_SHADER_STAGE_GEOMETRY_BIT = 0x8,

    /// <summary> VK_SHADER_STAGE_FRAGMENT_BIT specifies the fragment stage. </summary>
    VK_SHADER_STAGE_FRAGMENT_BIT = 0x10,

    /// <summary> VK_SHADER_STAGE_COMPUTE_BIT specifies the compute stage. </summary>
    VK_SHADER_STAGE_COMPUTE_BIT = 0x20,

    /// <summary> VK_SHADER_STAGE_ALL_GRAPHICS is a combination of bits used as shorthand to specify all graphics stages defined above (excluding the compute stage). </summary>
    VK_SHADER_STAGE_ALL_GRAPHICS = 0x0000001F,

    /// <summary> VK_SHADER_STAGE_ALL is a combination of bits used as shorthand to specify all shader stages supported by the device, including all additional stages which are introduced by extensions. </summary>
    VK_SHADER_STAGE_ALL = 0x7FFFFFFF,

    /// <summary> VK_SHADER_STAGE_RAYGEN_BIT_KHR specifies the ray generation stage. </summary>
    VK_SHADER_STAGE_RAYGEN_BIT_KHR = 0x100,

    /// <summary> VK_SHADER_STAGE_ANY_HIT_BIT_KHR specifies the any-hit stage. </summary>
    VK_SHADER_STAGE_ANY_HIT_BIT_KHR = 0x200,

    /// <summary> VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR specifies the closest hit stage. </summary>
    VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR = 0x400,

    /// <summary> VK_SHADER_STAGE_MISS_BIT_KHR specifies the miss stage. </summary>
    VK_SHADER_STAGE_MISS_BIT_KHR = 0x800,

    /// <summary> VK_SHADER_STAGE_INTERSECTION_BIT_KHR specifies the intersection stage. </summary>
    VK_SHADER_STAGE_INTERSECTION_BIT_KHR = 0x1000,

    /// <summary> VK_SHADER_STAGE_CALLABLE_BIT_KHR specifies the callable stage. </summary>
    VK_SHADER_STAGE_CALLABLE_BIT_KHR = 0x2000,

    /// <summary> VK_SHADER_STAGE_TASK_BIT_EXT specifies the task stage. </summary>
    VK_SHADER_STAGE_TASK_BIT_EXT = 0x40,

    /// <summary> VK_SHADER_STAGE_MESH_BIT_EXT specifies the mesh stage. </summary>
    VK_SHADER_STAGE_MESH_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits </a>
    /// </summary>
    VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI = 0x4000,

    /// <summary>
    ///     VK_SHADER_STAGE_EXT_483_RESERVE_15<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits </a>
    /// </summary>
    VK_SHADER_STAGE_EXT_483_RESERVE_15 = 0x8000,

    /// <summary>
    ///     VK_SHADER_STAGE_EXT_483_RESERVE_16<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits </a>
    /// </summary>
    VK_SHADER_STAGE_EXT_483_RESERVE_16 = 0x10000,

    /// <summary>
    ///     VK_SHADER_STAGE_EXT_483_RESERVE_17<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkShaderStageFlagBits </a>
    /// </summary>
    VK_SHADER_STAGE_EXT_483_RESERVE_17 = 0x20000,

    /// <summary> VK_SHADER_STAGE_RAYGEN_BIT_KHR specifies the ray generation stage. </summary>
    VK_SHADER_STAGE_RAYGEN_BIT_NV = VK_SHADER_STAGE_RAYGEN_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_ANY_HIT_BIT_KHR specifies the any-hit stage. </summary>
    VK_SHADER_STAGE_ANY_HIT_BIT_NV = VK_SHADER_STAGE_ANY_HIT_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR specifies the closest hit stage. </summary>
    VK_SHADER_STAGE_CLOSEST_HIT_BIT_NV = VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_MISS_BIT_KHR specifies the miss stage. </summary>
    VK_SHADER_STAGE_MISS_BIT_NV = VK_SHADER_STAGE_MISS_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_INTERSECTION_BIT_KHR specifies the intersection stage. </summary>
    VK_SHADER_STAGE_INTERSECTION_BIT_NV = VK_SHADER_STAGE_INTERSECTION_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_CALLABLE_BIT_KHR specifies the callable stage. </summary>
    VK_SHADER_STAGE_CALLABLE_BIT_NV = VK_SHADER_STAGE_CALLABLE_BIT_KHR,

    /// <summary> VK_SHADER_STAGE_TASK_BIT_EXT specifies the task stage. </summary>
    VK_SHADER_STAGE_TASK_BIT_NV = VK_SHADER_STAGE_TASK_BIT_EXT,

    /// <summary> VK_SHADER_STAGE_MESH_BIT_EXT specifies the mesh stage. </summary>
    VK_SHADER_STAGE_MESH_BIT_NV = VK_SHADER_STAGE_MESH_BIT_EXT
}