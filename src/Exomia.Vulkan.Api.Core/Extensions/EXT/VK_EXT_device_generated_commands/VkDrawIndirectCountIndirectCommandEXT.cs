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
///     VkDrawIndirectCountIndirectCommandEXT - Structure specifying input data for a single draw-type command token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCountIndirectCommandEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDrawIndirectCountIndirectCommandEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDrawIndirectCountIndirectCommandEXT
{
    /// <summary>bufferAddress specifies a physical address of the VkBufferused for draw commands.</summary>
    public VkDeviceAddress bufferAddress;

    /// <summary>stride is the byte size stride for the command arguments</summary>
    public uint stride;

    /// <summary>commandCount is the number of commands to execute</summary>
    public uint commandCount;
}