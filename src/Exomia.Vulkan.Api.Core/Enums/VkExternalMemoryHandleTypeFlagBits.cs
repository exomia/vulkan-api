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
///     VkExternalMemoryHandleTypeFlagBits - Bit specifying external memory handle types -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBits.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalMemoryHandleTypeFlagBits.html
///     </a>
/// </summary>
[Flags]
public enum VkExternalMemoryHandleTypeFlagBits
{
    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX file descriptor handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It must be compatible with the POSIX system calls dup,
    ///     dup2, close, and the non-standard system call dup3. Additionally, it must be transportable over a socket using an
    ///     SCM_RIGHTS control message. It owns a reference to the underlying memory resource represented by its Vulkan memory
    ///     object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT = 0x1,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT handle that has only limited valid usage
    ///     outside of Vulkan and other compatible APIs. It must be compatible with the functions DuplicateHandle, CloseHandle,
    ///     CompareObjectHandles, GetHandleInformation, and SetHandleInformation. It owns a reference to the underlying memory
    ///     resource represented by its Vulkan memory object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT = 0x2,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a global share handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own
    ///     a reference to the underlying memory resource represented by its Vulkan memory object, and will therefore become
    ///     invalid when all Vulkan memory objects associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = 0x4,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT specifies an NT handle returned by
    ///     IDXGIResource1::CreateSharedHandlereferring to a Direct3D 10 or 11 texture resource. It owns a reference to the
    ///     memory used by the Direct3D resource.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT = 0x8,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT specifies a global share handle returned by
    ///     IDXGIResource::GetSharedHandlereferring to a Direct3D 10 or 11 texture resource. It does not own a reference to the
    ///     underlying Direct3D resource, and will therefore become invalid when all Vulkan memory objects and Direct3D
    ///     resources associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT = 0x10,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT specifies an NT handle returned by
    ///     ID3D12Device::CreateSharedHandle referring to a Direct3D 12 heap resource. It owns a reference to the resources
    ///     used by the Direct3D heap.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT = 0x20,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT specifies an NT handle returned by
    ///     ID3D12Device::CreateSharedHandle referring to a Direct3D 12 committed resource. It owns a reference to the memory
    ///     used by the Direct3D resource.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT = 0x40,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT is a file descriptor for a Linux dma_buf. It owns a reference
    ///     to the underlying memory resource represented by its Vulkan memory object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT = 0x200,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROIDspecifies an
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/AHardwareBuffer.html">AHardwareBuffer</a>
    ///     object defined by the Android NDK. See
    ///     <a
    ///         href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#memory-external-android-hardware-buffer">
    ///         Android
    ///         Hardware Buffers
    ///     </a>
    ///     for more details of this handle type.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID = 0x400,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT specifies a host pointer returned by a host memory
    ///     allocation command. It does not own a reference to the underlying memory resource, and will therefore become
    ///     invalid if the host memory is freed.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT = 0x80,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXTspecifies a host pointer to host mapped
    ///     foreign memory. It does not own a reference to the underlying memory resource, and will therefore become invalid if
    ///     the foreign memory is unmapped or otherwise becomes no longer available.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT = 0x100,

    /// <summary>VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA is a Zircon handle to a virtual memory object.</summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA = 0x800,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV is a handle to an allocation accessible by remote devices.
    ///     It owns a reference to the underlying memory resource represented by its Vulkan memory object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV = 0x1000,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_RESERVED_13_BIT_NV<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalMemoryHandleTypeFlagBits">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkExternalMemoryHandleTypeFlagBits
    ///     </a>
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_RESERVED_13_BIT_NV = 0x2000,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT specifies a POSIX file descriptor handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It must be compatible with the POSIX system calls dup,
    ///     dup2, close, and the non-standard system call dup3. Additionally, it must be transportable over a socket using an
    ///     SCM_RIGHTS control message. It owns a reference to the underlying memory resource represented by its Vulkan memory
    ///     object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT specifies an NT handle that has only limited valid usage
    ///     outside of Vulkan and other compatible APIs. It must be compatible with the functions DuplicateHandle, CloseHandle,
    ///     CompareObjectHandles, GetHandleInformation, and SetHandleInformation. It owns a reference to the underlying memory
    ///     resource represented by its Vulkan memory object.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT specifies a global share handle that has only limited
    ///     valid usage outside of Vulkan and other compatible APIs. It is not compatible with any native APIs. It does not own
    ///     a reference to the underlying memory resource represented by its Vulkan memory object, and will therefore become
    ///     invalid when all Vulkan memory objects associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT specifies an NT handle returned by
    ///     IDXGIResource1::CreateSharedHandlereferring to a Direct3D 10 or 11 texture resource. It owns a reference to the
    ///     memory used by the Direct3D resource.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT specifies a global share handle returned by
    ///     IDXGIResource::GetSharedHandlereferring to a Direct3D 10 or 11 texture resource. It does not own a reference to the
    ///     underlying Direct3D resource, and will therefore become invalid when all Vulkan memory objects and Direct3D
    ///     resources associated with it are destroyed.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT specifies an NT handle returned by
    ///     ID3D12Device::CreateSharedHandle referring to a Direct3D 12 heap resource. It owns a reference to the resources
    ///     used by the Direct3D heap.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT,

    /// <summary>
    ///     VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT specifies an NT handle returned by
    ///     ID3D12Device::CreateSharedHandle referring to a Direct3D 12 committed resource. It owns a reference to the memory
    ///     used by the Direct3D resource.
    /// </summary>
    VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT_KHR = VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT
}