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
    public enum VkPipelineBindPoint
    {
        GRAPHICS               = 0,
        COMPUTE                = 1,
        RAY_TRACING_KHR        = 1000165000,
        SUBPASS_SHADING_HUAWEI = 1000369003,
        RAY_TRACING_NV         = RAY_TRACING_KHR,
        MAX_ENUM               = 0x7FFFFFFF
    }
}