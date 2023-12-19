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
///     VkBindDescriptorBufferEmbeddedSamplersInfoEXT - Structure specifying embedded immutable sampler offsets to set in a
///     command buffer -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorBufferEmbeddedSamplersInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindDescriptorBufferEmbeddedSamplersInfoEXT.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_DESCRIPTOR_BUFFER_EMBEDDED_SAMPLERS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages that will use the embedded
    ///     immutable samplers.
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>
    ///     layout is a VkPipelineLayout object used to program the bindings. If the dynamicPipelineLayoutfeature is
    ///     enabled, layout can be VK_NULL_HANDLE and the layout must be specified by chaining
    ///     VkPipelineLayoutCreateInfostructure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>set is the number of the set to be bound.</summary>
    public uint set;
}