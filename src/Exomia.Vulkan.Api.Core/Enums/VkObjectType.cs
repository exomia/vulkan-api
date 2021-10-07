#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member



// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
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
}