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
///     VkRenderPassCreateFlagBits - Bitmask specifying additional properties of a render pass -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkRenderPassCreateFlagBits.html</a>
/// </summary>
[Flags]
public enum VkRenderPassCreateFlagBits
{
    /// <summary>
    ///     VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR<br />
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkRenderPassCreateFlagBits">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkRenderPassCreateFlagBits</a>
    /// </summary>
    VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR = 0x1,

    /// <summary>
    ///     VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM specifies that the created render pass is compatible with
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#vertexpostproc-renderpass-transform">
    ///         render
    ///         pass transform
    ///     </a>
    ///     .
    /// </summary>
    VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = 0x2
}