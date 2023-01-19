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
///     VkDisplayPropertiesKHR - Structure describing an available display device -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPropertiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayPropertiesKHR
{
    /// <summary>
    ///     display is a handle that is used to refer to the display described here. This handle will be valid for the
    ///     lifetime of the Vulkan instance.
    /// </summary>
    public VkDisplayKHR display;

    /// <summary>
    ///     displayName is NULL or a pointer to a null-terminated UTF-8 string containing the name of the display.
    ///     Generally, this will be the name provided by the display&#8217;s EDID. If NULL, no suitable name is available. If
    ///     not NULL, the string pointed to must remain accessible and unmodified as long as display is valid.
    /// </summary>
    public byte* displayName;

    /// <summary>
    ///     physicalDimensions describes the physical width and height of the visible portion of the display, in
    ///     millimeters.
    /// </summary>
    public VkExtent2D physicalDimensions;

    /// <summary>physicalResolution describes the physical, native, or preferred resolution of the display.</summary>
    public VkExtent2D physicalResolution;

    /// <summary>
    ///     supportedTransforms is a bitmask of VkSurfaceTransformFlagBitsKHR describing which transforms are supported by
    ///     this display.
    /// </summary>
    public VkSurfaceTransformFlagsKHR supportedTransforms;

    /// <summary>
    ///     planeReorderPossible tells whether the planes on this display canhave their z order changed. If this is
    ///     VK_TRUE, the application can re-arrange the planes on this display in any order relative to each other.
    /// </summary>
    public VkBool32 planeReorderPossible;

    /// <summary>
    ///     persistentContent tells whether the display supports self-refresh/internal buffering. If this is true, the
    ///     application can submit persistent present operations on swapchains created against this display.
    /// </summary>
    public VkBool32 persistentContent;
}