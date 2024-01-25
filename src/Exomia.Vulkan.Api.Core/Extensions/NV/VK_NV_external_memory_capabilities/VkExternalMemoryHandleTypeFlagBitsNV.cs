#region License

// Copyright (c) 2018-2024, exomia
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
///     VkExternalMemoryHandleTypeFlagBitsNV - Bitmask specifying external memory handle types -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBitsNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBitsNV.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalMemoryHandleTypeFlagBitsNV
{
    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV specifies a handle to memory returned by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html">vkGetMemoryWin32HandleNV</a>
    ///     , or one duplicated from such a handle using DuplicateHandle().
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = 0x1,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV specifies a handle to memory returned by
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkGetMemoryWin32HandleNV.html">vkGetMemoryWin32HandleNV</a>
    ///     .
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = 0x2,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV specifies a valid NT handle to memory returned by
    ///     IDXGIResource1::CreateSharedHandle, or a handle duplicated from such a handle using DuplicateHandle().
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = 0x4,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV specifies a handle to memory returned by
    ///     IDXGIResource::GetSharedHandle().
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = 0x8
}