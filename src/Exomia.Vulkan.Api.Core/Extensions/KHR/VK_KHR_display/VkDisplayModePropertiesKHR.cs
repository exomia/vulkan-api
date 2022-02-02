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
///     VkDisplayModePropertiesKHR - Structure describing display mode properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayModePropertiesKHR.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkDisplayModePropertiesKHR.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct VkDisplayModePropertiesKHR
{
    /// <summary>
    ///     displayMode is a handle to the display mode described in this structure. This handle will be valid for the
    ///     lifetime of the Vulkan instance.
    /// </summary>
    public VkDisplayModeKHR displayMode;

    /// <summary>
    ///     parameters is a VkDisplayModeParametersKHR structure describing the display parameters associated with
    ///     displayMode.
    /// </summary>
    public VkDisplayModeParametersKHR parameters;
}