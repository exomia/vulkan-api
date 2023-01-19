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
///     VkBuildMicromapModeEXT - Enum specifying the type of build operation to perform -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBuildMicromapModeEXT.html</a>
/// </summary>
public enum VkBuildMicromapModeEXT
{
    /// <summary>
    ///     VK_BUILD_MICROMAP_MODE_BUILD_EXT specifies that the destination micromap will be built using the specified
    ///     data.
    /// </summary>
    VK_BUILD_MICROMAP_MODE_BUILD_EXT = 0
}