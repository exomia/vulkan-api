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
///     VkStructureType - Vulkan structure types (pname:sType) -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStructureType.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStructureType.html</a>
/// </summary>
public enum VkStructureType
{
    /// <summary>
    ///     VK_STRUCTURE_TYPE_APPLICATION_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_APPLICATION_INFO = 0,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 1,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = 2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 3,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBMIT_INFO = 4,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = 5,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 6,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_SPARSE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = 7,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FENCE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 8,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 9,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EVENT_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 10,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 11,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 12,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 13,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 14,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 15,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 16,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 17,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 18,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 19,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 20,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 21,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 22,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = 23,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 24,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 25,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 26,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = 27,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 28,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 29,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 30,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 31,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 32,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 33,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = 34,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 35,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 36,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 37,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 38,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = 39,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = 40,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = 41,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = 42,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 43,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 44,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 45,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_BARRIER<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_BARRIER = 46,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = 47,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = 48,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = 1000094000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = 1000157000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = 1000157001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = 1000083000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = 1000127000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = 1000127001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = 1000060000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = 1000060003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = 1000060004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = 1000060005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = 1000060006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = 1000060013,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = 1000060014,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = 1000070000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = 1000070001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = 1000146000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = 1000146001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = 1000146002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = 1000146003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = 1000146004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = 1000059000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = 1000059001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = 1000059002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = 1000059003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = 1000059004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = 1000059005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = 1000059006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = 1000059007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = 1000059008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = 1000117000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = 1000117001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = 1000117002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = 1000117003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = 1000053000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = 1000053001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = 1000053002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = 1000120000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = 1000145000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = 1000145001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = 1000145002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = 1000145003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = 1000156000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = 1000156001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = 1000156002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = 1000156003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = 1000156004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = 1000156005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = 1000085000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = 1000071000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = 1000071001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = 1000071002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = 1000071003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = 1000071004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = 1000072000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = 1000072001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = 1000072002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = 1000112000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = 1000112001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = 1000113000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = 1000077000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = 1000076000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = 1000076001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = 1000168000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = 1000168001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = 1000063000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES = 49,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES = 50,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES = 51,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES = 52,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO = 1000147000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2 = 1000109000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2 = 1000109001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2 = 1000109002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2 = 1000109003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2 = 1000109004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO = 1000109005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_END_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_END_INFO = 1000109006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES = 1000177000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES = 1000196000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES = 1000180000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES = 1000082000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES = 1000197000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO = 1000161000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES = 1000161001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES = 1000161002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO = 1000161003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT = 1000161004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES = 1000199000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE = 1000199001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES = 1000221000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO = 1000246000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES = 1000130000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO = 1000130001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES = 1000211000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES = 1000108000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO = 1000108001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO = 1000108002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO = 1000108003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES = 1000253000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES = 1000175000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES = 1000241000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT = 1000241001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT = 1000241002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES = 1000261000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES = 1000207000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES = 1000207001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO = 1000207002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO = 1000207003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO = 1000207004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO = 1000207005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES = 1000257000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO = 1000244001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO = 1000257002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO = 1000257003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO = 1000257004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES = 53,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES = 54,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO = 1000192000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES = 1000215000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES = 1000245000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES = 1000276000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES = 1000295000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO = 1000295001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO = 1000295002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES = 1000297000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_BARRIER_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_BARRIER_2 = 1000314000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2 = 1000314001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2 = 1000314002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEPENDENCY_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEPENDENCY_INFO = 1000314003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBMIT_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBMIT_INFO_2 = 1000314004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO = 1000314005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO = 1000314006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES = 1000314007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES = 1000325000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES = 1000335000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2 = 1000337000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2 = 1000337001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2 = 1000337002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2 = 1000337003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2 = 1000337004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2 = 1000337005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COPY_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COPY_2 = 1000337006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_COPY_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_COPY_2 = 1000337007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_BLIT_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_BLIT_2 = 1000337008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2 = 1000337009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2 = 1000337010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES = 1000225000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO = 1000225001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES = 1000225002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES = 1000138000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES = 1000138001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK = 1000138002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO = 1000138003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES = 1000066000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_INFO = 1000044000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO = 1000044001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO = 1000044002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES = 1000044003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO = 1000044004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES = 1000280000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES = 1000280001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES = 1000281001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3 = 1000360000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES = 1000413000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES = 1000413001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS = 1000413002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS = 1000413003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = 1000001000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRESENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = 1000001001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = 1000060007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = 1000060008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = 1000060009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = 1000060010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = 1000060011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = 1000060012,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = 1000002000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = 1000002001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = 1000003000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = 1000004000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = 1000005000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = 1000006000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = 1000008000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = 1000009000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = 1000011000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = 1000018000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = 1000022000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = 1000022001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = 1000022002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR = 1000023000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR = 1000023001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR = 1000023002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR = 1000023003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR = 1000023004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR = 1000023005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000023006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR = 1000023007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR = 1000023008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR = 1000023009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR = 1000023010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR = 1000023011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR = 1000023012,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR = 1000023013,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR = 1000023014,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR = 1000023015,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR = 1000023016,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR = 1000024000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR = 1000024001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR = 1000024002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = 1000026000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = 1000026001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = 1000026002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = 1000028000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = 1000028001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = 1000028002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX = 1000029000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX = 1000029001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX = 1000029002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = 1000030000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = 1000030001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT = 1000038000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT = 1000038001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT = 1000038002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_VCL_FRAME_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_VCL_FRAME_INFO_EXT = 1000038003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT = 1000038004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_EXT = 1000038005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_EXT = 1000038007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_EXT = 1000038008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_EXT = 1000038009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT = 1000039000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT = 1000039001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT = 1000039002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_VCL_FRAME_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_VCL_FRAME_INFO_EXT = 1000039003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_EXT = 1000039004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_EXT = 1000039005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_EXT = 1000039007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_EXT = 1000039009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_EXT = 1000039010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR = 1000040000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR = 1000040001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR = 1000040003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000040004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = 1000040005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR = 1000040006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = 1000041000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000044006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT = 1000044007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD = 1000044008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX = 1000044009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = 1000049000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = 1000050000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = 1000056000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = 1000056001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = 1000057001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = 1000058000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = 1000061000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = 1000062000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = 1000067000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = 1000067001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT = 1000068000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT = 1000068001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT = 1000068002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = 1000073001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = 1000073002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = 1000073003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = 1000074000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = 1000074001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = 1000074002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = 1000075000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = 1000078001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = 1000078002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = 1000078003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = 1000079000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = 1000079001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = 1000080000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = 1000081000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = 1000081001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = 1000081002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = 1000084000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = 1000087000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = 1000090000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = 1000091000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = 1000091001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = 1000091002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = 1000091003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = 1000092000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = 1000097000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = 1000098000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = 1000099000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = 1000099001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = 1000101000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = 1000101001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = 1000102000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = 1000102001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_HDR_METADATA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_HDR_METADATA_EXT = 1000105000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = 1000111000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = 1000114001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = 1000114002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = 1000115000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = 1000115001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = 1000116000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = 1000116001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = 1000116002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = 1000116003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = 1000116004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = 1000116005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = 1000116006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = 1000119000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = 1000119001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = 1000119002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = 1000121000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = 1000121001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = 1000121002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = 1000121003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = 1000121004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = 1000122000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = 1000123000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000128000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = 1000128001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = 1000128002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000128003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000128004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = 1000129000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = 1000129001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = 1000129002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = 1000129004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = 1000129005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID = 1000129006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = 1000143000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = 1000143001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = 1000143002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = 1000143003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = 1000143004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = 1000148000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = 1000148001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = 1000148002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = 1000149000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = 1000150007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = 1000150000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = 1000150002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = 1000150003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = 1000150004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = 1000150005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = 1000150006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = 1000150009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = 1000150010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = 1000150011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = 1000150012,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = 1000150013,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = 1000150014,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = 1000150017,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = 1000150020,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = 1000347000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = 1000347001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = 1000150015,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = 1000150016,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = 1000150018,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = 1000348013,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = 1000152000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = 1000154000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = 1000154001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = 1000158000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = 1000158002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = 1000158003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = 1000158004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = 1000158005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT = 1000158006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = 1000160001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR = 1000163000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR = 1000163001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = 1000164000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = 1000164001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = 1000164002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = 1000164005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = 1000165000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = 1000165001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GEOMETRY_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GEOMETRY_NV = 1000165003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = 1000165004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = 1000165005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = 1000165006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = 1000165007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = 1000165008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = 1000165009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = 1000165011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = 1000165012,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = 1000166000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = 1000166001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = 1000170000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = 1000170001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = 1000178000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = 1000178001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = 1000178002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = 1000181000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = 1000183000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = 1000184000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = 1000185000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR = 1000187000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = 1000187001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = 1000187002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR = 1000187003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR = 1000187004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR = 1000187005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR = 1000174000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR = 1000388000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR = 1000388001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = 1000189000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = 1000190000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = 1000190001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = 1000190002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = 1000191000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = 1000201000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = 1000202000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = 1000202001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = 1000204000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = 1000205000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = 1000205002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = 1000206000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = 1000206001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = 1000209000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = 1000210000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = 1000210001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = 1000210002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = 1000210003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = 1000210004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = 1000210005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = 1000212000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = 1000213000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = 1000213001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = 1000214000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = 1000217000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = 1000218000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = 1000218001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = 1000218002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = 1000226000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = 1000226001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = 1000226002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = 1000226003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = 1000226004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = 1000227000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = 1000229000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = 1000234000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = 1000237000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = 1000238000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = 1000238001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = 1000239000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = 1000240000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = 1000244000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = 1000244002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = 1000247000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR = 1000248000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = 1000249000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = 1000249002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = 1000250000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = 1000250001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = 1000250002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = 1000251000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = 1000252000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT = 1000254000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT = 1000254001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT = 1000254002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = 1000255000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = 1000255002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = 1000255001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = 1000256000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT = 1000259000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT = 1000259001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT = 1000259002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = 1000260000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT = 1000265000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = 1000267000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = 1000269000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = 1000269001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = 1000269002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = 1000269003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = 1000269004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = 1000269005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR = 1000271000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR = 1000271001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT = 1000273000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT = 1000274000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT = 1000274001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT = 1000274002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT = 1000275000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT = 1000275001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT = 1000275002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT = 1000275003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT = 1000275004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT = 1000275005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = 1000277000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = 1000277001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = 1000277002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = 1000277003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = 1000277004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = 1000277005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = 1000277006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = 1000277007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV = 1000278000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV = 1000278001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = 1000281000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = 1000282000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = 1000282001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = 1000284000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = 1000284001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = 1000284002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT = 1000286000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT = 1000286001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = 1000287000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = 1000287001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = 1000287002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = 1000290000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV = 1000292000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV = 1000292001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV = 1000292002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRESENT_ID_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRESENT_ID_KHR = 1000294000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR = 1000294001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR = 1000299000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR = 1000299001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR = 1000299002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR = 1000299003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR = 1000299004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR = 1000299005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = 1000300000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = 1000300001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV = 1000310000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT = 1000311000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT = 1000311001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT = 1000311002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT = 1000311003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT = 1000311004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT = 1000311005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT = 1000311006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT = 1000311007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT = 1000311008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT = 1000311009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT = 1000311011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV = 1000314008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV = 1000314009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT = 1000316000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT = 1000316001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT = 1000316002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT = 1000316003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT = 1000316004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT = 1000316010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT = 1000316011,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT = 1000316012,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = 1000316009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT = 1000320000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT = 1000320001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT = 1000320002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD = 1000321000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR = 1000203000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR = 1000322000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR = 1000323000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = 1000326000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = 1000326001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = 1000326002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV = 1000327000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV = 1000327001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV = 1000327002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT = 1000328000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT = 1000328001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT = 1000330000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = 1000332000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = 1000332001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = 1000333000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR = 1000336000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT = 1000338000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT = 1000338001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_EXT = 1000338002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_EXT = 1000338003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT = 1000338004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT = 1000339000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = 1000340000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT = 1000341000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT = 1000341001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT = 1000341002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT = 1000344000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = 1000346000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT = 1000352000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT = 1000352001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT = 1000352002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT = 1000353000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT = 1000354000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT = 1000354001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT = 1000355000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT = 1000355001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT = 1000356000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA = 1000364001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000364002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA = 1000365001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA = 1000366000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA = 1000366001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA = 1000366002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA = 1000366003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA = 1000366004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA = 1000366005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA = 1000366006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA = 1000366007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA = 1000366008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA = 1000366009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI = 1000369000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI = 1000369001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI = 1000369002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI = 1000370000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV = 1000371000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV = 1000371001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT = 1000372000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT = 1000372001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT = 1000376000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT = 1000376001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT = 1000376002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT = 1000377000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX = 1000378000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT = 1000381000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT = 1000381001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT = 1000382000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR = 1000386000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT = 1000391000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT = 1000391001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT = 1000392000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT = 1000392001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT = 1000393000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT = 1000396000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT = 1000396001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT = 1000396002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT = 1000396003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT = 1000396004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT = 1000396005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT = 1000396006,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT = 1000396007,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT = 1000396008,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT = 1000396009,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_FEATURES_NV = 1000397000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV = 1000397001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_DISPLACEMENT_MICROMAP_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_DISPLACEMENT_MICROMAP_NV = 1000397002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI = 1000404000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI = 1000404001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT = 1000411000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT = 1000411001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT = 1000412000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM = 1000415000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT = 1000418000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT = 1000418001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE = 1000420000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE = 1000420001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE = 1000420002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT = 1000421000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT = 1000422000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM = 1000425000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM = 1000425001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM = 1000425002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV = 1000426000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV = 1000426001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV = 1000427000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV = 1000427001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV = 1000430000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT = 1000437000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM = 1000440000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM = 1000440001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM = 1000440002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT = 1000455000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT = 1000455001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT = 1000458000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT = 1000458001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT = 1000458002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT = 1000458003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG = 1000459000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG = 1000459001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT = 1000462000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT = 1000462001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT = 1000462002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT = 1000462003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT = 1000342000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV = 1000464000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV = 1000464001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV = 1000464002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV = 1000464003,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV = 1000464004,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV = 1000464005,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV = 1000464010,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT = 1000465000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT = 1000466000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM = 1000484000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM = 1000484001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC = 1000485000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC = 1000485001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM = 1000488000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV = 1000490000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV = 1000490001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT = 1000351000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT = 1000351002,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM = 1000497000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM = 1000497001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT = 1000498000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM = 1000510000,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM = 1000510001,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEBUG_REPORT_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO_KHR = VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO_KHR = VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_NV = VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES2_EXT = VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR = VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2_KHR = VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_END_INFO_KHR = VK_STRUCTURE_TYPE_SUBPASS_END_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT = VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR = VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR = VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR = VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO_KHR = VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR = VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR = VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO_INTEL = VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR = VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_EXT = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR = VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR = VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR = VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO_EXT = VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_MEMORY_BARRIER_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2_KHR = VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEPENDENCY_INFO_KHR = VK_STRUCTURE_TYPE_DEPENDENCY_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SUBMIT_INFO_2_KHR = VK_STRUCTURE_TYPE_SUBMIT_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO_KHR = VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2_KHR = VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2_KHR = VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_COPY_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_IMAGE_COPY_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_BLIT_2_KHR = VK_STRUCTURE_TYPE_IMAGE_BLIT_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2_KHR = VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2_KHR = VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE = VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3_KHR = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PIPELINE_INFO_EXT = VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT = VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES_KHR = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS,

    /// <summary>
    ///     VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkStructureType</a>
    /// </summary>
    VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS_KHR = VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS
}