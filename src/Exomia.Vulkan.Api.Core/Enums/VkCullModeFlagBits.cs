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
///     VkCullModeFlagBits - Bitmask controlling triangle culling -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCullModeFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkCullModeFlagBits.html</a>
/// </summary>
[Flags]
public enum VkCullModeFlagBits
{
    /// <summary>VK_CULL_MODE_NONE specifies that no triangles are discarded</summary>
    VK_CULL_MODE_NONE = 0,

    /// <summary>VK_CULL_MODE_FRONT_BIT specifies that front-facing triangles are discarded</summary>
    VK_CULL_MODE_FRONT_BIT = 0x1,

    /// <summary>VK_CULL_MODE_BACK_BIT specifies that back-facing triangles are discarded</summary>
    VK_CULL_MODE_BACK_BIT = 0x2,

    /// <summary>VK_CULL_MODE_FRONT_AND_BACK specifies that all triangles are discarded.</summary>
    VK_CULL_MODE_FRONT_AND_BACK = 0x00000003
}