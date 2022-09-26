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
///     VkPipelineRasterizationStateCreateInfo - Structure specifying parameters of a newly created pipeline rasterization state -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineRasterizationStateCreateInfo.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkPipelineRasterizationStateCreateFlags flags;

    /// <summary> depthClampEnable controls whether to clamp the fragment&#8217;s depth values as described in Depth Test. If the pipeline is not created with VkPipelineRasterizationDepthClipStateCreateInfoEXT present then enabling depth clamp will also disable clipping primitives to the z planes of the frustrum as described in Primitive Clipping. Otherwise depth clipping is controlled by the state set in VkPipelineRasterizationDepthClipStateCreateInfoEXT. </summary>
    public VkBool32 depthClampEnable;

    /// <summary> rasterizerDiscardEnable controls whether primitives are discarded immediately before the rasterization stage. </summary>
    public VkBool32 rasterizerDiscardEnable;

    /// <summary> polygonMode is the triangle rendering mode. See VkPolygonMode. </summary>
    public VkPolygonMode polygonMode;

    /// <summary> cullMode is the triangle facing direction used for primitive culling. See VkCullModeFlagBits. </summary>
    public VkCullModeFlags cullMode;

    /// <summary> frontFace is a VkFrontFace value specifying the front-facing triangle orientation to be used for culling. </summary>
    public VkFrontFace frontFace;

    /// <summary> depthBiasEnable controls whether to bias fragment depth values. </summary>
    public VkBool32 depthBiasEnable;

    /// <summary> depthBiasConstantFactor is a scalar factor controlling the constant depth value added to each fragment. </summary>
    public float depthBiasConstantFactor;

    /// <summary> depthBiasClamp is the maximum (or minimum) depth bias of a fragment. </summary>
    public float depthBiasClamp;

    /// <summary> depthBiasSlopeFactor is a scalar factor applied to a fragment&#8217;s slope in depth bias calculations. </summary>
    public float depthBiasSlopeFactor;

    /// <summary> lineWidth is the width of rasterized line segments. </summary>
    public float lineWidth;
}