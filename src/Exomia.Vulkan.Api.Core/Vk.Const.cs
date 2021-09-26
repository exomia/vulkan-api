﻿#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core
{
    public static partial class Vk
    {
        public const int    VK_HEADER_VERSION                                          = 182;
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



        public const int    VK_NV_GLSL_SHADER                                          = 1;
        public const int    VK_NV_GLSL_SHADER_SPEC_VERSION                             = 1;
        public const string VK_NV_GLSL_SHADER_EXTENSION_NAME                           = "VK_NV_glsl_shader";

        public const int    VK_IMG_FILTER_CUBIC                                        = 1;
        public const int    VK_IMG_FILTER_CUBIC_SPEC_VERSION                           = 1;
        public const string VK_IMG_FILTER_CUBIC_EXTENSION_NAME                         = "VK_IMG_filter_cubic";
        public const int    VK_AMD_RASTERIZATION_ORDER                                 = 1;
        public const int    VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION                    = 1;
        public const string VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME                  = "VK_AMD_rasterization_order";
        public const int    VK_AMD_SHADER_TRINARY_MINMAX                               = 1;
        public const int    VK_AMD_SHADER_TRINARY_MINMAX_SPEC_VERSION                  = 1;
        public const string VK_AMD_SHADER_TRINARY_MINMAX_EXTENSION_NAME                = "VK_AMD_shader_trinary_minmax";
        public const int    VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER                    = 1;
        public const int    VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION       = 1;
        public const string VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME     = "VK_AMD_shader_explicit_vertex_parameter";

        public const int    VK_AMD_GCN_SHADER                                          = 1;
        public const int    VK_AMD_GCN_SHADER_SPEC_VERSION                             = 1;
        public const string VK_AMD_GCN_SHADER_EXTENSION_NAME                           = "VK_AMD_gcn_shader";
        public const int    VK_NV_DEDICATED_ALLOCATION                                 = 1;
        public const int    VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION                    = 1;
        public const string VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME                  = "VK_NV_dedicated_allocation";

        public const int    VK_NVX_IMAGE_VIEW_HANDLE                                   = 1;
        public const int    VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION                      = 2;
        public const string VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME                    = "VK_NVX_image_view_handle";
        public const int    VK_AMD_DRAW_INDIRECT_COUNT                                 = 1;
        public const int    VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION                    = 2;
        public const string VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME                  = "VK_AMD_draw_indirect_count";
        public const int    VK_AMD_NEGATIVE_VIEWPORT_HEIGHT                            = 1;
        public const int    VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION               = 1;
        public const string VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME             = "VK_AMD_negative_viewport_height";
        public const int    VK_AMD_GPU_SHADER_HALF_FLOAT                               = 1;
        public const int    VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION                  = 2;
        public const string VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME                = "VK_AMD_gpu_shader_half_float";
        public const int    VK_AMD_SHADER_BALLOT                                       = 1;
        public const int    VK_AMD_SHADER_BALLOT_SPEC_VERSION                          = 1;
        public const string VK_AMD_SHADER_BALLOT_EXTENSION_NAME                        = "VK_AMD_shader_ballot";
        public const int    VK_AMD_TEXTURE_GATHER_BIAS_LOD                             = 1;
        public const int    VK_AMD_TEXTURE_GATHER_BIAS_LOD_SPEC_VERSION                = 1;
        public const string VK_AMD_TEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME              = "VK_AMD_texture_gather_bias_lod";
        public const int    VK_AMD_SHADER_INFO                                         = 1;
        public const int    VK_AMD_SHADER_INFO_SPEC_VERSION                            = 1;
        public const string VK_AMD_SHADER_INFO_EXTENSION_NAME                          = "VK_AMD_shader_info";
        public const int    VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD                         = 1;
        public const int    VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION            = 1;
        public const string VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME          = "VK_AMD_shader_image_load_store_lod";
        public const int    VK_NV_CORNER_SAMPLED_IMAGE                                 = 1;
        public const int    VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION                    = 2;
        public const string VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME                  = "VK_NV_corner_sampled_image";
        public const int    VK_IMG_FORMAT_PVRTC                                        = 1;
        public const int    VK_IMG_FORMAT_PVRTC_SPEC_VERSION                           = 1;
        public const string VK_IMG_FORMAT_PVRTC_EXTENSION_NAME                         = "VK_IMG_format_pvrtc";
        public const int    VK_NV_EXTERNAL_MEMORY_CAPABILITIES                         = 1;
        public const int    VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION            = 1;
        public const string VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME          = "VK_NV_external_memory_capabilities";
        public const int    VK_NV_EXTERNAL_MEMORY                                      = 1;
        public const int    VK_NV_EXTERNAL_MEMORY_SPEC_VERSION                         = 1;
        public const string VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME                       = "VK_NV_external_memory";


        
        public const int    VK_NV_CLIP_SPACE_W_SCALING                                 = 1;
        public const int    VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION                    = 1;
        public const string VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME                  = "VK_NV_clip_space_w_scaling";
        
        public const int    VK_GOOGLE_DISPLAY_TIMING                                   = 1;
        public const int    VK_GOOGLE_DISPLAY_TIMING_SPEC_VERSION                      = 1;
        public const string VK_GOOGLE_DISPLAY_TIMING_EXTENSION_NAME                    = "VK_GOOGLE_display_timing";
        public const int    VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE                        = 1;
        public const int    VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION           = 1;
        public const string VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME         = "VK_NV_sample_mask_override_coverage";
        public const int    VK_NV_GEOMETRY_SHADER_PASSTHROUGH                          = 1;
        public const int    VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION             = 1;
        public const string VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME           = "VK_NV_geometry_shader_passthrough";
        public const int    VK_NV_VIEWPORT_ARRAY2                                      = 1;
        public const int    VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION                         = 1;
        public const string VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME                       = "VK_NV_viewport_array2";
        public const int    VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES                       = 1;
        public const int    VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION          = 1;
        public const string VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME        = "VK_NVX_multiview_per_view_attributes";
        public const int    VK_NV_VIEWPORT_SWIZZLE                                     = 1;
        public const int    VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION                        = 1;
        public const string VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME                      = "VK_NV_viewport_swizzle";



        public const int    VK_AMD_GPU_SHADER_INT16                                    = 1;
        public const int    VK_AMD_GPU_SHADER_INT16_SPEC_VERSION                       = 2;
        public const string VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME                     = "VK_AMD_gpu_shader_int16";
        public const int    VK_AMD_MIXED_ATTACHMENT_SAMPLES                            = 1;
        public const int    VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION               = 1;
        public const string VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME             = "VK_AMD_mixed_attachment_samples";
        public const int    VK_AMD_SHADER_FRAGMENT_MASK                                = 1;
        public const int    VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION                   = 1;
        public const string VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME                 = "VK_AMD_shader_fragment_mask";


        
        public const int    VK_NV_FRAGMENT_COVERAGE_TO_COLOR                           = 1;
        public const int    VK_NV_FRAGMENT_COVERAGE_TO_COLOR_SPEC_VERSION              = 1;
        public const string VK_NV_FRAGMENT_COVERAGE_TO_COLOR_EXTENSION_NAME            = "VK_NV_fragment_coverage_to_color";
        public const int    VK_NV_FRAMEBUFFER_MIXED_SAMPLES                            = 1;
        public const int    VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION               = 1;
        public const string VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME             = "VK_NV_framebuffer_mixed_samples";
        public const int    VK_NV_FILL_RECTANGLE                                       = 1;
        public const int    VK_NV_FILL_RECTANGLE_SPEC_VERSION                          = 1;
        public const string VK_NV_FILL_RECTANGLE_EXTENSION_NAME                        = "VK_NV_fill_rectangle";
        public const int    VK_NV_SHADER_SM_BUILTINS                                   = 1;
        public const int    VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION                      = 1;
        public const string VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME                    = "VK_NV_shader_sm_builtins";

        
        
        public const int    VK_NV_SHADING_RATE_IMAGE                                   = 1;
        public const int    VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION                      = 3;
        public const string VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME                    = "VK_NV_shading_rate_image";
        public const int    VK_NV_RAY_TRACING                                          = 1;
        public const int    VK_NV_RAY_TRACING_SPEC_VERSION                             = 3;
        public const string VK_NV_RAY_TRACING_EXTENSION_NAME                           = "VK_NV_ray_tracing";
        public const uint   VK_SHADER_UNUSED_KHR                                       = ~0U;
        public const uint   VK_SHADER_UNUSED_NV                                        = VK_SHADER_UNUSED_KHR;
        public const int    VK_NV_REPRESENTATIVE_FRAGMENT_TEST                         = 1;
        public const int    VK_NV_REPRESENTATIVE_FRAGMENT_TEST_SPEC_VERSION            = 2;
        public const string VK_NV_REPRESENTATIVE_FRAGMENT_TEST_EXTENSION_NAME          = "VK_NV_representative_fragment_test";


        public const int    VK_QCOM_RENDER_PASS_SHADER_RESOLVE                         = 1;
        public const int    VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION            = 4;
        public const string VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME          = "VK_QCOM_render_pass_shader_resolve";



        public const int    VK_AMD_BUFFER_MARKER                                       = 1;
        public const int    VK_AMD_BUFFER_MARKER_SPEC_VERSION                          = 1;
        public const string VK_AMD_BUFFER_MARKER_EXTENSION_NAME                        = "VK_AMD_buffer_marker";
        public const int    VK_AMD_PIPELINE_COMPILER_CONTROL                           = 1;
        public const int    VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION              = 1;
        public const string VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME            = "VK_AMD_pipeline_compiler_control";

        public const int    VK_AMD_SHADER_CORE_PROPERTIES                              = 1;
        public const int    VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION                 = 2;
        public const string VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME               = "VK_AMD_shader_core_properties";
        public const int    VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR                      = 1;
        public const int    VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION         = 1;
        public const string VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME       = "VK_AMD_memory_overallocation_behavior";



        public const int    VK_NV_SHADER_SUBGROUP_PARTITIONED                          = 1;
        public const int    VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION             = 1;
        public const string VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME           = "VK_NV_shader_subgroup_partitioned";
        public const int    VK_NV_COMPUTE_SHADER_DERIVATIVES                           = 1;
        public const int    VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION              = 1;
        public const string VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME            = "VK_NV_compute_shader_derivatives";
        public const int    VK_NV_MESH_SHADER                                          = 1;
        public const int    VK_NV_MESH_SHADER_SPEC_VERSION                             = 1;
        public const string VK_NV_MESH_SHADER_EXTENSION_NAME                           = "VK_NV_mesh_shader";
        public const int    VK_NV_FRAGMENT_SHADER_BARYCENTRIC                          = 1;
        public const int    VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION             = 1;
        public const string VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME           = "VK_NV_fragment_shader_barycentric";
        public const int    VK_NV_SHADER_IMAGE_FOOTPRINT                               = 1;
        public const int    VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION                  = 2;
        public const string VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME                = "VK_NV_shader_image_footprint";
        public const int    VK_NV_SCISSOR_EXCLUSIVE                                    = 1;
        public const int    VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION                       = 1;
        public const string VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME                     = "VK_NV_scissor_exclusive";
        public const int    VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS                        = 1;
        public const int    VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION           = 2;
        public const string VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME         = "VK_NV_device_diagnostic_checkpoints";
        public const int    VK_INTEL_SHADER_INTEGER_FUNCTIONS2                         = 1;
        public const int    VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION           = 1;
        public const string VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME         = "VK_INTEL_shader_integer_functions2";
        public const int    VK_INTEL_PERFORMANCE_QUERY                                 = 1;
        public const int    VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION                    = 2;
        public const string VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME                  = "VK_INTEL_performance_query";


        public const int    VK_AMD_DISPLAY_NATIVE_HDR                                  = 1;
        public const int    VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION                     = 1;
        public const string VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME                   = "VK_AMD_display_native_hdr";


        public const int    VK_GOOGLE_HLSL_FUNCTIONALITY1                              = 1;
        public const int    VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION                 = 1;
        public const string VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME               = "VK_GOOGLE_hlsl_functionality1";
        public const int    VK_GOOGLE_DECORATE_STRING                                  = 1;
        public const int    VK_GOOGLE_DECORATE_STRING_SPEC_VERSION                     = 1;
        public const string VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME                   = "VK_GOOGLE_decorate_string";


        public const int    VK_AMD_SHADER_CORE_PROPERTIES2                             = 1;
        public const int    VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION               = 1;
        public const string VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME             = "VK_AMD_shader_core_properties2";
        public const int    VK_AMD_DEVICE_COHERENT_MEMORY                              = 1;
        public const int    VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION                 = 1;
        public const string VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME               = "VK_AMD_device_coherent_memory";




        public const int    VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING                  = 1;
        public const int    VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION     = 1;
        public const string VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME   = "VK_NV_dedicated_allocation_image_aliasing";

        public const int    VK_EXT_SEPARATE_STENCIL_USAGE                              = 1;
        public const int    VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION                 = 1;
        public const string VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME               = "VK_EXT_separate_stencil_usage";
        public const int    VK_EXT_VALIDATION_FEATURES                                 = 1;
        public const int    VK_EXT_VALIDATION_FEATURES_SPEC_VERSION                    = 5;
        public const string VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME                  = "VK_EXT_validation_features";
        public const int    VK_NV_COOPERATIVE_MATRIX                                   = 1;
        public const int    VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION                      = 1;
        public const string VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME                    = "VK_NV_cooperative_matrix";
        public const int    VK_NV_COVERAGE_REDUCTION_MODE                              = 1;
        public const int    VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION                 = 1;
        public const string VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME               = "VK_NV_coverage_reduction_mode";


        
        public const int    VK_NV_DEVICE_GENERATED_COMMANDS                            = 1;
        public const int    VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION               = 3;
        public const string VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME             = "VK_NV_device_generated_commands";
        public const int    VK_NV_INHERITED_VIEWPORT_SCISSOR                           = 1;
        public const int    VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION              = 1;
        public const string VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME            = "VK_NV_inherited_viewport_scissor";


        public const int    VK_QCOM_RENDER_PASS_TRANSFORM                              = 1;
        public const int    VK_QCOM_RENDER_PASS_TRANSFORM_SPEC_VERSION                 = 2;
        public const string VK_QCOM_RENDER_PASS_TRANSFORM_EXTENSION_NAME               = "VK_QCOM_render_pass_transform";




        public const int    VK_GOOGLE_USER_TYPE                                        = 1;
        public const int    VK_GOOGLE_USER_TYPE_SPEC_VERSION                           = 1;
        public const string VK_GOOGLE_USER_TYPE_EXTENSION_NAME                         = "VK_GOOGLE_user_type";


        public const int    VK_NV_DEVICE_DIAGNOSTICS_CONFIG                            = 1;
        public const int    VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION               = 1;
        public const string VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME             = "VK_NV_device_diagnostics_config";
        public const int    VK_QCOM_RENDER_PASS_STORE_OPS                              = 1;
        public const int    VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION                 = 2;
        public const string VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME               = "VK_QCOM_render_pass_store_ops";
        public const int    VK_NV_FRAGMENT_SHADING_RATE_ENUMS                          = 1;
        public const int    VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION             = 1;
        public const string VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME           = "VK_NV_fragment_shading_rate_enums";
        public const int    VK_NV_RAY_TRACING_MOTION_BLUR                              = 1;
        public const int    VK_NV_RAY_TRACING_MOTION_BLUR_SPEC_VERSION                 = 1;
        public const string VK_NV_RAY_TRACING_MOTION_BLUR_EXTENSION_NAME               = "VK_NV_ray_tracing_motion_blur";
        public const int    VK_EXT_YCBCR_2PLANE_444_FORMATS                            = 1;
        public const int    VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION               = 1;
        public const string VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME             = "VK_EXT_ycbcr_2plane_444_formats";
        public const int    VK_EXT_FRAGMENT_DENSITY_MAP2                               = 1;
        public const int    VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION                 = 1;
        public const string VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME               = "VK_EXT_fragment_density_map2";
        public const int    VK_QCOM_ROTATED_COPY_COMMANDS                              = 1;
        public const int    VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION                 = 1;
        public const string VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME               = "VK_QCOM_rotated_copy_commands";
        public const int    VK_EXT_IMAGE_ROBUSTNESS                                    = 1;
        public const int    VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION                       = 1;
        public const string VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME                     = "VK_EXT_image_robustness";
        public const int    VK_EXT_4444_FORMATS                                        = 1;
        public const int    VK_EXT_4444_FORMATS_SPEC_VERSION                           = 1;
        public const string VK_EXT_4444_FORMATS_EXTENSION_NAME                         = "VK_EXT_4444_formats";
        public const int    VK_NV_ACQUIRE_WINRT_DISPLAY                                = 1;
        public const int    VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION                   = 1;
        public const string VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME                 = "VK_NV_acquire_winrt_display";
        public const int    VK_VALVE_MUTABLE_DESCRIPTOR_TYPE                           = 1;
        public const int    VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_SPEC_VERSION              = 1;
        public const string VK_VALVE_MUTABLE_DESCRIPTOR_TYPE_EXTENSION_NAME            = "VK_VALVE_mutable_descriptor_type";
        public const int    VK_EXT_VERTEX_INPUT_DYNAMIC_STATE                          = 1;
        public const int    VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION             = 2;
        public const string VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME           = "VK_EXT_vertex_input_dynamic_state";
        public const int    VK_EXT_PHYSICAL_DEVICE_DRM                                 = 1;
        public const int    VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION                    = 1;
        public const string VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME                  = "VK_EXT_physical_device_drm";
        public const int    VK_HUAWEI_SUBPASS_SHADING                                  = 1;
        public const int    VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION                     = 0;
        public const string VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME                   = "VK_HUAWEI_subpass_shading";
        public const int    VK_EXT_COLOR_WRITE_ENABLE                                  = 1;
        public const int    VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION                     = 1;
        public const string VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME                   = "VK_EXT_color_write_enable";

        public const int    VK_EXT_MULTI_DRAW                                          = 1;
        public const int    VK_EXT_MULTI_DRAW_SPEC_VERSION                             = 1;
        public const string VK_EXT_MULTI_DRAW_EXTENSION_NAME                           = "VK_EXT_multi_draw";
        public const int    VK_KHR_ACCELERATION_STRUCTURE                              = 1;
        public const int    VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION                 = 11;
        public const string VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME               = "VK_KHR_acceleration_structure";
        public const int    VK_KHR_RAY_TRACING_PIPELINE                                = 1;
        public const int    VK_KHR_RAY_TRACING_PIPELINE_SPEC_VERSION                   = 1;
        public const string VK_KHR_RAY_TRACING_PIPELINE_EXTENSION_NAME                 = "VK_KHR_ray_tracing_pipeline";
        public const int    VK_KHR_RAY_QUERY                                           = 1;
        public const int    VK_KHR_RAY_QUERY_SPEC_VERSION                              = 1;
        public const string VK_KHR_RAY_QUERY_EXTENSION_NAME                            = "VK_KHR_ray_query";
        public const int    VK_EXT_EXTENDED_DYNAMIC_STATE2                             = 1;
        public const int    VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION               = 1;
        public const string VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME             = "VK_EXT_extended_dynamic_state2";
        public const int    VK_EXT_PROVOKING_VERTEX                                    = 1;
        public const int    VK_EXT_PROVOKING_VERTEX_SPEC_VERSION                       = 1;
        public const string VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME                     = "VK_EXT_provoking_vertex";
        public const int    VK_NVX_BINARY_IMPORT                                       = 1;
        public const int    VK_NVX_BINARY_IMPORT_SPEC_VERSION                          = 1;
        public const string VK_NVX_BINARY_IMPORT_EXTENSION_NAME                        = "VK_NVX_binary_import";
        public const int    VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW                = 1;
        public const int    VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION   = 1;
        public const string VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME = "VK_KHR_shader_subgroup_uniform_control_flow";
    }
}