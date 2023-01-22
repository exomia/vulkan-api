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
namespace Exomia.Vulkan.Api.Fuchsia;

/// <summary>
///     VkBufferCollectionConstraintsInfoFUCHSIA - Structure of general buffer collection constraints -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionConstraintsInfoFUCHSIA.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBufferCollectionConstraintsInfoFUCHSIA.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCollectionConstraintsInfoFUCHSIA
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA;

    /// <summary>sType is the type of this structure</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure</summary>
    public void* pNext;

    /// <summary>minBufferCount is the minimum number of buffers available in the collection</summary>
    public uint minBufferCount;

    /// <summary>maxBufferCount is the maximum number of buffers allowed in the collection</summary>
    public uint maxBufferCount;

    /// <summary>minBufferCountForCamping is the per-participant minimum buffers for camping</summary>
    public uint minBufferCountForCamping;

    /// <summary>minBufferCountForDedicatedSlack is the per-participant minimum buffers for dedicated slack</summary>
    public uint minBufferCountForDedicatedSlack;

    /// <summary>minBufferCountForSharedSlack is the per-participant minimum buffers for shared slack</summary>
    public uint minBufferCountForSharedSlack;
}