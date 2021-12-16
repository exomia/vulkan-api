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