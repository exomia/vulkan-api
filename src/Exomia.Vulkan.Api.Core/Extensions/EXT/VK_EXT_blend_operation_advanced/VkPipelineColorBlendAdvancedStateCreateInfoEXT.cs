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
///     VkPipelineColorBlendAdvancedStateCreateInfoEXT - Structure specifying parameters that affect advanced blend
///     operations -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAdvancedStateCreateInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPipelineColorBlendAdvancedStateCreateInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPipelineColorBlendStateCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPipelineColorBlendStateCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>srcPremultiplied specifies whether the source color of the blend operation is treated as premultiplied.</summary>
    public VkBool32 srcPremultiplied;

    /// <summary>dstPremultiplied specifies whether the destination color of the blend operation is treated as premultiplied.</summary>
    public VkBool32 dstPremultiplied;

    /// <summary>
    ///     blendOverlap is a VkBlendOverlapEXT value specifying how the source and destination sample&#8217;s coverage is
    ///     correlated.
    /// </summary>
    public VkBlendOverlapEXT blendOverlap;
}