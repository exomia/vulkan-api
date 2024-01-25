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
///     VkDisplayPlanePropertiesKHR - Structure describing display plane properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlanePropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayPlanePropertiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkDisplayPlanePropertiesKHR
{
    /// <summary>
    ///     currentDisplay is the handle of the display the plane is currently associated with. If the plane is not
    ///     currently attached to any displays, this will be VK_NULL_HANDLE.
    /// </summary>
    public VkDisplayKHR currentDisplay;

    /// <summary>
    ///     currentStackIndex is the current z-order of the plane. This will be between 0 and the value returned by
    ///     vkGetPhysicalDeviceDisplayPlanePropertiesKHR in pPropertyCount.
    /// </summary>
    public uint currentStackIndex;
}