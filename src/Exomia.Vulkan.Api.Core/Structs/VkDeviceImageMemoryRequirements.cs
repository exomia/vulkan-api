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
///     VkDeviceImageMemoryRequirements - (None) -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceImageMemoryRequirements.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDeviceImageMemoryRequirements.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageMemoryRequirements
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>
    ///     pCreateInfo is a pointer to a VkImageCreateInfo structure containing parameters affecting creation of the
    ///     image to query.
    /// </summary>
    public VkImageCreateInfo* pCreateInfo;

    /// <summary>
    ///     planeAspect is a VkImageAspectFlagBits value specifying the aspect corresponding to the image plane to query.
    ///     This parameter is ignored unless pCreateInfo::tiling is VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT, or
    ///     pCreateInfo::flags has VK_IMAGE_CREATE_DISJOINT_BITset.
    /// </summary>
    public VkImageAspectFlagBits planeAspect;
}