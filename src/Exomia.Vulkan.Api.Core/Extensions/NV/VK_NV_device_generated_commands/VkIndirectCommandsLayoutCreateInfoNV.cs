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
///     VkIndirectCommandsLayoutCreateInfoNV - Structure specifying the parameters of a newly created indirect commands
///     layout object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutCreateInfoNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is a bitmask of VkIndirectCommandsLayoutUsageFlagBitsNV specifying usage hints of this layout.</summary>
    public VkIndirectCommandsLayoutUsageFlagsNV flags;

    /// <summary>pipelineBindPoint is the VkPipelineBindPoint that this layout targets.</summary>
    public VkPipelineBindPoint pipelineBindPoint;

    /// <summary>tokenCount is the length of the individual command sequence.</summary>
    public uint tokenCount;

    /// <summary>
    ///     pTokens is an array describing each command token in detail. See VkIndirectCommandsTokenTypeNV and
    ///     VkIndirectCommandsLayoutTokenNV below for details.
    /// </summary>
    public VkIndirectCommandsLayoutTokenNV* pTokens;

    /// <summary>streamCount is the number of streams used to provide the token inputs.</summary>
    public uint streamCount;

    /// <summary>pStreamStrides is an array defining the byte stride for each input stream.</summary>
    public uint* pStreamStrides;
}