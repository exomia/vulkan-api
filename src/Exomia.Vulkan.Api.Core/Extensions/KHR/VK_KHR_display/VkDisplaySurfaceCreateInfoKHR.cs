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
///     VkDisplaySurfaceCreateInfoKHR - Structure specifying parameters of a newly created display plane surface
///     object -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceCreateInfoKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplaySurfaceCreateInfoKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplaySurfaceCreateInfoKHR
{
    /// <summary> The stype of this structure. </summary>
    public const VkStructureType STYPE = VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR;

    /// <summary>sType is the type of this structure.</summary>
    public VkStructureType sType;

    /// <summary>pNext is NULL or a pointer to a structure extending this structure.</summary>
    public void* pNext;

    /// <summary>flags is reserved for future use, and must be zero.</summary>
    public VkDisplaySurfaceCreateFlagsKHR flags;

    /// <summary>displayMode is a VkDisplayModeKHR handle specifying the mode to use when displaying this surface.</summary>
    public VkDisplayModeKHR displayMode;

    /// <summary>planeIndex is the plane on which this surface appears.</summary>
    public uint planeIndex;

    /// <summary>planeStackIndex is the z-order of the plane.</summary>
    public uint planeStackIndex;

    /// <summary>
    ///     transform is a VkSurfaceTransformFlagBitsKHR value specifying the transformation to apply to images as part of
    ///     the scanout operation.
    /// </summary>
    public VkSurfaceTransformFlagBitsKHR transform;

    /// <summary>
    ///     globalAlpha is the global alpha value. This value is ignored if alphaMode is not
    ///     VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR.
    /// </summary>
    public float globalAlpha;

    /// <summary>alphaMode is a VkDisplayPlaneAlphaFlagBitsKHR value specifying the type of alpha blending to use.</summary>
    public VkDisplayPlaneAlphaFlagBitsKHR alphaMode;

    /// <summary>imageExtent is the size of the presentable images to use with the surface.</summary>
    public VkExtent2D imageExtent;
}