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
///     VkIndirectStateFlagBitsNV - Bitmask specifying state that can be altered on the device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectStateFlagBitsNV.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectStateFlagBitsNV.html</a>
/// </summary>
[Flags]
public enum VkIndirectStateFlagBitsNV
{
    /// <summary>
    ///     VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV allows to toggle the
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrontFace.html">VkFrontFace</a>
    ///     rasterization state for subsequent drawing commands.
    /// </summary>
    VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = 0x1
}