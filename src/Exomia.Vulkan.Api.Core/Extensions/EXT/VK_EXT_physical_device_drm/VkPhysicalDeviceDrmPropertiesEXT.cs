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
///     VkPhysicalDeviceDrmPropertiesEXT - Structure containing DRM information of a physical device -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDrmPropertiesEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkPhysicalDeviceDrmPropertiesEXT.html
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
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>hasPrimary is a boolean indicating whether the physical device has a DRM primary node.</summary>
    public VkBool32 hasPrimary;

    /// <summary>hasRender is a boolean indicating whether the physical device has a DRM render node.</summary>
    public VkBool32 hasRender;

    /// <summary>primaryMajor is the DRM primary node major number, if any.</summary>
    public long primaryMajor;

    /// <summary>primaryMinor is the DRM primary node minor number, if any.</summary>
    public long primaryMinor;

    /// <summary>renderMajor is the DRM render node major number, if any.</summary>
    public long renderMajor;

    /// <summary>renderMinor is the DRM render node minor number, if any.</summary>
    public long renderMinor;
}