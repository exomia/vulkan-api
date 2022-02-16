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
///     VkDrawIndexedIndirectCommand - Structure specifying a indexed indirect drawing command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndexedIndirectCommand.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndexedIndirectCommand.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDrawIndexedIndirectCommand
{
    /// <summary>indexCount is the number of vertices to draw.</summary>
    public uint indexCount;

    /// <summary>instanceCount is the number of instances to draw.</summary>
    public uint instanceCount;

    /// <summary>firstIndex is the base index within the index buffer.</summary>
    public uint firstIndex;

    /// <summary>vertexOffset is the value added to the vertex index before indexing into the vertex buffer.</summary>
    public int vertexOffset;

    /// <summary>firstInstance is the instance ID of the first instance to draw.</summary>
    public uint firstInstance;
}