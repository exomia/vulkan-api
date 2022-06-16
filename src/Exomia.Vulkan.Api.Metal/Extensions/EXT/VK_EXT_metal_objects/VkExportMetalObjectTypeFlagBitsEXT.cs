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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalObjectTypeFlagBitsEXT - Bitmask specifying Metal object types that can be exported from a Vulkan
///     object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectTypeFlagBitsEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalObjectTypeFlagBitsEXT.html
///     </a>
/// </summary>
[Flags]
public enum VkExportMetalObjectTypeFlagBitsEXT
{
    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT indicates a Metal MTLDevice may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT = 0x1,

    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT indicates a Metal MTLCommandQueue may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT = 0x2,

    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT indicates a Metal MTLBuffer may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT = 0x4,

    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT indicates a Metal MTLTexture may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT = 0x8,

    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT indicates a Metal IOSurface may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT = 0x10,

    /// <summary>VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT indicates a Metal MTLSharedEvent may be exported.</summary>
    VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT = 0x20
}