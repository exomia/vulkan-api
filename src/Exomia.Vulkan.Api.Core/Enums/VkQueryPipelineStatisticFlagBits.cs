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
///     VkQueryPipelineStatisticFlagBits - Bitmask specifying queried pipeline statistics -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPipelineStatisticFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkQueryPipelineStatisticFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkQueryPipelineStatisticFlagBits
{
    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT specifies that queries managed by the pool will count
    ///     the number of vertices processed by the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing">input assembly</a>
    ///     stage. Vertices corresponding to incomplete primitives may contribute to the count.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT = 0x1,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BITspecifies that queries managed by the pool will count
    ///     the number of primitives processed by the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#drawing">input assembly</a>
    ///     stage. If primitive restart is enabled, restarting the primitive topology has no effect on the count. Incomplete
    ///     primitives may be counted.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT = 0x2,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BITspecifies that queries managed by the pool will count
    ///     the number of vertex shader invocations. This counter&#8217;s value is incremented each time a vertex shader is
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shaders-vertex-execution">invoked</a>
    ///     .
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT = 0x4,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BITspecifies that queries managed by the pool will count
    ///     the number of geometry shader invocations. This counter&#8217;s value is incremented each time a geometry shader is
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shaders-geometry-execution">invoked</a>
    ///     . In the case of
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#geometry-invocations">
    ///         instanced
    ///         geometry shaders
    ///     </a>
    ///     , the geometry shader invocations count is incremented for each separate instanced
    ///     invocation.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT = 0x8,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BITspecifies that queries managed by the pool will
    ///     count the number of primitives generated by geometry shader invocations. The counter&#8217;s value is incremented
    ///     each time the geometry shader emits a primitive. Restarting primitive topology using the SPIR-V instructions
    ///     OpEndPrimitive or OpEndStreamPrimitive has no effect on the geometry shader output primitives count.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT = 0x10,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT specifies that queries managed by the pool will count the
    ///     number of primitives processed by the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#vertexpostproc-clipping">
    ///         Primitive
    ///         Clipping
    ///     </a>
    ///     stage of the pipeline. The counter&#8217;s value is incremented each time a primitive reaches the
    ///     primitive clipping stage.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT = 0x20,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT specifies that queries managed by the pool will count the
    ///     number of primitives output by the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#vertexpostproc-clipping">
    ///         Primitive
    ///         Clipping
    ///     </a>
    ///     stage of the pipeline. The counter&#8217;s value is incremented each time a primitive passes the
    ///     primitive clipping stage. The actual number of primitives output by the primitive clipping stage for a particular
    ///     input primitive is implementation-dependent but mustsatisfy the following conditions:<br />
    ///     If at least one vertex of the input primitive lies inside the clipping volume, the counter is incremented by one or
    ///     more.<br />
    ///     Otherwise, the counter is incremented by zero or more.<br />
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT = 0x40,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BITspecifies that queries managed by the pool will
    ///     count the number of fragment shader invocations. The counter&#8217;s value is incremented each time the fragment
    ///     shader is
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#fragops-shader">invoked</a>.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT = 0x80,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BITspecifies that queries managed by the pool will
    ///     count the number of patches processed by the tessellation control shader. The counter&#8217;s value is incremented
    ///     once for each patch for which a tessellation control shader is
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shaders-tessellation-control-execution">
    ///         invoked
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT = 0x100,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BITspecifies that queries managed by the
    ///     pool will count the number of invocations of the tessellation evaluation shader. The counter&#8217;s value is
    ///     incremented each time the tessellation evaluation shader is
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#shaders-tessellation-evaluation-execution">
    ///         invoked
    ///     </a>
    ///     .
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = 0x200,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BITspecifies that queries managed by the pool will
    ///     count the number of compute shader invocations. The counter&#8217;s value is incremented every time the compute
    ///     shader is invoked. Implementations may skip the execution of certain compute shader invocations or execute
    ///     additional compute shader invocations for implementation-dependent reasons as long as the results of rendering
    ///     otherwise remain unchanged.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT = 0x400,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXTspecifies that queries managed by the pool will
    ///     count the number of task shader invocations. The counter&#8217;s value is incremented every time the task shader is
    ///     invoked.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT = 0x800,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXTspecifies that queries managed by the pool will
    ///     count the number of mesh shader invocations. The counter&#8217;s value is incremented every time the mesh shader is
    ///     invoked.
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT = 0x1000,

    /// <summary>
    ///     VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkQueryPipelineStatisticFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkQueryPipelineStatisticFlagBits
    ///     </a>
    /// </summary>
    VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI = 0x2000
}