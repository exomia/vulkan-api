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
///     VkComponentSwizzle - Specify how a component is swizzled -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentSwizzle.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkComponentSwizzle.html </a>
/// </summary>
public enum VkComponentSwizzle
{
    /// <summary> VK_COMPONENT_SWIZZLE_IDENTITY specifies that the component is set to the identity swizzle. </summary>
    VK_COMPONENT_SWIZZLE_IDENTITY = 0,

    /// <summary> VK_COMPONENT_SWIZZLE_ZERO specifies that the component is set to zero. </summary>
    VK_COMPONENT_SWIZZLE_ZERO = 1,

    /// <summary>
    ///     VK_COMPONENT_SWIZZLE_ONE specifies that the component is set to either 1 or 1.0, depending on whether the type of the image view format is integer or floating-point respectively, as determined by the
    ///     <a href="https://registry.khronos.org/vulkan/specs/1.3-extensions/html/vkspec.html#formats-definition"> Format Definition </a>
    ///     section for each
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormat.html"> VkFormat </a>.
    /// </summary>
    VK_COMPONENT_SWIZZLE_ONE = 2,

    /// <summary> VK_COMPONENT_SWIZZLE_R specifies that the component is set to the value of the R component of the image. </summary>
    VK_COMPONENT_SWIZZLE_R = 3,

    /// <summary> VK_COMPONENT_SWIZZLE_G specifies that the component is set to the value of the G component of the image. </summary>
    VK_COMPONENT_SWIZZLE_G = 4,

    /// <summary> VK_COMPONENT_SWIZZLE_B specifies that the component is set to the value of the B component of the image. </summary>
    VK_COMPONENT_SWIZZLE_B = 5,

    /// <summary> VK_COMPONENT_SWIZZLE_A specifies that the component is set to the value of the A component of the image. </summary>
    VK_COMPONENT_SWIZZLE_A = 6
}