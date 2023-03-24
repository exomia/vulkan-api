#region License

// Copyright (c) 2018-2023, exomia
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
///     VkMicromapTypeEXT - Type of micromap -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapTypeEXT.html</a>
/// </summary>
public enum VkMicromapTypeEXT
{
    /// <summary>VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT is a micromap containing data to control the opacity of a triangle.</summary>
    VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT = 0,

    /// <summary>
    ///     VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV is a micromap containing data to control the displacement of
    ///     subtriangles within a triangle.
    /// </summary>
    VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV = 1000397000
}