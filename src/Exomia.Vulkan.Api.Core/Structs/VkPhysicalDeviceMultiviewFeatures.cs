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
///     VkPhysicalDeviceMultiviewFeatures - Structure describing multiview features that can be supported by an
///     implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewFeatures.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceMultiviewFeatures.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceFeatures2,VkDeviceCreateInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceFeatures2,VkDeviceCreateInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewFeatures
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     multiview specifies whether the implementation supports multiview rendering within a render pass. If this
    ///     feature is not enabled, the view mask of each subpass mustalways be zero.
    /// </summary>
    public VkBool32 multiview;

    /// <summary>
    ///     multiviewGeometryShaderspecifies whether the implementation supports multiview rendering within a render
    ///     pass, with geometry shaders. If this feature is not enabled, then a pipeline compiled against a subpass with a
    ///     non-zero view mask must not include a geometry shader.
    /// </summary>
    public VkBool32 multiviewGeometryShader;

    /// <summary>
    ///     multiviewTessellationShader specifies whether the implementation supports multiview rendering within a render
    ///     pass, with tessellation shaders. If this feature is not enabled, then a pipeline compiled against a subpass with a
    ///     non-zero view mask must not include any tessellation shaders.
    /// </summary>
    public VkBool32 multiviewTessellationShader;
}