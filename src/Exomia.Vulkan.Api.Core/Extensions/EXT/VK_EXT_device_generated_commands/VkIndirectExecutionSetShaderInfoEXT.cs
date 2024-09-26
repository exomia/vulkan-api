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
///     VkIndirectExecutionSetShaderInfoEXT - Struct specifying parameters of a newly created indirect execution set
///     containing only shader objects -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectExecutionSetShaderInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shaderCount is the number of members in the pInitialShadersand pSetLayoutInfos arrays.</summary>
    public uint shaderCount;

    /// <summary>
    ///     pInitialShaders is a pointer to an array containing a VkShaderEXT object for each shader stage that will be
    ///     used in the set. These shaders will be automatically added to the set beginning at index 0.
    /// </summary>
    public VkShaderEXT* pInitialShaders;

    /// <summary>
    ///     pSetLayoutInfos is a pointer to an array containing a VkIndirectExecutionSetShaderLayoutInfoEXT used by each
    ///     corresponding pInitialShaders shader stage in the set.
    /// </summary>
    public VkIndirectExecutionSetShaderLayoutInfoEXT* pSetLayoutInfos;

    /// <summary>maxShaderCount is the maximum number of shader objects stored in the set.</summary>
    public uint maxShaderCount;

    /// <summary>pushConstantRangeCount is the number of members in the pPushConstantRanges array.</summary>
    public uint pushConstantRangeCount;

    /// <summary>pPushConstantRanges is a pointer to the array of VkPushConstantRange ranges used by all shaders in the set.</summary>
    public VkPushConstantRange* pPushConstantRanges;
}