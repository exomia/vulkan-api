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
///     VkVertexInputRate - Specify rate at which vertex attributes are pulled from buffers -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputRate.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputRate.html</a>
/// </summary>
public enum VkVertexInputRate
{
    /// <summary>VK_VERTEX_INPUT_RATE_VERTEX specifies that vertex attribute addressing is a function of the vertex index.</summary>
    VK_VERTEX_INPUT_RATE_VERTEX = 0,

    /// <summary>VK_VERTEX_INPUT_RATE_INSTANCE specifies that vertex attribute addressing is a function of the instance index.</summary>
    VK_VERTEX_INPUT_RATE_INSTANCE = 1
}