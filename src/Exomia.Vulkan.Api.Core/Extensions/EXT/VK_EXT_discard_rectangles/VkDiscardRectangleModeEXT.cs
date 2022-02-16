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
///     VkDiscardRectangleModeEXT - Specify the discard rectangle mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDiscardRectangleModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDiscardRectangleModeEXT.html</a>
/// </summary>
public enum VkDiscardRectangleModeEXT
{
    /// <summary>VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT specifies that the discard rectangle test is inclusive.</summary>
    VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT = 0,

    /// <summary>VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT specifies that the discard rectangle test is exclusive.</summary>
    VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT = 1
}