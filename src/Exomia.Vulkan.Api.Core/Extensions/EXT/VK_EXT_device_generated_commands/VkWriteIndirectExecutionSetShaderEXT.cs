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
///     VkWriteIndirectExecutionSetShaderEXT - Struct specifying shader object update information for an indirect execution
///     set -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteIndirectExecutionSetShaderEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkWriteIndirectExecutionSetShaderEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkWriteIndirectExecutionSetShaderEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_WRITE_INDIRECT_EXECUTION_SET_SHADER_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>index is the element of the set to update</summary>
    public uint index;

    /// <summary>shader is the shader to store in the indirect execution set</summary>
    public VkShaderEXT shader;
}