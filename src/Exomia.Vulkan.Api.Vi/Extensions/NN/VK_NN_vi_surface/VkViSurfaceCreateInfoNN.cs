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
namespace Exomia.Vulkan.Api.Vi;

/// <summary>
///     VkViSurfaceCreateInfoNN - Structure specifying parameters of a newly created VI surface object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViSurfaceCreateInfoNN.html"> https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkViSurfaceCreateInfoNN.html </a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkViSurfaceCreateInfoNN
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN;

    /// <summary> sType is the type of this structure. </summary>
    public VkStructureType sType;

    /// <summary> pNext is NULL or a pointer to a structure extending this structure. </summary>
    public void* pNext;

    /// <summary> flags is reserved for future use. </summary>
    public VkViSurfaceCreateFlagsNN flags;

    /// <summary> window is the nn::vi::NativeWindowHandle for the nn::vi::Layer with which to associate the surface. </summary>
    public void* window;
}