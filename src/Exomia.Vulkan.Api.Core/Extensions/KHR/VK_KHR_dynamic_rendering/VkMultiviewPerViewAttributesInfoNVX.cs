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
///     VkMultiviewPerViewAttributesInfoNVX - Structure specifying the multiview per-attribute properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewAttributesInfoNVX.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultiviewPerViewAttributesInfoNVX.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term>
///             <description> VkCommandBufferInheritanceInfo,VkGraphicsPipelineCreateInfo,VkRenderingInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkCommandBufferInheritanceInfo,VkGraphicsPipelineCreateInfo,VkRenderingInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultiviewPerViewAttributesInfoNVX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> perViewAttributes specifies that shaders compiled for this pipeline write the attributes for all views in a single invocation of each vertex processing stage. All pipelines executed within a render pass instance that includes this bit must write per-view attributes to the *PerViewNV[] shader outputs, in addition to the non-per-view (e.g. Position) outputs. </summary>
    public VkBool32 perViewAttributes;

    /// <summary> perViewAttributesPositionXOnly specifies that shaders compiled for this pipeline use per-view positions which only differ in value in the x component. Per-view viewport mask can also be used. </summary>
    public VkBool32 perViewAttributesPositionXOnly;
}