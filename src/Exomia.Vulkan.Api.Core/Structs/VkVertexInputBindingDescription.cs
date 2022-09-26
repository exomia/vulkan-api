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
///     VkVertexInputBindingDescription - Structure specifying vertex input binding description -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkVertexInputBindingDescription.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkVertexInputBindingDescription
{
    /// <summary> binding is the binding number that this structure describes. </summary>
    public uint binding;

    /// <summary> stride is the byte stride between consecutive elements within the buffer. </summary>
    public uint stride;

    /// <summary> inputRate is a VkVertexInputRate value specifying whether vertex attribute addressing is a function of the vertex index or of the instance index. </summary>
    public VkVertexInputRate inputRate;
}