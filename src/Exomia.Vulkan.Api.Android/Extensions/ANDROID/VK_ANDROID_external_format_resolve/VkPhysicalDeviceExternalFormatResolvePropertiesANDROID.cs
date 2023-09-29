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
namespace Exomia.Vulkan.Api.Android;

/// <summary>
///     VkPhysicalDeviceExternalFormatResolvePropertiesANDROID - Structure describing external format resolve supported by
///     an implementation -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolvePropertiesANDROID.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceExternalFormatResolvePropertiesANDROID.html
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
public unsafe struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FORMAT_RESOLVE_PROPERTIES_ANDROID;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     nullColorAttachmentWithExternalFormatResolve indicates that there must be no color attachment image when
    ///     performing external format resolves if it is VK_TRUE.
    /// </summary>
    public VkBool32 nullColorAttachmentWithExternalFormatResolve;

    /// <summary>
    ///     externalFormatResolveChromaOffsetX indicates the VkChromaLocation that an implementation uses in the X axis
    ///     for accesses to an external format image as a resolve attachment. This must be consistent between external format
    ///     resolves and load operations from external format resolve attachments to color attachments when
    ///     nullColorAttachmentWithExternalFormatResolve is VK_TRUE.
    /// </summary>
    public VkChromaLocation externalFormatResolveChromaOffsetX;

    /// <summary>
    ///     externalFormatResolveChromaOffsetY indicates the VkChromaLocation that an implementation uses in the Y axis
    ///     for accesses to an external format image as a resolve attachment. This must be consistent between external format
    ///     resolves and load operations from external format resolve attachments to color attachments when
    ///     nullColorAttachmentWithExternalFormatResolve is VK_TRUE.
    /// </summary>
    public VkChromaLocation externalFormatResolveChromaOffsetY;
}