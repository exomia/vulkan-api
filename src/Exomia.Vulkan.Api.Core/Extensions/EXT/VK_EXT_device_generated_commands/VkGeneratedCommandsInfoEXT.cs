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
///     VkGeneratedCommandsInfoEXT - Structure specifying parameters for the generation of commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>shaderStages is the mask of shader stages used by the commands.</summary>
    public VkShaderStageFlags shaderStages;

    /// <summary>indirectExecutionSet is the indirect execution set to be used for binding shaders.</summary>
    public VkIndirectExecutionSetEXT indirectExecutionSet;

    /// <summary>indirectCommandsLayout is the VkIndirectCommandsLayoutEXTthat specifies the command sequence data.</summary>
    public VkIndirectCommandsLayoutEXT indirectCommandsLayout;

    /// <summary>indirectAddress is an address that holds the indirect buffer data.</summary>
    public VkDeviceAddress indirectAddress;

    /// <summary>indirectAddressSize is the size in bytes of indirect buffer data starting at indirectAddress.</summary>
    public VkDeviceSize indirectAddressSize;

    /// <summary>
    ///     preprocessAddress specifies a physical address of the VkBuffer used for preprocessing the input data for
    ///     execution. If this structure is used with vkCmdExecuteGeneratedCommandsEXTwith its isPreprocessed set to VK_TRUE,
    ///     then the preprocessing step is skipped but data in this address may still be modified. The contents and the layout
    ///     of this address are opaque to applications and must not be modified outside functions related to device-generated
    ///     commands or copied to another buffer for reuse.
    /// </summary>
    public VkDeviceAddress preprocessAddress;

    /// <summary>preprocessSize is the maximum byte size within preprocessAddress that is available for preprocessing.</summary>
    public VkDeviceSize preprocessSize;

    /// <summary>maxSequenceCount is used to determine the number of sequences to execute.</summary>
    public uint maxSequenceCount;

    /// <summary>
    ///     sequenceCountAddress specifies an optional physical address of a single uint32_t value containing the
    ///     requested number of sequences to execute.
    /// </summary>
    public VkDeviceAddress sequenceCountAddress;

    /// <summary>
    ///     maxDrawCount is the maximum number of indirect draws that can be executed by any COUNT-type multi-draw
    ///     indirect tokens. The draw count in the indirect buffer is clamped to this value for these token types.
    /// </summary>
    public uint maxDrawCount;
}