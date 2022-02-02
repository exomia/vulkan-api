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
///     VkSpecializationMapEntry - Structure specifying a specialization map entry -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSpecializationMapEntry.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSpecializationMapEntry.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkSpecializationMapEntry
{
    /// <summary>constantID is the ID of the specialization constant in SPIR-V.</summary>
    public uint constantID;

    /// <summary>offset is the byte offset of the specialization constant value within the supplied data buffer.</summary>
    public uint offset;

    /// <summary>size is the byte size of the specialization constant value within the supplied data buffer.</summary>
    public nuint size;
}