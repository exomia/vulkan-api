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
///     VkCopyMemoryIndirectCommandNV - Structure specifying indirect memory region copy operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryIndirectCommandNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMemoryIndirectCommandNV.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkCopyMemoryIndirectCommandNV
{
    /// <summary>srcAddress is the starting address of the source device memory to copy from.</summary>
    public VkDeviceAddress srcAddress;

    /// <summary>dstAddress is the starting address of the destination device memory to copy to.</summary>
    public VkDeviceAddress dstAddress;

    /// <summary>size is the size of the copy in bytes.</summary>
    public VkDeviceSize size;
}