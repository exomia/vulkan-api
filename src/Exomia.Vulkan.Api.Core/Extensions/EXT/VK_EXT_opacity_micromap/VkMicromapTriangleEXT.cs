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
///     VkMicromapTriangleEXT - Structure specifying the micromap format and data for a triangle -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapTriangleEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMicromapTriangleEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkMicromapTriangleEXT
{
    /// <summary>dataOffset is the offset in bytes of the start of the data for this triangle. This is a byte aligned value.</summary>
    public uint dataOffset;

    /// <summary>subdivisionLevel is the subdivision level of this triangle</summary>
    public ushort subdivisionLevel;

    /// <summary>format is the format of this triangle</summary>
    public ushort format;
}