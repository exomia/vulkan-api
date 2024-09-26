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
///     VkIndirectCommandsLayoutCreateInfoEXT - Structure specifying the parameters of a newly created indirect commands
///     layout object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkIndirectCommandsLayoutUsageFlagBitsEXT specifying usage rules for this layout.</summary>
    public VkIndirectCommandsLayoutUsageFlagsEXT flags;

    /// <summary>shaderStages is the VkShaderStageFlags that this layout supports.</summary>
    public VkShaderStageFlags shaderStages;

    /// <summary>indirectStride is the distance in bytes between sequences in the indirect buffer</summary>
    public uint indirectStride;

    /// <summary>
    ///     pipelineLayout is the optional VkPipelineLayout that tokens in this layout use. If the
    ///     dynamicGeneratedPipelineLayout feature is enabled, pipelineLayout can be VK_NULL_HANDLE and the layout mustbe
    ///     specified by chaining the VkPipelineLayoutCreateInfo structure off the pNext
    /// </summary>
    public VkPipelineLayout pipelineLayout;

    /// <summary>tokenCount is the length of the individual command sequence.</summary>
    public uint tokenCount;

    /// <summary>pTokens is a pointer to an array of VkIndirectCommandsLayoutTokenEXT describing each command token in detail.</summary>
    public VkIndirectCommandsLayoutTokenEXT* pTokens;
}