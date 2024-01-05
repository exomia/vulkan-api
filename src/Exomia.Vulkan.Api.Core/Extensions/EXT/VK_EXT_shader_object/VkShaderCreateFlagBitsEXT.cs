#region License

// Copyright (c) 2018-2024, exomia
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
///     VkShaderCreateFlagBitsEXT - Bitmask controlling how a shader object is created -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCreateFlagBitsEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCreateFlagBitsEXT.html</a>
/// </summary>
[Flags]
public enum VkShaderCreateFlagBitsEXT
{
    /// <summary>
    ///     VK_SHADER_CREATE_LINK_STAGE_BIT_EXT specifies that a shader is linked to all other shaders created in the same
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCreateShadersEXT.html">vkCreateShadersEXT</a>
    ///     call whose
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCreateInfoEXT.html">VkShaderCreateInfoEXT</a>
    ///     structures' flags include VK_SHADER_CREATE_LINK_STAGE_BIT_EXT.
    /// </summary>
    VK_SHADER_CREATE_LINK_STAGE_BIT_EXT = 0x1,

    /// <summary>
    ///     VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT specifies     that the
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#interfaces-builtin-variables-sgs">
    ///         <code>SubgroupSize</code>
    ///     </a>
    ///     may    vary in a task, mesh, or     compute shader.
    /// </summary>
    VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = 0x2,

    /// <summary>
    ///     VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT specifies that the     subgroup sizes must be launched with
    ///     all invocations active in a task, mesh, or     compute shader.
    /// </summary>
    VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = 0x4,

    /// <summary>
    ///     VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT specifies that a mesh shader must only be used without a task shader.
    ///     Otherwise, the mesh shader must only be used with a task shader.
    /// </summary>
    VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT = 0x8,

    /// <summary>
    ///     VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT specifies that a compute shader can be used with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html">vkCmdDispatchBase</a>
    ///     with a non-zero base workgroup.
    /// </summary>
    VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT = 0x10,

    /// <summary>
    ///     VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXTspecifies that a fragment shader can be used with a
    ///     fragment shading rate attachment.
    /// </summary>
    VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT = 0x20,

    /// <summary>
    ///     VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT specifies that a fragment shader can be used with a
    ///     fragment density map attachment.
    /// </summary>
    VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x40
}