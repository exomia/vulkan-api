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
///     VkPushConstantsInfoKHR - Structure specifying a push constant update operation -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushConstantsInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPushConstantsInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPushConstantsInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PUSH_CONSTANTS_INFO_KHR;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     layout is the pipeline layout used to program the push constant updates. If the dynamicPipelineLayoutfeature
    ///     is enabled, layout can be VK_NULL_HANDLE and the layout must be specified by chaining
    ///     VkPipelineLayoutCreateInfostructure off the pNext
    /// </summary>
    public VkPipelineLayout layout;

    /// <summary>
    ///     stageFlags is a bitmask of VkShaderStageFlagBits specifying the shader stages that will use the push constants
    ///     in the updated range.
    /// </summary>
    public VkShaderStageFlags stageFlags;

    /// <summary>offset is the start offset of the push constant range to update, in units of bytes.</summary>
    public uint offset;

    /// <summary>size is the size of the push constant range to update, in units of bytes.</summary>
    public uint size;

    /// <summary>pValues is a pointer to an array of size bytes containing the new push constant values.</summary>
    public void* pValues;
}