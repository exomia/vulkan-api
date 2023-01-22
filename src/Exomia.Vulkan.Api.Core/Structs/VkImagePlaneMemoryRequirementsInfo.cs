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
///     VkImagePlaneMemoryRequirementsInfo - Structure specifying image plane for memory requirements -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImagePlaneMemoryRequirementsInfo.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkImagePlaneMemoryRequirementsInfo.html
///     </a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>structextends</term><description>VkImageMemoryRequirementsInfo2</description>
///         </item>
///     </list>
/// </remarks>
[VkStructExtends("VkImageMemoryRequirementsInfo2")]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>planeAspect is a VkImageAspectFlagBits value specifying the aspect corresponding to the image plane to query.</summary>
    public VkImageAspectFlagBits planeAspect;
}