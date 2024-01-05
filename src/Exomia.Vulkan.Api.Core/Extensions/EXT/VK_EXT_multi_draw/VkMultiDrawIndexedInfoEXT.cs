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
///     VkMultiDrawIndexedInfoEXT - Structure specifying a multi-draw command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiDrawIndexedInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiDrawIndexedInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkMultiDrawIndexedInfoEXT
{
    /// <summary>firstIndex is the first index to draw.</summary>
    public uint firstIndex;

    /// <summary>indexCount is the number of vertices to draw.</summary>
    public uint indexCount;

    /// <summary>
    ///     vertexOffset is the value added to the vertex index before indexing into the vertex buffer for indexed
    ///     multidraws.
    /// </summary>
    public int vertexOffset;
}