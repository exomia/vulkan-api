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
///     VkIndirectCommandsExecutionSetTokenEXT - Structure specifying input data for a single execution set command token -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsExecutionSetTokenEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectCommandsExecutionSetTokenEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkIndirectCommandsExecutionSetTokenEXT
{
    /// <summary>type describes the type of indirect execution set in use.</summary>
    public VkIndirectExecutionSetInfoTypeEXT type;

    /// <summary>shaderStages specifies the shaders that will be changed by this token.</summary>
    public VkShaderStageFlags shaderStages;
}