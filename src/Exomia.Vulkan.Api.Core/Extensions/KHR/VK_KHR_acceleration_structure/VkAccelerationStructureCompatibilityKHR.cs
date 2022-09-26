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
///     VkAccelerationStructureCompatibilityKHR - Acceleration structure compatibility -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCompatibilityKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAccelerationStructureCompatibilityKHR.html
///     </a>
/// </summary>
public enum VkAccelerationStructureCompatibilityKHR
{
    /// <summary> VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR if the pVersionData version acceleration structure is compatible with device. </summary>
    VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR = 0,

    /// <summary> VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR if the pVersionData version acceleration structure is not compatible with device. </summary>
    VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR = 1
}