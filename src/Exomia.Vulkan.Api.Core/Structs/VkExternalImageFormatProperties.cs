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
///     VkExternalImageFormatProperties - Structure specifying supported external handle properties -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatProperties.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExternalImageFormatProperties.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageFormatProperties2</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageFormatProperties2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalImageFormatProperties
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     externalMemoryProperties is a VkExternalMemoryPropertiesstructure specifying various capabilities of the
    ///     external handle type when used with the specified image creation parameters.
    /// </summary>
    public VkExternalMemoryProperties externalMemoryProperties;
}