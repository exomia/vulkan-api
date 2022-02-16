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
///     VkStencilFaceFlagBits - Bitmask specifying sets of stencil state for which to update the compare mask -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilFaceFlagBits.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStencilFaceFlagBits.html</a>
/// </summary>
[Flags]
public enum VkStencilFaceFlagBits
{
    /// <summary>VK_STENCIL_FACE_FRONT_BIT specifies that only the front set of stencil state is updated.</summary>
    VK_STENCIL_FACE_FRONT_BIT = 0x1,

    /// <summary>VK_STENCIL_FACE_BACK_BIT specifies that only the back set of stencil state is updated.</summary>
    VK_STENCIL_FACE_BACK_BIT = 0x2,

    /// <summary>
    ///     VK_STENCIL_FACE_FRONT_AND_BACK is the combination of VK_STENCIL_FACE_FRONT_BIT and VK_STENCIL_FACE_BACK_BIT,
    ///     and specifies that both sets of stencil state are updated.
    /// </summary>
    VK_STENCIL_FACE_FRONT_AND_BACK = 0x00000003,

    /// <summary>
    ///     VK_STENCIL_FACE_FRONT_AND_BACK is the combination of VK_STENCIL_FACE_FRONT_BIT and VK_STENCIL_FACE_BACK_BIT,
    ///     and specifies that both sets of stencil state are updated.
    /// </summary>
    VK_STENCIL_FRONT_AND_BACK = VK_STENCIL_FACE_FRONT_AND_BACK
}