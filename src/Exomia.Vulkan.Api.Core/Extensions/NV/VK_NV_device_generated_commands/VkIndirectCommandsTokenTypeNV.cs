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
///     VkIndirectCommandsTokenTypeNV - Enum specifying token commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeNV.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeNV.html </a>
/// </summary>
public enum VkIndirectCommandsTokenTypeNV
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdBindPipelineShaderGroupNV </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> - </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdBindIndexBuffer </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdBindVertexBuffers </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdPushConstants </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdDrawIndexedIndirect </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdDrawIndirect </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdDrawMeshTasksIndirectNV </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term> Equivalent command </term><description> vkCmdDrawMeshTasksIndirectEXT </description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV = 1000328000
}