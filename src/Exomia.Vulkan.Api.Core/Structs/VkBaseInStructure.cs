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
///     VkBaseInStructure - Base structure for a read-only pointer chain -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBaseInStructure.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBaseInStructure.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBaseInStructure
{
    /// <summary>sType is the structure type of the structure being iterated through.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to the next structure in a structure chain.</summary>
    public VkBaseInStructure* pNext;
}