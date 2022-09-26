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
namespace Exomia.Vulkan.Api.Metal;

/// <summary>
///     VkExportMetalCommandQueueInfoEXT - Structure that identifies a VkQueue object and corresponding Metal MTLCommandQueue object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalCommandQueueInfoEXT.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExportMetalCommandQueueInfoEXT.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term> structextends </term><description> VkExportMetalObjectsInfoEXT </description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkExportMetalObjectsInfoEXT")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalCommandQueueInfoEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> queue is a VkQueue. </summary>
    public VkQueue queue;

    /// <summary> mtlCommandQueue is the Metal id&lt;MTLCommandQueue&gt; object underlying the VkQueue object in queue. The implementation will return the MTLCommandQueue in this member, or it will return NULL if no MTLCommandQueue could be found underlying the VkQueue object. </summary>
    public MTLCommandQueue_id mtlCommandQueue;
}