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
///     VkBindIndexBufferIndirectCommandEXT - Structure specifying input data for a single index buffer command token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindIndexBufferIndirectCommandEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindIndexBufferIndirectCommandEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkBindIndexBufferIndirectCommandEXT
{
    /// <summary>bufferAddress specifies a physical address of the VkBufferused as index buffer.</summary>
    public VkDeviceAddress bufferAddress;

    /// <summary>size is the byte size range which is available for this operation from the provided address.</summary>
    public uint size;

    /// <summary>indexType is a VkIndexType value specifying how indices are treated.</summary>
    public VkIndexType indexType;
}