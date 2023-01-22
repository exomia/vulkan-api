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
///     VkSurfaceFormatKHR - Structure describing a supported swapchain format-color space pair -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceFormatKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkSurfaceFormatKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkSurfaceFormatKHR
{
    /// <summary>format is a VkFormat that is compatible with the specified surface.</summary>
    public VkFormat format;

    /// <summary>colorSpace is a presentation VkColorSpaceKHR that is compatible with the surface.</summary>
    public VkColorSpaceKHR colorSpace;
}