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
namespace Exomia.Vulkan.Api.Ios;

/// <summary>
///     VkIOSSurfaceCreateInfoMVK - Structure specifying parameters of a newly created iOS surface object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIOSSurfaceCreateInfoMVK.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkIOSSurfaceCreateInfoMVK.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkIOSSurfaceCreateInfoMVK
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkIOSSurfaceCreateFlagsMVK flags;

    /// <summary>pView is a reference to either a CAMetalLayer object or a UIView object.</summary>
    public void* pView;
}