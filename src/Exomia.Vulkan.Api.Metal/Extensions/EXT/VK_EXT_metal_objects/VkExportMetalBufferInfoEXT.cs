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
///     VkExportMetalBufferInfoEXT - Structure that identifies a VkDeviceMemory object and corresponding Metal
///     MTLBuffer object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalBufferInfoEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalBufferInfoEXT.html</a>
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
public unsafe struct VkExportMetalBufferInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>memory is a VkDeviceMemory.</summary>
    public VkDeviceMemory memory;

    /// <summary>
    ///     mtlBuffer is the Metal id&lt;MTLBuffer&gt; object underlying the VkDeviceMemory object in memory. The
    ///     implementation will return the MTLBuffer in this member, or it will return NULL if no MTLBuffer could be found
    ///     underlying the VkDeviceMemory object.
    /// </summary>
    public MTLBuffer_id mtlBuffer;
}