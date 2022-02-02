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
///     VkSparseBufferMemoryBindInfo - Structure specifying a sparse buffer memory bind operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseBufferMemoryBindInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSparseBufferMemoryBindInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseBufferMemoryBindInfo
{
    /// <summary>buffer is the VkBuffer object to be bound.</summary>
    public VkBuffer buffer;

    /// <summary>bindCount is the number of VkSparseMemoryBind structures in the pBinds array.</summary>
    public uint bindCount;

    /// <summary>pBinds is a pointer to an array of VkSparseMemoryBindstructures.</summary>
    public VkSparseMemoryBind* pBinds;
}