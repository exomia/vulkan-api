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
namespace Exomia.Vulkan.Api.Core;

/// <summary>
///     VkSubresourceHostMemcpySizeEXT - Memory size needed to copy to or from an image on the host with
///     VK_HOST_IMAGE_COPY_MEMCPY_EXT -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubresourceHostMemcpySizeEXT.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSubresourceHostMemcpySizeEXT.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkSubresourceLayout2KHR</description>
///         </item>
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkSubresourceLayout2KHR")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubresourceHostMemcpySizeEXT
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>size is the size in bytes of the image subresource.</summary>
    public VkDeviceSize size;
}