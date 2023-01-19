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
///     VK_VERSION_1_0.constants - vulkan
/// </content>
public static partial class Vk
{
    /// <summary>
    ///     VK_ATTACHMENT_UNUSED - Unused attachment sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ATTACHMENT_UNUSED.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_ATTACHMENT_UNUSED.html</a>
    /// </summary>
    public const uint VK_ATTACHMENT_UNUSED = (~0U);

    /// <summary>
    ///     VK_FALSE - Boolean false value -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FALSE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_FALSE.html</a>
    /// </summary>
    public const uint VK_FALSE = 0;

    /// <summary>
    ///     VK_LOD_CLAMP_NONE - Maximum level of detail unclamped access sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LOD_CLAMP_NONE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_LOD_CLAMP_NONE.html</a>
    /// </summary>
    public const float VK_LOD_CLAMP_NONE = 1000.0F;

    /// <summary>
    ///     VK_QUEUE_FAMILY_IGNORED - Ignored queue family index sentinel -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_IGNORED.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_QUEUE_FAMILY_IGNORED.html</a>
    /// </summary>
    public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);

    /// <summary>
    ///     VK_REMAINING_ARRAY_LAYERS - Sentinel for all remaining array layers -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_ARRAY_LAYERS.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_ARRAY_LAYERS.html</a>
    /// </summary>
    public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);

    /// <summary>
    ///     VK_REMAINING_MIP_LEVELS - Sentinel for all remaining mipmap levels -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_MIP_LEVELS.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_REMAINING_MIP_LEVELS.html</a>
    /// </summary>
    public const uint VK_REMAINING_MIP_LEVELS = (~0U);

    /// <summary>
    ///     VK_SUBPASS_EXTERNAL - Subpass index sentinel expanding synchronization scope outside a subpass -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SUBPASS_EXTERNAL.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_SUBPASS_EXTERNAL.html</a>
    /// </summary>
    public const uint VK_SUBPASS_EXTERNAL = (~0U);

    /// <summary>
    ///     VK_TRUE - Boolean true value -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_TRUE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_TRUE.html</a>
    /// </summary>
    public const uint VK_TRUE = 1;

    /// <summary>
    ///     VK_WHOLE_SIZE - Sentinel value to use entire remaining array length -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_WHOLE_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_WHOLE_SIZE.html</a>
    /// </summary>
    public const ulong VK_WHOLE_SIZE = (~0UL);

    /// <summary>
    ///     VK_MAX_MEMORY_TYPES - Length of an array of memory types -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_TYPES.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_TYPES.html</a>
    /// </summary>
    public const uint VK_MAX_MEMORY_TYPES = 32;

    /// <summary>
    ///     VK_MAX_PHYSICAL_DEVICE_NAME_SIZE - Length of a physical device name string -
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_NAME_SIZE.html">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_PHYSICAL_DEVICE_NAME_SIZE.html
    ///     </a>
    /// </summary>
    public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256;

    /// <summary>
    ///     VK_UUID_SIZE - Length of a universally unique device or driver build identifier -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_UUID_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_UUID_SIZE.html</a>
    /// </summary>
    public const uint VK_UUID_SIZE = 16;

    /// <summary>
    ///     VK_MAX_EXTENSION_NAME_SIZE - Maximum length of a layer of extension name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_EXTENSION_NAME_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_EXTENSION_NAME_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_EXTENSION_NAME_SIZE = 256;

    /// <summary>
    ///     VK_MAX_DESCRIPTION_SIZE - Length of a driver name string -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DESCRIPTION_SIZE.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_DESCRIPTION_SIZE.html</a>
    /// </summary>
    public const uint VK_MAX_DESCRIPTION_SIZE = 256;

    /// <summary>
    ///     VK_MAX_MEMORY_HEAPS - Length of an array of memory heaps -
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_HEAPS.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VK_MAX_MEMORY_HEAPS.html</a>
    /// </summary>
    public const uint VK_MAX_MEMORY_HEAPS = 16;
}