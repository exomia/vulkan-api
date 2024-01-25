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
///     VkDepthBiasInfoEXT - Structure specifying depth bias parameters -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthBiasInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDepthBiasInfoEXT.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDepthBiasInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>depthBiasConstantFactor is a scalar factor controlling the constant depth value added to each fragment.</summary>
    public float depthBiasConstantFactor;

    /// <summary>depthBiasClamp is the maximum (or minimum) depth bias of a fragment.</summary>
    public float depthBiasClamp;

    /// <summary>depthBiasSlopeFactor is a scalar factor applied to a fragment&#8217;s slope in depth bias calculations.</summary>
    public float depthBiasSlopeFactor;
}