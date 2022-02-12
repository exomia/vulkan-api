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
///     VkExternalFenceHandleTypeFlagBits - Bitmask of valid external fence handle types -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceHandleTypeFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalFenceHandleTypeFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalFenceHandleTypeFlagBits
{
    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX file descriptor handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It must be compatible with the POSIX system calls dup,
    ///     dup2, close, and the non-standard system call dup3. Additionally, it must be transportable over a socket using an
    ///     SCM_RIGHTS control message. It owns a reference to the underlying synchronization primitive represented by its
    ///     Vulkan fence object.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT = 1 << 0,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT handle that has only limited valid usage
    ///     outside of Vulkan and other compatible APIs. It must be compatible with the functions DuplicateHandle, CloseHandle,
    ///     CompareObjectHandles, GetHandleInformation, and SetHandleInformation. It owns a reference to the underlying
    ///     synchronization primitive represented by its Vulkan fence object.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT = 1 << 1,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a global share handle that has only limited valid
    ///     usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own a
    ///     reference to the underlying synchronization primitive represented by its Vulkan fence object, and will therefore
    ///     become invalid when all Vulkan fence objects associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 1 << 2,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT specifies a POSIX file descriptor handle to a Linux Sync File or
    ///     Android Fence. It can be used with any native API accepting a valid sync file or fence as input. It owns a
    ///     reference to the underlying synchronization primitive associated with the file descriptor. Implementations which
    ///     support importing this handle type must accept any type of sync or fence FD supported by the native system they are
    ///     running on.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT = 1 << 3,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_4_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceHandleTypeFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceHandleTypeFlagBits
    ///     </a>
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_4_BIT_NV = 1 << 4,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_5_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceHandleTypeFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalFenceHandleTypeFlagBits
    ///     </a>
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_RESERVED_5_BIT_NV = 1 << 5,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX file descriptor handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It must be compatible with the POSIX system calls dup,
    ///     dup2, close, and the non-standard system call dup3. Additionally, it must be transportable over a socket using an
    ///     SCM_RIGHTS control message. It owns a reference to the underlying synchronization primitive represented by its
    ///     Vulkan fence object.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT handle that has only limited valid usage
    ///     outside of Vulkan and other compatible APIs. It must be compatible with the functions DuplicateHandle, CloseHandle,
    ///     CompareObjectHandles, GetHandleInformation, and SetHandleInformation. It owns a reference to the underlying
    ///     synchronization primitive represented by its Vulkan fence object.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a global share handle that has only limited valid
    ///     usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own a
    ///     reference to the underlying synchronization primitive represented by its Vulkan fence object, and will therefore
    ///     become invalid when all Vulkan fence objects associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,

    /// <summary>
    ///     VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT specifies a POSIX file descriptor handle to a Linux Sync File or
    ///     Android Fence. It can be used with any native API accepting a valid sync file or fence as input. It owns a
    ///     reference to the underlying synchronization primitive associated with the file descriptor. Implementations which
    ///     support importing this handle type must accept any type of sync or fence FD supported by the native system they are
    ///     running on.
    /// </summary>
    VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT_KHR = VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT
}