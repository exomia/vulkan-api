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
///     VkIndirectExecutionSetInfoTypeEXT - Enum specifying allowed usage of an indirect execution set -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoTypeEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetInfoTypeEXT.html
///     </a>
/// </summary>
public enum VkIndirectExecutionSetInfoTypeEXT
{
    /// <summary>
    ///     VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT specifies that the indirect execution set contains
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipeline.html">VkPipeline</a>
    ///     objects.
    /// </summary>
    VK_INDIRECT_EXECUTION_SET_INFO_TYPE_PIPELINES_EXT = 0,

    /// <summary>
    ///     VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT specifies that the indirect execution set contains
    ///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkShaderEXT.html">VkShaderEXT</a>
    ///     objects.
    /// </summary>
    VK_INDIRECT_EXECUTION_SET_INFO_TYPE_SHADER_OBJECTS_EXT = 1
}