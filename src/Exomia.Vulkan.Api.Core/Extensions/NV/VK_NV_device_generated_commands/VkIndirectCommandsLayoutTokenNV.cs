#region License

// Copyright (c) 2018-2022, exomia
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
///     VkIndirectCommandsLayoutTokenNV - Struct specifying the details of an indirect command layout token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenNV.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsLayoutTokenNV.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectCommandsLayoutTokenNV
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>tokenType specifies the token command type.</summary>
    public VkIndirectCommandsTokenTypeNV tokenType;

    /// <summary>stream is the index of the input stream containing the token argument data.</summary>
    public uint stream;

    /// <summary>offset is a relative starting offset within the input stream memory for the token argument data.</summary>
    public uint offset;

    /// <summary>vertexBindingUnit is used for the vertex buffer binding command.</summary>
    public uint vertexBindingUnit;

    /// <summary>
    ///     vertexDynamicStride sets if the vertex buffer stride is provided by the binding command rather than the
    ///     current bound graphics pipeline state.
    /// </summary>
    public VkBool32 vertexDynamicStride;

    /// <summary>pushconstantPipelineLayout is the VkPipelineLayout used for the push constant command.</summary>
    public VkPipelineLayout pushconstantPipelineLayout;

    /// <summary>pushconstantShaderStageFlags are the shader stage flags used for the push constant command.</summary>
    public VkShaderStageFlags pushconstantShaderStageFlags;

    /// <summary>pushconstantOffset is the offset used for the push constant command.</summary>
    public uint pushconstantOffset;

    /// <summary>pushconstantSize is the size used for the push constant command.</summary>
    public uint pushconstantSize;

    /// <summary>indirectStateFlags are the active states for the state flag command.</summary>
    public VkIndirectStateFlagsNV indirectStateFlags;

    /// <summary>
    ///     indexTypeCount is the optional size of the pIndexTypes and pIndexTypeValues array pairings. If not zero, it
    ///     allows to register a custom uint32_t value to be treated as specific VkIndexType.
    /// </summary>
    public uint indexTypeCount;

    /// <summary>pIndexTypes is the used VkIndexType for the corresponding uint32_t value entry in pIndexTypeValues.</summary>
    public VkIndexType* pIndexTypes;

    /// <summary>
    ///     indexTypeCount is the optional size of the pIndexTypes and pIndexTypeValues array pairings. If not zero, it
    ///     allows to register a custom uint32_t value to be treated as specific VkIndexType.
    /// </summary>
    public uint* pIndexTypeValues;
}