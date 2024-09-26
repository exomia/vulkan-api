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
///     VkGeneratedCommandsMemoryRequirementsInfoEXT - Structure specifying parameters for the reservation of preprocess
///     buffer space -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkGeneratedCommandsMemoryRequirementsInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeneratedCommandsMemoryRequirementsInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>indirectExecutionSet is the indirect execution set to be used for binding shaders.</summary>
    public VkIndirectExecutionSetEXT indirectExecutionSet;

    /// <summary>indirectCommandsLayout is the VkIndirectCommandsLayoutEXTthat this buffer memory is intended to be used with.</summary>
    public VkIndirectCommandsLayoutEXT indirectCommandsLayout;

    /// <summary>maxSequenceCount is the maximum number of sequences that this buffer memory can be used with.</summary>
    public uint maxSequenceCount;

    /// <summary>
    ///     maxDrawCount is the maximum number of indirect draws that can be executed by any COUNT-type multi-draw
    ///     indirect tokens. The draw count in the indirect buffer is clamped to this value for these token types.
    /// </summary>
    public uint maxDrawCount;
}