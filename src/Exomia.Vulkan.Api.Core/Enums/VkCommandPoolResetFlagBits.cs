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
///     VkCommandPoolResetFlagBits - Bitmask controlling behavior of a command pool reset -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandPoolResetFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandPoolResetFlagBits.html</a>
/// </summary>
[Flags]
public enum VkCommandPoolResetFlagBits
{
    /// <summary>
    ///     VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT specifies that resetting a command pool recycles all of the
    ///     resources from the command pool back to the system.
    /// </summary>
    VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = 0x1,

    /// <summary>
    ///     VK_COMMAND_POOL_RESET_RESERVED_1_BIT_COREAVI<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCommandPoolResetFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkCommandPoolResetFlagBits</a>
    /// </summary>
    VK_COMMAND_POOL_RESET_RESERVED_1_BIT_COREAVI = 0x2
}