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
///     VkGeneratedCommandsShaderInfoEXT - Structure specifying shader objects for use with indirect command
///     preprocessing -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsShaderInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsShaderInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term>
///             <description>VkGeneratedCommandsInfoEXT,VkGeneratedCommandsMemoryRequirementsInfoEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkGeneratedCommandsInfoEXT,VkGeneratedCommandsMemoryRequirementsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsShaderInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_SHADER_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shaderCount is the size of the pShaders array.</summary>
    public uint shaderCount;

    /// <summary>pShaders is a pointer to an array of shader objects.</summary>
    public VkShaderEXT* pShaders;
}