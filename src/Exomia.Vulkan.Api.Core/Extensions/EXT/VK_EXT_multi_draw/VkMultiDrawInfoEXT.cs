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
///     VkMultiDrawInfoEXT - Structure specifying a multi-draw command -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiDrawInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiDrawInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkMultiDrawInfoEXT
{
    /// <summary>firstVertex is the first vertex to draw.</summary>
    public uint firstVertex;

    /// <summary>vertexCount is the number of vertices to draw.</summary>
    public uint vertexCount;
}