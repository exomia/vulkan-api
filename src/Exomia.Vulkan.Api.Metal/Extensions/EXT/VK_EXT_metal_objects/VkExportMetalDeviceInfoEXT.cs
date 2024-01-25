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
///     VkExportMetalDeviceInfoEXT - Structure that identifies a VkDevice object and corresponding Metal MTLDevice
///     object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalDeviceInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalDeviceInfoEXT.html</a>
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
public unsafe struct VkExportMetalDeviceInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     mtlDevice is the Metal id&lt;MTLDevice&gt; object underlying the VkPhysicalDevice associated with the VkDevice
    ///     object identified in the call. The implementation will return the MTLDevice in this member, or it will return NULL
    ///     if no MTLDevice could be found underlying the VkPhysicalDevice object.
    /// </summary>
    public MTLDevice_id mtlDevice;
}