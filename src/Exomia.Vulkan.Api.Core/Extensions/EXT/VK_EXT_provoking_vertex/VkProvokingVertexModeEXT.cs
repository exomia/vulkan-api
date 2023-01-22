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
///     VkProvokingVertexModeEXT - Specify which vertex in a primitive is the provoking vertex -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkProvokingVertexModeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkProvokingVertexModeEXT.html</a>
/// </summary>
public enum VkProvokingVertexModeEXT
{
    /// <summary>
    ///     VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT specifies that the provoking vertex is the first non-adjacency
    ///     vertex in the list of vertices used by a primitive.
    /// </summary>
    VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT = 0,

    /// <summary>
    ///     VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT specifies that the provoking vertex is the last non-adjacency vertex
    ///     in the list of vertices used by a primitive.
    /// </summary>
    VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT = 1
}