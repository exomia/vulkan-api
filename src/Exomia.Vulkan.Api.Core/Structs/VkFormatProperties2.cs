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
///     VkFormatProperties2 - Structure specifying image format properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties2.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkFormatProperties2.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties2
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>formatProperties is a VkFormatProperties structure describing features supported by the requested format.</summary>
    public VkFormatProperties formatProperties;
}