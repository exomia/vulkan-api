﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global 
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core
{
    public static partial class Vk
    {
        public const int    VK_HEADER_VERSION                                          = 183;
        public const int    VK_NULL_HANDLE                                             = 0;
        public const uint   VK_ATTACHMENT_UNUSED                                       = ~0U;
        public const uint   VK_FALSE                                                   = 0U;
        public const float  VK_LOD_CLAMP_NONE                                          = 1000.0F;
        public const uint   VK_QUEUE_FAMILY_IGNORED                                    = ~0U;
        public const uint   VK_REMAINING_ARRAY_LAYERS                                  = ~0U;
        public const uint   VK_REMAINING_MIP_LEVELS                                    = ~0U;
        public const uint   VK_SUBPASS_EXTERNAL                                        = ~0U;
        public const uint   VK_TRUE                                                    = 1U;
        public const ulong  VK_WHOLE_SIZE                                              = ~0UL;
        public const uint   VK_MAX_MEMORY_TYPES                                        = 32U;
        public const uint   VK_MAX_MEMORY_HEAPS                                        = 16U;
        public const uint   VK_MAX_PHYSICAL_DEVICE_NAME_SIZE                           = 256U;
        public const uint   VK_UUID_SIZE                                               = 16U;
        public const uint   VK_MAX_EXTENSION_NAME_SIZE                                 = 256U;
        public const uint   VK_MAX_DESCRIPTION_SIZE                                    = 256U;
        public const uint   VK_MAX_DEVICE_GROUP_SIZE                                   = 32U;
        public const uint   VK_LUID_SIZE                                               = 8U;
        public const uint   VK_QUEUE_FAMILY_EXTERNAL                                   = ~1U;
        public const uint   VK_MAX_DRIVER_NAME_SIZE                                    = 256U;
        public const uint   VK_MAX_DRIVER_INFO_SIZE                                    = 256U;
        public const int    VK_KHR_SURFACE                                             = 1;
        public const int    VK_KHR_SURFACE_SPEC_VERSION                                = 25;
        public const string VK_KHR_SURFACE_EXTENSION_NAME                              = "VK_KHR_surface";
        public const int    VK_KHR_SWAPCHAIN                                           = 1;
        public const int    VK_KHR_SWAPCHAIN_SPEC_VERSION                              = 70;
        public const string VK_KHR_SWAPCHAIN_EXTENSION_NAME                            = "VK_KHR_swapchain";
        public const int    VK_KHR_DISPLAY                                             = 1;
        public const int    VK_KHR_DISPLAY_SPEC_VERSION                                = 23;
        public const string VK_KHR_DISPLAY_EXTENSION_NAME                              = "VK_KHR_display";
        public const int    VK_KHR_DISPLAY_SWAPCHAIN                                   = 1;
        public const int    VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION                      = 10;
        public const string VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME                    = "VK_KHR_display_swapchain";
        public const int    VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE                        = 1;
        public const int    VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_SPEC_VERSION           = 3;
        public const string VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE_EXTENSION_NAME         = "VK_KHR_sampler_mirror_clamp_to_edge";
        public const int    VK_KHR_MULTIVIEW                                           = 1;
        public const int    VK_KHR_MULTIVIEW_SPEC_VERSION                              = 1;
        public const string VK_KHR_MULTIVIEW_EXTENSION_NAME                            = "VK_KHR_multiview";
        public const int    VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES2                     = 1;
        public const int    VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION       = 2;
        public const string VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME     = "VK_KHR_get_physical_device_properties2";
        public const int    VK_KHR_DEVICE_GROUP                                        = 1;
        public const int    VK_KHR_DEVICE_GROUP_SPEC_VERSION                           = 4;
        public const string VK_KHR_DEVICE_GROUP_EXTENSION_NAME                         = "VK_KHR_device_group";
        public const int    VK_KHR_SHADER_DRAW_PARAMETERS                              = 1;
        public const int    VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION                 = 1;
        public const string VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME               = "VK_KHR_shader_draw_parameters";
        public const int    VK_KHR_MAINTENANCE1                                        = 1;
        public const int    VK_KHR_MAINTENANCE1_SPEC_VERSION                           = 2;
        public const string VK_KHR_MAINTENANCE1_EXTENSION_NAME                         = "VK_KHR_maintenance1";
        public const int    VK_KHR_DEVICE_GROUP_CREATION                               = 1;
        public const int    VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION                  = 1;
        public const string VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME                = "VK_KHR_device_group_creation";
        public const uint   VK_MAX_DEVICE_GROUP_SIZE_KHR                               = VK_MAX_DEVICE_GROUP_SIZE;
        public const int    VK_KHR_EXTERNAL_MEMORY_CAPABILITIES                        = 1;
        public const int    VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION           = 1;
        public const string VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME         = "VK_KHR_external_memory_capabilities";
        public const uint   VK_LUID_SIZE_KHR                                           = VK_LUID_SIZE;
        public const int    VK_KHR_EXTERNAL_MEMORY                                     = 1;
        public const int    VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION                        = 1;
        public const string VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME                      = "VK_KHR_external_memory";
        public const uint   VK_QUEUE_FAMILY_EXTERNAL_KHR                               = VK_QUEUE_FAMILY_EXTERNAL;
        public const int    VK_KHR_EXTERNAL_MEMORY_FD                                  = 1;
        public const int    VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION                     = 1;
        public const string VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME                   = "VK_KHR_external_memory_fd";
        public const int    VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES                     = 1;
        public const int    VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION        = 1;
        public const string VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME      = "VK_KHR_external_semaphore_capabilities";
        public const int    VK_KHR_EXTERNAL_SEMAPHORE                                  = 1;
        public const int    VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION                     = 1;
        public const string VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME                   = "VK_KHR_external_semaphore";
        public const int    VK_KHR_EXTERNAL_SEMAPHORE_FD                               = 1;
        public const int    VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION                  = 1;
        public const string VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME                = "VK_KHR_external_semaphore_fd";
        public const int    VK_KHR_PUSH_DESCRIPTOR                                     = 1;
        public const int    VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION                        = 2;
        public const string VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME                      = "VK_KHR_push_descriptor";
        public const int    VK_KHR_SHADER_FLOAT16_INT8                                 = 1;
        public const int    VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION                    = 1;
        public const string VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME                  = "VK_KHR_shader_float16_int8";
        public const int    VK_KHR_16BIT_STORAGE                                       = 1;
        public const int    VK_KHR_16BIT_STORAGE_SPEC_VERSION                          = 1;
        public const string VK_KHR_16BIT_STORAGE_EXTENSION_NAME                        = "VK_KHR_16bit_storage";
        public const int    VK_KHR_INCREMENTAL_PRESENT                                 = 1;
        public const int    VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION                    = 2;
        public const string VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME                  = "VK_KHR_incremental_present";
        public const int    VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE                          = 1;
        public const int    VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_SPEC_VERSION             = 1;
        public const string VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE_EXTENSION_NAME           = "VK_KHR_descriptor_update_template";
        public const int    VK_KHR_IMAGELESS_FRAMEBUFFER                               = 1;
        public const int    VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION                  = 1;
        public const string VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME                = "VK_KHR_imageless_framebuffer";
        public const int    VK_KHR_CREATE_RENDERPASS2                                  = 1;
        public const int    VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION                    = 1;
        public const string VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME                  = "VK_KHR_create_renderpass2";
        public const int    VK_KHR_SHARED_PRESENTABLE_IMAGE                            = 1;
        public const int    VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION               = 1;
        public const string VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME             = "VK_KHR_shared_presentable_image";
        public const int    VK_KHR_EXTERNAL_FENCE_CAPABILITIES                         = 1;
        public const int    VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION            = 1;
        public const string VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME          = "VK_KHR_external_fence_capabilities";
        public const int    VK_KHR_EXTERNAL_FENCE                                      = 1;
        public const int    VK_KHR_EXTERNAL_FENCE_SPEC_VERSION                         = 1;
        public const string VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME                       = "VK_KHR_external_fence";
        public const int    VK_KHR_EXTERNAL_FENCE_FD                                   = 1;
        public const int    VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION                      = 1;
        public const string VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME                    = "VK_KHR_external_fence_fd";
        public const int    VK_KHR_PERFORMANCE_QUERY                                   = 1;
        public const int    VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION                      = 1;
        public const string VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME                    = "VK_KHR_performance_query";
        public const int    VK_KHR_MAINTENANCE2                                        = 1;
        public const int    VK_KHR_MAINTENANCE2_SPEC_VERSION                           = 1;
        public const string VK_KHR_MAINTENANCE2_EXTENSION_NAME                         = "VK_KHR_maintenance2";
        public const int    VK_KHR_GET_SURFACE_CAPABILITIES2                           = 1;
        public const int    VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION             = 1;
        public const string VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME           = "VK_KHR_get_surface_capabilities2";
        public const int    VK_KHR_VARIABLE_POINTERS                                   = 1;
        public const int    VK_KHR_VARIABLE_POINTERS_SPEC_VERSION                      = 1;
        public const string VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME                    = "VK_KHR_variable_pointers";
        public const int    VK_KHR_GET_DISPLAY_PROPERTIES2                             = 1;
        public const int    VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION               = 1;
        public const string VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME             = "VK_KHR_get_display_properties2";
        public const int    VK_KHR_DEDICATED_ALLOCATION                                = 1;
        public const int    VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION                   = 3;
        public const string VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME                 = "VK_KHR_dedicated_allocation";
        public const int    VK_KHR_STORAGE_BUFFER_STORAGE_CLASS                        = 1;
        public const int    VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION           = 1;
        public const string VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME         = "VK_KHR_storage_buffer_storage_class";
        public const int    VK_KHR_RELAXED_BLOCK_LAYOUT                                = 1;
        public const int    VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION                   = 1;
        public const string VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME                 = "VK_KHR_relaxed_block_layout";
        public const int    VK_KHR_GET_MEMORY_REQUIREMENTS2                            = 1;
        public const int    VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION              = 1;
        public const string VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME            = "VK_KHR_get_memory_requirements2";
        public const int    VK_KHR_IMAGE_FORMAT_LIST                                   = 1;
        public const int    VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION                      = 1;
        public const string VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME                    = "VK_KHR_image_format_list";
        public const int    VK_KHR_SAMPLER_YCBCR_CONVERSION                            = 1;
        public const int    VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION               = 14;
        public const string VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME             = "VK_KHR_sampler_ycbcr_conversion";
        public const int    VK_KHR_BIND_MEMORY2                                        = 1;
        public const int    VK_KHR_BIND_MEMORY_2_SPEC_VERSION                          = 1;
        public const string VK_KHR_BIND_MEMORY_2_EXTENSION_NAME                        = "VK_KHR_bind_memory2";
        public const int    VK_KHR_MAINTENANCE3                                        = 1;
        public const int    VK_KHR_MAINTENANCE3_SPEC_VERSION                           = 1;
        public const string VK_KHR_MAINTENANCE3_EXTENSION_NAME                         = "VK_KHR_maintenance3";
        public const int    VK_KHR_DRAW_INDIRECT_COUNT                                 = 1;
        public const int    VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION                    = 1;
        public const string VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME                  = "VK_KHR_draw_indirect_count";
        public const int    VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES                      = 1;
        public const int    VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_SPEC_VERSION         = 1;
        public const string VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES_EXTENSION_NAME       = "VK_KHR_shader_subgroup_extended_types";
        public const int    VK_KHR_8BIT_STORAGE                                        = 1;
        public const int    VK_KHR_8BIT_STORAGE_SPEC_VERSION                           = 1;
        public const string VK_KHR_8BIT_STORAGE_EXTENSION_NAME                         = "VK_KHR_8bit_storage";
        public const int    VK_KHR_SHADER_ATOMIC_INT64                                 = 1;
        public const int    VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION                    = 1;
        public const string VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME                  = "VK_KHR_shader_atomic_int64";
        public const int    VK_KHR_SHADER_CLOCK                                        = 1;
        public const int    VK_KHR_SHADER_CLOCK_SPEC_VERSION                           = 1;
        public const string VK_KHR_SHADER_CLOCK_EXTENSION_NAME                         = "VK_KHR_shader_clock";
        public const int    VK_KHR_DRIVER_PROPERTIES                                   = 1;
        public const int    VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION                      = 1;
        public const string VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME                    = "VK_KHR_driver_properties";
        public const uint   VK_MAX_DRIVER_NAME_SIZE_KHR                                = VK_MAX_DRIVER_NAME_SIZE;
        public const uint   VK_MAX_DRIVER_INFO_SIZE_KHR                                = VK_MAX_DRIVER_INFO_SIZE;
        public const int    VK_KHR_SHADER_FLOAT_CONTROLS                               = 1;
        public const int    VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION                  = 4;
        public const string VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME                = "VK_KHR_shader_float_controls";
        public const int    VK_KHR_DEPTH_STENCIL_RESOLVE                               = 1;
        public const int    VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION                  = 1;
        public const string VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME                = "VK_KHR_depth_stencil_resolve";
        public const int    VK_KHR_SWAPCHAIN_MUTABLE_FORMAT                            = 1;
        public const int    VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION               = 1;
        public const string VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME             = "VK_KHR_swapchain_mutable_format";
        public const int    VK_KHR_TIMELINE_SEMAPHORE                                  = 1;
        public const int    VK_KHR_TIMELINE_SEMAPHORE_SPEC_VERSION                     = 2;
        public const string VK_KHR_TIMELINE_SEMAPHORE_EXTENSION_NAME                   = "VK_KHR_timeline_semaphore";
        public const int    VK_KHR_VULKAN_MEMORY_MODEL                                 = 1;
        public const int    VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION                    = 3;
        public const string VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME                  = "VK_KHR_vulkan_memory_model";
        public const int    VK_KHR_SHADER_TERMINATE_INVOCATION                         = 1;
        public const int    VK_KHR_SHADER_TERMINATE_INVOCATION_SPEC_VERSION            = 1;
        public const string VK_KHR_SHADER_TERMINATE_INVOCATION_EXTENSION_NAME          = "VK_KHR_shader_terminate_invocation";
        public const int    VK_KHR_FRAGMENT_SHADING_RATE                               = 1;
        public const int    VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION                  = 1;
        public const string VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME                = "VK_KHR_fragment_shading_rate";
        public const int    VK_KHR_SPIRV_1_4                                           = 1;
        public const int    VK_KHR_SPIRV_1_4_SPEC_VERSION                              = 1;
        public const string VK_KHR_SPIRV_1_4_EXTENSION_NAME                            = "VK_KHR_spirv_1_4";
        public const int    VK_KHR_SURFACE_PROTECTED_CAPABILITIES                      = 1;
        public const int    VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION         = 1;
        public const string VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME       = "VK_KHR_surface_protected_capabilities";
        public const int    VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS                      = 1;
        public const int    VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION         = 1;
        public const string VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME       = "VK_KHR_separate_depth_stencil_layouts";
        public const int    VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT                      = 1;
        public const int    VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION         = 1;
        public const string VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME       = "VK_KHR_uniform_buffer_standard_layout";
        public const int    VK_KHR_BUFFER_DEVICE_ADDRESS                               = 1;
        public const int    VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION                  = 1;
        public const string VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME                = "VK_KHR_buffer_device_address";
        public const int    VK_KHR_DEFERRED_HOST_OPERATIONS                            = 1;
        public const int    VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION               = 4;
        public const string VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME             = "VK_KHR_deferred_host_operations";
        public const int    VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES                      = 1;
        public const int    VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION         = 1;
        public const string VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME       = "VK_KHR_pipeline_executable_properties";
        public const int    VK_KHR_PIPELINE_LIBRARY                                    = 1;
        public const int    VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION                       = 1;
        public const string VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME                     = "VK_KHR_pipeline_library";
        public const int    VK_KHR_SHADER_NON_SEMANTIC_INFO                            = 1;
        public const int    VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION               = 1;
        public const string VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME             = "VK_KHR_shader_non_semantic_info";
        public const int    VK_KHR_SYNCHRONIZATION2                                    = 1;
        public const int    VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION                      = 1;
        public const string VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME                    = "VK_KHR_synchronization2";
        public const int    VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY                    = 1;
        public const int    VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION       = 1;
        public const string VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME     = "VK_KHR_zero_initialize_workgroup_memory";
        public const int    VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT                    = 1;
        public const int    VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION       = 1;
        public const string VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME     = "VK_KHR_workgroup_memory_explicit_layout";
        public const int    VK_KHR_COPY_COMMANDS2                                      = 1;
        public const int    VK_KHR_COPY_COMMANDS_2_SPEC_VERSION                        = 1;
        public const string VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME                      = "VK_KHR_copy_commands2";
        public const int    VK_KHR_ACCELERATION_STRUCTURE                              = 1;
        public const int    VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION                 = 11;
        public const string VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME               = "VK_KHR_acceleration_structure";
        public const int    VK_KHR_RAY_TRACING_PIPELINE                                = 1;
        public const int    VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION                   = 1;
        public const string VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME                 = "VK_KHR_ray_tracing_pipeline";
        public const int    VK_KHR_RAY_QUERY                                           = 1;
        public const int    VK_KHR_RAY_QUERY_SPEC_VERSION                              = 1;
        public const string VK_KHR_RAY_QUERY_EXTENSION_NAME                            = "VK_KHR_ray_query";
        public const int    VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW                = 1;
        public const int    VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION   = 1;
        public const string VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME = "VK_KHR_shader_subgroup_uniform_control_flow";
    }
}