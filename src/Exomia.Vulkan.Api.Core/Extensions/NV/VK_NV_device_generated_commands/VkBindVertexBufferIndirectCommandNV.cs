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
///     VkBindVertexBufferIndirectCommandNV - Structure specifying input data for a single vertex buffer command token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindVertexBufferIndirectCommandNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindVertexBufferIndirectCommandNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkBindVertexBufferIndirectCommandNV
{
    /// <summary>bufferAddress specifies a physical address of the VkBufferused as vertex input binding.</summary>
    public VkDeviceAddress bufferAddress;

    /// <summary>size is the byte size range which is available for this operation from the provided address.</summary>
    public uint size;

    /// <summary>
    ///     stride is the byte size stride for this vertex input binding as in VkVertexInputBindingDescription::stride. It
    ///     is only used if VkIndirectCommandsLayoutTokenNV::vertexDynamicStride was set, otherwise the stride is inherited
    ///     from the current bound graphics pipeline.
    /// </summary>
    public uint stride;
}