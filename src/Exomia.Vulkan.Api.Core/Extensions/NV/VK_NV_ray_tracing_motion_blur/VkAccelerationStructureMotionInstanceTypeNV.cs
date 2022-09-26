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
///     VkAccelerationStructureMotionInstanceTypeNV - Enum specifying a type of acceleration structure motion instance data for building into an acceleration structure geometry -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceTypeNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureMotionInstanceTypeNV.html
///     </a>
/// </summary>
public enum VkAccelerationStructureMotionInstanceTypeNV
{
    /// <summary> VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV specifies that the instance is a static instance with no instance motion. </summary>
    VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV = 0,

    /// <summary> VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NVspecifies that the instance is a motion instance with motion specified by interpolation between two matrices. </summary>
    VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV = 1,

    /// <summary> VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NVspecifies that the instance is a motion instance with motion specified by interpolation in the SRT decomposition. </summary>
    VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV = 2
}