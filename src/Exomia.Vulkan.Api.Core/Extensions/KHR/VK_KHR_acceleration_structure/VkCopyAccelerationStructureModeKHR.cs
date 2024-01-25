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
///     VkCopyAccelerationStructureModeKHR - Acceleration structure copy mode -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyAccelerationStructureModeKHR.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyAccelerationStructureModeKHR.html
///     </a>
/// </summary>
public enum VkCopyAccelerationStructureModeKHR
{
    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR creates a direct copy of the acceleration structure specified in
    ///     src into the one specified by dst. The dst acceleration structure must have been created with the same parameters
    ///     as src. If src contains references to other acceleration structures, dst will reference the same acceleration
    ///     structures.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = 0,

    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR creates a more compact version of an acceleration structure src
    ///     into dst. The acceleration structure dst must have been created with a size at least as large as that returned by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     after the build of the acceleration structure specified by src. If src contains references to other acceleration
    ///     structures, dst will reference the same acceleration structures.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = 1,

    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR serializes the acceleration structure to a semi-opaque
    ///     format which can be reloaded on a compatible implementation.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = 2,

    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR deserializes the semi-opaque serialization format in the
    ///     buffer to the acceleration structure.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = 3,

    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR creates a direct copy of the acceleration structure specified in
    ///     src into the one specified by dst. The dst acceleration structure must have been created with the same parameters
    ///     as src. If src contains references to other acceleration structures, dst will reference the same acceleration
    ///     structures.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR,

    /// <summary>
    ///     VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR creates a more compact version of an acceleration structure src
    ///     into dst. The acceleration structure dst must have been created with a size at least as large as that returned by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkCmdWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     or
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkWriteAccelerationStructuresPropertiesKHR.html">
    ///         vkWriteAccelerationStructuresPropertiesKHR
    ///     </a>
    ///     after the build of the acceleration structure specified by src. If src contains references to other acceleration
    ///     structures, dst will reference the same acceleration structures.
    /// </summary>
    VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_NV = VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR
}