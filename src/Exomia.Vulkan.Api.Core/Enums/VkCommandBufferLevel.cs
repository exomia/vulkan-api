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
///     VkCommandBufferLevel - Enumerant specifying a command buffer level -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferLevel.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCommandBufferLevel.html</a>
/// </summary>
public enum VkCommandBufferLevel
{
    /// <summary>VK_COMMAND_BUFFER_LEVEL_PRIMARY specifies a primary command buffer.</summary>
    VK_COMMAND_BUFFER_LEVEL_PRIMARY = 0,

    /// <summary>VK_COMMAND_BUFFER_LEVEL_SECONDARY specifies a secondary command buffer.</summary>
    VK_COMMAND_BUFFER_LEVEL_SECONDARY = 1
}