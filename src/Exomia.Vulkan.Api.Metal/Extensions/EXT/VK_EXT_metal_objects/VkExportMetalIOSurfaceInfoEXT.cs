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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalIOSurfaceInfoEXT - Structure that identifies a VkImage object and corresponding Metal
///     IOSurfaceRef object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalIOSurfaceInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalIOSurfaceInfoEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkExportMetalObjectsInfoEXT</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkExportMetalObjectsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalIOSurfaceInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>image is a VkImage.</summary>
    public VkImage image;

    /// <summary>
    ///     ioSurface is the Metal IOSurfaceRef object underlying the VkImage object in image. The implementation will
    ///     return the IOSurfaceRef in this member, or it will return NULL if no IOSurfaceRef could be found underlying the
    ///     VkImage object.
    /// </summary>
    public IOSurfaceRef ioSurface;
}