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
///     VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM - Structure describing whether rasterization order
///     attachment access can be supported by an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM.html
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
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_ARM;

    /// <summary>
    ///     sType<br />
    ///     <a
    ///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM">
    ///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/html/vkspec.html#VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
    ///     </a>
    /// </summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     rasterizationOrderColorAttachmentAccess indicates that rasterization order access to color and input
    ///     attachments is supported by the implementation.
    /// </summary>
    public VkBool32 rasterizationOrderColorAttachmentAccess;

    /// <summary>
    ///     rasterizationOrderDepthAttachmentAccess indicates that rasterization order access to the depth aspect of
    ///     depth/stencil and input attachments is supported by the implementation.
    /// </summary>
    public VkBool32 rasterizationOrderDepthAttachmentAccess;

    /// <summary>
    ///     rasterizationOrderStencilAttachmentAccess indicates that rasterization order access to the stencil aspect of
    ///     depth/stencil and input attachments is supported by the implementation.
    /// </summary>
    public VkBool32 rasterizationOrderStencilAttachmentAccess;
}