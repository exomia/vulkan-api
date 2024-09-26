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
///     VkIndirectCommandsTokenTypeEXT - Enum specifying token commands -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsTokenTypeEXT.html</a>
/// </summary>
public enum VkIndirectCommandsTokenTypeEXT
{
    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>u32[] array of indices into the indirect execution set</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_EXECUTION_SET_EXT = 0,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>u32[] raw data</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_EXT = 1,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>u32 placeholder data (not accessed by shader)</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_SEQUENCE_INDEX_EXT = 2,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkBindIndexBufferIndirectCommandEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_EXT = 3,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkBindVertexBufferIndirectCommandEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_EXT = 4,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkDrawIndexedIndirectCommand</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_EXT = 5,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkDrawIndirectCommand</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_EXT = 6,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term>
    ///             <description>VkDrawIndirectCountIndirectCommandEXT with VkDrawIndexedIndirectCommand</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_COUNT_EXT = 7,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term>
    ///             <description>VkDrawIndirectCountIndirectCommandEXT with VkDrawIndirectCommand</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_COUNT_EXT = 8,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkDispatchIndirectCommand</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_EXT = 9,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkDrawMeshTasksIndirectCommandNV</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV_EXT = 1000202002,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term>
    ///             <description>VkDrawIndirectCountIndirectCommandEXT with VkDrawMeshTasksIndirectCommandNV</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_NV_EXT = 1000202003,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkDrawMeshTasksIndirectCommandEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_EXT = 1000328000,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term>
    ///             <description>VkDrawIndirectCountIndirectCommandEXT with VkDrawMeshTasksIndirectCommandEXT</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_COUNT_EXT = 1000328001,

    /// <summary>
    ///     <list type="table">
    ///         <item>
    ///             <term>Command Data</term><description>VkTraceRaysIndirectCommand2KHR</description>
    ///         </item>
    ///     </list>
    /// </summary>
    VK_INDIRECT_COMMANDS_TOKEN_TYPE_TRACE_RAYS2_EXT = 1000386004
}