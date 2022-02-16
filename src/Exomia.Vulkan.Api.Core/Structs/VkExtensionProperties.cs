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
///     VkExtensionProperties - Structure specifying an extension properties -
///     <a href="https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtensionProperties.html">https://www.khronos.org/registry/vulkan/specs/1.3-extensions/man/html/VkExtensionProperties.html</a>
/// </summary>
/// <remarks>
///     <list type="table">
///         <item>
///             <term>returnedonly</term><description>true</description>
///         </item>
///     </list>
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExtensionProperties
{
    /// <summary>
    ///     extensionName is an array of VK_MAX_EXTENSION_NAME_SIZEchar containing a null-terminated UTF-8 string which is
    ///     the name of the extension.
    /// </summary>
    public fixed byte extensionName[(int)VK_MAX_EXTENSION_NAME_SIZE];

    /// <summary>specVersion is the version of this extension. It is an integer, incremented with backward compatible changes.</summary>
    public VkVersion specVersion;
}