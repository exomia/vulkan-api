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
///     VkBindImagePlaneMemoryInfo - Structure specifying how to bind an image plane to memory -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImagePlaneMemoryInfo.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkBindImagePlaneMemoryInfo.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkBindImageMemoryInfo</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkBindImageMemoryInfo")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImagePlaneMemoryInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>planeAspect is a VkImageAspectFlagBits value specifying the aspect of the disjoint image plane to bind.</summary>
    public VkImageAspectFlagBits planeAspect;
}