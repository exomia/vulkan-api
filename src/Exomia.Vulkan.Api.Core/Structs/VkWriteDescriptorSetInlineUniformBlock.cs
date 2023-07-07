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
///     VkWriteDescriptorSetInlineUniformBlock - Structure specifying inline uniform block data -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetInlineUniformBlock.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteDescriptorSetInlineUniformBlock.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkWriteDescriptorSet</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkWriteDescriptorSet")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteDescriptorSetInlineUniformBlock
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>dataSize is the number of bytes of inline uniform block data pointed to by pData.</summary>
    public uint dataSize;

    /// <summary>pData is a pointer to dataSize number of bytes of data to write to the inline uniform block.</summary>
    public void* pData;
}