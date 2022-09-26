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
namespace Exomia.Vulkan.Api.Macos;

/// <summary>
///     VkMacOSSurfaceCreateInfoMVK - Structure specifying parameters of a newly created macOS surface object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMacOSSurfaceCreateInfoMVK.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkMacOSSurfaceCreateInfoMVK.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMacOSSurfaceCreateInfoMVK
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkMacOSSurfaceCreateFlagsMVK flags;

    /// <summary> pView is a reference to either a CAMetalLayer object or an NSView object. </summary>
    public void* pView;
}