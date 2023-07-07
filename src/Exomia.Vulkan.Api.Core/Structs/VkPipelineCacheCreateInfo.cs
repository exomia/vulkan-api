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
///     VkPipelineCacheCreateInfo - Structure specifying parameters of a newly created pipeline cache -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineCacheCreateInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCacheCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkPipelineCacheCreateFlagBitsspecifying the behavior of the pipeline cache.</summary>
    public VkPipelineCacheCreateFlags flags;

    /// <summary>
    ///     initialDataSize is the number of bytes in pInitialData. If initialDataSize is zero, the pipeline cache will
    ///     initially be empty.
    /// </summary>
    public nuint initialDataSize;

    /// <summary>
    ///     pInitialData is a pointer to previously retrieved pipeline cache data. If the pipeline cache data is
    ///     incompatible (as defined below) with the device, the pipeline cache will be initially empty. If initialDataSize is
    ///     zero, pInitialData is ignored.
    /// </summary>
    public void* pInitialData;
}