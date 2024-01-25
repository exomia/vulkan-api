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
///     VkAccelerationStructureMotionInstanceNV - Structure specifying a single acceleration structure motion instance for
///     building into an acceleration structure geometry -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkAccelerationStructureMotionInstanceNV
{
    /// <summary>
    ///     type is a VkAccelerationStructureMotionInstanceTypeNVenumerant identifying which type of motion instance this
    ///     is and which type of the union is valid.
    /// </summary>
    public VkAccelerationStructureMotionInstanceTypeNV type;

    /// <summary>flags is currently unused, but is required to keep natural alignment of data.</summary>
    public VkAccelerationStructureMotionInstanceFlagsNV flags;

    /// <summary>data is a VkAccelerationStructureMotionInstanceDataNVcontaining motion instance data for this instance.</summary>
    public VkAccelerationStructureMotionInstanceDataNV data;
}