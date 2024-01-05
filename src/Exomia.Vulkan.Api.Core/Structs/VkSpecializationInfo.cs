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
///     VkSpecializationInfo - Structure specifying specialization information -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSpecializationInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSpecializationInfo.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSpecializationInfo
{
    /// <summary>mapEntryCount is the number of entries in the pMapEntriesarray.</summary>
    public uint mapEntryCount;

    /// <summary>
    ///     pMapEntries is a pointer to an array of VkSpecializationMapEntry structures, which map constant IDs to offsets
    ///     in pData.
    /// </summary>
    public VkSpecializationMapEntry* pMapEntries;

    /// <summary>dataSize is the byte size of the pData buffer.</summary>
    public nuint dataSize;

    /// <summary>pData contains the actual constant values to specialize with.</summary>
    public void* pData;
}