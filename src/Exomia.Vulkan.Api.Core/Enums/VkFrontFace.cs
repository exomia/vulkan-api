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
///     VkFrontFace - Interpret polygon front-facing orientation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrontFace.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFrontFace.html </a>
/// </summary>
public enum VkFrontFace
{
    /// <summary> VK_FRONT_FACE_COUNTER_CLOCKWISE specifies that a triangle with positive area is considered front-facing. </summary>
    VK_FRONT_FACE_COUNTER_CLOCKWISE = 0,

    /// <summary> VK_FRONT_FACE_CLOCKWISE specifies that a triangle with negative area is considered front-facing. </summary>
    VK_FRONT_FACE_CLOCKWISE = 1
}