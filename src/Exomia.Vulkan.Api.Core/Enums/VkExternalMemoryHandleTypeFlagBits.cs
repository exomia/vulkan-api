#region License

// Copyright (c) 2018-2021, exomia
// All rights reserved.
// 
// This source code is licensed under the BSD-style license found in the
// LICENSE file in the root directory of this source tree.

#endregion

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using System;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace
namespace Exomia.Vulkan.Api.Core
{
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits
    {
        OPAQUE_FD_BIT                       = 0x00000001,
        OPAQUE_WIN32_BIT                    = 0x00000002,
        OPAQUE_WIN32_KMT_BIT                = 0x00000004,
        D3D11_TEXTURE_BIT                   = 0x00000008,
        D3D11_TEXTURE_KMT_BIT               = 0x00000010,
        D3D12_HEAP_BIT                      = 0x00000020,
        D3D12_RESOURCE_BIT                  = 0x00000040,
        DMA_BUF_BIT_EXT                     = 0x00000200,
        ANDROID_HARDWARE_BUFFER_BIT_ANDROID = 0x00000400,
        HOST_ALLOCATION_BIT_EXT             = 0x00000080,
        HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT  = 0x00000100,
        ZIRCON_VMO_BIT_FUCHSIA              = 0x00000800,
        RDMA_ADDRESS_BIT_NV                 = 0x00001000,
        OPAQUE_FD_BIT_KHR                   = OPAQUE_FD_BIT,
        OPAQUE_WIN32_BIT_KHR                = OPAQUE_WIN32_BIT,
        OPAQUE_WIN32_KMT_BIT_KHR            = OPAQUE_WIN32_KMT_BIT,
        D3D11_TEXTURE_BIT_KHR               = D3D11_TEXTURE_BIT,
        D3D11_TEXTURE_KMT_BIT_KHR           = D3D11_TEXTURE_KMT_BIT,
        D3D12_HEAP_BIT_KHR                  = D3D12_HEAP_BIT,
        D3D12_RESOURCE_BIT_KHR              = D3D12_RESOURCE_BIT,
        FLAG_BITS_MAX_ENUM                  = 0x7FFFFFFF
    }
}