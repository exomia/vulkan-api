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
namespace Exomia.Vulkan.Api.Core;

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