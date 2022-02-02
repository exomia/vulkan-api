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
///     VkConditionalRenderingBeginInfoEXT - Structure specifying conditional rendering begin information -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingBeginInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkConditionalRenderingBeginInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>buffer is a buffer containing the predicate for conditional rendering.</summary>
    public VkBuffer buffer;

    /// <summary>offset is the byte offset into buffer where the predicate is located.</summary>
    public VkDeviceSize offset;

    /// <summary>flags is a bitmask of VkConditionalRenderingFlagsEXTspecifying the behavior of conditional rendering.</summary>
    public VkConditionalRenderingFlagsEXT flags;
}