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
///     VkFenceCreateFlagBits - Bitmask specifying initial state and behavior of a fence -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFenceCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkFenceCreateFlagBits
{
    /// <summary>
    ///     VK_FENCE_CREATE_SIGNALED_BIT specifies that the fence object is created in the signaled state. Otherwise, it
    ///     is created in the unsignaled state.
    /// </summary>
    VK_FENCE_CREATE_SIGNALED_BIT = 0x1
}