#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace Exomia.Vulkan.Api.Core
{
    public enum VkResult
    {
        SUCCESS                                            = 0,
        NOT_READY                                          = 1,
        TIMEOUT                                            = 2,
        EVENT_SET                                          = 3,
        EVENT_RESET                                        = 4,
        INCOMPLETE                                         = 5,
        ERROR_OUT_OF_HOST_MEMORY                           = -1,
        ERROR_OUT_OF_DEVICE_MEMORY                         = -2,
        ERROR_INITIALIZATION_FAILED                        = -3,
        ERROR_DEVICE_LOST                                  = -4,
        ERROR_MEMORY_MAP_FAILED                            = -5,
        ERROR_LAYER_NOT_PRESENT                            = -6,
        ERROR_EXTENSION_NOT_PRESENT                        = -7,
        ERROR_FEATURE_NOT_PRESENT                          = -8,
        ERROR_INCOMPATIBLE_DRIVER                          = -9,
        ERROR_TOO_MANY_OBJECTS                             = -10,
        ERROR_FORMAT_NOT_SUPPORTED                         = -11,
        ERROR_FRAGMENTED_POOL                              = -12,
        ERROR_UNKNOWN                                      = -13,
        ERROR_OUT_OF_POOL_MEMORY                           = -1000069000,
        ERROR_INVALID_EXTERNAL_HANDLE                      = -1000072003,
        ERROR_FRAGMENTATION                                = -1000161000,
        ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS               = -1000257000,
        ERROR_SURFACE_LOST_KHR                             = -1000000000,
        ERROR_NATIVE_WINDOW_IN_USE_KHR                     = -1000000001,
        SUBOPTIMAL_KHR                                     = 1000001003,
        ERROR_OUT_OF_DATE_KHR                              = -1000001004,
        ERROR_INCOMPATIBLE_DISPLAY_KHR                     = -1000003001,
        ERROR_VALIDATION_FAILED_EXT                        = -1000011001,
        ERROR_INVALID_SHADER_NV                            = -1000012000,
        ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = -1000158000,
        ERROR_NOT_PERMITTED_EXT                            = -1000174001,
        ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT          = -1000255000,
        THREAD_IDLE_KHR                                    = 1000268000,
        THREAD_DONE_KHR                                    = 1000268001,
        OPERATION_DEFERRED_KHR                             = 1000268002,
        OPERATION_NOT_DEFERRED_KHR                         = 1000268003,
        PIPELINE_COMPILE_REQUIRED_EXT                      = 1000297000,
        ERROR_OUT_OF_POOL_MEMORY_KHR                       = ERROR_OUT_OF_POOL_MEMORY,
        ERROR_INVALID_EXTERNAL_HANDLE_KHR                  = ERROR_INVALID_EXTERNAL_HANDLE,
        ERROR_FRAGMENTATION_EXT                            = ERROR_FRAGMENTATION,
        ERROR_INVALID_DEVICE_ADDRESS_EXT                   = ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,
        ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS_KHR           = ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS,
        ERROR_PIPELINE_COMPILE_REQUIRED_EXT                = PIPELINE_COMPILE_REQUIRED_EXT,
        RESULT_MAX_ENUM                                    = 0x7FFFFFFF
    }

    public enum VkStructureType
    {
        APPLICATION_INFO                                                  = 0,
        INSTANCE_CREATE_INFO                                              = 1,
        DEVICE_QUEUE_CREATE_INFO                                          = 2,
        DEVICE_CREATE_INFO                                                = 3,
        SUBMIT_INFO                                                       = 4,
        MEMORY_ALLOCATE_INFO                                              = 5,
        MAPPED_MEMORY_RANGE                                               = 6,
        BIND_SPARSE_INFO                                                  = 7,
        FENCE_CREATE_INFO                                                 = 8,
        SEMAPHORE_CREATE_INFO                                             = 9,
        EVENT_CREATE_INFO                                                 = 10,
        QUERY_POOL_CREATE_INFO                                            = 11,
        BUFFER_CREATE_INFO                                                = 12,
        BUFFER_VIEW_CREATE_INFO                                           = 13,
        IMAGE_CREATE_INFO                                                 = 14,
        IMAGE_VIEW_CREATE_INFO                                            = 15,
        SHADER_MODULE_CREATE_INFO                                         = 16,
        PIPELINE_CACHE_CREATE_INFO                                        = 17,
        PIPELINE_SHADER_STAGE_CREATE_INFO                                 = 18,
        PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO                           = 19,
        PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO                         = 20,
        PIPELINE_TESSELLATION_STATE_CREATE_INFO                           = 21,
        PIPELINE_VIEWPORT_STATE_CREATE_INFO                               = 22,
        PIPELINE_RASTERIZATION_STATE_CREATE_INFO                          = 23,
        PIPELINE_MULTISAMPLE_STATE_CREATE_INFO                            = 24,
        PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO                          = 25,
        PIPELINE_COLOR_BLEND_STATE_CREATE_INFO                            = 26,
        PIPELINE_DYNAMIC_STATE_CREATE_INFO                                = 27,
        GRAPHICS_PIPELINE_CREATE_INFO                                     = 28,
        COMPUTE_PIPELINE_CREATE_INFO                                      = 29,
        PIPELINE_LAYOUT_CREATE_INFO                                       = 30,
        SAMPLER_CREATE_INFO                                               = 31,
        DESCRIPTOR_SET_LAYOUT_CREATE_INFO                                 = 32,
        DESCRIPTOR_POOL_CREATE_INFO                                       = 33,
        DESCRIPTOR_SET_ALLOCATE_INFO                                      = 34,
        WRITE_DESCRIPTOR_SET                                              = 35,
        COPY_DESCRIPTOR_SET                                               = 36,
        FRAMEBUFFER_CREATE_INFO                                           = 37,
        RENDER_PASS_CREATE_INFO                                           = 38,
        COMMAND_POOL_CREATE_INFO                                          = 39,
        COMMAND_BUFFER_ALLOCATE_INFO                                      = 40,
        COMMAND_BUFFER_INHERITANCE_INFO                                   = 41,
        COMMAND_BUFFER_BEGIN_INFO                                         = 42,
        RENDER_PASS_BEGIN_INFO                                            = 43,
        BUFFER_MEMORY_BARRIER                                             = 44,
        IMAGE_MEMORY_BARRIER                                              = 45,
        MEMORY_BARRIER                                                    = 46,
        LOADER_INSTANCE_CREATE_INFO                                       = 47,
        LOADER_DEVICE_CREATE_INFO                                         = 48,
        PHYSICAL_DEVICE_SUBGROUP_PROPERTIES                               = 1000094000,
        BIND_BUFFER_MEMORY_INFO                                           = 1000157000,
        BIND_IMAGE_MEMORY_INFO                                            = 1000157001,
        PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES                            = 1000083000,
        MEMORY_DEDICATED_REQUIREMENTS                                     = 1000127000,
        MEMORY_DEDICATED_ALLOCATE_INFO                                    = 1000127001,
        MEMORY_ALLOCATE_FLAGS_INFO                                        = 1000060000,
        DEVICE_GROUP_RENDER_PASS_BEGIN_INFO                               = 1000060003,
        DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO                            = 1000060004,
        DEVICE_GROUP_SUBMIT_INFO                                          = 1000060005,
        DEVICE_GROUP_BIND_SPARSE_INFO                                     = 1000060006,
        BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO                              = 1000060013,
        BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO                               = 1000060014,
        PHYSICAL_DEVICE_GROUP_PROPERTIES                                  = 1000070000,
        DEVICE_GROUP_DEVICE_CREATE_INFO                                   = 1000070001,
        BUFFER_MEMORY_REQUIREMENTS_INFO_2                                 = 1000146000,
        IMAGE_MEMORY_REQUIREMENTS_INFO_2                                  = 1000146001,
        IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2                           = 1000146002,
        MEMORY_REQUIREMENTS_2                                             = 1000146003,
        SPARSE_IMAGE_MEMORY_REQUIREMENTS_2                                = 1000146004,
        PHYSICAL_DEVICE_FEATURES_2                                        = 1000059000,
        PHYSICAL_DEVICE_PROPERTIES_2                                      = 1000059001,
        FORMAT_PROPERTIES_2                                               = 1000059002,
        IMAGE_FORMAT_PROPERTIES_2                                         = 1000059003,
        PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2                               = 1000059004,
        QUEUE_FAMILY_PROPERTIES_2                                         = 1000059005,
        PHYSICAL_DEVICE_MEMORY_PROPERTIES_2                               = 1000059006,
        SPARSE_IMAGE_FORMAT_PROPERTIES_2                                  = 1000059007,
        PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2                        = 1000059008,
        PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES                         = 1000117000,
        RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO                   = 1000117001,
        IMAGE_VIEW_USAGE_CREATE_INFO                                      = 1000117002,
        PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO             = 1000117003,
        RENDER_PASS_MULTIVIEW_CREATE_INFO                                 = 1000053000,
        PHYSICAL_DEVICE_MULTIVIEW_FEATURES                                = 1000053001,
        PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES                              = 1000053002,
        PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES                        = 1000120000,
        PROTECTED_SUBMIT_INFO                                             = 1000145000,
        PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES                         = 1000145001,
        PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES                       = 1000145002,
        DEVICE_QUEUE_INFO_2                                               = 1000145003,
        SAMPLER_YCBCR_CONVERSION_CREATE_INFO                              = 1000156000,
        SAMPLER_YCBCR_CONVERSION_INFO                                     = 1000156001,
        BIND_IMAGE_PLANE_MEMORY_INFO                                      = 1000156002,
        IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO                              = 1000156003,
        PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES                 = 1000156004,
        SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES                  = 1000156005,
        DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO                            = 1000085000,
        PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO                        = 1000071000,
        EXTERNAL_IMAGE_FORMAT_PROPERTIES                                  = 1000071001,
        PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO                              = 1000071002,
        EXTERNAL_BUFFER_PROPERTIES                                        = 1000071003,
        PHYSICAL_DEVICE_ID_PROPERTIES                                     = 1000071004,
        EXTERNAL_MEMORY_BUFFER_CREATE_INFO                                = 1000072000,
        EXTERNAL_MEMORY_IMAGE_CREATE_INFO                                 = 1000072001,
        EXPORT_MEMORY_ALLOCATE_INFO                                       = 1000072002,
        PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO                               = 1000112000,
        EXTERNAL_FENCE_PROPERTIES                                         = 1000112001,
        EXPORT_FENCE_CREATE_INFO                                          = 1000113000,
        EXPORT_SEMAPHORE_CREATE_INFO                                      = 1000077000,
        PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO                           = 1000076000,
        EXTERNAL_SEMAPHORE_PROPERTIES                                     = 1000076001,
        PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES                          = 1000168000,
        DESCRIPTOR_SET_LAYOUT_SUPPORT                                     = 1000168001,
        PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES                   = 1000063000,
        PHYSICAL_DEVICE_VULKAN_1_1_FEATURES                               = 49,
        PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES                             = 50,
        PHYSICAL_DEVICE_VULKAN_1_2_FEATURES                               = 51,
        PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES                             = 52,
        IMAGE_FORMAT_LIST_CREATE_INFO                                     = 1000147000,
        ATTACHMENT_DESCRIPTION_2                                          = 1000109000,
        ATTACHMENT_REFERENCE_2                                            = 1000109001,
        SUBPASS_DESCRIPTION_2                                             = 1000109002,
        SUBPASS_DEPENDENCY_2                                              = 1000109003,
        RENDER_PASS_CREATE_INFO_2                                         = 1000109004,
        SUBPASS_BEGIN_INFO                                                = 1000109005,
        SUBPASS_END_INFO                                                  = 1000109006,
        PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES                             = 1000177000,
        PHYSICAL_DEVICE_DRIVER_PROPERTIES                                 = 1000196000,
        PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES                      = 1000180000,
        PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES                      = 1000082000,
        PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES                         = 1000197000,
        DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO                   = 1000161000,
        PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES                      = 1000161001,
        PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES                    = 1000161002,
        DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO            = 1000161003,
        DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT           = 1000161004,
        PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES                  = 1000199000,
        SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE                         = 1000199001,
        PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES                      = 1000221000,
        IMAGE_STENCIL_USAGE_CREATE_INFO                                   = 1000246000,
        PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES                  = 1000130000,
        SAMPLER_REDUCTION_MODE_CREATE_INFO                                = 1000130001,
        PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES                      = 1000211000,
        PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES                    = 1000108000,
        FRAMEBUFFER_ATTACHMENTS_CREATE_INFO                               = 1000108001,
        FRAMEBUFFER_ATTACHMENT_IMAGE_INFO                                 = 1000108002,
        RENDER_PASS_ATTACHMENT_BEGIN_INFO                                 = 1000108003,
        PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES           = 1000253000,
        PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES           = 1000175000,
        PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES           = 1000241000,
        ATTACHMENT_REFERENCE_STENCIL_LAYOUT                               = 1000241001,
        ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT                             = 1000241002,
        PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES                         = 1000261000,
        PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES                       = 1000207000,
        PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES                     = 1000207001,
        SEMAPHORE_TYPE_CREATE_INFO                                        = 1000207002,
        TIMELINE_SEMAPHORE_SUBMIT_INFO                                    = 1000207003,
        SEMAPHORE_WAIT_INFO                                               = 1000207004,
        SEMAPHORE_SIGNAL_INFO                                             = 1000207005,
        PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES                    = 1000257000,
        BUFFER_DEVICE_ADDRESS_INFO                                        = 1000244001,
        BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO                         = 1000257002,
        MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO                       = 1000257003,
        DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO                         = 1000257004,
        SWAPCHAIN_CREATE_INFO_KHR                                         = 1000001000,
        PRESENT_INFO_KHR                                                  = 1000001001,
        DEVICE_GROUP_PRESENT_CAPABILITIES_KHR                             = 1000060007,
        IMAGE_SWAPCHAIN_CREATE_INFO_KHR                                   = 1000060008,
        BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR                              = 1000060009,
        ACQUIRE_NEXT_IMAGE_INFO_KHR                                       = 1000060010,
        DEVICE_GROUP_PRESENT_INFO_KHR                                     = 1000060011,
        DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR                            = 1000060012,
        DISPLAY_MODE_CREATE_INFO_KHR                                      = 1000002000,
        DISPLAY_SURFACE_CREATE_INFO_KHR                                   = 1000002001,
        DISPLAY_PRESENT_INFO_KHR                                          = 1000003000,
        XLIB_SURFACE_CREATE_INFO_KHR                                      = 1000004000,
        XCB_SURFACE_CREATE_INFO_KHR                                       = 1000005000,
        WAYLAND_SURFACE_CREATE_INFO_KHR                                   = 1000006000,
        ANDROID_SURFACE_CREATE_INFO_KHR                                   = 1000008000,
        WIN32_SURFACE_CREATE_INFO_KHR                                     = 1000009000,
        DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT                             = 1000011000,
        PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD              = 1000018000,
        DEBUG_MARKER_OBJECT_NAME_INFO_EXT                                 = 1000022000,
        DEBUG_MARKER_OBJECT_TAG_INFO_EXT                                  = 1000022001,
        DEBUG_MARKER_MARKER_INFO_EXT                                      = 1000022002,
        VIDEO_PROFILE_KHR                                                 = 1000023000,
        VIDEO_CAPABILITIES_KHR                                            = 1000023001,
        VIDEO_PICTURE_RESOURCE_KHR                                        = 1000023002,
        VIDEO_GET_MEMORY_PROPERTIES_KHR                                   = 1000023003,
        VIDEO_BIND_MEMORY_KHR                                             = 1000023004,
        VIDEO_SESSION_CREATE_INFO_KHR                                     = 1000023005,
        VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR                          = 1000023006,
        VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR                          = 1000023007,
        VIDEO_BEGIN_CODING_INFO_KHR                                       = 1000023008,
        VIDEO_END_CODING_INFO_KHR                                         = 1000023009,
        VIDEO_CODING_CONTROL_INFO_KHR                                     = 1000023010,
        VIDEO_REFERENCE_SLOT_KHR                                          = 1000023011,
        VIDEO_QUEUE_FAMILY_PROPERTIES_2_KHR                               = 1000023012,
        VIDEO_PROFILES_KHR                                                = 1000023013,
        PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR                             = 1000023014,
        VIDEO_FORMAT_PROPERTIES_KHR                                       = 1000023015,
        VIDEO_DECODE_INFO_KHR                                             = 1000024000,
        DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV                         = 1000026000,
        DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV                        = 1000026001,
        DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV                      = 1000026002,
        PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT                   = 1000028000,
        PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT                 = 1000028001,
        PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT               = 1000028002,
        CU_MODULE_CREATE_INFO_NVX                                         = 1000029000,
        CU_FUNCTION_CREATE_INFO_NVX                                       = 1000029001,
        CU_LAUNCH_INFO_NVX                                                = 1000029002,
        IMAGE_VIEW_HANDLE_INFO_NVX                                        = 1000030000,
        IMAGE_VIEW_ADDRESS_PROPERTIES_NVX                                 = 1000030001,
        VIDEO_ENCODE_H264_CAPABILITIES_EXT                                = 1000038000,
        VIDEO_ENCODE_H264_SESSION_CREATE_INFO_EXT                         = 1000038001,
        VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT              = 1000038002,
        VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT                 = 1000038003,
        VIDEO_ENCODE_H264_VCL_FRAME_INFO_EXT                              = 1000038004,
        VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT                               = 1000038005,
        VIDEO_ENCODE_H264_NALU_SLICE_EXT                                  = 1000038006,
        VIDEO_ENCODE_H264_EMIT_PICTURE_PARAMETERS_EXT                     = 1000038007,
        VIDEO_ENCODE_H264_PROFILE_EXT                                     = 1000038008,
        VIDEO_DECODE_H264_CAPABILITIES_EXT                                = 1000040000,
        VIDEO_DECODE_H264_SESSION_CREATE_INFO_EXT                         = 1000040001,
        VIDEO_DECODE_H264_PICTURE_INFO_EXT                                = 1000040002,
        VIDEO_DECODE_H264_MVC_EXT                                         = 1000040003,
        VIDEO_DECODE_H264_PROFILE_EXT                                     = 1000040004,
        VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT              = 1000040005,
        VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT                 = 1000040006,
        VIDEO_DECODE_H264_DPB_SLOT_INFO_EXT                               = 1000040007,
        TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD                          = 1000041000,
        STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP                         = 1000049000,
        PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV                  = 1000050000,
        EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV                              = 1000056000,
        EXPORT_MEMORY_ALLOCATE_INFO_NV                                    = 1000056001,
        IMPORT_MEMORY_WIN32_HANDLE_INFO_NV                                = 1000057000,
        EXPORT_MEMORY_WIN32_HANDLE_INFO_NV                                = 1000057001,
        WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV                         = 1000058000,
        VALIDATION_FLAGS_EXT                                              = 1000061000,
        VI_SURFACE_CREATE_INFO_NN                                         = 1000062000,
        PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES_EXT         = 1000066000,
        IMAGE_VIEW_ASTC_DECODE_MODE_EXT                                   = 1000067000,
        PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT                          = 1000067001,
        IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR                               = 1000073000,
        EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR                               = 1000073001,
        MEMORY_WIN32_HANDLE_PROPERTIES_KHR                                = 1000073002,
        MEMORY_GET_WIN32_HANDLE_INFO_KHR                                  = 1000073003,
        IMPORT_MEMORY_FD_INFO_KHR                                         = 1000074000,
        MEMORY_FD_PROPERTIES_KHR                                          = 1000074001,
        MEMORY_GET_FD_INFO_KHR                                            = 1000074002,
        WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR                        = 1000075000,
        IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR                            = 1000078000,
        EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR                            = 1000078001,
        D3D12_FENCE_SUBMIT_INFO_KHR                                       = 1000078002,
        SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR                               = 1000078003,
        IMPORT_SEMAPHORE_FD_INFO_KHR                                      = 1000079000,
        SEMAPHORE_GET_FD_INFO_KHR                                         = 1000079001,
        PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR                    = 1000080000,
        COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT         = 1000081000,
        PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT                = 1000081001,
        CONDITIONAL_RENDERING_BEGIN_INFO_EXT                              = 1000081002,
        PRESENT_REGIONS_KHR                                               = 1000084000,
        PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV                  = 1000087000,
        SURFACE_CAPABILITIES_2_EXT                                        = 1000090000,
        DISPLAY_POWER_INFO_EXT                                            = 1000091000,
        DEVICE_EVENT_INFO_EXT                                             = 1000091001,
        DISPLAY_EVENT_INFO_EXT                                            = 1000091002,
        SWAPCHAIN_COUNTER_CREATE_INFO_EXT                                 = 1000091003,
        PRESENT_TIMES_INFO_GOOGLE                                         = 1000092000,
        PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX      = 1000097000,
        PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV                    = 1000098000,
        PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT                  = 1000099000,
        PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT                  = 1000099001,
        PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT         = 1000101000,
        PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT         = 1000101001,
        PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT                    = 1000102000,
        PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT           = 1000102001,
        HDR_METADATA_EXT                                                  = 1000105000,
        SHARED_PRESENT_SURFACE_CAPABILITIES_KHR                           = 1000111000,
        IMPORT_FENCE_WIN32_HANDLE_INFO_KHR                                = 1000114000,
        EXPORT_FENCE_WIN32_HANDLE_INFO_KHR                                = 1000114001,
        FENCE_GET_WIN32_HANDLE_INFO_KHR                                   = 1000114002,
        IMPORT_FENCE_FD_INFO_KHR                                          = 1000115000,
        FENCE_GET_FD_INFO_KHR                                             = 1000115001,
        PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR                    = 1000116000,
        PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR                  = 1000116001,
        QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR                            = 1000116002,
        PERFORMANCE_QUERY_SUBMIT_INFO_KHR                                 = 1000116003,
        ACQUIRE_PROFILING_LOCK_INFO_KHR                                   = 1000116004,
        PERFORMANCE_COUNTER_KHR                                           = 1000116005,
        PERFORMANCE_COUNTER_DESCRIPTION_KHR                               = 1000116006,
        PHYSICAL_DEVICE_SURFACE_INFO_2_KHR                                = 1000119000,
        SURFACE_CAPABILITIES_2_KHR                                        = 1000119001,
        SURFACE_FORMAT_2_KHR                                              = 1000119002,
        DISPLAY_PROPERTIES_2_KHR                                          = 1000121000,
        DISPLAY_PLANE_PROPERTIES_2_KHR                                    = 1000121001,
        DISPLAY_MODE_PROPERTIES_2_KHR                                     = 1000121002,
        DISPLAY_PLANE_INFO_2_KHR                                          = 1000121003,
        DISPLAY_PLANE_CAPABILITIES_2_KHR                                  = 1000121004,
        IOS_SURFACE_CREATE_INFO_MVK                                       = 1000122000,
        MACOS_SURFACE_CREATE_INFO_MVK                                     = 1000123000,
        DEBUG_UTILS_OBJECT_NAME_INFO_EXT                                  = 1000128000,
        DEBUG_UTILS_OBJECT_TAG_INFO_EXT                                   = 1000128001,
        DEBUG_UTILS_LABEL_EXT                                             = 1000128002,
        DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT                           = 1000128003,
        DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT                             = 1000128004,
        ANDROID_HARDWARE_BUFFER_USAGE_ANDROID                             = 1000129000,
        ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID                        = 1000129001,
        ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID                 = 1000129002,
        IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID                       = 1000129003,
        MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID                   = 1000129004,
        EXTERNAL_FORMAT_ANDROID                                           = 1000129005,
        PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES_EXT                 = 1000138000,
        PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES_EXT               = 1000138001,
        WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK_EXT                     = 1000138002,
        DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO_EXT              = 1000138003,
        SAMPLE_LOCATIONS_INFO_EXT                                         = 1000143000,
        RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT                       = 1000143001,
        PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT                   = 1000143002,
        PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT                   = 1000143003,
        MULTISAMPLE_PROPERTIES_EXT                                        = 1000143004,
        PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT             = 1000148000,
        PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT           = 1000148001,
        PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT               = 1000148002,
        PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV                   = 1000149000,
        WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR                   = 1000150007,
        ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR                    = 1000150000,
        ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR                    = 1000150002,
        ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR                    = 1000150003,
        ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR                = 1000150004,
        ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR                = 1000150005,
        ACCELERATION_STRUCTURE_GEOMETRY_KHR                               = 1000150006,
        ACCELERATION_STRUCTURE_VERSION_INFO_KHR                           = 1000150009,
        COPY_ACCELERATION_STRUCTURE_INFO_KHR                              = 1000150010,
        COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR                    = 1000150011,
        COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR                    = 1000150012,
        PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR               = 1000150013,
        PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR             = 1000150014,
        ACCELERATION_STRUCTURE_CREATE_INFO_KHR                            = 1000150017,
        ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR                       = 1000150020,
        PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR                 = 1000347000,
        PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR               = 1000347001,
        RAY_TRACING_PIPELINE_CREATE_INFO_KHR                              = 1000150015,
        RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR                          = 1000150016,
        RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR                    = 1000150018,
        PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR                            = 1000348013,
        PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV                 = 1000152000,
        PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV                    = 1000154000,
        PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV                  = 1000154001,
        DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT                           = 1000158000,
        PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT                = 1000158002,
        IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT                    = 1000158003,
        IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT                = 1000158004,
        IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT                          = 1000158005,
        VALIDATION_CACHE_CREATE_INFO_EXT                                  = 1000160000,
        SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT                    = 1000160001,
        PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR                   = 1000163000,
        PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR                 = 1000163001,
        PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV         = 1000164000,
        PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV                    = 1000164001,
        PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV                  = 1000164002,
        PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV        = 1000164005,
        RAY_TRACING_PIPELINE_CREATE_INFO_NV                               = 1000165000,
        ACCELERATION_STRUCTURE_CREATE_INFO_NV                             = 1000165001,
        GEOMETRY_NV                                                       = 1000165003,
        GEOMETRY_TRIANGLES_NV                                             = 1000165004,
        GEOMETRY_AABB_NV                                                  = 1000165005,
        BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV                        = 1000165006,
        WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV                    = 1000165007,
        ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV                = 1000165008,
        PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV                         = 1000165009,
        RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV                           = 1000165011,
        ACCELERATION_STRUCTURE_INFO_NV                                    = 1000165012,
        PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV          = 1000166000,
        PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV        = 1000166001,
        PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT                  = 1000170000,
        FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT               = 1000170001,
        DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_EXT                      = 1000174000,
        IMPORT_MEMORY_HOST_POINTER_INFO_EXT                               = 1000178000,
        MEMORY_HOST_POINTER_PROPERTIES_EXT                                = 1000178001,
        PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT               = 1000178002,
        PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR                         = 1000181000,
        PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD                         = 1000183000,
        CALIBRATED_TIMESTAMP_INFO_EXT                                     = 1000184000,
        PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD                        = 1000185000,
        VIDEO_DECODE_H265_CAPABILITIES_EXT                                = 1000187000,
        VIDEO_DECODE_H265_SESSION_CREATE_INFO_EXT                         = 1000187001,
        VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT              = 1000187002,
        VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT                 = 1000187003,
        VIDEO_DECODE_H265_PROFILE_EXT                                     = 1000187004,
        VIDEO_DECODE_H265_PICTURE_INFO_EXT                                = 1000187005,
        VIDEO_DECODE_H265_DPB_SLOT_INFO_EXT                               = 1000187006,
        DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD                      = 1000189000,
        PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT           = 1000190000,
        PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT               = 1000190001,
        PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT             = 1000190002,
        PRESENT_FRAME_TOKEN_GGP                                           = 1000191000,
        PIPELINE_CREATION_FEEDBACK_CREATE_INFO_EXT                        = 1000192000,
        PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV            = 1000201000,
        PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV                           = 1000202000,
        PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV                         = 1000202001,
        PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_NV           = 1000203000,
        PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV                = 1000204000,
        PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV          = 1000205000,
        PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV                     = 1000205002,
        CHECKPOINT_DATA_NV                                                = 1000206000,
        QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV                             = 1000206001,
        PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL         = 1000209000,
        QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL                    = 1000210000,
        INITIALIZE_PERFORMANCE_API_INFO_INTEL                             = 1000210001,
        PERFORMANCE_MARKER_INFO_INTEL                                     = 1000210002,
        PERFORMANCE_STREAM_MARKER_INFO_INTEL                              = 1000210003,
        PERFORMANCE_OVERRIDE_INFO_INTEL                                   = 1000210004,
        PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL                      = 1000210005,
        PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT                       = 1000212000,
        DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD                       = 1000213000,
        SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD                      = 1000213001,
        IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA                             = 1000214000,
        PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES_KHR          = 1000215000,
        METAL_SURFACE_CREATE_INFO_EXT                                     = 1000217000,
        PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT                 = 1000218000,
        PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT               = 1000218001,
        RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT                  = 1000218002,
        PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES_EXT              = 1000225000,
        PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO_EXT      = 1000225001,
        PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES_EXT                = 1000225002,
        FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR                         = 1000226000,
        PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR              = 1000226001,
        PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR              = 1000226002,
        PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR                = 1000226003,
        PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR                         = 1000226004,
        PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD                      = 1000227000,
        PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD                      = 1000229000,
        PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT            = 1000234000,
        PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT                      = 1000237000,
        PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT                      = 1000238000,
        MEMORY_PRIORITY_ALLOCATE_INFO_EXT                                 = 1000238001,
        SURFACE_PROTECTED_CAPABILITIES_KHR                                = 1000239000,
        PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV   = 1000240000,
        PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT                = 1000244000,
        BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT                             = 1000244002,
        PHYSICAL_DEVICE_TOOL_PROPERTIES_EXT                               = 1000245000,
        VALIDATION_FEATURES_EXT                                           = 1000247000,
        PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV                    = 1000249000,
        COOPERATIVE_MATRIX_PROPERTIES_NV                                  = 1000249001,
        PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV                  = 1000249002,
        PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV               = 1000250000,
        PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV                  = 1000250001,
        FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV                          = 1000250002,
        PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT            = 1000251000,
        PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT                   = 1000252000,
        PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT                     = 1000254000,
        PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT     = 1000254001,
        PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT                   = 1000254002,
        SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT                            = 1000255000,
        SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT                    = 1000255002,
        SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT                      = 1000255001,
        HEADLESS_SURFACE_CREATE_INFO_EXT                                  = 1000256000,
        PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT                   = 1000259000,
        PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT                 = 1000259001,
        PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT                 = 1000259002,
        PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT                  = 1000260000,
        PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT                     = 1000265000,
        PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT               = 1000267000,
        PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR       = 1000269000,
        PIPELINE_INFO_KHR                                                 = 1000269001,
        PIPELINE_EXECUTABLE_PROPERTIES_KHR                                = 1000269002,
        PIPELINE_EXECUTABLE_INFO_KHR                                      = 1000269003,
        PIPELINE_EXECUTABLE_STATISTIC_KHR                                 = 1000269004,
        PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR                   = 1000269005,
        PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES_EXT   = 1000276000,
        PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV           = 1000277000,
        GRAPHICS_SHADER_GROUP_CREATE_INFO_NV                              = 1000277001,
        GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV                    = 1000277002,
        INDIRECT_COMMANDS_LAYOUT_TOKEN_NV                                 = 1000277003,
        INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV                           = 1000277004,
        GENERATED_COMMANDS_INFO_NV                                        = 1000277005,
        GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV                    = 1000277006,
        PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV             = 1000277007,
        PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV            = 1000278000,
        COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV               = 1000278001,
        PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT               = 1000281000,
        PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES_EXT             = 1000281001,
        COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM        = 1000282000,
        RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM                             = 1000282001,
        PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT                 = 1000284000,
        DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT                       = 1000284001,
        DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT                            = 1000284002,
        PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT                         = 1000286000,
        PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT                       = 1000286001,
        SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT                       = 1000287000,
        PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT                = 1000287001,
        PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT                  = 1000287002,
        PIPELINE_LIBRARY_CREATE_INFO_KHR                                  = 1000290000,
        PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES_EXT                         = 1000295000,
        DEVICE_PRIVATE_DATA_CREATE_INFO_EXT                               = 1000295001,
        PRIVATE_DATA_SLOT_CREATE_INFO_EXT                                 = 1000295002,
        PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES_EXT      = 1000297000,
        VIDEO_ENCODE_INFO_KHR                                             = 1000299000,
        VIDEO_ENCODE_RATE_CONTROL_INFO_KHR                                = 1000299001,
        PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV                    = 1000300000,
        DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV                          = 1000300001,
        MEMORY_BARRIER_2_KHR                                              = 1000314000,
        BUFFER_MEMORY_BARRIER_2_KHR                                       = 1000314001,
        IMAGE_MEMORY_BARRIER_2_KHR                                        = 1000314002,
        DEPENDENCY_INFO_KHR                                               = 1000314003,
        SUBMIT_INFO_2_KHR                                                 = 1000314004,
        SEMAPHORE_SUBMIT_INFO_KHR                                         = 1000314005,
        COMMAND_BUFFER_SUBMIT_INFO_KHR                                    = 1000314006,
        PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES_KHR                    = 1000314007,
        QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV                           = 1000314008,
        CHECKPOINT_DATA_2_NV                                              = 1000314009,
        PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR = 1000323000,
        PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES_KHR     = 1000325000,
        PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV         = 1000326000,
        PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV           = 1000326001,
        PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV          = 1000326002,
        ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV          = 1000327000,
        PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV               = 1000327001,
        ACCELERATION_STRUCTURE_MOTION_INFO_NV                             = 1000327002,
        PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT            = 1000330000,
        PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT               = 1000332000,
        PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT             = 1000332001,
        COPY_COMMAND_TRANSFORM_INFO_QCOM                                  = 1000333000,
        PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES_EXT                     = 1000335000,
        PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR     = 1000336000,
        COPY_BUFFER_INFO_2_KHR                                            = 1000337000,
        COPY_IMAGE_INFO_2_KHR                                             = 1000337001,
        COPY_BUFFER_TO_IMAGE_INFO_2_KHR                                   = 1000337002,
        COPY_IMAGE_TO_BUFFER_INFO_2_KHR                                   = 1000337003,
        BLIT_IMAGE_INFO_2_KHR                                             = 1000337004,
        RESOLVE_IMAGE_INFO_2_KHR                                          = 1000337005,
        BUFFER_COPY_2_KHR                                                 = 1000337006,
        IMAGE_COPY_2_KHR                                                  = 1000337007,
        IMAGE_BLIT_2_KHR                                                  = 1000337008,
        BUFFER_IMAGE_COPY_2_KHR                                           = 1000337009,
        IMAGE_RESOLVE_2_KHR                                               = 1000337010,
        PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT                         = 1000340000,
        DIRECTFB_SURFACE_CREATE_INFO_EXT                                  = 1000346000,
        PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_VALVE            = 1000351000,
        MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_VALVE                         = 1000351002,
        PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT           = 1000352000,
        VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT                            = 1000352001,
        VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT                          = 1000352002,
        PHYSICAL_DEVICE_DRM_PROPERTIES_EXT                                = 1000353000,
        IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA                          = 1000364000,
        MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA                           = 1000364001,
        MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA                             = 1000364002,
        IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA                       = 1000365000,
        SUBPASSS_SHADING_PIPELINE_CREATE_INFO_HUAWEI                      = 1000369000,
        PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI                   = 1000369001,
        PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI                 = 1000369002,
        SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA                          = 1000365001,
        PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT             = 1000377000,
        SCREEN_SURFACE_CREATE_INFO_QNX                                    = 1000378000,
        PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT                   = 1000381000,
        PIPELINE_COLOR_WRITE_CREATE_INFO_EXT                              = 1000381001,
        PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_EXT                = 1000388000,
        QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_EXT                       = 1000388001,
        PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT                           = 1000392000,
        PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT                         = 1000392001,
        PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES                         = PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,
        PHYSICAL_DEVICE_SHADER_DRAW_PARAMETER_FEATURES                    = PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES,
        DEBUG_REPORT_CREATE_INFO_EXT                                      = DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT,
        RENDER_PASS_MULTIVIEW_CREATE_INFO_KHR                             = RENDER_PASS_MULTIVIEW_CREATE_INFO,
        PHYSICAL_DEVICE_MULTIVIEW_FEATURES_KHR                            = PHYSICAL_DEVICE_MULTIVIEW_FEATURES,
        PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES_KHR                          = PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES,
        PHYSICAL_DEVICE_FEATURES_2_KHR                                    = PHYSICAL_DEVICE_FEATURES_2,
        PHYSICAL_DEVICE_PROPERTIES_2_KHR                                  = PHYSICAL_DEVICE_PROPERTIES_2,
        FORMAT_PROPERTIES_2_KHR                                           = FORMAT_PROPERTIES_2,
        IMAGE_FORMAT_PROPERTIES_2_KHR                                     = IMAGE_FORMAT_PROPERTIES_2,
        PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2_KHR                           = PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2,
        QUEUE_FAMILY_PROPERTIES_2_KHR                                     = QUEUE_FAMILY_PROPERTIES_2,
        PHYSICAL_DEVICE_MEMORY_PROPERTIES_2_KHR                           = PHYSICAL_DEVICE_MEMORY_PROPERTIES_2,
        SPARSE_IMAGE_FORMAT_PROPERTIES_2_KHR                              = SPARSE_IMAGE_FORMAT_PROPERTIES_2,
        PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2_KHR                    = PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2,
        MEMORY_ALLOCATE_FLAGS_INFO_KHR                                    = MEMORY_ALLOCATE_FLAGS_INFO,
        DEVICE_GROUP_RENDER_PASS_BEGIN_INFO_KHR                           = DEVICE_GROUP_RENDER_PASS_BEGIN_INFO,
        DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO_KHR                        = DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO,
        DEVICE_GROUP_SUBMIT_INFO_KHR                                      = DEVICE_GROUP_SUBMIT_INFO,
        DEVICE_GROUP_BIND_SPARSE_INFO_KHR                                 = DEVICE_GROUP_BIND_SPARSE_INFO,
        BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO_KHR                          = BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO,
        BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO_KHR                           = BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO,
        PHYSICAL_DEVICE_GROUP_PROPERTIES_KHR                              = PHYSICAL_DEVICE_GROUP_PROPERTIES,
        DEVICE_GROUP_DEVICE_CREATE_INFO_KHR                               = DEVICE_GROUP_DEVICE_CREATE_INFO,
        PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO_KHR                    = PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO,
        EXTERNAL_IMAGE_FORMAT_PROPERTIES_KHR                              = EXTERNAL_IMAGE_FORMAT_PROPERTIES,
        PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO_KHR                          = PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO,
        EXTERNAL_BUFFER_PROPERTIES_KHR                                    = EXTERNAL_BUFFER_PROPERTIES,
        PHYSICAL_DEVICE_ID_PROPERTIES_KHR                                 = PHYSICAL_DEVICE_ID_PROPERTIES,
        EXTERNAL_MEMORY_BUFFER_CREATE_INFO_KHR                            = EXTERNAL_MEMORY_BUFFER_CREATE_INFO,
        EXTERNAL_MEMORY_IMAGE_CREATE_INFO_KHR                             = EXTERNAL_MEMORY_IMAGE_CREATE_INFO,
        EXPORT_MEMORY_ALLOCATE_INFO_KHR                                   = EXPORT_MEMORY_ALLOCATE_INFO,
        PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO_KHR                       = PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO,
        EXTERNAL_SEMAPHORE_PROPERTIES_KHR                                 = EXTERNAL_SEMAPHORE_PROPERTIES,
        EXPORT_SEMAPHORE_CREATE_INFO_KHR                                  = EXPORT_SEMAPHORE_CREATE_INFO,
        PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES_KHR                  = PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,
        PHYSICAL_DEVICE_FLOAT16_INT8_FEATURES_KHR                         = PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES,
        PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES_KHR                        = PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES,
        DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO_KHR                        = DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO,
        SURFACE_CAPABILITIES2_EXT                                         = SURFACE_CAPABILITIES_2_EXT,
        PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES_KHR                = PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES,
        FRAMEBUFFER_ATTACHMENTS_CREATE_INFO_KHR                           = FRAMEBUFFER_ATTACHMENTS_CREATE_INFO,
        FRAMEBUFFER_ATTACHMENT_IMAGE_INFO_KHR                             = FRAMEBUFFER_ATTACHMENT_IMAGE_INFO,
        RENDER_PASS_ATTACHMENT_BEGIN_INFO_KHR                             = RENDER_PASS_ATTACHMENT_BEGIN_INFO,
        ATTACHMENT_DESCRIPTION_2_KHR                                      = ATTACHMENT_DESCRIPTION_2,
        ATTACHMENT_REFERENCE_2_KHR                                        = ATTACHMENT_REFERENCE_2,
        SUBPASS_DESCRIPTION_2_KHR                                         = SUBPASS_DESCRIPTION_2,
        SUBPASS_DEPENDENCY_2_KHR                                          = SUBPASS_DEPENDENCY_2,
        RENDER_PASS_CREATE_INFO_2_KHR                                     = RENDER_PASS_CREATE_INFO_2,
        SUBPASS_BEGIN_INFO_KHR                                            = SUBPASS_BEGIN_INFO,
        SUBPASS_END_INFO_KHR                                              = SUBPASS_END_INFO,
        PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO_KHR                           = PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO,
        EXTERNAL_FENCE_PROPERTIES_KHR                                     = EXTERNAL_FENCE_PROPERTIES,
        EXPORT_FENCE_CREATE_INFO_KHR                                      = EXPORT_FENCE_CREATE_INFO,
        PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES_KHR                     = PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES,
        RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO_KHR               = RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO,
        IMAGE_VIEW_USAGE_CREATE_INFO_KHR                                  = IMAGE_VIEW_USAGE_CREATE_INFO,

        PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO_KHR =
            PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO,
        PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR        = PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES,
        PHYSICAL_DEVICE_VARIABLE_POINTER_FEATURES_KHR         = PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES_KHR,
        MEMORY_DEDICATED_REQUIREMENTS_KHR                     = MEMORY_DEDICATED_REQUIREMENTS,
        MEMORY_DEDICATED_ALLOCATE_INFO_KHR                    = MEMORY_DEDICATED_ALLOCATE_INFO,
        PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES_EXT  = PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES,
        SAMPLER_REDUCTION_MODE_CREATE_INFO_EXT                = SAMPLER_REDUCTION_MODE_CREATE_INFO,
        BUFFER_MEMORY_REQUIREMENTS_INFO_2_KHR                 = BUFFER_MEMORY_REQUIREMENTS_INFO_2,
        IMAGE_MEMORY_REQUIREMENTS_INFO_2_KHR                  = IMAGE_MEMORY_REQUIREMENTS_INFO_2,
        IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2_KHR           = IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2,
        MEMORY_REQUIREMENTS_2_KHR                             = MEMORY_REQUIREMENTS_2,
        SPARSE_IMAGE_MEMORY_REQUIREMENTS_2_KHR                = SPARSE_IMAGE_MEMORY_REQUIREMENTS_2,
        IMAGE_FORMAT_LIST_CREATE_INFO_KHR                     = IMAGE_FORMAT_LIST_CREATE_INFO,
        SAMPLER_YCBCR_CONVERSION_CREATE_INFO_KHR              = SAMPLER_YCBCR_CONVERSION_CREATE_INFO,
        SAMPLER_YCBCR_CONVERSION_INFO_KHR                     = SAMPLER_YCBCR_CONVERSION_INFO,
        BIND_IMAGE_PLANE_MEMORY_INFO_KHR                      = BIND_IMAGE_PLANE_MEMORY_INFO,
        IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO_KHR              = IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO,
        PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES_KHR = PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES,
        SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES_KHR  = SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES,
        BIND_BUFFER_MEMORY_INFO_KHR                           = BIND_BUFFER_MEMORY_INFO,
        BIND_IMAGE_MEMORY_INFO_KHR                            = BIND_IMAGE_MEMORY_INFO,
        DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO_EXT   = DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO,
        PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES_EXT      = PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES,
        PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES_EXT    = PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES,

        DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO_EXT =
            DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO,

        DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT_EXT =
            DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT,
        PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES_KHR = PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES,
        DESCRIPTOR_SET_LAYOUT_SUPPORT_KHR            = DESCRIPTOR_SET_LAYOUT_SUPPORT,

        PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES_KHR =
            PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES,
        PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES_KHR            = PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES,
        PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES_KHR     = PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES,
        PHYSICAL_DEVICE_DRIVER_PROPERTIES_KHR                = PHYSICAL_DEVICE_DRIVER_PROPERTIES,
        PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES_KHR        = PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES,
        PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES_KHR = PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES,
        SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE_KHR        = SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE,
        PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES_KHR      = PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES,
        PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES_KHR    = PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES,
        SEMAPHORE_TYPE_CREATE_INFO_KHR                       = SEMAPHORE_TYPE_CREATE_INFO,
        TIMELINE_SEMAPHORE_SUBMIT_INFO_KHR                   = TIMELINE_SEMAPHORE_SUBMIT_INFO,
        SEMAPHORE_WAIT_INFO_KHR                              = SEMAPHORE_WAIT_INFO,
        SEMAPHORE_SIGNAL_INFO_KHR                            = SEMAPHORE_SIGNAL_INFO,
        QUERY_POOL_CREATE_INFO_INTEL                         = QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL,
        PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES_KHR     = PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES,
        PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES_EXT     = PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES,

        PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES_KHR =
            PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES,
        ATTACHMENT_REFERENCE_STENCIL_LAYOUT_KHR     = ATTACHMENT_REFERENCE_STENCIL_LAYOUT,
        ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT_KHR   = ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT,
        PHYSICAL_DEVICE_BUFFER_ADDRESS_FEATURES_EXT = PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT,
        BUFFER_DEVICE_ADDRESS_INFO_EXT              = BUFFER_DEVICE_ADDRESS_INFO,
        IMAGE_STENCIL_USAGE_CREATE_INFO_EXT         = IMAGE_STENCIL_USAGE_CREATE_INFO,

        PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES_KHR =
            PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES,
        PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_KHR = PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES,
        BUFFER_DEVICE_ADDRESS_INFO_KHR                     = BUFFER_DEVICE_ADDRESS_INFO,
        BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO_KHR      = BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO,
        MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO_KHR    = MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO,
        DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO_KHR      = DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO,
        PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES_EXT      = PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES,
        MAX_ENUM                                           = 0x7FFFFFFF
    }

    public enum VkImageLayout
    {
        UNDEFINED                                      = 0,
        GENERAL                                        = 1,
        COLOR_ATTACHMENT_OPTIMAL                       = 2,
        DEPTH_STENCIL_ATTACHMENT_OPTIMAL               = 3,
        DEPTH_STENCIL_READ_ONLY_OPTIMAL                = 4,
        SHADER_READ_ONLY_OPTIMAL                       = 5,
        TRANSFER_SRC_OPTIMAL                           = 6,
        TRANSFER_DST_OPTIMAL                           = 7,
        PREINITIALIZED                                 = 8,
        DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL     = 1000117000,
        DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL     = 1000117001,
        DEPTH_ATTACHMENT_OPTIMAL                       = 1000241000,
        DEPTH_READ_ONLY_OPTIMAL                        = 1000241001,
        STENCIL_ATTACHMENT_OPTIMAL                     = 1000241002,
        STENCIL_READ_ONLY_OPTIMAL                      = 1000241003,
        PRESENT_SRC_KHR                                = 1000001002,
        VIDEO_DECODE_DST_KHR                           = 1000024000,
        VIDEO_DECODE_SRC_KHR                           = 1000024001,
        VIDEO_DECODE_DPB_KHR                           = 1000024002,
        SHARED_PRESENT_KHR                             = 1000111000,
        FRAGMENT_DENSITY_MAP_OPTIMAL_EXT               = 1000218000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR   = 1000164003,
        VIDEO_ENCODE_DST_KHR                           = 1000299000,
        VIDEO_ENCODE_SRC_KHR                           = 1000299001,
        VIDEO_ENCODE_DPB_KHR                           = 1000299002,
        READ_ONLY_OPTIMAL_KHR                          = 1000314000,
        ATTACHMENT_OPTIMAL_KHR                         = 1000314001,
        DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL_KHR = DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL,
        DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL_KHR = DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL,
        SHADING_RATE_OPTIMAL_NV                        = FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR,
        DEPTH_ATTACHMENT_OPTIMAL_KHR                   = DEPTH_ATTACHMENT_OPTIMAL,
        DEPTH_READ_ONLY_OPTIMAL_KHR                    = DEPTH_READ_ONLY_OPTIMAL,
        STENCIL_ATTACHMENT_OPTIMAL_KHR                 = STENCIL_ATTACHMENT_OPTIMAL,
        STENCIL_READ_ONLY_OPTIMAL_KHR                  = STENCIL_READ_ONLY_OPTIMAL,
        MAX_ENUM                                       = 0x7FFFFFFF
    }

    public enum VkObjectType
    {
        UNKNOWN                         = 0,
        INSTANCE                        = 1,
        PHYSICAL_DEVICE                 = 2,
        DEVICE                          = 3,
        QUEUE                           = 4,
        SEMAPHORE                       = 5,
        COMMAND_BUFFER                  = 6,
        FENCE                           = 7,
        DEVICE_MEMORY                   = 8,
        BUFFER                          = 9,
        IMAGE                           = 10,
        EVENT                           = 11,
        QUERY_POOL                      = 12,
        BUFFER_VIEW                     = 13,
        IMAGE_VIEW                      = 14,
        SHADER_MODULE                   = 15,
        PIPELINE_CACHE                  = 16,
        PIPELINE_LAYOUT                 = 17,
        RENDER_PASS                     = 18,
        PIPELINE                        = 19,
        DESCRIPTOR_SET_LAYOUT           = 20,
        SAMPLER                         = 21,
        DESCRIPTOR_POOL                 = 22,
        DESCRIPTOR_SET                  = 23,
        FRAMEBUFFER                     = 24,
        COMMAND_POOL                    = 25,
        SAMPLER_YCBCR_CONVERSION        = 1000156000,
        DESCRIPTOR_UPDATE_TEMPLATE      = 1000085000,
        SURFACE_KHR                     = 1000000000,
        SWAPCHAIN_KHR                   = 1000001000,
        DISPLAY_KHR                     = 1000002000,
        DISPLAY_MODE_KHR                = 1000002001,
        DEBUG_REPORT_CALLBACK_EXT       = 1000011000,
        VIDEO_SESSION_KHR               = 1000023000,
        VIDEO_SESSION_PARAMETERS_KHR    = 1000023001,
        CU_MODULE_NVX                   = 1000029000,
        CU_FUNCTION_NVX                 = 1000029001,
        DEBUG_UTILS_MESSENGER_EXT       = 1000128000,
        ACCELERATION_STRUCTURE_KHR      = 1000150000,
        VALIDATION_CACHE_EXT            = 1000160000,
        ACCELERATION_STRUCTURE_NV       = 1000165000,
        PERFORMANCE_CONFIGURATION_INTEL = 1000210000,
        DEFERRED_OPERATION_KHR          = 1000268000,
        INDIRECT_COMMANDS_LAYOUT_NV     = 1000277000,
        PRIVATE_DATA_SLOT_EXT           = 1000295000,
        DESCRIPTOR_UPDATE_TEMPLATE_KHR  = DESCRIPTOR_UPDATE_TEMPLATE,
        SAMPLER_YCBCR_CONVERSION_KHR    = SAMPLER_YCBCR_CONVERSION,
        MAX_ENUM                        = 0x7FFFFFFF
    }

    public enum VkVendorId
    {
        VIV      = 0x10001,
        VSI      = 0x10002,
        KAZAN    = 0x10003,
        CODEPLAY = 0x10004,
        MESA     = 0x10005,
        POCL     = 0x10006,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkPipelineCacheHeaderVersion
    {
        ONE      = 1,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkSystemAllocationScope
    {
        COMMAND  = 0,
        OBJECT   = 1,
        CACHE    = 2,
        DEVICE   = 3,
        INSTANCE = 4,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkInternalAllocationType
    {
        EXECUTABLE = 0,
        MAX_ENUM   = 0x7FFFFFFF
    }

    public enum VkFormat
    {
        UNDEFINED                                      = 0,
        R4G4_UNORM_PACK8                               = 1,
        R4G4B4A4_UNORM_PACK16                          = 2,
        B4G4R4A4_UNORM_PACK16                          = 3,
        R5G6B5_UNORM_PACK16                            = 4,
        B5G6R5_UNORM_PACK16                            = 5,
        R5G5B5A1_UNORM_PACK16                          = 6,
        B5G5R5A1_UNORM_PACK16                          = 7,
        A1R5G5B5_UNORM_PACK16                          = 8,
        R8_UNORM                                       = 9,
        R8_SNORM                                       = 10,
        R8_USCALED                                     = 11,
        R8_SSCALED                                     = 12,
        R8_UINT                                        = 13,
        R8_SINT                                        = 14,
        R8_SRGB                                        = 15,
        R8G8_UNORM                                     = 16,
        R8G8_SNORM                                     = 17,
        R8G8_USCALED                                   = 18,
        R8G8_SSCALED                                   = 19,
        R8G8_UINT                                      = 20,
        R8G8_SINT                                      = 21,
        R8G8_SRGB                                      = 22,
        R8G8B8_UNORM                                   = 23,
        R8G8B8_SNORM                                   = 24,
        R8G8B8_USCALED                                 = 25,
        R8G8B8_SSCALED                                 = 26,
        R8G8B8_UINT                                    = 27,
        R8G8B8_SINT                                    = 28,
        R8G8B8_SRGB                                    = 29,
        B8G8R8_UNORM                                   = 30,
        B8G8R8_SNORM                                   = 31,
        B8G8R8_USCALED                                 = 32,
        B8G8R8_SSCALED                                 = 33,
        B8G8R8_UINT                                    = 34,
        B8G8R8_SINT                                    = 35,
        B8G8R8_SRGB                                    = 36,
        R8G8B8A8_UNORM                                 = 37,
        R8G8B8A8_SNORM                                 = 38,
        R8G8B8A8_USCALED                               = 39,
        R8G8B8A8_SSCALED                               = 40,
        R8G8B8A8_UINT                                  = 41,
        R8G8B8A8_SINT                                  = 42,
        R8G8B8A8_SRGB                                  = 43,
        B8G8R8A8_UNORM                                 = 44,
        B8G8R8A8_SNORM                                 = 45,
        B8G8R8A8_USCALED                               = 46,
        B8G8R8A8_SSCALED                               = 47,
        B8G8R8A8_UINT                                  = 48,
        B8G8R8A8_SINT                                  = 49,
        B8G8R8A8_SRGB                                  = 50,
        A8B8G8R8_UNORM_PACK32                          = 51,
        A8B8G8R8_SNORM_PACK32                          = 52,
        A8B8G8R8_USCALED_PACK32                        = 53,
        A8B8G8R8_SSCALED_PACK32                        = 54,
        A8B8G8R8_UINT_PACK32                           = 55,
        A8B8G8R8_SINT_PACK32                           = 56,
        A8B8G8R8_SRGB_PACK32                           = 57,
        A2R10G10B10_UNORM_PACK32                       = 58,
        A2R10G10B10_SNORM_PACK32                       = 59,
        A2R10G10B10_USCALED_PACK32                     = 60,
        A2R10G10B10_SSCALED_PACK32                     = 61,
        A2R10G10B10_UINT_PACK32                        = 62,
        A2R10G10B10_SINT_PACK32                        = 63,
        A2B10G10R10_UNORM_PACK32                       = 64,
        A2B10G10R10_SNORM_PACK32                       = 65,
        A2B10G10R10_USCALED_PACK32                     = 66,
        A2B10G10R10_SSCALED_PACK32                     = 67,
        A2B10G10R10_UINT_PACK32                        = 68,
        A2B10G10R10_SINT_PACK32                        = 69,
        R16_UNORM                                      = 70,
        R16_SNORM                                      = 71,
        R16_USCALED                                    = 72,
        R16_SSCALED                                    = 73,
        R16_UINT                                       = 74,
        R16_SINT                                       = 75,
        R16_SFLOAT                                     = 76,
        R16G16_UNORM                                   = 77,
        R16G16_SNORM                                   = 78,
        R16G16_USCALED                                 = 79,
        R16G16_SSCALED                                 = 80,
        R16G16_UINT                                    = 81,
        R16G16_SINT                                    = 82,
        R16G16_SFLOAT                                  = 83,
        R16G16B16_UNORM                                = 84,
        R16G16B16_SNORM                                = 85,
        R16G16B16_USCALED                              = 86,
        R16G16B16_SSCALED                              = 87,
        R16G16B16_UINT                                 = 88,
        R16G16B16_SINT                                 = 89,
        R16G16B16_SFLOAT                               = 90,
        R16G16B16A16_UNORM                             = 91,
        R16G16B16A16_SNORM                             = 92,
        R16G16B16A16_USCALED                           = 93,
        R16G16B16A16_SSCALED                           = 94,
        R16G16B16A16_UINT                              = 95,
        R16G16B16A16_SINT                              = 96,
        R16G16B16A16_SFLOAT                            = 97,
        R32_UINT                                       = 98,
        R32_SINT                                       = 99,
        R32_SFLOAT                                     = 100,
        R32G32_UINT                                    = 101,
        R32G32_SINT                                    = 102,
        R32G32_SFLOAT                                  = 103,
        R32G32B32_UINT                                 = 104,
        R32G32B32_SINT                                 = 105,
        R32G32B32_SFLOAT                               = 106,
        R32G32B32A32_UINT                              = 107,
        R32G32B32A32_SINT                              = 108,
        R32G32B32A32_SFLOAT                            = 109,
        R64_UINT                                       = 110,
        R64_SINT                                       = 111,
        R64_SFLOAT                                     = 112,
        R64G64_UINT                                    = 113,
        R64G64_SINT                                    = 114,
        R64G64_SFLOAT                                  = 115,
        R64G64B64_UINT                                 = 116,
        R64G64B64_SINT                                 = 117,
        R64G64B64_SFLOAT                               = 118,
        R64G64B64A64_UINT                              = 119,
        R64G64B64A64_SINT                              = 120,
        R64G64B64A64_SFLOAT                            = 121,
        B10G11R11_UFLOAT_PACK32                        = 122,
        E5B9G9R9_UFLOAT_PACK32                         = 123,
        D16_UNORM                                      = 124,
        X8_D24_UNORM_PACK32                            = 125,
        D32_SFLOAT                                     = 126,
        S8_UINT                                        = 127,
        D16_UNORM_S8_UINT                              = 128,
        D24_UNORM_S8_UINT                              = 129,
        D32_SFLOAT_S8_UINT                             = 130,
        BC1_RGB_UNORM_BLOCK                            = 131,
        BC1_RGB_SRGB_BLOCK                             = 132,
        BC1_RGBA_UNORM_BLOCK                           = 133,
        BC1_RGBA_SRGB_BLOCK                            = 134,
        BC2_UNORM_BLOCK                                = 135,
        BC2_SRGB_BLOCK                                 = 136,
        BC3_UNORM_BLOCK                                = 137,
        BC3_SRGB_BLOCK                                 = 138,
        BC4_UNORM_BLOCK                                = 139,
        BC4_SNORM_BLOCK                                = 140,
        BC5_UNORM_BLOCK                                = 141,
        BC5_SNORM_BLOCK                                = 142,
        BC6H_UFLOAT_BLOCK                              = 143,
        BC6H_SFLOAT_BLOCK                              = 144,
        BC7_UNORM_BLOCK                                = 145,
        BC7_SRGB_BLOCK                                 = 146,
        ETC2_R8G8B8_UNORM_BLOCK                        = 147,
        ETC2_R8G8B8_SRGB_BLOCK                         = 148,
        ETC2_R8G8B8A1_UNORM_BLOCK                      = 149,
        ETC2_R8G8B8A1_SRGB_BLOCK                       = 150,
        ETC2_R8G8B8A8_UNORM_BLOCK                      = 151,
        ETC2_R8G8B8A8_SRGB_BLOCK                       = 152,
        EAC_R11_UNORM_BLOCK                            = 153,
        EAC_R11_SNORM_BLOCK                            = 154,
        EAC_R11G11_UNORM_BLOCK                         = 155,
        EAC_R11G11_SNORM_BLOCK                         = 156,
        ASTC_4x4_UNORM_BLOCK                           = 157,
        ASTC_4x4_SRGB_BLOCK                            = 158,
        ASTC_5x4_UNORM_BLOCK                           = 159,
        ASTC_5x4_SRGB_BLOCK                            = 160,
        ASTC_5x5_UNORM_BLOCK                           = 161,
        ASTC_5x5_SRGB_BLOCK                            = 162,
        ASTC_6x5_UNORM_BLOCK                           = 163,
        ASTC_6x5_SRGB_BLOCK                            = 164,
        ASTC_6x6_UNORM_BLOCK                           = 165,
        ASTC_6x6_SRGB_BLOCK                            = 166,
        ASTC_8x5_UNORM_BLOCK                           = 167,
        ASTC_8x5_SRGB_BLOCK                            = 168,
        ASTC_8x6_UNORM_BLOCK                           = 169,
        ASTC_8x6_SRGB_BLOCK                            = 170,
        ASTC_8x8_UNORM_BLOCK                           = 171,
        ASTC_8x8_SRGB_BLOCK                            = 172,
        ASTC_10x5_UNORM_BLOCK                          = 173,
        ASTC_10x5_SRGB_BLOCK                           = 174,
        ASTC_10x6_UNORM_BLOCK                          = 175,
        ASTC_10x6_SRGB_BLOCK                           = 176,
        ASTC_10x8_UNORM_BLOCK                          = 177,
        ASTC_10x8_SRGB_BLOCK                           = 178,
        ASTC_10x10_UNORM_BLOCK                         = 179,
        ASTC_10x10_SRGB_BLOCK                          = 180,
        ASTC_12x10_UNORM_BLOCK                         = 181,
        ASTC_12x10_SRGB_BLOCK                          = 182,
        ASTC_12x12_UNORM_BLOCK                         = 183,
        ASTC_12x12_SRGB_BLOCK                          = 184,
        G8B8G8R8_422_UNORM                             = 1000156000,
        B8G8R8G8_422_UNORM                             = 1000156001,
        G8_B8_R8_3PLANE_420_UNORM                      = 1000156002,
        G8_B8R8_2PLANE_420_UNORM                       = 1000156003,
        G8_B8_R8_3PLANE_422_UNORM                      = 1000156004,
        G8_B8R8_2PLANE_422_UNORM                       = 1000156005,
        G8_B8_R8_3PLANE_444_UNORM                      = 1000156006,
        R10X6_UNORM_PACK16                             = 1000156007,
        R10X6G10X6_UNORM_2PACK16                       = 1000156008,
        R10X6G10X6B10X6A10X6_UNORM_4PACK16             = 1000156009,
        G10X6B10X6G10X6R10X6_422_UNORM_4PACK16         = 1000156010,
        B10X6G10X6R10X6G10X6_422_UNORM_4PACK16         = 1000156011,
        G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16     = 1000156012,
        G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16      = 1000156013,
        G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16     = 1000156014,
        G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16      = 1000156015,
        G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16     = 1000156016,
        R12X4_UNORM_PACK16                             = 1000156017,
        R12X4G12X4_UNORM_2PACK16                       = 1000156018,
        R12X4G12X4B12X4A12X4_UNORM_4PACK16             = 1000156019,
        G12X4B12X4G12X4R12X4_422_UNORM_4PACK16         = 1000156020,
        B12X4G12X4R12X4G12X4_422_UNORM_4PACK16         = 1000156021,
        G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16     = 1000156022,
        G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16      = 1000156023,
        G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16     = 1000156024,
        G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16      = 1000156025,
        G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16     = 1000156026,
        G16B16G16R16_422_UNORM                         = 1000156027,
        B16G16R16G16_422_UNORM                         = 1000156028,
        G16_B16_R16_3PLANE_420_UNORM                   = 1000156029,
        G16_B16R16_2PLANE_420_UNORM                    = 1000156030,
        G16_B16_R16_3PLANE_422_UNORM                   = 1000156031,
        G16_B16R16_2PLANE_422_UNORM                    = 1000156032,
        G16_B16_R16_3PLANE_444_UNORM                   = 1000156033,
        PVRTC1_2BPP_UNORM_BLOCK_IMG                    = 1000054000,
        PVRTC1_4BPP_UNORM_BLOCK_IMG                    = 1000054001,
        PVRTC2_2BPP_UNORM_BLOCK_IMG                    = 1000054002,
        PVRTC2_4BPP_UNORM_BLOCK_IMG                    = 1000054003,
        PVRTC1_2BPP_SRGB_BLOCK_IMG                     = 1000054004,
        PVRTC1_4BPP_SRGB_BLOCK_IMG                     = 1000054005,
        PVRTC2_2BPP_SRGB_BLOCK_IMG                     = 1000054006,
        PVRTC2_4BPP_SRGB_BLOCK_IMG                     = 1000054007,
        ASTC_4x4_SFLOAT_BLOCK_EXT                      = 1000066000,
        ASTC_5x4_SFLOAT_BLOCK_EXT                      = 1000066001,
        ASTC_5x5_SFLOAT_BLOCK_EXT                      = 1000066002,
        ASTC_6x5_SFLOAT_BLOCK_EXT                      = 1000066003,
        ASTC_6x6_SFLOAT_BLOCK_EXT                      = 1000066004,
        ASTC_8x5_SFLOAT_BLOCK_EXT                      = 1000066005,
        ASTC_8x6_SFLOAT_BLOCK_EXT                      = 1000066006,
        ASTC_8x8_SFLOAT_BLOCK_EXT                      = 1000066007,
        ASTC_10x5_SFLOAT_BLOCK_EXT                     = 1000066008,
        ASTC_10x6_SFLOAT_BLOCK_EXT                     = 1000066009,
        ASTC_10x8_SFLOAT_BLOCK_EXT                     = 1000066010,
        ASTC_10x10_SFLOAT_BLOCK_EXT                    = 1000066011,
        ASTC_12x10_SFLOAT_BLOCK_EXT                    = 1000066012,
        ASTC_12x12_SFLOAT_BLOCK_EXT                    = 1000066013,
        G8_B8R8_2PLANE_444_UNORM_EXT                   = 1000330000,
        G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT  = 1000330001,
        G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT  = 1000330002,
        G16_B16R16_2PLANE_444_UNORM_EXT                = 1000330003,
        A4R4G4B4_UNORM_PACK16_EXT                      = 1000340000,
        A4B4G4R4_UNORM_PACK16_EXT                      = 1000340001,
        G8B8G8R8_422_UNORM_KHR                         = G8B8G8R8_422_UNORM,
        B8G8R8G8_422_UNORM_KHR                         = B8G8R8G8_422_UNORM,
        G8_B8_R8_3PLANE_420_UNORM_KHR                  = G8_B8_R8_3PLANE_420_UNORM,
        G8_B8R8_2PLANE_420_UNORM_KHR                   = G8_B8R8_2PLANE_420_UNORM,
        G8_B8_R8_3PLANE_422_UNORM_KHR                  = G8_B8_R8_3PLANE_422_UNORM,
        G8_B8R8_2PLANE_422_UNORM_KHR                   = G8_B8R8_2PLANE_422_UNORM,
        G8_B8_R8_3PLANE_444_UNORM_KHR                  = G8_B8_R8_3PLANE_444_UNORM,
        R10X6_UNORM_PACK16_KHR                         = R10X6_UNORM_PACK16,
        R10X6G10X6_UNORM_2PACK16_KHR                   = R10X6G10X6_UNORM_2PACK16,
        R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR         = R10X6G10X6B10X6A10X6_UNORM_4PACK16,
        G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR     = G10X6B10X6G10X6R10X6_422_UNORM_4PACK16,
        B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR     = B10X6G10X6R10X6G10X6_422_UNORM_4PACK16,
        G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR = G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16,
        G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR  = G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16,
        G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR = G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16,
        G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR  = G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16,
        G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR = G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16,
        R12X4_UNORM_PACK16_KHR                         = R12X4_UNORM_PACK16,
        R12X4G12X4_UNORM_2PACK16_KHR                   = R12X4G12X4_UNORM_2PACK16,
        R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR         = R12X4G12X4B12X4A12X4_UNORM_4PACK16,
        G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR     = G12X4B12X4G12X4R12X4_422_UNORM_4PACK16,
        B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR     = B12X4G12X4R12X4G12X4_422_UNORM_4PACK16,
        G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR = G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16,
        G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR  = G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16,
        G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR = G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16,
        G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR  = G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16,
        G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR = G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16,
        G16B16G16R16_422_UNORM_KHR                     = G16B16G16R16_422_UNORM,
        B16G16R16G16_422_UNORM_KHR                     = B16G16R16G16_422_UNORM,
        G16_B16_R16_3PLANE_420_UNORM_KHR               = G16_B16_R16_3PLANE_420_UNORM,
        G16_B16R16_2PLANE_420_UNORM_KHR                = G16_B16R16_2PLANE_420_UNORM,
        G16_B16_R16_3PLANE_422_UNORM_KHR               = G16_B16_R16_3PLANE_422_UNORM,
        G16_B16R16_2PLANE_422_UNORM_KHR                = G16_B16R16_2PLANE_422_UNORM,
        G16_B16_R16_3PLANE_444_UNORM_KHR               = G16_B16_R16_3PLANE_444_UNORM,
        MAX_ENUM                                       = 0x7FFFFFFF
    }

    public enum VkImageTiling
    {
        OPTIMAL                 = 0,
        LINEAR                  = 1,
        DRM_FORMAT_MODIFIER_EXT = 1000158000,
        MAX_ENUM                = 0x7FFFFFFF
    }

    public enum VkImageType
    {
        _1D      = 0,
        _2D      = 1,
        _3D      = 2,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkPhysicalDeviceType
    {
        OTHER          = 0,
        INTEGRATED_GPU = 1,
        DISCRETE_GPU   = 2,
        VIRTUAL_GPU    = 3,
        CPU            = 4,
        MAX_ENUM       = 0x7FFFFFFF
    }

    public enum VkQueryType
    {
        OCCLUSION                                     = 0,
        PIPELINE_STATISTICS                           = 1,
        TIMESTAMP                                     = 2,
        RESULT_STATUS_ONLY_KHR                        = 1000023000,
        TRANSFORM_FEEDBACK_STREAM_EXT                 = 1000028004,
        PERFORMANCE_QUERY_KHR                         = 1000116000,
        ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR     = 1000150000,
        ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = 1000150001,
        ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV      = 1000165000,
        PERFORMANCE_QUERY_INTEL                       = 1000210000,
        VIDEO_ENCODE_BITSTREAM_BUFFER_RANGE_KHR       = 1000299000,
        MAX_ENUM                                      = 0x7FFFFFFF
    }

    public enum VkSharingMode
    {
        EXCLUSIVE  = 0,
        CONCURRENT = 1,
        MAX_ENUM   = 0x7FFFFFFF
    }

    public enum VkComponentSwizzle
    {
        IDENTITY = 0,
        ZERO     = 1,
        ONE      = 2,
        R        = 3,
        G        = 4,
        B        = 5,
        A        = 6,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkImageViewType
    {
        _1D        = 0,
        _2D        = 1,
        _3D        = 2,
        CUBE       = 3,
        _1D_ARRAY  = 4,
        _2D_ARRAY  = 5,
        CUBE_ARRAY = 6,
        MAX_ENUM   = 0x7FFFFFFF
    }

    public enum VkBlendFactor
    {
        ZERO                     = 0,
        ONE                      = 1,
        SRC_COLOR                = 2,
        ONE_MINUS_SRC_COLOR      = 3,
        DST_COLOR                = 4,
        ONE_MINUS_DST_COLOR      = 5,
        SRC_ALPHA                = 6,
        ONE_MINUS_SRC_ALPHA      = 7,
        DST_ALPHA                = 8,
        ONE_MINUS_DST_ALPHA      = 9,
        CONSTANT_COLOR           = 10,
        ONE_MINUS_CONSTANT_COLOR = 11,
        CONSTANT_ALPHA           = 12,
        ONE_MINUS_CONSTANT_ALPHA = 13,
        SRC_ALPHA_SATURATE       = 14,
        SRC1_COLOR               = 15,
        ONE_MINUS_SRC1_COLOR     = 16,
        SRC1_ALPHA               = 17,
        ONE_MINUS_SRC1_ALPHA     = 18,
        MAX_ENUM                 = 0x7FFFFFFF
    }

    public enum VkBlendOp
    {
        ADD                    = 0,
        SUBTRACT               = 1,
        REVERSE_SUBTRACT       = 2,
        MIN                    = 3,
        MAX                    = 4,
        ZERO_EXT               = 1000148000,
        SRC_EXT                = 1000148001,
        DST_EXT                = 1000148002,
        SRC_OVER_EXT           = 1000148003,
        DST_OVER_EXT           = 1000148004,
        SRC_IN_EXT             = 1000148005,
        DST_IN_EXT             = 1000148006,
        SRC_OUT_EXT            = 1000148007,
        DST_OUT_EXT            = 1000148008,
        SRC_ATOP_EXT           = 1000148009,
        DST_ATOP_EXT           = 1000148010,
        XOR_EXT                = 1000148011,
        MULTIPLY_EXT           = 1000148012,
        SCREEN_EXT             = 1000148013,
        OVERLAY_EXT            = 1000148014,
        DARKEN_EXT             = 1000148015,
        LIGHTEN_EXT            = 1000148016,
        COLORDODGE_EXT         = 1000148017,
        COLORBURN_EXT          = 1000148018,
        HARDLIGHT_EXT          = 1000148019,
        SOFTLIGHT_EXT          = 1000148020,
        DIFFERENCE_EXT         = 1000148021,
        EXCLUSION_EXT          = 1000148022,
        INVERT_EXT             = 1000148023,
        INVERT_RGB_EXT         = 1000148024,
        LINEARDODGE_EXT        = 1000148025,
        LINEARBURN_EXT         = 1000148026,
        VIVIDLIGHT_EXT         = 1000148027,
        LINEARLIGHT_EXT        = 1000148028,
        PINLIGHT_EXT           = 1000148029,
        HARDMIX_EXT            = 1000148030,
        HSL_HUE_EXT            = 1000148031,
        HSL_SATURATION_EXT     = 1000148032,
        HSL_COLOR_EXT          = 1000148033,
        HSL_LUMINOSITY_EXT     = 1000148034,
        PLUS_EXT               = 1000148035,
        PLUS_CLAMPED_EXT       = 1000148036,
        PLUS_CLAMPED_ALPHA_EXT = 1000148037,
        PLUS_DARKER_EXT        = 1000148038,
        MINUS_EXT              = 1000148039,
        MINUS_CLAMPED_EXT      = 1000148040,
        CONTRAST_EXT           = 1000148041,
        INVERT_OVG_EXT         = 1000148042,
        RED_EXT                = 1000148043,
        GREEN_EXT              = 1000148044,
        BLUE_EXT               = 1000148045,
        MAX_ENUM               = 0x7FFFFFFF
    }

    public enum VkCompareOp
    {
        NEVER            = 0,
        LESS             = 1,
        EQUAL            = 2,
        LESS_OR_EQUAL    = 3,
        GREATER          = 4,
        NOT_EQUAL        = 5,
        GREATER_OR_EQUAL = 6,
        ALWAYS           = 7,
        MAX_ENUM         = 0x7FFFFFFF
    }

    public enum VkDynamicState
    {
        VIEWPORT                            = 0,
        SCISSOR                             = 1,
        LINE_WIDTH                          = 2,
        DEPTH_BIAS                          = 3,
        BLEND_CONSTANTS                     = 4,
        DEPTH_BOUNDS                        = 5,
        STENCIL_COMPARE_MASK                = 6,
        STENCIL_WRITE_MASK                  = 7,
        STENCIL_REFERENCE                   = 8,
        VIEWPORT_W_SCALING_NV               = 1000087000,
        DISCARD_RECTANGLE_EXT               = 1000099000,
        SAMPLE_LOCATIONS_EXT                = 1000143000,
        RAY_TRACING_PIPELINE_STACK_SIZE_KHR = 1000347000,
        VIEWPORT_SHADING_RATE_PALETTE_NV    = 1000164004,
        VIEWPORT_COARSE_SAMPLE_ORDER_NV     = 1000164006,
        EXCLUSIVE_SCISSOR_NV                = 1000205001,
        FRAGMENT_SHADING_RATE_KHR           = 1000226000,
        LINE_STIPPLE_EXT                    = 1000259000,
        CULL_MODE_EXT                       = 1000267000,
        FRONT_FACE_EXT                      = 1000267001,
        PRIMITIVE_TOPOLOGY_EXT              = 1000267002,
        VIEWPORT_WITH_COUNT_EXT             = 1000267003,
        SCISSOR_WITH_COUNT_EXT              = 1000267004,
        VERTEX_INPUT_BINDING_STRIDE_EXT     = 1000267005,
        DEPTH_TEST_ENABLE_EXT               = 1000267006,
        DEPTH_WRITE_ENABLE_EXT              = 1000267007,
        DEPTH_COMPARE_OP_EXT                = 1000267008,
        DEPTH_BOUNDS_TEST_ENABLE_EXT        = 1000267009,
        STENCIL_TEST_ENABLE_EXT             = 1000267010,
        STENCIL_OP_EXT                      = 1000267011,
        VERTEX_INPUT_EXT                    = 1000352000,
        PATCH_CONTROL_POINTS_EXT            = 1000377000,
        RASTERIZER_DISCARD_ENABLE_EXT       = 1000377001,
        DEPTH_BIAS_ENABLE_EXT               = 1000377002,
        LOGIC_OP_EXT                        = 1000377003,
        PRIMITIVE_RESTART_ENABLE_EXT        = 1000377004,
        COLOR_WRITE_ENABLE_EXT              = 1000381000,
        MAX_ENUM                            = 0x7FFFFFFF
    }

    public enum VkFrontFace
    {
        COUNTER_CLOCKWISE = 0,
        CLOCKWISE         = 1,
        MAX_ENUM          = 0x7FFFFFFF
    }

    public enum VkVertexInputRate
    {
        VERTEX   = 0,
        INSTANCE = 1,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkPrimitiveTopology
    {
        POINT_LIST                    = 0,
        LINE_LIST                     = 1,
        LINE_STRIP                    = 2,
        TRIANGLE_LIST                 = 3,
        TRIANGLE_STRIP                = 4,
        TRIANGLE_FAN                  = 5,
        LINE_LIST_WITH_ADJACENCY      = 6,
        LINE_STRIP_WITH_ADJACENCY     = 7,
        TRIANGLE_LIST_WITH_ADJACENCY  = 8,
        TRIANGLE_STRIP_WITH_ADJACENCY = 9,
        PATCH_LIST                    = 10,
        MAX_ENUM                      = 0x7FFFFFFF
    }

    public enum VkPolygonMode
    {
        FILL              = 0,
        LINE              = 1,
        POINT             = 2,
        FILL_RECTANGLE_NV = 1000153000,
        MAX_ENUM          = 0x7FFFFFFF
    }

    public enum VkStencilOp
    {
        KEEP                = 0,
        ZERO                = 1,
        REPLACE             = 2,
        INCREMENT_AND_CLAMP = 3,
        DECREMENT_AND_CLAMP = 4,
        INVERT              = 5,
        INCREMENT_AND_WRAP  = 6,
        DECREMENT_AND_WRAP  = 7,
        MAX_ENUM            = 0x7FFFFFFF
    }

    public enum VkLogicOp
    {
        CLEAR         = 0,
        AND           = 1,
        AND_REVERSE   = 2,
        COPY          = 3,
        AND_INVERTED  = 4,
        NO_OP         = 5,
        XOR           = 6,
        OR            = 7,
        NOR           = 8,
        EQUIVALENT    = 9,
        INVERT        = 10,
        OR_REVERSE    = 11,
        COPY_INVERTED = 12,
        OR_INVERTED   = 13,
        NAND          = 14,
        SET           = 15,
        MAX_ENUM      = 0x7FFFFFFF
    }

    public enum VkBorderColor
    {
        FLOAT_TRANSPARENT_BLACK = 0,
        INT_TRANSPARENT_BLACK   = 1,
        FLOAT_OPAQUE_BLACK      = 2,
        INT_OPAQUE_BLACK        = 3,
        FLOAT_OPAQUE_WHITE      = 4,
        INT_OPAQUE_WHITE        = 5,
        FLOAT_CUSTOM_EXT        = 1000287003,
        INT_CUSTOM_EXT          = 1000287004,
        MAX_ENUM                = 0x7FFFFFFF
    }

    public enum VkFilter
    {
        NEAREST   = 0,
        LINEAR    = 1,
        CUBIC_IMG = 1000015000,
        CUBIC_EXT = CUBIC_IMG,
        MAX_ENUM  = 0x7FFFFFFF
    }

    public enum VkSamplerAddressMode
    {
        REPEAT                   = 0,
        MIRRORED_REPEAT          = 1,
        CLAMP_TO_EDGE            = 2,
        CLAMP_TO_BORDER          = 3,
        MIRROR_CLAMP_TO_EDGE     = 4,
        MIRROR_CLAMP_TO_EDGE_KHR = MIRROR_CLAMP_TO_EDGE,
        MAX_ENUM                 = 0x7FFFFFFF
    }

    public enum VkSamplerMipmapMode
    {
        NEAREST  = 0,
        LINEAR   = 1,
        MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkDescriptorType
    {
        SAMPLER                    = 0,
        COMBINED_IMAGE_SAMPLER     = 1,
        SAMPLED_IMAGE              = 2,
        STORAGE_IMAGE              = 3,
        UNIFORM_TEXEL_BUFFER       = 4,
        STORAGE_TEXEL_BUFFER       = 5,
        UNIFORM_BUFFER             = 6,
        STORAGE_BUFFER             = 7,
        UNIFORM_BUFFER_DYNAMIC     = 8,
        STORAGE_BUFFER_DYNAMIC     = 9,
        INPUT_ATTACHMENT           = 10,
        INLINE_UNIFORM_BLOCK_EXT   = 1000138000,
        ACCELERATION_STRUCTURE_KHR = 1000150000,
        ACCELERATION_STRUCTURE_NV  = 1000165000,
        MUTABLE_VALVE              = 1000351000,
        MAX_ENUM                   = 0x7FFFFFFF
    }

    public enum VkAttachmentLoadOp
    {
        LOAD      = 0,
        CLEAR     = 1,
        DONT_CARE = 2,
        MAX_ENUM  = 0x7FFFFFFF
    }

    public enum VkAttachmentStoreOp
    {
        STORE     = 0,
        DONT_CARE = 1,
        NONE_QCOM = 1000301000,
        MAX_ENUM  = 0x7FFFFFFF
    }

    public enum VkPipelineBindPoint
    {
        GRAPHICS               = 0,
        COMPUTE                = 1,
        RAY_TRACING_KHR        = 1000165000,
        SUBPASS_SHADING_HUAWEI = 1000369003,
        RAY_TRACING_NV         = RAY_TRACING_KHR,
        MAX_ENUM               = 0x7FFFFFFF
    }

    public enum VkCommandBufferLevel
    {
        PRIMARY   = 0,
        SECONDARY = 1,
        MAX_ENUM  = 0x7FFFFFFF
    }

    public enum VkIndexType
    {
        UINT16    = 0,
        UINT32    = 1,
        NONE_KHR  = 1000165000,
        UINT8_EXT = 1000265000,
        NONE_NV   = NONE_KHR,
        MAX_ENUM  = 0x7FFFFFFF
    }

    public enum VkSubpassContents
    {
        INLINE                    = 0,
        SECONDARY_COMMAND_BUFFERS = 1,
        MAX_ENUM                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkAccessFlagBits
    {
        INDIRECT_COMMAND_READ_BIT                     = 0x00000001,
        INDEX_READ_BIT                                = 0x00000002,
        VERTEX_ATTRIBUTE_READ_BIT                     = 0x00000004,
        UNIFORM_READ_BIT                              = 0x00000008,
        INPUT_ATTACHMENT_READ_BIT                     = 0x00000010,
        SHADER_READ_BIT                               = 0x00000020,
        SHADER_WRITE_BIT                              = 0x00000040,
        COLOR_ATTACHMENT_READ_BIT                     = 0x00000080,
        COLOR_ATTACHMENT_WRITE_BIT                    = 0x00000100,
        DEPTH_STENCIL_ATTACHMENT_READ_BIT             = 0x00000200,
        DEPTH_STENCIL_ATTACHMENT_WRITE_BIT            = 0x00000400,
        TRANSFER_READ_BIT                             = 0x00000800,
        TRANSFER_WRITE_BIT                            = 0x00001000,
        HOST_READ_BIT                                 = 0x00002000,
        HOST_WRITE_BIT                                = 0x00004000,
        MEMORY_READ_BIT                               = 0x00008000,
        MEMORY_WRITE_BIT                              = 0x00010000,
        TRANSFORM_FEEDBACK_WRITE_BIT_EXT              = 0x02000000,
        TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT       = 0x04000000,
        TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT      = 0x08000000,
        CONDITIONAL_RENDERING_READ_BIT_EXT            = 0x00100000,
        COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT     = 0x00080000,
        ACCELERATION_STRUCTURE_READ_BIT_KHR           = 0x00200000,
        ACCELERATION_STRUCTURE_WRITE_BIT_KHR          = 0x00400000,
        FRAGMENT_DENSITY_MAP_READ_BIT_EXT             = 0x01000000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000,
        COMMAND_PREPROCESS_READ_BIT_NV                = 0x00020000,
        COMMAND_PREPROCESS_WRITE_BIT_NV               = 0x00040000,
        NONE_KHR                                      = 0,
        SHADING_RATE_IMAGE_READ_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR,
        ACCELERATION_STRUCTURE_READ_BIT_NV            = ACCELERATION_STRUCTURE_READ_BIT_KHR,
        ACCELERATION_STRUCTURE_WRITE_BIT_NV           = ACCELERATION_STRUCTURE_WRITE_BIT_KHR,
        FLAG_BITS_MAX_ENUM                            = 0x7FFFFFFF
    }

    [Flags]
    public enum VkImageAspectFlagBits
    {
        COLOR_BIT              = 0x00000001,
        DEPTH_BIT              = 0x00000002,
        STENCIL_BIT            = 0x00000004,
        METADATA_BIT           = 0x00000008,
        PLANE_0_BIT            = 0x00000010,
        PLANE_1_BIT            = 0x00000020,
        PLANE_2_BIT            = 0x00000040,
        MEMORY_PLANE_0_BIT_EXT = 0x00000080,
        MEMORY_PLANE_1_BIT_EXT = 0x00000100,
        MEMORY_PLANE_2_BIT_EXT = 0x00000200,
        MEMORY_PLANE_3_BIT_EXT = 0x00000400,
        PLANE_0_BIT_KHR        = PLANE_0_BIT,
        PLANE_1_BIT_KHR        = PLANE_1_BIT,
        PLANE_2_BIT_KHR        = PLANE_2_BIT,
        FLAG_BITS_MAX_ENUM     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkFormatFeatureFlagBits
    {
        SAMPLED_IMAGE_BIT                                                           = 0x00000001,
        STORAGE_IMAGE_BIT                                                           = 0x00000002,
        STORAGE_IMAGE_ATOMIC_BIT                                                    = 0x00000004,
        UNIFORM_TEXEL_BUFFER_BIT                                                    = 0x00000008,
        STORAGE_TEXEL_BUFFER_BIT                                                    = 0x00000010,
        STORAGE_TEXEL_BUFFER_ATOMIC_BIT                                             = 0x00000020,
        VERTEX_BUFFER_BIT                                                           = 0x00000040,
        COLOR_ATTACHMENT_BIT                                                        = 0x00000080,
        COLOR_ATTACHMENT_BLEND_BIT                                                  = 0x00000100,
        DEPTH_STENCIL_ATTACHMENT_BIT                                                = 0x00000200,
        BLIT_SRC_BIT                                                                = 0x00000400,
        BLIT_DST_BIT                                                                = 0x00000800,
        SAMPLED_IMAGE_FILTER_LINEAR_BIT                                             = 0x00001000,
        TRANSFER_SRC_BIT                                                            = 0x00004000,
        TRANSFER_DST_BIT                                                            = 0x00008000,
        MIDPOINT_CHROMA_SAMPLES_BIT                                                 = 0x00020000,
        SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT                            = 0x00040000,
        SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT           = 0x00080000,
        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT           = 0x00100000,
        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = 0x00200000,
        DISJOINT_BIT                                                                = 0x00400000,
        COSITED_CHROMA_SAMPLES_BIT                                                  = 0x00800000,
        SAMPLED_IMAGE_FILTER_MINMAX_BIT                                             = 0x00010000,
        SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG                                          = 0x00002000,
        VIDEO_DECODE_OUTPUT_BIT_KHR                                                 = 0x02000000,
        VIDEO_DECODE_DPB_BIT_KHR                                                    = 0x04000000,
        ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR                                = 0x20000000,
        FRAGMENT_DENSITY_MAP_BIT_EXT                                                = 0x01000000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR                                    = 0x40000000,
        VIDEO_ENCODE_INPUT_BIT_KHR                                                  = 0x08000000,
        VIDEO_ENCODE_DPB_BIT_KHR                                                    = 0x10000000,
        TRANSFER_SRC_BIT_KHR                                                        = TRANSFER_SRC_BIT,
        TRANSFER_DST_BIT_KHR                                                        = TRANSFER_DST_BIT,
        SAMPLED_IMAGE_FILTER_MINMAX_BIT_EXT                                         = SAMPLED_IMAGE_FILTER_MINMAX_BIT,
        MIDPOINT_CHROMA_SAMPLES_BIT_KHR                                             = MIDPOINT_CHROMA_SAMPLES_BIT,
        SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR                        = SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT,

        SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR =
            SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT,

        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR =
            SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT,

        SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR =
            SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT,
        DISJOINT_BIT_KHR                   = DISJOINT_BIT,
        COSITED_CHROMA_SAMPLES_BIT_KHR     = COSITED_CHROMA_SAMPLES_BIT,
        SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = SAMPLED_IMAGE_FILTER_CUBIC_BIT_IMG,
        FLAG_BITS_MAX_ENUM                 = 0x7FFFFFFF
    }

    [Flags]
    public enum VkImageCreateFlagBits
    {
        SPARSE_BINDING_BIT                        = 0x00000001,
        SPARSE_RESIDENCY_BIT                      = 0x00000002,
        SPARSE_ALIASED_BIT                        = 0x00000004,
        MUTABLE_FORMAT_BIT                        = 0x00000008,
        CUBE_COMPATIBLE_BIT                       = 0x00000010,
        ALIAS_BIT                                 = 0x00000400,
        SPLIT_INSTANCE_BIND_REGIONS_BIT           = 0x00000040,
        _2D_ARRAY_COMPATIBLE_BIT                  = 0x00000020,
        BLOCK_TEXEL_VIEW_COMPATIBLE_BIT           = 0x00000080,
        EXTENDED_USAGE_BIT                        = 0x00000100,
        PROTECTED_BIT                             = 0x00000800,
        DISJOINT_BIT                              = 0x00000200,
        CORNER_SAMPLED_BIT_NV                     = 0x00002000,
        SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = 0x00001000,
        SUBSAMPLED_BIT_EXT                        = 0x00004000,
        SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR       = SPLIT_INSTANCE_BIND_REGIONS_BIT,
        _2D_ARRAY_COMPATIBLE_BIT_KHR              = _2D_ARRAY_COMPATIBLE_BIT,
        BLOCK_TEXEL_VIEW_COMPATIBLE_BIT_KHR       = BLOCK_TEXEL_VIEW_COMPATIBLE_BIT,
        EXTENDED_USAGE_BIT_KHR                    = EXTENDED_USAGE_BIT,
        DISJOINT_BIT_KHR                          = DISJOINT_BIT,
        ALIAS_BIT_KHR                             = ALIAS_BIT,
        FLAG_BITS_MAX_ENUM                        = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSampleCountFlagBits
    {
        _1_BIT             = 0x00000001,
        _2_BIT             = 0x00000002,
        _4_BIT             = 0x00000004,
        _8_BIT             = 0x00000008,
        _16_BIT            = 0x00000010,
        _32_BIT            = 0x00000020,
        _64_BIT            = 0x00000040,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkImageUsageFlagBits
    {
        TRANSFER_SRC_BIT                         = 0x00000001,
        TRANSFER_DST_BIT                         = 0x00000002,
        SAMPLED_BIT                              = 0x00000004,
        STORAGE_BIT                              = 0x00000008,
        COLOR_ATTACHMENT_BIT                     = 0x00000010,
        DEPTH_STENCIL_ATTACHMENT_BIT             = 0x00000020,
        TRANSIENT_ATTACHMENT_BIT                 = 0x00000040,
        INPUT_ATTACHMENT_BIT                     = 0x00000080,
        VIDEO_DECODE_DST_BIT_KHR                 = 0x00000400,
        VIDEO_DECODE_SRC_BIT_KHR                 = 0x00000800,
        VIDEO_DECODE_DPB_BIT_KHR                 = 0x00001000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00000100,
        FRAGMENT_DENSITY_MAP_BIT_EXT             = 0x00000200,
        VIDEO_ENCODE_DST_BIT_KHR                 = 0x00002000,
        VIDEO_ENCODE_SRC_BIT_KHR                 = 0x00004000,
        VIDEO_ENCODE_DPB_BIT_KHR                 = 0x00008000,
        SHADING_RATE_IMAGE_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
        FLAG_BITS_MAX_ENUM                       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkMemoryHeapFlagBits
    {
        DEVICE_LOCAL_BIT       = 0x00000001,
        MULTI_INSTANCE_BIT     = 0x00000002,
        MULTI_INSTANCE_BIT_KHR = MULTI_INSTANCE_BIT,
        FLAG_BITS_MAX_ENUM     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkMemoryPropertyFlagBits
    {
        DEVICE_LOCAL_BIT        = 0x00000001,
        HOST_VISIBLE_BIT        = 0x00000002,
        HOST_COHERENT_BIT       = 0x00000004,
        HOST_CACHED_BIT         = 0x00000008,
        LAZILY_ALLOCATED_BIT    = 0x00000010,
        PROTECTED_BIT           = 0x00000020,
        VIDEO_DECODE_BIT_KHR    = 0x00000020,
        VIDEO_ENCODE_BIT_KHR    = 0x00000040,
        DEVICE_COHERENT_BIT_AMD = 0x00000040,
        DEVICE_UNCACHED_BIT_AMD = 0x00000080,
        FLAG_BITS_MAX_ENUM      = 0x7FFFFFFF
    }

    [Flags]
    public enum VkQueueFlagBits
    {
        GRAPHICS_BIT       = 0x00000001,
        COMPUTE_BIT        = 0x00000002,
        TRANSFER_BIT       = 0x00000004,
        SPARSE_BINDING_BIT = 0x00000008,
        PROTECTED_BIT      = 0x00000010,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDeviceQueueCreateFlagBits
    {
        PROTECTED_BIT      = 0x00000001,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineStageFlagBits
    {
        TOP_OF_PIPE_BIT                          = 0x00000001,
        DRAW_INDIRECT_BIT                        = 0x00000002,
        VERTEX_INPUT_BIT                         = 0x00000004,
        VERTEX_SHADER_BIT                        = 0x00000008,
        TESSELLATION_CONTROL_SHADER_BIT          = 0x00000010,
        TESSELLATION_EVALUATION_SHADER_BIT       = 0x00000020,
        GEOMETRY_SHADER_BIT                      = 0x00000040,
        FRAGMENT_SHADER_BIT                      = 0x00000080,
        EARLY_FRAGMENT_TESTS_BIT                 = 0x00000100,
        LATE_FRAGMENT_TESTS_BIT                  = 0x00000200,
        COLOR_ATTACHMENT_OUTPUT_BIT              = 0x00000400,
        COMPUTE_SHADER_BIT                       = 0x00000800,
        TRANSFER_BIT                             = 0x00001000,
        BOTTOM_OF_PIPE_BIT                       = 0x00002000,
        HOST_BIT                                 = 0x00004000,
        ALL_GRAPHICS_BIT                         = 0x00008000,
        ALL_COMMANDS_BIT                         = 0x00010000,
        TRANSFORM_FEEDBACK_BIT_EXT               = 0x01000000,
        CONDITIONAL_RENDERING_BIT_EXT            = 0x00040000,
        ACCELERATION_STRUCTURE_BUILD_BIT_KHR     = 0x02000000,
        RAY_TRACING_SHADER_BIT_KHR               = 0x00200000,
        TASK_SHADER_BIT_NV                       = 0x00080000,
        MESH_SHADER_BIT_NV                       = 0x00100000,
        FRAGMENT_DENSITY_PROCESS_BIT_EXT         = 0x00800000,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000,
        COMMAND_PREPROCESS_BIT_NV                = 0x00020000,
        NONE_KHR                                 = 0,
        SHADING_RATE_IMAGE_BIT_NV                = FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR,
        RAY_TRACING_SHADER_BIT_NV                = RAY_TRACING_SHADER_BIT_KHR,
        ACCELERATION_STRUCTURE_BUILD_BIT_NV      = ACCELERATION_STRUCTURE_BUILD_BIT_KHR,
        FLAG_BITS_MAX_ENUM                       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSparseMemoryBindFlagBits
    {
        METADATA_BIT       = 0x00000001,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSparseImageFormatFlagBits
    {
        SINGLE_MIPTAIL_BIT         = 0x00000001,
        ALIGNED_MIP_SIZE_BIT       = 0x00000002,
        NONSTANDARD_BLOCK_SIZE_BIT = 0x00000004,
        FLAG_BITS_MAX_ENUM         = 0x7FFFFFFF
    }

    [Flags]
    public enum VkFenceCreateFlagBits
    {
        SIGNALED_BIT       = 0x00000001,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineStageFlagBits2KHR : ulong
    {
        NONE_KHR                                 = 0UL,
        TOP_OF_PIPE_BIT_KHR                      = 0x00000001UL,
        DRAW_INDIRECT_BIT_KHR                    = 0x00000002UL,
        VERTEX_INPUT_BIT_KHR                     = 0x00000004UL,
        VERTEX_SHADER_BIT_KHR                    = 0x00000008UL,
        TESSELLATION_CONTROL_SHADER_BIT_KHR      = 0x00000010UL,
        TESSELLATION_EVALUATION_SHADER_BIT_KHR   = 0x00000020UL,
        GEOMETRY_SHADER_BIT_KHR                  = 0x00000040UL,
        FRAGMENT_SHADER_BIT_KHR                  = 0x00000080UL,
        EARLY_FRAGMENT_TESTS_BIT_KHR             = 0x00000100UL,
        LATE_FRAGMENT_TESTS_BIT_KHR              = 0x00000200UL,
        COLOR_ATTACHMENT_OUTPUT_BIT_KHR          = 0x00000400UL,
        COMPUTE_SHADER_BIT_KHR                   = 0x00000800UL,
        ALL_TRANSFER_BIT_KHR                     = 0x00001000UL,
        TRANSFER_BIT_KHR                         = 0x00001000UL,
        BOTTOM_OF_PIPE_BIT_KHR                   = 0x00002000UL,
        HOST_BIT_KHR                             = 0x00004000UL,
        ALL_GRAPHICS_BIT_KHR                     = 0x00008000UL,
        ALL_COMMANDS_BIT_KHR                     = 0x00010000UL,
        COPY_BIT_KHR                             = 0x100000000UL,
        RESOLVE_BIT_KHR                          = 0x200000000UL,
        BLIT_BIT_KHR                             = 0x400000000UL,
        CLEAR_BIT_KHR                            = 0x800000000UL,
        INDEX_INPUT_BIT_KHR                      = 0x1000000000UL,
        VERTEX_ATTRIBUTE_INPUT_BIT_KHR           = 0x2000000000UL,
        PRE_RASTERIZATION_SHADERS_BIT_KHR        = 0x4000000000UL,
        VIDEO_DECODE_BIT_KHR                     = 0x04000000UL,
        VIDEO_ENCODE_BIT_KHR                     = 0x08000000UL,
        RESERVED_26_BIT_KHR                      = 0x04000000,
        RESERVED_27_BIT_KHR                      = 0x08000000,
        TRANSFORM_FEEDBACK_BIT_EXT               = 0x01000000UL,
        CONDITIONAL_RENDERING_BIT_EXT            = 0x00040000UL,
        COMMAND_PREPROCESS_BIT_NV                = 0x00020000UL,
        FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000UL,
        SHADING_RATE_IMAGE_BIT_NV                = 0x00400000UL,
        ACCELERATION_STRUCTURE_BUILD_BIT_KHR     = 0x02000000UL,
        RAY_TRACING_SHADER_BIT_KHR               = 0x00200000UL,
        RAY_TRACING_SHADER_BIT_NV                = 0x00200000UL,
        ACCELERATION_STRUCTURE_BUILD_BIT_NV      = 0x02000000UL,
        FRAGMENT_DENSITY_PROCESS_BIT_EXT         = 0x00800000UL,
        TASK_SHADER_BIT_NV                       = 0x00080000UL,
        MESH_SHADER_BIT_NV                       = 0x00100000UL,
        SUBPASS_SHADING_BIT_HUAWEI               = 0x8000000000UL
    }

    [Flags]
    public enum VkAccessFlagBits2KHR : ulong
    {
        NONE_KHR                                      = 0UL,
        INDIRECT_COMMAND_READ_BIT_KHR                 = 0x00000001UL,
        INDEX_READ_BIT_KHR                            = 0x00000002UL,
        VERTEX_ATTRIBUTE_READ_BIT_KHR                 = 0x00000004UL,
        UNIFORM_READ_BIT_KHR                          = 0x00000008UL,
        INPUT_ATTACHMENT_READ_BIT_KHR                 = 0x00000010UL,
        SHADER_READ_BIT_KHR                           = 0x00000020UL,
        SHADER_WRITE_BIT_KHR                          = 0x00000040UL,
        COLOR_ATTACHMENT_READ_BIT_KHR                 = 0x00000080UL,
        COLOR_ATTACHMENT_WRITE_BIT_KHR                = 0x00000100UL,
        DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR         = 0x00000200UL,
        DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR        = 0x00000400UL,
        TRANSFER_READ_BIT_KHR                         = 0x00000800UL,
        TRANSFER_WRITE_BIT_KHR                        = 0x00001000UL,
        HOST_READ_BIT_KHR                             = 0x00002000UL,
        HOST_WRITE_BIT_KHR                            = 0x00004000UL,
        MEMORY_READ_BIT_KHR                           = 0x00008000UL,
        MEMORY_WRITE_BIT_KHR                          = 0x00010000UL,
        SHADER_SAMPLED_READ_BIT_KHR                   = 0x100000000UL,
        SHADER_STORAGE_READ_BIT_KHR                   = 0x200000000UL,
        SHADER_STORAGE_WRITE_BIT_KHR                  = 0x400000000UL,
        VIDEO_DECODE_READ_BIT_KHR                     = 0x800000000UL,
        VIDEO_DECODE_WRITE_BIT_KHR                    = 0x1000000000UL,
        VIDEO_ENCODE_READ_BIT_KHR                     = 0x2000000000UL,
        VIDEO_ENCODE_WRITE_BIT_KHR                    = 0x4000000000UL,
        RESERVED_READ_35_BIT_KHR                      = 0x800000000UL,
        RESERVED_WRITE_36_BIT_KHR                     = 0x1000000000UL,
        RESERVED_READ_37_BIT_KHR                      = 0x2000000000UL,
        RESERVED_WRITE_38_BIT_KHR                     = 0x4000000000UL,
        TRANSFORM_FEEDBACK_WRITE_BIT_EXT              = 0x02000000UL,
        TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT       = 0x04000000UL,
        TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT      = 0x08000000UL,
        CONDITIONAL_RENDERING_READ_BIT_EXT            = 0x00100000UL,
        COMMAND_PREPROCESS_READ_BIT_NV                = 0x00020000UL,
        COMMAND_PREPROCESS_WRITE_BIT_NV               = 0x00040000UL,
        FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000UL,
        SHADING_RATE_IMAGE_READ_BIT_NV                = 0x00800000UL,
        ACCELERATION_STRUCTURE_READ_BIT_KHR           = 0x00200000UL,
        ACCELERATION_STRUCTURE_WRITE_BIT_KHR          = 0x00400000UL,
        ACCELERATION_STRUCTURE_READ_BIT_NV            = 0x00200000UL,
        ACCELERATION_STRUCTURE_WRITE_BIT_NV           = 0x00400000UL,
        FRAGMENT_DENSITY_MAP_READ_BIT_EXT             = 0x01000000UL,
        COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT     = 0x00080000UL
    }

    [Flags]
    public enum VkSubmitFlagsKHR
    {
        PROTECTED_BIT_KHR      = 0x00000001,
        FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF
    }

    [Flags]
    public enum VkEventCreateFlagBits
    {
        DEVICE_ONLY_BIT_KHR = 0x00000001,
        FLAG_BITS_MAX_ENUM  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkQueryPipelineStatisticFlagBits
    {
        INPUT_ASSEMBLY_VERTICES_BIT                    = 0x00000001,
        INPUT_ASSEMBLY_PRIMITIVES_BIT                  = 0x00000002,
        VERTEX_SHADER_INVOCATIONS_BIT                  = 0x00000004,
        GEOMETRY_SHADER_INVOCATIONS_BIT                = 0x00000008,
        GEOMETRY_SHADER_PRIMITIVES_BIT                 = 0x00000010,
        CLIPPING_INVOCATIONS_BIT                       = 0x00000020,
        CLIPPING_PRIMITIVES_BIT                        = 0x00000040,
        FRAGMENT_SHADER_INVOCATIONS_BIT                = 0x00000080,
        TESSELLATION_CONTROL_SHADER_PATCHES_BIT        = 0x00000100,
        TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = 0x00000200,
        COMPUTE_SHADER_INVOCATIONS_BIT                 = 0x00000400,
        FLAG_BITS_MAX_ENUM                             = 0x7FFFFFFF
    }

    [Flags]
    public enum VkQueryResultFlagBits
    {
        _64_BIT               = 0x00000001,
        WAIT_BIT              = 0x00000002,
        WITH_AVAILABILITY_BIT = 0x00000004,
        PARTIAL_BIT           = 0x00000008,
        WITH_STATUS_BIT_KHR   = 0x00000010,
        FLAG_BITS_MAX_ENUM    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkBufferCreateFlagBits
    {
        SPARSE_BINDING_BIT                    = 0x00000001,
        SPARSE_RESIDENCY_BIT                  = 0x00000002,
        SPARSE_ALIASED_BIT                    = 0x00000004,
        PROTECTED_BIT                         = 0x00000008,
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT     = 0x00000010,
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
        FLAG_BITS_MAX_ENUM                    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkBufferUsageFlagBits
    {
        TRANSFER_SRC_BIT                                     = 0x00000001,
        TRANSFER_DST_BIT                                     = 0x00000002,
        UNIFORM_TEXEL_BUFFER_BIT                             = 0x00000004,
        STORAGE_TEXEL_BUFFER_BIT                             = 0x00000008,
        UNIFORM_BUFFER_BIT                                   = 0x00000010,
        STORAGE_BUFFER_BIT                                   = 0x00000020,
        INDEX_BUFFER_BIT                                     = 0x00000040,
        VERTEX_BUFFER_BIT                                    = 0x00000080,
        INDIRECT_BUFFER_BIT                                  = 0x00000100,
        SHADER_DEVICE_ADDRESS_BIT                            = 0x00020000,
        VIDEO_DECODE_SRC_BIT_KHR                             = 0x00002000,
        VIDEO_DECODE_DST_BIT_KHR                             = 0x00004000,
        TRANSFORM_FEEDBACK_BUFFER_BIT_EXT                    = 0x00000800,
        TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT            = 0x00001000,
        CONDITIONAL_RENDERING_BIT_EXT                        = 0x00000200,
        ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = 0x00080000,
        ACCELERATION_STRUCTURE_STORAGE_BIT_KHR               = 0x00100000,
        SHADER_BINDING_TABLE_BIT_KHR                         = 0x00000400,
        VIDEO_ENCODE_DST_BIT_KHR                             = 0x00008000,
        VIDEO_ENCODE_SRC_BIT_KHR                             = 0x00010000,
        RAY_TRACING_BIT_NV                                   = SHADER_BINDING_TABLE_BIT_KHR,
        SHADER_DEVICE_ADDRESS_BIT_EXT                        = SHADER_DEVICE_ADDRESS_BIT,
        SHADER_DEVICE_ADDRESS_BIT_KHR                        = SHADER_DEVICE_ADDRESS_BIT,
        FLAG_BITS_MAX_ENUM                                   = 0x7FFFFFFF
    }

    [Flags]
    public enum VkImageViewCreateFlagBits
    {
        VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT  = 0x00000001,
        VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT = 0x00000002,
        VK_IMAGE_VIEW_CREATE_FLAG_BITS_MAX_ENUM                    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkShaderModuleCreateFlagBits
    {
        MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineCacheCreateFlagBits
    {
        EXTERNALLY_SYNCHRONIZED_BIT_EXT = 0x00000001,
        FLAG_BITS_MAX_ENUM              = 0x7FFFFFFF
    }

    [Flags]
    public enum VkColorComponentFlagBits
    {
        R_BIT              = 0x00000001,
        G_BIT              = 0x00000002,
        B_BIT              = 0x00000004,
        A_BIT              = 0x00000008,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineCreateFlagBits
    {
        DISABLE_OPTIMIZATION_BIT                               = 0x00000001,
        ALLOW_DERIVATIVES_BIT                                  = 0x00000002,
        DERIVATIVE_BIT                                         = 0x00000004,
        VIEW_INDEX_FROM_DEVICE_INDEX_BIT                       = 0x00000008,
        DISPATCH_BASE_BIT                                      = 0x00000010,
        RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR            = 0x00004000,
        RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR        = 0x00008000,
        RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR               = 0x00010000,
        RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR       = 0x00020000,
        RAY_TRACING_SKIP_TRIANGLES_BIT_KHR                     = 0x00001000,
        RAY_TRACING_SKIP_AABBS_BIT_KHR                         = 0x00002000,
        RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = 0x00080000,
        DEFER_COMPILE_BIT_NV                                   = 0x00000020,
        CAPTURE_STATISTICS_BIT_KHR                             = 0x00000040,
        CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR               = 0x00000080,
        INDIRECT_BINDABLE_BIT_NV                               = 0x00040000,
        LIBRARY_BIT_KHR                                        = 0x00000800,
        FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_EXT              = 0x00000100,
        EARLY_RETURN_ON_FAILURE_BIT_EXT                        = 0x00000200,
        RAY_TRACING_ALLOW_MOTION_BIT_NV                        = 0x00100000,
        DISPATCH_BASE                                          = DISPATCH_BASE_BIT,
        VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR                   = VIEW_INDEX_FROM_DEVICE_INDEX_BIT,
        DISPATCH_BASE_KHR                                      = DISPATCH_BASE,
        FLAG_BITS_MAX_ENUM                                     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineShaderStageCreateFlagBits
    {
        ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = 0x00000001,
        REQUIRE_FULL_SUBGROUPS_BIT_EXT      = 0x00000002,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkShaderStageFlagBits
    {
        VERTEX_BIT                  = 0x00000001,
        TESSELLATION_CONTROL_BIT    = 0x00000002,
        TESSELLATION_EVALUATION_BIT = 0x00000004,
        GEOMETRY_BIT                = 0x00000008,
        FRAGMENT_BIT                = 0x00000010,
        COMPUTE_BIT                 = 0x00000020,
        ALL_GRAPHICS                = 0x0000001F,
        ALL                         = 0x7FFFFFFF,
        RAYGEN_BIT_KHR              = 0x00000100,
        ANY_HIT_BIT_KHR             = 0x00000200,
        CLOSEST_HIT_BIT_KHR         = 0x00000400,
        MISS_BIT_KHR                = 0x00000800,
        INTERSECTION_BIT_KHR        = 0x00001000,
        CALLABLE_BIT_KHR            = 0x00002000,
        TASK_BIT_NV                 = 0x00000040,
        MESH_BIT_NV                 = 0x00000080,
        SUBPASS_SHADING_BIT_HUAWEI  = 0x00004000,
        RAYGEN_BIT_NV               = RAYGEN_BIT_KHR,
        ANY_HIT_BIT_NV              = ANY_HIT_BIT_KHR,
        CLOSEST_HIT_BIT_NV          = CLOSEST_HIT_BIT_KHR,
        MISS_BIT_NV                 = MISS_BIT_KHR,
        INTERSECTION_BIT_NV         = INTERSECTION_BIT_KHR,
        CALLABLE_BIT_NV             = CALLABLE_BIT_KHR,
        FLAG_BITS_MAX_ENUM          = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCullModeFlagBits
    {
        NONE               = 0,
        FRONT_BIT          = 0x00000001,
        BACK_BIT           = 0x00000002,
        FRONT_AND_BACK     = 0x00000003,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSamplerCreateFlagBits
    {
        SUBSAMPLED_BIT_EXT                       = 0x00000001,
        SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = 0x00000002,
        FLAG_BITS_MAX_ENUM                       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDescriptorPoolCreateFlagBits
    {
        FREE_DESCRIPTOR_SET_BIT   = 0x00000001,
        UPDATE_AFTER_BIND_BIT     = 0x00000002,
        HOST_ONLY_BIT_VALVE       = 0x00000004,
        UPDATE_AFTER_BIND_BIT_EXT = UPDATE_AFTER_BIND_BIT,
        FLAG_BITS_MAX_ENUM        = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDescriptorSetLayoutCreateFlagBits
    {
        UPDATE_AFTER_BIND_POOL_BIT     = 0x00000002,
        PUSH_DESCRIPTOR_BIT_KHR        = 0x00000001,
        HOST_ONLY_POOL_BIT_VALVE       = 0x00000004,
        UPDATE_AFTER_BIND_POOL_BIT_EXT = UPDATE_AFTER_BIND_POOL_BIT,
        FLAG_BITS_MAX_ENUM             = 0x7FFFFFFF
    }

    [Flags]
    public enum VkAttachmentDescriptionFlagBits
    {
        MAY_ALIAS_BIT      = 0x00000001,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDependencyFlagBits
    {
        BY_REGION_BIT        = 0x00000001,
        DEVICE_GROUP_BIT     = 0x00000004,
        VIEW_LOCAL_BIT       = 0x00000002,
        VIEW_LOCAL_BIT_KHR   = VIEW_LOCAL_BIT,
        DEVICE_GROUP_BIT_KHR = DEVICE_GROUP_BIT,
        FLAG_BITS_MAX_ENUM   = 0x7FFFFFFF
    }

    [Flags]
    public enum VkFramebufferCreateFlagBits
    {
        IMAGELESS_BIT      = 0x00000001,
        IMAGELESS_BIT_KHR  = IMAGELESS_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkRenderPassCreateFlagBits
    {
        TRANSFORM_BIT_QCOM = 0x00000002,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSubpassDescriptionFlagBits
    {
        PER_VIEW_ATTRIBUTES_BIT_NVX      = 0x00000001,
        PER_VIEW_POSITION_X_ONLY_BIT_NVX = 0x00000002,
        FRAGMENT_REGION_BIT_QCOM         = 0x00000004,
        SHADER_RESOLVE_BIT_QCOM          = 0x00000008,
        FLAG_BITS_MAX_ENUM               = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCommandPoolCreateFlagBits
    {
        TRANSIENT_BIT            = 0x00000001,
        RESET_COMMAND_BUFFER_BIT = 0x00000002,
        PROTECTED_BIT            = 0x00000004,
        FLAG_BITS_MAX_ENUM       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCommandPoolResetFlagBits
    {
        RELEASE_RESOURCES_BIT = 0x00000001,
        FLAG_BITS_MAX_ENUM    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCommandBufferUsageFlagBits
    {
        ONE_TIME_SUBMIT_BIT      = 0x00000001,
        RENDER_PASS_CONTINUE_BIT = 0x00000002,
        SIMULTANEOUS_USE_BIT     = 0x00000004,
        FLAG_BITS_MAX_ENUM       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkQueryControlFlagBits
    {
        PRECISE_BIT        = 0x00000001,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCommandBufferResetFlagBits
    {
        RELEASE_RESOURCES_BIT = 0x00000001,
        FLAG_BITS_MAX_ENUM    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkStencilFaceFlagBits
    {
        VK_STENCIL_FACE_FRONT_BIT          = 0x00000001,
        VK_STENCIL_FACE_BACK_BIT           = 0x00000002,
        VK_STENCIL_FACE_FRONT_AND_BACK     = 0x00000003,
        VK_STENCIL_FRONT_AND_BACK          = VK_STENCIL_FACE_FRONT_AND_BACK,
        VK_STENCIL_FACE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkPointClippingBehavior
    {
        ALL_CLIP_PLANES           = 0,
        USER_CLIP_PLANES_ONLY     = 1,
        ALL_CLIP_PLANES_KHR       = ALL_CLIP_PLANES,
        USER_CLIP_PLANES_ONLY_KHR = USER_CLIP_PLANES_ONLY,
        MAX_ENUM                  = 0x7FFFFFFF
    }

    public enum VkTessellationDomainOrigin
    {
        UPPER_LEFT     = 0,
        LOWER_LEFT     = 1,
        UPPER_LEFT_KHR = UPPER_LEFT,
        LOWER_LEFT_KHR = LOWER_LEFT,
        MAX_ENUM       = 0x7FFFFFFF
    }

    public enum VkSamplerYcbcrModelConversion
    {
        RGB_IDENTITY       = 0,
        YCBCR_IDENTITY     = 1,
        YCBCR_709          = 2,
        YCBCR_601          = 3,
        YCBCR_2020         = 4,
        RGB_IDENTITY_KHR   = RGB_IDENTITY,
        YCBCR_IDENTITY_KHR = YCBCR_IDENTITY,
        YCBCR_709_KHR      = YCBCR_709,
        YCBCR_601_KHR      = YCBCR_601,
        YCBCR_2020_KHR     = YCBCR_2020,
        MAX_ENUM           = 0x7FFFFFFF
    }

    public enum VkSamplerYcbcrRange
    {
        ITU_FULL       = 0,
        ITU_NARROW     = 1,
        ITU_FULL_KHR   = ITU_FULL,
        ITU_NARROW_KHR = ITU_NARROW,
        MAX_ENUM       = 0x7FFFFFFF
    }

    public enum VkChromaLocation
    {
        COSITED_EVEN     = 0,
        MIDPOINT         = 1,
        COSITED_EVEN_KHR = COSITED_EVEN,
        MIDPOINT_KHR     = MIDPOINT,
        MAX_ENUM         = 0x7FFFFFFF
    }

    public enum VkDescriptorUpdateTemplateType
    {
        DESCRIPTOR_SET       = 0,
        PUSH_DESCRIPTORS_KHR = 1,
        DESCRIPTOR_SET_KHR   = DESCRIPTOR_SET,
        MAX_ENUM             = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSubgroupFeatureFlagBits
    {
        BASIC_BIT            = 0x00000001,
        VOTE_BIT             = 0x00000002,
        ARITHMETIC_BIT       = 0x00000004,
        BALLOT_BIT           = 0x00000008,
        SHUFFLE_BIT          = 0x00000010,
        SHUFFLE_RELATIVE_BIT = 0x00000020,
        CLUSTERED_BIT        = 0x00000040,
        QUAD_BIT             = 0x00000080,
        PARTITIONED_BIT_NV   = 0x00000100,
        FLAG_BITS_MAX_ENUM   = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPeerMemoryFeatureFlagBits
    {
        COPY_SRC_BIT        = 0x00000001,
        COPY_DST_BIT        = 0x00000002,
        GENERIC_SRC_BIT     = 0x00000004,
        GENERIC_DST_BIT     = 0x00000008,
        COPY_SRC_BIT_KHR    = COPY_SRC_BIT,
        COPY_DST_BIT_KHR    = COPY_DST_BIT,
        GENERIC_SRC_BIT_KHR = GENERIC_SRC_BIT,
        GENERIC_DST_BIT_KHR = GENERIC_DST_BIT,
        FLAG_BITS_MAX_ENUM  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkMemoryAllocateFlagBits
    {
        DEVICE_MASK_BIT                       = 0x00000001,
        DEVICE_ADDRESS_BIT                    = 0x00000002,
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT     = 0x00000004,
        DEVICE_MASK_BIT_KHR                   = DEVICE_MASK_BIT,
        DEVICE_ADDRESS_BIT_KHR                = DEVICE_ADDRESS_BIT,
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = DEVICE_ADDRESS_CAPTURE_REPLAY_BIT,
        FLAG_BITS_MAX_ENUM                    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits
    {
        OPAQUE_FD_BIT                       = 0x00000001,
        OPAQUE_WIN32_BIT                    = 0x00000002,
        OPAQUE_WIN32_KMT_BIT                = 0x00000004,
        D3D11_TEXTURE_BIT                   = 0x00000008,
        D3D11_TEXTURE_KMT_BIT               = 0x00000010,
        D3D12_HEAP_BIT                      = 0x00000020,
        D3D12_RESOURCE_BIT                  = 0x00000040,
        DMA_BUF_BIT_EXT                     = 0x00000200,
        ANDROID_HARDWARE_BUFFER_BIT_ANDROID = 0x00000400,
        HOST_ALLOCATION_BIT_EXT             = 0x00000080,
        HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT  = 0x00000100,
        ZIRCON_VMO_BIT_FUCHSIA              = 0x00000800,
        OPAQUE_FD_BIT_KHR                   = OPAQUE_FD_BIT,
        OPAQUE_WIN32_BIT_KHR                = OPAQUE_WIN32_BIT,
        OPAQUE_WIN32_KMT_BIT_KHR            = OPAQUE_WIN32_KMT_BIT,
        D3D11_TEXTURE_BIT_KHR               = D3D11_TEXTURE_BIT,
        D3D11_TEXTURE_KMT_BIT_KHR           = D3D11_TEXTURE_KMT_BIT,
        D3D12_HEAP_BIT_KHR                  = D3D12_HEAP_BIT,
        D3D12_RESOURCE_BIT_KHR              = D3D12_RESOURCE_BIT,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlagBits
    {
        DEDICATED_ONLY_BIT     = 0x00000001,
        EXPORTABLE_BIT         = 0x00000002,
        IMPORTABLE_BIT         = 0x00000004,
        DEDICATED_ONLY_BIT_KHR = DEDICATED_ONLY_BIT,
        EXPORTABLE_BIT_KHR     = EXPORTABLE_BIT,
        IMPORTABLE_BIT_KHR     = IMPORTABLE_BIT,
        FLAG_BITS_MAX_ENUM     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits
    {
        OPAQUE_FD_BIT            = 0x00000001,
        OPAQUE_WIN32_BIT         = 0x00000002,
        OPAQUE_WIN32_KMT_BIT     = 0x00000004,
        SYNC_FD_BIT              = 0x00000008,
        OPAQUE_FD_BIT_KHR        = OPAQUE_FD_BIT,
        OPAQUE_WIN32_BIT_KHR     = OPAQUE_WIN32_BIT,
        OPAQUE_WIN32_KMT_BIT_KHR = OPAQUE_WIN32_KMT_BIT,
        SYNC_FD_BIT_KHR          = SYNC_FD_BIT,
        FLAG_BITS_MAX_ENUM       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalFenceFeatureFlagBits
    {
        EXPORTABLE_BIT     = 0x00000001,
        IMPORTABLE_BIT     = 0x00000002,
        EXPORTABLE_BIT_KHR = EXPORTABLE_BIT,
        IMPORTABLE_BIT_KHR = IMPORTABLE_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkFenceImportFlagBits
    {
        TEMPORARY_BIT      = 0x00000001,
        TEMPORARY_BIT_KHR  = TEMPORARY_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSemaphoreImportFlagBits
    {
        TEMPORARY_BIT      = 0x00000001,
        TEMPORARY_BIT_KHR  = TEMPORARY_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits
    {
        OPAQUE_FD_BIT            = 0x00000001,
        OPAQUE_WIN32_BIT         = 0x00000002,
        OPAQUE_WIN32_KMT_BIT     = 0x00000004,
        D3D12_FENCE_BIT          = 0x00000008,
        SYNC_FD_BIT              = 0x00000010,
        ZIRCON_EVENT_BIT_FUCHSIA = 0x00000080,
        D3D11_FENCE_BIT          = D3D12_FENCE_BIT,
        OPAQUE_FD_BIT_KHR        = OPAQUE_FD_BIT,
        OPAQUE_WIN32_BIT_KHR     = OPAQUE_WIN32_BIT,
        OPAQUE_WIN32_KMT_BIT_KHR = OPAQUE_WIN32_KMT_BIT,
        D3D12_FENCE_BIT_KHR      = D3D12_FENCE_BIT,
        SYNC_FD_BIT_KHR          = SYNC_FD_BIT,
        FLAG_BITS_MAX_ENUM       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalSemaphoreFeatureFlagBits
    {
        EXPORTABLE_BIT     = 0x00000001,
        IMPORTABLE_BIT     = 0x00000002,
        EXPORTABLE_BIT_KHR = EXPORTABLE_BIT,
        IMPORTABLE_BIT_KHR = IMPORTABLE_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkDriverId
    {
        AMD_PROPRIETARY               = 1,
        AMD_OPEN_SOURCE               = 2,
        MESA_RADV                     = 3,
        NVIDIA_PROPRIETARY            = 4,
        INTEL_PROPRIETARY_WINDOWS     = 5,
        INTEL_OPEN_SOURCE_MESA        = 6,
        IMAGINATION_PROPRIETARY       = 7,
        QUALCOMM_PROPRIETARY          = 8,
        ARM_PROPRIETARY               = 9,
        GOOGLE_SWIFTSHADER            = 10,
        GGP_PROPRIETARY               = 11,
        BROADCOM_PROPRIETARY          = 12,
        MESA_LLVMPIPE                 = 13,
        MOLTENVK                      = 14,
        COREAVI_PROPRIETARY           = 15,
        JUICE_PROPRIETARY             = 16,
        AMD_PROPRIETARY_KHR           = AMD_PROPRIETARY,
        AMD_OPEN_SOURCE_KHR           = AMD_OPEN_SOURCE,
        MESA_RADV_KHR                 = MESA_RADV,
        NVIDIA_PROPRIETARY_KHR        = NVIDIA_PROPRIETARY,
        INTEL_PROPRIETARY_WINDOWS_KHR = INTEL_PROPRIETARY_WINDOWS,
        INTEL_OPEN_SOURCE_MESA_KHR    = INTEL_OPEN_SOURCE_MESA,
        IMAGINATION_PROPRIETARY_KHR   = IMAGINATION_PROPRIETARY,
        QUALCOMM_PROPRIETARY_KHR      = QUALCOMM_PROPRIETARY,
        ARM_PROPRIETARY_KHR           = ARM_PROPRIETARY,
        GOOGLE_SWIFTSHADER_KHR        = GOOGLE_SWIFTSHADER,
        GGP_PROPRIETARY_KHR           = GGP_PROPRIETARY,
        BROADCOM_PROPRIETARY_KHR      = BROADCOM_PROPRIETARY,
        MAX_ENUM                      = 0x7FFFFFFF
    }

    public enum VkShaderFloatControlsIndependence
    {
        _32_BIT_ONLY     = 0,
        ALL              = 1,
        NONE             = 2,
        _32_BIT_ONLY_KHR = _32_BIT_ONLY,
        ALL_KHR          = ALL,
        NONE_KHR         = NONE,
        MAX_ENUM         = 0x7FFFFFFF
    }

    public enum VkSamplerReductionMode
    {
        WEIGHTED_AVERAGE     = 0,
        MIN                  = 1,
        MAX                  = 2,
        WEIGHTED_AVERAGE_EXT = WEIGHTED_AVERAGE,
        MIN_EXT              = MIN,
        MAX_EXT              = MAX,
        MAX_ENUM             = 0x7FFFFFFF
    }

    public enum VkSemaphoreType
    {
        BINARY       = 0,
        TIMELINE     = 1,
        BINARY_KHR   = BINARY,
        TIMELINE_KHR = TIMELINE,
        MAX_ENUM     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkResolveModeFlagBits
    {
        NONE                = 0,
        SAMPLE_ZERO_BIT     = 0x00000001,
        AVERAGE_BIT         = 0x00000002,
        MIN_BIT             = 0x00000004,
        MAX_BIT             = 0x00000008,
        NONE_KHR            = NONE,
        SAMPLE_ZERO_BIT_KHR = SAMPLE_ZERO_BIT,
        AVERAGE_BIT_KHR     = AVERAGE_BIT,
        MIN_BIT_KHR         = MIN_BIT,
        MAX_BIT_KHR         = MAX_BIT,
        FLAG_BITS_MAX_ENUM  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDescriptorBindingFlagBits
    {
        UPDATE_AFTER_BIND_BIT               = 0x00000001,
        UPDATE_UNUSED_WHILE_PENDING_BIT     = 0x00000002,
        PARTIALLY_BOUND_BIT                 = 0x00000004,
        VARIABLE_DESCRIPTOR_COUNT_BIT       = 0x00000008,
        UPDATE_AFTER_BIND_BIT_EXT           = UPDATE_AFTER_BIND_BIT,
        UPDATE_UNUSED_WHILE_PENDING_BIT_EXT = UPDATE_UNUSED_WHILE_PENDING_BIT,
        PARTIALLY_BOUND_BIT_EXT             = PARTIALLY_BOUND_BIT,
        VARIABLE_DESCRIPTOR_COUNT_BIT_EXT   = VARIABLE_DESCRIPTOR_COUNT_BIT,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSemaphoreWaitFlagBits
    {
        ANY_BIT            = 0x00000001,
        ANY_BIT_KHR        = ANY_BIT,
        FLAG_BITS_MAX_ENUM = 0x7FFFFFFF
    }

    public enum VkPresentModeKHR
    {
        IMMEDIATE_KHR                 = 0,
        MAILBOX_KHR                   = 1,
        FIFO_KHR                      = 2,
        FIFO_RELAXED_KHR              = 3,
        SHARED_DEMAND_REFRESH_KHR     = 1000111000,
        SHARED_CONTINUOUS_REFRESH_KHR = 1000111001,
        MAX_ENUM_KHR                  = 0x7FFFFFFF
    }

    public enum VkColorSpaceKHR
    {
        SPACE_SRGB_NONLINEAR_KHR          = 0,
        SPACE_DISPLAY_P3_NONLINEAR_EXT    = 1000104001,
        SPACE_EXTENDED_SRGB_LINEAR_EXT    = 1000104002,
        SPACE_DISPLAY_P3_LINEAR_EXT       = 1000104003,
        SPACE_DCI_P3_NONLINEAR_EXT        = 1000104004,
        SPACE_BT709_LINEAR_EXT            = 1000104005,
        SPACE_BT709_NONLINEAR_EXT         = 1000104006,
        SPACE_BT2020_LINEAR_EXT           = 1000104007,
        SPACE_HDR10_ST2084_EXT            = 1000104008,
        SPACE_DOLBYVISION_EXT             = 1000104009,
        SPACE_HDR10_HLG_EXT               = 1000104010,
        SPACE_ADOBERGB_LINEAR_EXT         = 1000104011,
        SPACE_ADOBERGB_NONLINEAR_EXT      = 1000104012,
        SPACE_PASS_THROUGH_EXT            = 1000104013,
        SPACE_EXTENDED_SRGB_NONLINEAR_EXT = 1000104014,
        SPACE_DISPLAY_NATIVE_AMD          = 1000213000,
        VK_COLORSPACE_SRGB_NONLINEAR_KHR  = SPACE_SRGB_NONLINEAR_KHR,
        SPACE_DCI_P3_LINEAR_EXT           = SPACE_DISPLAY_P3_LINEAR_EXT,
        SPACE_MAX_ENUM_KHR                = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSurfaceTransformFlagsKHR
    {
        IDENTITY_BIT_KHR                     = 0x00000001,
        ROTATE_90_BIT_KHR                    = 0x00000002,
        ROTATE_180_BIT_KHR                   = 0x00000004,
        ROTATE_270_BIT_KHR                   = 0x00000008,
        HORIZONTAL_MIRROR_BIT_KHR            = 0x00000010,
        HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR  = 0x00000020,
        HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = 0x00000040,
        HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = 0x00000080,
        INHERIT_BIT_KHR                      = 0x00000100,
        FLAG_BITS_MAX_ENUM_KHR               = 0x7FFFFFFF
    }

    [Flags]
    public enum VkCompositeAlphaFlagsKHR
    {
        OPAQUE_BIT_KHR          = 0x00000001,
        PRE_MULTIPLIED_BIT_KHR  = 0x00000002,
        POST_MULTIPLIED_BIT_KHR = 0x00000004,
        INHERIT_BIT_KHR         = 0x00000008,
        FLAG_BITS_MAX_ENUM_KHR  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkSwapchainCreateFlagsKHR
    {
        SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = 0x00000001,
        PROTECTED_BIT_KHR                   = 0x00000002,
        MUTABLE_FORMAT_BIT_KHR              = 0x00000004,
        FLAG_BITS_MAX_ENUM_KHR              = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDeviceGroupPresentModeFlagsKHR
    {
        LOCAL_BIT_KHR              = 0x00000001,
        REMOTE_BIT_KHR             = 0x00000002,
        SUM_BIT_KHR                = 0x00000004,
        LOCAL_MULTI_DEVICE_BIT_KHR = 0x00000008,
        FLAG_BITS_MAX_ENUM_KHR     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDisplayPlaneAlphaFlagsKHR
    {
        OPAQUE_BIT_KHR                  = 0x00000001,
        GLOBAL_BIT_KHR                  = 0x00000002,
        PER_PIXEL_BIT_KHR               = 0x00000004,
        PER_PIXEL_PREMULTIPLIED_BIT_KHR = 0x00000008,
        FLAG_BITS_MAX_ENUM_KHR          = 0x7FFFFFFF
    }

    public enum VkPerformanceCounterUnitKHR
    {
        GENERIC_KHR          = 0,
        PERCENTAGE_KHR       = 1,
        NANOSECONDS_KHR      = 2,
        BYTES_KHR            = 3,
        BYTES_PER_SECOND_KHR = 4,
        KELVIN_KHR           = 5,
        WATTS_KHR            = 6,
        VOLTS_KHR            = 7,
        AMPS_KHR             = 8,
        HERTZ_KHR            = 9,
        CYCLES_KHR           = 10,
        MAX_ENUM_KHR         = 0x7FFFFFFF
    }

    public enum VkPerformanceCounterScopeKHR
    {
        COMMAND_BUFFER_KHR             = 0,
        RENDER_PASS_KHR                = 1,
        COMMAND_KHR                    = 2,
        QUERY_SCOPE_COMMAND_BUFFER_KHR = COMMAND_BUFFER_KHR,
        QUERY_SCOPE_RENDER_PASS_KHR    = RENDER_PASS_KHR,
        QUERY_SCOPE_COMMAND_KHR        = COMMAND_KHR,
        MAX_ENUM_KHR                   = 0x7FFFFFFF
    }

    public enum VkPerformanceCounterStorageKHR
    {
        INT32_KHR    = 0,
        INT64_KHR    = 1,
        UINT32_KHR   = 2,
        UINT64_KHR   = 3,
        FLOAT32_KHR  = 4,
        FLOAT64_KHR  = 5,
        MAX_ENUM_KHR = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPerformanceCounterDescriptionFlagsKHR
    {
        PERFORMANCE_IMPACTING_BIT_KHR = 0x00000001,
        CONCURRENTLY_IMPACTED_BIT_KHR = 0x00000002,
        PERFORMANCE_IMPACTING_KHR     = PERFORMANCE_IMPACTING_BIT_KHR,
        CONCURRENTLY_IMPACTED_KHR     = CONCURRENTLY_IMPACTED_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR        = 0x7FFFFFFF
    }

    [Flags]
    public enum VkAcquireProfilingLockFlagsKHR
    {
        MAX_ENUM_KHR = 0x7FFFFFFF
    }

    public enum VkFragmentShadingRateCombinerOpKHR
    {
        KEEP_KHR     = 0,
        REPLACE_KHR  = 1,
        MIN_KHR      = 2,
        MAX_KHR      = 3,
        MUL_KHR      = 4,
        MAX_ENUM_KHR = 0x7FFFFFFF
    }

    public enum VkPipelineExecutableStatisticFormatKHR
    {
        BOOL32_KHR   = 0,
        INT64_KHR    = 1,
        UINT64_KHR   = 2,
        FLOAT64_KHR  = 3,
        MAX_ENUM_KHR = 0x7FFFFFFF
    }

    public enum VkRasterizationOrderAMD
    {
        STRICT_AMD   = 0,
        RELAXED_AMD  = 1,
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    public enum VkShaderInfoTypeAMD
    {
        STATISTICS_AMD  = 0,
        BINARY_AMD      = 1,
        DISASSEMBLY_AMD = 2,
        MAX_ENUM_AMD    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsNV
    {
        OPAQUE_WIN32_BIT_NV     = 0x00000001,
        OPAQUE_WIN32_KMT_BIT_NV = 0x00000002,
        D3D11_IMAGE_BIT_NV      = 0x00000004,
        D3D11_IMAGE_KMT_BIT_NV  = 0x00000008,
        FLAG_BITS_MAX_ENUM_NV   = 0x7FFFFFFF
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV
    {
        DEDICATED_ONLY_BIT_NV = 0x00000001,
        EXPORTABLE_BIT_NV     = 0x00000002,
        IMPORTABLE_BIT_NV     = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }

    public enum VkViewportCoordinateSwizzleNV
    {
        POSITIVE_X_NV = 0,
        NEGATIVE_X_NV = 1,
        POSITIVE_Y_NV = 2,
        NEGATIVE_Y_NV = 3,
        POSITIVE_Z_NV = 4,
        NEGATIVE_Z_NV = 5,
        POSITIVE_W_NV = 6,
        NEGATIVE_W_NV = 7,
        MAX_ENUM_NV   = 0x7FFFFFFF
    }

    public enum VkCoverageModulationModeNV
    {
        NONE_NV     = 0,
        RGB_NV      = 1,
        ALPHA_NV    = 2,
        RGBA_NV     = 3,
        MAX_ENUM_NV = 0x7FFFFFFF
    }

    public enum VkShadingRatePaletteEntryNV
    {
        NO_INVOCATIONS_NV               = 0,
        _16_INVOCATIONS_PER_PIXEL_NV    = 1,
        _8_INVOCATIONS_PER_PIXEL_NV     = 2,
        _4_INVOCATIONS_PER_PIXEL_NV     = 3,
        _2_INVOCATIONS_PER_PIXEL_NV     = 4,
        _1_INVOCATION_PER_PIXEL_NV      = 5,
        _1_INVOCATION_PER_2X1_PIXELS_NV = 6,
        _1_INVOCATION_PER_1X2_PIXELS_NV = 7,
        _1_INVOCATION_PER_2X2_PIXELS_NV = 8,
        _1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        _1_INVOCATION_PER_2X4_PIXELS_NV = 10,
        _1_INVOCATION_PER_4X4_PIXELS_NV = 11,
        MAX_ENUM_NV                     = 0x7FFFFFFF
    }

    public enum VkCoarseSampleOrderTypeNV
    {
        DEFAULT_NV      = 0,
        CUSTOM_NV       = 1,
        PIXEL_MAJOR_NV  = 2,
        SAMPLE_MAJOR_NV = 3,
        MAX_ENUM_NV     = 0x7FFFFFFF
    }

    public enum VkRayTracingShaderGroupTypeKHR
    {
        GENERAL_KHR              = 0,
        TRIANGLES_HIT_GROUP_KHR  = 1,
        PROCEDURAL_HIT_GROUP_KHR = 2,
        GENERAL_NV               = GENERAL_KHR,
        TRIANGLES_HIT_GROUP_NV   = TRIANGLES_HIT_GROUP_KHR,
        PROCEDURAL_HIT_GROUP_NV  = PROCEDURAL_HIT_GROUP_KHR,
        MAX_ENUM_KHR             = 0x7FFFFFFF
    }

    public enum VkGeometryTypeKHR
    {
        TRIANGLES_KHR = 0,
        AABBS_KHR     = 1,
        INSTANCES_KHR = 2,
        TRIANGLES_NV  = TRIANGLES_KHR,
        AABBS_NV      = AABBS_KHR,
        MAX_ENUM_KHR  = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureTypeKHR
    {
        TOP_LEVEL_KHR    = 0,
        BOTTOM_LEVEL_KHR = 1,
        GENERIC_KHR      = 2,
        TOP_LEVEL_NV     = TOP_LEVEL_KHR,
        BOTTOM_LEVEL_NV  = BOTTOM_LEVEL_KHR,
        MAX_ENUM_KHR     = 0x7FFFFFFF
    }

    public enum VkCopyAccelerationStructureModeKHR
    {
        CLONE_KHR       = 0,
        COMPACT_KHR     = 1,
        SERIALIZE_KHR   = 2,
        DESERIALIZE_KHR = 3,
        CLONE_NV        = CLONE_KHR,
        COMPACT_NV      = COMPACT_KHR,
        MAX_ENUM_KHR    = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureMemoryRequirementsTypeNV
    {
        OBJECT_NV         = 0,
        BUILD_SCRATCH_NV  = 1,
        UPDATE_SCRATCH_NV = 2,
        MAX_ENUM_NV       = 0x7FFFFFFF
    }

    [Flags]
    public enum VkGeometryFlagsKHR
    {
        OPAQUE_BIT_KHR                          = 0x00000001,
        NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = 0x00000002,
        OPAQUE_BIT_NV                           = OPAQUE_BIT_KHR,
        NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_NV  = NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkGeometryInstanceFlagsKHR
    {
        TRIANGLE_FACING_CULL_DISABLE_BIT_KHR    = 0x00000001,
        TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR = 0x00000002,
        FORCE_OPAQUE_BIT_KHR                    = 0x00000004,
        FORCE_NO_OPAQUE_BIT_KHR                 = 0x00000008,
        TRIANGLE_CULL_DISABLE_BIT_NV            = TRIANGLE_FACING_CULL_DISABLE_BIT_KHR,
        TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_NV  = TRIANGLE_FRONT_COUNTERCLOCKWISE_BIT_KHR,
        FORCE_OPAQUE_BIT_NV                     = FORCE_OPAQUE_BIT_KHR,
        FORCE_NO_OPAQUE_BIT_NV                  = FORCE_NO_OPAQUE_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR                  = 0x7FFFFFFF
    }

    [Flags]
    public enum VkBuildAccelerationStructureFlagsKHR
    {
        ALLOW_UPDATE_BIT_KHR      = 0x00000001,
        ALLOW_COMPACTION_BIT_KHR  = 0x00000002,
        PREFER_FAST_TRACE_BIT_KHR = 0x00000004,
        PREFER_FAST_BUILD_BIT_KHR = 0x00000008,
        LOW_MEMORY_BIT_KHR        = 0x00000010,
        STRUCTURE_MOTION_BIT_NV   = 0x00000020,
        ALLOW_UPDATE_BIT_NV       = ALLOW_UPDATE_BIT_KHR,
        ALLOW_COMPACTION_BIT_NV   = ALLOW_COMPACTION_BIT_KHR,
        PREFER_FAST_TRACE_BIT_NV  = PREFER_FAST_TRACE_BIT_KHR,
        PREFER_FAST_BUILD_BIT_NV  = PREFER_FAST_BUILD_BIT_KHR,
        LOW_MEMORY_BIT_NV         = LOW_MEMORY_BIT_KHR,
        FLAG_BITS_MAX_ENUM_KHR    = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD
    {
        MAX_ENUM_AMD = 0x7FFFFFFF
    }

    public enum VkMemoryOverallocationBehaviorAMD
    {
        DEFAULT_AMD    = 0,
        ALLOWED_AMD    = 1,
        DISALLOWED_AMD = 2,
        MAX_ENUM_AMD   = 0x7FFFFFFF
    }

    public enum VkPerformanceConfigurationTypeINTEL
    {
        COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,
        MAX_ENUM_INTEL                                  = 0x7FFFFFFF
    }

    public enum VkQueryPoolSamplingModeINTEL
    {
        MANUAL_INTEL   = 0,
        MAX_ENUM_INTEL = 0x7FFFFFFF
    }

    public enum VkPerformanceOverrideTypeINTEL
    {
        NULL_HARDWARE_INTEL    = 0,
        FLUSH_GPU_CACHES_INTEL = 1,
        MAX_ENUM_INTEL         = 0x7FFFFFFF
    }

    public enum VkPerformanceParameterTypeINTEL
    {
        HW_COUNTERS_SUPPORTED_INTEL    = 0,
        STREAM_MARKER_VALID_BITS_INTEL = 1,
        MAX_ENUM_INTEL                 = 0x7FFFFFFF
    }

    public enum VkPerformanceValueTypeINTEL
    {
        UINT32_INTEL   = 0,
        UINT64_INTEL   = 1,
        FLOAT_INTEL    = 2,
        BOOL_INTEL     = 3,
        STRING_INTEL   = 4,
        MAX_ENUM_INTEL = 0x7FFFFFFF
    }

    [Flags]
    public enum VkShaderCorePropertiesFlagsAMD
    {
        MAX_ENUM_AMD = 0x7FFFFFFF
    }


    public enum VkValidationFeatureEnableEXT
    {
        GPU_ASSISTED_EXT                      = 0,
        GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = 1,
        BEST_PRACTICES_EXT                    = 2,
        DEBUG_PRINTF_EXT                      = 3,
        SYNCHRONIZATION_VALIDATION_EXT        = 4,
        MAX_ENUM_EXT                          = 0x7FFFFFFF
    }

    public enum VkValidationFeatureDisableEXT
    {
        ALL_EXT                     = 0,
        SHADERS_EXT                 = 1,
        THREAD_SAFETY_EXT           = 2,
        API_PARAMETERS_EXT          = 3,
        OBJECT_LIFETIMES_EXT        = 4,
        CORE_CHECKS_EXT             = 5,
        UNIQUE_HANDLES_EXT          = 6,
        SHADER_VALIDATION_CACHE_EXT = 7,
        MAX_ENUM_EXT                = 0x7FFFFFFF
    }

    public enum VkComponentTypeNV
    {
        FLOAT16_NV  = 0,
        FLOAT32_NV  = 1,
        FLOAT64_NV  = 2,
        SINT8_NV    = 3,
        SINT16_NV   = 4,
        SINT32_NV   = 5,
        SINT64_NV   = 6,
        UINT8_NV    = 7,
        UINT16_NV   = 8,
        UINT32_NV   = 9,
        UINT64_NV   = 10,
        MAX_ENUM_NV = 0x7FFFFFFF
    }

    public enum VkScopeNV
    {
        DEVICE_NV       = 1,
        WORKGROUP_NV    = 2,
        SUBGROUP_NV     = 3,
        QUEUE_FAMILY_NV = 5,
        MAX_ENUM_NV     = 0x7FFFFFFF
    }

    public enum VkCoverageReductionModeNV
    {
        MERGE_NV    = 0,
        TRUNCATE_NV = 1,
        MAX_ENUM_NV = 0x7FFFFFFF
    }
    

    public enum VkIndirectCommandsTokenTypeNV
    {
        SHADER_GROUP_NV  = 0,
        STATE_FLAGS_NV   = 1,
        INDEX_BUFFER_NV  = 2,
        VERTEX_BUFFER_NV = 3,
        PUSH_CONSTANT_NV = 4,
        DRAW_INDEXED_NV  = 5,
        DRAW_NV          = 6,
        DRAW_TASKS_NV    = 7,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }

    [Flags]
    public enum VkIndirectStateFlagsNV
    {
        FRONTFACE_BIT_NV = 0x00000001,
        BITS_MAX_ENUM_NV = 0x7FFFFFFF
    }

    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsNV
    {
        EXPLICIT_PREPROCESS_BIT_NV = 0x00000001,
        INDEXED_SEQUENCES_BIT_NV   = 0x00000002,
        UNORDERED_SEQUENCES_BIT_NV = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV      = 0x7FFFFFFF
    }

    [Flags]
    public enum VkPrivateDataSlotCreateFlagsEXT
    {
        MAX_ENUM_EXT = 0x7FFFFFFF
    }

    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagsNV
    {
        ENABLE_SHADER_DEBUG_INFO_BIT_NV     = 0x00000001,
        ENABLE_RESOURCE_TRACKING_BIT_NV     = 0x00000002,
        ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = 0x00000004,
        FLAG_BITS_MAX_ENUM_NV               = 0x7FFFFFFF
    }

    public enum VkFragmentShadingRateTypeNV
    {
        FRAGMENT_SIZE_NV = 0,
        ENUMS_NV         = 1,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }

    public enum VkFragmentShadingRateNV
    {
        _1_INVOCATION_PER_PIXEL_NV      = 0,
        _1_INVOCATION_PER_1X2_PIXELS_NV = 1,
        _1_INVOCATION_PER_2X1_PIXELS_NV = 4,
        _1_INVOCATION_PER_2X2_PIXELS_NV = 5,
        _1_INVOCATION_PER_2X4_PIXELS_NV = 6,
        _1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        _1_INVOCATION_PER_4X4_PIXELS_NV = 10,
        _2_INVOCATIONS_PER_PIXEL_NV     = 11,
        _4_INVOCATIONS_PER_PIXEL_NV     = 12,
        _8_INVOCATIONS_PER_PIXEL_NV     = 13,
        _16_INVOCATIONS_PER_PIXEL_NV    = 14,
        NO_INVOCATIONS_NV               = 15,
        MAX_ENUM_NV                     = 0x7FFFFFFF
    }

    public enum VkBuildAccelerationStructureModeKHR
    {
        BUILD_KHR    = 0,
        UPDATE_KHR   = 1,
        MAX_ENUM_KHR = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureBuildTypeKHR
    {
        HOST_KHR           = 0,
        DEVICE_KHR         = 1,
        HOST_OR_DEVICE_KHR = 2,
        MAX_ENUM_KHR       = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureCompatibilityKHR
    {
        COMPATIBLE_KHR   = 0,
        INCOMPATIBLE_KHR = 1,
        MAX_ENUM_KHR     = 0x7FFFFFFF
    }

    [Flags]
    public enum VkAccelerationStructureCreateFlagsKHR
    {
        DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = 0x00000001,
        MOTION_BIT_NV                         = 0x00000004,
        FLAG_BITS_MAX_ENUM_KHR                = 0x7FFFFFFF
    }

    public enum VkShaderGroupShaderKHR
    {
        GENERAL_KHR      = 0,
        CLOSEST_HIT_KHR  = 1,
        ANY_HIT_KHR      = 2,
        INTERSECTION_KHR = 3,
        MAX_ENUM_KHR     = 0x7FFFFFFF
    }

    public enum VkProvokingVertexModeEXT {
        FIRST_VERTEX_EXT = 0,
        LAST_VERTEX_EXT  = 1,
        MAX_ENUM_EXT     = 0x7FFFFFFF
    }

    public enum VkAccelerationStructureMotionInstanceTypeNV
    {
        STATIC_NV        = 0,
        MATRIX_MOTION_NV = 1,
        SRT_MOTION_NV    = 2,
        MAX_ENUM_NV      = 0x7FFFFFFF
    }
}