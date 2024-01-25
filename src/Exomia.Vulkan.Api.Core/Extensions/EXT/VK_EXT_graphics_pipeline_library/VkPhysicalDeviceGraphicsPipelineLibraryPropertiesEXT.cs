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
///     VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT - Structure describing additional properties of graphics
///     pipeline libraries -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     graphicsPipelineLibraryFastLinking indicates whether fast linking of graphics pipelines is supported. If it is
    ///     VK_TRUE, creating a graphics pipeline entirely from pipeline libraries without
    ///     VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT is comparable in cost to recording a command in a command buffer.
    /// </summary>
    public VkBool32 graphicsPipelineLibraryFastLinking;

    /// <summary>
    ///     graphicsPipelineLibraryIndependentInterpolationDecorationindicates whether NoPerspective and Flat
    ///     interpolation decorations in the last vertex processing stage and the fragment shader are required to match when
    ///     using graphics pipeline libraries. If it is VK_TRUE, the interpolation decorations do not need to match. If it is
    ///     VK_FALSE, these decorations must either be present in both stages or neither stage in order for a given interface
    ///     variable to match.
    /// </summary>
    public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
}