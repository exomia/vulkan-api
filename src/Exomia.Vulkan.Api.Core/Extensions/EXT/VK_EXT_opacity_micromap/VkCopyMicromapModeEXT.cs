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
///     VkCopyMicromapModeEXT - Micromap copy mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMicromapModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCopyMicromapModeEXT.html</a>
/// </summary>
public enum VkCopyMicromapModeEXT
{
    /// <summary>
    ///     VK_COPY_MICROMAP_MODE_CLONE_EXT creates a direct copy of the micromap specified in src into the one specified
    ///     by dst. The dst micromap must have been created with the same parameters as src.
    /// </summary>
    VK_COPY_MICROMAP_MODE_CLONE_EXT = 0,

    /// <summary>
    ///     VK_COPY_MICROMAP_MODE_SERIALIZE_EXT serializes the micromap to a semi-opaque format which can be reloaded on a
    ///     compatible implementation.
    /// </summary>
    VK_COPY_MICROMAP_MODE_SERIALIZE_EXT = 1,

    /// <summary>
    ///     VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT deserializes the semi-opaque serialization format in the buffer to the
    ///     micromap.
    /// </summary>
    VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT = 2,

    /// <summary>
    ///     VK_COPY_MICROMAP_MODE_COMPACT_EXT creates a more compact version of a micromap src into dst. The micromap dst
    ///     must have been created with a size at least as large as that returned by
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/vkCmdWriteMicromapsPropertiesEXT.html">
    ///         vkCmdWriteMicromapsPropertiesEXT
    ///     </a>
    ///     after the build of the micromap specified by src.
    /// </summary>
    VK_COPY_MICROMAP_MODE_COMPACT_EXT = 3
}