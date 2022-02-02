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
///     VkAccelerationStructureMotionInstanceDataNV - Union specifying a acceleration structure motion instance data for
///     building into an acceleration structure geometry -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceDataNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceDataNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct VkAccelerationStructureMotionInstanceDataNV
{
    /// <summary>staticInstance is a VkAccelerationStructureInstanceKHRstructure containing data for a static instance.</summary>
    [FieldOffset(0)]
    public VkAccelerationStructureInstanceKHR staticInstance;

    /// <summary>
    ///     matrixMotionInstance is a VkAccelerationStructureMatrixMotionInstanceNV structure containing data for a matrix
    ///     motion instance.
    /// </summary>
    [FieldOffset(0)]
    public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;

    /// <summary>
    ///     srtMotionInstance is a VkAccelerationStructureSRTMotionInstanceNV structure containing data for an SRT motion
    ///     instance.
    /// </summary>
    [FieldOffset(0)]
    public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
}