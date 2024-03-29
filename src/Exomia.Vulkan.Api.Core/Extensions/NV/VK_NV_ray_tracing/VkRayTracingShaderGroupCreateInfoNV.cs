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
///     VkRayTracingShaderGroupCreateInfoNV - Structure specifying shaders in a shader group -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRayTracingShaderGroupCreateInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRayTracingShaderGroupCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>type is the type of hit group specified in this structure.</summary>
    public VkRayTracingShaderGroupTypeKHR type;

    /// <summary>
    ///     generalShader is the index of the ray generation, miss, or callable shader from
    ///     VkRayTracingPipelineCreateInfoNV::pStages in the group if the shader group has type of
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_NV, and VK_SHADER_UNUSED_NV otherwise.
    /// </summary>
    public uint generalShader;

    /// <summary>
    ///     closestHitShader is the optional index of the closest hit shader from
    ///     VkRayTracingPipelineCreateInfoNV::pStages in the group if the shader group has type of
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV or
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV, and VK_SHADER_UNUSED_NV otherwise.
    /// </summary>
    public uint closestHitShader;

    /// <summary>
    ///     anyHitShader is the optional index of the any-hit shader from VkRayTracingPipelineCreateInfoNV::pStages in the
    ///     group if the shader group has type of VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_NV or
    ///     VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV, and VK_SHADER_UNUSED_NV otherwise.
    /// </summary>
    public uint anyHitShader;

    /// <summary>
    ///     intersectionShader is the index of the intersection shader from VkRayTracingPipelineCreateInfoNV::pStages in
    ///     the group if the shader group has type of VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_NV, and
    ///     VK_SHADER_UNUSED_NV otherwise.
    /// </summary>
    public uint intersectionShader;
}