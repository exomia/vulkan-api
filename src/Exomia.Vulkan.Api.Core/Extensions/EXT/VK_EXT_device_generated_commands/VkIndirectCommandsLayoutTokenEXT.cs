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
///     VkIndirectCommandsLayoutTokenEXT - Struct specifying the details of an indirect command layout token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutTokenEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>type specifies the VkIndirectCommandsTokenTypeEXT for data.</summary>
    public VkIndirectCommandsTokenTypeEXT type;

    /// <summary>
    ///     data specifies a VkIndirectCommandsTokenDataEXT containing token-specific details for command execution. It is
    ///     ignored if type does not match any member of the VkIndirectCommandsTokenDataEXT union.
    /// </summary>
    public VkIndirectCommandsTokenDataEXT data;

    /// <summary>
    ///     offset is the relative byte offset for the token within one sequence of the indirect buffer. The data stored
    ///     at that offset is the command data for the token, e.g. VkDispatchIndirectCommand.
    /// </summary>
    public uint offset;
}