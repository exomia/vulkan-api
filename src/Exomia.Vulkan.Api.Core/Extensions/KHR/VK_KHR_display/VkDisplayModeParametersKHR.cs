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
///     VkDisplayModeParametersKHR - Structure describing display parameters associated with a display mode -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayModeParametersKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayModeParametersKHR.html</a>
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct VkDisplayModeParametersKHR
{
    /// <summary>visibleRegion is the 2D extents of the visible region.</summary>
    public VkExtent2D visibleRegion;

    /// <summary>refreshRate is a uint32_t that is the number of times the display is refreshed each second multiplied by 1000.</summary>
    public uint refreshRate;
}