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
namespace Exomia.Vulkan.Api.Ggp;

/// <summary>
///     VkStreamDescriptorSurfaceCreateInfoGGP - Structure specifying parameters of a newly created Google Games Platform
///     stream surface object -
///     <a
///         href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStreamDescriptorSurfaceCreateInfoGGP.html">
///         https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkStreamDescriptorSurfaceCreateInfoGGP.html
///     </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkStreamDescriptorSurfaceCreateFlagsGGP flags;

    /// <summary>
    ///     streamDescriptor is a GgpStreamDescriptor referring to the GGP stream descriptor to associate with the
    ///     surface.
    /// </summary>
    public GgpStreamDescriptor streamDescriptor;
}