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
///     VkIndirectExecutionSetShaderLayoutInfoEXT - Struct specifying descriptor layout parameters of a newly created
///     indirect execution set containing only shader objects -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderLayoutInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIndirectExecutionSetShaderLayoutInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIndirectExecutionSetShaderLayoutInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_INDIRECT_EXECUTION_SET_SHADER_LAYOUT_INFO_EXT;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkIndirectExecutionSetShaderLayoutInfoEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkIndirectExecutionSetShaderLayoutInfoEXT
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>setLayoutCount is the number of members in the pSetLayoutsarray</summary>
    public uint setLayoutCount;

    /// <summary>pSetLayouts is a pointer to an array containing VkDescriptorSetLayout objects used by the shader stage.</summary>
    public VkDescriptorSetLayout* pSetLayouts;
}