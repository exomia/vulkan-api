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
///     VkDrawIndirectCommand - Structure specifying a indirect drawing command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCommand.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCommand.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDrawIndirectCommand
{
    /// <summary>vertexCount is the number of vertices to draw.</summary>
    public uint vertexCount;

    /// <summary>instanceCount is the number of instances to draw.</summary>
    public uint instanceCount;

    /// <summary>firstVertex is the index of the first vertex to draw.</summary>
    public uint firstVertex;

    /// <summary>firstInstance is the instance ID of the first instance to draw.</summary>
    public uint firstInstance;
}