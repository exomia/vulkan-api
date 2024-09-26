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
///     VkIndirectCommandsTokenDataEXT - Union specifying the token-specific details of an indirect command layout
///     token -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenDataEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenDataEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkIndirectCommandsTokenDataEXT
{
    /// <summary>
    ///     pPushConstant is a pointer to a VkIndirectCommandsPushConstantTokenEXT struct needed for
    ///     VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT and VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT tokens
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectCommandsPushConstantTokenEXT* pPushConstant;

    /// <summary>
    ///     pVertexBuffer is a pointer to a VkIndirectCommandsVertexBufferTokenEXT struct needed for
    ///     VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT tokens
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectCommandsVertexBufferTokenEXT* pVertexBuffer;

    /// <summary>
    ///     pIndexBuffer is a pointer to a VkIndirectCommandsIndexBufferTokenEXT struct needed for
    ///     VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT tokens
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectCommandsIndexBufferTokenEXT* pIndexBuffer;

    /// <summary>
    ///     pExecutionSet is a pointer to a VkIndirectCommandsExecutionSetTokenEXT struct needed for
    ///     VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT tokens
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectCommandsExecutionSetTokenEXT* pExecutionSet;
}