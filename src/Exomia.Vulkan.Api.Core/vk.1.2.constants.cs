#region License

// Copyright (c) 2018-2022, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable InconsistentNaming 
// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core;

/// <content>
///     VK_VERSION_1_2.constants - vulkan
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     VK_MAX_DRIVER_NAME_SIZE - Maximum length of a physical device driver name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_NAME_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_NAME_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_DRIVER_NAME_SIZE = 256;

    /// <summary>
    ///     VK_MAX_DRIVER_INFO_SIZE - Length of a physical device driver information string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_INFO_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DRIVER_INFO_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_DRIVER_INFO_SIZE = 256;
}