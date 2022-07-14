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
///     VkPhysicalDeviceProvokingVertexFeaturesEXT - Structure describing the provoking vertex features that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProvokingVertexFeaturesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceProvokingVertexFeaturesEXT.html
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
public unsafe struct VkPhysicalDeviceProvokingVertexFeaturesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     provokingVertexLast indicates whether the implementation supports the
    ///     VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXTprovoking vertex mode for flat shading.
    /// </summary>
    public VkBool32 provokingVertexLast;

    /// <summary>
    ///     transformFeedbackPreservesProvokingVertex indicates that the order of vertices within each primitive written
    ///     by transform feedback will preserve the provoking vertex. This does not apply to triangle fan primitives when
    ///     transformFeedbackPreservesTriangleFanProvokingVertex is VK_FALSE. transformFeedbackPreservesProvokingVertex must be
    ///     VK_FALSEwhen the VK_EXT_transform_feedback extension is not supported.
    /// </summary>
    public VkBool32 transformFeedbackPreservesProvokingVertex;
}