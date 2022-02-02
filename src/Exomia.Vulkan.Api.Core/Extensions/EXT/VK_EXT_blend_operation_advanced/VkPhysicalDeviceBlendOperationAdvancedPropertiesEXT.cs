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
///     VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT - Structure describing advanced blending limits that can be
///     supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkPhysicalDeviceProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkPhysicalDeviceProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     advancedBlendMaxColorAttachments is one greater than the highest color attachment index that can be used in a
    ///     subpass, for a pipeline that uses an advanced blend operation.
    /// </summary>
    public uint advancedBlendMaxColorAttachments;

    /// <summary>advancedBlendIndependentBlend specifies whether advanced blend operations can vary per-attachment.</summary>
    public VkBool32 advancedBlendIndependentBlend;

    /// <summary>
    ///     advancedBlendNonPremultipliedSrcColor specifies whether the source color can be treated as non-premultiplied.
    ///     If this is VK_FALSE, then VkPipelineColorBlendAdvancedStateCreateInfoEXT::srcPremultipliedmust be VK_TRUE.
    /// </summary>
    public VkBool32 advancedBlendNonPremultipliedSrcColor;

    /// <summary>
    ///     advancedBlendNonPremultipliedDstColor specifies whether the destination color can be treated as
    ///     non-premultiplied. If this is VK_FALSE, then VkPipelineColorBlendAdvancedStateCreateInfoEXT::dstPremultipliedmust
    ///     be VK_TRUE.
    /// </summary>
    public VkBool32 advancedBlendNonPremultipliedDstColor;

    /// <summary>
    ///     advancedBlendCorrelatedOverlap specifies whether the overlap mode can be treated as correlated. If this is
    ///     VK_FALSE, then VkPipelineColorBlendAdvancedStateCreateInfoEXT::blendOverlapmust be
    ///     VK_BLEND_OVERLAP_UNCORRELATED_EXT.
    /// </summary>
    public VkBool32 advancedBlendCorrelatedOverlap;

    /// <summary>
    ///     advancedBlendAllOperationsspecifies whether all advanced blend operation enums are supported. See the valid
    ///     usage of VkPipelineColorBlendAttachmentState.
    /// </summary>
    public VkBool32 advancedBlendAllOperations;
}