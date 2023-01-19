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
///     VkVertexInputAttributeDescription - Structure specifying vertex input attribute description -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputAttributeDescription.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputAttributeDescription.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVertexInputAttributeDescription
{
    /// <summary>location is the shader input location number for this attribute.</summary>
    public uint location;

    /// <summary>binding is the binding number which this attribute takes its data from.</summary>
    public uint binding;

    /// <summary>format is the size and type of the vertex attribute data.</summary>
    public VkFormat format;

    /// <summary>offset is a byte offset of this attribute relative to the start of an element in the vertex input binding.</summary>
    public uint offset;
}