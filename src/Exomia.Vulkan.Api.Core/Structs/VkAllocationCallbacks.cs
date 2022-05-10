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
///     VkAllocationCallbacks - Structure containing callback function pointers for memory allocation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAllocationCallbacks.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAllocationCallbacks.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAllocationCallbacks
{
    /// <summary>
    ///     pUserData is a value to be interpreted by the implementation of the callbacks. When any of the callbacks in
    ///     VkAllocationCallbacks are called, the Vulkan implementation will pass this value as the first parameter to the
    ///     callback. This value can vary each time an allocator is passed into a command, even when the same object takes an
    ///     allocator in multiple commands.
    /// </summary>
    public void* pUserData;

    /// <summary>pfnAllocation is a PFN_vkAllocationFunction pointer to an application-defined memory allocation function.</summary>
    public delegate*<void* /*pUserData*/, nuint /*size*/, nuint /*alignment*/, VkSystemAllocationScope /*allocationScope*/, void*> pfnAllocation;

    /// <summary>
    ///     pfnReallocation is a PFN_vkReallocationFunction pointer to an application-defined memory reallocation
    ///     function.
    /// </summary>
    public delegate*<void* /*pUserData*/, void* /*pOriginal*/, nuint /*size*/, nuint /*alignment*/, VkSystemAllocationScope /*allocationScope*/, void*> pfnReallocation;

    /// <summary>pfnFree is a PFN_vkFreeFunction pointer to an application-defined memory free function.</summary>
    public delegate*<void* /*pUserData*/, void* /*pMemory*/, void> pfnFree;

    /// <summary>
    ///     pfnInternalAllocation is a PFN_vkInternalAllocationNotification pointer to an application-defined function
    ///     that is called by the implementation when the implementation makes internal allocations.
    /// </summary>
    public delegate*<void* /*pUserData*/, nuint /*size*/, VkInternalAllocationType /*allocationType*/, VkSystemAllocationScope /*allocationScope*/, void> pfnInternalAllocation;

    /// <summary>
    ///     pfnInternalFree is a PFN_vkInternalFreeNotification pointer to an application-defined function that is called
    ///     by the implementation when the implementation frees internal allocations.
    /// </summary>
    public delegate*<void* /*pUserData*/, nuint /*size*/, VkInternalAllocationType /*allocationType*/, VkSystemAllocationScope /*allocationScope*/, void> pfnInternalFree;
}