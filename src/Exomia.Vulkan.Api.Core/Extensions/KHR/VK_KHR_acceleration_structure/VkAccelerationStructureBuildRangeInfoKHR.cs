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
///     VkAccelerationStructureBuildRangeInfoKHR - Structure specifying build offsets and counts for acceleration structure
///     builds -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildRangeInfoKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureBuildRangeInfoKHR.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAccelerationStructureBuildRangeInfoKHR
{
    /// <summary>primitiveCount defines the number of primitives for a corresponding acceleration structure geometry.</summary>
    public uint primitiveCount;

    /// <summary>primitiveOffset defines an offset in bytes into the memory where primitive data is defined.</summary>
    public uint primitiveOffset;

    /// <summary>firstVertex is the index of the first vertex to build from for triangle geometry.</summary>
    public uint firstVertex;

    /// <summary>transformOffset defines an offset in bytes into the memory where a transform matrix is defined.</summary>
    public uint transformOffset;
}