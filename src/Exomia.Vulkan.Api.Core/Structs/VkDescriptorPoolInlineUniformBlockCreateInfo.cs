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
///     VkDescriptorPoolInlineUniformBlockCreateInfo - Structure specifying the maximum number of inline uniform block
///     bindings of a newly created descriptor pool -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolInlineUniformBlockCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDescriptorPoolInlineUniformBlockCreateInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkDescriptorPoolCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkDescriptorPoolCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorPoolInlineUniformBlockCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>maxInlineUniformBlockBindings is the number of inline uniform block bindings to allocate.</summary>
    public uint maxInlineUniformBlockBindings;
}