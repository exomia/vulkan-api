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
///     VkMultisampledRenderToSingleSampledInfoEXT - Structure containing info for multisampled rendering to single-sampled attachments in a subpass -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultisampledRenderToSingleSampledInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMultisampledRenderToSingleSampledInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkSubpassDescription2,VkRenderingInfo </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubpassDescription2,VkRenderingInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisampledRenderToSingleSampledInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> multisampledRenderToSingleSampledEnable controls whether multisampled rendering to single-sampled attachments is performed as described below. </summary>
    public VkBool32 multisampledRenderToSingleSampledEnable;

    /// <summary> rasterizationSamples is a VkSampleCountFlagBits specifying the number of samples used in rasterization. </summary>
    public VkSampleCountFlagBits rasterizationSamples;
}