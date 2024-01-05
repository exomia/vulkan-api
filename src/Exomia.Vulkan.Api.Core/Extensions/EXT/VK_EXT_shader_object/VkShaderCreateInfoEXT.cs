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
///     VkShaderCreateInfoEXT - Structure specifying parameters of a newly created shader -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCreateInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderCreateInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkShaderCreateFlagBitsEXT describing additional parameters of the shader.</summary>
    public VkShaderCreateFlagsEXT flags;

    /// <summary>stage is a VkShaderStageFlagBits value specifying a single shader stage.</summary>
    public VkShaderStageFlagBits stage;

    /// <summary>
    ///     nextStage is a bitmask of VkShaderStageFlagBits specifying zero or stages which may be used as a logically
    ///     next bound stage when drawing with the shader bound.
    /// </summary>
    public VkShaderStageFlags nextStage;

    /// <summary>codeType is a VkShaderCodeTypeEXT value specifying the type of the shader code pointed to be pCode.</summary>
    public VkShaderCodeTypeEXT codeType;

    /// <summary>codeSize is the size in bytes of the shader code pointed to be pCode.</summary>
    public nuint codeSize;

    /// <summary>pCode is a pointer to the shader code to use to create the shader.</summary>
    public void* pCode;

    /// <summary>
    ///     pName is a pointer to a null-terminated UTF-8 string specifying the entry point name of the shader for this
    ///     stage.
    /// </summary>
    public byte* pName;

    /// <summary>setLayoutCount is the number of descriptor set layouts pointed to by pSetLayouts.</summary>
    public uint setLayoutCount;

    /// <summary>pSetLayouts is a pointer to an array of VkDescriptorSetLayout objects used by the shader stage.</summary>
    public VkDescriptorSetLayout* pSetLayouts;

    /// <summary>pushConstantRangeCount is the number of push constant ranges pointed to by pPushConstantRanges.</summary>
    public uint pushConstantRangeCount;

    /// <summary>pPushConstantRanges is a pointer to an array of VkPushConstantRange structures used by the shader stage.</summary>
    public VkPushConstantRange* pPushConstantRanges;

    /// <summary>
    ///     pSpecializationInfo is a pointer to a VkSpecializationInfostructure, as described in Specialization Constants,
    ///     or NULL.
    /// </summary>
    public VkSpecializationInfo* pSpecializationInfo;
}