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
///     VkIndirectExecutionSetInfoEXT - Union specifying parameters of a newly created indirect execution set -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct VkIndirectExecutionSetInfoEXT
{
    /// <summary>
    ///     pPipelineInfo is a pointer to a VkIndirectExecutionSetPipelineInfoEXT struct containing pipeline layout
    ///     information for the set.
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectExecutionSetPipelineInfoEXT* pPipelineInfo;

    /// <summary>
    ///     pShaderInfo is a pointer to a VkIndirectExecutionSetShaderInfoEXT struct containing shader object layout
    ///     information for the set.
    /// </summary>
    [FieldOffset(0)]
    public VkIndirectExecutionSetShaderInfoEXT* pShaderInfo;
}