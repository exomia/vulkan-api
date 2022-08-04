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
///     VkPipelineCreateFlagBits - Bitmask controlling how a pipeline is created -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkPipelineCreateFlagBits
{
    /// <summary>
    ///     VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT specifies that the created pipeline will not be optimized. Using
    ///     this flag may reduce the time taken to create the pipeline.
    /// </summary>
    VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x1,

    /// <summary>
    ///     VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT specifies that the pipeline to be created is allowed to be the parent
    ///     of a pipeline that will be created in a subsequent pipeline creation call.
    /// </summary>
    VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x2,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DERIVATIVE_BIT specifies that the pipeline to be created will be a child of a previously
    ///     created parent pipeline.
    /// </summary>
    VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x4,

    /// <summary>
    ///     VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT specifies that any shader input variables decorated as
    ///     ViewIndex will be assigned values as if they were decorated as DeviceIndex.
    /// </summary>
    VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = 0x8,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DISPATCH_BASE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_DISPATCH_BASE_BIT = 0x10,

    /// <summary>
    ///     VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT specifies that pipeline creation will fail if a
    ///     compile is required for creation of a valid
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</a>
    ///     object; VK_PIPELINE_COMPILE_REQUIREDwill be returned by pipeline creation, and the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</a> will
    ///     be set to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NULL_HANDLE.html">VK_NULL_HANDLE</a>
    ///     .
    /// </summary>
    VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT = 0x100,

    /// <summary>
    ///     VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT = 0x200,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRspecifies that the pipeline will be used
    ///     with a fragment shading rate attachment.
    /// </summary>
    VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x200000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXTspecifies that the pipeline will be used
    ///     with a fragment density map attachment.
    /// </summary>
    VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = 0x400000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHRspecifies that an any-hit shader will always be
    ///     present when an any-hit shader would be executed. A NULL any-hit shader is an any-hit shader which is effectively
    ///     VK_SHADER_UNUSED_KHR, such as from a shader group consisting entirely of zeros.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = 0x4000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHRspecifies that a closest hit shader will
    ///     always be present when a closest hit shader would be executed. A NULL closest hit shader is a closest hit shader
    ///     which is effectively VK_SHADER_UNUSED_KHR, such as from a shader group consisting entirely of zeros.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = 0x8000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHRspecifies that a miss shader will always be present
    ///     when a miss shader would be executed. A NULL miss shader is a miss shader which is effectively
    ///     VK_SHADER_UNUSED_KHR, such as from a shader group consisting entirely of zeros.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = 0x10000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHRspecifies that an intersection shader will
    ///     always be present when an intersection shader would be executed. A NULL intersection shader is an intersection
    ///     shader which is effectively VK_SHADER_UNUSED_KHR, such as from a shader group consisting entirely of zeros.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = 0x20000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR specifies that triangle primitives will be skipped
    ///     during traversal using OpTraceRayKHR.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = 0x1000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR specifies that AABB primitives will be skipped during
    ///     traversal using OpTraceRayKHR.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = 0x2000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHRspecifies that the shader group
    ///     handles can be saved and reused on a subsequent run (e.g. for trace capture and replay).
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x80000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV specifies that a pipeline is created with all shaders in the deferred
    ///     state. Before using the pipeline the application must call
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCompileDeferredNV.html">vkCompileDeferredNV</a>
    ///     exactly once on each shader in the pipeline before using the pipeline.
    /// </summary>
    VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = 0x20,

    /// <summary>
    ///     VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR specifies that the shader compiler should capture statistics for the
    ///     pipeline executables produced by the compile process which can later be retrieved by calling
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableStatisticsKHR.html">
    ///         vkGetPipelineExecutableStatisticsKHR
    ///     </a>
    ///     . Enabling this flag must not affect the final compiled pipeline but maydisable pipeline caching or otherwise
    ///     affect pipeline creation time.
    /// </summary>
    VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = 0x40,

    /// <summary>
    ///     VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHRspecifies that the shader compiler should capture the
    ///     internal representations of pipeline executables produced by the compile process which can later be retrieved by
    ///     calling
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetPipelineExecutableInternalRepresentationsKHR.html">
    ///         vkGetPipelineExecutableInternalRepresentationsKHR
    ///     </a>
    ///     . Enabling this flag must not affect the final compiled pipeline but maydisable pipeline caching or otherwise
    ///     affect pipeline creation time. When capturing IR from pipelines created with pipeline libraries, there is no
    ///     guarantee that IR from libraries can be retrieved from the linked pipeline. Applications should retrieve IR from
    ///     each library, and any linked pipelines, separately.
    /// </summary>
    VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = 0x80,

    /// <summary>
    ///     VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV specifies that the pipeline can be used in combination with
    ///     <a class="bare"
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#device-generated-commands">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#device-generated-commands
    ///     </a>
    ///     .
    /// </summary>
    VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = 0x40000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_LIBRARY_BIT_KHR specifies that the pipeline     cannot be used directly, and instead
    ///     defines a pipeline library that     can be combined with other pipelines using the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineLibraryCreateInfoKHR.html">VkPipelineLibraryCreateInfoKHR</a>
    ///     structure.     This is available in ray tracing and graphics     pipelines.
    /// </summary>
    VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = 0x800,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RESERVED_29_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_RESERVED_29_AMD = 0x20000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXTspecifies that pipeline libraries should retain
    ///     any information necessary to later perform an optimal link with VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT.
    /// </summary>
    VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = 0x800000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT specifies that pipeline libraries being linked into this
    ///     library should have link time optimizations applied. If this bit is omitted, implementations should instead perform
    ///     linking as rapidly as possible.
    /// </summary>
    VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT = 0x400,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV specifies that the pipeline is allowed to use
    ///     OpTraceRayMotionNV.
    /// </summary>
    VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV = 0x100000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXTspecifies that the pipeline may be used with an
    ///     attachment feedback loop including color attachments.
    /// </summary>
    VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x2000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXTspecifies that the pipeline may be used with
    ///     an attachment feedback loop including depth-stencil attachments.
    /// </summary>
    VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = 0x4000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RESERVED_24_BIT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_RESERVED_24_BIT_NV = 0x1000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RESERVED_BIT_28_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_RESERVED_BIT_28_NV = 0x10000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RESERVED_27_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_RESERVED_27_BIT_EXT = 0x8000000,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DISPATCH_BASE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_DISPATCH_BASE = VK_PIPELINE_CREATE_DISPATCH_BASE_BIT,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHRspecifies that the pipeline will be used
    ///     with a fragment shading rate attachment.
    /// </summary>
    VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,

    /// <summary>
    ///     VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXTspecifies that the pipeline will be used
    ///     with a fragment density map attachment.
    /// </summary>
    VK_PIPELINE_RASTERIZATION_STATE_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT,

    /// <summary>
    ///     VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT specifies that any shader input variables decorated as
    ///     ViewIndex will be assigned values as if they were decorated as DeviceIndex.
    /// </summary>
    VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT,

    /// <summary>
    ///     VK_PIPELINE_CREATE_DISPATCH_BASE specifies that a compute pipeline can be used with
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdDispatchBase.html">vkCmdDispatchBase</a>
    ///     with a non-zero base workgroup.
    /// </summary>
    VK_PIPELINE_CREATE_DISPATCH_BASE_KHR = VK_PIPELINE_CREATE_DISPATCH_BASE,

    /// <summary>
    ///     VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT specifies that pipeline creation will fail if a
    ///     compile is required for creation of a valid
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</a>
    ///     object; VK_PIPELINE_COMPILE_REQUIREDwill be returned by pipeline creation, and the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</a> will
    ///     be set to
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_NULL_HANDLE.html">VK_NULL_HANDLE</a>
    ///     .
    /// </summary>
    VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT = VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT,

    /// <summary>
    ///     VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPipelineCreateFlagBits</a>
    /// </summary>
    VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT_EXT = VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT
}