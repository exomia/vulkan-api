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
///     VkSparseMemoryBind - Structure specifying a sparse memory bind operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBind.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseMemoryBind.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSparseMemoryBind
{
    /// <summary> resourceOffset is the offset into the resource. </summary>
    public VkDeviceSize resourceOffset;

    /// <summary> size is the size of the memory region to be bound. </summary>
    public VkDeviceSize size;

    /// <summary> memory is the VkDeviceMemory object that the range of the resource is bound to. If memory is VK_NULL_HANDLE, the range is unbound. </summary>
    public VkDeviceMemory memory;

    /// <summary> memoryOffset is the offset into the VkDeviceMemory object to bind the resource range to. If memory is VK_NULL_HANDLE, this value is ignored. </summary>
    public VkDeviceSize memoryOffset;

    /// <summary> flags is a bitmask of VkSparseMemoryBindFlagBits specifying usage of the binding operation. </summary>
    public VkSparseMemoryBindFlags flags;
}