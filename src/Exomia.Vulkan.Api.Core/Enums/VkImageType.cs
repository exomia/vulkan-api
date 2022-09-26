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
///     VkImageType - Specifies the type of an image object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageType.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImageType.html </a>
/// </summary>
public enum VkImageType
{
    /// <summary> VK_IMAGE_TYPE_1D specifies a one-dimensional image. </summary>
    VK_IMAGE_TYPE_1D = 0,

    /// <summary> VK_IMAGE_TYPE_2D specifies a two-dimensional image. </summary>
    VK_IMAGE_TYPE_2D = 1,

    /// <summary> VK_IMAGE_TYPE_3D specifies a three-dimensional image. </summary>
    VK_IMAGE_TYPE_3D = 2
}