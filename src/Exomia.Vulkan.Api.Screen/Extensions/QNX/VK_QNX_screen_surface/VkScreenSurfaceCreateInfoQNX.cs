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
namespace Exomia.Vulkan.Api.Screen;

/// <summary>
///     VkScreenSurfaceCreateInfoQNX - Structure specifying parameters of a newly created QNX Screen surface object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenSurfaceCreateInfoQNX.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkScreenSurfaceCreateInfoQNX.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenSurfaceCreateInfoQNX
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX;

    /// <summary>sType is a VkStructureType value identifying this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use.</summary>
    public VkScreenSurfaceCreateFlagsQNX flags;

    /// <summary>context and window are QNX Screen context and window to associate the surface with.</summary>
    public _screen_context* context;

    /// <summary>context and window are QNX Screen context and window to associate the surface with.</summary>
    public _screen_window* window;
}