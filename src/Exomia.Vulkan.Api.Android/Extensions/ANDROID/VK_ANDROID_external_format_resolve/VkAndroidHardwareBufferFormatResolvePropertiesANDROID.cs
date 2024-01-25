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
namespace Exomia.Vulkan.Api.Android;

/// <summary>
///     VkAndroidHardwareBufferFormatResolvePropertiesANDROID - Structure defining properties of resolves using an external
///     format -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatResolvePropertiesANDROID.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkAndroidHardwareBufferFormatResolvePropertiesANDROID.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkAndroidHardwareBufferPropertiesANDROID</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkAndroidHardwareBufferPropertiesANDROID")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_RESOLVE_PROPERTIES_ANDROID;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     colorAttachmentFormat is a VkFormat specifying the format of color attachment images that must be used for
    ///     color attachments when resolving to the specified external format. If the implementation supports external format
    ///     resolves for the specified external format, this value will be set to a color format supporting the
    ///     VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT in VkFormatProperties::optimalTilingFeatures as returned by
    ///     vkGetPhysicalDeviceFormatProperties with format equal to colorAttachmentFormat If external format resolves are not
    ///     supported, this value will be set to VK_FORMAT_UNDEFINED.
    /// </summary>
    public VkFormat colorAttachmentFormat;
}