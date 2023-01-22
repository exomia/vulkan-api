#region License

// Copyright (c) 2018-2023, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

// ReSharper disable InconsistentNaming 
// ReSharper disable UnusedMember.Global
namespace Exomia.Vulkan.Api.Core;

/// <content>
///     VK_VERSION_1_1.constants - vulkan
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     VK_MAX_DEVICE_GROUP_SIZE - Length of a physical device handle array -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DEVICE_GROUP_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DEVICE_GROUP_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_DEVICE_GROUP_SIZE = 32;

    /// <summary>
    ///     VK_LUID_SIZE - Length of a locally unique device identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LUID_SIZE.html</a>
    /// </summary>
    public const uint VK_LUID_SIZE = 8;

    /// <summary>
    ///     VK_QUEUE_FAMILY_EXTERNAL - External queue family index sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_EXTERNAL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_EXTERNAL.html</a>
    /// </summary>
    public const uint VK_QUEUE_FAMILY_EXTERNAL = (~1U);
}